
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTypeWApi
 表名:vFunctionType(00050481)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:20
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
public static class  clsvFunctionTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeId(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunctionType.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunctionType.FuncTypeId);
objvFunctionTypeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeId) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeId, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeId] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeName(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convFunctionType.FuncTypeName);
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunctionType.FuncTypeName);
objvFunctionTypeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeENName">函数类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeENName(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeENName, 50, convFunctionType.FuncTypeENName);
objvFunctionTypeEN.FuncTypeENName = strFuncTypeENName; //函数类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeENName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeENName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeENName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeId(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convFunctionType.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionType.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionType.CodeTypeId);
objvFunctionTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeId) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeName">代码类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convFunctionType.CodeTypeName);
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunctionType.CodeTypeName);
objvFunctionTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeSimName">简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeSimName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convFunctionType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convFunctionType.CodeTypeSimName);
objvFunctionTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeSimName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeSimName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeSimName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeENName">代码类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeENName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convFunctionType.CodeTypeENName);
objvFunctionTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeENName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeENName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeENName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetMemo(this clsvFunctionTypeEN objvFunctionTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionType.Memo);
objvFunctionTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.Memo) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.Memo, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.Memo] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTypeEN objvFunctionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeId, objvFunctionTypeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeName, objvFunctionTypeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeENName) == true)
{
string strComparisonOpFuncTypeENName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeENName, objvFunctionTypeCond.FuncTypeENName, strComparisonOpFuncTypeENName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeId, objvFunctionTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeName, objvFunctionTypeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeSimName, objvFunctionTypeCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeENName, objvFunctionTypeCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.Memo) == true)
{
string strComparisonOpMemo = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.Memo, objvFunctionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vFunctionType(v函数类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTypeName_CodeTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvFunctionTypeEN objvFunctionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvFunctionTypeEN == null) return "";
if (objvFunctionTypeEN.FuncTypeId == null || objvFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objvFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// v函数类型(vFunctionType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTypeWApi
{
private static readonly string mstrApiControllerName = "vFunctionTypeApi";

 public clsvFunctionTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTypeEN GetObjByFuncTypeId(string strFuncTypeId)
{
if (strFuncTypeId == "") return null;
string strAction = "GetObjByFuncTypeId";
clsvFunctionTypeEN objvFunctionTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncTypeId"] = strFuncTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunctionTypeEN = JsonConvert.DeserializeObject<clsvFunctionTypeEN>(strJson);
return objvFunctionTypeEN;
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
public static clsvFunctionTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionTypeEN objvFunctionTypeEN;
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
objvFunctionTypeEN = JsonConvert.DeserializeObject<clsvFunctionTypeEN>(strJson);
return objvFunctionTypeEN;
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
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTypeEN GetObjByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrvFunctionTypeObjLst_Sel =
from objvFunctionTypeEN in arrvFunctionTypeObjLstCache
where objvFunctionTypeEN.FuncTypeId == strFuncTypeId 
select objvFunctionTypeEN;
if (arrvFunctionTypeObjLst_Sel.Count() == 0)
{
   clsvFunctionTypeEN obj = clsvFunctionTypeWApi.GetObjByFuncTypeId(strFuncTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunctionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
 /// <param name = "arrFuncTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLstByFuncTypeIdLst(List<string> arrFuncTypeId)
{
 List<clsvFunctionTypeEN> arrObjLst; 
string strAction = "GetObjLstByFuncTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
 /// <param name = "arrFuncTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunctionTypeEN> GetObjLstByFuncTypeIdLstCache(List<string> arrFuncTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrvFunctionTypeObjLst_Sel =
from objvFunctionTypeEN in arrvFunctionTypeObjLstCache
where arrFuncTypeId.Contains(objvFunctionTypeEN.FuncTypeId)
select objvFunctionTypeEN;
return arrvFunctionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
public static List<clsvFunctionTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
public static List<clsvFunctionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
public static List<clsvFunctionTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTypeEN>>(strJson);
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
public static bool IsExist(string strFuncTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncTypeId"] = strFuncTypeId
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
 /// <param name = "objvFunctionTypeENS">源对象</param>
 /// <param name = "objvFunctionTypeENT">目标对象</param>
 public static void CopyTo(clsvFunctionTypeEN objvFunctionTypeENS, clsvFunctionTypeEN objvFunctionTypeENT)
{
try
{
objvFunctionTypeENT.FuncTypeId = objvFunctionTypeENS.FuncTypeId; //函数类型Id
objvFunctionTypeENT.FuncTypeName = objvFunctionTypeENS.FuncTypeName; //函数类型名
objvFunctionTypeENT.FuncTypeENName = objvFunctionTypeENS.FuncTypeENName; //函数类型英文名
objvFunctionTypeENT.CodeTypeId = objvFunctionTypeENS.CodeTypeId; //代码类型Id
objvFunctionTypeENT.CodeTypeName = objvFunctionTypeENS.CodeTypeName; //代码类型名
objvFunctionTypeENT.CodeTypeSimName = objvFunctionTypeENS.CodeTypeSimName; //简称
objvFunctionTypeENT.CodeTypeENName = objvFunctionTypeENS.CodeTypeENName; //代码类型英文名
objvFunctionTypeENT.Memo = objvFunctionTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFunctionTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
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
public static List<clsvFunctionTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunctionTypeEN._CurrTabName;
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunctionTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionType.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.FuncTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.CodeTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionType.Memo, Type.GetType("System.String"));
foreach (clsvFunctionTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionType.FuncTypeId] = objInFor[convFunctionType.FuncTypeId];
objDR[convFunctionType.FuncTypeName] = objInFor[convFunctionType.FuncTypeName];
objDR[convFunctionType.FuncTypeENName] = objInFor[convFunctionType.FuncTypeENName];
objDR[convFunctionType.CodeTypeId] = objInFor[convFunctionType.CodeTypeId];
objDR[convFunctionType.CodeTypeName] = objInFor[convFunctionType.CodeTypeName];
objDR[convFunctionType.CodeTypeSimName] = objInFor[convFunctionType.CodeTypeSimName];
objDR[convFunctionType.CodeTypeENName] = objInFor[convFunctionType.CodeTypeENName];
objDR[convFunctionType.Memo] = objInFor[convFunctionType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}