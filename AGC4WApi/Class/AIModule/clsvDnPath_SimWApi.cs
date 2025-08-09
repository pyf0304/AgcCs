
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnPath_SimWApi
 表名:vDnPath_Sim(00050603)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:58
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
public static class  clsvDnPath_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathId">DN路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetDnPathId(this clsvDnPath_SimEN objvDnPath_SimEN, string strDnPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnPathId, 8, convDnPath_Sim.DnPathId);
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, convDnPath_Sim.DnPathId);
objvDnPath_SimEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.DnPathId) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.DnPathId, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.DnPathId] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathName">DN路径名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetDnPathName(this clsvDnPath_SimEN objvDnPath_SimEN, string strDnPathName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathName, convDnPath_Sim.DnPathName);
clsCheckSql.CheckFieldLen(strDnPathName, 100, convDnPath_Sim.DnPathName);
objvDnPath_SimEN.DnPathName = strDnPathName; //DN路径名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.DnPathName) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.DnPathName, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.DnPathName] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetInDataNodeId(this clsvDnPath_SimEN objvDnPath_SimEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, convDnPath_Sim.InDataNodeId);
objvDnPath_SimEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.InDataNodeId) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.InDataNodeId, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.InDataNodeId] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetOutDataNodeId(this clsvDnPath_SimEN objvDnPath_SimEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, convDnPath_Sim.OutDataNodeId);
objvDnPath_SimEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.OutDataNodeId) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.OutDataNodeId, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.OutDataNodeId] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathNodeLst">路径结点列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetDnPathNodeLst(this clsvDnPath_SimEN objvDnPath_SimEN, string strDnPathNodeLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathNodeLst, convDnPath_Sim.DnPathNodeLst);
clsCheckSql.CheckFieldLen(strDnPathNodeLst, 500, convDnPath_Sim.DnPathNodeLst);
objvDnPath_SimEN.DnPathNodeLst = strDnPathNodeLst; //路径结点列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.DnPathNodeLst) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.DnPathNodeLst, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.DnPathNodeLst] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnPath_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnPath_SimEN SetPrjId(this clsvDnPath_SimEN objvDnPath_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnPath_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnPath_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnPath_Sim.PrjId);
objvDnPath_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnPath_SimEN.dicFldComparisonOp.ContainsKey(convDnPath_Sim.PrjId) == false)
{
objvDnPath_SimEN.dicFldComparisonOp.Add(convDnPath_Sim.PrjId, strComparisonOp);
}
else
{
objvDnPath_SimEN.dicFldComparisonOp[convDnPath_Sim.PrjId] = strComparisonOp;
}
}
return objvDnPath_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnPath_SimEN objvDnPath_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.DnPathId) == true)
{
string strComparisonOpDnPathId = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnPath_Sim.DnPathId, objvDnPath_SimCond.DnPathId, strComparisonOpDnPathId);
}
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.DnPathName) == true)
{
string strComparisonOpDnPathName = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.DnPathName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnPath_Sim.DnPathName, objvDnPath_SimCond.DnPathName, strComparisonOpDnPathName);
}
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnPath_Sim.InDataNodeId, objvDnPath_SimCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnPath_Sim.OutDataNodeId, objvDnPath_SimCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.DnPathNodeLst) == true)
{
string strComparisonOpDnPathNodeLst = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.DnPathNodeLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnPath_Sim.DnPathNodeLst, objvDnPath_SimCond.DnPathNodeLst, strComparisonOpDnPathNodeLst);
}
if (objvDnPath_SimCond.IsUpdated(convDnPath_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvDnPath_SimCond.dicFldComparisonOp[convDnPath_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnPath_Sim.PrjId, objvDnPath_SimCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vDnPath_Sim(vDnPath_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDnPath_SimWApi
{
private static readonly string mstrApiControllerName = "vDnPath_SimApi";

 public clsvDnPath_SimWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DnPathId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDnPath_Sim]...","0");
List<clsvDnPath_SimEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DnPathId";
objDDL.DataTextField="DnPathName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_DnPathId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convDnPath_Sim.DnPathId); 
List<clsvDnPath_SimEN> arrObjLst = clsvDnPath_SimWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvDnPath_SimEN objvDnPath_SimEN = new clsvDnPath_SimEN()
{
DnPathId = "0",
DnPathName = "选[vDnPath_Sim]..."
};
arrObjLstSel.Insert(0, objvDnPath_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convDnPath_Sim.DnPathId;
objComboBox.DisplayMember = convDnPath_Sim.DnPathName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnPath_SimEN GetObjByDnPathId(string strDnPathId)
{
if (strDnPathId == "") return null;
string strAction = "GetObjByDnPathId";
clsvDnPath_SimEN objvDnPath_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnPathId"] = strDnPathId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDnPath_SimEN = JsonConvert.DeserializeObject<clsvDnPath_SimEN>(strJson);
return objvDnPath_SimEN;
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
public static clsvDnPath_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDnPath_SimEN objvDnPath_SimEN;
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
objvDnPath_SimEN = JsonConvert.DeserializeObject<clsvDnPath_SimEN>(strJson);
return objvDnPath_SimEN;
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
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnPath_SimEN GetObjByDnPathIdCache(string strDnPathId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvDnPath_SimEN._CurrTabName);
List<clsvDnPath_SimEN> arrvDnPath_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel =
from objvDnPath_SimEN in arrvDnPath_SimObjLstCache
where objvDnPath_SimEN.DnPathId == strDnPathId 
select objvDnPath_SimEN;
if (arrvDnPath_SimObjLst_Sel.Count() == 0)
{
   clsvDnPath_SimEN obj = clsvDnPath_SimWApi.GetObjByDnPathId(strDnPathId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDnPath_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDnPathNameByDnPathIdCache(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//初始化列表缓存
List<clsvDnPath_SimEN> arrvDnPath_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel1 =
from objvDnPath_SimEN in arrvDnPath_SimObjLstCache
where objvDnPath_SimEN.DnPathId == strDnPathId 
select objvDnPath_SimEN;
List <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel = new List<clsvDnPath_SimEN>();
foreach (clsvDnPath_SimEN obj in arrvDnPath_SimObjLst_Sel1)
{
arrvDnPath_SimObjLst_Sel.Add(obj);
}
if (arrvDnPath_SimObjLst_Sel.Count > 0)
{
return arrvDnPath_SimObjLst_Sel[0].DnPathName;
}
string strErrMsgForGetObjById = string.Format("在vDnPath_Sim对象缓存列表中,找不到记录[DnPathId = {0}](函数:{1})", strDnPathId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDnPath_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDnPathIdCache(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//初始化列表缓存
List<clsvDnPath_SimEN> arrvDnPath_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel1 =
from objvDnPath_SimEN in arrvDnPath_SimObjLstCache
where objvDnPath_SimEN.DnPathId == strDnPathId 
select objvDnPath_SimEN;
List <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel = new List<clsvDnPath_SimEN>();
foreach (clsvDnPath_SimEN obj in arrvDnPath_SimObjLst_Sel1)
{
arrvDnPath_SimObjLst_Sel.Add(obj);
}
if (arrvDnPath_SimObjLst_Sel.Count > 0)
{
return arrvDnPath_SimObjLst_Sel[0].DnPathName;
}
string strErrMsgForGetObjById = string.Format("在vDnPath_Sim对象缓存列表中,找不到记录的相关名称[DnPathId = {0}](函数:{1})", strDnPathId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDnPath_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnPath_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvDnPath_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
 /// <param name = "arrDnPathId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnPath_SimEN> GetObjLstByDnPathIdLst(List<string> arrDnPathId)
{
 List<clsvDnPath_SimEN> arrObjLst; 
string strAction = "GetObjLstByDnPathIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnPathId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
 /// <param name = "arrDnPathId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDnPath_SimEN> GetObjLstByDnPathIdLstCache(List<string> arrDnPathId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvDnPath_SimEN._CurrTabName);
List<clsvDnPath_SimEN> arrvDnPath_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvDnPath_SimEN> arrvDnPath_SimObjLst_Sel =
from objvDnPath_SimEN in arrvDnPath_SimObjLstCache
where arrDnPathId.Contains(objvDnPath_SimEN.DnPathId)
select objvDnPath_SimEN;
return arrvDnPath_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnPath_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDnPath_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
public static List<clsvDnPath_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDnPath_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
public static List<clsvDnPath_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDnPath_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
public static List<clsvDnPath_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDnPath_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnPath_SimEN>>(strJson);
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
public static bool IsExist(string strDnPathId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnPathId"] = strDnPathId
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
 /// <param name = "objvDnPath_SimENS">源对象</param>
 /// <param name = "objvDnPath_SimENT">目标对象</param>
 public static void CopyTo(clsvDnPath_SimEN objvDnPath_SimENS, clsvDnPath_SimEN objvDnPath_SimENT)
{
try
{
objvDnPath_SimENT.DnPathId = objvDnPath_SimENS.DnPathId; //DN路径Id
objvDnPath_SimENT.DnPathName = objvDnPath_SimENS.DnPathName; //DN路径名
objvDnPath_SimENT.InDataNodeId = objvDnPath_SimENS.InDataNodeId; //In数据结点Id
objvDnPath_SimENT.OutDataNodeId = objvDnPath_SimENS.OutDataNodeId; //Out数据结点Id
objvDnPath_SimENT.DnPathNodeLst = objvDnPath_SimENS.DnPathNodeLst; //路径结点列表
objvDnPath_SimENT.PrjId = objvDnPath_SimENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvDnPath_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDnPath_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDnPath_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDnPath_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDnPath_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDnPath_SimEN._AttributeName)
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
string strKey = string.Format("{0}", clsvDnPath_SimEN._CurrTabName);
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
public static List<clsvDnPath_SimEN> GetObjLstCache(string strPrjId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvDnPath_SimEN._CurrTabName;
List<clsvDnPath_SimEN> arrvDnPath_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDnPath_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDnPath_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDnPath_Sim.DnPathId, Type.GetType("System.String"));
objDT.Columns.Add(convDnPath_Sim.DnPathName, Type.GetType("System.String"));
objDT.Columns.Add(convDnPath_Sim.InDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnPath_Sim.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnPath_Sim.DnPathNodeLst, Type.GetType("System.String"));
objDT.Columns.Add(convDnPath_Sim.PrjId, Type.GetType("System.String"));
foreach (clsvDnPath_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDnPath_Sim.DnPathId] = objInFor[convDnPath_Sim.DnPathId];
objDR[convDnPath_Sim.DnPathName] = objInFor[convDnPath_Sim.DnPathName];
objDR[convDnPath_Sim.InDataNodeId] = objInFor[convDnPath_Sim.InDataNodeId];
objDR[convDnPath_Sim.OutDataNodeId] = objInFor[convDnPath_Sim.OutDataNodeId];
objDR[convDnPath_Sim.DnPathNodeLst] = objInFor[convDnPath_Sim.DnPathNodeLst];
objDR[convDnPath_Sim.PrjId] = objInFor[convDnPath_Sim.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}