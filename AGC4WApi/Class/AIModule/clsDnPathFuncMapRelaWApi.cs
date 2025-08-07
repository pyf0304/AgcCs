
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathFuncMapRelaWApi
 表名:DnPathFuncMapRela(00050601)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:27
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
public static class  clsDnPathFuncMapRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetmId(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, long lngmId, string strComparisonOp="")
	{
objDnPathFuncMapRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.mId) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.mId, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.mId] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathId">DN路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetDnPathId(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strDnPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathId, conDnPathFuncMapRela.DnPathId);
clsCheckSql.CheckFieldLen(strDnPathId, 8, conDnPathFuncMapRela.DnPathId);
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conDnPathFuncMapRela.DnPathId);
objDnPathFuncMapRelaEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.DnPathId) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.DnPathId, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.DnPathId] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetDnFuncMapId(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnFuncMapId, conDnPathFuncMapRela.DnFuncMapId);
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, conDnPathFuncMapRela.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, conDnPathFuncMapRela.DnFuncMapId);
objDnPathFuncMapRelaEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.DnFuncMapId) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.DnFuncMapId, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.DnFuncMapId] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetPrjId(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnPathFuncMapRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnPathFuncMapRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnPathFuncMapRela.PrjId);
objDnPathFuncMapRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.PrjId) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.PrjId, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.PrjId] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetUpdDate(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnPathFuncMapRela.UpdDate);
objDnPathFuncMapRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.UpdDate) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.UpdDate, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.UpdDate] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetUpdUser(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnPathFuncMapRela.UpdUser);
objDnPathFuncMapRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.UpdUser) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.UpdUser, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.UpdUser] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathFuncMapRelaEN SetMemo(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnPathFuncMapRela.Memo);
objDnPathFuncMapRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathFuncMapRelaEN.dicFldComparisonOp.ContainsKey(conDnPathFuncMapRela.Memo) == false)
{
objDnPathFuncMapRelaEN.dicFldComparisonOp.Add(conDnPathFuncMapRela.Memo, strComparisonOp);
}
else
{
objDnPathFuncMapRelaEN.dicFldComparisonOp[conDnPathFuncMapRela.Memo] = strComparisonOp;
}
}
return objDnPathFuncMapRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.mId) == true)
{
string strComparisonOpmId = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPathFuncMapRela.mId, objDnPathFuncMapRelaCond.mId, strComparisonOpmId);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.DnPathId) == true)
{
string strComparisonOpDnPathId = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.DnPathId, objDnPathFuncMapRelaCond.DnPathId, strComparisonOpDnPathId);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.DnFuncMapId, objDnPathFuncMapRelaCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.PrjId) == true)
{
string strComparisonOpPrjId = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.PrjId, objDnPathFuncMapRelaCond.PrjId, strComparisonOpPrjId);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.UpdDate, objDnPathFuncMapRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.UpdUser, objDnPathFuncMapRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnPathFuncMapRelaCond.IsUpdated(conDnPathFuncMapRela.Memo) == true)
{
string strComparisonOpMemo = objDnPathFuncMapRelaCond.dicFldComparisonOp[conDnPathFuncMapRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPathFuncMapRela.Memo, objDnPathFuncMapRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
 if (objDnPathFuncMapRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDnPathFuncMapRelaEN.sfUpdFldSetStr = objDnPathFuncMapRelaEN.getsfUpdFldSetStr();
clsDnPathFuncMapRelaWApi.CheckPropertyNew(objDnPathFuncMapRelaEN); 
bool bolResult = clsDnPathFuncMapRelaWApi.UpdateRecord(objDnPathFuncMapRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
 /// 获取唯一性条件串--DnPathFuncMapRela(Dn路径函数映射关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DnPathId_DnFuncMapId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnPathFuncMapRelaEN == null) return "";
if (objDnPathFuncMapRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnPathId = '{0}'", objDnPathFuncMapRelaEN.DnPathId);
 sbCondition.AppendFormat(" and DnFuncMapId = '{0}'", objDnPathFuncMapRelaEN.DnFuncMapId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDnPathFuncMapRelaEN.mId);
 sbCondition.AppendFormat(" and DnPathId = '{0}'", objDnPathFuncMapRelaEN.DnPathId);
 sbCondition.AppendFormat(" and DnFuncMapId = '{0}'", objDnPathFuncMapRelaEN.DnFuncMapId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
try
{
clsDnPathFuncMapRelaWApi.CheckPropertyNew(objDnPathFuncMapRelaEN); 
bool bolResult = clsDnPathFuncMapRelaWApi.AddNewRecord(objDnPathFuncMapRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
 /// <param name = "objDnPathFuncMapRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strWhereCond)
{
try
{
clsDnPathFuncMapRelaWApi.CheckPropertyNew(objDnPathFuncMapRelaEN); 
bool bolResult = clsDnPathFuncMapRelaWApi.UpdateWithCondition(objDnPathFuncMapRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
 /// Dn路径函数映射关系(DnPathFuncMapRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDnPathFuncMapRelaWApi
{
private static readonly string mstrApiControllerName = "DnPathFuncMapRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDnPathFuncMapRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
if (!Object.Equals(null, objDnPathFuncMapRelaEN.DnPathId) && GetStrLen(objDnPathFuncMapRelaEN.DnPathId) > 8)
{
 throw new Exception("字段[DN路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnPathFuncMapRelaEN.DnFuncMapId) && GetStrLen(objDnPathFuncMapRelaEN.DnFuncMapId) > 8)
{
 throw new Exception("字段[函数映射Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnPathFuncMapRelaEN.PrjId) && GetStrLen(objDnPathFuncMapRelaEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDnPathFuncMapRelaEN.UpdDate) && GetStrLen(objDnPathFuncMapRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDnPathFuncMapRelaEN.UpdUser) && GetStrLen(objDnPathFuncMapRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDnPathFuncMapRelaEN.Memo) && GetStrLen(objDnPathFuncMapRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDnPathFuncMapRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnPathFuncMapRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN;
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
objDnPathFuncMapRelaEN = JsonConvert.DeserializeObject<clsDnPathFuncMapRelaEN>(strJson);
return objDnPathFuncMapRelaEN;
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
public static clsDnPathFuncMapRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN;
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
objDnPathFuncMapRelaEN = JsonConvert.DeserializeObject<clsDnPathFuncMapRelaEN>(strJson);
return objDnPathFuncMapRelaEN;
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
public static clsDnPathFuncMapRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDnPathFuncMapRelaEN._CurrTabName);
List<clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLst_Sel =
from objDnPathFuncMapRelaEN in arrDnPathFuncMapRelaObjLstCache
where objDnPathFuncMapRelaEN.mId == lngmId 
select objDnPathFuncMapRelaEN;
if (arrDnPathFuncMapRelaObjLst_Sel.Count() == 0)
{
   clsDnPathFuncMapRelaEN obj = clsDnPathFuncMapRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDnPathFuncMapRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathFuncMapRelaEN> GetObjLst(string strWhereCond)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
public static List<clsDnPathFuncMapRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
public static IEnumerable<clsDnPathFuncMapRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDnPathFuncMapRelaEN._CurrTabName);
List<clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLst_Sel =
from objDnPathFuncMapRelaEN in arrDnPathFuncMapRelaObjLstCache
where arrMId.Contains(objDnPathFuncMapRelaEN.mId)
select objDnPathFuncMapRelaEN;
return arrDnPathFuncMapRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathFuncMapRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
public static List<clsDnPathFuncMapRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
public static List<clsDnPathFuncMapRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
public static List<clsDnPathFuncMapRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDnPathFuncMapRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathFuncMapRelaEN>>(strJson);
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
 clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN = clsDnPathFuncMapRelaWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
public static int DelDnPathFuncMapRelas(List<string> arrmId)
{
string strAction = "DelDnPathFuncMapRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
public static int DelDnPathFuncMapRelasByCond(string strWhereCond)
{
string strAction = "DelDnPathFuncMapRelasByCond";
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
public static bool AddNewRecord(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathFuncMapRelaEN>(objDnPathFuncMapRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
 /// <param name = "objDnPathFuncMapRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathFuncMapRelaEN>(objDnPathFuncMapRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
if (string.IsNullOrEmpty(objDnPathFuncMapRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathFuncMapRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathFuncMapRelaEN>(objDnPathFuncMapRelaEN);
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
 /// <param name = "objDnPathFuncMapRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDnPathFuncMapRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathFuncMapRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathFuncMapRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathFuncMapRelaEN>(objDnPathFuncMapRelaEN);
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
 /// <param name = "objDnPathFuncMapRelaENS">源对象</param>
 /// <param name = "objDnPathFuncMapRelaENT">目标对象</param>
 public static void CopyTo(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENS, clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENT)
{
try
{
objDnPathFuncMapRelaENT.mId = objDnPathFuncMapRelaENS.mId; //mId
objDnPathFuncMapRelaENT.DnPathId = objDnPathFuncMapRelaENS.DnPathId; //DN路径Id
objDnPathFuncMapRelaENT.DnFuncMapId = objDnPathFuncMapRelaENS.DnFuncMapId; //函数映射Id
objDnPathFuncMapRelaENT.PrjId = objDnPathFuncMapRelaENS.PrjId; //工程Id
objDnPathFuncMapRelaENT.UpdDate = objDnPathFuncMapRelaENS.UpdDate; //修改日期
objDnPathFuncMapRelaENT.UpdUser = objDnPathFuncMapRelaENS.UpdUser; //修改者
objDnPathFuncMapRelaENT.Memo = objDnPathFuncMapRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDnPathFuncMapRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDnPathFuncMapRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDnPathFuncMapRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDnPathFuncMapRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDnPathFuncMapRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDnPathFuncMapRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsDnPathFuncMapRelaEN._CurrTabName);
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
if (clsDnPathFuncMapRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDnPathFuncMapRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDnPathFuncMapRelaWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnPathFuncMapRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDnPathFuncMapRelaEN._CurrTabName;
List<clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDnPathFuncMapRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDnPathFuncMapRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDnPathFuncMapRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDnPathFuncMapRela.DnPathId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPathFuncMapRela.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPathFuncMapRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPathFuncMapRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDnPathFuncMapRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDnPathFuncMapRela.Memo, Type.GetType("System.String"));
foreach (clsDnPathFuncMapRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDnPathFuncMapRela.mId] = objInFor[conDnPathFuncMapRela.mId];
objDR[conDnPathFuncMapRela.DnPathId] = objInFor[conDnPathFuncMapRela.DnPathId];
objDR[conDnPathFuncMapRela.DnFuncMapId] = objInFor[conDnPathFuncMapRela.DnFuncMapId];
objDR[conDnPathFuncMapRela.PrjId] = objInFor[conDnPathFuncMapRela.PrjId];
objDR[conDnPathFuncMapRela.UpdDate] = objInFor[conDnPathFuncMapRela.UpdDate];
objDR[conDnPathFuncMapRela.UpdUser] = objInFor[conDnPathFuncMapRela.UpdUser];
objDR[conDnPathFuncMapRela.Memo] = objInFor[conDnPathFuncMapRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Dn路径函数映射关系(DnPathFuncMapRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DnPathFuncMapRela : clsCommFun4BL
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
clsDnPathFuncMapRelaWApi.ReFreshThisCache();
}
}

}