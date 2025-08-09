
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabWApi
 表名:vFieldTab(00050119)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvFieldTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabNum">表数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetTabNum(this clsvFieldTabEN objvFieldTabEN, int intTabNum, string strComparisonOp="")
	{
objvFieldTabEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.TabNum) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.TabNum, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.TabNum] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeName">字段类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeName(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFieldTab.FieldTypeName);
objvFieldTabEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FieldTypeName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FieldTypeName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FieldTypeName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeENName">字段类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeENName(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeENName, 30, convFieldTab.FieldTypeENName);
objvFieldTabEN.FieldTypeENName = strFieldTypeENName; //字段类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FieldTypeENName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FieldTypeENName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FieldTypeENName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strOraDbType">Ora数据类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetOraDbType(this clsvFieldTabEN objvFieldTabEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convFieldTab.OraDbType);
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFieldTab.OraDbType);
objvFieldTabEN.OraDbType = strOraDbType; //Ora数据类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.OraDbType) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.OraDbType, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.OraDbType] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsNeedTransCode(this clsvFieldTabEN objvFieldTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convFieldTab.IsNeedTransCode);
objvFieldTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsNeedTransCode) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsNeedTransCode, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsNeedTransCode] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldId(this clsvFieldTabEN objvFieldTabEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab.FldId);
objvFieldTabEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldName(this clsvFieldTabEN objvFieldTabEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab.FldName);
objvFieldTabEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldCnName(this clsvFieldTabEN objvFieldTabEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convFieldTab.FldCnName);
objvFieldTabEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldCnName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldCnName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldCnName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetCaption(this clsvFieldTabEN objvFieldTabEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab.Caption);
objvFieldTabEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.Caption) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.Caption, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.Caption] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeId(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFieldTab.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFieldTab.FieldTypeId);
objvFieldTabEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FieldTypeId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FieldTypeId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FieldTypeId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDataTypeId(this clsvFieldTabEN objvFieldTabEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab.DataTypeId);
objvFieldTabEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.DataTypeId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.DataTypeId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.DataTypeId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDataTypeName(this clsvFieldTabEN objvFieldTabEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convFieldTab.DataTypeName);
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab.DataTypeName);
objvFieldTabEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.DataTypeName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.DataTypeName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.DataTypeName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldLength(this clsvFieldTabEN objvFieldTabEN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convFieldTab.FldLength);
objvFieldTabEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldLength) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldLength, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldLength] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldPrecision">精确度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldPrecision(this clsvFieldTabEN objvFieldTabEN, int intFldPrecision, string strComparisonOp="")
	{
objvFieldTabEN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldPrecision) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldPrecision, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldPrecision] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldInfo">字段信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldInfo(this clsvFieldTabEN objvFieldTabEN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldInfo, convFieldTab.FldInfo);
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab.FldInfo);
objvFieldTabEN.FldInfo = strFldInfo; //字段信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldInfo) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldInfo, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldInfo] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNull">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsNull(this clsvFieldTabEN objvFieldTabEN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, convFieldTab.IsNull);
objvFieldTabEN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsNull) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsNull, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsNull] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPrimaryKey">是否主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsPrimaryKey(this clsvFieldTabEN objvFieldTabEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, convFieldTab.IsPrimaryKey);
objvFieldTabEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsPrimaryKey) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsPrimaryKey, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsPrimaryKey] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsIdentity(this clsvFieldTabEN objvFieldTabEN, bool bolIsIdentity, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsIdentity, convFieldTab.IsIdentity);
objvFieldTabEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsIdentity) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsIdentity, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsIdentity] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsChecked(this clsvFieldTabEN objvFieldTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objvFieldTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsChecked) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsChecked, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsChecked] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsArchive(this clsvFieldTabEN objvFieldTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objvFieldTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsArchive) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsArchive, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsArchive] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOnlyOne">是否唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetIsOnlyOne(this clsvFieldTabEN objvFieldTabEN, bool bolIsOnlyOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOnlyOne, convFieldTab.IsOnlyOne);
objvFieldTabEN.IsOnlyOne = bolIsOnlyOne; //是否唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.IsOnlyOne) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.IsOnlyOne, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.IsOnlyOne] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMaxValue(this clsvFieldTabEN objvFieldTabEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convFieldTab.MaxValue);
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab.MaxValue);
objvFieldTabEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.MaxValue) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.MaxValue, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.MaxValue] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMinValue(this clsvFieldTabEN objvFieldTabEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convFieldTab.MinValue);
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab.MinValue);
objvFieldTabEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.MinValue) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.MinValue, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.MinValue] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDefaultValue(this clsvFieldTabEN objvFieldTabEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convFieldTab.DefaultValue);
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab.DefaultValue);
objvFieldTabEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.DefaultValue) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.DefaultValue, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.DefaultValue] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldStateId">字段状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldStateId(this clsvFieldTabEN objvFieldTabEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, convFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(strFldStateId, 2, convFieldTab.FldStateId);
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, convFieldTab.FldStateId);
objvFieldTabEN.FldStateId = strFldStateId; //字段状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.FldStateId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.FldStateId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.FldStateId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strHomologousFldId">同源字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetHomologousFldId(this clsvFieldTabEN objvFieldTabEN, string strHomologousFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convFieldTab.HomologousFldId);
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convFieldTab.HomologousFldId);
objvFieldTabEN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.HomologousFldId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.HomologousFldId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.HomologousFldId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetPrjId(this clsvFieldTabEN objvFieldTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab.PrjId);
objvFieldTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.PrjId) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.PrjId, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.PrjId] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetPrjName(this clsvFieldTabEN objvFieldTabEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFieldTab.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convFieldTab.PrjName);
objvFieldTabEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.PrjName) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.PrjName, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.PrjName] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetUpdDate(this clsvFieldTabEN objvFieldTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab.UpdDate);
objvFieldTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.UpdDate) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.UpdDate, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.UpdDate] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetUpdUser(this clsvFieldTabEN objvFieldTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFieldTab.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab.UpdUser);
objvFieldTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.UpdUser) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.UpdUser, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.UpdUser] = strComparisonOp;
}
}
return objvFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMemo(this clsvFieldTabEN objvFieldTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab.Memo);
objvFieldTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTabEN.dicFldComparisonOp.ContainsKey(convFieldTab.Memo) == false)
{
objvFieldTabEN.dicFldComparisonOp.Add(convFieldTab.Memo, strComparisonOp);
}
else
{
objvFieldTabEN.dicFldComparisonOp[convFieldTab.Memo] = strComparisonOp;
}
}
return objvFieldTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTabEN objvFieldTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTabCond.IsUpdated(convFieldTab.TabNum) == true)
{
string strComparisonOpTabNum = objvFieldTabCond.dicFldComparisonOp[convFieldTab.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab.TabNum, objvFieldTabCond.TabNum, strComparisonOpTabNum);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FieldTypeName, objvFieldTabCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FieldTypeENName) == true)
{
string strComparisonOpFieldTypeENName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FieldTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FieldTypeENName, objvFieldTabCond.FieldTypeENName, strComparisonOpFieldTypeENName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.OraDbType) == true)
{
string strComparisonOpOraDbType = objvFieldTabCond.dicFldComparisonOp[convFieldTab.OraDbType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.OraDbType, objvFieldTabCond.OraDbType, strComparisonOpOraDbType);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsNeedTransCode) == true)
{
if (objvFieldTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsNeedTransCode);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldId) == true)
{
string strComparisonOpFldId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FldId, objvFieldTabCond.FldId, strComparisonOpFldId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldName) == true)
{
string strComparisonOpFldName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FldName, objvFieldTabCond.FldName, strComparisonOpFldName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldCnName) == true)
{
string strComparisonOpFldCnName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FldCnName, objvFieldTabCond.FldCnName, strComparisonOpFldCnName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.Caption) == true)
{
string strComparisonOpCaption = objvFieldTabCond.dicFldComparisonOp[convFieldTab.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.Caption, objvFieldTabCond.Caption, strComparisonOpCaption);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FieldTypeId, objvFieldTabCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.DataTypeId, objvFieldTabCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.DataTypeName, objvFieldTabCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldLength) == true)
{
string strComparisonOpFldLength = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab.FldLength, objvFieldTabCond.FldLength, strComparisonOpFldLength);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab.FldPrecision, objvFieldTabCond.FldPrecision, strComparisonOpFldPrecision);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldInfo) == true)
{
string strComparisonOpFldInfo = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FldInfo, objvFieldTabCond.FldInfo, strComparisonOpFldInfo);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsNull) == true)
{
if (objvFieldTabCond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsNull);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsPrimaryKey) == true)
{
if (objvFieldTabCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsPrimaryKey);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsIdentity) == true)
{
if (objvFieldTabCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsIdentity);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsChecked) == true)
{
if (objvFieldTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsChecked);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsArchive) == true)
{
if (objvFieldTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsArchive);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.IsOnlyOne) == true)
{
if (objvFieldTabCond.IsOnlyOne == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab.IsOnlyOne);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab.IsOnlyOne);
}
}
if (objvFieldTabCond.IsUpdated(convFieldTab.MaxValue) == true)
{
string strComparisonOpMaxValue = objvFieldTabCond.dicFldComparisonOp[convFieldTab.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.MaxValue, objvFieldTabCond.MaxValue, strComparisonOpMaxValue);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.MinValue) == true)
{
string strComparisonOpMinValue = objvFieldTabCond.dicFldComparisonOp[convFieldTab.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.MinValue, objvFieldTabCond.MinValue, strComparisonOpMinValue);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvFieldTabCond.dicFldComparisonOp[convFieldTab.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.DefaultValue, objvFieldTabCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.FldStateId) == true)
{
string strComparisonOpFldStateId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.FldStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.FldStateId, objvFieldTabCond.FldStateId, strComparisonOpFldStateId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.HomologousFldId, objvFieldTabCond.HomologousFldId, strComparisonOpHomologousFldId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTabCond.dicFldComparisonOp[convFieldTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.PrjId, objvFieldTabCond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.PrjName) == true)
{
string strComparisonOpPrjName = objvFieldTabCond.dicFldComparisonOp[convFieldTab.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.PrjName, objvFieldTabCond.PrjName, strComparisonOpPrjName);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFieldTabCond.dicFldComparisonOp[convFieldTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.UpdDate, objvFieldTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFieldTabCond.dicFldComparisonOp[convFieldTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.UpdUser, objvFieldTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFieldTabCond.IsUpdated(convFieldTab.Memo) == true)
{
string strComparisonOpMemo = objvFieldTabCond.dicFldComparisonOp[convFieldTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab.Memo, objvFieldTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程字段(vFieldTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTabWApi
{
private static readonly string mstrApiControllerName = "vFieldTabApi";

 public clsvFieldTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程字段]...","0");
List<clsvFieldTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FldId";
objDDL.DataTextField="FldName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_FldId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFieldTab.FldId); 
List<clsvFieldTabEN> arrObjLst = clsvFieldTabWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN()
{
FldId = "0",
FldName = "选[v工程字段]..."
};
arrObjLstSel.Insert(0, objvFieldTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFieldTab.FldId;
objComboBox.DisplayMember = convFieldTab.FldName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTabEN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsvFieldTabEN objvFieldTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFieldTabEN = JsonConvert.DeserializeObject<clsvFieldTabEN>(strJson);
return objvFieldTabEN;
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
public static clsvFieldTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTabEN objvFieldTabEN;
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
objvFieldTabEN = JsonConvert.DeserializeObject<clsvFieldTabEN>(strJson);
return objvFieldTabEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTabEN GetObjByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel =
from objvFieldTabEN in arrvFieldTabObjLstCache
where objvFieldTabEN.FldId == strFldId 
select objvFieldTabEN;
if (arrvFieldTabObjLst_Sel.Count() == 0)
{
   clsvFieldTabEN obj = clsvFieldTabWApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldNameByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel1 =
from objvFieldTabEN in arrvFieldTabObjLstCache
where objvFieldTabEN.FldId == strFldId 
select objvFieldTabEN;
List <clsvFieldTabEN> arrvFieldTabObjLst_Sel = new List<clsvFieldTabEN>();
foreach (clsvFieldTabEN obj in arrvFieldTabObjLst_Sel1)
{
arrvFieldTabObjLst_Sel.Add(obj);
}
if (arrvFieldTabObjLst_Sel.Count > 0)
{
return arrvFieldTabObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在vFieldTab对象缓存列表中,找不到记录[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFieldTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel1 =
from objvFieldTabEN in arrvFieldTabObjLstCache
where objvFieldTabEN.FldId == strFldId 
select objvFieldTabEN;
List <clsvFieldTabEN> arrvFieldTabObjLst_Sel = new List<clsvFieldTabEN>();
foreach (clsvFieldTabEN obj in arrvFieldTabObjLst_Sel1)
{
arrvFieldTabObjLst_Sel.Add(obj);
}
if (arrvFieldTabObjLst_Sel.Count > 0)
{
return arrvFieldTabObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在vFieldTab对象缓存列表中,找不到记录的相关名称[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFieldTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
 /// <param name = "arrFldId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsvFieldTabEN> arrObjLst; 
string strAction = "GetObjLstByFldIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
 /// <param name = "arrFldId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFieldTabEN> GetObjLstByFldIdLstCache(List<string> arrFldId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel =
from objvFieldTabEN in arrvFieldTabObjLstCache
where arrFldId.Contains(objvFieldTabEN.FldId)
select objvFieldTabEN;
return arrvFieldTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
public static List<clsvFieldTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
public static List<clsvFieldTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
public static List<clsvFieldTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTabEN>>(strJson);
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
public static bool IsExist(string strFldId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId
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
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <param name = "objvFieldTabENT">目标对象</param>
 public static void CopyTo(clsvFieldTabEN objvFieldTabENS, clsvFieldTabEN objvFieldTabENT)
{
try
{
objvFieldTabENT.TabNum = objvFieldTabENS.TabNum; //表数
objvFieldTabENT.FieldTypeName = objvFieldTabENS.FieldTypeName; //字段类型名
objvFieldTabENT.FieldTypeENName = objvFieldTabENS.FieldTypeENName; //字段类型英文名
objvFieldTabENT.OraDbType = objvFieldTabENS.OraDbType; //Ora数据类型
objvFieldTabENT.IsNeedTransCode = objvFieldTabENS.IsNeedTransCode; //是否需要转换代码
objvFieldTabENT.FldId = objvFieldTabENS.FldId; //字段Id
objvFieldTabENT.FldName = objvFieldTabENS.FldName; //字段名
objvFieldTabENT.FldCnName = objvFieldTabENS.FldCnName; //字段中文详名
objvFieldTabENT.Caption = objvFieldTabENS.Caption; //标题
objvFieldTabENT.FieldTypeId = objvFieldTabENS.FieldTypeId; //字段类型Id
objvFieldTabENT.DataTypeId = objvFieldTabENS.DataTypeId; //数据类型Id
objvFieldTabENT.DataTypeName = objvFieldTabENS.DataTypeName; //数据类型名称
objvFieldTabENT.FldLength = objvFieldTabENS.FldLength; //字段长度
objvFieldTabENT.FldPrecision = objvFieldTabENS.FldPrecision; //精确度
objvFieldTabENT.FldInfo = objvFieldTabENS.FldInfo; //字段信息
objvFieldTabENT.IsNull = objvFieldTabENS.IsNull; //是否可空
objvFieldTabENT.IsPrimaryKey = objvFieldTabENS.IsPrimaryKey; //是否主键
objvFieldTabENT.IsIdentity = objvFieldTabENS.IsIdentity; //是否Identity
objvFieldTabENT.IsChecked = objvFieldTabENS.IsChecked; //是否核实
objvFieldTabENT.IsArchive = objvFieldTabENS.IsArchive; //是否存档
objvFieldTabENT.IsOnlyOne = objvFieldTabENS.IsOnlyOne; //是否唯一
objvFieldTabENT.MaxValue = objvFieldTabENS.MaxValue; //最大值
objvFieldTabENT.MinValue = objvFieldTabENS.MinValue; //最小值
objvFieldTabENT.DefaultValue = objvFieldTabENS.DefaultValue; //缺省值
objvFieldTabENT.FldStateId = objvFieldTabENS.FldStateId; //字段状态Id
objvFieldTabENT.HomologousFldId = objvFieldTabENS.HomologousFldId; //同源字段Id
objvFieldTabENT.PrjId = objvFieldTabENS.PrjId; //工程Id
objvFieldTabENT.PrjName = objvFieldTabENS.PrjName; //工程名称
objvFieldTabENT.UpdDate = objvFieldTabENS.UpdDate; //修改日期
objvFieldTabENT.UpdUser = objvFieldTabENS.UpdUser; //修改者
objvFieldTabENT.Memo = objvFieldTabENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFieldTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTabEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
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
public static List<clsvFieldTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFieldTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvFieldTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFieldTabObjLstCache = CacheHelper.Get<List<clsvFieldTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFieldTabObjLstCache = CacheHelper.Get<List<clsvFieldTabEN>>(strKey);
}
return arrvFieldTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab.TabNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab.FieldTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FieldTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.OraDbType, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab.FldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab.FldInfo, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.IsNull, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.IsPrimaryKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.IsOnlyOne, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.FldStateId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.HomologousFldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab.Memo, Type.GetType("System.String"));
foreach (clsvFieldTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab.TabNum] = objInFor[convFieldTab.TabNum];
objDR[convFieldTab.FieldTypeName] = objInFor[convFieldTab.FieldTypeName];
objDR[convFieldTab.FieldTypeENName] = objInFor[convFieldTab.FieldTypeENName];
objDR[convFieldTab.OraDbType] = objInFor[convFieldTab.OraDbType];
objDR[convFieldTab.IsNeedTransCode] = objInFor[convFieldTab.IsNeedTransCode];
objDR[convFieldTab.FldId] = objInFor[convFieldTab.FldId];
objDR[convFieldTab.FldName] = objInFor[convFieldTab.FldName];
objDR[convFieldTab.FldCnName] = objInFor[convFieldTab.FldCnName];
objDR[convFieldTab.Caption] = objInFor[convFieldTab.Caption];
objDR[convFieldTab.FieldTypeId] = objInFor[convFieldTab.FieldTypeId];
objDR[convFieldTab.DataTypeId] = objInFor[convFieldTab.DataTypeId];
objDR[convFieldTab.DataTypeName] = objInFor[convFieldTab.DataTypeName];
objDR[convFieldTab.FldLength] = objInFor[convFieldTab.FldLength];
objDR[convFieldTab.FldPrecision] = objInFor[convFieldTab.FldPrecision];
objDR[convFieldTab.FldInfo] = objInFor[convFieldTab.FldInfo];
objDR[convFieldTab.IsNull] = objInFor[convFieldTab.IsNull];
objDR[convFieldTab.IsPrimaryKey] = objInFor[convFieldTab.IsPrimaryKey];
objDR[convFieldTab.IsIdentity] = objInFor[convFieldTab.IsIdentity];
objDR[convFieldTab.IsChecked] = objInFor[convFieldTab.IsChecked];
objDR[convFieldTab.IsArchive] = objInFor[convFieldTab.IsArchive];
objDR[convFieldTab.IsOnlyOne] = objInFor[convFieldTab.IsOnlyOne];
objDR[convFieldTab.MaxValue] = objInFor[convFieldTab.MaxValue];
objDR[convFieldTab.MinValue] = objInFor[convFieldTab.MinValue];
objDR[convFieldTab.DefaultValue] = objInFor[convFieldTab.DefaultValue];
objDR[convFieldTab.FldStateId] = objInFor[convFieldTab.FldStateId];
objDR[convFieldTab.HomologousFldId] = objInFor[convFieldTab.HomologousFldId];
objDR[convFieldTab.PrjId] = objInFor[convFieldTab.PrjId];
objDR[convFieldTab.PrjName] = objInFor[convFieldTab.PrjName];
objDR[convFieldTab.UpdDate] = objInFor[convFieldTab.UpdDate];
objDR[convFieldTab.UpdUser] = objInFor[convFieldTab.UpdUser];
objDR[convFieldTab.Memo] = objInFor[convFieldTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}