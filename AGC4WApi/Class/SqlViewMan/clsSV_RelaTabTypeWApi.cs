
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSV_RelaTabTypeWApi
 表名:SV_RelaTabType(00050248)
 生成代码版本:2021.09.24.1
 生成日期:2021/09/24 02:00:08
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理
 模块英文名:SqlViewMan
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
public static class clsSV_RelaTabTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetSvRelaTabTypeId(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, conSV_RelaTabType.SvRelaTabTypeId);
objSV_RelaTabTypeEN.SvRelaTabTypeId = strSvRelaTabTypeId; //Sql视图相关表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.SvRelaTabTypeId) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.SvRelaTabTypeId, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeId] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetSvRelaTabTypeName(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strSvRelaTabTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeName, conSV_RelaTabType.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(strSvRelaTabTypeName, 30, conSV_RelaTabType.SvRelaTabTypeName);
objSV_RelaTabTypeEN.SvRelaTabTypeName = strSvRelaTabTypeName; //Sql视图相关表类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.SvRelaTabTypeName) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.SvRelaTabTypeName, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeName] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSV_RelaTabTypeEN SetMemo(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSV_RelaTabType.Memo);
objSV_RelaTabTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSV_RelaTabTypeEN.dicFldComparisonOp.ContainsKey(conSV_RelaTabType.Memo) == false)
{
objSV_RelaTabTypeEN.dicFldComparisonOp.Add(conSV_RelaTabType.Memo, strComparisonOp);
}
else
{
objSV_RelaTabTypeEN.dicFldComparisonOp[conSV_RelaTabType.Memo] = strComparisonOp;
}
}
return objSV_RelaTabTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSV_RelaTabTypeEN objSV_RelaTabType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSV_RelaTabType_Cond.IsUpdated(conSV_RelaTabType.SvRelaTabTypeId) == true)
{
string strComparisonOp_SvRelaTabTypeId = objSV_RelaTabType_Cond.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.SvRelaTabTypeId, objSV_RelaTabType_Cond.SvRelaTabTypeId, strComparisonOp_SvRelaTabTypeId);
}
if (objSV_RelaTabType_Cond.IsUpdated(conSV_RelaTabType.SvRelaTabTypeName) == true)
{
string strComparisonOp_SvRelaTabTypeName = objSV_RelaTabType_Cond.dicFldComparisonOp[conSV_RelaTabType.SvRelaTabTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.SvRelaTabTypeName, objSV_RelaTabType_Cond.SvRelaTabTypeName, strComparisonOp_SvRelaTabTypeName);
}
if (objSV_RelaTabType_Cond.IsUpdated(conSV_RelaTabType.Memo) == true)
{
string strComparisonOp_Memo = objSV_RelaTabType_Cond.dicFldComparisonOp[conSV_RelaTabType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSV_RelaTabType.Memo, objSV_RelaTabType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSV_RelaTabTypeEN.sfUpdFldSetStr = objSV_RelaTabTypeEN.getsfUpdFldSetStr();
clsSV_RelaTabTypeWApi.CheckPropertyNew(objSV_RelaTabTypeEN); 
bool bolResult = clsSV_RelaTabTypeWApi.UpdateRecord(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--SV_RelaTabType(Sql视图相关表类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_SvRelaTabTypeName(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSV_RelaTabTypeEN == null) return "";
if (objSV_RelaTabTypeEN.SvRelaTabTypeId == null || objSV_RelaTabTypeEN.SvRelaTabTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SvRelaTabTypeId !=  '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeId);
 sbCondition.AppendFormat(" and SvRelaTabTypeName = '{0}'", objSV_RelaTabTypeEN.SvRelaTabTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true || clsSV_RelaTabTypeWApi.IsExist(objSV_RelaTabTypeEN.SvRelaTabTypeId) == true)
 {
     objSV_RelaTabTypeEN.SvRelaTabTypeId = clsSV_RelaTabTypeWApi.GetMaxStrId();
 }
clsSV_RelaTabTypeWApi.CheckPropertyNew(objSV_RelaTabTypeEN); 
bool bolResult = clsSV_RelaTabTypeWApi.AddNewRecord(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSV_RelaTabTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
try
{
clsSV_RelaTabTypeWApi.CheckPropertyNew(objSV_RelaTabTypeEN); 
string strSvRelaTabTypeId = clsSV_RelaTabTypeWApi.AddNewRecordWithMaxId(objSV_RelaTabTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
return strSvRelaTabTypeId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strWhereCond)
{
try
{
clsSV_RelaTabTypeWApi.CheckPropertyNew(objSV_RelaTabTypeEN); 
bool bolResult = clsSV_RelaTabTypeWApi.UpdateWithCondition(objSV_RelaTabTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
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
 /// Sql视图相关表类型(SV_RelaTabType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSV_RelaTabTypeWApi
{
private static readonly string mstrApiControllerName = "SV_RelaTabTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsSV_RelaTabTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SvRelaTabTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[Sql视图相关表类型]...","0");
List<clsSV_RelaTabTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="SvRelaTabTypeId";
objDDL.DataTextField="SvRelaTabTypeName";
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
public static void BindCbo_SvRelaTabTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSV_RelaTabType.SvRelaTabTypeId); 
List<clsSV_RelaTabTypeEN> arrObjLst = clsSV_RelaTabTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = new clsSV_RelaTabTypeEN()
{
SvRelaTabTypeId = "0",
SvRelaTabTypeName = "选[Sql视图相关表类型]..."
};
arrObjLst.Insert(0, objSV_RelaTabTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSV_RelaTabType.SvRelaTabTypeId;
objComboBox.DisplayMember = conSV_RelaTabType.SvRelaTabTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (!Object.Equals(null, objSV_RelaTabTypeEN.SvRelaTabTypeId) && GetStrLen(objSV_RelaTabTypeEN.SvRelaTabTypeId) > 2)
{
 throw new Exception("字段[Sql视图相关表类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSV_RelaTabTypeEN.SvRelaTabTypeName) && GetStrLen(objSV_RelaTabTypeEN.SvRelaTabTypeName) > 30)
{
 throw new Exception("字段[Sql视图相关表类型名]的长度不能超过30!");
}
if (!Object.Equals(null, objSV_RelaTabTypeEN.Memo) && GetStrLen(objSV_RelaTabTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSV_RelaTabTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeId(string strSvRelaTabTypeId)
{
string strAction = "GetObjBySvRelaTabTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["SvRelaTabTypeId"] = strSvRelaTabTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objSV_RelaTabTypeEN = JsonConvert.DeserializeObject<clsSV_RelaTabTypeEN>((string)jobjReturn["returnObj"]);
return objSV_RelaTabTypeEN;
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
 /// <param name = "strSvRelaTabTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeId_WA_Cache(string strSvRelaTabTypeId)
{
string strAction = "GetObjBySvRelaTabTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["SvRelaTabTypeId"] = strSvRelaTabTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objSV_RelaTabTypeEN = JsonConvert.DeserializeObject<clsSV_RelaTabTypeEN>((string)jobjReturn["returnObj"]);
return objSV_RelaTabTypeEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static clsSV_RelaTabTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = null;
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
objSV_RelaTabTypeEN = JsonConvert.DeserializeObject<clsSV_RelaTabTypeEN>((string)jobjReturn["returnObj"]);
return objSV_RelaTabTypeEN;
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
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSV_RelaTabTypeEN GetObjBySvRelaTabTypeId_Cache(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel =
from objSV_RelaTabTypeEN in arrSV_RelaTabTypeObjLst_Cache
where objSV_RelaTabTypeEN.SvRelaTabTypeId == strSvRelaTabTypeId
select objSV_RelaTabTypeEN;
if (arrSV_RelaTabTypeObjLst_Sel.Count() == 0)
{
   clsSV_RelaTabTypeEN obj = clsSV_RelaTabTypeWApi.GetObjBySvRelaTabTypeId(strSvRelaTabTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSV_RelaTabTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSvRelaTabTypeNameBySvRelaTabTypeId_Cache(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel1 =
from objSV_RelaTabTypeEN in arrSV_RelaTabTypeObjLst_Cache
where objSV_RelaTabTypeEN.SvRelaTabTypeId == strSvRelaTabTypeId
select objSV_RelaTabTypeEN;
List <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel = new List<clsSV_RelaTabTypeEN>();
foreach (clsSV_RelaTabTypeEN obj in arrSV_RelaTabTypeObjLst_Sel1)
{
arrSV_RelaTabTypeObjLst_Sel.Add(obj);
}
if (arrSV_RelaTabTypeObjLst_Sel.Count > 0)
{
return arrSV_RelaTabTypeObjLst_Sel[0].SvRelaTabTypeName;
}
string strErrMsgForGetObjById = string.Format("在SV_RelaTabType对象缓存列表中,找不到记录[SvRelaTabTypeId = {0}](函数:{1})", strSvRelaTabTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSV_RelaTabTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySvRelaTabTypeId_Cache(string strSvRelaTabTypeId)
{
if (string.IsNullOrEmpty(strSvRelaTabTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel1 =
from objSV_RelaTabTypeEN in arrSV_RelaTabTypeObjLst_Cache
where objSV_RelaTabTypeEN.SvRelaTabTypeId == strSvRelaTabTypeId
select objSV_RelaTabTypeEN;
List <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel = new List<clsSV_RelaTabTypeEN>();
foreach (clsSV_RelaTabTypeEN obj in arrSV_RelaTabTypeObjLst_Sel1)
{
arrSV_RelaTabTypeObjLst_Sel.Add(obj);
}
if (arrSV_RelaTabTypeObjLst_Sel.Count > 0)
{
return arrSV_RelaTabTypeObjLst_Sel[0].SvRelaTabTypeName;
}
string strErrMsgForGetObjById = string.Format("在SV_RelaTabType对象缓存列表中,找不到记录的相关名称[SvRelaTabTypeId = {0}](函数:{1})", strSvRelaTabTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSV_RelaTabTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLst(string strWhereCond)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstBySvRelaTabTypeIdLst(List<string> arrSvRelaTabTypeId)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
string strAction = "GetObjLstBySvRelaTabTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSvRelaTabTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
 /// <param name = "strSvRelaTabTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsSV_RelaTabTypeEN> GetObjLstBySvRelaTabTypeIdLst_Cache(List<string> arrSvRelaTabTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Sel =
from objSV_RelaTabTypeEN in arrSV_RelaTabTypeObjLst_Cache
where arrSvRelaTabTypeId.Contains(objSV_RelaTabTypeEN.SvRelaTabTypeId)
select objSV_RelaTabTypeEN;
return arrSV_RelaTabTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLstBySvRelaTabTypeIdLst_WA_Cache(List<string> arrSvRelaTabTypeId)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
string strAction = "GetObjLstBySvRelaTabTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSvRelaTabTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsSV_RelaTabTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsSV_RelaTabTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSV_RelaTabTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSV_RelaTabTypeEN>>((string)jobjReturn["returnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strSvRelaTabTypeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsSV_RelaTabTypeEN objSV_RelaTabTypeEN = clsSV_RelaTabTypeWApi.GetObjBySvRelaTabTypeId(strSvRelaTabTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strSvRelaTabTypeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsSV_RelaTabTypeWApi.ReFreshCache();
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
public static int DelSV_RelaTabTypes(List<string> arrSvRelaTabTypeId)
{
string strAction = "DelSV_RelaTabTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSvRelaTabTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsSV_RelaTabTypeWApi.ReFreshCache();
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
public static int DelSV_RelaTabTypesByCond(string strWhereCond)
{
string strAction = "DelSV_RelaTabTypesByCond";
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
public static bool AddNewRecord(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSV_RelaTabTypeEN>(objSV_RelaTabTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSV_RelaTabTypeEN>(objSV_RelaTabTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshCache();
var strSvRelaTabTypeId = (string)jobjReturn["returnStr"];
return strSvRelaTabTypeId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN)
{
if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSV_RelaTabTypeEN.SvRelaTabTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSV_RelaTabTypeEN>(objSV_RelaTabTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// <param name = "objSV_RelaTabTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSV_RelaTabTypeEN objSV_RelaTabTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSV_RelaTabTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSV_RelaTabTypeEN.SvRelaTabTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSV_RelaTabTypeEN.SvRelaTabTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSV_RelaTabTypeEN>(objSV_RelaTabTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strSvRelaTabTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["SvRelaTabTypeId"] = strSvRelaTabTypeId
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSV_RelaTabTypeENS">源对象</param>
 /// <param name = "objSV_RelaTabTypeENT">目标对象</param>
 public static void CopyTo(clsSV_RelaTabTypeEN objSV_RelaTabTypeENS, clsSV_RelaTabTypeEN objSV_RelaTabTypeENT)
{
try
{
objSV_RelaTabTypeENT.SvRelaTabTypeId = objSV_RelaTabTypeENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSV_RelaTabTypeENT.SvRelaTabTypeName = objSV_RelaTabTypeENS.SvRelaTabTypeName; //Sql视图相关表类型名
objSV_RelaTabTypeENT.Memo = objSV_RelaTabTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSV_RelaTabTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSV_RelaTabTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSV_RelaTabTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSV_RelaTabTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSV_RelaTabTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSV_RelaTabTypeEN.AttributeName)
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
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSV_RelaTabTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSV_RelaTabTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSV_RelaTabTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSV_RelaTabTypeEN._CurrTabName);
List<clsSV_RelaTabTypeEN> arrSV_RelaTabTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSV_RelaTabTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSV_RelaTabTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSV_RelaTabType.SvRelaTabTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSV_RelaTabType.SvRelaTabTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conSV_RelaTabType.Memo, Type.GetType("System.String"));
foreach (clsSV_RelaTabTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSV_RelaTabType.SvRelaTabTypeId] = objInFor[conSV_RelaTabType.SvRelaTabTypeId];
objDR[conSV_RelaTabType.SvRelaTabTypeName] = objInFor[conSV_RelaTabType.SvRelaTabTypeName];
objDR[conSV_RelaTabType.Memo] = objInFor[conSV_RelaTabType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Sql视图相关表类型(SV_RelaTabType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SV_RelaTabType : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSV_RelaTabTypeWApi.ReFreshThisCache();
}
}

}