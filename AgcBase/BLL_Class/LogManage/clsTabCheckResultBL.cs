
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckResultBL
 表名:TabCheckResult(00050188)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsTabCheckResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckResultEN GetObj(this K_mId_TabCheckResult myKey)
{
clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultBL.TabCheckResultDA.GetObjBymId(myKey.Value);
return objTabCheckResultEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabCheckResultEN objTabCheckResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckResultEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}],字段Id = [{3}],错误信息 = [{4}]的数据已经存在!(in clsTabCheckResultBL.AddNewRecord)", objTabCheckResultEN.PrjId,objTabCheckResultEN.PrjDataBaseId,objTabCheckResultEN.TabId,objTabCheckResultEN.FldId,objTabCheckResultEN.ErrorMsg);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsTabCheckResultBL.TabCheckResultDA.AddNewRecordBySQL2(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsTabCheckResultEN objTabCheckResultEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objTabCheckResultEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objTabCheckResultEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],项目数据库Id(PrjDataBaseId)=[{1}],表ID(TabId)=[{2}],字段Id(FldId)=[{3}],错误信息(ErrorMsg)=[{4}])已经存在,不能重复!", objTabCheckResultEN.PrjId, objTabCheckResultEN.PrjDataBaseId, objTabCheckResultEN.TabId, objTabCheckResultEN.FldId, objTabCheckResultEN.ErrorMsg);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objTabCheckResultEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTabCheckResultEN objTabCheckResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objTabCheckResultEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}],字段Id = [{3}],错误信息 = [{4}]的数据已经存在!(in clsTabCheckResultBL.AddNewRecordWithReturnKey)", objTabCheckResultEN.PrjId,objTabCheckResultEN.PrjDataBaseId,objTabCheckResultEN.TabId,objTabCheckResultEN.FldId,objTabCheckResultEN.ErrorMsg);
throw new Exception(strMsg);
}
try
{
string strKey = clsTabCheckResultBL.TabCheckResultDA.AddNewRecordBySQL2WithReturnKey(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetmId(this clsTabCheckResultEN objTabCheckResultEN, long lngmId, string strComparisonOp="")
	{
objTabCheckResultEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.mId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.mId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.mId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetPrjId(this clsTabCheckResultEN objTabCheckResultEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabCheckResult.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabCheckResult.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabCheckResult.PrjId);
}
objTabCheckResultEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.PrjId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.PrjId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.PrjId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetPrjDataBaseId(this clsTabCheckResultEN objTabCheckResultEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, conTabCheckResult.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, conTabCheckResult.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, conTabCheckResult.PrjDataBaseId);
}
objTabCheckResultEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.PrjDataBaseId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.PrjDataBaseId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.PrjDataBaseId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetTabId(this clsTabCheckResultEN objTabCheckResultEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conTabCheckResult.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conTabCheckResult.TabId);
}
objTabCheckResultEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.TabId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.TabId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.TabId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetFldId(this clsTabCheckResultEN objTabCheckResultEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conTabCheckResult.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conTabCheckResult.FldId);
}
objTabCheckResultEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.FldId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.FldId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.FldId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetErrorLevelId(this clsTabCheckResultEN objTabCheckResultEN, int intErrorLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intErrorLevelId, conTabCheckResult.ErrorLevelId);
objTabCheckResultEN.ErrorLevelId = intErrorLevelId; //错误等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.ErrorLevelId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.ErrorLevelId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.ErrorLevelId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetErrorMsg(this clsTabCheckResultEN objTabCheckResultEN, string strErrorMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrorMsg, conTabCheckResult.ErrorMsg);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMsg, 5000, conTabCheckResult.ErrorMsg);
}
objTabCheckResultEN.ErrorMsg = strErrorMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.ErrorMsg) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.ErrorMsg, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.ErrorMsg] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetTabCheckErrorTypeId(this clsTabCheckResultEN objTabCheckResultEN, string strTabCheckErrorTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCheckErrorTypeId, conTabCheckResult.TabCheckErrorTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCheckErrorTypeId, 2, conTabCheckResult.TabCheckErrorTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabCheckErrorTypeId, 2, conTabCheckResult.TabCheckErrorTypeId);
}
objTabCheckResultEN.TabCheckErrorTypeId = strTabCheckErrorTypeId; //表检查错误类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.TabCheckErrorTypeId) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.TabCheckErrorTypeId, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.TabCheckErrorTypeId] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetCheckDate(this clsTabCheckResultEN objTabCheckResultEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckDate, conTabCheckResult.CheckDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conTabCheckResult.CheckDate);
}
objTabCheckResultEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.CheckDate) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.CheckDate, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.CheckDate] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetCheckUser(this clsTabCheckResultEN objTabCheckResultEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCheckUser, conTabCheckResult.CheckUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckUser, 20, conTabCheckResult.CheckUser);
}
objTabCheckResultEN.CheckUser = strCheckUser; //检查人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.CheckUser) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.CheckUser, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.CheckUser] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabCheckResultEN SetMemo(this clsTabCheckResultEN objTabCheckResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabCheckResult.Memo);
}
objTabCheckResultEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabCheckResultEN.dicFldComparisonOp.ContainsKey(conTabCheckResult.Memo) == false)
{
objTabCheckResultEN.dicFldComparisonOp.Add(conTabCheckResult.Memo, strComparisonOp);
}
else
{
objTabCheckResultEN.dicFldComparisonOp[conTabCheckResult.Memo] = strComparisonOp;
}
}
return objTabCheckResultEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTabCheckResultEN objTabCheckResultEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabCheckResultEN.CheckPropertyNew();
clsTabCheckResultEN objTabCheckResultCond = new clsTabCheckResultEN();
string strCondition = objTabCheckResultCond
.SetmId(objTabCheckResultEN.mId, "<>")
.SetPrjId(objTabCheckResultEN.PrjId, "=")
.SetPrjDataBaseId(objTabCheckResultEN.PrjDataBaseId, "=")
.SetTabId(objTabCheckResultEN.TabId, "=")
.SetFldId(objTabCheckResultEN.FldId, "=")
.SetErrorMsg(objTabCheckResultEN.ErrorMsg, "=")
.GetCombineCondition();
objTabCheckResultEN._IsCheckProperty = true;
bool bolIsExist = clsTabCheckResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_PrjDataBaseId_TabId_FldId_ErrorMsg)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabCheckResultEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objTabCheckResult">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsTabCheckResultEN objTabCheckResult)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabCheckResultEN objTabCheckResultCond = new clsTabCheckResultEN();
string strCondition = objTabCheckResultCond
.SetPrjId(objTabCheckResult.PrjId, "=")
.SetPrjDataBaseId(objTabCheckResult.PrjDataBaseId, "=")
.SetTabId(objTabCheckResult.TabId, "=")
.SetFldId(objTabCheckResult.FldId, "=")
.SetErrorMsg(objTabCheckResult.ErrorMsg, "=")
.GetCombineCondition();
objTabCheckResult._IsCheckProperty = true;
bool bolIsExist = clsTabCheckResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabCheckResult.mId = clsTabCheckResultBL.GetFirstID_S(strCondition);
objTabCheckResult.UpdateWithCondition(strCondition);
}
else
{
objTabCheckResult.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckResultEN objTabCheckResultEN)
{
 if (objTabCheckResultEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckResultBL.TabCheckResultDA.UpdateBySql2(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabCheckResultEN objTabCheckResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabCheckResultEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTabCheckResultBL.TabCheckResultDA.UpdateBySql2(objTabCheckResultEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckResultEN objTabCheckResultEN, string strWhereCond)
{
try
{
bool bolResult = clsTabCheckResultBL.TabCheckResultDA.UpdateBySqlWithCondition(objTabCheckResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabCheckResultEN objTabCheckResultEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTabCheckResultBL.TabCheckResultDA.UpdateBySqlWithConditionTransaction(objTabCheckResultEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTabCheckResultEN objTabCheckResultEN)
{
try
{
int intRecNum = clsTabCheckResultBL.TabCheckResultDA.DelRecord(objTabCheckResultEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objTabCheckResultENS">源对象</param>
 /// <param name = "objTabCheckResultENT">目标对象</param>
 public static void CopyTo(this clsTabCheckResultEN objTabCheckResultENS, clsTabCheckResultEN objTabCheckResultENT)
{
try
{
objTabCheckResultENT.mId = objTabCheckResultENS.mId; //mId
objTabCheckResultENT.PrjId = objTabCheckResultENS.PrjId; //工程Id
objTabCheckResultENT.PrjDataBaseId = objTabCheckResultENS.PrjDataBaseId; //项目数据库Id
objTabCheckResultENT.TabId = objTabCheckResultENS.TabId; //表ID
objTabCheckResultENT.FldId = objTabCheckResultENS.FldId; //字段Id
objTabCheckResultENT.ErrorLevelId = objTabCheckResultENS.ErrorLevelId; //错误等级Id
objTabCheckResultENT.ErrorMsg = objTabCheckResultENS.ErrorMsg; //错误信息
objTabCheckResultENT.TabCheckErrorTypeId = objTabCheckResultENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckResultENT.CheckDate = objTabCheckResultENS.CheckDate; //检查日期
objTabCheckResultENT.CheckUser = objTabCheckResultENS.CheckUser; //检查人
objTabCheckResultENT.Memo = objTabCheckResultENS.Memo; //说明
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objTabCheckResultENS">源对象</param>
 /// <returns>目标对象=>clsTabCheckResultEN:objTabCheckResultENT</returns>
 public static clsTabCheckResultEN CopyTo(this clsTabCheckResultEN objTabCheckResultENS)
{
try
{
 clsTabCheckResultEN objTabCheckResultENT = new clsTabCheckResultEN()
{
mId = objTabCheckResultENS.mId, //mId
PrjId = objTabCheckResultENS.PrjId, //工程Id
PrjDataBaseId = objTabCheckResultENS.PrjDataBaseId, //项目数据库Id
TabId = objTabCheckResultENS.TabId, //表ID
FldId = objTabCheckResultENS.FldId, //字段Id
ErrorLevelId = objTabCheckResultENS.ErrorLevelId, //错误等级Id
ErrorMsg = objTabCheckResultENS.ErrorMsg, //错误信息
TabCheckErrorTypeId = objTabCheckResultENS.TabCheckErrorTypeId, //表检查错误类型Id
CheckDate = objTabCheckResultENS.CheckDate, //检查日期
CheckUser = objTabCheckResultENS.CheckUser, //检查人
Memo = objTabCheckResultENS.Memo, //说明
};
 return objTabCheckResultENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsTabCheckResultEN objTabCheckResultEN)
{
 clsTabCheckResultBL.TabCheckResultDA.CheckPropertyNew(objTabCheckResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTabCheckResultEN objTabCheckResultEN)
{
 clsTabCheckResultBL.TabCheckResultDA.CheckProperty4Condition(objTabCheckResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabCheckResultEN objTabCheckResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.mId) == true)
{
string strComparisonOpmId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckResult.mId, objTabCheckResultCond.mId, strComparisonOpmId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.PrjId) == true)
{
string strComparisonOpPrjId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.PrjId, objTabCheckResultCond.PrjId, strComparisonOpPrjId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.PrjDataBaseId, objTabCheckResultCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.TabId) == true)
{
string strComparisonOpTabId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.TabId, objTabCheckResultCond.TabId, strComparisonOpTabId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.FldId) == true)
{
string strComparisonOpFldId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.FldId, objTabCheckResultCond.FldId, strComparisonOpFldId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.ErrorLevelId) == true)
{
string strComparisonOpErrorLevelId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.ErrorLevelId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabCheckResult.ErrorLevelId, objTabCheckResultCond.ErrorLevelId, strComparisonOpErrorLevelId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.ErrorMsg) == true)
{
string strComparisonOpErrorMsg = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.ErrorMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.ErrorMsg, objTabCheckResultCond.ErrorMsg, strComparisonOpErrorMsg);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.TabCheckErrorTypeId) == true)
{
string strComparisonOpTabCheckErrorTypeId = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.TabCheckErrorTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.TabCheckErrorTypeId, objTabCheckResultCond.TabCheckErrorTypeId, strComparisonOpTabCheckErrorTypeId);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.CheckDate) == true)
{
string strComparisonOpCheckDate = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.CheckDate, objTabCheckResultCond.CheckDate, strComparisonOpCheckDate);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.CheckUser) == true)
{
string strComparisonOpCheckUser = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.CheckUser, objTabCheckResultCond.CheckUser, strComparisonOpCheckUser);
}
if (objTabCheckResultCond.IsUpdated(conTabCheckResult.Memo) == true)
{
string strComparisonOpMemo = objTabCheckResultCond.dicFldComparisonOp[conTabCheckResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabCheckResult.Memo, objTabCheckResultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--TabCheckResult(表检查结果), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId_FldId_ErrorMsg
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objTabCheckResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsTabCheckResultEN objTabCheckResultEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckResultEN == null) return true;
if (objTabCheckResultEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 if (objTabCheckResultEN.TabId == null)
{
 sbCondition.AppendFormat(" and TabId is null", objTabCheckResultEN.TabId);
}
else
{
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
}
 if (objTabCheckResultEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objTabCheckResultEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
}
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
if (clsTabCheckResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckResultEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
if (clsTabCheckResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--TabCheckResult(表检查结果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId_FldId_ErrorMsg
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabCheckResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsTabCheckResultEN objTabCheckResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabCheckResultEN == null) return "";
if (objTabCheckResultEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 if (objTabCheckResultEN.TabId == null)
{
 sbCondition.AppendFormat(" and TabId is null", objTabCheckResultEN.TabId);
}
else
{
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
}
 if (objTabCheckResultEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objTabCheckResultEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
}
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabCheckResultEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckResultEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckResultEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckResultEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabCheckResultEN.FldId);
 sbCondition.AppendFormat(" and ErrorMsg = '{0}'", objTabCheckResultEN.ErrorMsg);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TabCheckResult
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 表检查结果(TabCheckResult)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTabCheckResultBL
{
public static RelatedActions_TabCheckResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTabCheckResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTabCheckResultDA TabCheckResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTabCheckResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsTabCheckResultBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsTabCheckResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabCheckResultEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_TabCheckResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable_TabCheckResult(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = TabCheckResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTabCheckResultEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrTabCheckResultObjLst_Sel =
arrTabCheckResultObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTabCheckResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLst(string strWhereCond)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTabCheckResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTabCheckResultEN> GetSubObjLstCache(clsTabCheckResultEN objTabCheckResultCond)
{
List<clsTabCheckResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckResult._AttributeName)
{
if (objTabCheckResultCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckResultCond[strFldName].ToString());
}
else
{
if (objTabCheckResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckResultCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsTabCheckResultEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTabCheckResultEN> arrObjLst = new List<clsTabCheckResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckResultEN objTabCheckResultEN = new clsTabCheckResultEN();
try
{
objTabCheckResultEN.mId = Int32.Parse(objRow[conTabCheckResult.mId].ToString().Trim()); //mId
objTabCheckResultEN.PrjId = objRow[conTabCheckResult.PrjId].ToString().Trim(); //工程Id
objTabCheckResultEN.PrjDataBaseId = objRow[conTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckResultEN.TabId = objRow[conTabCheckResult.TabId] == DBNull.Value ? null : objRow[conTabCheckResult.TabId].ToString().Trim(); //表ID
objTabCheckResultEN.FldId = objRow[conTabCheckResult.FldId] == DBNull.Value ? null : objRow[conTabCheckResult.FldId].ToString().Trim(); //字段Id
objTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckResultEN.ErrorMsg = objRow[conTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckResultEN.TabCheckErrorTypeId = objRow[conTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckResultEN.CheckDate = objRow[conTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objTabCheckResultEN.CheckUser = objRow[conTabCheckResult.CheckUser].ToString().Trim(); //检查人
objTabCheckResultEN.Memo = objRow[conTabCheckResult.Memo] == DBNull.Value ? null : objRow[conTabCheckResult.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTabCheckResultEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTabCheckResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTabCheckResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTabCheckResult(ref clsTabCheckResultEN objTabCheckResultEN)
{
bool bolResult = TabCheckResultDA.GetTabCheckResult(ref objTabCheckResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabCheckResultEN GetObjBymId(long lngmId)
{
clsTabCheckResultEN objTabCheckResultEN = TabCheckResultDA.GetObjBymId(lngmId);
return objTabCheckResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTabCheckResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTabCheckResultEN objTabCheckResultEN = TabCheckResultDA.GetFirstObj(strWhereCond);
 return objTabCheckResultEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsTabCheckResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTabCheckResultEN objTabCheckResultEN = TabCheckResultDA.GetObjByDataRow(objRow);
 return objTabCheckResultEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsTabCheckResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTabCheckResultEN objTabCheckResultEN = TabCheckResultDA.GetObjByDataRow(objRow);
 return objTabCheckResultEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstTabCheckResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckResultEN GetObjBymIdFromList(long lngmId, List<clsTabCheckResultEN> lstTabCheckResultObjLst)
{
foreach (clsTabCheckResultEN objTabCheckResultEN in lstTabCheckResultObjLst)
{
if (objTabCheckResultEN.mId == lngmId)
{
return objTabCheckResultEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsTabCheckResultDA().GetFirstID(strWhereCond);
 return lngmId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = TabCheckResultDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = TabCheckResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = TabCheckResultDA.IsExist(lngmId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsTabCheckResultDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = TabCheckResultDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTabCheckResultEN objTabCheckResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}],字段Id = [{3}],错误信息 = [{4}]的数据已经存在!(in clsTabCheckResultBL.AddNewRecordBySql2)", objTabCheckResultEN.PrjId,objTabCheckResultEN.PrjDataBaseId,objTabCheckResultEN.TabId,objTabCheckResultEN.FldId,objTabCheckResultEN.ErrorMsg);
throw new Exception(strMsg);
}
try
{
bool bolResult = TabCheckResultDA.AddNewRecordBySQL2(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTabCheckResultEN objTabCheckResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objTabCheckResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],项目数据库Id = [{1}],表ID = [{2}],字段Id = [{3}],错误信息 = [{4}]的数据已经存在!(in clsTabCheckResultBL.AddNewRecordBySql2WithReturnKey)", objTabCheckResultEN.PrjId,objTabCheckResultEN.PrjDataBaseId,objTabCheckResultEN.TabId,objTabCheckResultEN.FldId,objTabCheckResultEN.ErrorMsg);
throw new Exception(strMsg);
}
try
{
string strKey = TabCheckResultDA.AddNewRecordBySQL2WithReturnKey(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTabCheckResultEN objTabCheckResultEN)
{
try
{
bool bolResult = TabCheckResultDA.Update(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objTabCheckResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTabCheckResultEN objTabCheckResultEN)
{
 if (objTabCheckResultEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TabCheckResultDA.UpdateBySql2(objTabCheckResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabCheckResultBL.ReFreshCache();

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsTabCheckResultEN objTabCheckResultEN = clsTabCheckResultBL.GetObjBymId(lngmId);

if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(objTabCheckResultEN.mId, "SetUpdDate");
}
if (objTabCheckResultEN != null)
{
int intRecNum = TabCheckResultDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckResultDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[TabCheckResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabCheckResult.mId,
//lngmId);
//        clsTabCheckResultBL.DelTabCheckResultsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckResultBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckResultBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTabCheckResultBL.relatedActions != null)
{
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TabCheckResultDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTabCheckResults(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTabCheckResultBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = TabCheckResultDA.DelTabCheckResult(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelTabCheckResultsByCond(string strWhereCond)
{
try
{
if (clsTabCheckResultBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTabCheckResultBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = TabCheckResultDA.DelTabCheckResult(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TabCheckResult]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTabCheckResultDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[TabCheckResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabCheckResultBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabCheckResultBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objTabCheckResultENS">源对象</param>
 /// <param name = "objTabCheckResultENT">目标对象</param>
 public static void CopyTo(clsTabCheckResultEN objTabCheckResultENS, clsTabCheckResultEN objTabCheckResultENT)
{
try
{
objTabCheckResultENT.mId = objTabCheckResultENS.mId; //mId
objTabCheckResultENT.PrjId = objTabCheckResultENS.PrjId; //工程Id
objTabCheckResultENT.PrjDataBaseId = objTabCheckResultENS.PrjDataBaseId; //项目数据库Id
objTabCheckResultENT.TabId = objTabCheckResultENS.TabId; //表ID
objTabCheckResultENT.FldId = objTabCheckResultENS.FldId; //字段Id
objTabCheckResultENT.ErrorLevelId = objTabCheckResultENS.ErrorLevelId; //错误等级Id
objTabCheckResultENT.ErrorMsg = objTabCheckResultENS.ErrorMsg; //错误信息
objTabCheckResultENT.TabCheckErrorTypeId = objTabCheckResultENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckResultENT.CheckDate = objTabCheckResultENS.CheckDate; //检查日期
objTabCheckResultENT.CheckUser = objTabCheckResultENS.CheckUser; //检查人
objTabCheckResultENT.Memo = objTabCheckResultENS.Memo; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objTabCheckResultEN">源简化对象</param>
 public static void SetUpdFlag(clsTabCheckResultEN objTabCheckResultEN)
{
try
{
objTabCheckResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTabCheckResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTabCheckResult.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.mId = objTabCheckResultEN.mId; //mId
}
if (arrFldSet.Contains(conTabCheckResult.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.PrjId = objTabCheckResultEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conTabCheckResult.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.PrjDataBaseId = objTabCheckResultEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(conTabCheckResult.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.TabId = objTabCheckResultEN.TabId == "[null]" ? null :  objTabCheckResultEN.TabId; //表ID
}
if (arrFldSet.Contains(conTabCheckResult.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.FldId = objTabCheckResultEN.FldId == "[null]" ? null :  objTabCheckResultEN.FldId; //字段Id
}
if (arrFldSet.Contains(conTabCheckResult.ErrorLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.ErrorLevelId = objTabCheckResultEN.ErrorLevelId; //错误等级Id
}
if (arrFldSet.Contains(conTabCheckResult.ErrorMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.ErrorMsg = objTabCheckResultEN.ErrorMsg; //错误信息
}
if (arrFldSet.Contains(conTabCheckResult.TabCheckErrorTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.TabCheckErrorTypeId = objTabCheckResultEN.TabCheckErrorTypeId; //表检查错误类型Id
}
if (arrFldSet.Contains(conTabCheckResult.CheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.CheckDate = objTabCheckResultEN.CheckDate; //检查日期
}
if (arrFldSet.Contains(conTabCheckResult.CheckUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.CheckUser = objTabCheckResultEN.CheckUser; //检查人
}
if (arrFldSet.Contains(conTabCheckResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTabCheckResultEN.Memo = objTabCheckResultEN.Memo == "[null]" ? null :  objTabCheckResultEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objTabCheckResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsTabCheckResultEN objTabCheckResultEN)
{
try
{
if (objTabCheckResultEN.TabId == "[null]") objTabCheckResultEN.TabId = null; //表ID
if (objTabCheckResultEN.FldId == "[null]") objTabCheckResultEN.FldId = null; //字段Id
if (objTabCheckResultEN.Memo == "[null]") objTabCheckResultEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabCheckResultEN objTabCheckResultEN)
{
 TabCheckResultDA.CheckPropertyNew(objTabCheckResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTabCheckResultEN objTabCheckResultEN)
{
 TabCheckResultDA.CheckProperty4Condition(objTabCheckResultEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsTabCheckResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabCheckResultBL没有刷新缓存机制(clsTabCheckResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTabCheckResultObjLstCache == null)
//{
//arrTabCheckResultObjLstCache = TabCheckResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTabCheckResultEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrTabCheckResultObjLst_Sel =
arrTabCheckResultObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTabCheckResultObjLst_Sel.Count() == 0)
{
   clsTabCheckResultEN obj = clsTabCheckResultBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTabCheckResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckResultEN> GetAllTabCheckResultObjLstCache()
{
//获取缓存中的对象列表
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = GetObjLstCache(); 
return arrTabCheckResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabCheckResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
List<clsTabCheckResultEN> arrTabCheckResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTabCheckResultObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabCheckResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}
/// <summary>
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsTabCheckResultEN._RefreshTimeLst.Count == 0) return "";
return clsTabCheckResultEN._RefreshTimeLst[clsTabCheckResultEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsTabCheckResultBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTabCheckResultEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTabCheckResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTabCheckResultBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--TabCheckResult(表检查结果)
 /// 唯一性条件:PrjId_PrjDataBaseId_TabId_FldId_ErrorMsg
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabCheckResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsTabCheckResultEN objTabCheckResultEN)
{
//检测记录是否存在
string strResult = TabCheckResultDA.GetUniCondStr(objTabCheckResultEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conTabCheckResult.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTabCheckResult._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTabCheckResult._AttributeName));
throw new Exception(strMsg);
}
var objTabCheckResult = clsTabCheckResultBL.GetObjBymIdCache(lngmId);
if (objTabCheckResult == null) return "";
return objTabCheckResult[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsTabCheckResultDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsTabCheckResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTabCheckResultDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsTabCheckResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTabCheckResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTabCheckResultEN objTabCheckResultCond)
{
List<clsTabCheckResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTabCheckResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTabCheckResult._AttributeName)
{
if (objTabCheckResultCond.IsUpdated(strFldName) == false) continue;
if (objTabCheckResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckResultCond[strFldName].ToString());
}
else
{
if (objTabCheckResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTabCheckResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTabCheckResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTabCheckResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTabCheckResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTabCheckResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTabCheckResultCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsTabCheckResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = TabCheckResultDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = TabCheckResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = TabCheckResultDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsTabCheckResultDA.SetFldValue(clsTabCheckResultEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = TabCheckResultDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsTabCheckResultDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsTabCheckResultDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsTabCheckResultDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[TabCheckResult] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**项目数据库Id*/ 
 strCreateTabCode.Append(" PrjDataBaseId char(4) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**错误等级Id*/ 
 strCreateTabCode.Append(" ErrorLevelId int not Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrorMsg varchar(5000) not Null, "); 
 // /**表检查错误类型Id*/ 
 strCreateTabCode.Append(" TabCheckErrorTypeId char(2) not Null, "); 
 // /**检查日期*/ 
 strCreateTabCode.Append(" CheckDate varchar(20) not Null, "); 
 // /**检查人*/ 
 strCreateTabCode.Append(" CheckUser varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 表检查结果(TabCheckResult)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TabCheckResult : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsTabCheckResultBL.ReFreshThisCache();
}
}

}