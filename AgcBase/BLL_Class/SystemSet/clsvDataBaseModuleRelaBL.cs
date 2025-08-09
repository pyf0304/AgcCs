
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataBaseModuleRelaBL
 表名:vDataBaseModuleRela(00050236)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvDataBaseModuleRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataBaseModuleRelaEN GetObj(this K_mId_vDataBaseModuleRela myKey)
{
clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = clsvDataBaseModuleRelaBL.vDataBaseModuleRelaDA.GetObjBymId(myKey.Value);
return objvDataBaseModuleRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetmId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, long lngmId, string strComparisonOp="")
	{
objvDataBaseModuleRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.mId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.mId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.mId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataBaseModuleRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataBaseModuleRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataBaseModuleRela.PrjId);
}
objvDataBaseModuleRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convDataBaseModuleRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convDataBaseModuleRela.PrjName);
}
objvDataBaseModuleRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjDataBaseId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convDataBaseModuleRela.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convDataBaseModuleRela.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convDataBaseModuleRela.PrjDataBaseId);
}
objvDataBaseModuleRelaEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjDataBaseId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjDataBaseId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetPrjDataBaseName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convDataBaseModuleRela.PrjDataBaseName);
}
objvDataBaseModuleRelaEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.PrjDataBaseName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.PrjDataBaseName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleAgcId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convDataBaseModuleRela.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convDataBaseModuleRela.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convDataBaseModuleRela.FuncModuleAgcId);
}
objvDataBaseModuleRelaEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleAgcId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleAgcId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleAgcId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convDataBaseModuleRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convDataBaseModuleRela.FuncModuleName);
}
objvDataBaseModuleRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetFuncModuleEnName(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convDataBaseModuleRela.FuncModuleEnName);
}
objvDataBaseModuleRelaEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.FuncModuleEnName) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.FuncModuleEnName, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleEnName] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetOrderNum(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convDataBaseModuleRela.OrderNum);
objvDataBaseModuleRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.OrderNum) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.OrderNum, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.OrderNum] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetIsVisible(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, bool bolIsVisible, string strComparisonOp="")
	{
objvDataBaseModuleRelaEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.IsVisible) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.IsVisible, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.IsVisible] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetUpdUserId(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convDataBaseModuleRela.UpdUserId);
}
objvDataBaseModuleRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.UpdUserId) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.UpdUserId, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.UpdUserId] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetUpdDate(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDataBaseModuleRela.UpdDate);
}
objvDataBaseModuleRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.UpdDate) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.UpdDate, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.UpdDate] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataBaseModuleRelaEN SetMemo(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDataBaseModuleRela.Memo);
}
objvDataBaseModuleRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataBaseModuleRelaEN.dicFldComparisonOp.ContainsKey(convDataBaseModuleRela.Memo) == false)
{
objvDataBaseModuleRelaEN.dicFldComparisonOp.Add(convDataBaseModuleRela.Memo, strComparisonOp);
}
else
{
objvDataBaseModuleRelaEN.dicFldComparisonOp[convDataBaseModuleRela.Memo] = strComparisonOp;
}
}
return objvDataBaseModuleRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaENS">源对象</param>
 /// <param name = "objvDataBaseModuleRelaENT">目标对象</param>
 public static void CopyTo(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENS, clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENT)
{
try
{
objvDataBaseModuleRelaENT.mId = objvDataBaseModuleRelaENS.mId; //mId
objvDataBaseModuleRelaENT.PrjId = objvDataBaseModuleRelaENS.PrjId; //工程Id
objvDataBaseModuleRelaENT.PrjName = objvDataBaseModuleRelaENS.PrjName; //工程名称
objvDataBaseModuleRelaENT.PrjDataBaseId = objvDataBaseModuleRelaENS.PrjDataBaseId; //项目数据库Id
objvDataBaseModuleRelaENT.PrjDataBaseName = objvDataBaseModuleRelaENS.PrjDataBaseName; //项目数据库名
objvDataBaseModuleRelaENT.FuncModuleAgcId = objvDataBaseModuleRelaENS.FuncModuleAgcId; //功能模块Id
objvDataBaseModuleRelaENT.FuncModuleName = objvDataBaseModuleRelaENS.FuncModuleName; //功能模块名称
objvDataBaseModuleRelaENT.FuncModuleEnName = objvDataBaseModuleRelaENS.FuncModuleEnName; //功能模块英文名称
objvDataBaseModuleRelaENT.OrderNum = objvDataBaseModuleRelaENS.OrderNum; //序号
objvDataBaseModuleRelaENT.IsVisible = objvDataBaseModuleRelaENS.IsVisible; //是否显示
objvDataBaseModuleRelaENT.UpdUserId = objvDataBaseModuleRelaENS.UpdUserId; //修改用户Id
objvDataBaseModuleRelaENT.UpdDate = objvDataBaseModuleRelaENS.UpdDate; //修改日期
objvDataBaseModuleRelaENT.Memo = objvDataBaseModuleRelaENS.Memo; //说明
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
 /// <param name = "objvDataBaseModuleRelaENS">源对象</param>
 /// <returns>目标对象=>clsvDataBaseModuleRelaEN:objvDataBaseModuleRelaENT</returns>
 public static clsvDataBaseModuleRelaEN CopyTo(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENS)
{
try
{
 clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENT = new clsvDataBaseModuleRelaEN()
{
mId = objvDataBaseModuleRelaENS.mId, //mId
PrjId = objvDataBaseModuleRelaENS.PrjId, //工程Id
PrjName = objvDataBaseModuleRelaENS.PrjName, //工程名称
PrjDataBaseId = objvDataBaseModuleRelaENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objvDataBaseModuleRelaENS.PrjDataBaseName, //项目数据库名
FuncModuleAgcId = objvDataBaseModuleRelaENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvDataBaseModuleRelaENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvDataBaseModuleRelaENS.FuncModuleEnName, //功能模块英文名称
OrderNum = objvDataBaseModuleRelaENS.OrderNum, //序号
IsVisible = objvDataBaseModuleRelaENS.IsVisible, //是否显示
UpdUserId = objvDataBaseModuleRelaENS.UpdUserId, //修改用户Id
UpdDate = objvDataBaseModuleRelaENS.UpdDate, //修改日期
Memo = objvDataBaseModuleRelaENS.Memo, //说明
};
 return objvDataBaseModuleRelaENT;
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
public static void CheckProperty4Condition(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
 clsvDataBaseModuleRelaBL.vDataBaseModuleRelaDA.CheckProperty4Condition(objvDataBaseModuleRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataBaseModuleRelaEN objvDataBaseModuleRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.mId) == true)
{
string strComparisonOpmId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convDataBaseModuleRela.mId, objvDataBaseModuleRelaCond.mId, strComparisonOpmId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjId) == true)
{
string strComparisonOpPrjId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjId, objvDataBaseModuleRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjName) == true)
{
string strComparisonOpPrjName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjName, objvDataBaseModuleRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjDataBaseId, objvDataBaseModuleRelaCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.PrjDataBaseName, objvDataBaseModuleRelaCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleAgcId, objvDataBaseModuleRelaCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleName, objvDataBaseModuleRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.FuncModuleEnName, objvDataBaseModuleRelaCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDataBaseModuleRela.OrderNum, objvDataBaseModuleRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.IsVisible) == true)
{
if (objvDataBaseModuleRelaCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDataBaseModuleRela.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDataBaseModuleRela.IsVisible);
}
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.UpdUserId, objvDataBaseModuleRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.UpdDate, objvDataBaseModuleRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDataBaseModuleRelaCond.IsUpdated(convDataBaseModuleRela.Memo) == true)
{
string strComparisonOpMemo = objvDataBaseModuleRelaCond.dicFldComparisonOp[convDataBaseModuleRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataBaseModuleRela.Memo, objvDataBaseModuleRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDataBaseModuleRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v数据库模块关系(vDataBaseModuleRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDataBaseModuleRelaBL
{
public static RelatedActions_vDataBaseModuleRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDataBaseModuleRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDataBaseModuleRelaDA vDataBaseModuleRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDataBaseModuleRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDataBaseModuleRelaBL()
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
if (string.IsNullOrEmpty(clsvDataBaseModuleRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataBaseModuleRelaEN._ConnectString);
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
public static DataTable GetDataTable_vDataBaseModuleRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDataBaseModuleRelaDA.GetDataTable_vDataBaseModuleRela(strWhereCond);
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
objDT = vDataBaseModuleRelaDA.GetDataTable(strWhereCond);
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
objDT = vDataBaseModuleRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDataBaseModuleRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDataBaseModuleRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDataBaseModuleRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vDataBaseModuleRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDataBaseModuleRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDataBaseModuleRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
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
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDataBaseModuleRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvDataBaseModuleRelaEN._CurrTabName);
List<clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLst_Sel =
arrvDataBaseModuleRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvDataBaseModuleRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetObjLst(string strWhereCond)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDataBaseModuleRelaEN> GetSubObjLstCache(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaCond)
{
List<clsvDataBaseModuleRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDataBaseModuleRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataBaseModuleRela._AttributeName)
{
if (objvDataBaseModuleRelaCond.IsUpdated(strFldName) == false) continue;
if (objvDataBaseModuleRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataBaseModuleRelaCond[strFldName].ToString());
}
else
{
if (objvDataBaseModuleRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataBaseModuleRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataBaseModuleRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataBaseModuleRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataBaseModuleRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataBaseModuleRelaCond[strFldName]));
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
List<clsvDataBaseModuleRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDataBaseModuleRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDataBaseModuleRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
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
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
public static List<clsvDataBaseModuleRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
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
public static List<clsvDataBaseModuleRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDataBaseModuleRelaEN> arrObjLst = new List<clsvDataBaseModuleRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = new clsvDataBaseModuleRelaEN();
try
{
objvDataBaseModuleRelaEN.mId = Int32.Parse(objRow[convDataBaseModuleRela.mId].ToString().Trim()); //mId
objvDataBaseModuleRelaEN.PrjId = objRow[convDataBaseModuleRela.PrjId].ToString().Trim(); //工程Id
objvDataBaseModuleRelaEN.PrjName = objRow[convDataBaseModuleRela.PrjName].ToString().Trim(); //工程名称
objvDataBaseModuleRelaEN.PrjDataBaseId = objRow[convDataBaseModuleRela.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvDataBaseModuleRelaEN.PrjDataBaseName = objRow[convDataBaseModuleRela.PrjDataBaseName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvDataBaseModuleRelaEN.FuncModuleAgcId = objRow[convDataBaseModuleRela.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvDataBaseModuleRelaEN.FuncModuleName = objRow[convDataBaseModuleRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvDataBaseModuleRelaEN.FuncModuleEnName = objRow[convDataBaseModuleRela.FuncModuleEnName] == DBNull.Value ? null : objRow[convDataBaseModuleRela.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvDataBaseModuleRelaEN.OrderNum = Int32.Parse(objRow[convDataBaseModuleRela.OrderNum].ToString().Trim()); //序号
objvDataBaseModuleRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convDataBaseModuleRela.IsVisible].ToString().Trim()); //是否显示
objvDataBaseModuleRelaEN.UpdUserId = objRow[convDataBaseModuleRela.UpdUserId] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdUserId].ToString().Trim(); //修改用户Id
objvDataBaseModuleRelaEN.UpdDate = objRow[convDataBaseModuleRela.UpdDate] == DBNull.Value ? null : objRow[convDataBaseModuleRela.UpdDate].ToString().Trim(); //修改日期
objvDataBaseModuleRelaEN.Memo = objRow[convDataBaseModuleRela.Memo] == DBNull.Value ? null : objRow[convDataBaseModuleRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataBaseModuleRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataBaseModuleRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDataBaseModuleRela(ref clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
bool bolResult = vDataBaseModuleRelaDA.GetvDataBaseModuleRela(ref objvDataBaseModuleRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataBaseModuleRelaEN GetObjBymId(long lngmId)
{
clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = vDataBaseModuleRelaDA.GetObjBymId(lngmId);
return objvDataBaseModuleRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDataBaseModuleRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = vDataBaseModuleRelaDA.GetFirstObj(strWhereCond);
 return objvDataBaseModuleRelaEN;
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
public static clsvDataBaseModuleRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = vDataBaseModuleRelaDA.GetObjByDataRow(objRow);
 return objvDataBaseModuleRelaEN;
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
public static clsvDataBaseModuleRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN = vDataBaseModuleRelaDA.GetObjByDataRow(objRow);
 return objvDataBaseModuleRelaEN;
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
 /// <param name = "lstvDataBaseModuleRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataBaseModuleRelaEN GetObjBymIdFromList(long lngmId, List<clsvDataBaseModuleRelaEN> lstvDataBaseModuleRelaObjLst)
{
foreach (clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN in lstvDataBaseModuleRelaObjLst)
{
if (objvDataBaseModuleRelaEN.mId == lngmId)
{
return objvDataBaseModuleRelaEN;
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
 lngmId = new clsvDataBaseModuleRelaDA().GetFirstID(strWhereCond);
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
 arrList = vDataBaseModuleRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vDataBaseModuleRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vDataBaseModuleRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvDataBaseModuleRelaDA.IsExistTable();
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
 bolIsExist = vDataBaseModuleRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvDataBaseModuleRelaENS">源对象</param>
 /// <param name = "objvDataBaseModuleRelaENT">目标对象</param>
 public static void CopyTo(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENS, clsvDataBaseModuleRelaEN objvDataBaseModuleRelaENT)
{
try
{
objvDataBaseModuleRelaENT.mId = objvDataBaseModuleRelaENS.mId; //mId
objvDataBaseModuleRelaENT.PrjId = objvDataBaseModuleRelaENS.PrjId; //工程Id
objvDataBaseModuleRelaENT.PrjName = objvDataBaseModuleRelaENS.PrjName; //工程名称
objvDataBaseModuleRelaENT.PrjDataBaseId = objvDataBaseModuleRelaENS.PrjDataBaseId; //项目数据库Id
objvDataBaseModuleRelaENT.PrjDataBaseName = objvDataBaseModuleRelaENS.PrjDataBaseName; //项目数据库名
objvDataBaseModuleRelaENT.FuncModuleAgcId = objvDataBaseModuleRelaENS.FuncModuleAgcId; //功能模块Id
objvDataBaseModuleRelaENT.FuncModuleName = objvDataBaseModuleRelaENS.FuncModuleName; //功能模块名称
objvDataBaseModuleRelaENT.FuncModuleEnName = objvDataBaseModuleRelaENS.FuncModuleEnName; //功能模块英文名称
objvDataBaseModuleRelaENT.OrderNum = objvDataBaseModuleRelaENS.OrderNum; //序号
objvDataBaseModuleRelaENT.IsVisible = objvDataBaseModuleRelaENS.IsVisible; //是否显示
objvDataBaseModuleRelaENT.UpdUserId = objvDataBaseModuleRelaENS.UpdUserId; //修改用户Id
objvDataBaseModuleRelaENT.UpdDate = objvDataBaseModuleRelaENS.UpdDate; //修改日期
objvDataBaseModuleRelaENT.Memo = objvDataBaseModuleRelaENS.Memo; //说明
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
 /// <param name = "objvDataBaseModuleRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
try
{
objvDataBaseModuleRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDataBaseModuleRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDataBaseModuleRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.mId = objvDataBaseModuleRelaEN.mId; //mId
}
if (arrFldSet.Contains(convDataBaseModuleRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.PrjId = objvDataBaseModuleRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDataBaseModuleRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.PrjName = objvDataBaseModuleRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convDataBaseModuleRela.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.PrjDataBaseId = objvDataBaseModuleRelaEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convDataBaseModuleRela.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.PrjDataBaseName = objvDataBaseModuleRelaEN.PrjDataBaseName == "[null]" ? null :  objvDataBaseModuleRelaEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convDataBaseModuleRela.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.FuncModuleAgcId = objvDataBaseModuleRelaEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convDataBaseModuleRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.FuncModuleName = objvDataBaseModuleRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convDataBaseModuleRela.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.FuncModuleEnName = objvDataBaseModuleRelaEN.FuncModuleEnName == "[null]" ? null :  objvDataBaseModuleRelaEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convDataBaseModuleRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.OrderNum = objvDataBaseModuleRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convDataBaseModuleRela.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.IsVisible = objvDataBaseModuleRelaEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convDataBaseModuleRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.UpdUserId = objvDataBaseModuleRelaEN.UpdUserId == "[null]" ? null :  objvDataBaseModuleRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convDataBaseModuleRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.UpdDate = objvDataBaseModuleRelaEN.UpdDate == "[null]" ? null :  objvDataBaseModuleRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDataBaseModuleRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataBaseModuleRelaEN.Memo = objvDataBaseModuleRelaEN.Memo == "[null]" ? null :  objvDataBaseModuleRelaEN.Memo; //说明
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
 /// <param name = "objvDataBaseModuleRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
try
{
if (objvDataBaseModuleRelaEN.PrjDataBaseName == "[null]") objvDataBaseModuleRelaEN.PrjDataBaseName = null; //项目数据库名
if (objvDataBaseModuleRelaEN.FuncModuleEnName == "[null]") objvDataBaseModuleRelaEN.FuncModuleEnName = null; //功能模块英文名称
if (objvDataBaseModuleRelaEN.UpdUserId == "[null]") objvDataBaseModuleRelaEN.UpdUserId = null; //修改用户Id
if (objvDataBaseModuleRelaEN.UpdDate == "[null]") objvDataBaseModuleRelaEN.UpdDate = null; //修改日期
if (objvDataBaseModuleRelaEN.Memo == "[null]") objvDataBaseModuleRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaEN)
{
 vDataBaseModuleRelaDA.CheckProperty4Condition(objvDataBaseModuleRelaEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataBaseModuleRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataBaseModuleRelaBL没有刷新缓存机制(clsDataBaseModuleRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvDataBaseModuleRelaObjLstCache == null)
//{
//arrvDataBaseModuleRelaObjLstCache = vDataBaseModuleRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataBaseModuleRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvDataBaseModuleRelaEN._CurrTabName);
List<clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLst_Sel =
arrvDataBaseModuleRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvDataBaseModuleRelaObjLst_Sel.Count() == 0)
{
   clsvDataBaseModuleRelaEN obj = clsvDataBaseModuleRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvDataBaseModuleRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetAllvDataBaseModuleRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLstCache = GetObjLstCache(); 
return arrvDataBaseModuleRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataBaseModuleRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvDataBaseModuleRelaEN._CurrTabName);
List<clsvDataBaseModuleRelaEN> arrvDataBaseModuleRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDataBaseModuleRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvDataBaseModuleRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvDataBaseModuleRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDataBaseModuleRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvDataBaseModuleRelaEN._RefreshTimeLst[clsvDataBaseModuleRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convDataBaseModuleRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDataBaseModuleRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDataBaseModuleRela._AttributeName));
throw new Exception(strMsg);
}
var objvDataBaseModuleRela = clsvDataBaseModuleRelaBL.GetObjBymIdCache(lngmId);
if (objvDataBaseModuleRela == null) return "";
return objvDataBaseModuleRela[strOutFldName].ToString();
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
int intRecCount = clsvDataBaseModuleRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvDataBaseModuleRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDataBaseModuleRelaDA.GetRecCount();
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
int intRecCount = clsvDataBaseModuleRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDataBaseModuleRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDataBaseModuleRelaEN objvDataBaseModuleRelaCond)
{
List<clsvDataBaseModuleRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDataBaseModuleRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataBaseModuleRela._AttributeName)
{
if (objvDataBaseModuleRelaCond.IsUpdated(strFldName) == false) continue;
if (objvDataBaseModuleRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataBaseModuleRelaCond[strFldName].ToString());
}
else
{
if (objvDataBaseModuleRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataBaseModuleRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataBaseModuleRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataBaseModuleRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataBaseModuleRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataBaseModuleRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataBaseModuleRelaCond[strFldName]));
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
 List<string> arrList = clsvDataBaseModuleRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDataBaseModuleRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDataBaseModuleRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}