
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcBL
 表名:vFuncModule_Agc(00050125)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvFuncModule_AgcBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModule_AgcEN GetObj(this K_FuncModuleAgcId_vFuncModule_Agc myKey)
{
clsvFuncModule_AgcEN objvFuncModule_AgcEN = clsvFuncModule_AgcBL.vFuncModule_AgcDA.GetObjByFuncModuleAgcId(myKey.Value);
return objvFuncModule_AgcEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleAgcId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convFuncModule_Agc.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convFuncModule_Agc.FuncModuleAgcId);
}
objvFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.FuncModuleAgcId) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetTabNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int? intTabNum, string strComparisonOp="")
	{
objvFuncModule_AgcEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.TabNum) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.TabNum, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.TabNum] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetViewNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int? intViewNum, string strComparisonOp="")
	{
objvFuncModule_AgcEN.ViewNum = intViewNum; //界面数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.ViewNum) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.ViewNum, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.ViewNum] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetObjNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int? intObjNum, string strComparisonOp="")
	{
objvFuncModule_AgcEN.ObjNum = intObjNum; //ObjNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.ObjNum) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.ObjNum, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.ObjNum] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjViewNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int? intPrjViewNum, string strComparisonOp="")
	{
objvFuncModule_AgcEN.PrjViewNum = intPrjViewNum; //PrjViewNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.PrjViewNum) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.PrjViewNum, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.PrjViewNum] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFuncModule_Agc.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFuncModule_Agc.FuncModuleName);
}
objvFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.FuncModuleName) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleEnName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convFuncModule_Agc.FuncModuleEnName);
}
objvFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.FuncModuleEnName) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFuncModule_Agc.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncModule_Agc.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncModule_Agc.PrjId);
}
objvFuncModule_AgcEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.PrjId) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.PrjId, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.PrjId] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFuncModule_Agc.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convFuncModule_Agc.PrjName);
}
objvFuncModule_AgcEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.PrjName) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.PrjName, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.PrjName] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetOrderNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFuncModule_Agc.OrderNum);
objvFuncModule_AgcEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.OrderNum) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUseStateId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convFuncModule_Agc.UseStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convFuncModule_Agc.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convFuncModule_Agc.UseStateId);
}
objvFuncModule_AgcEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.UseStateId) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUseStateName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convFuncModule_Agc.UseStateName);
}
objvFuncModule_AgcEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.UseStateName) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.UseStateName, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.UseStateName] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUpdDate(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncModule_Agc.UpdDate);
}
objvFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.UpdDate) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetMemo(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncModule_Agc.Memo);
}
objvFuncModule_AgcEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.Memo) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUpdUser(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncModule_Agc.UpdUser);
}
objvFuncModule_AgcEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(convFuncModule_Agc.UpdUser) == false)
{
objvFuncModule_AgcEN.dicFldComparisonOp.Add(convFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objvFuncModule_AgcEN.dicFldComparisonOp[convFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objvFuncModule_AgcEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <param name = "objvFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(this clsvFuncModule_AgcEN objvFuncModule_AgcENS, clsvFuncModule_AgcEN objvFuncModule_AgcENT)
{
try
{
objvFuncModule_AgcENT.FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvFuncModule_AgcENT.TabNum = objvFuncModule_AgcENS.TabNum; //表数
objvFuncModule_AgcENT.ViewNum = objvFuncModule_AgcENS.ViewNum; //界面数
objvFuncModule_AgcENT.ObjNum = objvFuncModule_AgcENS.ObjNum; //ObjNum
objvFuncModule_AgcENT.PrjViewNum = objvFuncModule_AgcENS.PrjViewNum; //PrjViewNum
objvFuncModule_AgcENT.FuncModuleName = objvFuncModule_AgcENS.FuncModuleName; //功能模块名称
objvFuncModule_AgcENT.FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objvFuncModule_AgcENT.PrjId = objvFuncModule_AgcENS.PrjId; //工程Id
objvFuncModule_AgcENT.PrjName = objvFuncModule_AgcENS.PrjName; //工程名称
objvFuncModule_AgcENT.OrderNum = objvFuncModule_AgcENS.OrderNum; //序号
objvFuncModule_AgcENT.UseStateId = objvFuncModule_AgcENS.UseStateId; //使用状态Id
objvFuncModule_AgcENT.UseStateName = objvFuncModule_AgcENS.UseStateName; //使用状态名称
objvFuncModule_AgcENT.UpdDate = objvFuncModule_AgcENS.UpdDate; //修改日期
objvFuncModule_AgcENT.Memo = objvFuncModule_AgcENS.Memo; //说明
objvFuncModule_AgcENT.UpdUser = objvFuncModule_AgcENS.UpdUser; //修改者
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
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <returns>目标对象=>clsvFuncModule_AgcEN:objvFuncModule_AgcENT</returns>
 public static clsvFuncModule_AgcEN CopyTo(this clsvFuncModule_AgcEN objvFuncModule_AgcENS)
{
try
{
 clsvFuncModule_AgcEN objvFuncModule_AgcENT = new clsvFuncModule_AgcEN()
{
FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId, //功能模块Id
TabNum = objvFuncModule_AgcENS.TabNum, //表数
ViewNum = objvFuncModule_AgcENS.ViewNum, //界面数
ObjNum = objvFuncModule_AgcENS.ObjNum, //ObjNum
PrjViewNum = objvFuncModule_AgcENS.PrjViewNum, //PrjViewNum
FuncModuleName = objvFuncModule_AgcENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName, //功能模块英文名称
PrjId = objvFuncModule_AgcENS.PrjId, //工程Id
PrjName = objvFuncModule_AgcENS.PrjName, //工程名称
OrderNum = objvFuncModule_AgcENS.OrderNum, //序号
UseStateId = objvFuncModule_AgcENS.UseStateId, //使用状态Id
UseStateName = objvFuncModule_AgcENS.UseStateName, //使用状态名称
UpdDate = objvFuncModule_AgcENS.UpdDate, //修改日期
Memo = objvFuncModule_AgcENS.Memo, //说明
UpdUser = objvFuncModule_AgcENS.UpdUser, //修改者
};
 return objvFuncModule_AgcENT;
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
public static void CheckProperty4Condition(this clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
 clsvFuncModule_AgcBL.vFuncModule_AgcDA.CheckProperty4Condition(objvFuncModule_AgcEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncModule_AgcEN objvFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.FuncModuleAgcId, objvFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.TabNum) == true)
{
string strComparisonOpTabNum = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule_Agc.TabNum, objvFuncModule_AgcCond.TabNum, strComparisonOpTabNum);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.ViewNum) == true)
{
string strComparisonOpViewNum = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.ViewNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule_Agc.ViewNum, objvFuncModule_AgcCond.ViewNum, strComparisonOpViewNum);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.ObjNum) == true)
{
string strComparisonOpObjNum = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.ObjNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule_Agc.ObjNum, objvFuncModule_AgcCond.ObjNum, strComparisonOpObjNum);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.PrjViewNum) == true)
{
string strComparisonOpPrjViewNum = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.PrjViewNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule_Agc.PrjViewNum, objvFuncModule_AgcCond.PrjViewNum, strComparisonOpPrjViewNum);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.FuncModuleName, objvFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.FuncModuleEnName, objvFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.PrjId, objvFuncModule_AgcCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.PrjName) == true)
{
string strComparisonOpPrjName = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.PrjName, objvFuncModule_AgcCond.PrjName, strComparisonOpPrjName);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModule_Agc.OrderNum, objvFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.UseStateId, objvFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.UseStateName) == true)
{
string strComparisonOpUseStateName = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.UseStateName, objvFuncModule_AgcCond.UseStateName, strComparisonOpUseStateName);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.UpdDate, objvFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.Memo, objvFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
if (objvFuncModule_AgcCond.IsUpdated(convFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncModule_AgcCond.dicFldComparisonOp[convFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModule_Agc.UpdUser, objvFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncModule_Agc
{
public virtual bool UpdRelaTabDate(string strFuncModuleAgcId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能模块_Agc(vFuncModule_Agc)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncModule_AgcBL
{
public static RelatedActions_vFuncModule_Agc relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncModule_AgcDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncModule_AgcDA vFuncModule_AgcDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncModule_AgcDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncModule_AgcBL()
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
if (string.IsNullOrEmpty(clsvFuncModule_AgcEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncModule_AgcEN._ConnectString);
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
public static DataTable GetDataTable_vFuncModule_Agc(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncModule_AgcDA.GetDataTable_vFuncModule_Agc(strWhereCond);
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
objDT = vFuncModule_AgcDA.GetDataTable(strWhereCond);
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
objDT = vFuncModule_AgcDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncModule_AgcDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncModule_AgcDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncModule_AgcDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncModule_AgcDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncModule_AgcDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcIdLst)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleAgcIdLst, true);
 string strWhereCond = string.Format("FuncModuleAgcId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLst_Sel =
arrvFuncModule_AgcObjLstCache
.Where(x => arrFuncModuleAgcIdLst.Contains(x.FuncModuleAgcId));
return arrvFuncModule_AgcObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
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
public static List<clsvFuncModule_AgcEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncModule_AgcEN> GetSubObjLstCache(clsvFuncModule_AgcEN objvFuncModule_AgcCond)
{
 string strPrjId = objvFuncModule_AgcCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFuncModule_AgcBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFuncModule_AgcEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModule_Agc._AttributeName)
{
if (objvFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objvFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModule_AgcCond[strFldName]));
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
public static List<clsvFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
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
public static List<clsvFuncModule_AgcEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
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
List<clsvFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncModule_AgcEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
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
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
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
public static List<clsvFuncModule_AgcEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
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
public static List<clsvFuncModule_AgcEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModule_AgcEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncModule_Agc(ref clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
bool bolResult = vFuncModule_AgcDA.GetvFuncModule_Agc(ref objvFuncModule_AgcEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleAgcId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleAgcId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFuncModule_AgcEN objvFuncModule_AgcEN = vFuncModule_AgcDA.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
return objvFuncModule_AgcEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncModule_AgcEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncModule_AgcEN objvFuncModule_AgcEN = vFuncModule_AgcDA.GetFirstObj(strWhereCond);
 return objvFuncModule_AgcEN;
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
public static clsvFuncModule_AgcEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncModule_AgcEN objvFuncModule_AgcEN = vFuncModule_AgcDA.GetObjByDataRow(objRow);
 return objvFuncModule_AgcEN;
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
public static clsvFuncModule_AgcEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncModule_AgcEN objvFuncModule_AgcEN = vFuncModule_AgcDA.GetObjByDataRow(objRow);
 return objvFuncModule_AgcEN;
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
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "lstvFuncModule_AgcObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModule_AgcEN GetObjByFuncModuleAgcIdFromList(string strFuncModuleAgcId, List<clsvFuncModule_AgcEN> lstvFuncModule_AgcObjLst)
{
foreach (clsvFuncModule_AgcEN objvFuncModule_AgcEN in lstvFuncModule_AgcObjLst)
{
if (objvFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId)
{
return objvFuncModule_AgcEN;
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
 string strFuncModuleAgcId;
 try
 {
 strFuncModuleAgcId = new clsvFuncModule_AgcDA().GetFirstID(strWhereCond);
 return strFuncModuleAgcId;
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
 arrList = vFuncModule_AgcDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncModule_AgcDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleAgcId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFuncModule_AgcDA.IsExist(strFuncModuleAgcId);
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
 bolIsExist = clsvFuncModule_AgcDA.IsExistTable();
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
 bolIsExist = vFuncModule_AgcDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <param name = "objvFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsvFuncModule_AgcEN objvFuncModule_AgcENS, clsvFuncModule_AgcEN objvFuncModule_AgcENT)
{
try
{
objvFuncModule_AgcENT.FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvFuncModule_AgcENT.TabNum = objvFuncModule_AgcENS.TabNum; //表数
objvFuncModule_AgcENT.ViewNum = objvFuncModule_AgcENS.ViewNum; //界面数
objvFuncModule_AgcENT.ObjNum = objvFuncModule_AgcENS.ObjNum; //ObjNum
objvFuncModule_AgcENT.PrjViewNum = objvFuncModule_AgcENS.PrjViewNum; //PrjViewNum
objvFuncModule_AgcENT.FuncModuleName = objvFuncModule_AgcENS.FuncModuleName; //功能模块名称
objvFuncModule_AgcENT.FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objvFuncModule_AgcENT.PrjId = objvFuncModule_AgcENS.PrjId; //工程Id
objvFuncModule_AgcENT.PrjName = objvFuncModule_AgcENS.PrjName; //工程名称
objvFuncModule_AgcENT.OrderNum = objvFuncModule_AgcENS.OrderNum; //序号
objvFuncModule_AgcENT.UseStateId = objvFuncModule_AgcENS.UseStateId; //使用状态Id
objvFuncModule_AgcENT.UseStateName = objvFuncModule_AgcENS.UseStateName; //使用状态名称
objvFuncModule_AgcENT.UpdDate = objvFuncModule_AgcENS.UpdDate; //修改日期
objvFuncModule_AgcENT.Memo = objvFuncModule_AgcENS.Memo; //说明
objvFuncModule_AgcENT.UpdUser = objvFuncModule_AgcENS.UpdUser; //修改者
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
 /// <param name = "objvFuncModule_AgcEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
try
{
objvFuncModule_AgcEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncModule_AgcEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncModule_Agc.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.FuncModuleAgcId = objvFuncModule_AgcEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convFuncModule_Agc.TabNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.TabNum = objvFuncModule_AgcEN.TabNum; //表数
}
if (arrFldSet.Contains(convFuncModule_Agc.ViewNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.ViewNum = objvFuncModule_AgcEN.ViewNum; //界面数
}
if (arrFldSet.Contains(convFuncModule_Agc.ObjNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.ObjNum = objvFuncModule_AgcEN.ObjNum; //ObjNum
}
if (arrFldSet.Contains(convFuncModule_Agc.PrjViewNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.PrjViewNum = objvFuncModule_AgcEN.PrjViewNum; //PrjViewNum
}
if (arrFldSet.Contains(convFuncModule_Agc.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.FuncModuleName = objvFuncModule_AgcEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convFuncModule_Agc.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.FuncModuleEnName = objvFuncModule_AgcEN.FuncModuleEnName == "[null]" ? null :  objvFuncModule_AgcEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convFuncModule_Agc.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.PrjId = objvFuncModule_AgcEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFuncModule_Agc.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.PrjName = objvFuncModule_AgcEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convFuncModule_Agc.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.OrderNum = objvFuncModule_AgcEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFuncModule_Agc.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.UseStateId = objvFuncModule_AgcEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(convFuncModule_Agc.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.UseStateName = objvFuncModule_AgcEN.UseStateName == "[null]" ? null :  objvFuncModule_AgcEN.UseStateName; //使用状态名称
}
if (arrFldSet.Contains(convFuncModule_Agc.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.UpdDate = objvFuncModule_AgcEN.UpdDate == "[null]" ? null :  objvFuncModule_AgcEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFuncModule_Agc.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.Memo = objvFuncModule_AgcEN.Memo == "[null]" ? null :  objvFuncModule_AgcEN.Memo; //说明
}
if (arrFldSet.Contains(convFuncModule_Agc.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModule_AgcEN.UpdUser = objvFuncModule_AgcEN.UpdUser == "[null]" ? null :  objvFuncModule_AgcEN.UpdUser; //修改者
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
 /// <param name = "objvFuncModule_AgcEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
try
{
if (objvFuncModule_AgcEN.FuncModuleEnName == "[null]") objvFuncModule_AgcEN.FuncModuleEnName = null; //功能模块英文名称
if (objvFuncModule_AgcEN.UseStateName == "[null]") objvFuncModule_AgcEN.UseStateName = null; //使用状态名称
if (objvFuncModule_AgcEN.UpdDate == "[null]") objvFuncModule_AgcEN.UpdDate = null; //修改日期
if (objvFuncModule_AgcEN.Memo == "[null]") objvFuncModule_AgcEN.Memo = null; //说明
if (objvFuncModule_AgcEN.UpdUser == "[null]") objvFuncModule_AgcEN.UpdUser = null; //修改者
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
public static void CheckProperty4Condition(clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
 vFuncModule_AgcDA.CheckProperty4Condition(objvFuncModule_AgcEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleAgcId");
//if (arrvFuncModule_AgcObjLstCache == null)
//{
//arrvFuncModule_AgcObjLstCache = vFuncModule_AgcDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModule_AgcEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLst_Sel =
arrvFuncModule_AgcObjLstCache
.Where(x=> x.FuncModuleAgcId == strFuncModuleAgcId 
);
if (arrvFuncModule_AgcObjLst_Sel.Count() == 0)
{
   clsvFuncModule_AgcEN obj = clsvFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFuncModuleAgcId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFuncModule_AgcObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetAllvFuncModule_AgcObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId); 
return arrvFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFuncModule_AgcObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFuncModule_AgcEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFuncModule_AgcEN._RefreshTimeLst.Count == 0) return "";
return clsvFuncModule_AgcEN._RefreshTimeLst[clsvFuncModule_AgcEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleAgcId, string strPrjId)
{
if (strInFldName != convFuncModule_Agc.FuncModuleAgcId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncModule_Agc._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncModule_Agc._AttributeName));
throw new Exception(strMsg);
}
var objvFuncModule_Agc = clsvFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId, strPrjId);
if (objvFuncModule_Agc == null) return "";
return objvFuncModule_Agc[strOutFldName].ToString();
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
int intRecCount = clsvFuncModule_AgcDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncModule_AgcDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncModule_AgcDA.GetRecCount();
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
int intRecCount = clsvFuncModule_AgcDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncModule_AgcCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncModule_AgcEN objvFuncModule_AgcCond)
{
 string strPrjId = objvFuncModule_AgcCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFuncModule_AgcBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFuncModule_AgcEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModule_Agc._AttributeName)
{
if (objvFuncModule_AgcCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModule_AgcCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModule_AgcCond[strFldName].ToString());
}
else
{
if (objvFuncModule_AgcCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModule_AgcCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModule_AgcCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModule_AgcCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModule_AgcCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModule_AgcCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModule_AgcCond[strFldName]));
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
 List<string> arrList = clsvFuncModule_AgcDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncModule_AgcDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncModule_AgcDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}