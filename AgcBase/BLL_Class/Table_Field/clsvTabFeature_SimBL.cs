
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeature_SimBL
 表名:vTabFeature_Sim(00050613)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvTabFeature_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeature_SimEN GetObj(this K_TabFeatureId_vTabFeature_Sim myKey)
{
clsvTabFeature_SimEN objvTabFeature_SimEN = clsvTabFeature_SimBL.vTabFeature_SimDA.GetObjByTabFeatureId(myKey.Value);
return objvTabFeature_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabFeatureId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeature_Sim.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeature_Sim.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabFeatureName(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureName, 100, convTabFeature_Sim.TabFeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetTabId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convTabFeature_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convTabFeature_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convTabFeature_Sim.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetUpdUser(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTabFeature_Sim.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetUpdDate(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTabFeature_Sim.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetMemo(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTabFeature_Sim.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFeatureId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convTabFeature_Sim.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convTabFeature_Sim.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convTabFeature_Sim.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFuncNameCs(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFuncNameCs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncNameCs, convTabFeature_Sim.FuncNameCs);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameCs, 100, convTabFeature_Sim.FuncNameCs);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetGetDdlDataFuncName4Ex(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strGetDdlDataFuncName4Ex, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGetDdlDataFuncName4Ex, 100, convTabFeature_Sim.GetDdlDataFuncName4Ex);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetCmPrjId(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convTabFeature_Sim.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convTabFeature_Sim.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convTabFeature_Sim.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetFuncNameJs(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strFuncNameJs, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncNameJs, convTabFeature_Sim.FuncNameJs);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncNameJs, 100, convTabFeature_Sim.FuncNameJs);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeature_SimEN SetToolTipText(this clsvTabFeature_SimEN objvTabFeature_SimEN, string strToolTipText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strToolTipText, 150, convTabFeature_Sim.ToolTipText);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFeature_SimENS">源对象</param>
 /// <param name = "objvTabFeature_SimENT">目标对象</param>
 public static void CopyTo(this clsvTabFeature_SimEN objvTabFeature_SimENS, clsvTabFeature_SimEN objvTabFeature_SimENT)
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
 /// <param name = "objvTabFeature_SimENS">源对象</param>
 /// <returns>目标对象=>clsvTabFeature_SimEN:objvTabFeature_SimENT</returns>
 public static clsvTabFeature_SimEN CopyTo(this clsvTabFeature_SimEN objvTabFeature_SimENS)
{
try
{
 clsvTabFeature_SimEN objvTabFeature_SimENT = new clsvTabFeature_SimEN()
{
TabFeatureId = objvTabFeature_SimENS.TabFeatureId, //表功能Id
TabFeatureName = objvTabFeature_SimENS.TabFeatureName, //表功能名
TabId = objvTabFeature_SimENS.TabId, //表ID
OrderNum = objvTabFeature_SimENS.OrderNum, //序号
InUse = objvTabFeature_SimENS.InUse, //是否在用
UpdUser = objvTabFeature_SimENS.UpdUser, //修改者
UpdDate = objvTabFeature_SimENS.UpdDate, //修改日期
Memo = objvTabFeature_SimENS.Memo, //说明
FeatureId = objvTabFeature_SimENS.FeatureId, //功能Id
FuncNameCs = objvTabFeature_SimENS.FuncNameCs, //Cs函数名
GetDdlDataFuncName4Ex = objvTabFeature_SimENS.GetDdlDataFuncName4Ex, //获取Ddl函数名
CmPrjId = objvTabFeature_SimENS.CmPrjId, //Cm工程Id
FuncNameJs = objvTabFeature_SimENS.FuncNameJs, //Js函数名
IsForDiv = objvTabFeature_SimENS.IsForDiv, //是否针对Div内控件
IsForCSharp = objvTabFeature_SimENS.IsForCSharp, //是否ForCSharp
IsForTypeScript = objvTabFeature_SimENS.IsForTypeScript, //是否ForTypeScript
IsExtendedClass = objvTabFeature_SimENS.IsExtendedClass, //是否在扩展类
IsNeedGC = objvTabFeature_SimENS.IsNeedGC, //是否需要生成代码
ToolTipText = objvTabFeature_SimENS.ToolTipText, //提示文字
};
 return objvTabFeature_SimENT;
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
public static void CheckProperty4Condition(this clsvTabFeature_SimEN objvTabFeature_SimEN)
{
 clsvTabFeature_SimBL.vTabFeature_SimDA.CheckProperty4Condition(objvTabFeature_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFeature_Sim
{
public virtual bool UpdRelaTabDate(string strTabFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表功能_Sim(vTabFeature_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeature_SimBL
{
public static RelatedActions_vTabFeature_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFeature_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFeature_SimDA vTabFeature_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFeature_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFeature_SimBL()
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
if (string.IsNullOrEmpty(clsvTabFeature_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeature_SimEN._ConnectString);
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
public static DataTable GetDataTable_vTabFeature_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFeature_SimDA.GetDataTable_vTabFeature_Sim(strWhereCond);
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
objDT = vTabFeature_SimDA.GetDataTable(strWhereCond);
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
objDT = vTabFeature_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabFeature_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabFeature_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabFeature_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vTabFeature_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabFeature_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabFeature_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstByTabFeatureIdLst(List<string> arrTabFeatureIdLst)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabFeatureIdLst, true);
 string strWhereCond = string.Format("TabFeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFeature_SimEN> GetObjLstByTabFeatureIdLstCache(List<string> arrTabFeatureIdLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrvTabFeature_SimObjLst_Sel =
arrvTabFeature_SimObjLstCache
.Where(x => arrTabFeatureIdLst.Contains(x.TabFeatureId));
return arrvTabFeature_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLst(string strWhereCond)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
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
public static List<clsvTabFeature_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFeature_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFeature_SimEN> GetSubObjLstCache(clsvTabFeature_SimEN objvTabFeature_SimCond)
{
 string strCmPrjId = objvTabFeature_SimCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTabFeature_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTabFeature_SimEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeature_Sim._AttributeName)
{
if (objvTabFeature_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeature_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeature_SimCond[strFldName].ToString());
}
else
{
if (objvTabFeature_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeature_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeature_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeature_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeature_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeature_SimCond[strFldName]));
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
public static List<clsvTabFeature_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
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
public static List<clsvTabFeature_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
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
List<clsvTabFeature_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabFeature_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeature_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabFeature_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
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
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
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
public static List<clsvTabFeature_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabFeature_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
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
public static List<clsvTabFeature_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFeature_SimEN> arrObjLst = new List<clsvTabFeature_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeature_SimEN objvTabFeature_SimEN = new clsvTabFeature_SimEN();
try
{
objvTabFeature_SimEN.TabFeatureId = objRow[convTabFeature_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeature_SimEN.TabFeatureName = objRow[convTabFeature_Sim.TabFeatureName] == DBNull.Value ? null : objRow[convTabFeature_Sim.TabFeatureName].ToString().Trim(); //表功能名
objvTabFeature_SimEN.TabId = objRow[convTabFeature_Sim.TabId].ToString().Trim(); //表ID
objvTabFeature_SimEN.OrderNum = Int32.Parse(objRow[convTabFeature_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeature_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeature_SimEN.UpdUser = objRow[convTabFeature_Sim.UpdUser] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdUser].ToString().Trim(); //修改者
objvTabFeature_SimEN.UpdDate = objRow[convTabFeature_Sim.UpdDate] == DBNull.Value ? null : objRow[convTabFeature_Sim.UpdDate].ToString().Trim(); //修改日期
objvTabFeature_SimEN.Memo = objRow[convTabFeature_Sim.Memo] == DBNull.Value ? null : objRow[convTabFeature_Sim.Memo].ToString().Trim(); //说明
objvTabFeature_SimEN.FeatureId = objRow[convTabFeature_Sim.FeatureId].ToString().Trim(); //功能Id
objvTabFeature_SimEN.FuncNameCs = objRow[convTabFeature_Sim.FuncNameCs].ToString().Trim(); //Cs函数名
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex] == DBNull.Value ? null : objRow[convTabFeature_Sim.GetDdlDataFuncName4Ex].ToString().Trim(); //获取Ddl函数名
objvTabFeature_SimEN.CmPrjId = objRow[convTabFeature_Sim.CmPrjId].ToString().Trim(); //Cm工程Id
objvTabFeature_SimEN.FuncNameJs = objRow[convTabFeature_Sim.FuncNameJs].ToString().Trim(); //Js函数名
objvTabFeature_SimEN.IsForDiv = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForDiv].ToString().Trim()); //是否针对Div内控件
objvTabFeature_SimEN.IsForCSharp = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForCSharp].ToString().Trim()); //是否ForCSharp
objvTabFeature_SimEN.IsForTypeScript = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsForTypeScript].ToString().Trim()); //是否ForTypeScript
objvTabFeature_SimEN.IsExtendedClass = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsExtendedClass].ToString().Trim()); //是否在扩展类
objvTabFeature_SimEN.IsNeedGC = clsEntityBase2.TransNullToBool_S(objRow[convTabFeature_Sim.IsNeedGC].ToString().Trim()); //是否需要生成代码
objvTabFeature_SimEN.ToolTipText = objRow[convTabFeature_Sim.ToolTipText] == DBNull.Value ? null : objRow[convTabFeature_Sim.ToolTipText].ToString().Trim(); //提示文字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeature_SimEN.TabFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeature_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFeature_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFeature_Sim(ref clsvTabFeature_SimEN objvTabFeature_SimEN)
{
bool bolResult = vTabFeature_SimDA.GetvTabFeature_Sim(ref objvTabFeature_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeature_SimEN GetObjByTabFeatureId(string strTabFeatureId)
{
if (strTabFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTabFeature_SimEN objvTabFeature_SimEN = vTabFeature_SimDA.GetObjByTabFeatureId(strTabFeatureId);
return objvTabFeature_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFeature_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFeature_SimEN objvTabFeature_SimEN = vTabFeature_SimDA.GetFirstObj(strWhereCond);
 return objvTabFeature_SimEN;
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
public static clsvTabFeature_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFeature_SimEN objvTabFeature_SimEN = vTabFeature_SimDA.GetObjByDataRow(objRow);
 return objvTabFeature_SimEN;
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
public static clsvTabFeature_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFeature_SimEN objvTabFeature_SimEN = vTabFeature_SimDA.GetObjByDataRow(objRow);
 return objvTabFeature_SimEN;
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
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "lstvTabFeature_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeature_SimEN GetObjByTabFeatureIdFromList(string strTabFeatureId, List<clsvTabFeature_SimEN> lstvTabFeature_SimObjLst)
{
foreach (clsvTabFeature_SimEN objvTabFeature_SimEN in lstvTabFeature_SimObjLst)
{
if (objvTabFeature_SimEN.TabFeatureId == strTabFeatureId)
{
return objvTabFeature_SimEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabFeatureId;
 try
 {
 strTabFeatureId = new clsvTabFeature_SimDA().GetFirstID(strWhereCond);
 return strTabFeatureId;
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
 arrList = vTabFeature_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vTabFeature_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabFeatureId)
{
if (string.IsNullOrEmpty(strTabFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTabFeature_SimDA.IsExist(strTabFeatureId);
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
 bolIsExist = clsvTabFeature_SimDA.IsExistTable();
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
 bolIsExist = vTabFeature_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvTabFeature_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFeature_SimEN objvTabFeature_SimEN)
{
try
{
objvTabFeature_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFeature_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFeature_Sim.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.TabFeatureId = objvTabFeature_SimEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convTabFeature_Sim.TabFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.TabFeatureName = objvTabFeature_SimEN.TabFeatureName == "[null]" ? null :  objvTabFeature_SimEN.TabFeatureName; //表功能名
}
if (arrFldSet.Contains(convTabFeature_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.TabId = objvTabFeature_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convTabFeature_Sim.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.OrderNum = objvTabFeature_SimEN.OrderNum; //序号
}
if (arrFldSet.Contains(convTabFeature_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.InUse = objvTabFeature_SimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convTabFeature_Sim.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.UpdUser = objvTabFeature_SimEN.UpdUser == "[null]" ? null :  objvTabFeature_SimEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convTabFeature_Sim.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.UpdDate = objvTabFeature_SimEN.UpdDate == "[null]" ? null :  objvTabFeature_SimEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTabFeature_Sim.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.Memo = objvTabFeature_SimEN.Memo == "[null]" ? null :  objvTabFeature_SimEN.Memo; //说明
}
if (arrFldSet.Contains(convTabFeature_Sim.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.FeatureId = objvTabFeature_SimEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convTabFeature_Sim.FuncNameCs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.FuncNameCs = objvTabFeature_SimEN.FuncNameCs; //Cs函数名
}
if (arrFldSet.Contains(convTabFeature_Sim.GetDdlDataFuncName4Ex, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.GetDdlDataFuncName4Ex = objvTabFeature_SimEN.GetDdlDataFuncName4Ex == "[null]" ? null :  objvTabFeature_SimEN.GetDdlDataFuncName4Ex; //获取Ddl函数名
}
if (arrFldSet.Contains(convTabFeature_Sim.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.CmPrjId = objvTabFeature_SimEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convTabFeature_Sim.FuncNameJs, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.FuncNameJs = objvTabFeature_SimEN.FuncNameJs; //Js函数名
}
if (arrFldSet.Contains(convTabFeature_Sim.IsForDiv, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.IsForDiv = objvTabFeature_SimEN.IsForDiv; //是否针对Div内控件
}
if (arrFldSet.Contains(convTabFeature_Sim.IsForCSharp, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.IsForCSharp = objvTabFeature_SimEN.IsForCSharp; //是否ForCSharp
}
if (arrFldSet.Contains(convTabFeature_Sim.IsForTypeScript, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.IsForTypeScript = objvTabFeature_SimEN.IsForTypeScript; //是否ForTypeScript
}
if (arrFldSet.Contains(convTabFeature_Sim.IsExtendedClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.IsExtendedClass = objvTabFeature_SimEN.IsExtendedClass; //是否在扩展类
}
if (arrFldSet.Contains(convTabFeature_Sim.IsNeedGC, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.IsNeedGC = objvTabFeature_SimEN.IsNeedGC; //是否需要生成代码
}
if (arrFldSet.Contains(convTabFeature_Sim.ToolTipText, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeature_SimEN.ToolTipText = objvTabFeature_SimEN.ToolTipText == "[null]" ? null :  objvTabFeature_SimEN.ToolTipText; //提示文字
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
 /// <param name = "objvTabFeature_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFeature_SimEN objvTabFeature_SimEN)
{
try
{
if (objvTabFeature_SimEN.TabFeatureName == "[null]") objvTabFeature_SimEN.TabFeatureName = null; //表功能名
if (objvTabFeature_SimEN.UpdUser == "[null]") objvTabFeature_SimEN.UpdUser = null; //修改者
if (objvTabFeature_SimEN.UpdDate == "[null]") objvTabFeature_SimEN.UpdDate = null; //修改日期
if (objvTabFeature_SimEN.Memo == "[null]") objvTabFeature_SimEN.Memo = null; //说明
if (objvTabFeature_SimEN.GetDdlDataFuncName4Ex == "[null]") objvTabFeature_SimEN.GetDdlDataFuncName4Ex = null; //获取Ddl函数名
if (objvTabFeature_SimEN.ToolTipText == "[null]") objvTabFeature_SimEN.ToolTipText = null; //提示文字
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
public static void CheckProperty4Condition(clsvTabFeature_SimEN objvTabFeature_SimEN)
{
 vTabFeature_SimDA.CheckProperty4Condition(objvTabFeature_SimEN);
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
if (clsTabFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureBL没有刷新缓存机制(clsTabFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabFeatureId");
//if (arrvTabFeature_SimObjLstCache == null)
//{
//arrvTabFeature_SimObjLstCache = vTabFeature_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabFeatureId">所给的关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeature_SimEN GetObjByTabFeatureIdCache(string strTabFeatureId, string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrvTabFeature_SimObjLst_Sel =
arrvTabFeature_SimObjLstCache
.Where(x=> x.TabFeatureId == strTabFeatureId 
);
if (arrvTabFeature_SimObjLst_Sel.Count() == 0)
{
   clsvTabFeature_SimEN obj = clsvTabFeature_SimBL.GetObjByTabFeatureId(strTabFeatureId);
   if (obj != null)
 {
if (obj.CmPrjId == strCmPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabFeatureId, strCmPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTabFeature_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeature_SimEN> GetAllvTabFeature_SimObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = GetObjLstCache(strCmPrjId); 
return arrvTabFeature_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeature_SimEN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsvTabFeature_SimEN> arrvTabFeature_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTabFeature_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvTabFeature_SimEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsvTabFeature_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabFeature_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFeature_SimEN._RefreshTimeLst[clsvTabFeature_SimEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabFeatureId, string strCmPrjId)
{
if (strInFldName != convTabFeature_Sim.TabFeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFeature_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFeature_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvTabFeature_Sim = clsvTabFeature_SimBL.GetObjByTabFeatureIdCache(strTabFeatureId, strCmPrjId);
if (objvTabFeature_Sim == null) return "";
return objvTabFeature_Sim[strOutFldName].ToString();
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
int intRecCount = clsvTabFeature_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabFeature_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFeature_SimDA.GetRecCount();
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
int intRecCount = clsvTabFeature_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFeature_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFeature_SimEN objvTabFeature_SimCond)
{
 string strCmPrjId = objvTabFeature_SimCond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTabFeature_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTabFeature_SimEN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvTabFeature_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeature_Sim._AttributeName)
{
if (objvTabFeature_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeature_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeature_SimCond[strFldName].ToString());
}
else
{
if (objvTabFeature_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeature_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeature_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeature_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeature_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeature_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeature_SimCond[strFldName]));
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
 List<string> arrList = clsvTabFeature_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabFeature_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabFeature_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}