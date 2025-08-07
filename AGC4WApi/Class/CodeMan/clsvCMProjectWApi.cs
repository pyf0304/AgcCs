
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectWApi
 表名:vCMProject(00050513)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvCMProjectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetCmPrjId(this clsvCMProjectEN objvCMProjectEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProject.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProject.CmPrjId);
objvCMProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.CmPrjId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetCmPrjName(this clsvCMProjectEN objvCMProjectEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProject.CmPrjName);
objvCMProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.CmPrjName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetPrjId(this clsvCMProjectEN objvCMProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProject.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProject.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProject.PrjId);
objvCMProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.PrjId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.PrjId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.PrjId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetPrjName(this clsvCMProjectEN objvCMProjectEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMProject.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMProject.PrjName);
objvCMProjectEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.PrjName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.PrjName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.PrjName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetApplicationTypeId(this clsvCMProjectEN objvCMProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMProject.ApplicationTypeId);
objvCMProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ApplicationTypeId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetApplicationTypeSimName(this clsvCMProjectEN objvCMProjectEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMProject.ApplicationTypeSimName);
objvCMProjectEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ApplicationTypeSimName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectFileName">工程文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetProjectFileName(this clsvCMProjectEN objvCMProjectEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMProject.ProjectFileName);
objvCMProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.ProjectFileName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.ProjectFileName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.ProjectFileName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUseStateId(this clsvCMProjectEN objvCMProjectEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convCMProject.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convCMProject.UseStateId);
objvCMProjectEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UseStateId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UseStateId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UseStateId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateName">使用状态名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUseStateName(this clsvCMProjectEN objvCMProjectEN, string strUseStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convCMProject.UseStateName);
objvCMProjectEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UseStateName) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UseStateName, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UseStateName] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRefresh4RelaView">是否刷新相关视图</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetIsRefresh4RelaView(this clsvCMProjectEN objvCMProjectEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objvCMProjectEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.IsRefresh4RelaView) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.IsRefresh4RelaView, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.IsRefresh4RelaView] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUpdDate(this clsvCMProjectEN objvCMProjectEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProject.UpdDate);
objvCMProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UpdDate) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UpdDate, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UpdDate] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetUpdUserId(this clsvCMProjectEN objvCMProjectEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCMProject.UpdUserId);
objvCMProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.UpdUserId) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.UpdUserId, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.UpdUserId] = strComparisonOp;
}
}
return objvCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectEN SetMemo(this clsvCMProjectEN objvCMProjectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProject.Memo);
objvCMProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectEN.dicFldComparisonOp.ContainsKey(convCMProject.Memo) == false)
{
objvCMProjectEN.dicFldComparisonOp.Add(convCMProject.Memo, strComparisonOp);
}
else
{
objvCMProjectEN.dicFldComparisonOp[convCMProject.Memo] = strComparisonOp;
}
}
return objvCMProjectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectEN objvCMProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectCond.IsUpdated(convCMProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectCond.dicFldComparisonOp[convCMProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.CmPrjId, objvCMProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectCond.dicFldComparisonOp[convCMProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.CmPrjName, objvCMProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectCond.dicFldComparisonOp[convCMProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.PrjId, objvCMProjectCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.PrjName) == true)
{
string strComparisonOpPrjName = objvCMProjectCond.dicFldComparisonOp[convCMProject.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.PrjName, objvCMProjectCond.PrjName, strComparisonOpPrjName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMProjectCond.dicFldComparisonOp[convCMProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProject.ApplicationTypeId, objvCMProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMProjectCond.dicFldComparisonOp[convCMProject.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.ApplicationTypeSimName, objvCMProjectCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvCMProjectCond.dicFldComparisonOp[convCMProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.ProjectFileName, objvCMProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UseStateId) == true)
{
string strComparisonOpUseStateId = objvCMProjectCond.dicFldComparisonOp[convCMProject.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UseStateId, objvCMProjectCond.UseStateId, strComparisonOpUseStateId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UseStateName) == true)
{
string strComparisonOpUseStateName = objvCMProjectCond.dicFldComparisonOp[convCMProject.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UseStateName, objvCMProjectCond.UseStateName, strComparisonOpUseStateName);
}
if (objvCMProjectCond.IsUpdated(convCMProject.IsRefresh4RelaView) == true)
{
if (objvCMProjectCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMProject.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMProject.IsRefresh4RelaView);
}
}
if (objvCMProjectCond.IsUpdated(convCMProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectCond.dicFldComparisonOp[convCMProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UpdDate, objvCMProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectCond.IsUpdated(convCMProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCMProjectCond.dicFldComparisonOp[convCMProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.UpdUserId, objvCMProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCMProjectCond.IsUpdated(convCMProject.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectCond.dicFldComparisonOp[convCMProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProject.Memo, objvCMProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM项目(vCMProject)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectWApi
{
private static readonly string mstrApiControllerName = "vCMProjectApi";

 public clsvCMProjectWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmPrjId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM项目]...","0");
List<clsvCMProjectEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CmPrjId";
objDDL.DataTextField="CmPrjName";
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

public static void BindCbo_CmPrjId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMProject.CmPrjId); 
List<clsvCMProjectEN> arrObjLst = clsvCMProjectWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMProjectEN objvCMProjectEN = new clsvCMProjectEN()
{
CmPrjId = "0",
CmPrjName = "选[vCM项目]..."
};
arrObjLst.Insert(0, objvCMProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMProject.CmPrjId;
objComboBox.DisplayMember = convCMProject.CmPrjName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
if (strCmPrjId == "") return null;
string strAction = "GetObjByCmPrjId";
clsvCMProjectEN objvCMProjectEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmPrjId"] = strCmPrjId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMProjectEN = JsonConvert.DeserializeObject<clsvCMProjectEN>(strJson);
return objvCMProjectEN;
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
public static clsvCMProjectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMProjectEN objvCMProjectEN;
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
objvCMProjectEN = JsonConvert.DeserializeObject<clsvCMProjectEN>(strJson);
return objvCMProjectEN;
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
//该表没有使用Cache,不需要生成[GetCmPrjNameByCmPrjIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectEN> GetObjLst(string strWhereCond)
{
 List<clsvCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
 /// <param name = "arrCmPrjId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectEN> GetObjLstByCmPrjIdLst(List<string> arrCmPrjId)
{
 List<clsvCMProjectEN> arrObjLst; 
string strAction = "GetObjLstByCmPrjIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmPrjId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
public static List<clsvCMProjectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
public static List<clsvCMProjectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
public static List<clsvCMProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
public static List<clsvCMProjectEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectEN>>(strJson);
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
public static bool IsExist(string strCmPrjId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmPrjId"] = strCmPrjId
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
 /// <param name = "objvCMProjectENS">源对象</param>
 /// <param name = "objvCMProjectENT">目标对象</param>
 public static void CopyTo(clsvCMProjectEN objvCMProjectENS, clsvCMProjectEN objvCMProjectENT)
{
try
{
objvCMProjectENT.CmPrjId = objvCMProjectENS.CmPrjId; //Cm工程Id
objvCMProjectENT.CmPrjName = objvCMProjectENS.CmPrjName; //CM工程名
objvCMProjectENT.PrjId = objvCMProjectENS.PrjId; //工程Id
objvCMProjectENT.PrjName = objvCMProjectENS.PrjName; //工程名称
objvCMProjectENT.ApplicationTypeId = objvCMProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectENT.ApplicationTypeSimName = objvCMProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectENT.ProjectFileName = objvCMProjectENS.ProjectFileName; //工程文件名
objvCMProjectENT.UseStateId = objvCMProjectENS.UseStateId; //使用状态Id
objvCMProjectENT.UseStateName = objvCMProjectENS.UseStateName; //使用状态名称
objvCMProjectENT.IsRefresh4RelaView = objvCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objvCMProjectENT.UpdDate = objvCMProjectENS.UpdDate; //修改日期
objvCMProjectENT.UpdUserId = objvCMProjectENS.UpdUserId; //修改用户Id
objvCMProjectENT.Memo = objvCMProjectENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMProjectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMProjectEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMProjectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMProjectEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMProjectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMProjectEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCMProjectEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvCMProjectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMProject.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProject.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.ProjectFileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.UseStateName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.IsRefresh4RelaView, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCMProject.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProject.Memo, Type.GetType("System.String"));
foreach (clsvCMProjectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMProject.CmPrjId] = objInFor[convCMProject.CmPrjId];
objDR[convCMProject.CmPrjName] = objInFor[convCMProject.CmPrjName];
objDR[convCMProject.PrjId] = objInFor[convCMProject.PrjId];
objDR[convCMProject.PrjName] = objInFor[convCMProject.PrjName];
objDR[convCMProject.ApplicationTypeId] = objInFor[convCMProject.ApplicationTypeId];
objDR[convCMProject.ApplicationTypeSimName] = objInFor[convCMProject.ApplicationTypeSimName];
objDR[convCMProject.ProjectFileName] = objInFor[convCMProject.ProjectFileName];
objDR[convCMProject.UseStateId] = objInFor[convCMProject.UseStateId];
objDR[convCMProject.UseStateName] = objInFor[convCMProject.UseStateName];
objDR[convCMProject.IsRefresh4RelaView] = objInFor[convCMProject.IsRefresh4RelaView];
objDR[convCMProject.UpdDate] = objInFor[convCMProject.UpdDate];
objDR[convCMProject.UpdUserId] = objInFor[convCMProject.UpdUserId];
objDR[convCMProject.Memo] = objInFor[convCMProject.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}