
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectFuncModuleBL
 表名:vCMProjectFuncModule(00050556)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMProjectFuncModuleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectFuncModuleEN GetObj(this K_mId_vCMProjectFuncModule myKey)
{
clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = clsvCMProjectFuncModuleBL.vCMProjectFuncModuleDA.GetObjBymId(myKey.Value);
return objvCMProjectFuncModuleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetmId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, long lngmId, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.mId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.mId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.mId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetCmPrjId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectFuncModule.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectFuncModule.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectFuncModule.CmPrjId);
}
objvCMProjectFuncModuleEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.CmPrjId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetCmPrjName(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectFuncModule.CmPrjName);
}
objvCMProjectFuncModuleEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.CmPrjName) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetFuncModuleAgcId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convCMProjectFuncModule.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convCMProjectFuncModule.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convCMProjectFuncModule.FuncModuleAgcId);
}
objvCMProjectFuncModuleEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.FuncModuleAgcId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.FuncModuleAgcId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleAgcId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetFuncModuleName(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCMProjectFuncModule.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCMProjectFuncModule.FuncModuleName);
}
objvCMProjectFuncModuleEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.FuncModuleName) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.FuncModuleName, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleName] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetTabNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int? intTabNum, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.TabNum = intTabNum; //表数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.TabNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.TabNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.TabNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetViewNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int? intViewNum, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.ViewNum = intViewNum; //界面数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.ViewNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.ViewNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.ViewNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetOrderNum(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMProjectFuncModule.OrderNum);
objvCMProjectFuncModuleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.OrderNum) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.OrderNum, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.OrderNum] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetOrderNumFuncModule(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, int? intOrderNumFuncModule, string strComparisonOp="")
	{
objvCMProjectFuncModuleEN.OrderNumFuncModule = intOrderNumFuncModule; //序号_模块
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.OrderNumFuncModule) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.OrderNumFuncModule, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.OrderNumFuncModule] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetPrjId(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectFuncModule.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectFuncModule.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectFuncModule.PrjId);
}
objvCMProjectFuncModuleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.PrjId) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.PrjId, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.PrjId] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetUpdDate(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectFuncModule.UpdDate);
}
objvCMProjectFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.UpdDate) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.UpdDate, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.UpdDate] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetUpdUser(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectFuncModule.UpdUser);
}
objvCMProjectFuncModuleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.UpdUser) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.UpdUser, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.UpdUser] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectFuncModuleEN SetMemo(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectFuncModule.Memo);
}
objvCMProjectFuncModuleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(convCMProjectFuncModule.Memo) == false)
{
objvCMProjectFuncModuleEN.dicFldComparisonOp.Add(convCMProjectFuncModule.Memo, strComparisonOp);
}
else
{
objvCMProjectFuncModuleEN.dicFldComparisonOp[convCMProjectFuncModule.Memo] = strComparisonOp;
}
}
return objvCMProjectFuncModuleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleENS">源对象</param>
 /// <param name = "objvCMProjectFuncModuleENT">目标对象</param>
 public static void CopyTo(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENS, clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENT)
{
try
{
objvCMProjectFuncModuleENT.mId = objvCMProjectFuncModuleENS.mId; //mId
objvCMProjectFuncModuleENT.CmPrjId = objvCMProjectFuncModuleENS.CmPrjId; //Cm工程Id
objvCMProjectFuncModuleENT.CmPrjName = objvCMProjectFuncModuleENS.CmPrjName; //CM工程名
objvCMProjectFuncModuleENT.FuncModuleAgcId = objvCMProjectFuncModuleENS.FuncModuleAgcId; //功能模块Id
objvCMProjectFuncModuleENT.FuncModuleName = objvCMProjectFuncModuleENS.FuncModuleName; //功能模块名称
objvCMProjectFuncModuleENT.TabNum = objvCMProjectFuncModuleENS.TabNum; //表数
objvCMProjectFuncModuleENT.ViewNum = objvCMProjectFuncModuleENS.ViewNum; //界面数
objvCMProjectFuncModuleENT.OrderNum = objvCMProjectFuncModuleENS.OrderNum; //序号
objvCMProjectFuncModuleENT.OrderNumFuncModule = objvCMProjectFuncModuleENS.OrderNumFuncModule; //序号_模块
objvCMProjectFuncModuleENT.PrjId = objvCMProjectFuncModuleENS.PrjId; //工程Id
objvCMProjectFuncModuleENT.UpdDate = objvCMProjectFuncModuleENS.UpdDate; //修改日期
objvCMProjectFuncModuleENT.UpdUser = objvCMProjectFuncModuleENS.UpdUser; //修改者
objvCMProjectFuncModuleENT.Memo = objvCMProjectFuncModuleENS.Memo; //说明
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
 /// <param name = "objvCMProjectFuncModuleENS">源对象</param>
 /// <returns>目标对象=>clsvCMProjectFuncModuleEN:objvCMProjectFuncModuleENT</returns>
 public static clsvCMProjectFuncModuleEN CopyTo(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENS)
{
try
{
 clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENT = new clsvCMProjectFuncModuleEN()
{
mId = objvCMProjectFuncModuleENS.mId, //mId
CmPrjId = objvCMProjectFuncModuleENS.CmPrjId, //Cm工程Id
CmPrjName = objvCMProjectFuncModuleENS.CmPrjName, //CM工程名
FuncModuleAgcId = objvCMProjectFuncModuleENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvCMProjectFuncModuleENS.FuncModuleName, //功能模块名称
TabNum = objvCMProjectFuncModuleENS.TabNum, //表数
ViewNum = objvCMProjectFuncModuleENS.ViewNum, //界面数
OrderNum = objvCMProjectFuncModuleENS.OrderNum, //序号
OrderNumFuncModule = objvCMProjectFuncModuleENS.OrderNumFuncModule, //序号_模块
PrjId = objvCMProjectFuncModuleENS.PrjId, //工程Id
UpdDate = objvCMProjectFuncModuleENS.UpdDate, //修改日期
UpdUser = objvCMProjectFuncModuleENS.UpdUser, //修改者
Memo = objvCMProjectFuncModuleENS.Memo, //说明
};
 return objvCMProjectFuncModuleENT;
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
public static void CheckProperty4Condition(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN)
{
 clsvCMProjectFuncModuleBL.vCMProjectFuncModuleDA.CheckProperty4Condition(objvCMProjectFuncModuleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectFuncModuleEN objvCMProjectFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.mId) == true)
{
string strComparisonOpmId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.mId, objvCMProjectFuncModuleCond.mId, strComparisonOpmId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.CmPrjId, objvCMProjectFuncModuleCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.CmPrjName, objvCMProjectFuncModuleCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.FuncModuleAgcId, objvCMProjectFuncModuleCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.FuncModuleName, objvCMProjectFuncModuleCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.TabNum) == true)
{
string strComparisonOpTabNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.TabNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.TabNum, objvCMProjectFuncModuleCond.TabNum, strComparisonOpTabNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.ViewNum) == true)
{
string strComparisonOpViewNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.ViewNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.ViewNum, objvCMProjectFuncModuleCond.ViewNum, strComparisonOpViewNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.OrderNum, objvCMProjectFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.OrderNumFuncModule) == true)
{
string strComparisonOpOrderNumFuncModule = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.OrderNumFuncModule];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectFuncModule.OrderNumFuncModule, objvCMProjectFuncModuleCond.OrderNumFuncModule, strComparisonOpOrderNumFuncModule);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.PrjId, objvCMProjectFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.UpdDate, objvCMProjectFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.UpdUser, objvCMProjectFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMProjectFuncModuleCond.IsUpdated(convCMProjectFuncModule.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectFuncModuleCond.dicFldComparisonOp[convCMProjectFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectFuncModule.Memo, objvCMProjectFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMProjectFuncModule
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCMProjectFuncModule(vCMProjectFuncModule)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectFuncModuleBL
{
public static RelatedActions_vCMProjectFuncModule relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMProjectFuncModuleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMProjectFuncModuleDA vCMProjectFuncModuleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMProjectFuncModuleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMProjectFuncModuleBL()
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
if (string.IsNullOrEmpty(clsvCMProjectFuncModuleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectFuncModuleEN._ConnectString);
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
public static DataTable GetDataTable_vCMProjectFuncModule(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMProjectFuncModuleDA.GetDataTable_vCMProjectFuncModule(strWhereCond);
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
objDT = vCMProjectFuncModuleDA.GetDataTable(strWhereCond);
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
objDT = vCMProjectFuncModuleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMProjectFuncModuleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMProjectFuncModuleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMProjectFuncModuleDA.GetDataTable_Top(objTopPara);
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
objDT = vCMProjectFuncModuleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMProjectFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMProjectFuncModuleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
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
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMProjectFuncModuleEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLst_Sel =
arrvCMProjectFuncModuleObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMProjectFuncModuleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLst(string strWhereCond)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMProjectFuncModuleEN> GetSubObjLstCache(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleCond)
{
 string strPrjId = objvCMProjectFuncModuleCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMProjectFuncModuleBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectFuncModuleEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectFuncModule._AttributeName)
{
if (objvCMProjectFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectFuncModuleCond[strFldName].ToString());
}
else
{
if (objvCMProjectFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectFuncModuleCond[strFldName]));
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
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
List<clsvCMProjectFuncModuleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMProjectFuncModuleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMProjectFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
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
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
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
public static List<clsvCMProjectFuncModuleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
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
public static List<clsvCMProjectFuncModuleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMProjectFuncModuleEN> arrObjLst = new List<clsvCMProjectFuncModuleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = new clsvCMProjectFuncModuleEN();
try
{
objvCMProjectFuncModuleEN.mId = Int32.Parse(objRow[convCMProjectFuncModule.mId].ToString().Trim()); //mId
objvCMProjectFuncModuleEN.CmPrjId = objRow[convCMProjectFuncModule.CmPrjId].ToString().Trim(); //Cm工程Id
objvCMProjectFuncModuleEN.CmPrjName = objRow[convCMProjectFuncModule.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectFuncModule.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectFuncModuleEN.FuncModuleAgcId = objRow[convCMProjectFuncModule.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectFuncModuleEN.FuncModuleName = objRow[convCMProjectFuncModule.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectFuncModuleEN.TabNum = objRow[convCMProjectFuncModule.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.TabNum].ToString().Trim()); //表数
objvCMProjectFuncModuleEN.ViewNum = objRow[convCMProjectFuncModule.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.ViewNum].ToString().Trim()); //界面数
objvCMProjectFuncModuleEN.OrderNum = Int32.Parse(objRow[convCMProjectFuncModule.OrderNum].ToString().Trim()); //序号
objvCMProjectFuncModuleEN.OrderNumFuncModule = objRow[convCMProjectFuncModule.OrderNumFuncModule] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectFuncModule.OrderNumFuncModule].ToString().Trim()); //序号_模块
objvCMProjectFuncModuleEN.PrjId = objRow[convCMProjectFuncModule.PrjId].ToString().Trim(); //工程Id
objvCMProjectFuncModuleEN.UpdDate = objRow[convCMProjectFuncModule.UpdDate] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdDate].ToString().Trim(); //修改日期
objvCMProjectFuncModuleEN.UpdUser = objRow[convCMProjectFuncModule.UpdUser] == DBNull.Value ? null : objRow[convCMProjectFuncModule.UpdUser].ToString().Trim(); //修改者
objvCMProjectFuncModuleEN.Memo = objRow[convCMProjectFuncModule.Memo] == DBNull.Value ? null : objRow[convCMProjectFuncModule.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectFuncModuleEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectFuncModuleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMProjectFuncModule(ref clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN)
{
bool bolResult = vCMProjectFuncModuleDA.GetvCMProjectFuncModule(ref objvCMProjectFuncModuleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectFuncModuleEN GetObjBymId(long lngmId)
{
clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = vCMProjectFuncModuleDA.GetObjBymId(lngmId);
return objvCMProjectFuncModuleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMProjectFuncModuleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = vCMProjectFuncModuleDA.GetFirstObj(strWhereCond);
 return objvCMProjectFuncModuleEN;
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
public static clsvCMProjectFuncModuleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = vCMProjectFuncModuleDA.GetObjByDataRow(objRow);
 return objvCMProjectFuncModuleEN;
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
public static clsvCMProjectFuncModuleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN = vCMProjectFuncModuleDA.GetObjByDataRow(objRow);
 return objvCMProjectFuncModuleEN;
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
 /// <param name = "lstvCMProjectFuncModuleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectFuncModuleEN GetObjBymIdFromList(long lngmId, List<clsvCMProjectFuncModuleEN> lstvCMProjectFuncModuleObjLst)
{
foreach (clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN in lstvCMProjectFuncModuleObjLst)
{
if (objvCMProjectFuncModuleEN.mId == lngmId)
{
return objvCMProjectFuncModuleEN;
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
 lngmId = new clsvCMProjectFuncModuleDA().GetFirstID(strWhereCond);
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
 arrList = vCMProjectFuncModuleDA.GetID(strWhereCond);
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
bool bolIsExist = vCMProjectFuncModuleDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCMProjectFuncModuleDA.IsExist(lngmId);
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
 bolIsExist = clsvCMProjectFuncModuleDA.IsExistTable();
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
 bolIsExist = vCMProjectFuncModuleDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMProjectFuncModuleENS">源对象</param>
 /// <param name = "objvCMProjectFuncModuleENT">目标对象</param>
 public static void CopyTo(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENS, clsvCMProjectFuncModuleEN objvCMProjectFuncModuleENT)
{
try
{
objvCMProjectFuncModuleENT.mId = objvCMProjectFuncModuleENS.mId; //mId
objvCMProjectFuncModuleENT.CmPrjId = objvCMProjectFuncModuleENS.CmPrjId; //Cm工程Id
objvCMProjectFuncModuleENT.CmPrjName = objvCMProjectFuncModuleENS.CmPrjName; //CM工程名
objvCMProjectFuncModuleENT.FuncModuleAgcId = objvCMProjectFuncModuleENS.FuncModuleAgcId; //功能模块Id
objvCMProjectFuncModuleENT.FuncModuleName = objvCMProjectFuncModuleENS.FuncModuleName; //功能模块名称
objvCMProjectFuncModuleENT.TabNum = objvCMProjectFuncModuleENS.TabNum; //表数
objvCMProjectFuncModuleENT.ViewNum = objvCMProjectFuncModuleENS.ViewNum; //界面数
objvCMProjectFuncModuleENT.OrderNum = objvCMProjectFuncModuleENS.OrderNum; //序号
objvCMProjectFuncModuleENT.OrderNumFuncModule = objvCMProjectFuncModuleENS.OrderNumFuncModule; //序号_模块
objvCMProjectFuncModuleENT.PrjId = objvCMProjectFuncModuleENS.PrjId; //工程Id
objvCMProjectFuncModuleENT.UpdDate = objvCMProjectFuncModuleENS.UpdDate; //修改日期
objvCMProjectFuncModuleENT.UpdUser = objvCMProjectFuncModuleENS.UpdUser; //修改者
objvCMProjectFuncModuleENT.Memo = objvCMProjectFuncModuleENS.Memo; //说明
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
 /// <param name = "objvCMProjectFuncModuleEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN)
{
try
{
objvCMProjectFuncModuleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMProjectFuncModuleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMProjectFuncModule.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.mId = objvCMProjectFuncModuleEN.mId; //mId
}
if (arrFldSet.Contains(convCMProjectFuncModule.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.CmPrjId = objvCMProjectFuncModuleEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(convCMProjectFuncModule.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.CmPrjName = objvCMProjectFuncModuleEN.CmPrjName == "[null]" ? null :  objvCMProjectFuncModuleEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMProjectFuncModule.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.FuncModuleAgcId = objvCMProjectFuncModuleEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convCMProjectFuncModule.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.FuncModuleName = objvCMProjectFuncModuleEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCMProjectFuncModule.TabNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.TabNum = objvCMProjectFuncModuleEN.TabNum; //表数
}
if (arrFldSet.Contains(convCMProjectFuncModule.ViewNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.ViewNum = objvCMProjectFuncModuleEN.ViewNum; //界面数
}
if (arrFldSet.Contains(convCMProjectFuncModule.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.OrderNum = objvCMProjectFuncModuleEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMProjectFuncModule.OrderNumFuncModule, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.OrderNumFuncModule = objvCMProjectFuncModuleEN.OrderNumFuncModule; //序号_模块
}
if (arrFldSet.Contains(convCMProjectFuncModule.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.PrjId = objvCMProjectFuncModuleEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMProjectFuncModule.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.UpdDate = objvCMProjectFuncModuleEN.UpdDate == "[null]" ? null :  objvCMProjectFuncModuleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMProjectFuncModule.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.UpdUser = objvCMProjectFuncModuleEN.UpdUser == "[null]" ? null :  objvCMProjectFuncModuleEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMProjectFuncModule.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectFuncModuleEN.Memo = objvCMProjectFuncModuleEN.Memo == "[null]" ? null :  objvCMProjectFuncModuleEN.Memo; //说明
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
 /// <param name = "objvCMProjectFuncModuleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN)
{
try
{
if (objvCMProjectFuncModuleEN.CmPrjName == "[null]") objvCMProjectFuncModuleEN.CmPrjName = null; //CM工程名
if (objvCMProjectFuncModuleEN.UpdDate == "[null]") objvCMProjectFuncModuleEN.UpdDate = null; //修改日期
if (objvCMProjectFuncModuleEN.UpdUser == "[null]") objvCMProjectFuncModuleEN.UpdUser = null; //修改者
if (objvCMProjectFuncModuleEN.Memo == "[null]") objvCMProjectFuncModuleEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleEN)
{
 vCMProjectFuncModuleDA.CheckProperty4Condition(objvCMProjectFuncModuleEN);
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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectFuncModuleBL没有刷新缓存机制(clsCMProjectFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewInfoBL没有刷新缓存机制(clsViewInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMProjectFuncModuleObjLstCache == null)
//{
//arrvCMProjectFuncModuleObjLstCache = vCMProjectFuncModuleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectFuncModuleEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLst_Sel =
arrvCMProjectFuncModuleObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMProjectFuncModuleObjLst_Sel.Count() == 0)
{
   clsvCMProjectFuncModuleEN obj = clsvCMProjectFuncModuleBL.GetObjBymId(lngmId);
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
return arrvCMProjectFuncModuleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetAllvCMProjectFuncModuleObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMProjectFuncModuleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectFuncModuleEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMProjectFuncModuleEN> arrvCMProjectFuncModuleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMProjectFuncModuleObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCMProjectFuncModuleEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMProjectFuncModuleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMProjectFuncModuleEN._RefreshTimeLst.Count == 0) return "";
return clsvCMProjectFuncModuleEN._RefreshTimeLst[clsvCMProjectFuncModuleEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convCMProjectFuncModule.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMProjectFuncModule._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMProjectFuncModule._AttributeName));
throw new Exception(strMsg);
}
var objvCMProjectFuncModule = clsvCMProjectFuncModuleBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvCMProjectFuncModule == null) return "";
return objvCMProjectFuncModule[strOutFldName].ToString();
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
int intRecCount = clsvCMProjectFuncModuleDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMProjectFuncModuleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMProjectFuncModuleDA.GetRecCount();
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
int intRecCount = clsvCMProjectFuncModuleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMProjectFuncModuleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMProjectFuncModuleEN objvCMProjectFuncModuleCond)
{
 string strPrjId = objvCMProjectFuncModuleCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMProjectFuncModuleBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectFuncModuleEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectFuncModuleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectFuncModule._AttributeName)
{
if (objvCMProjectFuncModuleCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectFuncModuleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectFuncModuleCond[strFldName].ToString());
}
else
{
if (objvCMProjectFuncModuleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectFuncModuleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectFuncModuleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectFuncModuleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectFuncModuleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectFuncModuleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectFuncModuleCond[strFldName]));
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
 List<string> arrList = clsvCMProjectFuncModuleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectFuncModuleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectFuncModuleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}