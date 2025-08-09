
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateWApi
 表名:vFunctionTemplate(00050316)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionTemplateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetFunctionTemplateId(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convFunctionTemplate.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convFunctionTemplate.FunctionTemplateId);
objvFunctionTemplateEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.FunctionTemplateId) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.FunctionTemplateId, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.FunctionTemplateId] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateName">函数模板名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetFunctionTemplateName(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strFunctionTemplateName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateName, convFunctionTemplate.FunctionTemplateName);
clsCheckSql.CheckFieldLen(strFunctionTemplateName, 50, convFunctionTemplate.FunctionTemplateName);
objvFunctionTemplateEN.FunctionTemplateName = strFunctionTemplateName; //函数模板名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.FunctionTemplateName) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.FunctionTemplateName, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.FunctionTemplateName] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetProgLangTypeId(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionTemplate.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionTemplate.ProgLangTypeId);
objvFunctionTemplateEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.ProgLangTypeId) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetProgLangTypeName(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionTemplate.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionTemplate.ProgLangTypeName);
objvFunctionTemplateEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.ProgLangTypeName) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetCreateUserId(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionTemplate.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionTemplate.CreateUserId);
objvFunctionTemplateEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.CreateUserId) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.CreateUserId, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.CreateUserId] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetUpdDate(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionTemplate.UpdDate);
objvFunctionTemplateEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.UpdDate) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.UpdDate, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.UpdDate] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetUpdUser(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionTemplate.UpdUser);
objvFunctionTemplateEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.UpdUser) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.UpdUser, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.UpdUser] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetMemo(this clsvFunctionTemplateEN objvFunctionTemplateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionTemplate.Memo);
objvFunctionTemplateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.Memo) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.Memo, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.Memo] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateEN">需要设置字段值的实体对象</param>
 /// <param name = "intFunctionCount">函数数目</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateEN SetFunctionCount(this clsvFunctionTemplateEN objvFunctionTemplateEN, int intFunctionCount, string strComparisonOp="")
	{
objvFunctionTemplateEN.FunctionCount = intFunctionCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateEN.dicFldComparisonOp.ContainsKey(convFunctionTemplate.FunctionCount) == false)
{
objvFunctionTemplateEN.dicFldComparisonOp.Add(convFunctionTemplate.FunctionCount, strComparisonOp);
}
else
{
objvFunctionTemplateEN.dicFldComparisonOp[convFunctionTemplate.FunctionCount] = strComparisonOp;
}
}
return objvFunctionTemplateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTemplateEN objvFunctionTemplateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.FunctionTemplateId, objvFunctionTemplateCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.FunctionTemplateName) == true)
{
string strComparisonOpFunctionTemplateName = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.FunctionTemplateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.FunctionTemplateName, objvFunctionTemplateCond.FunctionTemplateName, strComparisonOpFunctionTemplateName);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.ProgLangTypeId, objvFunctionTemplateCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.ProgLangTypeName, objvFunctionTemplateCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.CreateUserId, objvFunctionTemplateCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.UpdDate, objvFunctionTemplateCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.UpdUser, objvFunctionTemplateCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.Memo) == true)
{
string strComparisonOpMemo = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplate.Memo, objvFunctionTemplateCond.Memo, strComparisonOpMemo);
}
if (objvFunctionTemplateCond.IsUpdated(convFunctionTemplate.FunctionCount) == true)
{
string strComparisonOpFunctionCount = objvFunctionTemplateCond.dicFldComparisonOp[convFunctionTemplate.FunctionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionTemplate.FunctionCount, objvFunctionTemplateCond.FunctionCount, strComparisonOpFunctionCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数模板(vFunctionTemplate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTemplateWApi
{
private static readonly string mstrApiControllerName = "vFunctionTemplateApi";

 public clsvFunctionTemplateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateEN GetObjByFunctionTemplateId(string strFunctionTemplateId)
{
if (strFunctionTemplateId == "") return null;
string strAction = "GetObjByFunctionTemplateId";
clsvFunctionTemplateEN objvFunctionTemplateEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunctionTemplateEN = JsonConvert.DeserializeObject<clsvFunctionTemplateEN>(strJson);
return objvFunctionTemplateEN;
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
public static clsvFunctionTemplateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionTemplateEN objvFunctionTemplateEN;
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
objvFunctionTemplateEN = JsonConvert.DeserializeObject<clsvFunctionTemplateEN>(strJson);
return objvFunctionTemplateEN;
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
 /// <param name = "strFunctionTemplateId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateEN GetObjByFunctionTemplateIdCache(string strFunctionTemplateId)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTemplateEN._CurrTabName);
List<clsvFunctionTemplateEN> arrvFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateEN> arrvFunctionTemplateObjLst_Sel =
from objvFunctionTemplateEN in arrvFunctionTemplateObjLstCache
where objvFunctionTemplateEN.FunctionTemplateId == strFunctionTemplateId 
select objvFunctionTemplateEN;
if (arrvFunctionTemplateObjLst_Sel.Count() == 0)
{
   clsvFunctionTemplateEN obj = clsvFunctionTemplateWApi.GetObjByFunctionTemplateId(strFunctionTemplateId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunctionTemplateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
 /// <param name = "arrFunctionTemplateId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateEN> GetObjLstByFunctionTemplateIdLst(List<string> arrFunctionTemplateId)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
string strAction = "GetObjLstByFunctionTemplateIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionTemplateId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
 /// <param name = "arrFunctionTemplateId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunctionTemplateEN> GetObjLstByFunctionTemplateIdLstCache(List<string> arrFunctionTemplateId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTemplateEN._CurrTabName);
List<clsvFunctionTemplateEN> arrvFunctionTemplateObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateEN> arrvFunctionTemplateObjLst_Sel =
from objvFunctionTemplateEN in arrvFunctionTemplateObjLstCache
where arrFunctionTemplateId.Contains(objvFunctionTemplateEN.FunctionTemplateId)
select objvFunctionTemplateEN;
return arrvFunctionTemplateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
public static List<clsvFunctionTemplateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
public static List<clsvFunctionTemplateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
public static List<clsvFunctionTemplateEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateEN>>(strJson);
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
public static bool IsExist(string strFunctionTemplateId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId
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
 /// <param name = "objvFunctionTemplateENS">源对象</param>
 /// <param name = "objvFunctionTemplateENT">目标对象</param>
 public static void CopyTo(clsvFunctionTemplateEN objvFunctionTemplateENS, clsvFunctionTemplateEN objvFunctionTemplateENT)
{
try
{
objvFunctionTemplateENT.FunctionTemplateId = objvFunctionTemplateENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateENT.FunctionTemplateName = objvFunctionTemplateENS.FunctionTemplateName; //函数模板名
objvFunctionTemplateENT.ProgLangTypeId = objvFunctionTemplateENS.ProgLangTypeId; //编程语言类型Id
objvFunctionTemplateENT.ProgLangTypeName = objvFunctionTemplateENS.ProgLangTypeName; //编程语言类型名
objvFunctionTemplateENT.CreateUserId = objvFunctionTemplateENS.CreateUserId; //建立用户Id
objvFunctionTemplateENT.UpdDate = objvFunctionTemplateENS.UpdDate; //修改日期
objvFunctionTemplateENT.UpdUser = objvFunctionTemplateENS.UpdUser; //修改者
objvFunctionTemplateENT.Memo = objvFunctionTemplateENS.Memo; //说明
objvFunctionTemplateENT.FunctionCount = objvFunctionTemplateENS.FunctionCount; //函数数目
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
public static DataTable ToDataTable(List<clsvFunctionTemplateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionTemplateEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionTemplateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionTemplateEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionTemplateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionTemplateEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFunctionTemplateEN._CurrTabName);
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
public static List<clsvFunctionTemplateEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunctionTemplateEN._CurrTabName;
List<clsvFunctionTemplateEN> arrvFunctionTemplateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunctionTemplateObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionTemplateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionTemplate.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.FunctionTemplateName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplate.FunctionCount, Type.GetType("System.Int32"));
foreach (clsvFunctionTemplateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionTemplate.FunctionTemplateId] = objInFor[convFunctionTemplate.FunctionTemplateId];
objDR[convFunctionTemplate.FunctionTemplateName] = objInFor[convFunctionTemplate.FunctionTemplateName];
objDR[convFunctionTemplate.ProgLangTypeId] = objInFor[convFunctionTemplate.ProgLangTypeId];
objDR[convFunctionTemplate.ProgLangTypeName] = objInFor[convFunctionTemplate.ProgLangTypeName];
objDR[convFunctionTemplate.CreateUserId] = objInFor[convFunctionTemplate.CreateUserId];
objDR[convFunctionTemplate.UpdDate] = objInFor[convFunctionTemplate.UpdDate];
objDR[convFunctionTemplate.UpdUser] = objInFor[convFunctionTemplate.UpdUser];
objDR[convFunctionTemplate.Memo] = objInFor[convFunctionTemplate.Memo];
objDR[convFunctionTemplate.FunctionCount] = objInFor[convFunctionTemplate.FunctionCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}