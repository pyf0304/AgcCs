
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GeneTabCodeWApi
 表名:Log4GeneTabCode(00050279)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
public static class  clsLog4GeneTabCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetmId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, long lngmId, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.mId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.mId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.mId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetUserId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conLog4GeneTabCode.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conLog4GeneTabCode.UserId);
objLog4GeneTabCodeEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.UserId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.UserId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.UserId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetTabId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conLog4GeneTabCode.TabId);
objLog4GeneTabCodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.TabId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.TabId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.TabId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetPrjId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conLog4GeneTabCode.PrjId);
objLog4GeneTabCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.PrjId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.PrjId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.PrjId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGcPathId">GC路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetGcPathId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strGcPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conLog4GeneTabCode.GcPathId);
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conLog4GeneTabCode.GcPathId);
objLog4GeneTabCodeEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.GcPathId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.GcPathId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.GcPathId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetGeneCodeDate(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conLog4GeneTabCode.GeneCodeDate);
objLog4GeneTabCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.GeneCodeDate) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.GeneCodeDate, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.GeneCodeDate] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGene">是否需要生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetIsNeedGene(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.IsNeedGene) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.IsNeedGene, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.IsNeedGene] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersionGeneCode">生成代码版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetVersionGeneCode(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionGeneCode, conLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, conLog4GeneTabCode.VersionGeneCode);
objLog4GeneTabCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.VersionGeneCode) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.VersionGeneCode, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.VersionGeneCode] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetApplicationTypeId(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, int intApplicationTypeId, string strComparisonOp="")
	{
objLog4GeneTabCodeEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.ApplicationTypeId) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.ApplicationTypeId, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.ApplicationTypeId] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsLog4GeneTabCodeEN SetMemo(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conLog4GeneTabCode.Memo);
objLog4GeneTabCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objLog4GeneTabCodeEN.dicFldComparisonOp.ContainsKey(conLog4GeneTabCode.Memo) == false)
{
objLog4GeneTabCodeEN.dicFldComparisonOp.Add(conLog4GeneTabCode.Memo, strComparisonOp);
}
else
{
objLog4GeneTabCodeEN.dicFldComparisonOp[conLog4GeneTabCode.Memo] = strComparisonOp;
}
}
return objLog4GeneTabCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.mId) == true)
{
string strComparisonOpmId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4GeneTabCode.mId, objLog4GeneTabCodeCond.mId, strComparisonOpmId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.UserId) == true)
{
string strComparisonOpUserId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.UserId, objLog4GeneTabCodeCond.UserId, strComparisonOpUserId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.TabId) == true)
{
string strComparisonOpTabId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.TabId, objLog4GeneTabCodeCond.TabId, strComparisonOpTabId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.PrjId) == true)
{
string strComparisonOpPrjId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.PrjId, objLog4GeneTabCodeCond.PrjId, strComparisonOpPrjId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.GcPathId) == true)
{
string strComparisonOpGcPathId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.GcPathId, objLog4GeneTabCodeCond.GcPathId, strComparisonOpGcPathId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.GeneCodeDate, objLog4GeneTabCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.IsNeedGene) == true)
{
if (objLog4GeneTabCodeCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", conLog4GeneTabCode.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conLog4GeneTabCode.IsNeedGene);
}
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.VersionGeneCode, objLog4GeneTabCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conLog4GeneTabCode.ApplicationTypeId, objLog4GeneTabCodeCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objLog4GeneTabCodeCond.IsUpdated(conLog4GeneTabCode.Memo) == true)
{
string strComparisonOpMemo = objLog4GeneTabCodeCond.dicFldComparisonOp[conLog4GeneTabCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conLog4GeneTabCode.Memo, objLog4GeneTabCodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objLog4GeneTabCodeEN.sfUpdFldSetStr = objLog4GeneTabCodeEN.getsfUpdFldSetStr();
clsLog4GeneTabCodeWApi.CheckPropertyNew(objLog4GeneTabCodeEN); 
bool bolResult = clsLog4GeneTabCodeWApi.UpdateRecord(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--Log4GeneTabCode(生成表代码日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_GCPathId_ApplicationTypeId_UserId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objLog4GeneTabCodeEN == null) return "";
if (objLog4GeneTabCodeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objLog4GeneTabCodeEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
try
{
clsLog4GeneTabCodeWApi.CheckPropertyNew(objLog4GeneTabCodeEN); 
bool bolResult = clsLog4GeneTabCodeWApi.AddNewRecord(objLog4GeneTabCodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strWhereCond)
{
try
{
clsLog4GeneTabCodeWApi.CheckPropertyNew(objLog4GeneTabCodeEN); 
bool bolResult = clsLog4GeneTabCodeWApi.UpdateWithCondition(objLog4GeneTabCodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 生成表代码日志(Log4GeneTabCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsLog4GeneTabCodeWApi
{
private static readonly string mstrApiControllerName = "Log4GeneTabCodeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsLog4GeneTabCodeWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
if (!Object.Equals(null, objLog4GeneTabCodeEN.UserId) && GetStrLen(objLog4GeneTabCodeEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.TabId) && GetStrLen(objLog4GeneTabCodeEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.PrjId) && GetStrLen(objLog4GeneTabCodeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.GcPathId) && GetStrLen(objLog4GeneTabCodeEN.GcPathId) > 8)
{
 throw new Exception("字段[GC路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.GeneCodeDate) && GetStrLen(objLog4GeneTabCodeEN.GeneCodeDate) > 20)
{
 throw new Exception("字段[生成代码日期]的长度不能超过20!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.VersionGeneCode) && GetStrLen(objLog4GeneTabCodeEN.VersionGeneCode) > 30)
{
 throw new Exception("字段[生成代码版本]的长度不能超过30!");
}
if (!Object.Equals(null, objLog4GeneTabCodeEN.Memo) && GetStrLen(objLog4GeneTabCodeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objLog4GeneTabCodeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsLog4GeneTabCodeEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsLog4GeneTabCodeEN objLog4GeneTabCodeEN;
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
objLog4GeneTabCodeEN = JsonConvert.DeserializeObject<clsLog4GeneTabCodeEN>(strJson);
return objLog4GeneTabCodeEN;
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
public static clsLog4GeneTabCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsLog4GeneTabCodeEN objLog4GeneTabCodeEN;
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
objLog4GeneTabCodeEN = JsonConvert.DeserializeObject<clsLog4GeneTabCodeEN>(strJson);
return objLog4GeneTabCodeEN;
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
public static List<clsLog4GeneTabCodeEN> GetObjLst(string strWhereCond)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
public static List<clsLog4GeneTabCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
public static List<clsLog4GeneTabCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsLog4GeneTabCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsLog4GeneTabCodeEN>>(strJson);
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
 clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = clsLog4GeneTabCodeWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelLog4GeneTabCodes(List<string> arrmId)
{
string strAction = "DelLog4GeneTabCodes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelLog4GeneTabCodesByCond(string strWhereCond)
{
string strAction = "DelLog4GeneTabCodesByCond";
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
public static bool AddNewRecord(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4GeneTabCodeEN>(objLog4GeneTabCodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4GeneTabCodeEN>(objLog4GeneTabCodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
if (string.IsNullOrEmpty(objLog4GeneTabCodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4GeneTabCodeEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4GeneTabCodeEN>(objLog4GeneTabCodeEN);
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objLog4GeneTabCodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4GeneTabCodeEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objLog4GeneTabCodeEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsLog4GeneTabCodeEN>(objLog4GeneTabCodeEN);
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
 /// <param name = "objLog4GeneTabCodeENS">源对象</param>
 /// <param name = "objLog4GeneTabCodeENT">目标对象</param>
 public static void CopyTo(clsLog4GeneTabCodeEN objLog4GeneTabCodeENS, clsLog4GeneTabCodeEN objLog4GeneTabCodeENT)
{
try
{
objLog4GeneTabCodeENT.mId = objLog4GeneTabCodeENS.mId; //mId
objLog4GeneTabCodeENT.UserId = objLog4GeneTabCodeENS.UserId; //用户Id
objLog4GeneTabCodeENT.TabId = objLog4GeneTabCodeENS.TabId; //表ID
objLog4GeneTabCodeENT.PrjId = objLog4GeneTabCodeENS.PrjId; //工程Id
objLog4GeneTabCodeENT.GcPathId = objLog4GeneTabCodeENS.GcPathId; //GC路径Id
objLog4GeneTabCodeENT.GeneCodeDate = objLog4GeneTabCodeENS.GeneCodeDate; //生成代码日期
objLog4GeneTabCodeENT.IsNeedGene = objLog4GeneTabCodeENS.IsNeedGene; //是否需要生成
objLog4GeneTabCodeENT.VersionGeneCode = objLog4GeneTabCodeENS.VersionGeneCode; //生成代码版本
objLog4GeneTabCodeENT.ApplicationTypeId = objLog4GeneTabCodeENS.ApplicationTypeId; //应用程序类型ID
objLog4GeneTabCodeENT.Memo = objLog4GeneTabCodeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsLog4GeneTabCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsLog4GeneTabCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsLog4GeneTabCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsLog4GeneTabCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsLog4GeneTabCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsLog4GeneTabCodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
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
if (clsLog4GeneTabCodeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsLog4GeneTabCodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsLog4GeneTabCodeWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsLog4GeneTabCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conLog4GeneTabCode.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conLog4GeneTabCode.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.GcPathId, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(conLog4GeneTabCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(conLog4GeneTabCode.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conLog4GeneTabCode.Memo, Type.GetType("System.String"));
foreach (clsLog4GeneTabCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conLog4GeneTabCode.mId] = objInFor[conLog4GeneTabCode.mId];
objDR[conLog4GeneTabCode.UserId] = objInFor[conLog4GeneTabCode.UserId];
objDR[conLog4GeneTabCode.TabId] = objInFor[conLog4GeneTabCode.TabId];
objDR[conLog4GeneTabCode.PrjId] = objInFor[conLog4GeneTabCode.PrjId];
objDR[conLog4GeneTabCode.GcPathId] = objInFor[conLog4GeneTabCode.GcPathId];
objDR[conLog4GeneTabCode.GeneCodeDate] = objInFor[conLog4GeneTabCode.GeneCodeDate];
objDR[conLog4GeneTabCode.IsNeedGene] = objInFor[conLog4GeneTabCode.IsNeedGene];
objDR[conLog4GeneTabCode.VersionGeneCode] = objInFor[conLog4GeneTabCode.VersionGeneCode];
objDR[conLog4GeneTabCode.ApplicationTypeId] = objInFor[conLog4GeneTabCode.ApplicationTypeId];
objDR[conLog4GeneTabCode.Memo] = objInFor[conLog4GeneTabCode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 生成表代码日志(Log4GeneTabCode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Log4GeneTabCode : clsCommFun4BL
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
clsLog4GeneTabCodeWApi.ReFreshThisCache();
}
}

}