
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaRelaBL
 表名:vCMFuncParaRela(00050509)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMFuncParaRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaRelaEN GetObj(this K_mId_vCMFuncParaRela myKey)
{
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = clsvCMFuncParaRelaBL.vCMFuncParaRelaDA.GetObjBymId(myKey.Value);
return objvCMFuncParaRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetmId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, long lngmId, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.mId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.mId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.mId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCmFuncParaId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCmFuncParaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFuncParaId, convCMFuncParaRela.CmFuncParaId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, convCMFuncParaRela.CmFuncParaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, convCMFuncParaRela.CmFuncParaId);
}
objvCMFuncParaRelaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CmFuncParaId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CmFuncParaId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CmFuncParaId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convCMFuncParaRela.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, convCMFuncParaRela.ParaName);
}
objvCMFuncParaRelaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaComments(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaComments, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaComments, 500, convCMFuncParaRela.ParaComments);
}
objvCMFuncParaRelaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaComments) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaComments, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaComments] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParameterType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParameterType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, convCMFuncParaRela.ParameterType);
}
objvCMFuncParaRelaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParameterType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParameterType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParameterType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetDataTypeId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convCMFuncParaRela.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convCMFuncParaRela.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convCMFuncParaRela.DataTypeId);
}
objvCMFuncParaRelaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.DataTypeId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.DataTypeId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.DataTypeId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetDataTypeName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convCMFuncParaRela.DataTypeName);
}
objvCMFuncParaRelaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.DataTypeName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.DataTypeName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.DataTypeName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCsType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convCMFuncParaRela.CsType);
}
objvCMFuncParaRelaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CsType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CsType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CsType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetJavaType(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strJavaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convCMFuncParaRela.JavaType);
}
objvCMFuncParaRelaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.JavaType) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.JavaType, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.JavaType] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetIsNeedQuote(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.IsNeedQuote) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.IsNeedQuote, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.IsNeedQuote] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParameterTypeFullName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convCMFuncParaRela.ParameterTypeFullName);
}
objvCMFuncParaRelaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParameterTypeFullName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParameterTypeFullName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParameterTypeFullName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetIsByRef(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvCMFuncParaRelaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.IsByRef) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.IsByRef, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.IsByRef] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetParaCnName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convCMFuncParaRela.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convCMFuncParaRela.ParaCnName);
}
objvCMFuncParaRelaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.ParaCnName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.ParaCnName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.ParaCnName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetCmFunctionId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, convCMFuncParaRela.CmFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMFuncParaRela.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMFuncParaRela.CmFunctionId);
}
objvCMFuncParaRelaEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.CmFunctionId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.CmFunctionId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.CmFunctionId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetFunctionName(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMFuncParaRela.FunctionName);
}
objvCMFuncParaRelaEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.FunctionName) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.FunctionName, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.FunctionName] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetFunctionSignature(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, convCMFuncParaRela.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convCMFuncParaRela.FunctionSignature);
}
objvCMFuncParaRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.FunctionSignature) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.FunctionSignature, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.FunctionSignature] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetOrderNum(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMFuncParaRela.OrderNum);
objvCMFuncParaRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.OrderNum) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.OrderNum, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.OrderNum] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetPrjId(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFuncParaRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFuncParaRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFuncParaRela.PrjId);
}
objvCMFuncParaRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.PrjId) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.PrjId, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.PrjId] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetUpdDate(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFuncParaRela.UpdDate);
}
objvCMFuncParaRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.UpdDate) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.UpdDate, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.UpdDate] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetUpdUser(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFuncParaRela.UpdUser);
}
objvCMFuncParaRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.UpdUser) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.UpdUser, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.UpdUser] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaRelaEN SetMemo(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFuncParaRela.Memo);
}
objvCMFuncParaRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convCMFuncParaRela.Memo) == false)
{
objvCMFuncParaRelaEN.dicFldComparisonOp.Add(convCMFuncParaRela.Memo, strComparisonOp);
}
else
{
objvCMFuncParaRelaEN.dicFldComparisonOp[convCMFuncParaRela.Memo] = strComparisonOp;
}
}
return objvCMFuncParaRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <param name = "objvCMFuncParaRelaENT">目标对象</param>
 public static void CopyTo(this clsvCMFuncParaRelaEN objvCMFuncParaRelaENS, clsvCMFuncParaRelaEN objvCMFuncParaRelaENT)
{
try
{
objvCMFuncParaRelaENT.mId = objvCMFuncParaRelaENS.mId; //mId
objvCMFuncParaRelaENT.CmFuncParaId = objvCMFuncParaRelaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaRelaENT.ParaName = objvCMFuncParaRelaENS.ParaName; //参数名
objvCMFuncParaRelaENT.ParaComments = objvCMFuncParaRelaENS.ParaComments; //参数注释
objvCMFuncParaRelaENT.ParameterType = objvCMFuncParaRelaENS.ParameterType; //参数类型
objvCMFuncParaRelaENT.DataTypeId = objvCMFuncParaRelaENS.DataTypeId; //数据类型Id
objvCMFuncParaRelaENT.DataTypeName = objvCMFuncParaRelaENS.DataTypeName; //数据类型名称
objvCMFuncParaRelaENT.CsType = objvCMFuncParaRelaENS.CsType; //CS类型
objvCMFuncParaRelaENT.JavaType = objvCMFuncParaRelaENS.JavaType; //JAVA类型
objvCMFuncParaRelaENT.IsNeedQuote = objvCMFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaRelaENT.ParameterTypeFullName = objvCMFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaRelaENT.IsByRef = objvCMFuncParaRelaENS.IsByRef; //是否引用型参数
objvCMFuncParaRelaENT.ParaCnName = objvCMFuncParaRelaENS.ParaCnName; //参数中文名
objvCMFuncParaRelaENT.CmFunctionId = objvCMFuncParaRelaENS.CmFunctionId; //函数Id
objvCMFuncParaRelaENT.FunctionName = objvCMFuncParaRelaENS.FunctionName; //功能名称
objvCMFuncParaRelaENT.FunctionSignature = objvCMFuncParaRelaENS.FunctionSignature; //函数签名
objvCMFuncParaRelaENT.OrderNum = objvCMFuncParaRelaENS.OrderNum; //序号
objvCMFuncParaRelaENT.PrjId = objvCMFuncParaRelaENS.PrjId; //工程Id
objvCMFuncParaRelaENT.UpdDate = objvCMFuncParaRelaENS.UpdDate; //修改日期
objvCMFuncParaRelaENT.UpdUser = objvCMFuncParaRelaENS.UpdUser; //修改者
objvCMFuncParaRelaENT.Memo = objvCMFuncParaRelaENS.Memo; //说明
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
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCMFuncParaRelaEN:objvCMFuncParaRelaENT</returns>
 public static clsvCMFuncParaRelaEN CopyTo(this clsvCMFuncParaRelaEN objvCMFuncParaRelaENS)
{
try
{
 clsvCMFuncParaRelaEN objvCMFuncParaRelaENT = new clsvCMFuncParaRelaEN()
{
mId = objvCMFuncParaRelaENS.mId, //mId
CmFuncParaId = objvCMFuncParaRelaENS.CmFuncParaId, //函数参数Id
ParaName = objvCMFuncParaRelaENS.ParaName, //参数名
ParaComments = objvCMFuncParaRelaENS.ParaComments, //参数注释
ParameterType = objvCMFuncParaRelaENS.ParameterType, //参数类型
DataTypeId = objvCMFuncParaRelaENS.DataTypeId, //数据类型Id
DataTypeName = objvCMFuncParaRelaENS.DataTypeName, //数据类型名称
CsType = objvCMFuncParaRelaENS.CsType, //CS类型
JavaType = objvCMFuncParaRelaENS.JavaType, //JAVA类型
IsNeedQuote = objvCMFuncParaRelaENS.IsNeedQuote, //是否需要引号
ParameterTypeFullName = objvCMFuncParaRelaENS.ParameterTypeFullName, //参数类型全名
IsByRef = objvCMFuncParaRelaENS.IsByRef, //是否引用型参数
ParaCnName = objvCMFuncParaRelaENS.ParaCnName, //参数中文名
CmFunctionId = objvCMFuncParaRelaENS.CmFunctionId, //函数Id
FunctionName = objvCMFuncParaRelaENS.FunctionName, //功能名称
FunctionSignature = objvCMFuncParaRelaENS.FunctionSignature, //函数签名
OrderNum = objvCMFuncParaRelaENS.OrderNum, //序号
PrjId = objvCMFuncParaRelaENS.PrjId, //工程Id
UpdDate = objvCMFuncParaRelaENS.UpdDate, //修改日期
UpdUser = objvCMFuncParaRelaENS.UpdUser, //修改者
Memo = objvCMFuncParaRelaENS.Memo, //说明
};
 return objvCMFuncParaRelaENT;
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
public static void CheckProperty4Condition(this clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
 clsvCMFuncParaRelaBL.vCMFuncParaRelaDA.CheckProperty4Condition(objvCMFuncParaRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFuncParaRelaEN objvCMFuncParaRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.mId) == true)
{
string strComparisonOpmId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncParaRela.mId, objvCMFuncParaRelaCond.mId, strComparisonOpmId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CmFuncParaId, objvCMFuncParaRelaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaName) == true)
{
string strComparisonOpParaName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaName, objvCMFuncParaRelaCond.ParaName, strComparisonOpParaName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaComments) == true)
{
string strComparisonOpParaComments = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaComments, objvCMFuncParaRelaCond.ParaComments, strComparisonOpParaComments);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParameterType) == true)
{
string strComparisonOpParameterType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParameterType, objvCMFuncParaRelaCond.ParameterType, strComparisonOpParameterType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.DataTypeId, objvCMFuncParaRelaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.DataTypeName, objvCMFuncParaRelaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CsType) == true)
{
string strComparisonOpCsType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CsType, objvCMFuncParaRelaCond.CsType, strComparisonOpCsType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.JavaType) == true)
{
string strComparisonOpJavaType = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.JavaType, objvCMFuncParaRelaCond.JavaType, strComparisonOpJavaType);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.IsNeedQuote) == true)
{
if (objvCMFuncParaRelaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncParaRela.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncParaRela.IsNeedQuote);
}
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParameterTypeFullName, objvCMFuncParaRelaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.IsByRef) == true)
{
if (objvCMFuncParaRelaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncParaRela.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncParaRela.IsByRef);
}
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.ParaCnName, objvCMFuncParaRelaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.CmFunctionId, objvCMFuncParaRelaCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.FunctionName) == true)
{
string strComparisonOpFunctionName = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.FunctionName, objvCMFuncParaRelaCond.FunctionName, strComparisonOpFunctionName);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.FunctionSignature, objvCMFuncParaRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncParaRela.OrderNum, objvCMFuncParaRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.PrjId, objvCMFuncParaRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.UpdDate, objvCMFuncParaRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.UpdUser, objvCMFuncParaRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFuncParaRelaCond.IsUpdated(convCMFuncParaRela.Memo) == true)
{
string strComparisonOpMemo = objvCMFuncParaRelaCond.dicFldComparisonOp[convCMFuncParaRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncParaRela.Memo, objvCMFuncParaRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFuncParaRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM函数参数关系(vCMFuncParaRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFuncParaRelaBL
{
public static RelatedActions_vCMFuncParaRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFuncParaRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFuncParaRelaDA vCMFuncParaRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFuncParaRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFuncParaRelaBL()
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
if (string.IsNullOrEmpty(clsvCMFuncParaRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFuncParaRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCMFuncParaRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFuncParaRelaDA.GetDataTable_vCMFuncParaRela(strWhereCond);
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
objDT = vCMFuncParaRelaDA.GetDataTable(strWhereCond);
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
objDT = vCMFuncParaRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFuncParaRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFuncParaRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFuncParaRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFuncParaRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFuncParaRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFuncParaRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
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
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFuncParaRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLst_Sel =
arrvCMFuncParaRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMFuncParaRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
public static List<clsvCMFuncParaRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFuncParaRelaEN> GetSubObjLstCache(clsvCMFuncParaRelaEN objvCMFuncParaRelaCond)
{
 string strPrjId = objvCMFuncParaRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMFuncParaRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMFuncParaRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFuncParaRela._AttributeName)
{
if (objvCMFuncParaRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMFuncParaRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaRelaCond[strFldName].ToString());
}
else
{
if (objvCMFuncParaRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFuncParaRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFuncParaRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaRelaCond[strFldName]));
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
List<clsvCMFuncParaRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFuncParaRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFuncParaRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
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
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
public static List<clsvCMFuncParaRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
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
public static List<clsvCMFuncParaRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFuncParaRelaEN> arrObjLst = new List<clsvCMFuncParaRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = new clsvCMFuncParaRelaEN();
try
{
objvCMFuncParaRelaEN.mId = Int32.Parse(objRow[convCMFuncParaRela.mId].ToString().Trim()); //mId
objvCMFuncParaRelaEN.CmFuncParaId = objRow[convCMFuncParaRela.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaRelaEN.ParaName = objRow[convCMFuncParaRela.ParaName].ToString().Trim(); //参数名
objvCMFuncParaRelaEN.ParaComments = objRow[convCMFuncParaRela.ParaComments] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaRelaEN.ParameterType = objRow[convCMFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaRelaEN.DataTypeId = objRow[convCMFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaRelaEN.DataTypeName = objRow[convCMFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaRelaEN.CsType = objRow[convCMFuncParaRela.CsType] == DBNull.Value ? null : objRow[convCMFuncParaRela.CsType].ToString().Trim(); //CS类型
objvCMFuncParaRelaEN.JavaType = objRow[convCMFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convCMFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaRelaEN.ParameterTypeFullName = objRow[convCMFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaRelaEN.ParaCnName = objRow[convCMFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaRelaEN.CmFunctionId = objRow[convCMFuncParaRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMFuncParaRelaEN.FunctionName = objRow[convCMFuncParaRela.FunctionName] == DBNull.Value ? null : objRow[convCMFuncParaRela.FunctionName].ToString().Trim(); //功能名称
objvCMFuncParaRelaEN.FunctionSignature = objRow[convCMFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvCMFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convCMFuncParaRela.OrderNum].ToString().Trim()); //序号
objvCMFuncParaRelaEN.PrjId = objRow[convCMFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaRelaEN.UpdDate = objRow[convCMFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaRelaEN.UpdUser = objRow[convCMFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convCMFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaRelaEN.Memo = objRow[convCMFuncParaRela.Memo] == DBNull.Value ? null : objRow[convCMFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFuncParaRela(ref clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
bool bolResult = vCMFuncParaRelaDA.GetvCMFuncParaRela(ref objvCMFuncParaRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaRelaEN GetObjBymId(long lngmId)
{
clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = vCMFuncParaRelaDA.GetObjBymId(lngmId);
return objvCMFuncParaRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFuncParaRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = vCMFuncParaRelaDA.GetFirstObj(strWhereCond);
 return objvCMFuncParaRelaEN;
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
public static clsvCMFuncParaRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = vCMFuncParaRelaDA.GetObjByDataRow(objRow);
 return objvCMFuncParaRelaEN;
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
public static clsvCMFuncParaRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFuncParaRelaEN objvCMFuncParaRelaEN = vCMFuncParaRelaDA.GetObjByDataRow(objRow);
 return objvCMFuncParaRelaEN;
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
 /// <param name = "lstvCMFuncParaRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFuncParaRelaEN GetObjBymIdFromList(long lngmId, List<clsvCMFuncParaRelaEN> lstvCMFuncParaRelaObjLst)
{
foreach (clsvCMFuncParaRelaEN objvCMFuncParaRelaEN in lstvCMFuncParaRelaObjLst)
{
if (objvCMFuncParaRelaEN.mId == lngmId)
{
return objvCMFuncParaRelaEN;
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
 lngmId = new clsvCMFuncParaRelaDA().GetFirstID(strWhereCond);
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
 arrList = vCMFuncParaRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFuncParaRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCMFuncParaRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvCMFuncParaRelaDA.IsExistTable();
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
 bolIsExist = vCMFuncParaRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFuncParaRelaENS">源对象</param>
 /// <param name = "objvCMFuncParaRelaENT">目标对象</param>
 public static void CopyTo(clsvCMFuncParaRelaEN objvCMFuncParaRelaENS, clsvCMFuncParaRelaEN objvCMFuncParaRelaENT)
{
try
{
objvCMFuncParaRelaENT.mId = objvCMFuncParaRelaENS.mId; //mId
objvCMFuncParaRelaENT.CmFuncParaId = objvCMFuncParaRelaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaRelaENT.ParaName = objvCMFuncParaRelaENS.ParaName; //参数名
objvCMFuncParaRelaENT.ParaComments = objvCMFuncParaRelaENS.ParaComments; //参数注释
objvCMFuncParaRelaENT.ParameterType = objvCMFuncParaRelaENS.ParameterType; //参数类型
objvCMFuncParaRelaENT.DataTypeId = objvCMFuncParaRelaENS.DataTypeId; //数据类型Id
objvCMFuncParaRelaENT.DataTypeName = objvCMFuncParaRelaENS.DataTypeName; //数据类型名称
objvCMFuncParaRelaENT.CsType = objvCMFuncParaRelaENS.CsType; //CS类型
objvCMFuncParaRelaENT.JavaType = objvCMFuncParaRelaENS.JavaType; //JAVA类型
objvCMFuncParaRelaENT.IsNeedQuote = objvCMFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaRelaENT.ParameterTypeFullName = objvCMFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaRelaENT.IsByRef = objvCMFuncParaRelaENS.IsByRef; //是否引用型参数
objvCMFuncParaRelaENT.ParaCnName = objvCMFuncParaRelaENS.ParaCnName; //参数中文名
objvCMFuncParaRelaENT.CmFunctionId = objvCMFuncParaRelaENS.CmFunctionId; //函数Id
objvCMFuncParaRelaENT.FunctionName = objvCMFuncParaRelaENS.FunctionName; //功能名称
objvCMFuncParaRelaENT.FunctionSignature = objvCMFuncParaRelaENS.FunctionSignature; //函数签名
objvCMFuncParaRelaENT.OrderNum = objvCMFuncParaRelaENS.OrderNum; //序号
objvCMFuncParaRelaENT.PrjId = objvCMFuncParaRelaENS.PrjId; //工程Id
objvCMFuncParaRelaENT.UpdDate = objvCMFuncParaRelaENS.UpdDate; //修改日期
objvCMFuncParaRelaENT.UpdUser = objvCMFuncParaRelaENS.UpdUser; //修改者
objvCMFuncParaRelaENT.Memo = objvCMFuncParaRelaENS.Memo; //说明
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
 /// <param name = "objvCMFuncParaRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
try
{
objvCMFuncParaRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFuncParaRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFuncParaRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.mId = objvCMFuncParaRelaEN.mId; //mId
}
if (arrFldSet.Contains(convCMFuncParaRela.CmFuncParaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.CmFuncParaId = objvCMFuncParaRelaEN.CmFuncParaId; //函数参数Id
}
if (arrFldSet.Contains(convCMFuncParaRela.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.ParaName = objvCMFuncParaRelaEN.ParaName; //参数名
}
if (arrFldSet.Contains(convCMFuncParaRela.ParaComments, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.ParaComments = objvCMFuncParaRelaEN.ParaComments == "[null]" ? null :  objvCMFuncParaRelaEN.ParaComments; //参数注释
}
if (arrFldSet.Contains(convCMFuncParaRela.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.ParameterType = objvCMFuncParaRelaEN.ParameterType == "[null]" ? null :  objvCMFuncParaRelaEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(convCMFuncParaRela.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.DataTypeId = objvCMFuncParaRelaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convCMFuncParaRela.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.DataTypeName = objvCMFuncParaRelaEN.DataTypeName == "[null]" ? null :  objvCMFuncParaRelaEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convCMFuncParaRela.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.CsType = objvCMFuncParaRelaEN.CsType == "[null]" ? null :  objvCMFuncParaRelaEN.CsType; //CS类型
}
if (arrFldSet.Contains(convCMFuncParaRela.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.JavaType = objvCMFuncParaRelaEN.JavaType == "[null]" ? null :  objvCMFuncParaRelaEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convCMFuncParaRela.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.IsNeedQuote = objvCMFuncParaRelaEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convCMFuncParaRela.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.ParameterTypeFullName = objvCMFuncParaRelaEN.ParameterTypeFullName == "[null]" ? null :  objvCMFuncParaRelaEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(convCMFuncParaRela.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.IsByRef = objvCMFuncParaRelaEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(convCMFuncParaRela.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.ParaCnName = objvCMFuncParaRelaEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(convCMFuncParaRela.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.CmFunctionId = objvCMFuncParaRelaEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(convCMFuncParaRela.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.FunctionName = objvCMFuncParaRelaEN.FunctionName == "[null]" ? null :  objvCMFuncParaRelaEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convCMFuncParaRela.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.FunctionSignature = objvCMFuncParaRelaEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convCMFuncParaRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.OrderNum = objvCMFuncParaRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMFuncParaRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.PrjId = objvCMFuncParaRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMFuncParaRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.UpdDate = objvCMFuncParaRelaEN.UpdDate == "[null]" ? null :  objvCMFuncParaRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFuncParaRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.UpdUser = objvCMFuncParaRelaEN.UpdUser == "[null]" ? null :  objvCMFuncParaRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFuncParaRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaRelaEN.Memo = objvCMFuncParaRelaEN.Memo == "[null]" ? null :  objvCMFuncParaRelaEN.Memo; //说明
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
 /// <param name = "objvCMFuncParaRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
try
{
if (objvCMFuncParaRelaEN.ParaComments == "[null]") objvCMFuncParaRelaEN.ParaComments = null; //参数注释
if (objvCMFuncParaRelaEN.ParameterType == "[null]") objvCMFuncParaRelaEN.ParameterType = null; //参数类型
if (objvCMFuncParaRelaEN.DataTypeName == "[null]") objvCMFuncParaRelaEN.DataTypeName = null; //数据类型名称
if (objvCMFuncParaRelaEN.CsType == "[null]") objvCMFuncParaRelaEN.CsType = null; //CS类型
if (objvCMFuncParaRelaEN.JavaType == "[null]") objvCMFuncParaRelaEN.JavaType = null; //JAVA类型
if (objvCMFuncParaRelaEN.ParameterTypeFullName == "[null]") objvCMFuncParaRelaEN.ParameterTypeFullName = null; //参数类型全名
if (objvCMFuncParaRelaEN.FunctionName == "[null]") objvCMFuncParaRelaEN.FunctionName = null; //功能名称
if (objvCMFuncParaRelaEN.UpdDate == "[null]") objvCMFuncParaRelaEN.UpdDate = null; //修改日期
if (objvCMFuncParaRelaEN.UpdUser == "[null]") objvCMFuncParaRelaEN.UpdUser = null; //修改者
if (objvCMFuncParaRelaEN.Memo == "[null]") objvCMFuncParaRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMFuncParaRelaEN objvCMFuncParaRelaEN)
{
 vCMFuncParaRelaDA.CheckProperty4Condition(objvCMFuncParaRelaEN);
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
if (clsCMFuncParaRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFuncParaRelaBL没有刷新缓存机制(clsCMFuncParaRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionBL没有刷新缓存机制(clsCMFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMFuncParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFuncParaBL没有刷新缓存机制(clsCMFuncParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassBL没有刷新缓存机制(clsCMClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMFuncParaRelaObjLstCache == null)
//{
//arrvCMFuncParaRelaObjLstCache = vCMFuncParaRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFuncParaRelaEN GetObjBymIdCache(long lngmId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLst_Sel =
arrvCMFuncParaRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMFuncParaRelaObjLst_Sel.Count() == 0)
{
   clsvCMFuncParaRelaEN obj = clsvCMFuncParaRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMFuncParaRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetAllvCMFuncParaRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMFuncParaRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaRelaEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMFuncParaRelaEN> arrvCMFuncParaRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMFuncParaRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMFuncParaRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMFuncParaRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMFuncParaRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvCMFuncParaRelaEN._RefreshTimeLst[clsvCMFuncParaRelaEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convCMFuncParaRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFuncParaRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFuncParaRela._AttributeName));
throw new Exception(strMsg);
}
var objvCMFuncParaRela = clsvCMFuncParaRelaBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvCMFuncParaRela == null) return "";
return objvCMFuncParaRela[strOutFldName].ToString();
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
int intRecCount = clsvCMFuncParaRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFuncParaRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFuncParaRelaDA.GetRecCount();
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
int intRecCount = clsvCMFuncParaRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFuncParaRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFuncParaRelaEN objvCMFuncParaRelaCond)
{
 string strPrjId = objvCMFuncParaRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMFuncParaRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMFuncParaRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMFuncParaRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFuncParaRela._AttributeName)
{
if (objvCMFuncParaRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMFuncParaRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaRelaCond[strFldName].ToString());
}
else
{
if (objvCMFuncParaRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFuncParaRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFuncParaRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaRelaCond[strFldName]));
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
 List<string> arrList = clsvCMFuncParaRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFuncParaRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFuncParaRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}