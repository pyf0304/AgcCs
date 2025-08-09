
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTabWApi
 表名:FieldTab(00050021)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:16
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
public static class  clsFieldTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldId(this clsFieldTabEN objFieldTabEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conFieldTab.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conFieldTab.FldId);
objFieldTabEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldName(this clsFieldTabEN objFieldTabEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, conFieldTab.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, conFieldTab.FldName);
objFieldTabEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldName) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldName, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldName] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldCnName(this clsFieldTabEN objFieldTabEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, conFieldTab.FldCnName);
objFieldTabEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldCnName) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldCnName, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldCnName] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetCaption(this clsFieldTabEN objFieldTabEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, conFieldTab.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, conFieldTab.Caption);
objFieldTabEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.Caption) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.Caption, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.Caption] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFieldTypeId(this clsFieldTabEN objFieldTabEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conFieldTab.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conFieldTab.FieldTypeId);
objFieldTabEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FieldTypeId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FieldTypeId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FieldTypeId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetDataTypeId(this clsFieldTabEN objFieldTabEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conFieldTab.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conFieldTab.DataTypeId);
objFieldTabEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.DataTypeId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.DataTypeId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.DataTypeId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldLength(this clsFieldTabEN objFieldTabEN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, conFieldTab.FldLength);
objFieldTabEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldLength) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldLength, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldLength] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldPrecision">精确度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldPrecision(this clsFieldTabEN objFieldTabEN, int intFldPrecision, string strComparisonOp="")
	{
objFieldTabEN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldPrecision) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldPrecision, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldPrecision] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldInfo">字段信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldInfo(this clsFieldTabEN objFieldTabEN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldInfo, 100, conFieldTab.FldInfo);
objFieldTabEN.FldInfo = strFldInfo; //字段信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldInfo) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldInfo, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldInfo] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNull">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsNull(this clsFieldTabEN objFieldTabEN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, conFieldTab.IsNull);
objFieldTabEN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsNull) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsNull, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsNull] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPrimaryKey">是否主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsPrimaryKey(this clsFieldTabEN objFieldTabEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, conFieldTab.IsPrimaryKey);
objFieldTabEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsPrimaryKey) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsPrimaryKey, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsPrimaryKey] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsIdentity(this clsFieldTabEN objFieldTabEN, bool bolIsIdentity, string strComparisonOp="")
	{
objFieldTabEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsIdentity) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsIdentity, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsIdentity] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsChecked(this clsFieldTabEN objFieldTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objFieldTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsChecked) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsChecked, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsChecked] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsArchive">是否存档</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsArchive(this clsFieldTabEN objFieldTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objFieldTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsArchive) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsArchive, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsArchive] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOnlyOne">是否唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsOnlyOne(this clsFieldTabEN objFieldTabEN, bool bolIsOnlyOne, string strComparisonOp="")
	{
objFieldTabEN.IsOnlyOne = bolIsOnlyOne; //是否唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsOnlyOne) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsOnlyOne, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsOnlyOne] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMaxValue(this clsFieldTabEN objFieldTabEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMaxValue, 50, conFieldTab.MaxValue);
objFieldTabEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.MaxValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.MaxValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.MaxValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMinValue(this clsFieldTabEN objFieldTabEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMinValue, 50, conFieldTab.MinValue);
objFieldTabEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.MinValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.MinValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.MinValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetDefaultValue(this clsFieldTabEN objFieldTabEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conFieldTab.DefaultValue);
objFieldTabEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.DefaultValue) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.DefaultValue, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.DefaultValue] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldStateId">字段状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetFldStateId(this clsFieldTabEN objFieldTabEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, conFieldTab.FldStateId);
clsCheckSql.CheckFieldLen(strFldStateId, 2, conFieldTab.FldStateId);
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, conFieldTab.FldStateId);
objFieldTabEN.FldStateId = strFldStateId; //字段状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.FldStateId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.FldStateId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.FldStateId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strHomologousFldId">同源字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetHomologousFldId(this clsFieldTabEN objFieldTabEN, string strHomologousFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, conFieldTab.HomologousFldId);
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, conFieldTab.HomologousFldId);
objFieldTabEN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.HomologousFldId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.HomologousFldId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.HomologousFldId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabNum">表数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetTabNum(this clsFieldTabEN objFieldTabEN, int intTabNum, string strComparisonOp="")
	{
objFieldTabEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.TabNum) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.TabNum, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.TabNum] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetInUse(this clsFieldTabEN objFieldTabEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conFieldTab.InUse);
objFieldTabEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.InUse) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.InUse, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.InUse] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetPrjId(this clsFieldTabEN objFieldTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFieldTab.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conFieldTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFieldTab.PrjId);
objFieldTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.PrjId) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.PrjId, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.PrjId] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetUpdDate(this clsFieldTabEN objFieldTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conFieldTab.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFieldTab.UpdDate);
objFieldTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.UpdDate) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.UpdDate, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.UpdDate] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetUpdUser(this clsFieldTabEN objFieldTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFieldTab.UpdUser);
objFieldTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.UpdUser) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.UpdUser, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.UpdUser] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetMemo(this clsFieldTabEN objFieldTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldTab.Memo);
objFieldTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.Memo) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.Memo, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.Memo] = strComparisonOp;
}
}
return objFieldTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTabEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTabEN SetIsNeedTransCode(this clsFieldTabEN objFieldTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
objFieldTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTabEN.dicFldComparisonOp.ContainsKey(conFieldTab.IsNeedTransCode) == false)
{
objFieldTabEN.dicFldComparisonOp.Add(conFieldTab.IsNeedTransCode, strComparisonOp);
}
else
{
objFieldTabEN.dicFldComparisonOp[conFieldTab.IsNeedTransCode] = strComparisonOp;
}
}
return objFieldTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTabEN objFieldTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTabCond.IsUpdated(conFieldTab.FldId) == true)
{
string strComparisonOpFldId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldId, objFieldTabCond.FldId, strComparisonOpFldId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldName) == true)
{
string strComparisonOpFldName = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldName, objFieldTabCond.FldName, strComparisonOpFldName);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldCnName) == true)
{
string strComparisonOpFldCnName = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldCnName, objFieldTabCond.FldCnName, strComparisonOpFldCnName);
}
if (objFieldTabCond.IsUpdated(conFieldTab.Caption) == true)
{
string strComparisonOpCaption = objFieldTabCond.dicFldComparisonOp[conFieldTab.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.Caption, objFieldTabCond.Caption, strComparisonOpCaption);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FieldTypeId, objFieldTabCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objFieldTabCond.dicFldComparisonOp[conFieldTab.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.DataTypeId, objFieldTabCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldLength) == true)
{
string strComparisonOpFldLength = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.FldLength, objFieldTabCond.FldLength, strComparisonOpFldLength);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.FldPrecision, objFieldTabCond.FldPrecision, strComparisonOpFldPrecision);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldInfo) == true)
{
string strComparisonOpFldInfo = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldInfo, objFieldTabCond.FldInfo, strComparisonOpFldInfo);
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsNull) == true)
{
if (objFieldTabCond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsNull);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsPrimaryKey) == true)
{
if (objFieldTabCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsPrimaryKey);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsIdentity) == true)
{
if (objFieldTabCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsIdentity);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsChecked) == true)
{
if (objFieldTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsChecked);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsArchive) == true)
{
if (objFieldTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsArchive);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsOnlyOne) == true)
{
if (objFieldTabCond.IsOnlyOne == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsOnlyOne);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsOnlyOne);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.MaxValue) == true)
{
string strComparisonOpMaxValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.MaxValue, objFieldTabCond.MaxValue, strComparisonOpMaxValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.MinValue) == true)
{
string strComparisonOpMinValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.MinValue, objFieldTabCond.MinValue, strComparisonOpMinValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objFieldTabCond.dicFldComparisonOp[conFieldTab.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.DefaultValue, objFieldTabCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objFieldTabCond.IsUpdated(conFieldTab.FldStateId) == true)
{
string strComparisonOpFldStateId = objFieldTabCond.dicFldComparisonOp[conFieldTab.FldStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.FldStateId, objFieldTabCond.FldStateId, strComparisonOpFldStateId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objFieldTabCond.dicFldComparisonOp[conFieldTab.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.HomologousFldId, objFieldTabCond.HomologousFldId, strComparisonOpHomologousFldId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.TabNum) == true)
{
string strComparisonOpTabNum = objFieldTabCond.dicFldComparisonOp[conFieldTab.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab.TabNum, objFieldTabCond.TabNum, strComparisonOpTabNum);
}
if (objFieldTabCond.IsUpdated(conFieldTab.InUse) == true)
{
if (objFieldTabCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.InUse);
}
}
if (objFieldTabCond.IsUpdated(conFieldTab.PrjId) == true)
{
string strComparisonOpPrjId = objFieldTabCond.dicFldComparisonOp[conFieldTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.PrjId, objFieldTabCond.PrjId, strComparisonOpPrjId);
}
if (objFieldTabCond.IsUpdated(conFieldTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objFieldTabCond.dicFldComparisonOp[conFieldTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.UpdDate, objFieldTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objFieldTabCond.IsUpdated(conFieldTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objFieldTabCond.dicFldComparisonOp[conFieldTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.UpdUser, objFieldTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objFieldTabCond.IsUpdated(conFieldTab.Memo) == true)
{
string strComparisonOpMemo = objFieldTabCond.dicFldComparisonOp[conFieldTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab.Memo, objFieldTabCond.Memo, strComparisonOpMemo);
}
if (objFieldTabCond.IsUpdated(conFieldTab.IsNeedTransCode) == true)
{
if (objFieldTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab.IsNeedTransCode);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTabEN objFieldTabEN)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFieldTabEN.sfUpdFldSetStr = objFieldTabEN.getsfUpdFldSetStr();
clsFieldTabWApi.CheckPropertyNew(objFieldTabEN); 
bool bolResult = clsFieldTabWApi.UpdateRecord(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
 /// 获取唯一性条件串--FieldTab(工程字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FldName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFieldTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFieldTabEN objFieldTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFieldTabEN == null) return "";
if (objFieldTabEN.FldId == null || objFieldTabEN.FldId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FldId !=  '{0}'", objFieldTabEN.FldId);
 sbCondition.AppendFormat(" and FldName = '{0}'", objFieldTabEN.FldName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFieldTabEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTabEN objFieldTabEN)
{
 if (string.IsNullOrEmpty(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTabWApi.IsExist(objFieldTabEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTabEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFieldTabWApi.CheckPropertyNew(objFieldTabEN); 
bool bolResult = clsFieldTabWApi.AddNewRecord(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
 /// <param name = "objFieldTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFieldTabEN objFieldTabEN)
{
try
{
clsFieldTabWApi.CheckPropertyNew(objFieldTabEN); 
string strFldId = clsFieldTabWApi.AddNewRecordWithMaxId(objFieldTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
return strFldId;
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTabEN objFieldTabEN, string strWhereCond)
{
try
{
clsFieldTabWApi.CheckPropertyNew(objFieldTabEN); 
bool bolResult = clsFieldTabWApi.UpdateWithCondition(objFieldTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
 /// 工程字段(FieldTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFieldTabWApi
{
private static readonly string mstrApiControllerName = "FieldTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFieldTabWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程字段]...","0");
List<clsFieldTabEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conFieldTab.FldId); 
List<clsFieldTabEN> arrObjLst = clsFieldTabWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFieldTabEN objFieldTabEN = new clsFieldTabEN()
{
FldId = "0",
FldName = "选[工程字段]..."
};
arrObjLstSel.Insert(0, objFieldTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFieldTab.FldId;
objComboBox.DisplayMember = conFieldTab.FldName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFieldTabEN objFieldTabEN)
{
if (!Object.Equals(null, objFieldTabEN.FldId) && GetStrLen(objFieldTabEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTabEN.FldName) && GetStrLen(objFieldTabEN.FldName) > 50)
{
 throw new Exception("字段[字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objFieldTabEN.FldCnName) && GetStrLen(objFieldTabEN.FldCnName) > 200)
{
 throw new Exception("字段[字段中文详名]的长度不能超过200!");
}
if (!Object.Equals(null, objFieldTabEN.Caption) && GetStrLen(objFieldTabEN.Caption) > 200)
{
 throw new Exception("字段[标题]的长度不能超过200!");
}
if (!Object.Equals(null, objFieldTabEN.FieldTypeId) && GetStrLen(objFieldTabEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFieldTabEN.DataTypeId) && GetStrLen(objFieldTabEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFieldTabEN.FldInfo) && GetStrLen(objFieldTabEN.FldInfo) > 100)
{
 throw new Exception("字段[字段信息]的长度不能超过100!");
}
if (!Object.Equals(null, objFieldTabEN.MaxValue) && GetStrLen(objFieldTabEN.MaxValue) > 50)
{
 throw new Exception("字段[最大值]的长度不能超过50!");
}
if (!Object.Equals(null, objFieldTabEN.MinValue) && GetStrLen(objFieldTabEN.MinValue) > 50)
{
 throw new Exception("字段[最小值]的长度不能超过50!");
}
if (!Object.Equals(null, objFieldTabEN.DefaultValue) && GetStrLen(objFieldTabEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objFieldTabEN.FldStateId) && GetStrLen(objFieldTabEN.FldStateId) > 2)
{
 throw new Exception("字段[字段状态Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFieldTabEN.HomologousFldId) && GetStrLen(objFieldTabEN.HomologousFldId) > 8)
{
 throw new Exception("字段[同源字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTabEN.PrjId) && GetStrLen(objFieldTabEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFieldTabEN.UpdDate) && GetStrLen(objFieldTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTabEN.UpdUser) && GetStrLen(objFieldTabEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTabEN.Memo) && GetStrLen(objFieldTabEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFieldTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTabEN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsFieldTabEN objFieldTabEN;
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
objFieldTabEN = JsonConvert.DeserializeObject<clsFieldTabEN>(strJson);
return objFieldTabEN;
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
public static clsFieldTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFieldTabEN objFieldTabEN;
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
objFieldTabEN = JsonConvert.DeserializeObject<clsFieldTabEN>(strJson);
return objFieldTabEN;
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
public static clsFieldTabEN GetObjByFldIdCache(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel =
from objFieldTabEN in arrFieldTabObjLstCache
where objFieldTabEN.FldId == strFldId 
select objFieldTabEN;
if (arrFieldTabObjLst_Sel.Count() == 0)
{
   clsFieldTabEN obj = clsFieldTabWApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFieldTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldNameByFldIdCache(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel1 =
from objFieldTabEN in arrFieldTabObjLstCache
where objFieldTabEN.FldId == strFldId 
select objFieldTabEN;
List <clsFieldTabEN> arrFieldTabObjLst_Sel = new List<clsFieldTabEN>();
foreach (clsFieldTabEN obj in arrFieldTabObjLst_Sel1)
{
arrFieldTabObjLst_Sel.Add(obj);
}
if (arrFieldTabObjLst_Sel.Count > 0)
{
return arrFieldTabObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在FieldTab对象缓存列表中,找不到记录[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFieldTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldIdCache(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel1 =
from objFieldTabEN in arrFieldTabObjLstCache
where objFieldTabEN.FldId == strFldId 
select objFieldTabEN;
List <clsFieldTabEN> arrFieldTabObjLst_Sel = new List<clsFieldTabEN>();
foreach (clsFieldTabEN obj in arrFieldTabObjLst_Sel1)
{
arrFieldTabObjLst_Sel.Add(obj);
}
if (arrFieldTabObjLst_Sel.Count > 0)
{
return arrFieldTabObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在FieldTab对象缓存列表中,找不到记录的相关名称[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFieldTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTabEN> GetObjLst(string strWhereCond)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static List<clsFieldTabEN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static IEnumerable<clsFieldTabEN> GetObjLstByFldIdLstCache(List<string> arrFldId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = GetObjLstCache();
IEnumerable <clsFieldTabEN> arrFieldTabObjLst_Sel =
from objFieldTabEN in arrFieldTabObjLstCache
where arrFldId.Contains(objFieldTabEN.FldId)
select objFieldTabEN;
return arrFieldTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static List<clsFieldTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static List<clsFieldTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static List<clsFieldTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFieldTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTabEN>>(strJson);
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
public static int DelRecord(string strFldId)
{
string strAction = "DelRecord";
try
{
 clsFieldTabEN objFieldTabEN = clsFieldTabWApi.GetObjByFldId(strFldId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFldId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
public static int DelFieldTabs(List<string> arrFldId)
{
string strAction = "DelFieldTabs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFieldTabEN objFieldTabEN = clsFieldTabWApi.GetObjByFldId(arrFldId[0]);
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
public static int DelFieldTabsByCond(string strWhereCond)
{
string strAction = "DelFieldTabsByCond";
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
public static bool AddNewRecord(clsFieldTabEN objFieldTabEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTabEN>(objFieldTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsFieldTabEN objFieldTabEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTabEN>(objFieldTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTabWApi.ReFreshCache(objFieldTabEN.PrjId);
var strFldId = (string)jobjReturn0["returnStr"];
return strFldId;
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
public static bool UpdateRecord(clsFieldTabEN objFieldTabEN)
{
if (string.IsNullOrEmpty(objFieldTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTabEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTabEN>(objFieldTabEN);
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
 /// <param name = "objFieldTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFieldTabEN objFieldTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFieldTabEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTabEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTabEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTabEN>(objFieldTabEN);
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
 /// <param name = "objFieldTabENS">源对象</param>
 /// <param name = "objFieldTabENT">目标对象</param>
 public static void CopyTo(clsFieldTabEN objFieldTabENS, clsFieldTabEN objFieldTabENT)
{
try
{
objFieldTabENT.FldId = objFieldTabENS.FldId; //字段Id
objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
objFieldTabENT.FldCnName = objFieldTabENS.FldCnName; //字段中文详名
objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
objFieldTabENT.FieldTypeId = objFieldTabENS.FieldTypeId; //字段类型Id
objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //数据类型Id
objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
objFieldTabENT.HomologousFldId = objFieldTabENS.HomologousFldId; //同源字段Id
objFieldTabENT.TabNum = objFieldTabENS.TabNum; //表数
objFieldTabENT.InUse = objFieldTabENS.InUse; //是否在用
objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程Id
objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //修改者
objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
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
public static DataTable ToDataTable(List<clsFieldTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFieldTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFieldTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFieldTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFieldTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFieldTabEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFieldTabWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTabWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTabEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFieldTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFieldTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFieldTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFieldTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTabEN> GetObjLstCacheFromObjLst(List<clsFieldTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsFieldTabEN._CurrTabName, strPrjId);
List<clsFieldTabEN> arrFieldTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFieldTabObjLstCache = CacheHelper.Get<List<clsFieldTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFieldTabObjLstCache = CacheHelper.Get<List<clsFieldTabEN>>(strKey);
}
return arrFieldTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFieldTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFieldTab.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.FldName, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.Caption, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(conFieldTab.FldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(conFieldTab.FldInfo, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.IsNull, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.IsPrimaryKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.IsArchive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.IsOnlyOne, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.FldStateId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.HomologousFldId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.TabNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFieldTab.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab.IsNeedTransCode, Type.GetType("System.Boolean"));
foreach (clsFieldTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFieldTab.FldId] = objInFor[conFieldTab.FldId];
objDR[conFieldTab.FldName] = objInFor[conFieldTab.FldName];
objDR[conFieldTab.FldCnName] = objInFor[conFieldTab.FldCnName];
objDR[conFieldTab.Caption] = objInFor[conFieldTab.Caption];
objDR[conFieldTab.FieldTypeId] = objInFor[conFieldTab.FieldTypeId];
objDR[conFieldTab.DataTypeId] = objInFor[conFieldTab.DataTypeId];
objDR[conFieldTab.FldLength] = objInFor[conFieldTab.FldLength];
objDR[conFieldTab.FldPrecision] = objInFor[conFieldTab.FldPrecision];
objDR[conFieldTab.FldInfo] = objInFor[conFieldTab.FldInfo];
objDR[conFieldTab.IsNull] = objInFor[conFieldTab.IsNull];
objDR[conFieldTab.IsPrimaryKey] = objInFor[conFieldTab.IsPrimaryKey];
objDR[conFieldTab.IsIdentity] = objInFor[conFieldTab.IsIdentity];
objDR[conFieldTab.IsChecked] = objInFor[conFieldTab.IsChecked];
objDR[conFieldTab.IsArchive] = objInFor[conFieldTab.IsArchive];
objDR[conFieldTab.IsOnlyOne] = objInFor[conFieldTab.IsOnlyOne];
objDR[conFieldTab.MaxValue] = objInFor[conFieldTab.MaxValue];
objDR[conFieldTab.MinValue] = objInFor[conFieldTab.MinValue];
objDR[conFieldTab.DefaultValue] = objInFor[conFieldTab.DefaultValue];
objDR[conFieldTab.FldStateId] = objInFor[conFieldTab.FldStateId];
objDR[conFieldTab.HomologousFldId] = objInFor[conFieldTab.HomologousFldId];
objDR[conFieldTab.TabNum] = objInFor[conFieldTab.TabNum];
objDR[conFieldTab.InUse] = objInFor[conFieldTab.InUse];
objDR[conFieldTab.PrjId] = objInFor[conFieldTab.PrjId];
objDR[conFieldTab.UpdDate] = objInFor[conFieldTab.UpdDate];
objDR[conFieldTab.UpdUser] = objInFor[conFieldTab.UpdUser];
objDR[conFieldTab.Memo] = objInFor[conFieldTab.Memo];
objDR[conFieldTab.IsNeedTransCode] = objInFor[conFieldTab.IsNeedTransCode];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程字段(FieldTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FieldTab : clsCommFun4BL
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
clsFieldTabWApi.ReFreshThisCache();
}
}

}