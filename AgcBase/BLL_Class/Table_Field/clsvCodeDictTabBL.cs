
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeDictTabBL
 表名:vCodeDictTab(00050541)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:20
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
public static class  clsvCodeDictTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeDictTabEN GetObj(this K_CodeTabCodeId_vCodeDictTab myKey)
{
clsvCodeDictTabEN objvCodeDictTabEN = clsvCodeDictTabBL.vCodeDictTabDA.GetObjByCodeTabCodeId(myKey.Value);
return objvCodeDictTabEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabCodeId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabCodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convCodeDictTab.CodeTabCodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convCodeDictTab.CodeTabCodeId);
}
objvCodeDictTabEN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTabCodeId) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTabCodeId, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTabCodeId] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabCode(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convCodeDictTab.CodeTabCode);
}
objvCodeDictTabEN.CodeTabCode = strCodeTabCode; //代码表_代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTabCode) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTabCode, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTabCode] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabId, convCodeDictTab.CodeTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convCodeDictTab.CodeTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convCodeDictTab.CodeTabId);
}
objvCodeDictTabEN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTabId) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTabId, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTabId] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTab(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convCodeDictTab.CodeTab);
}
objvCodeDictTabEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTab) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTab, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTab] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabNameId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabNameId, convCodeDictTab.CodeTabNameId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convCodeDictTab.CodeTabNameId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convCodeDictTab.CodeTabNameId);
}
objvCodeDictTabEN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTabNameId) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTabNameId, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTabNameId] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabName(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 100, convCodeDictTab.CodeTabName);
}
objvCodeDictTabEN.CodeTabName = strCodeTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.CodeTabName) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.CodeTabName, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.CodeTabName] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetPrjId(this clsvCodeDictTabEN objvCodeDictTabEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCodeDictTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCodeDictTab.PrjId);
}
objvCodeDictTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.PrjId) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.PrjId, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.PrjId] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetPrjName(this clsvCodeDictTabEN objvCodeDictTabEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCodeDictTab.PrjName);
}
objvCodeDictTabEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.PrjName) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.PrjName, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.PrjName] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetUpdDate(this clsvCodeDictTabEN objvCodeDictTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convCodeDictTab.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCodeDictTab.UpdDate);
}
objvCodeDictTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.UpdDate) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.UpdDate, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.UpdDate] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetUpdUser(this clsvCodeDictTabEN objvCodeDictTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCodeDictTab.UpdUser);
}
objvCodeDictTabEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.UpdUser) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.UpdUser, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.UpdUser] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetMemo(this clsvCodeDictTabEN objvCodeDictTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCodeDictTab.Memo);
}
objvCodeDictTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCodeDictTabEN.dicFldComparisonOp.ContainsKey(convCodeDictTab.Memo) == false)
{
objvCodeDictTabEN.dicFldComparisonOp.Add(convCodeDictTab.Memo, strComparisonOp);
}
else
{
objvCodeDictTabEN.dicFldComparisonOp[convCodeDictTab.Memo] = strComparisonOp;
}
}
return objvCodeDictTabEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCodeDictTabENS">源对象</param>
 /// <param name = "objvCodeDictTabENT">目标对象</param>
 public static void CopyTo(this clsvCodeDictTabEN objvCodeDictTabENS, clsvCodeDictTabEN objvCodeDictTabENT)
{
try
{
objvCodeDictTabENT.CodeTabCodeId = objvCodeDictTabENS.CodeTabCodeId; //代码Id
objvCodeDictTabENT.CodeTabCode = objvCodeDictTabENS.CodeTabCode; //代码表_代码
objvCodeDictTabENT.CodeTabId = objvCodeDictTabENS.CodeTabId; //代码表Id
objvCodeDictTabENT.CodeTab = objvCodeDictTabENS.CodeTab; //代码表
objvCodeDictTabENT.CodeTabNameId = objvCodeDictTabENS.CodeTabNameId; //代码_名Id
objvCodeDictTabENT.CodeTabName = objvCodeDictTabENS.CodeTabName; //表名
objvCodeDictTabENT.PrjId = objvCodeDictTabENS.PrjId; //工程Id
objvCodeDictTabENT.PrjName = objvCodeDictTabENS.PrjName; //工程名称
objvCodeDictTabENT.UpdDate = objvCodeDictTabENS.UpdDate; //修改日期
objvCodeDictTabENT.UpdUser = objvCodeDictTabENS.UpdUser; //修改者
objvCodeDictTabENT.Memo = objvCodeDictTabENS.Memo; //说明
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
 /// <param name = "objvCodeDictTabENS">源对象</param>
 /// <returns>目标对象=>clsvCodeDictTabEN:objvCodeDictTabENT</returns>
 public static clsvCodeDictTabEN CopyTo(this clsvCodeDictTabEN objvCodeDictTabENS)
{
try
{
 clsvCodeDictTabEN objvCodeDictTabENT = new clsvCodeDictTabEN()
{
CodeTabCodeId = objvCodeDictTabENS.CodeTabCodeId, //代码Id
CodeTabCode = objvCodeDictTabENS.CodeTabCode, //代码表_代码
CodeTabId = objvCodeDictTabENS.CodeTabId, //代码表Id
CodeTab = objvCodeDictTabENS.CodeTab, //代码表
CodeTabNameId = objvCodeDictTabENS.CodeTabNameId, //代码_名Id
CodeTabName = objvCodeDictTabENS.CodeTabName, //表名
PrjId = objvCodeDictTabENS.PrjId, //工程Id
PrjName = objvCodeDictTabENS.PrjName, //工程名称
UpdDate = objvCodeDictTabENS.UpdDate, //修改日期
UpdUser = objvCodeDictTabENS.UpdUser, //修改者
Memo = objvCodeDictTabENS.Memo, //说明
};
 return objvCodeDictTabENT;
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
public static void CheckProperty4Condition(this clsvCodeDictTabEN objvCodeDictTabEN)
{
 clsvCodeDictTabBL.vCodeDictTabDA.CheckProperty4Condition(objvCodeDictTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCodeDictTabEN objvCodeDictTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTabCodeId, objvCodeDictTabCond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTabCode, objvCodeDictTabCond.CodeTabCode, strComparisonOpCodeTabCode);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTabId, objvCodeDictTabCond.CodeTabId, strComparisonOpCodeTabId);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTab) == true)
{
string strComparisonOpCodeTab = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTab, objvCodeDictTabCond.CodeTab, strComparisonOpCodeTab);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTabNameId, objvCodeDictTabCond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.CodeTabName, objvCodeDictTabCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.PrjId) == true)
{
string strComparisonOpPrjId = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.PrjId, objvCodeDictTabCond.PrjId, strComparisonOpPrjId);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.PrjName) == true)
{
string strComparisonOpPrjName = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.PrjName, objvCodeDictTabCond.PrjName, strComparisonOpPrjName);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.UpdDate, objvCodeDictTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.UpdUser, objvCodeDictTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCodeDictTabCond.IsUpdated(convCodeDictTab.Memo) == true)
{
string strComparisonOpMemo = objvCodeDictTabCond.dicFldComparisonOp[convCodeDictTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCodeDictTab.Memo, objvCodeDictTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCodeDictTab
{
public virtual bool UpdRelaTabDate(string strCodeTabCodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v代码字典表(vCodeDictTab)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCodeDictTabBL
{
public static RelatedActions_vCodeDictTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCodeDictTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCodeDictTabDA vCodeDictTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCodeDictTabDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCodeDictTabBL()
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
if (string.IsNullOrEmpty(clsvCodeDictTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCodeDictTabEN._ConnectString);
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
public static DataTable GetDataTable_vCodeDictTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCodeDictTabDA.GetDataTable_vCodeDictTab(strWhereCond);
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
objDT = vCodeDictTabDA.GetDataTable(strWhereCond);
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
objDT = vCodeDictTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCodeDictTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCodeDictTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCodeDictTabDA.GetDataTable_Top(objTopPara);
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
objDT = vCodeDictTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCodeDictTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCodeDictTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCodeTabCodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstByCodeTabCodeIdLst(List<string> arrCodeTabCodeIdLst)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCodeTabCodeIdLst, true);
 string strWhereCond = string.Format("CodeTabCodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCodeTabCodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCodeDictTabEN> GetObjLstByCodeTabCodeIdLstCache(List<string> arrCodeTabCodeIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrvCodeDictTabObjLst_Sel =
arrvCodeDictTabObjLstCache
.Where(x => arrCodeTabCodeIdLst.Contains(x.CodeTabCodeId));
return arrvCodeDictTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLst(string strWhereCond)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
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
public static List<clsvCodeDictTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCodeDictTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCodeDictTabEN> GetSubObjLstCache(clsvCodeDictTabEN objvCodeDictTabCond)
{
 string strPrjId = objvCodeDictTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCodeDictTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCodeDictTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeDictTab._AttributeName)
{
if (objvCodeDictTabCond.IsUpdated(strFldName) == false) continue;
if (objvCodeDictTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeDictTabCond[strFldName].ToString());
}
else
{
if (objvCodeDictTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeDictTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeDictTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeDictTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeDictTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeDictTabCond[strFldName]));
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
public static List<clsvCodeDictTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
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
public static List<clsvCodeDictTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
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
List<clsvCodeDictTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCodeDictTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCodeDictTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
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
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
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
public static List<clsvCodeDictTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCodeDictTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
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
public static List<clsvCodeDictTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCodeDictTabEN> arrObjLst = new List<clsvCodeDictTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeDictTabEN objvCodeDictTabEN = new clsvCodeDictTabEN();
try
{
objvCodeDictTabEN.CodeTabCodeId = objRow[convCodeDictTab.CodeTabCodeId].ToString().Trim(); //代码Id
objvCodeDictTabEN.CodeTabCode = objRow[convCodeDictTab.CodeTabCode] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabCode].ToString().Trim(); //代码表_代码
objvCodeDictTabEN.CodeTabId = objRow[convCodeDictTab.CodeTabId].ToString().Trim(); //代码表Id
objvCodeDictTabEN.CodeTab = objRow[convCodeDictTab.CodeTab] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTab].ToString().Trim(); //代码表
objvCodeDictTabEN.CodeTabNameId = objRow[convCodeDictTab.CodeTabNameId].ToString().Trim(); //代码_名Id
objvCodeDictTabEN.CodeTabName = objRow[convCodeDictTab.CodeTabName] == DBNull.Value ? null : objRow[convCodeDictTab.CodeTabName].ToString().Trim(); //表名
objvCodeDictTabEN.PrjId = objRow[convCodeDictTab.PrjId] == DBNull.Value ? null : objRow[convCodeDictTab.PrjId].ToString().Trim(); //工程Id
objvCodeDictTabEN.PrjName = objRow[convCodeDictTab.PrjName] == DBNull.Value ? null : objRow[convCodeDictTab.PrjName].ToString().Trim(); //工程名称
objvCodeDictTabEN.UpdDate = objRow[convCodeDictTab.UpdDate].ToString().Trim(); //修改日期
objvCodeDictTabEN.UpdUser = objRow[convCodeDictTab.UpdUser] == DBNull.Value ? null : objRow[convCodeDictTab.UpdUser].ToString().Trim(); //修改者
objvCodeDictTabEN.Memo = objRow[convCodeDictTab.Memo] == DBNull.Value ? null : objRow[convCodeDictTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCodeDictTabEN.CodeTabCodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCodeDictTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCodeDictTab(ref clsvCodeDictTabEN objvCodeDictTabEN)
{
bool bolResult = vCodeDictTabDA.GetvCodeDictTab(ref objvCodeDictTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeDictTabEN GetObjByCodeTabCodeId(string strCodeTabCodeId)
{
if (strCodeTabCodeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCodeTabCodeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCodeTabCodeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCodeTabCodeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvCodeDictTabEN objvCodeDictTabEN = vCodeDictTabDA.GetObjByCodeTabCodeId(strCodeTabCodeId);
return objvCodeDictTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCodeDictTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCodeDictTabEN objvCodeDictTabEN = vCodeDictTabDA.GetFirstObj(strWhereCond);
 return objvCodeDictTabEN;
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
public static clsvCodeDictTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCodeDictTabEN objvCodeDictTabEN = vCodeDictTabDA.GetObjByDataRow(objRow);
 return objvCodeDictTabEN;
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
public static clsvCodeDictTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCodeDictTabEN objvCodeDictTabEN = vCodeDictTabDA.GetObjByDataRow(objRow);
 return objvCodeDictTabEN;
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
 /// <param name = "strCodeTabCodeId">所给的关键字</param>
 /// <param name = "lstvCodeDictTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeDictTabEN GetObjByCodeTabCodeIdFromList(string strCodeTabCodeId, List<clsvCodeDictTabEN> lstvCodeDictTabObjLst)
{
foreach (clsvCodeDictTabEN objvCodeDictTabEN in lstvCodeDictTabObjLst)
{
if (objvCodeDictTabEN.CodeTabCodeId == strCodeTabCodeId)
{
return objvCodeDictTabEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxCodeTabCodeId;
 try
 {
 strMaxCodeTabCodeId = clsvCodeDictTabDA.GetMaxStrId();
 return strMaxCodeTabCodeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strCodeTabCodeId;
 try
 {
 strCodeTabCodeId = new clsvCodeDictTabDA().GetFirstID(strWhereCond);
 return strCodeTabCodeId;
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
 arrList = vCodeDictTabDA.GetID(strWhereCond);
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
bool bolIsExist = vCodeDictTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCodeTabCodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCodeTabCodeId)
{
if (string.IsNullOrEmpty(strCodeTabCodeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCodeTabCodeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vCodeDictTabDA.IsExist(strCodeTabCodeId);
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
 bolIsExist = clsvCodeDictTabDA.IsExistTable();
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
 bolIsExist = vCodeDictTabDA.IsExistTable(strTabName);
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
 /// <param name = "objvCodeDictTabENS">源对象</param>
 /// <param name = "objvCodeDictTabENT">目标对象</param>
 public static void CopyTo(clsvCodeDictTabEN objvCodeDictTabENS, clsvCodeDictTabEN objvCodeDictTabENT)
{
try
{
objvCodeDictTabENT.CodeTabCodeId = objvCodeDictTabENS.CodeTabCodeId; //代码Id
objvCodeDictTabENT.CodeTabCode = objvCodeDictTabENS.CodeTabCode; //代码表_代码
objvCodeDictTabENT.CodeTabId = objvCodeDictTabENS.CodeTabId; //代码表Id
objvCodeDictTabENT.CodeTab = objvCodeDictTabENS.CodeTab; //代码表
objvCodeDictTabENT.CodeTabNameId = objvCodeDictTabENS.CodeTabNameId; //代码_名Id
objvCodeDictTabENT.CodeTabName = objvCodeDictTabENS.CodeTabName; //表名
objvCodeDictTabENT.PrjId = objvCodeDictTabENS.PrjId; //工程Id
objvCodeDictTabENT.PrjName = objvCodeDictTabENS.PrjName; //工程名称
objvCodeDictTabENT.UpdDate = objvCodeDictTabENS.UpdDate; //修改日期
objvCodeDictTabENT.UpdUser = objvCodeDictTabENS.UpdUser; //修改者
objvCodeDictTabENT.Memo = objvCodeDictTabENS.Memo; //说明
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
 /// <param name = "objvCodeDictTabEN">源简化对象</param>
 public static void SetUpdFlag(clsvCodeDictTabEN objvCodeDictTabEN)
{
try
{
objvCodeDictTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCodeDictTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCodeDictTab.CodeTabCodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTabCodeId = objvCodeDictTabEN.CodeTabCodeId; //代码Id
}
if (arrFldSet.Contains(convCodeDictTab.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTabCode = objvCodeDictTabEN.CodeTabCode == "[null]" ? null :  objvCodeDictTabEN.CodeTabCode; //代码表_代码
}
if (arrFldSet.Contains(convCodeDictTab.CodeTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTabId = objvCodeDictTabEN.CodeTabId; //代码表Id
}
if (arrFldSet.Contains(convCodeDictTab.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTab = objvCodeDictTabEN.CodeTab == "[null]" ? null :  objvCodeDictTabEN.CodeTab; //代码表
}
if (arrFldSet.Contains(convCodeDictTab.CodeTabNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTabNameId = objvCodeDictTabEN.CodeTabNameId; //代码_名Id
}
if (arrFldSet.Contains(convCodeDictTab.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.CodeTabName = objvCodeDictTabEN.CodeTabName == "[null]" ? null :  objvCodeDictTabEN.CodeTabName; //表名
}
if (arrFldSet.Contains(convCodeDictTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.PrjId = objvCodeDictTabEN.PrjId == "[null]" ? null :  objvCodeDictTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCodeDictTab.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.PrjName = objvCodeDictTabEN.PrjName == "[null]" ? null :  objvCodeDictTabEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCodeDictTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.UpdDate = objvCodeDictTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCodeDictTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.UpdUser = objvCodeDictTabEN.UpdUser == "[null]" ? null :  objvCodeDictTabEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCodeDictTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCodeDictTabEN.Memo = objvCodeDictTabEN.Memo == "[null]" ? null :  objvCodeDictTabEN.Memo; //说明
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
 /// <param name = "objvCodeDictTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCodeDictTabEN objvCodeDictTabEN)
{
try
{
if (objvCodeDictTabEN.CodeTabCode == "[null]") objvCodeDictTabEN.CodeTabCode = null; //代码表_代码
if (objvCodeDictTabEN.CodeTab == "[null]") objvCodeDictTabEN.CodeTab = null; //代码表
if (objvCodeDictTabEN.CodeTabName == "[null]") objvCodeDictTabEN.CodeTabName = null; //表名
if (objvCodeDictTabEN.PrjId == "[null]") objvCodeDictTabEN.PrjId = null; //工程Id
if (objvCodeDictTabEN.PrjName == "[null]") objvCodeDictTabEN.PrjName = null; //工程名称
if (objvCodeDictTabEN.UpdUser == "[null]") objvCodeDictTabEN.UpdUser = null; //修改者
if (objvCodeDictTabEN.Memo == "[null]") objvCodeDictTabEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCodeDictTabEN objvCodeDictTabEN)
{
 vCodeDictTabDA.CheckProperty4Condition(objvCodeDictTabEN);
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
if (clsCodeDictTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeDictTabBL没有刷新缓存机制(clsCodeDictTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CodeTabCodeId");
//if (arrvCodeDictTabObjLstCache == null)
//{
//arrvCodeDictTabObjLstCache = vCodeDictTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCodeTabCodeId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeDictTabEN GetObjByCodeTabCodeIdCache(string strCodeTabCodeId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrvCodeDictTabObjLst_Sel =
arrvCodeDictTabObjLstCache
.Where(x=> x.CodeTabCodeId == strCodeTabCodeId 
);
if (arrvCodeDictTabObjLst_Sel.Count() == 0)
{
   clsvCodeDictTabEN obj = clsvCodeDictTabBL.GetObjByCodeTabCodeId(strCodeTabCodeId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strCodeTabCodeId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCodeDictTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeDictTabEN> GetAllvCodeDictTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = GetObjLstCache(strPrjId); 
return arrvCodeDictTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCodeDictTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCodeDictTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCodeDictTabEN._RefreshTimeLst.Count == 0) return "";
return clsvCodeDictTabEN._RefreshTimeLst[clsvCodeDictTabEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCodeTabCodeId, string strPrjId)
{
if (strInFldName != convCodeDictTab.CodeTabCodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCodeDictTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCodeDictTab._AttributeName));
throw new Exception(strMsg);
}
var objvCodeDictTab = clsvCodeDictTabBL.GetObjByCodeTabCodeIdCache(strCodeTabCodeId, strPrjId);
if (objvCodeDictTab == null) return "";
return objvCodeDictTab[strOutFldName].ToString();
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
int intRecCount = clsvCodeDictTabDA.GetRecCount(strTabName);
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
int intRecCount = clsvCodeDictTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCodeDictTabDA.GetRecCount();
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
int intRecCount = clsvCodeDictTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCodeDictTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCodeDictTabEN objvCodeDictTabCond)
{
 string strPrjId = objvCodeDictTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCodeDictTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCodeDictTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCodeDictTab._AttributeName)
{
if (objvCodeDictTabCond.IsUpdated(strFldName) == false) continue;
if (objvCodeDictTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeDictTabCond[strFldName].ToString());
}
else
{
if (objvCodeDictTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCodeDictTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCodeDictTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCodeDictTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCodeDictTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCodeDictTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCodeDictTabCond[strFldName]));
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
 List<string> arrList = clsvCodeDictTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCodeDictTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCodeDictTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}