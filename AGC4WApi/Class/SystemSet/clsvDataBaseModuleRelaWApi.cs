
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataBaseModuleRelaWApi
 表名:vDataBaseModuleRela(00050236)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvDataBaseModuleRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetmId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, long lngmId, string strComparisonOp="")
	{
objvDataBaseModuleRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.mId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.mId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.mId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataBaseModuleRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataBaseModuleRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataBaseModuleRela.PrjId);
objvDataBaseModuleRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convDataBaseModuleRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convDataBaseModuleRela.PrjName);
objvDataBaseModuleRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseId">项目数据库Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjDataBaseId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convDataBaseModuleRela.PrjDataBaseId);
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convDataBaseModuleRela.PrjDataBaseId);
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convDataBaseModuleRela.PrjDataBaseId);
objvDataBaseModuleRelaEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjDataBaseId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjDataBaseId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDataBaseName">项目数据库名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjDataBaseName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convDataBaseModuleRela.PrjDataBaseName);
objvDataBaseModuleRelaEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjDataBaseName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjDataBaseName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleAgcId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convDataBaseModuleRela.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convDataBaseModuleRela.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convDataBaseModuleRela.FuncModuleAgcId);
objvDataBaseModuleRelaEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleAgcId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleAgcId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleAgcId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convDataBaseModuleRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convDataBaseModuleRela.FuncModuleName);
objvDataBaseModuleRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleEnName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convDataBaseModuleRela.FuncModuleEnName);
objvDataBaseModuleRelaEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleEnName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleEnName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleEnName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetOrderNum(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convDataBaseModuleRela.OrderNum);
objvDataBaseModuleRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.OrderNum) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.OrderNum, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.OrderNum] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetIsVisible(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvDataBaseModuleRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.IsVisible) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.IsVisible, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.IsVisible] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetUpdUserId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convDataBaseModuleRela.UpdUserId);
objvDataBaseModuleRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.UpdUserId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.UpdUserId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.UpdUserId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetUpdDate(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDataBaseModuleRela.UpdDate);
objvDataBaseModuleRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.UpdDate) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.UpdDate, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.UpdDate] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetMemo(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDataBaseModuleRela.Memo);
objvDataBaseModuleRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.Memo) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.Memo, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.Memo] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.mId) == true)
{
string strComparisonOpmId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convDataBaseModuleRela.mId, objvDataBaseModuleRelaCond.mId, strComparisonOpmId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjId) == true)
{
string strComparisonOpPrjId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjId, objvDataBaseModuleRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjName) == true)
{
string strComparisonOpPrjName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjName, objvDataBaseModuleRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjDataBaseId, objvDataBaseModuleRelaCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjDataBaseName, objvDataBaseModuleRelaCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleAgcId, objvDataBaseModuleRelaCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleName, objvDataBaseModuleRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleEnName, objvDataBaseModuleRelaCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDataBaseModuleRela.OrderNum, objvDataBaseModuleRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.IsVisible) == true)
{
if (objvDataBaseModuleRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDataBaseModuleRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDataBaseModuleRela.IsVisible);
}
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.UpdUserId, objvDataBaseModuleRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.UpdDate, objvDataBaseModuleRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.Memo) == true)
{
string strComparisonOpMemo = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.Memo, objvDataBaseModuleRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v数据库模块关系(vDataBaseModuleRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDataBaseModuleRelaWApi
{
private static readonly string mstrApiControllerName = "vDataBaseModuleRelaApi";

 public clsvDataBaseModuleRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataBaseModuleRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN;
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
objvDataBaseModuleRelaEN = JsonConvert.DeserializeObject<clsvDataBaseModuleRelaEN>(strJson);
return objvDataBaseModuleRelaEN;
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
public static clsvDataBaseModuleRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN;
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
objvDataBaseModuleRelaEN = JsonConvert.DeserializeObject<clsvDataBaseModuleRelaEN>(strJson);
return objvDataBaseModuleRelaEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDataBaseModuleRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataBaseModuleRelaEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaENS">源对象</param>
 /// <param name = "objvDataBaseModuleRelaENT">目标对象</param>
 public static void CopyTo(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENS, clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENT)
{
try
{
objvDataBaseModuleRelaENT.mId = objvDataBaseModuleRelaENS.mId; //mId
objvDataBaseModuleRelaENT.PrjId = objvDataBaseModuleRelaENS.PrjId; //工程Id
objvDataBaseModuleRelaENT.PrjName = objvDataBaseModuleRelaENS.PrjName; //工程名称
objvDataBaseModuleRelaENT.PrjDataBaseId = objvDataBaseModuleRelaENS.PrjDataBaseId; //项目数据库Id
objvDataBaseModuleRelaENT.PrjDataBaseName = objvDataBaseModuleRelaENS.PrjDataBaseName; //项目数据库名
objvDataBaseModuleRelaENT.FuncModuleAgcId = objvDataBaseModuleRelaENS.FuncModuleAgcId; //功能模块Id
objvDataBaseModuleRelaENT.FuncModuleName = objvDataBaseModuleRelaENS.FuncModuleName; //功能模块名称
objvDataBaseModuleRelaENT.FuncModuleEnName = objvDataBaseModuleRelaENS.FuncModuleEnName; //功能模块英文名称
objvDataBaseModuleRelaENT.OrderNum = objvDataBaseModuleRelaENS.OrderNum; //序号
objvDataBaseModuleRelaENT.IsVisible = objvDataBaseModuleRelaENS.IsVisible; //是否显示
objvDataBaseModuleRelaENT.UpdUserId = objvDataBaseModuleRelaENS.UpdUserId; //修改用户Id
objvDataBaseModuleRelaENT.UpdDate = objvDataBaseModuleRelaENS.UpdDate; //修改日期
objvDataBaseModuleRelaENT.Memo = objvDataBaseModuleRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvDataBaseModuleRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDataBaseModuleRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDataBaseModuleRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDataBaseModuleRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDataBaseModuleRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDataBaseModuleRelaEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvDataBaseModuleRelaEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDataBaseModuleRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDataBaseModuleRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDataBaseModuleRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.PrjDataBaseId, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.PrjDataBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convDataBaseModuleRela.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDataBaseModuleRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDataBaseModuleRela.Memo, Type.GetType("System.String"));
foreach (clsvDataBaseModuleRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDataBaseModuleRela.mId] = objInFor[convDataBaseModuleRela.mId];
objDR[convDataBaseModuleRela.PrjId] = objInFor[convDataBaseModuleRela.PrjId];
objDR[convDataBaseModuleRela.PrjName] = objInFor[convDataBaseModuleRela.PrjName];
objDR[convDataBaseModuleRela.PrjDataBaseId] = objInFor[convDataBaseModuleRela.PrjDataBaseId];
objDR[convDataBaseModuleRela.PrjDataBaseName] = objInFor[convDataBaseModuleRela.PrjDataBaseName];
objDR[convDataBaseModuleRela.FuncModuleAgcId] = objInFor[convDataBaseModuleRela.FuncModuleAgcId];
objDR[convDataBaseModuleRela.FuncModuleName] = objInFor[convDataBaseModuleRela.FuncModuleName];
objDR[convDataBaseModuleRela.FuncModuleEnName] = objInFor[convDataBaseModuleRela.FuncModuleEnName];
objDR[convDataBaseModuleRela.OrderNum] = objInFor[convDataBaseModuleRela.OrderNum];
objDR[convDataBaseModuleRela.IsVisible] = objInFor[convDataBaseModuleRela.IsVisible];
objDR[convDataBaseModuleRela.UpdUserId] = objInFor[convDataBaseModuleRela.UpdUserId];
objDR[convDataBaseModuleRela.UpdDate] = objInFor[convDataBaseModuleRela.UpdDate];
objDR[convDataBaseModuleRela.Memo] = objInFor[convDataBaseModuleRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}