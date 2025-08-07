
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMProjectFuncModuleWApi
 表名:CMProjectFuncModule(00050555)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:15
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
public static class  clsCMProjectFuncModuleWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetmId(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, long lngmId, string strComparisonOp="")
	{
objCMProjectFuncModuleEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.mId) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.mId, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.mId] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">Cm工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetCmPrjId(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMProjectFuncModule.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMProjectFuncModule.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMProjectFuncModule.CmPrjId);
objCMProjectFuncModuleEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.CmPrjId) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.CmPrjId, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.CmPrjId] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetFuncModuleAgcId(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, conCMProjectFuncModule.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMProjectFuncModule.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMProjectFuncModule.FuncModuleAgcId);
objCMProjectFuncModuleEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.FuncModuleAgcId) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetOrderNum(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMProjectFuncModule.OrderNum);
objCMProjectFuncModuleEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.OrderNum) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.OrderNum, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.OrderNum] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetPrjId(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMProjectFuncModule.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMProjectFuncModule.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMProjectFuncModule.PrjId);
objCMProjectFuncModuleEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.PrjId) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.PrjId, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.PrjId] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetUpdDate(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMProjectFuncModule.UpdDate);
objCMProjectFuncModuleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.UpdDate) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.UpdDate, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.UpdDate] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetUpdUser(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMProjectFuncModule.UpdUser);
objCMProjectFuncModuleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.UpdUser) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.UpdUser, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.UpdUser] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMProjectFuncModuleEN SetMemo(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMProjectFuncModule.Memo);
objCMProjectFuncModuleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMProjectFuncModuleEN.dicFldComparisonOp.ContainsKey(conCMProjectFuncModule.Memo) == false)
{
objCMProjectFuncModuleEN.dicFldComparisonOp.Add(conCMProjectFuncModule.Memo, strComparisonOp);
}
else
{
objCMProjectFuncModuleEN.dicFldComparisonOp[conCMProjectFuncModule.Memo] = strComparisonOp;
}
}
return objCMProjectFuncModuleEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMProjectFuncModuleEN objCMProjectFuncModuleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.mId) == true)
{
string strComparisonOpmId = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectFuncModule.mId, objCMProjectFuncModuleCond.mId, strComparisonOpmId);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.CmPrjId, objCMProjectFuncModuleCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.FuncModuleAgcId, objCMProjectFuncModuleCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMProjectFuncModule.OrderNum, objCMProjectFuncModuleCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.PrjId) == true)
{
string strComparisonOpPrjId = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.PrjId, objCMProjectFuncModuleCond.PrjId, strComparisonOpPrjId);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.UpdDate, objCMProjectFuncModuleCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.UpdUser, objCMProjectFuncModuleCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMProjectFuncModuleCond.IsUpdated(conCMProjectFuncModule.Memo) == true)
{
string strComparisonOpMemo = objCMProjectFuncModuleCond.dicFldComparisonOp[conCMProjectFuncModule.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMProjectFuncModule.Memo, objCMProjectFuncModuleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
 if (objCMProjectFuncModuleEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMProjectFuncModuleEN.sfUpdFldSetStr = objCMProjectFuncModuleEN.getsfUpdFldSetStr();
clsCMProjectFuncModuleWApi.CheckPropertyNew(objCMProjectFuncModuleEN); 
bool bolResult = clsCMProjectFuncModuleWApi.UpdateRecord(objCMProjectFuncModuleEN);
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
 /// 获取唯一性条件串--CMProjectFuncModule(CM项目模块关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMPrjId_FuncModuleAgcId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMProjectFuncModuleEN == null) return "";
if (objCMProjectFuncModuleEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectFuncModuleEN.CmPrjId);
 sbCondition.AppendFormat(" and FuncModuleAgcId = '{0}'", objCMProjectFuncModuleEN.FuncModuleAgcId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMProjectFuncModuleEN.mId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMProjectFuncModuleEN.CmPrjId);
 sbCondition.AppendFormat(" and FuncModuleAgcId = '{0}'", objCMProjectFuncModuleEN.FuncModuleAgcId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMProjectFuncModuleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
try
{
clsCMProjectFuncModuleWApi.CheckPropertyNew(objCMProjectFuncModuleEN); 
bool bolResult = clsCMProjectFuncModuleWApi.AddNewRecord(objCMProjectFuncModuleEN);
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
 /// <param name = "objCMProjectFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strWhereCond)
{
try
{
clsCMProjectFuncModuleWApi.CheckPropertyNew(objCMProjectFuncModuleEN); 
bool bolResult = clsCMProjectFuncModuleWApi.UpdateWithCondition(objCMProjectFuncModuleEN, strWhereCond);
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
 /// CM项目模块关系(CMProjectFuncModule)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMProjectFuncModuleWApi
{
private static readonly string mstrApiControllerName = "CMProjectFuncModuleApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCMProjectFuncModuleWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
if (!Object.Equals(null, objCMProjectFuncModuleEN.CmPrjId) && GetStrLen(objCMProjectFuncModuleEN.CmPrjId) > 6)
{
 throw new Exception("字段[Cm工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objCMProjectFuncModuleEN.FuncModuleAgcId) && GetStrLen(objCMProjectFuncModuleEN.FuncModuleAgcId) > 8)
{
 throw new Exception("字段[功能模块Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMProjectFuncModuleEN.PrjId) && GetStrLen(objCMProjectFuncModuleEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCMProjectFuncModuleEN.UpdDate) && GetStrLen(objCMProjectFuncModuleEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectFuncModuleEN.UpdUser) && GetStrLen(objCMProjectFuncModuleEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMProjectFuncModuleEN.Memo) && GetStrLen(objCMProjectFuncModuleEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCMProjectFuncModuleEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMProjectFuncModuleEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsCMProjectFuncModuleEN objCMProjectFuncModuleEN;
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
objCMProjectFuncModuleEN = JsonConvert.DeserializeObject<clsCMProjectFuncModuleEN>(strJson);
return objCMProjectFuncModuleEN;
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
public static clsCMProjectFuncModuleEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMProjectFuncModuleEN objCMProjectFuncModuleEN;
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
objCMProjectFuncModuleEN = JsonConvert.DeserializeObject<clsCMProjectFuncModuleEN>(strJson);
return objCMProjectFuncModuleEN;
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
public static List<clsCMProjectFuncModuleEN> GetObjLst(string strWhereCond)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
public static List<clsCMProjectFuncModuleEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
public static List<clsCMProjectFuncModuleEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
public static List<clsCMProjectFuncModuleEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
public static List<clsCMProjectFuncModuleEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
public static List<clsCMProjectFuncModuleEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMProjectFuncModuleEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMProjectFuncModuleEN>>(strJson);
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
 clsCMProjectFuncModuleEN objCMProjectFuncModuleEN = clsCMProjectFuncModuleWApi.GetObjBymId(lngmId);
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
public static int DelCMProjectFuncModules(List<string> arrmId)
{
string strAction = "DelCMProjectFuncModules";
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
public static int DelCMProjectFuncModulesByCond(string strWhereCond)
{
string strAction = "DelCMProjectFuncModulesByCond";
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
public static bool AddNewRecord(clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectFuncModuleEN>(objCMProjectFuncModuleEN);
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
 /// <param name = "objCMProjectFuncModuleEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectFuncModuleEN>(objCMProjectFuncModuleEN);
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
public static bool UpdateRecord(clsCMProjectFuncModuleEN objCMProjectFuncModuleEN)
{
if (string.IsNullOrEmpty(objCMProjectFuncModuleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectFuncModuleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectFuncModuleEN>(objCMProjectFuncModuleEN);
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
 /// <param name = "objCMProjectFuncModuleEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMProjectFuncModuleEN objCMProjectFuncModuleEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMProjectFuncModuleEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectFuncModuleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMProjectFuncModuleEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMProjectFuncModuleEN>(objCMProjectFuncModuleEN);
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
 /// <param name = "objCMProjectFuncModuleENS">源对象</param>
 /// <param name = "objCMProjectFuncModuleENT">目标对象</param>
 public static void CopyTo(clsCMProjectFuncModuleEN objCMProjectFuncModuleENS, clsCMProjectFuncModuleEN objCMProjectFuncModuleENT)
{
try
{
objCMProjectFuncModuleENT.mId = objCMProjectFuncModuleENS.mId; //mId
objCMProjectFuncModuleENT.CmPrjId = objCMProjectFuncModuleENS.CmPrjId; //Cm工程Id
objCMProjectFuncModuleENT.FuncModuleAgcId = objCMProjectFuncModuleENS.FuncModuleAgcId; //功能模块Id
objCMProjectFuncModuleENT.OrderNum = objCMProjectFuncModuleENS.OrderNum; //序号
objCMProjectFuncModuleENT.PrjId = objCMProjectFuncModuleENS.PrjId; //工程Id
objCMProjectFuncModuleENT.UpdDate = objCMProjectFuncModuleENS.UpdDate; //修改日期
objCMProjectFuncModuleENT.UpdUser = objCMProjectFuncModuleENS.UpdUser; //修改者
objCMProjectFuncModuleENT.Memo = objCMProjectFuncModuleENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCMProjectFuncModuleEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMProjectFuncModuleEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMProjectFuncModuleEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMProjectFuncModuleEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMProjectFuncModuleEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMProjectFuncModuleEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsCMProjectFuncModuleWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsCMProjectFuncModuleWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMProjectFuncModuleEN._CurrTabName, strPrjId);
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
if (clsCMProjectFuncModuleWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMProjectFuncModuleEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMProjectFuncModuleWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
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
public static DataTable GetDataTableByObjLst(List<clsCMProjectFuncModuleEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMProjectFuncModule.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCMProjectFuncModule.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectFuncModule.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectFuncModule.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMProjectFuncModule.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectFuncModule.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectFuncModule.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMProjectFuncModule.Memo, Type.GetType("System.String"));
foreach (clsCMProjectFuncModuleEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMProjectFuncModule.mId] = objInFor[conCMProjectFuncModule.mId];
objDR[conCMProjectFuncModule.CmPrjId] = objInFor[conCMProjectFuncModule.CmPrjId];
objDR[conCMProjectFuncModule.FuncModuleAgcId] = objInFor[conCMProjectFuncModule.FuncModuleAgcId];
objDR[conCMProjectFuncModule.OrderNum] = objInFor[conCMProjectFuncModule.OrderNum];
objDR[conCMProjectFuncModule.PrjId] = objInFor[conCMProjectFuncModule.PrjId];
objDR[conCMProjectFuncModule.UpdDate] = objInFor[conCMProjectFuncModule.UpdDate];
objDR[conCMProjectFuncModule.UpdUser] = objInFor[conCMProjectFuncModule.UpdUser];
objDR[conCMProjectFuncModule.Memo] = objInFor[conCMProjectFuncModule.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM项目模块关系(CMProjectFuncModule)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMProjectFuncModule : clsCommFun4BLV2
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
clsCMProjectFuncModuleWApi.ReFreshThisCache(strPrjId);
}
}

}