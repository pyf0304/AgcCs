
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMUserProjectWApi
 表名:vCMUserProject(00050514)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:19
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
public static class  clsvCMUserProjectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetmId(this clsvCMUserProjectEN objvCMUserProjectEN, long lngmId, string strComparisonOp="")
	{
objvCMUserProjectEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.mId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.mId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.mId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUserId(this clsvCMUserProjectEN objvCMUserProjectEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convCMUserProject.UserId);
objvCMUserProjectEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UserId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UserId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UserId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUserName(this clsvCMUserProjectEN objvCMUserProjectEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convCMUserProject.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convCMUserProject.UserName);
objvCMUserProjectEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UserName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UserName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UserName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetCmPrjId(this clsvCMUserProjectEN objvCMUserProjectEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMUserProject.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMUserProject.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMUserProject.CmPrjId);
objvCMUserProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.CmPrjId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.CmPrjId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.CmPrjId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetCmPrjName(this clsvCMUserProjectEN objvCMUserProjectEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMUserProject.CmPrjName);
objvCMUserProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.CmPrjName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.CmPrjName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.CmPrjName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetPrjId(this clsvCMUserProjectEN objvCMUserProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMUserProject.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMUserProject.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMUserProject.PrjId);
objvCMUserProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.PrjId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.PrjId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.PrjId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetPrjName(this clsvCMUserProjectEN objvCMUserProjectEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMUserProject.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMUserProject.PrjName);
objvCMUserProjectEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.PrjName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.PrjName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.PrjName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetApplicationTypeId(this clsvCMUserProjectEN objvCMUserProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMUserProject.ApplicationTypeId);
objvCMUserProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ApplicationTypeId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetApplicationTypeSimName(this clsvCMUserProjectEN objvCMUserProjectEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMUserProject.ApplicationTypeSimName);
objvCMUserProjectEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ApplicationTypeSimName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectFileName">工程文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetProjectFileName(this clsvCMUserProjectEN objvCMUserProjectEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectFileName, convCMUserProject.ProjectFileName);
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convCMUserProject.ProjectFileName);
objvCMUserProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ProjectFileName) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ProjectFileName, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ProjectFileName] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetProjectPath(this clsvCMUserProjectEN objvCMUserProjectEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convCMUserProject.ProjectPath);
clsCheckSql.CheckFieldLen(strProjectPath, 500, convCMUserProject.ProjectPath);
objvCMUserProjectEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.ProjectPath) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.ProjectPath, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.ProjectPath] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUpdDate(this clsvCMUserProjectEN objvCMUserProjectEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMUserProject.UpdDate);
objvCMUserProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UpdDate) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UpdDate, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UpdDate] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetUpdUserId(this clsvCMUserProjectEN objvCMUserProjectEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convCMUserProject.UpdUserId);
objvCMUserProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.UpdUserId) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.UpdUserId, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.UpdUserId] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMUserProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMUserProjectEN SetMemo(this clsvCMUserProjectEN objvCMUserProjectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMUserProject.Memo);
objvCMUserProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMUserProjectEN.dicFldComparisonOp.ContainsKey(convCMUserProject.Memo) == false)
{
objvCMUserProjectEN.dicFldComparisonOp.Add(convCMUserProject.Memo, strComparisonOp);
}
else
{
objvCMUserProjectEN.dicFldComparisonOp[convCMUserProject.Memo] = strComparisonOp;
}
}
return objvCMUserProjectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMUserProjectEN objvCMUserProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.mId) == true)
{
string strComparisonOpmId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMUserProject.mId, objvCMUserProjectCond.mId, strComparisonOpmId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UserId) == true)
{
string strComparisonOpUserId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UserId, objvCMUserProjectCond.UserId, strComparisonOpUserId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UserName) == true)
{
string strComparisonOpUserName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UserName, objvCMUserProjectCond.UserName, strComparisonOpUserName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.CmPrjId, objvCMUserProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.CmPrjName, objvCMUserProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.PrjId) == true)
{
string strComparisonOpPrjId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.PrjId, objvCMUserProjectCond.PrjId, strComparisonOpPrjId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.PrjName) == true)
{
string strComparisonOpPrjName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.PrjName, objvCMUserProjectCond.PrjName, strComparisonOpPrjName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMUserProject.ApplicationTypeId, objvCMUserProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ApplicationTypeSimName, objvCMUserProjectCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ProjectFileName, objvCMUserProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.ProjectPath, objvCMUserProjectCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UpdDate, objvCMUserProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.UpdUserId, objvCMUserProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvCMUserProjectCond.IsUpdated(convCMUserProject.Memo) == true)
{
string strComparisonOpMemo = objvCMUserProjectCond.dicFldComparisonOp[convCMUserProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMUserProject.Memo, objvCMUserProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vCM用户工程(vCMUserProject)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMUserProjectWApi
{
private static readonly string mstrApiControllerName = "vCMUserProjectApi";

 public clsvCMUserProjectWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vCM用户工程]...","0");
List<clsvCMUserProjectEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="mId";
objDDL.DataTextField="UserId";
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

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convCMUserProject.mId); 
List<clsvCMUserProjectEN> arrObjLst = clsvCMUserProjectWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvCMUserProjectEN objvCMUserProjectEN = new clsvCMUserProjectEN()
{
mId = 0,
UserId = "选[vCM用户工程]..."
};
arrObjLst.Insert(0, objvCMUserProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convCMUserProject.mId;
objComboBox.DisplayMember = convCMUserProject.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMUserProjectEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvCMUserProjectEN objvCMUserProjectEN;
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
objvCMUserProjectEN = JsonConvert.DeserializeObject<clsvCMUserProjectEN>(strJson);
return objvCMUserProjectEN;
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
public static clsvCMUserProjectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMUserProjectEN objvCMUserProjectEN;
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
objvCMUserProjectEN = JsonConvert.DeserializeObject<clsvCMUserProjectEN>(strJson);
return objvCMUserProjectEN;
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
public static clsvCMUserProjectEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel =
from objvCMUserProjectEN in arrvCMUserProjectObjLstCache
where objvCMUserProjectEN.mId == lngmId 
select objvCMUserProjectEN;
if (arrvCMUserProjectObjLst_Sel.Count() == 0)
{
   clsvCMUserProjectEN obj = clsvCMUserProjectWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMUserProjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId)
{
//初始化列表缓存
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel1 =
from objvCMUserProjectEN in arrvCMUserProjectObjLstCache
where objvCMUserProjectEN.mId == lngmId 
select objvCMUserProjectEN;
List <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel = new List<clsvCMUserProjectEN>();
foreach (clsvCMUserProjectEN obj in arrvCMUserProjectObjLst_Sel1)
{
arrvCMUserProjectObjLst_Sel.Add(obj);
}
if (arrvCMUserProjectObjLst_Sel.Count > 0)
{
return arrvCMUserProjectObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在vCMUserProject对象缓存列表中,找不到记录[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCMUserProjectBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//初始化列表缓存
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel1 =
from objvCMUserProjectEN in arrvCMUserProjectObjLstCache
where objvCMUserProjectEN.mId == lngmId 
select objvCMUserProjectEN;
List <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel = new List<clsvCMUserProjectEN>();
foreach (clsvCMUserProjectEN obj in arrvCMUserProjectObjLst_Sel1)
{
arrvCMUserProjectObjLst_Sel.Add(obj);
}
if (arrvCMUserProjectObjLst_Sel.Count > 0)
{
return arrvCMUserProjectObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在vCMUserProject对象缓存列表中,找不到记录的相关名称[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvCMUserProjectBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMUserProjectEN> GetObjLst(string strWhereCond)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
public static List<clsvCMUserProjectEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
public static IEnumerable<clsvCMUserProjectEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = GetObjLstCache();
IEnumerable <clsvCMUserProjectEN> arrvCMUserProjectObjLst_Sel =
from objvCMUserProjectEN in arrvCMUserProjectObjLstCache
where arrMId.Contains(objvCMUserProjectEN.mId)
select objvCMUserProjectEN;
return arrvCMUserProjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMUserProjectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
public static List<clsvCMUserProjectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
public static List<clsvCMUserProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
public static List<clsvCMUserProjectEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMUserProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMUserProjectEN>>(strJson);
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
 /// <param name = "objvCMUserProjectENS">源对象</param>
 /// <param name = "objvCMUserProjectENT">目标对象</param>
 public static void CopyTo(clsvCMUserProjectEN objvCMUserProjectENS, clsvCMUserProjectEN objvCMUserProjectENT)
{
try
{
objvCMUserProjectENT.mId = objvCMUserProjectENS.mId; //mId
objvCMUserProjectENT.UserId = objvCMUserProjectENS.UserId; //用户Id
objvCMUserProjectENT.UserName = objvCMUserProjectENS.UserName; //用户名
objvCMUserProjectENT.CmPrjId = objvCMUserProjectENS.CmPrjId; //Cm工程Id
objvCMUserProjectENT.CmPrjName = objvCMUserProjectENS.CmPrjName; //CM工程名
objvCMUserProjectENT.PrjId = objvCMUserProjectENS.PrjId; //工程Id
objvCMUserProjectENT.PrjName = objvCMUserProjectENS.PrjName; //工程名称
objvCMUserProjectENT.ApplicationTypeId = objvCMUserProjectENS.ApplicationTypeId; //应用程序类型ID
objvCMUserProjectENT.ApplicationTypeSimName = objvCMUserProjectENS.ApplicationTypeSimName; //应用程序类型简称
objvCMUserProjectENT.ProjectFileName = objvCMUserProjectENS.ProjectFileName; //工程文件名
objvCMUserProjectENT.ProjectPath = objvCMUserProjectENS.ProjectPath; //工程路径
objvCMUserProjectENT.UpdDate = objvCMUserProjectENS.UpdDate; //修改日期
objvCMUserProjectENT.UpdUserId = objvCMUserProjectENS.UpdUserId; //修改用户Id
objvCMUserProjectENT.Memo = objvCMUserProjectENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvCMUserProjectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMUserProjectEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMUserProjectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMUserProjectEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMUserProjectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMUserProjectEN._AttributeName)
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
string strKey = string.Format("{0}", clsvCMUserProjectEN._CurrTabName);
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
public static List<clsvCMUserProjectEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvCMUserProjectEN._CurrTabName;
List<clsvCMUserProjectEN> arrvCMUserProjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMUserProjectObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMUserProjectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMUserProject.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMUserProject.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMUserProject.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.ProjectFileName, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convCMUserProject.Memo, Type.GetType("System.String"));
foreach (clsvCMUserProjectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMUserProject.mId] = objInFor[convCMUserProject.mId];
objDR[convCMUserProject.UserId] = objInFor[convCMUserProject.UserId];
objDR[convCMUserProject.UserName] = objInFor[convCMUserProject.UserName];
objDR[convCMUserProject.CmPrjId] = objInFor[convCMUserProject.CmPrjId];
objDR[convCMUserProject.CmPrjName] = objInFor[convCMUserProject.CmPrjName];
objDR[convCMUserProject.PrjId] = objInFor[convCMUserProject.PrjId];
objDR[convCMUserProject.PrjName] = objInFor[convCMUserProject.PrjName];
objDR[convCMUserProject.ApplicationTypeId] = objInFor[convCMUserProject.ApplicationTypeId];
objDR[convCMUserProject.ApplicationTypeSimName] = objInFor[convCMUserProject.ApplicationTypeSimName];
objDR[convCMUserProject.ProjectFileName] = objInFor[convCMUserProject.ProjectFileName];
objDR[convCMUserProject.ProjectPath] = objInFor[convCMUserProject.ProjectPath];
objDR[convCMUserProject.UpdDate] = objInFor[convCMUserProject.UpdDate];
objDR[convCMUserProject.UpdUserId] = objInFor[convCMUserProject.UpdUserId];
objDR[convCMUserProject.Memo] = objInFor[convCMUserProject.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}