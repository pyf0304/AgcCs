
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserCodePathBL
 表名:UserCodePath(00050204)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:59:48
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
public static class  clsUserCodePathBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePathEN GetObj(this K_mId_UserCodePath myKey)
{
clsUserCodePathEN objUserCodePathEN = clsUserCodePathBL.UserCodePathDA.GetObjBymId(myKey.Value);
return objUserCodePathEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePathEN objUserCodePathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePathEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecord)", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.AddNewRecordBySQL2(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
public static bool AddRecordEx(this clsUserCodePathEN objUserCodePathEN, bool bolIsNeedCheckUniqueness = true)
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
objUserCodePathEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserCodePathEN.CheckUniqueness() == false)
{
strMsg = string.Format("(代码类型Id(CodeTypeId)=[{0}],Cm工程应用关系Id(CMProjectAppRelaId)=[{1}])已经存在,不能重复!", objUserCodePathEN.CodeTypeId, objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserCodePathEN.AddNewRecord();
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePathEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecord(SqlTransaction))", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.AddNewRecordBySQL2(objUserCodePathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserCodePathEN objUserCodePathEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePathEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecordWithReturnKey)", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserCodePathBL.UserCodePathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserCodePathEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecordWithReturnKey)", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserCodePathBL.UserCodePathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetmId(this clsUserCodePathEN objUserCodePathEN, long lngmId, string strComparisonOp="")
	{
objUserCodePathEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.mId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.mId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.mId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetCMProjectAppRelaId(this clsUserCodePathEN objUserCodePathEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngCMProjectAppRelaId, conUserCodePath.CMProjectAppRelaId);
objUserCodePathEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.CMProjectAppRelaId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.CMProjectAppRelaId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.CMProjectAppRelaId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetCodeTypeId(this clsUserCodePathEN objUserCodePathEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, conUserCodePath.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conUserCodePath.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conUserCodePath.CodeTypeId);
}
objUserCodePathEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.CodeTypeId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.CodeTypeId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.CodeTypeId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetTabMainTypeId(this clsUserCodePathEN objUserCodePathEN, string strTabMainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, conUserCodePath.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, conUserCodePath.TabMainTypeId);
}
objUserCodePathEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.TabMainTypeId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.TabMainTypeId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.TabMainTypeId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetIsGeneCode(this clsUserCodePathEN objUserCodePathEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objUserCodePathEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.IsGeneCode) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.IsGeneCode, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.IsGeneCode] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetProjectFileName(this clsUserCodePathEN objUserCodePathEN, string strProjectFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectFileName, 200, conUserCodePath.ProjectFileName);
}
objUserCodePathEN.ProjectFileName = strProjectFileName; //工程文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.ProjectFileName) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.ProjectFileName, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.ProjectFileName] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetProjectPath(this clsUserCodePathEN objUserCodePathEN, string strProjectPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectPath, 500, conUserCodePath.ProjectPath);
}
objUserCodePathEN.ProjectPath = strProjectPath; //工程路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.ProjectPath) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.ProjectPath, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.ProjectPath] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetPrjFileStateId(this clsUserCodePathEN objUserCodePathEN, string strPrjFileStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjFileStateId, 2, conUserCodePath.PrjFileStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjFileStateId, 2, conUserCodePath.PrjFileStateId);
}
objUserCodePathEN.PrjFileStateId = strPrjFileStateId; //工程文件状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.PrjFileStateId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.PrjFileStateId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.PrjFileStateId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetCodePath(this clsUserCodePathEN objUserCodePathEN, string strCodePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePath, conUserCodePath.CodePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePath, 200, conUserCodePath.CodePath);
}
objUserCodePathEN.CodePath = strCodePath; //代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.CodePath) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.CodePath, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.CodePath] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetGcPathId(this clsUserCodePathEN objUserCodePathEN, string strGcPathId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGcPathId, 8, conUserCodePath.GcPathId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGcPathId, 8, conUserCodePath.GcPathId);
}
objUserCodePathEN.GcPathId = strGcPathId; //GC路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.GcPathId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.GcPathId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.GcPathId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetCodePathBackup(this clsUserCodePathEN objUserCodePathEN, string strCodePathBackup, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodePathBackup, conUserCodePath.CodePathBackup);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodePathBackup, 200, conUserCodePath.CodePathBackup);
}
objUserCodePathEN.CodePathBackup = strCodePathBackup; //备份代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.CodePathBackup) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.CodePathBackup, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.CodePathBackup] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetSuffixPath(this clsUserCodePathEN objUserCodePathEN, string strSuffixPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSuffixPath, 50, conUserCodePath.SuffixPath);
}
objUserCodePathEN.SuffixPath = strSuffixPath; //后缀路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.SuffixPath) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.SuffixPath, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.SuffixPath] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetIsTemplate(this clsUserCodePathEN objUserCodePathEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conUserCodePath.IsTemplate);
objUserCodePathEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.IsTemplate) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.IsTemplate, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.IsTemplate] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetIsExistCodePath(this clsUserCodePathEN objUserCodePathEN, bool bolIsExistCodePath, string strComparisonOp="")
	{
objUserCodePathEN.IsExistCodePath = bolIsExistCodePath; //是否存在代码路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.IsExistCodePath) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.IsExistCodePath, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.IsExistCodePath] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetIsExistCodePathBackup(this clsUserCodePathEN objUserCodePathEN, bool bolIsExistCodePathBackup, string strComparisonOp="")
	{
objUserCodePathEN.IsExistCodePathBackup = bolIsExistCodePathBackup; //是否存在备份路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.IsExistCodePathBackup) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.IsExistCodePathBackup, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.IsExistCodePathBackup] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetPrjId(this clsUserCodePathEN objUserCodePathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conUserCodePath.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conUserCodePath.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conUserCodePath.PrjId);
}
objUserCodePathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.PrjId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.PrjId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.PrjId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetUpdDate(this clsUserCodePathEN objUserCodePathEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserCodePath.UpdDate);
}
objUserCodePathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.UpdDate) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.UpdDate, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.UpdDate] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetUpdUserId(this clsUserCodePathEN objUserCodePathEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conUserCodePath.UpdUserId);
}
objUserCodePathEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.UpdUserId) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.UpdUserId, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.UpdUserId] = strComparisonOp;
}
}
return objUserCodePathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserCodePathEN SetMemo(this clsUserCodePathEN objUserCodePathEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserCodePath.Memo);
}
objUserCodePathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserCodePathEN.dicFldComparisonOp.ContainsKey(conUserCodePath.Memo) == false)
{
objUserCodePathEN.dicFldComparisonOp.Add(conUserCodePath.Memo, strComparisonOp);
}
else
{
objUserCodePathEN.dicFldComparisonOp[conUserCodePath.Memo] = strComparisonOp;
}
}
return objUserCodePathEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserCodePathEN objUserCodePathEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserCodePathEN.CheckPropertyNew();
clsUserCodePathEN objUserCodePathCond = new clsUserCodePathEN();
string strCondition = objUserCodePathCond
.SetmId(objUserCodePathEN.mId, "<>")
.SetCodeTypeId(objUserCodePathEN.CodeTypeId, "=")
.SetCMProjectAppRelaId(objUserCodePathEN.CMProjectAppRelaId, "=")
.GetCombineCondition();
objUserCodePathEN._IsCheckProperty = true;
bool bolIsExist = clsUserCodePathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ApplicationTypeId_CodeTypeId_UserCodePrjMainPathId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserCodePathEN.Update();
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
 /// <param name = "objUserCodePath">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserCodePathEN objUserCodePath)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserCodePathEN objUserCodePathCond = new clsUserCodePathEN();
string strCondition = objUserCodePathCond
.SetCodeTypeId(objUserCodePath.CodeTypeId, "=")
.SetCMProjectAppRelaId(objUserCodePath.CMProjectAppRelaId, "=")
.GetCombineCondition();
objUserCodePath._IsCheckProperty = true;
bool bolIsExist = clsUserCodePathBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserCodePath.mId = clsUserCodePathBL.GetFirstID_S(strCondition);
objUserCodePath.UpdateWithCondition(strCondition);
}
else
{
objUserCodePath.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePathEN objUserCodePathEN)
{
 if (objUserCodePathEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.UpdateBySql2(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserCodePathEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.UpdateBySql2(objUserCodePathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserCodePathEN objUserCodePathEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserCodePathEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.UpdateBySql2(objUserCodePathEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePathEN objUserCodePathEN, string strWhereCond)
{
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.UpdateBySqlWithCondition(objUserCodePathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserCodePathEN objUserCodePathEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserCodePathBL.UserCodePathDA.UpdateBySqlWithConditionTransaction(objUserCodePathEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
public static int Delete(this clsUserCodePathEN objUserCodePathEN)
{
try
{
int intRecNum = clsUserCodePathBL.UserCodePathDA.DelRecord(objUserCodePathEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathENS">源对象</param>
 /// <param name = "objUserCodePathENT">目标对象</param>
 public static void CopyTo(this clsUserCodePathEN objUserCodePathENS, clsUserCodePathEN objUserCodePathENT)
{
try
{
objUserCodePathENT.mId = objUserCodePathENS.mId; //mId
objUserCodePathENT.CMProjectAppRelaId = objUserCodePathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePathENT.CodeTypeId = objUserCodePathENS.CodeTypeId; //代码类型Id
objUserCodePathENT.TabMainTypeId = objUserCodePathENS.TabMainTypeId; //表主类型Id
objUserCodePathENT.IsGeneCode = objUserCodePathENS.IsGeneCode; //是否生成代码
objUserCodePathENT.ProjectFileName = objUserCodePathENS.ProjectFileName; //工程文件名
objUserCodePathENT.ProjectPath = objUserCodePathENS.ProjectPath; //工程路径
objUserCodePathENT.PrjFileStateId = objUserCodePathENS.PrjFileStateId; //工程文件状态Id
objUserCodePathENT.CodePath = objUserCodePathENS.CodePath; //代码路径
objUserCodePathENT.GcPathId = objUserCodePathENS.GcPathId; //GC路径Id
objUserCodePathENT.CodePathBackup = objUserCodePathENS.CodePathBackup; //备份代码路径
objUserCodePathENT.SuffixPath = objUserCodePathENS.SuffixPath; //后缀路径
objUserCodePathENT.IsTemplate = objUserCodePathENS.IsTemplate; //是否模板
objUserCodePathENT.IsExistCodePath = objUserCodePathENS.IsExistCodePath; //是否存在代码路径
objUserCodePathENT.IsExistCodePathBackup = objUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
objUserCodePathENT.PrjId = objUserCodePathENS.PrjId; //工程Id
objUserCodePathENT.UpdDate = objUserCodePathENS.UpdDate; //修改日期
objUserCodePathENT.UpdUserId = objUserCodePathENS.UpdUserId; //修改用户Id
objUserCodePathENT.Memo = objUserCodePathENS.Memo; //说明
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
 /// <param name = "objUserCodePathENS">源对象</param>
 /// <returns>目标对象=>clsUserCodePathEN:objUserCodePathENT</returns>
 public static clsUserCodePathEN CopyTo(this clsUserCodePathEN objUserCodePathENS)
{
try
{
 clsUserCodePathEN objUserCodePathENT = new clsUserCodePathEN()
{
mId = objUserCodePathENS.mId, //mId
CMProjectAppRelaId = objUserCodePathENS.CMProjectAppRelaId, //Cm工程应用关系Id
CodeTypeId = objUserCodePathENS.CodeTypeId, //代码类型Id
TabMainTypeId = objUserCodePathENS.TabMainTypeId, //表主类型Id
IsGeneCode = objUserCodePathENS.IsGeneCode, //是否生成代码
ProjectFileName = objUserCodePathENS.ProjectFileName, //工程文件名
ProjectPath = objUserCodePathENS.ProjectPath, //工程路径
PrjFileStateId = objUserCodePathENS.PrjFileStateId, //工程文件状态Id
CodePath = objUserCodePathENS.CodePath, //代码路径
GcPathId = objUserCodePathENS.GcPathId, //GC路径Id
CodePathBackup = objUserCodePathENS.CodePathBackup, //备份代码路径
SuffixPath = objUserCodePathENS.SuffixPath, //后缀路径
IsTemplate = objUserCodePathENS.IsTemplate, //是否模板
IsExistCodePath = objUserCodePathENS.IsExistCodePath, //是否存在代码路径
IsExistCodePathBackup = objUserCodePathENS.IsExistCodePathBackup, //是否存在备份路径
PrjId = objUserCodePathENS.PrjId, //工程Id
UpdDate = objUserCodePathENS.UpdDate, //修改日期
UpdUserId = objUserCodePathENS.UpdUserId, //修改用户Id
Memo = objUserCodePathENS.Memo, //说明
};
 return objUserCodePathENT;
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
public static void CheckPropertyNew(this clsUserCodePathEN objUserCodePathEN)
{
 clsUserCodePathBL.UserCodePathDA.CheckPropertyNew(objUserCodePathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserCodePathEN objUserCodePathEN)
{
 clsUserCodePathBL.UserCodePathDA.CheckProperty4Condition(objUserCodePathEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserCodePathEN objUserCodePathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserCodePathCond.IsUpdated(conUserCodePath.mId) == true)
{
string strComparisonOpmId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserCodePath.mId, objUserCodePathCond.mId, strComparisonOpmId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserCodePath.CMProjectAppRelaId, objUserCodePathCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.CodeTypeId, objUserCodePathCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.TabMainTypeId, objUserCodePathCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.IsGeneCode) == true)
{
if (objUserCodePathCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePath.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePath.IsGeneCode);
}
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.ProjectFileName) == true)
{
string strComparisonOpProjectFileName = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.ProjectFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.ProjectFileName, objUserCodePathCond.ProjectFileName, strComparisonOpProjectFileName);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.ProjectPath) == true)
{
string strComparisonOpProjectPath = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.ProjectPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.ProjectPath, objUserCodePathCond.ProjectPath, strComparisonOpProjectPath);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.PrjFileStateId) == true)
{
string strComparisonOpPrjFileStateId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.PrjFileStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.PrjFileStateId, objUserCodePathCond.PrjFileStateId, strComparisonOpPrjFileStateId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.CodePath) == true)
{
string strComparisonOpCodePath = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.CodePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.CodePath, objUserCodePathCond.CodePath, strComparisonOpCodePath);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.GcPathId) == true)
{
string strComparisonOpGcPathId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.GcPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.GcPathId, objUserCodePathCond.GcPathId, strComparisonOpGcPathId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.CodePathBackup) == true)
{
string strComparisonOpCodePathBackup = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.CodePathBackup];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.CodePathBackup, objUserCodePathCond.CodePathBackup, strComparisonOpCodePathBackup);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.SuffixPath) == true)
{
string strComparisonOpSuffixPath = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.SuffixPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.SuffixPath, objUserCodePathCond.SuffixPath, strComparisonOpSuffixPath);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.IsTemplate) == true)
{
if (objUserCodePathCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePath.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePath.IsTemplate);
}
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.IsExistCodePath) == true)
{
if (objUserCodePathCond.IsExistCodePath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePath.IsExistCodePath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePath.IsExistCodePath);
}
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.IsExistCodePathBackup) == true)
{
if (objUserCodePathCond.IsExistCodePathBackup == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserCodePath.IsExistCodePathBackup);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserCodePath.IsExistCodePathBackup);
}
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.PrjId) == true)
{
string strComparisonOpPrjId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.PrjId, objUserCodePathCond.PrjId, strComparisonOpPrjId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.UpdDate, objUserCodePathCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.UpdUserId, objUserCodePathCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objUserCodePathCond.IsUpdated(conUserCodePath.Memo) == true)
{
string strComparisonOpMemo = objUserCodePathCond.dicFldComparisonOp[conUserCodePath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserCodePath.Memo, objUserCodePathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserCodePath(用户生成路径), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMProjectAppRelaId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserCodePathEN objUserCodePathEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePathEN == null) return true;
if (objUserCodePathEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objUserCodePathEN.CodeTypeId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePathEN.CMProjectAppRelaId);
if (clsUserCodePathBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserCodePathEN.mId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objUserCodePathEN.CodeTypeId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePathEN.CMProjectAppRelaId);
if (clsUserCodePathBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserCodePath(用户生成路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMProjectAppRelaId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserCodePathEN objUserCodePathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserCodePathEN == null) return "";
if (objUserCodePathEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objUserCodePathEN.CodeTypeId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePathEN.CMProjectAppRelaId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objUserCodePathEN.mId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objUserCodePathEN.CodeTypeId);
 sbCondition.AppendFormat(" and CMProjectAppRelaId = '{0}'", objUserCodePathEN.CMProjectAppRelaId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserCodePath
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户生成路径(UserCodePath)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserCodePathBL
{
public static RelatedActions_UserCodePath relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserCodePathDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserCodePathDA UserCodePathDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserCodePathDA();
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
 public clsUserCodePathBL()
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
if (string.IsNullOrEmpty(clsUserCodePathEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserCodePathEN._ConnectString);
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
public static DataTable GetDataTable_UserCodePath(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserCodePathDA.GetDataTable_UserCodePath(strWhereCond);
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
objDT = UserCodePathDA.GetDataTable(strWhereCond);
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
objDT = UserCodePathDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserCodePathDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserCodePathDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserCodePathDA.GetDataTable_Top(objTopPara);
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
objDT = UserCodePathDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserCodePathDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsUserCodePathEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
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
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserCodePathEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsUserCodePathEN._CurrTabName, strPrjId);
List<clsUserCodePathEN> arrUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePathEN> arrUserCodePathObjLst_Sel =
arrUserCodePathObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrUserCodePathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePathEN> GetObjLst(string strWhereCond)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
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
public static List<clsUserCodePathEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserCodePathEN> GetSubObjLstCache(clsUserCodePathEN objUserCodePathCond)
{
 string strPrjId = objUserCodePathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsUserCodePathBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsUserCodePathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePath._AttributeName)
{
if (objUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePathCond[strFldName].ToString());
}
else
{
if (objUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePathCond[strFldName]));
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
public static List<clsUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
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
public static List<clsUserCodePathEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
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
List<clsUserCodePathEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserCodePathEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePathEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
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
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
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
public static List<clsUserCodePathEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserCodePathEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
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
public static List<clsUserCodePathEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserCodePathEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserCodePathEN> arrObjLst = new List<clsUserCodePathEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserCodePathEN objUserCodePathEN = new clsUserCodePathEN();
try
{
objUserCodePathEN.mId = Int32.Parse(objRow[conUserCodePath.mId].ToString().Trim()); //mId
objUserCodePathEN.CMProjectAppRelaId = Int32.Parse(objRow[conUserCodePath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objUserCodePathEN.CodeTypeId = objRow[conUserCodePath.CodeTypeId].ToString().Trim(); //代码类型Id
objUserCodePathEN.TabMainTypeId = objRow[conUserCodePath.TabMainTypeId] == DBNull.Value ? null : objRow[conUserCodePath.TabMainTypeId].ToString().Trim(); //表主类型Id
objUserCodePathEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsGeneCode].ToString().Trim()); //是否生成代码
objUserCodePathEN.ProjectFileName = objRow[conUserCodePath.ProjectFileName] == DBNull.Value ? null : objRow[conUserCodePath.ProjectFileName].ToString().Trim(); //工程文件名
objUserCodePathEN.ProjectPath = objRow[conUserCodePath.ProjectPath] == DBNull.Value ? null : objRow[conUserCodePath.ProjectPath].ToString().Trim(); //工程路径
objUserCodePathEN.PrjFileStateId = objRow[conUserCodePath.PrjFileStateId] == DBNull.Value ? null : objRow[conUserCodePath.PrjFileStateId].ToString().Trim(); //工程文件状态Id
objUserCodePathEN.CodePath = objRow[conUserCodePath.CodePath].ToString().Trim(); //代码路径
objUserCodePathEN.GcPathId = objRow[conUserCodePath.GcPathId] == DBNull.Value ? null : objRow[conUserCodePath.GcPathId].ToString().Trim(); //GC路径Id
objUserCodePathEN.CodePathBackup = objRow[conUserCodePath.CodePathBackup].ToString().Trim(); //备份代码路径
objUserCodePathEN.SuffixPath = objRow[conUserCodePath.SuffixPath] == DBNull.Value ? null : objRow[conUserCodePath.SuffixPath].ToString().Trim(); //后缀路径
objUserCodePathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsTemplate].ToString().Trim()); //是否模板
objUserCodePathEN.IsExistCodePath = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePath].ToString().Trim()); //是否存在代码路径
objUserCodePathEN.IsExistCodePathBackup = clsEntityBase2.TransNullToBool_S(objRow[conUserCodePath.IsExistCodePathBackup].ToString().Trim()); //是否存在备份路径
objUserCodePathEN.PrjId = objRow[conUserCodePath.PrjId].ToString().Trim(); //工程Id
objUserCodePathEN.UpdDate = objRow[conUserCodePath.UpdDate] == DBNull.Value ? null : objRow[conUserCodePath.UpdDate].ToString().Trim(); //修改日期
objUserCodePathEN.UpdUserId = objRow[conUserCodePath.UpdUserId] == DBNull.Value ? null : objRow[conUserCodePath.UpdUserId].ToString().Trim(); //修改用户Id
objUserCodePathEN.Memo = objRow[conUserCodePath.Memo] == DBNull.Value ? null : objRow[conUserCodePath.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserCodePathEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserCodePathEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserCodePathEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserCodePath(ref clsUserCodePathEN objUserCodePathEN)
{
bool bolResult = UserCodePathDA.GetUserCodePath(ref objUserCodePathEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserCodePathEN GetObjBymId(long lngmId)
{
clsUserCodePathEN objUserCodePathEN = UserCodePathDA.GetObjBymId(lngmId);
return objUserCodePathEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserCodePathEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserCodePathEN objUserCodePathEN = UserCodePathDA.GetFirstObj(strWhereCond);
 return objUserCodePathEN;
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
public static clsUserCodePathEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserCodePathEN objUserCodePathEN = UserCodePathDA.GetObjByDataRow(objRow);
 return objUserCodePathEN;
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
public static clsUserCodePathEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserCodePathEN objUserCodePathEN = UserCodePathDA.GetObjByDataRow(objRow);
 return objUserCodePathEN;
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
 /// <param name = "lstUserCodePathObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePathEN GetObjBymIdFromList(long lngmId, List<clsUserCodePathEN> lstUserCodePathObjLst)
{
foreach (clsUserCodePathEN objUserCodePathEN in lstUserCodePathObjLst)
{
if (objUserCodePathEN.mId == lngmId)
{
return objUserCodePathEN;
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
 lngmId = new clsUserCodePathDA().GetFirstID(strWhereCond);
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
 arrList = UserCodePathDA.GetID(strWhereCond);
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
bool bolIsExist = UserCodePathDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = UserCodePathDA.IsExist(lngmId);
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
clsUserCodePathEN objUserCodePathEN = clsUserCodePathBL.GetObjBymId(lngmId);
objUserCodePathEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserCodePathEN.UpdUserId = strOpUser;
return clsUserCodePathBL.UpdateBySql2(objUserCodePathEN);
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
 bolIsExist = clsUserCodePathDA.IsExistTable();
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
 bolIsExist = UserCodePathDA.IsExistTable(strTabName);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserCodePathEN objUserCodePathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserCodePathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecordBySql2)", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserCodePathDA.AddNewRecordBySQL2(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserCodePathEN objUserCodePathEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserCodePathEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],Cm工程应用关系Id = [{1}]的数据已经存在!(in clsUserCodePathBL.AddNewRecordBySql2WithReturnKey)", objUserCodePathEN.CodeTypeId,objUserCodePathEN.CMProjectAppRelaId);
throw new Exception(strMsg);
}
try
{
string strKey = UserCodePathDA.AddNewRecordBySQL2WithReturnKey(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserCodePathEN objUserCodePathEN)
{
try
{
bool bolResult = UserCodePathDA.Update(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 /// <param name = "objUserCodePathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserCodePathEN objUserCodePathEN)
{
 if (objUserCodePathEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserCodePathDA.UpdateBySql2(objUserCodePathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserCodePathBL.ReFreshCache(objUserCodePathEN.PrjId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
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
 clsUserCodePathEN objUserCodePathEN = clsUserCodePathBL.GetObjBymId(lngmId);

if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(objUserCodePathEN.mId, objUserCodePathEN.UpdUserId);
}
if (objUserCodePathEN != null)
{
int intRecNum = UserCodePathDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePathEN.PrjId);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
//删除与表:[UserCodePath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserCodePath.mId,
//lngmId);
//        clsUserCodePathBL.DelUserCodePathsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePathBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePathBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserCodePathBL.relatedActions != null)
{
clsUserCodePathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = UserCodePathDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUserCodePaths(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsUserCodePathBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsUserCodePathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsUserCodePathEN objUserCodePathEN = clsUserCodePathBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = UserCodePathDA.DelUserCodePath(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserCodePathEN.PrjId);
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
public static int DelUserCodePathsByCond(string strWhereCond)
{
try
{
if (clsUserCodePathBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserCodePathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conUserCodePath.PrjId, strWhereCond);
int intRecNum = UserCodePathDA.DelUserCodePath(strWhereCond);
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
public static bool DelUserCodePathsByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserCodePathBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsUserCodePathBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = UserCodePathDA.DelUserCodePathWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserCodePath]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserCodePathDA.GetSpecSQLObj();
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
//删除与表:[UserCodePath]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserCodePathBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserCodePathBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objUserCodePathENS">源对象</param>
 /// <param name = "objUserCodePathENT">目标对象</param>
 public static void CopyTo(clsUserCodePathEN objUserCodePathENS, clsUserCodePathEN objUserCodePathENT)
{
try
{
objUserCodePathENT.mId = objUserCodePathENS.mId; //mId
objUserCodePathENT.CMProjectAppRelaId = objUserCodePathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objUserCodePathENT.CodeTypeId = objUserCodePathENS.CodeTypeId; //代码类型Id
objUserCodePathENT.TabMainTypeId = objUserCodePathENS.TabMainTypeId; //表主类型Id
objUserCodePathENT.IsGeneCode = objUserCodePathENS.IsGeneCode; //是否生成代码
objUserCodePathENT.ProjectFileName = objUserCodePathENS.ProjectFileName; //工程文件名
objUserCodePathENT.ProjectPath = objUserCodePathENS.ProjectPath; //工程路径
objUserCodePathENT.PrjFileStateId = objUserCodePathENS.PrjFileStateId; //工程文件状态Id
objUserCodePathENT.CodePath = objUserCodePathENS.CodePath; //代码路径
objUserCodePathENT.GcPathId = objUserCodePathENS.GcPathId; //GC路径Id
objUserCodePathENT.CodePathBackup = objUserCodePathENS.CodePathBackup; //备份代码路径
objUserCodePathENT.SuffixPath = objUserCodePathENS.SuffixPath; //后缀路径
objUserCodePathENT.IsTemplate = objUserCodePathENS.IsTemplate; //是否模板
objUserCodePathENT.IsExistCodePath = objUserCodePathENS.IsExistCodePath; //是否存在代码路径
objUserCodePathENT.IsExistCodePathBackup = objUserCodePathENS.IsExistCodePathBackup; //是否存在备份路径
objUserCodePathENT.PrjId = objUserCodePathENS.PrjId; //工程Id
objUserCodePathENT.UpdDate = objUserCodePathENS.UpdDate; //修改日期
objUserCodePathENT.UpdUserId = objUserCodePathENS.UpdUserId; //修改用户Id
objUserCodePathENT.Memo = objUserCodePathENS.Memo; //说明
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
 /// <param name = "objUserCodePathEN">源简化对象</param>
 public static void SetUpdFlag(clsUserCodePathEN objUserCodePathEN)
{
try
{
objUserCodePathEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserCodePathEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserCodePath.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.mId = objUserCodePathEN.mId; //mId
}
if (arrFldSet.Contains(conUserCodePath.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.CMProjectAppRelaId = objUserCodePathEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(conUserCodePath.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.CodeTypeId = objUserCodePathEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conUserCodePath.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.TabMainTypeId = objUserCodePathEN.TabMainTypeId == "[null]" ? null :  objUserCodePathEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(conUserCodePath.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.IsGeneCode = objUserCodePathEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(conUserCodePath.ProjectFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.ProjectFileName = objUserCodePathEN.ProjectFileName == "[null]" ? null :  objUserCodePathEN.ProjectFileName; //工程文件名
}
if (arrFldSet.Contains(conUserCodePath.ProjectPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.ProjectPath = objUserCodePathEN.ProjectPath == "[null]" ? null :  objUserCodePathEN.ProjectPath; //工程路径
}
if (arrFldSet.Contains(conUserCodePath.PrjFileStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.PrjFileStateId = objUserCodePathEN.PrjFileStateId == "[null]" ? null :  objUserCodePathEN.PrjFileStateId; //工程文件状态Id
}
if (arrFldSet.Contains(conUserCodePath.CodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.CodePath = objUserCodePathEN.CodePath; //代码路径
}
if (arrFldSet.Contains(conUserCodePath.GcPathId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.GcPathId = objUserCodePathEN.GcPathId == "[null]" ? null :  objUserCodePathEN.GcPathId; //GC路径Id
}
if (arrFldSet.Contains(conUserCodePath.CodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup; //备份代码路径
}
if (arrFldSet.Contains(conUserCodePath.SuffixPath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.SuffixPath = objUserCodePathEN.SuffixPath == "[null]" ? null :  objUserCodePathEN.SuffixPath; //后缀路径
}
if (arrFldSet.Contains(conUserCodePath.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.IsTemplate = objUserCodePathEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conUserCodePath.IsExistCodePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.IsExistCodePath = objUserCodePathEN.IsExistCodePath; //是否存在代码路径
}
if (arrFldSet.Contains(conUserCodePath.IsExistCodePathBackup, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.IsExistCodePathBackup = objUserCodePathEN.IsExistCodePathBackup; //是否存在备份路径
}
if (arrFldSet.Contains(conUserCodePath.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.PrjId = objUserCodePathEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conUserCodePath.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.UpdDate = objUserCodePathEN.UpdDate == "[null]" ? null :  objUserCodePathEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserCodePath.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.UpdUserId = objUserCodePathEN.UpdUserId == "[null]" ? null :  objUserCodePathEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conUserCodePath.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserCodePathEN.Memo = objUserCodePathEN.Memo == "[null]" ? null :  objUserCodePathEN.Memo; //说明
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
 /// <param name = "objUserCodePathEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserCodePathEN objUserCodePathEN)
{
try
{
if (objUserCodePathEN.TabMainTypeId == "[null]") objUserCodePathEN.TabMainTypeId = null; //表主类型Id
if (objUserCodePathEN.ProjectFileName == "[null]") objUserCodePathEN.ProjectFileName = null; //工程文件名
if (objUserCodePathEN.ProjectPath == "[null]") objUserCodePathEN.ProjectPath = null; //工程路径
if (objUserCodePathEN.PrjFileStateId == "[null]") objUserCodePathEN.PrjFileStateId = null; //工程文件状态Id
if (objUserCodePathEN.GcPathId == "[null]") objUserCodePathEN.GcPathId = null; //GC路径Id
if (objUserCodePathEN.SuffixPath == "[null]") objUserCodePathEN.SuffixPath = null; //后缀路径
if (objUserCodePathEN.UpdDate == "[null]") objUserCodePathEN.UpdDate = null; //修改日期
if (objUserCodePathEN.UpdUserId == "[null]") objUserCodePathEN.UpdUserId = null; //修改用户Id
if (objUserCodePathEN.Memo == "[null]") objUserCodePathEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsUserCodePathEN objUserCodePathEN)
{
 UserCodePathDA.CheckPropertyNew(objUserCodePathEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserCodePathEN objUserCodePathEN)
{
 UserCodePathDA.CheckProperty4Condition(objUserCodePathEN);
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
if (clsUserCodePathBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserCodePathBL没有刷新缓存机制(clsUserCodePathBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrUserCodePathObjLstCache == null)
//{
//arrUserCodePathObjLstCache = UserCodePathDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserCodePathEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsUserCodePathEN._CurrTabName, strPrjId);
List<clsUserCodePathEN> arrUserCodePathObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePathEN> arrUserCodePathObjLst_Sel =
arrUserCodePathObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrUserCodePathObjLst_Sel.Count() == 0)
{
   clsUserCodePathEN obj = clsUserCodePathBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrUserCodePathObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePathEN> GetAllUserCodePathObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsUserCodePathEN> arrUserCodePathObjLstCache = GetObjLstCache(strPrjId); 
return arrUserCodePathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserCodePathEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsUserCodePathEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsUserCodePathEN> arrUserCodePathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrUserCodePathObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsUserCodePathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserCodePathEN._RefreshTimeLst.Count == 0) return "";
return clsUserCodePathEN._RefreshTimeLst[clsUserCodePathEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsUserCodePathBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsUserCodePathBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsUserCodePathBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserCodePathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsUserCodePathEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserCodePathBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserCodePath(用户生成路径)
 /// 唯一性条件:CMProjectAppRelaId_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserCodePathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserCodePathEN objUserCodePathEN)
{
//检测记录是否存在
string strResult = UserCodePathDA.GetUniCondStr(objUserCodePathEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conUserCodePath.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserCodePath._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserCodePath._AttributeName));
throw new Exception(strMsg);
}
var objUserCodePath = clsUserCodePathBL.GetObjBymIdCache(lngmId, strPrjId);
if (objUserCodePath == null) return "";
return objUserCodePath[strOutFldName].ToString();
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
int intRecCount = clsUserCodePathDA.GetRecCount(strTabName);
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
int intRecCount = clsUserCodePathDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserCodePathDA.GetRecCount();
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
int intRecCount = clsUserCodePathDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserCodePathCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserCodePathEN objUserCodePathCond)
{
 string strPrjId = objUserCodePathCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsUserCodePathBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsUserCodePathEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsUserCodePathEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserCodePath._AttributeName)
{
if (objUserCodePathCond.IsUpdated(strFldName) == false) continue;
if (objUserCodePathCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePathCond[strFldName].ToString());
}
else
{
if (objUserCodePathCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserCodePathCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserCodePathCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserCodePathCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserCodePathCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserCodePathCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserCodePathCond[strFldName]));
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
 List<string> arrList = clsUserCodePathDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserCodePathDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserCodePathDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserCodePathDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePathDA.SetFldValue(clsUserCodePathEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserCodePathDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePathDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserCodePathDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserCodePathDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserCodePath] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**Cm工程应用关系Id*/ 
 strCreateTabCode.Append(" CMProjectAppRelaId bigint not Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) not Null, "); 
 // /**表主类型Id*/ 
 strCreateTabCode.Append(" TabMainTypeId char(4) Null, "); 
 // /**是否生成代码*/ 
 strCreateTabCode.Append(" IsGeneCode bit Null, "); 
 // /**工程文件名*/ 
 strCreateTabCode.Append(" ProjectFileName varchar(200) Null, "); 
 // /**工程路径*/ 
 strCreateTabCode.Append(" ProjectPath varchar(500) Null, "); 
 // /**工程文件状态Id*/ 
 strCreateTabCode.Append(" PrjFileStateId char(2) Null, "); 
 // /**代码路径*/ 
 strCreateTabCode.Append(" CodePath varchar(200) not Null, "); 
 // /**GC路径Id*/ 
 strCreateTabCode.Append(" GcPathId char(8) Null, "); 
 // /**备份代码路径*/ 
 strCreateTabCode.Append(" CodePathBackup varchar(200) not Null, "); 
 // /**后缀路径*/ 
 strCreateTabCode.Append(" SuffixPath varchar(50) Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null, "); 
 // /**是否存在代码路径*/ 
 strCreateTabCode.Append(" IsExistCodePath bit Null, "); 
 // /**是否存在备份路径*/ 
 strCreateTabCode.Append(" IsExistCodePathBackup bit Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**编程语言类型简称*/ 
 strCreateTabCode.Append(" ProgLangTypeSimName varchar(30) Null, "); 
 // /**CM工程名*/ 
 strCreateTabCode.Append(" CmPrjName varchar(50) Null, "); 
 // /**表主类型名*/ 
 strCreateTabCode.Append(" TabMainTypeName varchar(30) Null, "); 
 // /**简称*/ 
 strCreateTabCode.Append(" CodeTypeSimName varchar(50) Null, "); 
 // /**GC路径名*/ 
 strCreateTabCode.Append(" GcPathName varchar(150) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户生成路径(UserCodePath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserCodePath : clsCommFun4BLV2
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
clsUserCodePathBL.ReFreshThisCache(strPrjId);
}
}

}