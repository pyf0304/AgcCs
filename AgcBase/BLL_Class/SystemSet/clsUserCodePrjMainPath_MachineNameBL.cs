
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPath_MachineNameBL
 表名:UserCodePrjMainPath_MachineName(00050614)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsUserCodePrjMainPath_MachineNameBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPath_MachineNameEN) == false)
{
var strMsg = string.Format("记录已经存在!生成主目录Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserCodePrjMainPath_MachineNameBL.AddNewRecord)", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.AddNewRecordBySQL2(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
public static bool AddRecordEx(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objUserCodePrjMainPath_MachineNameEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPath_MachineNameEN.CheckUniqueness() == false)
{
strMsg = string.Format("(生成主目录Id(UserCodePrjMainPathId)=[{0}],机器名(MachineName)=[{1}])已经存在,不能重复!", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserCodePrjMainPath_MachineNameEN.AddNewRecord();
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空.(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPath_MachineNameEN) == false)
{
var strMsg = string.Format("记录已经存在!生成主目录Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserCodePrjMainPath_MachineNameBL.AddNewRecord(SqlTransaction))", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.AddNewRecordBySQL2(objUserCodePrjMainPath_MachineNameEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPath_MachineNameEN) == false)
{
var strMsg = string.Format("记录已经存在!生成主目录Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserCodePrjMainPath_MachineNameBL.AddNewRecordWithReturnKey)", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUserCodePrjMainPathId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId);
}
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = strUserCodePrjMainPathId; //生成主目录Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetMachineName(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strMachineName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMachineName, 50, conUserCodePrjMainPath_MachineName.MachineName);
}
objUserCodePrjMainPath_MachineNameEN.MachineName = strMachineName; //机器名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.MachineName) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.MachineName, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.MachineName] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetCodePath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, conUserCodePrjMainPath_MachineName.CodePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePath, 200, conUserCodePrjMainPath_MachineName.CodePath);
}
objUserCodePrjMainPath_MachineNameEN.CodePath = strCodePath; //代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.CodePath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.CodePath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetGcPathId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strGcPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conUserCodePrjMainPath_MachineName.GcPathId);
}
objUserCodePrjMainPath_MachineNameEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.GcPathId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.GcPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.GcPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetCodePathBackup(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, conUserCodePrjMainPath_MachineName.CodePathBackup);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, conUserCodePrjMainPath_MachineName.CodePathBackup);
}
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = strCodePathBackup; //备份代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.CodePathBackup) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.CodePathBackup, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePathBackup] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetLogPath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strLogPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogPath, 150, conUserCodePrjMainPath_MachineName.LogPath);
}
objUserCodePrjMainPath_MachineNameEN.LogPath = strLogPath; //日志路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.LogPath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.LogPath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.LogPath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetIncludeXmlPath(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strIncludeXmlPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, conUserCodePrjMainPath_MachineName.IncludeXmlPath);
}
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = strIncludeXmlPath; //包含表Xml路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.IncludeXmlPath) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.IncludeXmlPath, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.IncludeXmlPath] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetPrjId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserCodePrjMainPath_MachineName.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserCodePrjMainPath_MachineName.PrjId);
}
objUserCodePrjMainPath_MachineNameEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.PrjId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.PrjId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.PrjId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUpdDate(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserCodePrjMainPath_MachineName.UpdDate);
}
objUserCodePrjMainPath_MachineNameEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UpdDate) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UpdDate, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdDate] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetUpdUserId(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserCodePrjMainPath_MachineName.UpdUserId);
}
objUserCodePrjMainPath_MachineNameEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.UpdUserId) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.UpdUserId, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdUserId] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPath_MachineNameEN SetMemo(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserCodePrjMainPath_MachineName.Memo);
}
objUserCodePrjMainPath_MachineNameEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath_MachineName.Memo) == false)
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp.Add(conUserCodePrjMainPath_MachineName.Memo, strComparisonOp);
}
else
{
objUserCodePrjMainPath_MachineNameEN.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.Memo] = strComparisonOp;
}
}
return objUserCodePrjMainPath_MachineNameEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserCodePrjMainPath_MachineNameEN.CheckPropertyNew();
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond = new clsUserCodePrjMainPath_MachineNameEN();
string strCondition = objUserCodePrjMainPath_MachineNameCond
.SetUserCodePrjMainPathId(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, "<>")
.SetUserCodePrjMainPathId(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, "=")
.SetMachineName(objUserCodePrjMainPath_MachineNameEN.MachineName, "=")
.GetCombineCondition();
objUserCodePrjMainPath_MachineNameEN._IsCheckProperty = true;
bool bolIsExist = clsUserCodePrjMainPath_MachineNameBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(UserCodePrjMainPathId_MachineName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserCodePrjMainPath_MachineNameEN.Update();
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
 /// <param name = "objUserCodePrjMainPath_MachineName">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond = new clsUserCodePrjMainPath_MachineNameEN();
string strCondition = objUserCodePrjMainPath_MachineNameCond
.SetUserCodePrjMainPathId(objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, "=")
.SetMachineName(objUserCodePrjMainPath_MachineName.MachineName, "=")
.GetCombineCondition();
objUserCodePrjMainPath_MachineName._IsCheckProperty = true;
bool bolIsExist = clsUserCodePrjMainPath_MachineNameBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserCodePrjMainPath_MachineName.UserCodePrjMainPathId = clsUserCodePrjMainPath_MachineNameBL.GetFirstID_S(strCondition);
objUserCodePrjMainPath_MachineName.UpdateWithCondition(strCondition);
}
else
{
objUserCodePrjMainPath_MachineName.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.UpdateBySql2(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.UpdateBySql2(objUserCodePrjMainPath_MachineNameEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.UpdateBySql2(objUserCodePrjMainPath_MachineNameEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strWhereCond)
{
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.UpdateBySqlWithCondition(objUserCodePrjMainPath_MachineNameEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.UpdateBySqlWithConditionTransaction(objUserCodePrjMainPath_MachineNameEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
try
{
int intRecNum = clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.DelRecord(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
 /// <param name = "objUserCodePrjMainPath_MachineNameENT">目标对象</param>
 public static void CopyTo(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS, clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT)
{
try
{
objUserCodePrjMainPath_MachineNameENT.UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPath_MachineNameENT.MachineName = objUserCodePrjMainPath_MachineNameENS.MachineName; //机器名
objUserCodePrjMainPath_MachineNameENT.CodePath = objUserCodePrjMainPath_MachineNameENS.CodePath; //代码路径
objUserCodePrjMainPath_MachineNameENT.GcPathId = objUserCodePrjMainPath_MachineNameENS.GcPathId; //GC路径Id
objUserCodePrjMainPath_MachineNameENT.CodePathBackup = objUserCodePrjMainPath_MachineNameENS.CodePathBackup; //备份代码路径
objUserCodePrjMainPath_MachineNameENT.LogPath = objUserCodePrjMainPath_MachineNameENS.LogPath; //日志路径
objUserCodePrjMainPath_MachineNameENT.IncludeXmlPath = objUserCodePrjMainPath_MachineNameENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPath_MachineNameENT.PrjId = objUserCodePrjMainPath_MachineNameENS.PrjId; //工程Id
objUserCodePrjMainPath_MachineNameENT.UpdDate = objUserCodePrjMainPath_MachineNameENS.UpdDate; //修改日期
objUserCodePrjMainPath_MachineNameENT.UpdUserId = objUserCodePrjMainPath_MachineNameENS.UpdUserId; //修改用户Id
objUserCodePrjMainPath_MachineNameENT.Memo = objUserCodePrjMainPath_MachineNameENS.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
 /// <returns>目标对象=>clsUserCodePrjMainPath_MachineNameEN:objUserCodePrjMainPath_MachineNameENT</returns>
 public static clsUserCodePrjMainPath_MachineNameEN CopyTo(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS)
{
try
{
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT = new clsUserCodePrjMainPath_MachineNameEN()
{
UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameENS.UserCodePrjMainPathId, //生成主目录Id
MachineName = objUserCodePrjMainPath_MachineNameENS.MachineName, //机器名
CodePath = objUserCodePrjMainPath_MachineNameENS.CodePath, //代码路径
GcPathId = objUserCodePrjMainPath_MachineNameENS.GcPathId, //GC路径Id
CodePathBackup = objUserCodePrjMainPath_MachineNameENS.CodePathBackup, //备份代码路径
LogPath = objUserCodePrjMainPath_MachineNameENS.LogPath, //日志路径
IncludeXmlPath = objUserCodePrjMainPath_MachineNameENS.IncludeXmlPath, //包含表Xml路径
PrjId = objUserCodePrjMainPath_MachineNameENS.PrjId, //工程Id
UpdDate = objUserCodePrjMainPath_MachineNameENS.UpdDate, //修改日期
UpdUserId = objUserCodePrjMainPath_MachineNameENS.UpdUserId, //修改用户Id
Memo = objUserCodePrjMainPath_MachineNameENS.Memo, //说明
};
 return objUserCodePrjMainPath_MachineNameENT;
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
public static void CheckPropertyNew(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 clsUserCodePrjMainPath_MachineNameBL.UserCodePrjMainPath_MachineNameDA.CheckProperty4Condition(objUserCodePrjMainPath_MachineNameEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId) == true)
{
string strComparisonOpUserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, objUserCodePrjMainPath_MachineNameCond.UserCodePrjMainPathId, strComparisonOpUserCodePrjMainPathId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.MachineName) == true)
{
string strComparisonOpMachineName = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.MachineName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.MachineName, objUserCodePrjMainPath_MachineNameCond.MachineName, strComparisonOpMachineName);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.CodePath) == true)
{
string strComparisonOpCodePath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.CodePath, objUserCodePrjMainPath_MachineNameCond.CodePath, strComparisonOpCodePath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.GcPathId) == true)
{
string strComparisonOpGcPathId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.GcPathId, objUserCodePrjMainPath_MachineNameCond.GcPathId, strComparisonOpGcPathId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.CodePathBackup) == true)
{
string strComparisonOpCodePathBackup = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.CodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.CodePathBackup, objUserCodePrjMainPath_MachineNameCond.CodePathBackup, strComparisonOpCodePathBackup);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.LogPath) == true)
{
string strComparisonOpLogPath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.LogPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.LogPath, objUserCodePrjMainPath_MachineNameCond.LogPath, strComparisonOpLogPath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.IncludeXmlPath) == true)
{
string strComparisonOpIncludeXmlPath = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.IncludeXmlPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.IncludeXmlPath, objUserCodePrjMainPath_MachineNameCond.IncludeXmlPath, strComparisonOpIncludeXmlPath);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.PrjId) == true)
{
string strComparisonOpPrjId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.PrjId, objUserCodePrjMainPath_MachineNameCond.PrjId, strComparisonOpPrjId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UpdDate, objUserCodePrjMainPath_MachineNameCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.UpdUserId, objUserCodePrjMainPath_MachineNameCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(conUserCodePrjMainPath_MachineName.Memo) == true)
{
string strComparisonOpMemo = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[conUserCodePrjMainPath_MachineName.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath_MachineName.Memo, objUserCodePrjMainPath_MachineNameCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:UserCodePrjMainPathId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPath_MachineNameEN == null) return true;
if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == null || objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
if (clsUserCodePrjMainPath_MachineNameBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
if (clsUserCodePrjMainPath_MachineNameBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserCodePrjMainPathId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPath_MachineNameEN == null) return "";
if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == null || objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and UserCodePrjMainPathId = '{0}'", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserCodePrjMainPath_MachineNameEN.MachineName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserCodePrjMainPath_MachineName
{
public virtual bool UpdRelaTabDate(string strUserCodePrjMainPathId,string strMachineName, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserCodePrjMainPath_MachineNameBL
{
public static RelatedActions_UserCodePrjMainPath_MachineName relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserCodePrjMainPath_MachineNameDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserCodePrjMainPath_MachineNameDA UserCodePrjMainPath_MachineNameDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserCodePrjMainPath_MachineNameDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsUserCodePrjMainPath_MachineNameBL()
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
if (string.IsNullOrEmpty(clsUserCodePrjMainPath_MachineNameEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPath_MachineNameEN._ConnectString);
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
public static DataTable GetDataTable_UserCodePrjMainPath_MachineName(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable_UserCodePrjMainPath_MachineName(strWhereCond);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable(strWhereCond);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable_Top(objTopPara);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserCodePrjMainPath_MachineNameDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检测记录是否存在
string strResult = "";
strResult += objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId;
strResult += "|" + objUserCodePrjMainPath_MachineNameEN.MachineName;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLst_Sel =
arrUserCodePrjMainPath_MachineNameObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrUserCodePrjMainPath_MachineNameObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLst(string strWhereCond)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserCodePrjMainPath_MachineNameEN> GetSubObjLstCache(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond)
{
 string strPrjId = objUserCodePrjMainPath_MachineNameCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsUserCodePrjMainPath_MachineNameBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePrjMainPath_MachineName._AttributeName)
{
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPath_MachineNameCond[strFldName].ToString());
}
else
{
if (objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPath_MachineNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePrjMainPath_MachineNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPath_MachineNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPath_MachineNameCond[strFldName]));
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
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
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
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
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLst = new List<clsUserCodePrjMainPath_MachineNameEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = new clsUserCodePrjMainPath_MachineNameEN();
try
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPath_MachineNameEN.MachineName = objRow[conUserCodePrjMainPath_MachineName.MachineName].ToString().Trim(); //机器名
objUserCodePrjMainPath_MachineNameEN.CodePath = objRow[conUserCodePrjMainPath_MachineName.CodePath].ToString().Trim(); //代码路径
objUserCodePrjMainPath_MachineNameEN.GcPathId = objRow[conUserCodePrjMainPath_MachineName.GcPathId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objRow[conUserCodePrjMainPath_MachineName.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePrjMainPath_MachineNameEN.LogPath = objRow[conUserCodePrjMainPath_MachineName.LogPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.LogPath].ToString().Trim(); //日志路径
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPath_MachineNameEN.PrjId = objRow[conUserCodePrjMainPath_MachineName.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPath_MachineNameEN.UpdDate = objRow[conUserCodePrjMainPath_MachineName.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objRow[conUserCodePrjMainPath_MachineName.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPath_MachineNameEN.Memo = objRow[conUserCodePrjMainPath_MachineName.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath_MachineName.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPath_MachineNameEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserCodePrjMainPath_MachineName(ref clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
bool bolResult = UserCodePrjMainPath_MachineNameDA.GetUserCodePrjMainPath_MachineName(ref objUserCodePrjMainPath_MachineNameEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLst(string strUserCodePrjMainPathId,string strMachineName)
{
if (strUserCodePrjMainPathId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strUserCodePrjMainPathId,strMachineName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strMachineName.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strUserCodePrjMainPathId,strMachineName]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strUserCodePrjMainPathId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMachineName) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strMachineName]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = UserCodePrjMainPath_MachineNameDA.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
return objUserCodePrjMainPath_MachineNameEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = UserCodePrjMainPath_MachineNameDA.GetFirstObj(strWhereCond);
 return objUserCodePrjMainPath_MachineNameEN;
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
public static clsUserCodePrjMainPath_MachineNameEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = UserCodePrjMainPath_MachineNameDA.GetObjByDataRow(objRow);
 return objUserCodePrjMainPath_MachineNameEN;
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
public static clsUserCodePrjMainPath_MachineNameEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = UserCodePrjMainPath_MachineNameDA.GetObjByDataRow(objRow);
 return objUserCodePrjMainPath_MachineNameEN;
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
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <param name = "lstUserCodePrjMainPath_MachineNameObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLstFromList(string strUserCodePrjMainPathId,string strMachineName, List<clsUserCodePrjMainPath_MachineNameEN> lstUserCodePrjMainPath_MachineNameObjLst)
{
foreach (clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN in lstUserCodePrjMainPath_MachineNameObjLst)
{
if (objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId == strUserCodePrjMainPathId 
 && objUserCodePrjMainPath_MachineNameEN.MachineName == strMachineName 
)
{
return objUserCodePrjMainPath_MachineNameEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strUserCodePrjMainPathId;
 try
 {
 strUserCodePrjMainPathId = new clsUserCodePrjMainPath_MachineNameDA().GetFirstID(strWhereCond);
 return strUserCodePrjMainPathId;
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
 arrList = UserCodePrjMainPath_MachineNameDA.GetID(strWhereCond);
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
bool bolIsExist = UserCodePrjMainPath_MachineNameDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserCodePrjMainPathId,string strMachineName)
{
//检测记录是否存在
bool bolIsExist = UserCodePrjMainPath_MachineNameDA.IsExist(strUserCodePrjMainPathId,strMachineName);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
/// <param name = "strMachineName">机器名</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserCodePrjMainPathId , string strMachineName, string strOpUser)
{
clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
objUserCodePrjMainPath_MachineNameEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserCodePrjMainPath_MachineNameEN.UpdUserId = strOpUser;
return clsUserCodePrjMainPath_MachineNameBL.UpdateBySql2(objUserCodePrjMainPath_MachineNameEN);
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
 bolIsExist = clsUserCodePrjMainPath_MachineNameDA.IsExistTable();
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
 bolIsExist = UserCodePrjMainPath_MachineNameDA.IsExistTable(strTabName);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPath_MachineNameEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!生成主目录Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserCodePrjMainPath_MachineNameBL.AddNewRecordBySql2)", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserCodePrjMainPath_MachineNameDA.AddNewRecordBySQL2(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsUserCodePrjMainPath_MachineNameBL.IsExist(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPath_MachineNameEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!生成主目录Id = [{0}],机器名 = [{1}]的数据已经存在!(in clsUserCodePrjMainPath_MachineNameBL.AddNewRecordBySql2WithReturnKey)", objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName);
throw new Exception(strMsg);
}
try
{
string strKey = UserCodePrjMainPath_MachineNameDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
try
{
bool bolResult = UserCodePrjMainPath_MachineNameDA.Update(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserCodePrjMainPath_MachineNameDA.UpdateBySql2(objUserCodePrjMainPath_MachineNameEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPath_MachineNameBL.ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strUserCodePrjMainPathId,string strMachineName)
{
try
{
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);

if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId,objUserCodePrjMainPath_MachineNameEN.MachineName, objUserCodePrjMainPath_MachineNameEN.UpdUserId);
}
if (objUserCodePrjMainPath_MachineNameEN != null)
{
int intRecNum = UserCodePrjMainPath_MachineNameDA.DelRecord(strUserCodePrjMainPathId,strMachineName);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
/// <param name="strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strUserCodePrjMainPathId,string strMachineName , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
//删除与表:[UserCodePrjMainPath_MachineName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId,
//strUserCodePrjMainPathId);
//        clsUserCodePrjMainPath_MachineNameBL.DelUserCodePrjMainPath_MachineNamesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePrjMainPath_MachineNameBL.DelRecord(strUserCodePrjMainPathId,strMachineName, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePrjMainPath_MachineNameBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strUserCodePrjMainPathId,string strMachineName, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId,strMachineName, "UpdRelaTabDate");
}
bool bolResult = UserCodePrjMainPath_MachineNameDA.DelRecord(strUserCodePrjMainPathId,strMachineName,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrUserCodePrjMainPathIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strUserCodePrjMainPathId;
string strMachineName;
if (clsUserCodePrjMainPath_MachineNameBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strUserCodePrjMainPathId = sstrKey[0];
strMachineName = sstrKey[1];
clsUserCodePrjMainPath_MachineNameBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId,strMachineName, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strUserCodePrjMainPathId = sstrKey[0];
strMachineName = sstrKey[1];
 clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
int intDelRecNum = UserCodePrjMainPath_MachineNameDA.DelRecKeyLsts(arrKeyLsts);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePrjMainPath_MachineNameEN.PrjId);
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
public static int DelUserCodePrjMainPath_MachineNamesByCond(string strWhereCond)
{
try
{
List<string> arrPrjId = GetFldValue(conUserCodePrjMainPath_MachineName.PrjId, strWhereCond);
int intRecNum = UserCodePrjMainPath_MachineNameDA.DelUserCodePrjMainPath_MachineName(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
public static bool DelUserCodePrjMainPath_MachineNamesByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = UserCodePrjMainPath_MachineNameDA.DelUserCodePrjMainPath_MachineNameWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserCodePrjMainPath_MachineName]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserCodePrjMainPathId,string strMachineName, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePrjMainPath_MachineNameDA.GetSpecSQLObj();
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
//删除与表:[UserCodePrjMainPath_MachineName]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePrjMainPath_MachineNameBL.DelRecord(strUserCodePrjMainPathId,strMachineName, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePrjMainPath_MachineNameBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strUserCodePrjMainPathId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUserCodePrjMainPath_MachineNameENS">源对象</param>
 /// <param name = "objUserCodePrjMainPath_MachineNameENT">目标对象</param>
 public static void CopyTo(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENS, clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameENT)
{
try
{
objUserCodePrjMainPath_MachineNameENT.UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPath_MachineNameENT.MachineName = objUserCodePrjMainPath_MachineNameENS.MachineName; //机器名
objUserCodePrjMainPath_MachineNameENT.CodePath = objUserCodePrjMainPath_MachineNameENS.CodePath; //代码路径
objUserCodePrjMainPath_MachineNameENT.GcPathId = objUserCodePrjMainPath_MachineNameENS.GcPathId; //GC路径Id
objUserCodePrjMainPath_MachineNameENT.CodePathBackup = objUserCodePrjMainPath_MachineNameENS.CodePathBackup; //备份代码路径
objUserCodePrjMainPath_MachineNameENT.LogPath = objUserCodePrjMainPath_MachineNameENS.LogPath; //日志路径
objUserCodePrjMainPath_MachineNameENT.IncludeXmlPath = objUserCodePrjMainPath_MachineNameENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPath_MachineNameENT.PrjId = objUserCodePrjMainPath_MachineNameENS.PrjId; //工程Id
objUserCodePrjMainPath_MachineNameENT.UpdDate = objUserCodePrjMainPath_MachineNameENS.UpdDate; //修改日期
objUserCodePrjMainPath_MachineNameENT.UpdUserId = objUserCodePrjMainPath_MachineNameENS.UpdUserId; //修改用户Id
objUserCodePrjMainPath_MachineNameENT.Memo = objUserCodePrjMainPath_MachineNameENS.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">源简化对象</param>
 public static void SetUpdFlag(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
try
{
objUserCodePrjMainPath_MachineNameEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserCodePrjMainPath_MachineNameEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId = objUserCodePrjMainPath_MachineNameEN.UserCodePrjMainPathId; //生成主目录Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.MachineName, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.MachineName = objUserCodePrjMainPath_MachineNameEN.MachineName; //机器名
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.CodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.CodePath = objUserCodePrjMainPath_MachineNameEN.CodePath; //代码路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.GcPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.GcPathId = objUserCodePrjMainPath_MachineNameEN.GcPathId == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.GcPathId; //GC路径Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.CodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.CodePathBackup = objUserCodePrjMainPath_MachineNameEN.CodePathBackup; //备份代码路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.LogPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.LogPath = objUserCodePrjMainPath_MachineNameEN.LogPath == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.LogPath; //日志路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.IncludeXmlPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath; //包含表Xml路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.PrjId = objUserCodePrjMainPath_MachineNameEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.UpdDate = objUserCodePrjMainPath_MachineNameEN.UpdDate == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.UpdUserId = objUserCodePrjMainPath_MachineNameEN.UpdUserId == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath_MachineName.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPath_MachineNameEN.Memo = objUserCodePrjMainPath_MachineNameEN.Memo == "[null]" ? null :  objUserCodePrjMainPath_MachineNameEN.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
try
{
if (objUserCodePrjMainPath_MachineNameEN.GcPathId == "[null]") objUserCodePrjMainPath_MachineNameEN.GcPathId = null; //GC路径Id
if (objUserCodePrjMainPath_MachineNameEN.LogPath == "[null]") objUserCodePrjMainPath_MachineNameEN.LogPath = null; //日志路径
if (objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath == "[null]") objUserCodePrjMainPath_MachineNameEN.IncludeXmlPath = null; //包含表Xml路径
if (objUserCodePrjMainPath_MachineNameEN.UpdDate == "[null]") objUserCodePrjMainPath_MachineNameEN.UpdDate = null; //修改日期
if (objUserCodePrjMainPath_MachineNameEN.UpdUserId == "[null]") objUserCodePrjMainPath_MachineNameEN.UpdUserId = null; //修改用户Id
if (objUserCodePrjMainPath_MachineNameEN.Memo == "[null]") objUserCodePrjMainPath_MachineNameEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 UserCodePrjMainPath_MachineNameDA.CheckPropertyNew(objUserCodePrjMainPath_MachineNameEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
 UserCodePrjMainPath_MachineNameDA.CheckProperty4Condition(objUserCodePrjMainPath_MachineNameEN);
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
if (clsUserCodePrjMainPath_MachineNameBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePrjMainPath_MachineNameBL没有刷新缓存机制(clsUserCodePrjMainPath_MachineNameBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserCodePrjMainPathId");
//if (arrUserCodePrjMainPath_MachineNameObjLstCache == null)
//{
//arrUserCodePrjMainPath_MachineNameObjLstCache = UserCodePrjMainPath_MachineNameDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strMachineName">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPath_MachineNameEN GetObjByKeyLstCache(string strUserCodePrjMainPathId,string strMachineName, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLst_Sel =
arrUserCodePrjMainPath_MachineNameObjLstCache
.Where(x=> x.UserCodePrjMainPathId == strUserCodePrjMainPathId 
 && x.MachineName == strMachineName 
);
if (arrUserCodePrjMainPath_MachineNameObjLst_Sel.Count() == 0)
{
   clsUserCodePrjMainPath_MachineNameEN obj = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(strUserCodePrjMainPathId,strMachineName);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strUserCodePrjMainPathId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrUserCodePrjMainPath_MachineNameObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetAllUserCodePrjMainPath_MachineNameObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = GetObjLstCache(strPrjId); 
return arrUserCodePrjMainPath_MachineNameObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPath_MachineNameEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsUserCodePrjMainPath_MachineNameEN> arrUserCodePrjMainPath_MachineNameObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrUserCodePrjMainPath_MachineNameObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPath_MachineNameEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserCodePrjMainPath_MachineNameEN._RefreshTimeLst.Count == 0) return "";
return clsUserCodePrjMainPath_MachineNameEN._RefreshTimeLst[clsUserCodePrjMainPath_MachineNameEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserCodePrjMainPath_MachineNameBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPath_MachineNameEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserCodePrjMainPath_MachineNameBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserCodePrjMainPath_MachineName(用户生成项目主路径_PC)
 /// 唯一性条件:UserCodePrjMainPathId_MachineName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameEN)
{
//检测记录是否存在
string strResult = UserCodePrjMainPath_MachineNameDA.GetUniCondStr(objUserCodePrjMainPath_MachineNameEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserCodePrjMainPathId,string strMachineName, string strPrjId)
{
if (strInFldName != conUserCodePrjMainPath_MachineName.UserCodePrjMainPathId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserCodePrjMainPath_MachineName._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserCodePrjMainPath_MachineName._AttributeName));
throw new Exception(strMsg);
}
var objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLstCache(strUserCodePrjMainPathId,strMachineName, strPrjId);
if (objUserCodePrjMainPath_MachineName == null) return "";
return objUserCodePrjMainPath_MachineName[strOutFldName].ToString();
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.GetRecCount(strTabName);
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.GetRecCount();
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserCodePrjMainPath_MachineNameCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineNameCond)
{
 string strPrjId = objUserCodePrjMainPath_MachineNameCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsUserCodePrjMainPath_MachineNameBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsUserCodePrjMainPath_MachineNameEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPath_MachineNameEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePrjMainPath_MachineName._AttributeName)
{
if (objUserCodePrjMainPath_MachineNameCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPath_MachineNameCond[strFldName].ToString());
}
else
{
if (objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePrjMainPath_MachineNameCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPath_MachineNameCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePrjMainPath_MachineNameCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePrjMainPath_MachineNameCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPath_MachineNameCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPath_MachineNameCond[strFldName]));
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
 List<string> arrList = clsUserCodePrjMainPath_MachineNameDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserCodePrjMainPath_MachineNameDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserCodePrjMainPath_MachineNameDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserCodePrjMainPath_MachineNameDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.SetFldValue(clsUserCodePrjMainPath_MachineNameEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserCodePrjMainPath_MachineNameDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPath_MachineNameDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserCodePrjMainPath_MachineName] "); 
 strCreateTabCode.Append(" ( "); 
 // /**生成主目录Id*/ 
 strCreateTabCode.Append(" UserCodePrjMainPathId char(8) primary key, "); 
 // /**机器名*/ 
 strCreateTabCode.Append(" MachineName varchar(50) primary key, "); 
 // /**代码路径*/ 
 strCreateTabCode.Append(" CodePath varchar(200) not Null, "); 
 // /**GC路径Id*/ 
 strCreateTabCode.Append(" GcPathId char(8) Null, "); 
 // /**备份代码路径*/ 
 strCreateTabCode.Append(" CodePathBackup varchar(200) not Null, "); 
 // /**日志路径*/ 
 strCreateTabCode.Append(" LogPath varchar(150) Null, "); 
 // /**包含表Xml路径*/ 
 strCreateTabCode.Append(" IncludeXmlPath varchar(150) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**应用程序类型简称*/ 
 strCreateTabCode.Append(" ApplicationTypeSimName varchar(30) Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**GC路径名*/ 
 strCreateTabCode.Append(" GcPathName varchar(150) Null, "); 
 // /**应用程序类型名称*/ 
 strCreateTabCode.Append(" ApplicationTypeName varchar(30) not Null, "); 
 // /**是否存在代码路径*/ 
 strCreateTabCode.Append(" IsExistCodePath bit Null, "); 
 // /**是否存在备份路径*/ 
 strCreateTabCode.Append(" IsExistCodePathBackup bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户生成项目主路径_PC(UserCodePrjMainPath_MachineName)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserCodePrjMainPath_MachineName : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsUserCodePrjMainPath_MachineNameBL.ReFreshThisCache(strPrjId);
}
}

}