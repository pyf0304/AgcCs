
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvErrorIdManageBL
 表名:vErrorIdManage(00050302)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsvErrorIdManageBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvErrorIdManageEN GetObj(this K_mId_vErrorIdManage myKey)
{
clsvErrorIdManageEN objvErrorIdManageEN = clsvErrorIdManageBL.vErrorIdManageDA.GetObjBymId(myKey.Value);
return objvErrorIdManageEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetmId(this clsvErrorIdManageEN objvErrorIdManageEN, long lngmId, string strComparisonOp="")
	{
objvErrorIdManageEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.mId) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.mId, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.mId] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetErrID(this clsvErrorIdManageEN objvErrorIdManageEN, string strErrID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrID, convErrorIdManage.ErrID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrID, 10, convErrorIdManage.ErrID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strErrID, 10, convErrorIdManage.ErrID);
}
objvErrorIdManageEN.ErrID = strErrID; //错误Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ErrID) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ErrID, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ErrID] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeId(this clsvErrorIdManageEN objvErrorIdManageEN, string strProgLevelTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLevelTypeId, convErrorIdManage.ProgLevelTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLevelTypeId, 2, convErrorIdManage.ProgLevelTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLevelTypeId, 2, convErrorIdManage.ProgLevelTypeId);
}
objvErrorIdManageEN.ProgLevelTypeId = strProgLevelTypeId; //程序分层类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeId) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeId, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeId] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeName(this clsvErrorIdManageEN objvErrorIdManageEN, string strProgLevelTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLevelTypeName, convErrorIdManage.ProgLevelTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLevelTypeName, 30, convErrorIdManage.ProgLevelTypeName);
}
objvErrorIdManageEN.ProgLevelTypeName = strProgLevelTypeName; //程序分层类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeName) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeName, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeName] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeENName(this clsvErrorIdManageEN objvErrorIdManageEN, string strProgLevelTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLevelTypeENName, 30, convErrorIdManage.ProgLevelTypeENName);
}
objvErrorIdManageEN.ProgLevelTypeENName = strProgLevelTypeENName; //程序分层类型英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeENName) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeENName, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeENName] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetPrefix(this clsvErrorIdManageEN objvErrorIdManageEN, string strPrefix, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrefix, 10, convErrorIdManage.Prefix);
}
objvErrorIdManageEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Prefix) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Prefix, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Prefix] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeId(this clsvErrorIdManageEN objvErrorIdManageEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convErrorIdManage.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convErrorIdManage.CodeTypeId);
}
objvErrorIdManageEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeId) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeId, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeId] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeName(this clsvErrorIdManageEN objvErrorIdManageEN, string strCodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convErrorIdManage.CodeTypeName);
}
objvErrorIdManageEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeName) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeName, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeName] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeENName(this clsvErrorIdManageEN objvErrorIdManageEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convErrorIdManage.CodeTypeENName);
}
objvErrorIdManageEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeENName) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeENName, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeENName] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetFunctionName(this clsvErrorIdManageEN objvErrorIdManageEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convErrorIdManage.FunctionName);
}
objvErrorIdManageEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.FunctionName) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.FunctionName, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.FunctionName] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetExplanation(this clsvErrorIdManageEN objvErrorIdManageEN, string strExplanation, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplanation, 1000, convErrorIdManage.Explanation);
}
objvErrorIdManageEN.Explanation = strExplanation; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Explanation) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Explanation, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Explanation] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetUpdDate(this clsvErrorIdManageEN objvErrorIdManageEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convErrorIdManage.UpdDate);
}
objvErrorIdManageEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.UpdDate) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.UpdDate, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.UpdDate] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetUpdUserId(this clsvErrorIdManageEN objvErrorIdManageEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convErrorIdManage.UpdUserId);
}
objvErrorIdManageEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.UpdUserId) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.UpdUserId, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.UpdUserId] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetMemo(this clsvErrorIdManageEN objvErrorIdManageEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convErrorIdManage.Memo);
}
objvErrorIdManageEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvErrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Memo) == false)
{
objvErrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Memo, strComparisonOp);
}
else
{
objvErrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Memo] = strComparisonOp;
}
}
return objvErrorIdManageEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvErrorIdManageENS">源对象</param>
 /// <param name = "objvErrorIdManageENT">目标对象</param>
 public static void CopyTo(this clsvErrorIdManageEN objvErrorIdManageENS, clsvErrorIdManageEN objvErrorIdManageENT)
{
try
{
objvErrorIdManageENT.mId = objvErrorIdManageENS.mId; //mId
objvErrorIdManageENT.ErrID = objvErrorIdManageENS.ErrID; //错误Id
objvErrorIdManageENT.ProgLevelTypeId = objvErrorIdManageENS.ProgLevelTypeId; //程序分层类型Id
objvErrorIdManageENT.ProgLevelTypeName = objvErrorIdManageENS.ProgLevelTypeName; //程序分层类型名称
objvErrorIdManageENT.ProgLevelTypeENName = objvErrorIdManageENS.ProgLevelTypeENName; //程序分层类型英文名称
objvErrorIdManageENT.Prefix = objvErrorIdManageENS.Prefix; //前缀
objvErrorIdManageENT.CodeTypeId = objvErrorIdManageENS.CodeTypeId; //代码类型Id
objvErrorIdManageENT.CodeTypeName = objvErrorIdManageENS.CodeTypeName; //代码类型名
objvErrorIdManageENT.CodeTypeENName = objvErrorIdManageENS.CodeTypeENName; //代码类型英文名
objvErrorIdManageENT.FunctionName = objvErrorIdManageENS.FunctionName; //功能名称
objvErrorIdManageENT.Explanation = objvErrorIdManageENS.Explanation; //详细说明
objvErrorIdManageENT.UpdDate = objvErrorIdManageENS.UpdDate; //修改日期
objvErrorIdManageENT.UpdUserId = objvErrorIdManageENS.UpdUserId; //修改用户Id
objvErrorIdManageENT.Memo = objvErrorIdManageENS.Memo; //说明
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
 /// <param name = "objvErrorIdManageENS">源对象</param>
 /// <returns>目标对象=>clsvErrorIdManageEN:objvErrorIdManageENT</returns>
 public static clsvErrorIdManageEN CopyTo(this clsvErrorIdManageEN objvErrorIdManageENS)
{
try
{
 clsvErrorIdManageEN objvErrorIdManageENT = new clsvErrorIdManageEN()
{
mId = objvErrorIdManageENS.mId, //mId
ErrID = objvErrorIdManageENS.ErrID, //错误Id
ProgLevelTypeId = objvErrorIdManageENS.ProgLevelTypeId, //程序分层类型Id
ProgLevelTypeName = objvErrorIdManageENS.ProgLevelTypeName, //程序分层类型名称
ProgLevelTypeENName = objvErrorIdManageENS.ProgLevelTypeENName, //程序分层类型英文名称
Prefix = objvErrorIdManageENS.Prefix, //前缀
CodeTypeId = objvErrorIdManageENS.CodeTypeId, //代码类型Id
CodeTypeName = objvErrorIdManageENS.CodeTypeName, //代码类型名
CodeTypeENName = objvErrorIdManageENS.CodeTypeENName, //代码类型英文名
FunctionName = objvErrorIdManageENS.FunctionName, //功能名称
Explanation = objvErrorIdManageENS.Explanation, //详细说明
UpdDate = objvErrorIdManageENS.UpdDate, //修改日期
UpdUserId = objvErrorIdManageENS.UpdUserId, //修改用户Id
Memo = objvErrorIdManageENS.Memo, //说明
};
 return objvErrorIdManageENT;
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
public static void CheckProperty4Condition(this clsvErrorIdManageEN objvErrorIdManageEN)
{
 clsvErrorIdManageBL.vErrorIdManageDA.CheckProperty4Condition(objvErrorIdManageEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvErrorIdManageEN objvErrorIdManageCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.mId) == true)
{
string strComparisonOpmId = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convErrorIdManage.mId, objvErrorIdManageCond.mId, strComparisonOpmId);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.ErrID) == true)
{
string strComparisonOpErrID = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.ErrID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ErrID, objvErrorIdManageCond.ErrID, strComparisonOpErrID);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.ProgLevelTypeId) == true)
{
string strComparisonOpProgLevelTypeId = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeId, objvErrorIdManageCond.ProgLevelTypeId, strComparisonOpProgLevelTypeId);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.ProgLevelTypeName) == true)
{
string strComparisonOpProgLevelTypeName = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeName, objvErrorIdManageCond.ProgLevelTypeName, strComparisonOpProgLevelTypeName);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.ProgLevelTypeENName) == true)
{
string strComparisonOpProgLevelTypeENName = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeENName, objvErrorIdManageCond.ProgLevelTypeENName, strComparisonOpProgLevelTypeENName);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.Prefix) == true)
{
string strComparisonOpPrefix = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Prefix, objvErrorIdManageCond.Prefix, strComparisonOpPrefix);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeId, objvErrorIdManageCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeName, objvErrorIdManageCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeENName, objvErrorIdManageCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.FunctionName) == true)
{
string strComparisonOpFunctionName = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.FunctionName, objvErrorIdManageCond.FunctionName, strComparisonOpFunctionName);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.Explanation) == true)
{
string strComparisonOpExplanation = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.Explanation];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Explanation, objvErrorIdManageCond.Explanation, strComparisonOpExplanation);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.UpdDate) == true)
{
string strComparisonOpUpdDate = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.UpdDate, objvErrorIdManageCond.UpdDate, strComparisonOpUpdDate);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.UpdUserId, objvErrorIdManageCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvErrorIdManageCond.IsUpdated(convErrorIdManage.Memo) == true)
{
string strComparisonOpMemo = objvErrorIdManageCond.dicFldComparisonOp[convErrorIdManage.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Memo, objvErrorIdManageCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vErrorIdManage
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v错误Id管理(vErrorIdManage)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvErrorIdManageBL
{
public static RelatedActions_vErrorIdManage relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vErrorIdManageListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vErrorIdManageList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvErrorIdManageEN> arrvErrorIdManageObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvErrorIdManageDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvErrorIdManageDA vErrorIdManageDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvErrorIdManageDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvErrorIdManageBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvErrorIdManageEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvErrorIdManageEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vErrorIdManageDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vErrorIdManageDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vErrorIdManageDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vErrorIdManage(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTable_vErrorIdManage(strWhereCond);
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
objDT = vErrorIdManageDA.GetDataTable(strWhereCond);
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
objDT = vErrorIdManageDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vErrorIdManageDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vErrorIdManageDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vErrorIdManageDA.GetDataTable_Top(objTopPara);
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
objDT = vErrorIdManageDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vErrorIdManageDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vErrorIdManageDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vErrorIdManageDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
public static List<clsvErrorIdManageEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
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
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvErrorIdManageEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrvErrorIdManageObjLstCache = GetObjLstCache();
IEnumerable <clsvErrorIdManageEN> arrvErrorIdManageObjLst_Sel =
arrvErrorIdManageObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvErrorIdManageObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLst(string strWhereCond)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
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
public static List<clsvErrorIdManageEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvErrorIdManageCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvErrorIdManageEN> GetSubObjLstCache(clsvErrorIdManageEN objvErrorIdManageCond)
{
List<clsvErrorIdManageEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvErrorIdManageEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convErrorIdManage.AttributeName)
{
if (objvErrorIdManageCond.IsUpdated(strFldName) == false) continue;
if (objvErrorIdManageCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else
{
if (objvErrorIdManageCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvErrorIdManageCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvErrorIdManageCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
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
public static List<clsvErrorIdManageEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
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
public static List<clsvErrorIdManageEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
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
List<clsvErrorIdManageEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvErrorIdManageEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvErrorIdManageEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
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
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
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
public static List<clsvErrorIdManageEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvErrorIdManageEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
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
public static List<clsvErrorIdManageEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvErrorIdManageEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvErrorIdManageEN objvErrorIdManageCond, string strOrderBy)
{
List<clsvErrorIdManageEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvErrorIdManageEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convErrorIdManage.AttributeName)
{
if (objvErrorIdManageCond.IsUpdated(strFldName) == false) continue;
if (objvErrorIdManageCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else
{
if (objvErrorIdManageCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvErrorIdManageCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvErrorIdManageCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvErrorIdManageEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvErrorIdManageEN objvErrorIdManageCond = JsonConvert.DeserializeObject<clsvErrorIdManageEN>(objPagerPara.whereCond);
if (objvErrorIdManageCond.sfFldComparisonOp == null)
{
objvErrorIdManageCond.dicFldComparisonOp = null;
}
else
{
objvErrorIdManageCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvErrorIdManageCond.sfFldComparisonOp);
}
clsvErrorIdManageBL.SetUpdFlag(objvErrorIdManageCond);
 try
{
CheckProperty4Condition(objvErrorIdManageCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvErrorIdManageBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvErrorIdManageCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvErrorIdManageEN> arrObjLst = new List<clsvErrorIdManageEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
try
{
objvErrorIdManageEN.mId = Int32.Parse(objRow[convErrorIdManage.mId].ToString().Trim()); //mId
objvErrorIdManageEN.ErrID = objRow[convErrorIdManage.ErrID].ToString().Trim(); //错误Id
objvErrorIdManageEN.ProgLevelTypeId = objRow[convErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objvErrorIdManageEN.ProgLevelTypeName = objRow[convErrorIdManage.ProgLevelTypeName].ToString().Trim(); //程序分层类型名称
objvErrorIdManageEN.ProgLevelTypeENName = objRow[convErrorIdManage.ProgLevelTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.ProgLevelTypeENName].ToString().Trim(); //程序分层类型英文名称
objvErrorIdManageEN.Prefix = objRow[convErrorIdManage.Prefix] == DBNull.Value ? null : objRow[convErrorIdManage.Prefix].ToString().Trim(); //前缀
objvErrorIdManageEN.CodeTypeId = objRow[convErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objvErrorIdManageEN.CodeTypeName = objRow[convErrorIdManage.CodeTypeName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeName].ToString().Trim(); //代码类型名
objvErrorIdManageEN.CodeTypeENName = objRow[convErrorIdManage.CodeTypeENName] == DBNull.Value ? null : objRow[convErrorIdManage.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvErrorIdManageEN.FunctionName = objRow[convErrorIdManage.FunctionName] == DBNull.Value ? null : objRow[convErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objvErrorIdManageEN.Explanation = objRow[convErrorIdManage.Explanation] == DBNull.Value ? null : objRow[convErrorIdManage.Explanation].ToString().Trim(); //详细说明
objvErrorIdManageEN.UpdDate = objRow[convErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[convErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objvErrorIdManageEN.UpdUserId = objRow[convErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[convErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objvErrorIdManageEN.Memo = objRow[convErrorIdManage.Memo] == DBNull.Value ? null : objRow[convErrorIdManage.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvErrorIdManageEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvErrorIdManageEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvErrorIdManage(ref clsvErrorIdManageEN objvErrorIdManageEN)
{
bool bolResult = vErrorIdManageDA.GetvErrorIdManage(ref objvErrorIdManageEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvErrorIdManageEN GetObjBymId(long lngmId)
{
clsvErrorIdManageEN objvErrorIdManageEN = vErrorIdManageDA.GetObjBymId(lngmId);
return objvErrorIdManageEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvErrorIdManageEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvErrorIdManageEN objvErrorIdManageEN = vErrorIdManageDA.GetFirstObj(strWhereCond);
 return objvErrorIdManageEN;
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
public static clsvErrorIdManageEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvErrorIdManageEN objvErrorIdManageEN = vErrorIdManageDA.GetObjByDataRow(objRow);
 return objvErrorIdManageEN;
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
public static clsvErrorIdManageEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvErrorIdManageEN objvErrorIdManageEN = vErrorIdManageDA.GetObjByDataRow(objRow);
 return objvErrorIdManageEN;
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
 /// <param name = "lstvErrorIdManageObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvErrorIdManageEN GetObjBymIdFromList(long lngmId, List<clsvErrorIdManageEN> lstvErrorIdManageObjLst)
{
foreach (clsvErrorIdManageEN objvErrorIdManageEN in lstvErrorIdManageObjLst)
{
if (objvErrorIdManageEN.mId == lngmId)
{
return objvErrorIdManageEN;
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
 lngmId = new clsvErrorIdManageDA().GetFirstID(strWhereCond);
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
 arrList = vErrorIdManageDA.GetID(strWhereCond);
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
bool bolIsExist = vErrorIdManageDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vErrorIdManageDA.IsExist(lngmId);
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
 bolIsExist = clsvErrorIdManageDA.IsExistTable();
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
 bolIsExist = vErrorIdManageDA.IsExistTable(strTabName);
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
 /// <param name = "objvErrorIdManageENS">源对象</param>
 /// <param name = "objvErrorIdManageENT">目标对象</param>
 public static void CopyTo(clsvErrorIdManageEN objvErrorIdManageENS, clsvErrorIdManageEN objvErrorIdManageENT)
{
try
{
objvErrorIdManageENT.mId = objvErrorIdManageENS.mId; //mId
objvErrorIdManageENT.ErrID = objvErrorIdManageENS.ErrID; //错误Id
objvErrorIdManageENT.ProgLevelTypeId = objvErrorIdManageENS.ProgLevelTypeId; //程序分层类型Id
objvErrorIdManageENT.ProgLevelTypeName = objvErrorIdManageENS.ProgLevelTypeName; //程序分层类型名称
objvErrorIdManageENT.ProgLevelTypeENName = objvErrorIdManageENS.ProgLevelTypeENName; //程序分层类型英文名称
objvErrorIdManageENT.Prefix = objvErrorIdManageENS.Prefix; //前缀
objvErrorIdManageENT.CodeTypeId = objvErrorIdManageENS.CodeTypeId; //代码类型Id
objvErrorIdManageENT.CodeTypeName = objvErrorIdManageENS.CodeTypeName; //代码类型名
objvErrorIdManageENT.CodeTypeENName = objvErrorIdManageENS.CodeTypeENName; //代码类型英文名
objvErrorIdManageENT.FunctionName = objvErrorIdManageENS.FunctionName; //功能名称
objvErrorIdManageENT.Explanation = objvErrorIdManageENS.Explanation; //详细说明
objvErrorIdManageENT.UpdDate = objvErrorIdManageENS.UpdDate; //修改日期
objvErrorIdManageENT.UpdUserId = objvErrorIdManageENS.UpdUserId; //修改用户Id
objvErrorIdManageENT.Memo = objvErrorIdManageENS.Memo; //说明
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
 /// <param name = "objvErrorIdManageEN">源简化对象</param>
 public static void SetUpdFlag(clsvErrorIdManageEN objvErrorIdManageEN)
{
try
{
objvErrorIdManageEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvErrorIdManageEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convErrorIdManage.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.mId = objvErrorIdManageEN.mId; //mId
}
if (arrFldSet.Contains(convErrorIdManage.ErrID, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.ErrID = objvErrorIdManageEN.ErrID; //错误Id
}
if (arrFldSet.Contains(convErrorIdManage.ProgLevelTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.ProgLevelTypeId = objvErrorIdManageEN.ProgLevelTypeId; //程序分层类型Id
}
if (arrFldSet.Contains(convErrorIdManage.ProgLevelTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.ProgLevelTypeName = objvErrorIdManageEN.ProgLevelTypeName; //程序分层类型名称
}
if (arrFldSet.Contains(convErrorIdManage.ProgLevelTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.ProgLevelTypeENName = objvErrorIdManageEN.ProgLevelTypeENName == "[null]" ? null :  objvErrorIdManageEN.ProgLevelTypeENName; //程序分层类型英文名称
}
if (arrFldSet.Contains(convErrorIdManage.Prefix, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.Prefix = objvErrorIdManageEN.Prefix == "[null]" ? null :  objvErrorIdManageEN.Prefix; //前缀
}
if (arrFldSet.Contains(convErrorIdManage.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.CodeTypeId = objvErrorIdManageEN.CodeTypeId == "[null]" ? null :  objvErrorIdManageEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convErrorIdManage.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.CodeTypeName = objvErrorIdManageEN.CodeTypeName == "[null]" ? null :  objvErrorIdManageEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convErrorIdManage.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.CodeTypeENName = objvErrorIdManageEN.CodeTypeENName == "[null]" ? null :  objvErrorIdManageEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convErrorIdManage.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.FunctionName = objvErrorIdManageEN.FunctionName == "[null]" ? null :  objvErrorIdManageEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convErrorIdManage.Explanation, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.Explanation = objvErrorIdManageEN.Explanation == "[null]" ? null :  objvErrorIdManageEN.Explanation; //详细说明
}
if (arrFldSet.Contains(convErrorIdManage.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.UpdDate = objvErrorIdManageEN.UpdDate == "[null]" ? null :  objvErrorIdManageEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convErrorIdManage.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.UpdUserId = objvErrorIdManageEN.UpdUserId == "[null]" ? null :  objvErrorIdManageEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convErrorIdManage.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvErrorIdManageEN.Memo = objvErrorIdManageEN.Memo == "[null]" ? null :  objvErrorIdManageEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">源简化对象</param>
 public static void AccessFldValueNull(clsvErrorIdManageEN objvErrorIdManageEN)
{
try
{
if (objvErrorIdManageEN.ProgLevelTypeENName == "[null]") objvErrorIdManageEN.ProgLevelTypeENName = null; //程序分层类型英文名称
if (objvErrorIdManageEN.Prefix == "[null]") objvErrorIdManageEN.Prefix = null; //前缀
if (objvErrorIdManageEN.CodeTypeId == "[null]") objvErrorIdManageEN.CodeTypeId = null; //代码类型Id
if (objvErrorIdManageEN.CodeTypeName == "[null]") objvErrorIdManageEN.CodeTypeName = null; //代码类型名
if (objvErrorIdManageEN.CodeTypeENName == "[null]") objvErrorIdManageEN.CodeTypeENName = null; //代码类型英文名
if (objvErrorIdManageEN.FunctionName == "[null]") objvErrorIdManageEN.FunctionName = null; //功能名称
if (objvErrorIdManageEN.Explanation == "[null]") objvErrorIdManageEN.Explanation = null; //详细说明
if (objvErrorIdManageEN.UpdDate == "[null]") objvErrorIdManageEN.UpdDate = null; //修改日期
if (objvErrorIdManageEN.UpdUserId == "[null]") objvErrorIdManageEN.UpdUserId = null; //修改用户Id
if (objvErrorIdManageEN.Memo == "[null]") objvErrorIdManageEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvErrorIdManageEN objvErrorIdManageEN)
{
 vErrorIdManageDA.CheckProperty4Condition(objvErrorIdManageEN);
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsErrorIdManageBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsErrorIdManageBL没有刷新缓存机制(clsErrorIdManageBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvErrorIdManageObjLstCache == null)
//{
//arrvErrorIdManageObjLstCache = vErrorIdManageDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvErrorIdManageEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrvErrorIdManageObjLstCache = GetObjLstCache();
IEnumerable <clsvErrorIdManageEN> arrvErrorIdManageObjLst_Sel =
arrvErrorIdManageObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvErrorIdManageObjLst_Sel.Count() == 0)
{
   clsvErrorIdManageEN obj = clsvErrorIdManageBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvErrorIdManageObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvErrorIdManageEN> GetAllvErrorIdManageObjLstCache()
{
//获取缓存中的对象列表
List<clsvErrorIdManageEN> arrvErrorIdManageObjLstCache = GetObjLstCache(); 
return arrvErrorIdManageObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrvErrorIdManageObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvErrorIdManageObjLstCache;
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
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
CacheHelper.Remove(strKey);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvErrorIdManageObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvErrorIdManageEN> lstvErrorIdManageObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvErrorIdManageObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvErrorIdManageObjLst">[clsvErrorIdManageEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvErrorIdManageEN> lstvErrorIdManageObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvErrorIdManageBL.listXmlNode);
writer.WriteStartElement(clsvErrorIdManageBL.itemsXmlNode);
foreach (clsvErrorIdManageEN objvErrorIdManageEN in lstvErrorIdManageObjLst)
{
clsvErrorIdManageBL.SerializeXML(writer, objvErrorIdManageEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvErrorIdManageEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvErrorIdManageEN objvErrorIdManageEN)
{
writer.WriteStartElement(clsvErrorIdManageBL.itemXmlNode);
 
writer.WriteElementString(convErrorIdManage.mId, objvErrorIdManageEN.mId.ToString(CultureInfo.InvariantCulture));
 
if (objvErrorIdManageEN.ErrID != null)
{
writer.WriteElementString(convErrorIdManage.ErrID, objvErrorIdManageEN.ErrID.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.ProgLevelTypeId != null)
{
writer.WriteElementString(convErrorIdManage.ProgLevelTypeId, objvErrorIdManageEN.ProgLevelTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.ProgLevelTypeName != null)
{
writer.WriteElementString(convErrorIdManage.ProgLevelTypeName, objvErrorIdManageEN.ProgLevelTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.ProgLevelTypeENName != null)
{
writer.WriteElementString(convErrorIdManage.ProgLevelTypeENName, objvErrorIdManageEN.ProgLevelTypeENName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.Prefix != null)
{
writer.WriteElementString(convErrorIdManage.Prefix, objvErrorIdManageEN.Prefix.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.CodeTypeId != null)
{
writer.WriteElementString(convErrorIdManage.CodeTypeId, objvErrorIdManageEN.CodeTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.CodeTypeName != null)
{
writer.WriteElementString(convErrorIdManage.CodeTypeName, objvErrorIdManageEN.CodeTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.CodeTypeENName != null)
{
writer.WriteElementString(convErrorIdManage.CodeTypeENName, objvErrorIdManageEN.CodeTypeENName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.FunctionName != null)
{
writer.WriteElementString(convErrorIdManage.FunctionName, objvErrorIdManageEN.FunctionName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.Explanation != null)
{
writer.WriteElementString(convErrorIdManage.Explanation, objvErrorIdManageEN.Explanation.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.UpdDate != null)
{
writer.WriteElementString(convErrorIdManage.UpdDate, objvErrorIdManageEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.UpdUserId != null)
{
writer.WriteElementString(convErrorIdManage.UpdUserId, objvErrorIdManageEN.UpdUserId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvErrorIdManageEN.Memo != null)
{
writer.WriteElementString(convErrorIdManage.Memo, objvErrorIdManageEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvErrorIdManageEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
reader.Read();
while (!(reader.Name == clsvErrorIdManageBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convErrorIdManage.mId))
{
objvErrorIdManageEN.mId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convErrorIdManage.ErrID))
{
objvErrorIdManageEN.ErrID = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.ProgLevelTypeId))
{
objvErrorIdManageEN.ProgLevelTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.ProgLevelTypeName))
{
objvErrorIdManageEN.ProgLevelTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.ProgLevelTypeENName))
{
objvErrorIdManageEN.ProgLevelTypeENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.Prefix))
{
objvErrorIdManageEN.Prefix = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.CodeTypeId))
{
objvErrorIdManageEN.CodeTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.CodeTypeName))
{
objvErrorIdManageEN.CodeTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.CodeTypeENName))
{
objvErrorIdManageEN.CodeTypeENName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.FunctionName))
{
objvErrorIdManageEN.FunctionName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.Explanation))
{
objvErrorIdManageEN.Explanation = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.UpdDate))
{
objvErrorIdManageEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.UpdUserId))
{
objvErrorIdManageEN.UpdUserId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convErrorIdManage.Memo))
{
objvErrorIdManageEN.Memo = reader.ReadElementContentAsString();
}
}
return objvErrorIdManageEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvErrorIdManageObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvErrorIdManageEN GetObjFromXmlStr(string strvErrorIdManageObjXmlStr)
{
clsvErrorIdManageEN objvErrorIdManageEN = new clsvErrorIdManageEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvErrorIdManageObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvErrorIdManageBL.itemXmlNode))
{
objvErrorIdManageEN = GetObjFromXml(reader);
return objvErrorIdManageEN;
}
}
return objvErrorIdManageEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvErrorIdManageEN objvErrorIdManageEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvErrorIdManageEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convErrorIdManage.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convErrorIdManage.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convErrorIdManage.AttributeName));
throw new Exception(strMsg);
}
var objvErrorIdManage = clsvErrorIdManageBL.GetObjBymIdCache(lngmId);
if (objvErrorIdManage == null) return "";
return objvErrorIdManage[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvErrorIdManageEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvErrorIdManageEN objvErrorIdManageEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvErrorIdManageEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvErrorIdManageEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvErrorIdManageObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvErrorIdManageEN> lstvErrorIdManageObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvErrorIdManageObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvErrorIdManageEN objvErrorIdManageEN in lstvErrorIdManageObjLst)
{
string strJSON_One = SerializeObjToJSON(objvErrorIdManageEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvErrorIdManageDA.GetRecCount(strTabName);
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
int intRecCount = clsvErrorIdManageDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvErrorIdManageDA.GetRecCount();
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
int intRecCount = clsvErrorIdManageDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvErrorIdManageCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvErrorIdManageEN objvErrorIdManageCond)
{
List<clsvErrorIdManageEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvErrorIdManageEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convErrorIdManage.AttributeName)
{
if (objvErrorIdManageCond.IsUpdated(strFldName) == false) continue;
if (objvErrorIdManageCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else
{
if (objvErrorIdManageCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvErrorIdManageCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvErrorIdManageCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvErrorIdManageCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvErrorIdManageCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvErrorIdManageCond[strFldName]));
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
 List<string> arrList = clsvErrorIdManageDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vErrorIdManageDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vErrorIdManageDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}