
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantBL
 表名:UserPrjGrant(00050092)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:29:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
public static class  clsUserPrjGrantBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserPrjGrantEN GetObj(this K_mId_UserPrjGrant myKey)
{
clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantBL.UserPrjGrantDA.GetObjBymId(myKey.Value);
return objUserPrjGrantEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserPrjGrantEN objUserPrjGrantEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserPrjGrantEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecord)", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.AddNewRecordBySQL2(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsUserPrjGrantEN objUserPrjGrantEN, bool bolIsNeedCheckUniqueness = true)
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
objUserPrjGrantEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserPrjGrantEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],用户Id(UserId)=[{1}])已经存在,不能重复!", objUserPrjGrantEN.PrjId, objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserPrjGrantEN.AddNewRecord();
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserPrjGrantEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecord(SqlTransaction))", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.AddNewRecordBySQL2(objUserPrjGrantEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserPrjGrantEN objUserPrjGrantEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserPrjGrantEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecordWithReturnKey)", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserPrjGrantBL.UserPrjGrantDA.AddNewRecordBySQL2WithReturnKey(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserPrjGrantEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecordWithReturnKey)", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserPrjGrantBL.UserPrjGrantDA.AddNewRecordBySQL2WithReturnKey(objUserPrjGrantEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetmId(this clsUserPrjGrantEN objUserPrjGrantEN, long lngmId, string strComparisonOp="")
	{
objUserPrjGrantEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.mId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.mId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.mId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetUserId(this clsUserPrjGrantEN objUserPrjGrantEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserPrjGrant.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserPrjGrant.UserId);
}
objUserPrjGrantEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.UserId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.UserId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.UserId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetPrjId(this clsUserPrjGrantEN objUserPrjGrantEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserPrjGrant.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserPrjGrant.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserPrjGrant.PrjId);
}
objUserPrjGrantEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.PrjId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.PrjId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.PrjId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetRoleId(this clsUserPrjGrantEN objUserPrjGrantEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRoleId, conUserPrjGrant.RoleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conUserPrjGrant.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conUserPrjGrant.RoleId);
}
objUserPrjGrantEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.RoleId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.RoleId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.RoleId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetVisitedNum(this clsUserPrjGrantEN objUserPrjGrantEN, int? intVisitedNum, string strComparisonOp="")
	{
objUserPrjGrantEN.VisitedNum = intVisitedNum; //访问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.VisitedNum) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.VisitedNum, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.VisitedNum] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetLastVisitedDate(this clsUserPrjGrantEN objUserPrjGrantEN, string strLastVisitedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastVisitedDate, 20, conUserPrjGrant.LastVisitedDate);
}
objUserPrjGrantEN.LastVisitedDate = strLastVisitedDate; //最后访问时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.LastVisitedDate) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.LastVisitedDate, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.LastVisitedDate] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetOptId(this clsUserPrjGrantEN objUserPrjGrantEN, string strOptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptId, 18, conUserPrjGrant.OptId);
}
objUserPrjGrantEN.OptId = strOptId; //操作者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.OptId) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.OptId, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.OptId] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetOptDate(this clsUserPrjGrantEN objUserPrjGrantEN, string strOptDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOptDate, 20, conUserPrjGrant.OptDate);
}
objUserPrjGrantEN.OptDate = strOptDate; //操作日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.OptDate) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.OptDate, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.OptDate] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserPrjGrantEN SetMemo(this clsUserPrjGrantEN objUserPrjGrantEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserPrjGrant.Memo);
}
objUserPrjGrantEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserPrjGrantEN.dicFldComparisonOp.ContainsKey(conUserPrjGrant.Memo) == false)
{
objUserPrjGrantEN.dicFldComparisonOp.Add(conUserPrjGrant.Memo, strComparisonOp);
}
else
{
objUserPrjGrantEN.dicFldComparisonOp[conUserPrjGrant.Memo] = strComparisonOp;
}
}
return objUserPrjGrantEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserPrjGrantEN objUserPrjGrantEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserPrjGrantEN.CheckPropertyNew();
clsUserPrjGrantEN objUserPrjGrantCond = new clsUserPrjGrantEN();
string strCondition = objUserPrjGrantCond
.SetmId(objUserPrjGrantEN.mId, "<>")
.SetPrjId(objUserPrjGrantEN.PrjId, "=")
.SetUserId(objUserPrjGrantEN.UserId, "=")
.GetCombineCondition();
objUserPrjGrantEN._IsCheckProperty = true;
bool bolIsExist = clsUserPrjGrantBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserPrjGrantEN.Update();
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
 /// <param name = "objUserPrjGrant">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserPrjGrantEN objUserPrjGrant)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserPrjGrantEN objUserPrjGrantCond = new clsUserPrjGrantEN();
string strCondition = objUserPrjGrantCond
.SetPrjId(objUserPrjGrant.PrjId, "=")
.SetUserId(objUserPrjGrant.UserId, "=")
.GetCombineCondition();
objUserPrjGrant._IsCheckProperty = true;
bool bolIsExist = clsUserPrjGrantBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserPrjGrant.mId = clsUserPrjGrantBL.GetFirstID_S(strCondition);
objUserPrjGrant.UpdateWithCondition(strCondition);
}
else
{
objUserPrjGrant.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.UpdateBySql2(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserPrjGrantEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.UpdateBySql2(objUserPrjGrantEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserPrjGrantEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.UpdateBySql2(objUserPrjGrantEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserPrjGrantEN objUserPrjGrantEN, string strWhereCond)
{
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.UpdateBySqlWithCondition(objUserPrjGrantEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserPrjGrantEN objUserPrjGrantEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserPrjGrantBL.UserPrjGrantDA.UpdateBySqlWithConditionTransaction(objUserPrjGrantEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
public static int Delete(this clsUserPrjGrantEN objUserPrjGrantEN)
{
try
{
int intRecNum = clsUserPrjGrantBL.UserPrjGrantDA.DelRecord(objUserPrjGrantEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
 public static void CopyTo(this clsUserPrjGrantEN objUserPrjGrantENS, clsUserPrjGrantEN objUserPrjGrantENT)
{
try
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程Id
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
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
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <returns>目标对象=>clsUserPrjGrantEN:objUserPrjGrantENT</returns>
 public static clsUserPrjGrantEN CopyTo(this clsUserPrjGrantEN objUserPrjGrantENS)
{
try
{
 clsUserPrjGrantEN objUserPrjGrantENT = new clsUserPrjGrantEN()
{
mId = objUserPrjGrantENS.mId, //mId
UserId = objUserPrjGrantENS.UserId, //用户Id
PrjId = objUserPrjGrantENS.PrjId, //工程Id
RoleId = objUserPrjGrantENS.RoleId, //角色ID
VisitedNum = objUserPrjGrantENS.VisitedNum, //访问数
LastVisitedDate = objUserPrjGrantENS.LastVisitedDate, //最后访问时间
OptId = objUserPrjGrantENS.OptId, //操作者Id
OptDate = objUserPrjGrantENS.OptDate, //操作日期
Memo = objUserPrjGrantENS.Memo, //说明
};
 return objUserPrjGrantENT;
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
public static void CheckPropertyNew(this clsUserPrjGrantEN objUserPrjGrantEN)
{
 clsUserPrjGrantBL.UserPrjGrantDA.CheckPropertyNew(objUserPrjGrantEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserPrjGrantEN objUserPrjGrantEN)
{
 clsUserPrjGrantBL.UserPrjGrantDA.CheckProperty4Condition(objUserPrjGrantEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserPrjGrantEN objUserPrjGrantCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.mId) == true)
{
string strComparisonOpmId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPrjGrant.mId, objUserPrjGrantCond.mId, strComparisonOpmId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.UserId) == true)
{
string strComparisonOpUserId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.UserId, objUserPrjGrantCond.UserId, strComparisonOpUserId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.PrjId) == true)
{
string strComparisonOpPrjId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.PrjId, objUserPrjGrantCond.PrjId, strComparisonOpPrjId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.RoleId) == true)
{
string strComparisonOpRoleId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.RoleId, objUserPrjGrantCond.RoleId, strComparisonOpRoleId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.VisitedNum) == true)
{
string strComparisonOpVisitedNum = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.VisitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conUserPrjGrant.VisitedNum, objUserPrjGrantCond.VisitedNum, strComparisonOpVisitedNum);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.LastVisitedDate) == true)
{
string strComparisonOpLastVisitedDate = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.LastVisitedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.LastVisitedDate, objUserPrjGrantCond.LastVisitedDate, strComparisonOpLastVisitedDate);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.OptId) == true)
{
string strComparisonOpOptId = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.OptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.OptId, objUserPrjGrantCond.OptId, strComparisonOpOptId);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.OptDate) == true)
{
string strComparisonOpOptDate = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.OptDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.OptDate, objUserPrjGrantCond.OptDate, strComparisonOpOptDate);
}
if (objUserPrjGrantCond.IsUpdated(conUserPrjGrant.Memo) == true)
{
string strComparisonOpMemo = objUserPrjGrantCond.dicFldComparisonOp[conUserPrjGrant.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserPrjGrant.Memo, objUserPrjGrantCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserPrjGrant(UserPrjGrant), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserPrjGrantEN objUserPrjGrantEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserPrjGrantEN == null) return true;
if (objUserPrjGrantEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
if (clsUserPrjGrantBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserPrjGrantEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
if (clsUserPrjGrantBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserPrjGrant(UserPrjGrant), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserPrjGrantEN objUserPrjGrantEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserPrjGrantEN == null) return "";
if (objUserPrjGrantEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserPrjGrantEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserPrjGrant
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// UserPrjGrant(UserPrjGrant)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserPrjGrantBL
{
public static RelatedActions_UserPrjGrant relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserPrjGrantDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserPrjGrantDA UserPrjGrantDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserPrjGrantDA();
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
 public clsUserPrjGrantBL()
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
if (string.IsNullOrEmpty(clsUserPrjGrantEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserPrjGrantEN._ConnectString);
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
public static DataTable GetDataTable_UserPrjGrant(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserPrjGrantDA.GetDataTable_UserPrjGrant(strWhereCond);
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
objDT = UserPrjGrantDA.GetDataTable(strWhereCond);
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
objDT = UserPrjGrantDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserPrjGrantDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserPrjGrantDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserPrjGrantDA.GetDataTable_Top(objTopPara);
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
objDT = UserPrjGrantDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserPrjGrantDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserPrjGrantDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsUserPrjGrantEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
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
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserPrjGrantEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsUserPrjGrantEN._CurrTabName);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = GetObjLstCache();
IEnumerable <clsUserPrjGrantEN> arrUserPrjGrantObjLst_Sel =
arrUserPrjGrantObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrUserPrjGrantObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLst(string strWhereCond)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
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
public static List<clsUserPrjGrantEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserPrjGrantCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserPrjGrantEN> GetSubObjLstCache(clsUserPrjGrantEN objUserPrjGrantCond)
{
List<clsUserPrjGrantEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserPrjGrantEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserPrjGrant._AttributeName)
{
if (objUserPrjGrantCond.IsUpdated(strFldName) == false) continue;
if (objUserPrjGrantCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserPrjGrantCond[strFldName].ToString());
}
else
{
if (objUserPrjGrantCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserPrjGrantCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserPrjGrantCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserPrjGrantCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserPrjGrantCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserPrjGrantCond[strFldName]));
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
public static List<clsUserPrjGrantEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
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
public static List<clsUserPrjGrantEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
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
List<clsUserPrjGrantEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserPrjGrantEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPrjGrantEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserPrjGrantEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
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
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
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
public static List<clsUserPrjGrantEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserPrjGrantEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
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
public static List<clsUserPrjGrantEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserPrjGrantEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserPrjGrant(ref clsUserPrjGrantEN objUserPrjGrantEN)
{
bool bolResult = UserPrjGrantDA.GetUserPrjGrant(ref objUserPrjGrantEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserPrjGrantEN GetObjBymId(long lngmId)
{
clsUserPrjGrantEN objUserPrjGrantEN = UserPrjGrantDA.GetObjBymId(lngmId);
return objUserPrjGrantEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserPrjGrantEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserPrjGrantEN objUserPrjGrantEN = UserPrjGrantDA.GetFirstObj(strWhereCond);
 return objUserPrjGrantEN;
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
public static clsUserPrjGrantEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserPrjGrantEN objUserPrjGrantEN = UserPrjGrantDA.GetObjByDataRow(objRow);
 return objUserPrjGrantEN;
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
public static clsUserPrjGrantEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserPrjGrantEN objUserPrjGrantEN = UserPrjGrantDA.GetObjByDataRow(objRow);
 return objUserPrjGrantEN;
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
 /// <param name = "lstUserPrjGrantObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserPrjGrantEN GetObjBymIdFromList(long lngmId, List<clsUserPrjGrantEN> lstUserPrjGrantObjLst)
{
foreach (clsUserPrjGrantEN objUserPrjGrantEN in lstUserPrjGrantObjLst)
{
if (objUserPrjGrantEN.mId == lngmId)
{
return objUserPrjGrantEN;
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
 lngmId = new clsUserPrjGrantDA().GetFirstID(strWhereCond);
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
 arrList = UserPrjGrantDA.GetID(strWhereCond);
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
bool bolIsExist = UserPrjGrantDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = UserPrjGrantDA.IsExist(lngmId);
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
 bolIsExist = clsUserPrjGrantDA.IsExistTable();
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
 bolIsExist = UserPrjGrantDA.IsExistTable(strTabName);
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserPrjGrantEN objUserPrjGrantEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserPrjGrantEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecordBySql2)", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserPrjGrantDA.AddNewRecordBySQL2(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserPrjGrantEN objUserPrjGrantEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserPrjGrantEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],用户Id = [{1}]的数据已经存在!(in clsUserPrjGrantBL.AddNewRecordBySql2WithReturnKey)", objUserPrjGrantEN.PrjId,objUserPrjGrantEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = UserPrjGrantDA.AddNewRecordBySQL2WithReturnKey(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserPrjGrantEN objUserPrjGrantEN)
{
try
{
bool bolResult = UserPrjGrantDA.Update(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserPrjGrantDA.UpdateBySql2(objUserPrjGrantEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserPrjGrantBL.ReFreshCache();

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
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
 clsUserPrjGrantEN objUserPrjGrantEN = clsUserPrjGrantBL.GetObjBymId(lngmId);

if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(objUserPrjGrantEN.mId, "SetUpdDate");
}
if (objUserPrjGrantEN != null)
{
int intRecNum = UserPrjGrantDA.DelRecord(lngmId);
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
objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
//删除与表:[UserPrjGrant]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserPrjGrant.mId,
//lngmId);
//        clsUserPrjGrantBL.DelUserPrjGrantsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserPrjGrantBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserPrjGrantBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsUserPrjGrantBL.relatedActions != null)
{
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = UserPrjGrantDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelUserPrjGrants(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsUserPrjGrantBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = UserPrjGrantDA.DelUserPrjGrant(arrmIdLst);
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
public static int DelUserPrjGrantsByCond(string strWhereCond)
{
try
{
if (clsUserPrjGrantBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = UserPrjGrantDA.DelUserPrjGrant(strWhereCond);
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
public static bool DelUserPrjGrantsByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserPrjGrantBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserPrjGrantBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = UserPrjGrantDA.DelUserPrjGrantWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserPrjGrant]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
//删除与表:[UserPrjGrant]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserPrjGrantBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserPrjGrantBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
 public static void CopyTo(clsUserPrjGrantEN objUserPrjGrantENS, clsUserPrjGrantEN objUserPrjGrantENT)
{
try
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程Id
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
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
 /// <param name = "objUserPrjGrantEN">源简化对象</param>
 public static void SetUpdFlag(clsUserPrjGrantEN objUserPrjGrantEN)
{
try
{
objUserPrjGrantEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserPrjGrantEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserPrjGrant.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.mId = objUserPrjGrantEN.mId; //mId
}
if (arrFldSet.Contains(conUserPrjGrant.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.UserId = objUserPrjGrantEN.UserId; //用户Id
}
if (arrFldSet.Contains(conUserPrjGrant.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.PrjId = objUserPrjGrantEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conUserPrjGrant.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.RoleId = objUserPrjGrantEN.RoleId; //角色ID
}
if (arrFldSet.Contains(conUserPrjGrant.VisitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.VisitedNum = objUserPrjGrantEN.VisitedNum; //访问数
}
if (arrFldSet.Contains(conUserPrjGrant.LastVisitedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.LastVisitedDate = objUserPrjGrantEN.LastVisitedDate == "[null]" ? null :  objUserPrjGrantEN.LastVisitedDate; //最后访问时间
}
if (arrFldSet.Contains(conUserPrjGrant.OptId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.OptId = objUserPrjGrantEN.OptId == "[null]" ? null :  objUserPrjGrantEN.OptId; //操作者Id
}
if (arrFldSet.Contains(conUserPrjGrant.OptDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.OptDate = objUserPrjGrantEN.OptDate == "[null]" ? null :  objUserPrjGrantEN.OptDate; //操作日期
}
if (arrFldSet.Contains(conUserPrjGrant.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserPrjGrantEN.Memo = objUserPrjGrantEN.Memo == "[null]" ? null :  objUserPrjGrantEN.Memo; //说明
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
 /// <param name = "objUserPrjGrantEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserPrjGrantEN objUserPrjGrantEN)
{
try
{
if (objUserPrjGrantEN.LastVisitedDate == "[null]") objUserPrjGrantEN.LastVisitedDate = null; //最后访问时间
if (objUserPrjGrantEN.OptId == "[null]") objUserPrjGrantEN.OptId = null; //操作者Id
if (objUserPrjGrantEN.OptDate == "[null]") objUserPrjGrantEN.OptDate = null; //操作日期
if (objUserPrjGrantEN.Memo == "[null]") objUserPrjGrantEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserPrjGrantEN objUserPrjGrantEN)
{
 UserPrjGrantDA.CheckPropertyNew(objUserPrjGrantEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserPrjGrantEN objUserPrjGrantEN)
{
 UserPrjGrantDA.CheckProperty4Condition(objUserPrjGrantEN);
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
if (clsUserPrjGrantBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserPrjGrantBL没有刷新缓存机制(clsUserPrjGrantBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserPrjGrantObjLstCache == null)
//{
//arrUserPrjGrantObjLstCache = UserPrjGrantDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserPrjGrantEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUserPrjGrantEN._CurrTabName);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = GetObjLstCache();
IEnumerable <clsUserPrjGrantEN> arrUserPrjGrantObjLst_Sel =
arrUserPrjGrantObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrUserPrjGrantObjLst_Sel.Count() == 0)
{
   clsUserPrjGrantEN obj = clsUserPrjGrantBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUserPrjGrantObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserPrjGrantEN> GetAllUserPrjGrantObjLstCache()
{
//获取缓存中的对象列表
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = GetObjLstCache(); 
return arrUserPrjGrantObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserPrjGrantEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUserPrjGrantEN._CurrTabName);
List<clsUserPrjGrantEN> arrUserPrjGrantObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUserPrjGrantObjLstCache;
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
string strKey = string.Format("{0}", clsUserPrjGrantEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserPrjGrantEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserPrjGrantEN._RefreshTimeLst.Count == 0) return "";
return clsUserPrjGrantEN._RefreshTimeLst[clsUserPrjGrantEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsUserPrjGrantBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUserPrjGrantEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUserPrjGrantEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserPrjGrantBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserPrjGrant(UserPrjGrant)
 /// 唯一性条件:PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserPrjGrantEN objUserPrjGrantEN)
{
//检测记录是否存在
string strResult = UserPrjGrantDA.GetUniCondStr(objUserPrjGrantEN);
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
if (strInFldName != conUserPrjGrant.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserPrjGrant._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserPrjGrant._AttributeName));
throw new Exception(strMsg);
}
var objUserPrjGrant = clsUserPrjGrantBL.GetObjBymIdCache(lngmId);
if (objUserPrjGrant == null) return "";
return objUserPrjGrant[strOutFldName].ToString();
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
int intRecCount = clsUserPrjGrantDA.GetRecCount(strTabName);
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
int intRecCount = clsUserPrjGrantDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserPrjGrantDA.GetRecCount();
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
int intRecCount = clsUserPrjGrantDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserPrjGrantCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserPrjGrantEN objUserPrjGrantCond)
{
List<clsUserPrjGrantEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUserPrjGrantEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserPrjGrant._AttributeName)
{
if (objUserPrjGrantCond.IsUpdated(strFldName) == false) continue;
if (objUserPrjGrantCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserPrjGrantCond[strFldName].ToString());
}
else
{
if (objUserPrjGrantCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserPrjGrantCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserPrjGrantCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserPrjGrantCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserPrjGrantCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserPrjGrantCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserPrjGrantCond[strFldName]));
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
 List<string> arrList = clsUserPrjGrantDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserPrjGrantDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserPrjGrantDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserPrjGrantDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserPrjGrantDA.SetFldValue(clsUserPrjGrantEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserPrjGrantDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserPrjGrantDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserPrjGrantDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserPrjGrantDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserPrjGrant] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**角色ID*/ 
 strCreateTabCode.Append(" RoleId char(8) not Null, "); 
 // /**访问数*/ 
 strCreateTabCode.Append(" VisitedNum int Null, "); 
 // /**最后访问时间*/ 
 strCreateTabCode.Append(" LastVisitedDate varchar(20) Null, "); 
 // /**操作者Id*/ 
 strCreateTabCode.Append(" OptId varchar(18) Null, "); 
 // /**操作日期*/ 
 strCreateTabCode.Append(" OptDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) not Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) not Null, "); 
 // /**角色名称*/ 
 strCreateTabCode.Append(" RoleName varchar(30) not Null, "); 
 // /**简化日期*/ 
 strCreateTabCode.Append(" OptDateSim varchar(50) not Null, "); 
 // /**最后访问时间*/ 
 strCreateTabCode.Append(" LastVisitedDateSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// UserPrjGrant(UserPrjGrant)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserPrjGrant : clsCommFun4BL
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
clsUserPrjGrantBL.ReFreshThisCache();
}
}

}