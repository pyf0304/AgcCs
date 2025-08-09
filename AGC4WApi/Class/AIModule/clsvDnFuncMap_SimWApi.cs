
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMap_SimWApi
 表名:vDnFuncMap_Sim(00050625)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvDnFuncMap_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetDnFuncMapId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, convDnFuncMap_Sim.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, convDnFuncMap_Sim.DnFuncMapId);
objvDnFuncMap_SimEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.DnFuncMapId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.DnFuncMapId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.DnFuncMapId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetInDataNodeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, long lngInDataNodeId, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.InDataNodeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.InDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.InDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetOutDataNodeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, long lngOutDataNodeId, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.OutDataNodeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.OutDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.OutDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetAssociationMappingId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFuncMap_Sim.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFuncMap_Sim.AssociationMappingId);
objvDnFuncMap_SimEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.AssociationMappingId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.AssociationMappingId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.AssociationMappingId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeId">函数映射模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetFuncMapModeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, convDnFuncMap_Sim.FuncMapModeId);
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, convDnFuncMap_Sim.FuncMapModeId);
objvDnFuncMap_SimEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.FuncMapModeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.FuncMapModeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.FuncMapModeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetTabId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDnFuncMap_Sim.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDnFuncMap_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDnFuncMap_Sim.TabId);
objvDnFuncMap_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.TabId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.TabId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.TabId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetDnFunctionId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFuncMap_Sim.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFuncMap_Sim.DnFunctionId);
objvDnFuncMap_SimEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.DnFunctionId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.DnFunctionId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.DnFunctionId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetPrjId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFuncMap_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFuncMap_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFuncMap_Sim.PrjId);
objvDnFuncMap_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.PrjId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.PrjId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.PrjId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetUsedTimes(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, int intUsedTimes, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.UsedTimes) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.UsedTimes, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.UsedTimes] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnFuncMap_SimEN objvDnFuncMap_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.DnFuncMapId, objvDnFuncMap_SimCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.InDataNodeId, objvDnFuncMap_SimCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.OutDataNodeId, objvDnFuncMap_SimCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.AssociationMappingId, objvDnFuncMap_SimCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.FuncMapModeId, objvDnFuncMap_SimCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.TabId) == true)
{
string strComparisonOpTabId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.TabId, objvDnFuncMap_SimCond.TabId, strComparisonOpTabId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.DnFunctionId, objvDnFuncMap_SimCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.PrjId, objvDnFuncMap_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.UsedTimes, objvDnFuncMap_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDnFuncMap_SimWApi
{
private static readonly string mstrApiControllerName = "vDnFuncMap_SimApi";

 public clsvDnFuncMap_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMap_SimEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
if (strDnFuncMapId == "") return null;
string strAction = "GetObjByDnFuncMapId";
clsvDnFuncMap_SimEN objvDnFuncMap_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFuncMapId"] = strDnFuncMapId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDnFuncMap_SimEN = JsonConvert.DeserializeObject<clsvDnFuncMap_SimEN>(strJson);
return objvDnFuncMap_SimEN;
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
public static clsvDnFuncMap_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDnFuncMap_SimEN objvDnFuncMap_SimEN;
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
objvDnFuncMap_SimEN = JsonConvert.DeserializeObject<clsvDnFuncMap_SimEN>(strJson);
return objvDnFuncMap_SimEN;
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
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMap_SimEN GetObjByDnFuncMapIdCache(string strDnFuncMapId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLst_Sel =
from objvDnFuncMap_SimEN in arrvDnFuncMap_SimObjLstCache
where objvDnFuncMap_SimEN.DnFuncMapId == strDnFuncMapId 
select objvDnFuncMap_SimEN;
if (arrvDnFuncMap_SimObjLst_Sel.Count() == 0)
{
   clsvDnFuncMap_SimEN obj = clsvDnFuncMap_SimWApi.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDnFuncMap_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
 /// <param name = "arrDnFuncMapId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapId)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
string strAction = "GetObjLstByDnFuncMapIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFuncMapId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
 /// <param name = "arrDnFuncMapId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDnFuncMap_SimEN> GetObjLstByDnFuncMapIdLstCache(List<string> arrDnFuncMapId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLst_Sel =
from objvDnFuncMap_SimEN in arrvDnFuncMap_SimObjLstCache
where arrDnFuncMapId.Contains(objvDnFuncMap_SimEN.DnFuncMapId)
select objvDnFuncMap_SimEN;
return arrvDnFuncMap_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDnFuncMap_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMap_SimEN>>(strJson);
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
public static bool IsExist(string strDnFuncMapId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFuncMapId"] = strDnFuncMapId
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
 /// <param name = "objvDnFuncMap_SimENS">源对象</param>
 /// <param name = "objvDnFuncMap_SimENT">目标对象</param>
 public static void CopyTo(clsvDnFuncMap_SimEN objvDnFuncMap_SimENS, clsvDnFuncMap_SimEN objvDnFuncMap_SimENT)
{
try
{
objvDnFuncMap_SimENT.DnFuncMapId = objvDnFuncMap_SimENS.DnFuncMapId; //函数映射Id
objvDnFuncMap_SimENT.InDataNodeId = objvDnFuncMap_SimENS.InDataNodeId; //In数据结点Id
objvDnFuncMap_SimENT.OutDataNodeId = objvDnFuncMap_SimENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMap_SimENT.AssociationMappingId = objvDnFuncMap_SimENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMap_SimENT.FuncMapModeId = objvDnFuncMap_SimENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMap_SimENT.TabId = objvDnFuncMap_SimENS.TabId; //表ID
objvDnFuncMap_SimENT.DnFunctionId = objvDnFuncMap_SimENS.DnFunctionId; //DN函数Id
objvDnFuncMap_SimENT.PrjId = objvDnFuncMap_SimENS.PrjId; //工程Id
objvDnFuncMap_SimENT.UsedTimes = objvDnFuncMap_SimENS.UsedTimes; //使用次数
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
public static DataTable ToDataTable(List<clsvDnFuncMap_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDnFuncMap_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDnFuncMap_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDnFuncMap_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDnFuncMap_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDnFuncMap_SimEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMap_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMap_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMap_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMap_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvDnFuncMap_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvDnFuncMap_SimEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convDnFuncMap_Sim.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDnFuncMap_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvDnFuncMap_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMap_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMap_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvDnFuncMap_SimObjLstCache = CacheHelper.Get<List<clsvDnFuncMap_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvDnFuncMap_SimObjLstCache = CacheHelper.Get<List<clsvDnFuncMap_SimEN>>(strKey);
}
return arrvDnFuncMap_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDnFuncMap_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDnFuncMap_Sim.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.InDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnFuncMap_Sim.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnFuncMap_Sim.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.FuncMapModeId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap_Sim.UsedTimes, Type.GetType("System.Int32"));
foreach (clsvDnFuncMap_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDnFuncMap_Sim.DnFuncMapId] = objInFor[convDnFuncMap_Sim.DnFuncMapId];
objDR[convDnFuncMap_Sim.InDataNodeId] = objInFor[convDnFuncMap_Sim.InDataNodeId];
objDR[convDnFuncMap_Sim.OutDataNodeId] = objInFor[convDnFuncMap_Sim.OutDataNodeId];
objDR[convDnFuncMap_Sim.AssociationMappingId] = objInFor[convDnFuncMap_Sim.AssociationMappingId];
objDR[convDnFuncMap_Sim.FuncMapModeId] = objInFor[convDnFuncMap_Sim.FuncMapModeId];
objDR[convDnFuncMap_Sim.TabId] = objInFor[convDnFuncMap_Sim.TabId];
objDR[convDnFuncMap_Sim.DnFunctionId] = objInFor[convDnFuncMap_Sim.DnFunctionId];
objDR[convDnFuncMap_Sim.PrjId] = objInFor[convDnFuncMap_Sim.PrjId];
objDR[convDnFuncMap_Sim.UsedTimes] = objInFor[convDnFuncMap_Sim.UsedTimes];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}