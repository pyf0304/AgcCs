
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvApplicationTypeBL
 表名:vApplicationType(00050403)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvApplicationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvApplicationTypeEN GetObj(this K_ApplicationTypeId_vApplicationType myKey)
{
clsvApplicationTypeEN objvApplicationTypeEN = clsvApplicationTypeBL.vApplicationTypeDA.GetObjByApplicationTypeId(myKey.Value);
return objvApplicationTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convApplicationType.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convApplicationType.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeSimName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convApplicationType.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetApplicationTypeENName(this clsvApplicationTypeEN objvApplicationTypeEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convApplicationType.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convApplicationType.ApplicationTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convApplicationType.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convApplicationType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convApplicationType.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convApplicationType.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convApplicationType.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeENName(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, convApplicationType.ProgLangTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convApplicationType.CharEncodingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convApplicationType.CharEncodingId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convApplicationType.CharEncodingName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId2(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId2, 2, convApplicationType.ProgLangTypeId2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId2, 2, convApplicationType.ProgLangTypeId2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId3(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId3, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId3, 2, convApplicationType.ProgLangTypeId3);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId3, 2, convApplicationType.ProgLangTypeId3);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId4(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId4, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId4, 2, convApplicationType.ProgLangTypeId4);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId4, 2, convApplicationType.ProgLangTypeId4);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeId5(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeId5, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId5, 2, convApplicationType.ProgLangTypeId5);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId5, 2, convApplicationType.ProgLangTypeId5);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetMemo(this clsvApplicationTypeEN objvApplicationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convApplicationType.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId2(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId2, 20, convApplicationType.CharEncodingId2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId3(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId3, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId3, 20, convApplicationType.CharEncodingId3);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName2(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName2, 100, convApplicationType.CharEncodingName2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName3(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName3, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName3, 100, convApplicationType.CharEncodingName3);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName2(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName2, 30, convApplicationType.ProgLangTypeName2);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName3(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName3, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName3, 30, convApplicationType.ProgLangTypeName3);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName5(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName5, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName5, 30, convApplicationType.ProgLangTypeName5);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCodeTypeCount(this clsvApplicationTypeEN objvApplicationTypeEN, int? intCodeTypeCount, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId4(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId4, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId4, 20, convApplicationType.CharEncodingId4);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName4(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName4, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName4, 100, convApplicationType.CharEncodingName4);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetProgLangTypeName4(this clsvApplicationTypeEN objvApplicationTypeEN, string strProgLangTypeName4, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName4, 30, convApplicationType.ProgLangTypeName4);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingId5(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingId5, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId5, 20, convApplicationType.CharEncodingId5);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvApplicationTypeEN SetCharEncodingName5(this clsvApplicationTypeEN objvApplicationTypeEN, string strCharEncodingName5, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName5, 100, convApplicationType.CharEncodingName5);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <param name = "objvApplicationTypeENT">目标对象</param>
 public static void CopyTo(this clsvApplicationTypeEN objvApplicationTypeENS, clsvApplicationTypeEN objvApplicationTypeENT)
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
 /// <param name = "objvApplicationTypeENS">源对象</param>
 /// <returns>目标对象=>clsvApplicationTypeEN:objvApplicationTypeENT</returns>
 public static clsvApplicationTypeEN CopyTo(this clsvApplicationTypeEN objvApplicationTypeENS)
{
try
{
 clsvApplicationTypeEN objvApplicationTypeENT = new clsvApplicationTypeEN()
{
ApplicationTypeId = objvApplicationTypeENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvApplicationTypeENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeSimName = objvApplicationTypeENS.ApplicationTypeSimName, //应用程序类型简称
ApplicationTypeENName = objvApplicationTypeENS.ApplicationTypeENName, //应用类型英文名
ProgLangTypeId = objvApplicationTypeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvApplicationTypeENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeENName = objvApplicationTypeENS.ProgLangTypeENName, //编程语言类型英文名
CharEncodingId = objvApplicationTypeENS.CharEncodingId, //字符编码
CharEncodingName = objvApplicationTypeENS.CharEncodingName, //字符编码名称
ProgLangTypeId2 = objvApplicationTypeENS.ProgLangTypeId2, //编程语言类型Id2
ProgLangTypeId3 = objvApplicationTypeENS.ProgLangTypeId3, //编程语言类型Id3
ProgLangTypeId4 = objvApplicationTypeENS.ProgLangTypeId4, //编程语言类型Id4
ProgLangTypeId5 = objvApplicationTypeENS.ProgLangTypeId5, //编程语言类型Id5
IsVisible = objvApplicationTypeENS.IsVisible, //是否显示
OrderNum = objvApplicationTypeENS.OrderNum, //序号
Memo = objvApplicationTypeENS.Memo, //说明
CharEncodingId2 = objvApplicationTypeENS.CharEncodingId2, //CharEncodingId2
CharEncodingId3 = objvApplicationTypeENS.CharEncodingId3, //CharEncodingId3
CharEncodingName2 = objvApplicationTypeENS.CharEncodingName2, //CharEncodingName2
CharEncodingName3 = objvApplicationTypeENS.CharEncodingName3, //CharEncodingName3
ProgLangTypeName2 = objvApplicationTypeENS.ProgLangTypeName2, //ProgLangTypeName2
ProgLangTypeName3 = objvApplicationTypeENS.ProgLangTypeName3, //ProgLangTypeName3
ProgLangTypeName5 = objvApplicationTypeENS.ProgLangTypeName5, //ProgLangTypeName5
CodeTypeCount = objvApplicationTypeENS.CodeTypeCount, //代码类型数
CharEncodingId4 = objvApplicationTypeENS.CharEncodingId4, //CharEncodingId4
CharEncodingName4 = objvApplicationTypeENS.CharEncodingName4, //CharEncodingName4
ProgLangTypeName4 = objvApplicationTypeENS.ProgLangTypeName4, //ProgLangTypeName4
CharEncodingId5 = objvApplicationTypeENS.CharEncodingId5, //CharEncodingId5
CharEncodingName5 = objvApplicationTypeENS.CharEncodingName5, //CharEncodingName5
};
 return objvApplicationTypeENT;
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
public static void CheckProperty4Condition(this clsvApplicationTypeEN objvApplicationTypeEN)
{
 clsvApplicationTypeBL.vApplicationTypeDA.CheckProperty4Condition(objvApplicationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vApplicationType
{
public virtual bool UpdRelaTabDate(int intApplicationTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v应用程序类型(vApplicationType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvApplicationTypeBL
{
public static RelatedActions_vApplicationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvApplicationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvApplicationTypeDA vApplicationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvApplicationTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvApplicationTypeBL()
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
if (string.IsNullOrEmpty(clsvApplicationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvApplicationTypeEN._ConnectString);
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
public static DataTable GetDataTable_vApplicationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vApplicationTypeDA.GetDataTable_vApplicationType(strWhereCond);
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
objDT = vApplicationTypeDA.GetDataTable(strWhereCond);
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
objDT = vApplicationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vApplicationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vApplicationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vApplicationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vApplicationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vApplicationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vApplicationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrApplicationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLstByApplicationTypeIdLst(List<int> arrApplicationTypeIdLst)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrApplicationTypeIdLst);
 string strWhereCond = string.Format("ApplicationTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrApplicationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvApplicationTypeEN> GetObjLstByApplicationTypeIdLstCache(List<int> arrApplicationTypeIdLst)
{
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrvApplicationTypeObjLst_Sel =
arrvApplicationTypeObjLstCache
.Where(x => arrApplicationTypeIdLst.Contains(x.ApplicationTypeId));
return arrvApplicationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLst(string strWhereCond)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
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
public static List<clsvApplicationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvApplicationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvApplicationTypeEN> GetSubObjLstCache(clsvApplicationTypeEN objvApplicationTypeCond)
{
List<clsvApplicationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convApplicationType._AttributeName)
{
if (objvApplicationTypeCond.IsUpdated(strFldName) == false) continue;
if (objvApplicationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvApplicationTypeCond[strFldName].ToString());
}
else
{
if (objvApplicationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvApplicationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvApplicationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvApplicationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvApplicationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvApplicationTypeCond[strFldName]));
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
public static List<clsvApplicationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
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
public static List<clsvApplicationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
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
List<clsvApplicationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvApplicationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvApplicationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
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
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
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
public static List<clsvApplicationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvApplicationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
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
public static List<clsvApplicationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvApplicationTypeEN> arrObjLst = new List<clsvApplicationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvApplicationTypeEN objvApplicationTypeEN = new clsvApplicationTypeEN();
try
{
objvApplicationTypeEN.ApplicationTypeId = Int32.Parse(objRow[convApplicationType.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvApplicationTypeEN.ApplicationTypeName = objRow[convApplicationType.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvApplicationTypeEN.ApplicationTypeSimName = objRow[convApplicationType.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convApplicationType.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvApplicationTypeEN.ApplicationTypeENName = objRow[convApplicationType.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvApplicationTypeEN.ProgLangTypeId = objRow[convApplicationType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvApplicationTypeEN.ProgLangTypeName = objRow[convApplicationType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvApplicationTypeEN.ProgLangTypeENName = objRow[convApplicationType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvApplicationTypeEN.CharEncodingId = objRow[convApplicationType.CharEncodingId].ToString().Trim(); //字符编码
objvApplicationTypeEN.CharEncodingName = objRow[convApplicationType.CharEncodingName] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName].ToString().Trim(); //字符编码名称
objvApplicationTypeEN.ProgLangTypeId2 = objRow[convApplicationType.ProgLangTypeId2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId2].ToString().Trim(); //编程语言类型Id2
objvApplicationTypeEN.ProgLangTypeId3 = objRow[convApplicationType.ProgLangTypeId3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId3].ToString().Trim(); //编程语言类型Id3
objvApplicationTypeEN.ProgLangTypeId4 = objRow[convApplicationType.ProgLangTypeId4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId4].ToString().Trim(); //编程语言类型Id4
objvApplicationTypeEN.ProgLangTypeId5 = objRow[convApplicationType.ProgLangTypeId5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeId5].ToString().Trim(); //编程语言类型Id5
objvApplicationTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convApplicationType.IsVisible].ToString().Trim()); //是否显示
objvApplicationTypeEN.OrderNum = Int32.Parse(objRow[convApplicationType.OrderNum].ToString().Trim()); //序号
objvApplicationTypeEN.Memo = objRow[convApplicationType.Memo] == DBNull.Value ? null : objRow[convApplicationType.Memo].ToString().Trim(); //说明
objvApplicationTypeEN.CharEncodingId2 = objRow[convApplicationType.CharEncodingId2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId2].ToString().Trim(); //CharEncodingId2
objvApplicationTypeEN.CharEncodingId3 = objRow[convApplicationType.CharEncodingId3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId3].ToString().Trim(); //CharEncodingId3
objvApplicationTypeEN.CharEncodingName2 = objRow[convApplicationType.CharEncodingName2] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName2].ToString().Trim(); //CharEncodingName2
objvApplicationTypeEN.CharEncodingName3 = objRow[convApplicationType.CharEncodingName3] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName3].ToString().Trim(); //CharEncodingName3
objvApplicationTypeEN.ProgLangTypeName2 = objRow[convApplicationType.ProgLangTypeName2] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName2].ToString().Trim(); //ProgLangTypeName2
objvApplicationTypeEN.ProgLangTypeName3 = objRow[convApplicationType.ProgLangTypeName3] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName3].ToString().Trim(); //ProgLangTypeName3
objvApplicationTypeEN.ProgLangTypeName5 = objRow[convApplicationType.ProgLangTypeName5] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName5].ToString().Trim(); //ProgLangTypeName5
objvApplicationTypeEN.CodeTypeCount = objRow[convApplicationType.CodeTypeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convApplicationType.CodeTypeCount].ToString().Trim()); //代码类型数
objvApplicationTypeEN.CharEncodingId4 = objRow[convApplicationType.CharEncodingId4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId4].ToString().Trim(); //CharEncodingId4
objvApplicationTypeEN.CharEncodingName4 = objRow[convApplicationType.CharEncodingName4] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName4].ToString().Trim(); //CharEncodingName4
objvApplicationTypeEN.ProgLangTypeName4 = objRow[convApplicationType.ProgLangTypeName4] == DBNull.Value ? null : objRow[convApplicationType.ProgLangTypeName4].ToString().Trim(); //ProgLangTypeName4
objvApplicationTypeEN.CharEncodingId5 = objRow[convApplicationType.CharEncodingId5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingId5].ToString().Trim(); //CharEncodingId5
objvApplicationTypeEN.CharEncodingName5 = objRow[convApplicationType.CharEncodingName5] == DBNull.Value ? null : objRow[convApplicationType.CharEncodingName5].ToString().Trim(); //CharEncodingName5
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvApplicationTypeEN.ApplicationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvApplicationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvApplicationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvApplicationType(ref clsvApplicationTypeEN objvApplicationTypeEN)
{
bool bolResult = vApplicationTypeDA.GetvApplicationType(ref objvApplicationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "intApplicationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvApplicationTypeEN GetObjByApplicationTypeId(int intApplicationTypeId)
{
clsvApplicationTypeEN objvApplicationTypeEN = vApplicationTypeDA.GetObjByApplicationTypeId(intApplicationTypeId);
return objvApplicationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvApplicationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvApplicationTypeEN objvApplicationTypeEN = vApplicationTypeDA.GetFirstObj(strWhereCond);
 return objvApplicationTypeEN;
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
public static clsvApplicationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvApplicationTypeEN objvApplicationTypeEN = vApplicationTypeDA.GetObjByDataRow(objRow);
 return objvApplicationTypeEN;
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
public static clsvApplicationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvApplicationTypeEN objvApplicationTypeEN = vApplicationTypeDA.GetObjByDataRow(objRow);
 return objvApplicationTypeEN;
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
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <param name = "lstvApplicationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvApplicationTypeEN GetObjByApplicationTypeIdFromList(int intApplicationTypeId, List<clsvApplicationTypeEN> lstvApplicationTypeObjLst)
{
foreach (clsvApplicationTypeEN objvApplicationTypeEN in lstvApplicationTypeObjLst)
{
if (objvApplicationTypeEN.ApplicationTypeId == intApplicationTypeId)
{
return objvApplicationTypeEN;
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
public static int GetFirstID_S(string strWhereCond) 
{
 int intApplicationTypeId;
 try
 {
 intApplicationTypeId = new clsvApplicationTypeDA().GetFirstID(strWhereCond);
 return intApplicationTypeId;
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
 arrList = vApplicationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vApplicationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "intApplicationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(int intApplicationTypeId)
{
//检测记录是否存在
bool bolIsExist = vApplicationTypeDA.IsExist(intApplicationTypeId);
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
 bolIsExist = clsvApplicationTypeDA.IsExistTable();
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
 bolIsExist = vApplicationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvApplicationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvApplicationTypeEN objvApplicationTypeEN)
{
try
{
objvApplicationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvApplicationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convApplicationType.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ApplicationTypeId = objvApplicationTypeEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convApplicationType.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ApplicationTypeName = objvApplicationTypeEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convApplicationType.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ApplicationTypeSimName = objvApplicationTypeEN.ApplicationTypeSimName == "[null]" ? null :  objvApplicationTypeEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convApplicationType.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ApplicationTypeENName = objvApplicationTypeEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeId = objvApplicationTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeName = objvApplicationTypeEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeENName = objvApplicationTypeEN.ProgLangTypeENName == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeENName; //编程语言类型英文名
}
if (arrFldSet.Contains(convApplicationType.CharEncodingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingId = objvApplicationTypeEN.CharEncodingId; //字符编码
}
if (arrFldSet.Contains(convApplicationType.CharEncodingName, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingName = objvApplicationTypeEN.CharEncodingName == "[null]" ? null :  objvApplicationTypeEN.CharEncodingName; //字符编码名称
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeId2, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeId2 = objvApplicationTypeEN.ProgLangTypeId2 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeId2; //编程语言类型Id2
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeId3, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeId3 = objvApplicationTypeEN.ProgLangTypeId3 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeId3; //编程语言类型Id3
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeId4, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeId4 = objvApplicationTypeEN.ProgLangTypeId4 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeId4; //编程语言类型Id4
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeId5, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeId5 = objvApplicationTypeEN.ProgLangTypeId5 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeId5; //编程语言类型Id5
}
if (arrFldSet.Contains(convApplicationType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.IsVisible = objvApplicationTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convApplicationType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.OrderNum = objvApplicationTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convApplicationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.Memo = objvApplicationTypeEN.Memo == "[null]" ? null :  objvApplicationTypeEN.Memo; //说明
}
if (arrFldSet.Contains(convApplicationType.CharEncodingId2, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingId2 = objvApplicationTypeEN.CharEncodingId2 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingId2; //CharEncodingId2
}
if (arrFldSet.Contains(convApplicationType.CharEncodingId3, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingId3 = objvApplicationTypeEN.CharEncodingId3 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingId3; //CharEncodingId3
}
if (arrFldSet.Contains(convApplicationType.CharEncodingName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingName2 = objvApplicationTypeEN.CharEncodingName2 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingName2; //CharEncodingName2
}
if (arrFldSet.Contains(convApplicationType.CharEncodingName3, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingName3 = objvApplicationTypeEN.CharEncodingName3 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingName3; //CharEncodingName3
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeName2, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeName2 = objvApplicationTypeEN.ProgLangTypeName2 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeName2; //ProgLangTypeName2
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeName3, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeName3 = objvApplicationTypeEN.ProgLangTypeName3 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeName3; //ProgLangTypeName3
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeName5, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeName5 = objvApplicationTypeEN.ProgLangTypeName5 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeName5; //ProgLangTypeName5
}
if (arrFldSet.Contains(convApplicationType.CodeTypeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CodeTypeCount = objvApplicationTypeEN.CodeTypeCount; //代码类型数
}
if (arrFldSet.Contains(convApplicationType.CharEncodingId4, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingId4 = objvApplicationTypeEN.CharEncodingId4 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingId4; //CharEncodingId4
}
if (arrFldSet.Contains(convApplicationType.CharEncodingName4, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingName4 = objvApplicationTypeEN.CharEncodingName4 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingName4; //CharEncodingName4
}
if (arrFldSet.Contains(convApplicationType.ProgLangTypeName4, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.ProgLangTypeName4 = objvApplicationTypeEN.ProgLangTypeName4 == "[null]" ? null :  objvApplicationTypeEN.ProgLangTypeName4; //ProgLangTypeName4
}
if (arrFldSet.Contains(convApplicationType.CharEncodingId5, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingId5 = objvApplicationTypeEN.CharEncodingId5 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingId5; //CharEncodingId5
}
if (arrFldSet.Contains(convApplicationType.CharEncodingName5, new clsStrCompareIgnoreCase())  ==  true)
{
objvApplicationTypeEN.CharEncodingName5 = objvApplicationTypeEN.CharEncodingName5 == "[null]" ? null :  objvApplicationTypeEN.CharEncodingName5; //CharEncodingName5
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
 /// <param name = "objvApplicationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvApplicationTypeEN objvApplicationTypeEN)
{
try
{
if (objvApplicationTypeEN.ApplicationTypeSimName == "[null]") objvApplicationTypeEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvApplicationTypeEN.ProgLangTypeENName == "[null]") objvApplicationTypeEN.ProgLangTypeENName = null; //编程语言类型英文名
if (objvApplicationTypeEN.CharEncodingName == "[null]") objvApplicationTypeEN.CharEncodingName = null; //字符编码名称
if (objvApplicationTypeEN.ProgLangTypeId2 == "[null]") objvApplicationTypeEN.ProgLangTypeId2 = null; //编程语言类型Id2
if (objvApplicationTypeEN.ProgLangTypeId3 == "[null]") objvApplicationTypeEN.ProgLangTypeId3 = null; //编程语言类型Id3
if (objvApplicationTypeEN.ProgLangTypeId4 == "[null]") objvApplicationTypeEN.ProgLangTypeId4 = null; //编程语言类型Id4
if (objvApplicationTypeEN.ProgLangTypeId5 == "[null]") objvApplicationTypeEN.ProgLangTypeId5 = null; //编程语言类型Id5
if (objvApplicationTypeEN.Memo == "[null]") objvApplicationTypeEN.Memo = null; //说明
if (objvApplicationTypeEN.CharEncodingId2 == "[null]") objvApplicationTypeEN.CharEncodingId2 = null; //CharEncodingId2
if (objvApplicationTypeEN.CharEncodingId3 == "[null]") objvApplicationTypeEN.CharEncodingId3 = null; //CharEncodingId3
if (objvApplicationTypeEN.CharEncodingName2 == "[null]") objvApplicationTypeEN.CharEncodingName2 = null; //CharEncodingName2
if (objvApplicationTypeEN.CharEncodingName3 == "[null]") objvApplicationTypeEN.CharEncodingName3 = null; //CharEncodingName3
if (objvApplicationTypeEN.ProgLangTypeName2 == "[null]") objvApplicationTypeEN.ProgLangTypeName2 = null; //ProgLangTypeName2
if (objvApplicationTypeEN.ProgLangTypeName3 == "[null]") objvApplicationTypeEN.ProgLangTypeName3 = null; //ProgLangTypeName3
if (objvApplicationTypeEN.ProgLangTypeName5 == "[null]") objvApplicationTypeEN.ProgLangTypeName5 = null; //ProgLangTypeName5
if (objvApplicationTypeEN.CharEncodingId4 == "[null]") objvApplicationTypeEN.CharEncodingId4 = null; //CharEncodingId4
if (objvApplicationTypeEN.CharEncodingName4 == "[null]") objvApplicationTypeEN.CharEncodingName4 = null; //CharEncodingName4
if (objvApplicationTypeEN.ProgLangTypeName4 == "[null]") objvApplicationTypeEN.ProgLangTypeName4 = null; //ProgLangTypeName4
if (objvApplicationTypeEN.CharEncodingId5 == "[null]") objvApplicationTypeEN.CharEncodingId5 = null; //CharEncodingId5
if (objvApplicationTypeEN.CharEncodingName5 == "[null]") objvApplicationTypeEN.CharEncodingName5 = null; //CharEncodingName5
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
public static void CheckProperty4Condition(clsvApplicationTypeEN objvApplicationTypeEN)
{
 vApplicationTypeDA.CheckProperty4Condition(objvApplicationTypeEN);
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
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCharEncodingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCharEncodingBL没有刷新缓存机制(clsCharEncodingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ApplicationTypeId");
//if (arrvApplicationTypeObjLstCache == null)
//{
//arrvApplicationTypeObjLstCache = vApplicationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "intApplicationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvApplicationTypeEN GetObjByApplicationTypeIdCache(int intApplicationTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrvApplicationTypeObjLst_Sel =
arrvApplicationTypeObjLstCache
.Where(x=> x.ApplicationTypeId == intApplicationTypeId 
);
if (arrvApplicationTypeObjLst_Sel.Count() == 0)
{
   clsvApplicationTypeEN obj = clsvApplicationTypeBL.GetObjByApplicationTypeId(intApplicationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvApplicationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvApplicationTypeEN> GetAllvApplicationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = GetObjLstCache(); 
return arrvApplicationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvApplicationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
List<clsvApplicationTypeEN> arrvApplicationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvApplicationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvApplicationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvApplicationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvApplicationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsvApplicationTypeEN._RefreshTimeLst[clsvApplicationTypeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, int intApplicationTypeId)
{
if (strInFldName != convApplicationType.ApplicationTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convApplicationType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convApplicationType._AttributeName));
throw new Exception(strMsg);
}
var objvApplicationType = clsvApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
if (objvApplicationType == null) return "";
return objvApplicationType[strOutFldName].ToString();
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
int intRecCount = clsvApplicationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvApplicationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvApplicationTypeDA.GetRecCount();
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
int intRecCount = clsvApplicationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvApplicationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvApplicationTypeEN objvApplicationTypeCond)
{
List<clsvApplicationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvApplicationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convApplicationType._AttributeName)
{
if (objvApplicationTypeCond.IsUpdated(strFldName) == false) continue;
if (objvApplicationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvApplicationTypeCond[strFldName].ToString());
}
else
{
if (objvApplicationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvApplicationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvApplicationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvApplicationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvApplicationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvApplicationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvApplicationTypeCond[strFldName]));
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
 List<string> arrList = clsvApplicationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vApplicationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vApplicationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}