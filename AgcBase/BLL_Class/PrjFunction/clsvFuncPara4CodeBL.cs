
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncPara4CodeBL
 表名:vFuncPara4Code(00050385)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:54
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
public static class  clsvFuncPara4CodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncPara4CodeEN GetObj(this K_FuncParaId4Code_vFuncPara4Code myKey)
{
clsvFuncPara4CodeEN objvFuncPara4CodeEN = clsvFuncPara4CodeBL.vFuncPara4CodeDA.GetObjByFuncParaId4Code(myKey.Value);
return objvFuncPara4CodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncParaId4Code(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strFuncParaId4Code, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, convFuncPara4Code.FuncParaId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, convFuncPara4Code.FuncParaId4Code);
}
objvFuncPara4CodeEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncParaId4Code) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncParaId4Code, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncParaId4Code] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParaName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaName, convFuncPara4Code.ParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, convFuncPara4Code.ParaName);
}
objvFuncPara4CodeEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParaName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParaName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParaName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParaCnName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParaCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParaCnName, convFuncPara4Code.ParaCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convFuncPara4Code.ParaCnName);
}
objvFuncPara4CodeEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParaCnName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParaCnName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParaCnName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataTypeId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFuncPara4Code.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFuncPara4Code.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFuncPara4Code.DataTypeId);
}
objvFuncPara4CodeEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataTypeId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataTypeId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataTypeId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataTypeName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFuncPara4Code.DataTypeName);
}
objvFuncPara4CodeEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataTypeName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataTypeName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataTypeName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetDataCnName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataCnName, convFuncPara4Code.DataCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convFuncPara4Code.DataCnName);
}
objvFuncPara4CodeEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.DataCnName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.DataCnName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.DataCnName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetCsType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, convFuncPara4Code.CsType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convFuncPara4Code.CsType);
}
objvFuncPara4CodeEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.CsType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.CsType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.CsType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetJavaType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJavaType, convFuncPara4Code.JavaType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convFuncPara4Code.JavaType);
}
objvFuncPara4CodeEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.JavaType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.JavaType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.JavaType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetJavaObjType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convFuncPara4Code.JavaObjType);
}
objvFuncPara4CodeEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.JavaObjType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.JavaObjType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.JavaObjType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetSwiftType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convFuncPara4Code.SwiftType);
}
objvFuncPara4CodeEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.SwiftType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.SwiftType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.SwiftType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetIsNeedQuote(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, convFuncPara4Code.IsNeedQuote);
objvFuncPara4CodeEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.IsNeedQuote) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.IsNeedQuote, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.IsNeedQuote] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetOraDbType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convFuncPara4Code.OraDbType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFuncPara4Code.OraDbType);
}
objvFuncPara4CodeEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.OraDbType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.OraDbType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.OraDbType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetMySqlType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convFuncPara4Code.MySqlType);
}
objvFuncPara4CodeEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.MySqlType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.MySqlType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.MySqlType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParameterType(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParameterType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, convFuncPara4Code.ParameterType);
}
objvFuncPara4CodeEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParameterType) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParameterType, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParameterType] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetParameterTypeFullName(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convFuncPara4Code.ParameterTypeFullName);
}
objvFuncPara4CodeEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.ParameterTypeFullName) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.ParameterTypeFullName, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.ParameterTypeFullName] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetIsByRef(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, bool bolIsByRef, string strComparisonOp="")
	{
objvFuncPara4CodeEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.IsByRef) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.IsByRef, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.IsByRef] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetPrjId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncPara4Code.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncPara4Code.PrjId);
}
objvFuncPara4CodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.PrjId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.PrjId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.PrjId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncPurposeId(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, convFuncPara4Code.FuncPurposeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, convFuncPara4Code.FuncPurposeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, convFuncPara4Code.FuncPurposeId);
}
objvFuncPara4CodeEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncPurposeId) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncPurposeId, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncPurposeId] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetUpdDate(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncPara4Code.UpdDate);
}
objvFuncPara4CodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.UpdDate) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.UpdDate, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.UpdDate] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetUpdUser(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncPara4Code.UpdUser);
}
objvFuncPara4CodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.UpdUser) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.UpdUser, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.UpdUser] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetMemo(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncPara4Code.Memo);
}
objvFuncPara4CodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.Memo) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.Memo, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.Memo] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncPara4CodeEN SetFuncCount(this clsvFuncPara4CodeEN objvFuncPara4CodeEN, int? intFuncCount, string strComparisonOp="")
	{
objvFuncPara4CodeEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncPara4CodeEN.dicFldComparisonOp.ContainsKey(convFuncPara4Code.FuncCount) == false)
{
objvFuncPara4CodeEN.dicFldComparisonOp.Add(convFuncPara4Code.FuncCount, strComparisonOp);
}
else
{
objvFuncPara4CodeEN.dicFldComparisonOp[convFuncPara4Code.FuncCount] = strComparisonOp;
}
}
return objvFuncPara4CodeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncPara4CodeENS">源对象</param>
 /// <param name = "objvFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(this clsvFuncPara4CodeEN objvFuncPara4CodeENS, clsvFuncPara4CodeEN objvFuncPara4CodeENT)
{
try
{
objvFuncPara4CodeENT.FuncParaId4Code = objvFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objvFuncPara4CodeENT.ParaName = objvFuncPara4CodeENS.ParaName; //参数名
objvFuncPara4CodeENT.ParaCnName = objvFuncPara4CodeENS.ParaCnName; //参数中文名
objvFuncPara4CodeENT.DataTypeId = objvFuncPara4CodeENS.DataTypeId; //数据类型Id
objvFuncPara4CodeENT.DataTypeName = objvFuncPara4CodeENS.DataTypeName; //数据类型名称
objvFuncPara4CodeENT.DataCnName = objvFuncPara4CodeENS.DataCnName; //数据类型中文名称
objvFuncPara4CodeENT.CsType = objvFuncPara4CodeENS.CsType; //CS类型
objvFuncPara4CodeENT.JavaType = objvFuncPara4CodeENS.JavaType; //JAVA类型
objvFuncPara4CodeENT.JavaObjType = objvFuncPara4CodeENS.JavaObjType; //JAVA对象类型
objvFuncPara4CodeENT.SwiftType = objvFuncPara4CodeENS.SwiftType; //SwiftType
objvFuncPara4CodeENT.IsNeedQuote = objvFuncPara4CodeENS.IsNeedQuote; //是否需要引号
objvFuncPara4CodeENT.OraDbType = objvFuncPara4CodeENS.OraDbType; //Ora数据类型
objvFuncPara4CodeENT.MySqlType = objvFuncPara4CodeENS.MySqlType; //MySqlType
objvFuncPara4CodeENT.ParameterType = objvFuncPara4CodeENS.ParameterType; //参数类型
objvFuncPara4CodeENT.ParameterTypeFullName = objvFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objvFuncPara4CodeENT.IsByRef = objvFuncPara4CodeENS.IsByRef; //是否引用型参数
objvFuncPara4CodeENT.PrjId = objvFuncPara4CodeENS.PrjId; //工程Id
objvFuncPara4CodeENT.FuncPurposeId = objvFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objvFuncPara4CodeENT.UpdDate = objvFuncPara4CodeENS.UpdDate; //修改日期
objvFuncPara4CodeENT.UpdUser = objvFuncPara4CodeENS.UpdUser; //修改者
objvFuncPara4CodeENT.Memo = objvFuncPara4CodeENS.Memo; //说明
objvFuncPara4CodeENT.FuncCount = objvFuncPara4CodeENS.FuncCount; //函数数目
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
 /// <param name = "objvFuncPara4CodeENS">源对象</param>
 /// <returns>目标对象=>clsvFuncPara4CodeEN:objvFuncPara4CodeENT</returns>
 public static clsvFuncPara4CodeEN CopyTo(this clsvFuncPara4CodeEN objvFuncPara4CodeENS)
{
try
{
 clsvFuncPara4CodeEN objvFuncPara4CodeENT = new clsvFuncPara4CodeEN()
{
FuncParaId4Code = objvFuncPara4CodeENS.FuncParaId4Code, //函数参数Id
ParaName = objvFuncPara4CodeENS.ParaName, //参数名
ParaCnName = objvFuncPara4CodeENS.ParaCnName, //参数中文名
DataTypeId = objvFuncPara4CodeENS.DataTypeId, //数据类型Id
DataTypeName = objvFuncPara4CodeENS.DataTypeName, //数据类型名称
DataCnName = objvFuncPara4CodeENS.DataCnName, //数据类型中文名称
CsType = objvFuncPara4CodeENS.CsType, //CS类型
JavaType = objvFuncPara4CodeENS.JavaType, //JAVA类型
JavaObjType = objvFuncPara4CodeENS.JavaObjType, //JAVA对象类型
SwiftType = objvFuncPara4CodeENS.SwiftType, //SwiftType
IsNeedQuote = objvFuncPara4CodeENS.IsNeedQuote, //是否需要引号
OraDbType = objvFuncPara4CodeENS.OraDbType, //Ora数据类型
MySqlType = objvFuncPara4CodeENS.MySqlType, //MySqlType
ParameterType = objvFuncPara4CodeENS.ParameterType, //参数类型
ParameterTypeFullName = objvFuncPara4CodeENS.ParameterTypeFullName, //参数类型全名
IsByRef = objvFuncPara4CodeENS.IsByRef, //是否引用型参数
PrjId = objvFuncPara4CodeENS.PrjId, //工程Id
FuncPurposeId = objvFuncPara4CodeENS.FuncPurposeId, //函数用途Id
UpdDate = objvFuncPara4CodeENS.UpdDate, //修改日期
UpdUser = objvFuncPara4CodeENS.UpdUser, //修改者
Memo = objvFuncPara4CodeENS.Memo, //说明
FuncCount = objvFuncPara4CodeENS.FuncCount, //函数数目
};
 return objvFuncPara4CodeENT;
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
public static void CheckProperty4Condition(this clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
 clsvFuncPara4CodeBL.vFuncPara4CodeDA.CheckProperty4Condition(objvFuncPara4CodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncPara4CodeEN objvFuncPara4CodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.FuncParaId4Code, objvFuncPara4CodeCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParaName) == true)
{
string strComparisonOpParaName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParaName, objvFuncPara4CodeCond.ParaName, strComparisonOpParaName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParaCnName, objvFuncPara4CodeCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataTypeId, objvFuncPara4CodeCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataTypeName, objvFuncPara4CodeCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.DataCnName) == true)
{
string strComparisonOpDataCnName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.DataCnName, objvFuncPara4CodeCond.DataCnName, strComparisonOpDataCnName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.CsType) == true)
{
string strComparisonOpCsType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.CsType, objvFuncPara4CodeCond.CsType, strComparisonOpCsType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.JavaType) == true)
{
string strComparisonOpJavaType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.JavaType, objvFuncPara4CodeCond.JavaType, strComparisonOpJavaType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.JavaObjType, objvFuncPara4CodeCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.SwiftType) == true)
{
string strComparisonOpSwiftType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.SwiftType, objvFuncPara4CodeCond.SwiftType, strComparisonOpSwiftType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.IsNeedQuote) == true)
{
if (objvFuncPara4CodeCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncPara4Code.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncPara4Code.IsNeedQuote);
}
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.OraDbType) == true)
{
string strComparisonOpOraDbType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.OraDbType, objvFuncPara4CodeCond.OraDbType, strComparisonOpOraDbType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.MySqlType) == true)
{
string strComparisonOpMySqlType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.MySqlType, objvFuncPara4CodeCond.MySqlType, strComparisonOpMySqlType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParameterType) == true)
{
string strComparisonOpParameterType = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParameterType, objvFuncPara4CodeCond.ParameterType, strComparisonOpParameterType);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.ParameterTypeFullName, objvFuncPara4CodeCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.IsByRef) == true)
{
if (objvFuncPara4CodeCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncPara4Code.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncPara4Code.IsByRef);
}
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.PrjId, objvFuncPara4CodeCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.FuncPurposeId, objvFuncPara4CodeCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.UpdDate, objvFuncPara4CodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.UpdUser, objvFuncPara4CodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.Memo) == true)
{
string strComparisonOpMemo = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncPara4Code.Memo, objvFuncPara4CodeCond.Memo, strComparisonOpMemo);
}
if (objvFuncPara4CodeCond.IsUpdated(convFuncPara4Code.FuncCount) == true)
{
string strComparisonOpFuncCount = objvFuncPara4CodeCond.dicFldComparisonOp[convFuncPara4Code.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncPara4Code.FuncCount, objvFuncPara4CodeCond.FuncCount, strComparisonOpFuncCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncPara4Code
{
public virtual bool UpdRelaTabDate(string strFuncParaId4Code, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数参数4Code(vFuncPara4Code)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncPara4CodeBL
{
public static RelatedActions_vFuncPara4Code relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncPara4CodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncPara4CodeDA vFuncPara4CodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncPara4CodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncPara4CodeBL()
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
if (string.IsNullOrEmpty(clsvFuncPara4CodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncPara4CodeEN._ConnectString);
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
public static DataTable GetDataTable_vFuncPara4Code(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncPara4CodeDA.GetDataTable_vFuncPara4Code(strWhereCond);
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
objDT = vFuncPara4CodeDA.GetDataTable(strWhereCond);
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
objDT = vFuncPara4CodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncPara4CodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncPara4CodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncPara4CodeDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncPara4CodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncPara4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncPara4CodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncParaId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLst(List<string> arrFuncParaId4CodeLst)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncParaId4CodeLst, true);
 string strWhereCond = string.Format("FuncParaId4Code in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncParaId4CodeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncPara4CodeEN> GetObjLstByFuncParaId4CodeLstCache(List<string> arrFuncParaId4CodeLst, string strFuncPurposeId)
{
string strKey = string.Format("{0}_{1}", clsvFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
List<clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLst_Sel =
arrvFuncPara4CodeObjLstCache
.Where(x => arrFuncParaId4CodeLst.Contains(x.FuncParaId4Code));
return arrvFuncPara4CodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLst(string strWhereCond)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
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
public static List<clsvFuncPara4CodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncPara4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncPara4CodeEN> GetSubObjLstCache(clsvFuncPara4CodeEN objvFuncPara4CodeCond)
{
 string strFuncPurposeId = objvFuncPara4CodeCond.FuncPurposeId;
 if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFuncPara4CodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFuncPara4CodeEN> arrObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsvFuncPara4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncPara4Code._AttributeName)
{
if (objvFuncPara4CodeCond.IsUpdated(strFldName) == false) continue;
if (objvFuncPara4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncPara4CodeCond[strFldName].ToString());
}
else
{
if (objvFuncPara4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncPara4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncPara4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncPara4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncPara4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncPara4CodeCond[strFldName]));
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
public static List<clsvFuncPara4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
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
public static List<clsvFuncPara4CodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
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
List<clsvFuncPara4CodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncPara4CodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncPara4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
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
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
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
public static List<clsvFuncPara4CodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncPara4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
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
public static List<clsvFuncPara4CodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncPara4CodeEN> arrObjLst = new List<clsvFuncPara4CodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncPara4CodeEN objvFuncPara4CodeEN = new clsvFuncPara4CodeEN();
try
{
objvFuncPara4CodeEN.FuncParaId4Code = objRow[convFuncPara4Code.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncPara4CodeEN.ParaName = objRow[convFuncPara4Code.ParaName].ToString().Trim(); //参数名
objvFuncPara4CodeEN.ParaCnName = objRow[convFuncPara4Code.ParaCnName].ToString().Trim(); //参数中文名
objvFuncPara4CodeEN.DataTypeId = objRow[convFuncPara4Code.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncPara4CodeEN.DataTypeName = objRow[convFuncPara4Code.DataTypeName] == DBNull.Value ? null : objRow[convFuncPara4Code.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncPara4CodeEN.DataCnName = objRow[convFuncPara4Code.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncPara4CodeEN.CsType = objRow[convFuncPara4Code.CsType].ToString().Trim(); //CS类型
objvFuncPara4CodeEN.JavaType = objRow[convFuncPara4Code.JavaType].ToString().Trim(); //JAVA类型
objvFuncPara4CodeEN.JavaObjType = objRow[convFuncPara4Code.JavaObjType] == DBNull.Value ? null : objRow[convFuncPara4Code.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncPara4CodeEN.SwiftType = objRow[convFuncPara4Code.SwiftType] == DBNull.Value ? null : objRow[convFuncPara4Code.SwiftType].ToString().Trim(); //SwiftType
objvFuncPara4CodeEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncPara4CodeEN.OraDbType = objRow[convFuncPara4Code.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncPara4CodeEN.MySqlType = objRow[convFuncPara4Code.MySqlType] == DBNull.Value ? null : objRow[convFuncPara4Code.MySqlType].ToString().Trim(); //MySqlType
objvFuncPara4CodeEN.ParameterType = objRow[convFuncPara4Code.ParameterType] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterType].ToString().Trim(); //参数类型
objvFuncPara4CodeEN.ParameterTypeFullName = objRow[convFuncPara4Code.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncPara4Code.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncPara4CodeEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncPara4Code.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncPara4CodeEN.PrjId = objRow[convFuncPara4Code.PrjId] == DBNull.Value ? null : objRow[convFuncPara4Code.PrjId].ToString().Trim(); //工程Id
objvFuncPara4CodeEN.FuncPurposeId = objRow[convFuncPara4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFuncPara4CodeEN.UpdDate = objRow[convFuncPara4Code.UpdDate] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdDate].ToString().Trim(); //修改日期
objvFuncPara4CodeEN.UpdUser = objRow[convFuncPara4Code.UpdUser] == DBNull.Value ? null : objRow[convFuncPara4Code.UpdUser].ToString().Trim(); //修改者
objvFuncPara4CodeEN.Memo = objRow[convFuncPara4Code.Memo] == DBNull.Value ? null : objRow[convFuncPara4Code.Memo].ToString().Trim(); //说明
objvFuncPara4CodeEN.FuncCount = objRow[convFuncPara4Code.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncPara4Code.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncPara4CodeEN.FuncParaId4Code, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncPara4CodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncPara4CodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncPara4Code(ref clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
bool bolResult = vFuncPara4CodeDA.GetvFuncPara4Code(ref objvFuncPara4CodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncParaId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncPara4CodeEN GetObjByFuncParaId4Code(string strFuncParaId4Code)
{
if (strFuncParaId4Code.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncParaId4Code]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncParaId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncParaId4Code]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFuncPara4CodeEN objvFuncPara4CodeEN = vFuncPara4CodeDA.GetObjByFuncParaId4Code(strFuncParaId4Code);
return objvFuncPara4CodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncPara4CodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncPara4CodeEN objvFuncPara4CodeEN = vFuncPara4CodeDA.GetFirstObj(strWhereCond);
 return objvFuncPara4CodeEN;
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
public static clsvFuncPara4CodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncPara4CodeEN objvFuncPara4CodeEN = vFuncPara4CodeDA.GetObjByDataRow(objRow);
 return objvFuncPara4CodeEN;
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
public static clsvFuncPara4CodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncPara4CodeEN objvFuncPara4CodeEN = vFuncPara4CodeDA.GetObjByDataRow(objRow);
 return objvFuncPara4CodeEN;
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
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <param name = "lstvFuncPara4CodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncPara4CodeEN GetObjByFuncParaId4CodeFromList(string strFuncParaId4Code, List<clsvFuncPara4CodeEN> lstvFuncPara4CodeObjLst)
{
foreach (clsvFuncPara4CodeEN objvFuncPara4CodeEN in lstvFuncPara4CodeObjLst)
{
if (objvFuncPara4CodeEN.FuncParaId4Code == strFuncParaId4Code)
{
return objvFuncPara4CodeEN;
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
 string strFuncParaId4Code;
 try
 {
 strFuncParaId4Code = new clsvFuncPara4CodeDA().GetFirstID(strWhereCond);
 return strFuncParaId4Code;
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
 arrList = vFuncPara4CodeDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncPara4CodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncParaId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncParaId4Code)
{
if (string.IsNullOrEmpty(strFuncParaId4Code) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncParaId4Code]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFuncPara4CodeDA.IsExist(strFuncParaId4Code);
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
 bolIsExist = clsvFuncPara4CodeDA.IsExistTable();
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
 bolIsExist = vFuncPara4CodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncPara4CodeENS">源对象</param>
 /// <param name = "objvFuncPara4CodeENT">目标对象</param>
 public static void CopyTo(clsvFuncPara4CodeEN objvFuncPara4CodeENS, clsvFuncPara4CodeEN objvFuncPara4CodeENT)
{
try
{
objvFuncPara4CodeENT.FuncParaId4Code = objvFuncPara4CodeENS.FuncParaId4Code; //函数参数Id
objvFuncPara4CodeENT.ParaName = objvFuncPara4CodeENS.ParaName; //参数名
objvFuncPara4CodeENT.ParaCnName = objvFuncPara4CodeENS.ParaCnName; //参数中文名
objvFuncPara4CodeENT.DataTypeId = objvFuncPara4CodeENS.DataTypeId; //数据类型Id
objvFuncPara4CodeENT.DataTypeName = objvFuncPara4CodeENS.DataTypeName; //数据类型名称
objvFuncPara4CodeENT.DataCnName = objvFuncPara4CodeENS.DataCnName; //数据类型中文名称
objvFuncPara4CodeENT.CsType = objvFuncPara4CodeENS.CsType; //CS类型
objvFuncPara4CodeENT.JavaType = objvFuncPara4CodeENS.JavaType; //JAVA类型
objvFuncPara4CodeENT.JavaObjType = objvFuncPara4CodeENS.JavaObjType; //JAVA对象类型
objvFuncPara4CodeENT.SwiftType = objvFuncPara4CodeENS.SwiftType; //SwiftType
objvFuncPara4CodeENT.IsNeedQuote = objvFuncPara4CodeENS.IsNeedQuote; //是否需要引号
objvFuncPara4CodeENT.OraDbType = objvFuncPara4CodeENS.OraDbType; //Ora数据类型
objvFuncPara4CodeENT.MySqlType = objvFuncPara4CodeENS.MySqlType; //MySqlType
objvFuncPara4CodeENT.ParameterType = objvFuncPara4CodeENS.ParameterType; //参数类型
objvFuncPara4CodeENT.ParameterTypeFullName = objvFuncPara4CodeENS.ParameterTypeFullName; //参数类型全名
objvFuncPara4CodeENT.IsByRef = objvFuncPara4CodeENS.IsByRef; //是否引用型参数
objvFuncPara4CodeENT.PrjId = objvFuncPara4CodeENS.PrjId; //工程Id
objvFuncPara4CodeENT.FuncPurposeId = objvFuncPara4CodeENS.FuncPurposeId; //函数用途Id
objvFuncPara4CodeENT.UpdDate = objvFuncPara4CodeENS.UpdDate; //修改日期
objvFuncPara4CodeENT.UpdUser = objvFuncPara4CodeENS.UpdUser; //修改者
objvFuncPara4CodeENT.Memo = objvFuncPara4CodeENS.Memo; //说明
objvFuncPara4CodeENT.FuncCount = objvFuncPara4CodeENS.FuncCount; //函数数目
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
 /// <param name = "objvFuncPara4CodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
try
{
objvFuncPara4CodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncPara4CodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncPara4Code.FuncParaId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.FuncParaId4Code = objvFuncPara4CodeEN.FuncParaId4Code; //函数参数Id
}
if (arrFldSet.Contains(convFuncPara4Code.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.ParaName = objvFuncPara4CodeEN.ParaName; //参数名
}
if (arrFldSet.Contains(convFuncPara4Code.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.ParaCnName = objvFuncPara4CodeEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(convFuncPara4Code.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.DataTypeId = objvFuncPara4CodeEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convFuncPara4Code.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.DataTypeName = objvFuncPara4CodeEN.DataTypeName == "[null]" ? null :  objvFuncPara4CodeEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convFuncPara4Code.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.DataCnName = objvFuncPara4CodeEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(convFuncPara4Code.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.CsType = objvFuncPara4CodeEN.CsType; //CS类型
}
if (arrFldSet.Contains(convFuncPara4Code.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.JavaType = objvFuncPara4CodeEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convFuncPara4Code.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.JavaObjType = objvFuncPara4CodeEN.JavaObjType == "[null]" ? null :  objvFuncPara4CodeEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(convFuncPara4Code.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.SwiftType = objvFuncPara4CodeEN.SwiftType == "[null]" ? null :  objvFuncPara4CodeEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(convFuncPara4Code.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.IsNeedQuote = objvFuncPara4CodeEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convFuncPara4Code.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.OraDbType = objvFuncPara4CodeEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convFuncPara4Code.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.MySqlType = objvFuncPara4CodeEN.MySqlType == "[null]" ? null :  objvFuncPara4CodeEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(convFuncPara4Code.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.ParameterType = objvFuncPara4CodeEN.ParameterType == "[null]" ? null :  objvFuncPara4CodeEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(convFuncPara4Code.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.ParameterTypeFullName = objvFuncPara4CodeEN.ParameterTypeFullName == "[null]" ? null :  objvFuncPara4CodeEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(convFuncPara4Code.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.IsByRef = objvFuncPara4CodeEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(convFuncPara4Code.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.PrjId = objvFuncPara4CodeEN.PrjId == "[null]" ? null :  objvFuncPara4CodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFuncPara4Code.FuncPurposeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.FuncPurposeId = objvFuncPara4CodeEN.FuncPurposeId; //函数用途Id
}
if (arrFldSet.Contains(convFuncPara4Code.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.UpdDate = objvFuncPara4CodeEN.UpdDate == "[null]" ? null :  objvFuncPara4CodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFuncPara4Code.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.UpdUser = objvFuncPara4CodeEN.UpdUser == "[null]" ? null :  objvFuncPara4CodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFuncPara4Code.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.Memo = objvFuncPara4CodeEN.Memo == "[null]" ? null :  objvFuncPara4CodeEN.Memo; //说明
}
if (arrFldSet.Contains(convFuncPara4Code.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncPara4CodeEN.FuncCount = objvFuncPara4CodeEN.FuncCount; //函数数目
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
 /// <param name = "objvFuncPara4CodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
try
{
if (objvFuncPara4CodeEN.DataTypeName == "[null]") objvFuncPara4CodeEN.DataTypeName = null; //数据类型名称
if (objvFuncPara4CodeEN.JavaObjType == "[null]") objvFuncPara4CodeEN.JavaObjType = null; //JAVA对象类型
if (objvFuncPara4CodeEN.SwiftType == "[null]") objvFuncPara4CodeEN.SwiftType = null; //SwiftType
if (objvFuncPara4CodeEN.MySqlType == "[null]") objvFuncPara4CodeEN.MySqlType = null; //MySqlType
if (objvFuncPara4CodeEN.ParameterType == "[null]") objvFuncPara4CodeEN.ParameterType = null; //参数类型
if (objvFuncPara4CodeEN.ParameterTypeFullName == "[null]") objvFuncPara4CodeEN.ParameterTypeFullName = null; //参数类型全名
if (objvFuncPara4CodeEN.PrjId == "[null]") objvFuncPara4CodeEN.PrjId = null; //工程Id
if (objvFuncPara4CodeEN.UpdDate == "[null]") objvFuncPara4CodeEN.UpdDate = null; //修改日期
if (objvFuncPara4CodeEN.UpdUser == "[null]") objvFuncPara4CodeEN.UpdUser = null; //修改者
if (objvFuncPara4CodeEN.Memo == "[null]") objvFuncPara4CodeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFuncPara4CodeEN objvFuncPara4CodeEN)
{
 vFuncPara4CodeDA.CheckProperty4Condition(objvFuncPara4CodeEN);
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
if (clsFuncPara4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncPara4CodeBL没有刷新缓存机制(clsFuncPara4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncParaId4Code");
//if (arrvFuncPara4CodeObjLstCache == null)
//{
//arrvFuncPara4CodeObjLstCache = vFuncPara4CodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncParaId4Code">所给的关键字</param>
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncPara4CodeEN GetObjByFuncParaId4CodeCache(string strFuncParaId4Code, string strFuncPurposeId)
{

if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确!(In {1})", strFuncPurposeId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
List<clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLst_Sel =
arrvFuncPara4CodeObjLstCache
.Where(x=> x.FuncParaId4Code == strFuncParaId4Code 
);
if (arrvFuncPara4CodeObjLst_Sel.Count() == 0)
{
   clsvFuncPara4CodeEN obj = clsvFuncPara4CodeBL.GetObjByFuncParaId4Code(strFuncParaId4Code);
   if (obj != null)
 {
if (obj.FuncPurposeId == strFuncPurposeId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFuncParaId4Code, strFuncPurposeId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFuncPara4CodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetAllvFuncPara4CodeObjLstCache(string strFuncPurposeId)
{
//获取缓存中的对象列表
List<clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLstCache = GetObjLstCache(strFuncPurposeId); 
return arrvFuncPara4CodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncPara4CodeEN> GetObjLstCache(string strFuncPurposeId)
{

if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
  var strMsg = string.Format("参数:[strFuncPurposeId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strFuncPurposeId.Length != 2)
{
var strMsg = string.Format("缓存分类变量:[strFuncPurposeId]的长度:[{0}]不正确!(In {1})", strFuncPurposeId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
string strCondition = string.Format("FuncPurposeId='{0}'", strFuncPurposeId);
List<clsvFuncPara4CodeEN> arrvFuncPara4CodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFuncPara4CodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strFuncPurposeId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFuncPara4CodeEN._CurrTabName, strFuncPurposeId);
CacheHelper.Remove(strKey);
clsvFuncPara4CodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFuncPara4CodeEN._RefreshTimeLst.Count == 0) return "";
return clsvFuncPara4CodeEN._RefreshTimeLst[clsvFuncPara4CodeEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strFuncPurposeId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncParaId4Code, string strFuncPurposeId)
{
if (strInFldName != convFuncPara4Code.FuncParaId4Code)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncPara4Code._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncPara4Code._AttributeName));
throw new Exception(strMsg);
}
var objvFuncPara4Code = clsvFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(strFuncParaId4Code, strFuncPurposeId);
if (objvFuncPara4Code == null) return "";
return objvFuncPara4Code[strOutFldName].ToString();
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
int intRecCount = clsvFuncPara4CodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncPara4CodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncPara4CodeDA.GetRecCount();
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
int intRecCount = clsvFuncPara4CodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncPara4CodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncPara4CodeEN objvFuncPara4CodeCond)
{
 string strFuncPurposeId = objvFuncPara4CodeCond.FuncPurposeId;
 if (string.IsNullOrEmpty(strFuncPurposeId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFuncPara4CodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFuncPara4CodeEN> arrObjLstCache = GetObjLstCache(strFuncPurposeId);
IEnumerable <clsvFuncPara4CodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncPara4Code._AttributeName)
{
if (objvFuncPara4CodeCond.IsUpdated(strFldName) == false) continue;
if (objvFuncPara4CodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncPara4CodeCond[strFldName].ToString());
}
else
{
if (objvFuncPara4CodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncPara4CodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncPara4CodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncPara4CodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncPara4CodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncPara4CodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncPara4CodeCond[strFldName]));
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
 List<string> arrList = clsvFuncPara4CodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncPara4CodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncPara4CodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}