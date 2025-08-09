
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4Code_SimWApi
 表名:vFunction4Code_Sim(00050602)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:12
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
public static class  clsvFunction4Code_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Code">函数Id4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncId4Code(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncId4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4Code, 8, convFunction4Code_Sim.FuncId4Code);
clsCheckSql.CheckFieldForeignKey(strFuncId4Code, 8, convFunction4Code_Sim.FuncId4Code);
objvFunction4Code_SimEN.FuncId4Code = strFuncId4Code; //函数Id4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncId4Code) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncId4Code, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncId4Code] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Code">函数名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncName4Code(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName4Code, convFunction4Code_Sim.FuncName4Code);
clsCheckSql.CheckFieldLen(strFuncName4Code, 100, convFunction4Code_Sim.FuncName4Code);
objvFunction4Code_SimEN.FuncName4Code = strFuncName4Code; //函数名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncName4Code) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncName4Code, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncName4Code] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncCHName4Code">函数中文名4Code</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncCHName4Code(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncCHName4Code, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncCHName4Code, 200, convFunction4Code_Sim.FuncCHName4Code);
objvFunction4Code_SimEN.FuncCHName4Code = strFuncCHName4Code; //函数中文名4Code
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncCHName4Code) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncCHName4Code, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncCHName4Code] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncGCTypeId">函数生成代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncGCTypeId(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncGCTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncGCTypeId, 2, convFunction4Code_Sim.FuncGCTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncGCTypeId, 2, convFunction4Code_Sim.FuncGCTypeId);
objvFunction4Code_SimEN.FuncGCTypeId = strFuncGCTypeId; //函数生成代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncGCTypeId) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncGCTypeId, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncGCTypeId] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetApplicationTypeId(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFunction4Code_Sim.ApplicationTypeId);
objvFunction4Code_SimEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.ApplicationTypeId) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.ApplicationTypeId, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.ApplicationTypeId] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncPurposeId">函数用途Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncPurposeId(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncPurposeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncPurposeId, convFunction4Code_Sim.FuncPurposeId);
clsCheckSql.CheckFieldLen(strFuncPurposeId, 2, convFunction4Code_Sim.FuncPurposeId);
clsCheckSql.CheckFieldForeignKey(strFuncPurposeId, 2, convFunction4Code_Sim.FuncPurposeId);
objvFunction4Code_SimEN.FuncPurposeId = strFuncPurposeId; //函数用途Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncPurposeId) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncPurposeId, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncPurposeId] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetFuncTypeId(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunction4Code_Sim.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunction4Code_Sim.FuncTypeId);
objvFunction4Code_SimEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.FuncTypeId) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.FuncTypeId, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.FuncTypeId] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunction4Code_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunction4Code_SimEN SetUsedTimes(this clsvFunction4Code_SimEN objvFunction4Code_SimEN, int intUsedTimes, string strComparisonOp="")
	{
objvFunction4Code_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunction4Code_SimEN.dicFldComparisonOp.ContainsKey(convFunction4Code_Sim.UsedTimes) == false)
{
objvFunction4Code_SimEN.dicFldComparisonOp.Add(convFunction4Code_Sim.UsedTimes, strComparisonOp);
}
else
{
objvFunction4Code_SimEN.dicFldComparisonOp[convFunction4Code_Sim.UsedTimes] = strComparisonOp;
}
}
return objvFunction4Code_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunction4Code_SimEN objvFunction4Code_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncId4Code) == true)
{
string strComparisonOpFuncId4Code = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncId4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncId4Code, objvFunction4Code_SimCond.FuncId4Code, strComparisonOpFuncId4Code);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncName4Code) == true)
{
string strComparisonOpFuncName4Code = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncName4Code, objvFunction4Code_SimCond.FuncName4Code, strComparisonOpFuncName4Code);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncCHName4Code) == true)
{
string strComparisonOpFuncCHName4Code = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncCHName4Code];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncCHName4Code, objvFunction4Code_SimCond.FuncCHName4Code, strComparisonOpFuncCHName4Code);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncGCTypeId) == true)
{
string strComparisonOpFuncGCTypeId = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncGCTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncGCTypeId, objvFunction4Code_SimCond.FuncGCTypeId, strComparisonOpFuncGCTypeId);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code_Sim.ApplicationTypeId, objvFunction4Code_SimCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncPurposeId) == true)
{
string strComparisonOpFuncPurposeId = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncPurposeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncPurposeId, objvFunction4Code_SimCond.FuncPurposeId, strComparisonOpFuncPurposeId);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunction4Code_Sim.FuncTypeId, objvFunction4Code_SimCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunction4Code_SimCond.IsUpdated(convFunction4Code_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvFunction4Code_SimCond.dicFldComparisonOp[convFunction4Code_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convFunction4Code_Sim.UsedTimes, objvFunction4Code_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数4Code_Sim(vFunction4Code_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4Code_SimWApi
{
private static readonly string mstrApiControllerName = "vFunction4Code_SimApi";

 public clsvFunction4Code_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunction4Code_SimEN GetObjByFuncId4Code(string strFuncId4Code)
{
if (strFuncId4Code == "") return null;
string strAction = "GetObjByFuncId4Code";
clsvFunction4Code_SimEN objvFunction4Code_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4Code"] = strFuncId4Code,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunction4Code_SimEN = JsonConvert.DeserializeObject<clsvFunction4Code_SimEN>(strJson);
return objvFunction4Code_SimEN;
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
public static clsvFunction4Code_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunction4Code_SimEN objvFunction4Code_SimEN;
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
objvFunction4Code_SimEN = JsonConvert.DeserializeObject<clsvFunction4Code_SimEN>(strJson);
return objvFunction4Code_SimEN;
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
 /// <param name = "strFuncId4Code">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunction4Code_SimEN GetObjByFuncId4CodeCache(string strFuncId4Code)
{
if (string.IsNullOrEmpty(strFuncId4Code) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4Code_SimEN._CurrTabName);
List<clsvFunction4Code_SimEN> arrvFunction4Code_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4Code_SimEN> arrvFunction4Code_SimObjLst_Sel =
from objvFunction4Code_SimEN in arrvFunction4Code_SimObjLstCache
where objvFunction4Code_SimEN.FuncId4Code == strFuncId4Code 
select objvFunction4Code_SimEN;
if (arrvFunction4Code_SimObjLst_Sel.Count() == 0)
{
   clsvFunction4Code_SimEN obj = clsvFunction4Code_SimWApi.GetObjByFuncId4Code(strFuncId4Code);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunction4Code_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4Code_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
 /// <param name = "arrFuncId4Code">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4Code_SimEN> GetObjLstByFuncId4CodeLst(List<string> arrFuncId4Code)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
string strAction = "GetObjLstByFuncId4CodeLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncId4Code);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
 /// <param name = "arrFuncId4Code">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFunction4Code_SimEN> GetObjLstByFuncId4CodeLstCache(List<string> arrFuncId4Code)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunction4Code_SimEN._CurrTabName);
List<clsvFunction4Code_SimEN> arrvFunction4Code_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvFunction4Code_SimEN> arrvFunction4Code_SimObjLst_Sel =
from objvFunction4Code_SimEN in arrvFunction4Code_SimObjLstCache
where arrFuncId4Code.Contains(objvFunction4Code_SimEN.FuncId4Code)
select objvFunction4Code_SimEN;
return arrvFunction4Code_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunction4Code_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
public static List<clsvFunction4Code_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
public static List<clsvFunction4Code_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
public static List<clsvFunction4Code_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunction4Code_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunction4Code_SimEN>>(strJson);
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
public static bool IsExist(string strFuncId4Code)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncId4Code"] = strFuncId4Code
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
 /// <param name = "objvFunction4Code_SimENS">源对象</param>
 /// <param name = "objvFunction4Code_SimENT">目标对象</param>
 public static void CopyTo(clsvFunction4Code_SimEN objvFunction4Code_SimENS, clsvFunction4Code_SimEN objvFunction4Code_SimENT)
{
try
{
objvFunction4Code_SimENT.FuncId4Code = objvFunction4Code_SimENS.FuncId4Code; //函数Id4Code
objvFunction4Code_SimENT.FuncName4Code = objvFunction4Code_SimENS.FuncName4Code; //函数名4Code
objvFunction4Code_SimENT.FuncCHName4Code = objvFunction4Code_SimENS.FuncCHName4Code; //函数中文名4Code
objvFunction4Code_SimENT.FuncGCTypeId = objvFunction4Code_SimENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4Code_SimENT.ApplicationTypeId = objvFunction4Code_SimENS.ApplicationTypeId; //应用程序类型ID
objvFunction4Code_SimENT.FuncPurposeId = objvFunction4Code_SimENS.FuncPurposeId; //函数用途Id
objvFunction4Code_SimENT.FuncTypeId = objvFunction4Code_SimENS.FuncTypeId; //函数类型Id
objvFunction4Code_SimENT.UsedTimes = objvFunction4Code_SimENS.UsedTimes; //使用次数
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
public static DataTable ToDataTable(List<clsvFunction4Code_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunction4Code_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunction4Code_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunction4Code_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunction4Code_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunction4Code_SimEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunction4Code_SimEN._CurrTabName);
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
public static List<clsvFunction4Code_SimEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunction4Code_SimEN._CurrTabName;
List<clsvFunction4Code_SimEN> arrvFunction4Code_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunction4Code_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunction4Code_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunction4Code_Sim.FuncId4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.FuncName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.FuncCHName4Code, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.FuncGCTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunction4Code_Sim.FuncPurposeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunction4Code_Sim.UsedTimes, Type.GetType("System.Int32"));
foreach (clsvFunction4Code_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunction4Code_Sim.FuncId4Code] = objInFor[convFunction4Code_Sim.FuncId4Code];
objDR[convFunction4Code_Sim.FuncName4Code] = objInFor[convFunction4Code_Sim.FuncName4Code];
objDR[convFunction4Code_Sim.FuncCHName4Code] = objInFor[convFunction4Code_Sim.FuncCHName4Code];
objDR[convFunction4Code_Sim.FuncGCTypeId] = objInFor[convFunction4Code_Sim.FuncGCTypeId];
objDR[convFunction4Code_Sim.ApplicationTypeId] = objInFor[convFunction4Code_Sim.ApplicationTypeId];
objDR[convFunction4Code_Sim.FuncPurposeId] = objInFor[convFunction4Code_Sim.FuncPurposeId];
objDR[convFunction4Code_Sim.FuncTypeId] = objInFor[convFunction4Code_Sim.FuncTypeId];
objDR[convFunction4Code_Sim.UsedTimes] = objInFor[convFunction4Code_Sim.UsedTimes];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}