
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeature_SimWApi
 表名:vTabFeature_Sim(00050613)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvTabFeature_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabFeatureId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeature_Sim.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeature_Sim.TabFeatureId);
objvTabFeature_SimEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.TabFeatureId) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.TabFeatureId, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.TabFeatureId] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureName">表功能名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabFeatureName(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeature_Sim.TabFeatureName);
objvTabFeature_SimEN.TabFeatureName = strTabFeatureName; //表功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.TabFeatureName) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.TabFeatureName, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.TabFeatureName] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeature_Sim.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeature_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeature_Sim.TabId);
objvTabFeature_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.TabId) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.TabId, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.TabId] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetOrderNum(this clsvTabFeature_SimEN objvTabFeature_SimEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convTabFeature_Sim.OrderNum);
objvTabFeature_SimEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.OrderNum) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.OrderNum, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.OrderNum] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetInUse(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvTabFeature_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.InUse) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.InUse, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.InUse] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetUpdUser(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeature_Sim.UpdUser);
objvTabFeature_SimEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.UpdUser) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.UpdUser, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.UpdUser] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetUpdDate(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeature_Sim.UpdDate);
objvTabFeature_SimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.UpdDate) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.UpdDate, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.UpdDate] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetMemo(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeature_Sim.Memo);
objvTabFeature_SimEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.Memo) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.Memo, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.Memo] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFeatureId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeature_Sim.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeature_Sim.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeature_Sim.FeatureId);
objvTabFeature_SimEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.FeatureId) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.FeatureId, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.FeatureId] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameCs">Cs函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFuncNameCs(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFuncNameCs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncNameCs, convTabFeature_Sim.FuncNameCs);
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, convTabFeature_Sim.FuncNameCs);
objvTabFeature_SimEN.FuncNameCs = strFuncNameCs; //Cs函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.FuncNameCs) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.FuncNameCs, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.FuncNameCs] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strGetDdlDataFuncName4Ex">获取Ddl函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetGetDdlDataFuncName4Ex(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strGetDdlDataFuncName4Ex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetDdlDataFuncName4Ex, 100, convTabFeature_Sim.GetDdlDataFuncName4Ex);
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = strGetDdlDataFuncName4Ex; //获取Ddl函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.GetDdlDataFuncName4Ex) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.GetDdlDataFuncName4Ex, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.GetDdlDataFuncName4Ex] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetCmPrjId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convTabFeature_Sim.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convTabFeature_Sim.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convTabFeature_Sim.CmPrjId);
objvTabFeature_SimEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.CmPrjId) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.CmPrjId, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.CmPrjId] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncNameJs">Js函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFuncNameJs(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFuncNameJs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncNameJs, convTabFeature_Sim.FuncNameJs);
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, convTabFeature_Sim.FuncNameJs);
objvTabFeature_SimEN.FuncNameJs = strFuncNameJs; //Js函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.FuncNameJs) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.FuncNameJs, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.FuncNameJs] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForDiv">是否针对Div内控件</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetIsForDiv(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolIsForDiv, string strComparisonOp="")
	{
objvTabFeature_SimEN.IsForDiv = bolIsForDiv; //是否针对Div内控件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.IsForDiv) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.IsForDiv, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.IsForDiv] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForCSharp">是否ForCSharp</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetIsForCSharp(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolIsForCSharp, string strComparisonOp="")
	{
objvTabFeature_SimEN.IsForCSharp = bolIsForCSharp; //是否ForCSharp
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.IsForCSharp) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.IsForCSharp, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.IsForCSharp] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForTypeScript">是否ForTypeScript</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetIsForTypeScript(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolIsForTypeScript, string strComparisonOp="")
	{
objvTabFeature_SimEN.IsForTypeScript = bolIsForTypeScript; //是否ForTypeScript
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.IsForTypeScript) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.IsForTypeScript, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.IsForTypeScript] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExtendedClass">是否在扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetIsExtendedClass(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolIsExtendedClass, string strComparisonOp="")
	{
objvTabFeature_SimEN.IsExtendedClass = bolIsExtendedClass; //是否在扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.IsExtendedClass) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.IsExtendedClass, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.IsExtendedClass] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGC">是否需要生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetIsNeedGC(this clsvTabFeature_SimEN objvTabFeature_SimEN, bool bolIsNeedGC, string strComparisonOp="")
	{
objvTabFeature_SimEN.IsNeedGC = bolIsNeedGC; //是否需要生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.IsNeedGC) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.IsNeedGC, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.IsNeedGC] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strToolTipText">提示文字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetToolTipText(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strToolTipText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strToolTipText, 150, convTabFeature_Sim.ToolTipText);
objvTabFeature_SimEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeature_SimEN.dicFldComparisonOp.ContainsKey(convTabFeature_Sim.ToolTipText) == false)
{
objvTabFeature_SimEN.dicFldComparisonOp.Add(convTabFeature_Sim.ToolTipText, strComparisonOp);
}
else
{
objvTabFeature_SimEN.dicFldComparisonOp[convTabFeature_Sim.ToolTipText] = strComparisonOp;
}
}
return objvTabFeature_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFeature_SimEN objvTabFeature_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.TabFeatureId, objvTabFeature_SimCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.TabFeatureName) == true)
{
string strComparisonOpTabFeatureName = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.TabFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.TabFeatureName, objvTabFeature_SimCond.TabFeatureName, strComparisonOpTabFeatureName);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.TabId) == true)
{
string strComparisonOpTabId = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.TabId, objvTabFeature_SimCond.TabId, strComparisonOpTabId);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.OrderNum) == true)
{
string strComparisonOpOrderNum = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeature_Sim.OrderNum, objvTabFeature_SimCond.OrderNum, strComparisonOpOrderNum);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.InUse) == true)
{
if (objvTabFeature_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.InUse);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.UpdUser, objvTabFeature_SimCond.UpdUser, strComparisonOpUpdUser);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.UpdDate, objvTabFeature_SimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.Memo) == true)
{
string strComparisonOpMemo = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.Memo, objvTabFeature_SimCond.Memo, strComparisonOpMemo);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.FeatureId) == true)
{
string strComparisonOpFeatureId = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.FeatureId, objvTabFeature_SimCond.FeatureId, strComparisonOpFeatureId);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.FuncNameCs) == true)
{
string strComparisonOpFuncNameCs = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.FuncNameCs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.FuncNameCs, objvTabFeature_SimCond.FuncNameCs, strComparisonOpFuncNameCs);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.GetDdlDataFuncName4Ex) == true)
{
string strComparisonOpGetDdlDataFuncName4Ex = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.GetDdlDataFuncName4Ex];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.GetDdlDataFuncName4Ex, objvTabFeature_SimCond.GetDdlDataFuncName4Ex, strComparisonOpGetDdlDataFuncName4Ex);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.CmPrjId, objvTabFeature_SimCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.FuncNameJs) == true)
{
string strComparisonOpFuncNameJs = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.FuncNameJs];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.FuncNameJs, objvTabFeature_SimCond.FuncNameJs, strComparisonOpFuncNameJs);
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.IsForDiv) == true)
{
if (objvTabFeature_SimCond.IsForDiv == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.IsForDiv);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.IsForDiv);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.IsForCSharp) == true)
{
if (objvTabFeature_SimCond.IsForCSharp == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.IsForCSharp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.IsForCSharp);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.IsForTypeScript) == true)
{
if (objvTabFeature_SimCond.IsForTypeScript == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.IsForTypeScript);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.IsForTypeScript);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.IsExtendedClass) == true)
{
if (objvTabFeature_SimCond.IsExtendedClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.IsExtendedClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.IsExtendedClass);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.IsNeedGC) == true)
{
if (objvTabFeature_SimCond.IsNeedGC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeature_Sim.IsNeedGC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeature_Sim.IsNeedGC);
}
}
if (objvTabFeature_SimCond.IsUpdated(convTabFeature_Sim.ToolTipText) == true)
{
string strComparisonOpToolTipText = objvTabFeature_SimCond.dicFldComparisonOp[convTabFeature_Sim.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeature_Sim.ToolTipText, objvTabFeature_SimCond.ToolTipText, strComparisonOpToolTipText);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v表功能_Sim(vTabFeature_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeature_SimWApi
{
private static readonly string mstrApiControllerName = "vTabFeature_SimApi";

 public clsvTabFeature_SimWApi()
 {
 }

//该表下拉框功能不需要生成;

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeature_SimEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId == "") return null;
string strAction = "GetObjByTabFeatureId";
clsvTabFeature_SimEN objvTabFeature_SimEN;
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
objvTabFeature_SimEN = JsonConvert.DeserializeObject<clsvTabFeature_SimEN>(strJson);
return objvTabFeature_SimEN;
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
public static clsvTabFeature_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFeature_SimEN objvTabFeature_SimEN;
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
objvTabFeature_SimEN = JsonConvert.DeserializeObject<clsvTabFeature_SimEN>(strJson);
return objvTabFeature_SimEN;
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
public static clsvTabFeature_SimEN GetObjByTabFeatureIdCache(string strTabFeatureId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrvTabFeature_SimObjLst_Sel =
from objvTabFeature_SimEN in arrvTabFeature_SimObjLstCache
where objvTabFeature_SimEN.TabFeatureId == strTabFeatureId 
select objvTabFeature_SimEN;
if (arrvTabFeature_SimObjLst_Sel.Count() == 0)
{
   clsvTabFeature_SimEN obj = clsvTabFeature_SimWApi.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFeature_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
public static List<clsvTabFeature_SimEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureId)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
public static IEnumerable<clsvTabFeature_SimEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrvTabFeature_SimObjLst_Sel =
from objvTabFeature_SimEN in arrvTabFeature_SimObjLstCache
where arrTabFeatureId.Contains(objvTabFeature_SimEN.TabFeatureId)
select objvTabFeature_SimEN;
return arrvTabFeature_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeature_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
public static List<clsvTabFeature_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
public static List<clsvTabFeature_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
public static List<clsvTabFeature_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFeature_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeature_SimEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvTabFeature_SimENS">源对象</param>
 /// <param name = "objvTabFeature_SimENT">目标对象</param>
 public static void CopyTo(clsvTabFeature_SimEN objvTabFeature_SimENS, clsvTabFeature_SimEN objvTabFeature_SimENT)
{
try
{
objvTabFeature_SimENT.TabFeatureId = objvTabFeature_SimENS.TabFeatureId; //表功能Id
objvTabFeature_SimENT.TabFeatureName = objvTabFeature_SimENS.TabFeatureName; //表功能名
objvTabFeature_SimENT.TabId = objvTabFeature_SimENS.TabId; //表ID
objvTabFeature_SimENT.OrderNum = objvTabFeature_SimENS.OrderNum; //序号
objvTabFeature_SimENT.InUse = objvTabFeature_SimENS.InUse; //是否在用
objvTabFeature_SimENT.UpdUser = objvTabFeature_SimENS.UpdUser; //修改者
objvTabFeature_SimENT.UpdDate = objvTabFeature_SimENS.UpdDate; //修改日期
objvTabFeature_SimENT.Memo = objvTabFeature_SimENS.Memo; //说明
objvTabFeature_SimENT.FeatureId = objvTabFeature_SimENS.FeatureId; //功能Id
objvTabFeature_SimENT.FuncNameCs = objvTabFeature_SimENS.FuncNameCs; //Cs函数名
objvTabFeature_SimENT.GetDdlDataFuncName4Ex = objvTabFeature_SimENS.GetDdlDataFuncName4Ex; //获取Ddl函数名
objvTabFeature_SimENT.CmPrjId = objvTabFeature_SimENS.CmPrjId; //Cm工程Id
objvTabFeature_SimENT.FuncNameJs = objvTabFeature_SimENS.FuncNameJs; //Js函数名
objvTabFeature_SimENT.IsForDiv = objvTabFeature_SimENS.IsForDiv; //是否针对Div内控件
objvTabFeature_SimENT.IsForCSharp = objvTabFeature_SimENS.IsForCSharp; //是否ForCSharp
objvTabFeature_SimENT.IsForTypeScript = objvTabFeature_SimENS.IsForTypeScript; //是否ForTypeScript
objvTabFeature_SimENT.IsExtendedClass = objvTabFeature_SimENS.IsExtendedClass; //是否在扩展类
objvTabFeature_SimENT.IsNeedGC = objvTabFeature_SimENS.IsNeedGC; //是否需要生成代码
objvTabFeature_SimENT.ToolTipText = objvTabFeature_SimENS.ToolTipText; //提示文字
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
public static DataTable ToDataTable(List<clsvTabFeature_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFeature_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFeature_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFeature_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFeature_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFeature_SimEN._AttributeName)
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
public static void ReFreshThisCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvTabFeature_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvTabFeature_SimWApi.ReFreshThisCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvTabFeature_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvTabFeature_SimWApi.GetObjLstCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvTabFeature_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvTabFeature_SimEN._WhereFormat, strCmPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convTabFeature_Sim.CmPrjId, strCmPrjId);
}
var strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFeature_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstCacheFromObjLst(string strCmPrjId,List<clsvTabFeature_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvTabFeature_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvTabFeature_SimWApi.GetObjLstCacheFromObjLst)", strCmPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvTabFeature_SimObjLstCache = CacheHelper.Get<List<clsvTabFeature_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.CmPrjId == strCmPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvTabFeature_SimObjLstCache = CacheHelper.Get<List<clsvTabFeature_SimEN>>(strKey);
}
return arrvTabFeature_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFeature_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFeature_Sim.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.TabFeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeature_Sim.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.FuncNameCs, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.GetDdlDataFuncName4Ex, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.FuncNameJs, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeature_Sim.IsForDiv, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.IsForCSharp, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.IsForTypeScript, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.IsExtendedClass, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.IsNeedGC, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeature_Sim.ToolTipText, Type.GetType("System.String"));
foreach (clsvTabFeature_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFeature_Sim.TabFeatureId] = objInFor[convTabFeature_Sim.TabFeatureId];
objDR[convTabFeature_Sim.TabFeatureName] = objInFor[convTabFeature_Sim.TabFeatureName];
objDR[convTabFeature_Sim.TabId] = objInFor[convTabFeature_Sim.TabId];
objDR[convTabFeature_Sim.OrderNum] = objInFor[convTabFeature_Sim.OrderNum];
objDR[convTabFeature_Sim.InUse] = objInFor[convTabFeature_Sim.InUse];
objDR[convTabFeature_Sim.UpdUser] = objInFor[convTabFeature_Sim.UpdUser];
objDR[convTabFeature_Sim.UpdDate] = objInFor[convTabFeature_Sim.UpdDate];
objDR[convTabFeature_Sim.Memo] = objInFor[convTabFeature_Sim.Memo];
objDR[convTabFeature_Sim.FeatureId] = objInFor[convTabFeature_Sim.FeatureId];
objDR[convTabFeature_Sim.FuncNameCs] = objInFor[convTabFeature_Sim.FuncNameCs];
objDR[convTabFeature_Sim.GetDdlDataFuncName4Ex] = objInFor[convTabFeature_Sim.GetDdlDataFuncName4Ex];
objDR[convTabFeature_Sim.CmPrjId] = objInFor[convTabFeature_Sim.CmPrjId];
objDR[convTabFeature_Sim.FuncNameJs] = objInFor[convTabFeature_Sim.FuncNameJs];
objDR[convTabFeature_Sim.IsForDiv] = objInFor[convTabFeature_Sim.IsForDiv];
objDR[convTabFeature_Sim.IsForCSharp] = objInFor[convTabFeature_Sim.IsForCSharp];
objDR[convTabFeature_Sim.IsForTypeScript] = objInFor[convTabFeature_Sim.IsForTypeScript];
objDR[convTabFeature_Sim.IsExtendedClass] = objInFor[convTabFeature_Sim.IsExtendedClass];
objDR[convTabFeature_Sim.IsNeedGC] = objInFor[convTabFeature_Sim.IsNeedGC];
objDR[convTabFeature_Sim.ToolTipText] = objInFor[convTabFeature_Sim.ToolTipText];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}