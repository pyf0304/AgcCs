
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectFuncModuleWApi
 表名:vCMProjectFuncModule(00050556)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMProjectFuncModuleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetmId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, long lngmId, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.mId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.mId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.mId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetCmPrjId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectFuncModule.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectFuncModule.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectFuncModule.CmPrjId);
objvCMProjectFuncModuleEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.CmPrjId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetCmPrjName(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectFuncModule.CmPrjName);
objvCMProjectFuncModuleEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.CmPrjName) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetFuncModuleAgcId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMProjectFuncModule.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMProjectFuncModule.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMProjectFuncModule.FuncModuleAgcId);
objvCMProjectFuncModuleEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.FuncModuleAgcId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetFuncModuleName(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCMProjectFuncModule.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMProjectFuncModule.FuncModuleName);
objvCMProjectFuncModuleEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.FuncModuleName) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabNum">表数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetTabNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int intTabNum, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.TabNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.TabNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.TabNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intViewNum">界面数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetViewNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int intViewNum, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.ViewNum = intViewNum; //界面数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.ViewNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.ViewNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.ViewNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetOrderNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMProjectFuncModule.OrderNum);
objvCMProjectFuncModuleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.OrderNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.OrderNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.OrderNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNumFuncModule">序号_模块</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetOrderNumFuncModule(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int intOrderNumFuncModule, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.OrderNumFuncModule = intOrderNumFuncModule; //序号_模块
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.OrderNumFuncModule) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.OrderNumFuncModule, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.OrderNumFuncModule] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetPrjId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectFuncModule.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectFuncModule.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectFuncModule.PrjId);
objvCMProjectFuncModuleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.PrjId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.PrjId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.PrjId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetUpdDate(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectFuncModule.UpdDate);
objvCMProjectFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.UpdDate) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.UpdDate, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.UpdDate] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetUpdUser(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectFuncModule.UpdUser);
objvCMProjectFuncModuleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.UpdUser) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.UpdUser, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.UpdUser] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetMemo(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectFuncModule.Memo);
objvCMProjectFuncModuleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.Memo) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.Memo, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.Memo] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.mId) == true)
{
string strComparisonOpmId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.mId, objvCMProjectFuncModuleCond.mId, strComparisonOpmId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.CmPrjId, objvCMProjectFuncModuleCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.CmPrjName, objvCMProjectFuncModuleCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.FuncModuleAgcId, objvCMProjectFuncModuleCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.FuncModuleName, objvCMProjectFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.TabNum) == true)
{
string strComparisonOpTabNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.TabNum, objvCMProjectFuncModuleCond.TabNum, strComparisonOpTabNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.ViewNum) == true)
{
string strComparisonOpViewNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.ViewNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.ViewNum, objvCMProjectFuncModuleCond.ViewNum, strComparisonOpViewNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.OrderNum, objvCMProjectFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.OrderNumFuncModule) == true)
{
string strComparisonOpOrderNumFuncModule = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.OrderNumFuncModule];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.OrderNumFuncModule, objvCMProjectFuncModuleCond.OrderNumFuncModule, strComparisonOpOrderNumFuncModule);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.PrjId, objvCMProjectFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.UpdDate, objvCMProjectFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.UpdUser, objvCMProjectFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.Memo, objvCMProjectFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCMProjectFuncModule(vCMProjectFuncModule)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectFuncModuleWApi
{
private static readonly string mstrApiControllerName = "vCMProjectFuncModuleApi";

 public clsvCMProjectFuncModuleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectFuncModuleEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN;
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
objvCMProjectFuncModuleEN = JsonConvert.DeserializeObject<clsvCMProjectFuncModuleEN>(strJson);
return objvCMProjectFuncModuleEN;
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
public static clsvCMProjectFuncModuleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN;
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
objvCMProjectFuncModuleEN = JsonConvert.DeserializeObject<clsvCMProjectFuncModuleEN>(strJson);
return objvCMProjectFuncModuleEN;
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
public static clsvCMProjectFuncModuleEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLst_Sel =
from objvCMProjectFuncModuleEN in arrvCMProjectFuncModuleObjLstCache
where objvCMProjectFuncModuleEN.mId == lngmId 
select objvCMProjectFuncModuleEN;
if (arrvCMProjectFuncModuleObjLst_Sel.Count() == 0)
{
   clsvCMProjectFuncModuleEN obj = clsvCMProjectFuncModuleWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMProjectFuncModuleObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLst(string strWhereCond)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
public static IEnumerable<clsvCMProjectFuncModuleEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLst_Sel =
from objvCMProjectFuncModuleEN in arrvCMProjectFuncModuleObjLstCache
where arrMId.Contains(objvCMProjectFuncModuleEN.mId)
select objvCMProjectFuncModuleEN;
return arrvCMProjectFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectFuncModuleEN>>(strJson);
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
 /// <param name = "objvCMProjectFuncModuleENS">源对象</param>
 /// <param name = "objvCMProjectFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENS, clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENT)
{
try
{
objvCMProjectFuncModuleENT.mId = objvCMProjectFuncModuleENS.mId; //mId
objvCMProjectFuncModuleENT.CmPrjId = objvCMProjectFuncModuleENS.CmPrjId; //Cm工程Id
objvCMProjectFuncModuleENT.CmPrjName = objvCMProjectFuncModuleENS.CmPrjName; //CM工程名
objvCMProjectFuncModuleENT.FuncModuleAgcId = objvCMProjectFuncModuleENS.FuncModuleAgcId; //功能模块Id
objvCMProjectFuncModuleENT.FuncModuleName = objvCMProjectFuncModuleENS.FuncModuleName; //功能模块名称
objvCMProjectFuncModuleENT.TabNum = objvCMProjectFuncModuleENS.TabNum; //表数
objvCMProjectFuncModuleENT.ViewNum = objvCMProjectFuncModuleENS.ViewNum; //界面数
objvCMProjectFuncModuleENT.OrderNum = objvCMProjectFuncModuleENS.OrderNum; //序号
objvCMProjectFuncModuleENT.OrderNumFuncModule = objvCMProjectFuncModuleENS.OrderNumFuncModule; //序号_模块
objvCMProjectFuncModuleENT.PrjId = objvCMProjectFuncModuleENS.PrjId; //工程Id
objvCMProjectFuncModuleENT.UpdDate = objvCMProjectFuncModuleENS.UpdDate; //修改日期
objvCMProjectFuncModuleENT.UpdUser = objvCMProjectFuncModuleENS.UpdUser; //修改者
objvCMProjectFuncModuleENT.Memo = objvCMProjectFuncModuleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMProjectFuncModuleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMProjectFuncModuleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMProjectFuncModuleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMProjectFuncModuleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMProjectFuncModuleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMProjectFuncModuleEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMProjectFuncModuleWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMProjectFuncModuleWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMProjectFuncModuleWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMProjectFuncModuleWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMProjectFuncModuleEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMProjectFuncModuleEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMProjectFuncModule.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMProjectFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMProjectFuncModuleEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCMProjectFuncModuleWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCMProjectFuncModuleWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMProjectFuncModuleObjLstCache = CacheHelper.Get<List<clsvCMProjectFuncModuleEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMProjectFuncModuleObjLstCache = CacheHelper.Get<List<clsvCMProjectFuncModuleEN>>(strKey);
}
return arrvCMProjectFuncModuleObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMProjectFuncModuleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMProjectFuncModule.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMProjectFuncModule.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.TabNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectFuncModule.ViewNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectFuncModule.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectFuncModule.OrderNumFuncModule, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectFuncModule.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectFuncModule.Memo, Type.GetType("System.String"));
foreach (clsvCMProjectFuncModuleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMProjectFuncModule.mId] = objInFor[convCMProjectFuncModule.mId];
objDR[convCMProjectFuncModule.CmPrjId] = objInFor[convCMProjectFuncModule.CmPrjId];
objDR[convCMProjectFuncModule.CmPrjName] = objInFor[convCMProjectFuncModule.CmPrjName];
objDR[convCMProjectFuncModule.FuncModuleAgcId] = objInFor[convCMProjectFuncModule.FuncModuleAgcId];
objDR[convCMProjectFuncModule.FuncModuleName] = objInFor[convCMProjectFuncModule.FuncModuleName];
objDR[convCMProjectFuncModule.TabNum] = objInFor[convCMProjectFuncModule.TabNum];
objDR[convCMProjectFuncModule.ViewNum] = objInFor[convCMProjectFuncModule.ViewNum];
objDR[convCMProjectFuncModule.OrderNum] = objInFor[convCMProjectFuncModule.OrderNum];
objDR[convCMProjectFuncModule.OrderNumFuncModule] = objInFor[convCMProjectFuncModule.OrderNumFuncModule];
objDR[convCMProjectFuncModule.PrjId] = objInFor[convCMProjectFuncModule.PrjId];
objDR[convCMProjectFuncModule.UpdDate] = objInFor[convCMProjectFuncModule.UpdDate];
objDR[convCMProjectFuncModule.UpdUser] = objInFor[convCMProjectFuncModule.UpdUser];
objDR[convCMProjectFuncModule.Memo] = objInFor[convCMProjectFuncModule.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}