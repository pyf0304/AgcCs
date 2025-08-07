
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRelaWApi
 表名:vFeatureFuncRela(00050398)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:59
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
public static class  clsvFeatureFuncRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetmId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureFuncRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.mId) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.mId, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.mId] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetApplicationTypeId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureFuncRela.ApplicationTypeId);
objvFeatureFuncRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.ApplicationTypeId) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetApplicationTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureFuncRela.ApplicationTypeName);
objvFeatureFuncRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.ApplicationTypeName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetProgLangTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFeatureFuncRela.ProgLangTypeName);
objvFeatureFuncRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.ProgLangTypeName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureFuncRela.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureFuncRela.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureFuncRela.FeatureId);
objvFeatureFuncRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FeatureId) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureFuncRela.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureFuncRela.FeatureName);
objvFeatureFuncRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FeatureName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetKeyWords(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureFuncRela.KeyWords);
objvFeatureFuncRelaEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.KeyWords) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.KeyWords, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.KeyWords] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureTypeId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFeatureFuncRela.FeatureTypeId);
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFeatureFuncRela.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFeatureFuncRela.FeatureTypeId);
objvFeatureFuncRelaEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FeatureTypeId) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FeatureTypeId, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FeatureTypeId] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureFuncRela.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureFuncRela.FeatureTypeName);
objvFeatureFuncRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FeatureTypeName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName2">功能名-FuncCount</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureName2(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convFeatureFuncRela.FeatureName2);
objvFeatureFuncRelaEN.FeatureName2 = strFeatureName2; //功能名-FuncCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FeatureName2) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FeatureName2, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FeatureName2] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncId4GC(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFeatureFuncRela.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFeatureFuncRela.FuncId4GC);
objvFeatureFuncRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncId4GC) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncId4GC, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncId4GC] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureFuncRela.FuncName);
objvFeatureFuncRelaEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncId4Code(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convFeatureFuncRela.FuncId4Code);
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFeatureFuncRela.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFeatureFuncRela.FuncId4Code);
objvFeatureFuncRelaEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncId4Code) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncId4Code, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncId4Code] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncName4Code(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFeatureFuncRela.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFeatureFuncRela.FuncName4Code);
objvFeatureFuncRelaEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncName4Code) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncName4Code, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncName4Code] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFunctionSignature(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convFeatureFuncRela.FunctionSignature);
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFeatureFuncRela.FunctionSignature);
objvFeatureFuncRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FunctionSignature) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FunctionSignature, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FunctionSignature] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetOrderNum(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvFeatureFuncRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.OrderNum) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetUpdDate(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureFuncRela.UpdDate);
objvFeatureFuncRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.UpdDate) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetUpdUser(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureFuncRela.UpdUser);
objvFeatureFuncRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.UpdUser) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetMemo(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureFuncRela.Memo);
objvFeatureFuncRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.Memo) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.Memo, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.Memo] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeENName">FuncCodeTypeENName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeENName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeENName, 50, convFeatureFuncRela.FuncCodeTypeENName);
objvFeatureFuncRelaEN.FuncCodeTypeENName = strFuncCodeTypeENName; //FuncCodeTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncCodeTypeENName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncCodeTypeENName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeENName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeId">函数代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFeatureFuncRela.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFeatureFuncRela.FuncCodeTypeId);
objvFeatureFuncRelaEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncCodeTypeId) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncCodeTypeId, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeId] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCodeTypeName">FuncCodeTypeName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCodeTypeName, 50, convFeatureFuncRela.FuncCodeTypeName);
objvFeatureFuncRelaEN.FuncCodeTypeName = strFuncCodeTypeName; //FuncCodeTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela.FuncCodeTypeName) == false)
{
objvFeatureFuncRelaEN.dicFldComparisonOp.Add(convFeatureFuncRela.FuncCodeTypeName, strComparisonOp);
}
else
{
objvFeatureFuncRelaEN.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeName] = strComparisonOp;
}
}
return objvFeatureFuncRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureFuncRelaEN objvFeatureFuncRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.mId) == true)
{
string strComparisonOpmId = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFuncRela.mId, objvFeatureFuncRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFuncRela.ApplicationTypeId, objvFeatureFuncRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.ApplicationTypeName, objvFeatureFuncRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.ProgLangTypeName, objvFeatureFuncRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FeatureId, objvFeatureFuncRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FeatureName, objvFeatureFuncRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.KeyWords, objvFeatureFuncRelaCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FeatureTypeId, objvFeatureFuncRelaCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FeatureTypeName, objvFeatureFuncRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FeatureName2) == true)
{
string strComparisonOpFeatureName2 = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FeatureName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FeatureName2, objvFeatureFuncRelaCond.FeatureName2, strComparisonOpFeatureName2);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncId4GC, objvFeatureFuncRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncName) == true)
{
string strComparisonOpFuncName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncName, objvFeatureFuncRelaCond.FuncName, strComparisonOpFuncName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncId4Code, objvFeatureFuncRelaCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncName4Code, objvFeatureFuncRelaCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FunctionSignature, objvFeatureFuncRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFuncRela.OrderNum, objvFeatureFuncRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.UpdDate, objvFeatureFuncRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.UpdUser, objvFeatureFuncRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.Memo, objvFeatureFuncRelaCond.Memo, strComparisonOpMemo);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncCodeTypeENName) == true)
{
string strComparisonOpFuncCodeTypeENName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncCodeTypeENName, objvFeatureFuncRelaCond.FuncCodeTypeENName, strComparisonOpFuncCodeTypeENName);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncCodeTypeId, objvFeatureFuncRelaCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objvFeatureFuncRelaCond.IsUpdated(convFeatureFuncRela.FuncCodeTypeName) == true)
{
string strComparisonOpFuncCodeTypeName = objvFeatureFuncRelaCond.dicFldComparisonOp[convFeatureFuncRela.FuncCodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela.FuncCodeTypeName, objvFeatureFuncRelaCond.FuncCodeTypeName, strComparisonOpFuncCodeTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v功能函数关系(vFeatureFuncRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFuncRelaWApi
{
private static readonly string mstrApiControllerName = "vFeatureFuncRelaApi";

 public clsvFeatureFuncRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFuncRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFeatureFuncRelaEN objvFeatureFuncRelaEN;
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
objvFeatureFuncRelaEN = JsonConvert.DeserializeObject<clsvFeatureFuncRelaEN>(strJson);
return objvFeatureFuncRelaEN;
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
public static clsvFeatureFuncRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFeatureFuncRelaEN objvFeatureFuncRelaEN;
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
objvFeatureFuncRelaEN = JsonConvert.DeserializeObject<clsvFeatureFuncRelaEN>(strJson);
return objvFeatureFuncRelaEN;
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
public static List<clsvFeatureFuncRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
public static List<clsvFeatureFuncRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFeatureFuncRelaEN>>(strJson);
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
 /// <param name = "objvFeatureFuncRelaENS">源对象</param>
 /// <param name = "objvFeatureFuncRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureFuncRelaEN objvFeatureFuncRelaENS, clsvFeatureFuncRelaEN objvFeatureFuncRelaENT)
{
try
{
objvFeatureFuncRelaENT.mId = objvFeatureFuncRelaENS.mId; //mId
objvFeatureFuncRelaENT.ApplicationTypeId = objvFeatureFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureFuncRelaENT.ApplicationTypeName = objvFeatureFuncRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureFuncRelaENT.ProgLangTypeName = objvFeatureFuncRelaENS.ProgLangTypeName; //编程语言类型名
objvFeatureFuncRelaENT.FeatureId = objvFeatureFuncRelaENS.FeatureId; //功能Id
objvFeatureFuncRelaENT.FeatureName = objvFeatureFuncRelaENS.FeatureName; //功能名称
objvFeatureFuncRelaENT.KeyWords = objvFeatureFuncRelaENS.KeyWords; //关键字
objvFeatureFuncRelaENT.FeatureTypeId = objvFeatureFuncRelaENS.FeatureTypeId; //功能类型Id
objvFeatureFuncRelaENT.FeatureTypeName = objvFeatureFuncRelaENS.FeatureTypeName; //功能类型名称
objvFeatureFuncRelaENT.FeatureName2 = objvFeatureFuncRelaENS.FeatureName2; //功能名-FuncCount
objvFeatureFuncRelaENT.FuncId4GC = objvFeatureFuncRelaENS.FuncId4GC; //函数ID
objvFeatureFuncRelaENT.FuncName = objvFeatureFuncRelaENS.FuncName; //函数名
objvFeatureFuncRelaENT.FuncId4Code = objvFeatureFuncRelaENS.FuncId4Code; //函数Id4Code
objvFeatureFuncRelaENT.FuncName4Code = objvFeatureFuncRelaENS.FuncName4Code; //函数名4Code
objvFeatureFuncRelaENT.FunctionSignature = objvFeatureFuncRelaENS.FunctionSignature; //函数签名
objvFeatureFuncRelaENT.OrderNum = objvFeatureFuncRelaENS.OrderNum; //序号
objvFeatureFuncRelaENT.UpdDate = objvFeatureFuncRelaENS.UpdDate; //修改日期
objvFeatureFuncRelaENT.UpdUser = objvFeatureFuncRelaENS.UpdUser; //修改者
objvFeatureFuncRelaENT.Memo = objvFeatureFuncRelaENS.Memo; //说明
objvFeatureFuncRelaENT.FuncCodeTypeENName = objvFeatureFuncRelaENS.FuncCodeTypeENName; //FuncCodeTypeENName
objvFeatureFuncRelaENT.FuncCodeTypeId = objvFeatureFuncRelaENS.FuncCodeTypeId; //函数代码类型Id
objvFeatureFuncRelaENT.FuncCodeTypeName = objvFeatureFuncRelaENS.FuncCodeTypeName; //FuncCodeTypeName
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
public static DataTable ToDataTable(List<clsvFeatureFuncRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFeatureFuncRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFeatureFuncRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFeatureFuncRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFeatureFuncRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFeatureFuncRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvFeatureFuncRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFeatureFuncRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFeatureFuncRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureFuncRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FeatureName2, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FunctionSignature, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFeatureFuncRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncCodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncCodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFeatureFuncRela.FuncCodeTypeName, Type.GetType("System.String"));
foreach (clsvFeatureFuncRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFeatureFuncRela.mId] = objInFor[convFeatureFuncRela.mId];
objDR[convFeatureFuncRela.ApplicationTypeId] = objInFor[convFeatureFuncRela.ApplicationTypeId];
objDR[convFeatureFuncRela.ApplicationTypeName] = objInFor[convFeatureFuncRela.ApplicationTypeName];
objDR[convFeatureFuncRela.ProgLangTypeName] = objInFor[convFeatureFuncRela.ProgLangTypeName];
objDR[convFeatureFuncRela.FeatureId] = objInFor[convFeatureFuncRela.FeatureId];
objDR[convFeatureFuncRela.FeatureName] = objInFor[convFeatureFuncRela.FeatureName];
objDR[convFeatureFuncRela.KeyWords] = objInFor[convFeatureFuncRela.KeyWords];
objDR[convFeatureFuncRela.FeatureTypeId] = objInFor[convFeatureFuncRela.FeatureTypeId];
objDR[convFeatureFuncRela.FeatureTypeName] = objInFor[convFeatureFuncRela.FeatureTypeName];
objDR[convFeatureFuncRela.FeatureName2] = objInFor[convFeatureFuncRela.FeatureName2];
objDR[convFeatureFuncRela.FuncId4GC] = objInFor[convFeatureFuncRela.FuncId4GC];
objDR[convFeatureFuncRela.FuncName] = objInFor[convFeatureFuncRela.FuncName];
objDR[convFeatureFuncRela.FuncId4Code] = objInFor[convFeatureFuncRela.FuncId4Code];
objDR[convFeatureFuncRela.FuncName4Code] = objInFor[convFeatureFuncRela.FuncName4Code];
objDR[convFeatureFuncRela.FunctionSignature] = objInFor[convFeatureFuncRela.FunctionSignature];
objDR[convFeatureFuncRela.OrderNum] = objInFor[convFeatureFuncRela.OrderNum];
objDR[convFeatureFuncRela.UpdDate] = objInFor[convFeatureFuncRela.UpdDate];
objDR[convFeatureFuncRela.UpdUser] = objInFor[convFeatureFuncRela.UpdUser];
objDR[convFeatureFuncRela.Memo] = objInFor[convFeatureFuncRela.Memo];
objDR[convFeatureFuncRela.FuncCodeTypeENName] = objInFor[convFeatureFuncRela.FuncCodeTypeENName];
objDR[convFeatureFuncRela.FuncCodeTypeId] = objInFor[convFeatureFuncRela.FuncCodeTypeId];
objDR[convFeatureFuncRela.FuncCodeTypeName] = objInFor[convFeatureFuncRela.FuncCodeTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}