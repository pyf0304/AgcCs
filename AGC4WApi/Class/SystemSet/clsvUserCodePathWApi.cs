
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePathWApi
 表名:vUserCodePath(00050205)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserCodePathWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetmId(this clsvUserCodePathEN objvUserCodePathEN, long lngmId, string strComparisonOp="")
	{
objvUserCodePathEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.mId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.mId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.mId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCMProjectAppRelaId(this clsvUserCodePathEN objvUserCodePathEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCMProjectAppRelaId, convUserCodePath.CMProjectAppRelaId);
objvUserCodePathEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CMProjectAppRelaId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CMProjectAppRelaId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CMProjectAppRelaId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convUserCodePath.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convUserCodePath.CodeTypeId);
objvUserCodePathEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodeTypeId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodeTypeId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodeTypeId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convUserCodePath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convUserCodePath.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convUserCodePath.ProgLangTypeId);
objvUserCodePathEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ProgLangTypeId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ProgLangTypeId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ProgLangTypeId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convUserCodePath.ProgLangTypeName);
objvUserCodePathEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ProgLangTypeName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ProgLangTypeName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ProgLangTypeName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCmPrjId(this clsvUserCodePathEN objvUserCodePathEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convUserCodePath.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convUserCodePath.CmPrjId);
objvUserCodePathEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CmPrjId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CmPrjId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CmPrjId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convUserCodePath.ApplicationTypeName);
objvUserCodePathEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ApplicationTypeName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ApplicationTypeName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ApplicationTypeName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeENName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convUserCodePath.ApplicationTypeENName);
objvUserCodePathEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ApplicationTypeENName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ApplicationTypeENName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ApplicationTypeENName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjFileStateName">工程文件状态名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjFileStateName(this clsvUserCodePathEN objvUserCodePathEN, string strPrjFileStateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjFileStateName, 30, convUserCodePath.PrjFileStateName);
objvUserCodePathEN.PrjFileStateName = strPrjFileStateName; //工程文件状态名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.PrjFileStateName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.PrjFileStateName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.PrjFileStateName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppOrderNum">AppOrderNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetAppOrderNum(this clsvUserCodePathEN objvUserCodePathEN, int intAppOrderNum, string strComparisonOp="")
	{
objvUserCodePathEN.AppOrderNum = intAppOrderNum; //AppOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.AppOrderNum) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.AppOrderNum, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.AppOrderNum] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strNewCodePath">NewCodePath</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetNewCodePath(this clsvUserCodePathEN objvUserCodePathEN, string strNewCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewCodePath, convUserCodePath.NewCodePath);
clsCheckSql.CheckFieldLen(strNewCodePath, 2, convUserCodePath.NewCodePath);
objvUserCodePathEN.NewCodePath = strNewCodePath; //NewCodePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.NewCodePath) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.NewCodePath, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.NewCodePath] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strNewCodePathBackup">新备份目录</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetNewCodePathBackup(this clsvUserCodePathEN objvUserCodePathEN, string strNewCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewCodePathBackup, convUserCodePath.NewCodePathBackup);
clsCheckSql.CheckFieldLen(strNewCodePathBackup, 2, convUserCodePath.NewCodePathBackup);
objvUserCodePathEN.NewCodePathBackup = strNewCodePathBackup; //新备份目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.NewCodePathBackup) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.NewCodePathBackup, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.NewCodePathBackup] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convUserCodePath.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convUserCodePath.CodeTypeName);
objvUserCodePathEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodeTypeName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodeTypeName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodeTypeName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeENName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convUserCodePath.CodeTypeENName);
objvUserCodePathEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodeTypeENName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodeTypeENName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodeTypeENName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetOrderNum(this clsvUserCodePathEN objvUserCodePathEN, int intOrderNum, string strComparisonOp="")
	{
objvUserCodePathEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.OrderNum) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.OrderNum, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.OrderNum] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeId(this clsvUserCodePathEN objvUserCodePathEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convUserCodePath.ApplicationTypeId);
objvUserCodePathEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ApplicationTypeId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ApplicationTypeId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ApplicationTypeId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeId">表主类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetTabMainTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convUserCodePath.TabMainTypeId);
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convUserCodePath.TabMainTypeId);
objvUserCodePathEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.TabMainTypeId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.TabMainTypeId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.TabMainTypeId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsGeneCode(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsGeneCode, convUserCodePath.IsGeneCode);
objvUserCodePathEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsGeneCode) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsGeneCode, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsGeneCode] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectFileName">工程文件名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProjectFileName(this clsvUserCodePathEN objvUserCodePathEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectFileName, convUserCodePath.ProjectFileName);
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convUserCodePath.ProjectFileName);
objvUserCodePathEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ProjectFileName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ProjectFileName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ProjectFileName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProjectPath">工程路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProjectPath(this clsvUserCodePathEN objvUserCodePathEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convUserCodePath.ProjectPath);
clsCheckSql.CheckFieldLen(strProjectPath, 500, convUserCodePath.ProjectPath);
objvUserCodePathEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ProjectPath) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ProjectPath, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ProjectPath] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjFileStateId">工程文件状态Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjFileStateId(this clsvUserCodePathEN objvUserCodePathEN, string strPrjFileStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjFileStateId, 2, convUserCodePath.PrjFileStateId);
clsCheckSql.CheckFieldForeignKey(strPrjFileStateId, 2, convUserCodePath.PrjFileStateId);
objvUserCodePathEN.PrjFileStateId = strPrjFileStateId; //工程文件状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.PrjFileStateId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.PrjFileStateId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.PrjFileStateId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePath">代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodePath(this clsvUserCodePathEN objvUserCodePathEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, convUserCodePath.CodePath);
clsCheckSql.CheckFieldLen(strCodePath, 200, convUserCodePath.CodePath);
objvUserCodePathEN.CodePath = strCodePath; //代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodePath) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodePath, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodePath] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodePathBackup">备份代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodePathBackup(this clsvUserCodePathEN objvUserCodePathEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, convUserCodePath.CodePathBackup);
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, convUserCodePath.CodePathBackup);
objvUserCodePathEN.CodePathBackup = strCodePathBackup; //备份代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodePathBackup) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodePathBackup, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodePathBackup] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strSuffixPath">后缀路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetSuffixPath(this clsvUserCodePathEN objvUserCodePathEN, string strSuffixPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSuffixPath, 50, convUserCodePath.SuffixPath);
objvUserCodePathEN.SuffixPath = strSuffixPath; //后缀路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.SuffixPath) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.SuffixPath, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.SuffixPath] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsTemplate(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convUserCodePath.IsTemplate);
objvUserCodePathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsTemplate) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsTemplate, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsTemplate] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistCodePath">是否存在代码路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsExistCodePath(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsExistCodePath, string strComparisonOp="")
	{
objvUserCodePathEN.IsExistCodePath = bolIsExistCodePath; //是否存在代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsExistCodePath) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsExistCodePath, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsExistCodePath] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistCodePathBackup">是否存在备份路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsExistCodePathBackup(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsExistCodePathBackup, string strComparisonOp="")
	{
objvUserCodePathEN.IsExistCodePathBackup = bolIsExistCodePathBackup; //是否存在备份路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsExistCodePathBackup) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsExistCodePathBackup, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsExistCodePathBackup] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjId(this clsvUserCodePathEN objvUserCodePathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserCodePath.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserCodePath.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserCodePath.PrjId);
objvUserCodePathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.PrjId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.PrjId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.PrjId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetUpdDate(this clsvUserCodePathEN objvUserCodePathEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserCodePath.UpdDate);
objvUserCodePathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.UpdDate) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.UpdDate, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.UpdDate] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetUpdUserId(this clsvUserCodePathEN objvUserCodePathEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserCodePath.UpdUserId);
objvUserCodePathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.UpdUserId) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.UpdUserId, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.UpdUserId] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetMemo(this clsvUserCodePathEN objvUserCodePathEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserCodePath.Memo);
objvUserCodePathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.Memo) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.Memo, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.Memo] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convUserCodePath.ProgLangTypeSimName);
objvUserCodePathEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ProgLangTypeSimName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ProgLangTypeSimName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ProgLangTypeSimName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convUserCodePath.ApplicationTypeSimName);
objvUserCodePathEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.ApplicationTypeSimName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCmPrjName(this clsvUserCodePathEN objvUserCodePathEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convUserCodePath.CmPrjName);
objvUserCodePathEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CmPrjName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CmPrjName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CmPrjName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabMainTypeName">表主类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetTabMainTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strTabMainTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convUserCodePath.TabMainTypeName);
objvUserCodePathEN.TabMainTypeName = strTabMainTypeName; //表主类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.TabMainTypeName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.TabMainTypeName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.TabMainTypeName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convUserCodePath.CodeTypeSimName);
objvUserCodePathEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.CodeTypeSimName) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.CodeTypeSimName, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.CodeTypeSimName] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistCodePathP">是否存在代码目录P</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsExistCodePathP(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsExistCodePathP, string strComparisonOp="")
	{
objvUserCodePathEN.IsExistCodePathP = bolIsExistCodePathP; //是否存在代码目录P
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsExistCodePathP) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsExistCodePathP, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsExistCodePathP] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistCodePathBackupP">是否存在备份目录P</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetIsExistCodePathBackupP(this clsvUserCodePathEN objvUserCodePathEN, bool bolIsExistCodePathBackupP, string strComparisonOp="")
	{
objvUserCodePathEN.IsExistCodePathBackupP = bolIsExistCodePathBackupP; //是否存在备份目录P
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserCodePathEN.dicFldComparisonOp.ContainsKey(convUserCodePath.IsExistCodePathBackupP) == false)
{
objvUserCodePathEN.dicFldComparisonOp.Add(convUserCodePath.IsExistCodePathBackupP, strComparisonOp);
}
else
{
objvUserCodePathEN.dicFldComparisonOp[convUserCodePath.IsExistCodePathBackupP] = strComparisonOp;
}
}
return objvUserCodePathEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserCodePathEN objvUserCodePathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserCodePathCond.IsUpdated(convUserCodePath.mId) == true)
{
string strComparisonOpmId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePath.mId, objvUserCodePathCond.mId, strComparisonOpmId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePath.CMProjectAppRelaId, objvUserCodePathCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodeTypeId, objvUserCodePathCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ProgLangTypeId, objvUserCodePathCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ProgLangTypeName, objvUserCodePathCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CmPrjId, objvUserCodePathCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ApplicationTypeName, objvUserCodePathCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ApplicationTypeENName, objvUserCodePathCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.PrjFileStateName) == true)
{
string strComparisonOpPrjFileStateName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.PrjFileStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.PrjFileStateName, objvUserCodePathCond.PrjFileStateName, strComparisonOpPrjFileStateName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.AppOrderNum) == true)
{
string strComparisonOpAppOrderNum = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.AppOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePath.AppOrderNum, objvUserCodePathCond.AppOrderNum, strComparisonOpAppOrderNum);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.NewCodePath) == true)
{
string strComparisonOpNewCodePath = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.NewCodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.NewCodePath, objvUserCodePathCond.NewCodePath, strComparisonOpNewCodePath);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.NewCodePathBackup) == true)
{
string strComparisonOpNewCodePathBackup = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.NewCodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.NewCodePathBackup, objvUserCodePathCond.NewCodePathBackup, strComparisonOpNewCodePathBackup);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodeTypeName, objvUserCodePathCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodeTypeENName, objvUserCodePathCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.OrderNum) == true)
{
string strComparisonOpOrderNum = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePath.OrderNum, objvUserCodePathCond.OrderNum, strComparisonOpOrderNum);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserCodePath.ApplicationTypeId, objvUserCodePathCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.TabMainTypeId, objvUserCodePathCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsGeneCode) == true)
{
if (objvUserCodePathCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsGeneCode);
}
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ProjectFileName, objvUserCodePathCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ProjectPath) == true)
{
string strComparisonOpProjectPath = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ProjectPath, objvUserCodePathCond.ProjectPath, strComparisonOpProjectPath);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.PrjFileStateId) == true)
{
string strComparisonOpPrjFileStateId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.PrjFileStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.PrjFileStateId, objvUserCodePathCond.PrjFileStateId, strComparisonOpPrjFileStateId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodePath) == true)
{
string strComparisonOpCodePath = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodePath, objvUserCodePathCond.CodePath, strComparisonOpCodePath);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodePathBackup) == true)
{
string strComparisonOpCodePathBackup = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodePathBackup, objvUserCodePathCond.CodePathBackup, strComparisonOpCodePathBackup);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.SuffixPath) == true)
{
string strComparisonOpSuffixPath = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.SuffixPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.SuffixPath, objvUserCodePathCond.SuffixPath, strComparisonOpSuffixPath);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsTemplate) == true)
{
if (objvUserCodePathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsTemplate);
}
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsExistCodePath) == true)
{
if (objvUserCodePathCond.IsExistCodePath == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsExistCodePath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsExistCodePath);
}
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsExistCodePathBackup) == true)
{
if (objvUserCodePathCond.IsExistCodePathBackup == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsExistCodePathBackup);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsExistCodePathBackup);
}
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.PrjId) == true)
{
string strComparisonOpPrjId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.PrjId, objvUserCodePathCond.PrjId, strComparisonOpPrjId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.UpdDate, objvUserCodePathCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.UpdUserId, objvUserCodePathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.Memo) == true)
{
string strComparisonOpMemo = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.Memo, objvUserCodePathCond.Memo, strComparisonOpMemo);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ProgLangTypeSimName, objvUserCodePathCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.ApplicationTypeSimName, objvUserCodePathCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CmPrjName, objvUserCodePathCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.TabMainTypeName) == true)
{
string strComparisonOpTabMainTypeName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.TabMainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.TabMainTypeName, objvUserCodePathCond.TabMainTypeName, strComparisonOpTabMainTypeName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvUserCodePathCond.dicFldComparisonOp[convUserCodePath.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserCodePath.CodeTypeSimName, objvUserCodePathCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsExistCodePathP) == true)
{
if (objvUserCodePathCond.IsExistCodePathP == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsExistCodePathP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsExistCodePathP);
}
}
if (objvUserCodePathCond.IsUpdated(convUserCodePath.IsExistCodePathBackupP) == true)
{
if (objvUserCodePathCond.IsExistCodePathBackupP == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserCodePath.IsExistCodePathBackupP);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserCodePath.IsExistCodePathBackupP);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vUserCodePath(v用户生成路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserCodePrjMainPathId_UserId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvUserCodePathEN objvUserCodePathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvUserCodePathEN == null) return "";
if (objvUserCodePathEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objvUserCodePathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvUserCodePathEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvUserCodePathEN.mId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objvUserCodePathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvUserCodePathEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// v用户生成路径(vUserCodePath)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserCodePathWApi
{
private static readonly string mstrApiControllerName = "vUserCodePathApi";

 public clsvUserCodePathWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePathEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvUserCodePathEN objvUserCodePathEN;
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
objvUserCodePathEN = JsonConvert.DeserializeObject<clsvUserCodePathEN>(strJson);
return objvUserCodePathEN;
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
public static clsvUserCodePathEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvUserCodePathEN objvUserCodePathEN;
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
objvUserCodePathEN = JsonConvert.DeserializeObject<clsvUserCodePathEN>(strJson);
return objvUserCodePathEN;
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
public static clsvUserCodePathEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrvUserCodePathObjLst_Sel =
from objvUserCodePathEN in arrvUserCodePathObjLstCache
where objvUserCodePathEN.mId == lngmId 
select objvUserCodePathEN;
if (arrvUserCodePathObjLst_Sel.Count() == 0)
{
   clsvUserCodePathEN obj = clsvUserCodePathWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUserCodePathObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLst(string strWhereCond)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
public static List<clsvUserCodePathEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
public static IEnumerable<clsvUserCodePathEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrvUserCodePathObjLst_Sel =
from objvUserCodePathEN in arrvUserCodePathObjLstCache
where arrMId.Contains(objvUserCodePathEN.mId)
select objvUserCodePathEN;
return arrvUserCodePathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePathEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
public static List<clsvUserCodePathEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
public static List<clsvUserCodePathEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
public static List<clsvUserCodePathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvUserCodePathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserCodePathEN>>(strJson);
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
 /// <param name = "objvUserCodePathENS">源对象</param>
 /// <param name = "objvUserCodePathENT">目标对象</param>
 public static void CopyTo(clsvUserCodePathEN objvUserCodePathENS, clsvUserCodePathEN objvUserCodePathENT)
{
try
{
objvUserCodePathENT.mId = objvUserCodePathENS.mId; //mId
objvUserCodePathENT.CMProjectAppRelaId = objvUserCodePathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvUserCodePathENT.CodeTypeId = objvUserCodePathENS.CodeTypeId; //代码类型Id
objvUserCodePathENT.ProgLangTypeId = objvUserCodePathENS.ProgLangTypeId; //编程语言类型Id
objvUserCodePathENT.ProgLangTypeName = objvUserCodePathENS.ProgLangTypeName; //编程语言类型名
objvUserCodePathENT.CmPrjId = objvUserCodePathENS.CmPrjId; //Cm工程Id
objvUserCodePathENT.ApplicationTypeName = objvUserCodePathENS.ApplicationTypeName; //应用程序类型名称
objvUserCodePathENT.ApplicationTypeENName = objvUserCodePathENS.ApplicationTypeENName; //应用类型英文名
objvUserCodePathENT.PrjFileStateName = objvUserCodePathENS.PrjFileStateName; //工程文件状态名
objvUserCodePathENT.AppOrderNum = objvUserCodePathENS.AppOrderNum; //AppOrderNum
objvUserCodePathENT.NewCodePath = objvUserCodePathENS.NewCodePath; //NewCodePath
objvUserCodePathENT.NewCodePathBackup = objvUserCodePathENS.NewCodePathBackup; //新备份目录
objvUserCodePathENT.CodeTypeName = objvUserCodePathENS.CodeTypeName; //代码类型名
objvUserCodePathENT.CodeTypeENName = objvUserCodePathENS.CodeTypeENName; //代码类型英文名
objvUserCodePathENT.OrderNum = objvUserCodePathENS.OrderNum; //序号
objvUserCodePathENT.ApplicationTypeId = objvUserCodePathENS.ApplicationTypeId; //应用程序类型ID
objvUserCodePathENT.TabMainTypeId = objvUserCodePathENS.TabMainTypeId; //表主类型Id
objvUserCodePathENT.IsGeneCode = objvUserCodePathENS.IsGeneCode; //是否生成代码
objvUserCodePathENT.ProjectFileName = objvUserCodePathENS.ProjectFileName; //工程文件名
objvUserCodePathENT.ProjectPath = objvUserCodePathENS.ProjectPath; //工程路径
objvUserCodePathENT.PrjFileStateId = objvUserCodePathENS.PrjFileStateId; //工程文件状态Id
objvUserCodePathENT.CodePath = objvUserCodePathENS.CodePath; //代码路径
objvUserCodePathENT.CodePathBackup = objvUserCodePathENS.CodePathBackup; //备份代码路径
objvUserCodePathENT.SuffixPath = objvUserCodePathENS.SuffixPath; //后缀路径
objvUserCodePathENT.IsTemplate = objvUserCodePathENS.IsTemplate; //是否模板
objvUserCodePathENT.IsExistCodePath = objvUserCodePathENS.IsExistCodePath; //是否存在代码路径
objvUserCodePathENT.IsExistCodePathBackup = objvUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
objvUserCodePathENT.PrjId = objvUserCodePathENS.PrjId; //工程Id
objvUserCodePathENT.UpdDate = objvUserCodePathENS.UpdDate; //修改日期
objvUserCodePathENT.UpdUserId = objvUserCodePathENS.UpdUserId; //修改用户Id
objvUserCodePathENT.Memo = objvUserCodePathENS.Memo; //说明
objvUserCodePathENT.ProgLangTypeSimName = objvUserCodePathENS.ProgLangTypeSimName; //编程语言类型简称
objvUserCodePathENT.ApplicationTypeSimName = objvUserCodePathENS.ApplicationTypeSimName; //应用程序类型简称
objvUserCodePathENT.CmPrjName = objvUserCodePathENS.CmPrjName; //CM工程名
objvUserCodePathENT.TabMainTypeName = objvUserCodePathENS.TabMainTypeName; //表主类型名
objvUserCodePathENT.CodeTypeSimName = objvUserCodePathENS.CodeTypeSimName; //简称
objvUserCodePathENT.IsExistCodePathP = objvUserCodePathENS.IsExistCodePathP; //是否存在代码目录P
objvUserCodePathENT.IsExistCodePathBackupP = objvUserCodePathENS.IsExistCodePathBackupP; //是否存在备份目录P
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
public static DataTable ToDataTable(List<clsvUserCodePathEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserCodePathEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserCodePathEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserCodePathEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserCodePathEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserCodePathEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvUserCodePathWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvUserCodePathWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
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
public static List<clsvUserCodePathEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvUserCodePathWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvUserCodePathWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvUserCodePathEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvUserCodePathEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convUserCodePath.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvUserCodePathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvUserCodePathEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvUserCodePathWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvUserCodePathWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvUserCodePathObjLstCache = CacheHelper.Get<List<clsvUserCodePathEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvUserCodePathObjLstCache = CacheHelper.Get<List<clsvUserCodePathEN>>(strKey);
}
return arrvUserCodePathObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserCodePathEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserCodePath.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserCodePath.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserCodePath.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.PrjFileStateName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.AppOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserCodePath.NewCodePath, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.NewCodePathBackup, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserCodePath.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserCodePath.TabMainTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.IsGeneCode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePath.ProjectFileName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ProjectPath, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.PrjFileStateId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CodePath, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CodePathBackup, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.SuffixPath, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePath.IsExistCodePath, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePath.IsExistCodePathBackup, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePath.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.TabMainTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convUserCodePath.IsExistCodePathP, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserCodePath.IsExistCodePathBackupP, Type.GetType("System.Boolean"));
foreach (clsvUserCodePathEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserCodePath.mId] = objInFor[convUserCodePath.mId];
objDR[convUserCodePath.CMProjectAppRelaId] = objInFor[convUserCodePath.CMProjectAppRelaId];
objDR[convUserCodePath.CodeTypeId] = objInFor[convUserCodePath.CodeTypeId];
objDR[convUserCodePath.ProgLangTypeId] = objInFor[convUserCodePath.ProgLangTypeId];
objDR[convUserCodePath.ProgLangTypeName] = objInFor[convUserCodePath.ProgLangTypeName];
objDR[convUserCodePath.CmPrjId] = objInFor[convUserCodePath.CmPrjId];
objDR[convUserCodePath.ApplicationTypeName] = objInFor[convUserCodePath.ApplicationTypeName];
objDR[convUserCodePath.ApplicationTypeENName] = objInFor[convUserCodePath.ApplicationTypeENName];
objDR[convUserCodePath.PrjFileStateName] = objInFor[convUserCodePath.PrjFileStateName];
objDR[convUserCodePath.AppOrderNum] = objInFor[convUserCodePath.AppOrderNum];
objDR[convUserCodePath.NewCodePath] = objInFor[convUserCodePath.NewCodePath];
objDR[convUserCodePath.NewCodePathBackup] = objInFor[convUserCodePath.NewCodePathBackup];
objDR[convUserCodePath.CodeTypeName] = objInFor[convUserCodePath.CodeTypeName];
objDR[convUserCodePath.CodeTypeENName] = objInFor[convUserCodePath.CodeTypeENName];
objDR[convUserCodePath.OrderNum] = objInFor[convUserCodePath.OrderNum];
objDR[convUserCodePath.ApplicationTypeId] = objInFor[convUserCodePath.ApplicationTypeId];
objDR[convUserCodePath.TabMainTypeId] = objInFor[convUserCodePath.TabMainTypeId];
objDR[convUserCodePath.IsGeneCode] = objInFor[convUserCodePath.IsGeneCode];
objDR[convUserCodePath.ProjectFileName] = objInFor[convUserCodePath.ProjectFileName];
objDR[convUserCodePath.ProjectPath] = objInFor[convUserCodePath.ProjectPath];
objDR[convUserCodePath.PrjFileStateId] = objInFor[convUserCodePath.PrjFileStateId];
objDR[convUserCodePath.CodePath] = objInFor[convUserCodePath.CodePath];
objDR[convUserCodePath.CodePathBackup] = objInFor[convUserCodePath.CodePathBackup];
objDR[convUserCodePath.SuffixPath] = objInFor[convUserCodePath.SuffixPath];
objDR[convUserCodePath.IsTemplate] = objInFor[convUserCodePath.IsTemplate];
objDR[convUserCodePath.IsExistCodePath] = objInFor[convUserCodePath.IsExistCodePath];
objDR[convUserCodePath.IsExistCodePathBackup] = objInFor[convUserCodePath.IsExistCodePathBackup];
objDR[convUserCodePath.PrjId] = objInFor[convUserCodePath.PrjId];
objDR[convUserCodePath.UpdDate] = objInFor[convUserCodePath.UpdDate];
objDR[convUserCodePath.UpdUserId] = objInFor[convUserCodePath.UpdUserId];
objDR[convUserCodePath.Memo] = objInFor[convUserCodePath.Memo];
objDR[convUserCodePath.ProgLangTypeSimName] = objInFor[convUserCodePath.ProgLangTypeSimName];
objDR[convUserCodePath.ApplicationTypeSimName] = objInFor[convUserCodePath.ApplicationTypeSimName];
objDR[convUserCodePath.CmPrjName] = objInFor[convUserCodePath.CmPrjName];
objDR[convUserCodePath.TabMainTypeName] = objInFor[convUserCodePath.TabMainTypeName];
objDR[convUserCodePath.CodeTypeSimName] = objInFor[convUserCodePath.CodeTypeSimName];
objDR[convUserCodePath.IsExistCodePathP] = objInFor[convUserCodePath.IsExistCodePathP];
objDR[convUserCodePath.IsExistCodePathBackupP] = objInFor[convUserCodePath.IsExistCodePathBackupP];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}