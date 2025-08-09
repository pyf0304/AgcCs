
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeWApi
 表名:vApplicationType(00050403)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:20
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
public static class  clsvApplicationTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeId(this clsvApplicationTypeEN objvApplicationTypeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvApplicationTypeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ApplicationTypeId) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ApplicationTypeId, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ApplicationTypeId] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convApplicationType.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convApplicationType.ApplicationTypeName);
objvApplicationTypeEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ApplicationTypeName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ApplicationTypeName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ApplicationTypeName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeSimName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convApplicationType.ApplicationTypeSimName);
objvApplicationTypeEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ApplicationTypeSimName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeENName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convApplicationType.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convApplicationType.ApplicationTypeENName);
objvApplicationTypeEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ApplicationTypeENName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ApplicationTypeENName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ApplicationTypeENName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convApplicationType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convApplicationType.ProgLangTypeId);
objvApplicationTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeId) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeId, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeId] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convApplicationType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convApplicationType.ProgLangTypeName);
objvApplicationTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeENName">编程语言类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeENName(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, convApplicationType.ProgLangTypeENName);
objvApplicationTypeEN.ProgLangTypeENName = strProgLangTypeENName; //编程语言类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeENName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeENName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeENName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId">字符编码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convApplicationType.CharEncodingId);
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convApplicationType.CharEncodingId);
objvApplicationTypeEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingId) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingId, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingId] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName">字符编码名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convApplicationType.CharEncodingName);
objvApplicationTypeEN.CharEncodingName = strCharEncodingName; //字符编码名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingName) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingName, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingName] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId2">编程语言类型Id2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId2(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId2, 2, convApplicationType.ProgLangTypeId2);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId2, 2, convApplicationType.ProgLangTypeId2);
objvApplicationTypeEN.ProgLangTypeId2 = strProgLangTypeId2; //编程语言类型Id2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeId2) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeId2, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeId2] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId3">编程语言类型Id3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId3(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId3, 2, convApplicationType.ProgLangTypeId3);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId3, 2, convApplicationType.ProgLangTypeId3);
objvApplicationTypeEN.ProgLangTypeId3 = strProgLangTypeId3; //编程语言类型Id3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeId3) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeId3, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeId3] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId4">编程语言类型Id4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId4(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId4, 2, convApplicationType.ProgLangTypeId4);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4, 2, convApplicationType.ProgLangTypeId4);
objvApplicationTypeEN.ProgLangTypeId4 = strProgLangTypeId4; //编程语言类型Id4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeId4) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeId4, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeId4] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId5">编程语言类型Id5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId5(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId5, 2, convApplicationType.ProgLangTypeId5);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId5, 2, convApplicationType.ProgLangTypeId5);
objvApplicationTypeEN.ProgLangTypeId5 = strProgLangTypeId5; //编程语言类型Id5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeId5) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeId5, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeId5] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetIsVisible(this clsvApplicationTypeEN objvApplicationTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvApplicationTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.IsVisible) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.IsVisible, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.IsVisible] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetOrderNum(this clsvApplicationTypeEN objvApplicationTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convApplicationType.OrderNum);
objvApplicationTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.OrderNum) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.OrderNum, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.OrderNum] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetMemo(this clsvApplicationTypeEN objvApplicationTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convApplicationType.Memo);
objvApplicationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.Memo) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.Memo, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.Memo] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId2">CharEncodingId2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId2(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingId2, 20, convApplicationType.CharEncodingId2);
objvApplicationTypeEN.CharEncodingId2 = strCharEncodingId2; //CharEncodingId2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingId2) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingId2, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingId2] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId3">CharEncodingId3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId3(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingId3, 20, convApplicationType.CharEncodingId3);
objvApplicationTypeEN.CharEncodingId3 = strCharEncodingId3; //CharEncodingId3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingId3) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingId3, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingId3] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName2">CharEncodingName2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName2(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingName2, 100, convApplicationType.CharEncodingName2);
objvApplicationTypeEN.CharEncodingName2 = strCharEncodingName2; //CharEncodingName2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingName2) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingName2, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingName2] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName3">CharEncodingName3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName3(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingName3, 100, convApplicationType.CharEncodingName3);
objvApplicationTypeEN.CharEncodingName3 = strCharEncodingName3; //CharEncodingName3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingName3) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingName3, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingName3] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName2">ProgLangTypeName2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName2(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName2, 30, convApplicationType.ProgLangTypeName2);
objvApplicationTypeEN.ProgLangTypeName2 = strProgLangTypeName2; //ProgLangTypeName2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeName2) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeName2, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeName2] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName3">ProgLangTypeName3</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName3(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName3, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName3, 30, convApplicationType.ProgLangTypeName3);
objvApplicationTypeEN.ProgLangTypeName3 = strProgLangTypeName3; //ProgLangTypeName3
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeName3) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeName3, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeName3] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName5">ProgLangTypeName5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName5(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName5, 30, convApplicationType.ProgLangTypeName5);
objvApplicationTypeEN.ProgLangTypeName5 = strProgLangTypeName5; //ProgLangTypeName5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeName5) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeName5, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeName5] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intCodeTypeCount">代码类型数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCodeTypeCount(this clsvApplicationTypeEN objvApplicationTypeEN, int intCodeTypeCount, string strComparisonOp="")
	{
objvApplicationTypeEN.CodeTypeCount = intCodeTypeCount; //代码类型数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CodeTypeCount) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CodeTypeCount, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CodeTypeCount] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId4">CharEncodingId4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId4(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingId4, 20, convApplicationType.CharEncodingId4);
objvApplicationTypeEN.CharEncodingId4 = strCharEncodingId4; //CharEncodingId4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingId4) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingId4, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingId4] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName4">CharEncodingName4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName4(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingName4, 100, convApplicationType.CharEncodingName4);
objvApplicationTypeEN.CharEncodingName4 = strCharEncodingName4; //CharEncodingName4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingName4) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingName4, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingName4] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName4">ProgLangTypeName4</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName4(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName4, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName4, 30, convApplicationType.ProgLangTypeName4);
objvApplicationTypeEN.ProgLangTypeName4 = strProgLangTypeName4; //ProgLangTypeName4
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.ProgLangTypeName4) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.ProgLangTypeName4, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.ProgLangTypeName4] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId5">CharEncodingId5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId5(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingId5, 20, convApplicationType.CharEncodingId5);
objvApplicationTypeEN.CharEncodingId5 = strCharEncodingId5; //CharEncodingId5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingId5) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingId5, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingId5] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName5">CharEncodingName5</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName5(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName5, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCharEncodingName5, 100, convApplicationType.CharEncodingName5);
objvApplicationTypeEN.CharEncodingName5 = strCharEncodingName5; //CharEncodingName5
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvApplicationTypeEN.dicFldComparisonOp.ContainsKey(convApplicationType.CharEncodingName5) == false)
{
objvApplicationTypeEN.dicFldComparisonOp.Add(convApplicationType.CharEncodingName5, strComparisonOp);
}
else
{
objvApplicationTypeEN.dicFldComparisonOp[convApplicationType.CharEncodingName5] = strComparisonOp;
}
}
return objvApplicationTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvApplicationTypeEN objvApplicationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convApplicationType.ApplicationTypeId, objvApplicationTypeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ApplicationTypeName, objvApplicationTypeCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ApplicationTypeSimName, objvApplicationTypeCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ApplicationTypeENName, objvApplicationTypeCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeId, objvApplicationTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeName, objvApplicationTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeENName) == true)
{
string strComparisonOpProgLangTypeENName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeENName, objvApplicationTypeCond.ProgLangTypeENName, strComparisonOpProgLangTypeENName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingId, objvApplicationTypeCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingName) == true)
{
string strComparisonOpCharEncodingName = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingName, objvApplicationTypeCond.CharEncodingName, strComparisonOpCharEncodingName);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeId2) == true)
{
string strComparisonOpProgLangTypeId2 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeId2, objvApplicationTypeCond.ProgLangTypeId2, strComparisonOpProgLangTypeId2);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeId3) == true)
{
string strComparisonOpProgLangTypeId3 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeId3];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeId3, objvApplicationTypeCond.ProgLangTypeId3, strComparisonOpProgLangTypeId3);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeId4) == true)
{
string strComparisonOpProgLangTypeId4 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeId4];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeId4, objvApplicationTypeCond.ProgLangTypeId4, strComparisonOpProgLangTypeId4);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeId5) == true)
{
string strComparisonOpProgLangTypeId5 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeId5];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeId5, objvApplicationTypeCond.ProgLangTypeId5, strComparisonOpProgLangTypeId5);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.IsVisible) == true)
{
if (objvApplicationTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convApplicationType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convApplicationType.IsVisible);
}
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convApplicationType.OrderNum, objvApplicationTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.Memo) == true)
{
string strComparisonOpMemo = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.Memo, objvApplicationTypeCond.Memo, strComparisonOpMemo);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingId2) == true)
{
string strComparisonOpCharEncodingId2 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingId2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingId2, objvApplicationTypeCond.CharEncodingId2, strComparisonOpCharEncodingId2);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingId3) == true)
{
string strComparisonOpCharEncodingId3 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingId3];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingId3, objvApplicationTypeCond.CharEncodingId3, strComparisonOpCharEncodingId3);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingName2) == true)
{
string strComparisonOpCharEncodingName2 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingName2, objvApplicationTypeCond.CharEncodingName2, strComparisonOpCharEncodingName2);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingName3) == true)
{
string strComparisonOpCharEncodingName3 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingName3];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingName3, objvApplicationTypeCond.CharEncodingName3, strComparisonOpCharEncodingName3);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeName2) == true)
{
string strComparisonOpProgLangTypeName2 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeName2, objvApplicationTypeCond.ProgLangTypeName2, strComparisonOpProgLangTypeName2);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeName3) == true)
{
string strComparisonOpProgLangTypeName3 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeName3];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeName3, objvApplicationTypeCond.ProgLangTypeName3, strComparisonOpProgLangTypeName3);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeName5) == true)
{
string strComparisonOpProgLangTypeName5 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeName5];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeName5, objvApplicationTypeCond.ProgLangTypeName5, strComparisonOpProgLangTypeName5);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CodeTypeCount) == true)
{
string strComparisonOpCodeTypeCount = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CodeTypeCount];
strWhereCond += string.Format(" And {0} {2} {1}", convApplicationType.CodeTypeCount, objvApplicationTypeCond.CodeTypeCount, strComparisonOpCodeTypeCount);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingId4) == true)
{
string strComparisonOpCharEncodingId4 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingId4];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingId4, objvApplicationTypeCond.CharEncodingId4, strComparisonOpCharEncodingId4);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingName4) == true)
{
string strComparisonOpCharEncodingName4 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingName4];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingName4, objvApplicationTypeCond.CharEncodingName4, strComparisonOpCharEncodingName4);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.ProgLangTypeName4) == true)
{
string strComparisonOpProgLangTypeName4 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.ProgLangTypeName4];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.ProgLangTypeName4, objvApplicationTypeCond.ProgLangTypeName4, strComparisonOpProgLangTypeName4);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingId5) == true)
{
string strComparisonOpCharEncodingId5 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingId5];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingId5, objvApplicationTypeCond.CharEncodingId5, strComparisonOpCharEncodingId5);
}
if (objvApplicationTypeCond.IsUpdated(convApplicationType.CharEncodingName5) == true)
{
string strComparisonOpCharEncodingName5 = objvApplicationTypeCond.dicFldComparisonOp[convApplicationType.CharEncodingName5];
strWhereCond += string.Format(" And {0} {2} '{1}'", convApplicationType.CharEncodingName5, objvApplicationTypeCond.CharEncodingName5, strComparisonOpCharEncodingName5);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v应用程序类型(vApplicationType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvApplicationTypeWApi
{
private static readonly string mstrApiControllerName = "vApplicationTypeApi";

 public clsvApplicationTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
if (intApplicationTypeId == 0) return null;
string strAction = "GetObjByApplicationTypeId";
clsvApplicationTypeEN objvApplicationTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvApplicationTypeEN = JsonConvert.DeserializeObject<clsvApplicationTypeEN>(strJson);
return objvApplicationTypeEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsvApplicationTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvApplicationTypeEN objvApplicationTypeEN;
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
objvApplicationTypeEN = JsonConvert.DeserializeObject<clsvApplicationTypeEN>(strJson);
return objvApplicationTypeEN;
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
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvApplicationTypeEN GetObjByApplicationTypeIdCache(int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrvApplicationTypeObjLst_Sel =
from objvApplicationTypeEN in arrvApplicationTypeObjLstCache
where objvApplicationTypeEN.ApplicationTypeId == intApplicationTypeId 
select objvApplicationTypeEN;
if (arrvApplicationTypeObjLst_Sel.Count() == 0)
{
   clsvApplicationTypeEN obj = clsvApplicationTypeWApi.GetObjByApplicationTypeId(intApplicationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvApplicationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLstByApplicationTypeIdLst(List<int> arrApplicationTypeId)
{
 List<clsvApplicationTypeEN> arrObjLst; 
string strAction = "GetObjLstByApplicationTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrApplicationTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
 /// <param name = "arrApplicationTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvApplicationTypeEN> GetObjLstByApplicationTypeIdLstCache(List<int> arrApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrvApplicationTypeObjLst_Sel =
from objvApplicationTypeEN in arrvApplicationTypeObjLstCache
where arrApplicationTypeId.Contains(objvApplicationTypeEN.ApplicationTypeId)
select objvApplicationTypeEN;
return arrvApplicationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
public static List<clsvApplicationTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
public static List<clsvApplicationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
public static List<clsvApplicationTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvApplicationTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvApplicationTypeEN>>(strJson);
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
public static bool IsExist(int intApplicationTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["intApplicationTypeId"] = intApplicationTypeId.ToString()
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
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <param name = "objvApplicationTypeENT">目标对象</param>
 public static void CopyTo(clsvApplicationTypeEN objvApplicationTypeENS, clsvApplicationTypeEN objvApplicationTypeENT)
{
try
{
objvApplicationTypeENT.ApplicationTypeId = objvApplicationTypeENS.ApplicationTypeId; //应用程序类型ID
objvApplicationTypeENT.ApplicationTypeName = objvApplicationTypeENS.ApplicationTypeName; //应用程序类型名称
objvApplicationTypeENT.ApplicationTypeSimName = objvApplicationTypeENS.ApplicationTypeSimName; //应用程序类型简称
objvApplicationTypeENT.ApplicationTypeENName = objvApplicationTypeENS.ApplicationTypeENName; //应用类型英文名
objvApplicationTypeENT.ProgLangTypeId = objvApplicationTypeENS.ProgLangTypeId; //编程语言类型Id
objvApplicationTypeENT.ProgLangTypeName = objvApplicationTypeENS.ProgLangTypeName; //编程语言类型名
objvApplicationTypeENT.ProgLangTypeENName = objvApplicationTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvApplicationTypeENT.CharEncodingId = objvApplicationTypeENS.CharEncodingId; //字符编码
objvApplicationTypeENT.CharEncodingName = objvApplicationTypeENS.CharEncodingName; //字符编码名称
objvApplicationTypeENT.ProgLangTypeId2 = objvApplicationTypeENS.ProgLangTypeId2; //编程语言类型Id2
objvApplicationTypeENT.ProgLangTypeId3 = objvApplicationTypeENS.ProgLangTypeId3; //编程语言类型Id3
objvApplicationTypeENT.ProgLangTypeId4 = objvApplicationTypeENS.ProgLangTypeId4; //编程语言类型Id4
objvApplicationTypeENT.ProgLangTypeId5 = objvApplicationTypeENS.ProgLangTypeId5; //编程语言类型Id5
objvApplicationTypeENT.IsVisible = objvApplicationTypeENS.IsVisible; //是否显示
objvApplicationTypeENT.OrderNum = objvApplicationTypeENS.OrderNum; //序号
objvApplicationTypeENT.Memo = objvApplicationTypeENS.Memo; //说明
objvApplicationTypeENT.CharEncodingId2 = objvApplicationTypeENS.CharEncodingId2; //CharEncodingId2
objvApplicationTypeENT.CharEncodingId3 = objvApplicationTypeENS.CharEncodingId3; //CharEncodingId3
objvApplicationTypeENT.CharEncodingName2 = objvApplicationTypeENS.CharEncodingName2; //CharEncodingName2
objvApplicationTypeENT.CharEncodingName3 = objvApplicationTypeENS.CharEncodingName3; //CharEncodingName3
objvApplicationTypeENT.ProgLangTypeName2 = objvApplicationTypeENS.ProgLangTypeName2; //ProgLangTypeName2
objvApplicationTypeENT.ProgLangTypeName3 = objvApplicationTypeENS.ProgLangTypeName3; //ProgLangTypeName3
objvApplicationTypeENT.ProgLangTypeName5 = objvApplicationTypeENS.ProgLangTypeName5; //ProgLangTypeName5
objvApplicationTypeENT.CodeTypeCount = objvApplicationTypeENS.CodeTypeCount; //代码类型数
objvApplicationTypeENT.CharEncodingId4 = objvApplicationTypeENS.CharEncodingId4; //CharEncodingId4
objvApplicationTypeENT.CharEncodingName4 = objvApplicationTypeENS.CharEncodingName4; //CharEncodingName4
objvApplicationTypeENT.ProgLangTypeName4 = objvApplicationTypeENS.ProgLangTypeName4; //ProgLangTypeName4
objvApplicationTypeENT.CharEncodingId5 = objvApplicationTypeENS.CharEncodingId5; //CharEncodingId5
objvApplicationTypeENT.CharEncodingName5 = objvApplicationTypeENS.CharEncodingName5; //CharEncodingName5
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
public static DataTable ToDataTable(List<clsvApplicationTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvApplicationTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvApplicationTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvApplicationTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvApplicationTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvApplicationTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
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
public static List<clsvApplicationTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvApplicationTypeEN._CurrTabName;
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvApplicationTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvApplicationTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convApplicationType.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convApplicationType.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingId, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingName, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeId2, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeId3, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeId4, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeId5, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convApplicationType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convApplicationType.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingId2, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingId3, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingName2, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingName3, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeName2, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeName3, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeName5, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CodeTypeCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convApplicationType.CharEncodingId4, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingName4, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.ProgLangTypeName4, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingId5, Type.GetType("System.String"));
objDT.Columns.Add(convApplicationType.CharEncodingName5, Type.GetType("System.String"));
foreach (clsvApplicationTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convApplicationType.ApplicationTypeId] = objInFor[convApplicationType.ApplicationTypeId];
objDR[convApplicationType.ApplicationTypeName] = objInFor[convApplicationType.ApplicationTypeName];
objDR[convApplicationType.ApplicationTypeSimName] = objInFor[convApplicationType.ApplicationTypeSimName];
objDR[convApplicationType.ApplicationTypeENName] = objInFor[convApplicationType.ApplicationTypeENName];
objDR[convApplicationType.ProgLangTypeId] = objInFor[convApplicationType.ProgLangTypeId];
objDR[convApplicationType.ProgLangTypeName] = objInFor[convApplicationType.ProgLangTypeName];
objDR[convApplicationType.ProgLangTypeENName] = objInFor[convApplicationType.ProgLangTypeENName];
objDR[convApplicationType.CharEncodingId] = objInFor[convApplicationType.CharEncodingId];
objDR[convApplicationType.CharEncodingName] = objInFor[convApplicationType.CharEncodingName];
objDR[convApplicationType.ProgLangTypeId2] = objInFor[convApplicationType.ProgLangTypeId2];
objDR[convApplicationType.ProgLangTypeId3] = objInFor[convApplicationType.ProgLangTypeId3];
objDR[convApplicationType.ProgLangTypeId4] = objInFor[convApplicationType.ProgLangTypeId4];
objDR[convApplicationType.ProgLangTypeId5] = objInFor[convApplicationType.ProgLangTypeId5];
objDR[convApplicationType.IsVisible] = objInFor[convApplicationType.IsVisible];
objDR[convApplicationType.OrderNum] = objInFor[convApplicationType.OrderNum];
objDR[convApplicationType.Memo] = objInFor[convApplicationType.Memo];
objDR[convApplicationType.CharEncodingId2] = objInFor[convApplicationType.CharEncodingId2];
objDR[convApplicationType.CharEncodingId3] = objInFor[convApplicationType.CharEncodingId3];
objDR[convApplicationType.CharEncodingName2] = objInFor[convApplicationType.CharEncodingName2];
objDR[convApplicationType.CharEncodingName3] = objInFor[convApplicationType.CharEncodingName3];
objDR[convApplicationType.ProgLangTypeName2] = objInFor[convApplicationType.ProgLangTypeName2];
objDR[convApplicationType.ProgLangTypeName3] = objInFor[convApplicationType.ProgLangTypeName3];
objDR[convApplicationType.ProgLangTypeName5] = objInFor[convApplicationType.ProgLangTypeName5];
objDR[convApplicationType.CodeTypeCount] = objInFor[convApplicationType.CodeTypeCount];
objDR[convApplicationType.CharEncodingId4] = objInFor[convApplicationType.CharEncodingId4];
objDR[convApplicationType.CharEncodingName4] = objInFor[convApplicationType.CharEncodingName4];
objDR[convApplicationType.ProgLangTypeName4] = objInFor[convApplicationType.ProgLangTypeName4];
objDR[convApplicationType.CharEncodingId5] = objInFor[convApplicationType.CharEncodingId5];
objDR[convApplicationType.CharEncodingName5] = objInFor[convApplicationType.CharEncodingName5];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}