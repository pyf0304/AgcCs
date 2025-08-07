
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsWApi
 表名:Projects(00050002)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsProjectsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjId(this clsProjectsEN objProjectsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conProjects.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conProjects.PrjId);
objProjectsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjName(this clsProjectsEN objProjectsEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, conProjects.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, conProjects.PrjName);
objProjectsEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjName] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjDomain">域/包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetPrjDomain(this clsProjectsEN objProjectsEN, string strPrjDomain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjDomain, 128, conProjects.PrjDomain);
objProjectsEN.PrjDomain = strPrjDomain; //域/包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.PrjDomain) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.PrjDomain, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.PrjDomain] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableSpace">表空间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetTableSpace(this clsProjectsEN objProjectsEN, string strTableSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableSpace, 50, conProjects.TableSpace);
objProjectsEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.TableSpace) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.TableSpace, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.TableSpace] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strGetWebApiFunc">获取WebApiUrl函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetGetWebApiFunc(this clsProjectsEN objProjectsEN, string strGetWebApiFunc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetWebApiFunc, 100, conProjects.GetWebApiFunc);
objProjectsEN.GetWebApiFunc = strGetWebApiFunc; //获取WebApiUrl函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.GetWebApiFunc) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.GetWebApiFunc, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.GetWebApiFunc] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRelaDataBase">是否关联数据库</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsRelaDataBase(this clsProjectsEN objProjectsEN, bool bolIsRelaDataBase, string strComparisonOp="")
	{
objProjectsEN.IsRelaDataBase = bolIsRelaDataBase; //是否关联数据库
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsRelaDataBase) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsRelaDataBase, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsRelaDataBase] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUseStateId(this clsProjectsEN objProjectsEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseStateId, conProjects.UseStateId);
clsCheckSql.CheckFieldLen(strUseStateId, 4, conProjects.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conProjects.UseStateId);
objProjectsEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UseStateId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UseStateId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UseStateId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUserId(this clsProjectsEN objProjectsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conProjects.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conProjects.UserId);
objProjectsEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UserId) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UserId, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UserId] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetUpdDate(this clsProjectsEN objProjectsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conProjects.UpdDate);
objProjectsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.UpdDate) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.UpdDate, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.UpdDate] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetMemo(this clsProjectsEN objProjectsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conProjects.Memo);
objProjectsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.Memo) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.Memo, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.Memo] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaPackageName">Java包名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetJavaPackageName(this clsProjectsEN objProjectsEN, string strJavaPackageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaPackageName, 200, conProjects.JavaPackageName);
objProjectsEN.JavaPackageName = strJavaPackageName; //Java包名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.JavaPackageName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.JavaPackageName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.JavaPackageName] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSupportMvc">是否支持Mvc</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsSupportMvc(this clsProjectsEN objProjectsEN, bool bolIsSupportMvc, string strComparisonOp="")
	{
objProjectsEN.IsSupportMvc = bolIsSupportMvc; //是否支持Mvc
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsSupportMvc) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsSupportMvc, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsSupportMvc] = strComparisonOp;
}
}
return objProjectsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProjectsEN">需要设置字段值的实体对象</param>
 /// <param name = "strIsoPrjName">ISO工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProjectsEN SetIsoPrjName(this clsProjectsEN objProjectsEN, string strIsoPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIsoPrjName, 50, conProjects.IsoPrjName);
objProjectsEN.IsoPrjName = strIsoPrjName; //ISO工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProjectsEN.dicFldComparisonOp.ContainsKey(conProjects.IsoPrjName) == false)
{
objProjectsEN.dicFldComparisonOp.Add(conProjects.IsoPrjName, strComparisonOp);
}
else
{
objProjectsEN.dicFldComparisonOp[conProjects.IsoPrjName] = strComparisonOp;
}
}
return objProjectsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsProjectsEN objProjectsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objProjectsCond.IsUpdated(conProjects.PrjId) == true)
{
string strComparisonOpPrjId = objProjectsCond.dicFldComparisonOp[conProjects.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjId, objProjectsCond.PrjId, strComparisonOpPrjId);
}
if (objProjectsCond.IsUpdated(conProjects.PrjName) == true)
{
string strComparisonOpPrjName = objProjectsCond.dicFldComparisonOp[conProjects.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjName, objProjectsCond.PrjName, strComparisonOpPrjName);
}
if (objProjectsCond.IsUpdated(conProjects.PrjDomain) == true)
{
string strComparisonOpPrjDomain = objProjectsCond.dicFldComparisonOp[conProjects.PrjDomain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.PrjDomain, objProjectsCond.PrjDomain, strComparisonOpPrjDomain);
}
if (objProjectsCond.IsUpdated(conProjects.TableSpace) == true)
{
string strComparisonOpTableSpace = objProjectsCond.dicFldComparisonOp[conProjects.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.TableSpace, objProjectsCond.TableSpace, strComparisonOpTableSpace);
}
if (objProjectsCond.IsUpdated(conProjects.GetWebApiFunc) == true)
{
string strComparisonOpGetWebApiFunc = objProjectsCond.dicFldComparisonOp[conProjects.GetWebApiFunc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.GetWebApiFunc, objProjectsCond.GetWebApiFunc, strComparisonOpGetWebApiFunc);
}
if (objProjectsCond.IsUpdated(conProjects.IsRelaDataBase) == true)
{
if (objProjectsCond.IsRelaDataBase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProjects.IsRelaDataBase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProjects.IsRelaDataBase);
}
}
if (objProjectsCond.IsUpdated(conProjects.UseStateId) == true)
{
string strComparisonOpUseStateId = objProjectsCond.dicFldComparisonOp[conProjects.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UseStateId, objProjectsCond.UseStateId, strComparisonOpUseStateId);
}
if (objProjectsCond.IsUpdated(conProjects.UserId) == true)
{
string strComparisonOpUserId = objProjectsCond.dicFldComparisonOp[conProjects.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UserId, objProjectsCond.UserId, strComparisonOpUserId);
}
if (objProjectsCond.IsUpdated(conProjects.UpdDate) == true)
{
string strComparisonOpUpdDate = objProjectsCond.dicFldComparisonOp[conProjects.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.UpdDate, objProjectsCond.UpdDate, strComparisonOpUpdDate);
}
if (objProjectsCond.IsUpdated(conProjects.Memo) == true)
{
string strComparisonOpMemo = objProjectsCond.dicFldComparisonOp[conProjects.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.Memo, objProjectsCond.Memo, strComparisonOpMemo);
}
if (objProjectsCond.IsUpdated(conProjects.JavaPackageName) == true)
{
string strComparisonOpJavaPackageName = objProjectsCond.dicFldComparisonOp[conProjects.JavaPackageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.JavaPackageName, objProjectsCond.JavaPackageName, strComparisonOpJavaPackageName);
}
if (objProjectsCond.IsUpdated(conProjects.IsSupportMvc) == true)
{
if (objProjectsCond.IsSupportMvc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProjects.IsSupportMvc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProjects.IsSupportMvc);
}
}
if (objProjectsCond.IsUpdated(conProjects.IsoPrjName) == true)
{
string strComparisonOpIsoPrjName = objProjectsCond.dicFldComparisonOp[conProjects.IsoPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProjects.IsoPrjName, objProjectsCond.IsoPrjName, strComparisonOpIsoPrjName);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProjectsEN objProjectsEN)
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objProjectsEN.sfUpdFldSetStr = objProjectsEN.getsfUpdFldSetStr();
clsProjectsWApi.CheckPropertyNew(objProjectsEN); 
bool bolResult = clsProjectsWApi.UpdateRecord(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
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
 /// 获取唯一性条件串--Projects(工程), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objProjectsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsProjectsEN objProjectsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objProjectsEN == null) return "";
if (objProjectsEN.PrjId == null || objProjectsEN.PrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjId !=  '{0}'", objProjectsEN.PrjId);
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsProjectsEN objProjectsEN)
{
try
{
 if (string.IsNullOrEmpty(objProjectsEN.PrjId) == true || clsProjectsWApi.IsExist(objProjectsEN.PrjId) == true)
 {
     objProjectsEN.PrjId = clsProjectsWApi.GetMaxStrId();
 }
clsProjectsWApi.CheckPropertyNew(objProjectsEN); 
bool bolResult = clsProjectsWApi.AddNewRecord(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsProjectsEN objProjectsEN)
{
try
{
clsProjectsWApi.CheckPropertyNew(objProjectsEN); 
string strPrjId = clsProjectsWApi.AddNewRecordWithMaxId(objProjectsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
return strPrjId;
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProjectsEN objProjectsEN, string strWhereCond)
{
try
{
clsProjectsWApi.CheckPropertyNew(objProjectsEN); 
bool bolResult = clsProjectsWApi.UpdateWithCondition(objProjectsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
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
 /// 工程(Projects)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsProjectsWApi
{
private static readonly string mstrApiControllerName = "ProjectsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsProjectsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程]...","0");
List<clsProjectsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PrjId";
objDDL.DataTextField="PrjName";
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

public static void BindCbo_PrjId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conProjects.PrjId); 
List<clsProjectsEN> arrObjLst = clsProjectsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsProjectsEN objProjectsEN = new clsProjectsEN()
{
PrjId = "0",
PrjName = "选[工程]..."
};
arrObjLst.Insert(0, objProjectsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conProjects.PrjId;
objComboBox.DisplayMember = conProjects.PrjName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsProjectsEN objProjectsEN)
{
if (!Object.Equals(null, objProjectsEN.PrjId) && GetStrLen(objProjectsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objProjectsEN.PrjName) && GetStrLen(objProjectsEN.PrjName) > 30)
{
 throw new Exception("字段[工程名称]的长度不能超过30!");
}
if (!Object.Equals(null, objProjectsEN.PrjDomain) && GetStrLen(objProjectsEN.PrjDomain) > 128)
{
 throw new Exception("字段[域/包名]的长度不能超过128!");
}
if (!Object.Equals(null, objProjectsEN.TableSpace) && GetStrLen(objProjectsEN.TableSpace) > 50)
{
 throw new Exception("字段[表空间]的长度不能超过50!");
}
if (!Object.Equals(null, objProjectsEN.GetWebApiFunc) && GetStrLen(objProjectsEN.GetWebApiFunc) > 100)
{
 throw new Exception("字段[获取WebApiUrl函数]的长度不能超过100!");
}
if (!Object.Equals(null, objProjectsEN.UseStateId) && GetStrLen(objProjectsEN.UseStateId) > 4)
{
 throw new Exception("字段[使用状态Id]的长度不能超过4!");
}
if (!Object.Equals(null, objProjectsEN.UserId) && GetStrLen(objProjectsEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objProjectsEN.UpdDate) && GetStrLen(objProjectsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objProjectsEN.Memo) && GetStrLen(objProjectsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objProjectsEN.JavaPackageName) && GetStrLen(objProjectsEN.JavaPackageName) > 200)
{
 throw new Exception("字段[Java包名]的长度不能超过200!");
}
if (!Object.Equals(null, objProjectsEN.IsoPrjName) && GetStrLen(objProjectsEN.IsoPrjName) > 50)
{
 throw new Exception("字段[ISO工程名]的长度不能超过50!");
}
 objProjectsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProjectsEN GetObjByPrjId(string strPrjId)
{
if (strPrjId == "") return null;
string strAction = "GetObjByPrjId";
clsProjectsEN objProjectsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjId"] = strPrjId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objProjectsEN = JsonConvert.DeserializeObject<clsProjectsEN>(strJson);
return objProjectsEN;
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
public static clsProjectsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsProjectsEN objProjectsEN;
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
objProjectsEN = JsonConvert.DeserializeObject<clsProjectsEN>(strJson);
return objProjectsEN;
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
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProjectsEN GetObjByPrjIdCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel =
from objProjectsEN in arrProjectsObjLstCache
where objProjectsEN.PrjId == strPrjId 
select objProjectsEN;
if (arrProjectsObjLst_Sel.Count() == 0)
{
   clsProjectsEN obj = clsProjectsWApi.GetObjByPrjId(strPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrProjectsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPrjNameByPrjIdCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return "";
//初始化列表缓存
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel1 =
from objProjectsEN in arrProjectsObjLstCache
where objProjectsEN.PrjId == strPrjId 
select objProjectsEN;
List <clsProjectsEN> arrProjectsObjLst_Sel = new List<clsProjectsEN>();
foreach (clsProjectsEN obj in arrProjectsObjLst_Sel1)
{
arrProjectsObjLst_Sel.Add(obj);
}
if (arrProjectsObjLst_Sel.Count > 0)
{
return arrProjectsObjLst_Sel[0].PrjName;
}
string strErrMsgForGetObjById = string.Format("在Projects对象缓存列表中,找不到记录[PrjId = {0}](函数:{1})", strPrjId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsProjectsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjIdCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true) return "";
//初始化列表缓存
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel1 =
from objProjectsEN in arrProjectsObjLstCache
where objProjectsEN.PrjId == strPrjId 
select objProjectsEN;
List <clsProjectsEN> arrProjectsObjLst_Sel = new List<clsProjectsEN>();
foreach (clsProjectsEN obj in arrProjectsObjLst_Sel1)
{
arrProjectsObjLst_Sel.Add(obj);
}
if (arrProjectsObjLst_Sel.Count > 0)
{
return arrProjectsObjLst_Sel[0].PrjName;
}
string strErrMsgForGetObjById = string.Format("在Projects对象缓存列表中,找不到记录的相关名称[PrjId = {0}](函数:{1})", strPrjId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsProjectsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetObjLst(string strWhereCond)
{
 List<clsProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
 /// <param name = "arrPrjId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetObjLstByPrjIdLst(List<string> arrPrjId)
{
 List<clsProjectsEN> arrObjLst; 
string strAction = "GetObjLstByPrjIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
 /// <param name = "arrPrjId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsProjectsEN> GetObjLstByPrjIdLstCache(List<string> arrPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
List<clsProjectsEN> arrProjectsObjLstCache = GetObjLstCache();
IEnumerable <clsProjectsEN> arrProjectsObjLst_Sel =
from objProjectsEN in arrProjectsObjLstCache
where arrPrjId.Contains(objProjectsEN.PrjId)
select objProjectsEN;
return arrProjectsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsProjectsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
public static List<clsProjectsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
public static List<clsProjectsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
public static List<clsProjectsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsProjectsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProjectsEN>>(strJson);
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
public static int DelRecord(string strPrjId)
{
string strAction = "DelRecord";
try
{
 clsProjectsEN objProjectsEN = clsProjectsWApi.GetObjByPrjId(strPrjId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPrjId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsProjectsWApi.ReFreshCache();
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
public static int DelProjectss(List<string> arrPrjId)
{
string strAction = "DelProjectss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsProjectsWApi.ReFreshCache();
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
public static int DelProjectssByCond(string strWhereCond)
{
string strAction = "DelProjectssByCond";
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
public static bool AddNewRecord(clsProjectsEN objProjectsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProjectsEN>(objProjectsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsProjectsEN objProjectsEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProjectsEN>(objProjectsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProjectsWApi.ReFreshCache();
var strPrjId = (string)jobjReturn0["returnStr"];
return strPrjId;
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
public static bool UpdateRecord(clsProjectsEN objProjectsEN)
{
if (string.IsNullOrEmpty(objProjectsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProjectsEN.PrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProjectsEN>(objProjectsEN);
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsProjectsEN objProjectsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objProjectsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProjectsEN.PrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProjectsEN.PrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProjectsEN>(objProjectsEN);
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
public static bool IsExist(string strPrjId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjId"] = strPrjId
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
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
 public static void CopyTo(clsProjectsEN objProjectsENS, clsProjectsEN objProjectsENT)
{
try
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程Id
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.GetWebApiFunc = objProjectsENS.GetWebApiFunc; //获取WebApiUrl函数
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.IsoPrjName = objProjectsENS.IsoPrjName; //ISO工程名
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
public static DataTable ToDataTable(List<clsProjectsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsProjectsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsProjectsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsProjectsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsProjectsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsProjectsEN._AttributeName)
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
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsProjectsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsProjectsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProjectsWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProjectsEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsProjectsEN._CurrTabName;
List<clsProjectsEN> arrProjectsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrProjectsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsProjectsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conProjects.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.PrjDomain, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.TableSpace, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.GetWebApiFunc, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.IsRelaDataBase, Type.GetType("System.Boolean"));
objDT.Columns.Add(conProjects.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.JavaPackageName, Type.GetType("System.String"));
objDT.Columns.Add(conProjects.IsSupportMvc, Type.GetType("System.Boolean"));
objDT.Columns.Add(conProjects.IsoPrjName, Type.GetType("System.String"));
foreach (clsProjectsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conProjects.PrjId] = objInFor[conProjects.PrjId];
objDR[conProjects.PrjName] = objInFor[conProjects.PrjName];
objDR[conProjects.PrjDomain] = objInFor[conProjects.PrjDomain];
objDR[conProjects.TableSpace] = objInFor[conProjects.TableSpace];
objDR[conProjects.GetWebApiFunc] = objInFor[conProjects.GetWebApiFunc];
objDR[conProjects.IsRelaDataBase] = objInFor[conProjects.IsRelaDataBase];
objDR[conProjects.UseStateId] = objInFor[conProjects.UseStateId];
objDR[conProjects.UserId] = objInFor[conProjects.UserId];
objDR[conProjects.UpdDate] = objInFor[conProjects.UpdDate];
objDR[conProjects.Memo] = objInFor[conProjects.Memo];
objDR[conProjects.JavaPackageName] = objInFor[conProjects.JavaPackageName];
objDR[conProjects.IsSupportMvc] = objInFor[conProjects.IsSupportMvc];
objDR[conProjects.IsoPrjName] = objInFor[conProjects.IsoPrjName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程(Projects)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Projects : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsProjectsWApi.ReFreshThisCache();
}
}

}