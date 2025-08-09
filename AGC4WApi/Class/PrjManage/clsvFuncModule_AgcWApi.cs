
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcWApi
 表名:vFuncModule_Agc(00050125)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvFuncModule_AgcWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleAgcId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convFuncModule_Agc.FuncModuleAgcId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabNum">表数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetTabNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int intTabNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewNum">界面数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetViewNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int intViewNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intObjNum">ObjNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetObjNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int intObjNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intPrjViewNum">PrjViewNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjViewNum(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, int intPrjViewNum, string strComparisonOp="")
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convFuncModule_Agc.FuncModuleName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetFuncModuleEnName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convFuncModule_Agc.FuncModuleEnName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFuncModule_Agc.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncModule_Agc.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncModule_Agc.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetPrjName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFuncModule_Agc.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convFuncModule_Agc.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUseStateId(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, convFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, convFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convFuncModule_Agc.UseStateId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUseStateName(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convFuncModule_Agc.UseStateName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUpdDate(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncModule_Agc.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetMemo(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncModule_Agc.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModule_AgcEN SetUpdUser(this clsvFuncModule_AgcEN objvFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncModule_Agc.UpdUser);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v功能模块_Agc(vFuncModule_Agc)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFuncModule_AgcWApi
{
private static readonly string mstrApiControllerName = "vFuncModule_AgcApi";

 public clsvFuncModule_AgcWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId == "") return null;
string strAction = "GetObjByFuncModuleAgcId";
clsvFuncModule_AgcEN objvFuncModule_AgcEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFuncModule_AgcEN = JsonConvert.DeserializeObject<clsvFuncModule_AgcEN>(strJson);
return objvFuncModule_AgcEN;
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
public static clsvFuncModule_AgcEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFuncModule_AgcEN objvFuncModule_AgcEN;
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
objvFuncModule_AgcEN = JsonConvert.DeserializeObject<clsvFuncModule_AgcEN>(strJson);
return objvFuncModule_AgcEN;
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
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModule_AgcEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId,string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLst_Sel =
from objvFuncModule_AgcEN in arrvFuncModule_AgcObjLstCache
where objvFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId 
select objvFuncModule_AgcEN;
if (arrvFuncModule_AgcObjLst_Sel.Count() == 0)
{
   clsvFuncModule_AgcEN obj = clsvFuncModule_AgcWApi.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFuncModule_AgcObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
 /// <param name = "arrFuncModuleAgcId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcId)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
string strAction = "GetObjLstByFuncModuleAgcIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleAgcId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
 /// <param name = "arrFuncModuleAgcId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLst_Sel =
from objvFuncModule_AgcEN in arrvFuncModule_AgcObjLstCache
where arrFuncModuleAgcId.Contains(objvFuncModule_AgcEN.FuncModuleAgcId)
select objvFuncModule_AgcEN;
return arrvFuncModule_AgcObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
public static List<clsvFuncModule_AgcEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
public static List<clsvFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
public static List<clsvFuncModule_AgcEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncModule_AgcEN>>(strJson);
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
public static bool IsExist(string strFuncModuleAgcId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncModuleAgcId"] = strFuncModuleAgcId
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
public static DataTable ToDataTable(List<clsvFuncModule_AgcEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFuncModule_AgcEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFuncModule_AgcEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFuncModule_AgcEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFuncModule_AgcEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFuncModule_AgcEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFuncModule_AgcWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFuncModule_AgcWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
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
public static List<clsvFuncModule_AgcEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFuncModule_AgcWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFuncModule_AgcWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFuncModule_AgcEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFuncModule_AgcEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFuncModule_Agc.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModule_AgcEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvFuncModule_AgcEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFuncModule_AgcWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFuncModule_AgcWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsvFuncModule_AgcEN> arrvFuncModule_AgcObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFuncModule_AgcObjLstCache = CacheHelper.Get<List<clsvFuncModule_AgcEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFuncModule_AgcObjLstCache = CacheHelper.Get<List<clsvFuncModule_AgcEN>>(strKey);
}
return arrvFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFuncModule_AgcEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFuncModule_Agc.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.TabNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule_Agc.ViewNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule_Agc.ObjNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule_Agc.PrjViewNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule_Agc.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFuncModule_Agc.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFuncModule_Agc.UpdUser, Type.GetType("System.String"));
foreach (clsvFuncModule_AgcEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFuncModule_Agc.FuncModuleAgcId] = objInFor[convFuncModule_Agc.FuncModuleAgcId];
objDR[convFuncModule_Agc.TabNum] = objInFor[convFuncModule_Agc.TabNum];
objDR[convFuncModule_Agc.ViewNum] = objInFor[convFuncModule_Agc.ViewNum];
objDR[convFuncModule_Agc.ObjNum] = objInFor[convFuncModule_Agc.ObjNum];
objDR[convFuncModule_Agc.PrjViewNum] = objInFor[convFuncModule_Agc.PrjViewNum];
objDR[convFuncModule_Agc.FuncModuleName] = objInFor[convFuncModule_Agc.FuncModuleName];
objDR[convFuncModule_Agc.FuncModuleEnName] = objInFor[convFuncModule_Agc.FuncModuleEnName];
objDR[convFuncModule_Agc.PrjId] = objInFor[convFuncModule_Agc.PrjId];
objDR[convFuncModule_Agc.PrjName] = objInFor[convFuncModule_Agc.PrjName];
objDR[convFuncModule_Agc.OrderNum] = objInFor[convFuncModule_Agc.OrderNum];
objDR[convFuncModule_Agc.UseStateId] = objInFor[convFuncModule_Agc.UseStateId];
objDR[convFuncModule_Agc.UseStateName] = objInFor[convFuncModule_Agc.UseStateName];
objDR[convFuncModule_Agc.UpdDate] = objInFor[convFuncModule_Agc.UpdDate];
objDR[convFuncModule_Agc.Memo] = objInFor[convFuncModule_Agc.Memo];
objDR[convFuncModule_Agc.UpdUser] = objInFor[convFuncModule_Agc.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}