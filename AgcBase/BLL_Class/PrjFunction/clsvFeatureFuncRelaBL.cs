
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRelaBL
 表名:vFeatureFuncRela(00050398)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:14:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvFeatureFuncRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFuncRelaEN GetObj(this K_mId_vFeatureFuncRela myKey)
{
clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = clsvFeatureFuncRelaBL.vFeatureFuncRelaDA.GetObjBymId(myKey.Value);
return objvFeatureFuncRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetApplicationTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureFuncRela.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetProgLangTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFeatureFuncRela.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureFuncRela.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureFuncRela.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureFuncRela.FeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureFuncRela.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureFuncRela.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetKeyWords(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureFuncRela.KeyWords);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureTypeId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFeatureFuncRela.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFeatureFuncRela.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFeatureFuncRela.FeatureTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureFuncRela.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureFuncRela.FeatureTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFeatureName2(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFeatureName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName2, 112, convFeatureFuncRela.FeatureName2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncId4GC(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFeatureFuncRela.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFeatureFuncRela.FuncId4GC);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFeatureFuncRela.FuncName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncId4Code(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convFeatureFuncRela.FuncId4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFeatureFuncRela.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFeatureFuncRela.FuncId4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncName4Code(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFeatureFuncRela.FuncName4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFeatureFuncRela.FuncName4Code);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFunctionSignature(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convFeatureFuncRela.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFeatureFuncRela.FunctionSignature);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetOrderNum(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetUpdDate(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureFuncRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetUpdUser(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureFuncRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetMemo(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureFuncRela.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeENName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeENName, 50, convFeatureFuncRela.FuncCodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeId(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, convFeatureFuncRela.FuncCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, convFeatureFuncRela.FuncCodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRelaEN SetFuncCodeTypeName(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN, string strFuncCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeName, 50, convFeatureFuncRela.FuncCodeTypeName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaENS">源对象</param>
 /// <param name = "objvFeatureFuncRelaENT">目标对象</param>
 public static void CopyTo(this clsvFeatureFuncRelaEN objvFeatureFuncRelaENS, clsvFeatureFuncRelaEN objvFeatureFuncRelaENT)
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
 /// <param name = "objvFeatureFuncRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFuncRelaEN:objvFeatureFuncRelaENT</returns>
 public static clsvFeatureFuncRelaEN CopyTo(this clsvFeatureFuncRelaEN objvFeatureFuncRelaENS)
{
try
{
 clsvFeatureFuncRelaEN objvFeatureFuncRelaENT = new clsvFeatureFuncRelaEN()
{
mId = objvFeatureFuncRelaENS.mId, //mId
ApplicationTypeId = objvFeatureFuncRelaENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvFeatureFuncRelaENS.ApplicationTypeName, //应用程序类型名称
ProgLangTypeName = objvFeatureFuncRelaENS.ProgLangTypeName, //编程语言类型名
FeatureId = objvFeatureFuncRelaENS.FeatureId, //功能Id
FeatureName = objvFeatureFuncRelaENS.FeatureName, //功能名称
KeyWords = objvFeatureFuncRelaENS.KeyWords, //关键字
FeatureTypeId = objvFeatureFuncRelaENS.FeatureTypeId, //功能类型Id
FeatureTypeName = objvFeatureFuncRelaENS.FeatureTypeName, //功能类型名称
FeatureName2 = objvFeatureFuncRelaENS.FeatureName2, //功能名-FuncCount
FuncId4GC = objvFeatureFuncRelaENS.FuncId4GC, //函数ID
FuncName = objvFeatureFuncRelaENS.FuncName, //函数名
FuncId4Code = objvFeatureFuncRelaENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvFeatureFuncRelaENS.FuncName4Code, //函数名4Code
FunctionSignature = objvFeatureFuncRelaENS.FunctionSignature, //函数签名
OrderNum = objvFeatureFuncRelaENS.OrderNum, //序号
UpdDate = objvFeatureFuncRelaENS.UpdDate, //修改日期
UpdUser = objvFeatureFuncRelaENS.UpdUser, //修改者
Memo = objvFeatureFuncRelaENS.Memo, //说明
FuncCodeTypeENName = objvFeatureFuncRelaENS.FuncCodeTypeENName, //FuncCodeTypeENName
FuncCodeTypeId = objvFeatureFuncRelaENS.FuncCodeTypeId, //函数代码类型Id
FuncCodeTypeName = objvFeatureFuncRelaENS.FuncCodeTypeName, //FuncCodeTypeName
};
 return objvFeatureFuncRelaENT;
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
public static void CheckProperty4Condition(this clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
 clsvFeatureFuncRelaBL.vFeatureFuncRelaDA.CheckProperty4Condition(objvFeatureFuncRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureFuncRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能函数关系(vFeatureFuncRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFuncRelaBL
{
public static RelatedActions_vFeatureFuncRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureFuncRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureFuncRelaDA vFeatureFuncRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureFuncRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureFuncRelaBL()
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
if (string.IsNullOrEmpty(clsvFeatureFuncRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureFuncRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureFuncRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureFuncRelaDA.GetDataTable_vFeatureFuncRela(strWhereCond);
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
objDT = vFeatureFuncRelaDA.GetDataTable(strWhereCond);
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
objDT = vFeatureFuncRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureFuncRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureFuncRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureFuncRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureFuncRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureFuncRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLst_Sel =
arrvFeatureFuncRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFeatureFuncRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
public static List<clsvFeatureFuncRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureFuncRelaEN> GetSubObjLstCache(clsvFeatureFuncRelaEN objvFeatureFuncRelaCond)
{
List<clsvFeatureFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFuncRela._AttributeName)
{
if (objvFeatureFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRelaCond[strFldName]));
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
List<clsvFeatureFuncRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureFuncRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
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
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
public static List<clsvFeatureFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
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
public static List<clsvFeatureFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureFuncRelaEN> arrObjLst = new List<clsvFeatureFuncRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = new clsvFeatureFuncRelaEN();
try
{
objvFeatureFuncRelaEN.mId = Int32.Parse(objRow[convFeatureFuncRela.mId].ToString().Trim()); //mId
objvFeatureFuncRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRelaEN.ApplicationTypeName = objRow[convFeatureFuncRela.ApplicationTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureFuncRelaEN.ProgLangTypeName = objRow[convFeatureFuncRela.ProgLangTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFeatureFuncRelaEN.FeatureId = objRow[convFeatureFuncRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRelaEN.FeatureName = objRow[convFeatureFuncRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFuncRelaEN.KeyWords = objRow[convFeatureFuncRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFuncRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFuncRelaEN.FeatureTypeId = objRow[convFeatureFuncRela.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureFuncRelaEN.FeatureTypeName = objRow[convFeatureFuncRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFuncRelaEN.FeatureName2 = objRow[convFeatureFuncRela.FeatureName2] == DBNull.Value ? null : objRow[convFeatureFuncRela.FeatureName2].ToString().Trim(); //功能名-FuncCount
objvFeatureFuncRelaEN.FuncId4GC = objRow[convFeatureFuncRela.FuncId4GC] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncId4GC].ToString().Trim(); //函数ID
objvFeatureFuncRelaEN.FuncName = objRow[convFeatureFuncRela.FuncName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncName].ToString().Trim(); //函数名
objvFeatureFuncRelaEN.FuncId4Code = objRow[convFeatureFuncRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFeatureFuncRelaEN.FuncName4Code = objRow[convFeatureFuncRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFeatureFuncRelaEN.FunctionSignature = objRow[convFeatureFuncRela.FunctionSignature].ToString().Trim(); //函数签名
objvFeatureFuncRelaEN.OrderNum = objRow[convFeatureFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela.OrderNum].ToString().Trim()); //序号
objvFeatureFuncRelaEN.UpdDate = objRow[convFeatureFuncRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFuncRelaEN.UpdUser = objRow[convFeatureFuncRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFuncRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFuncRelaEN.Memo = objRow[convFeatureFuncRela.Memo] == DBNull.Value ? null : objRow[convFeatureFuncRela.Memo].ToString().Trim(); //说明
objvFeatureFuncRelaEN.FuncCodeTypeENName = objRow[convFeatureFuncRela.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFeatureFuncRelaEN.FuncCodeTypeId = objRow[convFeatureFuncRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFeatureFuncRelaEN.FuncCodeTypeName = objRow[convFeatureFuncRela.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFeatureFuncRela.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureFuncRela(ref clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
bool bolResult = vFeatureFuncRelaDA.GetvFeatureFuncRela(ref objvFeatureFuncRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFuncRelaEN GetObjBymId(long lngmId)
{
clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = vFeatureFuncRelaDA.GetObjBymId(lngmId);
return objvFeatureFuncRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureFuncRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = vFeatureFuncRelaDA.GetFirstObj(strWhereCond);
 return objvFeatureFuncRelaEN;
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
public static clsvFeatureFuncRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = vFeatureFuncRelaDA.GetObjByDataRow(objRow);
 return objvFeatureFuncRelaEN;
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
public static clsvFeatureFuncRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureFuncRelaEN objvFeatureFuncRelaEN = vFeatureFuncRelaDA.GetObjByDataRow(objRow);
 return objvFeatureFuncRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvFeatureFuncRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFuncRelaEN GetObjBymIdFromList(long lngmId, List<clsvFeatureFuncRelaEN> lstvFeatureFuncRelaObjLst)
{
foreach (clsvFeatureFuncRelaEN objvFeatureFuncRelaEN in lstvFeatureFuncRelaObjLst)
{
if (objvFeatureFuncRelaEN.mId == lngmId)
{
return objvFeatureFuncRelaEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvFeatureFuncRelaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vFeatureFuncRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureFuncRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vFeatureFuncRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFeatureFuncRelaDA.IsExistTable();
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
 bolIsExist = vFeatureFuncRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureFuncRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
try
{
objvFeatureFuncRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureFuncRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureFuncRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.mId = objvFeatureFuncRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFeatureFuncRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.ApplicationTypeId = objvFeatureFuncRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convFeatureFuncRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.ApplicationTypeName = objvFeatureFuncRelaEN.ApplicationTypeName == "[null]" ? null :  objvFeatureFuncRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convFeatureFuncRela.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.ProgLangTypeName = objvFeatureFuncRelaEN.ProgLangTypeName == "[null]" ? null :  objvFeatureFuncRelaEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convFeatureFuncRela.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FeatureId = objvFeatureFuncRelaEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureFuncRela.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FeatureName = objvFeatureFuncRelaEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureFuncRela.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.KeyWords = objvFeatureFuncRelaEN.KeyWords == "[null]" ? null :  objvFeatureFuncRelaEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFeatureFuncRela.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FeatureTypeId = objvFeatureFuncRelaEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convFeatureFuncRela.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FeatureTypeName = objvFeatureFuncRelaEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFeatureFuncRela.FeatureName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FeatureName2 = objvFeatureFuncRelaEN.FeatureName2 == "[null]" ? null :  objvFeatureFuncRelaEN.FeatureName2; //功能名-FuncCount
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncId4GC = objvFeatureFuncRelaEN.FuncId4GC == "[null]" ? null :  objvFeatureFuncRelaEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncName = objvFeatureFuncRelaEN.FuncName == "[null]" ? null :  objvFeatureFuncRelaEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncId4Code = objvFeatureFuncRelaEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncName4Code = objvFeatureFuncRelaEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convFeatureFuncRela.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FunctionSignature = objvFeatureFuncRelaEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convFeatureFuncRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.OrderNum = objvFeatureFuncRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFeatureFuncRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.UpdDate = objvFeatureFuncRelaEN.UpdDate == "[null]" ? null :  objvFeatureFuncRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureFuncRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.UpdUser = objvFeatureFuncRelaEN.UpdUser == "[null]" ? null :  objvFeatureFuncRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureFuncRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.Memo = objvFeatureFuncRelaEN.Memo == "[null]" ? null :  objvFeatureFuncRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncCodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncCodeTypeENName = objvFeatureFuncRelaEN.FuncCodeTypeENName == "[null]" ? null :  objvFeatureFuncRelaEN.FuncCodeTypeENName; //FuncCodeTypeENName
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncCodeTypeId = objvFeatureFuncRelaEN.FuncCodeTypeId == "[null]" ? null :  objvFeatureFuncRelaEN.FuncCodeTypeId; //函数代码类型Id
}
if (arrFldSet.Contains(convFeatureFuncRela.FuncCodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRelaEN.FuncCodeTypeName = objvFeatureFuncRelaEN.FuncCodeTypeName == "[null]" ? null :  objvFeatureFuncRelaEN.FuncCodeTypeName; //FuncCodeTypeName
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
 /// <param name = "objvFeatureFuncRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
try
{
if (objvFeatureFuncRelaEN.ApplicationTypeName == "[null]") objvFeatureFuncRelaEN.ApplicationTypeName = null; //应用程序类型名称
if (objvFeatureFuncRelaEN.ProgLangTypeName == "[null]") objvFeatureFuncRelaEN.ProgLangTypeName = null; //编程语言类型名
if (objvFeatureFuncRelaEN.KeyWords == "[null]") objvFeatureFuncRelaEN.KeyWords = null; //关键字
if (objvFeatureFuncRelaEN.FeatureName2 == "[null]") objvFeatureFuncRelaEN.FeatureName2 = null; //功能名-FuncCount
if (objvFeatureFuncRelaEN.FuncId4GC == "[null]") objvFeatureFuncRelaEN.FuncId4GC = null; //函数ID
if (objvFeatureFuncRelaEN.FuncName == "[null]") objvFeatureFuncRelaEN.FuncName = null; //函数名
if (objvFeatureFuncRelaEN.UpdDate == "[null]") objvFeatureFuncRelaEN.UpdDate = null; //修改日期
if (objvFeatureFuncRelaEN.UpdUser == "[null]") objvFeatureFuncRelaEN.UpdUser = null; //修改者
if (objvFeatureFuncRelaEN.Memo == "[null]") objvFeatureFuncRelaEN.Memo = null; //说明
if (objvFeatureFuncRelaEN.FuncCodeTypeENName == "[null]") objvFeatureFuncRelaEN.FuncCodeTypeENName = null; //FuncCodeTypeENName
if (objvFeatureFuncRelaEN.FuncCodeTypeId == "[null]") objvFeatureFuncRelaEN.FuncCodeTypeId = null; //函数代码类型Id
if (objvFeatureFuncRelaEN.FuncCodeTypeName == "[null]") objvFeatureFuncRelaEN.FuncCodeTypeName = null; //FuncCodeTypeName
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
public static void CheckProperty4Condition(clsvFeatureFuncRelaEN objvFeatureFuncRelaEN)
{
 vFeatureFuncRelaDA.CheckProperty4Condition(objvFeatureFuncRelaEN);
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
if (clsFeatureFuncRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureFuncRelaBL没有刷新缓存机制(clsFeatureFuncRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCharEncodingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCharEncodingBL没有刷新缓存机制(clsCharEncodingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFeatureFuncRelaObjLstCache == null)
//{
//arrvFeatureFuncRelaObjLstCache = vFeatureFuncRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFuncRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLst_Sel =
arrvFeatureFuncRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFeatureFuncRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureFuncRelaEN obj = clsvFeatureFuncRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureFuncRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetAllvFeatureFuncRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLstCache = GetObjLstCache(); 
return arrvFeatureFuncRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFuncRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
List<clsvFeatureFuncRelaEN> arrvFeatureFuncRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureFuncRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureFuncRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureFuncRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureFuncRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureFuncRelaEN._RefreshTimeLst[clsvFeatureFuncRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFeatureFuncRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureFuncRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureFuncRela._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureFuncRela = clsvFeatureFuncRelaBL.GetObjBymIdCache(lngmId);
if (objvFeatureFuncRela == null) return "";
return objvFeatureFuncRela[strOutFldName].ToString();
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
int intRecCount = clsvFeatureFuncRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureFuncRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureFuncRelaDA.GetRecCount();
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
int intRecCount = clsvFeatureFuncRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureFuncRelaEN objvFeatureFuncRelaCond)
{
List<clsvFeatureFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFuncRela._AttributeName)
{
if (objvFeatureFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRelaCond[strFldName]));
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
 List<string> arrList = clsvFeatureFuncRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFuncRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFuncRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}