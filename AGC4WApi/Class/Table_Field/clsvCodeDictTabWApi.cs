
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeDictTabWApi
 表名:vCodeDictTab(00050541)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvCodeDictTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCodeId">代码Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabCodeId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabCodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convCodeDictTab.CodeTabCodeId);
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convCodeDictTab.CodeTabCodeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCode">代码表_代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabCode(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convCodeDictTab.CodeTabCode);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabId">代码表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabId, convCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convCodeDictTab.CodeTabId);
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convCodeDictTab.CodeTabId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTab">代码表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTab(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convCodeDictTab.CodeTab);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabNameId">代码_名Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabNameId(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTabNameId, convCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convCodeDictTab.CodeTabNameId);
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convCodeDictTab.CodeTabNameId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetCodeTabName(this clsvCodeDictTabEN objvCodeDictTabEN, string strCodeTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabName, 100, convCodeDictTab.CodeTabName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetPrjId(this clsvCodeDictTabEN objvCodeDictTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCodeDictTab.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCodeDictTab.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetPrjName(this clsvCodeDictTabEN objvCodeDictTabEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCodeDictTab.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetUpdDate(this clsvCodeDictTabEN objvCodeDictTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convCodeDictTab.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCodeDictTab.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetUpdUser(this clsvCodeDictTabEN objvCodeDictTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCodeDictTab.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCodeDictTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCodeDictTabEN SetMemo(this clsvCodeDictTabEN objvCodeDictTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCodeDictTab.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v代码字典表(vCodeDictTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCodeDictTabWApi
{
private static readonly string mstrApiControllerName = "vCodeDictTabApi";

 public clsvCodeDictTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTabCodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCodeDictTabEN GetObjByCodeTabCodeId(string strCodeTabCodeId)
{
if (strCodeTabCodeId == "") return null;
string strAction = "GetObjByCodeTabCodeId";
clsvCodeDictTabEN objvCodeDictTabEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeTabCodeId"] = strCodeTabCodeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCodeDictTabEN = JsonConvert.DeserializeObject<clsvCodeDictTabEN>(strJson);
return objvCodeDictTabEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsvCodeDictTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCodeDictTabEN objvCodeDictTabEN;
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
objvCodeDictTabEN = JsonConvert.DeserializeObject<clsvCodeDictTabEN>(strJson);
return objvCodeDictTabEN;
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
 /// <param name = "strCodeTabCodeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCodeDictTabEN GetObjByCodeTabCodeIdCache(string strCodeTabCodeId,string strPrjId)
{
if (string.IsNullOrEmpty(strCodeTabCodeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrvCodeDictTabObjLst_Sel =
from objvCodeDictTabEN in arrvCodeDictTabObjLstCache
where objvCodeDictTabEN.CodeTabCodeId == strCodeTabCodeId 
select objvCodeDictTabEN;
if (arrvCodeDictTabObjLst_Sel.Count() == 0)
{
   clsvCodeDictTabEN obj = clsvCodeDictTabWApi.GetObjByCodeTabCodeId(strCodeTabCodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCodeDictTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLst(string strWhereCond)
{
 List<clsvCodeDictTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
 /// <param name = "arrCodeTabCodeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstByCodeTabCodeIdLst(List<string> arrCodeTabCodeId)
{
 List<clsvCodeDictTabEN> arrObjLst; 
string strAction = "GetObjLstByCodeTabCodeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCodeTabCodeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
 /// <param name = "arrCodeTabCodeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCodeDictTabEN> GetObjLstByCodeTabCodeIdLstCache(List<string> arrCodeTabCodeId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCodeDictTabEN> arrvCodeDictTabObjLst_Sel =
from objvCodeDictTabEN in arrvCodeDictTabObjLstCache
where arrCodeTabCodeId.Contains(objvCodeDictTabEN.CodeTabCodeId)
select objvCodeDictTabEN;
return arrvCodeDictTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCodeDictTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCodeDictTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
public static List<clsvCodeDictTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCodeDictTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
public static List<clsvCodeDictTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCodeDictTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
public static List<clsvCodeDictTabEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCodeDictTabEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCodeDictTabEN>>(strJson);
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
public static bool IsExist(string strCodeTabCodeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeTabCodeId"] = strCodeTabCodeId
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
public static DataTable ToDataTable(List<clsvCodeDictTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCodeDictTabEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCodeDictTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCodeDictTabEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCodeDictTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCodeDictTabEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCodeDictTabWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCodeDictTabWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
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
public static List<clsvCodeDictTabEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCodeDictTabWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCodeDictTabWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCodeDictTabEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCodeDictTabEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCodeDictTab.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCodeDictTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCodeDictTabEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCodeDictTabEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvCodeDictTabWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvCodeDictTabWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvCodeDictTabEN._CurrTabName, strPrjId);
List<clsvCodeDictTabEN> arrvCodeDictTabObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCodeDictTabObjLstCache = CacheHelper.Get<List<clsvCodeDictTabEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCodeDictTabObjLstCache = CacheHelper.Get<List<clsvCodeDictTabEN>>(strKey);
}
return arrvCodeDictTabObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCodeDictTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCodeDictTab.CodeTabCodeId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.CodeTabCode, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.CodeTabId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.CodeTab, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.CodeTabNameId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.CodeTabName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCodeDictTab.Memo, Type.GetType("System.String"));
foreach (clsvCodeDictTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCodeDictTab.CodeTabCodeId] = objInFor[convCodeDictTab.CodeTabCodeId];
objDR[convCodeDictTab.CodeTabCode] = objInFor[convCodeDictTab.CodeTabCode];
objDR[convCodeDictTab.CodeTabId] = objInFor[convCodeDictTab.CodeTabId];
objDR[convCodeDictTab.CodeTab] = objInFor[convCodeDictTab.CodeTab];
objDR[convCodeDictTab.CodeTabNameId] = objInFor[convCodeDictTab.CodeTabNameId];
objDR[convCodeDictTab.CodeTabName] = objInFor[convCodeDictTab.CodeTabName];
objDR[convCodeDictTab.PrjId] = objInFor[convCodeDictTab.PrjId];
objDR[convCodeDictTab.PrjName] = objInFor[convCodeDictTab.PrjName];
objDR[convCodeDictTab.UpdDate] = objInFor[convCodeDictTab.UpdDate];
objDR[convCodeDictTab.UpdUser] = objInFor[convCodeDictTab.UpdUser];
objDR[convCodeDictTab.Memo] = objInFor[convCodeDictTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}