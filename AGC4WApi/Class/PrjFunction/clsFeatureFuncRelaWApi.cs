
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureFuncRelaWApi
 表名:FeatureFuncRela(00050397)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:35
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
public static class  clsFeatureFuncRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetmId(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, long lngmId, string strComparisonOp="")
	{
objFeatureFuncRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.mId) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.mId, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.mId] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetApplicationTypeId(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conFeatureFuncRela.ApplicationTypeId);
objFeatureFuncRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.ApplicationTypeId) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.ApplicationTypeId, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.ApplicationTypeId] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetFeatureId(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, conFeatureFuncRela.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, conFeatureFuncRela.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, conFeatureFuncRela.FeatureId);
objFeatureFuncRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.FeatureId) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.FeatureId, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.FeatureId] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetFuncId4GC(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFeatureFuncRela.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFeatureFuncRela.FuncId4GC);
objFeatureFuncRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.FuncId4GC) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.FuncId4GC, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.FuncId4GC] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetUpdDate(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFeatureFuncRela.UpdDate);
objFeatureFuncRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.UpdDate) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.UpdDate, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.UpdDate] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetUpdUser(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFeatureFuncRela.UpdUser);
objFeatureFuncRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.UpdUser) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.UpdUser, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.UpdUser] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFeatureFuncRelaEN SetMemo(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFeatureFuncRela.Memo);
objFeatureFuncRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFeatureFuncRelaEN.dicFldComparisonOp.ContainsKey(conFeatureFuncRela.Memo) == false)
{
objFeatureFuncRelaEN.dicFldComparisonOp.Add(conFeatureFuncRela.Memo, strComparisonOp);
}
else
{
objFeatureFuncRelaEN.dicFldComparisonOp[conFeatureFuncRela.Memo] = strComparisonOp;
}
}
return objFeatureFuncRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFeatureFuncRelaEN objFeatureFuncRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.mId) == true)
{
string strComparisonOpmId = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureFuncRela.mId, objFeatureFuncRelaCond.mId, strComparisonOpmId);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conFeatureFuncRela.ApplicationTypeId, objFeatureFuncRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureFuncRela.FeatureId, objFeatureFuncRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureFuncRela.FuncId4GC, objFeatureFuncRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureFuncRela.UpdDate, objFeatureFuncRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureFuncRela.UpdUser, objFeatureFuncRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFeatureFuncRelaCond.IsUpdated(conFeatureFuncRela.Memo) == true)
{
string strComparisonOpMemo = objFeatureFuncRelaCond.dicFldComparisonOp[conFeatureFuncRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFeatureFuncRela.Memo, objFeatureFuncRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
 if (objFeatureFuncRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFeatureFuncRelaEN.sfUpdFldSetStr = objFeatureFuncRelaEN.getsfUpdFldSetStr();
clsFeatureFuncRelaWApi.CheckPropertyNew(objFeatureFuncRelaEN); 
bool bolResult = clsFeatureFuncRelaWApi.UpdateRecord(objFeatureFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
 /// 获取唯一性条件串--FeatureFuncRela(功能函数关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_FeatureId_FuncId4GC
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFeatureFuncRelaEN == null) return "";
if (objFeatureFuncRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureFuncRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureFuncRelaEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFeatureFuncRelaEN.FuncId4GC);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFeatureFuncRelaEN.mId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objFeatureFuncRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureFuncRelaEN.FeatureId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFeatureFuncRelaEN.FuncId4GC);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
try
{
clsFeatureFuncRelaWApi.CheckPropertyNew(objFeatureFuncRelaEN); 
bool bolResult = clsFeatureFuncRelaWApi.AddNewRecord(objFeatureFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strWhereCond)
{
try
{
clsFeatureFuncRelaWApi.CheckPropertyNew(objFeatureFuncRelaEN); 
bool bolResult = clsFeatureFuncRelaWApi.UpdateWithCondition(objFeatureFuncRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
 /// 功能函数关系(FeatureFuncRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFeatureFuncRelaWApi
{
private static readonly string mstrApiControllerName = "FeatureFuncRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFeatureFuncRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
if (!Object.Equals(null, objFeatureFuncRelaEN.FeatureId) && GetStrLen(objFeatureFuncRelaEN.FeatureId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFeatureFuncRelaEN.FuncId4GC) && GetStrLen(objFeatureFuncRelaEN.FuncId4GC) > 10)
{
 throw new Exception("字段[函数ID]的长度不能超过10!");
}
if (!Object.Equals(null, objFeatureFuncRelaEN.UpdDate) && GetStrLen(objFeatureFuncRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFeatureFuncRelaEN.UpdUser) && GetStrLen(objFeatureFuncRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFeatureFuncRelaEN.Memo) && GetStrLen(objFeatureFuncRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFeatureFuncRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFeatureFuncRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsFeatureFuncRelaEN objFeatureFuncRelaEN;
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
objFeatureFuncRelaEN = JsonConvert.DeserializeObject<clsFeatureFuncRelaEN>(strJson);
return objFeatureFuncRelaEN;
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
public static clsFeatureFuncRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFeatureFuncRelaEN objFeatureFuncRelaEN;
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
objFeatureFuncRelaEN = JsonConvert.DeserializeObject<clsFeatureFuncRelaEN>(strJson);
return objFeatureFuncRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFeatureFuncRelaEN GetObjBymIdCache(long lngmId,int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLstCache = GetObjLstCache(intApplicationTypeId);
IEnumerable <clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLst_Sel =
from objFeatureFuncRelaEN in arrFeatureFuncRelaObjLstCache
where objFeatureFuncRelaEN.mId == lngmId 
select objFeatureFuncRelaEN;
if (arrFeatureFuncRelaObjLst_Sel.Count() == 0)
{
   clsFeatureFuncRelaEN obj = clsFeatureFuncRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFeatureFuncRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureFuncRelaEN> GetObjLst(string strWhereCond)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
public static List<clsFeatureFuncRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFeatureFuncRelaEN> GetObjLstByMIdLstCache(List<long> arrMId, int intApplicationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLstCache = GetObjLstCache(intApplicationTypeId);
IEnumerable <clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLst_Sel =
from objFeatureFuncRelaEN in arrFeatureFuncRelaObjLstCache
where arrMId.Contains(objFeatureFuncRelaEN.mId)
select objFeatureFuncRelaEN;
return arrFeatureFuncRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFeatureFuncRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
public static List<clsFeatureFuncRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
public static List<clsFeatureFuncRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
public static List<clsFeatureFuncRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFeatureFuncRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFeatureFuncRelaEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsFeatureFuncRelaEN objFeatureFuncRelaEN = clsFeatureFuncRelaWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
public static int DelFeatureFuncRelas(List<string> arrmId)
{
string strAction = "DelFeatureFuncRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFeatureFuncRelaEN objFeatureFuncRelaEN = clsFeatureFuncRelaWApi.GetObjBymId(long.Parse(arrmId[0]));
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
public static int DelFeatureFuncRelasByCond(string strWhereCond)
{
string strAction = "DelFeatureFuncRelasByCond";
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
public static bool AddNewRecord(clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureFuncRelaEN>(objFeatureFuncRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objFeatureFuncRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureFuncRelaEN>(objFeatureFuncRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFeatureFuncRelaWApi.ReFreshCache(objFeatureFuncRelaEN.ApplicationTypeId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsFeatureFuncRelaEN objFeatureFuncRelaEN)
{
if (string.IsNullOrEmpty(objFeatureFuncRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureFuncRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureFuncRelaEN>(objFeatureFuncRelaEN);
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
 /// <param name = "objFeatureFuncRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFeatureFuncRelaEN objFeatureFuncRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFeatureFuncRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureFuncRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFeatureFuncRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFeatureFuncRelaEN>(objFeatureFuncRelaEN);
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
 /// <param name = "objFeatureFuncRelaENS">源对象</param>
 /// <param name = "objFeatureFuncRelaENT">目标对象</param>
 public static void CopyTo(clsFeatureFuncRelaEN objFeatureFuncRelaENS, clsFeatureFuncRelaEN objFeatureFuncRelaENT)
{
try
{
objFeatureFuncRelaENT.mId = objFeatureFuncRelaENS.mId; //mId
objFeatureFuncRelaENT.ApplicationTypeId = objFeatureFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objFeatureFuncRelaENT.FeatureId = objFeatureFuncRelaENS.FeatureId; //功能Id
objFeatureFuncRelaENT.FuncId4GC = objFeatureFuncRelaENS.FuncId4GC; //函数ID
objFeatureFuncRelaENT.UpdDate = objFeatureFuncRelaENS.UpdDate; //修改日期
objFeatureFuncRelaENT.UpdUser = objFeatureFuncRelaENS.UpdUser; //修改者
objFeatureFuncRelaENT.Memo = objFeatureFuncRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFeatureFuncRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFeatureFuncRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFeatureFuncRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFeatureFuncRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFeatureFuncRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFeatureFuncRelaEN._AttributeName)
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
public static void ReFreshThisCache(string intApplicationTypeId = "")
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsFeatureFuncRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
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
public static void ReFreshCache(int intApplicationTypeId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFeatureFuncRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
CacheHelper.Remove(strKey);
clsFeatureFuncRelaWApi.objCommFun4WApi.ReFreshCache(intApplicationTypeId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureFuncRelaEN> GetObjLstCache(int intApplicationTypeId)
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsFeatureFuncRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFeatureFuncRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFeatureFuncRelaEN._WhereFormat, intApplicationTypeId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFeatureFuncRela.ApplicationTypeId, intApplicationTypeId);
}
var strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFeatureFuncRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFeatureFuncRelaEN> GetObjLstCacheFromObjLst(int intApplicationTypeId,List<clsFeatureFuncRelaEN> arrObjLst_P)
{


if (intApplicationTypeId == 0)
{
  var strMsg = string.Format("参数:[intApplicationTypeId]不能为空！(In clsFeatureFuncRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
var strKey = string.Format("{0}_{1}", clsFeatureFuncRelaEN._CurrTabName, intApplicationTypeId);
List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFeatureFuncRelaObjLstCache = CacheHelper.Get<List<clsFeatureFuncRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.ApplicationTypeId == intApplicationTypeId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFeatureFuncRelaObjLstCache = CacheHelper.Get<List<clsFeatureFuncRelaEN>>(strKey);
}
return arrFeatureFuncRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFeatureFuncRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFeatureFuncRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conFeatureFuncRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conFeatureFuncRela.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureFuncRela.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureFuncRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureFuncRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFeatureFuncRela.Memo, Type.GetType("System.String"));
foreach (clsFeatureFuncRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFeatureFuncRela.mId] = objInFor[conFeatureFuncRela.mId];
objDR[conFeatureFuncRela.ApplicationTypeId] = objInFor[conFeatureFuncRela.ApplicationTypeId];
objDR[conFeatureFuncRela.FeatureId] = objInFor[conFeatureFuncRela.FeatureId];
objDR[conFeatureFuncRela.FuncId4GC] = objInFor[conFeatureFuncRela.FuncId4GC];
objDR[conFeatureFuncRela.UpdDate] = objInFor[conFeatureFuncRela.UpdDate];
objDR[conFeatureFuncRela.UpdUser] = objInFor[conFeatureFuncRela.UpdUser];
objDR[conFeatureFuncRela.Memo] = objInFor[conFeatureFuncRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能函数关系(FeatureFuncRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FeatureFuncRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string intApplicationTypeId)
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
clsFeatureFuncRelaWApi.ReFreshThisCache(intApplicationTypeId);
}
}

}