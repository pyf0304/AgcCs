
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePathBL
 表名:vUserCodePath(00050205)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserCodePathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePathEN GetObj(this K_mId_vUserCodePath myKey)
{
clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathBL.vUserCodePathDA.GetObjBymId(myKey.Value);
return objvUserCodePathEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convUserCodePath.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convUserCodePath.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convUserCodePath.CodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convUserCodePath.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convUserCodePath.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convUserCodePath.ProgLangTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convUserCodePath.ProgLangTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCmPrjId(this clsvUserCodePathEN objvUserCodePathEN, string strCmPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convUserCodePath.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convUserCodePath.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convUserCodePath.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeENName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convUserCodePath.ApplicationTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjFileStateName(this clsvUserCodePathEN objvUserCodePathEN, string strPrjFileStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileStateName, 30, convUserCodePath.PrjFileStateName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetAppOrderNum(this clsvUserCodePathEN objvUserCodePathEN, int? intAppOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetNewCodePath(this clsvUserCodePathEN objvUserCodePathEN, string strNewCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewCodePath, convUserCodePath.NewCodePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewCodePath, 2, convUserCodePath.NewCodePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetNewCodePathBackup(this clsvUserCodePathEN objvUserCodePathEN, string strNewCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewCodePathBackup, convUserCodePath.NewCodePathBackup);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewCodePathBackup, 2, convUserCodePath.NewCodePathBackup);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convUserCodePath.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convUserCodePath.CodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeENName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convUserCodePath.CodeTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetOrderNum(this clsvUserCodePathEN objvUserCodePathEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetTabMainTypeId(this clsvUserCodePathEN objvUserCodePathEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, convUserCodePath.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, convUserCodePath.TabMainTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProjectFileName(this clsvUserCodePathEN objvUserCodePathEN, string strProjectFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectFileName, convUserCodePath.ProjectFileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, convUserCodePath.ProjectFileName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProjectPath(this clsvUserCodePathEN objvUserCodePathEN, string strProjectPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProjectPath, convUserCodePath.ProjectPath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, convUserCodePath.ProjectPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjFileStateId(this clsvUserCodePathEN objvUserCodePathEN, string strPrjFileStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileStateId, 2, convUserCodePath.PrjFileStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjFileStateId, 2, convUserCodePath.PrjFileStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodePath(this clsvUserCodePathEN objvUserCodePathEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, convUserCodePath.CodePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePath, 200, convUserCodePath.CodePath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodePathBackup(this clsvUserCodePathEN objvUserCodePathEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, convUserCodePath.CodePathBackup);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, convUserCodePath.CodePathBackup);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetSuffixPath(this clsvUserCodePathEN objvUserCodePathEN, string strSuffixPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuffixPath, 50, convUserCodePath.SuffixPath);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetPrjId(this clsvUserCodePathEN objvUserCodePathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserCodePath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserCodePath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserCodePath.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetUpdDate(this clsvUserCodePathEN objvUserCodePathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserCodePath.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetUpdUserId(this clsvUserCodePathEN objvUserCodePathEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserCodePath.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetMemo(this clsvUserCodePathEN objvUserCodePathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserCodePath.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetProgLangTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, convUserCodePath.ProgLangTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetApplicationTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convUserCodePath.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCmPrjName(this clsvUserCodePathEN objvUserCodePathEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convUserCodePath.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetTabMainTypeName(this clsvUserCodePathEN objvUserCodePathEN, string strTabMainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeName, 30, convUserCodePath.TabMainTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserCodePathEN SetCodeTypeSimName(this clsvUserCodePathEN objvUserCodePathEN, string strCodeTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convUserCodePath.CodeTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserCodePathEN">需要设置字段值的实体对象</param>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserCodePathENS">源对象</param>
 /// <param name = "objvUserCodePathENT">目标对象</param>
 public static void CopyTo(this clsvUserCodePathEN objvUserCodePathENS, clsvUserCodePathEN objvUserCodePathENT)
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
 /// <param name = "objvUserCodePathENS">源对象</param>
 /// <returns>目标对象=>clsvUserCodePathEN:objvUserCodePathENT</returns>
 public static clsvUserCodePathEN CopyTo(this clsvUserCodePathEN objvUserCodePathENS)
{
try
{
 clsvUserCodePathEN objvUserCodePathENT = new clsvUserCodePathEN()
{
mId = objvUserCodePathENS.mId, //mId
CMProjectAppRelaId = objvUserCodePathENS.CMProjectAppRelaId, //Cm工程应用关系Id
CodeTypeId = objvUserCodePathENS.CodeTypeId, //代码类型Id
ProgLangTypeId = objvUserCodePathENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvUserCodePathENS.ProgLangTypeName, //编程语言类型名
CmPrjId = objvUserCodePathENS.CmPrjId, //Cm工程Id
ApplicationTypeName = objvUserCodePathENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvUserCodePathENS.ApplicationTypeENName, //应用类型英文名
PrjFileStateName = objvUserCodePathENS.PrjFileStateName, //工程文件状态名
AppOrderNum = objvUserCodePathENS.AppOrderNum, //AppOrderNum
NewCodePath = objvUserCodePathENS.NewCodePath, //NewCodePath
NewCodePathBackup = objvUserCodePathENS.NewCodePathBackup, //新备份目录
CodeTypeName = objvUserCodePathENS.CodeTypeName, //代码类型名
CodeTypeENName = objvUserCodePathENS.CodeTypeENName, //代码类型英文名
OrderNum = objvUserCodePathENS.OrderNum, //序号
ApplicationTypeId = objvUserCodePathENS.ApplicationTypeId, //应用程序类型ID
TabMainTypeId = objvUserCodePathENS.TabMainTypeId, //表主类型Id
IsGeneCode = objvUserCodePathENS.IsGeneCode, //是否生成代码
ProjectFileName = objvUserCodePathENS.ProjectFileName, //工程文件名
ProjectPath = objvUserCodePathENS.ProjectPath, //工程路径
PrjFileStateId = objvUserCodePathENS.PrjFileStateId, //工程文件状态Id
CodePath = objvUserCodePathENS.CodePath, //代码路径
CodePathBackup = objvUserCodePathENS.CodePathBackup, //备份代码路径
SuffixPath = objvUserCodePathENS.SuffixPath, //后缀路径
IsTemplate = objvUserCodePathENS.IsTemplate, //是否模板
IsExistCodePath = objvUserCodePathENS.IsExistCodePath, //是否存在代码路径
IsExistCodePathBackup = objvUserCodePathENS.IsExistCodePathBackup, //是否存在备份路径
PrjId = objvUserCodePathENS.PrjId, //工程Id
UpdDate = objvUserCodePathENS.UpdDate, //修改日期
UpdUserId = objvUserCodePathENS.UpdUserId, //修改用户Id
Memo = objvUserCodePathENS.Memo, //说明
ProgLangTypeSimName = objvUserCodePathENS.ProgLangTypeSimName, //编程语言类型简称
ApplicationTypeSimName = objvUserCodePathENS.ApplicationTypeSimName, //应用程序类型简称
CmPrjName = objvUserCodePathENS.CmPrjName, //CM工程名
TabMainTypeName = objvUserCodePathENS.TabMainTypeName, //表主类型名
CodeTypeSimName = objvUserCodePathENS.CodeTypeSimName, //简称
IsExistCodePathP = objvUserCodePathENS.IsExistCodePathP, //是否存在代码目录P
IsExistCodePathBackupP = objvUserCodePathENS.IsExistCodePathBackupP, //是否存在备份目录P
};
 return objvUserCodePathENT;
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
public static void CheckProperty4Condition(this clsvUserCodePathEN objvUserCodePathEN)
{
 clsvUserCodePathBL.vUserCodePathDA.CheckProperty4Condition(objvUserCodePathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--vUserCodePath(v用户生成路径), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserCodePrjMainPathId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvUserCodePathEN objvUserCodePathEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvUserCodePathEN == null) return true;
if (objvUserCodePathEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objvUserCodePathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvUserCodePathEN.CodeTypeId);
if (clsvUserCodePathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvUserCodePathEN.mId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objvUserCodePathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvUserCodePathEN.CodeTypeId);
if (clsvUserCodePathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vUserCodePath(v用户生成路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserCodePrjMainPathId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvUserCodePathEN objvUserCodePathEN)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserCodePath
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户生成路径(vUserCodePath)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserCodePathBL
{
public static RelatedActions_vUserCodePath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserCodePathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserCodePathDA vUserCodePathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserCodePathDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserCodePathBL()
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
if (string.IsNullOrEmpty(clsvUserCodePathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserCodePathEN._ConnectString);
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
public static DataTable GetDataTable_vUserCodePath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserCodePathDA.GetDataTable_vUserCodePath(strWhereCond);
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
objDT = vUserCodePathDA.GetDataTable(strWhereCond);
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
objDT = vUserCodePathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserCodePathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserCodePathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserCodePathDA.GetDataTable_Top(objTopPara);
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
objDT = vUserCodePathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvUserCodePathEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
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
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserCodePathEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrvUserCodePathObjLst_Sel =
arrvUserCodePathObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvUserCodePathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLst(string strWhereCond)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
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
public static List<clsvUserCodePathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserCodePathEN> GetSubObjLstCache(clsvUserCodePathEN objvUserCodePathCond)
{
 string strPrjId = objvUserCodePathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvUserCodePathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvUserCodePathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserCodePath._AttributeName)
{
if (objvUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objvUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePathCond[strFldName].ToString());
}
else
{
if (objvUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserCodePathCond[strFldName]));
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
public static List<clsvUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
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
public static List<clsvUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
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
List<clsvUserCodePathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserCodePathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
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
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
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
public static List<clsvUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
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
public static List<clsvUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserCodePathEN> arrObjLst = new List<clsvUserCodePathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePathEN objvUserCodePathEN = new clsvUserCodePathEN();
try
{
objvUserCodePathEN.mId = Int32.Parse(objRow[convUserCodePath.mId].ToString().Trim()); //mId
objvUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePathEN.CodeTypeId = objRow[convUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objvUserCodePathEN.ProgLangTypeId = objRow[convUserCodePath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePathEN.ProgLangTypeName = objRow[convUserCodePath.ProgLangTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvUserCodePathEN.CmPrjId = objRow[convUserCodePath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePathEN.ApplicationTypeName = objRow[convUserCodePath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePathEN.ApplicationTypeENName = objRow[convUserCodePath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePathEN.PrjFileStateName = objRow[convUserCodePath.PrjFileStateName] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateName].ToString().Trim(); //工程文件状态名
objvUserCodePathEN.AppOrderNum = objRow[convUserCodePath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePathEN.NewCodePath = objRow[convUserCodePath.NewCodePath].ToString().Trim(); //NewCodePath
objvUserCodePathEN.NewCodePathBackup = objRow[convUserCodePath.NewCodePathBackup].ToString().Trim(); //新备份目录
objvUserCodePathEN.CodeTypeName = objRow[convUserCodePath.CodeTypeName].ToString().Trim(); //代码类型名
objvUserCodePathEN.CodeTypeENName = objRow[convUserCodePath.CodeTypeENName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvUserCodePathEN.OrderNum = objRow[convUserCodePath.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePath.OrderNum].ToString().Trim()); //序号
objvUserCodePathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePathEN.TabMainTypeId = objRow[convUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objvUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objvUserCodePathEN.ProjectFileName = objRow[convUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objvUserCodePathEN.ProjectPath = objRow[convUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objvUserCodePathEN.PrjFileStateId = objRow[convUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[convUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objvUserCodePathEN.CodePath = objRow[convUserCodePath.CodePath].ToString().Trim(); //代码路径
objvUserCodePathEN.CodePathBackup = objRow[convUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objvUserCodePathEN.SuffixPath = objRow[convUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[convUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objvUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objvUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objvUserCodePathEN.PrjId = objRow[convUserCodePath.PrjId].ToString().Trim(); //工程Id
objvUserCodePathEN.UpdDate = objRow[convUserCodePath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePathEN.UpdUserId = objRow[convUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePathEN.Memo = objRow[convUserCodePath.Memo] == DBNull.Value ? null : objRow[convUserCodePath.Memo].ToString().Trim(); //说明
objvUserCodePathEN.ProgLangTypeSimName = objRow[convUserCodePath.ProgLangTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ProgLangTypeSimName].ToString().Trim(); //编程语言类型简称
objvUserCodePathEN.ApplicationTypeSimName = objRow[convUserCodePath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePathEN.CmPrjName = objRow[convUserCodePath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePathEN.TabMainTypeName = objRow[convUserCodePath.TabMainTypeName] == DBNull.Value ? null : objRow[convUserCodePath.TabMainTypeName].ToString().Trim(); //表主类型名
objvUserCodePathEN.CodeTypeSimName = objRow[convUserCodePath.CodeTypeSimName] == DBNull.Value ? null : objRow[convUserCodePath.CodeTypeSimName].ToString().Trim(); //简称
objvUserCodePathEN.IsExistCodePathP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathP].ToString().Trim()); //是否存在代码目录P
objvUserCodePathEN.IsExistCodePathBackupP = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePath.IsExistCodePathBackupP].ToString().Trim()); //是否存在备份目录P
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserCodePathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserCodePathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserCodePath(ref clsvUserCodePathEN objvUserCodePathEN)
{
bool bolResult = vUserCodePathDA.GetvUserCodePath(ref objvUserCodePathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserCodePathEN GetObjBymId(long lngmId)
{
clsvUserCodePathEN objvUserCodePathEN = vUserCodePathDA.GetObjBymId(lngmId);
return objvUserCodePathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserCodePathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserCodePathEN objvUserCodePathEN = vUserCodePathDA.GetFirstObj(strWhereCond);
 return objvUserCodePathEN;
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
public static clsvUserCodePathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserCodePathEN objvUserCodePathEN = vUserCodePathDA.GetObjByDataRow(objRow);
 return objvUserCodePathEN;
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
public static clsvUserCodePathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserCodePathEN objvUserCodePathEN = vUserCodePathDA.GetObjByDataRow(objRow);
 return objvUserCodePathEN;
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
 /// <param name = "lstvUserCodePathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserCodePathEN GetObjBymIdFromList(long lngmId, List<clsvUserCodePathEN> lstvUserCodePathObjLst)
{
foreach (clsvUserCodePathEN objvUserCodePathEN in lstvUserCodePathObjLst)
{
if (objvUserCodePathEN.mId == lngmId)
{
return objvUserCodePathEN;
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
 lngmId = new clsvUserCodePathDA().GetFirstID(strWhereCond);
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
 arrList = vUserCodePathDA.GetID(strWhereCond);
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
bool bolIsExist = vUserCodePathDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vUserCodePathDA.IsExist(lngmId);
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
 bolIsExist = clsvUserCodePathDA.IsExistTable();
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
 bolIsExist = vUserCodePathDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserCodePathEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserCodePathEN objvUserCodePathEN)
{
try
{
objvUserCodePathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserCodePathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserCodePath.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.mId = objvUserCodePathEN.mId; //mId
}
if (arrFldSet.Contains(convUserCodePath.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CMProjectAppRelaId = objvUserCodePathEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(convUserCodePath.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodeTypeId = objvUserCodePathEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convUserCodePath.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ProgLangTypeId = objvUserCodePathEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convUserCodePath.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ProgLangTypeName = objvUserCodePathEN.ProgLangTypeName == "[null]" ? null :  objvUserCodePathEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convUserCodePath.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CmPrjId = objvUserCodePathEN.CmPrjId == "[null]" ? null :  objvUserCodePathEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convUserCodePath.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ApplicationTypeName = objvUserCodePathEN.ApplicationTypeName == "[null]" ? null :  objvUserCodePathEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convUserCodePath.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ApplicationTypeENName = objvUserCodePathEN.ApplicationTypeENName == "[null]" ? null :  objvUserCodePathEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convUserCodePath.PrjFileStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.PrjFileStateName = objvUserCodePathEN.PrjFileStateName == "[null]" ? null :  objvUserCodePathEN.PrjFileStateName; //工程文件状态名
}
if (arrFldSet.Contains(convUserCodePath.AppOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.AppOrderNum = objvUserCodePathEN.AppOrderNum; //AppOrderNum
}
if (arrFldSet.Contains(convUserCodePath.NewCodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.NewCodePath = objvUserCodePathEN.NewCodePath; //NewCodePath
}
if (arrFldSet.Contains(convUserCodePath.NewCodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.NewCodePathBackup = objvUserCodePathEN.NewCodePathBackup; //新备份目录
}
if (arrFldSet.Contains(convUserCodePath.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodeTypeName = objvUserCodePathEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convUserCodePath.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodeTypeENName = objvUserCodePathEN.CodeTypeENName == "[null]" ? null :  objvUserCodePathEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convUserCodePath.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.OrderNum = objvUserCodePathEN.OrderNum; //序号
}
if (arrFldSet.Contains(convUserCodePath.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ApplicationTypeId = objvUserCodePathEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convUserCodePath.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.TabMainTypeId = objvUserCodePathEN.TabMainTypeId == "[null]" ? null :  objvUserCodePathEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(convUserCodePath.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsGeneCode = objvUserCodePathEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(convUserCodePath.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ProjectFileName = objvUserCodePathEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(convUserCodePath.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ProjectPath = objvUserCodePathEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(convUserCodePath.PrjFileStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.PrjFileStateId = objvUserCodePathEN.PrjFileStateId == "[null]" ? null :  objvUserCodePathEN.PrjFileStateId; //工程文件状态Id
}
if (arrFldSet.Contains(convUserCodePath.CodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodePath = objvUserCodePathEN.CodePath; //代码路径
}
if (arrFldSet.Contains(convUserCodePath.CodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodePathBackup = objvUserCodePathEN.CodePathBackup; //备份代码路径
}
if (arrFldSet.Contains(convUserCodePath.SuffixPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.SuffixPath = objvUserCodePathEN.SuffixPath == "[null]" ? null :  objvUserCodePathEN.SuffixPath; //后缀路径
}
if (arrFldSet.Contains(convUserCodePath.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsTemplate = objvUserCodePathEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convUserCodePath.IsExistCodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsExistCodePath = objvUserCodePathEN.IsExistCodePath; //是否存在代码路径
}
if (arrFldSet.Contains(convUserCodePath.IsExistCodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsExistCodePathBackup = objvUserCodePathEN.IsExistCodePathBackup; //是否存在备份路径
}
if (arrFldSet.Contains(convUserCodePath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.PrjId = objvUserCodePathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convUserCodePath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.UpdDate = objvUserCodePathEN.UpdDate == "[null]" ? null :  objvUserCodePathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUserCodePath.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.UpdUserId = objvUserCodePathEN.UpdUserId == "[null]" ? null :  objvUserCodePathEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convUserCodePath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.Memo = objvUserCodePathEN.Memo == "[null]" ? null :  objvUserCodePathEN.Memo; //说明
}
if (arrFldSet.Contains(convUserCodePath.ProgLangTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ProgLangTypeSimName = objvUserCodePathEN.ProgLangTypeSimName == "[null]" ? null :  objvUserCodePathEN.ProgLangTypeSimName; //编程语言类型简称
}
if (arrFldSet.Contains(convUserCodePath.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.ApplicationTypeSimName = objvUserCodePathEN.ApplicationTypeSimName == "[null]" ? null :  objvUserCodePathEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convUserCodePath.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CmPrjName = objvUserCodePathEN.CmPrjName == "[null]" ? null :  objvUserCodePathEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convUserCodePath.TabMainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.TabMainTypeName = objvUserCodePathEN.TabMainTypeName == "[null]" ? null :  objvUserCodePathEN.TabMainTypeName; //表主类型名
}
if (arrFldSet.Contains(convUserCodePath.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.CodeTypeSimName = objvUserCodePathEN.CodeTypeSimName == "[null]" ? null :  objvUserCodePathEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convUserCodePath.IsExistCodePathP, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsExistCodePathP = objvUserCodePathEN.IsExistCodePathP; //是否存在代码目录P
}
if (arrFldSet.Contains(convUserCodePath.IsExistCodePathBackupP, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserCodePathEN.IsExistCodePathBackupP = objvUserCodePathEN.IsExistCodePathBackupP; //是否存在备份目录P
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
 /// <param name = "objvUserCodePathEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserCodePathEN objvUserCodePathEN)
{
try
{
if (objvUserCodePathEN.ProgLangTypeName == "[null]") objvUserCodePathEN.ProgLangTypeName = null; //编程语言类型名
if (objvUserCodePathEN.CmPrjId == "[null]") objvUserCodePathEN.CmPrjId = null; //Cm工程Id
if (objvUserCodePathEN.ApplicationTypeName == "[null]") objvUserCodePathEN.ApplicationTypeName = null; //应用程序类型名称
if (objvUserCodePathEN.ApplicationTypeENName == "[null]") objvUserCodePathEN.ApplicationTypeENName = null; //应用类型英文名
if (objvUserCodePathEN.PrjFileStateName == "[null]") objvUserCodePathEN.PrjFileStateName = null; //工程文件状态名
if (objvUserCodePathEN.CodeTypeENName == "[null]") objvUserCodePathEN.CodeTypeENName = null; //代码类型英文名
if (objvUserCodePathEN.TabMainTypeId == "[null]") objvUserCodePathEN.TabMainTypeId = null; //表主类型Id
if (objvUserCodePathEN.PrjFileStateId == "[null]") objvUserCodePathEN.PrjFileStateId = null; //工程文件状态Id
if (objvUserCodePathEN.SuffixPath == "[null]") objvUserCodePathEN.SuffixPath = null; //后缀路径
if (objvUserCodePathEN.UpdDate == "[null]") objvUserCodePathEN.UpdDate = null; //修改日期
if (objvUserCodePathEN.UpdUserId == "[null]") objvUserCodePathEN.UpdUserId = null; //修改用户Id
if (objvUserCodePathEN.Memo == "[null]") objvUserCodePathEN.Memo = null; //说明
if (objvUserCodePathEN.ProgLangTypeSimName == "[null]") objvUserCodePathEN.ProgLangTypeSimName = null; //编程语言类型简称
if (objvUserCodePathEN.ApplicationTypeSimName == "[null]") objvUserCodePathEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvUserCodePathEN.CmPrjName == "[null]") objvUserCodePathEN.CmPrjName = null; //CM工程名
if (objvUserCodePathEN.TabMainTypeName == "[null]") objvUserCodePathEN.TabMainTypeName = null; //表主类型名
if (objvUserCodePathEN.CodeTypeSimName == "[null]") objvUserCodePathEN.CodeTypeSimName = null; //简称
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
public static void CheckProperty4Condition(clsvUserCodePathEN objvUserCodePathEN)
{
 vUserCodePathDA.CheckProperty4Condition(objvUserCodePathEN);
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
if (clsUserCodePathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePathBL没有刷新缓存机制(clsUserCodePathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFileStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFileStateBL没有刷新缓存机制(clsPrjFileStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTabMainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabMainTypeBL没有刷新缓存机制(clsTabMainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserCodePrjMainPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePrjMainPathBL没有刷新缓存机制(clsUserCodePrjMainPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectAppRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectAppRelaBL没有刷新缓存机制(clsCMProjectAppRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentTypeBL没有刷新缓存机制(clsDepartmentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvUserCodePathObjLstCache == null)
//{
//arrvUserCodePathObjLstCache = vUserCodePathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserCodePathEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrvUserCodePathObjLst_Sel =
arrvUserCodePathObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvUserCodePathObjLst_Sel.Count() == 0)
{
   clsvUserCodePathEN obj = clsvUserCodePathBL.GetObjBymId(lngmId);
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
return arrvUserCodePathObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserCodePathEN> GetAllvUserCodePathObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = GetObjLstCache(strPrjId); 
return arrvUserCodePathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserCodePathEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvUserCodePathEN> arrvUserCodePathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvUserCodePathObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvUserCodePathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvUserCodePathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvUserCodePathEN._RefreshTimeLst.Count == 0) return "";
return clsvUserCodePathEN._RefreshTimeLst[clsvUserCodePathEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vUserCodePath(v用户生成路径)
 /// 唯一性条件:UserCodePrjMainPathId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvUserCodePathEN objvUserCodePathEN)
{
//检测记录是否存在
string strResult = vUserCodePathDA.GetUniCondStr(objvUserCodePathEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convUserCodePath.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserCodePath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserCodePath._AttributeName));
throw new Exception(strMsg);
}
var objvUserCodePath = clsvUserCodePathBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvUserCodePath == null) return "";
return objvUserCodePath[strOutFldName].ToString();
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
int intRecCount = clsvUserCodePathDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserCodePathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserCodePathDA.GetRecCount();
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
int intRecCount = clsvUserCodePathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserCodePathEN objvUserCodePathCond)
{
 string strPrjId = objvUserCodePathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvUserCodePathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvUserCodePathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserCodePath._AttributeName)
{
if (objvUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objvUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePathCond[strFldName].ToString());
}
else
{
if (objvUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserCodePathCond[strFldName]));
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
 List<string> arrList = clsvUserCodePathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserCodePathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserCodePathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}