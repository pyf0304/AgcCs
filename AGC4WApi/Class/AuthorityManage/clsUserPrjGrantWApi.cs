
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantWApi
 表名:UserPrjGrant(00050092)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
public static class  clsUserPrjGrantWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetmId(this clsUserPrjGrantEN objUserPrjGrantEN, long lngmId, string strComparisonOp="")
	{
objUserPrjGrantEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.mId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.mId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.mId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetUserId(this clsUserPrjGrantEN objUserPrjGrantEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conUserPrjGrant.UserId);
objUserPrjGrantEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.UserId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.UserId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.UserId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetPrjId(this clsUserPrjGrantEN objUserPrjGrantEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserPrjGrant.PrjId);
objUserPrjGrantEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.PrjId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.PrjId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.PrjId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoleId">角色ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetRoleId(this clsUserPrjGrantEN objUserPrjGrantEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(strRoleId, 8, conUserPrjGrant.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conUserPrjGrant.RoleId);
objUserPrjGrantEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.RoleId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.RoleId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.RoleId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "intVisitedNum">访问数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetVisitedNum(this clsUserPrjGrantEN objUserPrjGrantEN, int intVisitedNum, string strComparisonOp="")
	{
objUserPrjGrantEN.VisitedNum = intVisitedNum; //访问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.VisitedNum) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.VisitedNum, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.VisitedNum] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strLastVisitedDate">最后访问时间</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetLastVisitedDate(this clsUserPrjGrantEN objUserPrjGrantEN, string strLastVisitedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, conUserPrjGrant.LastVisitedDate);
objUserPrjGrantEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.LastVisitedDate) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.LastVisitedDate, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.LastVisitedDate] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptId">操作者Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetOptId(this clsUserPrjGrantEN objUserPrjGrantEN, string strOptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptId, 18, conUserPrjGrant.OptId);
objUserPrjGrantEN.OptId = strOptId; //操作者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.OptId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.OptId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.OptId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strOptDate">操作日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetOptDate(this clsUserPrjGrantEN objUserPrjGrantEN, string strOptDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptDate, 20, conUserPrjGrant.OptDate);
objUserPrjGrantEN.OptDate = strOptDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.OptDate) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.OptDate, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.OptDate] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetMemo(this clsUserPrjGrantEN objUserPrjGrantEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserPrjGrant.Memo);
objUserPrjGrantEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.Memo) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.Memo, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.Memo] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserPrjGrantEN objUserPrjGrantCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.mId) == true)
{
string strComparisonOpmId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPrjGrant.mId, objUserPrjGrantCond.mId, strComparisonOpmId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.UserId) == true)
{
string strComparisonOpUserId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.UserId, objUserPrjGrantCond.UserId, strComparisonOpUserId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.PrjId) == true)
{
string strComparisonOpPrjId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.PrjId, objUserPrjGrantCond.PrjId, strComparisonOpPrjId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.RoleId) == true)
{
string strComparisonOpRoleId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.RoleId, objUserPrjGrantCond.RoleId, strComparisonOpRoleId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.VisitedNum) == true)
{
string strComparisonOpVisitedNum = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.VisitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPrjGrant.VisitedNum, objUserPrjGrantCond.VisitedNum, strComparisonOpVisitedNum);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.LastVisitedDate, objUserPrjGrantCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.OptId) == true)
{
string strComparisonOpOptId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.OptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.OptId, objUserPrjGrantCond.OptId, strComparisonOpOptId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.OptDate) == true)
{
string strComparisonOpOptDate = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.OptDate, objUserPrjGrantCond.OptDate, strComparisonOpOptDate);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.Memo) == true)
{
string strComparisonOpMemo = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.Memo, objUserPrjGrantCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objUserPrjGrantEN.sfUpdFldSetStr = objUserPrjGrantEN.getsfUpdFldSetStr();
clsUserPrjGrantWApi.CheckPropertyNew(objUserPrjGrantEN); 
bool bolResult = clsUserPrjGrantWApi.UpdateRecord(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
 /// 获取唯一性条件串--UserPrjGrant(UserPrjGrant), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_UserId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsUserPrjGrantEN objUserPrjGrantEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserPrjGrantEN == null) return "";
if (objUserPrjGrantEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserPrjGrantEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserPrjGrantEN objUserPrjGrantEN)
{
try
{
clsUserPrjGrantWApi.CheckPropertyNew(objUserPrjGrantEN); 
bool bolResult = clsUserPrjGrantWApi.AddNewRecord(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserPrjGrantEN objUserPrjGrantEN, string strWhereCond)
{
try
{
clsUserPrjGrantWApi.CheckPropertyNew(objUserPrjGrantEN); 
bool bolResult = clsUserPrjGrantWApi.UpdateWithCondition(objUserPrjGrantEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsUserPrjGrantWApi
{
private static readonly string mstrApiControllerName = "UserPrjGrantApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsUserPrjGrantWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsUserPrjGrantEN objUserPrjGrantEN)
{
if (!Object.Equals(null, objUserPrjGrantEN.UserId) && GetStrLen(objUserPrjGrantEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objUserPrjGrantEN.PrjId) && GetStrLen(objUserPrjGrantEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objUserPrjGrantEN.RoleId) && GetStrLen(objUserPrjGrantEN.RoleId) > 8)
{
 throw new Exception("字段[角色ID]的长度不能超过8!");
}
if (!Object.Equals(null, objUserPrjGrantEN.LastVisitedDate) && GetStrLen(objUserPrjGrantEN.LastVisitedDate) > 20)
{
 throw new Exception("字段[最后访问时间]的长度不能超过20!");
}
if (!Object.Equals(null, objUserPrjGrantEN.OptId) && GetStrLen(objUserPrjGrantEN.OptId) > 18)
{
 throw new Exception("字段[操作者Id]的长度不能超过18!");
}
if (!Object.Equals(null, objUserPrjGrantEN.OptDate) && GetStrLen(objUserPrjGrantEN.OptDate) > 20)
{
 throw new Exception("字段[操作日期]的长度不能超过20!");
}
if (!Object.Equals(null, objUserPrjGrantEN.Memo) && GetStrLen(objUserPrjGrantEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objUserPrjGrantEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserPrjGrantEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsUserPrjGrantEN objUserPrjGrantEN;
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
objUserPrjGrantEN = JsonConvert.DeserializeObject<clsUserPrjGrantEN>(strJson);
return objUserPrjGrantEN;
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
public static clsUserPrjGrantEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsUserPrjGrantEN objUserPrjGrantEN;
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
objUserPrjGrantEN = JsonConvert.DeserializeObject<clsUserPrjGrantEN>(strJson);
return objUserPrjGrantEN;
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
public static clsUserPrjGrantEN GetObjBymIdCache(long lngmId,string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsUserPrjGrantEN> arrUserPrjGrantObjLst_Sel =
from objUserPrjGrantEN in arrUserPrjGrantObjLstCache
where objUserPrjGrantEN.mId == lngmId 
select objUserPrjGrantEN;
if (arrUserPrjGrantObjLst_Sel.Count() == 0)
{
   clsUserPrjGrantEN obj = clsUserPrjGrantWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrUserPrjGrantObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLst(string strWhereCond)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
public static List<clsUserPrjGrantEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
public static IEnumerable<clsUserPrjGrantEN> GetObjLstByMIdLstCache(List<long> arrMId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsUserPrjGrantEN> arrUserPrjGrantObjLst_Sel =
from objUserPrjGrantEN in arrUserPrjGrantObjLstCache
where arrMId.Contains(objUserPrjGrantEN.mId)
select objUserPrjGrantEN;
return arrUserPrjGrantObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPrjGrantEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
public static List<clsUserPrjGrantEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
public static List<clsUserPrjGrantEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
public static List<clsUserPrjGrantEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsUserPrjGrantEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsUserPrjGrantEN>>(strJson);
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
 clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
public static int DelUserPrjGrants(List<string> arrmId)
{
string strAction = "DelUserPrjGrants";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantWApi.GetObjBymId(long.Parse(arrmId[0]));
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
public static int DelUserPrjGrantsByCond(string strWhereCond)
{
string strAction = "DelUserPrjGrantsByCond";
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
public static bool AddNewRecord(clsUserPrjGrantEN objUserPrjGrantEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPrjGrantEN>(objUserPrjGrantEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
 /// <param name = "objUserPrjGrantEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsUserPrjGrantEN objUserPrjGrantEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPrjGrantEN>(objUserPrjGrantEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantWApi.ReFreshCache(objUserPrjGrantEN.UserId);
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
public static bool UpdateRecord(clsUserPrjGrantEN objUserPrjGrantEN)
{
if (string.IsNullOrEmpty(objUserPrjGrantEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserPrjGrantEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPrjGrantEN>(objUserPrjGrantEN);
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsUserPrjGrantEN objUserPrjGrantEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objUserPrjGrantEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserPrjGrantEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objUserPrjGrantEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsUserPrjGrantEN>(objUserPrjGrantEN);
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
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
 public static void CopyTo(clsUserPrjGrantEN objUserPrjGrantENS, clsUserPrjGrantEN objUserPrjGrantENT)
{
try
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程Id
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsUserPrjGrantEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsUserPrjGrantEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsUserPrjGrantEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsUserPrjGrantEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsUserPrjGrantEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsUserPrjGrantEN._AttributeName)
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
public static void ReFreshThisCache(string strUserId = "")
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsUserPrjGrantWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
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
public static void ReFreshCache(string strUserId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsUserPrjGrantWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsUserPrjGrantWApi.objCommFun4WApi.ReFreshCache(strUserId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLstCache(string strUserId)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsUserPrjGrantWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsUserPrjGrantEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsUserPrjGrantEN._WhereFormat, strUserId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conUserPrjGrant.UserId, strUserId);
}
var strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrUserPrjGrantObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLstCacheFromObjLst(string strUserId,List<clsUserPrjGrantEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsUserPrjGrantWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
var strKey = string.Format("{0}_{1}", clsUserPrjGrantEN._CurrTabName, strUserId);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrUserPrjGrantObjLstCache = CacheHelper.Get<List<clsUserPrjGrantEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.UserId == strUserId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrUserPrjGrantObjLstCache = CacheHelper.Get<List<clsUserPrjGrantEN>>(strKey);
}
return arrUserPrjGrantObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsUserPrjGrantEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conUserPrjGrant.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conUserPrjGrant.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.VisitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conUserPrjGrant.LastVisitedDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.OptId, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.OptDate, Type.GetType("System.String"));
objDT.Columns.Add(conUserPrjGrant.Memo, Type.GetType("System.String"));
foreach (clsUserPrjGrantEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conUserPrjGrant.mId] = objInFor[conUserPrjGrant.mId];
objDR[conUserPrjGrant.UserId] = objInFor[conUserPrjGrant.UserId];
objDR[conUserPrjGrant.PrjId] = objInFor[conUserPrjGrant.PrjId];
objDR[conUserPrjGrant.RoleId] = objInFor[conUserPrjGrant.RoleId];
objDR[conUserPrjGrant.VisitedNum] = objInFor[conUserPrjGrant.VisitedNum];
objDR[conUserPrjGrant.LastVisitedDate] = objInFor[conUserPrjGrant.LastVisitedDate];
objDR[conUserPrjGrant.OptId] = objInFor[conUserPrjGrant.OptId];
objDR[conUserPrjGrant.OptDate] = objInFor[conUserPrjGrant.OptDate];
objDR[conUserPrjGrant.Memo] = objInFor[conUserPrjGrant.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// UserPrjGrant(UserPrjGrant)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4UserPrjGrant : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsUserPrjGrantWApi.ReFreshThisCache(strUserId);
}
}

}