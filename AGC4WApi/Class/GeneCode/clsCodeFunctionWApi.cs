
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeFunctionWApi
 表名:CodeFunction(00050439)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:02
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
public static class  clsCodeFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeFuncId">代码函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetCodeFuncId(this clsCodeFunctionEN objCodeFunctionEN, string strCodeFuncId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeFuncId, 4, conCodeFunction.CodeFuncId);
clsCheckSql.CheckFieldForeignKey(strCodeFuncId, 4, conCodeFunction.CodeFuncId);
objCodeFunctionEN.CodeFuncId = strCodeFuncId; //代码函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.CodeFuncId) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.CodeFuncId, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.CodeFuncId] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeFuncName">代码函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetCodeFuncName(this clsCodeFunctionEN objCodeFunctionEN, string strCodeFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeFuncName, 50, conCodeFunction.CodeFuncName);
objCodeFunctionEN.CodeFuncName = strCodeFuncName; //代码函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.CodeFuncName) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.CodeFuncName, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.CodeFuncName] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncSignature">函数签名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetFuncSignature(this clsCodeFunctionEN objCodeFunctionEN, string strFuncSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncSignature, 300, conCodeFunction.FuncSignature);
objCodeFunctionEN.FuncSignature = strFuncSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.FuncSignature) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.FuncSignature, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.FuncSignature] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetUpdDate(this clsCodeFunctionEN objCodeFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCodeFunction.UpdDate);
objCodeFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.UpdDate) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.UpdDate, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.UpdDate] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetUpdUser(this clsCodeFunctionEN objCodeFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCodeFunction.UpdUser);
objCodeFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.UpdUser) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.UpdUser, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.UpdUser] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCodeFunctionEN SetMemo(this clsCodeFunctionEN objCodeFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCodeFunction.Memo);
objCodeFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCodeFunctionEN.dicFldComparisonOp.ContainsKey(conCodeFunction.Memo) == false)
{
objCodeFunctionEN.dicFldComparisonOp.Add(conCodeFunction.Memo, strComparisonOp);
}
else
{
objCodeFunctionEN.dicFldComparisonOp[conCodeFunction.Memo] = strComparisonOp;
}
}
return objCodeFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCodeFunctionEN objCodeFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCodeFunctionCond.IsUpdated(conCodeFunction.CodeFuncId) == true)
{
string strComparisonOpCodeFuncId = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.CodeFuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.CodeFuncId, objCodeFunctionCond.CodeFuncId, strComparisonOpCodeFuncId);
}
if (objCodeFunctionCond.IsUpdated(conCodeFunction.CodeFuncName) == true)
{
string strComparisonOpCodeFuncName = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.CodeFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.CodeFuncName, objCodeFunctionCond.CodeFuncName, strComparisonOpCodeFuncName);
}
if (objCodeFunctionCond.IsUpdated(conCodeFunction.FuncSignature) == true)
{
string strComparisonOpFuncSignature = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.FuncSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.FuncSignature, objCodeFunctionCond.FuncSignature, strComparisonOpFuncSignature);
}
if (objCodeFunctionCond.IsUpdated(conCodeFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.UpdDate, objCodeFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objCodeFunctionCond.IsUpdated(conCodeFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.UpdUser, objCodeFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objCodeFunctionCond.IsUpdated(conCodeFunction.Memo) == true)
{
string strComparisonOpMemo = objCodeFunctionCond.dicFldComparisonOp[conCodeFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCodeFunction.Memo, objCodeFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCodeFunctionEN objCodeFunctionEN)
{
 if (string.IsNullOrEmpty(objCodeFunctionEN.CodeFuncId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCodeFunctionEN.sfUpdFldSetStr = objCodeFunctionEN.getsfUpdFldSetStr();
clsCodeFunctionWApi.CheckPropertyNew(objCodeFunctionEN); 
bool bolResult = clsCodeFunctionWApi.UpdateRecord(objCodeFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCodeFunctionEN objCodeFunctionEN)
{
 if (string.IsNullOrEmpty(objCodeFunctionEN.CodeFuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCodeFunctionWApi.IsExist(objCodeFunctionEN.CodeFuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCodeFunctionEN.CodeFuncId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsCodeFunctionWApi.CheckPropertyNew(objCodeFunctionEN); 
bool bolResult = clsCodeFunctionWApi.AddNewRecord(objCodeFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
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
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCodeFunctionEN objCodeFunctionEN)
{
try
{
clsCodeFunctionWApi.CheckPropertyNew(objCodeFunctionEN); 
string strCodeFuncId = clsCodeFunctionWApi.AddNewRecordWithMaxId(objCodeFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
return strCodeFuncId;
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
 /// <param name = "objCodeFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCodeFunctionEN objCodeFunctionEN, string strWhereCond)
{
try
{
clsCodeFunctionWApi.CheckPropertyNew(objCodeFunctionEN); 
bool bolResult = clsCodeFunctionWApi.UpdateWithCondition(objCodeFunctionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
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
 /// 代码函数(CodeFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCodeFunctionWApi
{
private static readonly string mstrApiControllerName = "CodeFunctionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCodeFunctionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_CodeFuncId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[代码函数]...","0");
List<clsCodeFunctionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="CodeFuncId";
objDDL.DataTextField="CodeFuncName";
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

public static void BindCbo_CodeFuncId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCodeFunction.CodeFuncId); 
List<clsCodeFunctionEN> arrObjLst = clsCodeFunctionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN()
{
CodeFuncId = "0",
CodeFuncName = "选[代码函数]..."
};
arrObjLst.Insert(0, objCodeFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCodeFunction.CodeFuncId;
objComboBox.DisplayMember = conCodeFunction.CodeFuncName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCodeFunctionEN objCodeFunctionEN)
{
if (!Object.Equals(null, objCodeFunctionEN.CodeFuncId) && GetStrLen(objCodeFunctionEN.CodeFuncId) > 4)
{
 throw new Exception("字段[代码函数Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCodeFunctionEN.CodeFuncName) && GetStrLen(objCodeFunctionEN.CodeFuncName) > 50)
{
 throw new Exception("字段[代码函数名]的长度不能超过50!");
}
if (!Object.Equals(null, objCodeFunctionEN.FuncSignature) && GetStrLen(objCodeFunctionEN.FuncSignature) > 300)
{
 throw new Exception("字段[函数签名]的长度不能超过300!");
}
if (!Object.Equals(null, objCodeFunctionEN.UpdDate) && GetStrLen(objCodeFunctionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCodeFunctionEN.UpdUser) && GetStrLen(objCodeFunctionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCodeFunctionEN.Memo) && GetStrLen(objCodeFunctionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCodeFunctionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCodeFunctionEN GetObjByCodeFuncId(string strCodeFuncId)
{
if (strCodeFuncId == "") return null;
string strAction = "GetObjByCodeFuncId";
clsCodeFunctionEN objCodeFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeFuncId"] = strCodeFuncId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCodeFunctionEN = JsonConvert.DeserializeObject<clsCodeFunctionEN>(strJson);
return objCodeFunctionEN;
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
public static clsCodeFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCodeFunctionEN objCodeFunctionEN;
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
objCodeFunctionEN = JsonConvert.DeserializeObject<clsCodeFunctionEN>(strJson);
return objCodeFunctionEN;
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
 /// <param name = "strCodeFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCodeFunctionEN GetObjByCodeFuncIdCache(string strCodeFuncId)
{
if (string.IsNullOrEmpty(strCodeFuncId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsCodeFunctionEN._CurrTabName);
List<clsCodeFunctionEN> arrCodeFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel =
from objCodeFunctionEN in arrCodeFunctionObjLstCache
where objCodeFunctionEN.CodeFuncId == strCodeFuncId 
select objCodeFunctionEN;
if (arrCodeFunctionObjLst_Sel.Count() == 0)
{
   clsCodeFunctionEN obj = clsCodeFunctionWApi.GetObjByCodeFuncId(strCodeFuncId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCodeFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCodeFuncNameByCodeFuncIdCache(string strCodeFuncId)
{
if (string.IsNullOrEmpty(strCodeFuncId) == true) return "";
//初始化列表缓存
List<clsCodeFunctionEN> arrCodeFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel1 =
from objCodeFunctionEN in arrCodeFunctionObjLstCache
where objCodeFunctionEN.CodeFuncId == strCodeFuncId 
select objCodeFunctionEN;
List <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel = new List<clsCodeFunctionEN>();
foreach (clsCodeFunctionEN obj in arrCodeFunctionObjLst_Sel1)
{
arrCodeFunctionObjLst_Sel.Add(obj);
}
if (arrCodeFunctionObjLst_Sel.Count > 0)
{
return arrCodeFunctionObjLst_Sel[0].CodeFuncName;
}
string strErrMsgForGetObjById = string.Format("在CodeFunction对象缓存列表中,找不到记录[CodeFuncId = {0}](函数:{1})", strCodeFuncId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCodeFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCodeFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCodeFuncIdCache(string strCodeFuncId)
{
if (string.IsNullOrEmpty(strCodeFuncId) == true) return "";
//初始化列表缓存
List<clsCodeFunctionEN> arrCodeFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel1 =
from objCodeFunctionEN in arrCodeFunctionObjLstCache
where objCodeFunctionEN.CodeFuncId == strCodeFuncId 
select objCodeFunctionEN;
List <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel = new List<clsCodeFunctionEN>();
foreach (clsCodeFunctionEN obj in arrCodeFunctionObjLst_Sel1)
{
arrCodeFunctionObjLst_Sel.Add(obj);
}
if (arrCodeFunctionObjLst_Sel.Count > 0)
{
return arrCodeFunctionObjLst_Sel[0].CodeFuncName;
}
string strErrMsgForGetObjById = string.Format("在CodeFunction对象缓存列表中,找不到记录的相关名称[CodeFuncId = {0}](函数:{1})", strCodeFuncId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCodeFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsCodeFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
 /// <param name = "arrCodeFuncId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeFunctionEN> GetObjLstByCodeFuncIdLst(List<string> arrCodeFuncId)
{
 List<clsCodeFunctionEN> arrObjLst; 
string strAction = "GetObjLstByCodeFuncIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCodeFuncId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
 /// <param name = "arrCodeFuncId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCodeFunctionEN> GetObjLstByCodeFuncIdLstCache(List<string> arrCodeFuncId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCodeFunctionEN._CurrTabName);
List<clsCodeFunctionEN> arrCodeFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCodeFunctionEN> arrCodeFunctionObjLst_Sel =
from objCodeFunctionEN in arrCodeFunctionObjLstCache
where arrCodeFuncId.Contains(objCodeFunctionEN.CodeFuncId)
select objCodeFunctionEN;
return arrCodeFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCodeFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCodeFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
public static List<clsCodeFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCodeFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
public static List<clsCodeFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCodeFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
public static List<clsCodeFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCodeFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCodeFunctionEN>>(strJson);
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
public static int DelRecord(string strCodeFuncId)
{
string strAction = "DelRecord";
try
{
 clsCodeFunctionEN objCodeFunctionEN = clsCodeFunctionWApi.GetObjByCodeFuncId(strCodeFuncId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strCodeFuncId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCodeFunctionWApi.ReFreshCache();
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
public static int DelCodeFunctions(List<string> arrCodeFuncId)
{
string strAction = "DelCodeFunctions";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCodeFuncId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCodeFunctionWApi.ReFreshCache();
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
public static int DelCodeFunctionsByCond(string strWhereCond)
{
string strAction = "DelCodeFunctionsByCond";
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
public static bool AddNewRecord(clsCodeFunctionEN objCodeFunctionEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeFunctionEN>(objCodeFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsCodeFunctionEN objCodeFunctionEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeFunctionEN>(objCodeFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCodeFunctionWApi.ReFreshCache();
var strCodeFuncId = (string)jobjReturn0["returnStr"];
return strCodeFuncId;
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
public static bool UpdateRecord(clsCodeFunctionEN objCodeFunctionEN)
{
if (string.IsNullOrEmpty(objCodeFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeFunctionEN.CodeFuncId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeFunctionEN>(objCodeFunctionEN);
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
 /// <param name = "objCodeFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCodeFunctionEN objCodeFunctionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCodeFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeFunctionEN.CodeFuncId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCodeFunctionEN.CodeFuncId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCodeFunctionEN>(objCodeFunctionEN);
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
public static bool IsExist(string strCodeFuncId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strCodeFuncId"] = strCodeFuncId
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
 /// <param name = "objCodeFunctionENS">源对象</param>
 /// <param name = "objCodeFunctionENT">目标对象</param>
 public static void CopyTo(clsCodeFunctionEN objCodeFunctionENS, clsCodeFunctionEN objCodeFunctionENT)
{
try
{
objCodeFunctionENT.CodeFuncId = objCodeFunctionENS.CodeFuncId; //代码函数Id
objCodeFunctionENT.CodeFuncName = objCodeFunctionENS.CodeFuncName; //代码函数名
objCodeFunctionENT.FuncSignature = objCodeFunctionENS.FuncSignature; //函数签名
objCodeFunctionENT.UpdDate = objCodeFunctionENS.UpdDate; //修改日期
objCodeFunctionENT.UpdUser = objCodeFunctionENS.UpdUser; //修改者
objCodeFunctionENT.Memo = objCodeFunctionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCodeFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCodeFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCodeFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCodeFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCodeFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCodeFunctionEN._AttributeName)
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
string strKey = string.Format("{0}", clsCodeFunctionEN._CurrTabName);
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
if (clsCodeFunctionWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCodeFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCodeFunctionWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCodeFunctionEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsCodeFunctionEN._CurrTabName;
List<clsCodeFunctionEN> arrCodeFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCodeFunctionObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCodeFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCodeFunction.CodeFuncId, Type.GetType("System.String"));
objDT.Columns.Add(conCodeFunction.CodeFuncName, Type.GetType("System.String"));
objDT.Columns.Add(conCodeFunction.FuncSignature, Type.GetType("System.String"));
objDT.Columns.Add(conCodeFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCodeFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCodeFunction.Memo, Type.GetType("System.String"));
foreach (clsCodeFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCodeFunction.CodeFuncId] = objInFor[conCodeFunction.CodeFuncId];
objDR[conCodeFunction.CodeFuncName] = objInFor[conCodeFunction.CodeFuncName];
objDR[conCodeFunction.FuncSignature] = objInFor[conCodeFunction.FuncSignature];
objDR[conCodeFunction.UpdDate] = objInFor[conCodeFunction.UpdDate];
objDR[conCodeFunction.UpdUser] = objInFor[conCodeFunction.UpdUser];
objDR[conCodeFunction.Memo] = objInFor[conCodeFunction.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 代码函数(CodeFunction)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CodeFunction : clsCommFun4BL
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
clsCodeFunctionWApi.ReFreshThisCache();
}
}

}