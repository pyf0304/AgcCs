
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncPara4CodeWApi
 表名:FuncPara4Code(00050384)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFuncPara4CodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaId4Code">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetFuncParaId4Code(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strFuncParaId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, conFuncPara4Code.FuncParaId4Code);
objFuncPara4CodeEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.FuncParaId4Code) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.FuncParaId4Code, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.FuncParaId4Code] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParaName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conFuncPara4Code.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, conFuncPara4Code.ParaName);
objFuncPara4CodeEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParaName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParaName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParaName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParaCnName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, conFuncPara4Code.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, conFuncPara4Code.ParaCnName);
objFuncPara4CodeEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParaCnName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParaCnName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParaCnName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetDataTypeId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conFuncPara4Code.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conFuncPara4Code.DataTypeId);
objFuncPara4CodeEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.DataTypeId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.DataTypeId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.DataTypeId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParameterType(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterType, 100, conFuncPara4Code.ParameterType);
objFuncPara4CodeEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParameterType) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParameterType, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParameterType] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetParameterTypeFullName(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, conFuncPara4Code.ParameterTypeFullName);
objFuncPara4CodeEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.ParameterTypeFullName) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.ParameterTypeFullName, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.ParameterTypeFullName] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetIsByRef(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, conFuncPara4Code.IsByRef);
objFuncPara4CodeEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.IsByRef) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.IsByRef, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.IsByRef] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetPrjId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFuncPara4Code.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFuncPara4Code.PrjId);
objFuncPara4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.PrjId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.PrjId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.PrjId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetIsTemplate(this clsFuncPara4CodeEN objFuncPara4CodeEN, bool bolIsTemplate, string strComparisonOp="")
	{
objFuncPara4CodeEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.IsTemplate) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.IsTemplate, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.IsTemplate] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeId">函数用途Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetFuncPurposeId(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, conFuncPara4Code.FuncPurposeId);
objFuncPara4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.FuncPurposeId) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.FuncPurposeId, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.FuncPurposeId] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetUpdDate(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncPara4Code.UpdDate);
objFuncPara4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.UpdDate) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.UpdDate, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.UpdDate] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetUpdUser(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncPara4Code.UpdUser);
objFuncPara4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.UpdUser) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.UpdUser, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.UpdUser] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncPara4CodeEN SetMemo(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncPara4Code.Memo);
objFuncPara4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(conFuncPara4Code.Memo) == false)
{
objFuncPara4CodeEN.dicFldComparisonOp.Add(conFuncPara4Code.Memo, strComparisonOp);
}
else
{
objFuncPara4CodeEN.dicFldComparisonOp[conFuncPara4Code.Memo] = strComparisonOp;
}
}
return objFuncPara4CodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncPara4CodeEN objFuncPara4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.FuncParaId4Code, objFuncPara4CodeCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParaName) == true)
{
string strComparisonOpParaName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParaName, objFuncPara4CodeCond.ParaName, strComparisonOpParaName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParaCnName) == true)
{
string strComparisonOpParaCnName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParaCnName, objFuncPara4CodeCond.ParaCnName, strComparisonOpParaCnName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.DataTypeId, objFuncPara4CodeCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParameterType) == true)
{
string strComparisonOpParameterType = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParameterType, objFuncPara4CodeCond.ParameterType, strComparisonOpParameterType);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.ParameterTypeFullName, objFuncPara4CodeCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.IsByRef) == true)
{
if (objFuncPara4CodeCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFuncPara4Code.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFuncPara4Code.IsByRef);
}
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.PrjId) == true)
{
string strComparisonOpPrjId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.PrjId, objFuncPara4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.IsTemplate) == true)
{
if (objFuncPara4CodeCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFuncPara4Code.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFuncPara4Code.IsTemplate);
}
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.FuncPurposeId, objFuncPara4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.UpdDate, objFuncPara4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.UpdUser, objFuncPara4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncPara4CodeCond.IsUpdated(conFuncPara4Code.Memo) == true)
{
string strComparisonOpMemo = objFuncPara4CodeCond.dicFldComparisonOp[conFuncPara4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncPara4Code.Memo, objFuncPara4CodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFuncPara4CodeEN.sfUpdFldSetStr = objFuncPara4CodeEN.getsfUpdFldSetStr();
clsFuncPara4CodeWApi.CheckPropertyNew(objFuncPara4CodeEN); 
bool bolResult = clsFuncPara4CodeWApi.UpdateRecord(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--FuncPara4Code(函数参数4Code), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ParaName_DataTypeId_FuncPurposeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncPara4CodeEN == null) return "";
if (objFuncPara4CodeEN.FuncParaId4Code == null || objFuncPara4CodeEN.FuncParaId4Code == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncParaId4Code !=  '{0}'", objFuncPara4CodeEN.FuncParaId4Code);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFuncPara4CodeEN.PrjId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objFuncPara4CodeEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objFuncPara4CodeEN.DataTypeId);
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFuncPara4CodeEN.FuncPurposeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
 if (string.IsNullOrEmpty(objFuncPara4CodeEN.FuncParaId4Code) == true || clsFuncPara4CodeWApi.IsExist(objFuncPara4CodeEN.FuncParaId4Code) == true)
 {
     objFuncPara4CodeEN.FuncParaId4Code = clsFuncPara4CodeWApi.GetMaxStrId();
 }
clsFuncPara4CodeWApi.CheckPropertyNew(objFuncPara4CodeEN); 
bool bolResult = clsFuncPara4CodeWApi.AddNewRecord(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objFuncPara4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncPara4CodeEN objFuncPara4CodeEN)
{
try
{
clsFuncPara4CodeWApi.CheckPropertyNew(objFuncPara4CodeEN); 
string strFuncParaId4Code = clsFuncPara4CodeWApi.AddNewRecordWithMaxId(objFuncPara4CodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strFuncParaId4Code;
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncPara4CodeEN objFuncPara4CodeEN, string strWhereCond)
{
try
{
clsFuncPara4CodeWApi.CheckPropertyNew(objFuncPara4CodeEN); 
bool bolResult = clsFuncPara4CodeWApi.UpdateWithCondition(objFuncPara4CodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 函数参数4Code(FuncPara4Code)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFuncPara4CodeWApi
{
private static readonly string mstrApiControllerName = "FuncPara4CodeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFuncPara4CodeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncParaId4Code(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数参数4Code]...","0");
List<clsFuncPara4CodeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncParaId4Code";
objDDL.DataTextField="ParaName";
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

 /// <param name = "strFuncPurposeId"></param>
public static void BindCbo_FuncParaId4Code(System.Windows.Forms.ComboBox objComboBox , string strFuncPurposeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncPara4Code.FuncParaId4Code); 
List<clsFuncPara4CodeEN> arrObjLst = clsFuncPara4CodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FuncPurposeId == strFuncPurposeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncPara4CodeEN objFuncPara4CodeEN = new clsFuncPara4CodeEN()
{
FuncParaId4Code = "0",
ParaName = "选[函数参数4Code]..."
};
arrObjLstSel.Insert(0, objFuncPara4CodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncPara4Code.FuncParaId4Code;
objComboBox.DisplayMember = conFuncPara4Code.ParaName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
if (!Object.Equals(null, objFuncPara4CodeEN.FuncParaId4Code) && GetStrLen(objFuncPara4CodeEN.FuncParaId4Code) > 8)
{
 throw new Exception("字段[函数参数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.ParaName) && GetStrLen(objFuncPara4CodeEN.ParaName) > 50)
{
 throw new Exception("字段[参数名]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.ParaCnName) && GetStrLen(objFuncPara4CodeEN.ParaCnName) > 50)
{
 throw new Exception("字段[参数中文名]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.DataTypeId) && GetStrLen(objFuncPara4CodeEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.ParameterType) && GetStrLen(objFuncPara4CodeEN.ParameterType) > 100)
{
 throw new Exception("字段[参数类型]的长度不能超过100!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.ParameterTypeFullName) && GetStrLen(objFuncPara4CodeEN.ParameterTypeFullName) > 500)
{
 throw new Exception("字段[参数类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.PrjId) && GetStrLen(objFuncPara4CodeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.FuncPurposeId) && GetStrLen(objFuncPara4CodeEN.FuncPurposeId) > 2)
{
 throw new Exception("字段[函数用途Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.UpdDate) && GetStrLen(objFuncPara4CodeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.UpdUser) && GetStrLen(objFuncPara4CodeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncPara4CodeEN.Memo) && GetStrLen(objFuncPara4CodeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFuncPara4CodeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
if (strFuncParaId4Code == "") return null;
string strAction = "GetObjByFuncParaId4Code";
clsFuncPara4CodeEN objFuncPara4CodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncParaId4Code"] = strFuncParaId4Code,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFuncPara4CodeEN = JsonConvert.DeserializeObject<clsFuncPara4CodeEN>(strJson);
return objFuncPara4CodeEN;
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
public static clsFuncPara4CodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFuncPara4CodeEN objFuncPara4CodeEN;
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
objFuncPara4CodeEN = JsonConvert.DeserializeObject<clsFuncPara4CodeEN>(strJson);
return objFuncPara4CodeEN;
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
//该表没有使用Cache,不需要生成[GetParaNameByFuncParaId4CodeCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLst(string strWhereCond)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
 /// <param name = "arrFuncParaId4Code">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLst(List<string> arrFuncParaId4Code)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
string strAction = "GetObjLstByFuncParaId4CodeLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncParaId4Code);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
public static List<clsFuncPara4CodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
public static List<clsFuncPara4CodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
public static List<clsFuncPara4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
public static List<clsFuncPara4CodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFuncPara4CodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncPara4CodeEN>>(strJson);
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
public static int DelRecord(string strFuncParaId4Code)
{
string strAction = "DelRecord";
try
{
 clsFuncPara4CodeEN objFuncPara4CodeEN = clsFuncPara4CodeWApi.GetObjByFuncParaId4Code(strFuncParaId4Code);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncParaId4Code.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelFuncPara4Codes(List<string> arrFuncParaId4Code)
{
string strAction = "DelFuncPara4Codes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncParaId4Code);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFuncPara4CodesByCond(string strWhereCond)
{
string strAction = "DelFuncPara4CodesByCond";
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
public static bool AddNewRecord(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncPara4CodeEN>(objFuncPara4CodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static string AddNewRecordWithMaxId(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncPara4CodeEN>(objFuncPara4CodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strFuncParaId4Code = (string)jobjReturn0["returnStr"];
return strFuncParaId4Code;
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
public static bool UpdateRecord(clsFuncPara4CodeEN objFuncPara4CodeEN)
{
if (string.IsNullOrEmpty(objFuncPara4CodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncPara4CodeEN.FuncParaId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncPara4CodeEN>(objFuncPara4CodeEN);
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
 /// <param name = "objFuncPara4CodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFuncPara4CodeEN objFuncPara4CodeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFuncPara4CodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncPara4CodeEN.FuncParaId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncPara4CodeEN.FuncParaId4Code, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncPara4CodeEN>(objFuncPara4CodeEN);
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
public static bool IsExist(string strFuncParaId4Code)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncParaId4Code"] = strFuncParaId4Code
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
 /// <param name = "objFuncPara4CodeENS">源对象</param>
 /// <param name = "objFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(clsFuncPara4CodeEN objFuncPara4CodeENS, clsFuncPara4CodeEN objFuncPara4CodeENT)
{
try
{
objFuncPara4CodeENT.FuncParaId4Code = objFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objFuncPara4CodeENT.ParaName = objFuncPara4CodeENS.ParaName; //参数名
objFuncPara4CodeENT.ParaCnName = objFuncPara4CodeENS.ParaCnName; //参数中文名
objFuncPara4CodeENT.DataTypeId = objFuncPara4CodeENS.DataTypeId; //数据类型Id
objFuncPara4CodeENT.ParameterType = objFuncPara4CodeENS.ParameterType; //参数类型
objFuncPara4CodeENT.ParameterTypeFullName = objFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objFuncPara4CodeENT.IsByRef = objFuncPara4CodeENS.IsByRef; //是否引用型参数
objFuncPara4CodeENT.PrjId = objFuncPara4CodeENS.PrjId; //工程Id
objFuncPara4CodeENT.IsTemplate = objFuncPara4CodeENS.IsTemplate; //是否模板
objFuncPara4CodeENT.FuncPurposeId = objFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objFuncPara4CodeENT.UpdDate = objFuncPara4CodeENS.UpdDate; //修改日期
objFuncPara4CodeENT.UpdUser = objFuncPara4CodeENS.UpdUser; //修改者
objFuncPara4CodeENT.Memo = objFuncPara4CodeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFuncPara4CodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFuncPara4CodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFuncPara4CodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFuncPara4CodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFuncPara4CodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFuncPara4CodeEN._AttributeName)
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
public static void ReFreshThisCache(string strFuncPurposeId = "")
{


if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空！(In clsFuncPara4CodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确！(clsFuncPara4CodeWApi.ReFreshThisCache)", strFuncPurposeId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
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
public static void ReFreshCache(string strFuncPurposeId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFuncPara4CodeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
CacheHelper.Remove(strKey);
clsFuncPara4CodeWApi.objCommFun4WApi.ReFreshCache(strFuncPurposeId.ToString());
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
public static DataTable GetDataTableByObjLst(List<clsFuncPara4CodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFuncPara4Code.FuncParaId4Code, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFuncPara4Code.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFuncPara4Code.FuncPurposeId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFuncPara4Code.Memo, Type.GetType("System.String"));
foreach (clsFuncPara4CodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFuncPara4Code.FuncParaId4Code] = objInFor[conFuncPara4Code.FuncParaId4Code];
objDR[conFuncPara4Code.ParaName] = objInFor[conFuncPara4Code.ParaName];
objDR[conFuncPara4Code.ParaCnName] = objInFor[conFuncPara4Code.ParaCnName];
objDR[conFuncPara4Code.DataTypeId] = objInFor[conFuncPara4Code.DataTypeId];
objDR[conFuncPara4Code.ParameterType] = objInFor[conFuncPara4Code.ParameterType];
objDR[conFuncPara4Code.ParameterTypeFullName] = objInFor[conFuncPara4Code.ParameterTypeFullName];
objDR[conFuncPara4Code.IsByRef] = objInFor[conFuncPara4Code.IsByRef];
objDR[conFuncPara4Code.PrjId] = objInFor[conFuncPara4Code.PrjId];
objDR[conFuncPara4Code.IsTemplate] = objInFor[conFuncPara4Code.IsTemplate];
objDR[conFuncPara4Code.FuncPurposeId] = objInFor[conFuncPara4Code.FuncPurposeId];
objDR[conFuncPara4Code.UpdDate] = objInFor[conFuncPara4Code.UpdDate];
objDR[conFuncPara4Code.UpdUser] = objInFor[conFuncPara4Code.UpdUser];
objDR[conFuncPara4Code.Memo] = objInFor[conFuncPara4Code.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数参数4Code(FuncPara4Code)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FuncPara4Code : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strFuncPurposeId)
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
clsFuncPara4CodeWApi.ReFreshThisCache(strFuncPurposeId);
}
}

}