
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab2BL
 表名:vFieldTab2(00050120)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvFieldTab2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab2EN GetObj(this K_FldId_vFieldTab2 myKey)
{
clsvFieldTab2EN objvFieldTab2EN = clsvFieldTab2BL.vFieldTab2DA.GetObjByFldId(myKey.Value);
return objvFieldTab2EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetDataTypeName(this clsvFieldTab2EN objvFieldTab2EN, string strDataTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeName, convFieldTab2.DataTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab2.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldId(this clsvFieldTab2EN objvFieldTab2EN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab2.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab2.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetPrjId(this clsvFieldTab2EN objvFieldTab2EN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab2.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab2.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab2.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetPrjName(this clsvFieldTab2EN objvFieldTab2EN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convFieldTab2.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convFieldTab2.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldName(this clsvFieldTab2EN objvFieldTab2EN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab2.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab2.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCaption(this clsvFieldTab2EN objvFieldTab2EN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab2.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab2.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetFldInfo(this clsvFieldTab2EN objvFieldTab2EN, string strFldInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldInfo, convFieldTab2.FldInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab2.FldInfo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetMaxValue(this clsvFieldTab2EN objvFieldTab2EN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMaxValue, convFieldTab2.MaxValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab2.MaxValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetMinValue(this clsvFieldTab2EN objvFieldTab2EN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMinValue, convFieldTab2.MinValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab2.MinValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetDefaultValue(this clsvFieldTab2EN objvFieldTab2EN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaultValue, convFieldTab2.DefaultValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab2.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetAppliedScope(this clsvFieldTab2EN objvFieldTab2EN, string strAppliedScope, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppliedScope, convFieldTab2.AppliedScope);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppliedScope, 10, convFieldTab2.AppliedScope);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convFieldTab2.CodeTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convFieldTab2.CodeTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabNameId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabNameId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convFieldTab2.CodeTabNameId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convFieldTab2.CodeTabNameId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetCodeTabCodeId(this clsvFieldTab2EN objvFieldTab2EN, string strCodeTabCodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convFieldTab2.CodeTabCodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convFieldTab2.CodeTabCodeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUpdDate(this clsvFieldTab2EN objvFieldTab2EN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab2.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUpdUser(this clsvFieldTab2EN objvFieldTab2EN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convFieldTab2.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab2.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab2EN SetUserName(this clsvFieldTab2EN objvFieldTab2EN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convFieldTab2.UserName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <param name = "objvFieldTab2ENT">目标对象</param>
 public static void CopyTo(this clsvFieldTab2EN objvFieldTab2ENS, clsvFieldTab2EN objvFieldTab2ENT)
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
 /// <param name = "objvFieldTab2ENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab2EN:objvFieldTab2ENT</returns>
 public static clsvFieldTab2EN CopyTo(this clsvFieldTab2EN objvFieldTab2ENS)
{
try
{
 clsvFieldTab2EN objvFieldTab2ENT = new clsvFieldTab2EN()
{
DataTypeName = objvFieldTab2ENS.DataTypeName, //数据类型名称
FldId = objvFieldTab2ENS.FldId, //字段Id
PrjId = objvFieldTab2ENS.PrjId, //工程Id
PrjName = objvFieldTab2ENS.PrjName, //工程名称
FldName = objvFieldTab2ENS.FldName, //字段名
Caption = objvFieldTab2ENS.Caption, //标题
FldLength = objvFieldTab2ENS.FldLength, //字段长度
FldInfo = objvFieldTab2ENS.FldInfo, //字段信息
IsNull = objvFieldTab2ENS.IsNull, //是否可空
IsPrimaryKey = objvFieldTab2ENS.IsPrimaryKey, //是否主键
IsIdentity = objvFieldTab2ENS.IsIdentity, //是否Identity
IsChecked = objvFieldTab2ENS.IsChecked, //是否核实
IsOnlyOne = objvFieldTab2ENS.IsOnlyOne, //是否唯一
MaxValue = objvFieldTab2ENS.MaxValue, //最大值
MinValue = objvFieldTab2ENS.MinValue, //最小值
DefaultValue = objvFieldTab2ENS.DefaultValue, //缺省值
IsNeedTransCode = objvFieldTab2ENS.IsNeedTransCode, //是否需要转换代码
AppliedScope = objvFieldTab2ENS.AppliedScope, //应用范围
CodeTabId = objvFieldTab2ENS.CodeTabId, //代码表Id
CodeTabNameId = objvFieldTab2ENS.CodeTabNameId, //代码_名Id
CodeTabCodeId = objvFieldTab2ENS.CodeTabCodeId, //代码Id
UpdDate = objvFieldTab2ENS.UpdDate, //修改日期
UpdUser = objvFieldTab2ENS.UpdUser, //修改者
UserName = objvFieldTab2ENS.UserName, //用户名
};
 return objvFieldTab2ENT;
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
public static void CheckProperty4Condition(this clsvFieldTab2EN objvFieldTab2EN)
{
 clsvFieldTab2BL.vFieldTab2DA.CheckProperty4Condition(objvFieldTab2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFieldTab2
{
public virtual bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFieldTab2(vFieldTab2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab2BL
{
public static RelatedActions_vFieldTab2 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFieldTab2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFieldTab2DA vFieldTab2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFieldTab2DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFieldTab2BL()
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
if (string.IsNullOrEmpty(clsvFieldTab2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab2EN._ConnectString);
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
public static DataTable GetDataTable_vFieldTab2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFieldTab2DA.GetDataTable_vFieldTab2(strWhereCond);
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
objDT = vFieldTab2DA.GetDataTable(strWhereCond);
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
objDT = vFieldTab2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFieldTab2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFieldTab2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFieldTab2DA.GetDataTable_Top(objTopPara);
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
objDT = vFieldTab2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFieldTab2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFieldTab2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFieldTab2EN> GetObjLstByFldIdLst(List<string> arrFldIdLst)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
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
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFieldTab2EN> GetObjLstByFldIdLstCache(List<string> arrFldIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrvFieldTab2ObjLst_Sel =
arrvFieldTab2ObjLstCache
.Where(x => arrFldIdLst.Contains(x.FldId));
return arrvFieldTab2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLst(string strWhereCond)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
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
public static List<clsvFieldTab2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFieldTab2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFieldTab2EN> GetSubObjLstCache(clsvFieldTab2EN objvFieldTab2Cond)
{
 string strPrjId = objvFieldTab2Cond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFieldTab2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab2EN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab2._AttributeName)
{
if (objvFieldTab2Cond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab2Cond[strFldName].ToString());
}
else
{
if (objvFieldTab2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab2Cond[strFldName]));
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
public static List<clsvFieldTab2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
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
public static List<clsvFieldTab2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
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
List<clsvFieldTab2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFieldTab2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFieldTab2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
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
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
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
public static List<clsvFieldTab2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFieldTab2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
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
public static List<clsvFieldTab2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFieldTab2EN> arrObjLst = new List<clsvFieldTab2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab2EN objvFieldTab2EN = new clsvFieldTab2EN();
try
{
objvFieldTab2EN.DataTypeName = objRow[convFieldTab2.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab2EN.FldId = objRow[convFieldTab2.FldId].ToString().Trim(); //字段Id
objvFieldTab2EN.PrjId = objRow[convFieldTab2.PrjId].ToString().Trim(); //工程Id
objvFieldTab2EN.PrjName = objRow[convFieldTab2.PrjName].ToString().Trim(); //工程名称
objvFieldTab2EN.FldName = objRow[convFieldTab2.FldName].ToString().Trim(); //字段名
objvFieldTab2EN.Caption = objRow[convFieldTab2.Caption].ToString().Trim(); //标题
objvFieldTab2EN.FldLength = Int32.Parse(objRow[convFieldTab2.FldLength].ToString().Trim()); //字段长度
objvFieldTab2EN.FldInfo = objRow[convFieldTab2.FldInfo].ToString().Trim(); //字段信息
objvFieldTab2EN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNull].ToString().Trim()); //是否可空
objvFieldTab2EN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab2EN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab2EN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsChecked].ToString().Trim()); //是否核实
objvFieldTab2EN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab2EN.MaxValue = objRow[convFieldTab2.MaxValue].ToString().Trim(); //最大值
objvFieldTab2EN.MinValue = objRow[convFieldTab2.MinValue].ToString().Trim(); //最小值
objvFieldTab2EN.DefaultValue = objRow[convFieldTab2.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab2EN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab2.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvFieldTab2EN.AppliedScope = objRow[convFieldTab2.AppliedScope].ToString().Trim(); //应用范围
objvFieldTab2EN.CodeTabId = objRow[convFieldTab2.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab2EN.CodeTabNameId = objRow[convFieldTab2.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab2EN.CodeTabCodeId = objRow[convFieldTab2.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab2.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab2EN.UpdDate = objRow[convFieldTab2.UpdDate] == DBNull.Value ? null : objRow[convFieldTab2.UpdDate].ToString().Trim(); //修改日期
objvFieldTab2EN.UpdUser = objRow[convFieldTab2.UpdUser].ToString().Trim(); //修改者
objvFieldTab2EN.UserName = objRow[convFieldTab2.UserName] == DBNull.Value ? null : objRow[convFieldTab2.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFieldTab2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFieldTab2(ref clsvFieldTab2EN objvFieldTab2EN)
{
bool bolResult = vFieldTab2DA.GetvFieldTab2(ref objvFieldTab2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab2EN GetObjByFldId(string strFldId)
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
clsvFieldTab2EN objvFieldTab2EN = vFieldTab2DA.GetObjByFldId(strFldId);
return objvFieldTab2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFieldTab2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFieldTab2EN objvFieldTab2EN = vFieldTab2DA.GetFirstObj(strWhereCond);
 return objvFieldTab2EN;
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
public static clsvFieldTab2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFieldTab2EN objvFieldTab2EN = vFieldTab2DA.GetObjByDataRow(objRow);
 return objvFieldTab2EN;
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
public static clsvFieldTab2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFieldTab2EN objvFieldTab2EN = vFieldTab2DA.GetObjByDataRow(objRow);
 return objvFieldTab2EN;
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
 /// <param name = "lstvFieldTab2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab2EN GetObjByFldIdFromList(string strFldId, List<clsvFieldTab2EN> lstvFieldTab2ObjLst)
{
foreach (clsvFieldTab2EN objvFieldTab2EN in lstvFieldTab2ObjLst)
{
if (objvFieldTab2EN.FldId == strFldId)
{
return objvFieldTab2EN;
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
 strFldId = new clsvFieldTab2DA().GetFirstID(strWhereCond);
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
 arrList = vFieldTab2DA.GetID(strWhereCond);
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
bool bolIsExist = vFieldTab2DA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFieldTab2DA.IsExist(strFldId);
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
 bolIsExist = clsvFieldTab2DA.IsExistTable();
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
 bolIsExist = vFieldTab2DA.IsExistTable(strTabName);
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
 /// <param name = "objvFieldTab2EN">源简化对象</param>
 public static void SetUpdFlag(clsvFieldTab2EN objvFieldTab2EN)
{
try
{
objvFieldTab2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFieldTab2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFieldTab2.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.DataTypeName = objvFieldTab2EN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convFieldTab2.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.FldId = objvFieldTab2EN.FldId; //字段Id
}
if (arrFldSet.Contains(convFieldTab2.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.PrjId = objvFieldTab2EN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFieldTab2.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.PrjName = objvFieldTab2EN.PrjName; //工程名称
}
if (arrFldSet.Contains(convFieldTab2.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.FldName = objvFieldTab2EN.FldName; //字段名
}
if (arrFldSet.Contains(convFieldTab2.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.Caption = objvFieldTab2EN.Caption; //标题
}
if (arrFldSet.Contains(convFieldTab2.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.FldLength = objvFieldTab2EN.FldLength; //字段长度
}
if (arrFldSet.Contains(convFieldTab2.FldInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.FldInfo = objvFieldTab2EN.FldInfo; //字段信息
}
if (arrFldSet.Contains(convFieldTab2.IsNull, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsNull = objvFieldTab2EN.IsNull; //是否可空
}
if (arrFldSet.Contains(convFieldTab2.IsPrimaryKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsPrimaryKey = objvFieldTab2EN.IsPrimaryKey; //是否主键
}
if (arrFldSet.Contains(convFieldTab2.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsIdentity = objvFieldTab2EN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(convFieldTab2.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsChecked = objvFieldTab2EN.IsChecked; //是否核实
}
if (arrFldSet.Contains(convFieldTab2.IsOnlyOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsOnlyOne = objvFieldTab2EN.IsOnlyOne; //是否唯一
}
if (arrFldSet.Contains(convFieldTab2.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.MaxValue = objvFieldTab2EN.MaxValue; //最大值
}
if (arrFldSet.Contains(convFieldTab2.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.MinValue = objvFieldTab2EN.MinValue; //最小值
}
if (arrFldSet.Contains(convFieldTab2.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.DefaultValue = objvFieldTab2EN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convFieldTab2.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.IsNeedTransCode = objvFieldTab2EN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(convFieldTab2.AppliedScope, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.AppliedScope = objvFieldTab2EN.AppliedScope; //应用范围
}
if (arrFldSet.Contains(convFieldTab2.CodeTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.CodeTabId = objvFieldTab2EN.CodeTabId == "[null]" ? null :  objvFieldTab2EN.CodeTabId; //代码表Id
}
if (arrFldSet.Contains(convFieldTab2.CodeTabNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.CodeTabNameId = objvFieldTab2EN.CodeTabNameId == "[null]" ? null :  objvFieldTab2EN.CodeTabNameId; //代码_名Id
}
if (arrFldSet.Contains(convFieldTab2.CodeTabCodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.CodeTabCodeId = objvFieldTab2EN.CodeTabCodeId == "[null]" ? null :  objvFieldTab2EN.CodeTabCodeId; //代码Id
}
if (arrFldSet.Contains(convFieldTab2.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.UpdDate = objvFieldTab2EN.UpdDate == "[null]" ? null :  objvFieldTab2EN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFieldTab2.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.UpdUser = objvFieldTab2EN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFieldTab2.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab2EN.UserName = objvFieldTab2EN.UserName == "[null]" ? null :  objvFieldTab2EN.UserName; //用户名
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
 /// <param name = "objvFieldTab2EN">源简化对象</param>
 public static void AccessFldValueNull(clsvFieldTab2EN objvFieldTab2EN)
{
try
{
if (objvFieldTab2EN.CodeTabId == "[null]") objvFieldTab2EN.CodeTabId = null; //代码表Id
if (objvFieldTab2EN.CodeTabNameId == "[null]") objvFieldTab2EN.CodeTabNameId = null; //代码_名Id
if (objvFieldTab2EN.CodeTabCodeId == "[null]") objvFieldTab2EN.CodeTabCodeId = null; //代码Id
if (objvFieldTab2EN.UpdDate == "[null]") objvFieldTab2EN.UpdDate = null; //修改日期
if (objvFieldTab2EN.UserName == "[null]") objvFieldTab2EN.UserName = null; //用户名
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
public static void CheckProperty4Condition(clsvFieldTab2EN objvFieldTab2EN)
{
 vFieldTab2DA.CheckProperty4Condition(objvFieldTab2EN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldId");
//if (arrvFieldTab2ObjLstCache == null)
//{
//arrvFieldTab2ObjLstCache = vFieldTab2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab2EN GetObjByFldIdCache(string strFldId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrvFieldTab2ObjLst_Sel =
arrvFieldTab2ObjLstCache
.Where(x=> x.FldId == strFldId 
);
if (arrvFieldTab2ObjLst_Sel.Count() == 0)
{
   clsvFieldTab2EN obj = clsvFieldTab2BL.GetObjByFldId(strFldId);
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
return arrvFieldTab2ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab2EN> GetAllvFieldTab2ObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = GetObjLstCache(strPrjId); 
return arrvFieldTab2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab2EN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFieldTab2EN> arrvFieldTab2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFieldTab2ObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFieldTab2EN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFieldTab2EN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFieldTab2EN._RefreshTimeLst.Count == 0) return "";
return clsvFieldTab2EN._RefreshTimeLst[clsvFieldTab2EN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strFldId, string strPrjId)
{
if (strInFldName != convFieldTab2.FldId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFieldTab2._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFieldTab2._AttributeName));
throw new Exception(strMsg);
}
var objvFieldTab2 = clsvFieldTab2BL.GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab2 == null) return "";
return objvFieldTab2[strOutFldName].ToString();
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
int intRecCount = clsvFieldTab2DA.GetRecCount(strTabName);
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
int intRecCount = clsvFieldTab2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFieldTab2DA.GetRecCount();
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
int intRecCount = clsvFieldTab2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFieldTab2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFieldTab2EN objvFieldTab2Cond)
{
 string strPrjId = objvFieldTab2Cond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFieldTab2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab2EN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab2._AttributeName)
{
if (objvFieldTab2Cond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab2Cond[strFldName].ToString());
}
else
{
if (objvFieldTab2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab2Cond[strFldName]));
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
 List<string> arrList = clsvFieldTab2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}