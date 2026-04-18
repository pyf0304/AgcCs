
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskBL
 表名:CopyTask(00050643)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:20:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsCopyTaskBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngTaskId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskEN GetObj(this K_TaskId_CopyTask myKey)
{
clsCopyTaskEN objCopyTaskEN = clsCopyTaskBL.CopyTaskDA.GetObjByTaskId(myKey.Value);
return objCopyTaskEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCopyTaskEN objCopyTaskEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCopyTaskEN) == false)
{
var strMsg = string.Format("记录已经存在!SourceViewId = [{0}],TargetPrjId = [{1}],Status = [{2}]的数据已经存在!(in clsCopyTaskBL.AddNewRecord)", objCopyTaskEN.SourceViewId,objCopyTaskEN.TargetPrjId,objCopyTaskEN.Status);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCopyTaskBL.CopyTaskDA.AddNewRecordBySQL2(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCopyTaskEN objCopyTaskEN, bool bolIsNeedCheckUniqueness = true)
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
objCopyTaskEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCopyTaskEN.CheckUniqueness() == false)
{
strMsg = string.Format("(SourceViewId(SourceViewId)=[{0}],TargetPrjId(TargetPrjId)=[{1}],Status(Status)=[{2}])已经存在,不能重复!", objCopyTaskEN.SourceViewId, objCopyTaskEN.TargetPrjId, objCopyTaskEN.Status);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCopyTaskEN.AddNewRecord();
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCopyTaskEN objCopyTaskEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCopyTaskEN) == false)
{
var strMsg = string.Format("记录已经存在!SourceViewId = [{0}],TargetPrjId = [{1}],Status = [{2}]的数据已经存在!(in clsCopyTaskBL.AddNewRecordWithReturnKey)", objCopyTaskEN.SourceViewId,objCopyTaskEN.TargetPrjId,objCopyTaskEN.Status);
throw new Exception(strMsg);
}
try
{
string strKey = clsCopyTaskBL.CopyTaskDA.AddNewRecordBySQL2WithReturnKey(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTaskId(this clsCopyTaskEN objCopyTaskEN, long lngTaskId, string strComparisonOp="")
	{
objCopyTaskEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TaskId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TaskId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TaskId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetSourcePrjId(this clsCopyTaskEN objCopyTaskEN, string strSourcePrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourcePrjId, conCopyTask.SourcePrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourcePrjId, 4, conCopyTask.SourcePrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourcePrjId, 4, conCopyTask.SourcePrjId);
}
objCopyTaskEN.SourcePrjId = strSourcePrjId; //SourcePrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.SourcePrjId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.SourcePrjId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.SourcePrjId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetPrjId(this clsCopyTaskEN objCopyTaskEN, string strTargetPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTargetPrjId, conCopyTask.TargetPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetPrjId, 4, conCopyTask.TargetPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTargetPrjId, 4, conCopyTask.TargetPrjId);
}
objCopyTaskEN.TargetPrjId = strTargetPrjId; //TargetPrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetPrjId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetPrjId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetPrjId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetSourceViewId(this clsCopyTaskEN objCopyTaskEN, string strSourceViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceViewId, conCopyTask.SourceViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceViewId, 8, conCopyTask.SourceViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceViewId, 8, conCopyTask.SourceViewId);
}
objCopyTaskEN.SourceViewId = strSourceViewId; //SourceViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.SourceViewId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.SourceViewId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.SourceViewId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetViewId(this clsCopyTaskEN objCopyTaskEN, string strTargetViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetViewId, 8, conCopyTask.TargetViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTargetViewId, 8, conCopyTask.TargetViewId);
}
objCopyTaskEN.TargetViewId = strTargetViewId; //TargetViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetViewId) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetViewId, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetViewId] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetConflictStrategy(this clsCopyTaskEN objCopyTaskEN, string strConflictStrategy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConflictStrategy, conCopyTask.ConflictStrategy);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConflictStrategy, 20, conCopyTask.ConflictStrategy);
}
objCopyTaskEN.ConflictStrategy = strConflictStrategy; //ConflictStrategy
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.ConflictStrategy) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.ConflictStrategy, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.ConflictStrategy] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetStatus(this clsCopyTaskEN objCopyTaskEN, string strStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatus, conCopyTask.Status);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatus, 20, conCopyTask.Status);
}
objCopyTaskEN.Status = strStatus; //Status
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.Status) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.Status, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.Status] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCurrentStep(this clsCopyTaskEN objCopyTaskEN, string strCurrentStep, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCurrentStep, conCopyTask.CurrentStep);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCurrentStep, 30, conCopyTask.CurrentStep);
}
objCopyTaskEN.CurrentStep = strCurrentStep; //CurrentStep
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CurrentStep) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CurrentStep, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CurrentStep] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetErrorMessage(this clsCopyTaskEN objCopyTaskEN, string strErrorMessage, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMessage, 50, conCopyTask.ErrorMessage);
}
objCopyTaskEN.ErrorMessage = strErrorMessage; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.ErrorMessage) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.ErrorMessage, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.ErrorMessage] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCreatedBy(this clsCopyTaskEN objCopyTaskEN, string strCreatedBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreatedBy, conCopyTask.CreatedBy);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreatedBy, 50, conCopyTask.CreatedBy);
}
objCopyTaskEN.CreatedBy = strCreatedBy; //CreatedBy
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CreatedBy) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CreatedBy, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CreatedBy] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetCreatedTime(this clsCopyTaskEN objCopyTaskEN, DateTime dteCreatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteCreatedTime, conCopyTask.CreatedTime);
objCopyTaskEN.CreatedTime = dteCreatedTime; //CreatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.CreatedTime) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.CreatedTime, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.CreatedTime] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetUpdatedTime(this clsCopyTaskEN objCopyTaskEN, DateTime dteUpdatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteUpdatedTime, conCopyTask.UpdatedTime);
objCopyTaskEN.UpdatedTime = dteUpdatedTime; //UpdatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.UpdatedTime) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.UpdatedTime, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.UpdatedTime] = strComparisonOp;
}
}
return objCopyTaskEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskEN SetTargetViewName(this clsCopyTaskEN objCopyTaskEN, string strTargetViewName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetViewName, 50, conCopyTask.TargetViewName);
}
objCopyTaskEN.TargetViewName = strTargetViewName; //TargetViewName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskEN.dicFldComparisonOp.ContainsKey(conCopyTask.TargetViewName) == false)
{
objCopyTaskEN.dicFldComparisonOp.Add(conCopyTask.TargetViewName, strComparisonOp);
}
else
{
objCopyTaskEN.dicFldComparisonOp[conCopyTask.TargetViewName] = strComparisonOp;
}
}
return objCopyTaskEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCopyTaskEN objCopyTaskEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCopyTaskEN.CheckPropertyNew();
clsCopyTaskEN objCopyTaskCond = new clsCopyTaskEN();
string strCondition = objCopyTaskCond
.SetTaskId(objCopyTaskEN.TaskId, "<>")
.SetSourceViewId(objCopyTaskEN.SourceViewId, "=")
.SetTargetPrjId(objCopyTaskEN.TargetPrjId, "=")
.SetStatus(objCopyTaskEN.Status, "=")
.GetCombineCondition();
objCopyTaskEN._IsCheckProperty = true;
bool bolIsExist = clsCopyTaskBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCopyTaskEN.Update();
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
 /// <param name = "objCopyTask">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCopyTaskEN objCopyTask)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCopyTaskEN objCopyTaskCond = new clsCopyTaskEN();
string strCondition = objCopyTaskCond
.SetSourceViewId(objCopyTask.SourceViewId, "=")
.SetTargetPrjId(objCopyTask.TargetPrjId, "=")
.SetStatus(objCopyTask.Status, "=")
.GetCombineCondition();
objCopyTask._IsCheckProperty = true;
bool bolIsExist = clsCopyTaskBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCopyTask.TaskId = clsCopyTaskBL.GetFirstID_S(strCondition);
objCopyTask.UpdateWithCondition(strCondition);
}
else
{
objCopyTask.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN.TaskId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCopyTaskBL.CopyTaskDA.UpdateBySql2(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskEN objCopyTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskEN.TaskId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCopyTaskBL.CopyTaskDA.UpdateBySql2(objCopyTaskEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskEN objCopyTaskEN, string strWhereCond)
{
try
{
bool bolResult = clsCopyTaskBL.CopyTaskDA.UpdateBySqlWithCondition(objCopyTaskEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskEN objCopyTaskEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCopyTaskBL.CopyTaskDA.UpdateBySqlWithConditionTransaction(objCopyTaskEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCopyTaskEN objCopyTaskEN)
{
try
{
int intRecNum = clsCopyTaskBL.CopyTaskDA.DelRecord(objCopyTaskEN.TaskId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskENS">源对象</param>
 /// <param name = "objCopyTaskENT">目标对象</param>
 public static void CopyTo(this clsCopyTaskEN objCopyTaskENS, clsCopyTaskEN objCopyTaskENT)
{
try
{
objCopyTaskENT.TaskId = objCopyTaskENS.TaskId; //TaskId
objCopyTaskENT.SourcePrjId = objCopyTaskENS.SourcePrjId; //SourcePrjId
objCopyTaskENT.TargetPrjId = objCopyTaskENS.TargetPrjId; //TargetPrjId
objCopyTaskENT.SourceViewId = objCopyTaskENS.SourceViewId; //SourceViewId
objCopyTaskENT.TargetViewId = objCopyTaskENS.TargetViewId; //TargetViewId
objCopyTaskENT.ConflictStrategy = objCopyTaskENS.ConflictStrategy; //ConflictStrategy
objCopyTaskENT.Status = objCopyTaskENS.Status; //Status
objCopyTaskENT.CurrentStep = objCopyTaskENS.CurrentStep; //CurrentStep
objCopyTaskENT.ErrorMessage = objCopyTaskENS.ErrorMessage; //错误信息
objCopyTaskENT.CreatedBy = objCopyTaskENS.CreatedBy; //CreatedBy
objCopyTaskENT.CreatedTime = objCopyTaskENS.CreatedTime; //CreatedTime
objCopyTaskENT.UpdatedTime = objCopyTaskENS.UpdatedTime; //UpdatedTime
objCopyTaskENT.TargetViewName = objCopyTaskENS.TargetViewName; //TargetViewName
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
 /// <param name = "objCopyTaskENS">源对象</param>
 /// <returns>目标对象=>clsCopyTaskEN:objCopyTaskENT</returns>
 public static clsCopyTaskEN CopyTo(this clsCopyTaskEN objCopyTaskENS)
{
try
{
 clsCopyTaskEN objCopyTaskENT = new clsCopyTaskEN()
{
TaskId = objCopyTaskENS.TaskId, //TaskId
SourcePrjId = objCopyTaskENS.SourcePrjId, //SourcePrjId
TargetPrjId = objCopyTaskENS.TargetPrjId, //TargetPrjId
SourceViewId = objCopyTaskENS.SourceViewId, //SourceViewId
TargetViewId = objCopyTaskENS.TargetViewId, //TargetViewId
ConflictStrategy = objCopyTaskENS.ConflictStrategy, //ConflictStrategy
Status = objCopyTaskENS.Status, //Status
CurrentStep = objCopyTaskENS.CurrentStep, //CurrentStep
ErrorMessage = objCopyTaskENS.ErrorMessage, //错误信息
CreatedBy = objCopyTaskENS.CreatedBy, //CreatedBy
CreatedTime = objCopyTaskENS.CreatedTime, //CreatedTime
UpdatedTime = objCopyTaskENS.UpdatedTime, //UpdatedTime
TargetViewName = objCopyTaskENS.TargetViewName, //TargetViewName
};
 return objCopyTaskENT;
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
public static void CheckPropertyNew(this clsCopyTaskEN objCopyTaskEN)
{
 clsCopyTaskBL.CopyTaskDA.CheckPropertyNew(objCopyTaskEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCopyTaskEN objCopyTaskEN)
{
 clsCopyTaskBL.CopyTaskDA.CheckProperty4Condition(objCopyTaskEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCopyTaskEN objCopyTaskCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCopyTaskCond.IsUpdated(conCopyTask.TaskId) == true)
{
string strComparisonOpTaskId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTask.TaskId, objCopyTaskCond.TaskId, strComparisonOpTaskId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.SourcePrjId) == true)
{
string strComparisonOpSourcePrjId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.SourcePrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.SourcePrjId, objCopyTaskCond.SourcePrjId, strComparisonOpSourcePrjId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetPrjId) == true)
{
string strComparisonOpTargetPrjId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetPrjId, objCopyTaskCond.TargetPrjId, strComparisonOpTargetPrjId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.SourceViewId) == true)
{
string strComparisonOpSourceViewId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.SourceViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.SourceViewId, objCopyTaskCond.SourceViewId, strComparisonOpSourceViewId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetViewId) == true)
{
string strComparisonOpTargetViewId = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetViewId, objCopyTaskCond.TargetViewId, strComparisonOpTargetViewId);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.ConflictStrategy) == true)
{
string strComparisonOpConflictStrategy = objCopyTaskCond.dicFldComparisonOp[conCopyTask.ConflictStrategy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.ConflictStrategy, objCopyTaskCond.ConflictStrategy, strComparisonOpConflictStrategy);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.Status) == true)
{
string strComparisonOpStatus = objCopyTaskCond.dicFldComparisonOp[conCopyTask.Status];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.Status, objCopyTaskCond.Status, strComparisonOpStatus);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CurrentStep) == true)
{
string strComparisonOpCurrentStep = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CurrentStep];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CurrentStep, objCopyTaskCond.CurrentStep, strComparisonOpCurrentStep);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.ErrorMessage) == true)
{
string strComparisonOpErrorMessage = objCopyTaskCond.dicFldComparisonOp[conCopyTask.ErrorMessage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.ErrorMessage, objCopyTaskCond.ErrorMessage, strComparisonOpErrorMessage);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CreatedBy) == true)
{
string strComparisonOpCreatedBy = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CreatedBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CreatedBy, objCopyTaskCond.CreatedBy, strComparisonOpCreatedBy);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.CreatedTime) == true)
{
string strComparisonOpCreatedTime = objCopyTaskCond.dicFldComparisonOp[conCopyTask.CreatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.CreatedTime, objCopyTaskCond.CreatedTime, strComparisonOpCreatedTime);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.UpdatedTime) == true)
{
string strComparisonOpUpdatedTime = objCopyTaskCond.dicFldComparisonOp[conCopyTask.UpdatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.UpdatedTime, objCopyTaskCond.UpdatedTime, strComparisonOpUpdatedTime);
}
if (objCopyTaskCond.IsUpdated(conCopyTask.TargetViewName) == true)
{
string strComparisonOpTargetViewName = objCopyTaskCond.dicFldComparisonOp[conCopyTask.TargetViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTask.TargetViewName, objCopyTaskCond.TargetViewName, strComparisonOpTargetViewName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CopyTask(CopyTask), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SourceViewId_Status_TargetPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCopyTaskEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCopyTaskEN objCopyTaskEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskEN == null) return true;
if (objCopyTaskEN.TaskId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
if (clsCopyTaskBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TaskId !=  {0}", objCopyTaskEN.TaskId);
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
if (clsCopyTaskBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CopyTask(CopyTask), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SourceViewId_Status_TargetPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCopyTaskEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCopyTaskEN objCopyTaskEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskEN == null) return "";
if (objCopyTaskEN.TaskId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TaskId !=  {0}", objCopyTaskEN.TaskId);
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CopyTask
{
public virtual bool UpdRelaTabDate(long lngTaskId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CopyTask(CopyTask)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCopyTaskBL
{
public static RelatedActions_CopyTask relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCopyTaskDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCopyTaskDA CopyTaskDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCopyTaskDA();
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
 public clsCopyTaskBL()
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
if (string.IsNullOrEmpty(clsCopyTaskEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCopyTaskEN._ConnectString);
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
public static DataTable GetDataTable_CopyTask(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CopyTaskDA.GetDataTable_CopyTask(strWhereCond);
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
objDT = CopyTaskDA.GetDataTable(strWhereCond);
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
objDT = CopyTaskDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CopyTaskDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CopyTaskDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CopyTaskDA.GetDataTable_Top(objTopPara);
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
objDT = CopyTaskDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CopyTaskDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CopyTaskDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTaskIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstByTaskIdLst(List<long> arrTaskIdLst)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTaskIdLst);
 string strWhereCond = string.Format("TaskId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTaskIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCopyTaskEN> GetObjLstByTaskIdLstCache(List<long> arrTaskIdLst)
{
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
List<clsCopyTaskEN> arrCopyTaskObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrCopyTaskObjLst_Sel =
arrCopyTaskObjLstCache
.Where(x => arrTaskIdLst.Contains(x.TaskId));
return arrCopyTaskObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetObjLst(string strWhereCond)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
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
public static List<clsCopyTaskEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCopyTaskCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCopyTaskEN> GetSubObjLstCache(clsCopyTaskEN objCopyTaskCond)
{
List<clsCopyTaskEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCopyTask._AttributeName)
{
if (objCopyTaskCond.IsUpdated(strFldName) == false) continue;
if (objCopyTaskCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskCond[strFldName].ToString());
}
else
{
if (objCopyTaskCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCopyTaskCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCopyTaskCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCopyTaskCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCopyTaskCond[strFldName]));
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
public static List<clsCopyTaskEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
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
public static List<clsCopyTaskEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
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
List<clsCopyTaskEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCopyTaskEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCopyTaskEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
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
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
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
public static List<clsCopyTaskEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCopyTaskEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
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
public static List<clsCopyTaskEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskEN.TaskId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCopyTaskEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCopyTask(ref clsCopyTaskEN objCopyTaskEN)
{
bool bolResult = CopyTaskDA.GetCopyTask(ref objCopyTaskEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngTaskId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskEN GetObjByTaskId(long lngTaskId)
{
clsCopyTaskEN objCopyTaskEN = CopyTaskDA.GetObjByTaskId(lngTaskId);
return objCopyTaskEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCopyTaskEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCopyTaskEN objCopyTaskEN = CopyTaskDA.GetFirstObj(strWhereCond);
 return objCopyTaskEN;
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
public static clsCopyTaskEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCopyTaskEN objCopyTaskEN = CopyTaskDA.GetObjByDataRow(objRow);
 return objCopyTaskEN;
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
public static clsCopyTaskEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCopyTaskEN objCopyTaskEN = CopyTaskDA.GetObjByDataRow(objRow);
 return objCopyTaskEN;
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
 /// <param name = "lngTaskId">所给的关键字</param>
 /// <param name = "lstCopyTaskObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskEN GetObjByTaskIdFromList(long lngTaskId, List<clsCopyTaskEN> lstCopyTaskObjLst)
{
foreach (clsCopyTaskEN objCopyTaskEN in lstCopyTaskObjLst)
{
if (objCopyTaskEN.TaskId == lngTaskId)
{
return objCopyTaskEN;
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
 long lngTaskId;
 try
 {
 lngTaskId = new clsCopyTaskDA().GetFirstID(strWhereCond);
 return lngTaskId;
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
 arrList = CopyTaskDA.GetID(strWhereCond);
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
bool bolIsExist = CopyTaskDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngTaskId)
{
//检测记录是否存在
bool bolIsExist = CopyTaskDA.IsExist(lngTaskId);
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
 bolIsExist = clsCopyTaskDA.IsExistTable();
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
 bolIsExist = CopyTaskDA.IsExistTable(strTabName);
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCopyTaskEN objCopyTaskEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCopyTaskEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!SourceViewId = [{0}],TargetPrjId = [{1}],Status = [{2}]的数据已经存在!(in clsCopyTaskBL.AddNewRecordBySql2)", objCopyTaskEN.SourceViewId,objCopyTaskEN.TargetPrjId,objCopyTaskEN.Status);
throw new Exception(strMsg);
}
try
{
bool bolResult = CopyTaskDA.AddNewRecordBySQL2(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCopyTaskEN objCopyTaskEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCopyTaskEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!SourceViewId = [{0}],TargetPrjId = [{1}],Status = [{2}]的数据已经存在!(in clsCopyTaskBL.AddNewRecordBySql2WithReturnKey)", objCopyTaskEN.SourceViewId,objCopyTaskEN.TargetPrjId,objCopyTaskEN.Status);
throw new Exception(strMsg);
}
try
{
string strKey = CopyTaskDA.AddNewRecordBySQL2WithReturnKey(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCopyTaskEN objCopyTaskEN)
{
try
{
bool bolResult = CopyTaskDA.Update(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN.TaskId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CopyTaskDA.UpdateBySql2(objCopyTaskEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskBL.ReFreshCache();

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngTaskId)
{
try
{
 clsCopyTaskEN objCopyTaskEN = clsCopyTaskBL.GetObjByTaskId(lngTaskId);

if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(objCopyTaskEN.TaskId, "SetUpdDate");
}
if (objCopyTaskEN != null)
{
int intRecNum = CopyTaskDA.DelRecord(lngTaskId);
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
/// <param name="lngTaskId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngTaskId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
//删除与表:[CopyTask]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCopyTask.TaskId,
//lngTaskId);
//        clsCopyTaskBL.DelCopyTasksByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCopyTaskBL.DelRecord(lngTaskId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCopyTaskBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTaskId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngTaskId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCopyTaskBL.relatedActions != null)
{
clsCopyTaskBL.relatedActions.UpdRelaTabDate(lngTaskId, "UpdRelaTabDate");
}
bool bolResult = CopyTaskDA.DelRecord(lngTaskId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTaskIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCopyTasks(List<string> arrTaskIdLst)
{
if (arrTaskIdLst.Count == 0) return 0;
try
{
if (clsCopyTaskBL.relatedActions != null)
{
foreach (var strTaskId in arrTaskIdLst)
{
long lngTaskId = long.Parse(strTaskId);
clsCopyTaskBL.relatedActions.UpdRelaTabDate(lngTaskId, "UpdRelaTabDate");
}
}
int intDelRecNum = CopyTaskDA.DelCopyTask(arrTaskIdLst);
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
public static int DelCopyTasksByCond(string strWhereCond)
{
try
{
if (clsCopyTaskBL.relatedActions != null)
{
List<string> arrTaskId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTaskId in arrTaskId)
{
long lngTaskId = long.Parse(strTaskId);
clsCopyTaskBL.relatedActions.UpdRelaTabDate(lngTaskId, "UpdRelaTabDate");
}
}
int intRecNum = CopyTaskDA.DelCopyTask(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CopyTask]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngTaskId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngTaskId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
//删除与表:[CopyTask]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCopyTaskBL.DelRecord(lngTaskId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCopyTaskBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngTaskId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCopyTaskENS">源对象</param>
 /// <param name = "objCopyTaskENT">目标对象</param>
 public static void CopyTo(clsCopyTaskEN objCopyTaskENS, clsCopyTaskEN objCopyTaskENT)
{
try
{
objCopyTaskENT.TaskId = objCopyTaskENS.TaskId; //TaskId
objCopyTaskENT.SourcePrjId = objCopyTaskENS.SourcePrjId; //SourcePrjId
objCopyTaskENT.TargetPrjId = objCopyTaskENS.TargetPrjId; //TargetPrjId
objCopyTaskENT.SourceViewId = objCopyTaskENS.SourceViewId; //SourceViewId
objCopyTaskENT.TargetViewId = objCopyTaskENS.TargetViewId; //TargetViewId
objCopyTaskENT.ConflictStrategy = objCopyTaskENS.ConflictStrategy; //ConflictStrategy
objCopyTaskENT.Status = objCopyTaskENS.Status; //Status
objCopyTaskENT.CurrentStep = objCopyTaskENS.CurrentStep; //CurrentStep
objCopyTaskENT.ErrorMessage = objCopyTaskENS.ErrorMessage; //错误信息
objCopyTaskENT.CreatedBy = objCopyTaskENS.CreatedBy; //CreatedBy
objCopyTaskENT.CreatedTime = objCopyTaskENS.CreatedTime; //CreatedTime
objCopyTaskENT.UpdatedTime = objCopyTaskENS.UpdatedTime; //UpdatedTime
objCopyTaskENT.TargetViewName = objCopyTaskENS.TargetViewName; //TargetViewName
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
 /// <param name = "objCopyTaskEN">源简化对象</param>
 public static void SetUpdFlag(clsCopyTaskEN objCopyTaskEN)
{
try
{
objCopyTaskEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCopyTaskEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCopyTask.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.TaskId = objCopyTaskEN.TaskId; //TaskId
}
if (arrFldSet.Contains(conCopyTask.SourcePrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.SourcePrjId = objCopyTaskEN.SourcePrjId; //SourcePrjId
}
if (arrFldSet.Contains(conCopyTask.TargetPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.TargetPrjId = objCopyTaskEN.TargetPrjId; //TargetPrjId
}
if (arrFldSet.Contains(conCopyTask.SourceViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.SourceViewId = objCopyTaskEN.SourceViewId; //SourceViewId
}
if (arrFldSet.Contains(conCopyTask.TargetViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.TargetViewId = objCopyTaskEN.TargetViewId == "[null]" ? null :  objCopyTaskEN.TargetViewId; //TargetViewId
}
if (arrFldSet.Contains(conCopyTask.ConflictStrategy, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.ConflictStrategy = objCopyTaskEN.ConflictStrategy; //ConflictStrategy
}
if (arrFldSet.Contains(conCopyTask.Status, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.Status = objCopyTaskEN.Status; //Status
}
if (arrFldSet.Contains(conCopyTask.CurrentStep, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.CurrentStep = objCopyTaskEN.CurrentStep; //CurrentStep
}
if (arrFldSet.Contains(conCopyTask.ErrorMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.ErrorMessage = objCopyTaskEN.ErrorMessage == "[null]" ? null :  objCopyTaskEN.ErrorMessage; //错误信息
}
if (arrFldSet.Contains(conCopyTask.CreatedBy, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.CreatedBy = objCopyTaskEN.CreatedBy; //CreatedBy
}
if (arrFldSet.Contains(conCopyTask.CreatedTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.CreatedTime = objCopyTaskEN.CreatedTime; //CreatedTime
}
if (arrFldSet.Contains(conCopyTask.UpdatedTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.UpdatedTime = objCopyTaskEN.UpdatedTime; //UpdatedTime
}
if (arrFldSet.Contains(conCopyTask.TargetViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskEN.TargetViewName = objCopyTaskEN.TargetViewName == "[null]" ? null :  objCopyTaskEN.TargetViewName; //TargetViewName
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
 /// <param name = "objCopyTaskEN">源简化对象</param>
 public static void AccessFldValueNull(clsCopyTaskEN objCopyTaskEN)
{
try
{
if (objCopyTaskEN.TargetViewId == "[null]") objCopyTaskEN.TargetViewId = null; //TargetViewId
if (objCopyTaskEN.ErrorMessage == "[null]") objCopyTaskEN.ErrorMessage = null; //错误信息
if (objCopyTaskEN.TargetViewName == "[null]") objCopyTaskEN.TargetViewName = null; //TargetViewName
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
public static void CheckPropertyNew(clsCopyTaskEN objCopyTaskEN)
{
 CopyTaskDA.CheckPropertyNew(objCopyTaskEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCopyTaskEN objCopyTaskEN)
{
 CopyTaskDA.CheckProperty4Condition(objCopyTaskEN);
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
if (clsCopyTaskBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCopyTaskBL没有刷新缓存机制(clsCopyTaskBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TaskId");
//if (arrCopyTaskObjLstCache == null)
//{
//arrCopyTaskObjLstCache = CopyTaskDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngTaskId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskEN GetObjByTaskIdCache(long lngTaskId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
List<clsCopyTaskEN> arrCopyTaskObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrCopyTaskObjLst_Sel =
arrCopyTaskObjLstCache
.Where(x=> x.TaskId == lngTaskId 
);
if (arrCopyTaskObjLst_Sel.Count() == 0)
{
   clsCopyTaskEN obj = clsCopyTaskBL.GetObjByTaskId(lngTaskId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCopyTaskObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskEN> GetAllCopyTaskObjLstCache()
{
//获取缓存中的对象列表
List<clsCopyTaskEN> arrCopyTaskObjLstCache = GetObjLstCache(); 
return arrCopyTaskObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
List<clsCopyTaskEN> arrCopyTaskObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCopyTaskObjLstCache;
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
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCopyTaskEN._RefreshTimeLst.Count == 0) return "";
return clsCopyTaskEN._RefreshTimeLst[clsCopyTaskEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCopyTaskBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCopyTaskEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCopyTaskBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CopyTask(CopyTask)
 /// 唯一性条件:SourceViewId_Status_TargetPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCopyTaskEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCopyTaskEN objCopyTaskEN)
{
//检测记录是否存在
string strResult = CopyTaskDA.GetUniCondStr(objCopyTaskEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-04-05
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngTaskId)
{
if (strInFldName != conCopyTask.TaskId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCopyTask._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCopyTask._AttributeName));
throw new Exception(strMsg);
}
var objCopyTask = clsCopyTaskBL.GetObjByTaskIdCache(lngTaskId);
if (objCopyTask == null) return "";
return objCopyTask[strOutFldName].ToString();
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
int intRecCount = clsCopyTaskDA.GetRecCount(strTabName);
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
int intRecCount = clsCopyTaskDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCopyTaskDA.GetRecCount();
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
int intRecCount = clsCopyTaskDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCopyTaskCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCopyTaskEN objCopyTaskCond)
{
List<clsCopyTaskEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCopyTask._AttributeName)
{
if (objCopyTaskCond.IsUpdated(strFldName) == false) continue;
if (objCopyTaskCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskCond[strFldName].ToString());
}
else
{
if (objCopyTaskCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCopyTaskCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCopyTaskCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCopyTaskCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCopyTaskCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCopyTaskCond[strFldName]));
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
 List<string> arrList = clsCopyTaskDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CopyTaskDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CopyTaskDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CopyTaskDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCopyTaskDA.SetFldValue(clsCopyTaskEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CopyTaskDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCopyTaskDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCopyTaskDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCopyTaskDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CopyTask] "); 
 strCreateTabCode.Append(" ( "); 
 // /**TaskId*/ 
 strCreateTabCode.Append(" TaskId bigint primary key identity, "); 
 // /**SourcePrjId*/ 
 strCreateTabCode.Append(" SourcePrjId char(4) not Null, "); 
 // /**TargetPrjId*/ 
 strCreateTabCode.Append(" TargetPrjId char(4) not Null, "); 
 // /**SourceViewId*/ 
 strCreateTabCode.Append(" SourceViewId char(8) not Null, "); 
 // /**TargetViewId*/ 
 strCreateTabCode.Append(" TargetViewId char(8) Null, "); 
 // /**ConflictStrategy*/ 
 strCreateTabCode.Append(" ConflictStrategy varchar(20) not Null, "); 
 // /**Status*/ 
 strCreateTabCode.Append(" Status varchar(20) not Null, "); 
 // /**CurrentStep*/ 
 strCreateTabCode.Append(" CurrentStep varchar(30) not Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrorMessage varchar(50) Null, "); 
 // /**CreatedBy*/ 
 strCreateTabCode.Append(" CreatedBy varchar(50) not Null, "); 
 // /**CreatedTime*/ 
 strCreateTabCode.Append(" CreatedTime datetime not Null, "); 
 // /**UpdatedTime*/ 
 strCreateTabCode.Append(" UpdatedTime datetime not Null, "); 
 // /**TargetViewName*/ 
 strCreateTabCode.Append(" TargetViewName varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CopyTask(CopyTask)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CopyTask : clsCommFun4BL
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
clsCopyTaskBL.ReFreshThisCache();
}
}

}