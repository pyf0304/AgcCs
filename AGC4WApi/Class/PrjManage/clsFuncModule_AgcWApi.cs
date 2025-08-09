
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModule_AgcWApi
 表名:FuncModule_Agc(00050015)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:39
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
public static class  clsFuncModule_AgcWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleAgcId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conFuncModule_Agc.FuncModuleAgcId);
objFuncModule_AgcEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleAgcId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleAgcId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleAgcId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleName(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, conFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, conFuncModule_Agc.FuncModuleName);
objFuncModule_AgcEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleName) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleName, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleName] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleEnName(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, conFuncModule_Agc.FuncModuleEnName);
objFuncModule_AgcEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleEnName) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleEnName, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleEnName] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">功能模块简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetFuncModuleNameSim(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, conFuncModule_Agc.FuncModuleNameSim);
objFuncModule_AgcEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.FuncModuleNameSim) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.FuncModuleNameSim, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.FuncModuleNameSim] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetPrjId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFuncModule_Agc.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conFuncModule_Agc.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFuncModule_Agc.PrjId);
objFuncModule_AgcEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.PrjId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.PrjId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.PrjId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetOrderNum(this clsFuncModule_AgcEN objFuncModule_AgcEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFuncModule_Agc.OrderNum);
objFuncModule_AgcEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.OrderNum) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.OrderNum, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.OrderNum] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUseStateId(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, conFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conFuncModule_Agc.UseStateId);
objFuncModule_AgcEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UseStateId) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UseStateId, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UseStateId] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUpdUser(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncModule_Agc.UpdUser);
objFuncModule_AgcEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UpdUser) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UpdUser, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UpdUser] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetUpdDate(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncModule_Agc.UpdDate);
objFuncModule_AgcEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.UpdDate) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.UpdDate, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.UpdDate] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncModule_AgcEN SetMemo(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncModule_Agc.Memo);
objFuncModule_AgcEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncModule_AgcEN.dicFldComparisonOp.ContainsKey(conFuncModule_Agc.Memo) == false)
{
objFuncModule_AgcEN.dicFldComparisonOp.Add(conFuncModule_Agc.Memo, strComparisonOp);
}
else
{
objFuncModule_AgcEN.dicFldComparisonOp[conFuncModule_Agc.Memo] = strComparisonOp;
}
}
return objFuncModule_AgcEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncModule_AgcEN objFuncModule_AgcCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleAgcId, objFuncModule_AgcCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleName, objFuncModule_AgcCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleEnName, objFuncModule_AgcCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.FuncModuleNameSim, objFuncModule_AgcCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.PrjId) == true)
{
string strComparisonOpPrjId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.PrjId, objFuncModule_AgcCond.PrjId, strComparisonOpPrjId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.OrderNum) == true)
{
string strComparisonOpOrderNum = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFuncModule_Agc.OrderNum, objFuncModule_AgcCond.OrderNum, strComparisonOpOrderNum);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UseStateId) == true)
{
string strComparisonOpUseStateId = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UseStateId, objFuncModule_AgcCond.UseStateId, strComparisonOpUseStateId);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UpdUser, objFuncModule_AgcCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.UpdDate, objFuncModule_AgcCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncModule_AgcCond.IsUpdated(conFuncModule_Agc.Memo) == true)
{
string strComparisonOpMemo = objFuncModule_AgcCond.dicFldComparisonOp[conFuncModule_Agc.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncModule_Agc.Memo, objFuncModule_AgcCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFuncModule_AgcEN.sfUpdFldSetStr = objFuncModule_AgcEN.getsfUpdFldSetStr();
clsFuncModule_AgcWApi.CheckPropertyNew(objFuncModule_AgcEN); 
bool bolResult = clsFuncModule_AgcWApi.UpdateRecord(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
 /// 获取唯一性条件串--FuncModule_Agc(模块), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncModuleName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncModule_AgcEN == null) return "";
if (objFuncModule_AgcEN.FuncModuleAgcId == null || objFuncModule_AgcEN.FuncModuleAgcId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncModuleAgcId !=  '{0}'", objFuncModule_AgcEN.FuncModuleAgcId);
 sbCondition.AppendFormat(" and FuncModuleName = '{0}'", objFuncModule_AgcEN.FuncModuleName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncModule_AgcEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
 if (string.IsNullOrEmpty(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFuncModule_AgcWApi.IsExist(objFuncModule_AgcEN.FuncModuleAgcId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFuncModule_AgcEN.FuncModuleAgcId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFuncModule_AgcWApi.CheckPropertyNew(objFuncModule_AgcEN); 
bool bolResult = clsFuncModule_AgcWApi.AddNewRecord(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
 /// <param name = "objFuncModule_AgcEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncModule_AgcEN objFuncModule_AgcEN)
{
try
{
clsFuncModule_AgcWApi.CheckPropertyNew(objFuncModule_AgcEN); 
string strFuncModuleAgcId = clsFuncModule_AgcWApi.AddNewRecordWithMaxId(objFuncModule_AgcEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
return strFuncModuleAgcId;
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
 /// <param name = "objFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncModule_AgcEN objFuncModule_AgcEN, string strWhereCond)
{
try
{
clsFuncModule_AgcWApi.CheckPropertyNew(objFuncModule_AgcEN); 
bool bolResult = clsFuncModule_AgcWApi.UpdateWithCondition(objFuncModule_AgcEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
 /// 模块(FuncModule_Agc)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFuncModule_AgcWApi
{
private static readonly string mstrApiControllerName = "FuncModule_AgcApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFuncModule_AgcWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncModuleAgcId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[模块]...","0");
List<clsFuncModule_AgcEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncModuleAgcId";
objDDL.DataTextField="FuncModuleName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_FuncModuleAgcId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncModule_Agc.FuncModuleAgcId); 
List<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncModule_AgcEN objFuncModule_AgcEN = new clsFuncModule_AgcEN()
{
FuncModuleAgcId = "0",
FuncModuleName = "选[模块]..."
};
arrObjLstSel.Insert(0, objFuncModule_AgcEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncModule_Agc.FuncModuleAgcId;
objComboBox.DisplayMember = conFuncModule_Agc.FuncModuleName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
if (!Object.Equals(null, objFuncModule_AgcEN.FuncModuleAgcId) && GetStrLen(objFuncModule_AgcEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.FuncModuleName) && GetStrLen(objFuncModule_AgcEN.FuncModuleName) > 30)
{
 throw new Exception("字段[功能模块名称]的长度不能超过30!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.FuncModuleEnName) && GetStrLen(objFuncModule_AgcEN.FuncModuleEnName) > 30)
{
 throw new Exception("字段[功能模块英文名称]的长度不能超过30!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.FuncModuleNameSim) && GetStrLen(objFuncModule_AgcEN.FuncModuleNameSim) > 30)
{
 throw new Exception("字段[功能模块简称]的长度不能超过30!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.PrjId) && GetStrLen(objFuncModule_AgcEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.UseStateId) && GetStrLen(objFuncModule_AgcEN.UseStateId) > 4)
{
 throw new Exception("字段[使用状态Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.UpdUser) && GetStrLen(objFuncModule_AgcEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.UpdDate) && GetStrLen(objFuncModule_AgcEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncModule_AgcEN.Memo) && GetStrLen(objFuncModule_AgcEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFuncModule_AgcEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId == "") return null;
string strAction = "GetObjByFuncModuleAgcId";
clsFuncModule_AgcEN objFuncModule_AgcEN;
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
objFuncModule_AgcEN = JsonConvert.DeserializeObject<clsFuncModule_AgcEN>(strJson);
return objFuncModule_AgcEN;
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
public static clsFuncModule_AgcEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFuncModule_AgcEN objFuncModule_AgcEN;
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
objFuncModule_AgcEN = JsonConvert.DeserializeObject<clsFuncModule_AgcEN>(strJson);
return objFuncModule_AgcEN;
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
public static clsFuncModule_AgcEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId,string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel =
from objFuncModule_AgcEN in arrFuncModule_AgcObjLstCache
where objFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId 
select objFuncModule_AgcEN;
if (arrFuncModule_AgcObjLst_Sel.Count() == 0)
{
   clsFuncModule_AgcEN obj = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFuncModule_AgcObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncModuleNameByFuncModuleAgcIdCache(string strFuncModuleAgcId,string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//初始化列表缓存
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel1 =
from objFuncModule_AgcEN in arrFuncModule_AgcObjLstCache
where objFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId 
select objFuncModule_AgcEN;
List <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel = new List<clsFuncModule_AgcEN>();
foreach (clsFuncModule_AgcEN obj in arrFuncModule_AgcObjLst_Sel1)
{
arrFuncModule_AgcObjLst_Sel.Add(obj);
}
if (arrFuncModule_AgcObjLst_Sel.Count > 0)
{
return arrFuncModule_AgcObjLst_Sel[0].FuncModuleName;
}
string strErrMsgForGetObjById = string.Format("在FuncModule_Agc对象缓存列表中,找不到记录[FuncModuleAgcId = {0}](函数:{1})", strFuncModuleAgcId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFuncModule_AgcBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncModuleAgcIdCache(string strFuncModuleAgcId,string strPrjId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return "";
//初始化列表缓存
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel1 =
from objFuncModule_AgcEN in arrFuncModule_AgcObjLstCache
where objFuncModule_AgcEN.FuncModuleAgcId == strFuncModuleAgcId 
select objFuncModule_AgcEN;
List <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel = new List<clsFuncModule_AgcEN>();
foreach (clsFuncModule_AgcEN obj in arrFuncModule_AgcObjLst_Sel1)
{
arrFuncModule_AgcObjLst_Sel.Add(obj);
}
if (arrFuncModule_AgcObjLst_Sel.Count > 0)
{
return arrFuncModule_AgcObjLst_Sel[0].FuncModuleName;
}
string strErrMsgForGetObjById = string.Format("在FuncModule_Agc对象缓存列表中,找不到记录的相关名称[FuncModuleAgcId = {0}](函数:{1})", strFuncModuleAgcId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFuncModule_AgcBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLst(string strWhereCond)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static List<clsFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcId)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static IEnumerable<clsFuncModule_AgcEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFuncModule_AgcEN> arrFuncModule_AgcObjLst_Sel =
from objFuncModule_AgcEN in arrFuncModule_AgcObjLstCache
where arrFuncModuleAgcId.Contains(objFuncModule_AgcEN.FuncModuleAgcId)
select objFuncModule_AgcEN;
return arrFuncModule_AgcObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncModule_AgcEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static List<clsFuncModule_AgcEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static List<clsFuncModule_AgcEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static List<clsFuncModule_AgcEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFuncModule_AgcEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncModule_AgcEN>>(strJson);
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
public static int DelRecord(string strFuncModuleAgcId)
{
string strAction = "DelRecord";
try
{
 clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncModuleAgcId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
public static int DelFuncModule_Agcs(List<string> arrFuncModuleAgcId)
{
string strAction = "DelFuncModule_Agcs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleAgcId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcWApi.GetObjByFuncModuleAgcId(arrFuncModuleAgcId[0]);
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
public static int DelFuncModule_AgcsByCond(string strWhereCond)
{
string strAction = "DelFuncModule_AgcsByCond";
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
public static bool AddNewRecord(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncModule_AgcEN>(objFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncModule_AgcEN>(objFuncModule_AgcEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncModule_AgcWApi.ReFreshCache(objFuncModule_AgcEN.PrjId);
var strFuncModuleAgcId = (string)jobjReturn0["returnStr"];
return strFuncModuleAgcId;
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
public static bool UpdateRecord(clsFuncModule_AgcEN objFuncModule_AgcEN)
{
if (string.IsNullOrEmpty(objFuncModule_AgcEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncModule_AgcEN>(objFuncModule_AgcEN);
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
 /// <param name = "objFuncModule_AgcEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFuncModule_AgcEN objFuncModule_AgcEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFuncModule_AgcEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncModule_AgcEN.FuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncModule_AgcEN>(objFuncModule_AgcEN);
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
 /// <param name = "objFuncModule_AgcENS">源对象</param>
 /// <param name = "objFuncModule_AgcENT">目标对象</param>
 public static void CopyTo(clsFuncModule_AgcEN objFuncModule_AgcENS, clsFuncModule_AgcEN objFuncModule_AgcENT)
{
try
{
objFuncModule_AgcENT.FuncModuleAgcId = objFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objFuncModule_AgcENT.FuncModuleName = objFuncModule_AgcENS.FuncModuleName; //功能模块名称
objFuncModule_AgcENT.FuncModuleEnName = objFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objFuncModule_AgcENT.FuncModuleNameSim = objFuncModule_AgcENS.FuncModuleNameSim; //功能模块简称
objFuncModule_AgcENT.PrjId = objFuncModule_AgcENS.PrjId; //工程Id
objFuncModule_AgcENT.OrderNum = objFuncModule_AgcENS.OrderNum; //序号
objFuncModule_AgcENT.UseStateId = objFuncModule_AgcENS.UseStateId; //使用状态Id
objFuncModule_AgcENT.UpdUser = objFuncModule_AgcENS.UpdUser; //修改者
objFuncModule_AgcENT.UpdDate = objFuncModule_AgcENS.UpdDate; //修改日期
objFuncModule_AgcENT.Memo = objFuncModule_AgcENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFuncModule_AgcEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFuncModule_AgcEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFuncModule_AgcEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFuncModule_AgcEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFuncModule_AgcEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFuncModule_AgcEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFuncModule_AgcWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFuncModule_AgcWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
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
if (clsFuncModule_AgcWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFuncModule_AgcWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFuncModule_AgcWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFuncModule_AgcWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFuncModule_AgcEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFuncModule_AgcEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFuncModule_Agc.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncModule_AgcEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsFuncModule_AgcEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFuncModule_AgcWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFuncModule_AgcWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsFuncModule_AgcEN._CurrTabName, strPrjId);
List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFuncModule_AgcObjLstCache = CacheHelper.Get<List<clsFuncModule_AgcEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFuncModule_AgcObjLstCache = CacheHelper.Get<List<clsFuncModule_AgcEN>>(strKey);
}
return arrFuncModule_AgcObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFuncModule_AgcEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFuncModule_Agc.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFuncModule_Agc.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFuncModule_Agc.Memo, Type.GetType("System.String"));
foreach (clsFuncModule_AgcEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFuncModule_Agc.FuncModuleAgcId] = objInFor[conFuncModule_Agc.FuncModuleAgcId];
objDR[conFuncModule_Agc.FuncModuleName] = objInFor[conFuncModule_Agc.FuncModuleName];
objDR[conFuncModule_Agc.FuncModuleEnName] = objInFor[conFuncModule_Agc.FuncModuleEnName];
objDR[conFuncModule_Agc.FuncModuleNameSim] = objInFor[conFuncModule_Agc.FuncModuleNameSim];
objDR[conFuncModule_Agc.PrjId] = objInFor[conFuncModule_Agc.PrjId];
objDR[conFuncModule_Agc.OrderNum] = objInFor[conFuncModule_Agc.OrderNum];
objDR[conFuncModule_Agc.UseStateId] = objInFor[conFuncModule_Agc.UseStateId];
objDR[conFuncModule_Agc.UpdUser] = objInFor[conFuncModule_Agc.UpdUser];
objDR[conFuncModule_Agc.UpdDate] = objInFor[conFuncModule_Agc.UpdDate];
objDR[conFuncModule_Agc.Memo] = objInFor[conFuncModule_Agc.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 模块(FuncModule_Agc)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FuncModule_Agc : clsCommFun4BLV2
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
clsFuncModule_AgcWApi.ReFreshThisCache(strPrjId);
}
}

}