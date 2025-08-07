
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewStyleWApi
 表名:vViewStyle(00050292)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:51:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsvViewStyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewStyleEN SetViewId(this clsvViewStyleEN objvViewStyleEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, convViewStyle.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, convViewStyle.ViewId);
objvViewStyleEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewStyleEN.dicFldComparisonOp.ContainsKey(convViewStyle.ViewId) == false)
{
objvViewStyleEN.dicFldComparisonOp.Add(convViewStyle.ViewId, strComparisonOp);
}
else
{
objvViewStyleEN.dicFldComparisonOp[convViewStyle.ViewId] = strComparisonOp;
}
}
return objvViewStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleId">标题类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewStyleEN SetTitleStyleId(this clsvViewStyleEN objvViewStyleEN, string strTitleStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTitleStyleId, convViewStyle.TitleStyleId);
clsCheckSql.CheckFieldLen(strTitleStyleId, 8, convViewStyle.TitleStyleId);
objvViewStyleEN.TitleStyleId = strTitleStyleId; //标题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewStyleEN.dicFldComparisonOp.ContainsKey(convViewStyle.TitleStyleId) == false)
{
objvViewStyleEN.dicFldComparisonOp.Add(convViewStyle.TitleStyleId, strComparisonOp);
}
else
{
objvViewStyleEN.dicFldComparisonOp[convViewStyle.TitleStyleId] = strComparisonOp;
}
}
return objvViewStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strTitleStyleName">标题类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewStyleEN SetTitleStyleName(this clsvViewStyleEN objvViewStyleEN, string strTitleStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleStyleName, 20, convViewStyle.TitleStyleName);
objvViewStyleEN.TitleStyleName = strTitleStyleName; //标题类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewStyleEN.dicFldComparisonOp.ContainsKey(convViewStyle.TitleStyleName) == false)
{
objvViewStyleEN.dicFldComparisonOp.Add(convViewStyle.TitleStyleName, strComparisonOp);
}
else
{
objvViewStyleEN.dicFldComparisonOp[convViewStyle.TitleStyleName] = strComparisonOp;
}
}
return objvViewStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleId">DG模式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewStyleEN SetDgStyleId(this clsvViewStyleEN objvViewStyleEN, string strDgStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDgStyleId, convViewStyle.DgStyleId);
clsCheckSql.CheckFieldLen(strDgStyleId, 4, convViewStyle.DgStyleId);
objvViewStyleEN.DgStyleId = strDgStyleId; //DG模式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewStyleEN.dicFldComparisonOp.ContainsKey(convViewStyle.DgStyleId) == false)
{
objvViewStyleEN.dicFldComparisonOp.Add(convViewStyle.DgStyleId, strComparisonOp);
}
else
{
objvViewStyleEN.dicFldComparisonOp[convViewStyle.DgStyleId] = strComparisonOp;
}
}
return objvViewStyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewStyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgStyleName">DG模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvViewStyleEN SetDgStyleName(this clsvViewStyleEN objvViewStyleEN, string strDgStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgStyleName, 30, convViewStyle.DgStyleName);
objvViewStyleEN.DgStyleName = strDgStyleName; //DG模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewStyleEN.dicFldComparisonOp.ContainsKey(convViewStyle.DgStyleName) == false)
{
objvViewStyleEN.dicFldComparisonOp.Add(convViewStyle.DgStyleName, strComparisonOp);
}
else
{
objvViewStyleEN.dicFldComparisonOp[convViewStyle.DgStyleName] = strComparisonOp;
}
}
return objvViewStyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewStyleEN objvViewStyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewStyleCond.IsUpdated(convViewStyle.ViewId) == true)
{
string strComparisonOpViewId = objvViewStyleCond.dicFldComparisonOp[convViewStyle.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewStyle.ViewId, objvViewStyleCond.ViewId, strComparisonOpViewId);
}
if (objvViewStyleCond.IsUpdated(convViewStyle.TitleStyleId) == true)
{
string strComparisonOpTitleStyleId = objvViewStyleCond.dicFldComparisonOp[convViewStyle.TitleStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewStyle.TitleStyleId, objvViewStyleCond.TitleStyleId, strComparisonOpTitleStyleId);
}
if (objvViewStyleCond.IsUpdated(convViewStyle.TitleStyleName) == true)
{
string strComparisonOpTitleStyleName = objvViewStyleCond.dicFldComparisonOp[convViewStyle.TitleStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewStyle.TitleStyleName, objvViewStyleCond.TitleStyleName, strComparisonOpTitleStyleName);
}
if (objvViewStyleCond.IsUpdated(convViewStyle.DgStyleId) == true)
{
string strComparisonOpDgStyleId = objvViewStyleCond.dicFldComparisonOp[convViewStyle.DgStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewStyle.DgStyleId, objvViewStyleCond.DgStyleId, strComparisonOpDgStyleId);
}
if (objvViewStyleCond.IsUpdated(convViewStyle.DgStyleName) == true)
{
string strComparisonOpDgStyleName = objvViewStyleCond.dicFldComparisonOp[convViewStyle.DgStyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewStyle.DgStyleName, objvViewStyleCond.DgStyleName, strComparisonOpDgStyleName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v界面模式(vViewStyle)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewStyleWApi
{
private static readonly string mstrApiControllerName = "vViewStyleApi";

 public clsvViewStyleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewStyleEN GetObjByViewId(string strViewId)
{
if (strViewId == "") return null;
string strAction = "GetObjByViewId";
clsvViewStyleEN objvViewStyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvViewStyleEN = JsonConvert.DeserializeObject<clsvViewStyleEN>(strJson);
return objvViewStyleEN;
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
public static clsvViewStyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvViewStyleEN objvViewStyleEN;
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
objvViewStyleEN = JsonConvert.DeserializeObject<clsvViewStyleEN>(strJson);
return objvViewStyleEN;
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
 /// <param name = "strViewId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewStyleEN GetObjByViewIdCache(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewStyleEN._CurrTabName);
List<clsvViewStyleEN> arrvViewStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvViewStyleEN> arrvViewStyleObjLst_Sel =
from objvViewStyleEN in arrvViewStyleObjLstCache
where objvViewStyleEN.ViewId == strViewId 
select objvViewStyleEN;
if (arrvViewStyleObjLst_Sel.Count() == 0)
{
   clsvViewStyleEN obj = clsvViewStyleWApi.GetObjByViewId(strViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewStyleObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewStyleEN> GetObjLst(string strWhereCond)
{
 List<clsvViewStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
 /// <param name = "arrViewId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewStyleEN> GetObjLstByViewIdLst(List<string> arrViewId)
{
 List<clsvViewStyleEN> arrObjLst; 
string strAction = "GetObjLstByViewIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
 /// <param name = "arrViewId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvViewStyleEN> GetObjLstByViewIdLstCache(List<string> arrViewId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewStyleEN._CurrTabName);
List<clsvViewStyleEN> arrvViewStyleObjLstCache = GetObjLstCache();
IEnumerable <clsvViewStyleEN> arrvViewStyleObjLst_Sel =
from objvViewStyleEN in arrvViewStyleObjLstCache
where arrViewId.Contains(objvViewStyleEN.ViewId)
select objvViewStyleEN;
return arrvViewStyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewStyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
public static List<clsvViewStyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
public static List<clsvViewStyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
public static List<clsvViewStyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvViewStyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewStyleEN>>(strJson);
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
public static bool IsExist(string strViewId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewId"] = strViewId
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
 /// <param name = "objvViewStyleENS">源对象</param>
 /// <param name = "objvViewStyleENT">目标对象</param>
 public static void CopyTo(clsvViewStyleEN objvViewStyleENS, clsvViewStyleEN objvViewStyleENT)
{
try
{
objvViewStyleENT.ViewId = objvViewStyleENS.ViewId; //界面Id
objvViewStyleENT.TitleStyleId = objvViewStyleENS.TitleStyleId; //标题类型Id
objvViewStyleENT.TitleStyleName = objvViewStyleENS.TitleStyleName; //标题类型名
objvViewStyleENT.DgStyleId = objvViewStyleENS.DgStyleId; //DG模式ID
objvViewStyleENT.DgStyleName = objvViewStyleENS.DgStyleName; //DG模式名
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
public static DataTable ToDataTable(List<clsvViewStyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewStyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewStyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewStyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewStyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewStyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsvViewStyleEN._CurrTabName);
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
public static List<clsvViewStyleEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvViewStyleEN._CurrTabName;
List<clsvViewStyleEN> arrvViewStyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvViewStyleObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewStyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewStyle.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(convViewStyle.TitleStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewStyle.TitleStyleName, Type.GetType("System.String"));
objDT.Columns.Add(convViewStyle.DgStyleId, Type.GetType("System.String"));
objDT.Columns.Add(convViewStyle.DgStyleName, Type.GetType("System.String"));
foreach (clsvViewStyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewStyle.ViewId] = objInFor[convViewStyle.ViewId];
objDR[convViewStyle.TitleStyleId] = objInFor[convViewStyle.TitleStyleId];
objDR[convViewStyle.TitleStyleName] = objInFor[convViewStyle.TitleStyleName];
objDR[convViewStyle.DgStyleId] = objInFor[convViewStyle.DgStyleId];
objDR[convViewStyle.DgStyleName] = objInFor[convViewStyle.DgStyleName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}