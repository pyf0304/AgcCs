
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupWApi
 表名:vFunctionGroup(00050326)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:51:00
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
public static class  clsvFunctionGroupWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetFunctionGroupId(this clsvFunctionGroupEN objvFunctionGroupEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionGroup.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionGroup.FunctionGroupId);
objvFunctionGroupEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.FunctionGroupId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.FunctionGroupId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.FunctionGroupId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupName">函数组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetFunctionGroupName(this clsvFunctionGroupEN objvFunctionGroupEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupName, convFunctionGroup.FunctionGroupName);
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionGroup.FunctionGroupName);
objvFunctionGroupEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.FunctionGroupName) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.FunctionGroupName, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.FunctionGroupName] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetProgLangTypeId(this clsvFunctionGroupEN objvFunctionGroupEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionGroup.ProgLangTypeId);
objvFunctionGroupEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.ProgLangTypeId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetProgLangTypeName(this clsvFunctionGroupEN objvFunctionGroupEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionGroup.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionGroup.ProgLangTypeName);
objvFunctionGroupEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.ProgLangTypeName) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetCreateUserId(this clsvFunctionGroupEN objvFunctionGroupEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionGroup.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionGroup.CreateUserId);
objvFunctionGroupEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.CreateUserId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.CreateUserId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.CreateUserId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetUpdDate(this clsvFunctionGroupEN objvFunctionGroupEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionGroup.UpdDate);
objvFunctionGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.UpdDate) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.UpdDate, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.UpdDate] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetUpdUser(this clsvFunctionGroupEN objvFunctionGroupEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionGroup.UpdUser);
objvFunctionGroupEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.UpdUser) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.UpdUser, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.UpdUser] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetMemo(this clsvFunctionGroupEN objvFunctionGroupEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionGroup.Memo);
objvFunctionGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.Memo) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.Memo, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.Memo] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionGroupEN objvFunctionGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.FunctionGroupId, objvFunctionGroupCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.FunctionGroupName, objvFunctionGroupCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.ProgLangTypeId, objvFunctionGroupCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.ProgLangTypeName, objvFunctionGroupCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.CreateUserId, objvFunctionGroupCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.UpdDate, objvFunctionGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.UpdUser, objvFunctionGroupCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.Memo) == true)
{
string strComparisonOpMemo = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.Memo, objvFunctionGroupCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数组(vFunctionGroup)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionGroupWApi
{
private static readonly string mstrApiControllerName = "vFunctionGroupApi";

 public clsvFunctionGroupWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FunctionGroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数组]...","0");
List<clsvFunctionGroupEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FunctionGroupId";
objDDL.DataTextField="FunctionGroupName";
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

public static void BindCbo_FunctionGroupId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFunctionGroup.FunctionGroupId); 
List<clsvFunctionGroupEN> arrObjLst = clsvFunctionGroupWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN()
{
FunctionGroupId = "0",
FunctionGroupName = "选[v函数组]..."
};
arrObjLst.Insert(0, objvFunctionGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFunctionGroup.FunctionGroupId;
objComboBox.DisplayMember = convFunctionGroup.FunctionGroupName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupEN GetObjByFunctionGroupId(string strFunctionGroupId)
{
if (strFunctionGroupId == "") return null;
string strAction = "GetObjByFunctionGroupId";
clsvFunctionGroupEN objvFunctionGroupEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionGroupId"] = strFunctionGroupId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFunctionGroupEN = JsonConvert.DeserializeObject<clsvFunctionGroupEN>(strJson);
return objvFunctionGroupEN;
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
public static clsvFunctionGroupEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionGroupEN objvFunctionGroupEN;
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
objvFunctionGroupEN = JsonConvert.DeserializeObject<clsvFunctionGroupEN>(strJson);
return objvFunctionGroupEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
//该表没有使用Cache,不需要生成[GetFunctionGroupNameByFunctionGroupIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
 /// <param name = "arrFunctionGroupId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLstByFunctionGroupIdLst(List<string> arrFunctionGroupId)
{
 List<clsvFunctionGroupEN> arrObjLst; 
string strAction = "GetObjLstByFunctionGroupIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
public static List<clsvFunctionGroupEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
public static List<clsvFunctionGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
public static List<clsvFunctionGroupEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionGroupEN>>(strJson);
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
public static bool IsExist(string strFunctionGroupId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionGroupId"] = strFunctionGroupId
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
 /// <param name = "objvFunctionGroupENS">源对象</param>
 /// <param name = "objvFunctionGroupENT">目标对象</param>
 public static void CopyTo(clsvFunctionGroupEN objvFunctionGroupENS, clsvFunctionGroupEN objvFunctionGroupENT)
{
try
{
objvFunctionGroupENT.FunctionGroupId = objvFunctionGroupENS.FunctionGroupId; //函数组Id
objvFunctionGroupENT.FunctionGroupName = objvFunctionGroupENS.FunctionGroupName; //函数组名称
objvFunctionGroupENT.ProgLangTypeId = objvFunctionGroupENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupENT.ProgLangTypeName = objvFunctionGroupENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupENT.CreateUserId = objvFunctionGroupENS.CreateUserId; //建立用户Id
objvFunctionGroupENT.UpdDate = objvFunctionGroupENS.UpdDate; //修改日期
objvFunctionGroupENT.UpdUser = objvFunctionGroupENS.UpdUser; //修改者
objvFunctionGroupENT.Memo = objvFunctionGroupENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFunctionGroupEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionGroupEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionGroupEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionGroupEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionGroupEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionGroupEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionGroupEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionGroupEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionGroup.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.FunctionGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionGroup.Memo, Type.GetType("System.String"));
foreach (clsvFunctionGroupEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionGroup.FunctionGroupId] = objInFor[convFunctionGroup.FunctionGroupId];
objDR[convFunctionGroup.FunctionGroupName] = objInFor[convFunctionGroup.FunctionGroupName];
objDR[convFunctionGroup.ProgLangTypeId] = objInFor[convFunctionGroup.ProgLangTypeId];
objDR[convFunctionGroup.ProgLangTypeName] = objInFor[convFunctionGroup.ProgLangTypeName];
objDR[convFunctionGroup.CreateUserId] = objInFor[convFunctionGroup.CreateUserId];
objDR[convFunctionGroup.UpdDate] = objInFor[convFunctionGroup.UpdDate];
objDR[convFunctionGroup.UpdUser] = objInFor[convFunctionGroup.UpdUser];
objDR[convFunctionGroup.Memo] = objInFor[convFunctionGroup.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}