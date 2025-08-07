
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFunctionWApi
 表名:vDnFunction(00050553)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvDnFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetDnFunctionId(this clsvDnFunctionEN objvDnFunctionEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFunction.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFunction.DnFunctionId);
objvDnFunctionEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.DnFunctionId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.DnFunctionId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.DnFunctionId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionName">DN函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetDnFunctionName(this clsvDnFunctionEN objvDnFunctionEN, string strDnFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionName, 50, convDnFunction.DnFunctionName);
objvDnFunctionEN.DnFunctionName = strDnFunctionName; //DN函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.DnFunctionName) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.DnFunctionName, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.DnFunctionName] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetAssociationMappingId(this clsvDnFunctionEN objvDnFunctionEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFunction.AssociationMappingId);
objvDnFunctionEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.AssociationMappingId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.AssociationMappingId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.AssociationMappingId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingName">关联关系映射名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetAssociationMappingName(this clsvDnFunctionEN objvDnFunctionEN, string strAssociationMappingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, convDnFunction.AssociationMappingName);
objvDnFunctionEN.AssociationMappingName = strAssociationMappingName; //关联关系映射名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.AssociationMappingName) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.AssociationMappingName, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.AssociationMappingName] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportClass">导入类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetImportClass(this clsvDnFunctionEN objvDnFunctionEN, string strImportClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportClass, 50, convDnFunction.ImportClass);
objvDnFunctionEN.ImportClass = strImportClass; //导入类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.ImportClass) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.ImportClass, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.ImportClass] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportPath">导入路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetImportPath(this clsvDnFunctionEN objvDnFunctionEN, string strImportPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportPath, 100, convDnFunction.ImportPath);
objvDnFunctionEN.ImportPath = strImportPath; //导入路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.ImportPath) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.ImportPath, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.ImportPath] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetPrjId(this clsvDnFunctionEN objvDnFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFunction.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFunction.PrjId);
objvDnFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.PrjId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.PrjId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.PrjId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetUpdDate(this clsvDnFunctionEN objvDnFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDnFunction.UpdDate);
objvDnFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.UpdDate) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.UpdDate, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.UpdDate] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetUpdUser(this clsvDnFunctionEN objvDnFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDnFunction.UpdUser);
objvDnFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.UpdUser) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.UpdUser, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.UpdUser] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetMemo(this clsvDnFunctionEN objvDnFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDnFunction.Memo);
objvDnFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.Memo) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.Memo, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.Memo] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnFunctionEN objvDnFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnFunctionCond.IsUpdated(convDnFunction.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.DnFunctionId, objvDnFunctionCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.DnFunctionName) == true)
{
string strComparisonOpDnFunctionName = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.DnFunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.DnFunctionName, objvDnFunctionCond.DnFunctionName, strComparisonOpDnFunctionName);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.AssociationMappingId, objvDnFunctionCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.AssociationMappingName) == true)
{
string strComparisonOpAssociationMappingName = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.AssociationMappingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.AssociationMappingName, objvDnFunctionCond.AssociationMappingName, strComparisonOpAssociationMappingName);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.ImportClass) == true)
{
string strComparisonOpImportClass = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.ImportClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.ImportClass, objvDnFunctionCond.ImportClass, strComparisonOpImportClass);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.ImportPath) == true)
{
string strComparisonOpImportPath = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.ImportPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.ImportPath, objvDnFunctionCond.ImportPath, strComparisonOpImportPath);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.PrjId) == true)
{
string strComparisonOpPrjId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.PrjId, objvDnFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.UpdDate, objvDnFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.UpdUser, objvDnFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.Memo) == true)
{
string strComparisonOpMemo = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.Memo, objvDnFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vDnFunction(vDnFunction), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DNFunctionName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvDnFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvDnFunctionEN objvDnFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvDnFunctionEN == null) return "";
if (objvDnFunctionEN.DnFunctionId == null || objvDnFunctionEN.DnFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFunctionId !=  '{0}'", objvDnFunctionEN.DnFunctionId);
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vDnFunction(vDnFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDnFunctionWApi
{
private static readonly string mstrApiControllerName = "vDnFunctionApi";

 public clsvDnFunctionWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFunctionEN GetObjByDnFunctionId(string strDnFunctionId)
{
if (strDnFunctionId == "") return null;
string strAction = "GetObjByDnFunctionId";
clsvDnFunctionEN objvDnFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFunctionId"] = strDnFunctionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDnFunctionEN = JsonConvert.DeserializeObject<clsvDnFunctionEN>(strJson);
return objvDnFunctionEN;
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
public static clsvDnFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDnFunctionEN objvDnFunctionEN;
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
objvDnFunctionEN = JsonConvert.DeserializeObject<clsvDnFunctionEN>(strJson);
return objvDnFunctionEN;
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
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFunctionEN GetObjByDnFunctionIdCache(string strDnFunctionId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrvDnFunctionObjLst_Sel =
from objvDnFunctionEN in arrvDnFunctionObjLstCache
where objvDnFunctionEN.DnFunctionId == strDnFunctionId 
select objvDnFunctionEN;
if (arrvDnFunctionObjLst_Sel.Count() == 0)
{
   clsvDnFunctionEN obj = clsvDnFunctionWApi.GetObjByDnFunctionId(strDnFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDnFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsvDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
 /// <param name = "arrDnFunctionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstByDnFunctionIdLst(List<string> arrDnFunctionId)
{
 List<clsvDnFunctionEN> arrObjLst; 
string strAction = "GetObjLstByDnFunctionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
 /// <param name = "arrDnFunctionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDnFunctionEN> GetObjLstByDnFunctionIdLstCache(List<string> arrDnFunctionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrvDnFunctionObjLst_Sel =
from objvDnFunctionEN in arrvDnFunctionObjLstCache
where arrDnFunctionId.Contains(objvDnFunctionEN.DnFunctionId)
select objvDnFunctionEN;
return arrvDnFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
public static List<clsvDnFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
public static List<clsvDnFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
public static List<clsvDnFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFunctionEN>>(strJson);
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
public static bool IsExist(string strDnFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFunctionId"] = strDnFunctionId
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
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <param name = "objvDnFunctionENT">目标对象</param>
 public static void CopyTo(clsvDnFunctionEN objvDnFunctionENS, clsvDnFunctionEN objvDnFunctionENT)
{
try
{
objvDnFunctionENT.DnFunctionId = objvDnFunctionENS.DnFunctionId; //DN函数Id
objvDnFunctionENT.DnFunctionName = objvDnFunctionENS.DnFunctionName; //DN函数
objvDnFunctionENT.AssociationMappingId = objvDnFunctionENS.AssociationMappingId; //关联关系映射Id
objvDnFunctionENT.AssociationMappingName = objvDnFunctionENS.AssociationMappingName; //关联关系映射名
objvDnFunctionENT.ImportClass = objvDnFunctionENS.ImportClass; //导入类
objvDnFunctionENT.ImportPath = objvDnFunctionENS.ImportPath; //导入路径
objvDnFunctionENT.PrjId = objvDnFunctionENS.PrjId; //工程Id
objvDnFunctionENT.UpdDate = objvDnFunctionENS.UpdDate; //修改日期
objvDnFunctionENT.UpdUser = objvDnFunctionENS.UpdUser; //修改者
objvDnFunctionENT.Memo = objvDnFunctionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvDnFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDnFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDnFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDnFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDnFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDnFunctionEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFunctionWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFunctionWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
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
public static List<clsvDnFunctionEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFunctionWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFunctionWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvDnFunctionEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvDnFunctionEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convDnFunction.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDnFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvDnFunctionEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFunctionWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFunctionWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvDnFunctionObjLstCache = CacheHelper.Get<List<clsvDnFunctionEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvDnFunctionObjLstCache = CacheHelper.Get<List<clsvDnFunctionEN>>(strKey);
}
return arrvDnFunctionObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDnFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDnFunction.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.DnFunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.AssociationMappingName, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.ImportClass, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.ImportPath, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDnFunction.Memo, Type.GetType("System.String"));
foreach (clsvDnFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDnFunction.DnFunctionId] = objInFor[convDnFunction.DnFunctionId];
objDR[convDnFunction.DnFunctionName] = objInFor[convDnFunction.DnFunctionName];
objDR[convDnFunction.AssociationMappingId] = objInFor[convDnFunction.AssociationMappingId];
objDR[convDnFunction.AssociationMappingName] = objInFor[convDnFunction.AssociationMappingName];
objDR[convDnFunction.ImportClass] = objInFor[convDnFunction.ImportClass];
objDR[convDnFunction.ImportPath] = objInFor[convDnFunction.ImportPath];
objDR[convDnFunction.PrjId] = objInFor[convDnFunction.PrjId];
objDR[convDnFunction.UpdDate] = objInFor[convDnFunction.UpdDate];
objDR[convDnFunction.UpdUser] = objInFor[convDnFunction.UpdUser];
objDR[convDnFunction.Memo] = objInFor[convDnFunction.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}