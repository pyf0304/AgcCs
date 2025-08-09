
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSelfDefDataTypeWApi
 表名:SelfDefDataType(00050350)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:53
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
public static class  clsSelfDefDataTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSdDataTypeId">自定义数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSdDataTypeId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSdDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
clsCheckSql.CheckFieldForeignKey(strSdDataTypeId, 4, conSelfDefDataType.SdDataTypeId);
objSelfDefDataTypeEN.SdDataTypeId = strSdDataTypeId; //自定义数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SdDataTypeId) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SdDataTypeId, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SdDataTypeId] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataTypeName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, conSelfDefDataType.DataTypeName);
clsCheckSql.CheckFieldLen(strDataTypeName, 100, conSelfDefDataType.DataTypeName);
objSelfDefDataTypeEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataTypeName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataTypeName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataTypeName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsObject">是否对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsObject(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsObject, string strComparisonOp="")
	{
objSelfDefDataTypeEN.IsObject = bolIsObject; //是否对象
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsObject) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsObject, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsObject] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaVarName">默认变量名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaVarName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDefaVarName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaVarName, 50, conSelfDefDataType.DefaVarName);
objSelfDefDataTypeEN.DefaVarName = strDefaVarName; //默认变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaVarName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaVarName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaVarName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataCnName">数据类型中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataCnName(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataCnName, 100, conSelfDefDataType.DataCnName);
objSelfDefDataTypeEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataCnName) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataCnName, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataCnName] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeAbbr">数据类型缩写</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDataTypeAbbr(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strDataTypeAbbr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeAbbr, 5, conSelfDefDataType.DataTypeAbbr);
objSelfDefDataTypeEN.DataTypeAbbr = strDataTypeAbbr; //数据类型缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DataTypeAbbr) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DataTypeAbbr, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DataTypeAbbr] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strVbNetType">VBNET类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetVbNetType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strVbNetType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVbNetType, 100, conSelfDefDataType.VbNetType);
objSelfDefDataTypeEN.VbNetType = strVbNetType; //VBNET类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.VbNetType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.VbNetType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.VbNetType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCsType">CS类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetCsType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strCsType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCsType, conSelfDefDataType.CsType);
clsCheckSql.CheckFieldLen(strCsType, 100, conSelfDefDataType.CsType);
objSelfDefDataTypeEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.CsType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.CsType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.CsType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaType">JAVA类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetJavaType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strJavaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaType, 100, conSelfDefDataType.JavaType);
objSelfDefDataTypeEN.JavaType = strJavaType; //JAVA类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.JavaType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.JavaType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.JavaType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strJavaObjType">JAVA对象类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetJavaObjType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strJavaObjType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJavaObjType, 100, conSelfDefDataType.JavaObjType);
objSelfDefDataTypeEN.JavaObjType = strJavaObjType; //JAVA对象类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.JavaObjType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.JavaObjType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.JavaObjType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSwiftType">SwiftType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSwiftType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSwiftType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSwiftType, 100, conSelfDefDataType.SwiftType);
objSelfDefDataTypeEN.SwiftType = strSwiftType; //SwiftType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SwiftType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SwiftType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SwiftType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedQuote">是否需要引号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsNeedQuote(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsNeedQuote, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedQuote, conSelfDefDataType.IsNeedQuote);
objSelfDefDataTypeEN.IsNeedQuote = bolIsNeedQuote; //是否需要引号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsNeedQuote) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsNeedQuote, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsNeedQuote] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetOraDbType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOraDbType, 100, conSelfDefDataType.OraDbType);
objSelfDefDataTypeEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.OraDbType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.OraDbType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.OraDbType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsReturnType">是否可作返回类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetIsReturnType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, bool bolIsReturnType, string strComparisonOp="")
	{
objSelfDefDataTypeEN.IsReturnType = bolIsReturnType; //是否可作返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.IsReturnType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.IsReturnType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.IsReturnType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlParaType">SQL参数类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetSqlParaType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strSqlParaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlParaType, 100, conSelfDefDataType.SqlParaType);
objSelfDefDataTypeEN.SqlParaType = strSqlParaType; //SQL参数类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.SqlParaType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.SqlParaType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.SqlParaType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMySqlType">MySqlType</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetMySqlType(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strMySqlType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMySqlType, 100, conSelfDefDataType.MySqlType);
objSelfDefDataTypeEN.MySqlType = strMySqlType; //MySqlType
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.MySqlType) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.MySqlType, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.MySqlType] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intDefaFldLength">默认长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaFldLength(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, int intDefaFldLength, string strComparisonOp="")
	{
objSelfDefDataTypeEN.DefaFldLength = intDefaFldLength; //默认长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaFldLength) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaFldLength, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaFldLength] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intDefaFldPrecision">默认小数位数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetDefaFldPrecision(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, int intDefaFldPrecision, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intDefaFldPrecision, conSelfDefDataType.DefaFldPrecision);
objSelfDefDataTypeEN.DefaFldPrecision = intDefaFldPrecision; //默认小数位数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.DefaFldPrecision) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.DefaFldPrecision, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.DefaFldPrecision] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetPrjId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSelfDefDataType.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSelfDefDataType.PrjId);
objSelfDefDataTypeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.PrjId) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.PrjId, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.PrjId] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetUpdDate(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSelfDefDataType.UpdDate);
objSelfDefDataTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.UpdDate) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.UpdDate, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.UpdDate] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetUpdUser(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSelfDefDataType.UpdUser);
objSelfDefDataTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.UpdUser) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.UpdUser, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.UpdUser] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSelfDefDataTypeEN SetMemo(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSelfDefDataType.Memo);
objSelfDefDataTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSelfDefDataTypeEN.dicFldComparisonOp.ContainsKey(conSelfDefDataType.Memo) == false)
{
objSelfDefDataTypeEN.dicFldComparisonOp.Add(conSelfDefDataType.Memo, strComparisonOp);
}
else
{
objSelfDefDataTypeEN.dicFldComparisonOp[conSelfDefDataType.Memo] = strComparisonOp;
}
}
return objSelfDefDataTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSelfDefDataTypeEN objSelfDefDataTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SdDataTypeId) == true)
{
string strComparisonOpSdDataTypeId = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SdDataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SdDataTypeId, objSelfDefDataTypeCond.SdDataTypeId, strComparisonOpSdDataTypeId);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataTypeName, objSelfDefDataTypeCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsObject) == true)
{
if (objSelfDefDataTypeCond.IsObject == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsObject);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsObject);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaVarName) == true)
{
string strComparisonOpDefaVarName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaVarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DefaVarName, objSelfDefDataTypeCond.DefaVarName, strComparisonOpDefaVarName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataCnName) == true)
{
string strComparisonOpDataCnName = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataCnName, objSelfDefDataTypeCond.DataCnName, strComparisonOpDataCnName);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DataTypeAbbr) == true)
{
string strComparisonOpDataTypeAbbr = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DataTypeAbbr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.DataTypeAbbr, objSelfDefDataTypeCond.DataTypeAbbr, strComparisonOpDataTypeAbbr);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.VbNetType) == true)
{
string strComparisonOpVbNetType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.VbNetType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.VbNetType, objSelfDefDataTypeCond.VbNetType, strComparisonOpVbNetType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.CsType) == true)
{
string strComparisonOpCsType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.CsType, objSelfDefDataTypeCond.CsType, strComparisonOpCsType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.JavaType) == true)
{
string strComparisonOpJavaType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.JavaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.JavaType, objSelfDefDataTypeCond.JavaType, strComparisonOpJavaType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.JavaObjType) == true)
{
string strComparisonOpJavaObjType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.JavaObjType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.JavaObjType, objSelfDefDataTypeCond.JavaObjType, strComparisonOpJavaObjType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SwiftType) == true)
{
string strComparisonOpSwiftType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SwiftType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SwiftType, objSelfDefDataTypeCond.SwiftType, strComparisonOpSwiftType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsNeedQuote) == true)
{
if (objSelfDefDataTypeCond.IsNeedQuote == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsNeedQuote);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsNeedQuote);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.OraDbType) == true)
{
string strComparisonOpOraDbType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.OraDbType, objSelfDefDataTypeCond.OraDbType, strComparisonOpOraDbType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.IsReturnType) == true)
{
if (objSelfDefDataTypeCond.IsReturnType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSelfDefDataType.IsReturnType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSelfDefDataType.IsReturnType);
}
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.SqlParaType) == true)
{
string strComparisonOpSqlParaType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.SqlParaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.SqlParaType, objSelfDefDataTypeCond.SqlParaType, strComparisonOpSqlParaType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.MySqlType) == true)
{
string strComparisonOpMySqlType = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.MySqlType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.MySqlType, objSelfDefDataTypeCond.MySqlType, strComparisonOpMySqlType);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaFldLength) == true)
{
string strComparisonOpDefaFldLength = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaFldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conSelfDefDataType.DefaFldLength, objSelfDefDataTypeCond.DefaFldLength, strComparisonOpDefaFldLength);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.DefaFldPrecision) == true)
{
string strComparisonOpDefaFldPrecision = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.DefaFldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conSelfDefDataType.DefaFldPrecision, objSelfDefDataTypeCond.DefaFldPrecision, strComparisonOpDefaFldPrecision);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.PrjId) == true)
{
string strComparisonOpPrjId = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.PrjId, objSelfDefDataTypeCond.PrjId, strComparisonOpPrjId);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.UpdDate) == true)
{
string strComparisonOpUpdDate = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.UpdDate, objSelfDefDataTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.UpdUser) == true)
{
string strComparisonOpUpdUser = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.UpdUser, objSelfDefDataTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objSelfDefDataTypeCond.IsUpdated(conSelfDefDataType.Memo) == true)
{
string strComparisonOpMemo = objSelfDefDataTypeCond.dicFldComparisonOp[conSelfDefDataType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSelfDefDataType.Memo, objSelfDefDataTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSelfDefDataTypeEN.sfUpdFldSetStr = objSelfDefDataTypeEN.getsfUpdFldSetStr();
clsSelfDefDataTypeWApi.CheckPropertyNew(objSelfDefDataTypeEN); 
bool bolResult = clsSelfDefDataTypeWApi.UpdateRecord(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--SelfDefDataType(自定义数据类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DataTypeName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSelfDefDataTypeEN == null) return "";
if (objSelfDefDataTypeEN.SdDataTypeId == null || objSelfDefDataTypeEN.SdDataTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SdDataTypeId !=  '{0}'", objSelfDefDataTypeEN.SdDataTypeId);
 sbCondition.AppendFormat(" and DataTypeName = '{0}'", objSelfDefDataTypeEN.DataTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSelfDefDataTypeEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objSelfDefDataTypeEN.SdDataTypeId) == true || clsSelfDefDataTypeWApi.IsExist(objSelfDefDataTypeEN.SdDataTypeId) == true)
 {
     objSelfDefDataTypeEN.SdDataTypeId = clsSelfDefDataTypeWApi.GetMaxStrId();
 }
clsSelfDefDataTypeWApi.CheckPropertyNew(objSelfDefDataTypeEN); 
bool bolResult = clsSelfDefDataTypeWApi.AddNewRecord(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
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
 /// <param name = "objSelfDefDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
try
{
clsSelfDefDataTypeWApi.CheckPropertyNew(objSelfDefDataTypeEN); 
string strSdDataTypeId = clsSelfDefDataTypeWApi.AddNewRecordWithMaxId(objSelfDefDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
return strSdDataTypeId;
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strWhereCond)
{
try
{
clsSelfDefDataTypeWApi.CheckPropertyNew(objSelfDefDataTypeEN); 
bool bolResult = clsSelfDefDataTypeWApi.UpdateWithCondition(objSelfDefDataTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
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
 /// 自定义数据类型(SelfDefDataType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSelfDefDataTypeWApi
{
private static readonly string mstrApiControllerName = "SelfDefDataTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsSelfDefDataTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SdDataTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[自定义数据类型]...","0");
List<clsSelfDefDataTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="SdDataTypeId";
objDDL.DataTextField="DataTypeName";
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

public static void BindCbo_SdDataTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSelfDefDataType.SdDataTypeId); 
List<clsSelfDefDataTypeEN> arrObjLst = clsSelfDefDataTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN()
{
SdDataTypeId = "0",
DataTypeName = "选[自定义数据类型]..."
};
arrObjLst.Insert(0, objSelfDefDataTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSelfDefDataType.SdDataTypeId;
objComboBox.DisplayMember = conSelfDefDataType.DataTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
if (!Object.Equals(null, objSelfDefDataTypeEN.SdDataTypeId) && GetStrLen(objSelfDefDataTypeEN.SdDataTypeId) > 4)
{
 throw new Exception("字段[自定义数据类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.DataTypeName) && GetStrLen(objSelfDefDataTypeEN.DataTypeName) > 100)
{
 throw new Exception("字段[数据类型名称]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.DefaVarName) && GetStrLen(objSelfDefDataTypeEN.DefaVarName) > 50)
{
 throw new Exception("字段[默认变量名]的长度不能超过50!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.DataCnName) && GetStrLen(objSelfDefDataTypeEN.DataCnName) > 100)
{
 throw new Exception("字段[数据类型中文名称]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.DataTypeAbbr) && GetStrLen(objSelfDefDataTypeEN.DataTypeAbbr) > 5)
{
 throw new Exception("字段[数据类型缩写]的长度不能超过5!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.VbNetType) && GetStrLen(objSelfDefDataTypeEN.VbNetType) > 100)
{
 throw new Exception("字段[VBNET类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.CsType) && GetStrLen(objSelfDefDataTypeEN.CsType) > 100)
{
 throw new Exception("字段[CS类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.JavaType) && GetStrLen(objSelfDefDataTypeEN.JavaType) > 100)
{
 throw new Exception("字段[JAVA类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.JavaObjType) && GetStrLen(objSelfDefDataTypeEN.JavaObjType) > 100)
{
 throw new Exception("字段[JAVA对象类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.SwiftType) && GetStrLen(objSelfDefDataTypeEN.SwiftType) > 100)
{
 throw new Exception("字段[SwiftType]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.OraDbType) && GetStrLen(objSelfDefDataTypeEN.OraDbType) > 100)
{
 throw new Exception("字段[Ora数据类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.SqlParaType) && GetStrLen(objSelfDefDataTypeEN.SqlParaType) > 100)
{
 throw new Exception("字段[SQL参数类型]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.MySqlType) && GetStrLen(objSelfDefDataTypeEN.MySqlType) > 100)
{
 throw new Exception("字段[MySqlType]的长度不能超过100!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.PrjId) && GetStrLen(objSelfDefDataTypeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.UpdDate) && GetStrLen(objSelfDefDataTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.UpdUser) && GetStrLen(objSelfDefDataTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objSelfDefDataTypeEN.Memo) && GetStrLen(objSelfDefDataTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSelfDefDataTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSdDataTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSelfDefDataTypeEN GetObjBySdDataTypeId(string strSdDataTypeId)
{
if (strSdDataTypeId == "") return null;
string strAction = "GetObjBySdDataTypeId";
clsSelfDefDataTypeEN objSelfDefDataTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strSdDataTypeId"] = strSdDataTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objSelfDefDataTypeEN = JsonConvert.DeserializeObject<clsSelfDefDataTypeEN>(strJson);
return objSelfDefDataTypeEN;
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
public static clsSelfDefDataTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSelfDefDataTypeEN objSelfDefDataTypeEN;
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
objSelfDefDataTypeEN = JsonConvert.DeserializeObject<clsSelfDefDataTypeEN>(strJson);
return objSelfDefDataTypeEN;
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
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSelfDefDataTypeEN GetObjBySdDataTypeIdCache(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel =
from objSelfDefDataTypeEN in arrSelfDefDataTypeObjLstCache
where objSelfDefDataTypeEN.SdDataTypeId == strSdDataTypeId 
select objSelfDefDataTypeEN;
if (arrSelfDefDataTypeObjLst_Sel.Count() == 0)
{
   clsSelfDefDataTypeEN obj = clsSelfDefDataTypeWApi.GetObjBySdDataTypeId(strSdDataTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSelfDefDataTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataTypeNameBySdDataTypeIdCache(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return "";
//初始化列表缓存
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel1 =
from objSelfDefDataTypeEN in arrSelfDefDataTypeObjLstCache
where objSelfDefDataTypeEN.SdDataTypeId == strSdDataTypeId 
select objSelfDefDataTypeEN;
List <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel = new List<clsSelfDefDataTypeEN>();
foreach (clsSelfDefDataTypeEN obj in arrSelfDefDataTypeObjLst_Sel1)
{
arrSelfDefDataTypeObjLst_Sel.Add(obj);
}
if (arrSelfDefDataTypeObjLst_Sel.Count > 0)
{
return arrSelfDefDataTypeObjLst_Sel[0].DataTypeName;
}
string strErrMsgForGetObjById = string.Format("在SelfDefDataType对象缓存列表中,找不到记录[SdDataTypeId = {0}](函数:{1})", strSdDataTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSelfDefDataTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSdDataTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySdDataTypeIdCache(string strSdDataTypeId)
{
if (string.IsNullOrEmpty(strSdDataTypeId) == true) return "";
//初始化列表缓存
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel1 =
from objSelfDefDataTypeEN in arrSelfDefDataTypeObjLstCache
where objSelfDefDataTypeEN.SdDataTypeId == strSdDataTypeId 
select objSelfDefDataTypeEN;
List <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel = new List<clsSelfDefDataTypeEN>();
foreach (clsSelfDefDataTypeEN obj in arrSelfDefDataTypeObjLst_Sel1)
{
arrSelfDefDataTypeObjLst_Sel.Add(obj);
}
if (arrSelfDefDataTypeObjLst_Sel.Count > 0)
{
return arrSelfDefDataTypeObjLst_Sel[0].DataTypeName;
}
string strErrMsgForGetObjById = string.Format("在SelfDefDataType对象缓存列表中,找不到记录的相关名称[SdDataTypeId = {0}](函数:{1})", strSdDataTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSelfDefDataTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLst(string strWhereCond)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
 /// <param name = "arrSdDataTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstBySdDataTypeIdLst(List<string> arrSdDataTypeId)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
string strAction = "GetObjLstBySdDataTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSdDataTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
 /// <param name = "arrSdDataTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsSelfDefDataTypeEN> GetObjLstBySdDataTypeIdLstCache(List<string> arrSdDataTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLst_Sel =
from objSelfDefDataTypeEN in arrSelfDefDataTypeObjLstCache
where arrSdDataTypeId.Contains(objSelfDefDataTypeEN.SdDataTypeId)
select objSelfDefDataTypeEN;
return arrSelfDefDataTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
public static List<clsSelfDefDataTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
public static List<clsSelfDefDataTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
public static List<clsSelfDefDataTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSelfDefDataTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSelfDefDataTypeEN>>(strJson);
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
public static int DelRecord(string strSdDataTypeId)
{
string strAction = "DelRecord";
try
{
 clsSelfDefDataTypeEN objSelfDefDataTypeEN = clsSelfDefDataTypeWApi.GetObjBySdDataTypeId(strSdDataTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strSdDataTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsSelfDefDataTypeWApi.ReFreshCache();
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
public static int DelSelfDefDataTypes(List<string> arrSdDataTypeId)
{
string strAction = "DelSelfDefDataTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSdDataTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsSelfDefDataTypeWApi.ReFreshCache();
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
public static int DelSelfDefDataTypesByCond(string strWhereCond)
{
string strAction = "DelSelfDefDataTypesByCond";
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
public static bool AddNewRecord(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSelfDefDataTypeEN>(objSelfDefDataTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSelfDefDataTypeEN>(objSelfDefDataTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSelfDefDataTypeWApi.ReFreshCache();
var strSdDataTypeId = (string)jobjReturn0["returnStr"];
return strSdDataTypeId;
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
public static bool UpdateRecord(clsSelfDefDataTypeEN objSelfDefDataTypeEN)
{
if (string.IsNullOrEmpty(objSelfDefDataTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSelfDefDataTypeEN.SdDataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSelfDefDataTypeEN>(objSelfDefDataTypeEN);
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
 /// <param name = "objSelfDefDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSelfDefDataTypeEN objSelfDefDataTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSelfDefDataTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSelfDefDataTypeEN.SdDataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSelfDefDataTypeEN.SdDataTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSelfDefDataTypeEN>(objSelfDefDataTypeEN);
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
public static bool IsExist(string strSdDataTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strSdDataTypeId"] = strSdDataTypeId
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
 /// <param name = "objSelfDefDataTypeENS">源对象</param>
 /// <param name = "objSelfDefDataTypeENT">目标对象</param>
 public static void CopyTo(clsSelfDefDataTypeEN objSelfDefDataTypeENS, clsSelfDefDataTypeEN objSelfDefDataTypeENT)
{
try
{
objSelfDefDataTypeENT.SdDataTypeId = objSelfDefDataTypeENS.SdDataTypeId; //自定义数据类型Id
objSelfDefDataTypeENT.DataTypeName = objSelfDefDataTypeENS.DataTypeName; //数据类型名称
objSelfDefDataTypeENT.IsObject = objSelfDefDataTypeENS.IsObject; //是否对象
objSelfDefDataTypeENT.DefaVarName = objSelfDefDataTypeENS.DefaVarName; //默认变量名
objSelfDefDataTypeENT.DataCnName = objSelfDefDataTypeENS.DataCnName; //数据类型中文名称
objSelfDefDataTypeENT.DataTypeAbbr = objSelfDefDataTypeENS.DataTypeAbbr; //数据类型缩写
objSelfDefDataTypeENT.VbNetType = objSelfDefDataTypeENS.VbNetType; //VBNET类型
objSelfDefDataTypeENT.CsType = objSelfDefDataTypeENS.CsType; //CS类型
objSelfDefDataTypeENT.JavaType = objSelfDefDataTypeENS.JavaType; //JAVA类型
objSelfDefDataTypeENT.JavaObjType = objSelfDefDataTypeENS.JavaObjType; //JAVA对象类型
objSelfDefDataTypeENT.SwiftType = objSelfDefDataTypeENS.SwiftType; //SwiftType
objSelfDefDataTypeENT.IsNeedQuote = objSelfDefDataTypeENS.IsNeedQuote; //是否需要引号
objSelfDefDataTypeENT.OraDbType = objSelfDefDataTypeENS.OraDbType; //Ora数据类型
objSelfDefDataTypeENT.IsReturnType = objSelfDefDataTypeENS.IsReturnType; //是否可作返回类型
objSelfDefDataTypeENT.SqlParaType = objSelfDefDataTypeENS.SqlParaType; //SQL参数类型
objSelfDefDataTypeENT.MySqlType = objSelfDefDataTypeENS.MySqlType; //MySqlType
objSelfDefDataTypeENT.DefaFldLength = objSelfDefDataTypeENS.DefaFldLength; //默认长度
objSelfDefDataTypeENT.DefaFldPrecision = objSelfDefDataTypeENS.DefaFldPrecision; //默认小数位数
objSelfDefDataTypeENT.PrjId = objSelfDefDataTypeENS.PrjId; //工程Id
objSelfDefDataTypeENT.UpdDate = objSelfDefDataTypeENS.UpdDate; //修改日期
objSelfDefDataTypeENT.UpdUser = objSelfDefDataTypeENS.UpdUser; //修改者
objSelfDefDataTypeENT.Memo = objSelfDefDataTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSelfDefDataTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSelfDefDataTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSelfDefDataTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSelfDefDataTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSelfDefDataTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSelfDefDataTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
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
if (clsSelfDefDataTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSelfDefDataTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSelfDefDataTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSelfDefDataTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsSelfDefDataTypeEN._CurrTabName;
List<clsSelfDefDataTypeEN> arrSelfDefDataTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrSelfDefDataTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSelfDefDataTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSelfDefDataType.SdDataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.IsObject, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSelfDefDataType.DefaVarName, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.DataCnName, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.DataTypeAbbr, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.VbNetType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.CsType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.JavaType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.JavaObjType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.SwiftType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.IsNeedQuote, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSelfDefDataType.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.IsReturnType, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSelfDefDataType.SqlParaType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.MySqlType, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.DefaFldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(conSelfDefDataType.DefaFldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(conSelfDefDataType.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conSelfDefDataType.Memo, Type.GetType("System.String"));
foreach (clsSelfDefDataTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSelfDefDataType.SdDataTypeId] = objInFor[conSelfDefDataType.SdDataTypeId];
objDR[conSelfDefDataType.DataTypeName] = objInFor[conSelfDefDataType.DataTypeName];
objDR[conSelfDefDataType.IsObject] = objInFor[conSelfDefDataType.IsObject];
objDR[conSelfDefDataType.DefaVarName] = objInFor[conSelfDefDataType.DefaVarName];
objDR[conSelfDefDataType.DataCnName] = objInFor[conSelfDefDataType.DataCnName];
objDR[conSelfDefDataType.DataTypeAbbr] = objInFor[conSelfDefDataType.DataTypeAbbr];
objDR[conSelfDefDataType.VbNetType] = objInFor[conSelfDefDataType.VbNetType];
objDR[conSelfDefDataType.CsType] = objInFor[conSelfDefDataType.CsType];
objDR[conSelfDefDataType.JavaType] = objInFor[conSelfDefDataType.JavaType];
objDR[conSelfDefDataType.JavaObjType] = objInFor[conSelfDefDataType.JavaObjType];
objDR[conSelfDefDataType.SwiftType] = objInFor[conSelfDefDataType.SwiftType];
objDR[conSelfDefDataType.IsNeedQuote] = objInFor[conSelfDefDataType.IsNeedQuote];
objDR[conSelfDefDataType.OraDbType] = objInFor[conSelfDefDataType.OraDbType];
objDR[conSelfDefDataType.IsReturnType] = objInFor[conSelfDefDataType.IsReturnType];
objDR[conSelfDefDataType.SqlParaType] = objInFor[conSelfDefDataType.SqlParaType];
objDR[conSelfDefDataType.MySqlType] = objInFor[conSelfDefDataType.MySqlType];
objDR[conSelfDefDataType.DefaFldLength] = objInFor[conSelfDefDataType.DefaFldLength];
objDR[conSelfDefDataType.DefaFldPrecision] = objInFor[conSelfDefDataType.DefaFldPrecision];
objDR[conSelfDefDataType.PrjId] = objInFor[conSelfDefDataType.PrjId];
objDR[conSelfDefDataType.UpdDate] = objInFor[conSelfDefDataType.UpdDate];
objDR[conSelfDefDataType.UpdUser] = objInFor[conSelfDefDataType.UpdUser];
objDR[conSelfDefDataType.Memo] = objInFor[conSelfDefDataType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 自定义数据类型(SelfDefDataType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SelfDefDataType : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsSelfDefDataTypeWApi.ReFreshThisCache();
}
}

}