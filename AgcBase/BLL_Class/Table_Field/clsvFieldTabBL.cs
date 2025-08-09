
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTabBL
 表名:vFieldTab(00050119)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvFieldTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTabEN GetObj(this K_FldId_vFieldTab myKey)
{
clsvFieldTabEN objvFieldTabEN = clsvFieldTabBL.vFieldTabDA.GetObjByFldId(myKey.Value);
return objvFieldTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetTabNum(this clsvFieldTabEN objvFieldTabEN, int? intTabNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeName(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFieldTab.FieldTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeENName(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeENName, 30, convFieldTab.FieldTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetOraDbType(this clsvFieldTabEN objvFieldTabEN, string strOraDbType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOraDbType, convFieldTab.OraDbType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOraDbType, 100, convFieldTab.OraDbType);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldId(this clsvFieldTabEN objvFieldTabEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldName(this clsvFieldTabEN objvFieldTabEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldCnName(this clsvFieldTabEN objvFieldTabEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convFieldTab.FldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetCaption(this clsvFieldTabEN objvFieldTabEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFieldTypeId(this clsvFieldTabEN objvFieldTabEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFieldTab.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFieldTab.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDataTypeId(this clsvFieldTabEN objvFieldTabEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab.DataTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDataTypeName(this clsvFieldTabEN objvFieldTabEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convFieldTab.DataTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldPrecision(this clsvFieldTabEN objvFieldTabEN, int? intFldPrecision, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldInfo(this clsvFieldTabEN objvFieldTabEN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldInfo, convFieldTab.FldInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab.FldInfo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMaxValue(this clsvFieldTabEN objvFieldTabEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convFieldTab.MaxValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab.MaxValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMinValue(this clsvFieldTabEN objvFieldTabEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convFieldTab.MinValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab.MinValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetDefaultValue(this clsvFieldTabEN objvFieldTabEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convFieldTab.DefaultValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetFldStateId(this clsvFieldTabEN objvFieldTabEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, convFieldTab.FldStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldStateId, 2, convFieldTab.FldStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, convFieldTab.FldStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetHomologousFldId(this clsvFieldTabEN objvFieldTabEN, string strHomologousFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convFieldTab.HomologousFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convFieldTab.HomologousFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetPrjId(this clsvFieldTabEN objvFieldTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetPrjName(this clsvFieldTabEN objvFieldTabEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFieldTab.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convFieldTab.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetUpdDate(this clsvFieldTabEN objvFieldTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetUpdUser(this clsvFieldTabEN objvFieldTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFieldTab.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTabEN SetMemo(this clsvFieldTabEN objvFieldTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <param name = "objvFieldTabENT">目标对象</param>
 public static void CopyTo(this clsvFieldTabEN objvFieldTabENS, clsvFieldTabEN objvFieldTabENT)
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
 /// <param name = "objvFieldTabENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTabEN:objvFieldTabENT</returns>
 public static clsvFieldTabEN CopyTo(this clsvFieldTabEN objvFieldTabENS)
{
try
{
 clsvFieldTabEN objvFieldTabENT = new clsvFieldTabEN()
{
TabNum = objvFieldTabENS.TabNum, //表数
FieldTypeName = objvFieldTabENS.FieldTypeName, //字段类型名
FieldTypeENName = objvFieldTabENS.FieldTypeENName, //字段类型英文名
OraDbType = objvFieldTabENS.OraDbType, //Ora数据类型
IsNeedTransCode = objvFieldTabENS.IsNeedTransCode, //是否需要转换代码
FldId = objvFieldTabENS.FldId, //字段Id
FldName = objvFieldTabENS.FldName, //字段名
FldCnName = objvFieldTabENS.FldCnName, //字段中文详名
Caption = objvFieldTabENS.Caption, //标题
FieldTypeId = objvFieldTabENS.FieldTypeId, //字段类型Id
DataTypeId = objvFieldTabENS.DataTypeId, //数据类型Id
DataTypeName = objvFieldTabENS.DataTypeName, //数据类型名称
FldLength = objvFieldTabENS.FldLength, //字段长度
FldPrecision = objvFieldTabENS.FldPrecision, //精确度
FldInfo = objvFieldTabENS.FldInfo, //字段信息
IsNull = objvFieldTabENS.IsNull, //是否可空
IsPrimaryKey = objvFieldTabENS.IsPrimaryKey, //是否主键
IsIdentity = objvFieldTabENS.IsIdentity, //是否Identity
IsChecked = objvFieldTabENS.IsChecked, //是否核实
IsArchive = objvFieldTabENS.IsArchive, //是否存档
IsOnlyOne = objvFieldTabENS.IsOnlyOne, //是否唯一
MaxValue = objvFieldTabENS.MaxValue, //最大值
MinValue = objvFieldTabENS.MinValue, //最小值
DefaultValue = objvFieldTabENS.DefaultValue, //缺省值
FldStateId = objvFieldTabENS.FldStateId, //字段状态Id
HomologousFldId = objvFieldTabENS.HomologousFldId, //同源字段Id
PrjId = objvFieldTabENS.PrjId, //工程Id
PrjName = objvFieldTabENS.PrjName, //工程名称
UpdDate = objvFieldTabENS.UpdDate, //修改日期
UpdUser = objvFieldTabENS.UpdUser, //修改者
Memo = objvFieldTabENS.Memo, //说明
};
 return objvFieldTabENT;
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
public static void CheckProperty4Condition(this clsvFieldTabEN objvFieldTabEN)
{
 clsvFieldTabBL.vFieldTabDA.CheckProperty4Condition(objvFieldTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFieldTab
{
public virtual bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程字段(vFieldTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTabBL
{
public static RelatedActions_vFieldTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFieldTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFieldTabDA vFieldTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFieldTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFieldTabBL()
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
if (string.IsNullOrEmpty(clsvFieldTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTabEN._ConnectString);
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
public static DataTable GetDataTable_vFieldTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFieldTabDA.GetDataTable_vFieldTab(strWhereCond);
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
objDT = vFieldTabDA.GetDataTable(strWhereCond);
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
objDT = vFieldTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFieldTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFieldTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFieldTabDA.GetDataTable_Top(objTopPara);
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
objDT = vFieldTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFieldTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFieldTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstByFldIdLst(List<string> arrFldIdLst)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldIdLst, true);
 string strWhereCond = string.Format("FldId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFieldTabEN> GetObjLstByFldIdLstCache(List<string> arrFldIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel =
arrvFieldTabObjLstCache
.Where(x => arrFldIdLst.Contains(x.FldId));
return arrvFieldTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetObjLst(string strWhereCond)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
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
public static List<clsvFieldTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFieldTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFieldTabEN> GetSubObjLstCache(clsvFieldTabEN objvFieldTabCond)
{
 string strPrjId = objvFieldTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFieldTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFieldTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab._AttributeName)
{
if (objvFieldTabCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTabCond[strFldName].ToString());
}
else
{
if (objvFieldTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTabCond[strFldName]));
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
public static List<clsvFieldTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
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
public static List<clsvFieldTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
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
List<clsvFieldTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFieldTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFieldTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
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
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
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
public static List<clsvFieldTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFieldTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
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
public static List<clsvFieldTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFieldTabEN> arrObjLst = new List<clsvFieldTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTabEN objvFieldTabEN = new clsvFieldTabEN();
try
{
objvFieldTabEN.TabNum = objRow[convFieldTab.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.TabNum].ToString().Trim()); //表数
objvFieldTabEN.FieldTypeName = objRow[convFieldTab.FieldTypeName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeName].ToString().Trim(); //字段类型名
objvFieldTabEN.FieldTypeENName = objRow[convFieldTab.FieldTypeENName] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFieldTabEN.OraDbType = objRow[convFieldTab.OraDbType].ToString().Trim(); //Ora数据类型
objvFieldTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTabEN.FldId = objRow[convFieldTab.FldId].ToString().Trim(); //字段Id
objvFieldTabEN.FldName = objRow[convFieldTab.FldName].ToString().Trim(); //字段名
objvFieldTabEN.FldCnName = objRow[convFieldTab.FldCnName] == DBNull.Value ? null : objRow[convFieldTab.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTabEN.Caption = objRow[convFieldTab.Caption].ToString().Trim(); //标题
objvFieldTabEN.FieldTypeId = objRow[convFieldTab.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTabEN.DataTypeId = objRow[convFieldTab.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTabEN.DataTypeName = objRow[convFieldTab.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTabEN.FldLength = Int32.Parse(objRow[convFieldTab.FldLength].ToString().Trim()); //字段长度
objvFieldTabEN.FldPrecision = objRow[convFieldTab.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab.FldPrecision].ToString().Trim()); //精确度
objvFieldTabEN.FldInfo = objRow[convFieldTab.FldInfo].ToString().Trim(); //字段信息
objvFieldTabEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsNull].ToString().Trim()); //是否可空
objvFieldTabEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTabEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsChecked].ToString().Trim()); //是否核实
objvFieldTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsArchive].ToString().Trim()); //是否存档
objvFieldTabEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTabEN.MaxValue = objRow[convFieldTab.MaxValue].ToString().Trim(); //最大值
objvFieldTabEN.MinValue = objRow[convFieldTab.MinValue].ToString().Trim(); //最小值
objvFieldTabEN.DefaultValue = objRow[convFieldTab.DefaultValue].ToString().Trim(); //缺省值
objvFieldTabEN.FldStateId = objRow[convFieldTab.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTabEN.HomologousFldId = objRow[convFieldTab.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab.HomologousFldId].ToString().Trim(); //同源字段Id
objvFieldTabEN.PrjId = objRow[convFieldTab.PrjId].ToString().Trim(); //工程Id
objvFieldTabEN.PrjName = objRow[convFieldTab.PrjName].ToString().Trim(); //工程名称
objvFieldTabEN.UpdDate = objRow[convFieldTab.UpdDate] == DBNull.Value ? null : objRow[convFieldTab.UpdDate].ToString().Trim(); //修改日期
objvFieldTabEN.UpdUser = objRow[convFieldTab.UpdUser].ToString().Trim(); //修改者
objvFieldTabEN.Memo = objRow[convFieldTab.Memo] == DBNull.Value ? null : objRow[convFieldTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTabEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFieldTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFieldTab(ref clsvFieldTabEN objvFieldTabEN)
{
bool bolResult = vFieldTabDA.GetvFieldTab(ref objvFieldTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTabEN GetObjByFldId(string strFldId)
{
if (strFldId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFieldTabEN objvFieldTabEN = vFieldTabDA.GetObjByFldId(strFldId);
return objvFieldTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFieldTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFieldTabEN objvFieldTabEN = vFieldTabDA.GetFirstObj(strWhereCond);
 return objvFieldTabEN;
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
public static clsvFieldTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFieldTabEN objvFieldTabEN = vFieldTabDA.GetObjByDataRow(objRow);
 return objvFieldTabEN;
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
public static clsvFieldTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFieldTabEN objvFieldTabEN = vFieldTabDA.GetObjByDataRow(objRow);
 return objvFieldTabEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "lstvFieldTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTabEN GetObjByFldIdFromList(string strFldId, List<clsvFieldTabEN> lstvFieldTabObjLst)
{
foreach (clsvFieldTabEN objvFieldTabEN in lstvFieldTabObjLst)
{
if (objvFieldTabEN.FldId == strFldId)
{
return objvFieldTabEN;
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
 string strFldId;
 try
 {
 strFldId = new clsvFieldTabDA().GetFirstID(strWhereCond);
 return strFldId;
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
 arrList = vFieldTabDA.GetID(strWhereCond);
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
bool bolIsExist = vFieldTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFieldTabDA.IsExist(strFldId);
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
 bolIsExist = clsvFieldTabDA.IsExistTable();
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
 bolIsExist = vFieldTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvFieldTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvFieldTabEN objvFieldTabEN)
{
try
{
objvFieldTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFieldTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFieldTab.TabNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.TabNum = objvFieldTabEN.TabNum; //表数
}
if (arrFldSet.Contains(convFieldTab.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FieldTypeName = objvFieldTabEN.FieldTypeName == "[null]" ? null :  objvFieldTabEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convFieldTab.FieldTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FieldTypeENName = objvFieldTabEN.FieldTypeENName == "[null]" ? null :  objvFieldTabEN.FieldTypeENName; //字段类型英文名
}
if (arrFldSet.Contains(convFieldTab.OraDbType, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.OraDbType = objvFieldTabEN.OraDbType; //Ora数据类型
}
if (arrFldSet.Contains(convFieldTab.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsNeedTransCode = objvFieldTabEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convFieldTab.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldId = objvFieldTabEN.FldId; //字段Id
}
if (arrFldSet.Contains(convFieldTab.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldName = objvFieldTabEN.FldName; //字段名
}
if (arrFldSet.Contains(convFieldTab.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldCnName = objvFieldTabEN.FldCnName == "[null]" ? null :  objvFieldTabEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(convFieldTab.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.Caption = objvFieldTabEN.Caption; //标题
}
if (arrFldSet.Contains(convFieldTab.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FieldTypeId = objvFieldTabEN.FieldTypeId == "[null]" ? null :  objvFieldTabEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convFieldTab.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.DataTypeId = objvFieldTabEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convFieldTab.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.DataTypeName = objvFieldTabEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convFieldTab.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldLength = objvFieldTabEN.FldLength; //字段长度
}
if (arrFldSet.Contains(convFieldTab.FldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldPrecision = objvFieldTabEN.FldPrecision; //精确度
}
if (arrFldSet.Contains(convFieldTab.FldInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldInfo = objvFieldTabEN.FldInfo; //字段信息
}
if (arrFldSet.Contains(convFieldTab.IsNull, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsNull = objvFieldTabEN.IsNull; //是否可空
}
if (arrFldSet.Contains(convFieldTab.IsPrimaryKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsPrimaryKey = objvFieldTabEN.IsPrimaryKey; //是否主键
}
if (arrFldSet.Contains(convFieldTab.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsIdentity = objvFieldTabEN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(convFieldTab.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsChecked = objvFieldTabEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(convFieldTab.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsArchive = objvFieldTabEN.IsArchive; //是否存档
}
if (arrFldSet.Contains(convFieldTab.IsOnlyOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.IsOnlyOne = objvFieldTabEN.IsOnlyOne; //是否唯一
}
if (arrFldSet.Contains(convFieldTab.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.MaxValue = objvFieldTabEN.MaxValue; //最大值
}
if (arrFldSet.Contains(convFieldTab.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.MinValue = objvFieldTabEN.MinValue; //最小值
}
if (arrFldSet.Contains(convFieldTab.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.DefaultValue = objvFieldTabEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convFieldTab.FldStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.FldStateId = objvFieldTabEN.FldStateId; //字段状态Id
}
if (arrFldSet.Contains(convFieldTab.HomologousFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.HomologousFldId = objvFieldTabEN.HomologousFldId == "[null]" ? null :  objvFieldTabEN.HomologousFldId; //同源字段Id
}
if (arrFldSet.Contains(convFieldTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.PrjId = objvFieldTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFieldTab.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.PrjName = objvFieldTabEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convFieldTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.UpdDate = objvFieldTabEN.UpdDate == "[null]" ? null :  objvFieldTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFieldTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.UpdUser = objvFieldTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFieldTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTabEN.Memo = objvFieldTabEN.Memo == "[null]" ? null :  objvFieldTabEN.Memo; //说明
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
 /// <param name = "objvFieldTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFieldTabEN objvFieldTabEN)
{
try
{
if (objvFieldTabEN.FieldTypeName == "[null]") objvFieldTabEN.FieldTypeName = null; //字段类型名
if (objvFieldTabEN.FieldTypeENName == "[null]") objvFieldTabEN.FieldTypeENName = null; //字段类型英文名
if (objvFieldTabEN.FldCnName == "[null]") objvFieldTabEN.FldCnName = null; //字段中文详名
if (objvFieldTabEN.FieldTypeId == "[null]") objvFieldTabEN.FieldTypeId = null; //字段类型Id
if (objvFieldTabEN.HomologousFldId == "[null]") objvFieldTabEN.HomologousFldId = null; //同源字段Id
if (objvFieldTabEN.UpdDate == "[null]") objvFieldTabEN.UpdDate = null; //修改日期
if (objvFieldTabEN.Memo == "[null]") objvFieldTabEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFieldTabEN objvFieldTabEN)
{
 vFieldTabDA.CheckProperty4Condition(objvFieldTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_FldId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFieldTab.FldId); 
List<clsvFieldTabEN> arrObjLst = clsvFieldTabBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程字段]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convFieldTab.FldId); 
IEnumerable<clsvFieldTabEN> arrObjLst = clsvFieldTabBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convFieldTab.FldId;
objDDL.DataTextField = convFieldTab.FldName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程字段]...","0");
List<clsvFieldTabEN> arrvFieldTabObjLst = GetAllvFieldTabObjLstCache(strPrjId); 
objDDL.DataValueField = convFieldTab.FldId;
objDDL.DataTextField = convFieldTab.FldName;
objDDL.DataSource = arrvFieldTabObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldId");
//if (arrvFieldTabObjLstCache == null)
//{
//arrvFieldTabObjLstCache = vFieldTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTabEN GetObjByFldIdCache(string strFldId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrvFieldTabObjLst_Sel =
arrvFieldTabObjLstCache
.Where(x=> x.FldId == strFldId 
);
if (arrvFieldTabObjLst_Sel.Count() == 0)
{
   clsvFieldTabEN obj = clsvFieldTabBL.GetObjByFldId(strFldId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFldId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFieldTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldNameByFldIdCache(string strFldId, string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//获取缓存中的对象列表
clsvFieldTabEN objvFieldTab = GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab == null) return "";
return objvFieldTab.FldName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldIdCache(string strFldId, string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//获取缓存中的对象列表
clsvFieldTabEN objvFieldTab = GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab == null) return "";
return objvFieldTab.FldName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTabEN> GetAllvFieldTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFieldTabEN> arrvFieldTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvFieldTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFieldTabEN> arrvFieldTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFieldTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFieldTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFieldTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFieldTabEN._RefreshTimeLst.Count == 0) return "";
return clsvFieldTabEN._RefreshTimeLst[clsvFieldTabEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFldId, string strPrjId)
{
if (strInFldName != convFieldTab.FldId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFieldTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFieldTab._AttributeName));
throw new Exception(strMsg);
}
var objvFieldTab = clsvFieldTabBL.GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab == null) return "";
return objvFieldTab[strOutFldName].ToString();
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
int intRecCount = clsvFieldTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvFieldTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFieldTabDA.GetRecCount();
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
int intRecCount = clsvFieldTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFieldTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFieldTabEN objvFieldTabCond)
{
 string strPrjId = objvFieldTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFieldTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFieldTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab._AttributeName)
{
if (objvFieldTabCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTabCond[strFldName].ToString());
}
else
{
if (objvFieldTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTabCond[strFldName]));
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
 List<string> arrList = clsvFieldTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFieldTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFieldTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}