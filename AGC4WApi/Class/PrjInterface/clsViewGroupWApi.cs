
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewGroupWApi
 表名:ViewGroup(00050134)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsViewGroupWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupId">界面组ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetViewGroupId(this clsViewGroupEN objViewGroupEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewGroupId, 8, conViewGroup.ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, conViewGroup.ViewGroupId);
objViewGroupEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ViewGroupId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ViewGroupId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ViewGroupId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewGroupName">界面组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetViewGroupName(this clsViewGroupEN objViewGroupEN, string strViewGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupName, conViewGroup.ViewGroupName);
clsCheckSql.CheckFieldLen(strViewGroupName, 30, conViewGroup.ViewGroupName);
objViewGroupEN.ViewGroupName = strViewGroupName; //界面组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ViewGroupName) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ViewGroupName, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ViewGroupName] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInSqlDsTypeId">输入数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetInSqlDsTypeId(this clsViewGroupEN objViewGroupEN, string strInSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strInSqlDsTypeId, 2, conViewGroup.InSqlDsTypeId);
objViewGroupEN.InSqlDsTypeId = strInSqlDsTypeId; //输入数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.InSqlDsTypeId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.InSqlDsTypeId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.InSqlDsTypeId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strInRelaTabId">输入数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetInRelaTabId(this clsViewGroupEN objViewGroupEN, string strInRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInRelaTabId, 8, conViewGroup.InRelaTabId);
clsCheckSql.CheckFieldForeignKey(strInRelaTabId, 8, conViewGroup.InRelaTabId);
objViewGroupEN.InRelaTabId = strInRelaTabId; //输入数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.InRelaTabId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.InRelaTabId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.InRelaTabId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutSqlDsTypeId">输出数据源类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetOutSqlDsTypeId(this clsViewGroupEN objViewGroupEN, string strOutSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strOutSqlDsTypeId, 2, conViewGroup.OutSqlDsTypeId);
objViewGroupEN.OutSqlDsTypeId = strOutSqlDsTypeId; //输出数据源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.OutSqlDsTypeId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.OutSqlDsTypeId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.OutSqlDsTypeId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutRelaTabId">输出数据源表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetOutRelaTabId(this clsViewGroupEN objViewGroupEN, string strOutRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOutRelaTabId, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldLen(strOutRelaTabId, 8, conViewGroup.OutRelaTabId);
clsCheckSql.CheckFieldForeignKey(strOutRelaTabId, 8, conViewGroup.OutRelaTabId);
objViewGroupEN.OutRelaTabId = strOutRelaTabId; //输出数据源表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.OutRelaTabId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.OutRelaTabId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.OutRelaTabId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDomain">域/包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetPrjDomain(this clsViewGroupEN objViewGroupEN, string strPrjDomain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, conViewGroup.PrjDomain);
objViewGroupEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.PrjDomain) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.PrjDomain, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.PrjDomain] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strActionPath">Action路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetActionPath(this clsViewGroupEN objViewGroupEN, string strActionPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionPath, conViewGroup.ActionPath);
clsCheckSql.CheckFieldLen(strActionPath, 100, conViewGroup.ActionPath);
objViewGroupEN.ActionPath = strActionPath; //Action路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.ActionPath) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.ActionPath, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.ActionPath] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetPrjId(this clsViewGroupEN objViewGroupEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewGroup.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewGroup.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewGroup.PrjId);
objViewGroupEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.PrjId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.PrjId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.PrjId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetUserId(this clsViewGroupEN objViewGroupEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conViewGroup.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conViewGroup.UserId);
objViewGroupEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.UserId) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.UserId, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.UserId] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetUpdDate(this clsViewGroupEN objViewGroupEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewGroup.UpdDate);
objViewGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.UpdDate) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.UpdDate, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.UpdDate] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetMemo(this clsViewGroupEN objViewGroupEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewGroup.Memo);
objViewGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.Memo) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.Memo, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.Memo] = strComparisonOp;
}
}
return objViewGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableNameForProg">编程用表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewGroupEN SetTableNameForProg(this clsViewGroupEN objViewGroupEN, string strTableNameForProg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableNameForProg, 50, conViewGroup.TableNameForProg);
objViewGroupEN.TableNameForProg = strTableNameForProg; //编程用表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewGroupEN.dicFldComparisonOp.ContainsKey(conViewGroup.TableNameForProg) == false)
{
objViewGroupEN.dicFldComparisonOp.Add(conViewGroup.TableNameForProg, strComparisonOp);
}
else
{
objViewGroupEN.dicFldComparisonOp[conViewGroup.TableNameForProg] = strComparisonOp;
}
}
return objViewGroupEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewGroupEN objViewGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewGroupCond.IsUpdated(conViewGroup.ViewGroupId) == true)
{
string strComparisonOpViewGroupId = objViewGroupCond.dicFldComparisonOp[conViewGroup.ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ViewGroupId, objViewGroupCond.ViewGroupId, strComparisonOpViewGroupId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.ViewGroupName) == true)
{
string strComparisonOpViewGroupName = objViewGroupCond.dicFldComparisonOp[conViewGroup.ViewGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ViewGroupName, objViewGroupCond.ViewGroupName, strComparisonOpViewGroupName);
}
if (objViewGroupCond.IsUpdated(conViewGroup.InSqlDsTypeId) == true)
{
string strComparisonOpInSqlDsTypeId = objViewGroupCond.dicFldComparisonOp[conViewGroup.InSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.InSqlDsTypeId, objViewGroupCond.InSqlDsTypeId, strComparisonOpInSqlDsTypeId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.InRelaTabId) == true)
{
string strComparisonOpInRelaTabId = objViewGroupCond.dicFldComparisonOp[conViewGroup.InRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.InRelaTabId, objViewGroupCond.InRelaTabId, strComparisonOpInRelaTabId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.OutSqlDsTypeId) == true)
{
string strComparisonOpOutSqlDsTypeId = objViewGroupCond.dicFldComparisonOp[conViewGroup.OutSqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.OutSqlDsTypeId, objViewGroupCond.OutSqlDsTypeId, strComparisonOpOutSqlDsTypeId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.OutRelaTabId) == true)
{
string strComparisonOpOutRelaTabId = objViewGroupCond.dicFldComparisonOp[conViewGroup.OutRelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.OutRelaTabId, objViewGroupCond.OutRelaTabId, strComparisonOpOutRelaTabId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objViewGroupCond.dicFldComparisonOp[conViewGroup.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.PrjDomain, objViewGroupCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objViewGroupCond.IsUpdated(conViewGroup.ActionPath) == true)
{
string strComparisonOpActionPath = objViewGroupCond.dicFldComparisonOp[conViewGroup.ActionPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.ActionPath, objViewGroupCond.ActionPath, strComparisonOpActionPath);
}
if (objViewGroupCond.IsUpdated(conViewGroup.PrjId) == true)
{
string strComparisonOpPrjId = objViewGroupCond.dicFldComparisonOp[conViewGroup.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.PrjId, objViewGroupCond.PrjId, strComparisonOpPrjId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.UserId) == true)
{
string strComparisonOpUserId = objViewGroupCond.dicFldComparisonOp[conViewGroup.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.UserId, objViewGroupCond.UserId, strComparisonOpUserId);
}
if (objViewGroupCond.IsUpdated(conViewGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewGroupCond.dicFldComparisonOp[conViewGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.UpdDate, objViewGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewGroupCond.IsUpdated(conViewGroup.Memo) == true)
{
string strComparisonOpMemo = objViewGroupCond.dicFldComparisonOp[conViewGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.Memo, objViewGroupCond.Memo, strComparisonOpMemo);
}
if (objViewGroupCond.IsUpdated(conViewGroup.TableNameForProg) == true)
{
string strComparisonOpTableNameForProg = objViewGroupCond.dicFldComparisonOp[conViewGroup.TableNameForProg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewGroup.TableNameForProg, objViewGroupCond.TableNameForProg, strComparisonOpTableNameForProg);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewGroupEN objViewGroupEN)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewGroupEN.sfUpdFldSetStr = objViewGroupEN.getsfUpdFldSetStr();
clsViewGroupWApi.CheckPropertyNew(objViewGroupEN); 
bool bolResult = clsViewGroupWApi.UpdateRecord(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
 /// 获取唯一性条件串--ViewGroup(界面组), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewGroupName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewGroupEN objViewGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewGroupEN == null) return "";
if (objViewGroupEN.ViewGroupId == null || objViewGroupEN.ViewGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewGroupId !=  '{0}'", objViewGroupEN.ViewGroupId);
 sbCondition.AppendFormat(" and ViewGroupName = '{0}'", objViewGroupEN.ViewGroupName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewGroupEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewGroupEN objViewGroupEN)
{
 if (string.IsNullOrEmpty(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewGroupWApi.IsExist(objViewGroupEN.ViewGroupId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewGroupEN.ViewGroupId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsViewGroupWApi.CheckPropertyNew(objViewGroupEN); 
bool bolResult = clsViewGroupWApi.AddNewRecord(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
 /// <param name = "objViewGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewGroupEN objViewGroupEN)
{
try
{
clsViewGroupWApi.CheckPropertyNew(objViewGroupEN); 
string strViewGroupId = clsViewGroupWApi.AddNewRecordWithMaxId(objViewGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
return strViewGroupId;
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewGroupEN objViewGroupEN, string strWhereCond)
{
try
{
clsViewGroupWApi.CheckPropertyNew(objViewGroupEN); 
bool bolResult = clsViewGroupWApi.UpdateWithCondition(objViewGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
 /// 界面组(ViewGroup)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewGroupWApi
{
private static readonly string mstrApiControllerName = "ViewGroupApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewGroupWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewGroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面组]...","0");
List<clsViewGroupEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewGroupId";
objDDL.DataTextField="ViewGroupName";
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
public static void BindCbo_ViewGroupId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewGroup.ViewGroupId); 
List<clsViewGroupEN> arrObjLst = clsViewGroupWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewGroupEN objViewGroupEN = new clsViewGroupEN()
{
ViewGroupId = "0",
ViewGroupName = "选[界面组]..."
};
arrObjLstSel.Insert(0, objViewGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewGroup.ViewGroupId;
objComboBox.DisplayMember = conViewGroup.ViewGroupName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewGroupEN objViewGroupEN)
{
if (!Object.Equals(null, objViewGroupEN.ViewGroupId) && GetStrLen(objViewGroupEN.ViewGroupId) > 8)
{
 throw new Exception("字段[界面组ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewGroupEN.ViewGroupName) && GetStrLen(objViewGroupEN.ViewGroupName) > 30)
{
 throw new Exception("字段[界面组名称]的长度不能超过30!");
}
if (!Object.Equals(null, objViewGroupEN.InSqlDsTypeId) && GetStrLen(objViewGroupEN.InSqlDsTypeId) > 2)
{
 throw new Exception("字段[输入数据源类型]的长度不能超过2!");
}
if (!Object.Equals(null, objViewGroupEN.InRelaTabId) && GetStrLen(objViewGroupEN.InRelaTabId) > 8)
{
 throw new Exception("字段[输入数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewGroupEN.OutSqlDsTypeId) && GetStrLen(objViewGroupEN.OutSqlDsTypeId) > 2)
{
 throw new Exception("字段[输出数据源类型]的长度不能超过2!");
}
if (!Object.Equals(null, objViewGroupEN.OutRelaTabId) && GetStrLen(objViewGroupEN.OutRelaTabId) > 8)
{
 throw new Exception("字段[输出数据源表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objViewGroupEN.PrjDomain) && GetStrLen(objViewGroupEN.PrjDomain) > 128)
{
 throw new Exception("字段[域/包名]的长度不能超过128!");
}
if (!Object.Equals(null, objViewGroupEN.ActionPath) && GetStrLen(objViewGroupEN.ActionPath) > 100)
{
 throw new Exception("字段[Action路径]的长度不能超过100!");
}
if (!Object.Equals(null, objViewGroupEN.PrjId) && GetStrLen(objViewGroupEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewGroupEN.UserId) && GetStrLen(objViewGroupEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objViewGroupEN.UpdDate) && GetStrLen(objViewGroupEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewGroupEN.Memo) && GetStrLen(objViewGroupEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objViewGroupEN.TableNameForProg) && GetStrLen(objViewGroupEN.TableNameForProg) > 50)
{
 throw new Exception("字段[编程用表名]的长度不能超过50!");
}
 objViewGroupEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewGroupEN GetObjByViewGroupId(string strViewGroupId)
{
if (strViewGroupId == "") return null;
string strAction = "GetObjByViewGroupId";
clsViewGroupEN objViewGroupEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewGroupId"] = strViewGroupId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objViewGroupEN = JsonConvert.DeserializeObject<clsViewGroupEN>(strJson);
return objViewGroupEN;
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
public static clsViewGroupEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewGroupEN objViewGroupEN;
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
objViewGroupEN = JsonConvert.DeserializeObject<clsViewGroupEN>(strJson);
return objViewGroupEN;
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
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewGroupEN GetObjByViewGroupIdCache(string strViewGroupId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel =
from objViewGroupEN in arrViewGroupObjLstCache
where objViewGroupEN.ViewGroupId == strViewGroupId 
select objViewGroupEN;
if (arrViewGroupObjLst_Sel.Count() == 0)
{
   clsViewGroupEN obj = clsViewGroupWApi.GetObjByViewGroupId(strViewGroupId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewGroupNameByViewGroupIdCache(string strViewGroupId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//初始化列表缓存
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel1 =
from objViewGroupEN in arrViewGroupObjLstCache
where objViewGroupEN.ViewGroupId == strViewGroupId 
select objViewGroupEN;
List <clsViewGroupEN> arrViewGroupObjLst_Sel = new List<clsViewGroupEN>();
foreach (clsViewGroupEN obj in arrViewGroupObjLst_Sel1)
{
arrViewGroupObjLst_Sel.Add(obj);
}
if (arrViewGroupObjLst_Sel.Count > 0)
{
return arrViewGroupObjLst_Sel[0].ViewGroupName;
}
string strErrMsgForGetObjById = string.Format("在ViewGroup对象缓存列表中,找不到记录[ViewGroupId = {0}](函数:{1})", strViewGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewGroupIdCache(string strViewGroupId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewGroupId) == true) return "";
//初始化列表缓存
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel1 =
from objViewGroupEN in arrViewGroupObjLstCache
where objViewGroupEN.ViewGroupId == strViewGroupId 
select objViewGroupEN;
List <clsViewGroupEN> arrViewGroupObjLst_Sel = new List<clsViewGroupEN>();
foreach (clsViewGroupEN obj in arrViewGroupObjLst_Sel1)
{
arrViewGroupObjLst_Sel.Add(obj);
}
if (arrViewGroupObjLst_Sel.Count > 0)
{
return arrViewGroupObjLst_Sel[0].ViewGroupName;
}
string strErrMsgForGetObjById = string.Format("在ViewGroup对象缓存列表中,找不到记录的相关名称[ViewGroupId = {0}](函数:{1})", strViewGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetObjLst(string strWhereCond)
{
 List<clsViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
 /// <param name = "arrViewGroupId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetObjLstByViewGroupIdLst(List<string> arrViewGroupId)
{
 List<clsViewGroupEN> arrObjLst; 
string strAction = "GetObjLstByViewGroupIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
 /// <param name = "arrViewGroupId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsViewGroupEN> GetObjLstByViewGroupIdLstCache(List<string> arrViewGroupId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewGroupEN> arrViewGroupObjLst_Sel =
from objViewGroupEN in arrViewGroupObjLstCache
where arrViewGroupId.Contains(objViewGroupEN.ViewGroupId)
select objViewGroupEN;
return arrViewGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
public static List<clsViewGroupEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
public static List<clsViewGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
public static List<clsViewGroupEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewGroupEN>>(strJson);
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
public static int DelRecord(string strViewGroupId)
{
string strAction = "DelRecord";
try
{
 clsViewGroupEN objViewGroupEN = clsViewGroupWApi.GetObjByViewGroupId(strViewGroupId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewGroupId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
public static int DelViewGroups(List<string> arrViewGroupId)
{
string strAction = "DelViewGroups";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewGroupId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsViewGroupEN objViewGroupEN = clsViewGroupWApi.GetObjByViewGroupId(arrViewGroupId[0]);
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
public static int DelViewGroupsByCond(string strWhereCond)
{
string strAction = "DelViewGroupsByCond";
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
public static bool AddNewRecord(clsViewGroupEN objViewGroupEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewGroupEN>(objViewGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsViewGroupEN objViewGroupEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewGroupEN>(objViewGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewGroupWApi.ReFreshCache(objViewGroupEN.PrjId);
var strViewGroupId = (string)jobjReturn0["returnStr"];
return strViewGroupId;
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
public static bool UpdateRecord(clsViewGroupEN objViewGroupEN)
{
if (string.IsNullOrEmpty(objViewGroupEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewGroupEN.ViewGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewGroupEN>(objViewGroupEN);
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
 /// <param name = "objViewGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewGroupEN objViewGroupEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewGroupEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewGroupEN.ViewGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewGroupEN.ViewGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewGroupEN>(objViewGroupEN);
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
public static bool IsExist(string strViewGroupId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewGroupId"] = strViewGroupId
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
 /// <param name = "objViewGroupENS">源对象</param>
 /// <param name = "objViewGroupENT">目标对象</param>
 public static void CopyTo(clsViewGroupEN objViewGroupENS, clsViewGroupEN objViewGroupENT)
{
try
{
objViewGroupENT.ViewGroupId = objViewGroupENS.ViewGroupId; //界面组ID
objViewGroupENT.ViewGroupName = objViewGroupENS.ViewGroupName; //界面组名称
objViewGroupENT.InSqlDsTypeId = objViewGroupENS.InSqlDsTypeId; //输入数据源类型
objViewGroupENT.InRelaTabId = objViewGroupENS.InRelaTabId; //输入数据源表ID
objViewGroupENT.OutSqlDsTypeId = objViewGroupENS.OutSqlDsTypeId; //输出数据源类型
objViewGroupENT.OutRelaTabId = objViewGroupENS.OutRelaTabId; //输出数据源表ID
objViewGroupENT.PrjDomain = objViewGroupENS.PrjDomain; //域/包名
objViewGroupENT.ActionPath = objViewGroupENS.ActionPath; //Action路径
objViewGroupENT.PrjId = objViewGroupENS.PrjId; //工程Id
objViewGroupENT.UserId = objViewGroupENS.UserId; //用户Id
objViewGroupENT.UpdDate = objViewGroupENS.UpdDate; //修改日期
objViewGroupENT.Memo = objViewGroupENS.Memo; //说明
objViewGroupENT.TableNameForProg = objViewGroupENS.TableNameForProg; //编程用表名
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
public static DataTable ToDataTable(List<clsViewGroupEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewGroupEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewGroupEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewGroupEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewGroupEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewGroupEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewGroupWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewGroupWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
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
if (clsViewGroupWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewGroupWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewGroupWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewGroupWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewGroupEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewGroupEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewGroup.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewGroupEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsViewGroupEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewGroupWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewGroupWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewGroupEN._CurrTabName, strPrjId);
List<clsViewGroupEN> arrViewGroupObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewGroupObjLstCache = CacheHelper.Get<List<clsViewGroupEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewGroupObjLstCache = CacheHelper.Get<List<clsViewGroupEN>>(strKey);
}
return arrViewGroupObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewGroupEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewGroup.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.ViewGroupName, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.InSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.InRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.OutSqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.OutRelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.PrjDomain, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.ActionPath, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conViewGroup.TableNameForProg, Type.GetType("System.String"));
foreach (clsViewGroupEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewGroup.ViewGroupId] = objInFor[conViewGroup.ViewGroupId];
objDR[conViewGroup.ViewGroupName] = objInFor[conViewGroup.ViewGroupName];
objDR[conViewGroup.InSqlDsTypeId] = objInFor[conViewGroup.InSqlDsTypeId];
objDR[conViewGroup.InRelaTabId] = objInFor[conViewGroup.InRelaTabId];
objDR[conViewGroup.OutSqlDsTypeId] = objInFor[conViewGroup.OutSqlDsTypeId];
objDR[conViewGroup.OutRelaTabId] = objInFor[conViewGroup.OutRelaTabId];
objDR[conViewGroup.PrjDomain] = objInFor[conViewGroup.PrjDomain];
objDR[conViewGroup.ActionPath] = objInFor[conViewGroup.ActionPath];
objDR[conViewGroup.PrjId] = objInFor[conViewGroup.PrjId];
objDR[conViewGroup.UserId] = objInFor[conViewGroup.UserId];
objDR[conViewGroup.UpdDate] = objInFor[conViewGroup.UpdDate];
objDR[conViewGroup.Memo] = objInFor[conViewGroup.Memo];
objDR[conViewGroup.TableNameForProg] = objInFor[conViewGroup.TableNameForProg];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面组(ViewGroup)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewGroup : clsCommFun4BLV2
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
clsViewGroupWApi.ReFreshThisCache(strPrjId);
}
}

}