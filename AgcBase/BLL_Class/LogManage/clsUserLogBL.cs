
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogBL
 表名:UserLog(00050130)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:13
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
public static class  clsUserLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserLogEN GetObj(this K_mId_UserLog myKey)
{
clsUserLogEN objUserLogEN = clsUserLogBL.UserLogDA.GetObjBymId(myKey.Value);
return objUserLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserLogEN objUserLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecord)", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserLogBL.UserLogDA.AddNewRecordBySQL2(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsUserLogEN objUserLogEN, bool bolIsNeedCheckUniqueness = true)
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
objUserLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户Id(UserId)=[{0}],对象表(ObjectTable)=[{1}],登陆日期(LoginDate)=[{2}],登陆时间(LoginTime)=[{3}])已经存在,不能重复!", objUserLogEN.UserId, objUserLogEN.ObjectTable, objUserLogEN.LoginDate, objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserLogEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecord(SqlTransaction))", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserLogBL.UserLogDA.AddNewRecordBySQL2(objUserLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000086)添加记录出错!(带事务处理), {1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserLogEN objUserLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecordWithReturnKey)", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserLogBL.UserLogDA.AddNewRecordBySQL2WithReturnKey(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值,该函数可以进行事务处理(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecordWithReturnKey)", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserLogBL.UserLogDA.AddNewRecordBySQL2WithReturnKey(objUserLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000092)带返回值的添加记录出错!(带事务处理), {1}.(from {0})",
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
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetmId(this clsUserLogEN objUserLogEN, long lngmId, string strComparisonOp="")
	{
objUserLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.mId) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.mId, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.mId] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetUserId(this clsUserLogEN objUserLogEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserLog.UserId);
}
objUserLogEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.UserId) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.UserId, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.UserId] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetLoginTime(this clsUserLogEN objUserLogEN, string strLoginTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginTime, 6, conUserLog.LoginTime);
}
objUserLogEN.LoginTime = strLoginTime; //登陆时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.LoginTime) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.LoginTime, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.LoginTime] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetLoginDate(this clsUserLogEN objUserLogEN, string strLoginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginDate, 8, conUserLog.LoginDate);
}
objUserLogEN.LoginDate = strLoginDate; //登陆日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.LoginDate) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.LoginDate, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.LoginDate] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetUserIp(this clsUserLogEN objUserLogEN, string strUserIp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserIp, 40, conUserLog.UserIp);
}
objUserLogEN.UserIp = strUserIp; //用户IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.UserIp) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.UserIp, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.UserIp] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetObjectTable(this clsUserLogEN objUserLogEN, string strObjectTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectTable, 50, conUserLog.ObjectTable);
}
objUserLogEN.ObjectTable = strObjectTable; //对象表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.ObjectTable) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.ObjectTable, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.ObjectTable] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetUsedValue(this clsUserLogEN objUserLogEN, string strUsedValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUsedValue, 50, conUserLog.UsedValue);
}
objUserLogEN.UsedValue = strUsedValue; //使用值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.UsedValue) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.UsedValue, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.UsedValue] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetUpdDate(this clsUserLogEN objUserLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserLog.UpdDate);
}
objUserLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.UpdDate) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.UpdDate, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.UpdDate] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetMemo(this clsUserLogEN objUserLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserLog.Memo);
}
objUserLogEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.Memo) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.Memo, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.Memo] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetIsDeleted(this clsUserLogEN objUserLogEN, bool bolIsDeleted, string strComparisonOp="")
	{
objUserLogEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.IsDeleted) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.IsDeleted, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.IsDeleted] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetOrderNum(this clsUserLogEN objUserLogEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conUserLog.OrderNum);
objUserLogEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.OrderNum) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.OrderNum, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.OrderNum] = strComparisonOp;
}
}
return objUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserLogEN SetDeletedDate(this clsUserLogEN objUserLogEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, conUserLog.DeletedDate);
}
objUserLogEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserLogEN.dicFldComparisonOp.ContainsKey(conUserLog.DeletedDate) == false)
{
objUserLogEN.dicFldComparisonOp.Add(conUserLog.DeletedDate, strComparisonOp);
}
else
{
objUserLogEN.dicFldComparisonOp[conUserLog.DeletedDate] = strComparisonOp;
}
}
return objUserLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserLogEN objUserLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserLogEN.CheckPropertyNew();
clsUserLogEN objUserLogCond = new clsUserLogEN();
string strCondition = objUserLogCond
.SetmId(objUserLogEN.mId, "<>")
.SetUserId(objUserLogEN.UserId, "=")
.SetObjectTable(objUserLogEN.ObjectTable, "=")
.SetLoginDate(objUserLogEN.LoginDate, "=")
.SetLoginTime(objUserLogEN.LoginTime, "=")
.GetCombineCondition();
objUserLogEN._IsCheckProperty = true;
bool bolIsExist = clsUserLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_ObjectTable_LoginDate_LoginTime)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserLogEN.Update();
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
 /// <param name = "objUserLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserLogEN objUserLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserLogEN objUserLogCond = new clsUserLogEN();
string strCondition = objUserLogCond
.SetUserId(objUserLog.UserId, "=")
.SetObjectTable(objUserLog.ObjectTable, "=")
.SetLoginDate(objUserLog.LoginDate, "=")
.SetLoginTime(objUserLog.LoginTime, "=")
.GetCombineCondition();
objUserLog._IsCheckProperty = true;
bool bolIsExist = clsUserLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserLog.mId = clsUserLogBL.GetFirstID_S(strCondition);
objUserLog.UpdateWithCondition(strCondition);
}
else
{
objUserLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserLogEN objUserLogEN)
{
 if (objUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserLogBL.UserLogDA.UpdateBySql2(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateBySql2WithTransaction_S)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserLogBL.UserLogDA.UpdateBySql2(objUserLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000035)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserLogBL.UserLogDA.UpdateBySql2(objUserLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserLogEN objUserLogEN, string strWhereCond)
{
try
{
bool bolResult = clsUserLogBL.UserLogDA.UpdateBySqlWithCondition(objUserLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserLogEN objUserLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserLogBL.UserLogDA.UpdateBySqlWithConditionTransaction(objUserLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
public static int Delete(this clsUserLogEN objUserLogEN)
{
try
{
int intRecNum = clsUserLogBL.UserLogDA.DelRecord(objUserLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
 public static void CopyTo(this clsUserLogEN objUserLogENS, clsUserLogEN objUserLogENT)
{
try
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT.IsDeleted = objUserLogENS.IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT.DeletedDate = objUserLogENS.DeletedDate; //删除日期
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
 /// <param name = "objUserLogENS">源对象</param>
 /// <returns>目标对象=>clsUserLogEN:objUserLogENT</returns>
 public static clsUserLogEN CopyTo(this clsUserLogEN objUserLogENS)
{
try
{
 clsUserLogEN objUserLogENT = new clsUserLogEN()
{
mId = objUserLogENS.mId, //mId
UserId = objUserLogENS.UserId, //用户Id
LoginTime = objUserLogENS.LoginTime, //登陆时间
LoginDate = objUserLogENS.LoginDate, //登陆日期
UserIp = objUserLogENS.UserIp, //用户IP
ObjectTable = objUserLogENS.ObjectTable, //对象表
UsedValue = objUserLogENS.UsedValue, //使用值
UpdDate = objUserLogENS.UpdDate, //修改日期
Memo = objUserLogENS.Memo, //说明
IsDeleted = objUserLogENS.IsDeleted, //是否删除
OrderNum = objUserLogENS.OrderNum, //序号
DeletedDate = objUserLogENS.DeletedDate, //删除日期
};
 return objUserLogENT;
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
public static void CheckPropertyNew(this clsUserLogEN objUserLogEN)
{
 clsUserLogBL.UserLogDA.CheckPropertyNew(objUserLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserLogEN objUserLogEN)
{
 clsUserLogBL.UserLogDA.CheckProperty4Condition(objUserLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserLogEN objUserLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserLogCond.IsUpdated(conUserLog.mId) == true)
{
string strComparisonOpmId = objUserLogCond.dicFldComparisonOp[conUserLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserLog.mId, objUserLogCond.mId, strComparisonOpmId);
}
if (objUserLogCond.IsUpdated(conUserLog.UserId) == true)
{
string strComparisonOpUserId = objUserLogCond.dicFldComparisonOp[conUserLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.UserId, objUserLogCond.UserId, strComparisonOpUserId);
}
if (objUserLogCond.IsUpdated(conUserLog.LoginTime) == true)
{
string strComparisonOpLoginTime = objUserLogCond.dicFldComparisonOp[conUserLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.LoginTime, objUserLogCond.LoginTime, strComparisonOpLoginTime);
}
if (objUserLogCond.IsUpdated(conUserLog.LoginDate) == true)
{
string strComparisonOpLoginDate = objUserLogCond.dicFldComparisonOp[conUserLog.LoginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.LoginDate, objUserLogCond.LoginDate, strComparisonOpLoginDate);
}
if (objUserLogCond.IsUpdated(conUserLog.UserIp) == true)
{
string strComparisonOpUserIp = objUserLogCond.dicFldComparisonOp[conUserLog.UserIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.UserIp, objUserLogCond.UserIp, strComparisonOpUserIp);
}
if (objUserLogCond.IsUpdated(conUserLog.ObjectTable) == true)
{
string strComparisonOpObjectTable = objUserLogCond.dicFldComparisonOp[conUserLog.ObjectTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.ObjectTable, objUserLogCond.ObjectTable, strComparisonOpObjectTable);
}
if (objUserLogCond.IsUpdated(conUserLog.UsedValue) == true)
{
string strComparisonOpUsedValue = objUserLogCond.dicFldComparisonOp[conUserLog.UsedValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.UsedValue, objUserLogCond.UsedValue, strComparisonOpUsedValue);
}
if (objUserLogCond.IsUpdated(conUserLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserLogCond.dicFldComparisonOp[conUserLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.UpdDate, objUserLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserLogCond.IsUpdated(conUserLog.Memo) == true)
{
string strComparisonOpMemo = objUserLogCond.dicFldComparisonOp[conUserLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.Memo, objUserLogCond.Memo, strComparisonOpMemo);
}
if (objUserLogCond.IsUpdated(conUserLog.IsDeleted) == true)
{
if (objUserLogCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserLog.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserLog.IsDeleted);
}
}
if (objUserLogCond.IsUpdated(conUserLog.OrderNum) == true)
{
string strComparisonOpOrderNum = objUserLogCond.dicFldComparisonOp[conUserLog.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conUserLog.OrderNum, objUserLogCond.OrderNum, strComparisonOpOrderNum);
}
if (objUserLogCond.IsUpdated(conUserLog.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objUserLogCond.dicFldComparisonOp[conUserLog.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserLog.DeletedDate, objUserLogCond.DeletedDate, strComparisonOpDeletedDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserLog(用户日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_ObjectTable_LoginDate_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserLogEN objUserLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserLogEN == null) return true;
if (objUserLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLogEN.UserId);
}
 if (objUserLogEN.ObjectTable == null)
{
 sbCondition.AppendFormat(" and ObjectTable is null", objUserLogEN.ObjectTable);
}
else
{
 sbCondition.AppendFormat(" and ObjectTable = '{0}'", objUserLogEN.ObjectTable);
}
 if (objUserLogEN.LoginDate == null)
{
 sbCondition.AppendFormat(" and LoginDate is null", objUserLogEN.LoginDate);
}
else
{
 sbCondition.AppendFormat(" and LoginDate = '{0}'", objUserLogEN.LoginDate);
}
 if (objUserLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null", objUserLogEN.LoginTime);
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objUserLogEN.LoginTime);
}
if (clsUserLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLogEN.UserId);
 sbCondition.AppendFormat(" and ObjectTable = '{0}'", objUserLogEN.ObjectTable);
 sbCondition.AppendFormat(" and LoginDate = '{0}'", objUserLogEN.LoginDate);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objUserLogEN.LoginTime);
if (clsUserLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserLog(用户日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_ObjectTable_LoginDate_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserLogEN objUserLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserLogEN == null) return "";
if (objUserLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLogEN.UserId);
}
 if (objUserLogEN.ObjectTable == null)
{
 sbCondition.AppendFormat(" and ObjectTable is null", objUserLogEN.ObjectTable);
}
else
{
 sbCondition.AppendFormat(" and ObjectTable = '{0}'", objUserLogEN.ObjectTable);
}
 if (objUserLogEN.LoginDate == null)
{
 sbCondition.AppendFormat(" and LoginDate is null", objUserLogEN.LoginDate);
}
else
{
 sbCondition.AppendFormat(" and LoginDate = '{0}'", objUserLogEN.LoginDate);
}
 if (objUserLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null", objUserLogEN.LoginTime);
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objUserLogEN.LoginTime);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLogEN.UserId);
 sbCondition.AppendFormat(" and ObjectTable = '{0}'", objUserLogEN.ObjectTable);
 sbCondition.AppendFormat(" and LoginDate = '{0}'", objUserLogEN.LoginDate);
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objUserLogEN.LoginTime);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户日志(UserLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserLogBL
{
public static RelatedActions_UserLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserLogDA UserLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserLogDA();
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
 public clsUserLogBL()
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
if (string.IsNullOrEmpty(clsUserLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserLogEN._ConnectString);
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
public static DataTable GetDataTable_UserLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserLogDA.GetDataTable_UserLog(strWhereCond);
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
objDT = UserLogDA.GetDataTable(strWhereCond);
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
objDT = UserLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserLogDA.GetDataTable_Top(objTopPara);
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
objDT = UserLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsUserLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
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
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsUserLogEN._CurrTabName);
List<clsUserLogEN> arrUserLogObjLstCache = GetObjLstCache();
IEnumerable <clsUserLogEN> arrUserLogObjLst_Sel =
arrUserLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrUserLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserLogEN> GetObjLst(string strWhereCond)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
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
public static List<clsUserLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserLogEN> GetSubObjLstCache(clsUserLogEN objUserLogCond)
{
List<clsUserLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserLog._AttributeName)
{
if (objUserLogCond.IsUpdated(strFldName) == false) continue;
if (objUserLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserLogCond[strFldName].ToString());
}
else
{
if (objUserLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserLogCond[strFldName]));
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
public static List<clsUserLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
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
public static List<clsUserLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
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
List<clsUserLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
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
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
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
public static List<clsUserLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
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
public static List<clsUserLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserLog(ref clsUserLogEN objUserLogEN)
{
bool bolResult = UserLogDA.GetUserLog(ref objUserLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserLogEN GetObjBymId(long lngmId)
{
clsUserLogEN objUserLogEN = UserLogDA.GetObjBymId(lngmId);
return objUserLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserLogEN objUserLogEN = UserLogDA.GetFirstObj(strWhereCond);
 return objUserLogEN;
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
public static clsUserLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserLogEN objUserLogEN = UserLogDA.GetObjByDataRow(objRow);
 return objUserLogEN;
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
public static clsUserLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserLogEN objUserLogEN = UserLogDA.GetObjByDataRow(objRow);
 return objUserLogEN;
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
 /// <param name = "lstUserLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserLogEN GetObjBymIdFromList(long lngmId, List<clsUserLogEN> lstUserLogObjLst)
{
foreach (clsUserLogEN objUserLogEN in lstUserLogObjLst)
{
if (objUserLogEN.mId == lngmId)
{
return objUserLogEN;
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
 lngmId = new clsUserLogDA().GetFirstID(strWhereCond);
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
 arrList = UserLogDA.GetID(strWhereCond);
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
bool bolIsExist = UserLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = UserLogDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsUserLogEN objUserLogEN = clsUserLogBL.GetObjBymId(lngmId);
objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsUserLogBL.UpdateBySql2(objUserLogEN);
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
 bolIsExist = clsUserLogDA.IsExistTable();
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
 bolIsExist = UserLogDA.IsExistTable(strTabName);
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserLogEN objUserLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecordBySql2)", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserLogDA.AddNewRecordBySQL2(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserLogEN objUserLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],对象表 = [{1}],登陆日期 = [{2}],登陆时间 = [{3}]的数据已经存在!(in clsUserLogBL.AddNewRecordBySql2WithReturnKey)", objUserLogEN.UserId,objUserLogEN.ObjectTable,objUserLogEN.LoginDate,objUserLogEN.LoginTime);
throw new Exception(strMsg);
}
try
{
string strKey = UserLogDA.AddNewRecordBySQL2WithReturnKey(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserLogEN objUserLogEN)
{
try
{
bool bolResult = UserLogDA.Update(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserLogEN objUserLogEN)
{
 if (objUserLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserLogDA.UpdateBySql2(objUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserLogBL.ReFreshCache();

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
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
 clsUserLogEN objUserLogEN = clsUserLogBL.GetObjBymId(lngmId);

if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLogEN.mId, "SetUpdDate");
}
if (objUserLogEN != null)
{
int intRecNum = UserLogDA.DelRecord(lngmId);
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
objSQL = clsUserLogDA.GetSpecSQLObj();
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
//删除与表:[UserLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserLog.mId,
//lngmId);
//        clsUserLogBL.DelUserLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DelRecordBySign)
 /// </summary>
 /// <param name = "arrMId">给定的关键字列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecordBySign(List<long> arrMId)
{
try
{
if (clsUserLogBL.relatedActions != null)
{
foreach (var lngmId in arrMId)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum_Total = 0;
arrMId.ForEach((x) =>
{
int intRecNum = UserLogDA.DelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000077)根据标志删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:恢复被删除的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrMId">给定的关键字列表</param>
 /// <returns>返回恢复删除的记录数</returns>
public static int UnDelRecordBySign(List<long> arrMId)
{
try
{
int intRecNum_Total = 0;
arrMId.ForEach((x) =>
{
int intRecNum = UserLogDA.UnDelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
if (clsUserLogBL.relatedActions != null)
{
foreach (var lngmId in arrMId)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000078)恢复被删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
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
if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = UserLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelUserLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsUserLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = UserLogDA.DelUserLog(arrmIdLst);
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
public static int DelUserLogsByCond(string strWhereCond)
{
try
{
if (clsUserLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = UserLogDA.DelUserLog(strWhereCond);
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
 /// 功能:删除满足条件的多条记录.(带事务处理)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCondWithTransaction)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public static bool DelUserLogsByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = UserLogDA.DelUserLogWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000044)删除带条件表记录出错!(同时处理事务)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserLogDA.GetSpecSQLObj();
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
//删除与表:[UserLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
 public static void CopyTo(clsUserLogEN objUserLogENS, clsUserLogEN objUserLogENT)
{
try
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT.IsDeleted = objUserLogENS.IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT.DeletedDate = objUserLogENS.DeletedDate; //删除日期
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
 /// <param name = "objUserLogEN">源简化对象</param>
 public static void SetUpdFlag(clsUserLogEN objUserLogEN)
{
try
{
objUserLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.mId = objUserLogEN.mId; //mId
}
if (arrFldSet.Contains(conUserLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.UserId = objUserLogEN.UserId == "[null]" ? null :  objUserLogEN.UserId; //用户Id
}
if (arrFldSet.Contains(conUserLog.LoginTime, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.LoginTime = objUserLogEN.LoginTime == "[null]" ? null :  objUserLogEN.LoginTime; //登陆时间
}
if (arrFldSet.Contains(conUserLog.LoginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.LoginDate = objUserLogEN.LoginDate == "[null]" ? null :  objUserLogEN.LoginDate; //登陆日期
}
if (arrFldSet.Contains(conUserLog.UserIp, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.UserIp = objUserLogEN.UserIp == "[null]" ? null :  objUserLogEN.UserIp; //用户IP
}
if (arrFldSet.Contains(conUserLog.ObjectTable, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.ObjectTable = objUserLogEN.ObjectTable == "[null]" ? null :  objUserLogEN.ObjectTable; //对象表
}
if (arrFldSet.Contains(conUserLog.UsedValue, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.UsedValue = objUserLogEN.UsedValue == "[null]" ? null :  objUserLogEN.UsedValue; //使用值
}
if (arrFldSet.Contains(conUserLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.UpdDate = objUserLogEN.UpdDate == "[null]" ? null :  objUserLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.Memo = objUserLogEN.Memo == "[null]" ? null :  objUserLogEN.Memo; //说明
}
if (arrFldSet.Contains(conUserLog.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.IsDeleted = objUserLogEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(conUserLog.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.OrderNum = objUserLogEN.OrderNum; //序号
}
if (arrFldSet.Contains(conUserLog.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserLogEN.DeletedDate = objUserLogEN.DeletedDate == "[null]" ? null :  objUserLogEN.DeletedDate; //删除日期
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
 /// <param name = "objUserLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserLogEN objUserLogEN)
{
try
{
if (objUserLogEN.UserId == "[null]") objUserLogEN.UserId = null; //用户Id
if (objUserLogEN.LoginTime == "[null]") objUserLogEN.LoginTime = null; //登陆时间
if (objUserLogEN.LoginDate == "[null]") objUserLogEN.LoginDate = null; //登陆日期
if (objUserLogEN.UserIp == "[null]") objUserLogEN.UserIp = null; //用户IP
if (objUserLogEN.ObjectTable == "[null]") objUserLogEN.ObjectTable = null; //对象表
if (objUserLogEN.UsedValue == "[null]") objUserLogEN.UsedValue = null; //使用值
if (objUserLogEN.UpdDate == "[null]") objUserLogEN.UpdDate = null; //修改日期
if (objUserLogEN.Memo == "[null]") objUserLogEN.Memo = null; //说明
if (objUserLogEN.DeletedDate == "[null]") objUserLogEN.DeletedDate = null; //删除日期
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
public static void CheckPropertyNew(clsUserLogEN objUserLogEN)
{
 UserLogDA.CheckPropertyNew(objUserLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserLogEN objUserLogEN)
{
 UserLogDA.CheckProperty4Condition(objUserLogEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conUserLog.mId); 
List<clsUserLogEN> arrObjLst = clsUserLogBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsUserLogEN objUserLogEN = new clsUserLogEN()
{
mId = 0,
UserId = "选[用户日志]..."
};
arrObjLst.Insert(0, objUserLogEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conUserLog.mId;
objComboBox.DisplayMember = conUserLog.UserId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户日志]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conUserLog.mId); 
IEnumerable<clsUserLogEN> arrObjLst = clsUserLogBL.GetObjLst(strCondition);
objDDL.DataValueField = conUserLog.mId;
objDDL.DataTextField = conUserLog.UserId;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户日志]...","0");
List<clsUserLogEN> arrUserLogObjLst = GetAllUserLogObjLstCache(); 
arrUserLogObjLst = arrUserLogObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conUserLog.mId;
objDDL.DataTextField = conUserLog.UserId;
objDDL.DataSource = arrUserLogObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsUserLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserLogBL没有刷新缓存机制(clsUserLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserLogObjLstCache == null)
//{
//arrUserLogObjLstCache = UserLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUserLogEN._CurrTabName);
List<clsUserLogEN> arrUserLogObjLstCache = GetObjLstCache();
IEnumerable <clsUserLogEN> arrUserLogObjLst_Sel =
arrUserLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrUserLogObjLst_Sel.Count() == 0)
{
   clsUserLogEN obj = clsUserLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUserLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsUserLogEN objUserLog = GetObjBymIdCache(lngmId);
if (objUserLog == null) return "";
return objUserLog.UserId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsUserLogEN objUserLog = GetObjBymIdCache(lngmId);
if (objUserLog == null) return "";
return objUserLog.UserId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserLogEN> GetAllUserLogObjLstCache()
{
//获取缓存中的对象列表
List<clsUserLogEN> arrUserLogObjLstCache = GetObjLstCache(); 
return arrUserLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUserLogEN._CurrTabName);
List<clsUserLogEN> arrUserLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserLogObjLstCache;
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
string strKey = string.Format("{0}", clsUserLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserLogEN._RefreshTimeLst.Count == 0) return "";
return clsUserLogEN._RefreshTimeLst[clsUserLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsUserLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserLog(用户日志)
 /// 唯一性条件:UserId_ObjectTable_LoginDate_LoginTime
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserLogEN objUserLogEN)
{
//检测记录是否存在
string strResult = UserLogDA.GetUniCondStr(objUserLogEN);
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
if (strInFldName != conUserLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserLog._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserLog._AttributeName));
throw new Exception(strMsg);
}
var objUserLog = clsUserLogBL.GetObjBymIdCache(lngmId);
if (objUserLog == null) return "";
return objUserLog[strOutFldName].ToString();
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
int intRecCount = clsUserLogDA.GetRecCount(strTabName);
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
int intRecCount = clsUserLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserLogDA.GetRecCount();
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
int intRecCount = clsUserLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserLogEN objUserLogCond)
{
List<clsUserLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserLog._AttributeName)
{
if (objUserLogCond.IsUpdated(strFldName) == false) continue;
if (objUserLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserLogCond[strFldName].ToString());
}
else
{
if (objUserLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserLogCond[strFldName]));
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
 List<string> arrList = clsUserLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserLogDA.SetFldValue(clsUserLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**登陆时间*/ 
 strCreateTabCode.Append(" LoginTime varchar(6) Null, "); 
 // /**登陆日期*/ 
 strCreateTabCode.Append(" LoginDate varchar(8) Null, "); 
 // /**用户IP*/ 
 strCreateTabCode.Append(" UserIp varchar(40) Null, "); 
 // /**对象表*/ 
 strCreateTabCode.Append(" ObjectTable varchar(50) Null, "); 
 // /**使用值*/ 
 strCreateTabCode.Append(" UsedValue varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" IsDeleted bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" DeletedDate varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conUserLog.OrderNum); 
List<clsUserLogEN> arrUserLogObjList = new clsUserLogDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsUserLogEN objUserLog in arrUserLogObjList)
{
objUserLog.OrderNum = intIndex;
UpdateBySql2(objUserLog);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsUserLogEN objUserLog = clsUserLogBL.GetObjBymId(lngmId);

intOrderNum = objUserLog.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsUserLogBL.GetRecCountByCond(clsUserLogEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conUserLog.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsUserLogBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsUserLogBL.SetFldValue(clsUserLogEN._CurrTabName, conUserLog.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conUserLog.mId, lngmId));
clsUserLogBL.SetFldValue(clsUserLogEN._CurrTabName, conUserLog.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conUserLog.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
strCondition.AppendFormat(" {0} = {1}", conUserLog.OrderNum, intOrderNum + 1);

lngNextmId = clsUserLogBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsUserLogBL.SetFldValue(clsUserLogEN._CurrTabName, conUserLog.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conUserLog.mId, lngmId));
clsUserLogBL.SetFldValue(clsUserLogEN._CurrTabName, conUserLog.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conUserLog.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsUserLogBL.ReFreshCache();
if (clsUserLogBL.relatedActions != null)
{
clsUserLogBL.relatedActions.UpdRelaTabDate(objUserLog.mId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conUserLog.mId, strKeyList);
List<clsUserLogEN> arrUserLogLst = GetObjLst(strCondition);
foreach (clsUserLogEN objUserLog in arrUserLogLst)
{
objUserLog.OrderNum = objUserLog.OrderNum + 10000;
UpdateBySql2(objUserLog);
}
strCondition = string.Format("1 = 1 order by {0} ", conUserLog.OrderNum); 
List<clsUserLogEN> arrUserLogObjList = new clsUserLogDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsUserLogEN objUserLog in arrUserLogObjList)
{
objUserLog.OrderNum = intIndex;
UpdateBySql2(objUserLog);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conUserLog.mId, strKeyList);
List<clsUserLogEN> arrUserLogLst = GetObjLst(strCondition);
foreach (clsUserLogEN objUserLog in arrUserLogLst)
{
objUserLog.OrderNum = objUserLog.OrderNum - 10000;
UpdateBySql2(objUserLog);
}
strCondition = string.Format("1 = 1 order by {0} ", conUserLog.OrderNum); 
List<clsUserLogEN> arrUserLogObjList = new clsUserLogDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsUserLogEN objUserLog in arrUserLogObjList)
{
objUserLog.OrderNum = intIndex;
UpdateBySql2(objUserLog);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 用户日志(UserLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserLog : clsCommFun4BL
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
clsUserLogBL.ReFreshThisCache();
}
}

}