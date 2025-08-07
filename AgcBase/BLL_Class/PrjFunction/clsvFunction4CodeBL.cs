
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4CodeBL
 表名:vFunction4Code(00050387)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunction4CodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4CodeEN GetObj(this K_FuncId4Code_vFunction4Code myKey)
{
clsvFunction4CodeEN objvFunction4CodeEN = clsvFunction4CodeBL.vFunction4CodeDA.GetObjByFuncId4Code(myKey.Value);
return objvFunction4CodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncId4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4Code.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4Code.FuncId4Code);
}
objvFunction4CodeEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncId4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncName4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFunction4Code.FuncName4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunction4Code.FuncName4Code);
}
objvFunction4CodeEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncName4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncName4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncName4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncCHName4Code(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncCHName4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunction4Code.FuncCHName4Code);
}
objvFunction4CodeEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncCHName4Code) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetPrevFuncId(this clsvFunction4CodeEN objvFunction4CodeEN, string strPrevFuncId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrevFuncId, 8, convFunction4Code.PrevFuncId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrevFuncId, 8, convFunction4Code.PrevFuncId);
}
objvFunction4CodeEN.PrevFuncId = strPrevFuncId; //前函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.PrevFuncId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.PrevFuncId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.PrevFuncId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetRootFuncId(this clsvFunction4CodeEN objvFunction4CodeEN, string strRootFuncId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootFuncId, 8, convFunction4Code.RootFuncId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootFuncId, 8, convFunction4Code.RootFuncId);
}
objvFunction4CodeEN.RootFuncId = strRootFuncId; //根函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.RootFuncId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.RootFuncId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.RootFuncId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetApplicationTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFunction4Code.ApplicationTypeId);
objvFunction4CodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ApplicationTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ApplicationTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ApplicationTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetApplicationTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFunction4Code.ApplicationTypeName);
}
objvFunction4CodeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ApplicationTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ApplicationTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ApplicationTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncGCTypeId, convFunction4Code.FuncGCTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4Code.FuncGCTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4Code.FuncGCTypeId);
}
objvFunction4CodeEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeName, 50, convFunction4Code.FuncGCTypeName);
}
objvFunction4CodeEN.FuncGCTypeName = strFuncGCTypeName; //函数生成代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncGCTypeENName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncGCTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncGCTypeENName, 50, convFunction4Code.FuncGCTypeENName);
}
objvFunction4CodeEN.FuncGCTypeENName = strFuncGCTypeENName; //函数生成代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncGCTypeENName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncGCTypeENName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncGCTypeENName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunctionSignature(this clsvFunction4CodeEN objvFunction4CodeEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convFunction4Code.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFunction4Code.FunctionSignature);
}
objvFunction4CodeEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FunctionSignature) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FunctionSignature, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FunctionSignature] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunctionSignatureSim(this clsvFunction4CodeEN objvFunction4CodeEN, string strFunctionSignatureSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignatureSim, 500, convFunction4Code.FunctionSignatureSim);
}
objvFunction4CodeEN.FunctionSignatureSim = strFunctionSignatureSim; //函数签名_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FunctionSignatureSim) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FunctionSignatureSim, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FunctionSignatureSim] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnType(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, convFunction4Code.ReturnType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, convFunction4Code.ReturnType);
}
objvFunction4CodeEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnType) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnType, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnType] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convFunction4Code.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convFunction4Code.ReturnTypeId);
}
objvFunction4CodeEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeNameCustom(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeNameCustom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeNameCustom, 50, convFunction4Code.ReturnTypeNameCustom);
}
objvFunction4CodeEN.ReturnTypeNameCustom = strReturnTypeNameCustom; //定制返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeNameCustom) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeNameCustom, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeNameCustom] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetCodeTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunction4Code.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunction4Code.CodeTypeId);
}
objvFunction4CodeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.CodeTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.CodeTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.CodeTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetCodeTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunction4Code.CodeTypeName);
}
objvFunction4CodeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.CodeTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.CodeTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.CodeTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetProgLangTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunction4Code.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunction4Code.ProgLangTypeId);
}
objvFunction4CodeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ProgLangTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncAccessModeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncAccessModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncAccessModeId, 2, convFunction4Code.FuncAccessModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncAccessModeId, 2, convFunction4Code.FuncAccessModeId);
}
objvFunction4CodeEN.FuncAccessModeId = strFuncAccessModeId; //函数操作模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncAccessModeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncAccessModeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncAccessModeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncAccessModeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncAccessModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncAccessModeName, 50, convFunction4Code.FuncAccessModeName);
}
objvFunction4CodeEN.FuncAccessModeName = strFuncAccessModeName; //函数操作模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncAccessModeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncAccessModeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncAccessModeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabName(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convFunction4Code.TabName);
}
objvFunction4CodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabId(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convFunction4Code.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convFunction4Code.TabId);
}
objvFunction4CodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncPurposeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, convFunction4Code.FuncPurposeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, convFunction4Code.FuncPurposeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, convFunction4Code.FuncPurposeId);
}
objvFunction4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncPurposeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncPurposeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncPurposeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncPurposeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncPurposeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncPurposeName, 20, convFunction4Code.FuncPurposeName);
}
objvFunction4CodeEN.FuncPurposeName = strFuncPurposeName; //函数用途名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncPurposeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncPurposeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncPurposeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncTypeId(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convFunction4Code.FuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunction4Code.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunction4Code.FuncTypeId);
}
objvFunction4CodeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncTypeId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncTypeId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncTypeId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFuncTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convFunction4Code.FuncTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunction4Code.FuncTypeName);
}
objvFunction4CodeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FuncTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FuncTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FuncTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetIsAsyncFunc(this clsvFunction4CodeEN objvFunction4CodeEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvFunction4CodeEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.IsAsyncFunc) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.IsAsyncFunc, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.IsAsyncFunc] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetIsSysFunction(this clsvFunction4CodeEN objvFunction4CodeEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objvFunction4CodeEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.IsSysFunction) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.IsSysFunction, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.IsSysFunction] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetOrderNum(this clsvFunction4CodeEN objvFunction4CodeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFunction4Code.OrderNum);
objvFunction4CodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.OrderNum) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.OrderNum, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.OrderNum] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetPrjId(this clsvFunction4CodeEN objvFunction4CodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFunction4Code.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFunction4Code.PrjId);
}
objvFunction4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.PrjId) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.PrjId, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.PrjId] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetUpdDate(this clsvFunction4CodeEN objvFunction4CodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunction4Code.UpdDate);
}
objvFunction4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.UpdDate) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.UpdDate, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.UpdDate] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetUpdUser(this clsvFunction4CodeEN objvFunction4CodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunction4Code.UpdUser);
}
objvFunction4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.UpdUser) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.UpdUser, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.UpdUser] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetMemo(this clsvFunction4CodeEN objvFunction4CodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunction4Code.Memo);
}
objvFunction4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.Memo) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.Memo, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.Memo] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetReturnTypeName(this clsvFunction4CodeEN objvFunction4CodeEN, string strReturnTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeName, 100, convFunction4Code.ReturnTypeName);
}
objvFunction4CodeEN.ReturnTypeName = strReturnTypeName; //返回类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ReturnTypeName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ReturnTypeName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ReturnTypeName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetTabName2(this clsvFunction4CodeEN objvFunction4CodeEN, string strTabName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName2, 100, convFunction4Code.TabName2);
}
objvFunction4CodeEN.TabName2 = strTabName2; //TabName2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.TabName2) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.TabName2, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.TabName2] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFunc4GCCount(this clsvFunction4CodeEN objvFunction4CodeEN, int? intFunc4GCCount, string strComparisonOp="")
	{
objvFunction4CodeEN.Func4GCCount = intFunc4GCCount; //函数4GC数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.Func4GCCount) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.Func4GCCount, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.Func4GCCount] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetParaNum(this clsvFunction4CodeEN objvFunction4CodeEN, int? intParaNum, string strComparisonOp="")
	{
objvFunction4CodeEN.ParaNum = intParaNum; //参数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ParaNum) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ParaNum, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ParaNum] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetFeatureCount(this clsvFunction4CodeEN objvFunction4CodeEN, int? intFeatureCount, string strComparisonOp="")
	{
objvFunction4CodeEN.FeatureCount = intFeatureCount; //功能数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.FeatureCount) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.FeatureCount, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.FeatureCount] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4CodeEN SetClsName(this clsvFunction4CodeEN objvFunction4CodeEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convFunction4Code.ClsName);
}
objvFunction4CodeEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4CodeEN.dicFldComparisonOp.ContainsKey(convFunction4Code.ClsName) == false)
{
objvFunction4CodeEN.dicFldComparisonOp.Add(convFunction4Code.ClsName, strComparisonOp);
}
else
{
objvFunction4CodeEN.dicFldComparisonOp[convFunction4Code.ClsName] = strComparisonOp;
}
}
return objvFunction4CodeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunction4CodeENS">源对象</param>
 /// <param name = "objvFunction4CodeENT">目标对象</param>
 public static void CopyTo(this clsvFunction4CodeEN objvFunction4CodeENS, clsvFunction4CodeEN objvFunction4CodeENT)
{
try
{
objvFunction4CodeENT.FuncId4Code = objvFunction4CodeENS.FuncId4Code; //函数Id4Code
objvFunction4CodeENT.FuncName4Code = objvFunction4CodeENS.FuncName4Code; //函数名4Code
objvFunction4CodeENT.FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4CodeENT.PrevFuncId = objvFunction4CodeENS.PrevFuncId; //前函数Id
objvFunction4CodeENT.RootFuncId = objvFunction4CodeENS.RootFuncId; //根函数Id
objvFunction4CodeENT.ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objvFunction4CodeENT.ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName; //应用程序类型名称
objvFunction4CodeENT.FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4CodeENT.FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4CodeENT.FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4CodeENT.FunctionSignature = objvFunction4CodeENS.FunctionSignature; //函数签名
objvFunction4CodeENT.FunctionSignatureSim = objvFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4CodeENT.ReturnType = objvFunction4CodeENS.ReturnType; //返回类型
objvFunction4CodeENT.ReturnTypeId = objvFunction4CodeENS.ReturnTypeId; //返回类型ID
objvFunction4CodeENT.ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objvFunction4CodeENT.CodeTypeId = objvFunction4CodeENS.CodeTypeId; //代码类型Id
objvFunction4CodeENT.CodeTypeName = objvFunction4CodeENS.CodeTypeName; //代码类型名
objvFunction4CodeENT.ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4CodeENT.FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objvFunction4CodeENT.FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName; //函数操作模式名
objvFunction4CodeENT.TabName = objvFunction4CodeENS.TabName; //表名
objvFunction4CodeENT.TabId = objvFunction4CodeENS.TabId; //表ID
objvFunction4CodeENT.FuncPurposeId = objvFunction4CodeENS.FuncPurposeId; //函数用途Id
objvFunction4CodeENT.FuncPurposeName = objvFunction4CodeENS.FuncPurposeName; //函数用途名
objvFunction4CodeENT.FuncTypeId = objvFunction4CodeENS.FuncTypeId; //函数类型Id
objvFunction4CodeENT.FuncTypeName = objvFunction4CodeENS.FuncTypeName; //函数类型名
objvFunction4CodeENT.IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc; //是否异步函数
objvFunction4CodeENT.IsSysFunction = objvFunction4CodeENS.IsSysFunction; //是否系统函数
objvFunction4CodeENT.OrderNum = objvFunction4CodeENS.OrderNum; //序号
objvFunction4CodeENT.PrjId = objvFunction4CodeENS.PrjId; //工程Id
objvFunction4CodeENT.UpdDate = objvFunction4CodeENS.UpdDate; //修改日期
objvFunction4CodeENT.UpdUser = objvFunction4CodeENS.UpdUser; //修改者
objvFunction4CodeENT.Memo = objvFunction4CodeENS.Memo; //说明
objvFunction4CodeENT.ReturnTypeName = objvFunction4CodeENS.ReturnTypeName; //返回类型名
objvFunction4CodeENT.TabName2 = objvFunction4CodeENS.TabName2; //TabName2
objvFunction4CodeENT.Func4GCCount = objvFunction4CodeENS.Func4GCCount; //函数4GC数
objvFunction4CodeENT.ParaNum = objvFunction4CodeENS.ParaNum; //参数个数
objvFunction4CodeENT.FeatureCount = objvFunction4CodeENS.FeatureCount; //功能数
objvFunction4CodeENT.ClsName = objvFunction4CodeENS.ClsName; //类名
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
 /// <param name = "objvFunction4CodeENS">源对象</param>
 /// <returns>目标对象=>clsvFunction4CodeEN:objvFunction4CodeENT</returns>
 public static clsvFunction4CodeEN CopyTo(this clsvFunction4CodeEN objvFunction4CodeENS)
{
try
{
 clsvFunction4CodeEN objvFunction4CodeENT = new clsvFunction4CodeEN()
{
FuncId4Code = objvFunction4CodeENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvFunction4CodeENS.FuncName4Code, //函数名4Code
FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code, //函数中文名4Code
PrevFuncId = objvFunction4CodeENS.PrevFuncId, //前函数Id
RootFuncId = objvFunction4CodeENS.RootFuncId, //根函数Id
ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName, //应用程序类型名称
FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId, //函数生成代码类型Id
FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName, //函数生成代码类型名
FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName, //函数生成代码类型英文名
FunctionSignature = objvFunction4CodeENS.FunctionSignature, //函数签名
FunctionSignatureSim = objvFunction4CodeENS.FunctionSignatureSim, //函数签名_Sim
ReturnType = objvFunction4CodeENS.ReturnType, //返回类型
ReturnTypeId = objvFunction4CodeENS.ReturnTypeId, //返回类型ID
ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom, //定制返回类型名
CodeTypeId = objvFunction4CodeENS.CodeTypeId, //代码类型Id
CodeTypeName = objvFunction4CodeENS.CodeTypeName, //代码类型名
ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId, //编程语言类型Id
FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId, //函数操作模式Id
FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName, //函数操作模式名
TabName = objvFunction4CodeENS.TabName, //表名
TabId = objvFunction4CodeENS.TabId, //表ID
FuncPurposeId = objvFunction4CodeENS.FuncPurposeId, //函数用途Id
FuncPurposeName = objvFunction4CodeENS.FuncPurposeName, //函数用途名
FuncTypeId = objvFunction4CodeENS.FuncTypeId, //函数类型Id
FuncTypeName = objvFunction4CodeENS.FuncTypeName, //函数类型名
IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc, //是否异步函数
IsSysFunction = objvFunction4CodeENS.IsSysFunction, //是否系统函数
OrderNum = objvFunction4CodeENS.OrderNum, //序号
PrjId = objvFunction4CodeENS.PrjId, //工程Id
UpdDate = objvFunction4CodeENS.UpdDate, //修改日期
UpdUser = objvFunction4CodeENS.UpdUser, //修改者
Memo = objvFunction4CodeENS.Memo, //说明
ReturnTypeName = objvFunction4CodeENS.ReturnTypeName, //返回类型名
TabName2 = objvFunction4CodeENS.TabName2, //TabName2
Func4GCCount = objvFunction4CodeENS.Func4GCCount, //函数4GC数
ParaNum = objvFunction4CodeENS.ParaNum, //参数个数
FeatureCount = objvFunction4CodeENS.FeatureCount, //功能数
ClsName = objvFunction4CodeENS.ClsName, //类名
};
 return objvFunction4CodeENT;
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
public static void CheckProperty4Condition(this clsvFunction4CodeEN objvFunction4CodeEN)
{
 clsvFunction4CodeBL.vFunction4CodeDA.CheckProperty4Condition(objvFunction4CodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4CodeEN objvFunction4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncId4Code, objvFunction4CodeCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncName4Code, objvFunction4CodeCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncCHName4Code, objvFunction4CodeCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.PrevFuncId) == true)
{
string strComparisonOpPrevFuncId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.PrevFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.PrevFuncId, objvFunction4CodeCond.PrevFuncId, strComparisonOpPrevFuncId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.RootFuncId) == true)
{
string strComparisonOpRootFuncId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.RootFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.RootFuncId, objvFunction4CodeCond.RootFuncId, strComparisonOpRootFuncId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.ApplicationTypeId, objvFunction4CodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ApplicationTypeName, objvFunction4CodeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeId, objvFunction4CodeCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeName) == true)
{
string strComparisonOpFuncGCTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeName, objvFunction4CodeCond.FuncGCTypeName, strComparisonOpFuncGCTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncGCTypeENName) == true)
{
string strComparisonOpFuncGCTypeENName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncGCTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncGCTypeENName, objvFunction4CodeCond.FuncGCTypeENName, strComparisonOpFuncGCTypeENName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FunctionSignature, objvFunction4CodeCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FunctionSignatureSim) == true)
{
string strComparisonOpFunctionSignatureSim = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FunctionSignatureSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FunctionSignatureSim, objvFunction4CodeCond.FunctionSignatureSim, strComparisonOpFunctionSignatureSim);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnType) == true)
{
string strComparisonOpReturnType = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnType, objvFunction4CodeCond.ReturnType, strComparisonOpReturnType);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeId, objvFunction4CodeCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeNameCustom) == true)
{
string strComparisonOpReturnTypeNameCustom = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeNameCustom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeNameCustom, objvFunction4CodeCond.ReturnTypeNameCustom, strComparisonOpReturnTypeNameCustom);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.CodeTypeId, objvFunction4CodeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.CodeTypeName, objvFunction4CodeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ProgLangTypeId, objvFunction4CodeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncAccessModeId) == true)
{
string strComparisonOpFuncAccessModeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncAccessModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncAccessModeId, objvFunction4CodeCond.FuncAccessModeId, strComparisonOpFuncAccessModeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncAccessModeName) == true)
{
string strComparisonOpFuncAccessModeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncAccessModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncAccessModeName, objvFunction4CodeCond.FuncAccessModeName, strComparisonOpFuncAccessModeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabName) == true)
{
string strComparisonOpTabName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabName, objvFunction4CodeCond.TabName, strComparisonOpTabName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabId) == true)
{
string strComparisonOpTabId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabId, objvFunction4CodeCond.TabId, strComparisonOpTabId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncPurposeId, objvFunction4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncPurposeName) == true)
{
string strComparisonOpFuncPurposeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncPurposeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncPurposeName, objvFunction4CodeCond.FuncPurposeName, strComparisonOpFuncPurposeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncTypeId, objvFunction4CodeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.FuncTypeName, objvFunction4CodeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.IsAsyncFunc) == true)
{
if (objvFunction4CodeCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4Code.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4Code.IsAsyncFunc);
}
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.IsSysFunction) == true)
{
if (objvFunction4CodeCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunction4Code.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunction4Code.IsSysFunction);
}
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.OrderNum, objvFunction4CodeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.PrjId) == true)
{
string strComparisonOpPrjId = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.PrjId, objvFunction4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.UpdDate, objvFunction4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.UpdUser, objvFunction4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.Memo) == true)
{
string strComparisonOpMemo = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.Memo, objvFunction4CodeCond.Memo, strComparisonOpMemo);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ReturnTypeName) == true)
{
string strComparisonOpReturnTypeName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ReturnTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ReturnTypeName, objvFunction4CodeCond.ReturnTypeName, strComparisonOpReturnTypeName);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.TabName2) == true)
{
string strComparisonOpTabName2 = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.TabName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.TabName2, objvFunction4CodeCond.TabName2, strComparisonOpTabName2);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.Func4GCCount) == true)
{
string strComparisonOpFunc4GCCount = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.Func4GCCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.Func4GCCount, objvFunction4CodeCond.Func4GCCount, strComparisonOpFunc4GCCount);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ParaNum) == true)
{
string strComparisonOpParaNum = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ParaNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.ParaNum, objvFunction4CodeCond.ParaNum, strComparisonOpParaNum);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.FeatureCount) == true)
{
string strComparisonOpFeatureCount = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.FeatureCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code.FeatureCount, objvFunction4CodeCond.FeatureCount, strComparisonOpFeatureCount);
}
if (objvFunction4CodeCond.IsUpdated(convFunction4Code.ClsName) == true)
{
string strComparisonOpClsName = objvFunction4CodeCond.dicFldComparisonOp[convFunction4Code.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code.ClsName, objvFunction4CodeCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunction4Code
{
public virtual bool UpdRelaTabDate(string strFuncId4Code, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数4Code(vFunction4Code)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4CodeBL
{
public static RelatedActions_vFunction4Code relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunction4CodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunction4CodeDA vFunction4CodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunction4CodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunction4CodeBL()
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
if (string.IsNullOrEmpty(clsvFunction4CodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4CodeEN._ConnectString);
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
public static DataTable GetDataTable_vFunction4Code(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunction4CodeDA.GetDataTable_vFunction4Code(strWhereCond);
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
objDT = vFunction4CodeDA.GetDataTable(strWhereCond);
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
objDT = vFunction4CodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunction4CodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunction4CodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunction4CodeDA.GetDataTable_Top(objTopPara);
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
objDT = vFunction4CodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunction4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunction4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLstByFuncId4CodeLst(List<string> arrFuncId4CodeLst)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncId4CodeLst, true);
 string strWhereCond = string.Format("FuncId4Code in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunction4CodeEN> GetObjLstByFuncId4CodeLstCache(List<string> arrFuncId4CodeLst)
{
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel =
arrvFunction4CodeObjLstCache
.Where(x => arrFuncId4CodeLst.Contains(x.FuncId4Code));
return arrvFunction4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLst(string strWhereCond)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
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
public static List<clsvFunction4CodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunction4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunction4CodeEN> GetSubObjLstCache(clsvFunction4CodeEN objvFunction4CodeCond)
{
List<clsvFunction4CodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4Code._AttributeName)
{
if (objvFunction4CodeCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4CodeCond[strFldName].ToString());
}
else
{
if (objvFunction4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4CodeCond[strFldName]));
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
public static List<clsvFunction4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
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
public static List<clsvFunction4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
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
List<clsvFunction4CodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunction4CodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4CodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunction4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
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
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
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
public static List<clsvFunction4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunction4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
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
public static List<clsvFunction4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunction4CodeEN.FuncId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunction4Code(ref clsvFunction4CodeEN objvFunction4CodeEN)
{
bool bolResult = vFunction4CodeDA.GetvFunction4Code(ref objvFunction4CodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
if (strFuncId4Code.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId4Code]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId4Code]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunction4CodeEN objvFunction4CodeEN = vFunction4CodeDA.GetObjByFuncId4Code(strFuncId4Code);
return objvFunction4CodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunction4CodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunction4CodeEN objvFunction4CodeEN = vFunction4CodeDA.GetFirstObj(strWhereCond);
 return objvFunction4CodeEN;
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
public static clsvFunction4CodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunction4CodeEN objvFunction4CodeEN = vFunction4CodeDA.GetObjByDataRow(objRow);
 return objvFunction4CodeEN;
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
public static clsvFunction4CodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunction4CodeEN objvFunction4CodeEN = vFunction4CodeDA.GetObjByDataRow(objRow);
 return objvFunction4CodeEN;
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
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <param name = "lstvFunction4CodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4CodeEN GetObjByFuncId4CodeFromList(string strFuncId4Code, List<clsvFunction4CodeEN> lstvFunction4CodeObjLst)
{
foreach (clsvFunction4CodeEN objvFunction4CodeEN in lstvFunction4CodeObjLst)
{
if (objvFunction4CodeEN.FuncId4Code == strFuncId4Code)
{
return objvFunction4CodeEN;
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
 string strFuncId4Code;
 try
 {
 strFuncId4Code = new clsvFunction4CodeDA().GetFirstID(strWhereCond);
 return strFuncId4Code;
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
 arrList = vFunction4CodeDA.GetID(strWhereCond);
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
bool bolIsExist = vFunction4CodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId4Code]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFunction4CodeDA.IsExist(strFuncId4Code);
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
 bolIsExist = clsvFunction4CodeDA.IsExistTable();
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
 bolIsExist = vFunction4CodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunction4CodeENS">源对象</param>
 /// <param name = "objvFunction4CodeENT">目标对象</param>
 public static void CopyTo(clsvFunction4CodeEN objvFunction4CodeENS, clsvFunction4CodeEN objvFunction4CodeENT)
{
try
{
objvFunction4CodeENT.FuncId4Code = objvFunction4CodeENS.FuncId4Code; //函数Id4Code
objvFunction4CodeENT.FuncName4Code = objvFunction4CodeENS.FuncName4Code; //函数名4Code
objvFunction4CodeENT.FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4CodeENT.PrevFuncId = objvFunction4CodeENS.PrevFuncId; //前函数Id
objvFunction4CodeENT.RootFuncId = objvFunction4CodeENS.RootFuncId; //根函数Id
objvFunction4CodeENT.ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objvFunction4CodeENT.ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName; //应用程序类型名称
objvFunction4CodeENT.FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4CodeENT.FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4CodeENT.FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4CodeENT.FunctionSignature = objvFunction4CodeENS.FunctionSignature; //函数签名
objvFunction4CodeENT.FunctionSignatureSim = objvFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4CodeENT.ReturnType = objvFunction4CodeENS.ReturnType; //返回类型
objvFunction4CodeENT.ReturnTypeId = objvFunction4CodeENS.ReturnTypeId; //返回类型ID
objvFunction4CodeENT.ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objvFunction4CodeENT.CodeTypeId = objvFunction4CodeENS.CodeTypeId; //代码类型Id
objvFunction4CodeENT.CodeTypeName = objvFunction4CodeENS.CodeTypeName; //代码类型名
objvFunction4CodeENT.ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4CodeENT.FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objvFunction4CodeENT.FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName; //函数操作模式名
objvFunction4CodeENT.TabName = objvFunction4CodeENS.TabName; //表名
objvFunction4CodeENT.TabId = objvFunction4CodeENS.TabId; //表ID
objvFunction4CodeENT.FuncPurposeId = objvFunction4CodeENS.FuncPurposeId; //函数用途Id
objvFunction4CodeENT.FuncPurposeName = objvFunction4CodeENS.FuncPurposeName; //函数用途名
objvFunction4CodeENT.FuncTypeId = objvFunction4CodeENS.FuncTypeId; //函数类型Id
objvFunction4CodeENT.FuncTypeName = objvFunction4CodeENS.FuncTypeName; //函数类型名
objvFunction4CodeENT.IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc; //是否异步函数
objvFunction4CodeENT.IsSysFunction = objvFunction4CodeENS.IsSysFunction; //是否系统函数
objvFunction4CodeENT.OrderNum = objvFunction4CodeENS.OrderNum; //序号
objvFunction4CodeENT.PrjId = objvFunction4CodeENS.PrjId; //工程Id
objvFunction4CodeENT.UpdDate = objvFunction4CodeENS.UpdDate; //修改日期
objvFunction4CodeENT.UpdUser = objvFunction4CodeENS.UpdUser; //修改者
objvFunction4CodeENT.Memo = objvFunction4CodeENS.Memo; //说明
objvFunction4CodeENT.ReturnTypeName = objvFunction4CodeENS.ReturnTypeName; //返回类型名
objvFunction4CodeENT.TabName2 = objvFunction4CodeENS.TabName2; //TabName2
objvFunction4CodeENT.Func4GCCount = objvFunction4CodeENS.Func4GCCount; //函数4GC数
objvFunction4CodeENT.ParaNum = objvFunction4CodeENS.ParaNum; //参数个数
objvFunction4CodeENT.FeatureCount = objvFunction4CodeENS.FeatureCount; //功能数
objvFunction4CodeENT.ClsName = objvFunction4CodeENS.ClsName; //类名
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
 /// <param name = "objvFunction4CodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunction4CodeEN objvFunction4CodeEN)
{
try
{
objvFunction4CodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunction4CodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunction4Code.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncId4Code = objvFunction4CodeEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFunction4Code.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncName4Code = objvFunction4CodeEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convFunction4Code.FuncCHName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncCHName4Code = objvFunction4CodeEN.FuncCHName4Code == "[null]" ? null :  objvFunction4CodeEN.FuncCHName4Code; //函数中文名4Code
}
if (arrFldSet.Contains(convFunction4Code.PrevFuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.PrevFuncId = objvFunction4CodeEN.PrevFuncId == "[null]" ? null :  objvFunction4CodeEN.PrevFuncId; //前函数Id
}
if (arrFldSet.Contains(convFunction4Code.RootFuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.RootFuncId = objvFunction4CodeEN.RootFuncId == "[null]" ? null :  objvFunction4CodeEN.RootFuncId; //根函数Id
}
if (arrFldSet.Contains(convFunction4Code.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ApplicationTypeId = objvFunction4CodeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convFunction4Code.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ApplicationTypeName = objvFunction4CodeEN.ApplicationTypeName == "[null]" ? null :  objvFunction4CodeEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convFunction4Code.FuncGCTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncGCTypeId = objvFunction4CodeEN.FuncGCTypeId; //函数生成代码类型Id
}
if (arrFldSet.Contains(convFunction4Code.FuncGCTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncGCTypeName = objvFunction4CodeEN.FuncGCTypeName == "[null]" ? null :  objvFunction4CodeEN.FuncGCTypeName; //函数生成代码类型名
}
if (arrFldSet.Contains(convFunction4Code.FuncGCTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncGCTypeENName = objvFunction4CodeEN.FuncGCTypeENName == "[null]" ? null :  objvFunction4CodeEN.FuncGCTypeENName; //函数生成代码类型英文名
}
if (arrFldSet.Contains(convFunction4Code.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FunctionSignature = objvFunction4CodeEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convFunction4Code.FunctionSignatureSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FunctionSignatureSim = objvFunction4CodeEN.FunctionSignatureSim == "[null]" ? null :  objvFunction4CodeEN.FunctionSignatureSim; //函数签名_Sim
}
if (arrFldSet.Contains(convFunction4Code.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ReturnType = objvFunction4CodeEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(convFunction4Code.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ReturnTypeId = objvFunction4CodeEN.ReturnTypeId == "[null]" ? null :  objvFunction4CodeEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convFunction4Code.ReturnTypeNameCustom, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ReturnTypeNameCustom = objvFunction4CodeEN.ReturnTypeNameCustom == "[null]" ? null :  objvFunction4CodeEN.ReturnTypeNameCustom; //定制返回类型名
}
if (arrFldSet.Contains(convFunction4Code.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.CodeTypeId = objvFunction4CodeEN.CodeTypeId == "[null]" ? null :  objvFunction4CodeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convFunction4Code.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.CodeTypeName = objvFunction4CodeEN.CodeTypeName == "[null]" ? null :  objvFunction4CodeEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convFunction4Code.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ProgLangTypeId = objvFunction4CodeEN.ProgLangTypeId == "[null]" ? null :  objvFunction4CodeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunction4Code.FuncAccessModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncAccessModeId = objvFunction4CodeEN.FuncAccessModeId == "[null]" ? null :  objvFunction4CodeEN.FuncAccessModeId; //函数操作模式Id
}
if (arrFldSet.Contains(convFunction4Code.FuncAccessModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncAccessModeName = objvFunction4CodeEN.FuncAccessModeName == "[null]" ? null :  objvFunction4CodeEN.FuncAccessModeName; //函数操作模式名
}
if (arrFldSet.Contains(convFunction4Code.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.TabName = objvFunction4CodeEN.TabName == "[null]" ? null :  objvFunction4CodeEN.TabName; //表名
}
if (arrFldSet.Contains(convFunction4Code.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.TabId = objvFunction4CodeEN.TabId == "[null]" ? null :  objvFunction4CodeEN.TabId; //表ID
}
if (arrFldSet.Contains(convFunction4Code.FuncPurposeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncPurposeId = objvFunction4CodeEN.FuncPurposeId; //函数用途Id
}
if (arrFldSet.Contains(convFunction4Code.FuncPurposeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncPurposeName = objvFunction4CodeEN.FuncPurposeName == "[null]" ? null :  objvFunction4CodeEN.FuncPurposeName; //函数用途名
}
if (arrFldSet.Contains(convFunction4Code.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncTypeId = objvFunction4CodeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convFunction4Code.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FuncTypeName = objvFunction4CodeEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convFunction4Code.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.IsAsyncFunc = objvFunction4CodeEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(convFunction4Code.IsSysFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.IsSysFunction = objvFunction4CodeEN.IsSysFunction; //是否系统函数
}
if (arrFldSet.Contains(convFunction4Code.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.OrderNum = objvFunction4CodeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFunction4Code.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.PrjId = objvFunction4CodeEN.PrjId == "[null]" ? null :  objvFunction4CodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFunction4Code.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.UpdDate = objvFunction4CodeEN.UpdDate == "[null]" ? null :  objvFunction4CodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunction4Code.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.UpdUser = objvFunction4CodeEN.UpdUser == "[null]" ? null :  objvFunction4CodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunction4Code.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.Memo = objvFunction4CodeEN.Memo == "[null]" ? null :  objvFunction4CodeEN.Memo; //说明
}
if (arrFldSet.Contains(convFunction4Code.ReturnTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ReturnTypeName = objvFunction4CodeEN.ReturnTypeName == "[null]" ? null :  objvFunction4CodeEN.ReturnTypeName; //返回类型名
}
if (arrFldSet.Contains(convFunction4Code.TabName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.TabName2 = objvFunction4CodeEN.TabName2 == "[null]" ? null :  objvFunction4CodeEN.TabName2; //TabName2
}
if (arrFldSet.Contains(convFunction4Code.Func4GCCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.Func4GCCount = objvFunction4CodeEN.Func4GCCount; //函数4GC数
}
if (arrFldSet.Contains(convFunction4Code.ParaNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ParaNum = objvFunction4CodeEN.ParaNum; //参数个数
}
if (arrFldSet.Contains(convFunction4Code.FeatureCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.FeatureCount = objvFunction4CodeEN.FeatureCount; //功能数
}
if (arrFldSet.Contains(convFunction4Code.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunction4CodeEN.ClsName = objvFunction4CodeEN.ClsName == "[null]" ? null :  objvFunction4CodeEN.ClsName; //类名
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
 /// <param name = "objvFunction4CodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunction4CodeEN objvFunction4CodeEN)
{
try
{
if (objvFunction4CodeEN.FuncCHName4Code == "[null]") objvFunction4CodeEN.FuncCHName4Code = null; //函数中文名4Code
if (objvFunction4CodeEN.PrevFuncId == "[null]") objvFunction4CodeEN.PrevFuncId = null; //前函数Id
if (objvFunction4CodeEN.RootFuncId == "[null]") objvFunction4CodeEN.RootFuncId = null; //根函数Id
if (objvFunction4CodeEN.ApplicationTypeName == "[null]") objvFunction4CodeEN.ApplicationTypeName = null; //应用程序类型名称
if (objvFunction4CodeEN.FuncGCTypeName == "[null]") objvFunction4CodeEN.FuncGCTypeName = null; //函数生成代码类型名
if (objvFunction4CodeEN.FuncGCTypeENName == "[null]") objvFunction4CodeEN.FuncGCTypeENName = null; //函数生成代码类型英文名
if (objvFunction4CodeEN.FunctionSignatureSim == "[null]") objvFunction4CodeEN.FunctionSignatureSim = null; //函数签名_Sim
if (objvFunction4CodeEN.ReturnTypeId == "[null]") objvFunction4CodeEN.ReturnTypeId = null; //返回类型ID
if (objvFunction4CodeEN.ReturnTypeNameCustom == "[null]") objvFunction4CodeEN.ReturnTypeNameCustom = null; //定制返回类型名
if (objvFunction4CodeEN.CodeTypeId == "[null]") objvFunction4CodeEN.CodeTypeId = null; //代码类型Id
if (objvFunction4CodeEN.CodeTypeName == "[null]") objvFunction4CodeEN.CodeTypeName = null; //代码类型名
if (objvFunction4CodeEN.ProgLangTypeId == "[null]") objvFunction4CodeEN.ProgLangTypeId = null; //编程语言类型Id
if (objvFunction4CodeEN.FuncAccessModeId == "[null]") objvFunction4CodeEN.FuncAccessModeId = null; //函数操作模式Id
if (objvFunction4CodeEN.FuncAccessModeName == "[null]") objvFunction4CodeEN.FuncAccessModeName = null; //函数操作模式名
if (objvFunction4CodeEN.TabName == "[null]") objvFunction4CodeEN.TabName = null; //表名
if (objvFunction4CodeEN.TabId == "[null]") objvFunction4CodeEN.TabId = null; //表ID
if (objvFunction4CodeEN.FuncPurposeName == "[null]") objvFunction4CodeEN.FuncPurposeName = null; //函数用途名
if (objvFunction4CodeEN.PrjId == "[null]") objvFunction4CodeEN.PrjId = null; //工程Id
if (objvFunction4CodeEN.UpdDate == "[null]") objvFunction4CodeEN.UpdDate = null; //修改日期
if (objvFunction4CodeEN.UpdUser == "[null]") objvFunction4CodeEN.UpdUser = null; //修改者
if (objvFunction4CodeEN.Memo == "[null]") objvFunction4CodeEN.Memo = null; //说明
if (objvFunction4CodeEN.ReturnTypeName == "[null]") objvFunction4CodeEN.ReturnTypeName = null; //返回类型名
if (objvFunction4CodeEN.TabName2 == "[null]") objvFunction4CodeEN.TabName2 = null; //TabName2
if (objvFunction4CodeEN.ClsName == "[null]") objvFunction4CodeEN.ClsName = null; //类名
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
public static void CheckProperty4Condition(clsvFunction4CodeEN objvFunction4CodeEN)
{
 vFunction4CodeDA.CheckProperty4Condition(objvFunction4CodeEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncGCTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncGCTypeBL没有刷新缓存机制(clsFuncGCTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncAccessModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncAccessModeBL没有刷新缓存机制(clsFuncAccessModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionPurposeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionPurposeBL没有刷新缓存机制(clsFunctionPurposeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId4Code");
//if (arrvFunction4CodeObjLstCache == null)
//{
//arrvFunction4CodeObjLstCache = vFunction4CodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4CodeEN GetObjByFuncId4CodeCache(string strFuncId4Code)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrvFunction4CodeObjLst_Sel =
arrvFunction4CodeObjLstCache
.Where(x=> x.FuncId4Code == strFuncId4Code 
);
if (arrvFunction4CodeObjLst_Sel.Count() == 0)
{
   clsvFunction4CodeEN obj = clsvFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunction4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4CodeEN> GetAllvFunction4CodeObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = GetObjLstCache(); 
return arrvFunction4CodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunction4CodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
List<clsvFunction4CodeEN> arrvFunction4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunction4CodeObjLstCache;
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
string strKey = string.Format("{0}", clsvFunction4CodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunction4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunction4CodeEN._RefreshTimeLst.Count == 0) return "";
return clsvFunction4CodeEN._RefreshTimeLst[clsvFunction4CodeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strFuncId4Code)
{
if (strInFldName != convFunction4Code.FuncId4Code)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunction4Code._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunction4Code._AttributeName));
throw new Exception(strMsg);
}
var objvFunction4Code = clsvFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
if (objvFunction4Code == null) return "";
return objvFunction4Code[strOutFldName].ToString();
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
int intRecCount = clsvFunction4CodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunction4CodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunction4CodeDA.GetRecCount();
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
int intRecCount = clsvFunction4CodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunction4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunction4CodeEN objvFunction4CodeCond)
{
List<clsvFunction4CodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunction4Code._AttributeName)
{
if (objvFunction4CodeCond.IsUpdated(strFldName) == false) continue;
if (objvFunction4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4CodeCond[strFldName].ToString());
}
else
{
if (objvFunction4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunction4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunction4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunction4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunction4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunction4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunction4CodeCond[strFldName]));
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
 List<string> arrList = clsvFunction4CodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunction4CodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunction4CodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}