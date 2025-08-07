
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFuncParaWApi
 表名:WebSrvFuncPara(00050347)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsWebSrvFuncParaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFuncParaId">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetWebSrvFuncParaId(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strWebSrvFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvFuncParaId, 8, conWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFuncParaId, 8, conWebSrvFuncPara.WebSrvFuncParaId);
objWebSrvFuncParaEN.WebSrvFuncParaId = strWebSrvFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.WebSrvFuncParaId) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.WebSrvFuncParaId, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.WebSrvFuncParaId] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetWebSrvFunctionId(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvFunctionId, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, conWebSrvFuncPara.WebSrvFunctionId);
objWebSrvFuncParaEN.WebSrvFunctionId = strWebSrvFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.WebSrvFunctionId) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.WebSrvFunctionId, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.WebSrvFunctionId] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetDataTypeId(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conWebSrvFuncPara.DataTypeId);
objWebSrvFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.DataTypeId) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.DataTypeId, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.DataTypeId] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetParameterType(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParameterType, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(strParameterType, 100, conWebSrvFuncPara.ParameterType);
objWebSrvFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.ParameterType) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.ParameterType, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.ParameterType] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetParameterTypeFullName(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, conWebSrvFuncPara.ParameterTypeFullName);
objWebSrvFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.ParameterTypeFullName) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetIsByRef(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, conWebSrvFuncPara.IsByRef);
objWebSrvFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.IsByRef) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.IsByRef, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.IsByRef] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetParaName(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, conWebSrvFuncPara.ParaName);
objWebSrvFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.ParaName) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.ParaName, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.ParaName] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetParaCnName(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, conWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, conWebSrvFuncPara.ParaCnName);
objWebSrvFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.ParaCnName) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.ParaCnName, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.ParaCnName] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetIsKnownType(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, bool bolIsKnownType, string strComparisonOp="")
	{
objWebSrvFuncParaEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.IsKnownType) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.IsKnownType, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.IsKnownType] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetUpdDate(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWebSrvFuncPara.UpdDate);
objWebSrvFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.UpdDate) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.UpdDate, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.UpdDate] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetUpdUser(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conWebSrvFuncPara.UpdUser);
objWebSrvFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.UpdUser) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.UpdUser, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.UpdUser] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFuncParaEN SetMemo(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWebSrvFuncPara.Memo);
objWebSrvFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(conWebSrvFuncPara.Memo) == false)
{
objWebSrvFuncParaEN.dicFldComparisonOp.Add(conWebSrvFuncPara.Memo, strComparisonOp);
}
else
{
objWebSrvFuncParaEN.dicFldComparisonOp[conWebSrvFuncPara.Memo] = strComparisonOp;
}
}
return objWebSrvFuncParaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWebSrvFuncParaEN objWebSrvFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.WebSrvFuncParaId) == true)
{
string strComparisonOpWebSrvFuncParaId = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.WebSrvFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.WebSrvFuncParaId, objWebSrvFuncParaCond.WebSrvFuncParaId, strComparisonOpWebSrvFuncParaId);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId) == true)
{
string strComparisonOpWebSrvFunctionId = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.WebSrvFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.WebSrvFunctionId, objWebSrvFuncParaCond.WebSrvFunctionId, strComparisonOpWebSrvFunctionId);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.DataTypeId, objWebSrvFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.ParameterType, objWebSrvFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.ParameterTypeFullName, objWebSrvFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.IsByRef) == true)
{
if (objWebSrvFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFuncPara.IsByRef);
}
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.ParaName, objWebSrvFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.ParaCnName, objWebSrvFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.IsKnownType) == true)
{
if (objWebSrvFuncParaCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFuncPara.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFuncPara.IsKnownType);
}
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.UpdDate, objWebSrvFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.UpdUser, objWebSrvFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objWebSrvFuncParaCond.IsUpdated(conWebSrvFuncPara.Memo) == true)
{
string strComparisonOpMemo = objWebSrvFuncParaCond.dicFldComparisonOp[conWebSrvFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFuncPara.Memo, objWebSrvFuncParaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
 if (string.IsNullOrEmpty(objWebSrvFuncParaEN.WebSrvFuncParaId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objWebSrvFuncParaEN.sfUpdFldSetStr = objWebSrvFuncParaEN.getsfUpdFldSetStr();
clsWebSrvFuncParaWApi.CheckPropertyNew(objWebSrvFuncParaEN); 
bool bolResult = clsWebSrvFuncParaWApi.UpdateRecord(objWebSrvFuncParaEN);
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
 /// 获取唯一性条件串--WebSrvFuncPara(WebSrv函数参数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:WebSrvFunctionId_ParaName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvFuncParaEN == null) return "";
if (objWebSrvFuncParaEN.WebSrvFuncParaId == null || objWebSrvFuncParaEN.WebSrvFuncParaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WebSrvFunctionId = '{0}'", objWebSrvFuncParaEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objWebSrvFuncParaEN.ParaName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WebSrvFuncParaId !=  '{0}'", objWebSrvFuncParaEN.WebSrvFuncParaId);
 sbCondition.AppendFormat(" and WebSrvFunctionId = '{0}'", objWebSrvFuncParaEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objWebSrvFuncParaEN.ParaName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
try
{
 if (string.IsNullOrEmpty(objWebSrvFuncParaEN.WebSrvFuncParaId) == true || clsWebSrvFuncParaWApi.IsExist(objWebSrvFuncParaEN.WebSrvFuncParaId) == true)
 {
     objWebSrvFuncParaEN.WebSrvFuncParaId = clsWebSrvFuncParaWApi.GetMaxStrId();
 }
clsWebSrvFuncParaWApi.CheckPropertyNew(objWebSrvFuncParaEN); 
bool bolResult = clsWebSrvFuncParaWApi.AddNewRecord(objWebSrvFuncParaEN);
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
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
try
{
clsWebSrvFuncParaWApi.CheckPropertyNew(objWebSrvFuncParaEN); 
string strWebSrvFuncParaId = clsWebSrvFuncParaWApi.AddNewRecordWithMaxId(objWebSrvFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strWebSrvFuncParaId;
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
 /// <param name = "objWebSrvFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strWhereCond)
{
try
{
clsWebSrvFuncParaWApi.CheckPropertyNew(objWebSrvFuncParaEN); 
bool bolResult = clsWebSrvFuncParaWApi.UpdateWithCondition(objWebSrvFuncParaEN, strWhereCond);
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
 /// WebSrv函数参数(WebSrvFuncPara)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsWebSrvFuncParaWApi
{
private static readonly string mstrApiControllerName = "WebSrvFuncParaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsWebSrvFuncParaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
if (!Object.Equals(null, objWebSrvFuncParaEN.WebSrvFuncParaId) && GetStrLen(objWebSrvFuncParaEN.WebSrvFuncParaId) > 8)
{
 throw new Exception("字段[函数参数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.WebSrvFunctionId) && GetStrLen(objWebSrvFuncParaEN.WebSrvFunctionId) > 8)
{
 throw new Exception("字段[函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.DataTypeId) && GetStrLen(objWebSrvFuncParaEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.ParameterType) && GetStrLen(objWebSrvFuncParaEN.ParameterType) > 100)
{
 throw new Exception("字段[参数类型]的长度不能超过100!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.ParameterTypeFullName) && GetStrLen(objWebSrvFuncParaEN.ParameterTypeFullName) > 500)
{
 throw new Exception("字段[参数类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.ParaName) && GetStrLen(objWebSrvFuncParaEN.ParaName) > 50)
{
 throw new Exception("字段[参数名]的长度不能超过50!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.ParaCnName) && GetStrLen(objWebSrvFuncParaEN.ParaCnName) > 50)
{
 throw new Exception("字段[参数中文名]的长度不能超过50!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.UpdDate) && GetStrLen(objWebSrvFuncParaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.UpdUser) && GetStrLen(objWebSrvFuncParaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objWebSrvFuncParaEN.Memo) && GetStrLen(objWebSrvFuncParaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objWebSrvFuncParaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvFuncParaEN GetObjByWebSrvFuncParaId(string strWebSrvFuncParaId)
{
if (strWebSrvFuncParaId == "") return null;
string strAction = "GetObjByWebSrvFuncParaId";
clsWebSrvFuncParaEN objWebSrvFuncParaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvFuncParaId"] = strWebSrvFuncParaId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objWebSrvFuncParaEN = JsonConvert.DeserializeObject<clsWebSrvFuncParaEN>(strJson);
return objWebSrvFuncParaEN;
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
public static clsWebSrvFuncParaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsWebSrvFuncParaEN objWebSrvFuncParaEN;
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
objWebSrvFuncParaEN = JsonConvert.DeserializeObject<clsWebSrvFuncParaEN>(strJson);
return objWebSrvFuncParaEN;
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
public static List<clsWebSrvFuncParaEN> GetObjLst(string strWhereCond)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
 /// <param name = "arrWebSrvFuncParaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFuncParaEN> GetObjLstByWebSrvFuncParaIdLst(List<string> arrWebSrvFuncParaId)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
string strAction = "GetObjLstByWebSrvFuncParaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWebSrvFuncParaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
public static List<clsWebSrvFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
public static List<clsWebSrvFuncParaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
public static List<clsWebSrvFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
public static List<clsWebSrvFuncParaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsWebSrvFuncParaEN>>(strJson);
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
public static int DelRecord(string strWebSrvFuncParaId)
{
string strAction = "DelRecord";
try
{
 clsWebSrvFuncParaEN objWebSrvFuncParaEN = clsWebSrvFuncParaWApi.GetObjByWebSrvFuncParaId(strWebSrvFuncParaId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strWebSrvFuncParaId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelWebSrvFuncParas(List<string> arrWebSrvFuncParaId)
{
string strAction = "DelWebSrvFuncParas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWebSrvFuncParaId);
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
public static int DelWebSrvFuncParasByCond(string strWhereCond)
{
string strAction = "DelWebSrvFuncParasByCond";
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
public static bool AddNewRecord(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFuncParaEN>(objWebSrvFuncParaEN);
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
public static string AddNewRecordWithMaxId(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFuncParaEN>(objWebSrvFuncParaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strWebSrvFuncParaId = (string)jobjReturn0["returnStr"];
return strWebSrvFuncParaId;
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
public static bool UpdateRecord(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
if (string.IsNullOrEmpty(objWebSrvFuncParaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFuncParaEN.WebSrvFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFuncParaEN>(objWebSrvFuncParaEN);
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
 /// <param name = "objWebSrvFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objWebSrvFuncParaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFuncParaEN.WebSrvFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objWebSrvFuncParaEN.WebSrvFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsWebSrvFuncParaEN>(objWebSrvFuncParaEN);
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
public static bool IsExist(string strWebSrvFuncParaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvFuncParaId"] = strWebSrvFuncParaId
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
 /// <param name = "objWebSrvFuncParaENS">源对象</param>
 /// <param name = "objWebSrvFuncParaENT">目标对象</param>
 public static void CopyTo(clsWebSrvFuncParaEN objWebSrvFuncParaENS, clsWebSrvFuncParaEN objWebSrvFuncParaENT)
{
try
{
objWebSrvFuncParaENT.WebSrvFuncParaId = objWebSrvFuncParaENS.WebSrvFuncParaId; //函数参数Id
objWebSrvFuncParaENT.WebSrvFunctionId = objWebSrvFuncParaENS.WebSrvFunctionId; //函数Id
objWebSrvFuncParaENT.DataTypeId = objWebSrvFuncParaENS.DataTypeId; //数据类型Id
objWebSrvFuncParaENT.ParameterType = objWebSrvFuncParaENS.ParameterType; //参数类型
objWebSrvFuncParaENT.ParameterTypeFullName = objWebSrvFuncParaENS.ParameterTypeFullName; //参数类型全名
objWebSrvFuncParaENT.IsByRef = objWebSrvFuncParaENS.IsByRef; //是否引用型参数
objWebSrvFuncParaENT.ParaName = objWebSrvFuncParaENS.ParaName; //参数名
objWebSrvFuncParaENT.ParaCnName = objWebSrvFuncParaENS.ParaCnName; //参数中文名
objWebSrvFuncParaENT.IsKnownType = objWebSrvFuncParaENS.IsKnownType; //是否已知类型
objWebSrvFuncParaENT.UpdDate = objWebSrvFuncParaENS.UpdDate; //修改日期
objWebSrvFuncParaENT.UpdUser = objWebSrvFuncParaENS.UpdUser; //修改者
objWebSrvFuncParaENT.Memo = objWebSrvFuncParaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsWebSrvFuncParaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsWebSrvFuncParaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsWebSrvFuncParaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsWebSrvFuncParaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsWebSrvFuncParaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsWebSrvFuncParaEN._AttributeName)
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
string strKey = string.Format("{0}", clsWebSrvFuncParaEN._CurrTabName);
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
if (clsWebSrvFuncParaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWebSrvFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebSrvFuncParaWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsWebSrvFuncParaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conWebSrvFuncPara.WebSrvFuncParaId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.WebSrvFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFuncPara.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conWebSrvFuncPara.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conWebSrvFuncPara.Memo, Type.GetType("System.String"));
foreach (clsWebSrvFuncParaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conWebSrvFuncPara.WebSrvFuncParaId] = objInFor[conWebSrvFuncPara.WebSrvFuncParaId];
objDR[conWebSrvFuncPara.WebSrvFunctionId] = objInFor[conWebSrvFuncPara.WebSrvFunctionId];
objDR[conWebSrvFuncPara.DataTypeId] = objInFor[conWebSrvFuncPara.DataTypeId];
objDR[conWebSrvFuncPara.ParameterType] = objInFor[conWebSrvFuncPara.ParameterType];
objDR[conWebSrvFuncPara.ParameterTypeFullName] = objInFor[conWebSrvFuncPara.ParameterTypeFullName];
objDR[conWebSrvFuncPara.IsByRef] = objInFor[conWebSrvFuncPara.IsByRef];
objDR[conWebSrvFuncPara.ParaName] = objInFor[conWebSrvFuncPara.ParaName];
objDR[conWebSrvFuncPara.ParaCnName] = objInFor[conWebSrvFuncPara.ParaCnName];
objDR[conWebSrvFuncPara.IsKnownType] = objInFor[conWebSrvFuncPara.IsKnownType];
objDR[conWebSrvFuncPara.UpdDate] = objInFor[conWebSrvFuncPara.UpdDate];
objDR[conWebSrvFuncPara.UpdUser] = objInFor[conWebSrvFuncPara.UpdUser];
objDR[conWebSrvFuncPara.Memo] = objInFor[conWebSrvFuncPara.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// WebSrv函数参数(WebSrvFuncPara)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4WebSrvFuncPara : clsCommFun4BL
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
clsWebSrvFuncParaWApi.ReFreshThisCache();
}
}

}