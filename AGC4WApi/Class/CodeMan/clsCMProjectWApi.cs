
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectWApi
 表名:CMProject(00050512)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:56
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
public static class  clsCMProjectWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetCmPrjId(this clsCMProjectEN objCMProjectEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProject.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProject.CmPrjId);
objCMProjectEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.CmPrjId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.CmPrjId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.CmPrjId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetCmPrjName(this clsCMProjectEN objCMProjectEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjName, conCMProject.CmPrjName);
clsCheckSql.CheckFieldLen(strCmPrjName, 50, conCMProject.CmPrjName);
objCMProjectEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.CmPrjName) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.CmPrjName, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.CmPrjName] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetPrjId(this clsCMProjectEN objCMProjectEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMProject.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMProject.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMProject.PrjId);
objCMProjectEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.PrjId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.PrjId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.PrjId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetApplicationTypeId(this clsCMProjectEN objCMProjectEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMProject.ApplicationTypeId);
objCMProjectEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.ApplicationTypeId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.ApplicationTypeId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.ApplicationTypeId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetFunctionTemplateId(this clsCMProjectEN objCMProjectEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, conCMProject.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, conCMProject.FunctionTemplateId);
objCMProjectEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.FunctionTemplateId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.FunctionTemplateId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.FunctionTemplateId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strVueDesignSysId">Vue控件设计体系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetVueDesignSysId(this clsCMProjectEN objCMProjectEN, string strVueDesignSysId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVueDesignSysId, 2, conCMProject.VueDesignSysId);
clsCheckSql.CheckFieldForeignKey(strVueDesignSysId, 2, conCMProject.VueDesignSysId);
objCMProjectEN.VueDesignSysId = strVueDesignSysId; //Vue控件设计体系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.VueDesignSysId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.VueDesignSysId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.VueDesignSysId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFstLcase">是否首字母小写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsFstLcase(this clsCMProjectEN objCMProjectEN, bool bolIsFstLcase, string strComparisonOp="")
	{
objCMProjectEN.IsFstLcase = bolIsFstLcase; //是否首字母小写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsFstLcase) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsFstLcase, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsFstLcase] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCamelCase">是否使用CamelCase</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsCamelCase(this clsCMProjectEN objCMProjectEN, bool bolIsCamelCase, string strComparisonOp="")
	{
objCMProjectEN.IsCamelCase = bolIsCamelCase; //是否使用CamelCase
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsCamelCase) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsCamelCase, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsCamelCase] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectFileName">工程文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetProjectFileName(this clsCMProjectEN objCMProjectEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, conCMProject.ProjectFileName);
objCMProjectEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.ProjectFileName) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.ProjectFileName, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.ProjectFileName] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseStateId">使用状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUseStateId(this clsCMProjectEN objCMProjectEN, string strUseStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseStateId, 4, conCMProject.UseStateId);
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, conCMProject.UseStateId);
objCMProjectEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UseStateId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UseStateId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UseStateId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRefresh4RelaView">是否刷新相关视图</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetIsRefresh4RelaView(this clsCMProjectEN objCMProjectEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objCMProjectEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.IsRefresh4RelaView) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.IsRefresh4RelaView, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.IsRefresh4RelaView] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUpdDate(this clsCMProjectEN objCMProjectEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProject.UpdDate);
objCMProjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UpdDate) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UpdDate, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UpdDate] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetUpdUserId(this clsCMProjectEN objCMProjectEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCMProject.UpdUserId);
objCMProjectEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.UpdUserId) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.UpdUserId, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.UpdUserId] = strComparisonOp;
}
}
return objCMProjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectEN SetMemo(this clsCMProjectEN objCMProjectEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProject.Memo);
objCMProjectEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectEN.dicFldComparisonOp.ContainsKey(conCMProject.Memo) == false)
{
objCMProjectEN.dicFldComparisonOp.Add(conCMProject.Memo, strComparisonOp);
}
else
{
objCMProjectEN.dicFldComparisonOp[conCMProject.Memo] = strComparisonOp;
}
}
return objCMProjectEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectEN objCMProjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectCond.IsUpdated(conCMProject.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectCond.dicFldComparisonOp[conCMProject.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.CmPrjId, objCMProjectCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectCond.IsUpdated(conCMProject.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objCMProjectCond.dicFldComparisonOp[conCMProject.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.CmPrjName, objCMProjectCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objCMProjectCond.IsUpdated(conCMProject.PrjId) == true)
{
string strComparisonOpPrjId = objCMProjectCond.dicFldComparisonOp[conCMProject.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.PrjId, objCMProjectCond.PrjId, strComparisonOpPrjId);
}
if (objCMProjectCond.IsUpdated(conCMProject.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMProjectCond.dicFldComparisonOp[conCMProject.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProject.ApplicationTypeId, objCMProjectCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMProjectCond.IsUpdated(conCMProject.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objCMProjectCond.dicFldComparisonOp[conCMProject.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.FunctionTemplateId, objCMProjectCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objCMProjectCond.IsUpdated(conCMProject.VueDesignSysId) == true)
{
string strComparisonOpVueDesignSysId = objCMProjectCond.dicFldComparisonOp[conCMProject.VueDesignSysId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.VueDesignSysId, objCMProjectCond.VueDesignSysId, strComparisonOpVueDesignSysId);
}
if (objCMProjectCond.IsUpdated(conCMProject.IsFstLcase) == true)
{
if (objCMProjectCond.IsFstLcase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsFstLcase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsFstLcase);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.IsCamelCase) == true)
{
if (objCMProjectCond.IsCamelCase == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsCamelCase);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsCamelCase);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objCMProjectCond.dicFldComparisonOp[conCMProject.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.ProjectFileName, objCMProjectCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objCMProjectCond.IsUpdated(conCMProject.UseStateId) == true)
{
string strComparisonOpUseStateId = objCMProjectCond.dicFldComparisonOp[conCMProject.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UseStateId, objCMProjectCond.UseStateId, strComparisonOpUseStateId);
}
if (objCMProjectCond.IsUpdated(conCMProject.IsRefresh4RelaView) == true)
{
if (objCMProjectCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMProject.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMProject.IsRefresh4RelaView);
}
}
if (objCMProjectCond.IsUpdated(conCMProject.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectCond.dicFldComparisonOp[conCMProject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UpdDate, objCMProjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectCond.IsUpdated(conCMProject.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCMProjectCond.dicFldComparisonOp[conCMProject.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.UpdUserId, objCMProjectCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCMProjectCond.IsUpdated(conCMProject.Memo) == true)
{
string strComparisonOpMemo = objCMProjectCond.dicFldComparisonOp[conCMProject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProject.Memo, objCMProjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectEN objCMProjectEN)
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMProjectEN.sfUpdFldSetStr = objCMProjectEN.getsfUpdFldSetStr();
clsCMProjectWApi.CheckPropertyNew(objCMProjectEN); 
bool bolResult = clsCMProjectWApi.UpdateRecord(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
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
 /// 获取唯一性条件串--CMProject(CM项目), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMPrjName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMProjectEN objCMProjectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectEN == null) return "";
if (objCMProjectEN.CmPrjId == null || objCMProjectEN.CmPrjId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmPrjId !=  '{0}'", objCMProjectEN.CmPrjId);
 sbCondition.AppendFormat(" and CmPrjName = '{0}'", objCMProjectEN.CmPrjName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMProjectEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectEN objCMProjectEN)
{
try
{
 if (string.IsNullOrEmpty(objCMProjectEN.CmPrjId) == true || clsCMProjectWApi.IsExist(objCMProjectEN.CmPrjId) == true)
 {
     objCMProjectEN.CmPrjId = clsCMProjectWApi.GetMaxStrId();
 }
clsCMProjectWApi.CheckPropertyNew(objCMProjectEN); 
bool bolResult = clsCMProjectWApi.AddNewRecord(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
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
 /// <param name = "objCMProjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMProjectEN objCMProjectEN)
{
try
{
clsCMProjectWApi.CheckPropertyNew(objCMProjectEN); 
string strCmPrjId = clsCMProjectWApi.AddNewRecordWithMaxId(objCMProjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
return strCmPrjId;
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectEN objCMProjectEN, string strWhereCond)
{
try
{
clsCMProjectWApi.CheckPropertyNew(objCMProjectEN); 
bool bolResult = clsCMProjectWApi.UpdateWithCondition(objCMProjectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
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
 /// CM项目(CMProject)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectWApi
{
private static readonly string mstrApiControllerName = "CMProjectApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCMProjectWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM项目]...","0");
List<clsCMProjectEN> arrObjLst = GetObjLst("1=1");
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_CmPrjId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMProject.CmPrjId); 
List<clsCMProjectEN> arrObjLst = clsCMProjectWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMProjectEN objCMProjectEN = new clsCMProjectEN()
{
CmPrjId = "0",
CmPrjName = "选[CM项目]..."
};
arrObjLstSel.Insert(0, objCMProjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMProject.CmPrjId;
objComboBox.DisplayMember = conCMProject.CmPrjName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMProjectEN objCMProjectEN)
{
if (!Object.Equals(null, objCMProjectEN.CmPrjId) && GetStrLen(objCMProjectEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objCMProjectEN.CmPrjName) && GetStrLen(objCMProjectEN.CmPrjName) > 50)
{
 throw new Exception("字段[CM工程名]的长度不能超过50!");
}
if (!Object.Equals(null, objCMProjectEN.PrjId) && GetStrLen(objCMProjectEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMProjectEN.FunctionTemplateId) && GetStrLen(objCMProjectEN.FunctionTemplateId) > 4)
{
 throw new Exception("字段[函数模板Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMProjectEN.VueDesignSysId) && GetStrLen(objCMProjectEN.VueDesignSysId) > 2)
{
 throw new Exception("字段[Vue控件设计体系Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCMProjectEN.ProjectFileName) && GetStrLen(objCMProjectEN.ProjectFileName) > 200)
{
 throw new Exception("字段[工程文件名]的长度不能超过200!");
}
if (!Object.Equals(null, objCMProjectEN.UseStateId) && GetStrLen(objCMProjectEN.UseStateId) > 4)
{
 throw new Exception("字段[使用状态Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMProjectEN.UpdDate) && GetStrLen(objCMProjectEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectEN.UpdUserId) && GetStrLen(objCMProjectEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectEN.Memo) && GetStrLen(objCMProjectEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCMProjectEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmPrjId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectEN GetObjByCmPrjId(string strCmPrjId)
{
if (strCmPrjId == "") return null;
string strAction = "GetObjByCmPrjId";
clsCMProjectEN objCMProjectEN;
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
objCMProjectEN = JsonConvert.DeserializeObject<clsCMProjectEN>(strJson);
return objCMProjectEN;
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
public static clsCMProjectEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMProjectEN objCMProjectEN;
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
objCMProjectEN = JsonConvert.DeserializeObject<clsCMProjectEN>(strJson);
return objCMProjectEN;
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
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectEN GetObjByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel =
from objCMProjectEN in arrCMProjectObjLstCache
where objCMProjectEN.CmPrjId == strCmPrjId 
select objCMProjectEN;
if (arrCMProjectObjLst_Sel.Count() == 0)
{
   clsCMProjectEN obj = clsCMProjectWApi.GetObjByCmPrjId(strCmPrjId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMProjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCmPrjNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//初始化列表缓存
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel1 =
from objCMProjectEN in arrCMProjectObjLstCache
where objCMProjectEN.CmPrjId == strCmPrjId 
select objCMProjectEN;
List <clsCMProjectEN> arrCMProjectObjLst_Sel = new List<clsCMProjectEN>();
foreach (clsCMProjectEN obj in arrCMProjectObjLst_Sel1)
{
arrCMProjectObjLst_Sel.Add(obj);
}
if (arrCMProjectObjLst_Sel.Count > 0)
{
return arrCMProjectObjLst_Sel[0].CmPrjName;
}
string strErrMsgForGetObjById = string.Format("在CMProject对象缓存列表中,找不到记录[CmPrjId = {0}](函数:{1})", strCmPrjId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMProjectBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmPrjId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmPrjIdCache(string strCmPrjId)
{
if (string.IsNullOrEmpty(strCmPrjId) == true) return "";
//初始化列表缓存
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel1 =
from objCMProjectEN in arrCMProjectObjLstCache
where objCMProjectEN.CmPrjId == strCmPrjId 
select objCMProjectEN;
List <clsCMProjectEN> arrCMProjectObjLst_Sel = new List<clsCMProjectEN>();
foreach (clsCMProjectEN obj in arrCMProjectObjLst_Sel1)
{
arrCMProjectObjLst_Sel.Add(obj);
}
if (arrCMProjectObjLst_Sel.Count > 0)
{
return arrCMProjectObjLst_Sel[0].CmPrjName;
}
string strErrMsgForGetObjById = string.Format("在CMProject对象缓存列表中,找不到记录的相关名称[CmPrjId = {0}](函数:{1})", strCmPrjId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMProjectBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectEN> GetObjLst(string strWhereCond)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
public static List<clsCMProjectEN> GetObjLstByCmPrjIdLst(List<string> arrCmPrjId)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
 /// <param name = "arrCmPrjId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCMProjectEN> GetObjLstByCmPrjIdLstCache(List<string> arrCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
List<clsCMProjectEN> arrCMProjectObjLstCache = GetObjLstCache();
IEnumerable <clsCMProjectEN> arrCMProjectObjLst_Sel =
from objCMProjectEN in arrCMProjectObjLstCache
where arrCmPrjId.Contains(objCMProjectEN.CmPrjId)
select objCMProjectEN;
return arrCMProjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
public static List<clsCMProjectEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
public static List<clsCMProjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
public static List<clsCMProjectEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMProjectEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectEN>>(strJson);
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
public static int DelRecord(string strCmPrjId)
{
string strAction = "DelRecord";
try
{
 clsCMProjectEN objCMProjectEN = clsCMProjectWApi.GetObjByCmPrjId(strCmPrjId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCmPrjId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMProjectWApi.ReFreshCache();
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
public static int DelCMProjects(List<string> arrCmPrjId)
{
string strAction = "DelCMProjects";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmPrjId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMProjectWApi.ReFreshCache();
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
public static int DelCMProjectsByCond(string strWhereCond)
{
string strAction = "DelCMProjectsByCond";
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
public static bool AddNewRecord(clsCMProjectEN objCMProjectEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectEN>(objCMProjectEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCMProjectEN objCMProjectEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectEN>(objCMProjectEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectWApi.ReFreshCache();
var strCmPrjId = (string)jobjReturn0["returnStr"];
return strCmPrjId;
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
public static bool UpdateRecord(clsCMProjectEN objCMProjectEN)
{
if (string.IsNullOrEmpty(objCMProjectEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectEN.CmPrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectEN>(objCMProjectEN);
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
 /// <param name = "objCMProjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMProjectEN objCMProjectEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMProjectEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectEN.CmPrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectEN.CmPrjId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectEN>(objCMProjectEN);
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
 /// <param name = "objCMProjectENS">源对象</param>
 /// <param name = "objCMProjectENT">目标对象</param>
 public static void CopyTo(clsCMProjectEN objCMProjectENS, clsCMProjectEN objCMProjectENT)
{
try
{
objCMProjectENT.CmPrjId = objCMProjectENS.CmPrjId; //Cm工程Id
objCMProjectENT.CmPrjName = objCMProjectENS.CmPrjName; //CM工程名
objCMProjectENT.PrjId = objCMProjectENS.PrjId; //工程Id
objCMProjectENT.ApplicationTypeId = objCMProjectENS.ApplicationTypeId; //应用程序类型ID
objCMProjectENT.FunctionTemplateId = objCMProjectENS.FunctionTemplateId; //函数模板Id
objCMProjectENT.VueDesignSysId = objCMProjectENS.VueDesignSysId; //Vue控件设计体系Id
objCMProjectENT.IsFstLcase = objCMProjectENS.IsFstLcase; //是否首字母小写
objCMProjectENT.IsCamelCase = objCMProjectENS.IsCamelCase; //是否使用CamelCase
objCMProjectENT.ProjectFileName = objCMProjectENS.ProjectFileName; //工程文件名
objCMProjectENT.UseStateId = objCMProjectENS.UseStateId; //使用状态Id
objCMProjectENT.IsRefresh4RelaView = objCMProjectENS.IsRefresh4RelaView; //是否刷新相关视图
objCMProjectENT.UpdDate = objCMProjectENS.UpdDate; //修改日期
objCMProjectENT.UpdUserId = objCMProjectENS.UpdUserId; //修改用户Id
objCMProjectENT.Memo = objCMProjectENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCMProjectEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMProjectEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMProjectEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMProjectEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMProjectEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMProjectEN._AttributeName)
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
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
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
if (clsCMProjectWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMProjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMProjectWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCMProjectEN._CurrTabName;
List<clsCMProjectEN> arrCMProjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMProjectObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMProjectEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMProject.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMProject.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.VueDesignSysId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.IsFstLcase, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMProject.IsCamelCase, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMProject.ProjectFileName, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.UseStateId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.IsRefresh4RelaView, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMProject.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProject.Memo, Type.GetType("System.String"));
foreach (clsCMProjectEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMProject.CmPrjId] = objInFor[conCMProject.CmPrjId];
objDR[conCMProject.CmPrjName] = objInFor[conCMProject.CmPrjName];
objDR[conCMProject.PrjId] = objInFor[conCMProject.PrjId];
objDR[conCMProject.ApplicationTypeId] = objInFor[conCMProject.ApplicationTypeId];
objDR[conCMProject.FunctionTemplateId] = objInFor[conCMProject.FunctionTemplateId];
objDR[conCMProject.VueDesignSysId] = objInFor[conCMProject.VueDesignSysId];
objDR[conCMProject.IsFstLcase] = objInFor[conCMProject.IsFstLcase];
objDR[conCMProject.IsCamelCase] = objInFor[conCMProject.IsCamelCase];
objDR[conCMProject.ProjectFileName] = objInFor[conCMProject.ProjectFileName];
objDR[conCMProject.UseStateId] = objInFor[conCMProject.UseStateId];
objDR[conCMProject.IsRefresh4RelaView] = objInFor[conCMProject.IsRefresh4RelaView];
objDR[conCMProject.UpdDate] = objInFor[conCMProject.UpdDate];
objDR[conCMProject.UpdUserId] = objInFor[conCMProject.UpdUserId];
objDR[conCMProject.Memo] = objInFor[conCMProject.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM项目(CMProject)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMProject : clsCommFun4BL
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
clsCMProjectWApi.ReFreshThisCache();
}
}

}