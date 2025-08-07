
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_StyleWApi
 表名:vcss_Style(00050471)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
public static class  clsvcss_StyleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleId">样式ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleId(this clsvcss_StyleEN objvcss_StyleEN, string strStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleId, 8, convcss_Style.StyleId);
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, convcss_Style.StyleId);
objvcss_StyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleId) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleId, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleId] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetCtlTypeId(this clsvcss_StyleEN objvcss_StyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convcss_Style.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convcss_Style.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convcss_Style.CtlTypeId);
objvcss_StyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.CtlTypeId) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.CtlTypeId, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.CtlTypeId] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeName">控件类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetCtlTypeName(this clsvcss_StyleEN objvcss_StyleEN, string strCtlTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convcss_Style.CtlTypeName);
objvcss_StyleEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.CtlTypeName) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.CtlTypeName, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.CtlTypeName] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleName">样式名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleName(this clsvcss_StyleEN objvcss_StyleEN, string strStyleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleName, 50, convcss_Style.StyleName);
objvcss_StyleEN.StyleName = strStyleName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleName) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleName, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleName] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleDesc">样式描述</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleDesc(this clsvcss_StyleEN objvcss_StyleEN, string strStyleDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleDesc, 1000, convcss_Style.StyleDesc);
objvcss_StyleEN.StyleDesc = strStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleDesc) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleDesc, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleDesc] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strStyleContent">样式内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleContent(this clsvcss_StyleEN objvcss_StyleEN, string strStyleContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, convcss_Style.StyleContent);
objvcss_StyleEN.StyleContent = strStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleContent) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleContent, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleContent] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDeleted">是否删除</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetIsDeleted(this clsvcss_StyleEN objvcss_StyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objvcss_StyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.IsDeleted) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.IsDeleted, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.IsDeleted] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strDeletedDate">删除日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetDeletedDate(this clsvcss_StyleEN objvcss_StyleEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, convcss_Style.DeletedDate);
objvcss_StyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.DeletedDate) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.DeletedDate, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.DeletedDate] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetUpdDate(this clsvcss_StyleEN objvcss_StyleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcss_Style.UpdDate);
objvcss_StyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.UpdDate) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.UpdDate, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.UpdDate] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetUpdUser(this clsvcss_StyleEN objvcss_StyleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcss_Style.UpdUser);
objvcss_StyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.UpdUser) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.UpdUser, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.UpdUser] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetMemo(this clsvcss_StyleEN objvcss_StyleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcss_Style.Memo);
objvcss_StyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.Memo) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.Memo, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.Memo] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcss_StyleEN objvcss_StyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleId) == true)
{
string strComparisonOpStyleId = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleId, objvcss_StyleCond.StyleId, strComparisonOpStyleId);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.CtlTypeId, objvcss_StyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.CtlTypeName, objvcss_StyleCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleName) == true)
{
string strComparisonOpStyleName = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleName, objvcss_StyleCond.StyleName, strComparisonOpStyleName);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleDesc) == true)
{
string strComparisonOpStyleDesc = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleDesc, objvcss_StyleCond.StyleDesc, strComparisonOpStyleDesc);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleContent) == true)
{
string strComparisonOpStyleContent = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleContent, objvcss_StyleCond.StyleContent, strComparisonOpStyleContent);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.IsDeleted) == true)
{
if (objvcss_StyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcss_Style.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcss_Style.IsDeleted);
}
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.DeletedDate, objvcss_StyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.UpdDate, objvcss_StyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.UpdUser, objvcss_StyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.Memo) == true)
{
string strComparisonOpMemo = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.Memo, objvcss_StyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vcss_Style(vcss_Style)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcss_StyleWApi
{
private static readonly string mstrApiControllerName = "vcss_StyleApi";

 public clsvcss_StyleWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_StyleEN GetObjByStyleId(string strStyleId)
{
if (strStyleId == "") return null;
string strAction = "GetObjByStyleId";
clsvcss_StyleEN objvcss_StyleEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strStyleId"] = strStyleId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvcss_StyleEN = JsonConvert.DeserializeObject<clsvcss_StyleEN>(strJson);
return objvcss_StyleEN;
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
public static clsvcss_StyleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvcss_StyleEN objvcss_StyleEN;
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
objvcss_StyleEN = JsonConvert.DeserializeObject<clsvcss_StyleEN>(strJson);
return objvcss_StyleEN;
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

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLst(string strWhereCond)
{
 List<clsvcss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
 /// <param name = "arrStyleId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLstByStyleIdLst(List<string> arrStyleId)
{
 List<clsvcss_StyleEN> arrObjLst; 
string strAction = "GetObjLstByStyleIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrStyleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
public static List<clsvcss_StyleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
public static List<clsvcss_StyleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
public static List<clsvcss_StyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
public static List<clsvcss_StyleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvcss_StyleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcss_StyleEN>>(strJson);
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
public static bool IsExist(string strStyleId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strStyleId"] = strStyleId
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
 /// <param name = "objvcss_StyleENS">源对象</param>
 /// <param name = "objvcss_StyleENT">目标对象</param>
 public static void CopyTo(clsvcss_StyleEN objvcss_StyleENS, clsvcss_StyleEN objvcss_StyleENT)
{
try
{
objvcss_StyleENT.StyleId = objvcss_StyleENS.StyleId; //样式ID
objvcss_StyleENT.CtlTypeId = objvcss_StyleENS.CtlTypeId; //控件类型号
objvcss_StyleENT.CtlTypeName = objvcss_StyleENS.CtlTypeName; //控件类型名
objvcss_StyleENT.StyleName = objvcss_StyleENS.StyleName; //样式名称
objvcss_StyleENT.StyleDesc = objvcss_StyleENS.StyleDesc; //样式描述
objvcss_StyleENT.StyleContent = objvcss_StyleENS.StyleContent; //样式内容
objvcss_StyleENT.IsDeleted = objvcss_StyleENS.IsDeleted; //是否删除
objvcss_StyleENT.DeletedDate = objvcss_StyleENS.DeletedDate; //删除日期
objvcss_StyleENT.UpdDate = objvcss_StyleENS.UpdDate; //修改日期
objvcss_StyleENT.UpdUser = objvcss_StyleENS.UpdUser; //修改者
objvcss_StyleENT.Memo = objvcss_StyleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvcss_StyleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcss_StyleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcss_StyleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcss_StyleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcss_StyleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcss_StyleEN._AttributeName)
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
string strKey = string.Format("{0}", clsvcss_StyleEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvcss_StyleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcss_Style.StyleId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.CtlTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.StyleName, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.StyleDesc, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.StyleContent, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.IsDeleted, Type.GetType("System.Boolean"));
objDT.Columns.Add(convcss_Style.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcss_Style.Memo, Type.GetType("System.String"));
foreach (clsvcss_StyleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcss_Style.StyleId] = objInFor[convcss_Style.StyleId];
objDR[convcss_Style.CtlTypeId] = objInFor[convcss_Style.CtlTypeId];
objDR[convcss_Style.CtlTypeName] = objInFor[convcss_Style.CtlTypeName];
objDR[convcss_Style.StyleName] = objInFor[convcss_Style.StyleName];
objDR[convcss_Style.StyleDesc] = objInFor[convcss_Style.StyleDesc];
objDR[convcss_Style.StyleContent] = objInFor[convcss_Style.StyleContent];
objDR[convcss_Style.IsDeleted] = objInFor[convcss_Style.IsDeleted];
objDR[convcss_Style.DeletedDate] = objInFor[convcss_Style.DeletedDate];
objDR[convcss_Style.UpdDate] = objInFor[convcss_Style.UpdDate];
objDR[convcss_Style.UpdUser] = objInFor[convcss_Style.UpdUser];
objDR[convcss_Style.Memo] = objInFor[convcss_Style.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}