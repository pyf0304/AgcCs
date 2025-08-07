
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimV2WApi
 表名:vPrjTab_SimV2(00050610)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:08
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
public static class  clsvPrjTab_SimV2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTab_SimV2.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTab_SimV2.TabId);
objvPrjTab_SimV2EN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabName(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convPrjTab_SimV2.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convPrjTab_SimV2.TabName);
objvPrjTab_SimV2EN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabName) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabName, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabName] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetSqlDsTypeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlDsTypeId, convPrjTab_SimV2.SqlDsTypeId);
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convPrjTab_SimV2.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convPrjTab_SimV2.SqlDsTypeId);
objvPrjTab_SimV2EN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.SqlDsTypeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.SqlDsTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.SqlDsTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetFuncModuleAgcId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convPrjTab_SimV2.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convPrjTab_SimV2.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convPrjTab_SimV2.FuncModuleAgcId);
objvPrjTab_SimV2EN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.FuncModuleAgcId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.FuncModuleAgcId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.FuncModuleAgcId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strTabTypeId">表类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabTypeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, convPrjTab_SimV2.TabTypeId);
clsCheckSql.CheckFieldLen(strTabTypeId, 4, convPrjTab_SimV2.TabTypeId);
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, convPrjTab_SimV2.TabTypeId);
objvPrjTab_SimV2EN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabTypeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabTypeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabTypeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetCacheModeId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convPrjTab_SimV2.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convPrjTab_SimV2.CacheModeId);
objvPrjTab_SimV2EN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.CacheModeId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.CacheModeId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.CacheModeId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetTabStateId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, convPrjTab_SimV2.TabStateId);
clsCheckSql.CheckFieldLen(strTabStateId, 2, convPrjTab_SimV2.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convPrjTab_SimV2.TabStateId);
objvPrjTab_SimV2EN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.TabStateId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.TabStateId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.TabStateId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTab_SimV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTab_SimV2EN SetCmPrjId(this clsvPrjTab_SimV2EN objvPrjTab_SimV2EN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convPrjTab_SimV2.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convPrjTab_SimV2.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convPrjTab_SimV2.CmPrjId);
objvPrjTab_SimV2EN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTab_SimV2EN.dicFldComparisonOp.ContainsKey(convPrjTab_SimV2.CmPrjId) == false)
{
objvPrjTab_SimV2EN.dicFldComparisonOp.Add(convPrjTab_SimV2.CmPrjId, strComparisonOp);
}
else
{
objvPrjTab_SimV2EN.dicFldComparisonOp[convPrjTab_SimV2.CmPrjId] = strComparisonOp;
}
}
return objvPrjTab_SimV2EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTab_SimV2EN objvPrjTab_SimV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabId) == true)
{
string strComparisonOpTabId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabId, objvPrjTab_SimV2Cond.TabId, strComparisonOpTabId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabName) == true)
{
string strComparisonOpTabName = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabName, objvPrjTab_SimV2Cond.TabName, strComparisonOpTabName);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.SqlDsTypeId, objvPrjTab_SimV2Cond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.FuncModuleAgcId, objvPrjTab_SimV2Cond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabTypeId, objvPrjTab_SimV2Cond.TabTypeId, strComparisonOpTabTypeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.CacheModeId, objvPrjTab_SimV2Cond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.TabStateId) == true)
{
string strComparisonOpTabStateId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.TabStateId, objvPrjTab_SimV2Cond.TabStateId, strComparisonOpTabStateId);
}
if (objvPrjTab_SimV2Cond.IsUpdated(convPrjTab_SimV2.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvPrjTab_SimV2Cond.dicFldComparisonOp[convPrjTab_SimV2.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTab_SimV2.CmPrjId, objvPrjTab_SimV2Cond.CmPrjId, strComparisonOpCmPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表_SimV2(vPrjTab_SimV2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTab_SimV2WApi
{
private static readonly string mstrApiControllerName = "vPrjTab_SimV2Api";

 public clsvPrjTab_SimV2WApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程表_SimV2]...","0");
List<clsvPrjTab_SimV2EN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TabId";
objDDL.DataTextField="TabName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

//该表下拉框功能不需要生成;

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTab_SimV2EN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTab_SimV2EN objvPrjTab_SimV2EN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjTab_SimV2EN = JsonConvert.DeserializeObject<clsvPrjTab_SimV2EN>(strJson);
return objvPrjTab_SimV2EN;
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
public static clsvPrjTab_SimV2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTab_SimV2EN objvPrjTab_SimV2EN;
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
objvPrjTab_SimV2EN = JsonConvert.DeserializeObject<clsvPrjTab_SimV2EN>(strJson);
return objvPrjTab_SimV2EN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTab_SimV2EN GetObjByTabIdCache(string strTabId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel =
from objvPrjTab_SimV2EN in arrvPrjTab_SimV2ObjLstCache
where objvPrjTab_SimV2EN.TabId == strTabId 
select objvPrjTab_SimV2EN;
if (arrvPrjTab_SimV2ObjLst_Sel.Count() == 0)
{
   clsvPrjTab_SimV2EN obj = clsvPrjTab_SimV2WApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTab_SimV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel1 =
from objvPrjTab_SimV2EN in arrvPrjTab_SimV2ObjLstCache
where objvPrjTab_SimV2EN.TabId == strTabId 
select objvPrjTab_SimV2EN;
List <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel = new List<clsvPrjTab_SimV2EN>();
foreach (clsvPrjTab_SimV2EN obj in arrvPrjTab_SimV2ObjLst_Sel1)
{
arrvPrjTab_SimV2ObjLst_Sel.Add(obj);
}
if (arrvPrjTab_SimV2ObjLst_Sel.Count > 0)
{
return arrvPrjTab_SimV2ObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab_SimV2对象缓存列表中,找不到记录[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab_SimV2BL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//初始化列表缓存
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel1 =
from objvPrjTab_SimV2EN in arrvPrjTab_SimV2ObjLstCache
where objvPrjTab_SimV2EN.TabId == strTabId 
select objvPrjTab_SimV2EN;
List <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel = new List<clsvPrjTab_SimV2EN>();
foreach (clsvPrjTab_SimV2EN obj in arrvPrjTab_SimV2ObjLst_Sel1)
{
arrvPrjTab_SimV2ObjLst_Sel.Add(obj);
}
if (arrvPrjTab_SimV2ObjLst_Sel.Count > 0)
{
return arrvPrjTab_SimV2ObjLst_Sel[0].TabName;
}
string strErrMsgForGetObjById = string.Format("在vPrjTab_SimV2对象缓存列表中,找不到记录的相关名称[TabId = {0}](函数:{1})", strTabId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvPrjTab_SimV2BL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
 /// <param name = "arrTabId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
string strAction = "GetObjLstByTabIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
 /// <param name = "arrTabId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvPrjTab_SimV2EN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLst_Sel =
from objvPrjTab_SimV2EN in arrvPrjTab_SimV2ObjLstCache
where arrTabId.Contains(objvPrjTab_SimV2EN.TabId)
select objvPrjTab_SimV2EN;
return arrvPrjTab_SimV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTab_SimV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTab_SimV2EN>>(strJson);
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
public static bool IsExist(string strTabId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strTabId"] = strTabId
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
 /// <param name = "objvPrjTab_SimV2ENS">源对象</param>
 /// <param name = "objvPrjTab_SimV2ENT">目标对象</param>
 public static void CopyTo(clsvPrjTab_SimV2EN objvPrjTab_SimV2ENS, clsvPrjTab_SimV2EN objvPrjTab_SimV2ENT)
{
try
{
objvPrjTab_SimV2ENT.TabId = objvPrjTab_SimV2ENS.TabId; //表ID
objvPrjTab_SimV2ENT.TabName = objvPrjTab_SimV2ENS.TabName; //表名
objvPrjTab_SimV2ENT.SqlDsTypeId = objvPrjTab_SimV2ENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimV2ENT.FuncModuleAgcId = objvPrjTab_SimV2ENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimV2ENT.TabTypeId = objvPrjTab_SimV2ENS.TabTypeId; //表类型Id
objvPrjTab_SimV2ENT.CacheModeId = objvPrjTab_SimV2ENS.CacheModeId; //缓存方式Id
objvPrjTab_SimV2ENT.TabStateId = objvPrjTab_SimV2ENS.TabStateId; //表状态ID
objvPrjTab_SimV2ENT.CmPrjId = objvPrjTab_SimV2ENS.CmPrjId; //Cm工程Id
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
public static DataTable ToDataTable(List<clsvPrjTab_SimV2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTab_SimV2EN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTab_SimV2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTab_SimV2EN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTab_SimV2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTab_SimV2EN._AttributeName)
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
public static void ReFreshThisCache(string strCmPrjId = "")
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTab_SimV2WApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimV2WApi.ReFreshThisCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
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
public static List<clsvPrjTab_SimV2EN> GetObjLstCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTab_SimV2WApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimV2WApi.GetObjLstCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTab_SimV2EN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTab_SimV2EN._WhereFormat, strCmPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTab_SimV2.CmPrjId, strCmPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTab_SimV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTab_SimV2EN> GetObjLstCacheFromObjLst(string strCmPrjId,List<clsvPrjTab_SimV2EN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTab_SimV2WApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTab_SimV2WApi.GetObjLstCacheFromObjLst)", strCmPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTab_SimV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTab_SimV2EN> arrvPrjTab_SimV2ObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTab_SimV2ObjLstCache = CacheHelper.Get<List<clsvPrjTab_SimV2EN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.CmPrjId == strCmPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTab_SimV2ObjLstCache = CacheHelper.Get<List<clsvPrjTab_SimV2EN>>(strKey);
}
return arrvPrjTab_SimV2ObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTab_SimV2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTab_SimV2.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.TabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTab_SimV2.CmPrjId, Type.GetType("System.String"));
foreach (clsvPrjTab_SimV2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTab_SimV2.TabId] = objInFor[convPrjTab_SimV2.TabId];
objDR[convPrjTab_SimV2.TabName] = objInFor[convPrjTab_SimV2.TabName];
objDR[convPrjTab_SimV2.SqlDsTypeId] = objInFor[convPrjTab_SimV2.SqlDsTypeId];
objDR[convPrjTab_SimV2.FuncModuleAgcId] = objInFor[convPrjTab_SimV2.FuncModuleAgcId];
objDR[convPrjTab_SimV2.TabTypeId] = objInFor[convPrjTab_SimV2.TabTypeId];
objDR[convPrjTab_SimV2.CacheModeId] = objInFor[convPrjTab_SimV2.CacheModeId];
objDR[convPrjTab_SimV2.TabStateId] = objInFor[convPrjTab_SimV2.TabStateId];
objDR[convPrjTab_SimV2.CmPrjId] = objInFor[convPrjTab_SimV2.CmPrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}