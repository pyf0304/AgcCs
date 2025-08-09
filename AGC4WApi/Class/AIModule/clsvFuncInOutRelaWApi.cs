
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncInOutRelaWApi
 表名:vFuncInOutRela(00050408)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvFuncInOutRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetmId(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, long lngmId, string strComparisonOp="")
	{
objvFuncInOutRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.mId) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.mId, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.mId] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTabId">功能表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetFuncTabId(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strFuncTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTabId, 8, convFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldForeignKey(strFuncTabId, 8, convFuncInOutRela.FuncTabId);
objvFuncInOutRelaEN.FuncTabId = strFuncTabId; //功能表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.FuncTabId) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.FuncTabId, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.FuncTabId] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetTabName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convFuncInOutRela.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convFuncInOutRela.TabName);
objvFuncInOutRelaEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.TabName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.TabName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.TabName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabCnName">表中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetTabCnName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convFuncInOutRela.TabCnName);
objvFuncInOutRelaEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.TabCnName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.TabCnName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.TabCnName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strInFldIds">输入字段Ids</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetInFldIds(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strInFldIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInFldIds, 1000, convFuncInOutRela.InFldIds);
objvFuncInOutRelaEN.InFldIds = strInFldIds; //输入字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.InFldIds) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.InFldIds, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.InFldIds] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strInFldNames">输入字段名s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetInFldNames(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strInFldNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInFldNames, 1000, convFuncInOutRela.InFldNames);
objvFuncInOutRelaEN.InFldNames = strInFldNames; //输入字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.InFldNames) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.InFldNames, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.InFldNames] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldIds">输出字段Ids</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetOutFldIds(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strOutFldIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldIds, 1000, convFuncInOutRela.OutFldIds);
objvFuncInOutRelaEN.OutFldIds = strOutFldIds; //输出字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.OutFldIds) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.OutFldIds, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.OutFldIds] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldNames">输出字段名s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetOutFldNames(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strOutFldNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldNames, 1000, convFuncInOutRela.OutFldNames);
objvFuncInOutRelaEN.OutFldNames = strOutFldNames; //输出字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.OutFldNames) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.OutFldNames, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.OutFldNames] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strGcFuncName">GC函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetGcFuncName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strGcFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGcFuncName, 50, convFuncInOutRela.GcFuncName);
objvFuncInOutRelaEN.GcFuncName = strGcFuncName; //GC函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.GcFuncName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.GcFuncName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.GcFuncName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetUpdDate(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncInOutRela.UpdDate);
objvFuncInOutRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.UpdDate) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.UpdDate, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.UpdDate] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetUpdUser(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncInOutRela.UpdUser);
objvFuncInOutRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.UpdUser) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.UpdUser, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.UpdUser] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetMemo(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncInOutRela.Memo);
objvFuncInOutRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.Memo) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.Memo, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.Memo] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncInOutRelaEN objvFuncInOutRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.mId) == true)
{
string strComparisonOpmId = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncInOutRela.mId, objvFuncInOutRelaCond.mId, strComparisonOpmId);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.FuncTabId) == true)
{
string strComparisonOpFuncTabId = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.FuncTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.FuncTabId, objvFuncInOutRelaCond.FuncTabId, strComparisonOpFuncTabId);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.TabName) == true)
{
string strComparisonOpTabName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.TabName, objvFuncInOutRelaCond.TabName, strComparisonOpTabName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.TabCnName) == true)
{
string strComparisonOpTabCnName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.TabCnName, objvFuncInOutRelaCond.TabCnName, strComparisonOpTabCnName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.InFldIds) == true)
{
string strComparisonOpInFldIds = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.InFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.InFldIds, objvFuncInOutRelaCond.InFldIds, strComparisonOpInFldIds);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.InFldNames) == true)
{
string strComparisonOpInFldNames = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.InFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.InFldNames, objvFuncInOutRelaCond.InFldNames, strComparisonOpInFldNames);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.OutFldIds) == true)
{
string strComparisonOpOutFldIds = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.OutFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.OutFldIds, objvFuncInOutRelaCond.OutFldIds, strComparisonOpOutFldIds);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.OutFldNames) == true)
{
string strComparisonOpOutFldNames = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.OutFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.OutFldNames, objvFuncInOutRelaCond.OutFldNames, strComparisonOpOutFldNames);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.GcFuncName) == true)
{
string strComparisonOpGcFuncName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.GcFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.GcFuncName, objvFuncInOutRelaCond.GcFuncName, strComparisonOpGcFuncName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.UpdDate, objvFuncInOutRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.UpdUser, objvFuncInOutRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.Memo) == true)
{
string strComparisonOpMemo = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.Memo, objvFuncInOutRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数输入输出关系(vFuncInOutRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFuncInOutRelaWApi
{
private static readonly string mstrApiControllerName = "vFuncInOutRelaApi";

 public clsvFuncInOutRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncInOutRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFuncInOutRelaEN objvFuncInOutRelaEN;
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
objvFuncInOutRelaEN = JsonConvert.DeserializeObject<clsvFuncInOutRelaEN>(strJson);
return objvFuncInOutRelaEN;
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
public static clsvFuncInOutRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFuncInOutRelaEN objvFuncInOutRelaEN;
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
objvFuncInOutRelaEN = JsonConvert.DeserializeObject<clsvFuncInOutRelaEN>(strJson);
return objvFuncInOutRelaEN;
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
public static clsvFuncInOutRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLst_Sel =
from objvFuncInOutRelaEN in arrvFuncInOutRelaObjLstCache
where objvFuncInOutRelaEN.mId == lngmId 
select objvFuncInOutRelaEN;
if (arrvFuncInOutRelaObjLst_Sel.Count() == 0)
{
   clsvFuncInOutRelaEN obj = clsvFuncInOutRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFuncInOutRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
public static IEnumerable<clsvFuncInOutRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLst_Sel =
from objvFuncInOutRelaEN in arrvFuncInOutRelaObjLstCache
where arrMId.Contains(objvFuncInOutRelaEN.mId)
select objvFuncInOutRelaEN;
return arrvFuncInOutRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFuncInOutRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFuncInOutRelaEN>>(strJson);
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
 /// <param name = "objvFuncInOutRelaENS">源对象</param>
 /// <param name = "objvFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(clsvFuncInOutRelaEN objvFuncInOutRelaENS, clsvFuncInOutRelaEN objvFuncInOutRelaENT)
{
try
{
objvFuncInOutRelaENT.mId = objvFuncInOutRelaENS.mId; //mId
objvFuncInOutRelaENT.FuncTabId = objvFuncInOutRelaENS.FuncTabId; //功能表Id
objvFuncInOutRelaENT.TabName = objvFuncInOutRelaENS.TabName; //表名
objvFuncInOutRelaENT.TabCnName = objvFuncInOutRelaENS.TabCnName; //表中文名
objvFuncInOutRelaENT.InFldIds = objvFuncInOutRelaENS.InFldIds; //输入字段Ids
objvFuncInOutRelaENT.InFldNames = objvFuncInOutRelaENS.InFldNames; //输入字段名s
objvFuncInOutRelaENT.OutFldIds = objvFuncInOutRelaENS.OutFldIds; //输出字段Ids
objvFuncInOutRelaENT.OutFldNames = objvFuncInOutRelaENS.OutFldNames; //输出字段名s
objvFuncInOutRelaENT.GcFuncName = objvFuncInOutRelaENS.GcFuncName; //GC函数名
objvFuncInOutRelaENT.UpdDate = objvFuncInOutRelaENS.UpdDate; //修改日期
objvFuncInOutRelaENT.UpdUser = objvFuncInOutRelaENS.UpdUser; //修改者
objvFuncInOutRelaENT.Memo = objvFuncInOutRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFuncInOutRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFuncInOutRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFuncInOutRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFuncInOutRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFuncInOutRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFuncInOutRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
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
public static List<clsvFuncInOutRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFuncInOutRelaEN._CurrTabName;
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFuncInOutRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFuncInOutRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFuncInOutRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFuncInOutRela.FuncTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.TabCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.InFldIds, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.InFldNames, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.OutFldIds, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.OutFldNames, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.GcFuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFuncInOutRela.Memo, Type.GetType("System.String"));
foreach (clsvFuncInOutRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFuncInOutRela.mId] = objInFor[convFuncInOutRela.mId];
objDR[convFuncInOutRela.FuncTabId] = objInFor[convFuncInOutRela.FuncTabId];
objDR[convFuncInOutRela.TabName] = objInFor[convFuncInOutRela.TabName];
objDR[convFuncInOutRela.TabCnName] = objInFor[convFuncInOutRela.TabCnName];
objDR[convFuncInOutRela.InFldIds] = objInFor[convFuncInOutRela.InFldIds];
objDR[convFuncInOutRela.InFldNames] = objInFor[convFuncInOutRela.InFldNames];
objDR[convFuncInOutRela.OutFldIds] = objInFor[convFuncInOutRela.OutFldIds];
objDR[convFuncInOutRela.OutFldNames] = objInFor[convFuncInOutRela.OutFldNames];
objDR[convFuncInOutRela.GcFuncName] = objInFor[convFuncInOutRela.GcFuncName];
objDR[convFuncInOutRela.UpdDate] = objInFor[convFuncInOutRela.UpdDate];
objDR[convFuncInOutRela.UpdUser] = objInFor[convFuncInOutRela.UpdUser];
objDR[convFuncInOutRela.Memo] = objInFor[convFuncInOutRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}