
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDict4GCWApi
 表名:vDict4GC(00050353)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:53
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
public static class  clsvDict4GCWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictId">字典Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictId(this clsvDict4GCEN objvDict4GCEN, string strDictId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDictId, 8, convDict4GC.DictId);
clsCheckSql.CheckFieldForeignKey(strDictId, 8, convDict4GC.DictId);
objvDict4GCEN.DictId = strDictId; //字典Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictId) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictId, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictId] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictValue">字典值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictValue(this clsvDict4GCEN objvDict4GCEN, string strDictValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictValue, convDict4GC.DictValue);
clsCheckSql.CheckFieldLen(strDictValue, 500, convDict4GC.DictValue);
objvDict4GCEN.DictValue = strDictValue; //字典值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictValue) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictValue, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictValue] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictTypeId">字典类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictTypeId(this clsvDict4GCEN objvDict4GCEN, string strDictTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDictTypeId, 4, convDict4GC.DictTypeId);
clsCheckSql.CheckFieldForeignKey(strDictTypeId, 4, convDict4GC.DictTypeId);
objvDict4GCEN.DictTypeId = strDictTypeId; //字典类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictTypeId) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictTypeId, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictTypeId] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictTypeName">字典类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictTypeName(this clsvDict4GCEN objvDict4GCEN, string strDictTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictTypeName, convDict4GC.DictTypeName);
clsCheckSql.CheckFieldLen(strDictTypeName, 50, convDict4GC.DictTypeName);
objvDict4GCEN.DictTypeName = strDictTypeName; //字典类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictTypeName) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictTypeName, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictTypeName] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictKey1">字典关键字1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictKey1(this clsvDict4GCEN objvDict4GCEN, string strDictKey1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey1, convDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(strDictKey1, 50, convDict4GC.DictKey1);
objvDict4GCEN.DictKey1 = strDictKey1; //字典关键字1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictKey1) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictKey1, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictKey1] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictKey2">字典关键字2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictKey2(this clsvDict4GCEN objvDict4GCEN, string strDictKey2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey2, convDict4GC.DictKey2);
clsCheckSql.CheckFieldLen(strDictKey2, 50, convDict4GC.DictKey2);
objvDict4GCEN.DictKey2 = strDictKey2; //字典关键字2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictKey2) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictKey2, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictKey2] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetUpdDate(this clsvDict4GCEN objvDict4GCEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDict4GC.UpdDate);
objvDict4GCEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.UpdDate) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.UpdDate, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.UpdDate] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetUpdUser(this clsvDict4GCEN objvDict4GCEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDict4GC.UpdUser);
objvDict4GCEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.UpdUser) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.UpdUser, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.UpdUser] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetMemo(this clsvDict4GCEN objvDict4GCEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDict4GC.Memo);
objvDict4GCEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.Memo) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.Memo, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.Memo] = strComparisonOp;
}
}
return objvDict4GCEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDict4GCEN objvDict4GCCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDict4GCCond.IsUpdated(convDict4GC.DictId) == true)
{
string strComparisonOpDictId = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictId, objvDict4GCCond.DictId, strComparisonOpDictId);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictValue) == true)
{
string strComparisonOpDictValue = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictValue, objvDict4GCCond.DictValue, strComparisonOpDictValue);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictTypeId) == true)
{
string strComparisonOpDictTypeId = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictTypeId, objvDict4GCCond.DictTypeId, strComparisonOpDictTypeId);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictTypeName) == true)
{
string strComparisonOpDictTypeName = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictTypeName, objvDict4GCCond.DictTypeName, strComparisonOpDictTypeName);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictKey1) == true)
{
string strComparisonOpDictKey1 = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictKey1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictKey1, objvDict4GCCond.DictKey1, strComparisonOpDictKey1);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictKey2) == true)
{
string strComparisonOpDictKey2 = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictKey2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictKey2, objvDict4GCCond.DictKey2, strComparisonOpDictKey2);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDict4GCCond.dicFldComparisonOp[convDict4GC.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.UpdDate, objvDict4GCCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDict4GCCond.dicFldComparisonOp[convDict4GC.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.UpdUser, objvDict4GCCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.Memo) == true)
{
string strComparisonOpMemo = objvDict4GCCond.dicFldComparisonOp[convDict4GC.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.Memo, objvDict4GCCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v生成代码字典(vDict4GC)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDict4GCWApi
{
private static readonly string mstrApiControllerName = "vDict4GCApi";

 public clsvDict4GCWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDict4GCEN GetObjByDictId(string strDictId)
{
if (strDictId == "") return null;
string strAction = "GetObjByDictId";
clsvDict4GCEN objvDict4GCEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDictId"] = strDictId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDict4GCEN = JsonConvert.DeserializeObject<clsvDict4GCEN>(strJson);
return objvDict4GCEN;
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
public static clsvDict4GCEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDict4GCEN objvDict4GCEN;
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
objvDict4GCEN = JsonConvert.DeserializeObject<clsvDict4GCEN>(strJson);
return objvDict4GCEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetObjLst(string strWhereCond)
{
 List<clsvDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
 /// <param name = "arrDictId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetObjLstByDictIdLst(List<string> arrDictId)
{
 List<clsvDict4GCEN> arrObjLst; 
string strAction = "GetObjLstByDictIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDictId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
public static List<clsvDict4GCEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
public static List<clsvDict4GCEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
public static List<clsvDict4GCEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDict4GCEN>>(strJson);
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
public static bool IsExist(string strDictId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDictId"] = strDictId
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
 /// <param name = "objvDict4GCENS">源对象</param>
 /// <param name = "objvDict4GCENT">目标对象</param>
 public static void CopyTo(clsvDict4GCEN objvDict4GCENS, clsvDict4GCEN objvDict4GCENT)
{
try
{
objvDict4GCENT.DictId = objvDict4GCENS.DictId; //字典Id
objvDict4GCENT.DictValue = objvDict4GCENS.DictValue; //字典值
objvDict4GCENT.DictTypeId = objvDict4GCENS.DictTypeId; //字典类型Id
objvDict4GCENT.DictTypeName = objvDict4GCENS.DictTypeName; //字典类型名
objvDict4GCENT.DictKey1 = objvDict4GCENS.DictKey1; //字典关键字1
objvDict4GCENT.DictKey2 = objvDict4GCENS.DictKey2; //字典关键字2
objvDict4GCENT.UpdDate = objvDict4GCENS.UpdDate; //修改日期
objvDict4GCENT.UpdUser = objvDict4GCENS.UpdUser; //修改者
objvDict4GCENT.Memo = objvDict4GCENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvDict4GCEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDict4GCEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDict4GCEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDict4GCEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDict4GCEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDict4GCEN._AttributeName)
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
string strKey = string.Format("{0}", clsvDict4GCEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDict4GCEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDict4GC.DictId, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.DictValue, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.DictTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.DictTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.DictKey1, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.DictKey2, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDict4GC.Memo, Type.GetType("System.String"));
foreach (clsvDict4GCEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDict4GC.DictId] = objInFor[convDict4GC.DictId];
objDR[convDict4GC.DictValue] = objInFor[convDict4GC.DictValue];
objDR[convDict4GC.DictTypeId] = objInFor[convDict4GC.DictTypeId];
objDR[convDict4GC.DictTypeName] = objInFor[convDict4GC.DictTypeName];
objDR[convDict4GC.DictKey1] = objInFor[convDict4GC.DictKey1];
objDR[convDict4GC.DictKey2] = objInFor[convDict4GC.DictKey2];
objDR[convDict4GC.UpdDate] = objInFor[convDict4GC.UpdDate];
objDR[convDict4GC.UpdUser] = objInFor[convDict4GC.UpdUser];
objDR[convDict4GC.Memo] = objInFor[convDict4GC.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}