
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProgLangTypeWApi
 表名:ProgLangType(00050303)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
public static class  clsProgLangTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeId(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conProgLangType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conProgLangType.ProgLangTypeId);
objProgLangTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, conProgLangType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, conProgLangType.ProgLangTypeName);
objProgLangTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeSimName">编程语言类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeSimName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeSimName, 30, conProgLangType.ProgLangTypeSimName);
objProgLangTypeEN.ProgLangTypeSimName = strProgLangTypeSimName; //编程语言类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeSimName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeSimName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeSimName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeENName">编程语言类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetProgLangTypeENName(this clsProgLangTypeEN objProgLangTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, conProgLangType.ProgLangTypeENName);
objProgLangTypeEN.ProgLangTypeENName = strProgLangTypeENName; //编程语言类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.ProgLangTypeENName) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.ProgLangTypeENName, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.ProgLangTypeENName] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId">字符编码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetCharEncodingId(this clsProgLangTypeEN objProgLangTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, conProgLangType.CharEncodingId);
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, conProgLangType.CharEncodingId);
objProgLangTypeEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.CharEncodingId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.CharEncodingId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.CharEncodingId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetIsVisible(this clsProgLangTypeEN objProgLangTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objProgLangTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.IsVisible) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.IsVisible, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.IsVisible] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetOrderNum(this clsProgLangTypeEN objProgLangTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conProgLangType.OrderNum);
objProgLangTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.OrderNum) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.OrderNum, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.OrderNum] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetUpdDate(this clsProgLangTypeEN objProgLangTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conProgLangType.UpdDate);
objProgLangTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.UpdDate) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.UpdDate, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.UpdDate] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetUpdUserId(this clsProgLangTypeEN objProgLangTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conProgLangType.UpdUserId);
objProgLangTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.UpdUserId) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.UpdUserId, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.UpdUserId] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsProgLangTypeEN SetMemo(this clsProgLangTypeEN objProgLangTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conProgLangType.Memo);
objProgLangTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objProgLangTypeEN.dicFldComparisonOp.ContainsKey(conProgLangType.Memo) == false)
{
objProgLangTypeEN.dicFldComparisonOp.Add(conProgLangType.Memo, strComparisonOp);
}
else
{
objProgLangTypeEN.dicFldComparisonOp[conProgLangType.Memo] = strComparisonOp;
}
}
return objProgLangTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsProgLangTypeEN objProgLangTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeId, objProgLangTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeName, objProgLangTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeSimName) == true)
{
string strComparisonOpProgLangTypeSimName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeSimName, objProgLangTypeCond.ProgLangTypeSimName, strComparisonOpProgLangTypeSimName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.ProgLangTypeENName) == true)
{
string strComparisonOpProgLangTypeENName = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.ProgLangTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.ProgLangTypeENName, objProgLangTypeCond.ProgLangTypeENName, strComparisonOpProgLangTypeENName);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.CharEncodingId, objProgLangTypeCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.IsVisible) == true)
{
if (objProgLangTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conProgLangType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conProgLangType.IsVisible);
}
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.OrderNum) == true)
{
string strComparisonOpOrderNum = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conProgLangType.OrderNum, objProgLangTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.UpdDate) == true)
{
string strComparisonOpUpdDate = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.UpdDate, objProgLangTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.UpdUserId, objProgLangTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objProgLangTypeCond.IsUpdated(conProgLangType.Memo) == true)
{
string strComparisonOpMemo = objProgLangTypeCond.dicFldComparisonOp[conProgLangType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conProgLangType.Memo, objProgLangTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsProgLangTypeEN objProgLangTypeEN)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objProgLangTypeEN.sfUpdFldSetStr = objProgLangTypeEN.getsfUpdFldSetStr();
clsProgLangTypeWApi.CheckPropertyNew(objProgLangTypeEN); 
bool bolResult = clsProgLangTypeWApi.UpdateRecord(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsProgLangTypeEN objProgLangTypeEN)
{
 if (string.IsNullOrEmpty(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsProgLangTypeWApi.IsExist(objProgLangTypeEN.ProgLangTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objProgLangTypeEN.ProgLangTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsProgLangTypeWApi.CheckPropertyNew(objProgLangTypeEN); 
bool bolResult = clsProgLangTypeWApi.AddNewRecord(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
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
 /// <param name = "objProgLangTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsProgLangTypeEN objProgLangTypeEN)
{
try
{
clsProgLangTypeWApi.CheckPropertyNew(objProgLangTypeEN); 
string strProgLangTypeId = clsProgLangTypeWApi.AddNewRecordWithMaxId(objProgLangTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
return strProgLangTypeId;
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
 /// <param name = "objProgLangTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsProgLangTypeEN objProgLangTypeEN, string strWhereCond)
{
try
{
clsProgLangTypeWApi.CheckPropertyNew(objProgLangTypeEN); 
bool bolResult = clsProgLangTypeWApi.UpdateWithCondition(objProgLangTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
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
public class enumProgLangTypeWA
{
 /// <summary>
 /// AA0
 /// </summary>
public const string AA0_00 = "00";
 /// <summary>
 /// CSharp
 /// </summary>
public const string CSharp_01 = "01";
 /// <summary>
 /// JAVA
 /// </summary>
public const string JAVA_02 = "02";
 /// <summary>
 /// Swift
 /// </summary>
public const string Swift_03 = "03";
 /// <summary>
 /// JavaScript
 /// </summary>
public const string JavaScript_04 = "04";
 /// <summary>
 /// SilverLight
 /// </summary>
public const string SilverLight_05 = "05";
 /// <summary>
 /// VB
 /// </summary>
public const string VB_06 = "06";
 /// <summary>
 /// Swift3
 /// </summary>
public const string Swift3_07 = "07";
 /// <summary>
 /// Swift4
 /// </summary>
public const string Swift4_08 = "08";
 /// <summary>
 /// TypeScript
 /// </summary>
public const string TypeScript_09 = "09";
 /// <summary>
 /// Html
 /// </summary>
public const string Html_10 = "10";
}
 /// <summary>
 /// 编程语言类型(ProgLangType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsProgLangTypeWApi
{
private static readonly string mstrApiControllerName = "ProgLangTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsProgLangTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[编程语言类型]...","0");
List<clsProgLangTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ProgLangTypeId";
objDDL.DataTextField="ProgLangTypeName";
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

public static void BindCbo_ProgLangTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conProgLangType.ProgLangTypeId); 
List<clsProgLangTypeEN> arrObjLst = clsProgLangTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.OrderNum).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsProgLangTypeEN objProgLangTypeEN = new clsProgLangTypeEN()
{
ProgLangTypeId = "0",
ProgLangTypeName = "选[编程语言类型]..."
};
arrObjLst.Insert(0, objProgLangTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conProgLangType.ProgLangTypeId;
objComboBox.DisplayMember = conProgLangType.ProgLangTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsProgLangTypeEN objProgLangTypeEN)
{
if (!Object.Equals(null, objProgLangTypeEN.ProgLangTypeId) && GetStrLen(objProgLangTypeEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objProgLangTypeEN.ProgLangTypeName) && GetStrLen(objProgLangTypeEN.ProgLangTypeName) > 30)
{
 throw new Exception("字段[编程语言类型名]的长度不能超过30!");
}
if (!Object.Equals(null, objProgLangTypeEN.ProgLangTypeSimName) && GetStrLen(objProgLangTypeEN.ProgLangTypeSimName) > 30)
{
 throw new Exception("字段[编程语言类型简称]的长度不能超过30!");
}
if (!Object.Equals(null, objProgLangTypeEN.ProgLangTypeENName) && GetStrLen(objProgLangTypeEN.ProgLangTypeENName) > 50)
{
 throw new Exception("字段[编程语言类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objProgLangTypeEN.CharEncodingId) && GetStrLen(objProgLangTypeEN.CharEncodingId) > 20)
{
 throw new Exception("字段[字符编码]的长度不能超过20!");
}
if (!Object.Equals(null, objProgLangTypeEN.UpdDate) && GetStrLen(objProgLangTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objProgLangTypeEN.UpdUserId) && GetStrLen(objProgLangTypeEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objProgLangTypeEN.Memo) && GetStrLen(objProgLangTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objProgLangTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsProgLangTypeEN GetObjByProgLangTypeId(string strProgLangTypeId)
{
if (strProgLangTypeId == "") return null;
string strAction = "GetObjByProgLangTypeId";
clsProgLangTypeEN objProgLangTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strProgLangTypeId"] = strProgLangTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objProgLangTypeEN = JsonConvert.DeserializeObject<clsProgLangTypeEN>(strJson);
return objProgLangTypeEN;
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
public static clsProgLangTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsProgLangTypeEN objProgLangTypeEN;
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
objProgLangTypeEN = JsonConvert.DeserializeObject<clsProgLangTypeEN>(strJson);
return objProgLangTypeEN;
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
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsProgLangTypeEN GetObjByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel =
from objProgLangTypeEN in arrProgLangTypeObjLstCache
where objProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objProgLangTypeEN;
if (arrProgLangTypeObjLst_Sel.Count() == 0)
{
   clsProgLangTypeEN obj = clsProgLangTypeWApi.GetObjByProgLangTypeId(strProgLangTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrProgLangTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProgLangTypeNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//初始化列表缓存
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel1 =
from objProgLangTypeEN in arrProgLangTypeObjLstCache
where objProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objProgLangTypeEN;
List <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel = new List<clsProgLangTypeEN>();
foreach (clsProgLangTypeEN obj in arrProgLangTypeObjLst_Sel1)
{
arrProgLangTypeObjLst_Sel.Add(obj);
}
if (arrProgLangTypeObjLst_Sel.Count > 0)
{
return arrProgLangTypeObjLst_Sel[0].ProgLangTypeName;
}
string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[ProgLangTypeId = {0}](函数:{1})", strProgLangTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsProgLangTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//初始化列表缓存
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel1 =
from objProgLangTypeEN in arrProgLangTypeObjLstCache
where objProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objProgLangTypeEN;
List <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel = new List<clsProgLangTypeEN>();
foreach (clsProgLangTypeEN obj in arrProgLangTypeObjLst_Sel1)
{
arrProgLangTypeObjLst_Sel.Add(obj);
}
if (arrProgLangTypeObjLst_Sel.Count > 0)
{
return arrProgLangTypeObjLst_Sel[0].ProgLangTypeName;
}
string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录的相关名称[ProgLangTypeId = {0}](函数:{1})", strProgLangTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsProgLangTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLst(string strWhereCond)
{
 List<clsProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
 /// <param name = "arrProgLangTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstByProgLangTypeIdLst(List<string> arrProgLangTypeId)
{
 List<clsProgLangTypeEN> arrObjLst; 
string strAction = "GetObjLstByProgLangTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrProgLangTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
 /// <param name = "arrProgLangTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsProgLangTypeEN> GetObjLstByProgLangTypeIdLstCache(List<string> arrProgLangTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsProgLangTypeEN> arrProgLangTypeObjLst_Sel =
from objProgLangTypeEN in arrProgLangTypeObjLstCache
where arrProgLangTypeId.Contains(objProgLangTypeEN.ProgLangTypeId)
select objProgLangTypeEN;
return arrProgLangTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsProgLangTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
public static List<clsProgLangTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
public static List<clsProgLangTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
public static List<clsProgLangTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsProgLangTypeEN>>(strJson);
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
public static int DelRecord(string strProgLangTypeId)
{
string strAction = "DelRecord";
try
{
 clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeWApi.GetObjByProgLangTypeId(strProgLangTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strProgLangTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsProgLangTypeWApi.ReFreshCache();
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
public static int DelProgLangTypes(List<string> arrProgLangTypeId)
{
string strAction = "DelProgLangTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrProgLangTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsProgLangTypeWApi.ReFreshCache();
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
public static int DelProgLangTypesByCond(string strWhereCond)
{
string strAction = "DelProgLangTypesByCond";
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
public static bool AddNewRecord(clsProgLangTypeEN objProgLangTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProgLangTypeEN>(objProgLangTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsProgLangTypeEN objProgLangTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProgLangTypeEN>(objProgLangTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsProgLangTypeWApi.ReFreshCache();
var strProgLangTypeId = (string)jobjReturn0["returnStr"];
return strProgLangTypeId;
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
public static bool UpdateRecord(clsProgLangTypeEN objProgLangTypeEN)
{
if (string.IsNullOrEmpty(objProgLangTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProgLangTypeEN.ProgLangTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProgLangTypeEN>(objProgLangTypeEN);
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
 /// <param name = "objProgLangTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsProgLangTypeEN objProgLangTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objProgLangTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProgLangTypeEN.ProgLangTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objProgLangTypeEN.ProgLangTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsProgLangTypeEN>(objProgLangTypeEN);
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
public static bool IsExist(string strProgLangTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strProgLangTypeId"] = strProgLangTypeId
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
 /// <param name = "objProgLangTypeENS">源对象</param>
 /// <param name = "objProgLangTypeENT">目标对象</param>
 public static void CopyTo(clsProgLangTypeEN objProgLangTypeENS, clsProgLangTypeEN objProgLangTypeENT)
{
try
{
objProgLangTypeENT.ProgLangTypeId = objProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objProgLangTypeENT.ProgLangTypeName = objProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objProgLangTypeENT.ProgLangTypeSimName = objProgLangTypeENS.ProgLangTypeSimName; //编程语言类型简称
objProgLangTypeENT.ProgLangTypeENName = objProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objProgLangTypeENT.CharEncodingId = objProgLangTypeENS.CharEncodingId; //字符编码
objProgLangTypeENT.IsVisible = objProgLangTypeENS.IsVisible; //是否显示
objProgLangTypeENT.OrderNum = objProgLangTypeENS.OrderNum; //序号
objProgLangTypeENT.UpdDate = objProgLangTypeENS.UpdDate; //修改日期
objProgLangTypeENT.UpdUserId = objProgLangTypeENS.UpdUserId; //修改用户Id
objProgLangTypeENT.Memo = objProgLangTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsProgLangTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsProgLangTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsProgLangTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsProgLangTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsProgLangTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsProgLangTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
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
if (clsProgLangTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsProgLangTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsProgLangTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsProgLangTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsProgLangTypeEN._CurrTabName;
List<clsProgLangTypeEN> arrProgLangTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrProgLangTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsProgLangTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conProgLangType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.ProgLangTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.ProgLangTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.CharEncodingId, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conProgLangType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conProgLangType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conProgLangType.Memo, Type.GetType("System.String"));
foreach (clsProgLangTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conProgLangType.ProgLangTypeId] = objInFor[conProgLangType.ProgLangTypeId];
objDR[conProgLangType.ProgLangTypeName] = objInFor[conProgLangType.ProgLangTypeName];
objDR[conProgLangType.ProgLangTypeSimName] = objInFor[conProgLangType.ProgLangTypeSimName];
objDR[conProgLangType.ProgLangTypeENName] = objInFor[conProgLangType.ProgLangTypeENName];
objDR[conProgLangType.CharEncodingId] = objInFor[conProgLangType.CharEncodingId];
objDR[conProgLangType.IsVisible] = objInFor[conProgLangType.IsVisible];
objDR[conProgLangType.OrderNum] = objInFor[conProgLangType.OrderNum];
objDR[conProgLangType.UpdDate] = objInFor[conProgLangType.UpdDate];
objDR[conProgLangType.UpdUserId] = objInFor[conProgLangType.UpdUserId];
objDR[conProgLangType.Memo] = objInFor[conProgLangType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 编程语言类型(ProgLangType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ProgLangType : clsCommFun4BL
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
clsProgLangTypeWApi.ReFreshThisCache();
}
}

}