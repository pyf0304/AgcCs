
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupRelaBL
 表名:vFunctionGroupRela(00050329)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:37
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionGroupRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupRelaEN GetObj(this K_mId_vFunctionGroupRela myKey)
{
clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = clsvFunctionGroupRelaBL.vFunctionGroupRelaDA.GetObjBymId(myKey.Value);
return objvFunctionGroupRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetmId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, long lngmId, string strComparisonOp="")
	{
objvFunctionGroupRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.mId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.mId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.mId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFunctionGroupId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convFunctionGroupRela.FunctionGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionGroupRela.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionGroupRela.FunctionGroupId);
}
objvFunctionGroupRelaEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FunctionGroupId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FunctionGroupId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFunctionGroupName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFunctionGroupName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionGroupRela.FunctionGroupName);
}
objvFunctionGroupRelaEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FunctionGroupName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FunctionGroupName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetProgLangTypeId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionGroupRela.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionGroupRela.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionGroupRela.ProgLangTypeId);
}
objvFunctionGroupRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.ProgLangTypeId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetProgLangTypeName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionGroupRela.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionGroupRela.ProgLangTypeName);
}
objvFunctionGroupRelaEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.ProgLangTypeName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetCreateUserId(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionGroupRela.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionGroupRela.CreateUserId);
}
objvFunctionGroupRelaEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.CreateUserId) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.CreateUserId, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.CreateUserId] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFuncId4GC(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionGroupRela.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionGroupRela.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionGroupRela.FuncId4GC);
}
objvFunctionGroupRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FuncId4GC) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetFuncName(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionGroupRela.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionGroupRela.FuncName);
}
objvFunctionGroupRelaEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.FuncName) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.FuncName, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.FuncName] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetIsTemplate(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convFunctionGroupRela.IsTemplate);
objvFunctionGroupRelaEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.IsTemplate) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.IsTemplate, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.IsTemplate] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetUpdDate(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionGroupRela.UpdDate);
}
objvFunctionGroupRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.UpdDate) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.UpdDate, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.UpdDate] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetUpdUser(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionGroupRela.UpdUser);
}
objvFunctionGroupRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.UpdUser) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.UpdUser, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.UpdUser] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupRelaEN SetMemo(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionGroupRela.Memo);
}
objvFunctionGroupRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupRelaEN.dicFldComparisonOp.ContainsKey(convFunctionGroupRela.Memo) == false)
{
objvFunctionGroupRelaEN.dicFldComparisonOp.Add(convFunctionGroupRela.Memo, strComparisonOp);
}
else
{
objvFunctionGroupRelaEN.dicFldComparisonOp[convFunctionGroupRela.Memo] = strComparisonOp;
}
}
return objvFunctionGroupRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaENS">源对象</param>
 /// <param name = "objvFunctionGroupRelaENT">目标对象</param>
 public static void CopyTo(this clsvFunctionGroupRelaEN objvFunctionGroupRelaENS, clsvFunctionGroupRelaEN objvFunctionGroupRelaENT)
{
try
{
objvFunctionGroupRelaENT.mId = objvFunctionGroupRelaENS.mId; //mId
objvFunctionGroupRelaENT.FunctionGroupId = objvFunctionGroupRelaENS.FunctionGroupId; //函数组Id
objvFunctionGroupRelaENT.FunctionGroupName = objvFunctionGroupRelaENS.FunctionGroupName; //函数组名称
objvFunctionGroupRelaENT.ProgLangTypeId = objvFunctionGroupRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupRelaENT.ProgLangTypeName = objvFunctionGroupRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupRelaENT.CreateUserId = objvFunctionGroupRelaENS.CreateUserId; //建立用户Id
objvFunctionGroupRelaENT.FuncId4GC = objvFunctionGroupRelaENS.FuncId4GC; //函数ID
objvFunctionGroupRelaENT.FuncName = objvFunctionGroupRelaENS.FuncName; //函数名
objvFunctionGroupRelaENT.IsTemplate = objvFunctionGroupRelaENS.IsTemplate; //是否模板
objvFunctionGroupRelaENT.UpdDate = objvFunctionGroupRelaENS.UpdDate; //修改日期
objvFunctionGroupRelaENT.UpdUser = objvFunctionGroupRelaENS.UpdUser; //修改者
objvFunctionGroupRelaENT.Memo = objvFunctionGroupRelaENS.Memo; //说明
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
 /// <param name = "objvFunctionGroupRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionGroupRelaEN:objvFunctionGroupRelaENT</returns>
 public static clsvFunctionGroupRelaEN CopyTo(this clsvFunctionGroupRelaEN objvFunctionGroupRelaENS)
{
try
{
 clsvFunctionGroupRelaEN objvFunctionGroupRelaENT = new clsvFunctionGroupRelaEN()
{
mId = objvFunctionGroupRelaENS.mId, //mId
FunctionGroupId = objvFunctionGroupRelaENS.FunctionGroupId, //函数组Id
FunctionGroupName = objvFunctionGroupRelaENS.FunctionGroupName, //函数组名称
ProgLangTypeId = objvFunctionGroupRelaENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvFunctionGroupRelaENS.ProgLangTypeName, //编程语言类型名
CreateUserId = objvFunctionGroupRelaENS.CreateUserId, //建立用户Id
FuncId4GC = objvFunctionGroupRelaENS.FuncId4GC, //函数ID
FuncName = objvFunctionGroupRelaENS.FuncName, //函数名
IsTemplate = objvFunctionGroupRelaENS.IsTemplate, //是否模板
UpdDate = objvFunctionGroupRelaENS.UpdDate, //修改日期
UpdUser = objvFunctionGroupRelaENS.UpdUser, //修改者
Memo = objvFunctionGroupRelaENS.Memo, //说明
};
 return objvFunctionGroupRelaENT;
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
public static void CheckProperty4Condition(this clsvFunctionGroupRelaEN objvFunctionGroupRelaEN)
{
 clsvFunctionGroupRelaBL.vFunctionGroupRelaDA.CheckProperty4Condition(objvFunctionGroupRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionGroupRelaEN objvFunctionGroupRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.mId) == true)
{
string strComparisonOpmId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionGroupRela.mId, objvFunctionGroupRelaCond.mId, strComparisonOpmId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FunctionGroupId, objvFunctionGroupRelaCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FunctionGroupName, objvFunctionGroupRelaCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.ProgLangTypeId, objvFunctionGroupRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.ProgLangTypeName, objvFunctionGroupRelaCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.CreateUserId, objvFunctionGroupRelaCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FuncId4GC, objvFunctionGroupRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.FuncName) == true)
{
string strComparisonOpFuncName = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.FuncName, objvFunctionGroupRelaCond.FuncName, strComparisonOpFuncName);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.IsTemplate) == true)
{
if (objvFunctionGroupRelaCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionGroupRela.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionGroupRela.IsTemplate);
}
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.UpdDate, objvFunctionGroupRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.UpdUser, objvFunctionGroupRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionGroupRelaCond.IsUpdated(convFunctionGroupRela.Memo) == true)
{
string strComparisonOpMemo = objvFunctionGroupRelaCond.dicFldComparisonOp[convFunctionGroupRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroupRela.Memo, objvFunctionGroupRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionGroupRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数与组关系(vFunctionGroupRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionGroupRelaBL
{
public static RelatedActions_vFunctionGroupRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionGroupRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionGroupRelaDA vFunctionGroupRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionGroupRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionGroupRelaBL()
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
if (string.IsNullOrEmpty(clsvFunctionGroupRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionGroupRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionGroupRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionGroupRelaDA.GetDataTable_vFunctionGroupRela(strWhereCond);
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
objDT = vFunctionGroupRelaDA.GetDataTable(strWhereCond);
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
objDT = vFunctionGroupRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionGroupRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionGroupRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionGroupRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionGroupRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionGroupRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
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
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionGroupRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLst_Sel =
arrvFunctionGroupRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFunctionGroupRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
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
public static List<clsvFunctionGroupRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionGroupRelaEN> GetSubObjLstCache(clsvFunctionGroupRelaEN objvFunctionGroupRelaCond)
{
List<clsvFunctionGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionGroupRela._AttributeName)
{
if (objvFunctionGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupRelaCond[strFldName]));
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
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
List<clsvFunctionGroupRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionGroupRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
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
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
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
public static List<clsvFunctionGroupRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
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
public static List<clsvFunctionGroupRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionGroupRelaEN> arrObjLst = new List<clsvFunctionGroupRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = new clsvFunctionGroupRelaEN();
try
{
objvFunctionGroupRelaEN.mId = Int32.Parse(objRow[convFunctionGroupRela.mId].ToString().Trim()); //mId
objvFunctionGroupRelaEN.FunctionGroupId = objRow[convFunctionGroupRela.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupRelaEN.FunctionGroupName = objRow[convFunctionGroupRela.FunctionGroupName] == DBNull.Value ? null : objRow[convFunctionGroupRela.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupRelaEN.ProgLangTypeId = objRow[convFunctionGroupRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupRelaEN.ProgLangTypeName = objRow[convFunctionGroupRela.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupRelaEN.CreateUserId = objRow[convFunctionGroupRela.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupRelaEN.FuncId4GC = objRow[convFunctionGroupRela.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionGroupRelaEN.FuncName = objRow[convFunctionGroupRela.FuncName].ToString().Trim(); //函数名
objvFunctionGroupRelaEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunctionGroupRela.IsTemplate].ToString().Trim()); //是否模板
objvFunctionGroupRelaEN.UpdDate = objRow[convFunctionGroupRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupRelaEN.UpdUser = objRow[convFunctionGroupRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroupRela.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupRelaEN.Memo = objRow[convFunctionGroupRela.Memo] == DBNull.Value ? null : objRow[convFunctionGroupRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionGroupRela(ref clsvFunctionGroupRelaEN objvFunctionGroupRelaEN)
{
bool bolResult = vFunctionGroupRelaDA.GetvFunctionGroupRela(ref objvFunctionGroupRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupRelaEN GetObjBymId(long lngmId)
{
clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = vFunctionGroupRelaDA.GetObjBymId(lngmId);
return objvFunctionGroupRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionGroupRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = vFunctionGroupRelaDA.GetFirstObj(strWhereCond);
 return objvFunctionGroupRelaEN;
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
public static clsvFunctionGroupRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = vFunctionGroupRelaDA.GetObjByDataRow(objRow);
 return objvFunctionGroupRelaEN;
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
public static clsvFunctionGroupRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionGroupRelaEN objvFunctionGroupRelaEN = vFunctionGroupRelaDA.GetObjByDataRow(objRow);
 return objvFunctionGroupRelaEN;
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
 /// <param name = "lstvFunctionGroupRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionGroupRelaEN GetObjBymIdFromList(long lngmId, List<clsvFunctionGroupRelaEN> lstvFunctionGroupRelaObjLst)
{
foreach (clsvFunctionGroupRelaEN objvFunctionGroupRelaEN in lstvFunctionGroupRelaObjLst)
{
if (objvFunctionGroupRelaEN.mId == lngmId)
{
return objvFunctionGroupRelaEN;
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
 lngmId = new clsvFunctionGroupRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFunctionGroupRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionGroupRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFunctionGroupRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFunctionGroupRelaDA.IsExistTable();
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
 bolIsExist = vFunctionGroupRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionGroupRelaENS">源对象</param>
 /// <param name = "objvFunctionGroupRelaENT">目标对象</param>
 public static void CopyTo(clsvFunctionGroupRelaEN objvFunctionGroupRelaENS, clsvFunctionGroupRelaEN objvFunctionGroupRelaENT)
{
try
{
objvFunctionGroupRelaENT.mId = objvFunctionGroupRelaENS.mId; //mId
objvFunctionGroupRelaENT.FunctionGroupId = objvFunctionGroupRelaENS.FunctionGroupId; //函数组Id
objvFunctionGroupRelaENT.FunctionGroupName = objvFunctionGroupRelaENS.FunctionGroupName; //函数组名称
objvFunctionGroupRelaENT.ProgLangTypeId = objvFunctionGroupRelaENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupRelaENT.ProgLangTypeName = objvFunctionGroupRelaENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupRelaENT.CreateUserId = objvFunctionGroupRelaENS.CreateUserId; //建立用户Id
objvFunctionGroupRelaENT.FuncId4GC = objvFunctionGroupRelaENS.FuncId4GC; //函数ID
objvFunctionGroupRelaENT.FuncName = objvFunctionGroupRelaENS.FuncName; //函数名
objvFunctionGroupRelaENT.IsTemplate = objvFunctionGroupRelaENS.IsTemplate; //是否模板
objvFunctionGroupRelaENT.UpdDate = objvFunctionGroupRelaENS.UpdDate; //修改日期
objvFunctionGroupRelaENT.UpdUser = objvFunctionGroupRelaENS.UpdUser; //修改者
objvFunctionGroupRelaENT.Memo = objvFunctionGroupRelaENS.Memo; //说明
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
 /// <param name = "objvFunctionGroupRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionGroupRelaEN objvFunctionGroupRelaEN)
{
try
{
objvFunctionGroupRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionGroupRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionGroupRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.mId = objvFunctionGroupRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFunctionGroupRela.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.FunctionGroupId = objvFunctionGroupRelaEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(convFunctionGroupRela.FunctionGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.FunctionGroupName = objvFunctionGroupRelaEN.FunctionGroupName == "[null]" ? null :  objvFunctionGroupRelaEN.FunctionGroupName; //函数组名称
}
if (arrFldSet.Contains(convFunctionGroupRela.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.ProgLangTypeId = objvFunctionGroupRelaEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunctionGroupRela.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.ProgLangTypeName = objvFunctionGroupRelaEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convFunctionGroupRela.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.CreateUserId = objvFunctionGroupRelaEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convFunctionGroupRela.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.FuncId4GC = objvFunctionGroupRelaEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunctionGroupRela.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.FuncName = objvFunctionGroupRelaEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFunctionGroupRela.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.IsTemplate = objvFunctionGroupRelaEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convFunctionGroupRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.UpdDate = objvFunctionGroupRelaEN.UpdDate == "[null]" ? null :  objvFunctionGroupRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunctionGroupRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.UpdUser = objvFunctionGroupRelaEN.UpdUser == "[null]" ? null :  objvFunctionGroupRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunctionGroupRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupRelaEN.Memo = objvFunctionGroupRelaEN.Memo == "[null]" ? null :  objvFunctionGroupRelaEN.Memo; //说明
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
 /// <param name = "objvFunctionGroupRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionGroupRelaEN objvFunctionGroupRelaEN)
{
try
{
if (objvFunctionGroupRelaEN.FunctionGroupName == "[null]") objvFunctionGroupRelaEN.FunctionGroupName = null; //函数组名称
if (objvFunctionGroupRelaEN.UpdDate == "[null]") objvFunctionGroupRelaEN.UpdDate = null; //修改日期
if (objvFunctionGroupRelaEN.UpdUser == "[null]") objvFunctionGroupRelaEN.UpdUser = null; //修改者
if (objvFunctionGroupRelaEN.Memo == "[null]") objvFunctionGroupRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFunctionGroupRelaEN objvFunctionGroupRelaEN)
{
 vFunctionGroupRelaDA.CheckProperty4Condition(objvFunctionGroupRelaEN);
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
if (clsFunctionGroupRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupRelaBL没有刷新缓存机制(clsFunctionGroupRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncGCTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncGCTypeBL没有刷新缓存机制(clsFuncGCTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFunctionGroupRelaObjLstCache == null)
//{
//arrvFunctionGroupRelaObjLstCache = vFunctionGroupRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionGroupRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLst_Sel =
arrvFunctionGroupRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFunctionGroupRelaObjLst_Sel.Count() == 0)
{
   clsvFunctionGroupRelaEN obj = clsvFunctionGroupRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionGroupRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetAllvFunctionGroupRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = GetObjLstCache(); 
return arrvFunctionGroupRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionGroupRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
List<clsvFunctionGroupRelaEN> arrvFunctionGroupRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionGroupRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionGroupRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionGroupRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionGroupRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionGroupRelaEN._RefreshTimeLst[clsvFunctionGroupRelaEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFunctionGroupRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionGroupRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionGroupRela._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionGroupRela = clsvFunctionGroupRelaBL.GetObjBymIdCache(lngmId);
if (objvFunctionGroupRela == null) return "";
return objvFunctionGroupRela[strOutFldName].ToString();
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
int intRecCount = clsvFunctionGroupRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionGroupRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionGroupRelaDA.GetRecCount();
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
int intRecCount = clsvFunctionGroupRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionGroupRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionGroupRelaEN objvFunctionGroupRelaCond)
{
List<clsvFunctionGroupRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionGroupRela._AttributeName)
{
if (objvFunctionGroupRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionGroupRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionGroupRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionGroupRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionGroupRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionGroupRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupRelaCond[strFldName]));
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
 List<string> arrList = clsvFunctionGroupRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionGroupRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionGroupRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}