
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectAppRelaWApi
 表名:CMProjectAppRela(00050600)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMProjectAppRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetCMProjectAppRelaId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
objCMProjectAppRelaEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.CMProjectAppRelaId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.CMProjectAppRelaId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.CMProjectAppRelaId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetCmPrjId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProjectAppRela.CmPrjId);
objCMProjectAppRelaEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.CmPrjId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.CmPrjId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.CmPrjId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetApplicationTypeId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conCMProjectAppRela.ApplicationTypeId);
objCMProjectAppRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.ApplicationTypeId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.ApplicationTypeId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.ApplicationTypeId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetOrderNum(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMProjectAppRela.OrderNum);
objCMProjectAppRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.OrderNum) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.OrderNum, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.OrderNum] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetPrjId(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMProjectAppRela.PrjId);
objCMProjectAppRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.PrjId) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.PrjId, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.PrjId] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetUpdDate(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProjectAppRela.UpdDate);
objCMProjectAppRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.UpdDate) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.UpdDate, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.UpdDate] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetUpdUser(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMProjectAppRela.UpdUser);
objCMProjectAppRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.UpdUser) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.UpdUser, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.UpdUser] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectAppRelaEN SetMemo(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProjectAppRela.Memo);
objCMProjectAppRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(conCMProjectAppRela.Memo) == false)
{
objCMProjectAppRelaEN.dicFldComparisonOp.Add(conCMProjectAppRela.Memo, strComparisonOp);
}
else
{
objCMProjectAppRelaEN.dicFldComparisonOp[conCMProjectAppRela.Memo] = strComparisonOp;
}
}
return objCMProjectAppRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectAppRelaEN objCMProjectAppRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.CMProjectAppRelaId, objCMProjectAppRelaCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.CmPrjId, objCMProjectAppRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.ApplicationTypeId, objCMProjectAppRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectAppRela.OrderNum, objCMProjectAppRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.PrjId) == true)
{
string strComparisonOpPrjId = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.PrjId, objCMProjectAppRelaCond.PrjId, strComparisonOpPrjId);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.UpdDate, objCMProjectAppRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.UpdUser, objCMProjectAppRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMProjectAppRelaCond.IsUpdated(conCMProjectAppRela.Memo) == true)
{
string strComparisonOpMemo = objCMProjectAppRelaCond.dicFldComparisonOp[conCMProjectAppRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectAppRela.Memo, objCMProjectAppRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
 if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMProjectAppRelaEN.sfUpdFldSetStr = objCMProjectAppRelaEN.getsfUpdFldSetStr();
clsCMProjectAppRelaWApi.CheckPropertyNew(objCMProjectAppRelaEN); 
bool bolResult = clsCMProjectAppRelaWApi.UpdateRecord(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
 /// 获取唯一性条件串--CMProjectAppRela(CM项目应用关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CmPrjId_ApplicationTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectAppRelaEN == null) return "";
if (objCMProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objCMProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectAppRelaEN.CmPrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objCMProjectAppRelaEN.ApplicationTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectAppRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
try
{
clsCMProjectAppRelaWApi.CheckPropertyNew(objCMProjectAppRelaEN); 
bool bolResult = clsCMProjectAppRelaWApi.AddNewRecord(objCMProjectAppRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strWhereCond)
{
try
{
clsCMProjectAppRelaWApi.CheckPropertyNew(objCMProjectAppRelaEN); 
bool bolResult = clsCMProjectAppRelaWApi.UpdateWithCondition(objCMProjectAppRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
 /// CM项目应用关系(CMProjectAppRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectAppRelaWApi
{
private static readonly string mstrApiControllerName = "CMProjectAppRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCMProjectAppRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
if (!Object.Equals(null, objCMProjectAppRelaEN.CmPrjId) && GetStrLen(objCMProjectAppRelaEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objCMProjectAppRelaEN.PrjId) && GetStrLen(objCMProjectAppRelaEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMProjectAppRelaEN.UpdDate) && GetStrLen(objCMProjectAppRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectAppRelaEN.UpdUser) && GetStrLen(objCMProjectAppRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectAppRelaEN.Memo) && GetStrLen(objCMProjectAppRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCMProjectAppRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
if (lngCMProjectAppRelaId == 0) return null;
string strAction = "GetObjByCMProjectAppRelaId";
clsCMProjectAppRelaEN objCMProjectAppRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMProjectAppRelaEN = JsonConvert.DeserializeObject<clsCMProjectAppRelaEN>(strJson);
return objCMProjectAppRelaEN;
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
public static clsCMProjectAppRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMProjectAppRelaEN objCMProjectAppRelaEN;
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
objCMProjectAppRelaEN = JsonConvert.DeserializeObject<clsCMProjectAppRelaEN>(strJson);
return objCMProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLst_Sel =
from objCMProjectAppRelaEN in arrCMProjectAppRelaObjLstCache
where objCMProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId 
select objCMProjectAppRelaEN;
if (arrCMProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsCMProjectAppRelaEN obj = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCMProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLst(string strWhereCond)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaId)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
string strAction = "GetObjLstByCMProjectAppRelaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCMProjectAppRelaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLst_Sel =
from objCMProjectAppRelaEN in arrCMProjectAppRelaObjLstCache
where arrCMProjectAppRelaId.Contains(objCMProjectAppRelaEN.CMProjectAppRelaId)
select objCMProjectAppRelaEN;
return arrCMProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
public static List<clsCMProjectAppRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
public static List<clsCMProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
public static List<clsCMProjectAppRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectAppRelaEN>>(strJson);
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
public static int DelRecord(long lngCMProjectAppRelaId)
{
string strAction = "DelRecord";
try
{
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngCMProjectAppRelaId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
public static int DelCMProjectAppRelas(List<string> arrCMProjectAppRelaId)
{
string strAction = "DelCMProjectAppRelas";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCMProjectAppRelaId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsCMProjectAppRelaEN objCMProjectAppRelaEN = clsCMProjectAppRelaWApi.GetObjByCMProjectAppRelaId(long.Parse(arrCMProjectAppRelaId[0]));
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
public static int DelCMProjectAppRelasByCond(string strWhereCond)
{
string strAction = "DelCMProjectAppRelasByCond";
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
public static bool AddNewRecord(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectAppRelaEN>(objCMProjectAppRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
 /// <param name = "objCMProjectAppRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectAppRelaEN>(objCMProjectAppRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMProjectAppRelaWApi.ReFreshCache(objCMProjectAppRelaEN.PrjId);
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
public static bool UpdateRecord(clsCMProjectAppRelaEN objCMProjectAppRelaEN)
{
if (string.IsNullOrEmpty(objCMProjectAppRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectAppRelaEN.CMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectAppRelaEN>(objCMProjectAppRelaEN);
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
 /// <param name = "objCMProjectAppRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMProjectAppRelaEN objCMProjectAppRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMProjectAppRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectAppRelaEN.CMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectAppRelaEN.CMProjectAppRelaId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectAppRelaEN>(objCMProjectAppRelaEN);
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
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString()
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
 /// <param name = "objCMProjectAppRelaENS">源对象</param>
 /// <param name = "objCMProjectAppRelaENT">目标对象</param>
 public static void CopyTo(clsCMProjectAppRelaEN objCMProjectAppRelaENS, clsCMProjectAppRelaEN objCMProjectAppRelaENT)
{
try
{
objCMProjectAppRelaENT.CMProjectAppRelaId = objCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objCMProjectAppRelaENT.CmPrjId = objCMProjectAppRelaENS.CmPrjId; //Cm工程Id
objCMProjectAppRelaENT.ApplicationTypeId = objCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objCMProjectAppRelaENT.OrderNum = objCMProjectAppRelaENS.OrderNum; //序号
objCMProjectAppRelaENT.PrjId = objCMProjectAppRelaENS.PrjId; //工程Id
objCMProjectAppRelaENT.UpdDate = objCMProjectAppRelaENS.UpdDate; //修改日期
objCMProjectAppRelaENT.UpdUser = objCMProjectAppRelaENS.UpdUser; //修改者
objCMProjectAppRelaENT.Memo = objCMProjectAppRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCMProjectAppRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMProjectAppRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMProjectAppRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMProjectAppRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMProjectAppRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMProjectAppRelaEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMProjectAppRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMProjectAppRelaWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCMProjectAppRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMProjectAppRelaWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMProjectAppRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMProjectAppRelaWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsCMProjectAppRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsCMProjectAppRelaEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conCMProjectAppRela.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMProjectAppRelaEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsCMProjectAppRelaEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMProjectAppRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMProjectAppRelaWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsCMProjectAppRelaEN> arrCMProjectAppRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrCMProjectAppRelaObjLstCache = CacheHelper.Get<List<clsCMProjectAppRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrCMProjectAppRelaObjLstCache = CacheHelper.Get<List<clsCMProjectAppRelaEN>>(strKey);
}
return arrCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMProjectAppRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMProjectAppRela.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCMProjectAppRela.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectAppRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMProjectAppRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMProjectAppRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectAppRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectAppRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectAppRela.Memo, Type.GetType("System.String"));
foreach (clsCMProjectAppRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMProjectAppRela.CMProjectAppRelaId] = objInFor[conCMProjectAppRela.CMProjectAppRelaId];
objDR[conCMProjectAppRela.CmPrjId] = objInFor[conCMProjectAppRela.CmPrjId];
objDR[conCMProjectAppRela.ApplicationTypeId] = objInFor[conCMProjectAppRela.ApplicationTypeId];
objDR[conCMProjectAppRela.OrderNum] = objInFor[conCMProjectAppRela.OrderNum];
objDR[conCMProjectAppRela.PrjId] = objInFor[conCMProjectAppRela.PrjId];
objDR[conCMProjectAppRela.UpdDate] = objInFor[conCMProjectAppRela.UpdDate];
objDR[conCMProjectAppRela.UpdUser] = objInFor[conCMProjectAppRela.UpdUser];
objDR[conCMProjectAppRela.Memo] = objInFor[conCMProjectAppRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM项目应用关系(CMProjectAppRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMProjectAppRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsCMProjectAppRelaWApi.ReFreshThisCache(strPrjId);
}
}

}