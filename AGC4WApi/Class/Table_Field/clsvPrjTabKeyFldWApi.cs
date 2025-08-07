
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabKeyFldWApi
 表名:vPrjTabKeyFld(00050286)
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
public static class  clsvPrjTabKeyFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetTabId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabKeyFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabKeyFld.TabId);
objvPrjTabKeyFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.TabId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.TabId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.TabId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetFldId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabKeyFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabKeyFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabKeyFld.FldId);
objvPrjTabKeyFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.FldId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.FldId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.FldId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetFieldTypeId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, convPrjTabKeyFld.FieldTypeId);
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabKeyFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabKeyFld.FieldTypeId);
objvPrjTabKeyFldEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.FieldTypeId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrimaryTypeId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabKeyFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabKeyFld.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabKeyFld.PrimaryTypeId);
objvPrjTabKeyFldEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrimaryTypeId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrimaryTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrimaryTypeName(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabKeyFld.PrimaryTypeName);
objvPrjTabKeyFldEN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrimaryTypeName) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrimaryTypeName, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeName] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldName">关键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetKeyFldName(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strKeyFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldName, 300, convPrjTabKeyFld.KeyFldName);
objvPrjTabKeyFldEN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.KeyFldName) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.KeyFldName, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.KeyFldName] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldEN SetPrjId(this clsvPrjTabKeyFldEN objvPrjTabKeyFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabKeyFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabKeyFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabKeyFld.PrjId);
objvPrjTabKeyFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldEN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFld.PrjId) == false)
{
objvPrjTabKeyFldEN.dicFldComparisonOp.Add(convPrjTabKeyFld.PrjId, strComparisonOp);
}
else
{
objvPrjTabKeyFldEN.dicFldComparisonOp[convPrjTabKeyFld.PrjId] = strComparisonOp;
}
}
return objvPrjTabKeyFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabKeyFldEN objvPrjTabKeyFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.TabId, objvPrjTabKeyFldCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.FldId, objvPrjTabKeyFldCond.FldId, strComparisonOpFldId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.FieldTypeId, objvPrjTabKeyFldCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrimaryTypeId, objvPrjTabKeyFldCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrimaryTypeName, objvPrjTabKeyFldCond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.KeyFldName, objvPrjTabKeyFldCond.KeyFldName, strComparisonOpKeyFldName);
}
if (objvPrjTabKeyFldCond.IsUpdated(convPrjTabKeyFld.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabKeyFldCond.dicFldComparisonOp[convPrjTabKeyFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFld.PrjId, objvPrjTabKeyFldCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPrjTabKeyFld(vPrjTabKeyFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabKeyFldWApi
{
private static readonly string mstrApiControllerName = "vPrjTabKeyFldApi";

 public clsvPrjTabKeyFldWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldEN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTabKeyFldEN objvPrjTabKeyFldEN;
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
objvPrjTabKeyFldEN = JsonConvert.DeserializeObject<clsvPrjTabKeyFldEN>(strJson);
return objvPrjTabKeyFldEN;
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
public static clsvPrjTabKeyFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTabKeyFldEN objvPrjTabKeyFldEN;
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
objvPrjTabKeyFldEN = JsonConvert.DeserializeObject<clsvPrjTabKeyFldEN>(strJson);
return objvPrjTabKeyFldEN;
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
public static clsvPrjTabKeyFldEN GetObjByTabIdCache(string strTabId,string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLst_Sel =
from objvPrjTabKeyFldEN in arrvPrjTabKeyFldObjLstCache
where objvPrjTabKeyFldEN.TabId == strTabId 
select objvPrjTabKeyFldEN;
if (arrvPrjTabKeyFldObjLst_Sel.Count() == 0)
{
   clsvPrjTabKeyFldEN obj = clsvPrjTabKeyFldWApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTabKeyFldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
public static IEnumerable<clsvPrjTabKeyFldEN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLst_Sel =
from objvPrjTabKeyFldEN in arrvPrjTabKeyFldObjLstCache
where arrTabId.Contains(objvPrjTabKeyFldEN.TabId)
select objvPrjTabKeyFldEN;
return arrvPrjTabKeyFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTabKeyFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldEN>>(strJson);
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
 /// <param name = "objvPrjTabKeyFldENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldENT">目标对象</param>
 public static void CopyTo(clsvPrjTabKeyFldEN objvPrjTabKeyFldENS, clsvPrjTabKeyFldEN objvPrjTabKeyFldENT)
{
try
{
objvPrjTabKeyFldENT.TabId = objvPrjTabKeyFldENS.TabId; //表ID
objvPrjTabKeyFldENT.FldId = objvPrjTabKeyFldENS.FldId; //字段Id
objvPrjTabKeyFldENT.FieldTypeId = objvPrjTabKeyFldENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldENT.PrimaryTypeId = objvPrjTabKeyFldENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldENT.PrimaryTypeName = objvPrjTabKeyFldENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldENT.KeyFldName = objvPrjTabKeyFldENS.KeyFldName; //关键字段名
objvPrjTabKeyFldENT.PrjId = objvPrjTabKeyFldENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvPrjTabKeyFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTabKeyFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTabKeyFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTabKeyFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTabKeyFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTabKeyFldEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabKeyFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
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
public static List<clsvPrjTabKeyFldEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabKeyFldWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTabKeyFldEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTabKeyFldEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTabKeyFld.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTabKeyFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvPrjTabKeyFldEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabKeyFldWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldEN._CurrTabName, strPrjId);
List<clsvPrjTabKeyFldEN> arrvPrjTabKeyFldObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTabKeyFldObjLstCache = CacheHelper.Get<List<clsvPrjTabKeyFldEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTabKeyFldObjLstCache = CacheHelper.Get<List<clsvPrjTabKeyFldEN>>(strKey);
}
return arrvPrjTabKeyFldObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTabKeyFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTabKeyFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.KeyFldName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFld.PrjId, Type.GetType("System.String"));
foreach (clsvPrjTabKeyFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTabKeyFld.TabId] = objInFor[convPrjTabKeyFld.TabId];
objDR[convPrjTabKeyFld.FldId] = objInFor[convPrjTabKeyFld.FldId];
objDR[convPrjTabKeyFld.FieldTypeId] = objInFor[convPrjTabKeyFld.FieldTypeId];
objDR[convPrjTabKeyFld.PrimaryTypeId] = objInFor[convPrjTabKeyFld.PrimaryTypeId];
objDR[convPrjTabKeyFld.PrimaryTypeName] = objInFor[convPrjTabKeyFld.PrimaryTypeName];
objDR[convPrjTabKeyFld.KeyFldName] = objInFor[convPrjTabKeyFld.KeyFldName];
objDR[convPrjTabKeyFld.PrjId] = objInFor[convPrjTabKeyFld.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}