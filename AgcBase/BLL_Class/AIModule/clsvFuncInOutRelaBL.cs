
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncInOutRelaBL
 表名:vFuncInOutRela(00050408)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvFuncInOutRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncInOutRelaEN GetObj(this K_mId_vFuncInOutRela myKey)
{
clsvFuncInOutRelaEN objvFuncInOutRelaEN = clsvFuncInOutRelaBL.vFuncInOutRelaDA.GetObjBymId(myKey.Value);
return objvFuncInOutRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetmId(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, long lngmId, string strComparisonOp="")
	{
objvFuncInOutRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.mId) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.mId, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.mId] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetFuncTabId(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strFuncTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTabId, 8, convFuncInOutRela.FuncTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTabId, 8, convFuncInOutRela.FuncTabId);
}
objvFuncInOutRelaEN.FuncTabId = strFuncTabId; //功能表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.FuncTabId) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.FuncTabId, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.FuncTabId] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetTabName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convFuncInOutRela.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convFuncInOutRela.TabName);
}
objvFuncInOutRelaEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.TabName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.TabName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.TabName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetTabCnName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, convFuncInOutRela.TabCnName);
}
objvFuncInOutRelaEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.TabCnName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.TabCnName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.TabCnName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetInFldIds(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strInFldIds, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInFldIds, 1000, convFuncInOutRela.InFldIds);
}
objvFuncInOutRelaEN.InFldIds = strInFldIds; //输入字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.InFldIds) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.InFldIds, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.InFldIds] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetInFldNames(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strInFldNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInFldNames, 1000, convFuncInOutRela.InFldNames);
}
objvFuncInOutRelaEN.InFldNames = strInFldNames; //输入字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.InFldNames) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.InFldNames, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.InFldNames] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetOutFldIds(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strOutFldIds, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldIds, 1000, convFuncInOutRela.OutFldIds);
}
objvFuncInOutRelaEN.OutFldIds = strOutFldIds; //输出字段Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.OutFldIds) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.OutFldIds, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.OutFldIds] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetOutFldNames(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strOutFldNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutFldNames, 1000, convFuncInOutRela.OutFldNames);
}
objvFuncInOutRelaEN.OutFldNames = strOutFldNames; //输出字段名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.OutFldNames) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.OutFldNames, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.OutFldNames] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetGcFuncName(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strGcFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcFuncName, 50, convFuncInOutRela.GcFuncName);
}
objvFuncInOutRelaEN.GcFuncName = strGcFuncName; //GC函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.GcFuncName) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.GcFuncName, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.GcFuncName] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetUpdDate(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFuncInOutRela.UpdDate);
}
objvFuncInOutRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.UpdDate) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.UpdDate, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.UpdDate] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetUpdUser(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFuncInOutRela.UpdUser);
}
objvFuncInOutRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.UpdUser) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.UpdUser, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.UpdUser] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncInOutRelaEN SetMemo(this clsvFuncInOutRelaEN objvFuncInOutRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFuncInOutRela.Memo);
}
objvFuncInOutRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncInOutRelaEN.dicFldComparisonOp.ContainsKey(convFuncInOutRela.Memo) == false)
{
objvFuncInOutRelaEN.dicFldComparisonOp.Add(convFuncInOutRela.Memo, strComparisonOp);
}
else
{
objvFuncInOutRelaEN.dicFldComparisonOp[convFuncInOutRela.Memo] = strComparisonOp;
}
}
return objvFuncInOutRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncInOutRelaENS">源对象</param>
 /// <param name = "objvFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(this clsvFuncInOutRelaEN objvFuncInOutRelaENS, clsvFuncInOutRelaEN objvFuncInOutRelaENT)
{
try
{
objvFuncInOutRelaENT.mId = objvFuncInOutRelaENS.mId; //mId
objvFuncInOutRelaENT.FuncTabId = objvFuncInOutRelaENS.FuncTabId; //功能表Id
objvFuncInOutRelaENT.TabName = objvFuncInOutRelaENS.TabName; //表名
objvFuncInOutRelaENT.TabCnName = objvFuncInOutRelaENS.TabCnName; //表中文名
objvFuncInOutRelaENT.InFldIds = objvFuncInOutRelaENS.InFldIds; //输入字段Ids
objvFuncInOutRelaENT.InFldNames = objvFuncInOutRelaENS.InFldNames; //输入字段名s
objvFuncInOutRelaENT.OutFldIds = objvFuncInOutRelaENS.OutFldIds; //输出字段Ids
objvFuncInOutRelaENT.OutFldNames = objvFuncInOutRelaENS.OutFldNames; //输出字段名s
objvFuncInOutRelaENT.GcFuncName = objvFuncInOutRelaENS.GcFuncName; //GC函数名
objvFuncInOutRelaENT.UpdDate = objvFuncInOutRelaENS.UpdDate; //修改日期
objvFuncInOutRelaENT.UpdUser = objvFuncInOutRelaENS.UpdUser; //修改者
objvFuncInOutRelaENT.Memo = objvFuncInOutRelaENS.Memo; //说明
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
 /// <param name = "objvFuncInOutRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFuncInOutRelaEN:objvFuncInOutRelaENT</returns>
 public static clsvFuncInOutRelaEN CopyTo(this clsvFuncInOutRelaEN objvFuncInOutRelaENS)
{
try
{
 clsvFuncInOutRelaEN objvFuncInOutRelaENT = new clsvFuncInOutRelaEN()
{
mId = objvFuncInOutRelaENS.mId, //mId
FuncTabId = objvFuncInOutRelaENS.FuncTabId, //功能表Id
TabName = objvFuncInOutRelaENS.TabName, //表名
TabCnName = objvFuncInOutRelaENS.TabCnName, //表中文名
InFldIds = objvFuncInOutRelaENS.InFldIds, //输入字段Ids
InFldNames = objvFuncInOutRelaENS.InFldNames, //输入字段名s
OutFldIds = objvFuncInOutRelaENS.OutFldIds, //输出字段Ids
OutFldNames = objvFuncInOutRelaENS.OutFldNames, //输出字段名s
GcFuncName = objvFuncInOutRelaENS.GcFuncName, //GC函数名
UpdDate = objvFuncInOutRelaENS.UpdDate, //修改日期
UpdUser = objvFuncInOutRelaENS.UpdUser, //修改者
Memo = objvFuncInOutRelaENS.Memo, //说明
};
 return objvFuncInOutRelaENT;
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
public static void CheckProperty4Condition(this clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
 clsvFuncInOutRelaBL.vFuncInOutRelaDA.CheckProperty4Condition(objvFuncInOutRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncInOutRelaEN objvFuncInOutRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.mId) == true)
{
string strComparisonOpmId = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncInOutRela.mId, objvFuncInOutRelaCond.mId, strComparisonOpmId);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.FuncTabId) == true)
{
string strComparisonOpFuncTabId = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.FuncTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.FuncTabId, objvFuncInOutRelaCond.FuncTabId, strComparisonOpFuncTabId);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.TabName) == true)
{
string strComparisonOpTabName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.TabName, objvFuncInOutRelaCond.TabName, strComparisonOpTabName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.TabCnName) == true)
{
string strComparisonOpTabCnName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.TabCnName, objvFuncInOutRelaCond.TabCnName, strComparisonOpTabCnName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.InFldIds) == true)
{
string strComparisonOpInFldIds = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.InFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.InFldIds, objvFuncInOutRelaCond.InFldIds, strComparisonOpInFldIds);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.InFldNames) == true)
{
string strComparisonOpInFldNames = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.InFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.InFldNames, objvFuncInOutRelaCond.InFldNames, strComparisonOpInFldNames);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.OutFldIds) == true)
{
string strComparisonOpOutFldIds = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.OutFldIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.OutFldIds, objvFuncInOutRelaCond.OutFldIds, strComparisonOpOutFldIds);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.OutFldNames) == true)
{
string strComparisonOpOutFldNames = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.OutFldNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.OutFldNames, objvFuncInOutRelaCond.OutFldNames, strComparisonOpOutFldNames);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.GcFuncName) == true)
{
string strComparisonOpGcFuncName = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.GcFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.GcFuncName, objvFuncInOutRelaCond.GcFuncName, strComparisonOpGcFuncName);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.UpdDate, objvFuncInOutRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.UpdUser, objvFuncInOutRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFuncInOutRelaCond.IsUpdated(convFuncInOutRela.Memo) == true)
{
string strComparisonOpMemo = objvFuncInOutRelaCond.dicFldComparisonOp[convFuncInOutRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncInOutRela.Memo, objvFuncInOutRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncInOutRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数输入输出关系(vFuncInOutRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncInOutRelaBL
{
public static RelatedActions_vFuncInOutRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncInOutRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncInOutRelaDA vFuncInOutRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncInOutRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncInOutRelaBL()
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
if (string.IsNullOrEmpty(clsvFuncInOutRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncInOutRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFuncInOutRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncInOutRelaDA.GetDataTable_vFuncInOutRela(strWhereCond);
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
objDT = vFuncInOutRelaDA.GetDataTable(strWhereCond);
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
objDT = vFuncInOutRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncInOutRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncInOutRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncInOutRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncInOutRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncInOutRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncInOutRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
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
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncInOutRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLst_Sel =
arrvFuncInOutRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFuncInOutRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
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
public static List<clsvFuncInOutRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncInOutRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncInOutRelaEN> GetSubObjLstCache(clsvFuncInOutRelaEN objvFuncInOutRelaCond)
{
List<clsvFuncInOutRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncInOutRela._AttributeName)
{
if (objvFuncInOutRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFuncInOutRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncInOutRelaCond[strFldName].ToString());
}
else
{
if (objvFuncInOutRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncInOutRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncInOutRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncInOutRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncInOutRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncInOutRelaCond[strFldName]));
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
public static List<clsvFuncInOutRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
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
List<clsvFuncInOutRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncInOutRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncInOutRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
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
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
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
public static List<clsvFuncInOutRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncInOutRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
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
public static List<clsvFuncInOutRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncInOutRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncInOutRela(ref clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
bool bolResult = vFuncInOutRelaDA.GetvFuncInOutRela(ref objvFuncInOutRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncInOutRelaEN GetObjBymId(long lngmId)
{
clsvFuncInOutRelaEN objvFuncInOutRelaEN = vFuncInOutRelaDA.GetObjBymId(lngmId);
return objvFuncInOutRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncInOutRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncInOutRelaEN objvFuncInOutRelaEN = vFuncInOutRelaDA.GetFirstObj(strWhereCond);
 return objvFuncInOutRelaEN;
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
public static clsvFuncInOutRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncInOutRelaEN objvFuncInOutRelaEN = vFuncInOutRelaDA.GetObjByDataRow(objRow);
 return objvFuncInOutRelaEN;
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
public static clsvFuncInOutRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncInOutRelaEN objvFuncInOutRelaEN = vFuncInOutRelaDA.GetObjByDataRow(objRow);
 return objvFuncInOutRelaEN;
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
 /// <param name = "lstvFuncInOutRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncInOutRelaEN GetObjBymIdFromList(long lngmId, List<clsvFuncInOutRelaEN> lstvFuncInOutRelaObjLst)
{
foreach (clsvFuncInOutRelaEN objvFuncInOutRelaEN in lstvFuncInOutRelaObjLst)
{
if (objvFuncInOutRelaEN.mId == lngmId)
{
return objvFuncInOutRelaEN;
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
 lngmId = new clsvFuncInOutRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFuncInOutRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncInOutRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFuncInOutRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFuncInOutRelaDA.IsExistTable();
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
 bolIsExist = vFuncInOutRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncInOutRelaENS">源对象</param>
 /// <param name = "objvFuncInOutRelaENT">目标对象</param>
 public static void CopyTo(clsvFuncInOutRelaEN objvFuncInOutRelaENS, clsvFuncInOutRelaEN objvFuncInOutRelaENT)
{
try
{
objvFuncInOutRelaENT.mId = objvFuncInOutRelaENS.mId; //mId
objvFuncInOutRelaENT.FuncTabId = objvFuncInOutRelaENS.FuncTabId; //功能表Id
objvFuncInOutRelaENT.TabName = objvFuncInOutRelaENS.TabName; //表名
objvFuncInOutRelaENT.TabCnName = objvFuncInOutRelaENS.TabCnName; //表中文名
objvFuncInOutRelaENT.InFldIds = objvFuncInOutRelaENS.InFldIds; //输入字段Ids
objvFuncInOutRelaENT.InFldNames = objvFuncInOutRelaENS.InFldNames; //输入字段名s
objvFuncInOutRelaENT.OutFldIds = objvFuncInOutRelaENS.OutFldIds; //输出字段Ids
objvFuncInOutRelaENT.OutFldNames = objvFuncInOutRelaENS.OutFldNames; //输出字段名s
objvFuncInOutRelaENT.GcFuncName = objvFuncInOutRelaENS.GcFuncName; //GC函数名
objvFuncInOutRelaENT.UpdDate = objvFuncInOutRelaENS.UpdDate; //修改日期
objvFuncInOutRelaENT.UpdUser = objvFuncInOutRelaENS.UpdUser; //修改者
objvFuncInOutRelaENT.Memo = objvFuncInOutRelaENS.Memo; //说明
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
 /// <param name = "objvFuncInOutRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
try
{
objvFuncInOutRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncInOutRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncInOutRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.mId = objvFuncInOutRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFuncInOutRela.FuncTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.FuncTabId = objvFuncInOutRelaEN.FuncTabId == "[null]" ? null :  objvFuncInOutRelaEN.FuncTabId; //功能表Id
}
if (arrFldSet.Contains(convFuncInOutRela.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.TabName = objvFuncInOutRelaEN.TabName; //表名
}
if (arrFldSet.Contains(convFuncInOutRela.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.TabCnName = objvFuncInOutRelaEN.TabCnName == "[null]" ? null :  objvFuncInOutRelaEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(convFuncInOutRela.InFldIds, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.InFldIds = objvFuncInOutRelaEN.InFldIds == "[null]" ? null :  objvFuncInOutRelaEN.InFldIds; //输入字段Ids
}
if (arrFldSet.Contains(convFuncInOutRela.InFldNames, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.InFldNames = objvFuncInOutRelaEN.InFldNames == "[null]" ? null :  objvFuncInOutRelaEN.InFldNames; //输入字段名s
}
if (arrFldSet.Contains(convFuncInOutRela.OutFldIds, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.OutFldIds = objvFuncInOutRelaEN.OutFldIds == "[null]" ? null :  objvFuncInOutRelaEN.OutFldIds; //输出字段Ids
}
if (arrFldSet.Contains(convFuncInOutRela.OutFldNames, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.OutFldNames = objvFuncInOutRelaEN.OutFldNames == "[null]" ? null :  objvFuncInOutRelaEN.OutFldNames; //输出字段名s
}
if (arrFldSet.Contains(convFuncInOutRela.GcFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.GcFuncName = objvFuncInOutRelaEN.GcFuncName == "[null]" ? null :  objvFuncInOutRelaEN.GcFuncName; //GC函数名
}
if (arrFldSet.Contains(convFuncInOutRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.UpdDate = objvFuncInOutRelaEN.UpdDate == "[null]" ? null :  objvFuncInOutRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFuncInOutRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.UpdUser = objvFuncInOutRelaEN.UpdUser == "[null]" ? null :  objvFuncInOutRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFuncInOutRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncInOutRelaEN.Memo = objvFuncInOutRelaEN.Memo == "[null]" ? null :  objvFuncInOutRelaEN.Memo; //说明
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
 /// <param name = "objvFuncInOutRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
try
{
if (objvFuncInOutRelaEN.FuncTabId == "[null]") objvFuncInOutRelaEN.FuncTabId = null; //功能表Id
if (objvFuncInOutRelaEN.TabCnName == "[null]") objvFuncInOutRelaEN.TabCnName = null; //表中文名
if (objvFuncInOutRelaEN.InFldIds == "[null]") objvFuncInOutRelaEN.InFldIds = null; //输入字段Ids
if (objvFuncInOutRelaEN.InFldNames == "[null]") objvFuncInOutRelaEN.InFldNames = null; //输入字段名s
if (objvFuncInOutRelaEN.OutFldIds == "[null]") objvFuncInOutRelaEN.OutFldIds = null; //输出字段Ids
if (objvFuncInOutRelaEN.OutFldNames == "[null]") objvFuncInOutRelaEN.OutFldNames = null; //输出字段名s
if (objvFuncInOutRelaEN.GcFuncName == "[null]") objvFuncInOutRelaEN.GcFuncName = null; //GC函数名
if (objvFuncInOutRelaEN.UpdDate == "[null]") objvFuncInOutRelaEN.UpdDate = null; //修改日期
if (objvFuncInOutRelaEN.UpdUser == "[null]") objvFuncInOutRelaEN.UpdUser = null; //修改者
if (objvFuncInOutRelaEN.Memo == "[null]") objvFuncInOutRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
 vFuncInOutRelaDA.CheckProperty4Condition(objvFuncInOutRelaEN);
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
if (clsFuncInOutRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncInOutRelaBL没有刷新缓存机制(clsFuncInOutRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFuncInOutRelaObjLstCache == null)
//{
//arrvFuncInOutRelaObjLstCache = vFuncInOutRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncInOutRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLst_Sel =
arrvFuncInOutRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFuncInOutRelaObjLst_Sel.Count() == 0)
{
   clsvFuncInOutRelaEN obj = clsvFuncInOutRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFuncInOutRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetAllvFuncInOutRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = GetObjLstCache(); 
return arrvFuncInOutRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncInOutRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
List<clsvFuncInOutRelaEN> arrvFuncInOutRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFuncInOutRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFuncInOutRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFuncInOutRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFuncInOutRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFuncInOutRelaEN._RefreshTimeLst[clsvFuncInOutRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFuncInOutRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncInOutRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncInOutRela._AttributeName));
throw new Exception(strMsg);
}
var objvFuncInOutRela = clsvFuncInOutRelaBL.GetObjBymIdCache(lngmId);
if (objvFuncInOutRela == null) return "";
return objvFuncInOutRela[strOutFldName].ToString();
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
int intRecCount = clsvFuncInOutRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncInOutRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncInOutRelaDA.GetRecCount();
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
int intRecCount = clsvFuncInOutRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncInOutRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncInOutRelaEN objvFuncInOutRelaCond)
{
List<clsvFuncInOutRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncInOutRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncInOutRela._AttributeName)
{
if (objvFuncInOutRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFuncInOutRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncInOutRelaCond[strFldName].ToString());
}
else
{
if (objvFuncInOutRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncInOutRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncInOutRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncInOutRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncInOutRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncInOutRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncInOutRelaCond[strFldName]));
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
 List<string> arrList = clsvFuncInOutRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncInOutRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncInOutRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}