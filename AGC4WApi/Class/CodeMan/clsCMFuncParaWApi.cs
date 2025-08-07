
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFuncParaWApi
 表名:CMFuncPara(00050503)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:46
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
public static class  clsCMFuncParaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFuncParaId">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetCmFuncParaId(this clsCMFuncParaEN objCMFuncParaEN, string strCmFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, conCMFuncPara.CmFuncParaId);
objCMFuncParaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.CmFuncParaId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.CmFuncParaId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.CmFuncParaId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaName(this clsCMFuncParaEN objCMFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, conCMFuncPara.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, conCMFuncPara.ParaName);
objCMFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaComments">参数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaComments(this clsCMFuncParaEN objCMFuncParaEN, string strParaComments, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParaComments, 500, conCMFuncPara.ParaComments);
objCMFuncParaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaComments) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaComments, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaComments] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParameterType(this clsCMFuncParaEN objCMFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParameterType, conCMFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(strParameterType, 100, conCMFuncPara.ParameterType);
objCMFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParameterType) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParameterType, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParameterType] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetDataTypeId(this clsCMFuncParaEN objCMFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conCMFuncPara.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conCMFuncPara.DataTypeId);
objCMFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.DataTypeId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.DataTypeId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.DataTypeId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParameterTypeFullName(this clsCMFuncParaEN objCMFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, conCMFuncPara.ParameterTypeFullName);
objCMFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParameterTypeFullName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetIsByRef(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, conCMFuncPara.IsByRef);
objCMFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.IsByRef) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.IsByRef, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.IsByRef] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetParaCnName(this clsCMFuncParaEN objCMFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, conCMFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, conCMFuncPara.ParaCnName);
objCMFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.ParaCnName) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.ParaCnName, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.ParaCnName] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetIsKnownType(this clsCMFuncParaEN objCMFuncParaEN, bool bolIsKnownType, string strComparisonOp="")
	{
objCMFuncParaEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.IsKnownType) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.IsKnownType, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.IsKnownType] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetPrjId(this clsCMFuncParaEN objCMFuncParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMFuncPara.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMFuncPara.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMFuncPara.PrjId);
objCMFuncParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.PrjId) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.PrjId, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.PrjId] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetUpdDate(this clsCMFuncParaEN objCMFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFuncPara.UpdDate);
objCMFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.UpdDate) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.UpdDate, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.UpdDate] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetUpdUser(this clsCMFuncParaEN objCMFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFuncPara.UpdUser);
objCMFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.UpdUser) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.UpdUser, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.UpdUser] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFuncParaEN SetMemo(this clsCMFuncParaEN objCMFuncParaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFuncPara.Memo);
objCMFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFuncParaEN.dicFldComparisonOp.ContainsKey(conCMFuncPara.Memo) == false)
{
objCMFuncParaEN.dicFldComparisonOp.Add(conCMFuncPara.Memo, strComparisonOp);
}
else
{
objCMFuncParaEN.dicFldComparisonOp[conCMFuncPara.Memo] = strComparisonOp;
}
}
return objCMFuncParaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFuncParaEN objCMFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.CmFuncParaId, objCMFuncParaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaName, objCMFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaComments) == true)
{
string strComparisonOpParaComments = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaComments, objCMFuncParaCond.ParaComments, strComparisonOpParaComments);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParameterType, objCMFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.DataTypeId, objCMFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParameterTypeFullName, objCMFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.IsByRef) == true)
{
if (objCMFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFuncPara.IsByRef);
}
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.ParaCnName, objCMFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.IsKnownType) == true)
{
if (objCMFuncParaCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFuncPara.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFuncPara.IsKnownType);
}
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.PrjId) == true)
{
string strComparisonOpPrjId = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.PrjId, objCMFuncParaCond.PrjId, strComparisonOpPrjId);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.UpdDate, objCMFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.UpdUser, objCMFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFuncParaCond.IsUpdated(conCMFuncPara.Memo) == true)
{
string strComparisonOpMemo = objCMFuncParaCond.dicFldComparisonOp[conCMFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFuncPara.Memo, objCMFuncParaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFuncParaEN objCMFuncParaEN)
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMFuncParaEN.sfUpdFldSetStr = objCMFuncParaEN.getsfUpdFldSetStr();
clsCMFuncParaWApi.CheckPropertyNew(objCMFuncParaEN); 
bool bolResult = clsCMFuncParaWApi.UpdateRecord(objCMFuncParaEN);
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
 /// 获取唯一性条件串--CMFuncPara(CM函数参数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ParaName_DataTypeId_ParameterType
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFuncParaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMFuncParaEN objCMFuncParaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFuncParaEN == null) return "";
if (objCMFuncParaEN.CmFuncParaId == null || objCMFuncParaEN.CmFuncParaId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFuncParaId !=  '{0}'", objCMFuncParaEN.CmFuncParaId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objCMFuncParaEN.ParaName);
 sbCondition.AppendFormat(" and DataTypeId = '{0}'", objCMFuncParaEN.DataTypeId);
 sbCondition.AppendFormat(" and ParameterType = '{0}'", objCMFuncParaEN.ParameterType);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objCMFuncParaEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFuncParaEN objCMFuncParaEN)
{
try
{
 if (string.IsNullOrEmpty(objCMFuncParaEN.CmFuncParaId) == true || clsCMFuncParaWApi.IsExist(objCMFuncParaEN.CmFuncParaId) == true)
 {
     objCMFuncParaEN.CmFuncParaId = clsCMFuncParaWApi.GetMaxStrId();
 }
clsCMFuncParaWApi.CheckPropertyNew(objCMFuncParaEN); 
bool bolResult = clsCMFuncParaWApi.AddNewRecord(objCMFuncParaEN);
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
 /// <param name = "objCMFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFuncParaEN objCMFuncParaEN)
{
try
{
clsCMFuncParaWApi.CheckPropertyNew(objCMFuncParaEN); 
string strCmFuncParaId = clsCMFuncParaWApi.AddNewRecordWithMaxId(objCMFuncParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strCmFuncParaId;
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFuncParaEN objCMFuncParaEN, string strWhereCond)
{
try
{
clsCMFuncParaWApi.CheckPropertyNew(objCMFuncParaEN); 
bool bolResult = clsCMFuncParaWApi.UpdateWithCondition(objCMFuncParaEN, strWhereCond);
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
 /// CM函数参数(CMFuncPara)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMFuncParaWApi
{
private static readonly string mstrApiControllerName = "CMFuncParaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCMFuncParaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMFuncParaEN objCMFuncParaEN)
{
if (!Object.Equals(null, objCMFuncParaEN.CmFuncParaId) && GetStrLen(objCMFuncParaEN.CmFuncParaId) > 8)
{
 throw new Exception("字段[函数参数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFuncParaEN.ParaName) && GetStrLen(objCMFuncParaEN.ParaName) > 50)
{
 throw new Exception("字段[参数名]的长度不能超过50!");
}
if (!Object.Equals(null, objCMFuncParaEN.ParaComments) && GetStrLen(objCMFuncParaEN.ParaComments) > 500)
{
 throw new Exception("字段[参数注释]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFuncParaEN.ParameterType) && GetStrLen(objCMFuncParaEN.ParameterType) > 100)
{
 throw new Exception("字段[参数类型]的长度不能超过100!");
}
if (!Object.Equals(null, objCMFuncParaEN.DataTypeId) && GetStrLen(objCMFuncParaEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCMFuncParaEN.ParameterTypeFullName) && GetStrLen(objCMFuncParaEN.ParameterTypeFullName) > 500)
{
 throw new Exception("字段[参数类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFuncParaEN.ParaCnName) && GetStrLen(objCMFuncParaEN.ParaCnName) > 50)
{
 throw new Exception("字段[参数中文名]的长度不能超过50!");
}
if (!Object.Equals(null, objCMFuncParaEN.PrjId) && GetStrLen(objCMFuncParaEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMFuncParaEN.UpdDate) && GetStrLen(objCMFuncParaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFuncParaEN.UpdUser) && GetStrLen(objCMFuncParaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFuncParaEN.Memo) && GetStrLen(objCMFuncParaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCMFuncParaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
if (strCmFuncParaId == "") return null;
string strAction = "GetObjByCmFuncParaId";
clsCMFuncParaEN objCMFuncParaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFuncParaId"] = strCmFuncParaId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMFuncParaEN = JsonConvert.DeserializeObject<clsCMFuncParaEN>(strJson);
return objCMFuncParaEN;
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
public static clsCMFuncParaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMFuncParaEN objCMFuncParaEN;
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
objCMFuncParaEN = JsonConvert.DeserializeObject<clsCMFuncParaEN>(strJson);
return objCMFuncParaEN;
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
public static List<clsCMFuncParaEN> GetObjLst(string strWhereCond)
{
 List<clsCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
 /// <param name = "arrCmFuncParaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFuncParaEN> GetObjLstByCmFuncParaIdLst(List<string> arrCmFuncParaId)
{
 List<clsCMFuncParaEN> arrObjLst; 
string strAction = "GetObjLstByCmFuncParaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFuncParaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
public static List<clsCMFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
public static List<clsCMFuncParaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
public static List<clsCMFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
public static List<clsCMFuncParaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFuncParaEN>>(strJson);
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
public static int DelRecord(string strCmFuncParaId)
{
string strAction = "DelRecord";
try
{
 clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaWApi.GetObjByCmFuncParaId(strCmFuncParaId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCmFuncParaId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelCMFuncParas(List<string> arrCmFuncParaId)
{
string strAction = "DelCMFuncParas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFuncParaId);
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
public static int DelCMFuncParasByCond(string strWhereCond)
{
string strAction = "DelCMFuncParasByCond";
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
public static bool AddNewRecord(clsCMFuncParaEN objCMFuncParaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFuncParaEN>(objCMFuncParaEN);
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
public static string AddNewRecordWithMaxId(clsCMFuncParaEN objCMFuncParaEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFuncParaEN>(objCMFuncParaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strCmFuncParaId = (string)jobjReturn0["returnStr"];
return strCmFuncParaId;
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
public static bool UpdateRecord(clsCMFuncParaEN objCMFuncParaEN)
{
if (string.IsNullOrEmpty(objCMFuncParaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFuncParaEN.CmFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFuncParaEN>(objCMFuncParaEN);
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
 /// <param name = "objCMFuncParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMFuncParaEN objCMFuncParaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMFuncParaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFuncParaEN.CmFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFuncParaEN.CmFuncParaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFuncParaEN>(objCMFuncParaEN);
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
public static bool IsExist(string strCmFuncParaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFuncParaId"] = strCmFuncParaId
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
 /// <param name = "objCMFuncParaENS">源对象</param>
 /// <param name = "objCMFuncParaENT">目标对象</param>
 public static void CopyTo(clsCMFuncParaEN objCMFuncParaENS, clsCMFuncParaEN objCMFuncParaENT)
{
try
{
objCMFuncParaENT.CmFuncParaId = objCMFuncParaENS.CmFuncParaId; //函数参数Id
objCMFuncParaENT.ParaName = objCMFuncParaENS.ParaName; //参数名
objCMFuncParaENT.ParaComments = objCMFuncParaENS.ParaComments; //参数注释
objCMFuncParaENT.ParameterType = objCMFuncParaENS.ParameterType; //参数类型
objCMFuncParaENT.DataTypeId = objCMFuncParaENS.DataTypeId; //数据类型Id
objCMFuncParaENT.ParameterTypeFullName = objCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objCMFuncParaENT.IsByRef = objCMFuncParaENS.IsByRef; //是否引用型参数
objCMFuncParaENT.ParaCnName = objCMFuncParaENS.ParaCnName; //参数中文名
objCMFuncParaENT.IsKnownType = objCMFuncParaENS.IsKnownType; //是否已知类型
objCMFuncParaENT.PrjId = objCMFuncParaENS.PrjId; //工程Id
objCMFuncParaENT.UpdDate = objCMFuncParaENS.UpdDate; //修改日期
objCMFuncParaENT.UpdUser = objCMFuncParaENS.UpdUser; //修改者
objCMFuncParaENT.Memo = objCMFuncParaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCMFuncParaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMFuncParaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMFuncParaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMFuncParaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMFuncParaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMFuncParaEN._AttributeName)
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
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
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
if (clsCMFuncParaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFuncParaWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsCMFuncParaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMFuncPara.CmFuncParaId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.ParaComments, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFuncPara.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFuncPara.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFuncPara.Memo, Type.GetType("System.String"));
foreach (clsCMFuncParaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMFuncPara.CmFuncParaId] = objInFor[conCMFuncPara.CmFuncParaId];
objDR[conCMFuncPara.ParaName] = objInFor[conCMFuncPara.ParaName];
objDR[conCMFuncPara.ParaComments] = objInFor[conCMFuncPara.ParaComments];
objDR[conCMFuncPara.ParameterType] = objInFor[conCMFuncPara.ParameterType];
objDR[conCMFuncPara.DataTypeId] = objInFor[conCMFuncPara.DataTypeId];
objDR[conCMFuncPara.ParameterTypeFullName] = objInFor[conCMFuncPara.ParameterTypeFullName];
objDR[conCMFuncPara.IsByRef] = objInFor[conCMFuncPara.IsByRef];
objDR[conCMFuncPara.ParaCnName] = objInFor[conCMFuncPara.ParaCnName];
objDR[conCMFuncPara.IsKnownType] = objInFor[conCMFuncPara.IsKnownType];
objDR[conCMFuncPara.PrjId] = objInFor[conCMFuncPara.PrjId];
objDR[conCMFuncPara.UpdDate] = objInFor[conCMFuncPara.UpdDate];
objDR[conCMFuncPara.UpdUser] = objInFor[conCMFuncPara.UpdUser];
objDR[conCMFuncPara.Memo] = objInFor[conCMFuncPara.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM函数参数(CMFuncPara)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMFuncPara : clsCommFun4BL
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
clsCMFuncParaWApi.ReFreshThisCache();
}
}

}