
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserDefaValue_LocalBL
 表名:UserDefaValue_Local(00050089)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:10:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class  clsUserDefaValue_LocalBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserDefaValue_LocalEN GetObj(this K_mId_UserDefaValue_Local myKey)
{
clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.GetObjBymId(myKey.Value);
return objUserDefaValue_LocalEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserDefaValue_LocalEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecord)", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.AddNewRecordBySQL2(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
public static bool AddRecordEx(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, bool bolIsNeedCheckUniqueness = true)
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
objUserDefaValue_LocalEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserDefaValue_LocalEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],用户Id(UserId)=[{1}],DefaValNameId(DefaValNameId)=[{2}])已经存在,不能重复!", objUserDefaValue_LocalEN.PrjId, objUserDefaValue_LocalEN.UserId, objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserDefaValue_LocalEN.AddNewRecord();
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserDefaValue_LocalEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecord(SqlTransaction))", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.AddNewRecordBySQL2(objUserDefaValue_LocalEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserDefaValue_LocalEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecordWithReturnKey)", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.AddNewRecordBySQL2WithReturnKey(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserDefaValue_LocalEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecordWithReturnKey)", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.AddNewRecordBySQL2WithReturnKey(objUserDefaValue_LocalEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetmId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, long lngmId, string strComparisonOp="")
	{
objUserDefaValue_LocalEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.mId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.mId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.mId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetDefaValNameId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strDefaValNameId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDefaValNameId, conUserDefaValue_Local.DefaValNameId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaValNameId, 8, conUserDefaValue_Local.DefaValNameId);
}
objUserDefaValue_LocalEN.DefaValNameId = strDefaValNameId; //DefaValNameId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.DefaValNameId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.DefaValNameId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.DefaValNameId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUserId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserDefaValue_Local.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserDefaValue_Local.UserId);
}
objUserDefaValue_LocalEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UserId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UserId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UserId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUserDefaValue(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUserDefaValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserDefaValue, conUserDefaValue_Local.UserDefaValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserDefaValue, 100, conUserDefaValue_Local.UserDefaValue);
}
objUserDefaValue_LocalEN.UserDefaValue = strUserDefaValue; //UserDefaValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UserDefaValue) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UserDefaValue, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UserDefaValue] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetPrjId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserDefaValue_Local.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserDefaValue_Local.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserDefaValue_Local.PrjId);
}
objUserDefaValue_LocalEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.PrjId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.PrjId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.PrjId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUpdDate(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserDefaValue_Local.UpdDate);
}
objUserDefaValue_LocalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UpdDate) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UpdDate, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UpdDate] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetUpdUserId(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserDefaValue_Local.UpdUserId);
}
objUserDefaValue_LocalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.UpdUserId) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.UpdUserId, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.UpdUserId] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserDefaValue_LocalEN SetMemo(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserDefaValue_Local.Memo);
}
objUserDefaValue_LocalEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserDefaValue_LocalEN.dicFldComparisonOp.ContainsKey(conUserDefaValue_Local.Memo) == false)
{
objUserDefaValue_LocalEN.dicFldComparisonOp.Add(conUserDefaValue_Local.Memo, strComparisonOp);
}
else
{
objUserDefaValue_LocalEN.dicFldComparisonOp[conUserDefaValue_Local.Memo] = strComparisonOp;
}
}
return objUserDefaValue_LocalEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserDefaValue_LocalEN.CheckPropertyNew();
clsUserDefaValue_LocalEN objUserDefaValue_LocalCond = new clsUserDefaValue_LocalEN();
string strCondition = objUserDefaValue_LocalCond
.SetmId(objUserDefaValue_LocalEN.mId, "<>")
.SetPrjId(objUserDefaValue_LocalEN.PrjId, "=")
.SetUserId(objUserDefaValue_LocalEN.UserId, "=")
.SetDefaValNameId(objUserDefaValue_LocalEN.DefaValNameId, "=")
.GetCombineCondition();
objUserDefaValue_LocalEN._IsCheckProperty = true;
bool bolIsExist = clsUserDefaValue_LocalBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_UserId_DefaValNameId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserDefaValue_LocalEN.Update();
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
 /// <param name = "objUserDefaValue_Local">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserDefaValue_LocalEN objUserDefaValue_Local)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserDefaValue_LocalEN objUserDefaValue_LocalCond = new clsUserDefaValue_LocalEN();
string strCondition = objUserDefaValue_LocalCond
.SetPrjId(objUserDefaValue_Local.PrjId, "=")
.SetUserId(objUserDefaValue_Local.UserId, "=")
.SetDefaValNameId(objUserDefaValue_Local.DefaValNameId, "=")
.GetCombineCondition();
objUserDefaValue_Local._IsCheckProperty = true;
bool bolIsExist = clsUserDefaValue_LocalBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserDefaValue_Local.mId = clsUserDefaValue_LocalBL.GetFirstID_S(strCondition);
objUserDefaValue_Local.UpdateWithCondition(strCondition);
}
else
{
objUserDefaValue_Local.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 if (objUserDefaValue_LocalEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.UpdateBySql2(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserDefaValue_LocalEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.UpdateBySql2(objUserDefaValue_LocalEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserDefaValue_LocalEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.UpdateBySql2(objUserDefaValue_LocalEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strWhereCond)
{
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.UpdateBySqlWithCondition(objUserDefaValue_LocalEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.UpdateBySqlWithConditionTransaction(objUserDefaValue_LocalEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
public static int Delete(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
try
{
int intRecNum = clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.DelRecord(objUserDefaValue_LocalEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalENS">源对象</param>
 /// <param name = "objUserDefaValue_LocalENT">目标对象</param>
 public static void CopyTo(this clsUserDefaValue_LocalEN objUserDefaValue_LocalENS, clsUserDefaValue_LocalEN objUserDefaValue_LocalENT)
{
try
{
objUserDefaValue_LocalENT.mId = objUserDefaValue_LocalENS.mId; //mId
objUserDefaValue_LocalENT.DefaValNameId = objUserDefaValue_LocalENS.DefaValNameId; //DefaValNameId
objUserDefaValue_LocalENT.UserId = objUserDefaValue_LocalENS.UserId; //用户Id
objUserDefaValue_LocalENT.UserDefaValue = objUserDefaValue_LocalENS.UserDefaValue; //UserDefaValue
objUserDefaValue_LocalENT.PrjId = objUserDefaValue_LocalENS.PrjId; //工程Id
objUserDefaValue_LocalENT.UpdDate = objUserDefaValue_LocalENS.UpdDate; //修改日期
objUserDefaValue_LocalENT.UpdUserId = objUserDefaValue_LocalENS.UpdUserId; //修改用户Id
objUserDefaValue_LocalENT.Memo = objUserDefaValue_LocalENS.Memo; //说明
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
 /// <param name = "objUserDefaValue_LocalENS">源对象</param>
 /// <returns>目标对象=>clsUserDefaValue_LocalEN:objUserDefaValue_LocalENT</returns>
 public static clsUserDefaValue_LocalEN CopyTo(this clsUserDefaValue_LocalEN objUserDefaValue_LocalENS)
{
try
{
 clsUserDefaValue_LocalEN objUserDefaValue_LocalENT = new clsUserDefaValue_LocalEN()
{
mId = objUserDefaValue_LocalENS.mId, //mId
DefaValNameId = objUserDefaValue_LocalENS.DefaValNameId, //DefaValNameId
UserId = objUserDefaValue_LocalENS.UserId, //用户Id
UserDefaValue = objUserDefaValue_LocalENS.UserDefaValue, //UserDefaValue
PrjId = objUserDefaValue_LocalENS.PrjId, //工程Id
UpdDate = objUserDefaValue_LocalENS.UpdDate, //修改日期
UpdUserId = objUserDefaValue_LocalENS.UpdUserId, //修改用户Id
Memo = objUserDefaValue_LocalENS.Memo, //说明
};
 return objUserDefaValue_LocalENT;
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
public static void CheckPropertyNew(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.CheckPropertyNew(objUserDefaValue_LocalEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 clsUserDefaValue_LocalBL.UserDefaValue_LocalDA.CheckProperty4Condition(objUserDefaValue_LocalEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserDefaValue_LocalEN objUserDefaValue_LocalCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.mId) == true)
{
string strComparisonOpmId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserDefaValue_Local.mId, objUserDefaValue_LocalCond.mId, strComparisonOpmId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.DefaValNameId) == true)
{
string strComparisonOpDefaValNameId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.DefaValNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.DefaValNameId, objUserDefaValue_LocalCond.DefaValNameId, strComparisonOpDefaValNameId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UserId) == true)
{
string strComparisonOpUserId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UserId, objUserDefaValue_LocalCond.UserId, strComparisonOpUserId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UserDefaValue) == true)
{
string strComparisonOpUserDefaValue = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UserDefaValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UserDefaValue, objUserDefaValue_LocalCond.UserDefaValue, strComparisonOpUserDefaValue);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.PrjId) == true)
{
string strComparisonOpPrjId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.PrjId, objUserDefaValue_LocalCond.PrjId, strComparisonOpPrjId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UpdDate, objUserDefaValue_LocalCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.UpdUserId, objUserDefaValue_LocalCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserDefaValue_LocalCond.IsUpdated(conUserDefaValue_Local.Memo) == true)
{
string strComparisonOpMemo = objUserDefaValue_LocalCond.dicFldComparisonOp[conUserDefaValue_Local.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserDefaValue_Local.Memo, objUserDefaValue_LocalCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserDefaValue_Local(用户缺省值), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_UserId_DefaValNameId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserDefaValue_LocalEN == null) return true;
if (objUserDefaValue_LocalEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
if (clsUserDefaValue_LocalBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserDefaValue_LocalEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
if (clsUserDefaValue_LocalBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserDefaValue_Local(用户缺省值), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_UserId_DefaValNameId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserDefaValue_LocalEN == null) return "";
if (objUserDefaValue_LocalEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserDefaValue_LocalEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserDefaValue_LocalEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserDefaValue_LocalEN.UserId);
 sbCondition.AppendFormat(" and DefaValNameId = '{0}'", objUserDefaValue_LocalEN.DefaValNameId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserDefaValue_Local
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户缺省值(UserDefaValue_Local)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserDefaValue_LocalBL
{
public static RelatedActions_UserDefaValue_Local relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserDefaValue_LocalDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserDefaValue_LocalDA UserDefaValue_LocalDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserDefaValue_LocalDA();
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
 public clsUserDefaValue_LocalBL()
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
if (string.IsNullOrEmpty(clsUserDefaValue_LocalEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserDefaValue_LocalEN._ConnectString);
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
public static DataTable GetDataTable_UserDefaValue_Local(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserDefaValue_LocalDA.GetDataTable_UserDefaValue_Local(strWhereCond);
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
objDT = UserDefaValue_LocalDA.GetDataTable(strWhereCond);
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
objDT = UserDefaValue_LocalDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserDefaValue_LocalDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserDefaValue_LocalDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserDefaValue_LocalDA.GetDataTable_Top(objTopPara);
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
objDT = UserDefaValue_LocalDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserDefaValue_LocalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserDefaValue_LocalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
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
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserDefaValue_LocalEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
List<clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLstCache = GetObjLstCache();
IEnumerable <clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLst_Sel =
arrUserDefaValue_LocalObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrUserDefaValue_LocalObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetObjLst(string strWhereCond)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
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
public static List<clsUserDefaValue_LocalEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserDefaValue_LocalEN> GetSubObjLstCache(clsUserDefaValue_LocalEN objUserDefaValue_LocalCond)
{
List<clsUserDefaValue_LocalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserDefaValue_LocalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserDefaValue_Local._AttributeName)
{
if (objUserDefaValue_LocalCond.IsUpdated(strFldName) == false) continue;
if (objUserDefaValue_LocalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserDefaValue_LocalCond[strFldName].ToString());
}
else
{
if (objUserDefaValue_LocalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserDefaValue_LocalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserDefaValue_LocalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserDefaValue_LocalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserDefaValue_LocalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserDefaValue_LocalCond[strFldName]));
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
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
List<clsUserDefaValue_LocalEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserDefaValue_LocalEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserDefaValue_LocalEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
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
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
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
public static List<clsUserDefaValue_LocalEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
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
public static List<clsUserDefaValue_LocalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserDefaValue_LocalEN> arrObjLst = new List<clsUserDefaValue_LocalEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = new clsUserDefaValue_LocalEN();
try
{
objUserDefaValue_LocalEN.mId = Int32.Parse(objRow[conUserDefaValue_Local.mId].ToString().Trim()); //mId
objUserDefaValue_LocalEN.DefaValNameId = objRow[conUserDefaValue_Local.DefaValNameId].ToString().Trim(); //DefaValNameId
objUserDefaValue_LocalEN.UserId = objRow[conUserDefaValue_Local.UserId].ToString().Trim(); //用户Id
objUserDefaValue_LocalEN.UserDefaValue = objRow[conUserDefaValue_Local.UserDefaValue].ToString().Trim(); //UserDefaValue
objUserDefaValue_LocalEN.PrjId = objRow[conUserDefaValue_Local.PrjId].ToString().Trim(); //工程Id
objUserDefaValue_LocalEN.UpdDate = objRow[conUserDefaValue_Local.UpdDate] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdDate].ToString().Trim(); //修改日期
objUserDefaValue_LocalEN.UpdUserId = objRow[conUserDefaValue_Local.UpdUserId] == DBNull.Value ? null : objRow[conUserDefaValue_Local.UpdUserId].ToString().Trim(); //修改用户Id
objUserDefaValue_LocalEN.Memo = objRow[conUserDefaValue_Local.Memo] == DBNull.Value ? null : objRow[conUserDefaValue_Local.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserDefaValue_LocalEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserDefaValue_LocalEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserDefaValue_Local(ref clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
bool bolResult = UserDefaValue_LocalDA.GetUserDefaValue_Local(ref objUserDefaValue_LocalEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserDefaValue_LocalEN GetObjBymId(long lngmId)
{
clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = UserDefaValue_LocalDA.GetObjBymId(lngmId);
return objUserDefaValue_LocalEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserDefaValue_LocalEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = UserDefaValue_LocalDA.GetFirstObj(strWhereCond);
 return objUserDefaValue_LocalEN;
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
public static clsUserDefaValue_LocalEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = UserDefaValue_LocalDA.GetObjByDataRow(objRow);
 return objUserDefaValue_LocalEN;
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
public static clsUserDefaValue_LocalEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = UserDefaValue_LocalDA.GetObjByDataRow(objRow);
 return objUserDefaValue_LocalEN;
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
 /// <param name = "lstUserDefaValue_LocalObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserDefaValue_LocalEN GetObjBymIdFromList(long lngmId, List<clsUserDefaValue_LocalEN> lstUserDefaValue_LocalObjLst)
{
foreach (clsUserDefaValue_LocalEN objUserDefaValue_LocalEN in lstUserDefaValue_LocalObjLst)
{
if (objUserDefaValue_LocalEN.mId == lngmId)
{
return objUserDefaValue_LocalEN;
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
 lngmId = new clsUserDefaValue_LocalDA().GetFirstID(strWhereCond);
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
 arrList = UserDefaValue_LocalDA.GetID(strWhereCond);
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
bool bolIsExist = UserDefaValue_LocalDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = UserDefaValue_LocalDA.IsExist(lngmId);
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
clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = clsUserDefaValue_LocalBL.GetObjBymId(lngmId);
objUserDefaValue_LocalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserDefaValue_LocalEN.UpdUserId = strOpUser;
return clsUserDefaValue_LocalBL.UpdateBySql2(objUserDefaValue_LocalEN);
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
 bolIsExist = clsUserDefaValue_LocalDA.IsExistTable();
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
 bolIsExist = UserDefaValue_LocalDA.IsExistTable(strTabName);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserDefaValue_LocalEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecordBySql2)", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserDefaValue_LocalDA.AddNewRecordBySQL2(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserDefaValue_LocalEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}],DefaValNameId = [{2}]的数据已经存在!(in clsUserDefaValue_LocalBL.AddNewRecordBySql2WithReturnKey)", objUserDefaValue_LocalEN.PrjId,objUserDefaValue_LocalEN.UserId,objUserDefaValue_LocalEN.DefaValNameId);
throw new Exception(strMsg);
}
try
{
string strKey = UserDefaValue_LocalDA.AddNewRecordBySQL2WithReturnKey(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
try
{
bool bolResult = UserDefaValue_LocalDA.Update(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 /// <param name = "objUserDefaValue_LocalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 if (objUserDefaValue_LocalEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserDefaValue_LocalDA.UpdateBySql2(objUserDefaValue_LocalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserDefaValue_LocalBL.ReFreshCache();

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
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
 clsUserDefaValue_LocalEN objUserDefaValue_LocalEN = clsUserDefaValue_LocalBL.GetObjBymId(lngmId);

if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(objUserDefaValue_LocalEN.mId, objUserDefaValue_LocalEN.UpdUserId);
}
if (objUserDefaValue_LocalEN != null)
{
int intRecNum = UserDefaValue_LocalDA.DelRecord(lngmId);
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
objSQL = clsUserDefaValue_LocalDA.GetSpecSQLObj();
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
//删除与表:[UserDefaValue_Local]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserDefaValue_Local.mId,
//lngmId);
//        clsUserDefaValue_LocalBL.DelUserDefaValue_LocalsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserDefaValue_LocalBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserDefaValue_LocalBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsUserDefaValue_LocalBL.relatedActions != null)
{
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = UserDefaValue_LocalDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelUserDefaValue_Locals(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsUserDefaValue_LocalBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = UserDefaValue_LocalDA.DelUserDefaValue_Local(arrmIdLst);
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
public static int DelUserDefaValue_LocalsByCond(string strWhereCond)
{
try
{
if (clsUserDefaValue_LocalBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = UserDefaValue_LocalDA.DelUserDefaValue_Local(strWhereCond);
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
public static bool DelUserDefaValue_LocalsByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserDefaValue_LocalBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserDefaValue_LocalBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = UserDefaValue_LocalDA.DelUserDefaValue_LocalWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserDefaValue_Local]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserDefaValue_LocalDA.GetSpecSQLObj();
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
//删除与表:[UserDefaValue_Local]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserDefaValue_LocalBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserDefaValue_LocalBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserDefaValue_LocalENS">源对象</param>
 /// <param name = "objUserDefaValue_LocalENT">目标对象</param>
 public static void CopyTo(clsUserDefaValue_LocalEN objUserDefaValue_LocalENS, clsUserDefaValue_LocalEN objUserDefaValue_LocalENT)
{
try
{
objUserDefaValue_LocalENT.mId = objUserDefaValue_LocalENS.mId; //mId
objUserDefaValue_LocalENT.DefaValNameId = objUserDefaValue_LocalENS.DefaValNameId; //DefaValNameId
objUserDefaValue_LocalENT.UserId = objUserDefaValue_LocalENS.UserId; //用户Id
objUserDefaValue_LocalENT.UserDefaValue = objUserDefaValue_LocalENS.UserDefaValue; //UserDefaValue
objUserDefaValue_LocalENT.PrjId = objUserDefaValue_LocalENS.PrjId; //工程Id
objUserDefaValue_LocalENT.UpdDate = objUserDefaValue_LocalENS.UpdDate; //修改日期
objUserDefaValue_LocalENT.UpdUserId = objUserDefaValue_LocalENS.UpdUserId; //修改用户Id
objUserDefaValue_LocalENT.Memo = objUserDefaValue_LocalENS.Memo; //说明
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
 /// <param name = "objUserDefaValue_LocalEN">源简化对象</param>
 public static void SetUpdFlag(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
try
{
objUserDefaValue_LocalEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserDefaValue_LocalEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserDefaValue_Local.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.mId = objUserDefaValue_LocalEN.mId; //mId
}
if (arrFldSet.Contains(conUserDefaValue_Local.DefaValNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.DefaValNameId = objUserDefaValue_LocalEN.DefaValNameId; //DefaValNameId
}
if (arrFldSet.Contains(conUserDefaValue_Local.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.UserId = objUserDefaValue_LocalEN.UserId; //用户Id
}
if (arrFldSet.Contains(conUserDefaValue_Local.UserDefaValue, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.UserDefaValue = objUserDefaValue_LocalEN.UserDefaValue; //UserDefaValue
}
if (arrFldSet.Contains(conUserDefaValue_Local.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.PrjId = objUserDefaValue_LocalEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conUserDefaValue_Local.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.UpdDate = objUserDefaValue_LocalEN.UpdDate == "[null]" ? null :  objUserDefaValue_LocalEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserDefaValue_Local.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.UpdUserId = objUserDefaValue_LocalEN.UpdUserId == "[null]" ? null :  objUserDefaValue_LocalEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conUserDefaValue_Local.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserDefaValue_LocalEN.Memo = objUserDefaValue_LocalEN.Memo == "[null]" ? null :  objUserDefaValue_LocalEN.Memo; //说明
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
 /// <param name = "objUserDefaValue_LocalEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
try
{
if (objUserDefaValue_LocalEN.UpdDate == "[null]") objUserDefaValue_LocalEN.UpdDate = null; //修改日期
if (objUserDefaValue_LocalEN.UpdUserId == "[null]") objUserDefaValue_LocalEN.UpdUserId = null; //修改用户Id
if (objUserDefaValue_LocalEN.Memo == "[null]") objUserDefaValue_LocalEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 UserDefaValue_LocalDA.CheckPropertyNew(objUserDefaValue_LocalEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
 UserDefaValue_LocalDA.CheckProperty4Condition(objUserDefaValue_LocalEN);
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
if (clsUserDefaValue_LocalBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserDefaValue_LocalBL没有刷新缓存机制(clsUserDefaValue_LocalBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserDefaValue_LocalObjLstCache == null)
//{
//arrUserDefaValue_LocalObjLstCache = UserDefaValue_LocalDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserDefaValue_LocalEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
List<clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLstCache = GetObjLstCache();
IEnumerable <clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLst_Sel =
arrUserDefaValue_LocalObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrUserDefaValue_LocalObjLst_Sel.Count() == 0)
{
   clsUserDefaValue_LocalEN obj = clsUserDefaValue_LocalBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUserDefaValue_LocalObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetAllUserDefaValue_LocalObjLstCache()
{
//获取缓存中的对象列表
List<clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLstCache = GetObjLstCache(); 
return arrUserDefaValue_LocalObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserDefaValue_LocalEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
List<clsUserDefaValue_LocalEN> arrUserDefaValue_LocalObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserDefaValue_LocalObjLstCache;
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
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserDefaValue_LocalEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserDefaValue_LocalEN._RefreshTimeLst.Count == 0) return "";
return clsUserDefaValue_LocalEN._RefreshTimeLst[clsUserDefaValue_LocalEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsUserDefaValue_LocalBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserDefaValue_LocalEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserDefaValue_LocalEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserDefaValue_LocalBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserDefaValue_Local(用户缺省值)
 /// 唯一性条件:PrjId_UserId_DefaValNameId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserDefaValue_LocalEN objUserDefaValue_LocalEN)
{
//检测记录是否存在
string strResult = UserDefaValue_LocalDA.GetUniCondStr(objUserDefaValue_LocalEN);
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
if (strInFldName != conUserDefaValue_Local.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserDefaValue_Local._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserDefaValue_Local._AttributeName));
throw new Exception(strMsg);
}
var objUserDefaValue_Local = clsUserDefaValue_LocalBL.GetObjBymIdCache(lngmId);
if (objUserDefaValue_Local == null) return "";
return objUserDefaValue_Local[strOutFldName].ToString();
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
int intRecCount = clsUserDefaValue_LocalDA.GetRecCount(strTabName);
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
int intRecCount = clsUserDefaValue_LocalDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserDefaValue_LocalDA.GetRecCount();
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
int intRecCount = clsUserDefaValue_LocalDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserDefaValue_LocalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserDefaValue_LocalEN objUserDefaValue_LocalCond)
{
List<clsUserDefaValue_LocalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserDefaValue_LocalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserDefaValue_Local._AttributeName)
{
if (objUserDefaValue_LocalCond.IsUpdated(strFldName) == false) continue;
if (objUserDefaValue_LocalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserDefaValue_LocalCond[strFldName].ToString());
}
else
{
if (objUserDefaValue_LocalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserDefaValue_LocalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserDefaValue_LocalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserDefaValue_LocalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserDefaValue_LocalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserDefaValue_LocalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserDefaValue_LocalCond[strFldName]));
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
 List<string> arrList = clsUserDefaValue_LocalDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserDefaValue_LocalDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserDefaValue_LocalDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserDefaValue_LocalDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserDefaValue_LocalDA.SetFldValue(clsUserDefaValue_LocalEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserDefaValue_LocalDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserDefaValue_LocalDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserDefaValue_LocalDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserDefaValue_LocalDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserDefaValue_Local] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**DefaValNameId*/ 
 strCreateTabCode.Append(" DefaValNameId varchar(8) not Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**UserDefaValue*/ 
 strCreateTabCode.Append(" UserDefaValue varchar(100) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户缺省值(UserDefaValue_Local)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserDefaValue_Local : clsCommFun4BL
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
clsUserDefaValue_LocalBL.ReFreshThisCache();
}
}

}