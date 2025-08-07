
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncParaRelaBL
 表名:vFuncParaRela(00050499)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:43
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
public static class  clsvFuncParaRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncParaRelaEN GetObj(this K_mId_vFuncParaRela myKey)
{
clsvFuncParaRelaEN objvFuncParaRelaEN = clsvFuncParaRelaBL.vFuncParaRelaDA.GetObjBymId(myKey.Value);
return objvFuncParaRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetmId(this clsvFuncParaRelaEN objvFuncParaRelaEN, long lngmId, string strComparisonOp="")
	{
objvFuncParaRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.mId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.mId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.mId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncParaId4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncParaId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncParaId4Code, convFuncParaRela.FuncParaId4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaId4Code, 8, convFuncParaRela.FuncParaId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncParaId4Code, 8, convFuncParaRela.FuncParaId4Code);
}
objvFuncParaRelaEN.FuncParaId4Code = strFuncParaId4Code; //函数参数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncParaId4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncParaId4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncParaId4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParaName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParaName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaName, 50, convFuncParaRela.ParaName);
}
objvFuncParaRelaEN.ParaName = strParaName; //参数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParaName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParaName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParaName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParaCnName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParaCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaCnName, 50, convFuncParaRela.ParaCnName);
}
objvFuncParaRelaEN.ParaCnName = strParaCnName; //参数中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParaCnName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParaCnName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParaCnName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataTypeId(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFuncParaRela.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFuncParaRela.DataTypeId);
}
objvFuncParaRelaEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataTypeId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataTypeId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataTypeId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataTypeName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFuncParaRela.DataTypeName);
}
objvFuncParaRelaEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataTypeName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataTypeName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataTypeName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetDataCnName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strDataCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convFuncParaRela.DataCnName);
}
objvFuncParaRelaEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.DataCnName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.DataCnName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.DataCnName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetCsType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strCsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convFuncParaRela.CsType);
}
objvFuncParaRelaEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.CsType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.CsType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.CsType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetJavaType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strJavaType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaType, 100, convFuncParaRela.JavaType);
}
objvFuncParaRelaEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.JavaType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.JavaType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.JavaType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetJavaObjType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strJavaObjType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, convFuncParaRela.JavaObjType);
}
objvFuncParaRelaEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.JavaObjType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.JavaObjType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.JavaObjType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetSwiftType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strSwiftType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSwiftType, 100, convFuncParaRela.SwiftType);
}
objvFuncParaRelaEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.SwiftType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.SwiftType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.SwiftType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsNeedQuote(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsNeedQuote) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsNeedQuote, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsNeedQuote] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetOraDbType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strOraDbType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFuncParaRela.OraDbType);
}
objvFuncParaRelaEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.OraDbType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.OraDbType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.OraDbType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetMySqlType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strMySqlType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMySqlType, 100, convFuncParaRela.MySqlType);
}
objvFuncParaRelaEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.MySqlType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.MySqlType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.MySqlType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParameterType(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParameterType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterType, 100, convFuncParaRela.ParameterType);
}
objvFuncParaRelaEN.ParameterType = strParameterType; //参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParameterType) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParameterType, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParameterType] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetParameterTypeFullName(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strParameterTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParameterTypeFullName, 500, convFuncParaRela.ParameterTypeFullName);
}
objvFuncParaRelaEN.ParameterTypeFullName = strParameterTypeFullName; //参数类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.ParameterTypeFullName) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.ParameterTypeFullName, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.ParameterTypeFullName] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsByRef(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsByRef, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsByRef = bolIsByRef; //是否引用型参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsByRef) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsByRef, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsByRef] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetPrjId(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFuncParaRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFuncParaRela.PrjId);
}
objvFuncParaRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.PrjId) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.PrjId, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.PrjId] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncId4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Code, convFuncParaRela.FuncId4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFuncParaRela.FuncId4Code);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFuncParaRela.FuncId4Code);
}
objvFuncParaRelaEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncId4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncId4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncId4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFuncName4Code(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFuncParaRela.FuncName4Code);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFuncParaRela.FuncName4Code);
}
objvFuncParaRelaEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FuncName4Code) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FuncName4Code, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FuncName4Code] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetFunctionSignature(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, convFuncParaRela.FunctionSignature);
}
objvFuncParaRelaEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.FunctionSignature) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.FunctionSignature, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.FunctionSignature] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsAsyncFunc(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsAsyncFunc) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsAsyncFunc, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsAsyncFunc] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetIsSysFunction(this clsvFuncParaRelaEN objvFuncParaRelaEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objvFuncParaRelaEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.IsSysFunction) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.IsSysFunction, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.IsSysFunction] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetOrderNum(this clsvFuncParaRelaEN objvFuncParaRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFuncParaRela.OrderNum);
objvFuncParaRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.OrderNum) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.OrderNum, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.OrderNum] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetUpdDate(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncParaRela.UpdDate);
}
objvFuncParaRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.UpdDate) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.UpdDate, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.UpdDate] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetUpdUser(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncParaRela.UpdUser);
}
objvFuncParaRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.UpdUser) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.UpdUser, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.UpdUser] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncParaRelaEN SetMemo(this clsvFuncParaRelaEN objvFuncParaRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncParaRela.Memo);
}
objvFuncParaRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncParaRelaEN.dicFldComparisonOp.ContainsKey(convFuncParaRela.Memo) == false)
{
objvFuncParaRelaEN.dicFldComparisonOp.Add(convFuncParaRela.Memo, strComparisonOp);
}
else
{
objvFuncParaRelaEN.dicFldComparisonOp[convFuncParaRela.Memo] = strComparisonOp;
}
}
return objvFuncParaRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncParaRelaENS">源对象</param>
 /// <param name = "objvFuncParaRelaENT">目标对象</param>
 public static void CopyTo(this clsvFuncParaRelaEN objvFuncParaRelaENS, clsvFuncParaRelaEN objvFuncParaRelaENT)
{
try
{
objvFuncParaRelaENT.mId = objvFuncParaRelaENS.mId; //mId
objvFuncParaRelaENT.FuncParaId4Code = objvFuncParaRelaENS.FuncParaId4Code; //函数参数Id
objvFuncParaRelaENT.ParaName = objvFuncParaRelaENS.ParaName; //参数名
objvFuncParaRelaENT.ParaCnName = objvFuncParaRelaENS.ParaCnName; //参数中文名
objvFuncParaRelaENT.DataTypeId = objvFuncParaRelaENS.DataTypeId; //数据类型Id
objvFuncParaRelaENT.DataTypeName = objvFuncParaRelaENS.DataTypeName; //数据类型名称
objvFuncParaRelaENT.DataCnName = objvFuncParaRelaENS.DataCnName; //数据类型中文名称
objvFuncParaRelaENT.CsType = objvFuncParaRelaENS.CsType; //CS类型
objvFuncParaRelaENT.JavaType = objvFuncParaRelaENS.JavaType; //JAVA类型
objvFuncParaRelaENT.JavaObjType = objvFuncParaRelaENS.JavaObjType; //JAVA对象类型
objvFuncParaRelaENT.SwiftType = objvFuncParaRelaENS.SwiftType; //SwiftType
objvFuncParaRelaENT.IsNeedQuote = objvFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvFuncParaRelaENT.OraDbType = objvFuncParaRelaENS.OraDbType; //Ora数据类型
objvFuncParaRelaENT.MySqlType = objvFuncParaRelaENS.MySqlType; //MySqlType
objvFuncParaRelaENT.ParameterType = objvFuncParaRelaENS.ParameterType; //参数类型
objvFuncParaRelaENT.ParameterTypeFullName = objvFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvFuncParaRelaENT.IsByRef = objvFuncParaRelaENS.IsByRef; //是否引用型参数
objvFuncParaRelaENT.PrjId = objvFuncParaRelaENS.PrjId; //工程Id
objvFuncParaRelaENT.FuncId4Code = objvFuncParaRelaENS.FuncId4Code; //函数Id4Code
objvFuncParaRelaENT.FuncName4Code = objvFuncParaRelaENS.FuncName4Code; //函数名4Code
objvFuncParaRelaENT.FunctionSignature = objvFuncParaRelaENS.FunctionSignature; //函数签名
objvFuncParaRelaENT.IsAsyncFunc = objvFuncParaRelaENS.IsAsyncFunc; //是否异步函数
objvFuncParaRelaENT.IsSysFunction = objvFuncParaRelaENS.IsSysFunction; //是否系统函数
objvFuncParaRelaENT.OrderNum = objvFuncParaRelaENS.OrderNum; //序号
objvFuncParaRelaENT.UpdDate = objvFuncParaRelaENS.UpdDate; //修改日期
objvFuncParaRelaENT.UpdUser = objvFuncParaRelaENS.UpdUser; //修改者
objvFuncParaRelaENT.Memo = objvFuncParaRelaENS.Memo; //说明
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
 /// <param name = "objvFuncParaRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFuncParaRelaEN:objvFuncParaRelaENT</returns>
 public static clsvFuncParaRelaEN CopyTo(this clsvFuncParaRelaEN objvFuncParaRelaENS)
{
try
{
 clsvFuncParaRelaEN objvFuncParaRelaENT = new clsvFuncParaRelaEN()
{
mId = objvFuncParaRelaENS.mId, //mId
FuncParaId4Code = objvFuncParaRelaENS.FuncParaId4Code, //函数参数Id
ParaName = objvFuncParaRelaENS.ParaName, //参数名
ParaCnName = objvFuncParaRelaENS.ParaCnName, //参数中文名
DataTypeId = objvFuncParaRelaENS.DataTypeId, //数据类型Id
DataTypeName = objvFuncParaRelaENS.DataTypeName, //数据类型名称
DataCnName = objvFuncParaRelaENS.DataCnName, //数据类型中文名称
CsType = objvFuncParaRelaENS.CsType, //CS类型
JavaType = objvFuncParaRelaENS.JavaType, //JAVA类型
JavaObjType = objvFuncParaRelaENS.JavaObjType, //JAVA对象类型
SwiftType = objvFuncParaRelaENS.SwiftType, //SwiftType
IsNeedQuote = objvFuncParaRelaENS.IsNeedQuote, //是否需要引号
OraDbType = objvFuncParaRelaENS.OraDbType, //Ora数据类型
MySqlType = objvFuncParaRelaENS.MySqlType, //MySqlType
ParameterType = objvFuncParaRelaENS.ParameterType, //参数类型
ParameterTypeFullName = objvFuncParaRelaENS.ParameterTypeFullName, //参数类型全名
IsByRef = objvFuncParaRelaENS.IsByRef, //是否引用型参数
PrjId = objvFuncParaRelaENS.PrjId, //工程Id
FuncId4Code = objvFuncParaRelaENS.FuncId4Code, //函数Id4Code
FuncName4Code = objvFuncParaRelaENS.FuncName4Code, //函数名4Code
FunctionSignature = objvFuncParaRelaENS.FunctionSignature, //函数签名
IsAsyncFunc = objvFuncParaRelaENS.IsAsyncFunc, //是否异步函数
IsSysFunction = objvFuncParaRelaENS.IsSysFunction, //是否系统函数
OrderNum = objvFuncParaRelaENS.OrderNum, //序号
UpdDate = objvFuncParaRelaENS.UpdDate, //修改日期
UpdUser = objvFuncParaRelaENS.UpdUser, //修改者
Memo = objvFuncParaRelaENS.Memo, //说明
};
 return objvFuncParaRelaENT;
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
public static void CheckProperty4Condition(this clsvFuncParaRelaEN objvFuncParaRelaEN)
{
 clsvFuncParaRelaBL.vFuncParaRelaDA.CheckProperty4Condition(objvFuncParaRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncParaRelaEN objvFuncParaRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.mId) == true)
{
string strComparisonOpmId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncParaRela.mId, objvFuncParaRelaCond.mId, strComparisonOpmId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncParaId4Code) == true)
{
string strComparisonOpFuncParaId4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncParaId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncParaId4Code, objvFuncParaRelaCond.FuncParaId4Code, strComparisonOpFuncParaId4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParaName) == true)
{
string strComparisonOpParaName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParaName, objvFuncParaRelaCond.ParaName, strComparisonOpParaName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParaCnName) == true)
{
string strComparisonOpParaCnName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParaCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParaCnName, objvFuncParaRelaCond.ParaCnName, strComparisonOpParaCnName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataTypeId, objvFuncParaRelaCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataTypeName, objvFuncParaRelaCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.DataCnName) == true)
{
string strComparisonOpDataCnName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.DataCnName, objvFuncParaRelaCond.DataCnName, strComparisonOpDataCnName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.CsType) == true)
{
string strComparisonOpCsType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.CsType, objvFuncParaRelaCond.CsType, strComparisonOpCsType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.JavaType) == true)
{
string strComparisonOpJavaType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.JavaType, objvFuncParaRelaCond.JavaType, strComparisonOpJavaType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.JavaObjType, objvFuncParaRelaCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.SwiftType) == true)
{
string strComparisonOpSwiftType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.SwiftType, objvFuncParaRelaCond.SwiftType, strComparisonOpSwiftType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsNeedQuote) == true)
{
if (objvFuncParaRelaCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsNeedQuote);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.OraDbType) == true)
{
string strComparisonOpOraDbType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.OraDbType, objvFuncParaRelaCond.OraDbType, strComparisonOpOraDbType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.MySqlType) == true)
{
string strComparisonOpMySqlType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.MySqlType, objvFuncParaRelaCond.MySqlType, strComparisonOpMySqlType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParameterType) == true)
{
string strComparisonOpParameterType = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParameterType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParameterType, objvFuncParaRelaCond.ParameterType, strComparisonOpParameterType);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.ParameterTypeFullName) == true)
{
string strComparisonOpParameterTypeFullName = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.ParameterTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.ParameterTypeFullName, objvFuncParaRelaCond.ParameterTypeFullName, strComparisonOpParameterTypeFullName);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsByRef) == true)
{
if (objvFuncParaRelaCond.IsByRef == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsByRef);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsByRef);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.PrjId) == true)
{
string strComparisonOpPrjId = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.PrjId, objvFuncParaRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncId4Code, objvFuncParaRelaCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FuncName4Code, objvFuncParaRelaCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.FunctionSignature, objvFuncParaRelaCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsAsyncFunc) == true)
{
if (objvFuncParaRelaCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsAsyncFunc);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.IsSysFunction) == true)
{
if (objvFuncParaRelaCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFuncParaRela.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFuncParaRela.IsSysFunction);
}
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncParaRela.OrderNum, objvFuncParaRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.UpdDate, objvFuncParaRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.UpdUser, objvFuncParaRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncParaRelaCond.IsUpdated(convFuncParaRela.Memo) == true)
{
string strComparisonOpMemo = objvFuncParaRelaCond.dicFldComparisonOp[convFuncParaRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncParaRela.Memo, objvFuncParaRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncParaRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFuncParaRela(vFuncParaRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncParaRelaBL
{
public static RelatedActions_vFuncParaRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncParaRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncParaRelaDA vFuncParaRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncParaRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncParaRelaBL()
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
if (string.IsNullOrEmpty(clsvFuncParaRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncParaRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFuncParaRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncParaRelaDA.GetDataTable_vFuncParaRela(strWhereCond);
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
objDT = vFuncParaRelaDA.GetDataTable(strWhereCond);
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
objDT = vFuncParaRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncParaRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncParaRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncParaRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncParaRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncParaRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncParaRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFuncParaRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
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
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncParaRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFuncParaRelaEN._CurrTabName);
List<clsvFuncParaRelaEN> arrvFuncParaRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncParaRelaEN> arrvFuncParaRelaObjLst_Sel =
arrvFuncParaRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFuncParaRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncParaRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
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
public static List<clsvFuncParaRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncParaRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncParaRelaEN> GetSubObjLstCache(clsvFuncParaRelaEN objvFuncParaRelaCond)
{
List<clsvFuncParaRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncParaRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncParaRela._AttributeName)
{
if (objvFuncParaRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFuncParaRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncParaRelaCond[strFldName].ToString());
}
else
{
if (objvFuncParaRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncParaRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncParaRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncParaRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncParaRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncParaRelaCond[strFldName]));
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
public static List<clsvFuncParaRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
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
public static List<clsvFuncParaRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
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
List<clsvFuncParaRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncParaRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncParaRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncParaRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
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
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
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
public static List<clsvFuncParaRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncParaRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncParaRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
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
public static List<clsvFuncParaRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncParaRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncParaRelaEN> arrObjLst = new List<clsvFuncParaRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncParaRelaEN objvFuncParaRelaEN = new clsvFuncParaRelaEN();
try
{
objvFuncParaRelaEN.mId = Int32.Parse(objRow[convFuncParaRela.mId].ToString().Trim()); //mId
objvFuncParaRelaEN.FuncParaId4Code = objRow[convFuncParaRela.FuncParaId4Code].ToString().Trim(); //函数参数Id
objvFuncParaRelaEN.ParaName = objRow[convFuncParaRela.ParaName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaName].ToString().Trim(); //参数名
objvFuncParaRelaEN.ParaCnName = objRow[convFuncParaRela.ParaCnName] == DBNull.Value ? null : objRow[convFuncParaRela.ParaCnName].ToString().Trim(); //参数中文名
objvFuncParaRelaEN.DataTypeId = objRow[convFuncParaRela.DataTypeId] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeId].ToString().Trim(); //数据类型Id
objvFuncParaRelaEN.DataTypeName = objRow[convFuncParaRela.DataTypeName] == DBNull.Value ? null : objRow[convFuncParaRela.DataTypeName].ToString().Trim(); //数据类型名称
objvFuncParaRelaEN.DataCnName = objRow[convFuncParaRela.DataCnName] == DBNull.Value ? null : objRow[convFuncParaRela.DataCnName].ToString().Trim(); //数据类型中文名称
objvFuncParaRelaEN.CsType = objRow[convFuncParaRela.CsType] == DBNull.Value ? null : objRow[convFuncParaRela.CsType].ToString().Trim(); //CS类型
objvFuncParaRelaEN.JavaType = objRow[convFuncParaRela.JavaType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaType].ToString().Trim(); //JAVA类型
objvFuncParaRelaEN.JavaObjType = objRow[convFuncParaRela.JavaObjType] == DBNull.Value ? null : objRow[convFuncParaRela.JavaObjType].ToString().Trim(); //JAVA对象类型
objvFuncParaRelaEN.SwiftType = objRow[convFuncParaRela.SwiftType] == DBNull.Value ? null : objRow[convFuncParaRela.SwiftType].ToString().Trim(); //SwiftType
objvFuncParaRelaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsNeedQuote].ToString().Trim()); //是否需要引号
objvFuncParaRelaEN.OraDbType = objRow[convFuncParaRela.OraDbType] == DBNull.Value ? null : objRow[convFuncParaRela.OraDbType].ToString().Trim(); //Ora数据类型
objvFuncParaRelaEN.MySqlType = objRow[convFuncParaRela.MySqlType] == DBNull.Value ? null : objRow[convFuncParaRela.MySqlType].ToString().Trim(); //MySqlType
objvFuncParaRelaEN.ParameterType = objRow[convFuncParaRela.ParameterType] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterType].ToString().Trim(); //参数类型
objvFuncParaRelaEN.ParameterTypeFullName = objRow[convFuncParaRela.ParameterTypeFullName] == DBNull.Value ? null : objRow[convFuncParaRela.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvFuncParaRelaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsByRef].ToString().Trim()); //是否引用型参数
objvFuncParaRelaEN.PrjId = objRow[convFuncParaRela.PrjId] == DBNull.Value ? null : objRow[convFuncParaRela.PrjId].ToString().Trim(); //工程Id
objvFuncParaRelaEN.FuncId4Code = objRow[convFuncParaRela.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFuncParaRelaEN.FuncName4Code = objRow[convFuncParaRela.FuncName4Code].ToString().Trim(); //函数名4Code
objvFuncParaRelaEN.FunctionSignature = objRow[convFuncParaRela.FunctionSignature] == DBNull.Value ? null : objRow[convFuncParaRela.FunctionSignature].ToString().Trim(); //函数签名
objvFuncParaRelaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFuncParaRelaEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFuncParaRela.IsSysFunction].ToString().Trim()); //是否系统函数
objvFuncParaRelaEN.OrderNum = Int32.Parse(objRow[convFuncParaRela.OrderNum].ToString().Trim()); //序号
objvFuncParaRelaEN.UpdDate = objRow[convFuncParaRela.UpdDate] == DBNull.Value ? null : objRow[convFuncParaRela.UpdDate].ToString().Trim(); //修改日期
objvFuncParaRelaEN.UpdUser = objRow[convFuncParaRela.UpdUser] == DBNull.Value ? null : objRow[convFuncParaRela.UpdUser].ToString().Trim(); //修改者
objvFuncParaRelaEN.Memo = objRow[convFuncParaRela.Memo] == DBNull.Value ? null : objRow[convFuncParaRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncParaRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncParaRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncParaRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncParaRela(ref clsvFuncParaRelaEN objvFuncParaRelaEN)
{
bool bolResult = vFuncParaRelaDA.GetvFuncParaRela(ref objvFuncParaRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncParaRelaEN GetObjBymId(long lngmId)
{
clsvFuncParaRelaEN objvFuncParaRelaEN = vFuncParaRelaDA.GetObjBymId(lngmId);
return objvFuncParaRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncParaRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncParaRelaEN objvFuncParaRelaEN = vFuncParaRelaDA.GetFirstObj(strWhereCond);
 return objvFuncParaRelaEN;
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
public static clsvFuncParaRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncParaRelaEN objvFuncParaRelaEN = vFuncParaRelaDA.GetObjByDataRow(objRow);
 return objvFuncParaRelaEN;
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
public static clsvFuncParaRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncParaRelaEN objvFuncParaRelaEN = vFuncParaRelaDA.GetObjByDataRow(objRow);
 return objvFuncParaRelaEN;
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
 /// <param name = "lstvFuncParaRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncParaRelaEN GetObjBymIdFromList(long lngmId, List<clsvFuncParaRelaEN> lstvFuncParaRelaObjLst)
{
foreach (clsvFuncParaRelaEN objvFuncParaRelaEN in lstvFuncParaRelaObjLst)
{
if (objvFuncParaRelaEN.mId == lngmId)
{
return objvFuncParaRelaEN;
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
 lngmId = new clsvFuncParaRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFuncParaRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncParaRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFuncParaRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFuncParaRelaDA.IsExistTable();
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
 bolIsExist = vFuncParaRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncParaRelaENS">源对象</param>
 /// <param name = "objvFuncParaRelaENT">目标对象</param>
 public static void CopyTo(clsvFuncParaRelaEN objvFuncParaRelaENS, clsvFuncParaRelaEN objvFuncParaRelaENT)
{
try
{
objvFuncParaRelaENT.mId = objvFuncParaRelaENS.mId; //mId
objvFuncParaRelaENT.FuncParaId4Code = objvFuncParaRelaENS.FuncParaId4Code; //函数参数Id
objvFuncParaRelaENT.ParaName = objvFuncParaRelaENS.ParaName; //参数名
objvFuncParaRelaENT.ParaCnName = objvFuncParaRelaENS.ParaCnName; //参数中文名
objvFuncParaRelaENT.DataTypeId = objvFuncParaRelaENS.DataTypeId; //数据类型Id
objvFuncParaRelaENT.DataTypeName = objvFuncParaRelaENS.DataTypeName; //数据类型名称
objvFuncParaRelaENT.DataCnName = objvFuncParaRelaENS.DataCnName; //数据类型中文名称
objvFuncParaRelaENT.CsType = objvFuncParaRelaENS.CsType; //CS类型
objvFuncParaRelaENT.JavaType = objvFuncParaRelaENS.JavaType; //JAVA类型
objvFuncParaRelaENT.JavaObjType = objvFuncParaRelaENS.JavaObjType; //JAVA对象类型
objvFuncParaRelaENT.SwiftType = objvFuncParaRelaENS.SwiftType; //SwiftType
objvFuncParaRelaENT.IsNeedQuote = objvFuncParaRelaENS.IsNeedQuote; //是否需要引号
objvFuncParaRelaENT.OraDbType = objvFuncParaRelaENS.OraDbType; //Ora数据类型
objvFuncParaRelaENT.MySqlType = objvFuncParaRelaENS.MySqlType; //MySqlType
objvFuncParaRelaENT.ParameterType = objvFuncParaRelaENS.ParameterType; //参数类型
objvFuncParaRelaENT.ParameterTypeFullName = objvFuncParaRelaENS.ParameterTypeFullName; //参数类型全名
objvFuncParaRelaENT.IsByRef = objvFuncParaRelaENS.IsByRef; //是否引用型参数
objvFuncParaRelaENT.PrjId = objvFuncParaRelaENS.PrjId; //工程Id
objvFuncParaRelaENT.FuncId4Code = objvFuncParaRelaENS.FuncId4Code; //函数Id4Code
objvFuncParaRelaENT.FuncName4Code = objvFuncParaRelaENS.FuncName4Code; //函数名4Code
objvFuncParaRelaENT.FunctionSignature = objvFuncParaRelaENS.FunctionSignature; //函数签名
objvFuncParaRelaENT.IsAsyncFunc = objvFuncParaRelaENS.IsAsyncFunc; //是否异步函数
objvFuncParaRelaENT.IsSysFunction = objvFuncParaRelaENS.IsSysFunction; //是否系统函数
objvFuncParaRelaENT.OrderNum = objvFuncParaRelaENS.OrderNum; //序号
objvFuncParaRelaENT.UpdDate = objvFuncParaRelaENS.UpdDate; //修改日期
objvFuncParaRelaENT.UpdUser = objvFuncParaRelaENS.UpdUser; //修改者
objvFuncParaRelaENT.Memo = objvFuncParaRelaENS.Memo; //说明
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
 /// <param name = "objvFuncParaRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncParaRelaEN objvFuncParaRelaEN)
{
try
{
objvFuncParaRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncParaRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncParaRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.mId = objvFuncParaRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFuncParaRela.FuncParaId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.FuncParaId4Code = objvFuncParaRelaEN.FuncParaId4Code; //函数参数Id
}
if (arrFldSet.Contains(convFuncParaRela.ParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.ParaName = objvFuncParaRelaEN.ParaName == "[null]" ? null :  objvFuncParaRelaEN.ParaName; //参数名
}
if (arrFldSet.Contains(convFuncParaRela.ParaCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.ParaCnName = objvFuncParaRelaEN.ParaCnName == "[null]" ? null :  objvFuncParaRelaEN.ParaCnName; //参数中文名
}
if (arrFldSet.Contains(convFuncParaRela.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.DataTypeId = objvFuncParaRelaEN.DataTypeId == "[null]" ? null :  objvFuncParaRelaEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convFuncParaRela.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.DataTypeName = objvFuncParaRelaEN.DataTypeName == "[null]" ? null :  objvFuncParaRelaEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convFuncParaRela.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.DataCnName = objvFuncParaRelaEN.DataCnName == "[null]" ? null :  objvFuncParaRelaEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(convFuncParaRela.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.CsType = objvFuncParaRelaEN.CsType == "[null]" ? null :  objvFuncParaRelaEN.CsType; //CS类型
}
if (arrFldSet.Contains(convFuncParaRela.JavaType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.JavaType = objvFuncParaRelaEN.JavaType == "[null]" ? null :  objvFuncParaRelaEN.JavaType; //JAVA类型
}
if (arrFldSet.Contains(convFuncParaRela.JavaObjType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.JavaObjType = objvFuncParaRelaEN.JavaObjType == "[null]" ? null :  objvFuncParaRelaEN.JavaObjType; //JAVA对象类型
}
if (arrFldSet.Contains(convFuncParaRela.SwiftType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.SwiftType = objvFuncParaRelaEN.SwiftType == "[null]" ? null :  objvFuncParaRelaEN.SwiftType; //SwiftType
}
if (arrFldSet.Contains(convFuncParaRela.IsNeedQuote, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.IsNeedQuote = objvFuncParaRelaEN.IsNeedQuote; //是否需要引号
}
if (arrFldSet.Contains(convFuncParaRela.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.OraDbType = objvFuncParaRelaEN.OraDbType == "[null]" ? null :  objvFuncParaRelaEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convFuncParaRela.MySqlType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.MySqlType = objvFuncParaRelaEN.MySqlType == "[null]" ? null :  objvFuncParaRelaEN.MySqlType; //MySqlType
}
if (arrFldSet.Contains(convFuncParaRela.ParameterType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.ParameterType = objvFuncParaRelaEN.ParameterType == "[null]" ? null :  objvFuncParaRelaEN.ParameterType; //参数类型
}
if (arrFldSet.Contains(convFuncParaRela.ParameterTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.ParameterTypeFullName = objvFuncParaRelaEN.ParameterTypeFullName == "[null]" ? null :  objvFuncParaRelaEN.ParameterTypeFullName; //参数类型全名
}
if (arrFldSet.Contains(convFuncParaRela.IsByRef, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.IsByRef = objvFuncParaRelaEN.IsByRef; //是否引用型参数
}
if (arrFldSet.Contains(convFuncParaRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.PrjId = objvFuncParaRelaEN.PrjId == "[null]" ? null :  objvFuncParaRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFuncParaRela.FuncId4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.FuncId4Code = objvFuncParaRelaEN.FuncId4Code; //函数Id4Code
}
if (arrFldSet.Contains(convFuncParaRela.FuncName4Code, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.FuncName4Code = objvFuncParaRelaEN.FuncName4Code; //函数名4Code
}
if (arrFldSet.Contains(convFuncParaRela.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.FunctionSignature = objvFuncParaRelaEN.FunctionSignature == "[null]" ? null :  objvFuncParaRelaEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(convFuncParaRela.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.IsAsyncFunc = objvFuncParaRelaEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(convFuncParaRela.IsSysFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.IsSysFunction = objvFuncParaRelaEN.IsSysFunction; //是否系统函数
}
if (arrFldSet.Contains(convFuncParaRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.OrderNum = objvFuncParaRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFuncParaRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.UpdDate = objvFuncParaRelaEN.UpdDate == "[null]" ? null :  objvFuncParaRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFuncParaRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.UpdUser = objvFuncParaRelaEN.UpdUser == "[null]" ? null :  objvFuncParaRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFuncParaRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncParaRelaEN.Memo = objvFuncParaRelaEN.Memo == "[null]" ? null :  objvFuncParaRelaEN.Memo; //说明
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
 /// <param name = "objvFuncParaRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncParaRelaEN objvFuncParaRelaEN)
{
try
{
if (objvFuncParaRelaEN.ParaName == "[null]") objvFuncParaRelaEN.ParaName = null; //参数名
if (objvFuncParaRelaEN.ParaCnName == "[null]") objvFuncParaRelaEN.ParaCnName = null; //参数中文名
if (objvFuncParaRelaEN.DataTypeId == "[null]") objvFuncParaRelaEN.DataTypeId = null; //数据类型Id
if (objvFuncParaRelaEN.DataTypeName == "[null]") objvFuncParaRelaEN.DataTypeName = null; //数据类型名称
if (objvFuncParaRelaEN.DataCnName == "[null]") objvFuncParaRelaEN.DataCnName = null; //数据类型中文名称
if (objvFuncParaRelaEN.CsType == "[null]") objvFuncParaRelaEN.CsType = null; //CS类型
if (objvFuncParaRelaEN.JavaType == "[null]") objvFuncParaRelaEN.JavaType = null; //JAVA类型
if (objvFuncParaRelaEN.JavaObjType == "[null]") objvFuncParaRelaEN.JavaObjType = null; //JAVA对象类型
if (objvFuncParaRelaEN.SwiftType == "[null]") objvFuncParaRelaEN.SwiftType = null; //SwiftType
if (objvFuncParaRelaEN.OraDbType == "[null]") objvFuncParaRelaEN.OraDbType = null; //Ora数据类型
if (objvFuncParaRelaEN.MySqlType == "[null]") objvFuncParaRelaEN.MySqlType = null; //MySqlType
if (objvFuncParaRelaEN.ParameterType == "[null]") objvFuncParaRelaEN.ParameterType = null; //参数类型
if (objvFuncParaRelaEN.ParameterTypeFullName == "[null]") objvFuncParaRelaEN.ParameterTypeFullName = null; //参数类型全名
if (objvFuncParaRelaEN.PrjId == "[null]") objvFuncParaRelaEN.PrjId = null; //工程Id
if (objvFuncParaRelaEN.FunctionSignature == "[null]") objvFuncParaRelaEN.FunctionSignature = null; //函数签名
if (objvFuncParaRelaEN.UpdDate == "[null]") objvFuncParaRelaEN.UpdDate = null; //修改日期
if (objvFuncParaRelaEN.UpdUser == "[null]") objvFuncParaRelaEN.UpdUser = null; //修改者
if (objvFuncParaRelaEN.Memo == "[null]") objvFuncParaRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFuncParaRelaEN objvFuncParaRelaEN)
{
 vFuncParaRelaDA.CheckProperty4Condition(objvFuncParaRelaEN);
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
if (clsFuncParaRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncParaRelaBL没有刷新缓存机制(clsFuncParaRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFuncParaRelaObjLstCache == null)
//{
//arrvFuncParaRelaObjLstCache = vFuncParaRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncParaRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFuncParaRelaEN._CurrTabName);
List<clsvFuncParaRelaEN> arrvFuncParaRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncParaRelaEN> arrvFuncParaRelaObjLst_Sel =
arrvFuncParaRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFuncParaRelaObjLst_Sel.Count() == 0)
{
   clsvFuncParaRelaEN obj = clsvFuncParaRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFuncParaRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncParaRelaEN> GetAllvFuncParaRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFuncParaRelaEN> arrvFuncParaRelaObjLstCache = GetObjLstCache(); 
return arrvFuncParaRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncParaRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFuncParaRelaEN._CurrTabName);
List<clsvFuncParaRelaEN> arrvFuncParaRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFuncParaRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFuncParaRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFuncParaRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFuncParaRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFuncParaRelaEN._RefreshTimeLst[clsvFuncParaRelaEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFuncParaRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncParaRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncParaRela._AttributeName));
throw new Exception(strMsg);
}
var objvFuncParaRela = clsvFuncParaRelaBL.GetObjBymIdCache(lngmId);
if (objvFuncParaRela == null) return "";
return objvFuncParaRela[strOutFldName].ToString();
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
int intRecCount = clsvFuncParaRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncParaRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncParaRelaDA.GetRecCount();
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
int intRecCount = clsvFuncParaRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncParaRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncParaRelaEN objvFuncParaRelaCond)
{
List<clsvFuncParaRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncParaRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncParaRela._AttributeName)
{
if (objvFuncParaRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFuncParaRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncParaRelaCond[strFldName].ToString());
}
else
{
if (objvFuncParaRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncParaRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncParaRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncParaRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncParaRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncParaRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncParaRelaCond[strFldName]));
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
 List<string> arrList = clsvFuncParaRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncParaRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncParaRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}