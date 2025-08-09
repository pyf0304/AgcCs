
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDict4GCWApi
 表名:Dict4GC(00050351)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:40:53
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
public static class  clsDict4GCWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictId">字典Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictId(this clsDict4GCEN objDict4GCEN, string strDictId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDictId, 8, conDict4GC.DictId);
clsCheckSql.CheckFieldForeignKey(strDictId, 8, conDict4GC.DictId);
objDict4GCEN.DictId = strDictId; //字典Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictId) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictId, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictId] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictValue">字典值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictValue(this clsDict4GCEN objDict4GCEN, string strDictValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictValue, conDict4GC.DictValue);
clsCheckSql.CheckFieldLen(strDictValue, 500, conDict4GC.DictValue);
objDict4GCEN.DictValue = strDictValue; //字典值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictValue) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictValue, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictValue] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictTypeId">字典类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictTypeId(this clsDict4GCEN objDict4GCEN, string strDictTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDictTypeId, 4, conDict4GC.DictTypeId);
clsCheckSql.CheckFieldForeignKey(strDictTypeId, 4, conDict4GC.DictTypeId);
objDict4GCEN.DictTypeId = strDictTypeId; //字典类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictTypeId) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictTypeId, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictTypeId] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictKey1">字典关键字1</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictKey1(this clsDict4GCEN objDict4GCEN, string strDictKey1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey1, conDict4GC.DictKey1);
clsCheckSql.CheckFieldLen(strDictKey1, 50, conDict4GC.DictKey1);
objDict4GCEN.DictKey1 = strDictKey1; //字典关键字1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictKey1) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictKey1, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictKey1] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strDictKey2">字典关键字2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetDictKey2(this clsDict4GCEN objDict4GCEN, string strDictKey2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDictKey2, 50, conDict4GC.DictKey2);
objDict4GCEN.DictKey2 = strDictKey2; //字典关键字2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.DictKey2) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.DictKey2, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.DictKey2] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetUpdDate(this clsDict4GCEN objDict4GCEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDict4GC.UpdDate);
objDict4GCEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.UpdDate) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.UpdDate, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.UpdDate] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetUpdUser(this clsDict4GCEN objDict4GCEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDict4GC.UpdUser);
objDict4GCEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.UpdUser) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.UpdUser, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.UpdUser] = strComparisonOp;
}
}
return objDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDict4GCEN SetMemo(this clsDict4GCEN objDict4GCEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDict4GC.Memo);
objDict4GCEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDict4GCEN.dicFldComparisonOp.ContainsKey(conDict4GC.Memo) == false)
{
objDict4GCEN.dicFldComparisonOp.Add(conDict4GC.Memo, strComparisonOp);
}
else
{
objDict4GCEN.dicFldComparisonOp[conDict4GC.Memo] = strComparisonOp;
}
}
return objDict4GCEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDict4GCEN objDict4GCCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDict4GCCond.IsUpdated(conDict4GC.DictId) == true)
{
string strComparisonOpDictId = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictId, objDict4GCCond.DictId, strComparisonOpDictId);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictValue) == true)
{
string strComparisonOpDictValue = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictValue, objDict4GCCond.DictValue, strComparisonOpDictValue);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictTypeId) == true)
{
string strComparisonOpDictTypeId = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictTypeId, objDict4GCCond.DictTypeId, strComparisonOpDictTypeId);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictKey1) == true)
{
string strComparisonOpDictKey1 = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictKey1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictKey1, objDict4GCCond.DictKey1, strComparisonOpDictKey1);
}
if (objDict4GCCond.IsUpdated(conDict4GC.DictKey2) == true)
{
string strComparisonOpDictKey2 = objDict4GCCond.dicFldComparisonOp[conDict4GC.DictKey2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.DictKey2, objDict4GCCond.DictKey2, strComparisonOpDictKey2);
}
if (objDict4GCCond.IsUpdated(conDict4GC.UpdDate) == true)
{
string strComparisonOpUpdDate = objDict4GCCond.dicFldComparisonOp[conDict4GC.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.UpdDate, objDict4GCCond.UpdDate, strComparisonOpUpdDate);
}
if (objDict4GCCond.IsUpdated(conDict4GC.UpdUser) == true)
{
string strComparisonOpUpdUser = objDict4GCCond.dicFldComparisonOp[conDict4GC.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.UpdUser, objDict4GCCond.UpdUser, strComparisonOpUpdUser);
}
if (objDict4GCCond.IsUpdated(conDict4GC.Memo) == true)
{
string strComparisonOpMemo = objDict4GCCond.dicFldComparisonOp[conDict4GC.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDict4GC.Memo, objDict4GCCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDict4GCEN objDict4GCEN)
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDict4GCEN.sfUpdFldSetStr = objDict4GCEN.getsfUpdFldSetStr();
clsDict4GCWApi.CheckPropertyNew(objDict4GCEN); 
bool bolResult = clsDict4GCWApi.UpdateRecord(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
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
 /// 获取唯一性条件串--Dict4GC(生成代码字典), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DictValue_DictTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDict4GCEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDict4GCEN objDict4GCEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDict4GCEN == null) return "";
if (objDict4GCEN.DictId == null || objDict4GCEN.DictId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DictId !=  '{0}'", objDict4GCEN.DictId);
 sbCondition.AppendFormat(" and DictValue = '{0}'", objDict4GCEN.DictValue);
 sbCondition.AppendFormat(" and DictTypeId = '{0}'", objDict4GCEN.DictTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDict4GCEN objDict4GCEN)
{
try
{
 if (string.IsNullOrEmpty(objDict4GCEN.DictId) == true || clsDict4GCWApi.IsExist(objDict4GCEN.DictId) == true)
 {
     objDict4GCEN.DictId = clsDict4GCWApi.GetMaxStrId();
 }
clsDict4GCWApi.CheckPropertyNew(objDict4GCEN); 
bool bolResult = clsDict4GCWApi.AddNewRecord(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
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
 /// <param name = "objDict4GCEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDict4GCEN objDict4GCEN)
{
try
{
clsDict4GCWApi.CheckPropertyNew(objDict4GCEN); 
string strDictId = clsDict4GCWApi.AddNewRecordWithMaxId(objDict4GCEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
return strDictId;
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDict4GCEN objDict4GCEN, string strWhereCond)
{
try
{
clsDict4GCWApi.CheckPropertyNew(objDict4GCEN); 
bool bolResult = clsDict4GCWApi.UpdateWithCondition(objDict4GCEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
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
 /// 根据表字段内容设置enum列表-字段名：[DictKey1]
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList4Field)
 /// </summary>
public class enumDict4GC_DictKey1WS
{
 /// <summary>
 /// GetRecordJSONObjByKey
 /// </summary>
public const string conGetRecordJSONObjByKey = "GetRecordJSONObjByKey";
 /// <summary>
 /// GetRecordJSONObjLst
 /// </summary>
public const string conGetRecordJSONObjLst = "GetRecordJSONObjLst";
 /// <summary>
 /// GetTopRecordJSONObjLst
 /// </summary>
public const string conGetTopRecordJSONObjLst = "GetTopRecordJSONObjLst";
 /// <summary>
 /// AddNewRecordByJSON
 /// </summary>
public const string conAddNewRecordByJSON = "AddNewRecordByJSON";
 /// <summary>
 /// UpdateRecordByJSON
 /// </summary>
public const string conUpdateRecordByJSON = "UpdateRecordByJSON";
 /// <summary>
 /// DelRecord
 /// </summary>
public const string conDelRecord = "DelRecord";
 /// <summary>
 /// GetFirstJSONObj
 /// </summary>
public const string conGetFirstJSONObj = "GetFirstJSONObj";
 /// <summary>
 /// IsExistRecord
 /// </summary>
public const string conIsExistRecord = "IsExistRecord";
 /// <summary>
 /// GetMaxStrId
 /// </summary>
public const string conGetMaxStrId = "GetMaxStrId";
 /// <summary>
 /// GetMaxStrIdByPrefix
 /// </summary>
public const string conGetMaxStrIdByPrefix = "GetMaxStrIdByPrefix";
 /// <summary>
 /// SelfDefFunc
 /// </summary>
public const string conSelfDefFunc = "SelfDefFunc";
 /// <summary>
 /// GetRecordJSONObjLstByPager
 /// </summary>
public const string conGetRecordJSONObjLstByPager = "GetRecordJSONObjLstByPager";
 /// <summary>
 /// GetRecCountByCond
 /// </summary>
public const string conGetRecCountByCond = "GetRecCountByCond";
 /// <summary>
 /// DelRecordsByJSON
 /// </summary>
public const string conDelRecordsByJSON = "DelRecordsByJSON";
 /// <summary>
 /// GetRecordJSONObjLstByRange
 /// </summary>
public const string conGetRecordJSONObjLstByRange = "GetRecordJSONObjLstByRange";
 /// <summary>
 /// GetObjByKey
 /// </summary>
public const string conGetObjByKey = "GetObjByKey";
 /// <summary>
 /// AddNewRecord
 /// </summary>
public const string conAddNewRecord = "AddNewRecord";
 /// <summary>
 /// GetFirstObj
 /// </summary>
public const string conGetFirstObj = "GetFirstObj";
 /// <summary>
 /// GetObjLstByPager
 /// </summary>
public const string conGetObjLstByPager = "GetObjLstByPager";
 /// <summary>
 /// GetObjLstByRange
 /// </summary>
public const string conGetObjLstByRange = "GetObjLstByRange";
 /// <summary>
 /// GetObjLst
 /// </summary>
public const string conGetObjLst = "GetObjLst";
 /// <summary>
 /// GetTopObjLst
 /// </summary>
public const string conGetTopObjLst = "GetTopObjLst";
 /// <summary>
 /// UpdateRecord
 /// </summary>
public const string conUpdateRecord = "UpdateRecord";
}
 /// <summary>
 /// 根据表字段内容设置enum列表-字段名：[DictKey2]
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList4Field)
 /// </summary>
public class enumDict4GC_DictKey2WS
{
 /// <summary>
 /// Finished
 /// </summary>
public const string conFinished = "Finished";
 /// <summary>
 /// CorrectFinished
 /// </summary>
public const string conCorrectFinished = "CorrectFinished";
}
 /// <summary>
 /// 生成代码字典(Dict4GC)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDict4GCWApi
{
private static readonly string mstrApiControllerName = "Dict4GCApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDict4GCWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDict4GCEN objDict4GCEN)
{
if (!Object.Equals(null, objDict4GCEN.DictId) && GetStrLen(objDict4GCEN.DictId) > 8)
{
 throw new Exception("字段[字典Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDict4GCEN.DictValue) && GetStrLen(objDict4GCEN.DictValue) > 500)
{
 throw new Exception("字段[字典值]的长度不能超过500!");
}
if (!Object.Equals(null, objDict4GCEN.DictTypeId) && GetStrLen(objDict4GCEN.DictTypeId) > 4)
{
 throw new Exception("字段[字典类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDict4GCEN.DictKey1) && GetStrLen(objDict4GCEN.DictKey1) > 50)
{
 throw new Exception("字段[字典关键字1]的长度不能超过50!");
}
if (!Object.Equals(null, objDict4GCEN.DictKey2) && GetStrLen(objDict4GCEN.DictKey2) > 50)
{
 throw new Exception("字段[字典关键字2]的长度不能超过50!");
}
if (!Object.Equals(null, objDict4GCEN.UpdDate) && GetStrLen(objDict4GCEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDict4GCEN.UpdUser) && GetStrLen(objDict4GCEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDict4GCEN.Memo) && GetStrLen(objDict4GCEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDict4GCEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDict4GCEN GetObjByDictId(string strDictId)
{
if (strDictId == "") return null;
string strAction = "GetObjByDictId";
clsDict4GCEN objDict4GCEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDictId"] = strDictId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDict4GCEN = JsonConvert.DeserializeObject<clsDict4GCEN>(strJson);
return objDict4GCEN;
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
public static clsDict4GCEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDict4GCEN objDict4GCEN;
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
objDict4GCEN = JsonConvert.DeserializeObject<clsDict4GCEN>(strJson);
return objDict4GCEN;
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
 /// <param name = "strDictId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDict4GCEN GetObjByDictIdCache(string strDictId)
{
if (string.IsNullOrEmpty(strDictId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
List<clsDict4GCEN> arrDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrDict4GCObjLst_Sel =
from objDict4GCEN in arrDict4GCObjLstCache
where objDict4GCEN.DictId == strDictId 
select objDict4GCEN;
if (arrDict4GCObjLst_Sel.Count() == 0)
{
   clsDict4GCEN obj = clsDict4GCWApi.GetObjByDictId(strDictId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDict4GCObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetObjLst(string strWhereCond)
{
 List<clsDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
 /// <param name = "arrDictId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetObjLstByDictIdLst(List<string> arrDictId)
{
 List<clsDict4GCEN> arrObjLst; 
string strAction = "GetObjLstByDictIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDictId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
 /// <param name = "arrDictId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDict4GCEN> GetObjLstByDictIdLstCache(List<string> arrDictId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
List<clsDict4GCEN> arrDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsDict4GCEN> arrDict4GCObjLst_Sel =
from objDict4GCEN in arrDict4GCObjLstCache
where arrDictId.Contains(objDict4GCEN.DictId)
select objDict4GCEN;
return arrDict4GCObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDict4GCEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
public static List<clsDict4GCEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
public static List<clsDict4GCEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
public static List<clsDict4GCEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDict4GCEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDict4GCEN>>(strJson);
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
public static int DelRecord(string strDictId)
{
string strAction = "DelRecord";
try
{
 clsDict4GCEN objDict4GCEN = clsDict4GCWApi.GetObjByDictId(strDictId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDictId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDict4GCWApi.ReFreshCache();
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
public static int DelDict4GCs(List<string> arrDictId)
{
string strAction = "DelDict4GCs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDictId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDict4GCWApi.ReFreshCache();
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
public static int DelDict4GCsByCond(string strWhereCond)
{
string strAction = "DelDict4GCsByCond";
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
public static bool AddNewRecord(clsDict4GCEN objDict4GCEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDict4GCEN>(objDict4GCEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsDict4GCEN objDict4GCEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDict4GCEN>(objDict4GCEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDict4GCWApi.ReFreshCache();
var strDictId = (string)jobjReturn0["returnStr"];
return strDictId;
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
public static bool UpdateRecord(clsDict4GCEN objDict4GCEN)
{
if (string.IsNullOrEmpty(objDict4GCEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDict4GCEN.DictId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDict4GCEN>(objDict4GCEN);
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
 /// <param name = "objDict4GCEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDict4GCEN objDict4GCEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDict4GCEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDict4GCEN.DictId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDict4GCEN.DictId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDict4GCEN>(objDict4GCEN);
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
public static bool IsExist(string strDictId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDictId"] = strDictId
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
 /// <param name = "objDict4GCENS">源对象</param>
 /// <param name = "objDict4GCENT">目标对象</param>
 public static void CopyTo(clsDict4GCEN objDict4GCENS, clsDict4GCEN objDict4GCENT)
{
try
{
objDict4GCENT.DictId = objDict4GCENS.DictId; //字典Id
objDict4GCENT.DictValue = objDict4GCENS.DictValue; //字典值
objDict4GCENT.DictTypeId = objDict4GCENS.DictTypeId; //字典类型Id
objDict4GCENT.DictKey1 = objDict4GCENS.DictKey1; //字典关键字1
objDict4GCENT.DictKey2 = objDict4GCENS.DictKey2; //字典关键字2
objDict4GCENT.UpdDate = objDict4GCENS.UpdDate; //修改日期
objDict4GCENT.UpdUser = objDict4GCENS.UpdUser; //修改者
objDict4GCENT.Memo = objDict4GCENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDict4GCEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDict4GCEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDict4GCEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDict4GCEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDict4GCEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDict4GCEN._AttributeName)
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
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
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
if (clsDict4GCWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDict4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDict4GCWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDict4GCEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDict4GCEN._CurrTabName;
List<clsDict4GCEN> arrDict4GCObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDict4GCObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDict4GCEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDict4GC.DictId, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.DictValue, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.DictTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.DictKey1, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.DictKey2, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDict4GC.Memo, Type.GetType("System.String"));
foreach (clsDict4GCEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDict4GC.DictId] = objInFor[conDict4GC.DictId];
objDR[conDict4GC.DictValue] = objInFor[conDict4GC.DictValue];
objDR[conDict4GC.DictTypeId] = objInFor[conDict4GC.DictTypeId];
objDR[conDict4GC.DictKey1] = objInFor[conDict4GC.DictKey1];
objDR[conDict4GC.DictKey2] = objInFor[conDict4GC.DictKey2];
objDR[conDict4GC.UpdDate] = objInFor[conDict4GC.UpdDate];
objDR[conDict4GC.UpdUser] = objInFor[conDict4GC.UpdUser];
objDR[conDict4GC.Memo] = objInFor[conDict4GC.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 生成代码字典(Dict4GC)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4Dict4GC : clsCommFun4BL
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
clsDict4GCWApi.ReFreshThisCache();
}
}

}