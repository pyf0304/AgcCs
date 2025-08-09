
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4CodeConvWApi
 表名:FieldTab4CodeConv(00050593)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsFieldTab4CodeConvWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetFldId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conFieldTab4CodeConv.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conFieldTab4CodeConv.FldId);
objFieldTab4CodeConvEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.FldId) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.FldId, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.FldId] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetPrjId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conFieldTab4CodeConv.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFieldTab4CodeConv.PrjId);
objFieldTab4CodeConvEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.PrjId) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.PrjId, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.PrjId] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabId">代码表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetCodeTabId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strCodeTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, conFieldTab4CodeConv.CodeTabId);
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, conFieldTab4CodeConv.CodeTabId);
objFieldTab4CodeConvEN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.CodeTabId) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.CodeTabId, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabId] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabNameId">代码_名Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetCodeTabNameId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strCodeTabNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, conFieldTab4CodeConv.CodeTabNameId);
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, conFieldTab4CodeConv.CodeTabNameId);
objFieldTab4CodeConvEN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.CodeTabNameId) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.CodeTabNameId, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabNameId] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strCodeTabCodeId">代码Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetCodeTabCodeId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strCodeTabCodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, conFieldTab4CodeConv.CodeTabCodeId);
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, conFieldTab4CodeConv.CodeTabCodeId);
objFieldTab4CodeConvEN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.CodeTabCodeId) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.CodeTabCodeId, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabCodeId] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetUpdDate(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conFieldTab4CodeConv.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFieldTab4CodeConv.UpdDate);
objFieldTab4CodeConvEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.UpdDate) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.UpdDate, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.UpdDate] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetUpdUser(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFieldTab4CodeConv.UpdUser);
objFieldTab4CodeConvEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.UpdUser) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.UpdUser, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.UpdUser] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4CodeConvEN SetMemo(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldTab4CodeConv.Memo);
objFieldTab4CodeConvEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(conFieldTab4CodeConv.Memo) == false)
{
objFieldTab4CodeConvEN.dicFldComparisonOp.Add(conFieldTab4CodeConv.Memo, strComparisonOp);
}
else
{
objFieldTab4CodeConvEN.dicFldComparisonOp[conFieldTab4CodeConv.Memo] = strComparisonOp;
}
}
return objFieldTab4CodeConvEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTab4CodeConvEN objFieldTab4CodeConvCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.FldId) == true)
{
string strComparisonOpFldId = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.FldId, objFieldTab4CodeConvCond.FldId, strComparisonOpFldId);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.PrjId) == true)
{
string strComparisonOpPrjId = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.PrjId, objFieldTab4CodeConvCond.PrjId, strComparisonOpPrjId);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.CodeTabId, objFieldTab4CodeConvCond.CodeTabId, strComparisonOpCodeTabId);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.CodeTabNameId, objFieldTab4CodeConvCond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.CodeTabCodeId, objFieldTab4CodeConvCond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.UpdDate) == true)
{
string strComparisonOpUpdDate = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.UpdDate, objFieldTab4CodeConvCond.UpdDate, strComparisonOpUpdDate);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.UpdUser) == true)
{
string strComparisonOpUpdUser = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.UpdUser, objFieldTab4CodeConvCond.UpdUser, strComparisonOpUpdUser);
}
if (objFieldTab4CodeConvCond.IsUpdated(conFieldTab4CodeConv.Memo) == true)
{
string strComparisonOpMemo = objFieldTab4CodeConvCond.dicFldComparisonOp[conFieldTab4CodeConv.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4CodeConv.Memo, objFieldTab4CodeConvCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 if (string.IsNullOrEmpty(objFieldTab4CodeConvEN.FldId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFieldTab4CodeConvEN.sfUpdFldSetStr = objFieldTab4CodeConvEN.getsfUpdFldSetStr();
clsFieldTab4CodeConvWApi.CheckPropertyNew(objFieldTab4CodeConvEN); 
bool bolResult = clsFieldTab4CodeConvWApi.UpdateRecord(objFieldTab4CodeConvEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
 if (string.IsNullOrEmpty(objFieldTab4CodeConvEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFieldTab4CodeConvWApi.IsExist(objFieldTab4CodeConvEN.FldId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objFieldTab4CodeConvEN.FldId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFieldTab4CodeConvWApi.CheckPropertyNew(objFieldTab4CodeConvEN); 
bool bolResult = clsFieldTab4CodeConvWApi.AddNewRecord(objFieldTab4CodeConvEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
 /// <param name = "objFieldTab4CodeConvEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
try
{
clsFieldTab4CodeConvWApi.CheckPropertyNew(objFieldTab4CodeConvEN); 
string strFldId = clsFieldTab4CodeConvWApi.AddNewRecordWithMaxId(objFieldTab4CodeConvEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
return strFldId;
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
 /// <param name = "objFieldTab4CodeConvEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strWhereCond)
{
try
{
clsFieldTab4CodeConvWApi.CheckPropertyNew(objFieldTab4CodeConvEN); 
bool bolResult = clsFieldTab4CodeConvWApi.UpdateWithCondition(objFieldTab4CodeConvEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
 /// 字段4代码转换(FieldTab4CodeConv)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFieldTab4CodeConvWApi
{
private static readonly string mstrApiControllerName = "FieldTab4CodeConvApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFieldTab4CodeConvWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
if (!Object.Equals(null, objFieldTab4CodeConvEN.FldId) && GetStrLen(objFieldTab4CodeConvEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.PrjId) && GetStrLen(objFieldTab4CodeConvEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.CodeTabId) && GetStrLen(objFieldTab4CodeConvEN.CodeTabId) > 8)
{
 throw new Exception("字段[代码表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.CodeTabNameId) && GetStrLen(objFieldTab4CodeConvEN.CodeTabNameId) > 8)
{
 throw new Exception("字段[代码_名Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.CodeTabCodeId) && GetStrLen(objFieldTab4CodeConvEN.CodeTabCodeId) > 8)
{
 throw new Exception("字段[代码Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.UpdDate) && GetStrLen(objFieldTab4CodeConvEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.UpdUser) && GetStrLen(objFieldTab4CodeConvEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTab4CodeConvEN.Memo) && GetStrLen(objFieldTab4CodeConvEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFieldTab4CodeConvEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTab4CodeConvEN GetObjByFldId(string strFldId)
{
if (strFldId == "") return null;
string strAction = "GetObjByFldId";
clsFieldTab4CodeConvEN objFieldTab4CodeConvEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFieldTab4CodeConvEN = JsonConvert.DeserializeObject<clsFieldTab4CodeConvEN>(strJson);
return objFieldTab4CodeConvEN;
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
public static clsFieldTab4CodeConvEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFieldTab4CodeConvEN objFieldTab4CodeConvEN;
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
objFieldTab4CodeConvEN = JsonConvert.DeserializeObject<clsFieldTab4CodeConvEN>(strJson);
return objFieldTab4CodeConvEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTab4CodeConvEN GetObjByFldIdCache(string strFldId,string strPrjId)
{
if (string.IsNullOrEmpty(strFldId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLst_Sel =
from objFieldTab4CodeConvEN in arrFieldTab4CodeConvObjLstCache
where objFieldTab4CodeConvEN.FldId == strFldId 
select objFieldTab4CodeConvEN;
if (arrFieldTab4CodeConvObjLst_Sel.Count() == 0)
{
   clsFieldTab4CodeConvEN obj = clsFieldTab4CodeConvWApi.GetObjByFldId(strFldId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFieldTab4CodeConvObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4CodeConvEN> GetObjLst(string strWhereCond)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
 /// <param name = "arrFldId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4CodeConvEN> GetObjLstByFldIdLst(List<string> arrFldId)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
string strAction = "GetObjLstByFldIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
 /// <param name = "arrFldId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFieldTab4CodeConvEN> GetObjLstByFldIdLstCache(List<string> arrFldId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLst_Sel =
from objFieldTab4CodeConvEN in arrFieldTab4CodeConvObjLstCache
where arrFldId.Contains(objFieldTab4CodeConvEN.FldId)
select objFieldTab4CodeConvEN;
return arrFieldTab4CodeConvObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4CodeConvEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
public static List<clsFieldTab4CodeConvEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
public static List<clsFieldTab4CodeConvEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
public static List<clsFieldTab4CodeConvEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFieldTab4CodeConvEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4CodeConvEN>>(strJson);
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
public static int DelRecord(string strFldId)
{
string strAction = "DelRecord";
try
{
 clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = clsFieldTab4CodeConvWApi.GetObjByFldId(strFldId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFldId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
public static int DelFieldTab4CodeConvs(List<string> arrFldId)
{
string strAction = "DelFieldTab4CodeConvs";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFldId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFieldTab4CodeConvEN objFieldTab4CodeConvEN = clsFieldTab4CodeConvWApi.GetObjByFldId(arrFldId[0]);
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
public static int DelFieldTab4CodeConvsByCond(string strWhereCond)
{
string strAction = "DelFieldTab4CodeConvsByCond";
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
public static bool AddNewRecord(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4CodeConvEN>(objFieldTab4CodeConvEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4CodeConvEN>(objFieldTab4CodeConvEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4CodeConvWApi.ReFreshCache(objFieldTab4CodeConvEN.PrjId);
var strFldId = (string)jobjReturn0["returnStr"];
return strFldId;
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
public static bool UpdateRecord(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN)
{
if (string.IsNullOrEmpty(objFieldTab4CodeConvEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4CodeConvEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4CodeConvEN>(objFieldTab4CodeConvEN);
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
 /// <param name = "objFieldTab4CodeConvEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFieldTab4CodeConvEN objFieldTab4CodeConvEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFieldTab4CodeConvEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4CodeConvEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4CodeConvEN.FldId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4CodeConvEN>(objFieldTab4CodeConvEN);
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
public static bool IsExist(string strFldId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldId"] = strFldId
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
 /// <param name = "objFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objFieldTab4CodeConvENT">目标对象</param>
 public static void CopyTo(clsFieldTab4CodeConvEN objFieldTab4CodeConvENS, clsFieldTab4CodeConvEN objFieldTab4CodeConvENT)
{
try
{
objFieldTab4CodeConvENT.FldId = objFieldTab4CodeConvENS.FldId; //字段Id
objFieldTab4CodeConvENT.PrjId = objFieldTab4CodeConvENS.PrjId; //工程Id
objFieldTab4CodeConvENT.CodeTabId = objFieldTab4CodeConvENS.CodeTabId; //代码表Id
objFieldTab4CodeConvENT.CodeTabNameId = objFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objFieldTab4CodeConvENT.CodeTabCodeId = objFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objFieldTab4CodeConvENT.UpdDate = objFieldTab4CodeConvENS.UpdDate; //修改日期
objFieldTab4CodeConvENT.UpdUser = objFieldTab4CodeConvENS.UpdUser; //修改者
objFieldTab4CodeConvENT.Memo = objFieldTab4CodeConvENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFieldTab4CodeConvEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFieldTab4CodeConvEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFieldTab4CodeConvEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFieldTab4CodeConvEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFieldTab4CodeConvEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFieldTab4CodeConvEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTab4CodeConvWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTab4CodeConvWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
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
if (clsFieldTab4CodeConvWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTab4CodeConvWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4CodeConvEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTab4CodeConvWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTab4CodeConvWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFieldTab4CodeConvEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFieldTab4CodeConvEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFieldTab4CodeConv.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFieldTab4CodeConvObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4CodeConvEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsFieldTab4CodeConvEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsFieldTab4CodeConvWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsFieldTab4CodeConvWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsFieldTab4CodeConvEN> arrFieldTab4CodeConvObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFieldTab4CodeConvObjLstCache = CacheHelper.Get<List<clsFieldTab4CodeConvEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFieldTab4CodeConvObjLstCache = CacheHelper.Get<List<clsFieldTab4CodeConvEN>>(strKey);
}
return arrFieldTab4CodeConvObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFieldTab4CodeConvEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFieldTab4CodeConv.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.CodeTabId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.CodeTabNameId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.CodeTabCodeId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4CodeConv.Memo, Type.GetType("System.String"));
foreach (clsFieldTab4CodeConvEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFieldTab4CodeConv.FldId] = objInFor[conFieldTab4CodeConv.FldId];
objDR[conFieldTab4CodeConv.PrjId] = objInFor[conFieldTab4CodeConv.PrjId];
objDR[conFieldTab4CodeConv.CodeTabId] = objInFor[conFieldTab4CodeConv.CodeTabId];
objDR[conFieldTab4CodeConv.CodeTabNameId] = objInFor[conFieldTab4CodeConv.CodeTabNameId];
objDR[conFieldTab4CodeConv.CodeTabCodeId] = objInFor[conFieldTab4CodeConv.CodeTabCodeId];
objDR[conFieldTab4CodeConv.UpdDate] = objInFor[conFieldTab4CodeConv.UpdDate];
objDR[conFieldTab4CodeConv.UpdUser] = objInFor[conFieldTab4CodeConv.UpdUser];
objDR[conFieldTab4CodeConv.Memo] = objInFor[conFieldTab4CodeConv.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 字段4代码转换(FieldTab4CodeConv)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FieldTab4CodeConv : clsCommFun4BLV2
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
clsFieldTab4CodeConvWApi.ReFreshThisCache(strPrjId);
}
}

}