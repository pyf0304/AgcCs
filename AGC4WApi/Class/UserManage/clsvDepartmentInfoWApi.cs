
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDepartmentInfoWApi
 表名:vDepartmentInfo(00050305)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:31:34
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvDepartmentInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convDepartmentInfo.DepartmentId);
objvDepartmentInfoEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convDepartmentInfo.DepartmentName);
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convDepartmentInfo.DepartmentName);
objvDepartmentInfoEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentAbbrName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convDepartmentInfo.DepartmentAbbrName);
objvDepartmentInfoEN.DepartmentAbbrName = strDepartmentAbbrName; //部门简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentAbbrName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentAbbrName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentAbbrName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentTypeId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convDepartmentInfo.DepartmentTypeId);
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convDepartmentInfo.DepartmentTypeId);
objvDepartmentInfoEN.DepartmentTypeId = strDepartmentTypeId; //部门类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentTypeId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentTypeId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUpDepartmentId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strUpDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convDepartmentInfo.UpDepartmentId);
objvDepartmentInfoEN.UpDepartmentId = strUpDepartmentId; //上级部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UpDepartmentId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UpDepartmentId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UpDepartmentId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentTypeName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convDepartmentInfo.DepartmentTypeName);
objvDepartmentInfoEN.DepartmentTypeName = strDepartmentTypeName; //部门类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentTypeName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentTypeName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetInUse(this clsvDepartmentInfoEN objvDepartmentInfoEN, bool bolInUse, string strComparisonOp="")
	{
objvDepartmentInfoEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.InUse) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.InUse, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.InUse] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetOrderNum(this clsvDepartmentInfoEN objvDepartmentInfoEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convDepartmentInfo.OrderNum);
objvDepartmentInfoEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.OrderNum) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.OrderNum, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.OrderNum] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetMemo(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDepartmentInfo.Memo);
objvDepartmentInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.Memo) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.Memo, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.Memo] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUpDepartmentName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strUpDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 30, convDepartmentInfo.UpDepartmentName);
objvDepartmentInfoEN.UpDepartmentName = strUpDepartmentName; //上级部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UpDepartmentName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UpDepartmentName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UpDepartmentName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUserNum(this clsvDepartmentInfoEN objvDepartmentInfoEN, int intUserNum, string strComparisonOp="")
	{
objvDepartmentInfoEN.UserNum = intUserNum; //UserNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UserNum) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UserNum, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UserNum] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDepartmentInfoEN objvDepartmentInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.DepartmentId) == true)
{
string strComparisonOp_DepartmentId = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentId, objvDepartmentInfo_Cond.DepartmentId, strComparisonOp_DepartmentId);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.DepartmentName) == true)
{
string strComparisonOp_DepartmentName = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentName, objvDepartmentInfo_Cond.DepartmentName, strComparisonOp_DepartmentName);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.DepartmentAbbrName) == true)
{
string strComparisonOp_DepartmentAbbrName = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentAbbrName, objvDepartmentInfo_Cond.DepartmentAbbrName, strComparisonOp_DepartmentAbbrName);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.DepartmentTypeId) == true)
{
string strComparisonOp_DepartmentTypeId = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentTypeId, objvDepartmentInfo_Cond.DepartmentTypeId, strComparisonOp_DepartmentTypeId);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.UpDepartmentId) == true)
{
string strComparisonOp_UpDepartmentId = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.UpDepartmentId, objvDepartmentInfo_Cond.UpDepartmentId, strComparisonOp_UpDepartmentId);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.DepartmentTypeName) == true)
{
string strComparisonOp_DepartmentTypeName = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentTypeName, objvDepartmentInfo_Cond.DepartmentTypeName, strComparisonOp_DepartmentTypeName);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.InUse) == true)
{
if (objvDepartmentInfo_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDepartmentInfo.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDepartmentInfo.InUse);
}
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDepartmentInfo.OrderNum, objvDepartmentInfo_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.Memo) == true)
{
string strComparisonOp_Memo = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.Memo, objvDepartmentInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.UpDepartmentName) == true)
{
string strComparisonOp_UpDepartmentName = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.UpDepartmentName, objvDepartmentInfo_Cond.UpDepartmentName, strComparisonOp_UpDepartmentName);
}
if (objvDepartmentInfo_Cond.IsUpdated(convDepartmentInfo.UserNum) == true)
{
string strComparisonOp_UserNum = objvDepartmentInfo_Cond.dicFldComparisonOp[convDepartmentInfo.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDepartmentInfo.UserNum, objvDepartmentInfo_Cond.UserNum, strComparisonOp_UserNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v部门(vDepartmentInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDepartmentInfoWApi
{
private static readonly string mstrApiControllerName = "vDepartmentInfoApi";

 public clsvDepartmentInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
string strAction = "GetObjByDepartmentId";
string strErrMsg = string.Empty;
string strResult = "";
clsvDepartmentInfoEN objvDepartmentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DepartmentId"] = strDepartmentId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvDepartmentInfoEN = JsonConvert.DeserializeObject<clsvDepartmentInfoEN>((string)jobjReturn["returnObj"]);
return objvDepartmentInfoEN;
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
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentId_WA_Cache(string strDepartmentId)
{
string strAction = "GetObjByDepartmentId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvDepartmentInfoEN objvDepartmentInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DepartmentId"] = strDepartmentId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvDepartmentInfoEN = JsonConvert.DeserializeObject<clsvDepartmentInfoEN>((string)jobjReturn["returnObj"]);
return objvDepartmentInfoEN;
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
public static clsvDepartmentInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvDepartmentInfoEN objvDepartmentInfoEN = null;
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
objvDepartmentInfoEN = JsonConvert.DeserializeObject<clsvDepartmentInfoEN>((string)jobjReturn["returnObj"]);
return objvDepartmentInfoEN;
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
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentId_Cache(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Sel =
from objvDepartmentInfoEN in arrvDepartmentInfoObjLst_Cache
where objvDepartmentInfoEN.DepartmentId == strDepartmentId
select objvDepartmentInfoEN;
if (arrvDepartmentInfoObjLst_Sel.Count() == 0)
{
   clsvDepartmentInfoEN obj = clsvDepartmentInfoWApi.GetObjByDepartmentId(strDepartmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDepartmentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvDepartmentInfoEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentId)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstByDepartmentIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvDepartmentInfoEN> GetObjLstByDepartmentIdLst_Cache(List<string> arrDepartmentId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Sel =
from objvDepartmentInfoEN in arrvDepartmentInfoObjLst_Cache
where arrDepartmentId.Contains(objvDepartmentInfoEN.DepartmentId)
select objvDepartmentInfoEN;
return arrvDepartmentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstByDepartmentIdLst_WA_Cache(List<string> arrDepartmentId)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
string strAction = "GetObjLstByDepartmentIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDepartmentId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvDepartmentInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvDepartmentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvDepartmentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsvDepartmentInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvDepartmentInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDepartmentInfoEN>>((string)jobjReturn["returnObjLst"]);
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
public static bool IsExist(string strDepartmentId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DepartmentId"] = strDepartmentId
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvDepartmentInfoENS">源对象</param>
 /// <param name = "objvDepartmentInfoENT">目标对象</param>
 public static void CopyTo(clsvDepartmentInfoEN objvDepartmentInfoENS, clsvDepartmentInfoEN objvDepartmentInfoENT)
{
try
{
objvDepartmentInfoENT.DepartmentId = objvDepartmentInfoENS.DepartmentId; //部门ID
objvDepartmentInfoENT.DepartmentName = objvDepartmentInfoENS.DepartmentName; //部门名称
objvDepartmentInfoENT.DepartmentAbbrName = objvDepartmentInfoENS.DepartmentAbbrName; //部门简称
objvDepartmentInfoENT.DepartmentTypeId = objvDepartmentInfoENS.DepartmentTypeId; //部门类型Id
objvDepartmentInfoENT.UpDepartmentId = objvDepartmentInfoENS.UpDepartmentId; //上级部门Id
objvDepartmentInfoENT.DepartmentTypeName = objvDepartmentInfoENS.DepartmentTypeName; //部门类型
objvDepartmentInfoENT.InUse = objvDepartmentInfoENS.InUse; //是否在用
objvDepartmentInfoENT.OrderNum = objvDepartmentInfoENS.OrderNum; //序号
objvDepartmentInfoENT.Memo = objvDepartmentInfoENS.Memo; //说明
objvDepartmentInfoENT.UpDepartmentName = objvDepartmentInfoENS.UpDepartmentName; //上级部门名
objvDepartmentInfoENT.UserNum = objvDepartmentInfoENS.UserNum; //UserNum
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
public static DataTable ToDataTable(List<clsvDepartmentInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDepartmentInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDepartmentInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDepartmentInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDepartmentInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDepartmentInfoEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsDepartmentInfoWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsDepartmentInfoWApi没有刷新缓存机制(clsDepartmentInfoWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsDepartmentTypeWApi没有刷新缓存机制(clsDepartmentTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DepartmentId");
//if (arrvDepartmentInfoObjLst_Cache == null)
//{
//arrvDepartmentInfoObjLst_Cache = await clsvDepartmentInfoWApi.GetObjLst(strWhereCond);
//}
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
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDepartmentInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDepartmentInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDepartmentInfo.DepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.DepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.DepartmentAbbrName, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.DepartmentTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.UpDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.DepartmentTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convDepartmentInfo.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convDepartmentInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.UpDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convDepartmentInfo.UserNum, Type.GetType("System.Int32"));
foreach (clsvDepartmentInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDepartmentInfo.DepartmentId] = objInFor[convDepartmentInfo.DepartmentId];
objDR[convDepartmentInfo.DepartmentName] = objInFor[convDepartmentInfo.DepartmentName];
objDR[convDepartmentInfo.DepartmentAbbrName] = objInFor[convDepartmentInfo.DepartmentAbbrName];
objDR[convDepartmentInfo.DepartmentTypeId] = objInFor[convDepartmentInfo.DepartmentTypeId];
objDR[convDepartmentInfo.UpDepartmentId] = objInFor[convDepartmentInfo.UpDepartmentId];
objDR[convDepartmentInfo.DepartmentTypeName] = objInFor[convDepartmentInfo.DepartmentTypeName];
objDR[convDepartmentInfo.InUse] = objInFor[convDepartmentInfo.InUse];
objDR[convDepartmentInfo.OrderNum] = objInFor[convDepartmentInfo.OrderNum];
objDR[convDepartmentInfo.Memo] = objInFor[convDepartmentInfo.Memo];
objDR[convDepartmentInfo.UpDepartmentName] = objInFor[convDepartmentInfo.UpDepartmentName];
objDR[convDepartmentInfo.UserNum] = objInFor[convDepartmentInfo.UserNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}