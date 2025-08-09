
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionWApi
 表名:CMFunction(00050502)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:17
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
public static class  clsCMFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetCmFunctionId(this clsCMFunctionEN objCMFunctionEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, conCMFunction.CmFunctionId);
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, conCMFunction.CmFunctionId);
objCMFunctionEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.CmFunctionId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.CmFunctionId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.CmFunctionId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetCmClassId(this clsCMFunctionEN objCMFunctionEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, conCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(strCmClassId, 8, conCMFunction.CmClassId);
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, conCMFunction.CmClassId);
objCMFunctionEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.CmClassId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.CmClassId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.CmClassId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFunctionName(this clsCMFunctionEN objCMFunctionEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conCMFunction.FunctionName);
clsCheckSql.CheckFieldLen(strFunctionName, 200, conCMFunction.FunctionName);
objCMFunctionEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FunctionName) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FunctionName, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FunctionName] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncContent">函数内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncContent(this clsCMFunctionEN objCMFunctionEN, string strFuncContent, string strComparisonOp="")
	{
objCMFunctionEN.FuncContent = strFuncContent; //函数内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncContent) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncContent, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncContent] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetKeyWords(this clsCMFunctionEN objCMFunctionEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conCMFunction.KeyWords);
objCMFunctionEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.KeyWords) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.KeyWords, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.KeyWords] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncParaLst">函数参数列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncParaLst(this clsCMFunctionEN objCMFunctionEN, string strFuncParaLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, conCMFunction.FuncParaLst);
objCMFunctionEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncParaLst) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncParaLst, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncParaLst] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncComments">函数注释</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncComments(this clsCMFunctionEN objCMFunctionEN, string strFuncComments, string strComparisonOp="")
	{
objCMFunctionEN.FuncComments = strFuncComments; //函数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncComments) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncComments, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncComments] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFunctionSignature(this clsCMFunctionEN objCMFunctionEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conCMFunction.FunctionSignature);
objCMFunctionEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FunctionSignature) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FunctionSignature, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FunctionSignature] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncTypeId(this clsCMFunctionEN objCMFunctionEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conCMFunction.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conCMFunction.FuncTypeId);
objCMFunctionEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncTypeId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncTypeId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncTypeId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnType">返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnType(this clsCMFunctionEN objCMFunctionEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnType, 500, conCMFunction.ReturnType);
objCMFunctionEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnType) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnType, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnType] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeFullName">返回类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnTypeFullName(this clsCMFunctionEN objCMFunctionEN, string strReturnTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conCMFunction.ReturnTypeFullName);
objCMFunctionEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnTypeFullName) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnTypeFullName, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnTypeFullName] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsKnownType(this clsCMFunctionEN objCMFunctionEN, bool bolIsKnownType, string strComparisonOp="")
	{
objCMFunctionEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsKnownType) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsKnownType, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsKnownType] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnTypeId">返回类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnTypeId(this clsCMFunctionEN objCMFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conCMFunction.ReturnTypeId);
objCMFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnTypeId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnTypeId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnTypeId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsAsyncFunc(this clsCMFunctionEN objCMFunctionEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objCMFunctionEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsAsyncFunc) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsAsyncFunc, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsAsyncFunc] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSourceFunction">来源函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSourceFunction(this clsCMFunctionEN objCMFunctionEN, string strSourceFunction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conCMFunction.SourceFunction);
objCMFunctionEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SourceFunction) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SourceFunction, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SourceFunction] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsGeneCode(this clsCMFunctionEN objCMFunctionEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objCMFunctionEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsGeneCode) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsGeneCode, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsGeneCode] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strReturnValueDescription">返回值说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnValueDescription(this clsCMFunctionEN objCMFunctionEN, string strReturnValueDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, conCMFunction.ReturnValueDescription);
objCMFunctionEN.ReturnValueDescription = strReturnValueDescription; //返回值说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnValueDescription) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnValueDescription, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnValueDescription] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSysFunction">是否系统函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSysFunction(this clsCMFunctionEN objCMFunctionEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objCMFunctionEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSysFunction) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSysFunction, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSysFunction] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "intGetCustomAttributes">GetCustomAttributes</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetGetCustomAttributes(this clsCMFunctionEN objCMFunctionEN, int intGetCustomAttributes, string strComparisonOp="")
	{
objCMFunctionEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.GetCustomAttributes) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.GetCustomAttributes, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.GetCustomAttributes] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strClassNameLst">类名列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetClassNameLst(this clsCMFunctionEN objCMFunctionEN, string strClassNameLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassNameLst, 500, conCMFunction.ClassNameLst);
objCMFunctionEN.ClassNameLst = strClassNameLst; //类名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ClassNameLst) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ClassNameLst, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ClassNameLst] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetUpdDate(this clsCMFunctionEN objCMFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFunction.UpdDate);
objCMFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.UpdDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.UpdDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.UpdDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetUpdUser(this clsCMFunctionEN objCMFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFunction.UpdUser);
objCMFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.UpdUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.UpdUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.UpdUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetMemo(this clsCMFunctionEN objCMFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFunction.Memo);
objCMFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.Memo) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.Memo, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.Memo] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToServer">是否同步到Server</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSynchToServer(this clsCMFunctionEN objCMFunctionEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMFunctionEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSynchToServer) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSynchToServer, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSynchToServer] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerDate">同步到Server日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToServerDate(this clsCMFunctionEN objCMFunctionEN, string strSynchToServerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMFunction.SynchToServerDate);
objCMFunctionEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToServerDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToServerDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToServerDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerUser">同步到Server用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToServerUser(this clsCMFunctionEN objCMFunctionEN, string strSynchToServerUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMFunction.SynchToServerUser);
objCMFunctionEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToServerUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToServerUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToServerUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToClient">是否同步到Client</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSynchToClient(this clsCMFunctionEN objCMFunctionEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMFunctionEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSynchToClient) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSynchToClient, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSynchToClient] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientDate">同步到Client库日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToClientDate(this clsCMFunctionEN objCMFunctionEN, string strSynchToClientDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMFunction.SynchToClientDate);
objCMFunctionEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToClientDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToClientDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToClientDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientUser">同步到Client库用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToClientUser(this clsCMFunctionEN objCMFunctionEN, string strSynchToClientUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMFunction.SynchToClientUser);
objCMFunctionEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToClientUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToClientUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToClientUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynSource">同步来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynSource(this clsCMFunctionEN objCMFunctionEN, string strSynSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMFunction.SynSource);
objCMFunctionEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynSource) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynSource, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynSource] = strComparisonOp;
}
}
return objCMFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFunctionEN objCMFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFunctionCond.IsUpdated(conCMFunction.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.CmFunctionId, objCMFunctionCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.CmClassId) == true)
{
string strComparisonOpCmClassId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.CmClassId, objCMFunctionCond.CmClassId, strComparisonOpCmClassId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FunctionName) == true)
{
string strComparisonOpFunctionName = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FunctionName, objCMFunctionCond.FunctionName, strComparisonOpFunctionName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objCMFunctionCond.IsUpdated(conCMFunction.KeyWords) == true)
{
string strComparisonOpKeyWords = objCMFunctionCond.dicFldComparisonOp[conCMFunction.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.KeyWords, objCMFunctionCond.KeyWords, strComparisonOpKeyWords);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FuncParaLst, objCMFunctionCond.FuncParaLst, strComparisonOpFuncParaLst);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理!
if (objCMFunctionCond.IsUpdated(conCMFunction.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FunctionSignature, objCMFunctionCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FuncTypeId, objCMFunctionCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnType) == true)
{
string strComparisonOpReturnType = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnType, objCMFunctionCond.ReturnType, strComparisonOpReturnType);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnTypeFullName, objCMFunctionCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsKnownType) == true)
{
if (objCMFunctionCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsKnownType);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnTypeId, objCMFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsAsyncFunc) == true)
{
if (objCMFunctionCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsAsyncFunc);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SourceFunction, objCMFunctionCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsGeneCode) == true)
{
if (objCMFunctionCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsGeneCode);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnValueDescription) == true)
{
string strComparisonOpReturnValueDescription = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnValueDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnValueDescription, objCMFunctionCond.ReturnValueDescription, strComparisonOpReturnValueDescription);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSysFunction) == true)
{
if (objCMFunctionCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSysFunction);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objCMFunctionCond.dicFldComparisonOp[conCMFunction.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFunction.GetCustomAttributes, objCMFunctionCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ClassNameLst) == true)
{
string strComparisonOpClassNameLst = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ClassNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ClassNameLst, objCMFunctionCond.ClassNameLst, strComparisonOpClassNameLst);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.UpdDate, objCMFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.UpdUser, objCMFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.Memo) == true)
{
string strComparisonOpMemo = objCMFunctionCond.dicFldComparisonOp[conCMFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.Memo, objCMFunctionCond.Memo, strComparisonOpMemo);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSynchToServer) == true)
{
if (objCMFunctionCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSynchToServer);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToServerDate, objCMFunctionCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToServerUser, objCMFunctionCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSynchToClient) == true)
{
if (objCMFunctionCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSynchToClient);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToClientDate, objCMFunctionCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToClientUser, objCMFunctionCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynSource) == true)
{
string strComparisonOpSynSource = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynSource, objCMFunctionCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionEN objCMFunctionEN)
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMFunctionEN.sfUpdFldSetStr = objCMFunctionEN.getsfUpdFldSetStr();
clsCMFunctionWApi.CheckPropertyNew(objCMFunctionEN); 
bool bolResult = clsCMFunctionWApi.UpdateRecord(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
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
 /// 获取唯一性条件串--CMFunction(CM函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMClassId_FuncName_UserId_ParaList
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMFunctionEN objCMFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionEN == null) return "";
if (objCMFunctionEN.CmFunctionId == null || objCMFunctionEN.CmFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFunctionId !=  '{0}'", objCMFunctionEN.CmFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFunctionEN objCMFunctionEN)
{
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionWApi.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionWApi.GetMaxStrId();
 }
clsCMFunctionWApi.CheckPropertyNew(objCMFunctionEN); 
bool bolResult = clsCMFunctionWApi.AddNewRecord(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFunctionEN objCMFunctionEN)
{
try
{
clsCMFunctionWApi.CheckPropertyNew(objCMFunctionEN); 
string strCmFunctionId = clsCMFunctionWApi.AddNewRecordWithMaxId(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
return strCmFunctionId;
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionEN objCMFunctionEN, string strWhereCond)
{
try
{
clsCMFunctionWApi.CheckPropertyNew(objCMFunctionEN); 
bool bolResult = clsCMFunctionWApi.UpdateWithCondition(objCMFunctionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
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
 /// CM函数(CMFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMFunctionWApi
{
private static readonly string mstrApiControllerName = "CMFunctionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCMFunctionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CmFunctionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM函数]...","0");
List<clsCMFunctionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CmFunctionId";
objDDL.DataTextField="FunctionName";
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

public static void BindCbo_CmFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMFunction.CmFunctionId); 
List<clsCMFunctionEN> arrObjLst = clsCMFunctionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN()
{
CmFunctionId = "0",
FunctionName = "选[CM函数]..."
};
arrObjLst.Insert(0, objCMFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMFunction.CmFunctionId;
objComboBox.DisplayMember = conCMFunction.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMFunctionEN objCMFunctionEN)
{
if (!Object.Equals(null, objCMFunctionEN.CmFunctionId) && GetStrLen(objCMFunctionEN.CmFunctionId) > 8)
{
 throw new Exception("字段[函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFunctionEN.CmClassId) && GetStrLen(objCMFunctionEN.CmClassId) > 8)
{
 throw new Exception("字段[类Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFunctionEN.FunctionName) && GetStrLen(objCMFunctionEN.FunctionName) > 200)
{
 throw new Exception("字段[功能名称]的长度不能超过200!");
}
if (!Object.Equals(null, objCMFunctionEN.KeyWords) && GetStrLen(objCMFunctionEN.KeyWords) > 500)
{
 throw new Exception("字段[关键字]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.FuncParaLst) && GetStrLen(objCMFunctionEN.FuncParaLst) > 500)
{
 throw new Exception("字段[函数参数列表]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.FunctionSignature) && GetStrLen(objCMFunctionEN.FunctionSignature) > 500)
{
 throw new Exception("字段[函数签名]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.FuncTypeId) && GetStrLen(objCMFunctionEN.FuncTypeId) > 2)
{
 throw new Exception("字段[函数类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCMFunctionEN.ReturnType) && GetStrLen(objCMFunctionEN.ReturnType) > 500)
{
 throw new Exception("字段[返回类型]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.ReturnTypeFullName) && GetStrLen(objCMFunctionEN.ReturnTypeFullName) > 500)
{
 throw new Exception("字段[返回类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.ReturnTypeId) && GetStrLen(objCMFunctionEN.ReturnTypeId) > 2)
{
 throw new Exception("字段[返回类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objCMFunctionEN.SourceFunction) && GetStrLen(objCMFunctionEN.SourceFunction) > 500)
{
 throw new Exception("字段[来源函数]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.ReturnValueDescription) && GetStrLen(objCMFunctionEN.ReturnValueDescription) > 500)
{
 throw new Exception("字段[返回值说明]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.ClassNameLst) && GetStrLen(objCMFunctionEN.ClassNameLst) > 500)
{
 throw new Exception("字段[类名列表]的长度不能超过500!");
}
if (!Object.Equals(null, objCMFunctionEN.UpdDate) && GetStrLen(objCMFunctionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.UpdUser) && GetStrLen(objCMFunctionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.Memo) && GetStrLen(objCMFunctionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objCMFunctionEN.SynchToServerDate) && GetStrLen(objCMFunctionEN.SynchToServerDate) > 20)
{
 throw new Exception("字段[同步到Server日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.SynchToServerUser) && GetStrLen(objCMFunctionEN.SynchToServerUser) > 20)
{
 throw new Exception("字段[同步到Server用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.SynchToClientDate) && GetStrLen(objCMFunctionEN.SynchToClientDate) > 20)
{
 throw new Exception("字段[同步到Client库日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.SynchToClientUser) && GetStrLen(objCMFunctionEN.SynchToClientUser) > 20)
{
 throw new Exception("字段[同步到Client库用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionEN.SynSource) && GetStrLen(objCMFunctionEN.SynSource) > 50)
{
 throw new Exception("字段[同步来源]的长度不能超过50!");
}
 objCMFunctionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
if (strCmFunctionId == "") return null;
string strAction = "GetObjByCmFunctionId";
clsCMFunctionEN objCMFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFunctionId"] = strCmFunctionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMFunctionEN = JsonConvert.DeserializeObject<clsCMFunctionEN>(strJson);
return objCMFunctionEN;
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
public static clsCMFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMFunctionEN objCMFunctionEN;
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
objCMFunctionEN = JsonConvert.DeserializeObject<clsCMFunctionEN>(strJson);
return objCMFunctionEN;
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
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFunctionEN GetObjByCmFunctionIdCache(string strCmFunctionId,string strCmClassId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel =
from objCMFunctionEN in arrCMFunctionObjLstCache
where objCMFunctionEN.CmFunctionId == strCmFunctionId 
select objCMFunctionEN;
if (arrCMFunctionObjLst_Sel.Count() == 0)
{
   clsCMFunctionEN obj = clsCMFunctionWApi.GetObjByCmFunctionId(strCmFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//初始化列表缓存
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel1 =
from objCMFunctionEN in arrCMFunctionObjLstCache
where objCMFunctionEN.CmFunctionId == strCmFunctionId 
select objCMFunctionEN;
List <clsCMFunctionEN> arrCMFunctionObjLst_Sel = new List<clsCMFunctionEN>();
foreach (clsCMFunctionEN obj in arrCMFunctionObjLst_Sel1)
{
arrCMFunctionObjLst_Sel.Add(obj);
}
if (arrCMFunctionObjLst_Sel.Count > 0)
{
return arrCMFunctionObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在CMFunction对象缓存列表中,找不到记录[CmFunctionId = {0}](函数:{1})", strCmFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//初始化列表缓存
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel1 =
from objCMFunctionEN in arrCMFunctionObjLstCache
where objCMFunctionEN.CmFunctionId == strCmFunctionId 
select objCMFunctionEN;
List <clsCMFunctionEN> arrCMFunctionObjLst_Sel = new List<clsCMFunctionEN>();
foreach (clsCMFunctionEN obj in arrCMFunctionObjLst_Sel1)
{
arrCMFunctionObjLst_Sel.Add(obj);
}
if (arrCMFunctionObjLst_Sel.Count > 0)
{
return arrCMFunctionObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在CMFunction对象缓存列表中,找不到记录的相关名称[CmFunctionId = {0}](函数:{1})", strCmFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCMFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
 /// <param name = "arrCmFunctionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstByCmFunctionIdLst(List<string> arrCmFunctionId)
{
 List<clsCMFunctionEN> arrObjLst; 
string strAction = "GetObjLstByCmFunctionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
 /// <param name = "arrCmFunctionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCMFunctionEN> GetObjLstByCmFunctionIdLstCache(List<string> arrCmFunctionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel =
from objCMFunctionEN in arrCMFunctionObjLstCache
where arrCmFunctionId.Contains(objCMFunctionEN.CmFunctionId)
select objCMFunctionEN;
return arrCMFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
public static List<clsCMFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
public static List<clsCMFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
public static List<clsCMFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionEN>>(strJson);
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
public static int DelRecord(string strCmFunctionId)
{
string strAction = "DelRecord";
try
{
 clsCMFunctionEN objCMFunctionEN = clsCMFunctionWApi.GetObjByCmFunctionId(strCmFunctionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCmFunctionId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMFunctionWApi.ReFreshCache();
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
public static int DelCMFunctions(List<string> arrCmFunctionId)
{
string strAction = "DelCMFunctions";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCmFunctionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMFunctionWApi.ReFreshCache();
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
public static int DelCMFunctionsByCond(string strWhereCond)
{
string strAction = "DelCMFunctionsByCond";
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
public static bool AddNewRecord(clsCMFunctionEN objCMFunctionEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionEN>(objCMFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCMFunctionEN objCMFunctionEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionEN>(objCMFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionWApi.ReFreshCache();
var strCmFunctionId = (string)jobjReturn0["returnStr"];
return strCmFunctionId;
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
public static bool UpdateRecord(clsCMFunctionEN objCMFunctionEN)
{
if (string.IsNullOrEmpty(objCMFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionEN.CmFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionEN>(objCMFunctionEN);
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMFunctionEN objCMFunctionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionEN.CmFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionEN.CmFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionEN>(objCMFunctionEN);
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
public static bool IsExist(string strCmFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCmFunctionId"] = strCmFunctionId
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
 /// <param name = "objCMFunctionENS">源对象</param>
 /// <param name = "objCMFunctionENT">目标对象</param>
 public static void CopyTo(clsCMFunctionEN objCMFunctionENS, clsCMFunctionEN objCMFunctionENT)
{
try
{
objCMFunctionENT.CmFunctionId = objCMFunctionENS.CmFunctionId; //函数Id
objCMFunctionENT.CmClassId = objCMFunctionENS.CmClassId; //类Id
objCMFunctionENT.FunctionName = objCMFunctionENS.FunctionName; //功能名称
objCMFunctionENT.FuncContent = objCMFunctionENS.FuncContent; //函数内容
objCMFunctionENT.KeyWords = objCMFunctionENS.KeyWords; //关键字
objCMFunctionENT.FuncParaLst = objCMFunctionENS.FuncParaLst; //函数参数列表
objCMFunctionENT.FuncComments = objCMFunctionENS.FuncComments; //函数注释
objCMFunctionENT.FunctionSignature = objCMFunctionENS.FunctionSignature; //函数签名
objCMFunctionENT.FuncTypeId = objCMFunctionENS.FuncTypeId; //函数类型Id
objCMFunctionENT.ReturnType = objCMFunctionENS.ReturnType; //返回类型
objCMFunctionENT.ReturnTypeFullName = objCMFunctionENS.ReturnTypeFullName; //返回类型全名
objCMFunctionENT.IsKnownType = objCMFunctionENS.IsKnownType; //是否已知类型
objCMFunctionENT.ReturnTypeId = objCMFunctionENS.ReturnTypeId; //返回类型ID
objCMFunctionENT.IsAsyncFunc = objCMFunctionENS.IsAsyncFunc; //是否异步函数
objCMFunctionENT.SourceFunction = objCMFunctionENS.SourceFunction; //来源函数
objCMFunctionENT.IsGeneCode = objCMFunctionENS.IsGeneCode; //是否生成代码
objCMFunctionENT.ReturnValueDescription = objCMFunctionENS.ReturnValueDescription; //返回值说明
objCMFunctionENT.IsSysFunction = objCMFunctionENS.IsSysFunction; //是否系统函数
objCMFunctionENT.GetCustomAttributes = objCMFunctionENS.GetCustomAttributes; //GetCustomAttributes
objCMFunctionENT.ClassNameLst = objCMFunctionENS.ClassNameLst; //类名列表
objCMFunctionENT.UpdDate = objCMFunctionENS.UpdDate; //修改日期
objCMFunctionENT.UpdUser = objCMFunctionENS.UpdUser; //修改者
objCMFunctionENT.Memo = objCMFunctionENS.Memo; //说明
objCMFunctionENT.IsSynchToServer = objCMFunctionENS.IsSynchToServer; //是否同步到Server
objCMFunctionENT.SynchToServerDate = objCMFunctionENS.SynchToServerDate; //同步到Server日期
objCMFunctionENT.SynchToServerUser = objCMFunctionENS.SynchToServerUser; //同步到Server用户
objCMFunctionENT.IsSynchToClient = objCMFunctionENS.IsSynchToClient; //是否同步到Client
objCMFunctionENT.SynchToClientDate = objCMFunctionENS.SynchToClientDate; //同步到Client库日期
objCMFunctionENT.SynchToClientUser = objCMFunctionENS.SynchToClientUser; //同步到Client库用户
objCMFunctionENT.SynSource = objCMFunctionENS.SynSource; //同步来源
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
public static DataTable ToDataTable(List<clsCMFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMFunctionEN._AttributeName)
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
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
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
if (clsCMFunctionWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstCache(string strCmClassId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCMFunctionEN._CurrTabName;
List<clsCMFunctionEN> arrCMFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMFunctionObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMFunction.CmFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.CmClassId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FuncContent, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FuncParaLst, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FuncComments, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.ReturnType, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.ReturnTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.ReturnTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.SourceFunction, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.ReturnValueDescription, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsSysFunction, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.GetCustomAttributes, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMFunction.ClassNameLst, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsSynchToServer, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.SynchToServerDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.SynchToServerUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.IsSynchToClient, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunction.SynchToClientDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.SynchToClientUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunction.SynSource, Type.GetType("System.String"));
foreach (clsCMFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMFunction.CmFunctionId] = objInFor[conCMFunction.CmFunctionId];
objDR[conCMFunction.CmClassId] = objInFor[conCMFunction.CmClassId];
objDR[conCMFunction.FunctionName] = objInFor[conCMFunction.FunctionName];
objDR[conCMFunction.FuncContent] = objInFor[conCMFunction.FuncContent];
objDR[conCMFunction.KeyWords] = objInFor[conCMFunction.KeyWords];
objDR[conCMFunction.FuncParaLst] = objInFor[conCMFunction.FuncParaLst];
objDR[conCMFunction.FuncComments] = objInFor[conCMFunction.FuncComments];
objDR[conCMFunction.FunctionSignature] = objInFor[conCMFunction.FunctionSignature];
objDR[conCMFunction.FuncTypeId] = objInFor[conCMFunction.FuncTypeId];
objDR[conCMFunction.ReturnType] = objInFor[conCMFunction.ReturnType];
objDR[conCMFunction.ReturnTypeFullName] = objInFor[conCMFunction.ReturnTypeFullName];
objDR[conCMFunction.IsKnownType] = objInFor[conCMFunction.IsKnownType];
objDR[conCMFunction.ReturnTypeId] = objInFor[conCMFunction.ReturnTypeId];
objDR[conCMFunction.IsAsyncFunc] = objInFor[conCMFunction.IsAsyncFunc];
objDR[conCMFunction.SourceFunction] = objInFor[conCMFunction.SourceFunction];
objDR[conCMFunction.IsGeneCode] = objInFor[conCMFunction.IsGeneCode];
objDR[conCMFunction.ReturnValueDescription] = objInFor[conCMFunction.ReturnValueDescription];
objDR[conCMFunction.IsSysFunction] = objInFor[conCMFunction.IsSysFunction];
objDR[conCMFunction.GetCustomAttributes] = objInFor[conCMFunction.GetCustomAttributes];
objDR[conCMFunction.ClassNameLst] = objInFor[conCMFunction.ClassNameLst];
objDR[conCMFunction.UpdDate] = objInFor[conCMFunction.UpdDate];
objDR[conCMFunction.UpdUser] = objInFor[conCMFunction.UpdUser];
objDR[conCMFunction.Memo] = objInFor[conCMFunction.Memo];
objDR[conCMFunction.IsSynchToServer] = objInFor[conCMFunction.IsSynchToServer];
objDR[conCMFunction.SynchToServerDate] = objInFor[conCMFunction.SynchToServerDate];
objDR[conCMFunction.SynchToServerUser] = objInFor[conCMFunction.SynchToServerUser];
objDR[conCMFunction.IsSynchToClient] = objInFor[conCMFunction.IsSynchToClient];
objDR[conCMFunction.SynchToClientDate] = objInFor[conCMFunction.SynchToClientDate];
objDR[conCMFunction.SynchToClientUser] = objInFor[conCMFunction.SynchToClientUser];
objDR[conCMFunction.SynSource] = objInFor[conCMFunction.SynSource];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM函数(CMFunction)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMFunction : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCmClassId)
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
clsCMFunctionWApi.ReFreshThisCache(strCmClassId);
}
}

}