
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGCVariableWApi
 表名:vGCVariable(00050561)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvGCVariableWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarId(this clsvGCVariableEN objvGCVariableEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, convGCVariable.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convGCVariable.VarId);
objvGCVariableEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarName">变量名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarName(this clsvGCVariableEN objvGCVariableEN, string strVarName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarName, 50, convGCVariable.VarName);
objvGCVariableEN.VarName = strVarName; //变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarName) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarName, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarName] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarExpression">变量表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarExpression(this clsvGCVariableEN objvGCVariableEN, string strVarExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarExpression, 150, convGCVariable.VarExpression);
objvGCVariableEN.VarExpression = strVarExpression; //变量表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarExpression) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarExpression, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarExpression] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strInitValue">初始值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetInitValue(this clsvGCVariableEN objvGCVariableEN, string strInitValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInitValue, 1000, convGCVariable.InitValue);
objvGCVariableEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.InitValue) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.InitValue, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.InitValue] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarTypeId">变量类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarTypeId(this clsvGCVariableEN objvGCVariableEN, string strVarTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarTypeId, 4, convGCVariable.VarTypeId);
clsCheckSql.CheckFieldForeignKey(strVarTypeId, 4, convGCVariable.VarTypeId);
objvGCVariableEN.VarTypeId = strVarTypeId; //变量类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarTypeId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarTypeId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarTypeId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarTypeName">变量类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarTypeName(this clsvGCVariableEN objvGCVariableEN, string strVarTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarTypeName, 50, convGCVariable.VarTypeName);
objvGCVariableEN.VarTypeName = strVarTypeName; //变量类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarTypeName) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarTypeName, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarTypeName] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetPrjId(this clsvGCVariableEN objvGCVariableEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convGCVariable.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convGCVariable.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convGCVariable.PrjId);
objvGCVariableEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.PrjId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.PrjId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.PrjId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetUpdDate(this clsvGCVariableEN objvGCVariableEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convGCVariable.UpdDate);
objvGCVariableEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.UpdDate) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.UpdDate, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.UpdDate] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetUpdUser(this clsvGCVariableEN objvGCVariableEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convGCVariable.UpdUser);
objvGCVariableEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.UpdUser) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.UpdUser, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.UpdUser] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetMemo(this clsvGCVariableEN objvGCVariableEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convGCVariable.Memo);
objvGCVariableEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.Memo) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.Memo, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.Memo] = strComparisonOp;
}
}
return objvGCVariableEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvGCVariableEN objvGCVariableCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvGCVariableCond.IsUpdated(convGCVariable.VarId) == true)
{
string strComparisonOpVarId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarId, objvGCVariableCond.VarId, strComparisonOpVarId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarName) == true)
{
string strComparisonOpVarName = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarName, objvGCVariableCond.VarName, strComparisonOpVarName);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarExpression) == true)
{
string strComparisonOpVarExpression = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarExpression, objvGCVariableCond.VarExpression, strComparisonOpVarExpression);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.InitValue) == true)
{
string strComparisonOpInitValue = objvGCVariableCond.dicFldComparisonOp[convGCVariable.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.InitValue, objvGCVariableCond.InitValue, strComparisonOpInitValue);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarTypeId) == true)
{
string strComparisonOpVarTypeId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarTypeId, objvGCVariableCond.VarTypeId, strComparisonOpVarTypeId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarTypeName) == true)
{
string strComparisonOpVarTypeName = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarTypeName, objvGCVariableCond.VarTypeName, strComparisonOpVarTypeName);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.PrjId) == true)
{
string strComparisonOpPrjId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.PrjId, objvGCVariableCond.PrjId, strComparisonOpPrjId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.UpdDate) == true)
{
string strComparisonOpUpdDate = objvGCVariableCond.dicFldComparisonOp[convGCVariable.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.UpdDate, objvGCVariableCond.UpdDate, strComparisonOpUpdDate);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.UpdUser) == true)
{
string strComparisonOpUpdUser = objvGCVariableCond.dicFldComparisonOp[convGCVariable.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.UpdUser, objvGCVariableCond.UpdUser, strComparisonOpUpdUser);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.Memo) == true)
{
string strComparisonOpMemo = objvGCVariableCond.dicFldComparisonOp[convGCVariable.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.Memo, objvGCVariableCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vGCVariable(vGCVariable)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvGCVariableWApi
{
private static readonly string mstrApiControllerName = "vGCVariableApi";

 public clsvGCVariableWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGCVariableEN GetObjByVarId(string strVarId)
{
if (strVarId == "") return null;
string strAction = "GetObjByVarId";
clsvGCVariableEN objvGCVariableEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvGCVariableEN = JsonConvert.DeserializeObject<clsvGCVariableEN>(strJson);
return objvGCVariableEN;
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
public static clsvGCVariableEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvGCVariableEN objvGCVariableEN;
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
objvGCVariableEN = JsonConvert.DeserializeObject<clsvGCVariableEN>(strJson);
return objvGCVariableEN;
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
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGCVariableEN GetObjByVarIdCache(string strVarId,string strPrjId)
{
if (string.IsNullOrEmpty(strVarId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrvGCVariableObjLst_Sel =
from objvGCVariableEN in arrvGCVariableObjLstCache
where objvGCVariableEN.VarId == strVarId 
select objvGCVariableEN;
if (arrvGCVariableObjLst_Sel.Count() == 0)
{
   clsvGCVariableEN obj = clsvGCVariableWApi.GetObjByVarId(strVarId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvGCVariableObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetObjLst(string strWhereCond)
{
 List<clsvGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
 /// <param name = "arrVarId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstByVarIdLst(List<string> arrVarId)
{
 List<clsvGCVariableEN> arrObjLst; 
string strAction = "GetObjLstByVarIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVarId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
 /// <param name = "arrVarId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvGCVariableEN> GetObjLstByVarIdLstCache(List<string> arrVarId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrvGCVariableObjLst_Sel =
from objvGCVariableEN in arrvGCVariableObjLstCache
where arrVarId.Contains(objvGCVariableEN.VarId)
select objvGCVariableEN;
return arrvGCVariableObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
public static List<clsvGCVariableEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
public static List<clsvGCVariableEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
public static List<clsvGCVariableEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvGCVariableEN>>(strJson);
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
public static bool IsExist(string strVarId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId
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
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <param name = "objvGCVariableENT">目标对象</param>
 public static void CopyTo(clsvGCVariableEN objvGCVariableENS, clsvGCVariableEN objvGCVariableENT)
{
try
{
objvGCVariableENT.VarId = objvGCVariableENS.VarId; //变量Id
objvGCVariableENT.VarName = objvGCVariableENS.VarName; //变量名
objvGCVariableENT.VarExpression = objvGCVariableENS.VarExpression; //变量表达式
objvGCVariableENT.InitValue = objvGCVariableENS.InitValue; //初始值
objvGCVariableENT.VarTypeId = objvGCVariableENS.VarTypeId; //变量类型Id
objvGCVariableENT.VarTypeName = objvGCVariableENS.VarTypeName; //变量类型名
objvGCVariableENT.PrjId = objvGCVariableENS.PrjId; //工程Id
objvGCVariableENT.UpdDate = objvGCVariableENS.UpdDate; //修改日期
objvGCVariableENT.UpdUser = objvGCVariableENS.UpdUser; //修改者
objvGCVariableENT.Memo = objvGCVariableENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvGCVariableEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvGCVariableEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvGCVariableEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvGCVariableEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvGCVariableEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvGCVariableEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvGCVariableWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvGCVariableWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
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
public static List<clsvGCVariableEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvGCVariableWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvGCVariableWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvGCVariableEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvGCVariableEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convGCVariable.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvGCVariableObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvGCVariableEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvGCVariableWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvGCVariableWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvGCVariableObjLstCache = CacheHelper.Get<List<clsvGCVariableEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvGCVariableObjLstCache = CacheHelper.Get<List<clsvGCVariableEN>>(strKey);
}
return arrvGCVariableObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvGCVariableEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convGCVariable.VarId, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.VarName, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.VarExpression, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.InitValue, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.VarTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.VarTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convGCVariable.Memo, Type.GetType("System.String"));
foreach (clsvGCVariableEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convGCVariable.VarId] = objInFor[convGCVariable.VarId];
objDR[convGCVariable.VarName] = objInFor[convGCVariable.VarName];
objDR[convGCVariable.VarExpression] = objInFor[convGCVariable.VarExpression];
objDR[convGCVariable.InitValue] = objInFor[convGCVariable.InitValue];
objDR[convGCVariable.VarTypeId] = objInFor[convGCVariable.VarTypeId];
objDR[convGCVariable.VarTypeName] = objInFor[convGCVariable.VarTypeName];
objDR[convGCVariable.PrjId] = objInFor[convGCVariable.PrjId];
objDR[convGCVariable.UpdDate] = objInFor[convGCVariable.UpdDate];
objDR[convGCVariable.UpdUser] = objInFor[convGCVariable.UpdUser];
objDR[convGCVariable.Memo] = objInFor[convGCVariable.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}