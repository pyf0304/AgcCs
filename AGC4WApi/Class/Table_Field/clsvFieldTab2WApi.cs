
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2WApi
 表名:vFieldTab2(00050120)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:29
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
public static class  clsvFieldTab2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeName">数据类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetDataTypeName(this clsvFieldTab2EN objvFieldTab2EN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convFieldTab2.DataTypeName);
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab2.DataTypeName);
objvFieldTab2EN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.DataTypeName) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.DataTypeName, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.DataTypeName] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldId(this clsvFieldTab2EN objvFieldTab2EN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab2.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab2.FldId);
objvFieldTab2EN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.FldId) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.FldId, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.FldId] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetPrjId(this clsvFieldTab2EN objvFieldTab2EN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab2.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab2.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab2.PrjId);
objvFieldTab2EN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.PrjId) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.PrjId, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.PrjId] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetPrjName(this clsvFieldTab2EN objvFieldTab2EN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFieldTab2.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convFieldTab2.PrjName);
objvFieldTab2EN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.PrjName) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.PrjName, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.PrjName] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldName(this clsvFieldTab2EN objvFieldTab2EN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab2.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab2.FldName);
objvFieldTab2EN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.FldName) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.FldName, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.FldName] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCaption(this clsvFieldTab2EN objvFieldTab2EN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab2.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab2.Caption);
objvFieldTab2EN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.Caption) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.Caption, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.Caption] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldLength(this clsvFieldTab2EN objvFieldTab2EN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convFieldTab2.FldLength);
objvFieldTab2EN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.FldLength) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.FldLength, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.FldLength] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldInfo">字段信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldInfo(this clsvFieldTab2EN objvFieldTab2EN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldInfo, convFieldTab2.FldInfo);
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab2.FldInfo);
objvFieldTab2EN.FldInfo = strFldInfo; //字段信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.FldInfo) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.FldInfo, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.FldInfo] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNull">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsNull(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsNull, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNull, convFieldTab2.IsNull);
objvFieldTab2EN.IsNull = bolIsNull; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsNull) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsNull, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsNull] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPrimaryKey">是否主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsPrimaryKey(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, convFieldTab2.IsPrimaryKey);
objvFieldTab2EN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsPrimaryKey) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsPrimaryKey, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsPrimaryKey] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsIdentity">是否Identity</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsIdentity(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsIdentity, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsIdentity, convFieldTab2.IsIdentity);
objvFieldTab2EN.IsIdentity = bolIsIdentity; //是否Identity
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsIdentity) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsIdentity, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsIdentity] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsChecked">是否核实</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsChecked(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsChecked, string strComparisonOp="")
	{
objvFieldTab2EN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsChecked) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsChecked, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsChecked] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsOnlyOne">是否唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsOnlyOne(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsOnlyOne, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsOnlyOne, convFieldTab2.IsOnlyOne);
objvFieldTab2EN.IsOnlyOne = bolIsOnlyOne; //是否唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsOnlyOne) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsOnlyOne, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsOnlyOne] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetMaxValue(this clsvFieldTab2EN objvFieldTab2EN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convFieldTab2.MaxValue);
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab2.MaxValue);
objvFieldTab2EN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.MaxValue) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.MaxValue, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.MaxValue] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetMinValue(this clsvFieldTab2EN objvFieldTab2EN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convFieldTab2.MinValue);
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab2.MinValue);
objvFieldTab2EN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.MinValue) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.MinValue, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.MinValue] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetDefaultValue(this clsvFieldTab2EN objvFieldTab2EN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convFieldTab2.DefaultValue);
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab2.DefaultValue);
objvFieldTab2EN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.DefaultValue) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.DefaultValue, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.DefaultValue] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedTransCode">是否需要转换代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetIsNeedTransCode(this clsvFieldTab2EN objvFieldTab2EN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, convFieldTab2.IsNeedTransCode);
objvFieldTab2EN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.IsNeedTransCode) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.IsNeedTransCode, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.IsNeedTransCode] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strAppliedScope">应用范围</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetAppliedScope(this clsvFieldTab2EN objvFieldTab2EN, string strAppliedScope, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppliedScope, convFieldTab2.AppliedScope);
clsCheckSql.CheckFieldLen(strAppliedScope, 10, convFieldTab2.AppliedScope);
objvFieldTab2EN.AppliedScope = strAppliedScope; //应用范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.AppliedScope) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.AppliedScope, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.AppliedScope] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabId">代码表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convFieldTab2.CodeTabId);
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convFieldTab2.CodeTabId);
objvFieldTab2EN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.CodeTabId) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.CodeTabId, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.CodeTabId] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabNameId">代码_名Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabNameId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convFieldTab2.CodeTabNameId);
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convFieldTab2.CodeTabNameId);
objvFieldTab2EN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.CodeTabNameId) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.CodeTabNameId, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.CodeTabNameId] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCodeId">代码Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabCodeId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabCodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convFieldTab2.CodeTabCodeId);
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convFieldTab2.CodeTabCodeId);
objvFieldTab2EN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.CodeTabCodeId) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.CodeTabCodeId, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.CodeTabCodeId] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUpdDate(this clsvFieldTab2EN objvFieldTab2EN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab2.UpdDate);
objvFieldTab2EN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.UpdDate) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.UpdDate, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.UpdDate] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUpdUser(this clsvFieldTab2EN objvFieldTab2EN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFieldTab2.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab2.UpdUser);
objvFieldTab2EN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.UpdUser) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.UpdUser, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.UpdUser] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUserName(this clsvFieldTab2EN objvFieldTab2EN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 30, convFieldTab2.UserName);
objvFieldTab2EN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab2EN.dicFldComparisonOp.ContainsKey(convFieldTab2.UserName) == false)
{
objvFieldTab2EN.dicFldComparisonOp.Add(convFieldTab2.UserName, strComparisonOp);
}
else
{
objvFieldTab2EN.dicFldComparisonOp[convFieldTab2.UserName] = strComparisonOp;
}
}
return objvFieldTab2EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab2EN objvFieldTab2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.DataTypeName, objvFieldTab2Cond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.FldId, objvFieldTab2Cond.FldId, strComparisonOpFldId);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.PrjId, objvFieldTab2Cond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.PrjName) == true)
{
string strComparisonOpPrjName = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.PrjName, objvFieldTab2Cond.PrjName, strComparisonOpPrjName);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.FldName, objvFieldTab2Cond.FldName, strComparisonOpFldName);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.Caption) == true)
{
string strComparisonOpCaption = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.Caption, objvFieldTab2Cond.Caption, strComparisonOpCaption);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.FldLength) == true)
{
string strComparisonOpFldLength = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab2.FldLength, objvFieldTab2Cond.FldLength, strComparisonOpFldLength);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.FldInfo) == true)
{
string strComparisonOpFldInfo = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.FldInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.FldInfo, objvFieldTab2Cond.FldInfo, strComparisonOpFldInfo);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsNull) == true)
{
if (objvFieldTab2Cond.IsNull == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsNull);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsNull);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsPrimaryKey) == true)
{
if (objvFieldTab2Cond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsPrimaryKey);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsIdentity) == true)
{
if (objvFieldTab2Cond.IsIdentity == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsIdentity);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsIdentity);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsChecked) == true)
{
if (objvFieldTab2Cond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsChecked);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsOnlyOne) == true)
{
if (objvFieldTab2Cond.IsOnlyOne == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsOnlyOne);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsOnlyOne);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.MaxValue) == true)
{
string strComparisonOpMaxValue = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.MaxValue, objvFieldTab2Cond.MaxValue, strComparisonOpMaxValue);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.MinValue) == true)
{
string strComparisonOpMinValue = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.MinValue, objvFieldTab2Cond.MinValue, strComparisonOpMinValue);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.DefaultValue, objvFieldTab2Cond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.IsNeedTransCode) == true)
{
if (objvFieldTab2Cond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFieldTab2.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFieldTab2.IsNeedTransCode);
}
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.AppliedScope) == true)
{
string strComparisonOpAppliedScope = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.AppliedScope];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.AppliedScope, objvFieldTab2Cond.AppliedScope, strComparisonOpAppliedScope);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.CodeTabId, objvFieldTab2Cond.CodeTabId, strComparisonOpCodeTabId);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.CodeTabNameId, objvFieldTab2Cond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.CodeTabCodeId, objvFieldTab2Cond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.UpdDate, objvFieldTab2Cond.UpdDate, strComparisonOpUpdDate);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.UpdUser, objvFieldTab2Cond.UpdUser, strComparisonOpUpdUser);
}
if (objvFieldTab2Cond.IsUpdated(convFieldTab2.UserName) == true)
{
string strComparisonOpUserName = objvFieldTab2Cond.dicFldComparisonOp[convFieldTab2.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab2.UserName, objvFieldTab2Cond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFieldTab2(vFieldTab2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab2WApi
{
private static readonly string mstrApiControllerName = "vFieldTab2Api";

 public clsvFieldTab2WApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab2EN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsvFieldTab2EN objvFieldTab2EN;
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
objvFieldTab2EN = JsonConvert.DeserializeObject<clsvFieldTab2EN>(strJson);
return objvFieldTab2EN;
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
public static clsvFieldTab2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTab2EN objvFieldTab2EN;
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
objvFieldTab2EN = JsonConvert.DeserializeObject<clsvFieldTab2EN>(strJson);
return objvFieldTab2EN;
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
public static clsvFieldTab2EN GetObjByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrvFieldTab2ObjLst_Sel =
from objvFieldTab2EN in arrvFieldTab2ObjLstCache
where objvFieldTab2EN.FldId == strFldId 
select objvFieldTab2EN;
if (arrvFieldTab2ObjLst_Sel.Count() == 0)
{
   clsvFieldTab2EN obj = clsvFieldTab2WApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTab2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
public static List<clsvFieldTab2EN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
public static IEnumerable<clsvFieldTab2EN> GetObjLstByFldIdLstCache(List<string> arrFldId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrvFieldTab2ObjLst_Sel =
from objvFieldTab2EN in arrvFieldTab2ObjLstCache
where arrFldId.Contains(objvFieldTab2EN.FldId)
select objvFieldTab2EN;
return arrvFieldTab2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
public static List<clsvFieldTab2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
public static List<clsvFieldTab2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
public static List<clsvFieldTab2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTab2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab2EN>>(strJson);
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
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <param name = "objvFieldTab2ENT">目标对象</param>
 public static void CopyTo(clsvFieldTab2EN objvFieldTab2ENS, clsvFieldTab2EN objvFieldTab2ENT)
{
try
{
objvFieldTab2ENT.DataTypeName = objvFieldTab2ENS.DataTypeName; //数据类型名称
objvFieldTab2ENT.FldId = objvFieldTab2ENS.FldId; //字段Id
objvFieldTab2ENT.PrjId = objvFieldTab2ENS.PrjId; //工程Id
objvFieldTab2ENT.PrjName = objvFieldTab2ENS.PrjName; //工程名称
objvFieldTab2ENT.FldName = objvFieldTab2ENS.FldName; //字段名
objvFieldTab2ENT.Caption = objvFieldTab2ENS.Caption; //标题
objvFieldTab2ENT.FldLength = objvFieldTab2ENS.FldLength; //字段长度
objvFieldTab2ENT.FldInfo = objvFieldTab2ENS.FldInfo; //字段信息
objvFieldTab2ENT.IsNull = objvFieldTab2ENS.IsNull; //是否可空
objvFieldTab2ENT.IsPrimaryKey = objvFieldTab2ENS.IsPrimaryKey; //是否主键
objvFieldTab2ENT.IsIdentity = objvFieldTab2ENS.IsIdentity; //是否Identity
objvFieldTab2ENT.IsChecked = objvFieldTab2ENS.IsChecked; //是否核实
objvFieldTab2ENT.IsOnlyOne = objvFieldTab2ENS.IsOnlyOne; //是否唯一
objvFieldTab2ENT.MaxValue = objvFieldTab2ENS.MaxValue; //最大值
objvFieldTab2ENT.MinValue = objvFieldTab2ENS.MinValue; //最小值
objvFieldTab2ENT.DefaultValue = objvFieldTab2ENS.DefaultValue; //缺省值
objvFieldTab2ENT.IsNeedTransCode = objvFieldTab2ENS.IsNeedTransCode; //是否需要转换代码
objvFieldTab2ENT.AppliedScope = objvFieldTab2ENS.AppliedScope; //应用范围
objvFieldTab2ENT.CodeTabId = objvFieldTab2ENS.CodeTabId; //代码表Id
objvFieldTab2ENT.CodeTabNameId = objvFieldTab2ENS.CodeTabNameId; //代码_名Id
objvFieldTab2ENT.CodeTabCodeId = objvFieldTab2ENS.CodeTabCodeId; //代码Id
objvFieldTab2ENT.UpdDate = objvFieldTab2ENS.UpdDate; //修改日期
objvFieldTab2ENT.UpdUser = objvFieldTab2ENS.UpdUser; //修改者
objvFieldTab2ENT.UserName = objvFieldTab2ENS.UserName; //用户名
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
public static DataTable ToDataTable(List<clsvFieldTab2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTab2EN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTab2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTab2EN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTab2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTab2EN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab2WApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab2WApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
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
public static List<clsvFieldTab2EN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab2WApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab2WApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTab2EN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTab2EN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFieldTab2.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTab2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvFieldTab2EN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab2WApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab2WApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFieldTab2ObjLstCache = CacheHelper.Get<List<clsvFieldTab2EN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFieldTab2ObjLstCache = CacheHelper.Get<List<clsvFieldTab2EN>>(strKey);
}
return arrvFieldTab2ObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTab2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab2.DataTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab2.FldInfo, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.IsNull, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.IsPrimaryKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.IsIdentity, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.IsOnlyOne, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.IsNeedTransCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFieldTab2.AppliedScope, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.CodeTabId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.CodeTabNameId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.CodeTabCodeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab2.UserName, Type.GetType("System.String"));
foreach (clsvFieldTab2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab2.DataTypeName] = objInFor[convFieldTab2.DataTypeName];
objDR[convFieldTab2.FldId] = objInFor[convFieldTab2.FldId];
objDR[convFieldTab2.PrjId] = objInFor[convFieldTab2.PrjId];
objDR[convFieldTab2.PrjName] = objInFor[convFieldTab2.PrjName];
objDR[convFieldTab2.FldName] = objInFor[convFieldTab2.FldName];
objDR[convFieldTab2.Caption] = objInFor[convFieldTab2.Caption];
objDR[convFieldTab2.FldLength] = objInFor[convFieldTab2.FldLength];
objDR[convFieldTab2.FldInfo] = objInFor[convFieldTab2.FldInfo];
objDR[convFieldTab2.IsNull] = objInFor[convFieldTab2.IsNull];
objDR[convFieldTab2.IsPrimaryKey] = objInFor[convFieldTab2.IsPrimaryKey];
objDR[convFieldTab2.IsIdentity] = objInFor[convFieldTab2.IsIdentity];
objDR[convFieldTab2.IsChecked] = objInFor[convFieldTab2.IsChecked];
objDR[convFieldTab2.IsOnlyOne] = objInFor[convFieldTab2.IsOnlyOne];
objDR[convFieldTab2.MaxValue] = objInFor[convFieldTab2.MaxValue];
objDR[convFieldTab2.MinValue] = objInFor[convFieldTab2.MinValue];
objDR[convFieldTab2.DefaultValue] = objInFor[convFieldTab2.DefaultValue];
objDR[convFieldTab2.IsNeedTransCode] = objInFor[convFieldTab2.IsNeedTransCode];
objDR[convFieldTab2.AppliedScope] = objInFor[convFieldTab2.AppliedScope];
objDR[convFieldTab2.CodeTabId] = objInFor[convFieldTab2.CodeTabId];
objDR[convFieldTab2.CodeTabNameId] = objInFor[convFieldTab2.CodeTabNameId];
objDR[convFieldTab2.CodeTabCodeId] = objInFor[convFieldTab2.CodeTabCodeId];
objDR[convFieldTab2.UpdDate] = objInFor[convFieldTab2.UpdDate];
objDR[convFieldTab2.UpdUser] = objInFor[convFieldTab2.UpdUser];
objDR[convFieldTab2.UserName] = objInFor[convFieldTab2.UserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}