
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4RootFldBL
 表名:vFieldTab4RootFld(00050406)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:10
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
public static class  clsvFieldTab4RootFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4RootFldEN GetObj(this K_mId_vFieldTab4RootFld myKey)
{
clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = clsvFieldTab4RootFldBL.vFieldTab4RootFldDA.GetObjBymId(myKey.Value);
return objvFieldTab4RootFldEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convFieldTab4RootFld.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabNum(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, int? intTabNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab4RootFld.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab4RootFld.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldCnName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldCnName, 200, convFieldTab4RootFld.FldCnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetCaption(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab4RootFld.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab4RootFld.Caption);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDataTypeId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab4RootFld.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab4RootFld.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab4RootFld.DataTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDataTypeName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convFieldTab4RootFld.DataTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldPrecision(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, int? intFldPrecision, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldInfo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldInfo, 100, convFieldTab4RootFld.FldInfo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMaxValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMaxValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, convFieldTab4RootFld.MaxValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMinValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMinValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, convFieldTab4RootFld.MinValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetDefaultValue(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convFieldTab4RootFld.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldStateId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldStateId, convFieldTab4RootFld.FldStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldStateId, 2, convFieldTab4RootFld.FldStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldStateId, 2, convFieldTab4RootFld.FldStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetTabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convFieldTab4RootFld.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convFieldTab4RootFld.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convFieldTab4RootFld.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetFldId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convFieldTab4RootFld.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab4RootFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab4RootFld.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRoot4TabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRoot4TabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoot4TabId, 8, convFieldTab4RootFld.Root4TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoot4TabId, 8, convFieldTab4RootFld.Root4TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootFldId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootFldId, 8, convFieldTab4RootFld.RootFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootFldId, 8, convFieldTab4RootFld.RootFldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootTabId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootTabId, 8, convFieldTab4RootFld.RootTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRootTabId, 8, convFieldTab4RootFld.RootTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetPrjId(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab4RootFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab4RootFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab4RootFld.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetUpdUser(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab4RootFld.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetUpdDate(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab4RootFld.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetMemo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab4RootFld.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootFldName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootFldName, 50, convFieldTab4RootFld.RootFldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRootTabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRootTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRootTabName, 100, convFieldTab4RootFld.RootTabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4RootFldEN SetRoot4TabName(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN, string strRoot4TabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoot4TabName, 100, convFieldTab4RootFld.Root4TabName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldENS">源对象</param>
 /// <param name = "objvFieldTab4RootFldENT">目标对象</param>
 public static void CopyTo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldENS, clsvFieldTab4RootFldEN objvFieldTab4RootFldENT)
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
 /// <param name = "objvFieldTab4RootFldENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab4RootFldEN:objvFieldTab4RootFldENT</returns>
 public static clsvFieldTab4RootFldEN CopyTo(this clsvFieldTab4RootFldEN objvFieldTab4RootFldENS)
{
try
{
 clsvFieldTab4RootFldEN objvFieldTab4RootFldENT = new clsvFieldTab4RootFldEN()
{
TabName = objvFieldTab4RootFldENS.TabName, //表名
TabNum = objvFieldTab4RootFldENS.TabNum, //表数
FldName = objvFieldTab4RootFldENS.FldName, //字段名
FldCnName = objvFieldTab4RootFldENS.FldCnName, //字段中文详名
Caption = objvFieldTab4RootFldENS.Caption, //标题
DataTypeId = objvFieldTab4RootFldENS.DataTypeId, //数据类型Id
DataTypeName = objvFieldTab4RootFldENS.DataTypeName, //数据类型名称
FldLength = objvFieldTab4RootFldENS.FldLength, //字段长度
FldPrecision = objvFieldTab4RootFldENS.FldPrecision, //精确度
FldInfo = objvFieldTab4RootFldENS.FldInfo, //字段信息
IsNull = objvFieldTab4RootFldENS.IsNull, //是否可空
IsIdentity = objvFieldTab4RootFldENS.IsIdentity, //是否Identity
IsOnlyOne = objvFieldTab4RootFldENS.IsOnlyOne, //是否唯一
MaxValue = objvFieldTab4RootFldENS.MaxValue, //最大值
MinValue = objvFieldTab4RootFldENS.MinValue, //最小值
DefaultValue = objvFieldTab4RootFldENS.DefaultValue, //缺省值
FldStateId = objvFieldTab4RootFldENS.FldStateId, //字段状态Id
mId = objvFieldTab4RootFldENS.mId, //mId
TabId = objvFieldTab4RootFldENS.TabId, //表ID
FldId = objvFieldTab4RootFldENS.FldId, //字段Id
IsPrimaryKey = objvFieldTab4RootFldENS.IsPrimaryKey, //是否主键
IsRootFld = objvFieldTab4RootFldENS.IsRootFld, //是否根字段
Root4TabId = objvFieldTab4RootFldENS.Root4TabId, //主根表Id
RootFldId = objvFieldTab4RootFldENS.RootFldId, //根字段Id
RootTabId = objvFieldTab4RootFldENS.RootTabId, //根表Id
PrjId = objvFieldTab4RootFldENS.PrjId, //工程Id
UpdUser = objvFieldTab4RootFldENS.UpdUser, //修改者
UpdDate = objvFieldTab4RootFldENS.UpdDate, //修改日期
Memo = objvFieldTab4RootFldENS.Memo, //说明
RootFldName = objvFieldTab4RootFldENS.RootFldName, //RootFldName
RootTabName = objvFieldTab4RootFldENS.RootTabName, //根表
Root4TabName = objvFieldTab4RootFldENS.Root4TabName, //主根表
};
 return objvFieldTab4RootFldENT;
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
public static void CheckProperty4Condition(this clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
 clsvFieldTab4RootFldBL.vFieldTab4RootFldDA.CheckProperty4Condition(objvFieldTab4RootFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFieldTab4RootFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程字段4RootFld(vFieldTab4RootFld)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab4RootFldBL
{
public static RelatedActions_vFieldTab4RootFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFieldTab4RootFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFieldTab4RootFldDA vFieldTab4RootFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFieldTab4RootFldDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFieldTab4RootFldBL()
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
if (string.IsNullOrEmpty(clsvFieldTab4RootFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab4RootFldEN._ConnectString);
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
public static DataTable GetDataTable_vFieldTab4RootFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFieldTab4RootFldDA.GetDataTable_vFieldTab4RootFld(strWhereCond);
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
objDT = vFieldTab4RootFldDA.GetDataTable(strWhereCond);
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
objDT = vFieldTab4RootFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFieldTab4RootFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFieldTab4RootFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFieldTab4RootFldDA.GetDataTable_Top(objTopPara);
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
objDT = vFieldTab4RootFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFieldTab4RootFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFieldTab4RootFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
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
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFieldTab4RootFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel =
arrvFieldTab4RootFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFieldTab4RootFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLst(string strWhereCond)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
public static List<clsvFieldTab4RootFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFieldTab4RootFldEN> GetSubObjLstCache(clsvFieldTab4RootFldEN objvFieldTab4RootFldCond)
{
 string strPrjId = objvFieldTab4RootFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFieldTab4RootFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab4RootFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab4RootFld._AttributeName)
{
if (objvFieldTab4RootFldCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab4RootFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4RootFldCond[strFldName].ToString());
}
else
{
if (objvFieldTab4RootFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab4RootFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4RootFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab4RootFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab4RootFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab4RootFldCond[strFldName]));
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
List<clsvFieldTab4RootFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFieldTab4RootFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFieldTab4RootFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
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
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
public static List<clsvFieldTab4RootFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
public static List<clsvFieldTab4RootFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4RootFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFieldTab4RootFld(ref clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
bool bolResult = vFieldTab4RootFldDA.GetvFieldTab4RootFld(ref objvFieldTab4RootFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4RootFldEN GetObjBymId(long lngmId)
{
clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = vFieldTab4RootFldDA.GetObjBymId(lngmId);
return objvFieldTab4RootFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFieldTab4RootFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = vFieldTab4RootFldDA.GetFirstObj(strWhereCond);
 return objvFieldTab4RootFldEN;
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
public static clsvFieldTab4RootFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = vFieldTab4RootFldDA.GetObjByDataRow(objRow);
 return objvFieldTab4RootFldEN;
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
public static clsvFieldTab4RootFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = vFieldTab4RootFldDA.GetObjByDataRow(objRow);
 return objvFieldTab4RootFldEN;
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
 /// <param name = "lstvFieldTab4RootFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4RootFldEN GetObjBymIdFromList(long lngmId, List<clsvFieldTab4RootFldEN> lstvFieldTab4RootFldObjLst)
{
foreach (clsvFieldTab4RootFldEN objvFieldTab4RootFldEN in lstvFieldTab4RootFldObjLst)
{
if (objvFieldTab4RootFldEN.mId == lngmId)
{
return objvFieldTab4RootFldEN;
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
 lngmId = new clsvFieldTab4RootFldDA().GetFirstID(strWhereCond);
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
 arrList = vFieldTab4RootFldDA.GetID(strWhereCond);
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
bool bolIsExist = vFieldTab4RootFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFieldTab4RootFldDA.IsExist(lngmId);
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
 bolIsExist = clsvFieldTab4RootFldDA.IsExistTable();
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
 bolIsExist = vFieldTab4RootFldDA.IsExistTable(strTabName);
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
 /// <param name = "objvFieldTab4RootFldEN">源简化对象</param>
 public static void SetUpdFlag(clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
try
{
objvFieldTab4RootFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFieldTab4RootFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFieldTab4RootFld.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.TabName = objvFieldTab4RootFldEN.TabName == "[null]" ? null :  objvFieldTab4RootFldEN.TabName; //表名
}
if (arrFldSet.Contains(convFieldTab4RootFld.TabNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.TabNum = objvFieldTab4RootFldEN.TabNum; //表数
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldName = objvFieldTab4RootFldEN.FldName; //字段名
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldCnName = objvFieldTab4RootFldEN.FldCnName == "[null]" ? null :  objvFieldTab4RootFldEN.FldCnName; //字段中文详名
}
if (arrFldSet.Contains(convFieldTab4RootFld.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.Caption = objvFieldTab4RootFldEN.Caption; //标题
}
if (arrFldSet.Contains(convFieldTab4RootFld.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.DataTypeId = objvFieldTab4RootFldEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.DataTypeName = objvFieldTab4RootFldEN.DataTypeName == "[null]" ? null :  objvFieldTab4RootFldEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldLength = objvFieldTab4RootFldEN.FldLength; //字段长度
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldPrecision = objvFieldTab4RootFldEN.FldPrecision; //精确度
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldInfo = objvFieldTab4RootFldEN.FldInfo == "[null]" ? null :  objvFieldTab4RootFldEN.FldInfo; //字段信息
}
if (arrFldSet.Contains(convFieldTab4RootFld.IsNull, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.IsNull = objvFieldTab4RootFldEN.IsNull; //是否可空
}
if (arrFldSet.Contains(convFieldTab4RootFld.IsIdentity, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.IsIdentity = objvFieldTab4RootFldEN.IsIdentity; //是否Identity
}
if (arrFldSet.Contains(convFieldTab4RootFld.IsOnlyOne, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.IsOnlyOne = objvFieldTab4RootFldEN.IsOnlyOne; //是否唯一
}
if (arrFldSet.Contains(convFieldTab4RootFld.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.MaxValue = objvFieldTab4RootFldEN.MaxValue == "[null]" ? null :  objvFieldTab4RootFldEN.MaxValue; //最大值
}
if (arrFldSet.Contains(convFieldTab4RootFld.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.MinValue = objvFieldTab4RootFldEN.MinValue == "[null]" ? null :  objvFieldTab4RootFldEN.MinValue; //最小值
}
if (arrFldSet.Contains(convFieldTab4RootFld.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.DefaultValue = objvFieldTab4RootFldEN.DefaultValue == "[null]" ? null :  objvFieldTab4RootFldEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldStateId = objvFieldTab4RootFldEN.FldStateId; //字段状态Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.mId = objvFieldTab4RootFldEN.mId; //mId
}
if (arrFldSet.Contains(convFieldTab4RootFld.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.TabId = objvFieldTab4RootFldEN.TabId; //表ID
}
if (arrFldSet.Contains(convFieldTab4RootFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.FldId = objvFieldTab4RootFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.IsPrimaryKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.IsPrimaryKey = objvFieldTab4RootFldEN.IsPrimaryKey; //是否主键
}
if (arrFldSet.Contains(convFieldTab4RootFld.IsRootFld, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.IsRootFld = objvFieldTab4RootFldEN.IsRootFld; //是否根字段
}
if (arrFldSet.Contains(convFieldTab4RootFld.Root4TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.Root4TabId = objvFieldTab4RootFldEN.Root4TabId == "[null]" ? null :  objvFieldTab4RootFldEN.Root4TabId; //主根表Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.RootFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.RootFldId = objvFieldTab4RootFldEN.RootFldId == "[null]" ? null :  objvFieldTab4RootFldEN.RootFldId; //根字段Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.RootTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.RootTabId = objvFieldTab4RootFldEN.RootTabId == "[null]" ? null :  objvFieldTab4RootFldEN.RootTabId; //根表Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.PrjId = objvFieldTab4RootFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFieldTab4RootFld.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.UpdUser = objvFieldTab4RootFldEN.UpdUser == "[null]" ? null :  objvFieldTab4RootFldEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFieldTab4RootFld.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.UpdDate = objvFieldTab4RootFldEN.UpdDate == "[null]" ? null :  objvFieldTab4RootFldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFieldTab4RootFld.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.Memo = objvFieldTab4RootFldEN.Memo == "[null]" ? null :  objvFieldTab4RootFldEN.Memo; //说明
}
if (arrFldSet.Contains(convFieldTab4RootFld.RootFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.RootFldName = objvFieldTab4RootFldEN.RootFldName == "[null]" ? null :  objvFieldTab4RootFldEN.RootFldName; //RootFldName
}
if (arrFldSet.Contains(convFieldTab4RootFld.RootTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.RootTabName = objvFieldTab4RootFldEN.RootTabName == "[null]" ? null :  objvFieldTab4RootFldEN.RootTabName; //根表
}
if (arrFldSet.Contains(convFieldTab4RootFld.Root4TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4RootFldEN.Root4TabName = objvFieldTab4RootFldEN.Root4TabName == "[null]" ? null :  objvFieldTab4RootFldEN.Root4TabName; //主根表
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
 /// <param name = "objvFieldTab4RootFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
try
{
if (objvFieldTab4RootFldEN.TabName == "[null]") objvFieldTab4RootFldEN.TabName = null; //表名
if (objvFieldTab4RootFldEN.FldCnName == "[null]") objvFieldTab4RootFldEN.FldCnName = null; //字段中文详名
if (objvFieldTab4RootFldEN.DataTypeName == "[null]") objvFieldTab4RootFldEN.DataTypeName = null; //数据类型名称
if (objvFieldTab4RootFldEN.FldInfo == "[null]") objvFieldTab4RootFldEN.FldInfo = null; //字段信息
if (objvFieldTab4RootFldEN.MaxValue == "[null]") objvFieldTab4RootFldEN.MaxValue = null; //最大值
if (objvFieldTab4RootFldEN.MinValue == "[null]") objvFieldTab4RootFldEN.MinValue = null; //最小值
if (objvFieldTab4RootFldEN.DefaultValue == "[null]") objvFieldTab4RootFldEN.DefaultValue = null; //缺省值
if (objvFieldTab4RootFldEN.Root4TabId == "[null]") objvFieldTab4RootFldEN.Root4TabId = null; //主根表Id
if (objvFieldTab4RootFldEN.RootFldId == "[null]") objvFieldTab4RootFldEN.RootFldId = null; //根字段Id
if (objvFieldTab4RootFldEN.RootTabId == "[null]") objvFieldTab4RootFldEN.RootTabId = null; //根表Id
if (objvFieldTab4RootFldEN.UpdUser == "[null]") objvFieldTab4RootFldEN.UpdUser = null; //修改者
if (objvFieldTab4RootFldEN.UpdDate == "[null]") objvFieldTab4RootFldEN.UpdDate = null; //修改日期
if (objvFieldTab4RootFldEN.Memo == "[null]") objvFieldTab4RootFldEN.Memo = null; //说明
if (objvFieldTab4RootFldEN.RootFldName == "[null]") objvFieldTab4RootFldEN.RootFldName = null; //RootFldName
if (objvFieldTab4RootFldEN.RootTabName == "[null]") objvFieldTab4RootFldEN.RootTabName = null; //根表
if (objvFieldTab4RootFldEN.Root4TabName == "[null]") objvFieldTab4RootFldEN.Root4TabName = null; //主根表
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
public static void CheckProperty4Condition(clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
 vFieldTab4RootFldDA.CheckProperty4Condition(objvFieldTab4RootFldEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTab4RootFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTab4RootFldBL没有刷新缓存机制(clsFieldTab4RootFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFieldTab4RootFldObjLstCache == null)
//{
//arrvFieldTab4RootFldObjLstCache = vFieldTab4RootFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4RootFldEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLst_Sel =
arrvFieldTab4RootFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFieldTab4RootFldObjLst_Sel.Count() == 0)
{
   clsvFieldTab4RootFldEN obj = clsvFieldTab4RootFldBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFieldTab4RootFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetAllvFieldTab4RootFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId); 
return arrvFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4RootFldEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFieldTab4RootFldEN> arrvFieldTab4RootFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFieldTab4RootFldObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4RootFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFieldTab4RootFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFieldTab4RootFldEN._RefreshTimeLst.Count == 0) return "";
return clsvFieldTab4RootFldEN._RefreshTimeLst[clsvFieldTab4RootFldEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convFieldTab4RootFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFieldTab4RootFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFieldTab4RootFld._AttributeName));
throw new Exception(strMsg);
}
var objvFieldTab4RootFld = clsvFieldTab4RootFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvFieldTab4RootFld == null) return "";
return objvFieldTab4RootFld[strOutFldName].ToString();
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
int intRecCount = clsvFieldTab4RootFldDA.GetRecCount(strTabName);
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
int intRecCount = clsvFieldTab4RootFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFieldTab4RootFldDA.GetRecCount();
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
int intRecCount = clsvFieldTab4RootFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFieldTab4RootFldEN objvFieldTab4RootFldCond)
{
 string strPrjId = objvFieldTab4RootFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFieldTab4RootFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab4RootFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4RootFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab4RootFld._AttributeName)
{
if (objvFieldTab4RootFldCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab4RootFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4RootFldCond[strFldName].ToString());
}
else
{
if (objvFieldTab4RootFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab4RootFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4RootFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab4RootFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab4RootFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab4RootFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab4RootFldCond[strFldName]));
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
 List<string> arrList = clsvFieldTab4RootFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab4RootFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab4RootFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}