
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersWApi
 表名:ExportExcel4Users(00050241)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsExportExcel4UsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetmId(this clsExportExcel4UsersEN objExportExcel4UsersEN, long lngmId, string strComparisonOp="")
	{
objExportExcel4UsersEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.mId) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.mId, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.mId] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdExportExcel4Users">导出Excel用户字段流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetIdExportExcel4Users(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strIdExportExcel4Users, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(strIdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldForeignKey(strIdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
objExportExcel4UsersEN.IdExportExcel4Users = strIdExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.IdExportExcel4Users) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.IdExportExcel4Users, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.IdExportExcel4Users] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetFieldName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldName, conExportExcel4Users.FieldName);
clsCheckSql.CheckFieldLen(strFieldName, 50, conExportExcel4Users.FieldName);
objExportExcel4UsersEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.FieldName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.FieldName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.FieldName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldCnName">字段中文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetFieldCnName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strFieldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldCnName, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(strFieldCnName, 50, conExportExcel4Users.FieldCnName);
objExportExcel4UsersEN.FieldCnName = strFieldCnName; //字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.FieldCnName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.FieldCnName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.FieldCnName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExport">是否导出</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetIsExport(this clsExportExcel4UsersEN objExportExcel4UsersEN, bool bolIsExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsExport, conExportExcel4Users.IsExport);
objExportExcel4UsersEN.IsExport = bolIsExport; //是否导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.IsExport) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.IsExport, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.IsExport] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetOrderNum(this clsExportExcel4UsersEN objExportExcel4UsersEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conExportExcel4Users.OrderNum);
objExportExcel4UsersEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.OrderNum) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.OrderNum, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.OrderNum] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewName">界面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetViewName(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 100, conExportExcel4Users.ViewName);
objExportExcel4UsersEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.ViewName) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.ViewName, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.ViewName] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetUpdDate(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conExportExcel4Users.UpdDate);
objExportExcel4UsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.UpdDate) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.UpdDate, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.UpdDate] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetUpdUserId(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conExportExcel4Users.UpdUserId);
objExportExcel4UsersEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.UpdUserId) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.UpdUserId, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.UpdUserId] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExportExcel4UsersEN SetMemo(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExportExcel4Users.Memo);
objExportExcel4UsersEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(conExportExcel4Users.Memo) == false)
{
objExportExcel4UsersEN.dicFldComparisonOp.Add(conExportExcel4Users.Memo, strComparisonOp);
}
else
{
objExportExcel4UsersEN.dicFldComparisonOp[conExportExcel4Users.Memo] = strComparisonOp;
}
}
return objExportExcel4UsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExportExcel4UsersEN objExportExcel4UsersCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.mId) == true)
{
string strComparisonOpmId = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conExportExcel4Users.mId, objExportExcel4UsersCond.mId, strComparisonOpmId);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.IdExportExcel4Users) == true)
{
string strComparisonOpIdExportExcel4Users = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.IdExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.IdExportExcel4Users, objExportExcel4UsersCond.IdExportExcel4Users, strComparisonOpIdExportExcel4Users);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.FieldName) == true)
{
string strComparisonOpFieldName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.FieldName, objExportExcel4UsersCond.FieldName, strComparisonOpFieldName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.FieldCnName) == true)
{
string strComparisonOpFieldCnName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.FieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.FieldCnName, objExportExcel4UsersCond.FieldCnName, strComparisonOpFieldCnName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.IsExport) == true)
{
if (objExportExcel4UsersCond.IsExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExportExcel4Users.IsExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExportExcel4Users.IsExport);
}
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.OrderNum) == true)
{
string strComparisonOpOrderNum = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conExportExcel4Users.OrderNum, objExportExcel4UsersCond.OrderNum, strComparisonOpOrderNum);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.ViewName) == true)
{
string strComparisonOpViewName = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.ViewName, objExportExcel4UsersCond.ViewName, strComparisonOpViewName);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.UpdDate) == true)
{
string strComparisonOpUpdDate = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.UpdDate, objExportExcel4UsersCond.UpdDate, strComparisonOpUpdDate);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.UpdUserId, objExportExcel4UsersCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objExportExcel4UsersCond.IsUpdated(conExportExcel4Users.Memo) == true)
{
string strComparisonOpMemo = objExportExcel4UsersCond.dicFldComparisonOp[conExportExcel4Users.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExportExcel4Users.Memo, objExportExcel4UsersCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 if (objExportExcel4UsersEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objExportExcel4UsersEN.sfUpdFldSetStr = objExportExcel4UsersEN.getsfUpdFldSetStr();
clsExportExcel4UsersWApi.CheckPropertyNew(objExportExcel4UsersEN); 
bool bolResult = clsExportExcel4UsersWApi.UpdateRecord(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersWApi.ReFreshCache();
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
 /// 获取唯一性条件串--ExportExcel4Users(导出Excel用户字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_ExportExcel4Users_FieldName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExportExcel4UsersEN == null) return "";
if (objExportExcel4UsersEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExportExcel4UsersEN.mId);
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExportExcel4UsersEN objExportExcel4UsersEN)
{
try
{
clsExportExcel4UsersWApi.CheckPropertyNew(objExportExcel4UsersEN); 
bool bolResult = clsExportExcel4UsersWApi.AddNewRecord(objExportExcel4UsersEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersWApi.ReFreshCache();
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExportExcel4UsersEN objExportExcel4UsersEN, string strWhereCond)
{
try
{
clsExportExcel4UsersWApi.CheckPropertyNew(objExportExcel4UsersEN); 
bool bolResult = clsExportExcel4UsersWApi.UpdateWithCondition(objExportExcel4UsersEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersWApi.ReFreshCache();
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
 /// 导出Excel用户字段(ExportExcel4Users)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsExportExcel4UsersWApi
{
private static readonly string mstrApiControllerName = "ExportExcel4UsersApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsExportExcel4UsersWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
if (!Object.Equals(null, objExportExcel4UsersEN.IdExportExcel4Users) && GetStrLen(objExportExcel4UsersEN.IdExportExcel4Users) > 8)
{
 throw new Exception("字段[导出Excel用户字段流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.FieldName) && GetStrLen(objExportExcel4UsersEN.FieldName) > 50)
{
 throw new Exception("字段[字段名]的长度不能超过50!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.FieldCnName) && GetStrLen(objExportExcel4UsersEN.FieldCnName) > 50)
{
 throw new Exception("字段[字段中文名称]的长度不能超过50!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.ViewName) && GetStrLen(objExportExcel4UsersEN.ViewName) > 100)
{
 throw new Exception("字段[界面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.UpdDate) && GetStrLen(objExportExcel4UsersEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.UpdUserId) && GetStrLen(objExportExcel4UsersEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objExportExcel4UsersEN.Memo) && GetStrLen(objExportExcel4UsersEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objExportExcel4UsersEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExportExcel4UsersEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsExportExcel4UsersEN objExportExcel4UsersEN;
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
objExportExcel4UsersEN = JsonConvert.DeserializeObject<clsExportExcel4UsersEN>(strJson);
return objExportExcel4UsersEN;
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
public static clsExportExcel4UsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsExportExcel4UsersEN objExportExcel4UsersEN;
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
objExportExcel4UsersEN = JsonConvert.DeserializeObject<clsExportExcel4UsersEN>(strJson);
return objExportExcel4UsersEN;
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
public static clsExportExcel4UsersEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrExportExcel4UsersObjLst_Sel =
from objExportExcel4UsersEN in arrExportExcel4UsersObjLstCache
where objExportExcel4UsersEN.mId == lngmId 
select objExportExcel4UsersEN;
if (arrExportExcel4UsersObjLst_Sel.Count() == 0)
{
   clsExportExcel4UsersEN obj = clsExportExcel4UsersWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrExportExcel4UsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLst(string strWhereCond)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
public static List<clsExportExcel4UsersEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
public static IEnumerable<clsExportExcel4UsersEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = GetObjLstCache();
IEnumerable <clsExportExcel4UsersEN> arrExportExcel4UsersObjLst_Sel =
from objExportExcel4UsersEN in arrExportExcel4UsersObjLstCache
where arrMId.Contains(objExportExcel4UsersEN.mId)
select objExportExcel4UsersEN;
return arrExportExcel4UsersObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExportExcel4UsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
public static List<clsExportExcel4UsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
public static List<clsExportExcel4UsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
public static List<clsExportExcel4UsersEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsExportExcel4UsersEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExportExcel4UsersEN>>(strJson);
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
 clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsExportExcel4UsersWApi.ReFreshCache();
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
public static int DelExportExcel4Userss(List<string> arrmId)
{
string strAction = "DelExportExcel4Userss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsExportExcel4UsersWApi.ReFreshCache();
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
public static int DelExportExcel4UserssByCond(string strWhereCond)
{
string strAction = "DelExportExcel4UserssByCond";
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
public static bool AddNewRecord(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN>(objExportExcel4UsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersWApi.ReFreshCache();
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
 /// <param name = "objExportExcel4UsersEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN>(objExportExcel4UsersEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersWApi.ReFreshCache();
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
public static bool UpdateRecord(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
if (string.IsNullOrEmpty(objExportExcel4UsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExportExcel4UsersEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN>(objExportExcel4UsersEN);
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsExportExcel4UsersEN objExportExcel4UsersEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objExportExcel4UsersEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExportExcel4UsersEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExportExcel4UsersEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExportExcel4UsersEN>(objExportExcel4UsersEN);
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <param name = "objExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(clsExportExcel4UsersEN objExportExcel4UsersENS, clsExportExcel4UsersEN objExportExcel4UsersENT)
{
try
{
objExportExcel4UsersENT.mId = objExportExcel4UsersENS.mId; //mId
objExportExcel4UsersENT.IdExportExcel4Users = objExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcel4UsersENT.FieldName = objExportExcel4UsersENS.FieldName; //字段名
objExportExcel4UsersENT.FieldCnName = objExportExcel4UsersENS.FieldCnName; //字段中文名称
objExportExcel4UsersENT.IsExport = objExportExcel4UsersENS.IsExport; //是否导出
objExportExcel4UsersENT.OrderNum = objExportExcel4UsersENS.OrderNum; //序号
objExportExcel4UsersENT.ViewName = objExportExcel4UsersENS.ViewName; //界面名称
objExportExcel4UsersENT.UpdDate = objExportExcel4UsersENS.UpdDate; //修改日期
objExportExcel4UsersENT.UpdUserId = objExportExcel4UsersENS.UpdUserId; //修改用户Id
objExportExcel4UsersENT.Memo = objExportExcel4UsersENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsExportExcel4UsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsExportExcel4UsersEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsExportExcel4UsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsExportExcel4UsersEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsExportExcel4UsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsExportExcel4UsersEN._AttributeName)
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
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
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
if (clsExportExcel4UsersWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsExportExcel4UsersEN._CurrTabName);
CacheHelper.Remove(strKey);
clsExportExcel4UsersWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExportExcel4UsersEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsExportExcel4UsersEN._CurrTabName;
List<clsExportExcel4UsersEN> arrExportExcel4UsersObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrExportExcel4UsersObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsExportExcel4UsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conExportExcel4Users.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conExportExcel4Users.IdExportExcel4Users, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.FieldCnName, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.IsExport, Type.GetType("System.Boolean"));
objDT.Columns.Add(conExportExcel4Users.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conExportExcel4Users.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conExportExcel4Users.Memo, Type.GetType("System.String"));
foreach (clsExportExcel4UsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conExportExcel4Users.mId] = objInFor[conExportExcel4Users.mId];
objDR[conExportExcel4Users.IdExportExcel4Users] = objInFor[conExportExcel4Users.IdExportExcel4Users];
objDR[conExportExcel4Users.FieldName] = objInFor[conExportExcel4Users.FieldName];
objDR[conExportExcel4Users.FieldCnName] = objInFor[conExportExcel4Users.FieldCnName];
objDR[conExportExcel4Users.IsExport] = objInFor[conExportExcel4Users.IsExport];
objDR[conExportExcel4Users.OrderNum] = objInFor[conExportExcel4Users.OrderNum];
objDR[conExportExcel4Users.ViewName] = objInFor[conExportExcel4Users.ViewName];
objDR[conExportExcel4Users.UpdDate] = objInFor[conExportExcel4Users.UpdDate];
objDR[conExportExcel4Users.UpdUserId] = objInFor[conExportExcel4Users.UpdUserId];
objDR[conExportExcel4Users.Memo] = objInFor[conExportExcel4Users.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 导出Excel用户字段(ExportExcel4Users)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ExportExcel4Users : clsCommFun4BL
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
clsExportExcel4UsersWApi.ReFreshThisCache();
}
}

}