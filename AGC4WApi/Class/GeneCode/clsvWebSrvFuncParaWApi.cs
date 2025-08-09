
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFuncParaWApi
 表名:vWebSrvFuncPara(00050348)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvWebSrvFuncParaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFuncParaId">函数参数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvFuncParaId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvFuncParaId, 8, convWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFuncParaId, 8, convWebSrvFuncPara.WebSrvFuncParaId);
objvWebSrvFuncParaEN.WebSrvFuncParaId = strWebSrvFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.WebSrvFuncParaId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.WebSrvFuncParaId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.WebSrvFuncParaId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvFunctionId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvFunctionId, convWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, convWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, convWebSrvFuncPara.WebSrvFunctionId);
objvWebSrvFuncParaEN.WebSrvFunctionId = strWebSrvFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.WebSrvFunctionId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.WebSrvFunctionId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.WebSrvFunctionId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvClassId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvFuncPara.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvFuncPara.WebSrvClassId);
objvWebSrvFuncParaEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.WebSrvClassId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.WebSrvClassId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.WebSrvClassId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFuncModuleAgcId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvFuncPara.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvFuncPara.FuncModuleAgcId);
objvWebSrvFuncParaEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.FuncModuleAgcId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.FuncModuleAgcId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.FuncModuleAgcId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetPrjId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvFuncPara.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvFuncPara.PrjId);
objvWebSrvFuncParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.PrjId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.PrjId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.PrjId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFunctionName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convWebSrvFuncPara.FunctionName);
objvWebSrvFuncParaEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.FunctionName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.FunctionName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.FunctionName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFunctionSignature(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convWebSrvFuncPara.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convWebSrvFuncPara.FunctionSignature);
objvWebSrvFuncParaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.FunctionSignature) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.FunctionSignature, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.FunctionSignature] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsAsyncFunc">是否异步函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetIsAsyncFunc(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvWebSrvFuncParaEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.IsAsyncFunc) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.IsAsyncFunc, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.IsAsyncFunc] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetIsGeneCode(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvWebSrvFuncParaEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.IsGeneCode) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.IsGeneCode, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.IsGeneCode] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataTypeId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convWebSrvFuncPara.DataTypeId);
objvWebSrvFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.DataTypeId) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.DataTypeId, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.DataTypeId] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataTypeName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convWebSrvFuncPara.DataTypeName);
objvWebSrvFuncParaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.DataTypeName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.DataTypeName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.DataTypeName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataCnName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convWebSrvFuncPara.DataCnName);
clsCheckSql.CheckFieldLen(strDataCnName, 100, convWebSrvFuncPara.DataCnName);
objvWebSrvFuncParaEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.DataCnName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.DataCnName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.DataCnName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetCsType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convWebSrvFuncPara.CsType);
clsCheckSql.CheckFieldLen(strCsType, 100, convWebSrvFuncPara.CsType);
objvWebSrvFuncParaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.CsType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.CsType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.CsType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetJavaType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convWebSrvFuncPara.JavaType);
clsCheckSql.CheckFieldLen(strJavaType, 100, convWebSrvFuncPara.JavaType);
objvWebSrvFuncParaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.JavaType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.JavaType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.JavaType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetJavaObjType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convWebSrvFuncPara.JavaObjType);
objvWebSrvFuncParaEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.JavaObjType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.JavaObjType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.JavaObjType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetSwiftType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convWebSrvFuncPara.SwiftType);
objvWebSrvFuncParaEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.SwiftType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.SwiftType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.SwiftType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetIsNeedQuote(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, convWebSrvFuncPara.IsNeedQuote);
objvWebSrvFuncParaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.IsNeedQuote) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.IsNeedQuote, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.IsNeedQuote] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetOraDbType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convWebSrvFuncPara.OraDbType);
clsCheckSql.CheckFieldLen(strOraDbType, 100, convWebSrvFuncPara.OraDbType);
objvWebSrvFuncParaEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.OraDbType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.OraDbType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.OraDbType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetMySqlType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convWebSrvFuncPara.MySqlType);
objvWebSrvFuncParaEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.MySqlType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.MySqlType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.MySqlType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterType">参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParameterType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParameterType, convWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(strParameterType, 100, convWebSrvFuncPara.ParameterType);
objvWebSrvFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.ParameterType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.ParameterType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.ParameterType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParameterTypeFullName">参数类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParameterTypeFullName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convWebSrvFuncPara.ParameterTypeFullName);
objvWebSrvFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.ParameterTypeFullName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsByRef">是否引用型参数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetIsByRef(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsByRef, convWebSrvFuncPara.IsByRef);
objvWebSrvFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.IsByRef) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.IsByRef, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.IsByRef] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaName">参数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParaName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(strParaName, 50, convWebSrvFuncPara.ParaName);
objvWebSrvFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.ParaName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.ParaName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.ParaName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strParaCnName">参数中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParaCnName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(strParaCnName, 50, convWebSrvFuncPara.ParaCnName);
objvWebSrvFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.ParaCnName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.ParaCnName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.ParaCnName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsKnownType">是否已知类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetIsKnownType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, bool bolIsKnownType, string strComparisonOp="")
	{
objvWebSrvFuncParaEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.IsKnownType) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.IsKnownType, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.IsKnownType] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetUpdDate(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvFuncPara.UpdDate);
objvWebSrvFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.UpdDate) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.UpdDate, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.UpdDate] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetUpdUser(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvFuncPara.UpdUser);
objvWebSrvFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.UpdUser) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.UpdUser, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.UpdUser] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetMemo(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvFuncPara.Memo);
objvWebSrvFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.Memo) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.Memo, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.Memo] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetClsName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvFuncPara.ClsName);
objvWebSrvFuncParaEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvFuncParaEN.dicFldComparisonOp.ContainsKey(convWebSrvFuncPara.ClsName) == false)
{
objvWebSrvFuncParaEN.dicFldComparisonOp.Add(convWebSrvFuncPara.ClsName, strComparisonOp);
}
else
{
objvWebSrvFuncParaEN.dicFldComparisonOp[convWebSrvFuncPara.ClsName] = strComparisonOp;
}
}
return objvWebSrvFuncParaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWebSrvFuncParaEN objvWebSrvFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.WebSrvFuncParaId) == true)
{
string strComparisonOpWebSrvFuncParaId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.WebSrvFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.WebSrvFuncParaId, objvWebSrvFuncParaCond.WebSrvFuncParaId, strComparisonOpWebSrvFuncParaId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.WebSrvFunctionId) == true)
{
string strComparisonOpWebSrvFunctionId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.WebSrvFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.WebSrvFunctionId, objvWebSrvFuncParaCond.WebSrvFunctionId, strComparisonOpWebSrvFunctionId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.WebSrvClassId, objvWebSrvFuncParaCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.FuncModuleAgcId, objvWebSrvFuncParaCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.PrjId) == true)
{
string strComparisonOpPrjId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.PrjId, objvWebSrvFuncParaCond.PrjId, strComparisonOpPrjId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.FunctionName) == true)
{
string strComparisonOpFunctionName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.FunctionName, objvWebSrvFuncParaCond.FunctionName, strComparisonOpFunctionName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.FunctionSignature, objvWebSrvFuncParaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.IsAsyncFunc) == true)
{
if (objvWebSrvFuncParaCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFuncPara.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFuncPara.IsAsyncFunc);
}
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.IsGeneCode) == true)
{
if (objvWebSrvFuncParaCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFuncPara.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFuncPara.IsGeneCode);
}
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.DataTypeId, objvWebSrvFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.DataTypeName, objvWebSrvFuncParaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.DataCnName) == true)
{
string strComparisonOpDataCnName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.DataCnName, objvWebSrvFuncParaCond.DataCnName, strComparisonOpDataCnName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.CsType) == true)
{
string strComparisonOpCsType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.CsType, objvWebSrvFuncParaCond.CsType, strComparisonOpCsType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.JavaType) == true)
{
string strComparisonOpJavaType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.JavaType, objvWebSrvFuncParaCond.JavaType, strComparisonOpJavaType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.JavaObjType, objvWebSrvFuncParaCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.SwiftType) == true)
{
string strComparisonOpSwiftType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.SwiftType, objvWebSrvFuncParaCond.SwiftType, strComparisonOpSwiftType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.IsNeedQuote) == true)
{
if (objvWebSrvFuncParaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFuncPara.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFuncPara.IsNeedQuote);
}
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.OraDbType) == true)
{
string strComparisonOpOraDbType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.OraDbType, objvWebSrvFuncParaCond.OraDbType, strComparisonOpOraDbType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.MySqlType) == true)
{
string strComparisonOpMySqlType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.MySqlType, objvWebSrvFuncParaCond.MySqlType, strComparisonOpMySqlType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.ParameterType, objvWebSrvFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.ParameterTypeFullName, objvWebSrvFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.IsByRef) == true)
{
if (objvWebSrvFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFuncPara.IsByRef);
}
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.ParaName, objvWebSrvFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.ParaCnName, objvWebSrvFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.IsKnownType) == true)
{
if (objvWebSrvFuncParaCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvFuncPara.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvFuncPara.IsKnownType);
}
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.UpdDate, objvWebSrvFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.UpdUser, objvWebSrvFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.Memo) == true)
{
string strComparisonOpMemo = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.Memo, objvWebSrvFuncParaCond.Memo, strComparisonOpMemo);
}
if (objvWebSrvFuncParaCond.IsUpdated(convWebSrvFuncPara.ClsName) == true)
{
string strComparisonOpClsName = objvWebSrvFuncParaCond.dicFldComparisonOp[convWebSrvFuncPara.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvFuncPara.ClsName, objvWebSrvFuncParaCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWebSrv函数参数(vWebSrvFuncPara)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvFuncParaWApi
{
private static readonly string mstrApiControllerName = "vWebSrvFuncParaApi";

 public clsvWebSrvFuncParaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaId(string strWebSrvFuncParaId)
{
if (strWebSrvFuncParaId == "") return null;
string strAction = "GetObjByWebSrvFuncParaId";
clsvWebSrvFuncParaEN objvWebSrvFuncParaEN;
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
objvWebSrvFuncParaEN = JsonConvert.DeserializeObject<clsvWebSrvFuncParaEN>(strJson);
return objvWebSrvFuncParaEN;
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
public static clsvWebSrvFuncParaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvWebSrvFuncParaEN objvWebSrvFuncParaEN;
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
objvWebSrvFuncParaEN = JsonConvert.DeserializeObject<clsvWebSrvFuncParaEN>(strJson);
return objvWebSrvFuncParaEN;
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
 /// <param name = "strWebSrvFuncParaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaIdCache(string strWebSrvFuncParaId)
{
if (string.IsNullOrEmpty(strWebSrvFuncParaId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst_Sel =
from objvWebSrvFuncParaEN in arrvWebSrvFuncParaObjLstCache
where objvWebSrvFuncParaEN.WebSrvFuncParaId == strWebSrvFuncParaId 
select objvWebSrvFuncParaEN;
if (arrvWebSrvFuncParaObjLst_Sel.Count() == 0)
{
   clsvWebSrvFuncParaEN obj = clsvWebSrvFuncParaWApi.GetObjByWebSrvFuncParaId(strWebSrvFuncParaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWebSrvFuncParaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLst(string strWhereCond)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
public static List<clsvWebSrvFuncParaEN> GetObjLstByWebSrvFuncParaIdLst(List<string> arrWebSrvFuncParaId)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
 /// <param name = "arrWebSrvFuncParaId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvWebSrvFuncParaEN> GetObjLstByWebSrvFuncParaIdLstCache(List<string> arrWebSrvFuncParaId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst_Sel =
from objvWebSrvFuncParaEN in arrvWebSrvFuncParaObjLstCache
where arrWebSrvFuncParaId.Contains(objvWebSrvFuncParaEN.WebSrvFuncParaId)
select objvWebSrvFuncParaEN;
return arrvWebSrvFuncParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
public static List<clsvWebSrvFuncParaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
public static List<clsvWebSrvFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
public static List<clsvWebSrvFuncParaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvWebSrvFuncParaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvFuncParaEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaENS">源对象</param>
 /// <param name = "objvWebSrvFuncParaENT">目标对象</param>
 public static void CopyTo(clsvWebSrvFuncParaEN objvWebSrvFuncParaENS, clsvWebSrvFuncParaEN objvWebSrvFuncParaENT)
{
try
{
objvWebSrvFuncParaENT.WebSrvFuncParaId = objvWebSrvFuncParaENS.WebSrvFuncParaId; //函数参数Id
objvWebSrvFuncParaENT.WebSrvFunctionId = objvWebSrvFuncParaENS.WebSrvFunctionId; //函数Id
objvWebSrvFuncParaENT.WebSrvClassId = objvWebSrvFuncParaENS.WebSrvClassId; //类Id
objvWebSrvFuncParaENT.FuncModuleAgcId = objvWebSrvFuncParaENS.FuncModuleAgcId; //功能模块Id
objvWebSrvFuncParaENT.PrjId = objvWebSrvFuncParaENS.PrjId; //工程Id
objvWebSrvFuncParaENT.FunctionName = objvWebSrvFuncParaENS.FunctionName; //功能名称
objvWebSrvFuncParaENT.FunctionSignature = objvWebSrvFuncParaENS.FunctionSignature; //函数签名
objvWebSrvFuncParaENT.IsAsyncFunc = objvWebSrvFuncParaENS.IsAsyncFunc; //是否异步函数
objvWebSrvFuncParaENT.IsGeneCode = objvWebSrvFuncParaENS.IsGeneCode; //是否生成代码
objvWebSrvFuncParaENT.DataTypeId = objvWebSrvFuncParaENS.DataTypeId; //数据类型Id
objvWebSrvFuncParaENT.DataTypeName = objvWebSrvFuncParaENS.DataTypeName; //数据类型名称
objvWebSrvFuncParaENT.DataCnName = objvWebSrvFuncParaENS.DataCnName; //数据类型中文名称
objvWebSrvFuncParaENT.CsType = objvWebSrvFuncParaENS.CsType; //CS类型
objvWebSrvFuncParaENT.JavaType = objvWebSrvFuncParaENS.JavaType; //JAVA类型
objvWebSrvFuncParaENT.JavaObjType = objvWebSrvFuncParaENS.JavaObjType; //JAVA对象类型
objvWebSrvFuncParaENT.SwiftType = objvWebSrvFuncParaENS.SwiftType; //SwiftType
objvWebSrvFuncParaENT.IsNeedQuote = objvWebSrvFuncParaENS.IsNeedQuote; //是否需要引号
objvWebSrvFuncParaENT.OraDbType = objvWebSrvFuncParaENS.OraDbType; //Ora数据类型
objvWebSrvFuncParaENT.MySqlType = objvWebSrvFuncParaENS.MySqlType; //MySqlType
objvWebSrvFuncParaENT.ParameterType = objvWebSrvFuncParaENS.ParameterType; //参数类型
objvWebSrvFuncParaENT.ParameterTypeFullName = objvWebSrvFuncParaENS.ParameterTypeFullName; //参数类型全名
objvWebSrvFuncParaENT.IsByRef = objvWebSrvFuncParaENS.IsByRef; //是否引用型参数
objvWebSrvFuncParaENT.ParaName = objvWebSrvFuncParaENS.ParaName; //参数名
objvWebSrvFuncParaENT.ParaCnName = objvWebSrvFuncParaENS.ParaCnName; //参数中文名
objvWebSrvFuncParaENT.IsKnownType = objvWebSrvFuncParaENS.IsKnownType; //是否已知类型
objvWebSrvFuncParaENT.UpdDate = objvWebSrvFuncParaENS.UpdDate; //修改日期
objvWebSrvFuncParaENT.UpdUser = objvWebSrvFuncParaENS.UpdUser; //修改者
objvWebSrvFuncParaENT.Memo = objvWebSrvFuncParaENS.Memo; //说明
objvWebSrvFuncParaENT.ClsName = objvWebSrvFuncParaENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvWebSrvFuncParaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWebSrvFuncParaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWebSrvFuncParaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWebSrvFuncParaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWebSrvFuncParaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWebSrvFuncParaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
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
public static List<clsvWebSrvFuncParaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvWebSrvFuncParaEN._CurrTabName;
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvWebSrvFuncParaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWebSrvFuncParaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWebSrvFuncPara.WebSrvFuncParaId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.WebSrvFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.IsAsyncFunc, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFuncPara.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFuncPara.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.CsType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFuncPara.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.ParameterType, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.ParameterTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.IsByRef, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFuncPara.ParaName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.ParaCnName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.IsKnownType, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvFuncPara.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvFuncPara.ClsName, Type.GetType("System.String"));
foreach (clsvWebSrvFuncParaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWebSrvFuncPara.WebSrvFuncParaId] = objInFor[convWebSrvFuncPara.WebSrvFuncParaId];
objDR[convWebSrvFuncPara.WebSrvFunctionId] = objInFor[convWebSrvFuncPara.WebSrvFunctionId];
objDR[convWebSrvFuncPara.WebSrvClassId] = objInFor[convWebSrvFuncPara.WebSrvClassId];
objDR[convWebSrvFuncPara.FuncModuleAgcId] = objInFor[convWebSrvFuncPara.FuncModuleAgcId];
objDR[convWebSrvFuncPara.PrjId] = objInFor[convWebSrvFuncPara.PrjId];
objDR[convWebSrvFuncPara.FunctionName] = objInFor[convWebSrvFuncPara.FunctionName];
objDR[convWebSrvFuncPara.FunctionSignature] = objInFor[convWebSrvFuncPara.FunctionSignature];
objDR[convWebSrvFuncPara.IsAsyncFunc] = objInFor[convWebSrvFuncPara.IsAsyncFunc];
objDR[convWebSrvFuncPara.IsGeneCode] = objInFor[convWebSrvFuncPara.IsGeneCode];
objDR[convWebSrvFuncPara.DataTypeId] = objInFor[convWebSrvFuncPara.DataTypeId];
objDR[convWebSrvFuncPara.DataTypeName] = objInFor[convWebSrvFuncPara.DataTypeName];
objDR[convWebSrvFuncPara.DataCnName] = objInFor[convWebSrvFuncPara.DataCnName];
objDR[convWebSrvFuncPara.CsType] = objInFor[convWebSrvFuncPara.CsType];
objDR[convWebSrvFuncPara.JavaType] = objInFor[convWebSrvFuncPara.JavaType];
objDR[convWebSrvFuncPara.JavaObjType] = objInFor[convWebSrvFuncPara.JavaObjType];
objDR[convWebSrvFuncPara.SwiftType] = objInFor[convWebSrvFuncPara.SwiftType];
objDR[convWebSrvFuncPara.IsNeedQuote] = objInFor[convWebSrvFuncPara.IsNeedQuote];
objDR[convWebSrvFuncPara.OraDbType] = objInFor[convWebSrvFuncPara.OraDbType];
objDR[convWebSrvFuncPara.MySqlType] = objInFor[convWebSrvFuncPara.MySqlType];
objDR[convWebSrvFuncPara.ParameterType] = objInFor[convWebSrvFuncPara.ParameterType];
objDR[convWebSrvFuncPara.ParameterTypeFullName] = objInFor[convWebSrvFuncPara.ParameterTypeFullName];
objDR[convWebSrvFuncPara.IsByRef] = objInFor[convWebSrvFuncPara.IsByRef];
objDR[convWebSrvFuncPara.ParaName] = objInFor[convWebSrvFuncPara.ParaName];
objDR[convWebSrvFuncPara.ParaCnName] = objInFor[convWebSrvFuncPara.ParaCnName];
objDR[convWebSrvFuncPara.IsKnownType] = objInFor[convWebSrvFuncPara.IsKnownType];
objDR[convWebSrvFuncPara.UpdDate] = objInFor[convWebSrvFuncPara.UpdDate];
objDR[convWebSrvFuncPara.UpdUser] = objInFor[convWebSrvFuncPara.UpdUser];
objDR[convWebSrvFuncPara.Memo] = objInFor[convWebSrvFuncPara.Memo];
objDR[convWebSrvFuncPara.ClsName] = objInFor[convWebSrvFuncPara.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}