
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFld_SimWApi
 表名:vPrjTabFld_Sim(00050589)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvPrjTabFld_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetmId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, long lngmId, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.mId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.mId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.mId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetTabId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjTabFld_Sim.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabFld_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabFld_Sim.TabId);
objvPrjTabFld_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.TabId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.TabId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.TabId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetPrjId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabFld_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabFld_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabFld_Sim.PrjId);
objvPrjTabFld_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.PrjId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.PrjId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.PrjId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetFldId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabFld_Sim.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabFld_Sim.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabFld_Sim.FldId);
objvPrjTabFld_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.FldId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.FldId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.FldId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intSequenceNumber">顺序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetSequenceNumber(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, int intSequenceNumber, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.SequenceNumber) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.SequenceNumber, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.SequenceNumber] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetFieldTypeId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, convPrjTabFld_Sim.FieldTypeId);
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabFld_Sim.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabFld_Sim.FieldTypeId);
objvPrjTabFld_SimEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.FieldTypeId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForExtendClass">用于扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetIsForExtendClass(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, bool bolIsForExtendClass, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.IsForExtendClass = bolIsForExtendClass; //用于扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.IsForExtendClass) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.IsForExtendClass, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.IsForExtendClass] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabFld_SimEN objvPrjTabFld_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.mId) == true)
{
string strComparisonOpmId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld_Sim.mId, objvPrjTabFld_SimCond.mId, strComparisonOpmId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.TabId, objvPrjTabFld_SimCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.PrjId, objvPrjTabFld_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.FldId, objvPrjTabFld_SimCond.FldId, strComparisonOpFldId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld_Sim.SequenceNumber, objvPrjTabFld_SimCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.FieldTypeId, objvPrjTabFld_SimCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.IsForExtendClass) == true)
{
if (objvPrjTabFld_SimCond.IsForExtendClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld_Sim.IsForExtendClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld_Sim.IsForExtendClass);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// v工程表字段_Sim(vPrjTabFld_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabFld_SimWApi
{
private static readonly string mstrApiControllerName = "vPrjTabFld_SimApi";

 public clsvPrjTabFld_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFld_SimEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvPrjTabFld_SimEN objvPrjTabFld_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjTabFld_SimEN = JsonConvert.DeserializeObject<clsvPrjTabFld_SimEN>(strJson);
return objvPrjTabFld_SimEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
public static clsvPrjTabFld_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjTabFld_SimEN objvPrjTabFld_SimEN;
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
objvPrjTabFld_SimEN = JsonConvert.DeserializeObject<clsvPrjTabFld_SimEN>(strJson);
return objvPrjTabFld_SimEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabFld_SimEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLst_Sel =
from objvPrjTabFld_SimEN in arrvPrjTabFld_SimObjLstCache
where objvPrjTabFld_SimEN.mId == lngmId 
select objvPrjTabFld_SimEN;
if (arrvPrjTabFld_SimObjLst_Sel.Count() == 0)
{
   clsvPrjTabFld_SimEN obj = clsvPrjTabFld_SimWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjTabFld_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvPrjTabFld_SimEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLst_Sel =
from objvPrjTabFld_SimEN in arrvPrjTabFld_SimObjLstCache
where arrMId.Contains(objvPrjTabFld_SimEN.mId)
select objvPrjTabFld_SimEN;
return arrvPrjTabFld_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjTabFld_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjTabFld_SimEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvPrjTabFld_SimENS">源对象</param>
 /// <param name = "objvPrjTabFld_SimENT">目标对象</param>
 public static void CopyTo(clsvPrjTabFld_SimEN objvPrjTabFld_SimENS, clsvPrjTabFld_SimEN objvPrjTabFld_SimENT)
{
try
{
objvPrjTabFld_SimENT.mId = objvPrjTabFld_SimENS.mId; //mId
objvPrjTabFld_SimENT.TabId = objvPrjTabFld_SimENS.TabId; //表ID
objvPrjTabFld_SimENT.PrjId = objvPrjTabFld_SimENS.PrjId; //工程Id
objvPrjTabFld_SimENT.FldId = objvPrjTabFld_SimENS.FldId; //字段Id
objvPrjTabFld_SimENT.SequenceNumber = objvPrjTabFld_SimENS.SequenceNumber; //顺序号
objvPrjTabFld_SimENT.FieldTypeId = objvPrjTabFld_SimENS.FieldTypeId; //字段类型Id
objvPrjTabFld_SimENT.IsForExtendClass = objvPrjTabFld_SimENS.IsForExtendClass; //用于扩展类
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
public static DataTable ToDataTable(List<clsvPrjTabFld_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjTabFld_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjTabFld_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjTabFld_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjTabFld_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjTabFld_SimEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabFld_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabFld_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabFld_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabFld_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvPrjTabFld_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvPrjTabFld_SimEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convPrjTabFld_Sim.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjTabFld_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvPrjTabFld_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvPrjTabFld_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvPrjTabFld_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvPrjTabFld_SimObjLstCache = CacheHelper.Get<List<clsvPrjTabFld_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvPrjTabFld_SimObjLstCache = CacheHelper.Get<List<clsvPrjTabFld_SimEN>>(strKey);
}
return arrvPrjTabFld_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjTabFld_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjTabFld_Sim.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPrjTabFld_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld_Sim.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld_Sim.SequenceNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convPrjTabFld_Sim.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjTabFld_Sim.IsForExtendClass, Type.GetType("System.Boolean"));
foreach (clsvPrjTabFld_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjTabFld_Sim.mId] = objInFor[convPrjTabFld_Sim.mId];
objDR[convPrjTabFld_Sim.TabId] = objInFor[convPrjTabFld_Sim.TabId];
objDR[convPrjTabFld_Sim.PrjId] = objInFor[convPrjTabFld_Sim.PrjId];
objDR[convPrjTabFld_Sim.FldId] = objInFor[convPrjTabFld_Sim.FldId];
objDR[convPrjTabFld_Sim.SequenceNumber] = objInFor[convPrjTabFld_Sim.SequenceNumber];
objDR[convPrjTabFld_Sim.FieldTypeId] = objInFor[convPrjTabFld_Sim.FieldTypeId];
objDR[convPrjTabFld_Sim.IsForExtendClass] = objInFor[convPrjTabFld_Sim.IsForExtendClass];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}