
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEditRegionWApi
 表名:EditRegion(00050118)
 生成代码版本:2020.07.25.1
 生成日期:2020/07/25 23:30:07
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using AGC.Const;

namespace AGC4WApi
{
public static class clsEditRegionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEditRegionEN SetRegionId(this clsEditRegionEN objEditRegionEN, string lngRegionId, string strComparisonOp="")
	{
objEditRegionEN.RegionId = lngRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionEN.dicFldComparisonOp.ContainsKey(clsEditRegionEN.con_RegionId) == false)
{
objEditRegionEN.dicFldComparisonOp.Add(clsEditRegionEN.con_RegionId, strComparisonOp);
}
else
{
objEditRegionEN.dicFldComparisonOp[clsEditRegionEN.con_RegionId] = strComparisonOp;
}
}
return objEditRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEditRegionEN SetIsUseCtrl(this clsEditRegionEN objEditRegionEN, bool bolIsUseCtrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUseCtrl, clsEditRegionEN.con_IsUseCtrl);
objEditRegionEN.IsUseCtrl = bolIsUseCtrl; //是否使用控件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionEN.dicFldComparisonOp.ContainsKey(clsEditRegionEN.con_IsUseCtrl) == false)
{
objEditRegionEN.dicFldComparisonOp.Add(clsEditRegionEN.con_IsUseCtrl, strComparisonOp);
}
else
{
objEditRegionEN.dicFldComparisonOp[clsEditRegionEN.con_IsUseCtrl] = strComparisonOp;
}
}
return objEditRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEditRegionEN SetPrjId(this clsEditRegionEN objEditRegionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, clsEditRegionEN.con_PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, clsEditRegionEN.con_PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, clsEditRegionEN.con_PrjId);
objEditRegionEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionEN.dicFldComparisonOp.ContainsKey(clsEditRegionEN.con_PrjId) == false)
{
objEditRegionEN.dicFldComparisonOp.Add(clsEditRegionEN.con_PrjId, strComparisonOp);
}
else
{
objEditRegionEN.dicFldComparisonOp[clsEditRegionEN.con_PrjId] = strComparisonOp;
}
}
return objEditRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEditRegionEN SetUpdUser(this clsEditRegionEN objEditRegionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, clsEditRegionEN.con_UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, clsEditRegionEN.con_UpdUser);
objEditRegionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionEN.dicFldComparisonOp.ContainsKey(clsEditRegionEN.con_UpdUser) == false)
{
objEditRegionEN.dicFldComparisonOp.Add(clsEditRegionEN.con_UpdUser, strComparisonOp);
}
else
{
objEditRegionEN.dicFldComparisonOp[clsEditRegionEN.con_UpdUser] = strComparisonOp;
}
}
return objEditRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objEditRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsEditRegionEN SetUpdDate(this clsEditRegionEN objEditRegionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, clsEditRegionEN.con_UpdDate);
objEditRegionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objEditRegionEN.dicFldComparisonOp.ContainsKey(clsEditRegionEN.con_UpdDate) == false)
{
objEditRegionEN.dicFldComparisonOp.Add(clsEditRegionEN.con_UpdDate, strComparisonOp);
}
else
{
objEditRegionEN.dicFldComparisonOp[clsEditRegionEN.con_UpdDate] = strComparisonOp;
}
}
return objEditRegionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsEditRegionEN objEditRegion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objEditRegion_Cond.IsUpdated(clsEditRegionEN.con_RegionId) == true)
{
string strComparisonOp_RegionId = objEditRegion_Cond.dicFldComparisonOp[clsEditRegionEN.con_RegionId];
strWhereCond += string.Format(" And {0} {2} {1}", clsEditRegionEN.con_RegionId, objEditRegion_Cond.RegionId, strComparisonOp_RegionId);
}
if (objEditRegion_Cond.IsUpdated(clsEditRegionEN.con_IsUseCtrl) == true)
{
if (objEditRegion_Cond.IsUseCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", clsEditRegionEN.con_IsUseCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", clsEditRegionEN.con_IsUseCtrl);
}
}
if (objEditRegion_Cond.IsUpdated(clsEditRegionEN.con_PrjId) == true)
{
string strComparisonOp_PrjId = objEditRegion_Cond.dicFldComparisonOp[clsEditRegionEN.con_PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsEditRegionEN.con_PrjId, objEditRegion_Cond.PrjId, strComparisonOp_PrjId);
}
if (objEditRegion_Cond.IsUpdated(clsEditRegionEN.con_UpdUser) == true)
{
string strComparisonOp_UpdUser = objEditRegion_Cond.dicFldComparisonOp[clsEditRegionEN.con_UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsEditRegionEN.con_UpdUser, objEditRegion_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objEditRegion_Cond.IsUpdated(clsEditRegionEN.con_UpdDate) == true)
{
string strComparisonOp_UpdDate = objEditRegion_Cond.dicFldComparisonOp[clsEditRegionEN.con_UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsEditRegionEN.con_UpdDate, objEditRegion_Cond.UpdDate, strComparisonOp_UpdDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objEditRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsEditRegionEN objEditRegionEN)
{
 if (objEditRegionEN.RegionId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objEditRegionEN.sf_UpdFldSetStr = objEditRegionEN.getsf_UpdFldSetStr();
clsEditRegionWApi.CheckPropertyNew(objEditRegionEN); 
bool bolResult = clsEditRegionWApi.UpdateRecord(objEditRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--EditRegion(编辑区域), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objEditRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PrjId_RegionId(this clsEditRegionEN objEditRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objEditRegionEN == null) return "";
if (objEditRegionEN.RegionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objEditRegionEN.PrjId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionEN.RegionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RegionId !=  {0}", objEditRegionEN.RegionId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objEditRegionEN.PrjId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objEditRegionEN.RegionId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objEditRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsEditRegionEN objEditRegionEN)
{
try
{
clsEditRegionWApi.CheckPropertyNew(objEditRegionEN); 
bool bolResult = clsEditRegionWApi.AddNewRecord(objEditRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objEditRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsEditRegionEN objEditRegionEN, string strWhereCond)
{
try
{
clsEditRegionWApi.CheckPropertyNew(objEditRegionEN); 
bool bolResult = clsEditRegionWApi.UpdateWithCondition(objEditRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 编辑区域(EditRegion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsEditRegionWApi
{
private static readonly string mstrApiControllerName = "EditRegionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsEditRegionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsEditRegionEN objEditRegionEN)
{
if (!Object.Equals(null, objEditRegionEN.PrjId) && GetStrLen(objEditRegionEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objEditRegionEN.UpdUser) && GetStrLen(objEditRegionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objEditRegionEN.UpdDate) && GetStrLen(objEditRegionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
 objEditRegionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEditRegionEN GetObjByRegionId(string lngRegionId)
{
string strAction = "GetObjByRegionId";
string strErrMsg = string.Empty;
string strResult = "";
clsEditRegionEN objEditRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objEditRegionEN = JsonConvert.DeserializeObject<clsEditRegionEN>((string)jobjReturn["ReturnObj"]);
return objEditRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "lngRegionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsEditRegionEN GetObjByRegionId_WA_Cache(string lngRegionId, string strPrjId)
{
string strAction = "GetObjByRegionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsEditRegionEN objEditRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString(),
["PrjId"] = strPrjId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objEditRegionEN = JsonConvert.DeserializeObject<clsEditRegionEN>((string)jobjReturn["ReturnObj"]);
return objEditRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsEditRegionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsEditRegionEN objEditRegionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objEditRegionEN = JsonConvert.DeserializeObject<clsEditRegionEN>((string)jobjReturn["ReturnObj"]);
return objEditRegionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "lngRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsEditRegionEN GetObjByRegionId_Cache(string lngRegionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsEditRegionEN._CurrTabName_S, strPrjId);
List<clsEditRegionEN> arrEditRegionObjLst_Cache = GetObjLst_Cache(strPrjId);
IEnumerable <clsEditRegionEN> arrEditRegionObjLst_Sel =
from objEditRegionEN in arrEditRegionObjLst_Cache
where objEditRegionEN.RegionId == lngRegionId
select objEditRegionEN;
if (arrEditRegionObjLst_Sel.Count() == 0)
{
   clsEditRegionEN obj = clsEditRegionWApi.GetObjByRegionId(lngRegionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrEditRegionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionEN> GetObjLst(string strWhereCond)
{
 List<clsEditRegionEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsEditRegionEN> GetObjLstByRegionIdLst(List<long> arrRegionId)
{
 List<clsEditRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByRegionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "lngRegionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsEditRegionEN> GetObjLstByRegionIdLst_Cache(List<long> arrRegionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsEditRegionEN._CurrTabName_S, strPrjId);
List<clsEditRegionEN> arrEditRegionObjLst_Cache = GetObjLst_Cache(strPrjId);
IEnumerable <clsEditRegionEN> arrEditRegionObjLst_Sel =
from objEditRegionEN in arrEditRegionObjLst_Cache
where arrRegionId.Contains(objEditRegionEN.RegionId)
select objEditRegionEN;
return arrEditRegionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsEditRegionEN> GetObjLstByRegionIdLst_WA_Cache(List<long> arrRegionId, string strPrjId)
{
 List<clsEditRegionEN> arrObjLst = null; 
string strAction = "GetObjLstByRegionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PrjId"] = strPrjId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsEditRegionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsEditRegionEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsEditRegionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsEditRegionEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsEditRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsEditRegionEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsEditRegionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsEditRegionEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsEditRegionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string lngRegionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsEditRegionEN objEditRegionEN = clsEditRegionWApi.GetObjByRegionId(lngRegionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngRegionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelEditRegions(List<string> arrRegionId)
{
string strAction = "DelEditRegions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRegionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsEditRegionEN objEditRegionEN = clsEditRegionWApi.GetObjByRegionId(long.Parse(arrRegionId[0]));
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelEditRegionsByCond(string strWhereCond)
{
string strAction = "DelEditRegionsByCond";
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsEditRegionEN objEditRegionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionEN>(objEditRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsEditRegionWApi.ReFreshCache(objEditRegionEN.PrjId);
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsEditRegionEN objEditRegionEN)
{
if (string.IsNullOrEmpty(objEditRegionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionEN>(objEditRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objEditRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsEditRegionEN objEditRegionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objEditRegionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objEditRegionEN.RegionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsEditRegionEN>(objEditRegionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string lngRegionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RegionId"] = lngRegionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objEditRegionENS">源对象</param>
 /// <param name = "objEditRegionENT">目标对象</param>
 public static void CopyTo(clsEditRegionEN objEditRegionENS, clsEditRegionEN objEditRegionENT)
{
try
{
objEditRegionENT.RegionId = objEditRegionENS.RegionId; //区域Id
objEditRegionENT.IsUseCtrl = objEditRegionENS.IsUseCtrl; //是否使用控件
objEditRegionENT.PrjId = objEditRegionENS.PrjId; //工程ID
objEditRegionENT.UpdUser = objEditRegionENS.UpdUser; //修改者
objEditRegionENT.UpdDate = objEditRegionENS.UpdDate; //修改日期
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
public static DataTable ToDataTable(List<clsEditRegionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsEditRegionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsEditRegionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsEditRegionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsEditRegionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsEditRegionEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsEditRegionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEditRegionWApi没有刷新缓存机制(clsEditRegionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RegionId");
//if (arrEditRegionObjLst_Cache == null)
//{
//arrEditRegionObjLst_Cache = await clsEditRegionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsEditRegionEN._CurrTabName_S, strPrjId);
CacheHelper.Remove(strKey);
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsEditRegionWApi.objCommFun4BL != null) 
{
 string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsEditRegionEN._CurrTabName_S, strPrjId);
CacheHelper.Remove(strKey);
clsEditRegionWApi.objCommFun4BL.ReFreshCache(strPrjId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsEditRegionEN> GetObjLst_Cache(string strPrjId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsEditRegionEN._CurrTabName_S, strPrjId);
List<clsEditRegionEN> arrEditRegionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("PrjId='{0}'", strPrjId)); });
return arrEditRegionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsEditRegionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conEditRegion.RegionId, Type.GetType("System.Int64"));
objDT.Columns.Add(conEditRegion.IsUseCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(conEditRegion.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conEditRegion.UpdDate, Type.GetType("System.String"));
foreach (clsEditRegionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conEditRegion.RegionId] = objInFor[conEditRegion.RegionId];
objDR[conEditRegion.IsUseCtrl] = objInFor[conEditRegion.IsUseCtrl];
objDR[conEditRegion.PrjId] = objInFor[conEditRegion.PrjId];
objDR[conEditRegion.UpdUser] = objInFor[conEditRegion.UpdUser];
objDR[conEditRegion.UpdDate] = objInFor[conEditRegion.UpdDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}