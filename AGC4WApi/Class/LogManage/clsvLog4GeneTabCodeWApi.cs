
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4GeneTabCodeWApi
 表名:vLog4GeneTabCode(00050282)
 生成代码版本:2021.09.24.1
 生成日期:2021/09/25 14:59:36
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理
 模块英文名:LogManage
 框架-层名:WA_访问层(WA_Access)
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
public static class clsvLog4GeneTabCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetmId(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, long lngmId, string strComparisonOp="")
	{
objvLog4GeneTabCodeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.mId) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.mId, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.mId] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetUserId(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convLog4GeneTabCode.UserId);
objvLog4GeneTabCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.UserId) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.UserId, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.UserId] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetUserName(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convLog4GeneTabCode.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convLog4GeneTabCode.UserName);
objvLog4GeneTabCodeEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.UserName) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.UserName, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.UserName] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetTabId(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convLog4GeneTabCode.TabId);
objvLog4GeneTabCodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.TabId) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.TabId, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.TabId] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetGcPathId(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strGcPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGcPathId, 8, convLog4GeneTabCode.GcPathId);
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, convLog4GeneTabCode.GcPathId);
objvLog4GeneTabCodeEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.GcPathId) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.GcPathId, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.GcPathId] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetGeneCodeDate(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convLog4GeneTabCode.GeneCodeDate);
objvLog4GeneTabCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.GeneCodeDate) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.GeneCodeDate, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.GeneCodeDate] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetIsNeedGene(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objvLog4GeneTabCodeEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.IsNeedGene) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.IsNeedGene, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.IsNeedGene] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetVersionGeneCode(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, convLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convLog4GeneTabCode.VersionGeneCode);
objvLog4GeneTabCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.VersionGeneCode) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.VersionGeneCode, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.VersionGeneCode] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetApplicationTypeId(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objvLog4GeneTabCodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.ApplicationTypeId) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.ApplicationTypeId, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.ApplicationTypeId] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvLog4GeneTabCodeEN SetMemo(this clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convLog4GeneTabCode.Memo);
objvLog4GeneTabCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(convLog4GeneTabCode.Memo) == false)
{
objvLog4GeneTabCodeEN.dicFldComparisonOp.Add(convLog4GeneTabCode.Memo, strComparisonOp);
}
else
{
objvLog4GeneTabCodeEN.dicFldComparisonOp[convLog4GeneTabCode.Memo] = strComparisonOp;
}
}
return objvLog4GeneTabCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvLog4GeneTabCodeEN objvLog4GeneTabCode_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.mId) == true)
{
string strComparisonOp_mId = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GeneTabCode.mId, objvLog4GeneTabCode_Cond.mId, strComparisonOp_mId);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.UserId) == true)
{
string strComparisonOp_UserId = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.UserId, objvLog4GeneTabCode_Cond.UserId, strComparisonOp_UserId);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.UserName) == true)
{
string strComparisonOp_UserName = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.UserName, objvLog4GeneTabCode_Cond.UserName, strComparisonOp_UserName);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.TabId) == true)
{
string strComparisonOp_TabId = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.TabId, objvLog4GeneTabCode_Cond.TabId, strComparisonOp_TabId);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.GcPathId) == true)
{
string strComparisonOp_GcPathId = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.GcPathId, objvLog4GeneTabCode_Cond.GcPathId, strComparisonOp_GcPathId);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.GeneCodeDate) == true)
{
string strComparisonOp_GeneCodeDate = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.GeneCodeDate, objvLog4GeneTabCode_Cond.GeneCodeDate, strComparisonOp_GeneCodeDate);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.IsNeedGene) == true)
{
if (objvLog4GeneTabCode_Cond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", convLog4GeneTabCode.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convLog4GeneTabCode.IsNeedGene);
}
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.VersionGeneCode) == true)
{
string strComparisonOp_VersionGeneCode = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.VersionGeneCode, objvLog4GeneTabCode_Cond.VersionGeneCode, strComparisonOp_VersionGeneCode);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.ApplicationTypeId) == true)
{
string strComparisonOp_ApplicationTypeId = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convLog4GeneTabCode.ApplicationTypeId, objvLog4GeneTabCode_Cond.ApplicationTypeId, strComparisonOp_ApplicationTypeId);
}
if (objvLog4GeneTabCode_Cond.IsUpdated(convLog4GeneTabCode.Memo) == true)
{
string strComparisonOp_Memo = objvLog4GeneTabCode_Cond.dicFldComparisonOp[convLog4GeneTabCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convLog4GeneTabCode.Memo, objvLog4GeneTabCode_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v生成表代码日志(vLog4GeneTabCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvLog4GeneTabCodeWApi
{
private static readonly string mstrApiControllerName = "vLog4GeneTabCodeApi";

 public clsvLog4GeneTabCodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneTabCodeEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneTabCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneTabCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneTabCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvLog4GeneTabCodeEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneTabCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneTabCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneTabCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsvLog4GeneTabCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvLog4GeneTabCodeEN objvLog4GeneTabCodeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvLog4GeneTabCodeEN = JsonConvert.DeserializeObject<clsvLog4GeneTabCodeEN>((string)jobjReturn["returnObj"]);
return objvLog4GeneTabCodeEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvLog4GeneTabCodeEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4GeneTabCodeEN._CurrTabName);
List<clsvLog4GeneTabCodeEN> arrvLog4GeneTabCodeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4GeneTabCodeEN> arrvLog4GeneTabCodeObjLst_Sel =
from objvLog4GeneTabCodeEN in arrvLog4GeneTabCodeObjLst_Cache
where objvLog4GeneTabCodeEN.mId == lngmId
select objvLog4GeneTabCodeEN;
if (arrvLog4GeneTabCodeObjLst_Sel.Count() == 0)
{
   clsvLog4GeneTabCodeEN obj = clsvLog4GeneTabCodeWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvLog4GeneTabCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvLog4GeneTabCodeEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4GeneTabCodeEN._CurrTabName);
List<clsvLog4GeneTabCodeEN> arrvLog4GeneTabCodeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvLog4GeneTabCodeEN> arrvLog4GeneTabCodeObjLst_Sel =
from objvLog4GeneTabCodeEN in arrvLog4GeneTabCodeObjLst_Cache
where arrMId.Contains(objvLog4GeneTabCodeEN.mId)
select objvLog4GeneTabCodeEN;
return arrvLog4GeneTabCodeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvLog4GeneTabCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvLog4GeneTabCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvLog4GeneTabCodeEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvLog4GeneTabCodeEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "objvLog4GeneTabCodeENS">源对象</param>
 /// <param name = "objvLog4GeneTabCodeENT">目标对象</param>
 public static void CopyTo(clsvLog4GeneTabCodeEN objvLog4GeneTabCodeENS, clsvLog4GeneTabCodeEN objvLog4GeneTabCodeENT)
{
try
{
objvLog4GeneTabCodeENT.mId = objvLog4GeneTabCodeENS.mId; //mId
objvLog4GeneTabCodeENT.UserId = objvLog4GeneTabCodeENS.UserId; //用户Id
objvLog4GeneTabCodeENT.UserName = objvLog4GeneTabCodeENS.UserName; //用户名
objvLog4GeneTabCodeENT.TabId = objvLog4GeneTabCodeENS.TabId; //表ID
objvLog4GeneTabCodeENT.GcPathId = objvLog4GeneTabCodeENS.GcPathId; //GC路径Id
objvLog4GeneTabCodeENT.GeneCodeDate = objvLog4GeneTabCodeENS.GeneCodeDate; //生成代码日期
objvLog4GeneTabCodeENT.IsNeedGene = objvLog4GeneTabCodeENS.IsNeedGene; //是否需要生成
objvLog4GeneTabCodeENT.VersionGeneCode = objvLog4GeneTabCodeENS.VersionGeneCode; //生成代码版本
objvLog4GeneTabCodeENT.ApplicationTypeId = objvLog4GeneTabCodeENS.ApplicationTypeId; //应用程序类型ID
objvLog4GeneTabCodeENT.Memo = objvLog4GeneTabCodeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvLog4GeneTabCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvLog4GeneTabCodeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvLog4GeneTabCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvLog4GeneTabCodeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvLog4GeneTabCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvLog4GeneTabCodeEN.AttributeName)
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
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvLog4GeneTabCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvLog4GeneTabCodeEN> GetObjLst_Cache()
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvLog4GeneTabCodeEN._CurrTabName);
List<clsvLog4GeneTabCodeEN> arrvLog4GeneTabCodeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvLog4GeneTabCodeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvLog4GeneTabCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convLog4GeneTabCode.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convLog4GeneTabCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.GcPathId, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(convLog4GeneTabCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convLog4GeneTabCode.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convLog4GeneTabCode.Memo, Type.GetType("System.String"));
foreach (clsvLog4GeneTabCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convLog4GeneTabCode.mId] = objInFor[convLog4GeneTabCode.mId];
objDR[convLog4GeneTabCode.UserId] = objInFor[convLog4GeneTabCode.UserId];
objDR[convLog4GeneTabCode.UserName] = objInFor[convLog4GeneTabCode.UserName];
objDR[convLog4GeneTabCode.TabId] = objInFor[convLog4GeneTabCode.TabId];
objDR[convLog4GeneTabCode.GcPathId] = objInFor[convLog4GeneTabCode.GcPathId];
objDR[convLog4GeneTabCode.GeneCodeDate] = objInFor[convLog4GeneTabCode.GeneCodeDate];
objDR[convLog4GeneTabCode.IsNeedGene] = objInFor[convLog4GeneTabCode.IsNeedGene];
objDR[convLog4GeneTabCode.VersionGeneCode] = objInFor[convLog4GeneTabCode.VersionGeneCode];
objDR[convLog4GeneTabCode.ApplicationTypeId] = objInFor[convLog4GeneTabCode.ApplicationTypeId];
objDR[convLog4GeneTabCode.Memo] = objInFor[convLog4GeneTabCode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}