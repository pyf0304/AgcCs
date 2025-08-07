
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolWApi
 表名:XzSchool(00050244)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:21
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsXzSchoolWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strIdSchool">学校流水号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetIdSchool(this clsXzSchoolEN objXzSchoolEN, string strIdSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conXzSchool.IdSchool);
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conXzSchool.IdSchool);
objXzSchoolEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.IdSchool) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.IdSchool, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.IdSchool] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolId">学校Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolId(this clsXzSchoolEN objXzSchoolEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conXzSchool.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 20, conXzSchool.SchoolId);
objXzSchoolEN.SchoolId = strSchoolId; //学校Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolName">学校名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolName(this clsXzSchoolEN objXzSchoolEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, conXzSchool.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, conXzSchool.SchoolName);
objXzSchoolEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolName) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolName, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolName] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCurrentUse">是否当前使用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetIsCurrentUse(this clsXzSchoolEN objXzSchoolEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCurrentUse, conXzSchool.IsCurrentUse);
objXzSchoolEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.IsCurrentUse) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.IsCurrentUse, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.IsCurrentUse] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolENName">学校英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolENName(this clsXzSchoolEN objXzSchoolEN, string strSchoolENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolENName, 50, conXzSchool.SchoolENName);
objXzSchoolEN.SchoolENName = strSchoolENName; //学校英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolENName) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolENName, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolENName] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolNameA">学校简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolNameA(this clsXzSchoolEN objXzSchoolEN, string strSchoolNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolNameA, 14, conXzSchool.SchoolNameA);
objXzSchoolEN.SchoolNameA = strSchoolNameA; //学校简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolNameA) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolNameA, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolNameA] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strSchoolTypeId">学校类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetSchoolTypeId(this clsXzSchoolEN objXzSchoolEN, string strSchoolTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTypeId, 2, conXzSchool.SchoolTypeId);
clsCheckSql.CheckFieldForeignKey(strSchoolTypeId, 2, conXzSchool.SchoolTypeId);
objXzSchoolEN.SchoolTypeId = strSchoolTypeId; //学校类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.SchoolTypeId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.SchoolTypeId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.SchoolTypeId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetUpdDate(this clsXzSchoolEN objXzSchoolEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzSchool.UpdDate);
objXzSchoolEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.UpdDate) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.UpdDate, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.UpdDate] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetUpdUserId(this clsXzSchoolEN objXzSchoolEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conXzSchool.UpdUserId);
objXzSchoolEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.UpdUserId) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.UpdUserId, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.UpdUserId] = strComparisonOp;
}
}
return objXzSchoolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzSchoolEN SetMemo(this clsXzSchoolEN objXzSchoolEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzSchool.Memo);
objXzSchoolEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchoolEN.dicFldComparisonOp.ContainsKey(conXzSchool.Memo) == false)
{
objXzSchoolEN.dicFldComparisonOp.Add(conXzSchool.Memo, strComparisonOp);
}
else
{
objXzSchoolEN.dicFldComparisonOp[conXzSchool.Memo] = strComparisonOp;
}
}
return objXzSchoolEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzSchoolEN objXzSchoolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzSchoolCond.IsUpdated(conXzSchool.IdSchool) == true)
{
string strComparisonOpIdSchool = objXzSchoolCond.dicFldComparisonOp[conXzSchool.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.IdSchool, objXzSchoolCond.IdSchool, strComparisonOpIdSchool);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolId) == true)
{
string strComparisonOpSchoolId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolId, objXzSchoolCond.SchoolId, strComparisonOpSchoolId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolName) == true)
{
string strComparisonOpSchoolName = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolName, objXzSchoolCond.SchoolName, strComparisonOpSchoolName);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.IsCurrentUse) == true)
{
if (objXzSchoolCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzSchool.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzSchool.IsCurrentUse);
}
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolENName) == true)
{
string strComparisonOpSchoolENName = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolENName, objXzSchoolCond.SchoolENName, strComparisonOpSchoolENName);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolNameA) == true)
{
string strComparisonOpSchoolNameA = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolNameA, objXzSchoolCond.SchoolNameA, strComparisonOpSchoolNameA);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.SchoolTypeId) == true)
{
string strComparisonOpSchoolTypeId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.SchoolTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.SchoolTypeId, objXzSchoolCond.SchoolTypeId, strComparisonOpSchoolTypeId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.UpdDate) == true)
{
string strComparisonOpUpdDate = objXzSchoolCond.dicFldComparisonOp[conXzSchool.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.UpdDate, objXzSchoolCond.UpdDate, strComparisonOpUpdDate);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objXzSchoolCond.dicFldComparisonOp[conXzSchool.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.UpdUserId, objXzSchoolCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objXzSchoolCond.IsUpdated(conXzSchool.Memo) == true)
{
string strComparisonOpMemo = objXzSchoolCond.dicFldComparisonOp[conXzSchool.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool.Memo, objXzSchoolCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzSchoolEN.sfUpdFldSetStr = objXzSchoolEN.getsfUpdFldSetStr();
clsXzSchoolWApi.CheckPropertyNew(objXzSchoolEN); 
bool bolResult = clsXzSchoolWApi.UpdateRecord(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzSchoolEN objXzSchoolEN)
{
 if (string.IsNullOrEmpty(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchoolWApi.IsExist(objXzSchoolEN.IdSchool) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzSchoolEN.IdSchool, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzSchoolWApi.CheckPropertyNew(objXzSchoolEN); 
bool bolResult = clsXzSchoolWApi.AddNewRecord(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
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
 /// <param name = "objXzSchoolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzSchoolEN objXzSchoolEN)
{
try
{
clsXzSchoolWApi.CheckPropertyNew(objXzSchoolEN); 
string strIdSchool = clsXzSchoolWApi.AddNewRecordWithMaxId(objXzSchoolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
return strIdSchool;
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchoolEN objXzSchoolEN, string strWhereCond)
{
try
{
clsXzSchoolWApi.CheckPropertyNew(objXzSchoolEN); 
bool bolResult = clsXzSchoolWApi.UpdateWithCondition(objXzSchoolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumXzSchoolWA
{
 /// <summary>
 /// 淮阴师范学院
 /// </summary>
public const string HYSF_0001 = "0001";
 /// <summary>
 /// 上海师范大学
 /// </summary>
public const string SHNU_0002 = "0002";
 /// <summary>
 /// 温州大学
 /// </summary>
public const string WZU_0003 = "0003";
 /// <summary>
 /// 宁波大学
 /// </summary>
public const string NBU_0004 = "0004";
 /// <summary>
 /// 淮阴师范测试
 /// </summary>
public const string HYSF_TEST_0005 = "0005";
 /// <summary>
 /// 江苏二师
 /// </summary>
public const string JSIE_0006 = "0006";
 /// <summary>
 /// 上海泰泽
 /// </summary>
public const string TZ_0007 = "0007";
 /// <summary>
 /// 上海师大第二附属中学
 /// </summary>
public const string SSDEFZ_0008 = "0008";
 /// <summary>
 /// 上海市交通局下属单位
 /// </summary>
public const string JT_0009 = "0009";
}
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzSchoolWApi
{
private static readonly string mstrApiControllerName = "XzSchoolApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsXzSchoolWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdSchool(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学校]...","0");
List<clsXzSchoolEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="IdSchool";
objDDL.DataTextField="SchoolName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSchool(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzSchool.IdSchool); 
List<clsXzSchoolEN> arrObjLst = clsXzSchoolWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzSchoolEN objXzSchoolEN = new clsXzSchoolEN()
{
IdSchool = "0",
SchoolName = "选[学校]..."
};
arrObjLst.Insert(0, objXzSchoolEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzSchool.IdSchool;
objComboBox.DisplayMember = conXzSchool.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzSchoolEN objXzSchoolEN)
{
if (!Object.Equals(null, objXzSchoolEN.IdSchool) && GetStrLen(objXzSchoolEN.IdSchool) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolId) && GetStrLen(objXzSchoolEN.SchoolId) > 20)
{
 throw new Exception("字段[学校Id]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolName) && GetStrLen(objXzSchoolEN.SchoolName) > 50)
{
 throw new Exception("字段[学校名称]的长度不能超过50!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolENName) && GetStrLen(objXzSchoolEN.SchoolENName) > 50)
{
 throw new Exception("字段[学校英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolNameA) && GetStrLen(objXzSchoolEN.SchoolNameA) > 14)
{
 throw new Exception("字段[学校简称]的长度不能超过14!");
}
if (!Object.Equals(null, objXzSchoolEN.SchoolTypeId) && GetStrLen(objXzSchoolEN.SchoolTypeId) > 2)
{
 throw new Exception("字段[学校类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objXzSchoolEN.UpdDate) && GetStrLen(objXzSchoolEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchoolEN.UpdUserId) && GetStrLen(objXzSchoolEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchoolEN.Memo) && GetStrLen(objXzSchoolEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objXzSchoolEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchoolEN GetObjByIdSchool(string strIdSchool)
{
if (strIdSchool == "") return null;
string strAction = "GetObjByIdSchool";
clsXzSchoolEN objXzSchoolEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strIdSchool"] = strIdSchool,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objXzSchoolEN = JsonConvert.DeserializeObject<clsXzSchoolEN>(strJson);
return objXzSchoolEN;
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
public static clsXzSchoolEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsXzSchoolEN objXzSchoolEN;
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
objXzSchoolEN = JsonConvert.DeserializeObject<clsXzSchoolEN>(strJson);
return objXzSchoolEN;
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
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchoolEN GetObjByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
from objXzSchoolEN in arrXzSchoolObjLstCache
where objXzSchoolEN.IdSchool == strIdSchool 
select objXzSchoolEN;
if (arrXzSchoolObjLst_Sel.Count() == 0)
{
   clsXzSchoolEN obj = clsXzSchoolWApi.GetObjByIdSchool(strIdSchool);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzSchoolObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//初始化列表缓存
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel1 =
from objXzSchoolEN in arrXzSchoolObjLstCache
where objXzSchoolEN.IdSchool == strIdSchool 
select objXzSchoolEN;
List <clsXzSchoolEN> arrXzSchoolObjLst_Sel = new List<clsXzSchoolEN>();
foreach (clsXzSchoolEN obj in arrXzSchoolObjLst_Sel1)
{
arrXzSchoolObjLst_Sel.Add(obj);
}
if (arrXzSchoolObjLst_Sel.Count > 0)
{
return arrXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录[IdSchool = {0}](函数:{1})", strIdSchool, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSchool">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSchoolCache(string strIdSchool)
{
if (string.IsNullOrEmpty(strIdSchool) == true) return "";
//初始化列表缓存
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel1 =
from objXzSchoolEN in arrXzSchoolObjLstCache
where objXzSchoolEN.IdSchool == strIdSchool 
select objXzSchoolEN;
List <clsXzSchoolEN> arrXzSchoolObjLst_Sel = new List<clsXzSchoolEN>();
foreach (clsXzSchoolEN obj in arrXzSchoolObjLst_Sel1)
{
arrXzSchoolObjLst_Sel.Add(obj);
}
if (arrXzSchoolObjLst_Sel.Count > 0)
{
return arrXzSchoolObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool对象缓存列表中,找不到记录的相关名称[IdSchool = {0}](函数:{1})", strIdSchool, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchoolBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLst(string strWhereCond)
{
 List<clsXzSchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
 /// <param name = "arrIdSchool">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstByIdSchoolLst(List<string> arrIdSchool)
{
 List<clsXzSchoolEN> arrObjLst; 
string strAction = "GetObjLstByIdSchoolLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdSchool);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
 /// <param name = "arrIdSchool">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsXzSchoolEN> GetObjLstByIdSchoolLstCache(List<string> arrIdSchool)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
List<clsXzSchoolEN> arrXzSchoolObjLstCache = GetObjLstCache();
IEnumerable <clsXzSchoolEN> arrXzSchoolObjLst_Sel =
from objXzSchoolEN in arrXzSchoolObjLstCache
where arrIdSchool.Contains(objXzSchoolEN.IdSchool)
select objXzSchoolEN;
return arrXzSchoolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchoolEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzSchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
public static List<clsXzSchoolEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzSchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
public static List<clsXzSchoolEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzSchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
public static List<clsXzSchoolEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsXzSchoolEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchoolEN>>(strJson);
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
public static int DelRecord(string strIdSchool)
{
string strAction = "DelRecord";
try
{
 clsXzSchoolEN objXzSchoolEN = clsXzSchoolWApi.GetObjByIdSchool(strIdSchool);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strIdSchool.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsXzSchoolWApi.ReFreshCache();
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
public static int DelXzSchools(List<string> arrIdSchool)
{
string strAction = "DelXzSchools";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrIdSchool);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsXzSchoolWApi.ReFreshCache();
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
public static int DelXzSchoolsByCond(string strWhereCond)
{
string strAction = "DelXzSchoolsByCond";
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
public static bool AddNewRecord(clsXzSchoolEN objXzSchoolEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchoolEN>(objXzSchoolEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzSchoolEN objXzSchoolEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchoolEN>(objXzSchoolEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchoolWApi.ReFreshCache();
var strIdSchool = (string)jobjReturn0["returnStr"];
return strIdSchool;
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
public static bool UpdateRecord(clsXzSchoolEN objXzSchoolEN)
{
if (string.IsNullOrEmpty(objXzSchoolEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchoolEN.IdSchool, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchoolEN>(objXzSchoolEN);
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
 /// <param name = "objXzSchoolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzSchoolEN objXzSchoolEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzSchoolEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchoolEN.IdSchool, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchoolEN.IdSchool, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchoolEN>(objXzSchoolEN);
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
public static bool IsExist(string strIdSchool)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strIdSchool"] = strIdSchool
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
 /// <param name = "objXzSchoolENS">源对象</param>
 /// <param name = "objXzSchoolENT">目标对象</param>
 public static void CopyTo(clsXzSchoolEN objXzSchoolENS, clsXzSchoolEN objXzSchoolENT)
{
try
{
objXzSchoolENT.IdSchool = objXzSchoolENS.IdSchool; //学校流水号
objXzSchoolENT.SchoolId = objXzSchoolENS.SchoolId; //学校Id
objXzSchoolENT.SchoolName = objXzSchoolENS.SchoolName; //学校名称
objXzSchoolENT.IsCurrentUse = objXzSchoolENS.IsCurrentUse; //是否当前使用
objXzSchoolENT.SchoolENName = objXzSchoolENS.SchoolENName; //学校英文名
objXzSchoolENT.SchoolNameA = objXzSchoolENS.SchoolNameA; //学校简称
objXzSchoolENT.SchoolTypeId = objXzSchoolENS.SchoolTypeId; //学校类型Id
objXzSchoolENT.UpdDate = objXzSchoolENS.UpdDate; //修改日期
objXzSchoolENT.UpdUserId = objXzSchoolENS.UpdUserId; //修改用户Id
objXzSchoolENT.Memo = objXzSchoolENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsXzSchoolEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzSchoolEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzSchoolEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzSchoolEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzSchoolEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzSchoolEN._AttributeName)
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
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
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
if (clsXzSchoolWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzSchoolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzSchoolWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchoolEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsXzSchoolEN._CurrTabName;
List<clsXzSchoolEN> arrXzSchoolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrXzSchoolObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzSchoolEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzSchool.IdSchool, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.IsCurrentUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzSchool.SchoolENName, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.SchoolNameA, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.SchoolTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool.Memo, Type.GetType("System.String"));
foreach (clsXzSchoolEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzSchool.IdSchool] = objInFor[conXzSchool.IdSchool];
objDR[conXzSchool.SchoolId] = objInFor[conXzSchool.SchoolId];
objDR[conXzSchool.SchoolName] = objInFor[conXzSchool.SchoolName];
objDR[conXzSchool.IsCurrentUse] = objInFor[conXzSchool.IsCurrentUse];
objDR[conXzSchool.SchoolENName] = objInFor[conXzSchool.SchoolENName];
objDR[conXzSchool.SchoolNameA] = objInFor[conXzSchool.SchoolNameA];
objDR[conXzSchool.SchoolTypeId] = objInFor[conXzSchool.SchoolTypeId];
objDR[conXzSchool.UpdDate] = objInFor[conXzSchool.UpdDate];
objDR[conXzSchool.UpdUserId] = objInFor[conXzSchool.UpdUserId];
objDR[conXzSchool.Memo] = objInFor[conXzSchool.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学校(XzSchool)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4XzSchool : clsCommFun4BL
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
clsXzSchoolWApi.ReFreshThisCache();
}
}

}