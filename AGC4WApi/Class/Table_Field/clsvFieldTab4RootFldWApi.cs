
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4RootFldWApi
 表名:vFieldTab4RootFld(00050406)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:04
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
public static class  clsvFieldTab4RootFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 100, convFieldTab4RootFld.TabName);
objvFieldTab4RootFldEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.TabName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.TabName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.TabName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intTabNum">表数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabNum(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, int intTabNum, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.TabNum) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.TabNum, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.TabNum] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab4RootFld.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab4RootFld.FldName);
objvFieldTab4RootFldEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldCnName">字段中文详名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldCnName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convFieldTab4RootFld.FldCnName);
objvFieldTab4RootFldEN.FldCnName = strFldCnName; //字段中文详名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldCnName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldCnName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldCnName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetCaption(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab4RootFld.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab4RootFld.Caption);
objvFieldTab4RootFldEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.Caption) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.Caption, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.Caption] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDataTypeId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab4RootFld.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab4RootFld.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab4RootFld.DataTypeId);
objvFieldTab4RootFldEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.DataTypeId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.DataTypeId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.DataTypeId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDataTypeName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab4RootFld.DataTypeName);
objvFieldTab4RootFldEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.DataTypeName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.DataTypeName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.DataTypeName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldLength(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convFieldTab4RootFld.FldLength);
objvFieldTab4RootFldEN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldLength) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldLength, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldLength] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intFldPrecision">精确度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldPrecision(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, int intFldPrecision, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldPrecision) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldPrecision, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldPrecision] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldInfo">字段信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldInfo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab4RootFld.FldInfo);
objvFieldTab4RootFldEN.FldInfo = strFldInfo; //字段信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldInfo) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldInfo, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldInfo] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNull">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetIsNull(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, convFieldTab4RootFld.IsNull);
objvFieldTab4RootFldEN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.IsNull) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.IsNull, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.IsNull] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetIsIdentity(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, bool bolIsIdentity, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.IsIdentity) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.IsIdentity, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.IsIdentity] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOnlyOne">是否唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetIsOnlyOne(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, bool bolIsOnlyOne, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.IsOnlyOne = bolIsOnlyOne; //是否唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.IsOnlyOne) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.IsOnlyOne, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.IsOnlyOne] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMaxValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab4RootFld.MaxValue);
objvFieldTab4RootFldEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.MaxValue) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.MaxValue, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.MaxValue] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMinValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab4RootFld.MinValue);
objvFieldTab4RootFldEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.MinValue) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.MinValue, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.MinValue] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDefaultValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab4RootFld.DefaultValue);
objvFieldTab4RootFldEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.DefaultValue) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.DefaultValue, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.DefaultValue] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldStateId">字段状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldStateId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, convFieldTab4RootFld.FldStateId);
clsCheckSql.CheckFieldLen(strFldStateId, 2, convFieldTab4RootFld.FldStateId);
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, convFieldTab4RootFld.FldStateId);
objvFieldTab4RootFldEN.FldStateId = strFldStateId; //字段状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldStateId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldStateId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldStateId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetmId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, long lngmId, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.mId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.mId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.mId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convFieldTab4RootFld.TabId);
objvFieldTab4RootFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.TabId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.TabId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.TabId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab4RootFld.FldId);
objvFieldTab4RootFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.FldId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.FldId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.FldId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPrimaryKey">是否主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetIsPrimaryKey(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, convFieldTab4RootFld.IsPrimaryKey);
objvFieldTab4RootFldEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.IsPrimaryKey) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.IsPrimaryKey, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.IsPrimaryKey] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRootFld">是否根字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetIsRootFld(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, bool bolIsRootFld, string strComparisonOp="")
	{
objvFieldTab4RootFldEN.IsRootFld = bolIsRootFld; //是否根字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.IsRootFld) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.IsRootFld, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.IsRootFld] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoot4TabId">主根表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRoot4TabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRoot4TabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoot4TabId, 8, convFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldForeignKey(strRoot4TabId, 8, convFieldTab4RootFld.Root4TabId);
objvFieldTab4RootFldEN.Root4TabId = strRoot4TabId; //主根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.Root4TabId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.Root4TabId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.Root4TabId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootFldId">根字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootFldId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootFldId, 8, convFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldForeignKey(strRootFldId, 8, convFieldTab4RootFld.RootFldId);
objvFieldTab4RootFldEN.RootFldId = strRootFldId; //根字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.RootFldId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.RootFldId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.RootFldId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootTabId">根表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootTabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootTabId, 8, convFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldForeignKey(strRootTabId, 8, convFieldTab4RootFld.RootTabId);
objvFieldTab4RootFldEN.RootTabId = strRootTabId; //根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.RootTabId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.RootTabId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.RootTabId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetPrjId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab4RootFld.PrjId);
objvFieldTab4RootFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.PrjId) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.PrjId, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.PrjId] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetUpdUser(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab4RootFld.UpdUser);
objvFieldTab4RootFldEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.UpdUser) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.UpdUser, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.UpdUser] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetUpdDate(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab4RootFld.UpdDate);
objvFieldTab4RootFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.UpdDate) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.UpdDate, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.UpdDate] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMemo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab4RootFld.Memo);
objvFieldTab4RootFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.Memo) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.Memo, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.Memo] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootFldName">RootFldName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootFldName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootFldName, 50, convFieldTab4RootFld.RootFldName);
objvFieldTab4RootFldEN.RootFldName = strRootFldName; //RootFldName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.RootFldName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.RootFldName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.RootFldName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootTabName">根表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootTabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootTabName, 100, convFieldTab4RootFld.RootTabName);
objvFieldTab4RootFldEN.RootTabName = strRootTabName; //根表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.RootTabName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.RootTabName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.RootTabName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoot4TabName">主根表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRoot4TabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRoot4TabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoot4TabName, 100, convFieldTab4RootFld.Root4TabName);
objvFieldTab4RootFldEN.Root4TabName = strRoot4TabName; //主根表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(convFieldTab4RootFld.Root4TabName) == false)
{
objvFieldTab4RootFldEN.dicFldComparisonOp.Add(convFieldTab4RootFld.Root4TabName, strComparisonOp);
}
else
{
objvFieldTab4RootFldEN.dicFldComparisonOp[convFieldTab4RootFld.Root4TabName] = strComparisonOp;
}
}
return objvFieldTab4RootFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab4RootFldEN objvFieldTab4RootFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.TabName) == true)
{
string strComparisonOpTabName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.TabName, objvFieldTab4RootFldCond.TabName, strComparisonOpTabName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.TabNum) == true)
{
string strComparisonOpTabNum = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab4RootFld.TabNum, objvFieldTab4RootFldCond.TabNum, strComparisonOpTabNum);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.FldName, objvFieldTab4RootFldCond.FldName, strComparisonOpFldName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldCnName) == true)
{
string strComparisonOpFldCnName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.FldCnName, objvFieldTab4RootFldCond.FldCnName, strComparisonOpFldCnName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.Caption) == true)
{
string strComparisonOpCaption = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.Caption, objvFieldTab4RootFldCond.Caption, strComparisonOpCaption);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.DataTypeId, objvFieldTab4RootFldCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.DataTypeName, objvFieldTab4RootFldCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldLength) == true)
{
string strComparisonOpFldLength = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab4RootFld.FldLength, objvFieldTab4RootFldCond.FldLength, strComparisonOpFldLength);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab4RootFld.FldPrecision, objvFieldTab4RootFldCond.FldPrecision, strComparisonOpFldPrecision);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldInfo) == true)
{
string strComparisonOpFldInfo = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.FldInfo, objvFieldTab4RootFldCond.FldInfo, strComparisonOpFldInfo);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.IsNull) == true)
{
if (objvFieldTab4RootFldCond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab4RootFld.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab4RootFld.IsNull);
}
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.IsIdentity) == true)
{
if (objvFieldTab4RootFldCond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab4RootFld.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab4RootFld.IsIdentity);
}
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.IsOnlyOne) == true)
{
if (objvFieldTab4RootFldCond.IsOnlyOne == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab4RootFld.IsOnlyOne);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab4RootFld.IsOnlyOne);
}
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.MaxValue) == true)
{
string strComparisonOpMaxValue = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.MaxValue, objvFieldTab4RootFldCond.MaxValue, strComparisonOpMaxValue);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.MinValue) == true)
{
string strComparisonOpMinValue = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.MinValue, objvFieldTab4RootFldCond.MinValue, strComparisonOpMinValue);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.DefaultValue, objvFieldTab4RootFldCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldStateId) == true)
{
string strComparisonOpFldStateId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.FldStateId, objvFieldTab4RootFldCond.FldStateId, strComparisonOpFldStateId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.mId) == true)
{
string strComparisonOpmId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab4RootFld.mId, objvFieldTab4RootFldCond.mId, strComparisonOpmId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.TabId) == true)
{
string strComparisonOpTabId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.TabId, objvFieldTab4RootFldCond.TabId, strComparisonOpTabId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.FldId, objvFieldTab4RootFldCond.FldId, strComparisonOpFldId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.IsPrimaryKey) == true)
{
if (objvFieldTab4RootFldCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab4RootFld.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab4RootFld.IsPrimaryKey);
}
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.IsRootFld) == true)
{
if (objvFieldTab4RootFldCond.IsRootFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab4RootFld.IsRootFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab4RootFld.IsRootFld);
}
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.Root4TabId) == true)
{
string strComparisonOpRoot4TabId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.Root4TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.Root4TabId, objvFieldTab4RootFldCond.Root4TabId, strComparisonOpRoot4TabId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.RootFldId) == true)
{
string strComparisonOpRootFldId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.RootFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.RootFldId, objvFieldTab4RootFldCond.RootFldId, strComparisonOpRootFldId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.RootTabId) == true)
{
string strComparisonOpRootTabId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.RootTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.RootTabId, objvFieldTab4RootFldCond.RootTabId, strComparisonOpRootTabId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.PrjId, objvFieldTab4RootFldCond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.UpdUser, objvFieldTab4RootFldCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.UpdDate, objvFieldTab4RootFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.Memo) == true)
{
string strComparisonOpMemo = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.Memo, objvFieldTab4RootFldCond.Memo, strComparisonOpMemo);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.RootFldName) == true)
{
string strComparisonOpRootFldName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.RootFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.RootFldName, objvFieldTab4RootFldCond.RootFldName, strComparisonOpRootFldName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.RootTabName) == true)
{
string strComparisonOpRootTabName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.RootTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.RootTabName, objvFieldTab4RootFldCond.RootTabName, strComparisonOpRootTabName);
}
if (objvFieldTab4RootFldCond.IsUpdated(convFieldTab4RootFld.Root4TabName) == true)
{
string strComparisonOpRoot4TabName = objvFieldTab4RootFldCond.dicFldComparisonOp[convFieldTab4RootFld.Root4TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4RootFld.Root4TabName, objvFieldTab4RootFldCond.Root4TabName, strComparisonOpRoot4TabName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程字段4RootFld(vFieldTab4RootFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab4RootFldWApi
{
private static readonly string mstrApiControllerName = "vFieldTab4RootFldApi";

 public clsvFieldTab4RootFldWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4RootFldEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFieldTab4RootFldEN objvFieldTab4RootFldEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFieldTab4RootFldEN = JsonConvert.DeserializeObject<clsvFieldTab4RootFldEN>(strJson);
return objvFieldTab4RootFldEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvFieldTab4RootFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTab4RootFldEN objvFieldTab4RootFldEN;
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
objvFieldTab4RootFldEN = JsonConvert.DeserializeObject<clsvFieldTab4RootFldEN>(strJson);
return objvFieldTab4RootFldEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4RootFldEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel =
from objvFieldTab4RootFldEN in arrvFieldTab4RootFldObjLstCache
where objvFieldTab4RootFldEN.mId == lngmId 
select objvFieldTab4RootFldEN;
if (arrvFieldTab4RootFldObjLst_Sel.Count() == 0)
{
   clsvFieldTab4RootFldEN obj = clsvFieldTab4RootFldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTab4RootFldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFieldTab4RootFldEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel =
from objvFieldTab4RootFldEN in arrvFieldTab4RootFldObjLstCache
where arrMId.Contains(objvFieldTab4RootFldEN.mId)
select objvFieldTab4RootFldEN;
return arrvFieldTab4RootFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab4RootFldEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvFieldTab4RootFldENS">源对象</param>
 /// <param name = "objvFieldTab4RootFldENT">目标对象</param>
 public static void CopyTo(clsvFieldTab4RootFldEN objvFieldTab4RootFldENS, clsvFieldTab4RootFldEN objvFieldTab4RootFldENT)
{
try
{
objvFieldTab4RootFldENT.TabName = objvFieldTab4RootFldENS.TabName; //表名
objvFieldTab4RootFldENT.TabNum = objvFieldTab4RootFldENS.TabNum; //表数
objvFieldTab4RootFldENT.FldName = objvFieldTab4RootFldENS.FldName; //字段名
objvFieldTab4RootFldENT.FldCnName = objvFieldTab4RootFldENS.FldCnName; //字段中文详名
objvFieldTab4RootFldENT.Caption = objvFieldTab4RootFldENS.Caption; //标题
objvFieldTab4RootFldENT.DataTypeId = objvFieldTab4RootFldENS.DataTypeId; //数据类型Id
objvFieldTab4RootFldENT.DataTypeName = objvFieldTab4RootFldENS.DataTypeName; //数据类型名称
objvFieldTab4RootFldENT.FldLength = objvFieldTab4RootFldENS.FldLength; //字段长度
objvFieldTab4RootFldENT.FldPrecision = objvFieldTab4RootFldENS.FldPrecision; //精确度
objvFieldTab4RootFldENT.FldInfo = objvFieldTab4RootFldENS.FldInfo; //字段信息
objvFieldTab4RootFldENT.IsNull = objvFieldTab4RootFldENS.IsNull; //是否可空
objvFieldTab4RootFldENT.IsIdentity = objvFieldTab4RootFldENS.IsIdentity; //是否Identity
objvFieldTab4RootFldENT.IsOnlyOne = objvFieldTab4RootFldENS.IsOnlyOne; //是否唯一
objvFieldTab4RootFldENT.MaxValue = objvFieldTab4RootFldENS.MaxValue; //最大值
objvFieldTab4RootFldENT.MinValue = objvFieldTab4RootFldENS.MinValue; //最小值
objvFieldTab4RootFldENT.DefaultValue = objvFieldTab4RootFldENS.DefaultValue; //缺省值
objvFieldTab4RootFldENT.FldStateId = objvFieldTab4RootFldENS.FldStateId; //字段状态Id
objvFieldTab4RootFldENT.mId = objvFieldTab4RootFldENS.mId; //mId
objvFieldTab4RootFldENT.TabId = objvFieldTab4RootFldENS.TabId; //表ID
objvFieldTab4RootFldENT.FldId = objvFieldTab4RootFldENS.FldId; //字段Id
objvFieldTab4RootFldENT.IsPrimaryKey = objvFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objvFieldTab4RootFldENT.IsRootFld = objvFieldTab4RootFldENS.IsRootFld; //是否根字段
objvFieldTab4RootFldENT.Root4TabId = objvFieldTab4RootFldENS.Root4TabId; //主根表Id
objvFieldTab4RootFldENT.RootFldId = objvFieldTab4RootFldENS.RootFldId; //根字段Id
objvFieldTab4RootFldENT.RootTabId = objvFieldTab4RootFldENS.RootTabId; //根表Id
objvFieldTab4RootFldENT.PrjId = objvFieldTab4RootFldENS.PrjId; //工程Id
objvFieldTab4RootFldENT.UpdUser = objvFieldTab4RootFldENS.UpdUser; //修改者
objvFieldTab4RootFldENT.UpdDate = objvFieldTab4RootFldENS.UpdDate; //修改日期
objvFieldTab4RootFldENT.Memo = objvFieldTab4RootFldENS.Memo; //说明
objvFieldTab4RootFldENT.RootFldName = objvFieldTab4RootFldENS.RootFldName; //RootFldName
objvFieldTab4RootFldENT.RootTabName = objvFieldTab4RootFldENS.RootTabName; //根表
objvFieldTab4RootFldENT.Root4TabName = objvFieldTab4RootFldENS.Root4TabName; //主根表
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
public static DataTable ToDataTable(List<clsvFieldTab4RootFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTab4RootFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTab4RootFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTab4RootFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTab4RootFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTab4RootFldEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4RootFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4RootFldWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4RootFldWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4RootFldWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTab4RootFldEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTab4RootFldEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFieldTab4RootFld.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvFieldTab4RootFldEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab4RootFldWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab4RootFldWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFieldTab4RootFldObjLstCache = CacheHelper.Get<List<clsvFieldTab4RootFldEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFieldTab4RootFldObjLstCache = CacheHelper.Get<List<clsvFieldTab4RootFldEN>>(strKey);
}
return arrvFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTab4RootFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab4RootFld.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.TabNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab4RootFld.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.FldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab4RootFld.FldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab4RootFld.FldInfo, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.IsNull, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab4RootFld.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab4RootFld.IsOnlyOne, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab4RootFld.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.FldStateId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFieldTab4RootFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.IsPrimaryKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab4RootFld.IsRootFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab4RootFld.Root4TabId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.RootFldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.RootTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.RootFldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.RootTabName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab4RootFld.Root4TabName, Type.GetType("System.String"));
foreach (clsvFieldTab4RootFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab4RootFld.TabName] = objInFor[convFieldTab4RootFld.TabName];
objDR[convFieldTab4RootFld.TabNum] = objInFor[convFieldTab4RootFld.TabNum];
objDR[convFieldTab4RootFld.FldName] = objInFor[convFieldTab4RootFld.FldName];
objDR[convFieldTab4RootFld.FldCnName] = objInFor[convFieldTab4RootFld.FldCnName];
objDR[convFieldTab4RootFld.Caption] = objInFor[convFieldTab4RootFld.Caption];
objDR[convFieldTab4RootFld.DataTypeId] = objInFor[convFieldTab4RootFld.DataTypeId];
objDR[convFieldTab4RootFld.DataTypeName] = objInFor[convFieldTab4RootFld.DataTypeName];
objDR[convFieldTab4RootFld.FldLength] = objInFor[convFieldTab4RootFld.FldLength];
objDR[convFieldTab4RootFld.FldPrecision] = objInFor[convFieldTab4RootFld.FldPrecision];
objDR[convFieldTab4RootFld.FldInfo] = objInFor[convFieldTab4RootFld.FldInfo];
objDR[convFieldTab4RootFld.IsNull] = objInFor[convFieldTab4RootFld.IsNull];
objDR[convFieldTab4RootFld.IsIdentity] = objInFor[convFieldTab4RootFld.IsIdentity];
objDR[convFieldTab4RootFld.IsOnlyOne] = objInFor[convFieldTab4RootFld.IsOnlyOne];
objDR[convFieldTab4RootFld.MaxValue] = objInFor[convFieldTab4RootFld.MaxValue];
objDR[convFieldTab4RootFld.MinValue] = objInFor[convFieldTab4RootFld.MinValue];
objDR[convFieldTab4RootFld.DefaultValue] = objInFor[convFieldTab4RootFld.DefaultValue];
objDR[convFieldTab4RootFld.FldStateId] = objInFor[convFieldTab4RootFld.FldStateId];
objDR[convFieldTab4RootFld.mId] = objInFor[convFieldTab4RootFld.mId];
objDR[convFieldTab4RootFld.TabId] = objInFor[convFieldTab4RootFld.TabId];
objDR[convFieldTab4RootFld.FldId] = objInFor[convFieldTab4RootFld.FldId];
objDR[convFieldTab4RootFld.IsPrimaryKey] = objInFor[convFieldTab4RootFld.IsPrimaryKey];
objDR[convFieldTab4RootFld.IsRootFld] = objInFor[convFieldTab4RootFld.IsRootFld];
objDR[convFieldTab4RootFld.Root4TabId] = objInFor[convFieldTab4RootFld.Root4TabId];
objDR[convFieldTab4RootFld.RootFldId] = objInFor[convFieldTab4RootFld.RootFldId];
objDR[convFieldTab4RootFld.RootTabId] = objInFor[convFieldTab4RootFld.RootTabId];
objDR[convFieldTab4RootFld.PrjId] = objInFor[convFieldTab4RootFld.PrjId];
objDR[convFieldTab4RootFld.UpdUser] = objInFor[convFieldTab4RootFld.UpdUser];
objDR[convFieldTab4RootFld.UpdDate] = objInFor[convFieldTab4RootFld.UpdDate];
objDR[convFieldTab4RootFld.Memo] = objInFor[convFieldTab4RootFld.Memo];
objDR[convFieldTab4RootFld.RootFldName] = objInFor[convFieldTab4RootFld.RootFldName];
objDR[convFieldTab4RootFld.RootTabName] = objInFor[convFieldTab4RootFld.RootTabName];
objDR[convFieldTab4RootFld.Root4TabName] = objInFor[convFieldTab4RootFld.Root4TabName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}