
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRela_SimWApi
 表名:vFunctionTemplateRela_Sim(00050604)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:13
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
public static class  clsvFunctionTemplateRela_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionTemplateId">函数模板Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetFunctionTemplateId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, convFunctionTemplateRela_Sim.FunctionTemplateId);
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, convFunctionTemplateRela_Sim.FunctionTemplateId);
objvFunctionTemplateRela_SimEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.FunctionTemplateId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.FunctionTemplateId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.FunctionTemplateId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetFuncId4GC(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionTemplateRela_Sim.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionTemplateRela_Sim.FuncId4GC);
objvFunctionTemplateRela_SimEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.FuncId4GC) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetCodeTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionTemplateRela_Sim.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionTemplateRela_Sim.CodeTypeId);
objvFunctionTemplateRela_SimEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.CodeTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeId">区域类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetRegionTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convFunctionTemplateRela_Sim.RegionTypeId);
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convFunctionTemplateRela_Sim.RegionTypeId);
objvFunctionTemplateRela_SimEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.RegionTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.RegionTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.RegionTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlDsTypeId">数据源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetSqlDsTypeId(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, string strSqlDsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, convFunctionTemplateRela_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, convFunctionTemplateRela_Sim.SqlDsTypeId);
objvFunctionTemplateRela_SimEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.SqlDsTypeId) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.SqlDsTypeId, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.SqlDsTypeId] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneCode">是否生成代码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTemplateRela_SimEN SetIsGeneCode(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objvFunctionTemplateRela_SimEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTemplateRela_SimEN.dicFldComparisonOp.ContainsKey(convFunctionTemplateRela_Sim.IsGeneCode) == false)
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp.Add(convFunctionTemplateRela_Sim.IsGeneCode, strComparisonOp);
}
else
{
objvFunctionTemplateRela_SimEN.dicFldComparisonOp[convFunctionTemplateRela_Sim.IsGeneCode] = strComparisonOp;
}
}
return objvFunctionTemplateRela_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.FunctionTemplateId, objvFunctionTemplateRela_SimCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.FuncId4GC, objvFunctionTemplateRela_SimCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.CodeTypeId, objvFunctionTemplateRela_SimCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.RegionTypeId, objvFunctionTemplateRela_SimCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objvFunctionTemplateRela_SimCond.dicFldComparisonOp[convFunctionTemplateRela_Sim.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionTemplateRela_Sim.SqlDsTypeId, objvFunctionTemplateRela_SimCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objvFunctionTemplateRela_SimCond.IsUpdated(convFunctionTemplateRela_Sim.IsGeneCode) == true)
{
if (objvFunctionTemplateRela_SimCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFunctionTemplateRela_Sim.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFunctionTemplateRela_Sim.IsGeneCode);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数模板关系_Sim(vFunctionTemplateRela_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTemplateRela_SimWApi
{
private static readonly string mstrApiControllerName = "vFunctionTemplateRela_SimApi";

 public clsvFunctionTemplateRela_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTemplateRela_SimEN GetObjByKeyLst(string strFunctionTemplateId,string strFuncId4GC)
{
if (strFunctionTemplateId == "") return null;
if (strFuncId4GC == "") return null;
string strAction = "GetObjByKeyLst";
clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId,
["strFuncId4GC"] = strFuncId4GC,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunctionTemplateRela_SimEN = JsonConvert.DeserializeObject<clsvFunctionTemplateRela_SimEN>(strJson);
return objvFunctionTemplateRela_SimEN;
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
public static clsvFunctionTemplateRela_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN;
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
objvFunctionTemplateRela_SimEN = JsonConvert.DeserializeObject<clsvFunctionTemplateRela_SimEN>(strJson);
return objvFunctionTemplateRela_SimEN;
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
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTemplateRela_SimEN GetObjByKeyLstCache(string strFunctionTemplateId,string strFuncId4GC)
{
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return null;
if (string.IsNullOrEmpty(strFunctionTemplateId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLst_Sel =
from objvFunctionTemplateRela_SimEN in arrvFunctionTemplateRela_SimObjLstCache
where objvFunctionTemplateRela_SimEN.FunctionTemplateId == strFunctionTemplateId 
 && objvFunctionTemplateRela_SimEN.FuncId4GC == strFuncId4GC 
select objvFunctionTemplateRela_SimEN;
if (arrvFunctionTemplateRela_SimObjLst_Sel.Count() == 0)
{
   clsvFunctionTemplateRela_SimEN obj = clsvFunctionTemplateRela_SimWApi.GetObjByKeyLst(strFunctionTemplateId,strFuncId4GC);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunctionTemplateRela_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByKeyLsts(List<string> arrFunctionTemplateId)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
string strAction = "GetObjLstByKeyLsts";
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunctionTemplateRela_SimEN> GetObjLstByKeyLstsCache(List<string> arrFunctionTemplateId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLst_Sel =
from objvFunctionTemplateRela_SimEN in arrvFunctionTemplateRela_SimObjLstCache
where arrFunctionTemplateId.Contains(objvFunctionTemplateRela_SimEN.FunctionTemplateId)
select objvFunctionTemplateRela_SimEN;
return arrvFunctionTemplateRela_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTemplateRela_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionTemplateRela_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionTemplateRela_SimEN>>(strJson);
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
public static bool IsExist(string strFunctionTemplateId,string strFuncId4GC)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionTemplateId"] = strFunctionTemplateId,
["strFuncId4GC"] = strFuncId4GC,
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
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <param name = "objvFunctionTemplateRela_SimENT">目标对象</param>
 public static void CopyTo(clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENS, clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENT)
{
try
{
objvFunctionTemplateRela_SimENT.FunctionTemplateId = objvFunctionTemplateRela_SimENS.FunctionTemplateId; //函数模板Id
objvFunctionTemplateRela_SimENT.FuncId4GC = objvFunctionTemplateRela_SimENS.FuncId4GC; //函数ID
objvFunctionTemplateRela_SimENT.CodeTypeId = objvFunctionTemplateRela_SimENS.CodeTypeId; //代码类型Id
objvFunctionTemplateRela_SimENT.RegionTypeId = objvFunctionTemplateRela_SimENS.RegionTypeId; //区域类型Id
objvFunctionTemplateRela_SimENT.SqlDsTypeId = objvFunctionTemplateRela_SimENS.SqlDsTypeId; //数据源类型Id
objvFunctionTemplateRela_SimENT.IsGeneCode = objvFunctionTemplateRela_SimENS.IsGeneCode; //是否生成代码
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
public static DataTable ToDataTable(List<clsvFunctionTemplateRela_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionTemplateRela_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionTemplateRela_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionTemplateRela_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionTemplateRela_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionTemplateRela_SimEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionTemplateRela_SimEN._CurrTabName);
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
public static List<clsvFunctionTemplateRela_SimEN> GetObjLstCache(string strFunctionTemplateId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunctionTemplateRela_SimEN._CurrTabName;
List<clsvFunctionTemplateRela_SimEN> arrvFunctionTemplateRela_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunctionTemplateRela_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionTemplateRela_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionTemplateRela_Sim.FunctionTemplateId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela_Sim.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela_Sim.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela_Sim.RegionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela_Sim.SqlDsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionTemplateRela_Sim.IsGeneCode, Type.GetType("System.Boolean"));
foreach (clsvFunctionTemplateRela_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionTemplateRela_Sim.FunctionTemplateId] = objInFor[convFunctionTemplateRela_Sim.FunctionTemplateId];
objDR[convFunctionTemplateRela_Sim.FuncId4GC] = objInFor[convFunctionTemplateRela_Sim.FuncId4GC];
objDR[convFunctionTemplateRela_Sim.CodeTypeId] = objInFor[convFunctionTemplateRela_Sim.CodeTypeId];
objDR[convFunctionTemplateRela_Sim.RegionTypeId] = objInFor[convFunctionTemplateRela_Sim.RegionTypeId];
objDR[convFunctionTemplateRela_Sim.SqlDsTypeId] = objInFor[convFunctionTemplateRela_Sim.SqlDsTypeId];
objDR[convFunctionTemplateRela_Sim.IsGeneCode] = objInFor[convFunctionTemplateRela_Sim.IsGeneCode];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}