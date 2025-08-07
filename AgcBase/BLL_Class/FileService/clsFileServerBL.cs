
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileServerBL
 表名:FileServer(00050209)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件服务(FileService)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsFileServerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngid_FileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObj(this K_id_FileId_FileServer myKey)
{
clsFileServerEN objFileServerEN = clsFileServerBL.FileServerDA.GetObjByid_FileId(myKey.Value);
return objFileServerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFileServerEN objFileServerEN)
{
if (CheckUniqueness_ProjectName_id_ResourceType_FileName(objFileServerEN) == false)
{
var strMsg = string.Format("记录已经存在!项目名称 = [{0}],资源类型流水号 = [{1}],文件名 = [{2}]的数据已经存在!(in clsFileServerBL.AddNewRecord)", objFileServerEN.ProjectName,objFileServerEN.id_ResourceType,objFileServerEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFileServerBL.FileServerDA.AddNewRecordBySQL2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFileServerEN objFileServerEN)
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
objFileServerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objFileServerEN. CheckUniqueness_ProjectName_id_ResourceType_FileName() == false)
{
strMsg = string.Format("(项目名称(ProjectName)=[{0}],资源类型流水号(id_ResourceType)=[{1}],文件名(FileName)=[{2}])已经存在，不能重复!", objFileServerEN.ProjectName, objFileServerEN.id_ResourceType, objFileServerEN.FileName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFileServerEN.AddNewRecord();
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFileServerEN objFileServerEN)
{
if (CheckUniqueness_ProjectName_id_ResourceType_FileName(objFileServerEN) == false)
{
var strMsg = string.Format("记录已经存在!项目名称 = [{0}],资源类型流水号 = [{1}],文件名 = [{2}]的数据已经存在!(in clsFileServerBL.AddNewRecordWithReturnKey)", objFileServerEN.ProjectName,objFileServerEN.id_ResourceType,objFileServerEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = clsFileServerBL.FileServerDA.AddNewRecordBySQL2WithReturnKey(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN Setid_FileId(this clsFileServerEN objFileServerEN, long lngid_FileId, string strComparisonOp="")
	{
objFileServerEN.id_FileId = lngid_FileId; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.id_FileId) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.id_FileId, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.id_FileId] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileContent(this clsFileServerEN objFileServerEN, byte[] bytFileContent, string strComparisonOp="")
	{
objFileServerEN.FileContent = bytFileContent; //文件内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileContent) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileContent, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileContent] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileName(this clsFileServerEN objFileServerEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conFileServer.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conFileServer.FileName);
}
objFileServerEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileName] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetIsFree(this clsFileServerEN objFileServerEN, bool bolIsFree, string strComparisonOp="")
	{
objFileServerEN.IsFree = bolIsFree; //是否释放
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.IsFree) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.IsFree, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.IsFree] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileSize(this clsFileServerEN objFileServerEN, long lngFileSize, string strComparisonOp="")
	{
objFileServerEN.FileSize = lngFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileSize) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileSize, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileSize] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetFileType(this clsFileServerEN objFileServerEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, conFileServer.FileType);
}
objFileServerEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.FileType) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.FileType, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.FileType] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetSaveDate(this clsFileServerEN objFileServerEN, string strSaveDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveDate, 25, conFileServer.SaveDate);
}
objFileServerEN.SaveDate = strSaveDate; //保存日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveDate) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveDate, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveDate] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetLastWriteTime(this clsFileServerEN objFileServerEN, string strLastWriteTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastWriteTime, 30, conFileServer.LastWriteTime);
}
objFileServerEN.LastWriteTime = strLastWriteTime; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.LastWriteTime) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.LastWriteTime, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.LastWriteTime] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetIdFtpResource(this clsFileServerEN objFileServerEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conFileServer.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conFileServer.IdFtpResource);
}
objFileServerEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.IdFtpResource) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.IdFtpResource, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.IdFtpResource] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN Setid_ResourceType(this clsFileServerEN objFileServerEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, conFileServer.id_ResourceType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, conFileServer.id_ResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, conFileServer.id_ResourceType);
}
objFileServerEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.id_ResourceType) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.id_ResourceType, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.id_ResourceType] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetSaveMode(this clsFileServerEN objFileServerEN, string strSaveMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSaveMode, 10, conFileServer.SaveMode);
}
objFileServerEN.SaveMode = strSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.SaveMode) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.SaveMode, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.SaveMode] = strComparisonOp;
}
}
return objFileServerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileServerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFileServerEN SetProjectName(this clsFileServerEN objFileServerEN, string strProjectName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProjectName, 100, conFileServer.ProjectName);
}
objFileServerEN.ProjectName = strProjectName; //项目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileServerEN.dicFldComparisonOp.ContainsKey(conFileServer.ProjectName) == false)
{
objFileServerEN.dicFldComparisonOp.Add(conFileServer.ProjectName, strComparisonOp);
}
else
{
objFileServerEN.dicFldComparisonOp[conFileServer.ProjectName] = strComparisonOp;
}
}
return objFileServerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFileServerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFileServerEN objFileServerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFileServerEN.CheckPropertyNew();
clsFileServerEN objFileServerCond = new clsFileServerEN();
string strCondition = objFileServerCond
.Setid_FileId(objFileServerEN.id_FileId, "<>")
.SetProjectName(objFileServerEN.ProjectName, "=")
.Setid_ResourceType(objFileServerEN.id_ResourceType, "=")
.SetFileName(objFileServerEN.FileName, "=")
.GetCombineCondition();
objFileServerEN._IsCheckProperty = true;
bool bolIsExist = clsFileServerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ProjectName_id_ResourceType_FileName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFileServerEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objFileServer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFileServerEN objFileServer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFileServerEN objFileServerCond = new clsFileServerEN();
string strCondition = objFileServerCond
.SetProjectName(objFileServer.ProjectName, "=")
.Setid_ResourceType(objFileServer.id_ResourceType, "=")
.SetFileName(objFileServer.FileName, "=")
.GetCombineCondition();
objFileServer._IsCheckProperty = true;
bool bolIsExist = clsFileServerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFileServer.id_FileId = clsFileServerBL.GetFirstID_S(strCondition);
objFileServer.UpdateWithCondition(strCondition);
}
else
{
objFileServer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileServerEN objFileServerEN)
{
 if (objFileServerEN.id_FileId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySql2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileServerEN objFileServerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileServerEN.id_FileId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySql2(objFileServerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileServerEN objFileServerEN, string strWhereCond)
{
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySqlWithCondition(objFileServerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileServerEN objFileServerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFileServerBL.FileServerDA.UpdateBySqlWithConditionTransaction(objFileServerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFileServerEN objFileServerEN)
{
try
{
int intRecNum = clsFileServerBL.FileServerDA.DelRecord(objFileServerEN.id_FileId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
 public static void CopyTo(this clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
try
{
objFileServerENT.id_FileId = objFileServerENS.id_FileId; //文件流水号
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileName = objFileServerENS.FileName; //文件名
objFileServerENT.IsFree = objFileServerENS.IsFree; //是否释放
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //保存日期
objFileServerENT.LastWriteTime = objFileServerENS.LastWriteTime; //修改日期
objFileServerENT.IdFtpResource = objFileServerENS.IdFtpResource; //FTP资源流水号
objFileServerENT.id_ResourceType = objFileServerENS.id_ResourceType; //资源类型流水号
objFileServerENT.SaveMode = objFileServerENS.SaveMode; //文件存放方式
objFileServerENT.ProjectName = objFileServerENS.ProjectName; //项目名称
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <returns>目标对象=>clsFileServerEN:objFileServerENT</returns>
 public static clsFileServerEN CopyTo(this clsFileServerEN objFileServerENS)
{
try
{
 clsFileServerEN objFileServerENT = new clsFileServerEN()
{
id_FileId = objFileServerENS.id_FileId, //文件流水号
FileContent = objFileServerENS.FileContent, //文件内容
FileName = objFileServerENS.FileName, //文件名
IsFree = objFileServerENS.IsFree, //是否释放
FileSize = objFileServerENS.FileSize, //文件大小
FileType = objFileServerENS.FileType, //文件类型
SaveDate = objFileServerENS.SaveDate, //保存日期
LastWriteTime = objFileServerENS.LastWriteTime, //修改日期
IdFtpResource = objFileServerENS.IdFtpResource, //FTP资源流水号
id_ResourceType = objFileServerENS.id_ResourceType, //资源类型流水号
SaveMode = objFileServerENS.SaveMode, //文件存放方式
ProjectName = objFileServerENS.ProjectName, //项目名称
};
 return objFileServerENT;
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
public static void CheckPropertyNew(this clsFileServerEN objFileServerEN)
{
 clsFileServerBL.FileServerDA.CheckPropertyNew(objFileServerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFileServerEN objFileServerEN)
{
 clsFileServerBL.FileServerDA.CheckProperty4Condition(objFileServerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFileServerEN objFileServerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFileServerCond.IsUpdated(conFileServer.id_FileId) == true)
{
string strComparisonOpid_FileId = objFileServerCond.dicFldComparisonOp[conFileServer.id_FileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFileServer.id_FileId, objFileServerCond.id_FileId, strComparisonOpid_FileId);
}
//数据类型byte[](image)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理！
if (objFileServerCond.IsUpdated(conFileServer.FileName) == true)
{
string strComparisonOpFileName = objFileServerCond.dicFldComparisonOp[conFileServer.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileName, objFileServerCond.FileName, strComparisonOpFileName);
}
if (objFileServerCond.IsUpdated(conFileServer.IsFree) == true)
{
if (objFileServerCond.IsFree == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileServer.IsFree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileServer.IsFree);
}
}
if (objFileServerCond.IsUpdated(conFileServer.FileSize) == true)
{
string strComparisonOpFileSize = objFileServerCond.dicFldComparisonOp[conFileServer.FileSize];
strWhereCond += string.Format(" And {0} {2} {1}", conFileServer.FileSize, objFileServerCond.FileSize, strComparisonOpFileSize);
}
if (objFileServerCond.IsUpdated(conFileServer.FileType) == true)
{
string strComparisonOpFileType = objFileServerCond.dicFldComparisonOp[conFileServer.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.FileType, objFileServerCond.FileType, strComparisonOpFileType);
}
if (objFileServerCond.IsUpdated(conFileServer.SaveDate) == true)
{
string strComparisonOpSaveDate = objFileServerCond.dicFldComparisonOp[conFileServer.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveDate, objFileServerCond.SaveDate, strComparisonOpSaveDate);
}
if (objFileServerCond.IsUpdated(conFileServer.LastWriteTime) == true)
{
string strComparisonOpLastWriteTime = objFileServerCond.dicFldComparisonOp[conFileServer.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.LastWriteTime, objFileServerCond.LastWriteTime, strComparisonOpLastWriteTime);
}
if (objFileServerCond.IsUpdated(conFileServer.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objFileServerCond.dicFldComparisonOp[conFileServer.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.IdFtpResource, objFileServerCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objFileServerCond.IsUpdated(conFileServer.id_ResourceType) == true)
{
string strComparisonOpid_ResourceType = objFileServerCond.dicFldComparisonOp[conFileServer.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.id_ResourceType, objFileServerCond.id_ResourceType, strComparisonOpid_ResourceType);
}
if (objFileServerCond.IsUpdated(conFileServer.SaveMode) == true)
{
string strComparisonOpSaveMode = objFileServerCond.dicFldComparisonOp[conFileServer.SaveMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.SaveMode, objFileServerCond.SaveMode, strComparisonOpSaveMode);
}
if (objFileServerCond.IsUpdated(conFileServer.ProjectName) == true)
{
string strComparisonOpProjectName = objFileServerCond.dicFldComparisonOp[conFileServer.ProjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileServer.ProjectName, objFileServerCond.ProjectName, strComparisonOpProjectName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FileServer(文件服务), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFileServerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_ProjectName_id_ResourceType_FileName(this clsFileServerEN objFileServerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFileServerEN == null) return true;
if (objFileServerEN.id_FileId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFileServerEN.ProjectName == null)
{
 sbCondition.AppendFormat(" and ProjectName is null", objFileServerEN.ProjectName);
}
else
{
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
}
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
if (clsFileServerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("id_FileId !=  {0}", objFileServerEN.id_FileId);
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
if (clsFileServerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--FileServer(文件服务), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFileServerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrProjectName_id_ResourceType_FileName(this clsFileServerEN objFileServerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFileServerEN == null) return "";
if (objFileServerEN.id_FileId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFileServerEN.ProjectName == null)
{
 sbCondition.AppendFormat(" and ProjectName is null", objFileServerEN.ProjectName);
}
else
{
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
}
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_FileId !=  {0}", objFileServerEN.id_FileId);
 sbCondition.AppendFormat(" and ProjectName = '{0}'", objFileServerEN.ProjectName);
 sbCondition.AppendFormat(" and id_ResourceType = '{0}'", objFileServerEN.id_ResourceType);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileServerEN.FileName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FileServer
{
public virtual bool UpdRelaTabDate(long lngid_FileId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 文件服务(FileServer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFileServerBL
{
public static RelatedActions_FileServer relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "FileServerListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "FileServerList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsFileServerEN> arrFileServerObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFileServerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFileServerDA FileServerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFileServerDA();
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
 public clsFileServerBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsFileServerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileServerEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = FileServerDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = FileServerDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = FileServerDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_FileServer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTable_FileServer(strWhereCond);
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
objDT = FileServerDA.GetDataTable(strWhereCond);
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
objDT = FileServerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FileServerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FileServerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FileServerDA.GetDataTable_Top(objTopPara);
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
objDT = FileServerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = FileServerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FileServerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = FileServerDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrId_FileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFileServerEN> GetObjLstById_FileIdLst(List<long> arrId_FileIdLst)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_FileIdLst);
 string strWhereCond = string.Format("id_FileId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrId_FileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFileServerEN> GetObjLstById_FileIdLstCache(List<long> arrId_FileIdLst)
{
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
arrFileServerObjLstCache
.Where(x => arrId_FileIdLst.Contains(x.id_FileId));
return arrFileServerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLst(string strWhereCond)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFileServerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFileServerEN> GetSubObjLstCache(clsFileServerEN objFileServerCond)
{
List<clsFileServerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileServer.AttributeName)
{
if (objFileServerCond.IsUpdated(strFldName) == false) continue;
if (objFileServerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else
{
if (objFileServerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileServerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileServerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
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
public static List<clsFileServerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
List<clsFileServerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFileServerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFileServerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
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
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFileServerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFileServerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
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
public static List<clsFileServerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsFileServerEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsFileServerEN objFileServerCond, string strOrderBy)
{
List<clsFileServerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileServer.AttributeName)
{
if (objFileServerCond.IsUpdated(strFldName) == false) continue;
if (objFileServerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else
{
if (objFileServerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileServerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileServerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsFileServerEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsFileServerEN objFileServerCond = JsonConvert.DeserializeObject<clsFileServerEN>(objPagerPara.whereCond);
if (objFileServerCond.sfFldComparisonOp == null)
{
objFileServerCond.dicFldComparisonOp = null;
}
else
{
objFileServerCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objFileServerCond.sfFldComparisonOp);
}
clsFileServerBL.SetUpdFlag(objFileServerCond);
 try
{
CheckProperty4Condition(objFileServerCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsFileServerBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objFileServerCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileServerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFileServerEN> arrObjLst = new List<clsFileServerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileServerEN objFileServerEN = new clsFileServerEN();
try
{
objFileServerEN.id_FileId = Int32.Parse(objRow[conFileServer.id_FileId].ToString().Trim()); //文件流水号
objFileServerEN.FileContent = (byte[])objRow[conFileServer.FileContent]; //文件内容
objFileServerEN.FileName = objRow[conFileServer.FileName].ToString().Trim(); //文件名
objFileServerEN.IsFree = clsEntityBase2.TransNullToBool_S(objRow[conFileServer.IsFree].ToString().Trim()); //是否释放
objFileServerEN.FileSize = objRow[conFileServer.FileSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileServer.FileSize].ToString().Trim()); //文件大小
objFileServerEN.FileType = objRow[conFileServer.FileType] == DBNull.Value ? null : objRow[conFileServer.FileType].ToString().Trim(); //文件类型
objFileServerEN.SaveDate = objRow[conFileServer.SaveDate] == DBNull.Value ? null : objRow[conFileServer.SaveDate].ToString().Trim(); //保存日期
objFileServerEN.LastWriteTime = objRow[conFileServer.LastWriteTime] == DBNull.Value ? null : objRow[conFileServer.LastWriteTime].ToString().Trim(); //修改日期
objFileServerEN.IdFtpResource = objRow[conFileServer.IdFtpResource] == DBNull.Value ? null : objRow[conFileServer.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileServerEN.id_ResourceType = objRow[conFileServer.id_ResourceType].ToString().Trim(); //资源类型流水号
objFileServerEN.SaveMode = objRow[conFileServer.SaveMode] == DBNull.Value ? null : objRow[conFileServer.SaveMode].ToString().Trim(); //文件存放方式
objFileServerEN.ProjectName = objRow[conFileServer.ProjectName] == DBNull.Value ? null : objRow[conFileServer.ProjectName].ToString().Trim(); //项目名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileServerEN.id_FileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileServerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFileServerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFileServer(ref clsFileServerEN objFileServerEN)
{
bool bolResult = FileServerDA.GetFileServer(ref objFileServerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngid_FileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileServerEN GetObjByid_FileId(long lngid_FileId)
{
clsFileServerEN objFileServerEN = FileServerDA.GetObjByid_FileId(lngid_FileId);
return objFileServerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFileServerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetFirstObj(strWhereCond);
 return objFileServerEN;
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
public static clsFileServerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetObjByDataRow(objRow);
 return objFileServerEN;
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
public static clsFileServerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFileServerEN objFileServerEN = FileServerDA.GetObjByDataRow(objRow);
 return objFileServerEN;
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
 /// <param name = "lngid_FileId">所给的关键字</param>
 /// <param name = "lstFileServerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileServerEN GetObjByid_FileIdFromList(long lngid_FileId, List<clsFileServerEN> lstFileServerObjLst)
{
foreach (clsFileServerEN objFileServerEN in lstFileServerObjLst)
{
if (objFileServerEN.id_FileId == lngid_FileId)
{
return objFileServerEN;
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
 long lngid_FileId;
 try
 {
 lngid_FileId = new clsFileServerDA().GetFirstID(strWhereCond);
 return lngid_FileId;
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
 arrList = FileServerDA.GetID(strWhereCond);
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
bool bolIsExist = FileServerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngid_FileId)
{
//检测记录是否存在
bool bolIsExist = FileServerDA.IsExist(lngid_FileId);
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
 bolIsExist = clsFileServerDA.IsExistTable();
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
 bolIsExist = FileServerDA.IsExistTable(strTabName);
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFileServerEN objFileServerEN)
{
if (objFileServerEN.CheckUniqueness_ProjectName_id_ResourceType_FileName() == false)
{
var strMsg = string.Format("记录已经存在!项目名称 = [{0}],资源类型流水号 = [{1}],文件名 = [{2}]的数据已经存在!(in clsFileServerBL.AddNewRecordBySql2)", objFileServerEN.ProjectName,objFileServerEN.id_ResourceType,objFileServerEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = FileServerDA.AddNewRecordBySQL2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFileServerEN objFileServerEN)
{
if (objFileServerEN.CheckUniqueness_ProjectName_id_ResourceType_FileName() == false)
{
var strMsg = string.Format("记录已经存在!项目名称 = [{0}],资源类型流水号 = [{1}],文件名 = [{2}]的数据已经存在!(in clsFileServerBL.AddNewRecordBySql2WithReturnKey)", objFileServerEN.ProjectName,objFileServerEN.id_ResourceType,objFileServerEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = FileServerDA.AddNewRecordBySQL2WithReturnKey(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strFileServerObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strFileServerObjXml)
{
clsFileServerEN objFileServerEN = GetObjFromXmlStr(strFileServerObjXml);
try
{
bool bolResult = FileServerDA.AddNewRecordBySQL2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFileServerEN objFileServerEN)
{
try
{
bool bolResult = FileServerDA.Update(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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
 /// <param name = "objFileServerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFileServerEN objFileServerEN)
{
 if (objFileServerEN.id_FileId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FileServerDA.UpdateBySql2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
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

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strFileServerObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strFileServerObjXml)
{
clsFileServerEN objFileServerEN = GetObjFromXmlStr(strFileServerObjXml);
try
{
bool bolResult = FileServerDA.UpdateBySql2(objFileServerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileServerBL.ReFreshCache();

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngid_FileId)
{
try
{
 clsFileServerEN objFileServerEN = clsFileServerBL.GetObjByid_FileId(lngid_FileId);

if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(objFileServerEN.id_FileId, "SetUpdDate");
}
if (objFileServerEN != null)
{
int intRecNum = FileServerDA.DelRecord(lngid_FileId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngid_FileId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngid_FileId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除与表:[FileServer]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFileServer.id_FileId,
//lngid_FileId);
//        clsFileServerBL.DelFileServersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileServerBL.DelRecord(lngid_FileId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileServerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngid_FileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngid_FileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(lngid_FileId, "UpdRelaTabDate");
}
bool bolResult = FileServerDA.DelRecord(lngid_FileId,objSqlConnection,objSqlTransaction);
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
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "lngid_FileId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngid_FileId) 
{
try
{
if (clsFileServerBL.relatedActions != null)
{
clsFileServerBL.relatedActions.UpdRelaTabDate(lngid_FileId, "UpdRelaTabDate");
}
bool bolResult = FileServerDA.DelRecordBySP(lngid_FileId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrid_FileIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFileServers(List<string> arrid_FileIdLst)
{
if (arrid_FileIdLst.Count == 0) return 0;
try
{
if (clsFileServerBL.relatedActions != null)
{
foreach (var strid_FileId in arrid_FileIdLst)
{
long lngid_FileId = long.Parse(strid_FileId);
clsFileServerBL.relatedActions.UpdRelaTabDate(lngid_FileId, "UpdRelaTabDate");
}
}
int intDelRecNum = FileServerDA.DelFileServer(arrid_FileIdLst);
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
public static int DelFileServersByCond(string strWhereCond)
{
try
{
if (clsFileServerBL.relatedActions != null)
{
List<string> arrid_FileId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strid_FileId in arrid_FileId)
{
long lngid_FileId = long.Parse(strid_FileId);
clsFileServerBL.relatedActions.UpdRelaTabDate(lngid_FileId, "UpdRelaTabDate");
}
}
int intRecNum = FileServerDA.DelFileServer(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[FileServer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngid_FileId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngid_FileId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileServerDA.GetSpecSQLObj();
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
//删除与表:[FileServer]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileServerBL.DelRecord(lngid_FileId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileServerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngid_FileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFileServerENS">源对象</param>
 /// <param name = "objFileServerENT">目标对象</param>
 public static void CopyTo(clsFileServerEN objFileServerENS, clsFileServerEN objFileServerENT)
{
try
{
objFileServerENT.id_FileId = objFileServerENS.id_FileId; //文件流水号
objFileServerENT.FileContent = objFileServerENS.FileContent; //文件内容
objFileServerENT.FileName = objFileServerENS.FileName; //文件名
objFileServerENT.IsFree = objFileServerENS.IsFree; //是否释放
objFileServerENT.FileSize = objFileServerENS.FileSize; //文件大小
objFileServerENT.FileType = objFileServerENS.FileType; //文件类型
objFileServerENT.SaveDate = objFileServerENS.SaveDate; //保存日期
objFileServerENT.LastWriteTime = objFileServerENS.LastWriteTime; //修改日期
objFileServerENT.IdFtpResource = objFileServerENS.IdFtpResource; //FTP资源流水号
objFileServerENT.id_ResourceType = objFileServerENS.id_ResourceType; //资源类型流水号
objFileServerENT.SaveMode = objFileServerENS.SaveMode; //文件存放方式
objFileServerENT.ProjectName = objFileServerENS.ProjectName; //项目名称
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
 /// <param name = "objFileServerEN">源简化对象</param>
 public static void SetUpdFlag(clsFileServerEN objFileServerEN)
{
try
{
objFileServerEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objFileServerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFileServer.id_FileId, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.id_FileId = objFileServerEN.id_FileId; //文件流水号
}
if (arrFldSet.Contains(conFileServer.FileContent, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileContent = objFileServerEN.FileContent; //文件内容
}
if (arrFldSet.Contains(conFileServer.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileName = objFileServerEN.FileName; //文件名
}
if (arrFldSet.Contains(conFileServer.IsFree, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.IsFree = objFileServerEN.IsFree; //是否释放
}
if (arrFldSet.Contains(conFileServer.FileSize, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileSize = objFileServerEN.FileSize; //文件大小
}
if (arrFldSet.Contains(conFileServer.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.FileType = objFileServerEN.FileType == "[null]" ? null :  objFileServerEN.FileType; //文件类型
}
if (arrFldSet.Contains(conFileServer.SaveDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.SaveDate = objFileServerEN.SaveDate == "[null]" ? null :  objFileServerEN.SaveDate; //保存日期
}
if (arrFldSet.Contains(conFileServer.LastWriteTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.LastWriteTime = objFileServerEN.LastWriteTime == "[null]" ? null :  objFileServerEN.LastWriteTime; //修改日期
}
if (arrFldSet.Contains(conFileServer.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.IdFtpResource = objFileServerEN.IdFtpResource == "[null]" ? null :  objFileServerEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(conFileServer.id_ResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.id_ResourceType = objFileServerEN.id_ResourceType; //资源类型流水号
}
if (arrFldSet.Contains(conFileServer.SaveMode, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.SaveMode = objFileServerEN.SaveMode == "[null]" ? null :  objFileServerEN.SaveMode; //文件存放方式
}
if (arrFldSet.Contains(conFileServer.ProjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileServerEN.ProjectName = objFileServerEN.ProjectName == "[null]" ? null :  objFileServerEN.ProjectName; //项目名称
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objFileServerEN">源简化对象</param>
 public static void AccessFldValueNull(clsFileServerEN objFileServerEN)
{
try
{
if (objFileServerEN.FileType == "[null]") objFileServerEN.FileType = null; //文件类型
if (objFileServerEN.SaveDate == "[null]") objFileServerEN.SaveDate = null; //保存日期
if (objFileServerEN.LastWriteTime == "[null]") objFileServerEN.LastWriteTime = null; //修改日期
if (objFileServerEN.IdFtpResource == "[null]") objFileServerEN.IdFtpResource = null; //FTP资源流水号
if (objFileServerEN.SaveMode == "[null]") objFileServerEN.SaveMode = null; //文件存放方式
if (objFileServerEN.ProjectName == "[null]") objFileServerEN.ProjectName = null; //项目名称
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsFileServerEN objFileServerEN)
{
 FileServerDA.CheckPropertyNew(objFileServerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFileServerEN objFileServerEN)
{
 FileServerDA.CheckProperty4Condition(objFileServerEN);
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
if (clsFileServerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerBL没有刷新缓存机制(clsFileServerBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_FileId");
//if (arrFileServerObjLstCache == null)
//{
//arrFileServerObjLstCache = FileServerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngid_FileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileServerEN GetObjByid_FileIdCache(long lngid_FileId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrFileServerObjLst_Sel =
arrFileServerObjLstCache
.Where(x=> x.id_FileId == lngid_FileId 
);
if (arrFileServerObjLst_Sel.Count() == 0)
{
   clsFileServerEN obj = clsFileServerBL.GetObjByid_FileId(lngid_FileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFileServerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileServerEN> GetAllFileServerObjLstCache()
{
//获取缓存中的对象列表
List<clsFileServerEN> arrFileServerObjLstCache = GetObjLstCache(); 
return arrFileServerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileServerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
List<clsFileServerEN> arrFileServerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFileServerObjLstCache;
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
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
CacheHelper.Remove(strKey);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFileServerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFileServerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileServerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FileServer(文件服务)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFileServerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrProjectName_id_ResourceType_FileName(clsFileServerEN objFileServerEN)
{
//检测记录是否存在
string strResult = FileServerDA.GetUniCondStrProjectName_id_ResourceType_FileName(objFileServerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstFileServerObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsFileServerEN> lstFileServerObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstFileServerObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstFileServerObjLst">[clsFileServerEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsFileServerEN> lstFileServerObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsFileServerBL.listXmlNode);
writer.WriteStartElement(clsFileServerBL.itemsXmlNode);
foreach (clsFileServerEN objFileServerEN in lstFileServerObjLst)
{
clsFileServerBL.SerializeXML(writer, objFileServerEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objFileServerEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsFileServerEN objFileServerEN)
{
writer.WriteStartElement(clsFileServerBL.itemXmlNode);
 
writer.WriteElementString(conFileServer.id_FileId, objFileServerEN.id_FileId.ToString(CultureInfo.InvariantCulture));
 
 
if (objFileServerEN.FileName != null)
{
writer.WriteElementString(conFileServer.FileName, objFileServerEN.FileName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conFileServer.IsFree, objFileServerEN.IsFree.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(conFileServer.FileSize, objFileServerEN.FileSize.ToString());
 
if (objFileServerEN.FileType != null)
{
writer.WriteElementString(conFileServer.FileType, objFileServerEN.FileType.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.SaveDate != null)
{
writer.WriteElementString(conFileServer.SaveDate, objFileServerEN.SaveDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.LastWriteTime != null)
{
writer.WriteElementString(conFileServer.LastWriteTime, objFileServerEN.LastWriteTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.IdFtpResource != null)
{
writer.WriteElementString(conFileServer.IdFtpResource, objFileServerEN.IdFtpResource.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.id_ResourceType != null)
{
writer.WriteElementString(conFileServer.id_ResourceType, objFileServerEN.id_ResourceType.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.SaveMode != null)
{
writer.WriteElementString(conFileServer.SaveMode, objFileServerEN.SaveMode.ToString(CultureInfo.InvariantCulture));
}
 
if (objFileServerEN.ProjectName != null)
{
writer.WriteElementString(conFileServer.ProjectName, objFileServerEN.ProjectName.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsFileServerEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsFileServerEN objFileServerEN = new clsFileServerEN();
reader.Read();
while (!(reader.Name == clsFileServerBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conFileServer.id_FileId))
{
objFileServerEN.id_FileId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conFileServer.FileContent))
{
}
if (reader.IsStartElement(conFileServer.FileName))
{
objFileServerEN.FileName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.IsFree))
{
objFileServerEN.IsFree = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conFileServer.FileSize))
{
objFileServerEN.FileSize = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conFileServer.FileType))
{
objFileServerEN.FileType = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.SaveDate))
{
objFileServerEN.SaveDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.LastWriteTime))
{
objFileServerEN.LastWriteTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.IdFtpResource))
{
objFileServerEN.IdFtpResource = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.id_ResourceType))
{
objFileServerEN.id_ResourceType = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.SaveMode))
{
objFileServerEN.SaveMode = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conFileServer.ProjectName))
{
objFileServerEN.ProjectName = reader.ReadElementContentAsString();
}
}
return objFileServerEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strFileServerObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsFileServerEN GetObjFromXmlStr(string strFileServerObjXmlStr)
{
clsFileServerEN objFileServerEN = new clsFileServerEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strFileServerObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsFileServerBL.itemXmlNode))
{
objFileServerEN = GetObjFromXml(reader);
return objFileServerEN;
}
}
return objFileServerEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objFileServerEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsFileServerEN objFileServerEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objFileServerEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngid_FileId)
{
if (strInFldName != conFileServer.id_FileId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFileServer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFileServer.AttributeName));
throw new Exception(strMsg);
}
var objFileServer = clsFileServerBL.GetObjByid_FileIdCache(lngid_FileId);
if (objFileServer == null) return "";
return objFileServer[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objFileServerEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsFileServerEN objFileServerEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsFileServerEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objFileServerEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstFileServerObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsFileServerEN> lstFileServerObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstFileServerObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsFileServerEN objFileServerEN in lstFileServerObjLst)
{
string strJSON_One = SerializeObjToJSON(objFileServerEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsFileServerDA.GetRecCount(strTabName);
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
int intRecCount = clsFileServerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFileServerDA.GetRecCount();
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
int intRecCount = clsFileServerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFileServerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFileServerEN objFileServerCond)
{
List<clsFileServerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileServerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileServer.AttributeName)
{
if (objFileServerCond.IsUpdated(strFldName) == false) continue;
if (objFileServerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else
{
if (objFileServerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileServerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileServerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileServerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileServerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileServerCond[strFldName]));
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
 List<string> arrList = clsFileServerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FileServerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FileServerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FileServerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(clsFileServerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FileServerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileServerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FileServer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**文件流水号*/ 
 strCreateTabCode.Append(" id_FileId bigint primary key identity, "); 
 // /**文件内容*/ 
 strCreateTabCode.Append(" FileContent image Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) not Null, "); 
 // /**是否释放*/ 
 strCreateTabCode.Append(" IsFree bit Null, "); 
 // /**文件大小*/ 
 strCreateTabCode.Append(" FileSize bigint Null, "); 
 // /**文件类型*/ 
 strCreateTabCode.Append(" FileType varchar(30) Null, "); 
 // /**保存日期*/ 
 strCreateTabCode.Append(" SaveDate varchar(25) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" LastWriteTime varchar(30) Null, "); 
 // /**FTP资源流水号*/ 
 strCreateTabCode.Append(" IdFtpResource char(8) Null, "); 
 // /**资源类型流水号*/ 
 strCreateTabCode.Append(" id_ResourceType char(4) not Null, "); 
 // /**文件存放方式*/ 
 strCreateTabCode.Append(" SaveMode varchar(10) Null, "); 
 // /**项目名称*/ 
 strCreateTabCode.Append(" ProjectName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步
}
 /// <summary>
 /// 文件服务(FileServer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4FileServer : clsCommFun4BL
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
clsFileServerBL.ReFreshThisCache();
}
}

}