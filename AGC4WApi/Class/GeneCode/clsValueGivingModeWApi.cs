
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsValueGivingModeWApi
 表名:ValueGivingMode(00050462)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsValueGivingModeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsValueGivingModeEN SetValueGivingModeId(this clsValueGivingModeEN objValueGivingModeEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, conValueGivingMode.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, conValueGivingMode.ValueGivingModeId);
objValueGivingModeEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objValueGivingModeEN.dicFldComparisonOp.ContainsKey(conValueGivingMode.ValueGivingModeId) == false)
{
objValueGivingModeEN.dicFldComparisonOp.Add(conValueGivingMode.ValueGivingModeId, strComparisonOp);
}
else
{
objValueGivingModeEN.dicFldComparisonOp[conValueGivingMode.ValueGivingModeId] = strComparisonOp;
}
}
return objValueGivingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeName">给值方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsValueGivingModeEN SetValueGivingModeName(this clsValueGivingModeEN objValueGivingModeEN, string strValueGivingModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strValueGivingModeName, conValueGivingMode.ValueGivingModeName);
clsCheckSql.CheckFieldLen(strValueGivingModeName, 50, conValueGivingMode.ValueGivingModeName);
objValueGivingModeEN.ValueGivingModeName = strValueGivingModeName; //给值方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objValueGivingModeEN.dicFldComparisonOp.ContainsKey(conValueGivingMode.ValueGivingModeName) == false)
{
objValueGivingModeEN.dicFldComparisonOp.Add(conValueGivingMode.ValueGivingModeName, strComparisonOp);
}
else
{
objValueGivingModeEN.dicFldComparisonOp[conValueGivingMode.ValueGivingModeName] = strComparisonOp;
}
}
return objValueGivingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeENName">给值方式英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsValueGivingModeEN SetValueGivingModeENName(this clsValueGivingModeEN objValueGivingModeEN, string strValueGivingModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeENName, 50, conValueGivingMode.ValueGivingModeENName);
objValueGivingModeEN.ValueGivingModeENName = strValueGivingModeENName; //给值方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objValueGivingModeEN.dicFldComparisonOp.ContainsKey(conValueGivingMode.ValueGivingModeENName) == false)
{
objValueGivingModeEN.dicFldComparisonOp.Add(conValueGivingMode.ValueGivingModeENName, strComparisonOp);
}
else
{
objValueGivingModeEN.dicFldComparisonOp[conValueGivingMode.ValueGivingModeENName] = strComparisonOp;
}
}
return objValueGivingModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsValueGivingModeEN SetMemo(this clsValueGivingModeEN objValueGivingModeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conValueGivingMode.Memo);
objValueGivingModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objValueGivingModeEN.dicFldComparisonOp.ContainsKey(conValueGivingMode.Memo) == false)
{
objValueGivingModeEN.dicFldComparisonOp.Add(conValueGivingMode.Memo, strComparisonOp);
}
else
{
objValueGivingModeEN.dicFldComparisonOp[conValueGivingMode.Memo] = strComparisonOp;
}
}
return objValueGivingModeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsValueGivingModeEN objValueGivingModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objValueGivingModeCond.IsUpdated(conValueGivingMode.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objValueGivingModeCond.dicFldComparisonOp[conValueGivingMode.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conValueGivingMode.ValueGivingModeId, objValueGivingModeCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objValueGivingModeCond.IsUpdated(conValueGivingMode.ValueGivingModeName) == true)
{
string strComparisonOpValueGivingModeName = objValueGivingModeCond.dicFldComparisonOp[conValueGivingMode.ValueGivingModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conValueGivingMode.ValueGivingModeName, objValueGivingModeCond.ValueGivingModeName, strComparisonOpValueGivingModeName);
}
if (objValueGivingModeCond.IsUpdated(conValueGivingMode.ValueGivingModeENName) == true)
{
string strComparisonOpValueGivingModeENName = objValueGivingModeCond.dicFldComparisonOp[conValueGivingMode.ValueGivingModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conValueGivingMode.ValueGivingModeENName, objValueGivingModeCond.ValueGivingModeENName, strComparisonOpValueGivingModeENName);
}
if (objValueGivingModeCond.IsUpdated(conValueGivingMode.Memo) == true)
{
string strComparisonOpMemo = objValueGivingModeCond.dicFldComparisonOp[conValueGivingMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conValueGivingMode.Memo, objValueGivingModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsValueGivingModeEN objValueGivingModeEN)
{
 if (string.IsNullOrEmpty(objValueGivingModeEN.ValueGivingModeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objValueGivingModeEN.sfUpdFldSetStr = objValueGivingModeEN.getsfUpdFldSetStr();
clsValueGivingModeWApi.CheckPropertyNew(objValueGivingModeEN); 
bool bolResult = clsValueGivingModeWApi.UpdateRecord(objValueGivingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ValueGivingMode(给值方式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ValueGivingModeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objValueGivingModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsValueGivingModeEN objValueGivingModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objValueGivingModeEN == null) return "";
if (objValueGivingModeEN.ValueGivingModeId == null || objValueGivingModeEN.ValueGivingModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ValueGivingModeName = '{0}'", objValueGivingModeEN.ValueGivingModeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ValueGivingModeId !=  '{0}'", objValueGivingModeEN.ValueGivingModeId);
 sbCondition.AppendFormat(" and ValueGivingModeName = '{0}'", objValueGivingModeEN.ValueGivingModeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objValueGivingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsValueGivingModeEN objValueGivingModeEN)
{
try
{
 if (string.IsNullOrEmpty(objValueGivingModeEN.ValueGivingModeId) == true || clsValueGivingModeWApi.IsExist(objValueGivingModeEN.ValueGivingModeId) == true)
 {
     objValueGivingModeEN.ValueGivingModeId = clsValueGivingModeWApi.GetMaxStrId();
 }
clsValueGivingModeWApi.CheckPropertyNew(objValueGivingModeEN); 
bool bolResult = clsValueGivingModeWApi.AddNewRecord(objValueGivingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
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
 /// <param name = "objValueGivingModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsValueGivingModeEN objValueGivingModeEN)
{
try
{
clsValueGivingModeWApi.CheckPropertyNew(objValueGivingModeEN); 
string strValueGivingModeId = clsValueGivingModeWApi.AddNewRecordWithMaxId(objValueGivingModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
return strValueGivingModeId;
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
 /// <param name = "objValueGivingModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsValueGivingModeEN objValueGivingModeEN, string strWhereCond)
{
try
{
clsValueGivingModeWApi.CheckPropertyNew(objValueGivingModeEN); 
bool bolResult = clsValueGivingModeWApi.UpdateWithCondition(objValueGivingModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumValueGivingModeWA
{
 /// <summary>
 /// 缺省值
 /// </summary>
public const string DefaultValue_01 = "01";
 /// <summary>
 /// 给定值
 /// </summary>
public const string GivenValue_02 = "02";
}
 /// <summary>
 /// 给值方式(ValueGivingMode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsValueGivingModeWApi
{
private static readonly string mstrApiControllerName = "ValueGivingModeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsValueGivingModeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ValueGivingModeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[给值方式]...","0");
List<clsValueGivingModeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ValueGivingModeId";
objDDL.DataTextField="ValueGivingModeName";
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

public static void BindCbo_ValueGivingModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conValueGivingMode.ValueGivingModeId); 
List<clsValueGivingModeEN> arrObjLst = clsValueGivingModeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsValueGivingModeEN objValueGivingModeEN = new clsValueGivingModeEN()
{
ValueGivingModeId = "0",
ValueGivingModeName = "选[给值方式]..."
};
arrObjLst.Insert(0, objValueGivingModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conValueGivingMode.ValueGivingModeId;
objComboBox.DisplayMember = conValueGivingMode.ValueGivingModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsValueGivingModeEN objValueGivingModeEN)
{
if (!Object.Equals(null, objValueGivingModeEN.ValueGivingModeId) && GetStrLen(objValueGivingModeEN.ValueGivingModeId) > 2)
{
 throw new Exception("字段[给值方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objValueGivingModeEN.ValueGivingModeName) && GetStrLen(objValueGivingModeEN.ValueGivingModeName) > 50)
{
 throw new Exception("字段[给值方式名]的长度不能超过50!");
}
if (!Object.Equals(null, objValueGivingModeEN.ValueGivingModeENName) && GetStrLen(objValueGivingModeEN.ValueGivingModeENName) > 50)
{
 throw new Exception("字段[给值方式英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objValueGivingModeEN.Memo) && GetStrLen(objValueGivingModeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objValueGivingModeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strValueGivingModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsValueGivingModeEN GetObjByValueGivingModeId(string strValueGivingModeId)
{
if (strValueGivingModeId == "") return null;
string strAction = "GetObjByValueGivingModeId";
clsValueGivingModeEN objValueGivingModeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strValueGivingModeId"] = strValueGivingModeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objValueGivingModeEN = JsonConvert.DeserializeObject<clsValueGivingModeEN>(strJson);
return objValueGivingModeEN;
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
public static clsValueGivingModeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsValueGivingModeEN objValueGivingModeEN;
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
objValueGivingModeEN = JsonConvert.DeserializeObject<clsValueGivingModeEN>(strJson);
return objValueGivingModeEN;
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
 /// <param name = "strValueGivingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsValueGivingModeEN GetObjByValueGivingModeIdCache(string strValueGivingModeId)
{
if (string.IsNullOrEmpty(strValueGivingModeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsValueGivingModeEN._CurrTabName);
List<clsValueGivingModeEN> arrValueGivingModeObjLstCache = GetObjLstCache();
IEnumerable <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel =
from objValueGivingModeEN in arrValueGivingModeObjLstCache
where objValueGivingModeEN.ValueGivingModeId == strValueGivingModeId 
select objValueGivingModeEN;
if (arrValueGivingModeObjLst_Sel.Count() == 0)
{
   clsValueGivingModeEN obj = clsValueGivingModeWApi.GetObjByValueGivingModeId(strValueGivingModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrValueGivingModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strValueGivingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetValueGivingModeNameByValueGivingModeIdCache(string strValueGivingModeId)
{
if (string.IsNullOrEmpty(strValueGivingModeId) == true) return "";
//初始化列表缓存
List<clsValueGivingModeEN> arrValueGivingModeObjLstCache = GetObjLstCache();
IEnumerable <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel1 =
from objValueGivingModeEN in arrValueGivingModeObjLstCache
where objValueGivingModeEN.ValueGivingModeId == strValueGivingModeId 
select objValueGivingModeEN;
List <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel = new List<clsValueGivingModeEN>();
foreach (clsValueGivingModeEN obj in arrValueGivingModeObjLst_Sel1)
{
arrValueGivingModeObjLst_Sel.Add(obj);
}
if (arrValueGivingModeObjLst_Sel.Count > 0)
{
return arrValueGivingModeObjLst_Sel[0].ValueGivingModeName;
}
string strErrMsgForGetObjById = string.Format("在ValueGivingMode对象缓存列表中,找不到记录[ValueGivingModeId = {0}](函数:{1})", strValueGivingModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsValueGivingModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strValueGivingModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByValueGivingModeIdCache(string strValueGivingModeId)
{
if (string.IsNullOrEmpty(strValueGivingModeId) == true) return "";
//初始化列表缓存
List<clsValueGivingModeEN> arrValueGivingModeObjLstCache = GetObjLstCache();
IEnumerable <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel1 =
from objValueGivingModeEN in arrValueGivingModeObjLstCache
where objValueGivingModeEN.ValueGivingModeId == strValueGivingModeId 
select objValueGivingModeEN;
List <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel = new List<clsValueGivingModeEN>();
foreach (clsValueGivingModeEN obj in arrValueGivingModeObjLst_Sel1)
{
arrValueGivingModeObjLst_Sel.Add(obj);
}
if (arrValueGivingModeObjLst_Sel.Count > 0)
{
return arrValueGivingModeObjLst_Sel[0].ValueGivingModeName;
}
string strErrMsgForGetObjById = string.Format("在ValueGivingMode对象缓存列表中,找不到记录的相关名称[ValueGivingModeId = {0}](函数:{1})", strValueGivingModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsValueGivingModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsValueGivingModeEN> GetObjLst(string strWhereCond)
{
 List<clsValueGivingModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
 /// <param name = "arrValueGivingModeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsValueGivingModeEN> GetObjLstByValueGivingModeIdLst(List<string> arrValueGivingModeId)
{
 List<clsValueGivingModeEN> arrObjLst; 
string strAction = "GetObjLstByValueGivingModeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrValueGivingModeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
 /// <param name = "arrValueGivingModeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsValueGivingModeEN> GetObjLstByValueGivingModeIdLstCache(List<string> arrValueGivingModeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsValueGivingModeEN._CurrTabName);
List<clsValueGivingModeEN> arrValueGivingModeObjLstCache = GetObjLstCache();
IEnumerable <clsValueGivingModeEN> arrValueGivingModeObjLst_Sel =
from objValueGivingModeEN in arrValueGivingModeObjLstCache
where arrValueGivingModeId.Contains(objValueGivingModeEN.ValueGivingModeId)
select objValueGivingModeEN;
return arrValueGivingModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsValueGivingModeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsValueGivingModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
public static List<clsValueGivingModeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsValueGivingModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
public static List<clsValueGivingModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsValueGivingModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
public static List<clsValueGivingModeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsValueGivingModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsValueGivingModeEN>>(strJson);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strValueGivingModeId)
{
string strAction = "DelRecord";
try
{
 clsValueGivingModeEN objValueGivingModeEN = clsValueGivingModeWApi.GetObjByValueGivingModeId(strValueGivingModeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strValueGivingModeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsValueGivingModeWApi.ReFreshCache();
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
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
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
public static int DelValueGivingModes(List<string> arrValueGivingModeId)
{
string strAction = "DelValueGivingModes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrValueGivingModeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsValueGivingModeWApi.ReFreshCache();
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
public static int DelValueGivingModesByCond(string strWhereCond)
{
string strAction = "DelValueGivingModesByCond";
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
public static bool AddNewRecord(clsValueGivingModeEN objValueGivingModeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsValueGivingModeEN>(objValueGivingModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
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
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsValueGivingModeEN objValueGivingModeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsValueGivingModeEN>(objValueGivingModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsValueGivingModeWApi.ReFreshCache();
var strValueGivingModeId = (string)jobjReturn0["returnStr"];
return strValueGivingModeId;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsValueGivingModeEN objValueGivingModeEN)
{
if (string.IsNullOrEmpty(objValueGivingModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objValueGivingModeEN.ValueGivingModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsValueGivingModeEN>(objValueGivingModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
 /// <param name = "objValueGivingModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsValueGivingModeEN objValueGivingModeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objValueGivingModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objValueGivingModeEN.ValueGivingModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objValueGivingModeEN.ValueGivingModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsValueGivingModeEN>(objValueGivingModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
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
public static bool IsExist(string strValueGivingModeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strValueGivingModeId"] = strValueGivingModeId
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
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
 /// <param name = "objValueGivingModeENS">源对象</param>
 /// <param name = "objValueGivingModeENT">目标对象</param>
 public static void CopyTo(clsValueGivingModeEN objValueGivingModeENS, clsValueGivingModeEN objValueGivingModeENT)
{
try
{
objValueGivingModeENT.ValueGivingModeId = objValueGivingModeENS.ValueGivingModeId; //给值方式Id
objValueGivingModeENT.ValueGivingModeName = objValueGivingModeENS.ValueGivingModeName; //给值方式名
objValueGivingModeENT.ValueGivingModeENName = objValueGivingModeENS.ValueGivingModeENName; //给值方式英文名
objValueGivingModeENT.Memo = objValueGivingModeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsValueGivingModeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsValueGivingModeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsValueGivingModeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsValueGivingModeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsValueGivingModeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsValueGivingModeEN._AttributeName)
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
string strKey = string.Format("{0}", clsValueGivingModeEN._CurrTabName);
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
if (clsValueGivingModeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsValueGivingModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsValueGivingModeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsValueGivingModeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsValueGivingModeEN._CurrTabName;
List<clsValueGivingModeEN> arrValueGivingModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrValueGivingModeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsValueGivingModeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conValueGivingMode.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(conValueGivingMode.ValueGivingModeName, Type.GetType("System.String"));
objDT.Columns.Add(conValueGivingMode.ValueGivingModeENName, Type.GetType("System.String"));
objDT.Columns.Add(conValueGivingMode.Memo, Type.GetType("System.String"));
foreach (clsValueGivingModeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conValueGivingMode.ValueGivingModeId] = objInFor[conValueGivingMode.ValueGivingModeId];
objDR[conValueGivingMode.ValueGivingModeName] = objInFor[conValueGivingMode.ValueGivingModeName];
objDR[conValueGivingMode.ValueGivingModeENName] = objInFor[conValueGivingMode.ValueGivingModeENName];
objDR[conValueGivingMode.Memo] = objInFor[conValueGivingMode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 给值方式(ValueGivingMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ValueGivingMode : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
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
clsValueGivingModeWApi.ReFreshThisCache();
}
}

}