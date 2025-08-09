
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePrjMainPathBL
 表名:UserCodePrjMainPath(00050338)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsUserCodePrjMainPathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePrjMainPathEN GetObj(this K_UserCodePrjMainPathId_UserCodePrjMainPath myKey)
{
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.GetObjByUserCodePrjMainPathId(myKey.Value);
return objUserCodePrjMainPathEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPathEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecord)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.AddNewRecordBySQL2(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
public static bool AddRecordEx(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objUserCodePrjMainPathEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPathEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Cm工程应用关系Id(CMProjectAppRelaId)=[{0}],工程Id(PrjId)=[{1}],用户Id(UserId)=[{2}])已经存在,不能重复!", objUserCodePrjMainPathEN.CMProjectAppRelaId, objUserCodePrjMainPathEN.PrjId, objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objUserCodePrjMainPathEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPathEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecordWithMaxId)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
string strUserCodePrjMainPathId = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPathEN);
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
}
return strUserCodePrjMainPathId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPathEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecord(SqlTransaction))", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.AddNewRecordBySQL2(objUserCodePrjMainPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPathEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecordWithReturnKey)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
string strKey = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePrjMainPathEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecordWithReturnKey)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUserCodePrjMainPathId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUserCodePrjMainPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserCodePrjMainPathId, 8, conUserCodePrjMainPath.UserCodePrjMainPathId);
}
objUserCodePrjMainPathEN.UserCodePrjMainPathId = strUserCodePrjMainPathId; //生成主目录Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UserCodePrjMainPathId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UserCodePrjMainPathId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UserCodePrjMainPathId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetCMProjectAppRelaId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCMProjectAppRelaId, conUserCodePrjMainPath.CMProjectAppRelaId);
objUserCodePrjMainPathEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.CMProjectAppRelaId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.CMProjectAppRelaId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.CMProjectAppRelaId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetPrjId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserCodePrjMainPath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserCodePrjMainPath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserCodePrjMainPath.PrjId);
}
objUserCodePrjMainPathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.PrjId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.PrjId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.PrjId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetProgLangTypeId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conUserCodePrjMainPath.ProgLangTypeId);
}
objUserCodePrjMainPathEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.ProgLangTypeId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.ProgLangTypeId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.ProgLangTypeId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUserId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conUserCodePrjMainPath.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserCodePrjMainPath.UserId);
}
objUserCodePrjMainPathEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UserId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UserId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UserId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIsUsePrjMainPath(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsUsePrjMainPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUsePrjMainPath, conUserCodePrjMainPath.IsUsePrjMainPath);
objUserCodePrjMainPathEN.IsUsePrjMainPath = bolIsUsePrjMainPath; //是否使用主路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IsUsePrjMainPath) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IsUsePrjMainPath, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IsUsePrjMainPath] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIncludeXmlPath(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strIncludeXmlPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIncludeXmlPath, 150, conUserCodePrjMainPath.IncludeXmlPath);
}
objUserCodePrjMainPathEN.IncludeXmlPath = strIncludeXmlPath; //包含表Xml路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IncludeXmlPath) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IncludeXmlPath, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IncludeXmlPath] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetIsTemplate(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conUserCodePrjMainPath.IsTemplate);
objUserCodePrjMainPathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.IsTemplate) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.IsTemplate, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.IsTemplate] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetInUse(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conUserCodePrjMainPath.InUse);
objUserCodePrjMainPathEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.InUse) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.InUse, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.InUse] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUpdDate(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserCodePrjMainPath.UpdDate);
}
objUserCodePrjMainPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UpdDate) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UpdDate, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UpdDate] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetUpdUserId(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserCodePrjMainPath.UpdUserId);
}
objUserCodePrjMainPathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.UpdUserId) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.UpdUserId, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.UpdUserId] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePrjMainPathEN SetMemo(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserCodePrjMainPath.Memo);
}
objUserCodePrjMainPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePrjMainPathEN.dicFldComparisonOp.ContainsKey(conUserCodePrjMainPath.Memo) == false)
{
objUserCodePrjMainPathEN.dicFldComparisonOp.Add(conUserCodePrjMainPath.Memo, strComparisonOp);
}
else
{
objUserCodePrjMainPathEN.dicFldComparisonOp[conUserCodePrjMainPath.Memo] = strComparisonOp;
}
}
return objUserCodePrjMainPathEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserCodePrjMainPathEN.CheckPropertyNew();
clsUserCodePrjMainPathEN objUserCodePrjMainPathCond = new clsUserCodePrjMainPathEN();
string strCondition = objUserCodePrjMainPathCond
.SetUserCodePrjMainPathId(objUserCodePrjMainPathEN.UserCodePrjMainPathId, "<>")
.SetCMProjectAppRelaId(objUserCodePrjMainPathEN.CMProjectAppRelaId, "=")
.SetPrjId(objUserCodePrjMainPathEN.PrjId, "=")
.SetUserId(objUserCodePrjMainPathEN.UserId, "=")
.GetCombineCondition();
objUserCodePrjMainPathEN._IsCheckProperty = true;
bool bolIsExist = clsUserCodePrjMainPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ss)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserCodePrjMainPathEN.Update();
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
 /// <param name = "objUserCodePrjMainPath">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserCodePrjMainPathEN objUserCodePrjMainPath)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserCodePrjMainPathEN objUserCodePrjMainPathCond = new clsUserCodePrjMainPathEN();
string strCondition = objUserCodePrjMainPathCond
.SetCMProjectAppRelaId(objUserCodePrjMainPath.CMProjectAppRelaId, "=")
.SetPrjId(objUserCodePrjMainPath.PrjId, "=")
.SetUserId(objUserCodePrjMainPath.UserId, "=")
.GetCombineCondition();
objUserCodePrjMainPath._IsCheckProperty = true;
bool bolIsExist = clsUserCodePrjMainPathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserCodePrjMainPath.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetFirstID_S(strCondition);
objUserCodePrjMainPath.UpdateWithCondition(strCondition);
}
else
{
objUserCodePrjMainPath.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
objUserCodePrjMainPath.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.UpdateBySql2(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.UpdateBySql2(objUserCodePrjMainPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.UpdateBySql2(objUserCodePrjMainPathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strWhereCond)
{
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.UpdateBySqlWithCondition(objUserCodePrjMainPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.UpdateBySqlWithConditionTransaction(objUserCodePrjMainPathEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
public static int Delete(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
int intRecNum = clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.DelRecord(objUserCodePrjMainPathEN.UserCodePrjMainPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objUserCodePrjMainPathENT">目标对象</param>
 public static void CopyTo(this clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, clsUserCodePrjMainPathEN objUserCodePrjMainPathENT)
{
try
{
objUserCodePrjMainPathENT.UserCodePrjMainPathId = objUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPathENT.CMProjectAppRelaId = objUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePrjMainPathENT.PrjId = objUserCodePrjMainPathENS.PrjId; //工程Id
objUserCodePrjMainPathENT.ProgLangTypeId = objUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objUserCodePrjMainPathENT.UserId = objUserCodePrjMainPathENS.UserId; //用户Id
objUserCodePrjMainPathENT.IsUsePrjMainPath = objUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objUserCodePrjMainPathENT.IncludeXmlPath = objUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPathENT.IsTemplate = objUserCodePrjMainPathENS.IsTemplate; //是否模板
objUserCodePrjMainPathENT.InUse = objUserCodePrjMainPathENS.InUse; //是否在用
objUserCodePrjMainPathENT.UpdDate = objUserCodePrjMainPathENS.UpdDate; //修改日期
objUserCodePrjMainPathENT.UpdUserId = objUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objUserCodePrjMainPathENT.Memo = objUserCodePrjMainPathENS.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPathENS">源对象</param>
 /// <returns>目标对象=>clsUserCodePrjMainPathEN:objUserCodePrjMainPathENT</returns>
 public static clsUserCodePrjMainPathEN CopyTo(this clsUserCodePrjMainPathEN objUserCodePrjMainPathENS)
{
try
{
 clsUserCodePrjMainPathEN objUserCodePrjMainPathENT = new clsUserCodePrjMainPathEN()
{
UserCodePrjMainPathId = objUserCodePrjMainPathENS.UserCodePrjMainPathId, //生成主目录Id
CMProjectAppRelaId = objUserCodePrjMainPathENS.CMProjectAppRelaId, //Cm工程应用关系Id
PrjId = objUserCodePrjMainPathENS.PrjId, //工程Id
ProgLangTypeId = objUserCodePrjMainPathENS.ProgLangTypeId, //编程语言类型Id
UserId = objUserCodePrjMainPathENS.UserId, //用户Id
IsUsePrjMainPath = objUserCodePrjMainPathENS.IsUsePrjMainPath, //是否使用主路径
IncludeXmlPath = objUserCodePrjMainPathENS.IncludeXmlPath, //包含表Xml路径
IsTemplate = objUserCodePrjMainPathENS.IsTemplate, //是否模板
InUse = objUserCodePrjMainPathENS.InUse, //是否在用
UpdDate = objUserCodePrjMainPathENS.UpdDate, //修改日期
UpdUserId = objUserCodePrjMainPathENS.UpdUserId, //修改用户Id
Memo = objUserCodePrjMainPathENS.Memo, //说明
};
 return objUserCodePrjMainPathENT;
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
public static void CheckPropertyNew(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.CheckPropertyNew(objUserCodePrjMainPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 clsUserCodePrjMainPathBL.UserCodePrjMainPathDA.CheckProperty4Condition(objUserCodePrjMainPathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserCodePrjMainPathEN objUserCodePrjMainPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UserCodePrjMainPathId) == true)
{
string strComparisonOpUserCodePrjMainPathId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UserCodePrjMainPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UserCodePrjMainPathId, objUserCodePrjMainPathCond.UserCodePrjMainPathId, strComparisonOpUserCodePrjMainPathId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserCodePrjMainPath.CMProjectAppRelaId, objUserCodePrjMainPathCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.PrjId) == true)
{
string strComparisonOpPrjId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.PrjId, objUserCodePrjMainPathCond.PrjId, strComparisonOpPrjId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.ProgLangTypeId, objUserCodePrjMainPathCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UserId) == true)
{
string strComparisonOpUserId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UserId, objUserCodePrjMainPathCond.UserId, strComparisonOpUserId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IsUsePrjMainPath) == true)
{
if (objUserCodePrjMainPathCond.IsUsePrjMainPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.IsUsePrjMainPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.IsUsePrjMainPath);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IncludeXmlPath) == true)
{
string strComparisonOpIncludeXmlPath = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.IncludeXmlPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.IncludeXmlPath, objUserCodePrjMainPathCond.IncludeXmlPath, strComparisonOpIncludeXmlPath);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.IsTemplate) == true)
{
if (objUserCodePrjMainPathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.IsTemplate);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.InUse) == true)
{
if (objUserCodePrjMainPathCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePrjMainPath.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePrjMainPath.InUse);
}
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UpdDate, objUserCodePrjMainPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.UpdUserId, objUserCodePrjMainPathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserCodePrjMainPathCond.IsUpdated(conUserCodePrjMainPath.Memo) == true)
{
string strComparisonOpMemo = objUserCodePrjMainPathCond.dicFldComparisonOp[conUserCodePrjMainPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePrjMainPath.Memo, objUserCodePrjMainPathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserCodePrjMainPath(用户生成项目主路径), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMProjectAppRelaId_PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPathEN == null) return true;
if (objUserCodePrjMainPathEN.UserCodePrjMainPathId == null || objUserCodePrjMainPathEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
if (clsUserCodePrjMainPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPathEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
if (clsUserCodePrjMainPathBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserCodePrjMainPath(用户生成项目主路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMProjectAppRelaId_PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePrjMainPathEN == null) return "";
if (objUserCodePrjMainPathEN.UserCodePrjMainPathId == null || objUserCodePrjMainPathEN.UserCodePrjMainPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("UserCodePrjMainPathId !=  '{0}'", objUserCodePrjMainPathEN.UserCodePrjMainPathId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePrjMainPathEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserCodePrjMainPathEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserCodePrjMainPathEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserCodePrjMainPath
{
public virtual bool UpdRelaTabDate(string strUserCodePrjMainPathId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserCodePrjMainPathBL
{
public static RelatedActions_UserCodePrjMainPath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserCodePrjMainPathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserCodePrjMainPathDA UserCodePrjMainPathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserCodePrjMainPathDA();
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
 public clsUserCodePrjMainPathBL()
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
if (string.IsNullOrEmpty(clsUserCodePrjMainPathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePrjMainPathEN._ConnectString);
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
public static DataTable GetDataTable_UserCodePrjMainPath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserCodePrjMainPathDA.GetDataTable_UserCodePrjMainPath(strWhereCond);
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
objDT = UserCodePrjMainPathDA.GetDataTable(strWhereCond);
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
objDT = UserCodePrjMainPathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserCodePrjMainPathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserCodePrjMainPathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserCodePrjMainPathDA.GetDataTable_Top(objTopPara);
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
objDT = UserCodePrjMainPathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserCodePrjMainPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserCodePrjMainPathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrUserCodePrjMainPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLst(List<string> arrUserCodePrjMainPathIdLst)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrUserCodePrjMainPathIdLst, true);
 string strWhereCond = string.Format("UserCodePrjMainPathId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrUserCodePrjMainPathIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserCodePrjMainPathEN> GetObjLstByUserCodePrjMainPathIdLstCache(List<string> arrUserCodePrjMainPathIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel =
arrUserCodePrjMainPathObjLstCache
.Where(x => arrUserCodePrjMainPathIdLst.Contains(x.UserCodePrjMainPathId));
return arrUserCodePrjMainPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLst(string strWhereCond)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
public static List<clsUserCodePrjMainPathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserCodePrjMainPathEN> GetSubObjLstCache(clsUserCodePrjMainPathEN objUserCodePrjMainPathCond)
{
 string strPrjId = objUserCodePrjMainPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsUserCodePrjMainPathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsUserCodePrjMainPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePrjMainPath._AttributeName)
{
if (objUserCodePrjMainPathCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePrjMainPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPathCond[strFldName].ToString());
}
else
{
if (objUserCodePrjMainPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePrjMainPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePrjMainPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPathCond[strFldName]));
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
List<clsUserCodePrjMainPathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserCodePrjMainPathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserCodePrjMainPathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
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
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
public static List<clsUserCodePrjMainPathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
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
public static List<clsUserCodePrjMainPathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserCodePrjMainPathEN> arrObjLst = new List<clsUserCodePrjMainPathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = new clsUserCodePrjMainPathEN();
try
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[conUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePrjMainPathEN.PrjId = objRow[conUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objUserCodePrjMainPathEN.ProgLangTypeId = objRow[conUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objUserCodePrjMainPathEN.UserId = objRow[conUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objUserCodePrjMainPathEN.IncludeXmlPath = objRow[conUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objUserCodePrjMainPathEN.UpdDate = objRow[conUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objUserCodePrjMainPathEN.UpdUserId = objRow[conUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePrjMainPathEN.Memo = objRow[conUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[conUserCodePrjMainPath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePrjMainPathEN.UserCodePrjMainPathId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePrjMainPathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserCodePrjMainPath(ref clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
bool bolResult = UserCodePrjMainPathDA.GetUserCodePrjMainPath(ref objUserCodePrjMainPathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
if (strUserCodePrjMainPathId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strUserCodePrjMainPathId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strUserCodePrjMainPathId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = UserCodePrjMainPathDA.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
return objUserCodePrjMainPathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserCodePrjMainPathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = UserCodePrjMainPathDA.GetFirstObj(strWhereCond);
 return objUserCodePrjMainPathEN;
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
public static clsUserCodePrjMainPathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = UserCodePrjMainPathDA.GetObjByDataRow(objRow);
 return objUserCodePrjMainPathEN;
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
public static clsUserCodePrjMainPathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = UserCodePrjMainPathDA.GetObjByDataRow(objRow);
 return objUserCodePrjMainPathEN;
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
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <param name = "lstUserCodePrjMainPathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathIdFromList(string strUserCodePrjMainPathId, List<clsUserCodePrjMainPathEN> lstUserCodePrjMainPathObjLst)
{
foreach (clsUserCodePrjMainPathEN objUserCodePrjMainPathEN in lstUserCodePrjMainPathObjLst)
{
if (objUserCodePrjMainPathEN.UserCodePrjMainPathId == strUserCodePrjMainPathId)
{
return objUserCodePrjMainPathEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxUserCodePrjMainPathId;
 try
 {
 strMaxUserCodePrjMainPathId = clsUserCodePrjMainPathDA.GetMaxStrId();
 return strMaxUserCodePrjMainPathId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

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
 strUserCodePrjMainPathId = new clsUserCodePrjMainPathDA().GetFirstID(strWhereCond);
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
 arrList = UserCodePrjMainPathDA.GetID(strWhereCond);
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
bool bolIsExist = UserCodePrjMainPathDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strUserCodePrjMainPathId)
{
if (string.IsNullOrEmpty(strUserCodePrjMainPathId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strUserCodePrjMainPathId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = UserCodePrjMainPathDA.IsExist(strUserCodePrjMainPathId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strUserCodePrjMainPathId">生成主目录Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strUserCodePrjMainPathId, string strOpUser)
{
clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
objUserCodePrjMainPathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserCodePrjMainPathEN.UpdUserId = strOpUser;
return clsUserCodePrjMainPathBL.UpdateBySql2(objUserCodePrjMainPathEN);
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
 bolIsExist = clsUserCodePrjMainPathDA.IsExistTable();
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
 bolIsExist = UserCodePrjMainPathDA.IsExistTable(strTabName);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecordBySql2)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
bool bolResult = UserCodePrjMainPathDA.AddNewRecordBySQL2(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserCodePrjMainPathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程应用关系Id = [{0}],工程Id = [{1}],用户Id = [{2}]的数据已经存在!(in clsUserCodePrjMainPathBL.AddNewRecordBySql2WithReturnKey)", objUserCodePrjMainPathEN.CMProjectAppRelaId,objUserCodePrjMainPathEN.PrjId,objUserCodePrjMainPathEN.UserId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true || clsUserCodePrjMainPathBL.IsExist(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
     objUserCodePrjMainPathEN.UserCodePrjMainPathId = clsUserCodePrjMainPathBL.GetMaxStrId_S();
 }
string strKey = UserCodePrjMainPathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
bool bolResult = UserCodePrjMainPathDA.Update(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
 /// <param name = "objUserCodePrjMainPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 if (string.IsNullOrEmpty(objUserCodePrjMainPathEN.UserCodePrjMainPathId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserCodePrjMainPathDA.UpdateBySql2(objUserCodePrjMainPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePrjMainPathBL.ReFreshCache(objUserCodePrjMainPathEN.PrjId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
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
public static int DelRecord(string strUserCodePrjMainPathId)
{
try
{
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);

if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(objUserCodePrjMainPathEN.UserCodePrjMainPathId, objUserCodePrjMainPathEN.UpdUserId);
}
if (objUserCodePrjMainPathEN != null)
{
int intRecNum = UserCodePrjMainPathDA.DelRecord(strUserCodePrjMainPathId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePrjMainPathEN.PrjId);
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
public static bool DelRecordEx(string strUserCodePrjMainPathId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
//删除与表:[UserCodePrjMainPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserCodePrjMainPath.UserCodePrjMainPathId,
//strUserCodePrjMainPathId);
//        clsUserCodePrjMainPathBL.DelUserCodePrjMainPathsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePrjMainPathBL.DelRecord(strUserCodePrjMainPathId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePrjMainPathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(string strUserCodePrjMainPathId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserCodePrjMainPathBL.relatedActions != null)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId, "UpdRelaTabDate");
}
bool bolResult = UserCodePrjMainPathDA.DelRecord(strUserCodePrjMainPathId,objSqlConnection,objSqlTransaction);
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
public static int DelUserCodePrjMainPaths(List<string> arrUserCodePrjMainPathIdLst)
{
if (arrUserCodePrjMainPathIdLst.Count == 0) return 0;
try
{
if (clsUserCodePrjMainPathBL.relatedActions != null)
{
foreach (var strUserCodePrjMainPathId in arrUserCodePrjMainPathIdLst)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId, "UpdRelaTabDate");
}
}
 clsUserCodePrjMainPathEN objUserCodePrjMainPathEN = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(arrUserCodePrjMainPathIdLst[0]);
int intDelRecNum = UserCodePrjMainPathDA.DelUserCodePrjMainPath(arrUserCodePrjMainPathIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePrjMainPathEN.PrjId);
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
public static int DelUserCodePrjMainPathsByCond(string strWhereCond)
{
try
{
if (clsUserCodePrjMainPathBL.relatedActions != null)
{
List<string> arrUserCodePrjMainPathId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserCodePrjMainPathId in arrUserCodePrjMainPathId)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conUserCodePrjMainPath.PrjId, strWhereCond);
int intRecNum = UserCodePrjMainPathDA.DelUserCodePrjMainPath(strWhereCond);
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
public static bool DelUserCodePrjMainPathsByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserCodePrjMainPathBL.relatedActions != null)
{
List<string> arrUserCodePrjMainPathId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strUserCodePrjMainPathId in arrUserCodePrjMainPathId)
{
clsUserCodePrjMainPathBL.relatedActions.UpdRelaTabDate(strUserCodePrjMainPathId, "UpdRelaTabDate");
}
}
bool bolResult = UserCodePrjMainPathDA.DelUserCodePrjMainPathWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserCodePrjMainPath]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strUserCodePrjMainPathId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strUserCodePrjMainPathId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePrjMainPathDA.GetSpecSQLObj();
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
//删除与表:[UserCodePrjMainPath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePrjMainPathBL.DelRecord(strUserCodePrjMainPathId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePrjMainPathBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objUserCodePrjMainPathENT">目标对象</param>
 public static void CopyTo(clsUserCodePrjMainPathEN objUserCodePrjMainPathENS, clsUserCodePrjMainPathEN objUserCodePrjMainPathENT)
{
try
{
objUserCodePrjMainPathENT.UserCodePrjMainPathId = objUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objUserCodePrjMainPathENT.CMProjectAppRelaId = objUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePrjMainPathENT.PrjId = objUserCodePrjMainPathENS.PrjId; //工程Id
objUserCodePrjMainPathENT.ProgLangTypeId = objUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objUserCodePrjMainPathENT.UserId = objUserCodePrjMainPathENS.UserId; //用户Id
objUserCodePrjMainPathENT.IsUsePrjMainPath = objUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objUserCodePrjMainPathENT.IncludeXmlPath = objUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objUserCodePrjMainPathENT.IsTemplate = objUserCodePrjMainPathENS.IsTemplate; //是否模板
objUserCodePrjMainPathENT.InUse = objUserCodePrjMainPathENS.InUse; //是否在用
objUserCodePrjMainPathENT.UpdDate = objUserCodePrjMainPathENS.UpdDate; //修改日期
objUserCodePrjMainPathENT.UpdUserId = objUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objUserCodePrjMainPathENT.Memo = objUserCodePrjMainPathENS.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPathEN">源简化对象</param>
 public static void SetUpdFlag(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
objUserCodePrjMainPathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserCodePrjMainPathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserCodePrjMainPath.UserCodePrjMainPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.UserCodePrjMainPathId = objUserCodePrjMainPathEN.UserCodePrjMainPathId; //生成主目录Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.CMProjectAppRelaId = objUserCodePrjMainPathEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.PrjId = objUserCodePrjMainPathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.ProgLangTypeId = objUserCodePrjMainPathEN.ProgLangTypeId == "[null]" ? null :  objUserCodePrjMainPathEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.UserId = objUserCodePrjMainPathEN.UserId; //用户Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.IsUsePrjMainPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.IsUsePrjMainPath = objUserCodePrjMainPathEN.IsUsePrjMainPath; //是否使用主路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath.IncludeXmlPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.IncludeXmlPath = objUserCodePrjMainPathEN.IncludeXmlPath == "[null]" ? null :  objUserCodePrjMainPathEN.IncludeXmlPath; //包含表Xml路径
}
if (arrFldSet.Contains(conUserCodePrjMainPath.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.IsTemplate = objUserCodePrjMainPathEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conUserCodePrjMainPath.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.InUse = objUserCodePrjMainPathEN.InUse; //是否在用
}
if (arrFldSet.Contains(conUserCodePrjMainPath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.UpdDate = objUserCodePrjMainPathEN.UpdDate == "[null]" ? null :  objUserCodePrjMainPathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserCodePrjMainPath.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.UpdUserId = objUserCodePrjMainPathEN.UpdUserId == "[null]" ? null :  objUserCodePrjMainPathEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conUserCodePrjMainPath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePrjMainPathEN.Memo = objUserCodePrjMainPathEN.Memo == "[null]" ? null :  objUserCodePrjMainPathEN.Memo; //说明
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
 /// <param name = "objUserCodePrjMainPathEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
try
{
if (objUserCodePrjMainPathEN.ProgLangTypeId == "[null]") objUserCodePrjMainPathEN.ProgLangTypeId = null; //编程语言类型Id
if (objUserCodePrjMainPathEN.IncludeXmlPath == "[null]") objUserCodePrjMainPathEN.IncludeXmlPath = null; //包含表Xml路径
if (objUserCodePrjMainPathEN.UpdDate == "[null]") objUserCodePrjMainPathEN.UpdDate = null; //修改日期
if (objUserCodePrjMainPathEN.UpdUserId == "[null]") objUserCodePrjMainPathEN.UpdUserId = null; //修改用户Id
if (objUserCodePrjMainPathEN.Memo == "[null]") objUserCodePrjMainPathEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 UserCodePrjMainPathDA.CheckPropertyNew(objUserCodePrjMainPathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
 UserCodePrjMainPathDA.CheckProperty4Condition(objUserCodePrjMainPathEN);
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
if (clsUserCodePrjMainPathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePrjMainPathBL没有刷新缓存机制(clsUserCodePrjMainPathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by UserCodePrjMainPathId");
//if (arrUserCodePrjMainPathObjLstCache == null)
//{
//arrUserCodePrjMainPathObjLstCache = UserCodePrjMainPathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePrjMainPathEN GetObjByUserCodePrjMainPathIdCache(string strUserCodePrjMainPathId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel =
arrUserCodePrjMainPathObjLstCache
.Where(x=> x.UserCodePrjMainPathId == strUserCodePrjMainPathId 
);
if (arrUserCodePrjMainPathObjLst_Sel.Count() == 0)
{
   clsUserCodePrjMainPathEN obj = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathId(strUserCodePrjMainPathId);
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
return arrUserCodePrjMainPathObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetAllUserCodePrjMainPathObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId); 
return arrUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePrjMainPathEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrUserCodePrjMainPathObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:PrjId字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrUserCodePrjMainPathObjLst">需要排序的对象列表</param>
public static List <clsUserCodePrjMainPathEN> GetSubSet4UserCodePrjMainPathObjLstByPrjIdCache(string strPrjId)
{
   if (string.IsNullOrEmpty(strPrjId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
List<clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel1 =
from objUserCodePrjMainPathEN in arrUserCodePrjMainPathObjLstCache
where objUserCodePrjMainPathEN.PrjId == strPrjId
select objUserCodePrjMainPathEN;
List <clsUserCodePrjMainPathEN> arrUserCodePrjMainPathObjLst_Sel = new List<clsUserCodePrjMainPathEN>();
foreach (clsUserCodePrjMainPathEN obj in arrUserCodePrjMainPathObjLst_Sel1)
{
arrUserCodePrjMainPathObjLst_Sel.Add(obj);
}
return arrUserCodePrjMainPathObjLst_Sel;
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
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserCodePrjMainPathEN._RefreshTimeLst.Count == 0) return "";
return clsUserCodePrjMainPathEN._RefreshTimeLst[clsUserCodePrjMainPathEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsUserCodePrjMainPathBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsUserCodePrjMainPathBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsUserCodePrjMainPathBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserCodePrjMainPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePrjMainPathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserCodePrjMainPathBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserCodePrjMainPath(用户生成项目主路径)
 /// 唯一性条件:CMProjectAppRelaId_PrjId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserCodePrjMainPathEN objUserCodePrjMainPathEN)
{
//检测记录是否存在
string strResult = UserCodePrjMainPathDA.GetUniCondStr(objUserCodePrjMainPathEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strUserCodePrjMainPathId, string strPrjId)
{
if (strInFldName != conUserCodePrjMainPath.UserCodePrjMainPathId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserCodePrjMainPath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserCodePrjMainPath._AttributeName));
throw new Exception(strMsg);
}
var objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetObjByUserCodePrjMainPathIdCache(strUserCodePrjMainPathId, strPrjId);
if (objUserCodePrjMainPath == null) return "";
return objUserCodePrjMainPath[strOutFldName].ToString();
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
int intRecCount = clsUserCodePrjMainPathDA.GetRecCount(strTabName);
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
int intRecCount = clsUserCodePrjMainPathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserCodePrjMainPathDA.GetRecCount();
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
int intRecCount = clsUserCodePrjMainPathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserCodePrjMainPathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserCodePrjMainPathEN objUserCodePrjMainPathCond)
{
 string strPrjId = objUserCodePrjMainPathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsUserCodePrjMainPathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsUserCodePrjMainPathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePrjMainPathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePrjMainPath._AttributeName)
{
if (objUserCodePrjMainPathCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePrjMainPathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPathCond[strFldName].ToString());
}
else
{
if (objUserCodePrjMainPathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePrjMainPathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePrjMainPathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePrjMainPathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePrjMainPathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePrjMainPathCond[strFldName]));
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
 List<string> arrList = clsUserCodePrjMainPathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserCodePrjMainPathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserCodePrjMainPathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserCodePrjMainPathDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPathDA.SetFldValue(clsUserCodePrjMainPathEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserCodePrjMainPathDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPathDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPathDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePrjMainPathDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserCodePrjMainPath] "); 
 strCreateTabCode.Append(" ( "); 
 // /**生成主目录Id*/ 
 strCreateTabCode.Append(" UserCodePrjMainPathId char(8) primary key, "); 
 // /**Cm工程应用关系Id*/ 
 strCreateTabCode.Append(" CMProjectAppRelaId bigint not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**编程语言类型Id*/ 
 strCreateTabCode.Append(" ProgLangTypeId char(2) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null, "); 
 // /**是否使用主路径*/ 
 strCreateTabCode.Append(" IsUsePrjMainPath bit not Null, "); 
 // /**包含表Xml路径*/ 
 strCreateTabCode.Append(" IncludeXmlPath varchar(150) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**编程语言类型名*/ 
 strCreateTabCode.Append(" ProgLangTypeName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户生成项目主路径(UserCodePrjMainPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserCodePrjMainPath : clsCommFun4BLV2
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
clsUserCodePrjMainPathBL.ReFreshThisCache(strPrjId);
}
}

}