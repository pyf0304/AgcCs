
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFuncParaBL
 表名:vWebSrvFuncPara(00050348)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:44:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvWebSrvFuncParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFuncParaEN GetObj(this K_WebSrvFuncParaId_vWebSrvFuncPara myKey)
{
clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = clsvWebSrvFuncParaBL.vWebSrvFuncParaDA.GetObjByWebSrvFuncParaId(myKey.Value);
return objvWebSrvFuncParaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvFuncParaId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvFuncParaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvFuncParaId, 8, convWebSrvFuncPara.WebSrvFuncParaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvFuncParaId, 8, convWebSrvFuncPara.WebSrvFuncParaId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvFunctionId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvFunctionId, convWebSrvFuncPara.WebSrvFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, convWebSrvFuncPara.WebSrvFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, convWebSrvFuncPara.WebSrvFunctionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetWebSrvClassId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strWebSrvClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvFuncPara.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvFuncPara.WebSrvClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFuncModuleAgcId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvFuncPara.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvFuncPara.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetPrjId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvFuncPara.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvFuncPara.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFunctionName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convWebSrvFuncPara.FunctionName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetFunctionSignature(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convWebSrvFuncPara.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convWebSrvFuncPara.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataTypeId(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convWebSrvFuncPara.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convWebSrvFuncPara.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convWebSrvFuncPara.DataTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataTypeName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convWebSrvFuncPara.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetDataCnName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convWebSrvFuncPara.DataCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convWebSrvFuncPara.DataCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetCsType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convWebSrvFuncPara.CsType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convWebSrvFuncPara.CsType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetJavaType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convWebSrvFuncPara.JavaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convWebSrvFuncPara.JavaType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetJavaObjType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convWebSrvFuncPara.JavaObjType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetSwiftType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convWebSrvFuncPara.SwiftType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetOraDbType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convWebSrvFuncPara.OraDbType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convWebSrvFuncPara.OraDbType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetMySqlType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convWebSrvFuncPara.MySqlType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParameterType(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParameterType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParameterType, convWebSrvFuncPara.ParameterType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, convWebSrvFuncPara.ParameterType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParameterTypeFullName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convWebSrvFuncPara.ParameterTypeFullName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParaName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convWebSrvFuncPara.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, convWebSrvFuncPara.ParaName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetParaCnName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convWebSrvFuncPara.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convWebSrvFuncPara.ParaCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetUpdDate(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvFuncPara.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetUpdUser(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvFuncPara.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetMemo(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvFuncPara.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvFuncParaEN SetClsName(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvFuncPara.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaENS">源对象</param>
 /// <param name = "objvWebSrvFuncParaENT">目标对象</param>
 public static void CopyTo(this clsvWebSrvFuncParaEN objvWebSrvFuncParaENS, clsvWebSrvFuncParaEN objvWebSrvFuncParaENT)
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
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaENS">源对象</param>
 /// <returns>目标对象=>clsvWebSrvFuncParaEN:objvWebSrvFuncParaENT</returns>
 public static clsvWebSrvFuncParaEN CopyTo(this clsvWebSrvFuncParaEN objvWebSrvFuncParaENS)
{
try
{
 clsvWebSrvFuncParaEN objvWebSrvFuncParaENT = new clsvWebSrvFuncParaEN()
{
WebSrvFuncParaId = objvWebSrvFuncParaENS.WebSrvFuncParaId, //函数参数Id
WebSrvFunctionId = objvWebSrvFuncParaENS.WebSrvFunctionId, //函数Id
WebSrvClassId = objvWebSrvFuncParaENS.WebSrvClassId, //类Id
FuncModuleAgcId = objvWebSrvFuncParaENS.FuncModuleAgcId, //功能模块Id
PrjId = objvWebSrvFuncParaENS.PrjId, //工程Id
FunctionName = objvWebSrvFuncParaENS.FunctionName, //功能名称
FunctionSignature = objvWebSrvFuncParaENS.FunctionSignature, //函数签名
IsAsyncFunc = objvWebSrvFuncParaENS.IsAsyncFunc, //是否异步函数
IsGeneCode = objvWebSrvFuncParaENS.IsGeneCode, //是否生成代码
DataTypeId = objvWebSrvFuncParaENS.DataTypeId, //数据类型Id
DataTypeName = objvWebSrvFuncParaENS.DataTypeName, //数据类型名称
DataCnName = objvWebSrvFuncParaENS.DataCnName, //数据类型中文名称
CsType = objvWebSrvFuncParaENS.CsType, //CS类型
JavaType = objvWebSrvFuncParaENS.JavaType, //JAVA类型
JavaObjType = objvWebSrvFuncParaENS.JavaObjType, //JAVA对象类型
SwiftType = objvWebSrvFuncParaENS.SwiftType, //SwiftType
IsNeedQuote = objvWebSrvFuncParaENS.IsNeedQuote, //是否需要引号
OraDbType = objvWebSrvFuncParaENS.OraDbType, //Ora数据类型
MySqlType = objvWebSrvFuncParaENS.MySqlType, //MySqlType
ParameterType = objvWebSrvFuncParaENS.ParameterType, //参数类型
ParameterTypeFullName = objvWebSrvFuncParaENS.ParameterTypeFullName, //参数类型全名
IsByRef = objvWebSrvFuncParaENS.IsByRef, //是否引用型参数
ParaName = objvWebSrvFuncParaENS.ParaName, //参数名
ParaCnName = objvWebSrvFuncParaENS.ParaCnName, //参数中文名
IsKnownType = objvWebSrvFuncParaENS.IsKnownType, //是否已知类型
UpdDate = objvWebSrvFuncParaENS.UpdDate, //修改日期
UpdUser = objvWebSrvFuncParaENS.UpdUser, //修改者
Memo = objvWebSrvFuncParaENS.Memo, //说明
ClsName = objvWebSrvFuncParaENS.ClsName, //类名
};
 return objvWebSrvFuncParaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
 clsvWebSrvFuncParaBL.vWebSrvFuncParaDA.CheckProperty4Condition(objvWebSrvFuncParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vWebSrvFuncPara
{
public virtual bool UpdRelaTabDate(string strWebSrvFuncParaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vWebSrv函数参数(vWebSrvFuncPara)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvFuncParaBL
{
public static RelatedActions_vWebSrvFuncPara relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvWebSrvFuncParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvWebSrvFuncParaDA vWebSrvFuncParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvWebSrvFuncParaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvWebSrvFuncParaBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvWebSrvFuncParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvFuncParaEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vWebSrvFuncPara(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable_vWebSrvFuncPara(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vWebSrvFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrWebSrvFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByWebSrvFuncParaIdLst(List<string> arrWebSrvFuncParaIdLst)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWebSrvFuncParaIdLst, true);
 string strWhereCond = string.Format("WebSrvFuncParaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvWebSrvFuncParaEN> GetObjLstByWebSrvFuncParaIdLstCache(List<string> arrWebSrvFuncParaIdLst)
{
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst_Sel =
arrvWebSrvFuncParaObjLstCache
.Where(x => arrWebSrvFuncParaIdLst.Contains(x.WebSrvFuncParaId));
return arrvWebSrvFuncParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLst(string strWhereCond)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvWebSrvFuncParaEN> GetSubObjLstCache(clsvWebSrvFuncParaEN objvWebSrvFuncParaCond)
{
List<clsvWebSrvFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvFuncPara._AttributeName)
{
if (objvWebSrvFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFuncParaCond[strFldName].ToString());
}
else
{
if (objvWebSrvFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvFuncParaCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvWebSrvFuncParaEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFuncParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvFuncParaEN.WebSrvFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvWebSrvFuncPara(ref clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
bool bolResult = vWebSrvFuncParaDA.GetvWebSrvFuncPara(ref objvWebSrvFuncParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaId(string strWebSrvFuncParaId)
{
if (strWebSrvFuncParaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWebSrvFuncParaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWebSrvFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWebSrvFuncParaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = vWebSrvFuncParaDA.GetObjByWebSrvFuncParaId(strWebSrvFuncParaId);
return objvWebSrvFuncParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvWebSrvFuncParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = vWebSrvFuncParaDA.GetFirstObj(strWhereCond);
 return objvWebSrvFuncParaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvWebSrvFuncParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = vWebSrvFuncParaDA.GetObjByDataRow(objRow);
 return objvWebSrvFuncParaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvWebSrvFuncParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = vWebSrvFuncParaDA.GetObjByDataRow(objRow);
 return objvWebSrvFuncParaEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">所给的关键字</param>
 /// <param name = "lstvWebSrvFuncParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaIdFromList(string strWebSrvFuncParaId, List<clsvWebSrvFuncParaEN> lstvWebSrvFuncParaObjLst)
{
foreach (clsvWebSrvFuncParaEN objvWebSrvFuncParaEN in lstvWebSrvFuncParaObjLst)
{
if (objvWebSrvFuncParaEN.WebSrvFuncParaId == strWebSrvFuncParaId)
{
return objvWebSrvFuncParaEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strWebSrvFuncParaId;
 try
 {
 strWebSrvFuncParaId = new clsvWebSrvFuncParaDA().GetFirstID(strWhereCond);
 return strWebSrvFuncParaId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vWebSrvFuncParaDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vWebSrvFuncParaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWebSrvFuncParaId)
{
if (string.IsNullOrEmpty(strWebSrvFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWebSrvFuncParaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vWebSrvFuncParaDA.IsExist(strWebSrvFuncParaId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvWebSrvFuncParaDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vWebSrvFuncParaDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">源简化对象</param>
 public static void SetUpdFlag(clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
try
{
objvWebSrvFuncParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvWebSrvFuncParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convWebSrvFuncPara.WebSrvFuncParaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objvWebSrvFuncParaEN.WebSrvFuncParaId; //函数参数Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.WebSrvFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.WebSrvFunctionId = objvWebSrvFuncParaEN.WebSrvFunctionId; //函数Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.WebSrvClassId = objvWebSrvFuncParaEN.WebSrvClassId == "[null]" ? null :  objvWebSrvFuncParaEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.FuncModuleAgcId = objvWebSrvFuncParaEN.FuncModuleAgcId == "[null]" ? null :  objvWebSrvFuncParaEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.PrjId = objvWebSrvFuncParaEN.PrjId == "[null]" ? null :  objvWebSrvFuncParaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.FunctionName = objvWebSrvFuncParaEN.FunctionName == "[null]" ? null :  objvWebSrvFuncParaEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convWebSrvFuncPara.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.FunctionSignature = objvWebSrvFuncParaEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convWebSrvFuncPara.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.IsAsyncFunc = objvWebSrvFuncParaEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(convWebSrvFuncPara.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.IsGeneCode = objvWebSrvFuncParaEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(convWebSrvFuncPara.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.DataTypeId = objvWebSrvFuncParaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convWebSrvFuncPara.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.DataTypeName = objvWebSrvFuncParaEN.DataTypeName == "[null]" ? null :  objvWebSrvFuncParaEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convWebSrvFuncPara.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.DataCnName = objvWebSrvFuncParaEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(convWebSrvFuncPara.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.CsType = objvWebSrvFuncParaEN.CsType; //CS类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.JavaType = objvWebSrvFuncParaEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.JavaObjType = objvWebSrvFuncParaEN.JavaObjType == "[null]" ? null :  objvWebSrvFuncParaEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.SwiftType = objvWebSrvFuncParaEN.SwiftType == "[null]" ? null :  objvWebSrvFuncParaEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(convWebSrvFuncPara.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.IsNeedQuote = objvWebSrvFuncParaEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convWebSrvFuncPara.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.OraDbType = objvWebSrvFuncParaEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.MySqlType = objvWebSrvFuncParaEN.MySqlType == "[null]" ? null :  objvWebSrvFuncParaEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(convWebSrvFuncPara.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.ParameterType = objvWebSrvFuncParaEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.ParameterTypeFullName = objvWebSrvFuncParaEN.ParameterTypeFullName == "[null]" ? null :  objvWebSrvFuncParaEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(convWebSrvFuncPara.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.IsByRef = objvWebSrvFuncParaEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(convWebSrvFuncPara.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.ParaName = objvWebSrvFuncParaEN.ParaName; //参数名
}
if (arrFldSet.Contains(convWebSrvFuncPara.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.ParaCnName = objvWebSrvFuncParaEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(convWebSrvFuncPara.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.IsKnownType = objvWebSrvFuncParaEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(convWebSrvFuncPara.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.UpdDate = objvWebSrvFuncParaEN.UpdDate == "[null]" ? null :  objvWebSrvFuncParaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convWebSrvFuncPara.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.UpdUser = objvWebSrvFuncParaEN.UpdUser == "[null]" ? null :  objvWebSrvFuncParaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convWebSrvFuncPara.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.Memo = objvWebSrvFuncParaEN.Memo == "[null]" ? null :  objvWebSrvFuncParaEN.Memo; //说明
}
if (arrFldSet.Contains(convWebSrvFuncPara.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvFuncParaEN.ClsName = objvWebSrvFuncParaEN.ClsName == "[null]" ? null :  objvWebSrvFuncParaEN.ClsName; //类名
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
try
{
if (objvWebSrvFuncParaEN.WebSrvClassId == "[null]") objvWebSrvFuncParaEN.WebSrvClassId = null; //类Id
if (objvWebSrvFuncParaEN.FuncModuleAgcId == "[null]") objvWebSrvFuncParaEN.FuncModuleAgcId = null; //功能模块Id
if (objvWebSrvFuncParaEN.PrjId == "[null]") objvWebSrvFuncParaEN.PrjId = null; //工程Id
if (objvWebSrvFuncParaEN.FunctionName == "[null]") objvWebSrvFuncParaEN.FunctionName = null; //功能名称
if (objvWebSrvFuncParaEN.DataTypeName == "[null]") objvWebSrvFuncParaEN.DataTypeName = null; //数据类型名称
if (objvWebSrvFuncParaEN.JavaObjType == "[null]") objvWebSrvFuncParaEN.JavaObjType = null; //JAVA对象类型
if (objvWebSrvFuncParaEN.SwiftType == "[null]") objvWebSrvFuncParaEN.SwiftType = null; //SwiftType
if (objvWebSrvFuncParaEN.MySqlType == "[null]") objvWebSrvFuncParaEN.MySqlType = null; //MySqlType
if (objvWebSrvFuncParaEN.ParameterTypeFullName == "[null]") objvWebSrvFuncParaEN.ParameterTypeFullName = null; //参数类型全名
if (objvWebSrvFuncParaEN.UpdDate == "[null]") objvWebSrvFuncParaEN.UpdDate = null; //修改日期
if (objvWebSrvFuncParaEN.UpdUser == "[null]") objvWebSrvFuncParaEN.UpdUser = null; //修改者
if (objvWebSrvFuncParaEN.Memo == "[null]") objvWebSrvFuncParaEN.Memo = null; //说明
if (objvWebSrvFuncParaEN.ClsName == "[null]") objvWebSrvFuncParaEN.ClsName = null; //类名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
 vWebSrvFuncParaDA.CheckProperty4Condition(objvWebSrvFuncParaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvFuncParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvFuncParaBL没有刷新缓存机制(clsWebSrvFuncParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvFunctionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvFunctionsBL没有刷新缓存机制(clsWebSrvFunctionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvFuncParaId");
//if (arrvWebSrvFuncParaObjLstCache == null)
//{
//arrvWebSrvFuncParaObjLstCache = vWebSrvFuncParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaIdCache(string strWebSrvFuncParaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst_Sel =
arrvWebSrvFuncParaObjLstCache
.Where(x=> x.WebSrvFuncParaId == strWebSrvFuncParaId 
);
if (arrvWebSrvFuncParaObjLst_Sel.Count() == 0)
{
   clsvWebSrvFuncParaEN obj = clsvWebSrvFuncParaBL.GetObjByWebSrvFuncParaId(strWebSrvFuncParaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvWebSrvFuncParaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetAllvWebSrvFuncParaObjLstCache()
{
//获取缓存中的对象列表
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = GetObjLstCache(); 
return arrvWebSrvFuncParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvFuncParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvWebSrvFuncParaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvWebSrvFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvWebSrvFuncParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvWebSrvFuncParaEN._RefreshTimeLst.Count == 0) return "";
return clsvWebSrvFuncParaEN._RefreshTimeLst[clsvWebSrvFuncParaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strWebSrvFuncParaId)
{
if (strInFldName != convWebSrvFuncPara.WebSrvFuncParaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convWebSrvFuncPara._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convWebSrvFuncPara._AttributeName));
throw new Exception(strMsg);
}
var objvWebSrvFuncPara = clsvWebSrvFuncParaBL.GetObjByWebSrvFuncParaIdCache(strWebSrvFuncParaId);
if (objvWebSrvFuncPara == null) return "";
return objvWebSrvFuncPara[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvWebSrvFuncParaDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvWebSrvFuncParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvWebSrvFuncParaDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvWebSrvFuncParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvWebSrvFuncParaEN objvWebSrvFuncParaCond)
{
List<clsvWebSrvFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvWebSrvFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvFuncPara._AttributeName)
{
if (objvWebSrvFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFuncParaCond[strFldName].ToString());
}
else
{
if (objvWebSrvFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvFuncParaCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvWebSrvFuncParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vWebSrvFuncParaDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vWebSrvFuncParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}