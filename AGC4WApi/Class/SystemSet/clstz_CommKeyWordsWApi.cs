
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clstz_CommKeyWordsWApi
 表名:tz_CommKeyWords(00050330)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:41:01
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
public static class  clstz_CommKeyWordsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId">关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetKeyId(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strKeyId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId, 8, contz_CommKeyWords.KeyId);
objtz_CommKeyWordsEN.KeyId = strKeyId; //关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.KeyId) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.KeyId, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.KeyId] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetKeyword(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyword, contz_CommKeyWords.Keyword);
clsCheckSql.CheckFieldLen(strKeyword, 50, contz_CommKeyWords.Keyword);
objtz_CommKeyWordsEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.Keyword) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.Keyword, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.Keyword] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetTableName(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableName, contz_CommKeyWords.TableName);
clsCheckSql.CheckFieldLen(strTableName, 100, contz_CommKeyWords.TableName);
objtz_CommKeyWordsEN.TableName = strTableName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.TableName) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.TableName, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.TableName] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTableKey">数据表关键字值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetTableKey(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strTableKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTableKey, contz_CommKeyWords.TableKey);
clsCheckSql.CheckFieldLen(strTableKey, 100, contz_CommKeyWords.TableKey);
objtz_CommKeyWordsEN.TableKey = strTableKey; //数据表关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.TableKey) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.TableKey, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.TableKey] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetUpdUser(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, contz_CommKeyWords.UpdUser);
objtz_CommKeyWordsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.UpdUser) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.UpdUser, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.UpdUser] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetUpdDate(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, contz_CommKeyWords.UpdDate);
objtz_CommKeyWordsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.UpdDate) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.UpdDate, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.UpdDate] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clstz_CommKeyWordsEN SetMemo(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, contz_CommKeyWords.Memo);
objtz_CommKeyWordsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objtz_CommKeyWordsEN.dicFldComparisonOp.ContainsKey(contz_CommKeyWords.Memo) == false)
{
objtz_CommKeyWordsEN.dicFldComparisonOp.Add(contz_CommKeyWords.Memo, strComparisonOp);
}
else
{
objtz_CommKeyWordsEN.dicFldComparisonOp[contz_CommKeyWords.Memo] = strComparisonOp;
}
}
return objtz_CommKeyWordsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clstz_CommKeyWordsEN objtz_CommKeyWordsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.KeyId) == true)
{
string strComparisonOpKeyId = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.KeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.KeyId, objtz_CommKeyWordsCond.KeyId, strComparisonOpKeyId);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.Keyword) == true)
{
string strComparisonOpKeyword = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.Keyword, objtz_CommKeyWordsCond.Keyword, strComparisonOpKeyword);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.TableName) == true)
{
string strComparisonOpTableName = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.TableName, objtz_CommKeyWordsCond.TableName, strComparisonOpTableName);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.TableKey) == true)
{
string strComparisonOpTableKey = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.TableKey, objtz_CommKeyWordsCond.TableKey, strComparisonOpTableKey);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.UpdUser) == true)
{
string strComparisonOpUpdUser = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.UpdUser, objtz_CommKeyWordsCond.UpdUser, strComparisonOpUpdUser);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.UpdDate) == true)
{
string strComparisonOpUpdDate = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.UpdDate, objtz_CommKeyWordsCond.UpdDate, strComparisonOpUpdDate);
}
if (objtz_CommKeyWordsCond.IsUpdated(contz_CommKeyWords.Memo) == true)
{
string strComparisonOpMemo = objtz_CommKeyWordsCond.dicFldComparisonOp[contz_CommKeyWords.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", contz_CommKeyWords.Memo, objtz_CommKeyWordsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
 if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.KeyId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objtz_CommKeyWordsEN.sfUpdFldSetStr = objtz_CommKeyWordsEN.getsfUpdFldSetStr();
clstz_CommKeyWordsWApi.CheckPropertyNew(objtz_CommKeyWordsEN); 
bool bolResult = clstz_CommKeyWordsWApi.UpdateRecord(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
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
 /// 获取唯一性条件串--tz_CommKeyWords(tz_通用关键字), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TableKey_KeyWord
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objtz_CommKeyWordsEN == null) return "";
if (objtz_CommKeyWordsEN.KeyId == null || objtz_CommKeyWordsEN.KeyId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KeyId !=  '{0}'", objtz_CommKeyWordsEN.KeyId);
 sbCondition.AppendFormat(" and TableKey = '{0}'", objtz_CommKeyWordsEN.TableKey);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objtz_CommKeyWordsEN.Keyword);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
clstz_CommKeyWordsWApi.CheckPropertyNew(objtz_CommKeyWordsEN); 
bool bolResult = clstz_CommKeyWordsWApi.AddNewRecord(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
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
 /// <param name = "objtz_CommKeyWordsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
try
{
clstz_CommKeyWordsWApi.CheckPropertyNew(objtz_CommKeyWordsEN); 
string strKeyId = clstz_CommKeyWordsWApi.AddNewRecordWithMaxId(objtz_CommKeyWordsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
return strKeyId;
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strWhereCond)
{
try
{
clstz_CommKeyWordsWApi.CheckPropertyNew(objtz_CommKeyWordsEN); 
bool bolResult = clstz_CommKeyWordsWApi.UpdateWithCondition(objtz_CommKeyWordsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
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
 /// tz_通用关键字(tz_CommKeyWords)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clstz_CommKeyWordsWApi
{
private static readonly string mstrApiControllerName = "tz_CommKeyWordsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clstz_CommKeyWordsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
if (!Object.Equals(null, objtz_CommKeyWordsEN.KeyId) && GetStrLen(objtz_CommKeyWordsEN.KeyId) > 8)
{
 throw new Exception("字段[关键字Id]的长度不能超过8!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.Keyword) && GetStrLen(objtz_CommKeyWordsEN.Keyword) > 50)
{
 throw new Exception("字段[关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.TableName) && GetStrLen(objtz_CommKeyWordsEN.TableName) > 100)
{
 throw new Exception("字段[表名]的长度不能超过100!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.TableKey) && GetStrLen(objtz_CommKeyWordsEN.TableKey) > 100)
{
 throw new Exception("字段[数据表关键字值]的长度不能超过100!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.UpdUser) && GetStrLen(objtz_CommKeyWordsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.UpdDate) && GetStrLen(objtz_CommKeyWordsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objtz_CommKeyWordsEN.Memo) && GetStrLen(objtz_CommKeyWordsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objtz_CommKeyWordsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKeyId">表关键字</param>
 /// <returns>表对象</returns>
public static clstz_CommKeyWordsEN GetObjByKeyId(string strKeyId)
{
if (strKeyId == "") return null;
string strAction = "GetObjByKeyId";
clstz_CommKeyWordsEN objtz_CommKeyWordsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strKeyId"] = strKeyId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objtz_CommKeyWordsEN = JsonConvert.DeserializeObject<clstz_CommKeyWordsEN>(strJson);
return objtz_CommKeyWordsEN;
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
public static clstz_CommKeyWordsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clstz_CommKeyWordsEN objtz_CommKeyWordsEN;
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
objtz_CommKeyWordsEN = JsonConvert.DeserializeObject<clstz_CommKeyWordsEN>(strJson);
return objtz_CommKeyWordsEN;
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
 /// <param name = "strKeyId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clstz_CommKeyWordsEN GetObjByKeyIdCache(string strKeyId)
{
if (string.IsNullOrEmpty(strKeyId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLst_Sel =
from objtz_CommKeyWordsEN in arrtz_CommKeyWordsObjLstCache
where objtz_CommKeyWordsEN.KeyId == strKeyId 
select objtz_CommKeyWordsEN;
if (arrtz_CommKeyWordsObjLst_Sel.Count() == 0)
{
   clstz_CommKeyWordsEN obj = clstz_CommKeyWordsWApi.GetObjByKeyId(strKeyId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrtz_CommKeyWordsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLst(string strWhereCond)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
 /// <param name = "arrKeyId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstByKeyIdLst(List<string> arrKeyId)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
string strAction = "GetObjLstByKeyIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrKeyId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
 /// <param name = "arrKeyId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clstz_CommKeyWordsEN> GetObjLstByKeyIdLstCache(List<string> arrKeyId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = GetObjLstCache();
IEnumerable <clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLst_Sel =
from objtz_CommKeyWordsEN in arrtz_CommKeyWordsObjLstCache
where arrKeyId.Contains(objtz_CommKeyWordsEN.KeyId)
select objtz_CommKeyWordsEN;
return arrtz_CommKeyWordsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
public static List<clstz_CommKeyWordsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
public static List<clstz_CommKeyWordsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
public static List<clstz_CommKeyWordsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clstz_CommKeyWordsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clstz_CommKeyWordsEN>>(strJson);
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
public static int DelRecord(string strKeyId)
{
string strAction = "DelRecord";
try
{
 clstz_CommKeyWordsEN objtz_CommKeyWordsEN = clstz_CommKeyWordsWApi.GetObjByKeyId(strKeyId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strKeyId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clstz_CommKeyWordsWApi.ReFreshCache();
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
public static int Deltz_CommKeyWordss(List<string> arrKeyId)
{
string strAction = "Deltz_CommKeyWordss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrKeyId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clstz_CommKeyWordsWApi.ReFreshCache();
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
public static int Deltz_CommKeyWordssByCond(string strWhereCond)
{
string strAction = "Deltz_CommKeyWordssByCond";
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
public static bool AddNewRecord(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_CommKeyWordsEN>(objtz_CommKeyWordsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_CommKeyWordsEN>(objtz_CommKeyWordsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
var strKeyId = (string)jobjReturn0["returnStr"];
return strKeyId;
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objtz_CommKeyWordsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_CommKeyWordsEN>(objtz_CommKeyWordsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clstz_CommKeyWordsWApi.ReFreshCache();
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
public static bool UpdateRecord(clstz_CommKeyWordsEN objtz_CommKeyWordsEN)
{
if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objtz_CommKeyWordsEN.KeyId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_CommKeyWordsEN>(objtz_CommKeyWordsEN);
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
 /// <param name = "objtz_CommKeyWordsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clstz_CommKeyWordsEN objtz_CommKeyWordsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objtz_CommKeyWordsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objtz_CommKeyWordsEN.KeyId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objtz_CommKeyWordsEN.KeyId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clstz_CommKeyWordsEN>(objtz_CommKeyWordsEN);
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
public static bool IsExist(string strKeyId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strKeyId"] = strKeyId
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
 /// <param name = "objtz_CommKeyWordsENS">源对象</param>
 /// <param name = "objtz_CommKeyWordsENT">目标对象</param>
 public static void CopyTo(clstz_CommKeyWordsEN objtz_CommKeyWordsENS, clstz_CommKeyWordsEN objtz_CommKeyWordsENT)
{
try
{
objtz_CommKeyWordsENT.KeyId = objtz_CommKeyWordsENS.KeyId; //关键字Id
objtz_CommKeyWordsENT.Keyword = objtz_CommKeyWordsENS.Keyword; //关键字
objtz_CommKeyWordsENT.TableName = objtz_CommKeyWordsENS.TableName; //表名
objtz_CommKeyWordsENT.TableKey = objtz_CommKeyWordsENS.TableKey; //数据表关键字值
objtz_CommKeyWordsENT.UpdUser = objtz_CommKeyWordsENS.UpdUser; //修改者
objtz_CommKeyWordsENT.UpdDate = objtz_CommKeyWordsENS.UpdDate; //修改日期
objtz_CommKeyWordsENT.Memo = objtz_CommKeyWordsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clstz_CommKeyWordsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clstz_CommKeyWordsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clstz_CommKeyWordsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clstz_CommKeyWordsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clstz_CommKeyWordsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clstz_CommKeyWordsEN._AttributeName)
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
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
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
if (clstz_CommKeyWordsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clstz_CommKeyWordsEN._CurrTabName);
CacheHelper.Remove(strKey);
clstz_CommKeyWordsWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clstz_CommKeyWordsEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clstz_CommKeyWordsEN._CurrTabName;
List<clstz_CommKeyWordsEN> arrtz_CommKeyWordsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrtz_CommKeyWordsObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clstz_CommKeyWordsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(contz_CommKeyWords.KeyId, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.TableName, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.TableKey, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(contz_CommKeyWords.Memo, Type.GetType("System.String"));
foreach (clstz_CommKeyWordsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[contz_CommKeyWords.KeyId] = objInFor[contz_CommKeyWords.KeyId];
objDR[contz_CommKeyWords.Keyword] = objInFor[contz_CommKeyWords.Keyword];
objDR[contz_CommKeyWords.TableName] = objInFor[contz_CommKeyWords.TableName];
objDR[contz_CommKeyWords.TableKey] = objInFor[contz_CommKeyWords.TableKey];
objDR[contz_CommKeyWords.UpdUser] = objInFor[contz_CommKeyWords.UpdUser];
objDR[contz_CommKeyWords.UpdDate] = objInFor[contz_CommKeyWords.UpdDate];
objDR[contz_CommKeyWords.Memo] = objInFor[contz_CommKeyWords.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// tz_通用关键字(tz_CommKeyWords)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4tz_CommKeyWords : clsCommFun4BL
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
clstz_CommKeyWordsWApi.ReFreshThisCache();
}
}

}