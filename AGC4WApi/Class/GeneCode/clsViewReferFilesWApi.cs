
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewReferFilesWApi
 表名:ViewReferFiles(00050465)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:44
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
public static class  clsViewReferFilesWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetmId(this clsViewReferFilesEN objViewReferFilesEN, long lngmId, string strComparisonOp="")
	{
objViewReferFilesEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.mId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.mId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.mId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewId">界面Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetViewId(this clsViewReferFilesEN objViewReferFilesEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewReferFiles.ViewId);
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewReferFiles.ViewId);
objViewReferFilesEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.ViewId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.ViewId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.ViewId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTypeId">代码类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetCodeTypeId(this clsViewReferFilesEN objViewReferFilesEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conViewReferFiles.CodeTypeId);
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conViewReferFiles.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conViewReferFiles.CodeTypeId);
objViewReferFilesEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.CodeTypeId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.CodeTypeId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.CodeTypeId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strReferFileId">引用文件Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetReferFileId(this clsViewReferFilesEN objViewReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReferFileId, conViewReferFiles.ReferFileId);
clsCheckSql.CheckFieldLen(strReferFileId, 8, conViewReferFiles.ReferFileId);
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, conViewReferFiles.ReferFileId);
objViewReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.ReferFileId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.ReferFileId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.ReferFileId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetInUse(this clsViewReferFilesEN objViewReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objViewReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.InUse) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.InUse, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.InUse] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetOrderNum(this clsViewReferFilesEN objViewReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conViewReferFiles.OrderNum);
objViewReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.OrderNum) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.OrderNum, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.OrderNum] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTemplate">是否模板</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetIsTemplate(this clsViewReferFilesEN objViewReferFilesEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conViewReferFiles.IsTemplate);
objViewReferFilesEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.IsTemplate) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.IsTemplate, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.IsTemplate] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetPrjId(this clsViewReferFilesEN objViewReferFilesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewReferFiles.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewReferFiles.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewReferFiles.PrjId);
objViewReferFilesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.PrjId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.PrjId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.PrjId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetUpdDate(this clsViewReferFilesEN objViewReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conViewReferFiles.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewReferFiles.UpdDate);
objViewReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.UpdDate) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.UpdDate, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.UpdDate] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetUpdUserId(this clsViewReferFilesEN objViewReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conViewReferFiles.UpdUserId);
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conViewReferFiles.UpdUserId);
objViewReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.UpdUserId) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.UpdUserId, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.UpdUserId] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewReferFilesEN SetMemo(this clsViewReferFilesEN objViewReferFilesEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewReferFiles.Memo);
objViewReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewReferFilesEN.dicFldComparisonOp.ContainsKey(conViewReferFiles.Memo) == false)
{
objViewReferFilesEN.dicFldComparisonOp.Add(conViewReferFiles.Memo, strComparisonOp);
}
else
{
objViewReferFilesEN.dicFldComparisonOp[conViewReferFiles.Memo] = strComparisonOp;
}
}
return objViewReferFilesEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewReferFilesEN objViewReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.mId) == true)
{
string strComparisonOpmId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewReferFiles.mId, objViewReferFilesCond.mId, strComparisonOpmId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.ViewId) == true)
{
string strComparisonOpViewId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.ViewId, objViewReferFilesCond.ViewId, strComparisonOpViewId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.CodeTypeId, objViewReferFilesCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.ReferFileId, objViewReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.InUse) == true)
{
if (objViewReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewReferFiles.InUse);
}
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conViewReferFiles.OrderNum, objViewReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.IsTemplate) == true)
{
if (objViewReferFilesCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewReferFiles.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewReferFiles.IsTemplate);
}
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.PrjId) == true)
{
string strComparisonOpPrjId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.PrjId, objViewReferFilesCond.PrjId, strComparisonOpPrjId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.UpdDate, objViewReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.UpdUserId, objViewReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objViewReferFilesCond.IsUpdated(conViewReferFiles.Memo) == true)
{
string strComparisonOpMemo = objViewReferFilesCond.dicFldComparisonOp[conViewReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewReferFiles.Memo, objViewReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewReferFilesEN objViewReferFilesEN)
{
 if (objViewReferFilesEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewReferFilesEN.sfUpdFldSetStr = objViewReferFilesEN.getsfUpdFldSetStr();
clsViewReferFilesWApi.CheckPropertyNew(objViewReferFilesEN); 
bool bolResult = clsViewReferFilesWApi.UpdateRecord(objViewReferFilesEN);
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
 /// 获取唯一性条件串--ViewReferFiles(界面引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ViewId_CodeTypeId_ReferFileId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewReferFilesEN objViewReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewReferFilesEN == null) return "";
if (objViewReferFilesEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objViewReferFilesEN.mId);
 sbCondition.AppendFormat(" and ReferFileId = '{0}'", objViewReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objViewReferFilesEN.ViewId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objViewReferFilesEN.CodeTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewReferFilesEN objViewReferFilesEN)
{
try
{
clsViewReferFilesWApi.CheckPropertyNew(objViewReferFilesEN); 
bool bolResult = clsViewReferFilesWApi.AddNewRecord(objViewReferFilesEN);
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
 /// <param name = "objViewReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewReferFilesEN objViewReferFilesEN, string strWhereCond)
{
try
{
clsViewReferFilesWApi.CheckPropertyNew(objViewReferFilesEN); 
bool bolResult = clsViewReferFilesWApi.UpdateWithCondition(objViewReferFilesEN, strWhereCond);
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
 /// 界面引用文件(ViewReferFiles)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewReferFilesWApi
{
private static readonly string mstrApiControllerName = "ViewReferFilesApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewReferFilesWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewReferFilesEN objViewReferFilesEN)
{
if (!Object.Equals(null, objViewReferFilesEN.ViewId) && GetStrLen(objViewReferFilesEN.ViewId) > 8)
{
 throw new Exception("字段[界面Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewReferFilesEN.CodeTypeId) && GetStrLen(objViewReferFilesEN.CodeTypeId) > 4)
{
 throw new Exception("字段[代码类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewReferFilesEN.ReferFileId) && GetStrLen(objViewReferFilesEN.ReferFileId) > 8)
{
 throw new Exception("字段[引用文件Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewReferFilesEN.PrjId) && GetStrLen(objViewReferFilesEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewReferFilesEN.UpdDate) && GetStrLen(objViewReferFilesEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewReferFilesEN.UpdUserId) && GetStrLen(objViewReferFilesEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objViewReferFilesEN.Memo) && GetStrLen(objViewReferFilesEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objViewReferFilesEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewReferFilesEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsViewReferFilesEN objViewReferFilesEN;
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
objViewReferFilesEN = JsonConvert.DeserializeObject<clsViewReferFilesEN>(strJson);
return objViewReferFilesEN;
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
public static clsViewReferFilesEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewReferFilesEN objViewReferFilesEN;
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
objViewReferFilesEN = JsonConvert.DeserializeObject<clsViewReferFilesEN>(strJson);
return objViewReferFilesEN;
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
public static List<clsViewReferFilesEN> GetObjLst(string strWhereCond)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
public static List<clsViewReferFilesEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
public static List<clsViewReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
public static List<clsViewReferFilesEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
public static List<clsViewReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
public static List<clsViewReferFilesEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewReferFilesEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsViewReferFilesEN>>(strJson);
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
 clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesWApi.GetObjBymId(lngmId);
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
public static int DelViewReferFiless(List<string> arrmId)
{
string strAction = "DelViewReferFiless";
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
public static int DelViewReferFilessByCond(string strWhereCond)
{
string strAction = "DelViewReferFilessByCond";
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
public static bool AddNewRecord(clsViewReferFilesEN objViewReferFilesEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewReferFilesEN>(objViewReferFilesEN);
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
 /// <param name = "objViewReferFilesEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsViewReferFilesEN objViewReferFilesEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewReferFilesEN>(objViewReferFilesEN);
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
public static bool UpdateRecord(clsViewReferFilesEN objViewReferFilesEN)
{
if (string.IsNullOrEmpty(objViewReferFilesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewReferFilesEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewReferFilesEN>(objViewReferFilesEN);
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
 /// <param name = "objViewReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewReferFilesEN objViewReferFilesEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewReferFilesEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewReferFilesEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewReferFilesEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewReferFilesEN>(objViewReferFilesEN);
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
 /// <param name = "objViewReferFilesENS">源对象</param>
 /// <param name = "objViewReferFilesENT">目标对象</param>
 public static void CopyTo(clsViewReferFilesEN objViewReferFilesENS, clsViewReferFilesEN objViewReferFilesENT)
{
try
{
objViewReferFilesENT.mId = objViewReferFilesENS.mId; //mId
objViewReferFilesENT.ViewId = objViewReferFilesENS.ViewId; //界面Id
objViewReferFilesENT.CodeTypeId = objViewReferFilesENS.CodeTypeId; //代码类型Id
objViewReferFilesENT.ReferFileId = objViewReferFilesENS.ReferFileId; //引用文件Id
objViewReferFilesENT.InUse = objViewReferFilesENS.InUse; //是否在用
objViewReferFilesENT.OrderNum = objViewReferFilesENS.OrderNum; //序号
objViewReferFilesENT.IsTemplate = objViewReferFilesENS.IsTemplate; //是否模板
objViewReferFilesENT.PrjId = objViewReferFilesENS.PrjId; //工程Id
objViewReferFilesENT.UpdDate = objViewReferFilesENS.UpdDate; //修改日期
objViewReferFilesENT.UpdUserId = objViewReferFilesENS.UpdUserId; //修改用户Id
objViewReferFilesENT.Memo = objViewReferFilesENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsViewReferFilesEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewReferFilesEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewReferFilesEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewReferFilesEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewReferFilesEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewReferFilesEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewReferFilesWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewReferFilesWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
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
if (clsViewReferFilesWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewReferFilesEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewReferFilesWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
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
public static DataTable GetDataTableByObjLst(List<clsViewReferFilesEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewReferFiles.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conViewReferFiles.ViewId, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.ReferFileId, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewReferFiles.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewReferFiles.IsTemplate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conViewReferFiles.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conViewReferFiles.Memo, Type.GetType("System.String"));
foreach (clsViewReferFilesEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewReferFiles.mId] = objInFor[conViewReferFiles.mId];
objDR[conViewReferFiles.ViewId] = objInFor[conViewReferFiles.ViewId];
objDR[conViewReferFiles.CodeTypeId] = objInFor[conViewReferFiles.CodeTypeId];
objDR[conViewReferFiles.ReferFileId] = objInFor[conViewReferFiles.ReferFileId];
objDR[conViewReferFiles.InUse] = objInFor[conViewReferFiles.InUse];
objDR[conViewReferFiles.OrderNum] = objInFor[conViewReferFiles.OrderNum];
objDR[conViewReferFiles.IsTemplate] = objInFor[conViewReferFiles.IsTemplate];
objDR[conViewReferFiles.PrjId] = objInFor[conViewReferFiles.PrjId];
objDR[conViewReferFiles.UpdDate] = objInFor[conViewReferFiles.UpdDate];
objDR[conViewReferFiles.UpdUserId] = objInFor[conViewReferFiles.UpdUserId];
objDR[conViewReferFiles.Memo] = objInFor[conViewReferFiles.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面引用文件(ViewReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewReferFiles : clsCommFun4BLV2
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
clsViewReferFilesWApi.ReFreshThisCache(strPrjId);
}
}

}