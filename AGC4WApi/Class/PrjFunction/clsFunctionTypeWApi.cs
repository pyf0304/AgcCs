
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTypeWApi
 表名:FunctionType(00050063)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:55
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsFunctionTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeId">函数类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeId(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conFunctionType.FuncTypeId);
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conFunctionType.FuncTypeId);
objFunctionTypeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeId) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeId, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeId] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeName">函数类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeName(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, conFunctionType.FuncTypeName);
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, conFunctionType.FuncTypeName);
objFunctionTypeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeName) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeName, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeName] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncTypeENName">函数类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetFuncTypeENName(this clsFunctionTypeEN objFunctionTypeEN, string strFuncTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncTypeENName, 50, conFunctionType.FuncTypeENName);
objFunctionTypeEN.FuncTypeENName = strFuncTypeENName; //函数类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.FuncTypeENName) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.FuncTypeENName, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.FuncTypeENName] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetCodeTypeId(this clsFunctionTypeEN objFunctionTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conFunctionType.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conFunctionType.CodeTypeId);
objFunctionTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.CodeTypeId) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.CodeTypeId, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.CodeTypeId] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTypeEN SetMemo(this clsFunctionTypeEN objFunctionTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionType.Memo);
objFunctionTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTypeEN.dicFldComparisonOp.ContainsKey(conFunctionType.Memo) == false)
{
objFunctionTypeEN.dicFldComparisonOp.Add(conFunctionType.Memo, strComparisonOp);
}
else
{
objFunctionTypeEN.dicFldComparisonOp[conFunctionType.Memo] = strComparisonOp;
}
}
return objFunctionTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionTypeEN objFunctionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeId, objFunctionTypeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeName, objFunctionTypeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.FuncTypeENName) == true)
{
string strComparisonOpFuncTypeENName = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.FuncTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.FuncTypeENName, objFunctionTypeCond.FuncTypeENName, strComparisonOpFuncTypeENName);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.CodeTypeId, objFunctionTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objFunctionTypeCond.IsUpdated(conFunctionType.Memo) == true)
{
string strComparisonOpMemo = objFunctionTypeCond.dicFldComparisonOp[conFunctionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionType.Memo, objFunctionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTypeEN objFunctionTypeEN)
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunctionTypeEN.sfUpdFldSetStr = objFunctionTypeEN.getsfUpdFldSetStr();
clsFunctionTypeWApi.CheckPropertyNew(objFunctionTypeEN); 
bool bolResult = clsFunctionTypeWApi.UpdateRecord(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--FunctionType(函数类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFunctionTypeEN objFunctionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTypeEN == null) return "";
if (objFunctionTypeEN.FuncTypeId == null || objFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objFunctionTypeEN.FuncTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionTypeEN objFunctionTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionTypeEN.FuncTypeId) == true || clsFunctionTypeWApi.IsExist(objFunctionTypeEN.FuncTypeId) == true)
 {
     objFunctionTypeEN.FuncTypeId = clsFunctionTypeWApi.GetMaxStrId();
 }
clsFunctionTypeWApi.CheckPropertyNew(objFunctionTypeEN); 
bool bolResult = clsFunctionTypeWApi.AddNewRecord(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
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
 /// <param name = "objFunctionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionTypeEN objFunctionTypeEN)
{
try
{
clsFunctionTypeWApi.CheckPropertyNew(objFunctionTypeEN); 
string strFuncTypeId = clsFunctionTypeWApi.AddNewRecordWithMaxId(objFunctionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
return strFuncTypeId;
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
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTypeEN objFunctionTypeEN, string strWhereCond)
{
try
{
clsFunctionTypeWApi.CheckPropertyNew(objFunctionTypeEN); 
bool bolResult = clsFunctionTypeWApi.UpdateWithCondition(objFunctionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
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
public class enumFunctionTypeWA
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 工程私有函数
 /// </summary>
public const string EngineeringPrivateFunctions_06 = "06";
 /// <summary>
 /// 公共函数
 /// </summary>
public const string PublicFunction_07 = "07";
 /// <summary>
 /// 模板函数
 /// </summary>
public const string TemplateFunction_08 = "08";
 /// <summary>
 /// 系统函数
 /// </summary>
public const string SystemFunction_09 = "09";
 /// <summary>
 /// 用户定义函数
 /// </summary>
public const string UserDefinedFunctions_10 = "10";
 /// <summary>
 /// 界面后台函数
 /// </summary>
public const string ViewBackgroundFunction_11 = "11";
 /// <summary>
 /// 纯静态函数
 /// </summary>
public const string PureStaticFunction_12 = "12";
 /// <summary>
 /// 扩展生成函数
 /// </summary>
public const string ExGCFunc_13 = "13";
 /// <summary>
 /// 泛型函数
 /// </summary>
public const string GenericFunctions_14 = "14";
 /// <summary>
 /// 类静态函数
 /// </summary>
public const string ClassStaticFunction_15 = "15";
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunctionTypeWApi
{
private static readonly string mstrApiControllerName = "FunctionTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFunctionTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数类型]...","0");
List<clsFunctionTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncTypeId";
objDDL.DataTextField="FuncTypeName";
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

public static void BindCbo_FuncTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionType.FuncTypeId); 
List<clsFunctionTypeEN> arrObjLst = clsFunctionTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionTypeEN objFunctionTypeEN = new clsFunctionTypeEN()
{
FuncTypeId = "0",
FuncTypeName = "选[函数类型]..."
};
arrObjLst.Insert(0, objFunctionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionType.FuncTypeId;
objComboBox.DisplayMember = conFunctionType.FuncTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunctionTypeEN objFunctionTypeEN)
{
if (!Object.Equals(null, objFunctionTypeEN.FuncTypeId) && GetStrLen(objFunctionTypeEN.FuncTypeId) > 2)
{
 throw new Exception("字段[函数类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunctionTypeEN.FuncTypeName) && GetStrLen(objFunctionTypeEN.FuncTypeName) > 20)
{
 throw new Exception("字段[函数类型名]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionTypeEN.FuncTypeENName) && GetStrLen(objFunctionTypeEN.FuncTypeENName) > 50)
{
 throw new Exception("字段[函数类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionTypeEN.CodeTypeId) && GetStrLen(objFunctionTypeEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunctionTypeEN.Memo) && GetStrLen(objFunctionTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFunctionTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTypeEN GetObjByFuncTypeId(string strFuncTypeId)
{
if (strFuncTypeId == "") return null;
string strAction = "GetObjByFuncTypeId";
clsFunctionTypeEN objFunctionTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncTypeId"] = strFuncTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFunctionTypeEN = JsonConvert.DeserializeObject<clsFunctionTypeEN>(strJson);
return objFunctionTypeEN;
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
public static clsFunctionTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFunctionTypeEN objFunctionTypeEN;
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
objFunctionTypeEN = JsonConvert.DeserializeObject<clsFunctionTypeEN>(strJson);
return objFunctionTypeEN;
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
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTypeEN GetObjByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel =
from objFunctionTypeEN in arrFunctionTypeObjLstCache
where objFunctionTypeEN.FuncTypeId == strFuncTypeId 
select objFunctionTypeEN;
if (arrFunctionTypeObjLst_Sel.Count() == 0)
{
   clsFunctionTypeEN obj = clsFunctionTypeWApi.GetObjByFuncTypeId(strFuncTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunctionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncTypeNameByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return "";
//初始化列表缓存
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel1 =
from objFunctionTypeEN in arrFunctionTypeObjLstCache
where objFunctionTypeEN.FuncTypeId == strFuncTypeId 
select objFunctionTypeEN;
List <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel = new List<clsFunctionTypeEN>();
foreach (clsFunctionTypeEN obj in arrFunctionTypeObjLst_Sel1)
{
arrFunctionTypeObjLst_Sel.Add(obj);
}
if (arrFunctionTypeObjLst_Sel.Count > 0)
{
return arrFunctionTypeObjLst_Sel[0].FuncTypeName;
}
string strErrMsgForGetObjById = string.Format("在FunctionType对象缓存列表中,找不到记录[FuncTypeId = {0}](函数:{1})", strFuncTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncTypeIdCache(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true) return "";
//初始化列表缓存
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel1 =
from objFunctionTypeEN in arrFunctionTypeObjLstCache
where objFunctionTypeEN.FuncTypeId == strFuncTypeId 
select objFunctionTypeEN;
List <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel = new List<clsFunctionTypeEN>();
foreach (clsFunctionTypeEN obj in arrFunctionTypeObjLst_Sel1)
{
arrFunctionTypeObjLst_Sel.Add(obj);
}
if (arrFunctionTypeObjLst_Sel.Count > 0)
{
return arrFunctionTypeObjLst_Sel[0].FuncTypeName;
}
string strErrMsgForGetObjById = string.Format("在FunctionType对象缓存列表中,找不到记录的相关名称[FuncTypeId = {0}](函数:{1})", strFuncTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLst(string strWhereCond)
{
 List<clsFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
 /// <param name = "arrFuncTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstByFuncTypeIdLst(List<string> arrFuncTypeId)
{
 List<clsFunctionTypeEN> arrObjLst; 
string strAction = "GetObjLstByFuncTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
 /// <param name = "arrFuncTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFunctionTypeEN> GetObjLstByFuncTypeIdLstCache(List<string> arrFuncTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTypeEN> arrFunctionTypeObjLst_Sel =
from objFunctionTypeEN in arrFunctionTypeObjLstCache
where arrFuncTypeId.Contains(objFunctionTypeEN.FuncTypeId)
select objFunctionTypeEN;
return arrFunctionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
public static List<clsFunctionTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
public static List<clsFunctionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
public static List<clsFunctionTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFunctionTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionTypeEN>>(strJson);
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
public static int DelRecord(string strFuncTypeId)
{
string strAction = "DelRecord";
try
{
 clsFunctionTypeEN objFunctionTypeEN = clsFunctionTypeWApi.GetObjByFuncTypeId(strFuncTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionTypeWApi.ReFreshCache();
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
public static int DelFunctionTypes(List<string> arrFuncTypeId)
{
string strAction = "DelFunctionTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionTypeWApi.ReFreshCache();
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
public static int DelFunctionTypesByCond(string strWhereCond)
{
string strAction = "DelFunctionTypesByCond";
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
public static bool AddNewRecord(clsFunctionTypeEN objFunctionTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTypeEN>(objFunctionTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsFunctionTypeEN objFunctionTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTypeEN>(objFunctionTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTypeWApi.ReFreshCache();
var strFuncTypeId = (string)jobjReturn0["returnStr"];
return strFuncTypeId;
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
public static bool UpdateRecord(clsFunctionTypeEN objFunctionTypeEN)
{
if (string.IsNullOrEmpty(objFunctionTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTypeEN.FuncTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTypeEN>(objFunctionTypeEN);
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
 /// <param name = "objFunctionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunctionTypeEN objFunctionTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunctionTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTypeEN.FuncTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionTypeEN.FuncTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionTypeEN>(objFunctionTypeEN);
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
public static bool IsExist(string strFuncTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncTypeId"] = strFuncTypeId
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
 /// <param name = "objFunctionTypeENS">源对象</param>
 /// <param name = "objFunctionTypeENT">目标对象</param>
 public static void CopyTo(clsFunctionTypeEN objFunctionTypeENS, clsFunctionTypeEN objFunctionTypeENT)
{
try
{
objFunctionTypeENT.FuncTypeId = objFunctionTypeENS.FuncTypeId; //函数类型Id
objFunctionTypeENT.FuncTypeName = objFunctionTypeENS.FuncTypeName; //函数类型名
objFunctionTypeENT.FuncTypeENName = objFunctionTypeENS.FuncTypeENName; //函数类型英文名
objFunctionTypeENT.CodeTypeId = objFunctionTypeENS.CodeTypeId; //代码类型Id
objFunctionTypeENT.Memo = objFunctionTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFunctionTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunctionTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunctionTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunctionTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunctionTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunctionTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
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
if (clsFunctionTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsFunctionTypeEN._CurrTabName;
List<clsFunctionTypeEN> arrFunctionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFunctionTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunctionTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunctionType.FuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionType.FuncTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionType.FuncTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionType.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionType.Memo, Type.GetType("System.String"));
foreach (clsFunctionTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunctionType.FuncTypeId] = objInFor[conFunctionType.FuncTypeId];
objDR[conFunctionType.FuncTypeName] = objInFor[conFunctionType.FuncTypeName];
objDR[conFunctionType.FuncTypeENName] = objInFor[conFunctionType.FuncTypeENName];
objDR[conFunctionType.CodeTypeId] = objInFor[conFunctionType.CodeTypeId];
objDR[conFunctionType.Memo] = objInFor[conFunctionType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数类型(FunctionType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FunctionType : clsCommFun4BL
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
clsFunctionTypeWApi.ReFreshThisCache();
}
}

}