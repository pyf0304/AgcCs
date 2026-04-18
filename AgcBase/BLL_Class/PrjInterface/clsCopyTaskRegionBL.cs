
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskRegionBL
 表名:CopyTaskRegion(00050644)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:41:47
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
public static class  clsCopyTaskRegionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngRowId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskRegionEN GetObj(this K_RowId_CopyTaskRegion myKey)
{
clsCopyTaskRegionEN objCopyTaskRegionEN = clsCopyTaskRegionBL.CopyTaskRegionDA.GetObjByRowId(myKey.Value);
return objCopyTaskRegionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCopyTaskRegionEN objCopyTaskRegionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCopyTaskRegionEN) == false)
{
var strMsg = string.Format("记录已经存在!RelationStatus = [{0}],TaskId = [{1}],SourceRegionId = [{2}]的数据已经存在!(in clsCopyTaskRegionBL.AddNewRecord)", objCopyTaskRegionEN.RelationStatus,objCopyTaskRegionEN.TaskId,objCopyTaskRegionEN.SourceRegionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCopyTaskRegionBL.CopyTaskRegionDA.AddNewRecordBySQL2(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCopyTaskRegionEN objCopyTaskRegionEN, bool bolIsNeedCheckUniqueness = true)
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
objCopyTaskRegionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCopyTaskRegionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(RelationStatus(RelationStatus)=[{0}],TaskId(TaskId)=[{1}],SourceRegionId(SourceRegionId)=[{2}])已经存在,不能重复!", objCopyTaskRegionEN.RelationStatus, objCopyTaskRegionEN.TaskId, objCopyTaskRegionEN.SourceRegionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCopyTaskRegionEN.AddNewRecord();
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCopyTaskRegionEN objCopyTaskRegionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCopyTaskRegionEN) == false)
{
var strMsg = string.Format("记录已经存在!RelationStatus = [{0}],TaskId = [{1}],SourceRegionId = [{2}]的数据已经存在!(in clsCopyTaskRegionBL.AddNewRecordWithReturnKey)", objCopyTaskRegionEN.RelationStatus,objCopyTaskRegionEN.TaskId,objCopyTaskRegionEN.SourceRegionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCopyTaskRegionBL.CopyTaskRegionDA.AddNewRecordBySQL2WithReturnKey(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetRowId(this clsCopyTaskRegionEN objCopyTaskRegionEN, long lngRowId, string strComparisonOp="")
	{
objCopyTaskRegionEN.RowId = lngRowId; //RowId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.RowId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.RowId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.RowId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetTaskId(this clsCopyTaskRegionEN objCopyTaskRegionEN, long lngTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTaskId, conCopyTaskRegion.TaskId);
objCopyTaskRegionEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.TaskId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.TaskId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.TaskId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetSourceRegionId(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strSourceRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceRegionId, conCopyTaskRegion.SourceRegionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
}
objCopyTaskRegionEN.SourceRegionId = strSourceRegionId; //SourceRegionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.SourceRegionId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.SourceRegionId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.SourceRegionId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetSourceClsName(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strSourceClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceClsName, conCopyTaskRegion.SourceClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceClsName, 100, conCopyTaskRegion.SourceClsName);
}
objCopyTaskRegionEN.SourceClsName = strSourceClsName; //SourceClsName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.SourceClsName) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.SourceClsName, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.SourceClsName] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetTargetRegionId(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strTargetRegionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
}
objCopyTaskRegionEN.TargetRegionId = strTargetRegionId; //TargetRegionId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.TargetRegionId) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.TargetRegionId, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.TargetRegionId] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetCopyStatus(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strCopyStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCopyStatus, conCopyTaskRegion.CopyStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCopyStatus, 20, conCopyTaskRegion.CopyStatus);
}
objCopyTaskRegionEN.CopyStatus = strCopyStatus; //CopyStatus
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.CopyStatus) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.CopyStatus, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.CopyStatus] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetRelationStatus(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strRelationStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationStatus, conCopyTaskRegion.RelationStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelationStatus, 20, conCopyTaskRegion.RelationStatus);
}
objCopyTaskRegionEN.RelationStatus = strRelationStatus; //RelationStatus
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.RelationStatus) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.RelationStatus, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.RelationStatus] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetErrorMessage(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strErrorMessage, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrorMessage, 50, conCopyTaskRegion.ErrorMessage);
}
objCopyTaskRegionEN.ErrorMessage = strErrorMessage; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.ErrorMessage) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.ErrorMessage, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.ErrorMessage] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetStepOrder(this clsCopyTaskRegionEN objCopyTaskRegionEN, int intStepOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intStepOrder, conCopyTaskRegion.StepOrder);
objCopyTaskRegionEN.StepOrder = intStepOrder; //StepOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.StepOrder) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.StepOrder, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.StepOrder] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCopyTaskRegionEN SetUpdatedTime(this clsCopyTaskRegionEN objCopyTaskRegionEN, DateTime dteUpdatedTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteUpdatedTime, conCopyTaskRegion.UpdatedTime);
objCopyTaskRegionEN.UpdatedTime = dteUpdatedTime; //UpdatedTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCopyTaskRegionEN.dicFldComparisonOp.ContainsKey(conCopyTaskRegion.UpdatedTime) == false)
{
objCopyTaskRegionEN.dicFldComparisonOp.Add(conCopyTaskRegion.UpdatedTime, strComparisonOp);
}
else
{
objCopyTaskRegionEN.dicFldComparisonOp[conCopyTaskRegion.UpdatedTime] = strComparisonOp;
}
}
return objCopyTaskRegionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCopyTaskRegionEN.CheckPropertyNew();
clsCopyTaskRegionEN objCopyTaskRegionCond = new clsCopyTaskRegionEN();
string strCondition = objCopyTaskRegionCond
.SetRowId(objCopyTaskRegionEN.RowId, "<>")
.SetRelationStatus(objCopyTaskRegionEN.RelationStatus, "=")
.SetTaskId(objCopyTaskRegionEN.TaskId, "=")
.SetSourceRegionId(objCopyTaskRegionEN.SourceRegionId, "=")
.GetCombineCondition();
objCopyTaskRegionEN._IsCheckProperty = true;
bool bolIsExist = clsCopyTaskRegionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCopyTaskRegionEN.Update();
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
 /// <param name = "objCopyTaskRegion">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCopyTaskRegionEN objCopyTaskRegion)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCopyTaskRegionEN objCopyTaskRegionCond = new clsCopyTaskRegionEN();
string strCondition = objCopyTaskRegionCond
.SetRelationStatus(objCopyTaskRegion.RelationStatus, "=")
.SetTaskId(objCopyTaskRegion.TaskId, "=")
.SetSourceRegionId(objCopyTaskRegion.SourceRegionId, "=")
.GetCombineCondition();
objCopyTaskRegion._IsCheckProperty = true;
bool bolIsExist = clsCopyTaskRegionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCopyTaskRegion.RowId = clsCopyTaskRegionBL.GetFirstID_S(strCondition);
objCopyTaskRegion.UpdateWithCondition(strCondition);
}
else
{
objCopyTaskRegion.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN.RowId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCopyTaskRegionBL.CopyTaskRegionDA.UpdateBySql2(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCopyTaskRegionEN objCopyTaskRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskRegionEN.RowId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCopyTaskRegionBL.CopyTaskRegionDA.UpdateBySql2(objCopyTaskRegionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strWhereCond)
{
try
{
bool bolResult = clsCopyTaskRegionBL.CopyTaskRegionDA.UpdateBySqlWithCondition(objCopyTaskRegionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCopyTaskRegionEN objCopyTaskRegionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCopyTaskRegionBL.CopyTaskRegionDA.UpdateBySqlWithConditionTransaction(objCopyTaskRegionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
try
{
int intRecNum = clsCopyTaskRegionBL.CopyTaskRegionDA.DelRecord(objCopyTaskRegionEN.RowId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionENS">源对象</param>
 /// <param name = "objCopyTaskRegionENT">目标对象</param>
 public static void CopyTo(this clsCopyTaskRegionEN objCopyTaskRegionENS, clsCopyTaskRegionEN objCopyTaskRegionENT)
{
try
{
objCopyTaskRegionENT.RowId = objCopyTaskRegionENS.RowId; //RowId
objCopyTaskRegionENT.TaskId = objCopyTaskRegionENS.TaskId; //TaskId
objCopyTaskRegionENT.SourceRegionId = objCopyTaskRegionENS.SourceRegionId; //SourceRegionId
objCopyTaskRegionENT.SourceClsName = objCopyTaskRegionENS.SourceClsName; //SourceClsName
objCopyTaskRegionENT.TargetRegionId = objCopyTaskRegionENS.TargetRegionId; //TargetRegionId
objCopyTaskRegionENT.CopyStatus = objCopyTaskRegionENS.CopyStatus; //CopyStatus
objCopyTaskRegionENT.RelationStatus = objCopyTaskRegionENS.RelationStatus; //RelationStatus
objCopyTaskRegionENT.ErrorMessage = objCopyTaskRegionENS.ErrorMessage; //错误信息
objCopyTaskRegionENT.StepOrder = objCopyTaskRegionENS.StepOrder; //StepOrder
objCopyTaskRegionENT.UpdatedTime = objCopyTaskRegionENS.UpdatedTime; //UpdatedTime
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
 /// <param name = "objCopyTaskRegionENS">源对象</param>
 /// <returns>目标对象=>clsCopyTaskRegionEN:objCopyTaskRegionENT</returns>
 public static clsCopyTaskRegionEN CopyTo(this clsCopyTaskRegionEN objCopyTaskRegionENS)
{
try
{
 clsCopyTaskRegionEN objCopyTaskRegionENT = new clsCopyTaskRegionEN()
{
RowId = objCopyTaskRegionENS.RowId, //RowId
TaskId = objCopyTaskRegionENS.TaskId, //TaskId
SourceRegionId = objCopyTaskRegionENS.SourceRegionId, //SourceRegionId
SourceClsName = objCopyTaskRegionENS.SourceClsName, //SourceClsName
TargetRegionId = objCopyTaskRegionENS.TargetRegionId, //TargetRegionId
CopyStatus = objCopyTaskRegionENS.CopyStatus, //CopyStatus
RelationStatus = objCopyTaskRegionENS.RelationStatus, //RelationStatus
ErrorMessage = objCopyTaskRegionENS.ErrorMessage, //错误信息
StepOrder = objCopyTaskRegionENS.StepOrder, //StepOrder
UpdatedTime = objCopyTaskRegionENS.UpdatedTime, //UpdatedTime
};
 return objCopyTaskRegionENT;
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
public static void CheckPropertyNew(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 clsCopyTaskRegionBL.CopyTaskRegionDA.CheckPropertyNew(objCopyTaskRegionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 clsCopyTaskRegionBL.CopyTaskRegionDA.CheckProperty4Condition(objCopyTaskRegionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCopyTaskRegionEN objCopyTaskRegionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.RowId) == true)
{
string strComparisonOpRowId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.RowId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.RowId, objCopyTaskRegionCond.RowId, strComparisonOpRowId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.TaskId) == true)
{
string strComparisonOpTaskId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.TaskId, objCopyTaskRegionCond.TaskId, strComparisonOpTaskId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.SourceRegionId) == true)
{
string strComparisonOpSourceRegionId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.SourceRegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.SourceRegionId, objCopyTaskRegionCond.SourceRegionId, strComparisonOpSourceRegionId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.SourceClsName) == true)
{
string strComparisonOpSourceClsName = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.SourceClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.SourceClsName, objCopyTaskRegionCond.SourceClsName, strComparisonOpSourceClsName);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.TargetRegionId) == true)
{
string strComparisonOpTargetRegionId = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.TargetRegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.TargetRegionId, objCopyTaskRegionCond.TargetRegionId, strComparisonOpTargetRegionId);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.CopyStatus) == true)
{
string strComparisonOpCopyStatus = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.CopyStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.CopyStatus, objCopyTaskRegionCond.CopyStatus, strComparisonOpCopyStatus);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.RelationStatus) == true)
{
string strComparisonOpRelationStatus = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.RelationStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.RelationStatus, objCopyTaskRegionCond.RelationStatus, strComparisonOpRelationStatus);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.ErrorMessage) == true)
{
string strComparisonOpErrorMessage = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.ErrorMessage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.ErrorMessage, objCopyTaskRegionCond.ErrorMessage, strComparisonOpErrorMessage);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.StepOrder) == true)
{
string strComparisonOpStepOrder = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.StepOrder];
strWhereCond += string.Format(" And {0} {2} {1}", conCopyTaskRegion.StepOrder, objCopyTaskRegionCond.StepOrder, strComparisonOpStepOrder);
}
if (objCopyTaskRegionCond.IsUpdated(conCopyTaskRegion.UpdatedTime) == true)
{
string strComparisonOpUpdatedTime = objCopyTaskRegionCond.dicFldComparisonOp[conCopyTaskRegion.UpdatedTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCopyTaskRegion.UpdatedTime, objCopyTaskRegionCond.UpdatedTime, strComparisonOpUpdatedTime);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CopyTaskRegion(CopyTaskRegion), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RelationStatus_SourceRegionId_TaskId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskRegionEN == null) return true;
if (objCopyTaskRegionEN.RowId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelationStatus = '{0}'", objCopyTaskRegionEN.RelationStatus);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and SourceRegionId = '{0}'", objCopyTaskRegionEN.SourceRegionId);
if (clsCopyTaskRegionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RowId !=  {0}", objCopyTaskRegionEN.RowId);
 sbCondition.AppendFormat(" and RelationStatus = '{0}'", objCopyTaskRegionEN.RelationStatus);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and SourceRegionId = '{0}'", objCopyTaskRegionEN.SourceRegionId);
if (clsCopyTaskRegionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CopyTaskRegion(CopyTaskRegion), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RelationStatus_SourceRegionId_TaskId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCopyTaskRegionEN == null) return "";
if (objCopyTaskRegionEN.RowId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelationStatus = '{0}'", objCopyTaskRegionEN.RelationStatus);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and SourceRegionId = '{0}'", objCopyTaskRegionEN.SourceRegionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RowId !=  {0}", objCopyTaskRegionEN.RowId);
 sbCondition.AppendFormat(" and RelationStatus = '{0}'", objCopyTaskRegionEN.RelationStatus);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and SourceRegionId = '{0}'", objCopyTaskRegionEN.SourceRegionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CopyTaskRegion
{
public virtual bool UpdRelaTabDate(long lngRowId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CopyTaskRegion(CopyTaskRegion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCopyTaskRegionBL
{
public static RelatedActions_CopyTaskRegion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCopyTaskRegionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCopyTaskRegionDA CopyTaskRegionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCopyTaskRegionDA();
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
 public clsCopyTaskRegionBL()
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
if (string.IsNullOrEmpty(clsCopyTaskRegionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCopyTaskRegionEN._ConnectString);
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
public static DataTable GetDataTable_CopyTaskRegion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CopyTaskRegionDA.GetDataTable_CopyTaskRegion(strWhereCond);
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
objDT = CopyTaskRegionDA.GetDataTable(strWhereCond);
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
objDT = CopyTaskRegionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CopyTaskRegionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CopyTaskRegionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CopyTaskRegionDA.GetDataTable_Top(objTopPara);
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
objDT = CopyTaskRegionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CopyTaskRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CopyTaskRegionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstByRowIdLst(List<long> arrRowIdLst)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRowIdLst);
 string strWhereCond = string.Format("RowId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCopyTaskRegionEN> GetObjLstByRowIdLstCache(List<long> arrRowIdLst)
{
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrCopyTaskRegionObjLst_Sel =
arrCopyTaskRegionObjLstCache
.Where(x => arrRowIdLst.Contains(x.RowId));
return arrCopyTaskRegionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLst(string strWhereCond)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
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
public static List<clsCopyTaskRegionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCopyTaskRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCopyTaskRegionEN> GetSubObjLstCache(clsCopyTaskRegionEN objCopyTaskRegionCond)
{
List<clsCopyTaskRegionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCopyTaskRegion._AttributeName)
{
if (objCopyTaskRegionCond.IsUpdated(strFldName) == false) continue;
if (objCopyTaskRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskRegionCond[strFldName].ToString());
}
else
{
if (objCopyTaskRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCopyTaskRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCopyTaskRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCopyTaskRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCopyTaskRegionCond[strFldName]));
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
public static List<clsCopyTaskRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
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
public static List<clsCopyTaskRegionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
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
List<clsCopyTaskRegionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCopyTaskRegionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCopyTaskRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
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
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
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
public static List<clsCopyTaskRegionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCopyTaskRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
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
public static List<clsCopyTaskRegionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCopyTaskRegionEN.RowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCopyTaskRegion(ref clsCopyTaskRegionEN objCopyTaskRegionEN)
{
bool bolResult = CopyTaskRegionDA.GetCopyTaskRegion(ref objCopyTaskRegionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngRowId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCopyTaskRegionEN GetObjByRowId(long lngRowId)
{
clsCopyTaskRegionEN objCopyTaskRegionEN = CopyTaskRegionDA.GetObjByRowId(lngRowId);
return objCopyTaskRegionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCopyTaskRegionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCopyTaskRegionEN objCopyTaskRegionEN = CopyTaskRegionDA.GetFirstObj(strWhereCond);
 return objCopyTaskRegionEN;
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
public static clsCopyTaskRegionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCopyTaskRegionEN objCopyTaskRegionEN = CopyTaskRegionDA.GetObjByDataRow(objRow);
 return objCopyTaskRegionEN;
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
public static clsCopyTaskRegionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCopyTaskRegionEN objCopyTaskRegionEN = CopyTaskRegionDA.GetObjByDataRow(objRow);
 return objCopyTaskRegionEN;
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
 /// <param name = "lngRowId">所给的关键字</param>
 /// <param name = "lstCopyTaskRegionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskRegionEN GetObjByRowIdFromList(long lngRowId, List<clsCopyTaskRegionEN> lstCopyTaskRegionObjLst)
{
foreach (clsCopyTaskRegionEN objCopyTaskRegionEN in lstCopyTaskRegionObjLst)
{
if (objCopyTaskRegionEN.RowId == lngRowId)
{
return objCopyTaskRegionEN;
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
 long lngRowId;
 try
 {
 lngRowId = new clsCopyTaskRegionDA().GetFirstID(strWhereCond);
 return lngRowId;
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
 arrList = CopyTaskRegionDA.GetID(strWhereCond);
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
bool bolIsExist = CopyTaskRegionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngRowId)
{
//检测记录是否存在
bool bolIsExist = CopyTaskRegionDA.IsExist(lngRowId);
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
 bolIsExist = clsCopyTaskRegionDA.IsExistTable();
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
 bolIsExist = CopyTaskRegionDA.IsExistTable(strTabName);
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCopyTaskRegionEN objCopyTaskRegionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCopyTaskRegionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RelationStatus = [{0}],TaskId = [{1}],SourceRegionId = [{2}]的数据已经存在!(in clsCopyTaskRegionBL.AddNewRecordBySql2)", objCopyTaskRegionEN.RelationStatus,objCopyTaskRegionEN.TaskId,objCopyTaskRegionEN.SourceRegionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CopyTaskRegionDA.AddNewRecordBySQL2(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCopyTaskRegionEN objCopyTaskRegionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCopyTaskRegionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RelationStatus = [{0}],TaskId = [{1}],SourceRegionId = [{2}]的数据已经存在!(in clsCopyTaskRegionBL.AddNewRecordBySql2WithReturnKey)", objCopyTaskRegionEN.RelationStatus,objCopyTaskRegionEN.TaskId,objCopyTaskRegionEN.SourceRegionId);
throw new Exception(strMsg);
}
try
{
string strKey = CopyTaskRegionDA.AddNewRecordBySQL2WithReturnKey(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
try
{
bool bolResult = CopyTaskRegionDA.Update(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN.RowId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CopyTaskRegionDA.UpdateBySql2(objCopyTaskRegionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCopyTaskRegionBL.ReFreshCache();

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
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
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngRowId)
{
try
{
 clsCopyTaskRegionEN objCopyTaskRegionEN = clsCopyTaskRegionBL.GetObjByRowId(lngRowId);

if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(objCopyTaskRegionEN.RowId, "SetUpdDate");
}
if (objCopyTaskRegionEN != null)
{
int intRecNum = CopyTaskRegionDA.DelRecord(lngRowId);
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
/// <param name="lngRowId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngRowId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
//删除与表:[CopyTaskRegion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCopyTaskRegion.RowId,
//lngRowId);
//        clsCopyTaskRegionBL.DelCopyTaskRegionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCopyTaskRegionBL.DelRecord(lngRowId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCopyTaskRegionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRowId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngRowId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCopyTaskRegionBL.relatedActions != null)
{
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(lngRowId, "UpdRelaTabDate");
}
bool bolResult = CopyTaskRegionDA.DelRecord(lngRowId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRowIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCopyTaskRegions(List<string> arrRowIdLst)
{
if (arrRowIdLst.Count == 0) return 0;
try
{
if (clsCopyTaskRegionBL.relatedActions != null)
{
foreach (var strRowId in arrRowIdLst)
{
long lngRowId = long.Parse(strRowId);
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(lngRowId, "UpdRelaTabDate");
}
}
int intDelRecNum = CopyTaskRegionDA.DelCopyTaskRegion(arrRowIdLst);
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
public static int DelCopyTaskRegionsByCond(string strWhereCond)
{
try
{
if (clsCopyTaskRegionBL.relatedActions != null)
{
List<string> arrRowId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRowId in arrRowId)
{
long lngRowId = long.Parse(strRowId);
clsCopyTaskRegionBL.relatedActions.UpdRelaTabDate(lngRowId, "UpdRelaTabDate");
}
}
int intRecNum = CopyTaskRegionDA.DelCopyTaskRegion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CopyTaskRegion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngRowId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngRowId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
//删除与表:[CopyTaskRegion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCopyTaskRegionBL.DelRecord(lngRowId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCopyTaskRegionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngRowId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCopyTaskRegionENS">源对象</param>
 /// <param name = "objCopyTaskRegionENT">目标对象</param>
 public static void CopyTo(clsCopyTaskRegionEN objCopyTaskRegionENS, clsCopyTaskRegionEN objCopyTaskRegionENT)
{
try
{
objCopyTaskRegionENT.RowId = objCopyTaskRegionENS.RowId; //RowId
objCopyTaskRegionENT.TaskId = objCopyTaskRegionENS.TaskId; //TaskId
objCopyTaskRegionENT.SourceRegionId = objCopyTaskRegionENS.SourceRegionId; //SourceRegionId
objCopyTaskRegionENT.SourceClsName = objCopyTaskRegionENS.SourceClsName; //SourceClsName
objCopyTaskRegionENT.TargetRegionId = objCopyTaskRegionENS.TargetRegionId; //TargetRegionId
objCopyTaskRegionENT.CopyStatus = objCopyTaskRegionENS.CopyStatus; //CopyStatus
objCopyTaskRegionENT.RelationStatus = objCopyTaskRegionENS.RelationStatus; //RelationStatus
objCopyTaskRegionENT.ErrorMessage = objCopyTaskRegionENS.ErrorMessage; //错误信息
objCopyTaskRegionENT.StepOrder = objCopyTaskRegionENS.StepOrder; //StepOrder
objCopyTaskRegionENT.UpdatedTime = objCopyTaskRegionENS.UpdatedTime; //UpdatedTime
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
 /// <param name = "objCopyTaskRegionEN">源简化对象</param>
 public static void SetUpdFlag(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
try
{
objCopyTaskRegionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCopyTaskRegionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCopyTaskRegion.RowId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.RowId = objCopyTaskRegionEN.RowId; //RowId
}
if (arrFldSet.Contains(conCopyTaskRegion.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.TaskId = objCopyTaskRegionEN.TaskId; //TaskId
}
if (arrFldSet.Contains(conCopyTaskRegion.SourceRegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.SourceRegionId = objCopyTaskRegionEN.SourceRegionId; //SourceRegionId
}
if (arrFldSet.Contains(conCopyTaskRegion.SourceClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.SourceClsName = objCopyTaskRegionEN.SourceClsName; //SourceClsName
}
if (arrFldSet.Contains(conCopyTaskRegion.TargetRegionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.TargetRegionId = objCopyTaskRegionEN.TargetRegionId == "[null]" ? null :  objCopyTaskRegionEN.TargetRegionId; //TargetRegionId
}
if (arrFldSet.Contains(conCopyTaskRegion.CopyStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.CopyStatus = objCopyTaskRegionEN.CopyStatus; //CopyStatus
}
if (arrFldSet.Contains(conCopyTaskRegion.RelationStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.RelationStatus = objCopyTaskRegionEN.RelationStatus; //RelationStatus
}
if (arrFldSet.Contains(conCopyTaskRegion.ErrorMessage, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.ErrorMessage = objCopyTaskRegionEN.ErrorMessage == "[null]" ? null :  objCopyTaskRegionEN.ErrorMessage; //错误信息
}
if (arrFldSet.Contains(conCopyTaskRegion.StepOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.StepOrder = objCopyTaskRegionEN.StepOrder; //StepOrder
}
if (arrFldSet.Contains(conCopyTaskRegion.UpdatedTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCopyTaskRegionEN.UpdatedTime = objCopyTaskRegionEN.UpdatedTime; //UpdatedTime
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
 /// <param name = "objCopyTaskRegionEN">源简化对象</param>
 public static void AccessFldValueNull(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
try
{
if (objCopyTaskRegionEN.TargetRegionId == "[null]") objCopyTaskRegionEN.TargetRegionId = null; //TargetRegionId
if (objCopyTaskRegionEN.ErrorMessage == "[null]") objCopyTaskRegionEN.ErrorMessage = null; //错误信息
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
public static void CheckPropertyNew(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 CopyTaskRegionDA.CheckPropertyNew(objCopyTaskRegionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 CopyTaskRegionDA.CheckProperty4Condition(objCopyTaskRegionEN);
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
if (clsCopyTaskRegionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCopyTaskRegionBL没有刷新缓存机制(clsCopyTaskRegionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RowId");
//if (arrCopyTaskRegionObjLstCache == null)
//{
//arrCopyTaskRegionObjLstCache = CopyTaskRegionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngRowId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCopyTaskRegionEN GetObjByRowIdCache(long lngRowId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrCopyTaskRegionObjLst_Sel =
arrCopyTaskRegionObjLstCache
.Where(x=> x.RowId == lngRowId 
);
if (arrCopyTaskRegionObjLst_Sel.Count() == 0)
{
   clsCopyTaskRegionEN obj = clsCopyTaskRegionBL.GetObjByRowId(lngRowId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCopyTaskRegionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskRegionEN> GetAllCopyTaskRegionObjLstCache()
{
//获取缓存中的对象列表
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = GetObjLstCache(); 
return arrCopyTaskRegionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCopyTaskRegionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
List<clsCopyTaskRegionEN> arrCopyTaskRegionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCopyTaskRegionObjLstCache;
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
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskRegionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCopyTaskRegionEN._RefreshTimeLst.Count == 0) return "";
return clsCopyTaskRegionEN._RefreshTimeLst[clsCopyTaskRegionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsCopyTaskRegionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCopyTaskRegionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCopyTaskRegionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCopyTaskRegionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CopyTaskRegion(CopyTaskRegion)
 /// 唯一性条件:RelationStatus_SourceRegionId_TaskId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检测记录是否存在
string strResult = CopyTaskRegionDA.GetUniCondStr(objCopyTaskRegionEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngRowId)
{
if (strInFldName != conCopyTaskRegion.RowId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCopyTaskRegion._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCopyTaskRegion._AttributeName));
throw new Exception(strMsg);
}
var objCopyTaskRegion = clsCopyTaskRegionBL.GetObjByRowIdCache(lngRowId);
if (objCopyTaskRegion == null) return "";
return objCopyTaskRegion[strOutFldName].ToString();
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
int intRecCount = clsCopyTaskRegionDA.GetRecCount(strTabName);
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
int intRecCount = clsCopyTaskRegionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCopyTaskRegionDA.GetRecCount();
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
int intRecCount = clsCopyTaskRegionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCopyTaskRegionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCopyTaskRegionEN objCopyTaskRegionCond)
{
List<clsCopyTaskRegionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCopyTaskRegionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCopyTaskRegion._AttributeName)
{
if (objCopyTaskRegionCond.IsUpdated(strFldName) == false) continue;
if (objCopyTaskRegionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskRegionCond[strFldName].ToString());
}
else
{
if (objCopyTaskRegionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCopyTaskRegionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCopyTaskRegionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCopyTaskRegionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCopyTaskRegionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCopyTaskRegionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCopyTaskRegionCond[strFldName]));
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
 List<string> arrList = clsCopyTaskRegionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CopyTaskRegionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CopyTaskRegionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CopyTaskRegionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCopyTaskRegionDA.SetFldValue(clsCopyTaskRegionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CopyTaskRegionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCopyTaskRegionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCopyTaskRegionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCopyTaskRegionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CopyTaskRegion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RowId*/ 
 strCreateTabCode.Append(" RowId bigint primary key identity, "); 
 // /**TaskId*/ 
 strCreateTabCode.Append(" TaskId bigint not Null, "); 
 // /**SourceRegionId*/ 
 strCreateTabCode.Append(" SourceRegionId char(10) not Null, "); 
 // /**SourceClsName*/ 
 strCreateTabCode.Append(" SourceClsName varchar(100) not Null, "); 
 // /**TargetRegionId*/ 
 strCreateTabCode.Append(" TargetRegionId char(10) Null, "); 
 // /**CopyStatus*/ 
 strCreateTabCode.Append(" CopyStatus varchar(20) not Null, "); 
 // /**RelationStatus*/ 
 strCreateTabCode.Append(" RelationStatus varchar(20) not Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrorMessage varchar(50) Null, "); 
 // /**StepOrder*/ 
 strCreateTabCode.Append(" StepOrder int not Null, "); 
 // /**UpdatedTime*/ 
 strCreateTabCode.Append(" UpdatedTime datetime not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CopyTaskRegion(CopyTaskRegion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CopyTaskRegion : clsCommFun4BL
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
clsCopyTaskRegionBL.ReFreshThisCache();
}
}

}