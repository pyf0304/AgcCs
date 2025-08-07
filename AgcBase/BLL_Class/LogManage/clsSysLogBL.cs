
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysLogBL
 表名:SysLog(00050129)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsSysLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysLogEN GetObj(this K_mId_SysLog myKey)
{
clsSysLogEN objSysLogEN = clsSysLogBL.SysLogDA.GetObjBymId(myKey.Value);
return objSysLogEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysLogEN objSysLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],操作日期 = [{1}],操作时间 = [{2}],工程Id = [{3}]的数据已经存在!(in clsSysLogBL.AddNewRecord)", objSysLogEN.UserId,objSysLogEN.OpDate,objSysLogEN.OpTime,objSysLogEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSysLogBL.SysLogDA.AddNewRecordBySQL2(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysLogEN objSysLogEN, bool bolIsNeedCheckUniqueness = true)
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
objSysLogEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysLogEN.CheckUniqueness() == false)
{
strMsg = string.Format("(用户Id(UserId)=[{0}],操作日期(OpDate)=[{1}],操作时间(OpTime)=[{2}],工程Id(PrjId)=[{3}])已经存在,不能重复!", objSysLogEN.UserId, objSysLogEN.OpDate, objSysLogEN.OpTime, objSysLogEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSysLogEN.AddNewRecord();
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysLogEN objSysLogEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysLogEN) == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],操作日期 = [{1}],操作时间 = [{2}],工程Id = [{3}]的数据已经存在!(in clsSysLogBL.AddNewRecordWithReturnKey)", objSysLogEN.UserId,objSysLogEN.OpDate,objSysLogEN.OpTime,objSysLogEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsSysLogBL.SysLogDA.AddNewRecordBySQL2WithReturnKey(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetmId(this clsSysLogEN objSysLogEN, long lngmId, string strComparisonOp="")
	{
objSysLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.mId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.mId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.mId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetLoginTime(this clsSysLogEN objSysLogEN, string strLoginTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginTime, 6, conSysLog.LoginTime);
}
objSysLogEN.LoginTime = strLoginTime; //登陆时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.LoginTime) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.LoginTime, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.LoginTime] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetLoginDate(this clsSysLogEN objSysLogEN, string strLoginDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLoginDate, 8, conSysLog.LoginDate);
}
objSysLogEN.LoginDate = strLoginDate; //登陆日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.LoginDate) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.LoginDate, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.LoginDate] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetTableName(this clsSysLogEN objSysLogEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, conSysLog.TableName);
}
objSysLogEN.TableName = strTableName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.TableName) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.TableName, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.TableName] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetTableKey(this clsSysLogEN objSysLogEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 100, conSysLog.TableKey);
}
objSysLogEN.TableKey = strTableKey; //数据表关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.TableKey) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.TableKey, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.TableKey] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetUserIp(this clsSysLogEN objSysLogEN, string strUserIp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserIp, 40, conSysLog.UserIp);
}
objSysLogEN.UserIp = strUserIp; //用户IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.UserIp) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.UserIp, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.UserIp] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpTypeId(this clsSysLogEN objSysLogEN, string strOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOpTypeId, conSysLog.OpTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpTypeId, 4, conSysLog.OpTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOpTypeId, 4, conSysLog.OpTypeId);
}
objSysLogEN.OpTypeId = strOpTypeId; //操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpTypeId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpTypeId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpTypeId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpContent(this clsSysLogEN objSysLogEN, string strOpContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpContent, 1000, conSysLog.OpContent);
}
objSysLogEN.OpContent = strOpContent; //操作内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpContent) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpContent, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpContent] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpDate(this clsSysLogEN objSysLogEN, string strOpDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpDate, 8, conSysLog.OpDate);
}
objSysLogEN.OpDate = strOpDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpDate) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpDate, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpDate] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetOpTime(this clsSysLogEN objSysLogEN, string strOpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOpTime, 6, conSysLog.OpTime);
}
objSysLogEN.OpTime = strOpTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.OpTime) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.OpTime, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.OpTime] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetPrjId(this clsSysLogEN objSysLogEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSysLog.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSysLog.PrjId);
}
objSysLogEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.PrjId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.PrjId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.PrjId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetUserId(this clsSysLogEN objSysLogEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conSysLog.UserId);
}
objSysLogEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.UserId) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.UserId, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.UserId] = strComparisonOp;
}
}
return objSysLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysLogEN SetMemo(this clsSysLogEN objSysLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysLog.Memo);
}
objSysLogEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysLogEN.dicFldComparisonOp.ContainsKey(conSysLog.Memo) == false)
{
objSysLogEN.dicFldComparisonOp.Add(conSysLog.Memo, strComparisonOp);
}
else
{
objSysLogEN.dicFldComparisonOp[conSysLog.Memo] = strComparisonOp;
}
}
return objSysLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysLogEN objSysLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysLogEN.CheckPropertyNew();
clsSysLogEN objSysLogCond = new clsSysLogEN();
string strCondition = objSysLogCond
.SetmId(objSysLogEN.mId, "<>")
.SetUserId(objSysLogEN.UserId, "=")
.SetOpDate(objSysLogEN.OpDate, "=")
.SetOpTime(objSysLogEN.OpTime, "=")
.SetPrjId(objSysLogEN.PrjId, "=")
.GetCombineCondition();
objSysLogEN._IsCheckProperty = true;
bool bolIsExist = clsSysLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserId_OpDate_OpTime_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysLogEN.Update();
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
 /// <param name = "objSysLog">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysLogEN objSysLog)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysLogEN objSysLogCond = new clsSysLogEN();
string strCondition = objSysLogCond
.SetUserId(objSysLog.UserId, "=")
.SetOpDate(objSysLog.OpDate, "=")
.SetOpTime(objSysLog.OpTime, "=")
.SetPrjId(objSysLog.PrjId, "=")
.GetCombineCondition();
objSysLog._IsCheckProperty = true;
bool bolIsExist = clsSysLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysLog.mId = clsSysLogBL.GetFirstID_S(strCondition);
objSysLog.UpdateWithCondition(strCondition);
}
else
{
objSysLog.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysLogEN objSysLogEN)
{
 if (objSysLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysLogBL.SysLogDA.UpdateBySql2(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysLogEN objSysLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysLogBL.SysLogDA.UpdateBySql2(objSysLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysLogEN objSysLogEN, string strWhereCond)
{
try
{
bool bolResult = clsSysLogBL.SysLogDA.UpdateBySqlWithCondition(objSysLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysLogEN objSysLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysLogBL.SysLogDA.UpdateBySqlWithConditionTransaction(objSysLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
public static int Delete(this clsSysLogEN objSysLogEN)
{
try
{
int intRecNum = clsSysLogBL.SysLogDA.DelRecord(objSysLogEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogENS">源对象</param>
 /// <param name = "objSysLogENT">目标对象</param>
 public static void CopyTo(this clsSysLogEN objSysLogENS, clsSysLogEN objSysLogENT)
{
try
{
objSysLogENT.mId = objSysLogENS.mId; //mId
objSysLogENT.LoginTime = objSysLogENS.LoginTime; //登陆时间
objSysLogENT.LoginDate = objSysLogENS.LoginDate; //登陆日期
objSysLogENT.TableName = objSysLogENS.TableName; //表名
objSysLogENT.TableKey = objSysLogENS.TableKey; //数据表关键字值
objSysLogENT.UserIp = objSysLogENS.UserIp; //用户IP
objSysLogENT.OpTypeId = objSysLogENS.OpTypeId; //操作类型Id
objSysLogENT.OpContent = objSysLogENS.OpContent; //操作内容
objSysLogENT.OpDate = objSysLogENS.OpDate; //操作日期
objSysLogENT.OpTime = objSysLogENS.OpTime; //操作时间
objSysLogENT.PrjId = objSysLogENS.PrjId; //工程Id
objSysLogENT.UserId = objSysLogENS.UserId; //用户Id
objSysLogENT.Memo = objSysLogENS.Memo; //说明
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
 /// <param name = "objSysLogENS">源对象</param>
 /// <returns>目标对象=>clsSysLogEN:objSysLogENT</returns>
 public static clsSysLogEN CopyTo(this clsSysLogEN objSysLogENS)
{
try
{
 clsSysLogEN objSysLogENT = new clsSysLogEN()
{
mId = objSysLogENS.mId, //mId
LoginTime = objSysLogENS.LoginTime, //登陆时间
LoginDate = objSysLogENS.LoginDate, //登陆日期
TableName = objSysLogENS.TableName, //表名
TableKey = objSysLogENS.TableKey, //数据表关键字值
UserIp = objSysLogENS.UserIp, //用户IP
OpTypeId = objSysLogENS.OpTypeId, //操作类型Id
OpContent = objSysLogENS.OpContent, //操作内容
OpDate = objSysLogENS.OpDate, //操作日期
OpTime = objSysLogENS.OpTime, //操作时间
PrjId = objSysLogENS.PrjId, //工程Id
UserId = objSysLogENS.UserId, //用户Id
Memo = objSysLogENS.Memo, //说明
};
 return objSysLogENT;
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
public static void CheckPropertyNew(this clsSysLogEN objSysLogEN)
{
 clsSysLogBL.SysLogDA.CheckPropertyNew(objSysLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysLogEN objSysLogEN)
{
 clsSysLogBL.SysLogDA.CheckProperty4Condition(objSysLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysLogEN objSysLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysLogCond.IsUpdated(conSysLog.mId) == true)
{
string strComparisonOpmId = objSysLogCond.dicFldComparisonOp[conSysLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSysLog.mId, objSysLogCond.mId, strComparisonOpmId);
}
if (objSysLogCond.IsUpdated(conSysLog.LoginTime) == true)
{
string strComparisonOpLoginTime = objSysLogCond.dicFldComparisonOp[conSysLog.LoginTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.LoginTime, objSysLogCond.LoginTime, strComparisonOpLoginTime);
}
if (objSysLogCond.IsUpdated(conSysLog.LoginDate) == true)
{
string strComparisonOpLoginDate = objSysLogCond.dicFldComparisonOp[conSysLog.LoginDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.LoginDate, objSysLogCond.LoginDate, strComparisonOpLoginDate);
}
if (objSysLogCond.IsUpdated(conSysLog.TableName) == true)
{
string strComparisonOpTableName = objSysLogCond.dicFldComparisonOp[conSysLog.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.TableName, objSysLogCond.TableName, strComparisonOpTableName);
}
if (objSysLogCond.IsUpdated(conSysLog.TableKey) == true)
{
string strComparisonOpTableKey = objSysLogCond.dicFldComparisonOp[conSysLog.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.TableKey, objSysLogCond.TableKey, strComparisonOpTableKey);
}
if (objSysLogCond.IsUpdated(conSysLog.UserIp) == true)
{
string strComparisonOpUserIp = objSysLogCond.dicFldComparisonOp[conSysLog.UserIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.UserIp, objSysLogCond.UserIp, strComparisonOpUserIp);
}
if (objSysLogCond.IsUpdated(conSysLog.OpTypeId) == true)
{
string strComparisonOpOpTypeId = objSysLogCond.dicFldComparisonOp[conSysLog.OpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpTypeId, objSysLogCond.OpTypeId, strComparisonOpOpTypeId);
}
if (objSysLogCond.IsUpdated(conSysLog.OpContent) == true)
{
string strComparisonOpOpContent = objSysLogCond.dicFldComparisonOp[conSysLog.OpContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpContent, objSysLogCond.OpContent, strComparisonOpOpContent);
}
if (objSysLogCond.IsUpdated(conSysLog.OpDate) == true)
{
string strComparisonOpOpDate = objSysLogCond.dicFldComparisonOp[conSysLog.OpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpDate, objSysLogCond.OpDate, strComparisonOpOpDate);
}
if (objSysLogCond.IsUpdated(conSysLog.OpTime) == true)
{
string strComparisonOpOpTime = objSysLogCond.dicFldComparisonOp[conSysLog.OpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.OpTime, objSysLogCond.OpTime, strComparisonOpOpTime);
}
if (objSysLogCond.IsUpdated(conSysLog.PrjId) == true)
{
string strComparisonOpPrjId = objSysLogCond.dicFldComparisonOp[conSysLog.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.PrjId, objSysLogCond.PrjId, strComparisonOpPrjId);
}
if (objSysLogCond.IsUpdated(conSysLog.UserId) == true)
{
string strComparisonOpUserId = objSysLogCond.dicFldComparisonOp[conSysLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.UserId, objSysLogCond.UserId, strComparisonOpUserId);
}
if (objSysLogCond.IsUpdated(conSysLog.Memo) == true)
{
string strComparisonOpMemo = objSysLogCond.dicFldComparisonOp[conSysLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysLog.Memo, objSysLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysLog(系统日志), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserId_OpDate_OpTime_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysLogEN objSysLogEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysLogEN == null) return true;
if (objSysLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objSysLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objSysLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
}
 if (objSysLogEN.OpDate == null)
{
 sbCondition.AppendFormat(" and OpDate is null", objSysLogEN.OpDate);
}
else
{
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
}
 if (objSysLogEN.OpTime == null)
{
 sbCondition.AppendFormat(" and OpTime is null", objSysLogEN.OpTime);
}
else
{
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
}
 if (objSysLogEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objSysLogEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
}
if (clsSysLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSysLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
if (clsSysLogBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysLog(系统日志), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_OpDate_OpTime_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysLogEN objSysLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysLogEN == null) return "";
if (objSysLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objSysLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objSysLogEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
}
 if (objSysLogEN.OpDate == null)
{
 sbCondition.AppendFormat(" and OpDate is null", objSysLogEN.OpDate);
}
else
{
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
}
 if (objSysLogEN.OpTime == null)
{
 sbCondition.AppendFormat(" and OpTime is null", objSysLogEN.OpTime);
}
else
{
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
}
 if (objSysLogEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null", objSysLogEN.PrjId);
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSysLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysLog
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 系统日志(SysLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysLogBL
{
public static RelatedActions_SysLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysLogDA SysLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysLogDA();
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
 public clsSysLogBL()
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
if (string.IsNullOrEmpty(clsSysLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysLogEN._ConnectString);
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
public static DataTable GetDataTable_SysLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysLogDA.GetDataTable_SysLog(strWhereCond);
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
objDT = SysLogDA.GetDataTable(strWhereCond);
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
objDT = SysLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysLogDA.GetDataTable_Top(objTopPara);
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
objDT = SysLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsSysLogEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
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
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysLogEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
List<clsSysLogEN> arrSysLogObjLstCache = GetObjLstCache();
IEnumerable <clsSysLogEN> arrSysLogObjLst_Sel =
arrSysLogObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrSysLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysLogEN> GetObjLst(string strWhereCond)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
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
public static List<clsSysLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysLogEN> GetSubObjLstCache(clsSysLogEN objSysLogCond)
{
List<clsSysLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysLog._AttributeName)
{
if (objSysLogCond.IsUpdated(strFldName) == false) continue;
if (objSysLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysLogCond[strFldName].ToString());
}
else
{
if (objSysLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysLogCond[strFldName]));
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
public static List<clsSysLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
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
public static List<clsSysLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
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
List<clsSysLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
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
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
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
public static List<clsSysLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
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
public static List<clsSysLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysLogEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysLog(ref clsSysLogEN objSysLogEN)
{
bool bolResult = SysLogDA.GetSysLog(ref objSysLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysLogEN GetObjBymId(long lngmId)
{
clsSysLogEN objSysLogEN = SysLogDA.GetObjBymId(lngmId);
return objSysLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysLogEN objSysLogEN = SysLogDA.GetFirstObj(strWhereCond);
 return objSysLogEN;
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
public static clsSysLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysLogEN objSysLogEN = SysLogDA.GetObjByDataRow(objRow);
 return objSysLogEN;
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
public static clsSysLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysLogEN objSysLogEN = SysLogDA.GetObjByDataRow(objRow);
 return objSysLogEN;
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
 /// <param name = "lstSysLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysLogEN GetObjBymIdFromList(long lngmId, List<clsSysLogEN> lstSysLogObjLst)
{
foreach (clsSysLogEN objSysLogEN in lstSysLogObjLst)
{
if (objSysLogEN.mId == lngmId)
{
return objSysLogEN;
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
 lngmId = new clsSysLogDA().GetFirstID(strWhereCond);
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
 arrList = SysLogDA.GetID(strWhereCond);
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
bool bolIsExist = SysLogDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = SysLogDA.IsExist(lngmId);
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
 bolIsExist = clsSysLogDA.IsExistTable();
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
 bolIsExist = SysLogDA.IsExistTable(strTabName);
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysLogEN objSysLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],操作日期 = [{1}],操作时间 = [{2}],工程Id = [{3}]的数据已经存在!(in clsSysLogBL.AddNewRecordBySql2)", objSysLogEN.UserId,objSysLogEN.OpDate,objSysLogEN.OpTime,objSysLogEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = SysLogDA.AddNewRecordBySQL2(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysLogEN objSysLogEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysLogEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!用户Id = [{0}],操作日期 = [{1}],操作时间 = [{2}],工程Id = [{3}]的数据已经存在!(in clsSysLogBL.AddNewRecordBySql2WithReturnKey)", objSysLogEN.UserId,objSysLogEN.OpDate,objSysLogEN.OpTime,objSysLogEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = SysLogDA.AddNewRecordBySQL2WithReturnKey(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysLogEN objSysLogEN)
{
try
{
bool bolResult = SysLogDA.Update(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysLogEN objSysLogEN)
{
 if (objSysLogEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysLogDA.UpdateBySql2(objSysLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysLogBL.ReFreshCache();

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
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
 clsSysLogEN objSysLogEN = clsSysLogBL.GetObjBymId(lngmId);

if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(objSysLogEN.mId, "SetUpdDate");
}
if (objSysLogEN != null)
{
int intRecNum = SysLogDA.DelRecord(lngmId);
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
objSQL = clsSysLogDA.GetSpecSQLObj();
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
//删除与表:[SysLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysLog.mId,
//lngmId);
//        clsSysLogBL.DelSysLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsSysLogBL.relatedActions != null)
{
clsSysLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = SysLogDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelSysLogs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsSysLogBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsSysLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysLogDA.DelSysLog(arrmIdLst);
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
public static int DelSysLogsByCond(string strWhereCond)
{
try
{
if (clsSysLogBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsSysLogBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = SysLogDA.DelSysLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysLogDA.GetSpecSQLObj();
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
//删除与表:[SysLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysLogBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objSysLogENS">源对象</param>
 /// <param name = "objSysLogENT">目标对象</param>
 public static void CopyTo(clsSysLogEN objSysLogENS, clsSysLogEN objSysLogENT)
{
try
{
objSysLogENT.mId = objSysLogENS.mId; //mId
objSysLogENT.LoginTime = objSysLogENS.LoginTime; //登陆时间
objSysLogENT.LoginDate = objSysLogENS.LoginDate; //登陆日期
objSysLogENT.TableName = objSysLogENS.TableName; //表名
objSysLogENT.TableKey = objSysLogENS.TableKey; //数据表关键字值
objSysLogENT.UserIp = objSysLogENS.UserIp; //用户IP
objSysLogENT.OpTypeId = objSysLogENS.OpTypeId; //操作类型Id
objSysLogENT.OpContent = objSysLogENS.OpContent; //操作内容
objSysLogENT.OpDate = objSysLogENS.OpDate; //操作日期
objSysLogENT.OpTime = objSysLogENS.OpTime; //操作时间
objSysLogENT.PrjId = objSysLogENS.PrjId; //工程Id
objSysLogENT.UserId = objSysLogENS.UserId; //用户Id
objSysLogENT.Memo = objSysLogENS.Memo; //说明
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
 /// <param name = "objSysLogEN">源简化对象</param>
 public static void SetUpdFlag(clsSysLogEN objSysLogEN)
{
try
{
objSysLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysLog.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.mId = objSysLogEN.mId; //mId
}
if (arrFldSet.Contains(conSysLog.LoginTime, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.LoginTime = objSysLogEN.LoginTime == "[null]" ? null :  objSysLogEN.LoginTime; //登陆时间
}
if (arrFldSet.Contains(conSysLog.LoginDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.LoginDate = objSysLogEN.LoginDate == "[null]" ? null :  objSysLogEN.LoginDate; //登陆日期
}
if (arrFldSet.Contains(conSysLog.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.TableName = objSysLogEN.TableName == "[null]" ? null :  objSysLogEN.TableName; //表名
}
if (arrFldSet.Contains(conSysLog.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.TableKey = objSysLogEN.TableKey == "[null]" ? null :  objSysLogEN.TableKey; //数据表关键字值
}
if (arrFldSet.Contains(conSysLog.UserIp, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.UserIp = objSysLogEN.UserIp == "[null]" ? null :  objSysLogEN.UserIp; //用户IP
}
if (arrFldSet.Contains(conSysLog.OpTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.OpTypeId = objSysLogEN.OpTypeId; //操作类型Id
}
if (arrFldSet.Contains(conSysLog.OpContent, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.OpContent = objSysLogEN.OpContent == "[null]" ? null :  objSysLogEN.OpContent; //操作内容
}
if (arrFldSet.Contains(conSysLog.OpDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.OpDate = objSysLogEN.OpDate == "[null]" ? null :  objSysLogEN.OpDate; //操作日期
}
if (arrFldSet.Contains(conSysLog.OpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.OpTime = objSysLogEN.OpTime == "[null]" ? null :  objSysLogEN.OpTime; //操作时间
}
if (arrFldSet.Contains(conSysLog.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.PrjId = objSysLogEN.PrjId == "[null]" ? null :  objSysLogEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSysLog.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.UserId = objSysLogEN.UserId == "[null]" ? null :  objSysLogEN.UserId; //用户Id
}
if (arrFldSet.Contains(conSysLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysLogEN.Memo = objSysLogEN.Memo == "[null]" ? null :  objSysLogEN.Memo; //说明
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
 /// <param name = "objSysLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysLogEN objSysLogEN)
{
try
{
if (objSysLogEN.LoginTime == "[null]") objSysLogEN.LoginTime = null; //登陆时间
if (objSysLogEN.LoginDate == "[null]") objSysLogEN.LoginDate = null; //登陆日期
if (objSysLogEN.TableName == "[null]") objSysLogEN.TableName = null; //表名
if (objSysLogEN.TableKey == "[null]") objSysLogEN.TableKey = null; //数据表关键字值
if (objSysLogEN.UserIp == "[null]") objSysLogEN.UserIp = null; //用户IP
if (objSysLogEN.OpContent == "[null]") objSysLogEN.OpContent = null; //操作内容
if (objSysLogEN.OpDate == "[null]") objSysLogEN.OpDate = null; //操作日期
if (objSysLogEN.OpTime == "[null]") objSysLogEN.OpTime = null; //操作时间
if (objSysLogEN.PrjId == "[null]") objSysLogEN.PrjId = null; //工程Id
if (objSysLogEN.UserId == "[null]") objSysLogEN.UserId = null; //用户Id
if (objSysLogEN.Memo == "[null]") objSysLogEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSysLogEN objSysLogEN)
{
 SysLogDA.CheckPropertyNew(objSysLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysLogEN objSysLogEN)
{
 SysLogDA.CheckProperty4Condition(objSysLogEN);
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
if (clsSysLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysLogBL没有刷新缓存机制(clsSysLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSysLogObjLstCache == null)
//{
//arrSysLogObjLstCache = SysLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysLogEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
List<clsSysLogEN> arrSysLogObjLstCache = GetObjLstCache();
IEnumerable <clsSysLogEN> arrSysLogObjLst_Sel =
arrSysLogObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrSysLogObjLst_Sel.Count() == 0)
{
   clsSysLogEN obj = clsSysLogBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysLogEN> GetAllSysLogObjLstCache()
{
//获取缓存中的对象列表
List<clsSysLogEN> arrSysLogObjLstCache = GetObjLstCache(); 
return arrSysLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
List<clsSysLogEN> arrSysLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysLogObjLstCache;
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
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysLogEN._RefreshTimeLst.Count == 0) return "";
return clsSysLogEN._RefreshTimeLst[clsSysLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysLog(系统日志)
 /// 唯一性条件:UserId_OpDate_OpTime_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysLogEN objSysLogEN)
{
//检测记录是否存在
string strResult = SysLogDA.GetUniCondStr(objSysLogEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conSysLog.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysLog._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysLog._AttributeName));
throw new Exception(strMsg);
}
var objSysLog = clsSysLogBL.GetObjBymIdCache(lngmId);
if (objSysLog == null) return "";
return objSysLog[strOutFldName].ToString();
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
int intRecCount = clsSysLogDA.GetRecCount(strTabName);
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
int intRecCount = clsSysLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysLogDA.GetRecCount();
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
int intRecCount = clsSysLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysLogEN objSysLogCond)
{
List<clsSysLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysLog._AttributeName)
{
if (objSysLogCond.IsUpdated(strFldName) == false) continue;
if (objSysLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysLogCond[strFldName].ToString());
}
else
{
if (objSysLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysLogCond[strFldName]));
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
 List<string> arrList = clsSysLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysLogDA.SetFldValue(clsSysLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**登陆时间*/ 
 strCreateTabCode.Append(" LoginTime varchar(6) Null, "); 
 // /**登陆日期*/ 
 strCreateTabCode.Append(" LoginDate varchar(8) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TableName varchar(100) Null, "); 
 // /**数据表关键字值*/ 
 strCreateTabCode.Append(" TableKey varchar(100) Null, "); 
 // /**用户IP*/ 
 strCreateTabCode.Append(" UserIp varchar(40) Null, "); 
 // /**操作类型Id*/ 
 strCreateTabCode.Append(" OpTypeId char(4) not Null, "); 
 // /**操作内容*/ 
 strCreateTabCode.Append(" OpContent varchar(1000) Null, "); 
 // /**操作日期*/ 
 strCreateTabCode.Append(" OpDate varchar(8) Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OpTime varchar(6) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 系统日志(SysLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysLog : clsCommFun4BL
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
clsSysLogBL.ReFreshThisCache();
}
}

}