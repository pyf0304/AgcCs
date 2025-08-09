
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMFuncParaBL
 表名:vCMFuncPara(00050508)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvCMFuncParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaEN GetObj(this K_CmFuncParaId_vCMFuncPara myKey)
{
clsvCMFuncParaEN objvCMFuncParaEN = clsvCMFuncParaBL.vCMFuncParaDA.GetObjByCmFuncParaId(myKey.Value);
return objvCMFuncParaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetCmFuncParaId(this clsvCMFuncParaEN objvCMFuncParaEN, string strCmFuncParaId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFuncParaId, 8, convCMFuncPara.CmFuncParaId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFuncParaId, 8, convCMFuncPara.CmFuncParaId);
}
objvCMFuncParaEN.CmFuncParaId = strCmFuncParaId; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.CmFuncParaId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.CmFuncParaId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.CmFuncParaId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convCMFuncPara.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, convCMFuncPara.ParaName);
}
objvCMFuncParaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaComments(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaComments, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaComments, 500, convCMFuncPara.ParaComments);
}
objvCMFuncParaEN.ParaComments = strParaComments; //参数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaComments) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaComments, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaComments] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParameterType(this clsvCMFuncParaEN objvCMFuncParaEN, string strParameterType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, convCMFuncPara.ParameterType);
}
objvCMFuncParaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParameterType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParameterType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParameterType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataTypeId(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convCMFuncPara.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convCMFuncPara.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convCMFuncPara.DataTypeId);
}
objvCMFuncParaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataTypeId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataTypeId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataTypeId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataTypeName(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convCMFuncPara.DataTypeName);
}
objvCMFuncParaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataTypeName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataTypeName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataTypeName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetDataCnName(this clsvCMFuncParaEN objvCMFuncParaEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convCMFuncPara.DataCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convCMFuncPara.DataCnName);
}
objvCMFuncParaEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.DataCnName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.DataCnName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.DataCnName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetCsType(this clsvCMFuncParaEN objvCMFuncParaEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convCMFuncPara.CsType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convCMFuncPara.CsType);
}
objvCMFuncParaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.CsType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.CsType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.CsType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetJavaType(this clsvCMFuncParaEN objvCMFuncParaEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convCMFuncPara.JavaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convCMFuncPara.JavaType);
}
objvCMFuncParaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.JavaType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.JavaType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.JavaType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetJavaObjType(this clsvCMFuncParaEN objvCMFuncParaEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convCMFuncPara.JavaObjType);
}
objvCMFuncParaEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.JavaObjType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.JavaObjType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.JavaObjType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetSwiftType(this clsvCMFuncParaEN objvCMFuncParaEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convCMFuncPara.SwiftType);
}
objvCMFuncParaEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.SwiftType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.SwiftType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.SwiftType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetIsNeedQuote(this clsvCMFuncParaEN objvCMFuncParaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, convCMFuncPara.IsNeedQuote);
objvCMFuncParaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.IsNeedQuote) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.IsNeedQuote, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.IsNeedQuote] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetOraDbType(this clsvCMFuncParaEN objvCMFuncParaEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convCMFuncPara.OraDbType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convCMFuncPara.OraDbType);
}
objvCMFuncParaEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.OraDbType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.OraDbType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.OraDbType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetMySqlType(this clsvCMFuncParaEN objvCMFuncParaEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convCMFuncPara.MySqlType);
}
objvCMFuncParaEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.MySqlType) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.MySqlType, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.MySqlType] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParameterTypeFullName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convCMFuncPara.ParameterTypeFullName);
}
objvCMFuncParaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParameterTypeFullName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParameterTypeFullName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParameterTypeFullName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetIsByRef(this clsvCMFuncParaEN objvCMFuncParaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvCMFuncParaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.IsByRef) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.IsByRef, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.IsByRef] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetParaCnName(this clsvCMFuncParaEN objvCMFuncParaEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convCMFuncPara.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convCMFuncPara.ParaCnName);
}
objvCMFuncParaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.ParaCnName) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.ParaCnName, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.ParaCnName] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetPrjId(this clsvCMFuncParaEN objvCMFuncParaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMFuncPara.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMFuncPara.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMFuncPara.PrjId);
}
objvCMFuncParaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.PrjId) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.PrjId, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.PrjId] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetUpdDate(this clsvCMFuncParaEN objvCMFuncParaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMFuncPara.UpdDate);
}
objvCMFuncParaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.UpdDate) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.UpdDate, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.UpdDate] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetUpdUser(this clsvCMFuncParaEN objvCMFuncParaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMFuncPara.UpdUser);
}
objvCMFuncParaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.UpdUser) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.UpdUser, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.UpdUser] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetMemo(this clsvCMFuncParaEN objvCMFuncParaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMFuncPara.Memo);
}
objvCMFuncParaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.Memo) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.Memo, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.Memo] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMFuncParaEN SetFuncCount(this clsvCMFuncParaEN objvCMFuncParaEN, int? intFuncCount, string strComparisonOp="")
	{
objvCMFuncParaEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMFuncParaEN.dicFldComparisonOp.ContainsKey(convCMFuncPara.FuncCount) == false)
{
objvCMFuncParaEN.dicFldComparisonOp.Add(convCMFuncPara.FuncCount, strComparisonOp);
}
else
{
objvCMFuncParaEN.dicFldComparisonOp[convCMFuncPara.FuncCount] = strComparisonOp;
}
}
return objvCMFuncParaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMFuncParaENS">源对象</param>
 /// <param name = "objvCMFuncParaENT">目标对象</param>
 public static void CopyTo(this clsvCMFuncParaEN objvCMFuncParaENS, clsvCMFuncParaEN objvCMFuncParaENT)
{
try
{
objvCMFuncParaENT.CmFuncParaId = objvCMFuncParaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaENT.ParaName = objvCMFuncParaENS.ParaName; //参数名
objvCMFuncParaENT.ParaComments = objvCMFuncParaENS.ParaComments; //参数注释
objvCMFuncParaENT.ParameterType = objvCMFuncParaENS.ParameterType; //参数类型
objvCMFuncParaENT.DataTypeId = objvCMFuncParaENS.DataTypeId; //数据类型Id
objvCMFuncParaENT.DataTypeName = objvCMFuncParaENS.DataTypeName; //数据类型名称
objvCMFuncParaENT.DataCnName = objvCMFuncParaENS.DataCnName; //数据类型中文名称
objvCMFuncParaENT.CsType = objvCMFuncParaENS.CsType; //CS类型
objvCMFuncParaENT.JavaType = objvCMFuncParaENS.JavaType; //JAVA类型
objvCMFuncParaENT.JavaObjType = objvCMFuncParaENS.JavaObjType; //JAVA对象类型
objvCMFuncParaENT.SwiftType = objvCMFuncParaENS.SwiftType; //SwiftType
objvCMFuncParaENT.IsNeedQuote = objvCMFuncParaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaENT.OraDbType = objvCMFuncParaENS.OraDbType; //Ora数据类型
objvCMFuncParaENT.MySqlType = objvCMFuncParaENS.MySqlType; //MySqlType
objvCMFuncParaENT.ParameterTypeFullName = objvCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaENT.IsByRef = objvCMFuncParaENS.IsByRef; //是否引用型参数
objvCMFuncParaENT.ParaCnName = objvCMFuncParaENS.ParaCnName; //参数中文名
objvCMFuncParaENT.PrjId = objvCMFuncParaENS.PrjId; //工程Id
objvCMFuncParaENT.UpdDate = objvCMFuncParaENS.UpdDate; //修改日期
objvCMFuncParaENT.UpdUser = objvCMFuncParaENS.UpdUser; //修改者
objvCMFuncParaENT.Memo = objvCMFuncParaENS.Memo; //说明
objvCMFuncParaENT.FuncCount = objvCMFuncParaENS.FuncCount; //函数数目
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
 /// <param name = "objvCMFuncParaENS">源对象</param>
 /// <returns>目标对象=>clsvCMFuncParaEN:objvCMFuncParaENT</returns>
 public static clsvCMFuncParaEN CopyTo(this clsvCMFuncParaEN objvCMFuncParaENS)
{
try
{
 clsvCMFuncParaEN objvCMFuncParaENT = new clsvCMFuncParaEN()
{
CmFuncParaId = objvCMFuncParaENS.CmFuncParaId, //函数参数Id
ParaName = objvCMFuncParaENS.ParaName, //参数名
ParaComments = objvCMFuncParaENS.ParaComments, //参数注释
ParameterType = objvCMFuncParaENS.ParameterType, //参数类型
DataTypeId = objvCMFuncParaENS.DataTypeId, //数据类型Id
DataTypeName = objvCMFuncParaENS.DataTypeName, //数据类型名称
DataCnName = objvCMFuncParaENS.DataCnName, //数据类型中文名称
CsType = objvCMFuncParaENS.CsType, //CS类型
JavaType = objvCMFuncParaENS.JavaType, //JAVA类型
JavaObjType = objvCMFuncParaENS.JavaObjType, //JAVA对象类型
SwiftType = objvCMFuncParaENS.SwiftType, //SwiftType
IsNeedQuote = objvCMFuncParaENS.IsNeedQuote, //是否需要引号
OraDbType = objvCMFuncParaENS.OraDbType, //Ora数据类型
MySqlType = objvCMFuncParaENS.MySqlType, //MySqlType
ParameterTypeFullName = objvCMFuncParaENS.ParameterTypeFullName, //参数类型全名
IsByRef = objvCMFuncParaENS.IsByRef, //是否引用型参数
ParaCnName = objvCMFuncParaENS.ParaCnName, //参数中文名
PrjId = objvCMFuncParaENS.PrjId, //工程Id
UpdDate = objvCMFuncParaENS.UpdDate, //修改日期
UpdUser = objvCMFuncParaENS.UpdUser, //修改者
Memo = objvCMFuncParaENS.Memo, //说明
FuncCount = objvCMFuncParaENS.FuncCount, //函数数目
};
 return objvCMFuncParaENT;
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
public static void CheckProperty4Condition(this clsvCMFuncParaEN objvCMFuncParaEN)
{
 clsvCMFuncParaBL.vCMFuncParaDA.CheckProperty4Condition(objvCMFuncParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMFuncParaEN objvCMFuncParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.CmFuncParaId) == true)
{
string strComparisonOpCmFuncParaId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.CmFuncParaId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.CmFuncParaId, objvCMFuncParaCond.CmFuncParaId, strComparisonOpCmFuncParaId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaName) == true)
{
string strComparisonOpParaName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaName, objvCMFuncParaCond.ParaName, strComparisonOpParaName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaComments) == true)
{
string strComparisonOpParaComments = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaComments];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaComments, objvCMFuncParaCond.ParaComments, strComparisonOpParaComments);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParameterType) == true)
{
string strComparisonOpParameterType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParameterType, objvCMFuncParaCond.ParameterType, strComparisonOpParameterType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataTypeId, objvCMFuncParaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataTypeName, objvCMFuncParaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.DataCnName) == true)
{
string strComparisonOpDataCnName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.DataCnName, objvCMFuncParaCond.DataCnName, strComparisonOpDataCnName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.CsType) == true)
{
string strComparisonOpCsType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.CsType, objvCMFuncParaCond.CsType, strComparisonOpCsType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.JavaType) == true)
{
string strComparisonOpJavaType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.JavaType, objvCMFuncParaCond.JavaType, strComparisonOpJavaType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.JavaObjType, objvCMFuncParaCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.SwiftType) == true)
{
string strComparisonOpSwiftType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.SwiftType, objvCMFuncParaCond.SwiftType, strComparisonOpSwiftType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.IsNeedQuote) == true)
{
if (objvCMFuncParaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncPara.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncPara.IsNeedQuote);
}
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.OraDbType) == true)
{
string strComparisonOpOraDbType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.OraDbType, objvCMFuncParaCond.OraDbType, strComparisonOpOraDbType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.MySqlType) == true)
{
string strComparisonOpMySqlType = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.MySqlType, objvCMFuncParaCond.MySqlType, strComparisonOpMySqlType);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParameterTypeFullName, objvCMFuncParaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.IsByRef) == true)
{
if (objvCMFuncParaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMFuncPara.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMFuncPara.IsByRef);
}
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.ParaCnName, objvCMFuncParaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.PrjId) == true)
{
string strComparisonOpPrjId = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.PrjId, objvCMFuncParaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.UpdDate, objvCMFuncParaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.UpdUser, objvCMFuncParaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.Memo) == true)
{
string strComparisonOpMemo = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMFuncPara.Memo, objvCMFuncParaCond.Memo, strComparisonOpMemo);
}
if (objvCMFuncParaCond.IsUpdated(convCMFuncPara.FuncCount) == true)
{
string strComparisonOpFuncCount = objvCMFuncParaCond.dicFldComparisonOp[convCMFuncPara.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCMFuncPara.FuncCount, objvCMFuncParaCond.FuncCount, strComparisonOpFuncCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMFuncPara
{
public virtual bool UpdRelaTabDate(string strCmFuncParaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM函数参数(vCMFuncPara)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMFuncParaBL
{
public static RelatedActions_vCMFuncPara relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMFuncParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMFuncParaDA vCMFuncParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMFuncParaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMFuncParaBL()
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
if (string.IsNullOrEmpty(clsvCMFuncParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMFuncParaEN._ConnectString);
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
public static DataTable GetDataTable_vCMFuncPara(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMFuncParaDA.GetDataTable_vCMFuncPara(strWhereCond);
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
objDT = vCMFuncParaDA.GetDataTable(strWhereCond);
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
objDT = vCMFuncParaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMFuncParaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMFuncParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMFuncParaDA.GetDataTable_Top(objTopPara);
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
objDT = vCMFuncParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMFuncParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLstByCmFuncParaIdLst(List<string> arrCmFuncParaIdLst)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFuncParaIdLst, true);
 string strWhereCond = string.Format("CmFuncParaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFuncParaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMFuncParaEN> GetObjLstByCmFuncParaIdLstCache(List<string> arrCmFuncParaIdLst)
{
string strKey = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
List<clsvCMFuncParaEN> arrvCMFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFuncParaEN> arrvCMFuncParaObjLst_Sel =
arrvCMFuncParaObjLstCache
.Where(x => arrCmFuncParaIdLst.Contains(x.CmFuncParaId));
return arrvCMFuncParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLst(string strWhereCond)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
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
public static List<clsvCMFuncParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMFuncParaEN> GetSubObjLstCache(clsvCMFuncParaEN objvCMFuncParaCond)
{
List<clsvCMFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFuncPara._AttributeName)
{
if (objvCMFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objvCMFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaCond[strFldName].ToString());
}
else
{
if (objvCMFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaCond[strFldName]));
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
public static List<clsvCMFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
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
public static List<clsvCMFuncParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
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
List<clsvCMFuncParaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMFuncParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
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
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
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
public static List<clsvCMFuncParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
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
public static List<clsvCMFuncParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMFuncParaEN> arrObjLst = new List<clsvCMFuncParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMFuncParaEN objvCMFuncParaEN = new clsvCMFuncParaEN();
try
{
objvCMFuncParaEN.CmFuncParaId = objRow[convCMFuncPara.CmFuncParaId].ToString().Trim(); //函数参数Id
objvCMFuncParaEN.ParaName = objRow[convCMFuncPara.ParaName].ToString().Trim(); //参数名
objvCMFuncParaEN.ParaComments = objRow[convCMFuncPara.ParaComments] == DBNull.Value ? null : objRow[convCMFuncPara.ParaComments].ToString().Trim(); //参数注释
objvCMFuncParaEN.ParameterType = objRow[convCMFuncPara.ParameterType] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterType].ToString().Trim(); //参数类型
objvCMFuncParaEN.DataTypeId = objRow[convCMFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvCMFuncParaEN.DataTypeName = objRow[convCMFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convCMFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvCMFuncParaEN.DataCnName = objRow[convCMFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvCMFuncParaEN.CsType = objRow[convCMFuncPara.CsType].ToString().Trim(); //CS类型
objvCMFuncParaEN.JavaType = objRow[convCMFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvCMFuncParaEN.JavaObjType = objRow[convCMFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convCMFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvCMFuncParaEN.SwiftType = objRow[convCMFuncPara.SwiftType] == DBNull.Value ? null : objRow[convCMFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvCMFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvCMFuncParaEN.OraDbType = objRow[convCMFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvCMFuncParaEN.MySqlType = objRow[convCMFuncPara.MySqlType] == DBNull.Value ? null : objRow[convCMFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvCMFuncParaEN.ParameterTypeFullName = objRow[convCMFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convCMFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvCMFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convCMFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvCMFuncParaEN.ParaCnName = objRow[convCMFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvCMFuncParaEN.PrjId = objRow[convCMFuncPara.PrjId].ToString().Trim(); //工程Id
objvCMFuncParaEN.UpdDate = objRow[convCMFuncPara.UpdDate] == DBNull.Value ? null : objRow[convCMFuncPara.UpdDate].ToString().Trim(); //修改日期
objvCMFuncParaEN.UpdUser = objRow[convCMFuncPara.UpdUser] == DBNull.Value ? null : objRow[convCMFuncPara.UpdUser].ToString().Trim(); //修改者
objvCMFuncParaEN.Memo = objRow[convCMFuncPara.Memo] == DBNull.Value ? null : objRow[convCMFuncPara.Memo].ToString().Trim(); //说明
objvCMFuncParaEN.FuncCount = objRow[convCMFuncPara.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMFuncPara.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMFuncParaEN.CmFuncParaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMFuncParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMFuncParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMFuncPara(ref clsvCMFuncParaEN objvCMFuncParaEN)
{
bool bolResult = vCMFuncParaDA.GetvCMFuncPara(ref objvCMFuncParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMFuncParaEN GetObjByCmFuncParaId(string strCmFuncParaId)
{
if (strCmFuncParaId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFuncParaId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFuncParaId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCMFuncParaEN objvCMFuncParaEN = vCMFuncParaDA.GetObjByCmFuncParaId(strCmFuncParaId);
return objvCMFuncParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMFuncParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMFuncParaEN objvCMFuncParaEN = vCMFuncParaDA.GetFirstObj(strWhereCond);
 return objvCMFuncParaEN;
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
public static clsvCMFuncParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMFuncParaEN objvCMFuncParaEN = vCMFuncParaDA.GetObjByDataRow(objRow);
 return objvCMFuncParaEN;
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
public static clsvCMFuncParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMFuncParaEN objvCMFuncParaEN = vCMFuncParaDA.GetObjByDataRow(objRow);
 return objvCMFuncParaEN;
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
 /// <param name = "strCmFuncParaId">所给的关键字</param>
 /// <param name = "lstvCMFuncParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFuncParaEN GetObjByCmFuncParaIdFromList(string strCmFuncParaId, List<clsvCMFuncParaEN> lstvCMFuncParaObjLst)
{
foreach (clsvCMFuncParaEN objvCMFuncParaEN in lstvCMFuncParaObjLst)
{
if (objvCMFuncParaEN.CmFuncParaId == strCmFuncParaId)
{
return objvCMFuncParaEN;
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
 string strCmFuncParaId;
 try
 {
 strCmFuncParaId = new clsvCMFuncParaDA().GetFirstID(strWhereCond);
 return strCmFuncParaId;
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
 arrList = vCMFuncParaDA.GetID(strWhereCond);
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
bool bolIsExist = vCMFuncParaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFuncParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFuncParaId)
{
if (string.IsNullOrEmpty(strCmFuncParaId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFuncParaId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCMFuncParaDA.IsExist(strCmFuncParaId);
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
 bolIsExist = clsvCMFuncParaDA.IsExistTable();
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
 bolIsExist = vCMFuncParaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMFuncParaENS">源对象</param>
 /// <param name = "objvCMFuncParaENT">目标对象</param>
 public static void CopyTo(clsvCMFuncParaEN objvCMFuncParaENS, clsvCMFuncParaEN objvCMFuncParaENT)
{
try
{
objvCMFuncParaENT.CmFuncParaId = objvCMFuncParaENS.CmFuncParaId; //函数参数Id
objvCMFuncParaENT.ParaName = objvCMFuncParaENS.ParaName; //参数名
objvCMFuncParaENT.ParaComments = objvCMFuncParaENS.ParaComments; //参数注释
objvCMFuncParaENT.ParameterType = objvCMFuncParaENS.ParameterType; //参数类型
objvCMFuncParaENT.DataTypeId = objvCMFuncParaENS.DataTypeId; //数据类型Id
objvCMFuncParaENT.DataTypeName = objvCMFuncParaENS.DataTypeName; //数据类型名称
objvCMFuncParaENT.DataCnName = objvCMFuncParaENS.DataCnName; //数据类型中文名称
objvCMFuncParaENT.CsType = objvCMFuncParaENS.CsType; //CS类型
objvCMFuncParaENT.JavaType = objvCMFuncParaENS.JavaType; //JAVA类型
objvCMFuncParaENT.JavaObjType = objvCMFuncParaENS.JavaObjType; //JAVA对象类型
objvCMFuncParaENT.SwiftType = objvCMFuncParaENS.SwiftType; //SwiftType
objvCMFuncParaENT.IsNeedQuote = objvCMFuncParaENS.IsNeedQuote; //是否需要引号
objvCMFuncParaENT.OraDbType = objvCMFuncParaENS.OraDbType; //Ora数据类型
objvCMFuncParaENT.MySqlType = objvCMFuncParaENS.MySqlType; //MySqlType
objvCMFuncParaENT.ParameterTypeFullName = objvCMFuncParaENS.ParameterTypeFullName; //参数类型全名
objvCMFuncParaENT.IsByRef = objvCMFuncParaENS.IsByRef; //是否引用型参数
objvCMFuncParaENT.ParaCnName = objvCMFuncParaENS.ParaCnName; //参数中文名
objvCMFuncParaENT.PrjId = objvCMFuncParaENS.PrjId; //工程Id
objvCMFuncParaENT.UpdDate = objvCMFuncParaENS.UpdDate; //修改日期
objvCMFuncParaENT.UpdUser = objvCMFuncParaENS.UpdUser; //修改者
objvCMFuncParaENT.Memo = objvCMFuncParaENS.Memo; //说明
objvCMFuncParaENT.FuncCount = objvCMFuncParaENS.FuncCount; //函数数目
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
 /// <param name = "objvCMFuncParaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMFuncParaEN objvCMFuncParaEN)
{
try
{
objvCMFuncParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMFuncParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMFuncPara.CmFuncParaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.CmFuncParaId = objvCMFuncParaEN.CmFuncParaId; //函数参数Id
}
if (arrFldSet.Contains(convCMFuncPara.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.ParaName = objvCMFuncParaEN.ParaName; //参数名
}
if (arrFldSet.Contains(convCMFuncPara.ParaComments, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.ParaComments = objvCMFuncParaEN.ParaComments == "[null]" ? null :  objvCMFuncParaEN.ParaComments; //参数注释
}
if (arrFldSet.Contains(convCMFuncPara.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.ParameterType = objvCMFuncParaEN.ParameterType == "[null]" ? null :  objvCMFuncParaEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(convCMFuncPara.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.DataTypeId = objvCMFuncParaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convCMFuncPara.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.DataTypeName = objvCMFuncParaEN.DataTypeName == "[null]" ? null :  objvCMFuncParaEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convCMFuncPara.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.DataCnName = objvCMFuncParaEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(convCMFuncPara.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.CsType = objvCMFuncParaEN.CsType; //CS类型
}
if (arrFldSet.Contains(convCMFuncPara.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.JavaType = objvCMFuncParaEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convCMFuncPara.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.JavaObjType = objvCMFuncParaEN.JavaObjType == "[null]" ? null :  objvCMFuncParaEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(convCMFuncPara.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.SwiftType = objvCMFuncParaEN.SwiftType == "[null]" ? null :  objvCMFuncParaEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(convCMFuncPara.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.IsNeedQuote = objvCMFuncParaEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convCMFuncPara.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.OraDbType = objvCMFuncParaEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convCMFuncPara.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.MySqlType = objvCMFuncParaEN.MySqlType == "[null]" ? null :  objvCMFuncParaEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(convCMFuncPara.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.ParameterTypeFullName = objvCMFuncParaEN.ParameterTypeFullName == "[null]" ? null :  objvCMFuncParaEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(convCMFuncPara.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.IsByRef = objvCMFuncParaEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(convCMFuncPara.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.ParaCnName = objvCMFuncParaEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(convCMFuncPara.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.PrjId = objvCMFuncParaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMFuncPara.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.UpdDate = objvCMFuncParaEN.UpdDate == "[null]" ? null :  objvCMFuncParaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMFuncPara.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.UpdUser = objvCMFuncParaEN.UpdUser == "[null]" ? null :  objvCMFuncParaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMFuncPara.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.Memo = objvCMFuncParaEN.Memo == "[null]" ? null :  objvCMFuncParaEN.Memo; //说明
}
if (arrFldSet.Contains(convCMFuncPara.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMFuncParaEN.FuncCount = objvCMFuncParaEN.FuncCount; //函数数目
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
 /// <param name = "objvCMFuncParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMFuncParaEN objvCMFuncParaEN)
{
try
{
if (objvCMFuncParaEN.ParaComments == "[null]") objvCMFuncParaEN.ParaComments = null; //参数注释
if (objvCMFuncParaEN.ParameterType == "[null]") objvCMFuncParaEN.ParameterType = null; //参数类型
if (objvCMFuncParaEN.DataTypeName == "[null]") objvCMFuncParaEN.DataTypeName = null; //数据类型名称
if (objvCMFuncParaEN.JavaObjType == "[null]") objvCMFuncParaEN.JavaObjType = null; //JAVA对象类型
if (objvCMFuncParaEN.SwiftType == "[null]") objvCMFuncParaEN.SwiftType = null; //SwiftType
if (objvCMFuncParaEN.MySqlType == "[null]") objvCMFuncParaEN.MySqlType = null; //MySqlType
if (objvCMFuncParaEN.ParameterTypeFullName == "[null]") objvCMFuncParaEN.ParameterTypeFullName = null; //参数类型全名
if (objvCMFuncParaEN.UpdDate == "[null]") objvCMFuncParaEN.UpdDate = null; //修改日期
if (objvCMFuncParaEN.UpdUser == "[null]") objvCMFuncParaEN.UpdUser = null; //修改者
if (objvCMFuncParaEN.Memo == "[null]") objvCMFuncParaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMFuncParaEN objvCMFuncParaEN)
{
 vCMFuncParaDA.CheckProperty4Condition(objvCMFuncParaEN);
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
if (clsCMFuncParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFuncParaBL没有刷新缓存机制(clsCMFuncParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFuncParaId");
//if (arrvCMFuncParaObjLstCache == null)
//{
//arrvCMFuncParaObjLstCache = vCMFuncParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFuncParaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMFuncParaEN GetObjByCmFuncParaIdCache(string strCmFuncParaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
List<clsvCMFuncParaEN> arrvCMFuncParaObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFuncParaEN> arrvCMFuncParaObjLst_Sel =
arrvCMFuncParaObjLstCache
.Where(x=> x.CmFuncParaId == strCmFuncParaId 
);
if (arrvCMFuncParaObjLst_Sel.Count() == 0)
{
   clsvCMFuncParaEN obj = clsvCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMFuncParaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaEN> GetAllvCMFuncParaObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMFuncParaEN> arrvCMFuncParaObjLstCache = GetObjLstCache(); 
return arrvCMFuncParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMFuncParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
List<clsvCMFuncParaEN> arrvCMFuncParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMFuncParaObjLstCache;
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
string strKey = string.Format("{0}", clsvCMFuncParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCMFuncParaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMFuncParaEN._RefreshTimeLst.Count == 0) return "";
return clsvCMFuncParaEN._RefreshTimeLst[clsvCMFuncParaEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCmFuncParaId)
{
if (strInFldName != convCMFuncPara.CmFuncParaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMFuncPara._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMFuncPara._AttributeName));
throw new Exception(strMsg);
}
var objvCMFuncPara = clsvCMFuncParaBL.GetObjByCmFuncParaIdCache(strCmFuncParaId);
if (objvCMFuncPara == null) return "";
return objvCMFuncPara[strOutFldName].ToString();
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
int intRecCount = clsvCMFuncParaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMFuncParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMFuncParaDA.GetRecCount();
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
int intRecCount = clsvCMFuncParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMFuncParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMFuncParaEN objvCMFuncParaCond)
{
List<clsvCMFuncParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMFuncParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMFuncPara._AttributeName)
{
if (objvCMFuncParaCond.IsUpdated(strFldName) == false) continue;
if (objvCMFuncParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaCond[strFldName].ToString());
}
else
{
if (objvCMFuncParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMFuncParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMFuncParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMFuncParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMFuncParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMFuncParaCond[strFldName]));
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
 List<string> arrList = clsvCMFuncParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMFuncParaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMFuncParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}