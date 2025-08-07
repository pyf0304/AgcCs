
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabKeyFldV2WApi
 表名:vPrjTabKeyFldV2(00050612)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:15
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
public static class  clsvPrjTabKeyFldV2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetTabId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabKeyFldV2.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabKeyFldV2.TabId);
objvPrjTabKeyFldV2EN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.TabId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.TabId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.TabId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetFldId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabKeyFldV2.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabKeyFldV2.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabKeyFldV2.FldId);
objvPrjTabKeyFldV2EN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.FldId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.FldId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.FldId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetPrimaryTypeId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabKeyFldV2.PrimaryTypeId);
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabKeyFldV2.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabKeyFldV2.PrimaryTypeId);
objvPrjTabKeyFldV2EN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.PrimaryTypeId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.PrimaryTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldName">关键字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetKeyFldName(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strKeyFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldName, 300, convPrjTabKeyFldV2.KeyFldName);
objvPrjTabKeyFldV2EN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.KeyFldName) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.KeyFldName, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.KeyFldName] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeName">主键类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetPrimaryTypeName(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strPrimaryTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabKeyFldV2.PrimaryTypeName);
objvPrjTabKeyFldV2EN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.PrimaryTypeName) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.PrimaryTypeName, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeName] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetFieldTypeId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabKeyFldV2.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabKeyFldV2.FieldTypeId);
objvPrjTabKeyFldV2EN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.FieldTypeId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetCmPrjId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convPrjTabKeyFldV2.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convPrjTabKeyFldV2.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convPrjTabKeyFldV2.CmPrjId);
objvPrjTabKeyFldV2EN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.CmPrjId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.CmPrjId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.CmPrjId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.TabId, objvPrjTabKeyFldV2Cond.TabId, strComparisonOpTabId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.FldId, objvPrjTabKeyFldV2Cond.FldId, strComparisonOpFldId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.PrimaryTypeId, objvPrjTabKeyFldV2Cond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.KeyFldName, objvPrjTabKeyFldV2Cond.KeyFldName, strComparisonOpKeyFldName);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.PrimaryTypeName, objvPrjTabKeyFldV2Cond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.FieldTypeId, objvPrjTabKeyFldV2Cond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.CmPrjId, objvPrjTabKeyFldV2Cond.CmPrjId, strComparisonOpCmPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPrjTabKeyFldV2(vPrjTabKeyFldV2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabKeyFldV2WApi
{
private static readonly string mstrApiControllerName = "vPrjTabKeyFldV2Api";

 public clsvPrjTabKeyFldV2WApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByTabId(string strTabId)
{
if (strTabId == "") return null;
string strAction = "GetObjByTabId";
clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN;
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
objvPrjTabKeyFldV2EN = JsonConvert.DeserializeObject<clsvPrjTabKeyFldV2EN>(strJson);
return objvPrjTabKeyFldV2EN;
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
public static clsvPrjTabKeyFldV2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN;
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
objvPrjTabKeyFldV2EN = JsonConvert.DeserializeObject<clsvPrjTabKeyFldV2EN>(strJson);
return objvPrjTabKeyFldV2EN;
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
public static clsvPrjTabKeyFldV2EN GetObjByTabIdCache(string strTabId,string strCmPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLst_Sel =
from objvPrjTabKeyFldV2EN in arrvPrjTabKeyFldV2ObjLstCache
where objvPrjTabKeyFldV2EN.TabId == strTabId 
select objvPrjTabKeyFldV2EN;
if (arrvPrjTabKeyFldV2ObjLst_Sel.Count() == 0)
{
   clsvPrjTabKeyFldV2EN obj = clsvPrjTabKeyFldV2WApi.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTabKeyFldV2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByTabIdLst(List<string> arrTabId)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
public static IEnumerable<clsvPrjTabKeyFldV2EN> GetObjLstByTabIdLstCache(List<string> arrTabId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLst_Sel =
from objvPrjTabKeyFldV2EN in arrvPrjTabKeyFldV2ObjLstCache
where arrTabId.Contains(objvPrjTabKeyFldV2EN.TabId)
select objvPrjTabKeyFldV2EN;
return arrvPrjTabKeyFldV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTabKeyFldV2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabKeyFldV2EN>>(strJson);
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
 /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldV2ENT">目标对象</param>
 public static void CopyTo(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENS, clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENT)
{
try
{
objvPrjTabKeyFldV2ENT.TabId = objvPrjTabKeyFldV2ENS.TabId; //表ID
objvPrjTabKeyFldV2ENT.FldId = objvPrjTabKeyFldV2ENS.FldId; //字段Id
objvPrjTabKeyFldV2ENT.PrimaryTypeId = objvPrjTabKeyFldV2ENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldV2ENT.KeyFldName = objvPrjTabKeyFldV2ENS.KeyFldName; //关键字段名
objvPrjTabKeyFldV2ENT.PrimaryTypeName = objvPrjTabKeyFldV2ENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldV2ENT.FieldTypeId = objvPrjTabKeyFldV2ENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldV2ENT.CmPrjId = objvPrjTabKeyFldV2ENS.CmPrjId; //Cm工程Id
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
public static DataTable ToDataTable(List<clsvPrjTabKeyFldV2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTabKeyFldV2EN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTabKeyFldV2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTabKeyFldV2EN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTabKeyFldV2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTabKeyFldV2EN._AttributeName)
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
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTabKeyFldV2WApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldV2WApi.ReFreshThisCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
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
public static List<clsvPrjTabKeyFldV2EN> GetObjLstCache(string strCmPrjId)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTabKeyFldV2WApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldV2WApi.GetObjLstCache)", strCmPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTabKeyFldV2EN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTabKeyFldV2EN._WhereFormat, strCmPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTabKeyFldV2.CmPrjId, strCmPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTabKeyFldV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstCacheFromObjLst(string strCmPrjId,List<clsvPrjTabKeyFldV2EN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空！(In clsvPrjTabKeyFldV2WApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确！(clsvPrjTabKeyFldV2WApi.GetObjLstCacheFromObjLst)", strCmPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTabKeyFldV2ObjLstCache = CacheHelper.Get<List<clsvPrjTabKeyFldV2EN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.CmPrjId == strCmPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTabKeyFldV2ObjLstCache = CacheHelper.Get<List<clsvPrjTabKeyFldV2EN>>(strKey);
}
return arrvPrjTabKeyFldV2ObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTabKeyFldV2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTabKeyFldV2.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.KeyFldName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.PrimaryTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabKeyFldV2.CmPrjId, Type.GetType("System.String"));
foreach (clsvPrjTabKeyFldV2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTabKeyFldV2.TabId] = objInFor[convPrjTabKeyFldV2.TabId];
objDR[convPrjTabKeyFldV2.FldId] = objInFor[convPrjTabKeyFldV2.FldId];
objDR[convPrjTabKeyFldV2.PrimaryTypeId] = objInFor[convPrjTabKeyFldV2.PrimaryTypeId];
objDR[convPrjTabKeyFldV2.KeyFldName] = objInFor[convPrjTabKeyFldV2.KeyFldName];
objDR[convPrjTabKeyFldV2.PrimaryTypeName] = objInFor[convPrjTabKeyFldV2.PrimaryTypeName];
objDR[convPrjTabKeyFldV2.FieldTypeId] = objInFor[convPrjTabKeyFldV2.FieldTypeId];
objDR[convPrjTabKeyFldV2.CmPrjId] = objInFor[convPrjTabKeyFldV2.CmPrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}