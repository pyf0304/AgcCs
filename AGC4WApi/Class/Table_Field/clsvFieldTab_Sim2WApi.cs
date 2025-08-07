
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_Sim2WApi
 表名:vFieldTab_Sim2(00050608)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:11
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
public static class  clsvFieldTab_Sim2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab_Sim2.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab_Sim2.FldId);
objvFieldTab_Sim2EN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetDataTypeId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab_Sim2.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab_Sim2.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab_Sim2.DataTypeId);
objvFieldTab_Sim2EN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.DataTypeId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.DataTypeId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.DataTypeId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldName(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab_Sim2.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab_Sim2.FldName);
objvFieldTab_Sim2EN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldName) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldName, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldName] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strCaption">标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetCaption(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab_Sim2.Caption);
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab_Sim2.Caption);
objvFieldTab_Sim2EN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.Caption) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.Caption, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.Caption] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "intFldLength">字段长度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldLength(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convFieldTab_Sim2.FldLength);
objvFieldTab_Sim2EN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldLength) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldLength, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldLength] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "intFldPrecision">精确度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldPrecision(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, int intFldPrecision, string strComparisonOp="")
	{
objvFieldTab_Sim2EN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldPrecision) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldPrecision, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldPrecision] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetPrjId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab_Sim2.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab_Sim2.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab_Sim2.PrjId);
objvFieldTab_Sim2EN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.PrjId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.PrjId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.PrjId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFieldTypeId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFieldTab_Sim2.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFieldTab_Sim2.FieldTypeId);
objvFieldTab_Sim2EN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FieldTypeId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FieldTypeId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FieldTypeId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strHomologousFldId">同源字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetHomologousFldId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strHomologousFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convFieldTab_Sim2.HomologousFldId);
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convFieldTab_Sim2.HomologousFldId);
objvFieldTab_Sim2EN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.HomologousFldId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.HomologousFldId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.HomologousFldId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab_Sim2EN objvFieldTab_Sim2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FldId, objvFieldTab_Sim2Cond.FldId, strComparisonOpFldId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.DataTypeId, objvFieldTab_Sim2Cond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FldName, objvFieldTab_Sim2Cond.FldName, strComparisonOpFldName);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.Caption) == true)
{
string strComparisonOpCaption = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.Caption, objvFieldTab_Sim2Cond.Caption, strComparisonOpCaption);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldLength) == true)
{
string strComparisonOpFldLength = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab_Sim2.FldLength, objvFieldTab_Sim2Cond.FldLength, strComparisonOpFldLength);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab_Sim2.FldPrecision, objvFieldTab_Sim2Cond.FldPrecision, strComparisonOpFldPrecision);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.PrjId, objvFieldTab_Sim2Cond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FieldTypeId, objvFieldTab_Sim2Cond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.HomologousFldId, objvFieldTab_Sim2Cond.HomologousFldId, strComparisonOpHomologousFldId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab_Sim2WApi
{
private static readonly string mstrApiControllerName = "vFieldTab_Sim2Api";

 public clsvFieldTab_Sim2WApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab_Sim2EN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN;
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
objvFieldTab_Sim2EN = JsonConvert.DeserializeObject<clsvFieldTab_Sim2EN>(strJson);
return objvFieldTab_Sim2EN;
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
public static clsvFieldTab_Sim2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN;
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
objvFieldTab_Sim2EN = JsonConvert.DeserializeObject<clsvFieldTab_Sim2EN>(strJson);
return objvFieldTab_Sim2EN;
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
public static clsvFieldTab_Sim2EN GetObjByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLst_Sel =
from objvFieldTab_Sim2EN in arrvFieldTab_Sim2ObjLstCache
where objvFieldTab_Sim2EN.FldId == strFldId 
select objvFieldTab_Sim2EN;
if (arrvFieldTab_Sim2ObjLst_Sel.Count() == 0)
{
   clsvFieldTab_Sim2EN obj = clsvFieldTab_Sim2WApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFieldTab_Sim2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLst(string strWhereCond)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
public static IEnumerable<clsvFieldTab_Sim2EN> GetObjLstByFldIdLstCache(List<string> arrFldId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLst_Sel =
from objvFieldTab_Sim2EN in arrvFieldTab_Sim2ObjLstCache
where arrFldId.Contains(objvFieldTab_Sim2EN.FldId)
select objvFieldTab_Sim2EN;
return arrvFieldTab_Sim2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFieldTab_Sim2EN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFieldTab_Sim2EN>>(strJson);
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
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <param name = "objvFieldTab_Sim2ENT">目标对象</param>
 public static void CopyTo(clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS, clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT)
{
try
{
objvFieldTab_Sim2ENT.FldId = objvFieldTab_Sim2ENS.FldId; //字段Id
objvFieldTab_Sim2ENT.DataTypeId = objvFieldTab_Sim2ENS.DataTypeId; //数据类型Id
objvFieldTab_Sim2ENT.FldName = objvFieldTab_Sim2ENS.FldName; //字段名
objvFieldTab_Sim2ENT.Caption = objvFieldTab_Sim2ENS.Caption; //标题
objvFieldTab_Sim2ENT.FldLength = objvFieldTab_Sim2ENS.FldLength; //字段长度
objvFieldTab_Sim2ENT.FldPrecision = objvFieldTab_Sim2ENS.FldPrecision; //精确度
objvFieldTab_Sim2ENT.PrjId = objvFieldTab_Sim2ENS.PrjId; //工程Id
objvFieldTab_Sim2ENT.FieldTypeId = objvFieldTab_Sim2ENS.FieldTypeId; //字段类型Id
objvFieldTab_Sim2ENT.HomologousFldId = objvFieldTab_Sim2ENS.HomologousFldId; //同源字段Id
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
public static DataTable ToDataTable(List<clsvFieldTab_Sim2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFieldTab_Sim2EN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFieldTab_Sim2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFieldTab_Sim2EN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFieldTab_Sim2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFieldTab_Sim2EN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab_Sim2WApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab_Sim2WApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab_Sim2WApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab_Sim2WApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvFieldTab_Sim2EN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvFieldTab_Sim2EN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convFieldTab_Sim2.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFieldTab_Sim2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvFieldTab_Sim2EN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvFieldTab_Sim2WApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvFieldTab_Sim2WApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvFieldTab_Sim2ObjLstCache = CacheHelper.Get<List<clsvFieldTab_Sim2EN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvFieldTab_Sim2ObjLstCache = CacheHelper.Get<List<clsvFieldTab_Sim2EN>>(strKey);
}
return arrvFieldTab_Sim2ObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFieldTab_Sim2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFieldTab_Sim2.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.Caption, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.FldLength, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab_Sim2.FldPrecision, Type.GetType("System.Int32"));
objDT.Columns.Add(convFieldTab_Sim2.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFieldTab_Sim2.HomologousFldId, Type.GetType("System.String"));
foreach (clsvFieldTab_Sim2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFieldTab_Sim2.FldId] = objInFor[convFieldTab_Sim2.FldId];
objDR[convFieldTab_Sim2.DataTypeId] = objInFor[convFieldTab_Sim2.DataTypeId];
objDR[convFieldTab_Sim2.FldName] = objInFor[convFieldTab_Sim2.FldName];
objDR[convFieldTab_Sim2.Caption] = objInFor[convFieldTab_Sim2.Caption];
objDR[convFieldTab_Sim2.FldLength] = objInFor[convFieldTab_Sim2.FldLength];
objDR[convFieldTab_Sim2.FldPrecision] = objInFor[convFieldTab_Sim2.FldPrecision];
objDR[convFieldTab_Sim2.PrjId] = objInFor[convFieldTab_Sim2.PrjId];
objDR[convFieldTab_Sim2.FieldTypeId] = objInFor[convFieldTab_Sim2.FieldTypeId];
objDR[convFieldTab_Sim2.HomologousFldId] = objInFor[convFieldTab_Sim2.HomologousFldId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}