
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationFileBL
 表名:UiFileRelationFile(00050653)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:49:34
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
public static class  clsUiFileRelationFileBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationFileEN GetObj(this K_FileId_UiFileRelationFile myKey)
{
clsUiFileRelationFileEN objUiFileRelationFileEN = clsUiFileRelationFileBL.UiFileRelationFileDA.GetObjByFileId(myKey.Value);
return objUiFileRelationFileEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationFileEN) == false)
{
var strMsg = string.Format("记录已经存在!FileName = [{0}],FilePath = [{1}]的数据已经存在!(in clsUiFileRelationFileBL.AddNewRecord)", objUiFileRelationFileEN.FileName,objUiFileRelationFileEN.FilePath);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUiFileRelationFileBL.UiFileRelationFileDA.AddNewRecordBySQL2(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
public static bool AddRecordEx(this clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsNeedCheckUniqueness = true)
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
objUiFileRelationFileEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUiFileRelationFileEN.CheckUniqueness() == false)
{
strMsg = string.Format("(FileName(FileName)=[{0}],FilePath(FilePath)=[{1}])已经存在,不能重复!", objUiFileRelationFileEN.FileName, objUiFileRelationFileEN.FilePath);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUiFileRelationFileEN.AddNewRecord();
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUiFileRelationFileEN) == false)
{
var strMsg = string.Format("记录已经存在!FileName = [{0}],FilePath = [{1}]的数据已经存在!(in clsUiFileRelationFileBL.AddNewRecordWithReturnKey)", objUiFileRelationFileEN.FileName,objUiFileRelationFileEN.FilePath);
throw new Exception(strMsg);
}
try
{
string strKey = clsUiFileRelationFileBL.UiFileRelationFileDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetFileId(this clsUiFileRelationFileEN objUiFileRelationFileEN, long lngFileId, string strComparisonOp="")
	{
objUiFileRelationFileEN.FileId = lngFileId; //FileId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.FileId) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.FileId, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.FileId] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetTaskId(this clsUiFileRelationFileEN objUiFileRelationFileEN, long lngTaskId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTaskId, conUiFileRelationFile.TaskId);
objUiFileRelationFileEN.TaskId = lngTaskId; //TaskId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.TaskId) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.TaskId, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.TaskId] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetFilePath(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conUiFileRelationFile.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 1000, conUiFileRelationFile.FilePath);
}
objUiFileRelationFileEN.FilePath = strFilePath; //FilePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.FilePath) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.FilePath, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.FilePath] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetRelativePath(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strRelativePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelativePath, 1000, conUiFileRelationFile.RelativePath);
}
objUiFileRelationFileEN.RelativePath = strRelativePath; //RelativePath
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.RelativePath) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.RelativePath, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.RelativePath] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetFileName(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conUiFileRelationFile.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 400, conUiFileRelationFile.FileName);
}
objUiFileRelationFileEN.FileName = strFileName; //FileName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.FileName) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.FileName, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.FileName] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetExtension(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 20, conUiFileRelationFile.Extension);
}
objUiFileRelationFileEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.Extension) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.Extension, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.Extension] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetFileKind(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strFileKind, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileKind, conUiFileRelationFile.FileKind);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileKind, 20, conUiFileRelationFile.FileKind);
}
objUiFileRelationFileEN.FileKind = strFileKind; //FileKind
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.FileKind) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.FileKind, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.FileKind] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetFileHash(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strFileHash, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileHash, 64, conUiFileRelationFile.FileHash);
}
objUiFileRelationFileEN.FileHash = strFileHash; //FileHash
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.FileHash) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.FileHash, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.FileHash] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetIsEntry(this clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsEntry, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsEntry, conUiFileRelationFile.IsEntry);
objUiFileRelationFileEN.IsEntry = bolIsEntry; //IsEntry
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.IsEntry) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.IsEntry, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.IsEntry] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetParseStatus(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strParseStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParseStatus, conUiFileRelationFile.ParseStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParseStatus, 20, conUiFileRelationFile.ParseStatus);
}
objUiFileRelationFileEN.ParseStatus = strParseStatus; //ParseStatus
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.ParseStatus) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.ParseStatus, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.ParseStatus] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetParseMsg(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strParseMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParseMsg, 2147483646, conUiFileRelationFile.ParseMsg);
}
objUiFileRelationFileEN.ParseMsg = strParseMsg; //ParseMsg
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.ParseMsg) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.ParseMsg, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.ParseMsg] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUiFileRelationFileEN SetCreatedAt(this clsUiFileRelationFileEN objUiFileRelationFileEN, DateTime dteCreatedAt, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dteCreatedAt, conUiFileRelationFile.CreatedAt);
objUiFileRelationFileEN.CreatedAt = dteCreatedAt; //CreatedAt
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUiFileRelationFileEN.dicFldComparisonOp.ContainsKey(conUiFileRelationFile.CreatedAt) == false)
{
objUiFileRelationFileEN.dicFldComparisonOp.Add(conUiFileRelationFile.CreatedAt, strComparisonOp);
}
else
{
objUiFileRelationFileEN.dicFldComparisonOp[conUiFileRelationFile.CreatedAt] = strComparisonOp;
}
}
return objUiFileRelationFileEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUiFileRelationFileEN.CheckPropertyNew();
clsUiFileRelationFileEN objUiFileRelationFileCond = new clsUiFileRelationFileEN();
string strCondition = objUiFileRelationFileCond
.SetFileId(objUiFileRelationFileEN.FileId, "<>")
.SetFileName(objUiFileRelationFileEN.FileName, "=")
.SetFilePath(objUiFileRelationFileEN.FilePath, "=")
.GetCombineCondition();
objUiFileRelationFileEN._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationFileBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUiFileRelationFileEN.Update();
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
 /// <param name = "objUiFileRelationFile">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUiFileRelationFileEN objUiFileRelationFile)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUiFileRelationFileEN objUiFileRelationFileCond = new clsUiFileRelationFileEN();
string strCondition = objUiFileRelationFileCond
.SetFileName(objUiFileRelationFile.FileName, "=")
.SetFilePath(objUiFileRelationFile.FilePath, "=")
.GetCombineCondition();
objUiFileRelationFile._IsCheckProperty = true;
bool bolIsExist = clsUiFileRelationFileBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUiFileRelationFile.FileId = clsUiFileRelationFileBL.GetFirstID_S(strCondition);
objUiFileRelationFile.UpdateWithCondition(strCondition);
}
else
{
objUiFileRelationFile.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN.FileId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationFileBL.UiFileRelationFileDA.UpdateBySql2(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUiFileRelationFileEN objUiFileRelationFileEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationFileEN.FileId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUiFileRelationFileBL.UiFileRelationFileDA.UpdateBySql2(objUiFileRelationFileEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strWhereCond)
{
try
{
bool bolResult = clsUiFileRelationFileBL.UiFileRelationFileDA.UpdateBySqlWithCondition(objUiFileRelationFileEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUiFileRelationFileEN objUiFileRelationFileEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUiFileRelationFileBL.UiFileRelationFileDA.UpdateBySqlWithConditionTransaction(objUiFileRelationFileEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
try
{
int intRecNum = clsUiFileRelationFileBL.UiFileRelationFileDA.DelRecord(objUiFileRelationFileEN.FileId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileENS">源对象</param>
 /// <param name = "objUiFileRelationFileENT">目标对象</param>
 public static void CopyTo(this clsUiFileRelationFileEN objUiFileRelationFileENS, clsUiFileRelationFileEN objUiFileRelationFileENT)
{
try
{
objUiFileRelationFileENT.FileId = objUiFileRelationFileENS.FileId; //FileId
objUiFileRelationFileENT.TaskId = objUiFileRelationFileENS.TaskId; //TaskId
objUiFileRelationFileENT.FilePath = objUiFileRelationFileENS.FilePath; //FilePath
objUiFileRelationFileENT.RelativePath = objUiFileRelationFileENS.RelativePath; //RelativePath
objUiFileRelationFileENT.FileName = objUiFileRelationFileENS.FileName; //FileName
objUiFileRelationFileENT.Extension = objUiFileRelationFileENS.Extension; //扩展名
objUiFileRelationFileENT.FileKind = objUiFileRelationFileENS.FileKind; //FileKind
objUiFileRelationFileENT.FileHash = objUiFileRelationFileENS.FileHash; //FileHash
objUiFileRelationFileENT.IsEntry = objUiFileRelationFileENS.IsEntry; //IsEntry
objUiFileRelationFileENT.ParseStatus = objUiFileRelationFileENS.ParseStatus; //ParseStatus
objUiFileRelationFileENT.ParseMsg = objUiFileRelationFileENS.ParseMsg; //ParseMsg
objUiFileRelationFileENT.CreatedAt = objUiFileRelationFileENS.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationFileENS">源对象</param>
 /// <returns>目标对象=>clsUiFileRelationFileEN:objUiFileRelationFileENT</returns>
 public static clsUiFileRelationFileEN CopyTo(this clsUiFileRelationFileEN objUiFileRelationFileENS)
{
try
{
 clsUiFileRelationFileEN objUiFileRelationFileENT = new clsUiFileRelationFileEN()
{
FileId = objUiFileRelationFileENS.FileId, //FileId
TaskId = objUiFileRelationFileENS.TaskId, //TaskId
FilePath = objUiFileRelationFileENS.FilePath, //FilePath
RelativePath = objUiFileRelationFileENS.RelativePath, //RelativePath
FileName = objUiFileRelationFileENS.FileName, //FileName
Extension = objUiFileRelationFileENS.Extension, //扩展名
FileKind = objUiFileRelationFileENS.FileKind, //FileKind
FileHash = objUiFileRelationFileENS.FileHash, //FileHash
IsEntry = objUiFileRelationFileENS.IsEntry, //IsEntry
ParseStatus = objUiFileRelationFileENS.ParseStatus, //ParseStatus
ParseMsg = objUiFileRelationFileENS.ParseMsg, //ParseMsg
CreatedAt = objUiFileRelationFileENS.CreatedAt, //CreatedAt
};
 return objUiFileRelationFileENT;
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
public static void CheckPropertyNew(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 clsUiFileRelationFileBL.UiFileRelationFileDA.CheckPropertyNew(objUiFileRelationFileEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 clsUiFileRelationFileBL.UiFileRelationFileDA.CheckProperty4Condition(objUiFileRelationFileEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUiFileRelationFileEN objUiFileRelationFileCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.FileId) == true)
{
string strComparisonOpFileId = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.FileId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationFile.FileId, objUiFileRelationFileCond.FileId, strComparisonOpFileId);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.TaskId) == true)
{
string strComparisonOpTaskId = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.TaskId];
strWhereCond += string.Format(" And {0} {2} {1}", conUiFileRelationFile.TaskId, objUiFileRelationFileCond.TaskId, strComparisonOpTaskId);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.FilePath) == true)
{
string strComparisonOpFilePath = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.FilePath, objUiFileRelationFileCond.FilePath, strComparisonOpFilePath);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.RelativePath) == true)
{
string strComparisonOpRelativePath = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.RelativePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.RelativePath, objUiFileRelationFileCond.RelativePath, strComparisonOpRelativePath);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.FileName) == true)
{
string strComparisonOpFileName = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.FileName, objUiFileRelationFileCond.FileName, strComparisonOpFileName);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.Extension) == true)
{
string strComparisonOpExtension = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.Extension, objUiFileRelationFileCond.Extension, strComparisonOpExtension);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.FileKind) == true)
{
string strComparisonOpFileKind = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.FileKind];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.FileKind, objUiFileRelationFileCond.FileKind, strComparisonOpFileKind);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.FileHash) == true)
{
string strComparisonOpFileHash = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.FileHash];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.FileHash, objUiFileRelationFileCond.FileHash, strComparisonOpFileHash);
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.IsEntry) == true)
{
if (objUiFileRelationFileCond.IsEntry == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUiFileRelationFile.IsEntry);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUiFileRelationFile.IsEntry);
}
}
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.ParseStatus) == true)
{
string strComparisonOpParseStatus = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.ParseStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.ParseStatus, objUiFileRelationFileCond.ParseStatus, strComparisonOpParseStatus);
}
//数据类型string(ntext)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objUiFileRelationFileCond.IsUpdated(conUiFileRelationFile.CreatedAt) == true)
{
string strComparisonOpCreatedAt = objUiFileRelationFileCond.dicFldComparisonOp[conUiFileRelationFile.CreatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUiFileRelationFile.CreatedAt, objUiFileRelationFileCond.CreatedAt, strComparisonOpCreatedAt);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UiFileRelationFile(UiFileRelationFile), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationFileEN == null) return true;
if (objUiFileRelationFileEN.FileId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objUiFileRelationFileEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objUiFileRelationFileEN.FilePath);
if (clsUiFileRelationFileBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FileId !=  {0}", objUiFileRelationFileEN.FileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objUiFileRelationFileEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objUiFileRelationFileEN.FilePath);
if (clsUiFileRelationFileBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UiFileRelationFile(UiFileRelationFile), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUiFileRelationFileEN == null) return "";
if (objUiFileRelationFileEN.FileId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objUiFileRelationFileEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objUiFileRelationFileEN.FilePath);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FileId !=  {0}", objUiFileRelationFileEN.FileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objUiFileRelationFileEN.FileName);
 sbCondition.AppendFormat(" and FilePath = '{0}'", objUiFileRelationFileEN.FilePath);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UiFileRelationFile
{
public virtual bool UpdRelaTabDate(long lngFileId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// UiFileRelationFile(UiFileRelationFile)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUiFileRelationFileBL
{
public static RelatedActions_UiFileRelationFile relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUiFileRelationFileDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUiFileRelationFileDA UiFileRelationFileDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUiFileRelationFileDA();
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
 public clsUiFileRelationFileBL()
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
if (string.IsNullOrEmpty(clsUiFileRelationFileEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationFileEN._ConnectString);
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
public static DataTable GetDataTable_UiFileRelationFile(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UiFileRelationFileDA.GetDataTable_UiFileRelationFile(strWhereCond);
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
objDT = UiFileRelationFileDA.GetDataTable(strWhereCond);
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
objDT = UiFileRelationFileDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UiFileRelationFileDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UiFileRelationFileDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UiFileRelationFileDA.GetDataTable_Top(objTopPara);
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
objDT = UiFileRelationFileDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UiFileRelationFileDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UiFileRelationFileDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUiFileRelationFileEN> GetObjLstByFileIdLst(List<long> arrFileIdLst)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFileIdLst);
 string strWhereCond = string.Format("FileId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUiFileRelationFileEN> GetObjLstByFileIdLstCache(List<long> arrFileIdLst)
{
string strKey = string.Format("{0}", clsUiFileRelationFileEN._CurrTabName);
List<clsUiFileRelationFileEN> arrUiFileRelationFileObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationFileEN> arrUiFileRelationFileObjLst_Sel =
arrUiFileRelationFileObjLstCache
.Where(x => arrFileIdLst.Contains(x.FileId));
return arrUiFileRelationFileObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationFileEN> GetObjLst(string strWhereCond)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
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
public static List<clsUiFileRelationFileEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUiFileRelationFileCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUiFileRelationFileEN> GetSubObjLstCache(clsUiFileRelationFileEN objUiFileRelationFileCond)
{
List<clsUiFileRelationFileEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationFileEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationFile._AttributeName)
{
if (objUiFileRelationFileCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationFileCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationFileCond[strFldName].ToString());
}
else
{
if (objUiFileRelationFileCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationFileCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationFileCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationFileCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationFileCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationFileCond[strFldName]));
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
public static List<clsUiFileRelationFileEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
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
public static List<clsUiFileRelationFileEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
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
List<clsUiFileRelationFileEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUiFileRelationFileEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationFileEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUiFileRelationFileEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
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
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
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
public static List<clsUiFileRelationFileEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUiFileRelationFileEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUiFileRelationFileEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
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
public static List<clsUiFileRelationFileEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUiFileRelationFileEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUiFileRelationFileEN> arrObjLst = new List<clsUiFileRelationFileEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationFileEN objUiFileRelationFileEN = new clsUiFileRelationFileEN();
try
{
objUiFileRelationFileEN.FileId = Int32.Parse(objRow[conUiFileRelationFile.FileId].ToString().Trim()); //FileId
objUiFileRelationFileEN.TaskId = Int32.Parse(objRow[conUiFileRelationFile.TaskId].ToString().Trim()); //TaskId
objUiFileRelationFileEN.FilePath = objRow[conUiFileRelationFile.FilePath].ToString().Trim(); //FilePath
objUiFileRelationFileEN.RelativePath = objRow[conUiFileRelationFile.RelativePath] == DBNull.Value ? null : objRow[conUiFileRelationFile.RelativePath].ToString().Trim(); //RelativePath
objUiFileRelationFileEN.FileName = objRow[conUiFileRelationFile.FileName].ToString().Trim(); //FileName
objUiFileRelationFileEN.Extension = objRow[conUiFileRelationFile.Extension] == DBNull.Value ? null : objRow[conUiFileRelationFile.Extension].ToString().Trim(); //扩展名
objUiFileRelationFileEN.FileKind = objRow[conUiFileRelationFile.FileKind].ToString().Trim(); //FileKind
objUiFileRelationFileEN.FileHash = objRow[conUiFileRelationFile.FileHash] == DBNull.Value ? null : objRow[conUiFileRelationFile.FileHash].ToString().Trim(); //FileHash
objUiFileRelationFileEN.IsEntry = clsEntityBase2.TransNullToBool_S(objRow[conUiFileRelationFile.IsEntry].ToString().Trim()); //IsEntry
objUiFileRelationFileEN.ParseStatus = objRow[conUiFileRelationFile.ParseStatus].ToString().Trim(); //ParseStatus
objUiFileRelationFileEN.ParseMsg = objRow[conUiFileRelationFile.ParseMsg] == DBNull.Value ? null : objRow[conUiFileRelationFile.ParseMsg].ToString().Trim(); //ParseMsg
objUiFileRelationFileEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationFile.CreatedAt].ToString().Trim()); //CreatedAt
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUiFileRelationFileEN.FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUiFileRelationFileEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUiFileRelationFile(ref clsUiFileRelationFileEN objUiFileRelationFileEN)
{
bool bolResult = UiFileRelationFileDA.GetUiFileRelationFile(ref objUiFileRelationFileEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUiFileRelationFileEN GetObjByFileId(long lngFileId)
{
clsUiFileRelationFileEN objUiFileRelationFileEN = UiFileRelationFileDA.GetObjByFileId(lngFileId);
return objUiFileRelationFileEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUiFileRelationFileEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUiFileRelationFileEN objUiFileRelationFileEN = UiFileRelationFileDA.GetFirstObj(strWhereCond);
 return objUiFileRelationFileEN;
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
public static clsUiFileRelationFileEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUiFileRelationFileEN objUiFileRelationFileEN = UiFileRelationFileDA.GetObjByDataRow(objRow);
 return objUiFileRelationFileEN;
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
public static clsUiFileRelationFileEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUiFileRelationFileEN objUiFileRelationFileEN = UiFileRelationFileDA.GetObjByDataRow(objRow);
 return objUiFileRelationFileEN;
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
 /// <param name = "lngFileId">所给的关键字</param>
 /// <param name = "lstUiFileRelationFileObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationFileEN GetObjByFileIdFromList(long lngFileId, List<clsUiFileRelationFileEN> lstUiFileRelationFileObjLst)
{
foreach (clsUiFileRelationFileEN objUiFileRelationFileEN in lstUiFileRelationFileObjLst)
{
if (objUiFileRelationFileEN.FileId == lngFileId)
{
return objUiFileRelationFileEN;
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
 long lngFileId;
 try
 {
 lngFileId = new clsUiFileRelationFileDA().GetFirstID(strWhereCond);
 return lngFileId;
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
 arrList = UiFileRelationFileDA.GetID(strWhereCond);
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
bool bolIsExist = UiFileRelationFileDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngFileId)
{
//检测记录是否存在
bool bolIsExist = UiFileRelationFileDA.IsExist(lngFileId);
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
 bolIsExist = clsUiFileRelationFileDA.IsExistTable();
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
 bolIsExist = UiFileRelationFileDA.IsExistTable(strTabName);
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationFileEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FileName = [{0}],FilePath = [{1}]的数据已经存在!(in clsUiFileRelationFileBL.AddNewRecordBySql2)", objUiFileRelationFileEN.FileName,objUiFileRelationFileEN.FilePath);
throw new Exception(strMsg);
}
try
{
bool bolResult = UiFileRelationFileDA.AddNewRecordBySQL2(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUiFileRelationFileEN objUiFileRelationFileEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUiFileRelationFileEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!FileName = [{0}],FilePath = [{1}]的数据已经存在!(in clsUiFileRelationFileBL.AddNewRecordBySql2WithReturnKey)", objUiFileRelationFileEN.FileName,objUiFileRelationFileEN.FilePath);
throw new Exception(strMsg);
}
try
{
string strKey = UiFileRelationFileDA.AddNewRecordBySQL2WithReturnKey(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
try
{
bool bolResult = UiFileRelationFileDA.Update(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "objUiFileRelationFileEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 if (objUiFileRelationFileEN.FileId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UiFileRelationFileDA.UpdateBySql2(objUiFileRelationFileEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUiFileRelationFileBL.ReFreshCache();

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
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
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngFileId)
{
try
{
 clsUiFileRelationFileEN objUiFileRelationFileEN = clsUiFileRelationFileBL.GetObjByFileId(lngFileId);

if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(objUiFileRelationFileEN.FileId, "SetUpdDate");
}
if (objUiFileRelationFileEN != null)
{
int intRecNum = UiFileRelationFileDA.DelRecord(lngFileId);
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
/// <param name="lngFileId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngFileId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationFile]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUiFileRelationFile.FileId,
//lngFileId);
//        clsUiFileRelationFileBL.DelUiFileRelationFilesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationFileBL.DelRecord(lngFileId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationFileBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngFileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngFileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngFileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUiFileRelationFileBL.relatedActions != null)
{
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(lngFileId, "UpdRelaTabDate");
}
bool bolResult = UiFileRelationFileDA.DelRecord(lngFileId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFileIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUiFileRelationFiles(List<string> arrFileIdLst)
{
if (arrFileIdLst.Count == 0) return 0;
try
{
if (clsUiFileRelationFileBL.relatedActions != null)
{
foreach (var strFileId in arrFileIdLst)
{
long lngFileId = long.Parse(strFileId);
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(lngFileId, "UpdRelaTabDate");
}
}
int intDelRecNum = UiFileRelationFileDA.DelUiFileRelationFile(arrFileIdLst);
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
public static int DelUiFileRelationFilesByCond(string strWhereCond)
{
try
{
if (clsUiFileRelationFileBL.relatedActions != null)
{
List<string> arrFileId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFileId in arrFileId)
{
long lngFileId = long.Parse(strFileId);
clsUiFileRelationFileBL.relatedActions.UpdRelaTabDate(lngFileId, "UpdRelaTabDate");
}
}
int intRecNum = UiFileRelationFileDA.DelUiFileRelationFile(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UiFileRelationFile]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngFileId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngFileId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUiFileRelationFileDA.GetSpecSQLObj();
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
//删除与表:[UiFileRelationFile]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUiFileRelationFileBL.DelRecord(lngFileId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUiFileRelationFileBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngFileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUiFileRelationFileENS">源对象</param>
 /// <param name = "objUiFileRelationFileENT">目标对象</param>
 public static void CopyTo(clsUiFileRelationFileEN objUiFileRelationFileENS, clsUiFileRelationFileEN objUiFileRelationFileENT)
{
try
{
objUiFileRelationFileENT.FileId = objUiFileRelationFileENS.FileId; //FileId
objUiFileRelationFileENT.TaskId = objUiFileRelationFileENS.TaskId; //TaskId
objUiFileRelationFileENT.FilePath = objUiFileRelationFileENS.FilePath; //FilePath
objUiFileRelationFileENT.RelativePath = objUiFileRelationFileENS.RelativePath; //RelativePath
objUiFileRelationFileENT.FileName = objUiFileRelationFileENS.FileName; //FileName
objUiFileRelationFileENT.Extension = objUiFileRelationFileENS.Extension; //扩展名
objUiFileRelationFileENT.FileKind = objUiFileRelationFileENS.FileKind; //FileKind
objUiFileRelationFileENT.FileHash = objUiFileRelationFileENS.FileHash; //FileHash
objUiFileRelationFileENT.IsEntry = objUiFileRelationFileENS.IsEntry; //IsEntry
objUiFileRelationFileENT.ParseStatus = objUiFileRelationFileENS.ParseStatus; //ParseStatus
objUiFileRelationFileENT.ParseMsg = objUiFileRelationFileENS.ParseMsg; //ParseMsg
objUiFileRelationFileENT.CreatedAt = objUiFileRelationFileENS.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationFileEN">源简化对象</param>
 public static void SetUpdFlag(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
try
{
objUiFileRelationFileEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUiFileRelationFileEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUiFileRelationFile.FileId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.FileId = objUiFileRelationFileEN.FileId; //FileId
}
if (arrFldSet.Contains(conUiFileRelationFile.TaskId, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.TaskId = objUiFileRelationFileEN.TaskId; //TaskId
}
if (arrFldSet.Contains(conUiFileRelationFile.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.FilePath = objUiFileRelationFileEN.FilePath; //FilePath
}
if (arrFldSet.Contains(conUiFileRelationFile.RelativePath, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.RelativePath = objUiFileRelationFileEN.RelativePath == "[null]" ? null :  objUiFileRelationFileEN.RelativePath; //RelativePath
}
if (arrFldSet.Contains(conUiFileRelationFile.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.FileName = objUiFileRelationFileEN.FileName; //FileName
}
if (arrFldSet.Contains(conUiFileRelationFile.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.Extension = objUiFileRelationFileEN.Extension == "[null]" ? null :  objUiFileRelationFileEN.Extension; //扩展名
}
if (arrFldSet.Contains(conUiFileRelationFile.FileKind, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.FileKind = objUiFileRelationFileEN.FileKind; //FileKind
}
if (arrFldSet.Contains(conUiFileRelationFile.FileHash, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.FileHash = objUiFileRelationFileEN.FileHash == "[null]" ? null :  objUiFileRelationFileEN.FileHash; //FileHash
}
if (arrFldSet.Contains(conUiFileRelationFile.IsEntry, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.IsEntry = objUiFileRelationFileEN.IsEntry; //IsEntry
}
if (arrFldSet.Contains(conUiFileRelationFile.ParseStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.ParseStatus = objUiFileRelationFileEN.ParseStatus; //ParseStatus
}
if (arrFldSet.Contains(conUiFileRelationFile.ParseMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.ParseMsg = objUiFileRelationFileEN.ParseMsg == "[null]" ? null :  objUiFileRelationFileEN.ParseMsg; //ParseMsg
}
if (arrFldSet.Contains(conUiFileRelationFile.CreatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objUiFileRelationFileEN.CreatedAt = objUiFileRelationFileEN.CreatedAt; //CreatedAt
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
 /// <param name = "objUiFileRelationFileEN">源简化对象</param>
 public static void AccessFldValueNull(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
try
{
if (objUiFileRelationFileEN.RelativePath == "[null]") objUiFileRelationFileEN.RelativePath = null; //RelativePath
if (objUiFileRelationFileEN.Extension == "[null]") objUiFileRelationFileEN.Extension = null; //扩展名
if (objUiFileRelationFileEN.FileHash == "[null]") objUiFileRelationFileEN.FileHash = null; //FileHash
if (objUiFileRelationFileEN.ParseMsg == "[null]") objUiFileRelationFileEN.ParseMsg = null; //ParseMsg
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
public static void CheckPropertyNew(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 UiFileRelationFileDA.CheckPropertyNew(objUiFileRelationFileEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
 UiFileRelationFileDA.CheckProperty4Condition(objUiFileRelationFileEN);
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
if (clsUiFileRelationFileBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUiFileRelationFileBL没有刷新缓存机制(clsUiFileRelationFileBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FileId");
//if (arrUiFileRelationFileObjLstCache == null)
//{
//arrUiFileRelationFileObjLstCache = UiFileRelationFileDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngFileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUiFileRelationFileEN GetObjByFileIdCache(long lngFileId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsUiFileRelationFileEN._CurrTabName);
List<clsUiFileRelationFileEN> arrUiFileRelationFileObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationFileEN> arrUiFileRelationFileObjLst_Sel =
arrUiFileRelationFileObjLstCache
.Where(x=> x.FileId == lngFileId 
);
if (arrUiFileRelationFileObjLst_Sel.Count() == 0)
{
   clsUiFileRelationFileEN obj = clsUiFileRelationFileBL.GetObjByFileId(lngFileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrUiFileRelationFileObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationFileEN> GetAllUiFileRelationFileObjLstCache()
{
//获取缓存中的对象列表
List<clsUiFileRelationFileEN> arrUiFileRelationFileObjLstCache = GetObjLstCache(); 
return arrUiFileRelationFileObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUiFileRelationFileEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsUiFileRelationFileEN._CurrTabName);
List<clsUiFileRelationFileEN> arrUiFileRelationFileObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrUiFileRelationFileObjLstCache;
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
string strKey = string.Format("{0}", clsUiFileRelationFileEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationFileEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUiFileRelationFileEN._RefreshTimeLst.Count == 0) return "";
return clsUiFileRelationFileEN._RefreshTimeLst[clsUiFileRelationFileEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsUiFileRelationFileBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsUiFileRelationFileEN._CurrTabName);
CacheHelper.Remove(strKey);
clsUiFileRelationFileEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUiFileRelationFileBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UiFileRelationFile(UiFileRelationFile)
 /// 唯一性条件:FileName_FilePath
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationFileEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUiFileRelationFileEN objUiFileRelationFileEN)
{
//检测记录是否存在
string strResult = UiFileRelationFileDA.GetUniCondStr(objUiFileRelationFileEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-07-21
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngFileId)
{
if (strInFldName != conUiFileRelationFile.FileId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUiFileRelationFile._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUiFileRelationFile._AttributeName));
throw new Exception(strMsg);
}
var objUiFileRelationFile = clsUiFileRelationFileBL.GetObjByFileIdCache(lngFileId);
if (objUiFileRelationFile == null) return "";
return objUiFileRelationFile[strOutFldName].ToString();
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
int intRecCount = clsUiFileRelationFileDA.GetRecCount(strTabName);
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
int intRecCount = clsUiFileRelationFileDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUiFileRelationFileDA.GetRecCount();
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
int intRecCount = clsUiFileRelationFileDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUiFileRelationFileCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUiFileRelationFileEN objUiFileRelationFileCond)
{
List<clsUiFileRelationFileEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsUiFileRelationFileEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUiFileRelationFile._AttributeName)
{
if (objUiFileRelationFileCond.IsUpdated(strFldName) == false) continue;
if (objUiFileRelationFileCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationFileCond[strFldName].ToString());
}
else
{
if (objUiFileRelationFileCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUiFileRelationFileCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUiFileRelationFileCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUiFileRelationFileCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUiFileRelationFileCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUiFileRelationFileCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUiFileRelationFileCond[strFldName]));
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
 List<string> arrList = clsUiFileRelationFileDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationFileDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UiFileRelationFileDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UiFileRelationFileDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationFileDA.SetFldValue(clsUiFileRelationFileEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UiFileRelationFileDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationFileDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUiFileRelationFileDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUiFileRelationFileDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UiFileRelationFile] "); 
 strCreateTabCode.Append(" ( "); 
 // /**FileId*/ 
 strCreateTabCode.Append(" FileId bigint primary key identity, "); 
 // /**TaskId*/ 
 strCreateTabCode.Append(" TaskId bigint not Null, "); 
 // /**FilePath*/ 
 strCreateTabCode.Append(" FilePath nvarchar(1000) not Null, "); 
 // /**RelativePath*/ 
 strCreateTabCode.Append(" RelativePath nvarchar(1000) Null, "); 
 // /**FileName*/ 
 strCreateTabCode.Append(" FileName nvarchar(400) not Null, "); 
 // /**扩展名*/ 
 strCreateTabCode.Append(" Extension varchar(20) Null, "); 
 // /**FileKind*/ 
 strCreateTabCode.Append(" FileKind varchar(20) not Null, "); 
 // /**FileHash*/ 
 strCreateTabCode.Append(" FileHash varchar(64) Null, "); 
 // /**IsEntry*/ 
 strCreateTabCode.Append(" IsEntry bit not Null, "); 
 // /**ParseStatus*/ 
 strCreateTabCode.Append(" ParseStatus varchar(20) not Null, "); 
 // /**ParseMsg*/ 
 strCreateTabCode.Append(" ParseMsg ntext(2147483646) Null, "); 
 // /**CreatedAt*/ 
 strCreateTabCode.Append(" CreatedAt datetime not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// UiFileRelationFile(UiFileRelationFile)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UiFileRelationFile : clsCommFun4BL
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
clsUiFileRelationFileBL.ReFreshThisCache();
}
}

}