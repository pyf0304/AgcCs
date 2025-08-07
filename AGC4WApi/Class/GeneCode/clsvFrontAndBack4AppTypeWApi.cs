
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeWApi
 表名:vFrontAndBack4AppType(00050424)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:52
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
public static class  clsvFrontAndBack4AppTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetmId(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, long lngmId, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.mId) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.mId, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.mId] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetOrderNum(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFrontAndBack4AppType.OrderNum);
objvFrontAndBack4AppTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.OrderNum) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.OrderNum, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.OrderNum] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppTypeId4Front">应用类型Id4Front</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetAppTypeId4Front(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int intAppTypeId4Front, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.AppTypeId4Front = intAppTypeId4Front; //应用类型Id4Front
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.AppTypeId4Front) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.AppTypeId4Front, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Front] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplTypeName4Front">ApplTypeName4Front</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetApplTypeName4Front(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strApplTypeName4Front, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplTypeName4Front, 30, convFrontAndBack4AppType.ApplTypeName4Front);
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = strApplTypeName4Front; //ApplTypeName4Front
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.ApplTypeName4Front) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.ApplTypeName4Front, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Front] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetIsVisible(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.IsVisible) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.IsVisible, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.IsVisible] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppTypeId4Back">应用类型Id4Back</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetAppTypeId4Back(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int intAppTypeId4Back, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.AppTypeId4Back = intAppTypeId4Back; //应用类型Id4Back
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.AppTypeId4Back) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.AppTypeId4Back, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Back] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplTypeName4Back">ApplTypeName4Back</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetApplTypeName4Back(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strApplTypeName4Back, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplTypeName4Back, 30, convFrontAndBack4AppType.ApplTypeName4Back);
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = strApplTypeName4Back; //ApplTypeName4Back
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.ApplTypeName4Back) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.ApplTypeName4Back, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Back] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetUpdDate(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFrontAndBack4AppType.UpdDate);
objvFrontAndBack4AppTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.UpdDate) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.UpdDate, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.UpdDate] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetUpdUser(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFrontAndBack4AppType.UpdUser);
objvFrontAndBack4AppTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.UpdUser) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.UpdUser, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.UpdUser] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetMemo(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFrontAndBack4AppType.Memo);
objvFrontAndBack4AppTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.Memo) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.Memo, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.Memo] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.mId) == true)
{
string strComparisonOpmId = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.mId, objvFrontAndBack4AppTypeCond.mId, strComparisonOpmId);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.OrderNum, objvFrontAndBack4AppTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.AppTypeId4Front) == true)
{
string strComparisonOpAppTypeId4Front = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Front];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.AppTypeId4Front, objvFrontAndBack4AppTypeCond.AppTypeId4Front, strComparisonOpAppTypeId4Front);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.ApplTypeName4Front) == true)
{
string strComparisonOpApplTypeName4Front = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Front];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.ApplTypeName4Front, objvFrontAndBack4AppTypeCond.ApplTypeName4Front, strComparisonOpApplTypeName4Front);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.IsVisible) == true)
{
if (objvFrontAndBack4AppTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFrontAndBack4AppType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFrontAndBack4AppType.IsVisible);
}
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.AppTypeId4Back) == true)
{
string strComparisonOpAppTypeId4Back = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Back];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.AppTypeId4Back, objvFrontAndBack4AppTypeCond.AppTypeId4Back, strComparisonOpAppTypeId4Back);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.ApplTypeName4Back) == true)
{
string strComparisonOpApplTypeName4Back = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Back];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.ApplTypeName4Back, objvFrontAndBack4AppTypeCond.ApplTypeName4Back, strComparisonOpApplTypeName4Back);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.UpdDate, objvFrontAndBack4AppTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.UpdUser, objvFrontAndBack4AppTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.Memo) == true)
{
string strComparisonOpMemo = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.Memo, objvFrontAndBack4AppTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFrontAndBack4AppTypeWApi
{
private static readonly string mstrApiControllerName = "vFrontAndBack4AppTypeApi";

 public clsvFrontAndBack4AppTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFrontAndBack4AppTypeEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvFrontAndBack4AppTypeEN = JsonConvert.DeserializeObject<clsvFrontAndBack4AppTypeEN>(strJson);
return objvFrontAndBack4AppTypeEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvFrontAndBack4AppTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN;
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
objvFrontAndBack4AppTypeEN = JsonConvert.DeserializeObject<clsvFrontAndBack4AppTypeEN>(strJson);
return objvFrontAndBack4AppTypeEN;
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
public static List<clsvFrontAndBack4AppTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFrontAndBack4AppTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFrontAndBack4AppTypeEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
 public static void CopyTo(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENS, clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENT)
{
try
{
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvFrontAndBack4AppTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFrontAndBack4AppTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFrontAndBack4AppTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFrontAndBack4AppTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFrontAndBack4AppTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFrontAndBack4AppTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFrontAndBack4AppTypeEN._CurrTabName);
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
public static DataTable GetDataTableByObjLst(List<clsvFrontAndBack4AppTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFrontAndBack4AppType.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFrontAndBack4AppType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFrontAndBack4AppType.AppTypeId4Front, Type.GetType("System.Int32"));
objDT.Columns.Add(convFrontAndBack4AppType.ApplTypeName4Front, Type.GetType("System.String"));
objDT.Columns.Add(convFrontAndBack4AppType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convFrontAndBack4AppType.AppTypeId4Back, Type.GetType("System.Int32"));
objDT.Columns.Add(convFrontAndBack4AppType.ApplTypeName4Back, Type.GetType("System.String"));
objDT.Columns.Add(convFrontAndBack4AppType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFrontAndBack4AppType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFrontAndBack4AppType.Memo, Type.GetType("System.String"));
foreach (clsvFrontAndBack4AppTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFrontAndBack4AppType.mId] = objInFor[convFrontAndBack4AppType.mId];
objDR[convFrontAndBack4AppType.OrderNum] = objInFor[convFrontAndBack4AppType.OrderNum];
objDR[convFrontAndBack4AppType.AppTypeId4Front] = objInFor[convFrontAndBack4AppType.AppTypeId4Front];
objDR[convFrontAndBack4AppType.ApplTypeName4Front] = objInFor[convFrontAndBack4AppType.ApplTypeName4Front];
objDR[convFrontAndBack4AppType.IsVisible] = objInFor[convFrontAndBack4AppType.IsVisible];
objDR[convFrontAndBack4AppType.AppTypeId4Back] = objInFor[convFrontAndBack4AppType.AppTypeId4Back];
objDR[convFrontAndBack4AppType.ApplTypeName4Back] = objInFor[convFrontAndBack4AppType.ApplTypeName4Back];
objDR[convFrontAndBack4AppType.UpdDate] = objInFor[convFrontAndBack4AppType.UpdDate];
objDR[convFrontAndBack4AppType.UpdUser] = objInFor[convFrontAndBack4AppType.UpdUser];
objDR[convFrontAndBack4AppType.Memo] = objInFor[convFrontAndBack4AppType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}