
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_SimWApi
 表名:vFieldTab_Sim(00050590)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:02
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
public static class  clsvFieldTab_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_SimEN SetFldId(this clsvFieldTab_SimEN objvFieldTab_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab_Sim.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab_Sim.FldId);
objvFieldTab_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_SimEN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim.FldId) == false)
{
objvFieldTab_SimEN.dicFldComparisonOp.Add(convFieldTab_Sim.FldId, strComparisonOp);
}
else
{
objvFieldTab_SimEN.dicFldComparisonOp[convFieldTab_Sim.FldId] = strComparisonOp;
}
}
return objvFieldTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_SimEN SetFldName(this clsvFieldTab_SimEN objvFieldTab_SimEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab_Sim.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab_Sim.FldName);
objvFieldTab_SimEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_SimEN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim.FldName) == false)
{
objvFieldTab_SimEN.dicFldComparisonOp.Add(convFieldTab_Sim.FldName, strComparisonOp);
}
else
{
objvFieldTab_SimEN.dicFldComparisonOp[convFieldTab_Sim.FldName] = strComparisonOp;
}
}
return objvFieldTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_SimEN SetCaption(this clsvFieldTab_SimEN objvFieldTab_SimEN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab_Sim.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab_Sim.Caption);
objvFieldTab_SimEN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_SimEN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim.Caption) == false)
{
objvFieldTab_SimEN.dicFldComparisonOp.Add(convFieldTab_Sim.Caption, strComparisonOp);
}
else
{
objvFieldTab_SimEN.dicFldComparisonOp[convFieldTab_Sim.Caption] = strComparisonOp;
}
}
return objvFieldTab_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_SimEN SetDataTypeId(this clsvFieldTab_SimEN objvFieldTab_SimEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab_Sim.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab_Sim.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab_Sim.DataTypeId);
objvFieldTab_SimEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_SimEN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim.DataTypeId) == false)
{
objvFieldTab_SimEN.dicFldComparisonOp.Add(convFieldTab_Sim.DataTypeId, strComparisonOp);
}
else
{
objvFieldTab_SimEN.dicFldComparisonOp[convFieldTab_Sim.DataTypeId] = strComparisonOp;
}
}
return objvFieldTab_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab_SimEN objvFieldTab_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab_SimCond.IsUpdated(convFieldTab_Sim.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab_SimCond.dicFldComparisonOp[convFieldTab_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim.FldId, objvFieldTab_SimCond.FldId, strComparisonOpFldId);
}
if (objvFieldTab_SimCond.IsUpdated(convFieldTab_Sim.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab_SimCond.dicFldComparisonOp[convFieldTab_Sim.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim.FldName, objvFieldTab_SimCond.FldName, strComparisonOpFldName);
}
if (objvFieldTab_SimCond.IsUpdated(convFieldTab_Sim.Caption) == true)
{
string strComparisonOpCaption = objvFieldTab_SimCond.dicFldComparisonOp[convFieldTab_Sim.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim.Caption, objvFieldTab_SimCond.Caption, strComparisonOpCaption);
}
if (objvFieldTab_SimCond.IsUpdated(convFieldTab_Sim.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFieldTab_SimCond.dicFldComparisonOp[convFieldTab_Sim.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim.DataTypeId, objvFieldTab_SimCond.DataTypeId, strComparisonOpDataTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v字段表_Sim(vFieldTab_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab_SimWApi
{
private static readonly string mstrApiControllerName = "vFieldTab_SimApi";

 public clsvFieldTab_SimWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FldId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v字段表_Sim]...","0");
List<clsvFieldTab_SimEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FldId";
objDDL.DataTextField="FldName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

//该表下拉框功能不需要生成;
//该表下拉框功能不需要生成;

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab_SimEN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsvFieldTab_SimEN objvFieldTab_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFieldTab_SimEN = JsonConvert.DeserializeObject<clsvFieldTab_SimEN>(strJson);
return objvFieldTab_SimEN;
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
public static clsvFieldTab_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTab_SimEN objvFieldTab_SimEN;
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
objvFieldTab_SimEN = JsonConvert.DeserializeObject<clsvFieldTab_SimEN>(strJson);
return objvFieldTab_SimEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab_SimEN GetObjByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab_SimEN._CurrTabName, strPrjId);
List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel =
from objvFieldTab_SimEN in arrvFieldTab_SimObjLstCache
where objvFieldTab_SimEN.FldId == strFldId 
select objvFieldTab_SimEN;
if (arrvFieldTab_SimObjLst_Sel.Count() == 0)
{
   clsvFieldTab_SimEN obj = clsvFieldTab_SimWApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTab_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFldNameByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel1 =
from objvFieldTab_SimEN in arrvFieldTab_SimObjLstCache
where objvFieldTab_SimEN.FldId == strFldId 
select objvFieldTab_SimEN;
List <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel = new List<clsvFieldTab_SimEN>();
foreach (clsvFieldTab_SimEN obj in arrvFieldTab_SimObjLst_Sel1)
{
arrvFieldTab_SimObjLst_Sel.Add(obj);
}
if (arrvFieldTab_SimObjLst_Sel.Count > 0)
{
return arrvFieldTab_SimObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在vFieldTab_Sim对象缓存列表中,找不到记录[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFieldTab_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return "";
//初始化列表缓存
List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel1 =
from objvFieldTab_SimEN in arrvFieldTab_SimObjLstCache
where objvFieldTab_SimEN.FldId == strFldId 
select objvFieldTab_SimEN;
List <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel = new List<clsvFieldTab_SimEN>();
foreach (clsvFieldTab_SimEN obj in arrvFieldTab_SimObjLst_Sel1)
{
arrvFieldTab_SimObjLst_Sel.Add(obj);
}
if (arrvFieldTab_SimObjLst_Sel.Count > 0)
{
return arrvFieldTab_SimObjLst_Sel[0].FldName;
}
string strErrMsgForGetObjById = string.Format("在vFieldTab_Sim对象缓存列表中,找不到记录的相关名称[FldId = {0}](函数:{1})", strFldId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvFieldTab_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
 /// <param name = "arrFldId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_SimEN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
string strAction = "GetObjLstByFldIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
 /// <param name = "arrFldId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvFieldTab_SimEN> GetObjLstByFldIdLstCache(List<string> arrFldId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab_SimEN._CurrTabName, strPrjId);
List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_SimEN> arrvFieldTab_SimObjLst_Sel =
from objvFieldTab_SimEN in arrvFieldTab_SimObjLstCache
where arrFldId.Contains(objvFieldTab_SimEN.FldId)
select objvFieldTab_SimEN;
return arrvFieldTab_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
public static List<clsvFieldTab_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
public static List<clsvFieldTab_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
public static List<clsvFieldTab_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTab_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_SimEN>>(strJson);
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
public static bool IsExist(string strFldId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId
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
 /// <param name = "objvFieldTab_SimENS">源对象</param>
 /// <param name = "objvFieldTab_SimENT">目标对象</param>
 public static void CopyTo(clsvFieldTab_SimEN objvFieldTab_SimENS, clsvFieldTab_SimEN objvFieldTab_SimENT)
{
try
{
objvFieldTab_SimENT.FldId = objvFieldTab_SimENS.FldId; //字段Id
objvFieldTab_SimENT.FldName = objvFieldTab_SimENS.FldName; //字段名
objvFieldTab_SimENT.Caption = objvFieldTab_SimENS.Caption; //标题
objvFieldTab_SimENT.DataTypeId = objvFieldTab_SimENS.DataTypeId; //数据类型Id
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
public static DataTable ToDataTable(List<clsvFieldTab_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTab_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTab_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTab_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTab_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTab_SimEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab_SimEN._CurrTabName, strPrjId);
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
public static List<clsvFieldTab_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTab_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTab_SimEN._WhereFormat, strPrjId);
}
else
{
var strMsg =$"分类字段为扩展字段,此时_WhereFormat不能为空!({clsStackTrace.GetCurrFunction()})";
throw new Exception(strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab_SimEN._CurrTabName, strPrjId);
List<clsvFieldTab_SimEN> arrvFieldTab_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTab_SimObjLstCache;
}
//该表缓存分类字段是扩展字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTab_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab_Sim.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim.DataTypeId, Type.GetType("System.String"));
foreach (clsvFieldTab_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab_Sim.FldId] = objInFor[convFieldTab_Sim.FldId];
objDR[convFieldTab_Sim.FldName] = objInFor[convFieldTab_Sim.FldName];
objDR[convFieldTab_Sim.Caption] = objInFor[convFieldTab_Sim.Caption];
objDR[convFieldTab_Sim.DataTypeId] = objInFor[convFieldTab_Sim.DataTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}