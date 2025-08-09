
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewIdGCVariableRelaWApi
 表名:ViewIdGCVariableRela(00050631)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsViewIdGCVariableRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUseInRegion">是否在区域中使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetIsUseInRegion(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsUseInRegion, string strComparisonOp="")
	{
objViewIdGCVariableRelaEN.IsUseInRegion = bolIsUseInRegion; //是否在区域中使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.IsUseInRegion) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.IsUseInRegion, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.IsUseInRegion] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetVarId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conViewIdGCVariableRela.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conViewIdGCVariableRela.VarId);
objViewIdGCVariableRelaEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.VarId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.VarId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.VarId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetViewId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewIdGCVariableRela.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewIdGCVariableRela.ViewId);
objViewIdGCVariableRelaEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.ViewId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.ViewId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.ViewId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRetrievalMethodId">获取方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetRetrievalMethodId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strRetrievalMethodId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldLen(strRetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
clsCheckSql.CheckFieldForeignKey(strRetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
objViewIdGCVariableRelaEN.RetrievalMethodId = strRetrievalMethodId; //获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.RetrievalMethodId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.RetrievalMethodId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.RetrievalMethodId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionTypeNames">区域类型名s</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetRegionTypeNames(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strRegionTypeNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRegionTypeNames, 100, conViewIdGCVariableRela.RegionTypeNames);
objViewIdGCVariableRelaEN.RegionTypeNames = strRegionTypeNames; //区域类型名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.RegionTypeNames) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.RegionTypeNames, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.RegionTypeNames] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetErrMsg(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewIdGCVariableRela.ErrMsg);
objViewIdGCVariableRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.ErrMsg) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.ErrMsg, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.ErrMsg] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetPrjId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewIdGCVariableRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewIdGCVariableRela.PrjId);
objViewIdGCVariableRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.PrjId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.PrjId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.PrjId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetUpdUser(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewIdGCVariableRela.UpdUser);
objViewIdGCVariableRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.UpdUser) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.UpdUser, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.UpdUser] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetUpdDate(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewIdGCVariableRela.UpdDate);
objViewIdGCVariableRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.UpdDate) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.UpdDate, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.UpdDate] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetMemo(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewIdGCVariableRela.Memo);
objViewIdGCVariableRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.Memo) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.Memo, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.Memo] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.IsUseInRegion) == true)
{
if (objViewIdGCVariableRelaCond.IsUseInRegion == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewIdGCVariableRela.IsUseInRegion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewIdGCVariableRela.IsUseInRegion);
}
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.VarId) == true)
{
string strComparisonOpVarId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.VarId, objViewIdGCVariableRelaCond.VarId, strComparisonOpVarId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.ViewId) == true)
{
string strComparisonOpViewId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.ViewId, objViewIdGCVariableRelaCond.ViewId, strComparisonOpViewId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId) == true)
{
string strComparisonOpRetrievalMethodId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.RetrievalMethodId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.RetrievalMethodId, objViewIdGCVariableRelaCond.RetrievalMethodId, strComparisonOpRetrievalMethodId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.RegionTypeNames) == true)
{
string strComparisonOpRegionTypeNames = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.RegionTypeNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.RegionTypeNames, objViewIdGCVariableRelaCond.RegionTypeNames, strComparisonOpRegionTypeNames);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.ErrMsg, objViewIdGCVariableRelaCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.PrjId) == true)
{
string strComparisonOpPrjId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.PrjId, objViewIdGCVariableRelaCond.PrjId, strComparisonOpPrjId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.UpdUser, objViewIdGCVariableRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.UpdDate, objViewIdGCVariableRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.Memo) == true)
{
string strComparisonOpMemo = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.Memo, objViewIdGCVariableRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewIdGCVariableRelaEN.sfUpdFldSetStr = objViewIdGCVariableRelaEN.getsfUpdFldSetStr();
clsViewIdGCVariableRelaWApi.CheckPropertyNew(objViewIdGCVariableRelaEN); 
bool bolResult = clsViewIdGCVariableRelaWApi.UpdateRecord(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewIdGCVariableRelaWApi.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewIdGCVariableRelaEN.VarId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsViewIdGCVariableRelaWApi.CheckPropertyNew(objViewIdGCVariableRelaEN); 
bool bolResult = clsViewIdGCVariableRelaWApi.AddNewRecord(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
try
{
clsViewIdGCVariableRelaWApi.CheckPropertyNew(objViewIdGCVariableRelaEN); 
string strVarId = clsViewIdGCVariableRelaWApi.AddNewRecordWithMaxId(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
return strVarId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strWhereCond)
{
try
{
clsViewIdGCVariableRelaWApi.CheckPropertyNew(objViewIdGCVariableRelaEN); 
bool bolResult = clsViewIdGCVariableRelaWApi.UpdateWithCondition(objViewIdGCVariableRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
 /// 界面变量关系(ViewIdGCVariableRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewIdGCVariableRelaWApi
{
private static readonly string mstrApiControllerName = "ViewIdGCVariableRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewIdGCVariableRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
if (!Object.Equals(null, objViewIdGCVariableRelaEN.VarId) && GetStrLen(objViewIdGCVariableRelaEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.ViewId) && GetStrLen(objViewIdGCVariableRelaEN.ViewId) > 8)
{
 throw new Exception("字段[界面Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.RetrievalMethodId) && GetStrLen(objViewIdGCVariableRelaEN.RetrievalMethodId) > 2)
{
 throw new Exception("字段[获取方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.RegionTypeNames) && GetStrLen(objViewIdGCVariableRelaEN.RegionTypeNames) > 100)
{
 throw new Exception("字段[区域类型名s]的长度不能超过100!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.ErrMsg) && GetStrLen(objViewIdGCVariableRelaEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.PrjId) && GetStrLen(objViewIdGCVariableRelaEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.UpdUser) && GetStrLen(objViewIdGCVariableRelaEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.UpdDate) && GetStrLen(objViewIdGCVariableRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewIdGCVariableRelaEN.Memo) && GetStrLen(objViewIdGCVariableRelaEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objViewIdGCVariableRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewIdGCVariableRelaEN GetObjByKeyLst(string strVarId,string strViewId)
{
if (strVarId == "") return null;
if (strViewId == "") return null;
string strAction = "GetObjByKeyLst";
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId,
["strViewId"] = strViewId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objViewIdGCVariableRelaEN = JsonConvert.DeserializeObject<clsViewIdGCVariableRelaEN>(strJson);
return objViewIdGCVariableRelaEN;
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
public static clsViewIdGCVariableRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN;
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
objViewIdGCVariableRelaEN = JsonConvert.DeserializeObject<clsViewIdGCVariableRelaEN>(strJson);
return objViewIdGCVariableRelaEN;
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
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewIdGCVariableRelaEN GetObjByKeyLstCache(string strVarId,string strViewId)
{
if (string.IsNullOrEmpty(strVarId) == true) return null;
if (string.IsNullOrEmpty(strVarId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = GetObjLstCache();
IEnumerable <clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLst_Sel =
from objViewIdGCVariableRelaEN in arrViewIdGCVariableRelaObjLstCache
where objViewIdGCVariableRelaEN.VarId == strVarId 
 && objViewIdGCVariableRelaEN.ViewId == strViewId 
select objViewIdGCVariableRelaEN;
if (arrViewIdGCVariableRelaObjLst_Sel.Count() == 0)
{
   clsViewIdGCVariableRelaEN obj = clsViewIdGCVariableRelaWApi.GetObjByKeyLst(strVarId,strViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewIdGCVariableRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLst(string strWhereCond)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstByKeyLsts(List<string> arrVarId)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
string strAction = "GetObjLstByKeyLsts";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVarId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "strPrjId">分类字段值</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsViewIdGCVariableRelaEN> GetObjLstByKeyLstsCache(List<string> arrVarId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = GetObjLstCache();
IEnumerable <clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLst_Sel =
from objViewIdGCVariableRelaEN in arrViewIdGCVariableRelaObjLstCache
where arrVarId.Contains(objViewIdGCVariableRelaEN.VarId)
select objViewIdGCVariableRelaEN;
return arrViewIdGCVariableRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewIdGCVariableRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewIdGCVariableRelaEN>>(strJson);
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
public static int DelRecord(string strVarId,string strViewId)
{
string strAction = "DelRecord";
try
{
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = clsViewIdGCVariableRelaWApi.GetObjByKeyLst(strVarId,strViewId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strVarId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelViewIdGCVariableRelasByCond(string strWhereCond)
{
string strAction = "DelViewIdGCVariableRelasByCond";
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
public static bool AddNewRecord(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewIdGCVariableRelaEN>(objViewIdGCVariableRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewIdGCVariableRelaEN>(objViewIdGCVariableRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaWApi.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
var strVarId = (string)jobjReturn0["returnStr"];
return strVarId;
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
public static bool UpdateRecord(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewIdGCVariableRelaEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewIdGCVariableRelaEN>(objViewIdGCVariableRelaEN);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewIdGCVariableRelaEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewIdGCVariableRelaEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewIdGCVariableRelaEN>(objViewIdGCVariableRelaEN);
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
public static bool IsExist(string strVarId,string strViewId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId,
["strViewId"] = strViewId,
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
 /// <param name = "objViewIdGCVariableRelaENT">目标对象</param>
 public static void CopyTo(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS, clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT)
{
try
{
objViewIdGCVariableRelaENT.IsUseInRegion = objViewIdGCVariableRelaENS.IsUseInRegion; //是否在区域中使用
objViewIdGCVariableRelaENT.VarId = objViewIdGCVariableRelaENS.VarId; //变量Id
objViewIdGCVariableRelaENT.ViewId = objViewIdGCVariableRelaENS.ViewId; //界面Id
objViewIdGCVariableRelaENT.RetrievalMethodId = objViewIdGCVariableRelaENS.RetrievalMethodId; //获取方式Id
objViewIdGCVariableRelaENT.RegionTypeNames = objViewIdGCVariableRelaENS.RegionTypeNames; //区域类型名s
objViewIdGCVariableRelaENT.ErrMsg = objViewIdGCVariableRelaENS.ErrMsg; //错误信息
objViewIdGCVariableRelaENT.PrjId = objViewIdGCVariableRelaENS.PrjId; //工程Id
objViewIdGCVariableRelaENT.UpdUser = objViewIdGCVariableRelaENS.UpdUser; //修改者
objViewIdGCVariableRelaENT.UpdDate = objViewIdGCVariableRelaENS.UpdDate; //修改日期
objViewIdGCVariableRelaENT.Memo = objViewIdGCVariableRelaENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsViewIdGCVariableRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewIdGCVariableRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewIdGCVariableRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewIdGCVariableRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewIdGCVariableRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewIdGCVariableRelaEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewIdGCVariableRelaWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewIdGCVariableRelaWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
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
if (clsViewIdGCVariableRelaWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewIdGCVariableRelaWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewIdGCVariableRelaWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewIdGCVariableRelaWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewIdGCVariableRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewIdGCVariableRelaEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewIdGCVariableRela.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewIdGCVariableRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstCacheFromObjLst(List<clsViewIdGCVariableRelaEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewIdGCVariableRelaWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewIdGCVariableRelaWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewIdGCVariableRelaObjLstCache = CacheHelper.Get<List<clsViewIdGCVariableRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewIdGCVariableRelaObjLstCache = CacheHelper.Get<List<clsViewIdGCVariableRelaEN>>(strKey);
}
return arrViewIdGCVariableRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewIdGCVariableRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewIdGCVariableRela.IsUseInRegion, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewIdGCVariableRela.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.RetrievalMethodId, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.RegionTypeNames, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewIdGCVariableRela.Memo, Type.GetType("System.String"));
foreach (clsViewIdGCVariableRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewIdGCVariableRela.IsUseInRegion] = objInFor[conViewIdGCVariableRela.IsUseInRegion];
objDR[conViewIdGCVariableRela.VarId] = objInFor[conViewIdGCVariableRela.VarId];
objDR[conViewIdGCVariableRela.ViewId] = objInFor[conViewIdGCVariableRela.ViewId];
objDR[conViewIdGCVariableRela.RetrievalMethodId] = objInFor[conViewIdGCVariableRela.RetrievalMethodId];
objDR[conViewIdGCVariableRela.RegionTypeNames] = objInFor[conViewIdGCVariableRela.RegionTypeNames];
objDR[conViewIdGCVariableRela.ErrMsg] = objInFor[conViewIdGCVariableRela.ErrMsg];
objDR[conViewIdGCVariableRela.PrjId] = objInFor[conViewIdGCVariableRela.PrjId];
objDR[conViewIdGCVariableRela.UpdUser] = objInFor[conViewIdGCVariableRela.UpdUser];
objDR[conViewIdGCVariableRela.UpdDate] = objInFor[conViewIdGCVariableRela.UpdDate];
objDR[conViewIdGCVariableRela.Memo] = objInFor[conViewIdGCVariableRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面变量关系(ViewIdGCVariableRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewIdGCVariableRela : clsCommFun4BL
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
clsViewIdGCVariableRelaWApi.ReFreshThisCache();
}
}

}