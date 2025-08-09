
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFilesBL
 表名:ReferFiles(00050460)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsReferFilesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsReferFilesEN GetObj(this K_ReferFileId_ReferFiles myKey)
{
clsReferFilesEN objReferFilesEN = clsReferFilesBL.ReferFilesDA.GetObjByReferFileId(myKey.Value);
return objReferFilesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objReferFilesEN) == false)
{
var strMsg = string.Format("记录已经存在!文件名 = [{0}],引用文件类型Id = [{1}]的数据已经存在!(in clsReferFilesBL.AddNewRecord)", objReferFilesEN.FileName,objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
bool bolResult = clsReferFilesBL.ReferFilesDA.AddNewRecordBySQL2(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
public static bool AddRecordEx(this clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objReferFilesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objReferFilesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(文件名(FileName)=[{0}],引用文件类型Id(ReferFileTypeId)=[{1}])已经存在,不能重复!", objReferFilesEN.FileName, objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objReferFilesEN.AddNewRecord();
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objReferFilesEN) == false)
{
var strMsg = string.Format("记录已经存在!文件名 = [{0}],引用文件类型Id = [{1}]的数据已经存在!(in clsReferFilesBL.AddNewRecordWithMaxId)", objReferFilesEN.FileName,objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
string strReferFileId = clsReferFilesBL.ReferFilesDA.AddNewRecordBySQL2WithReturnKey(objReferFilesEN);
     objReferFilesEN.ReferFileId = strReferFileId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
}
return strReferFileId;
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objReferFilesEN) == false)
{
var strMsg = string.Format("记录已经存在!文件名 = [{0}],引用文件类型Id = [{1}]的数据已经存在!(in clsReferFilesBL.AddNewRecordWithReturnKey)", objReferFilesEN.FileName,objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
string strKey = clsReferFilesBL.ReferFilesDA.AddNewRecordBySQL2WithReturnKey(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetReferFileId(this clsReferFilesEN objReferFilesEN, string strReferFileId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileId, 8, conReferFiles.ReferFileId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileId, 8, conReferFiles.ReferFileId);
}
objReferFilesEN.ReferFileId = strReferFileId; //引用文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.ReferFileId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.ReferFileId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.ReferFileId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetFileName(this clsReferFilesEN objReferFilesEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conReferFiles.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conReferFiles.FileName);
}
objReferFilesEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.FileName) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.FileName, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.FileName] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetReferFileTypeId(this clsReferFilesEN objReferFilesEN, string strReferFileTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReferFileTypeId, 2, conReferFiles.ReferFileTypeId);
}
objReferFilesEN.ReferFileTypeId = strReferFileTypeId; //引用文件类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.ReferFileTypeId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.ReferFileTypeId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.ReferFileTypeId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetFilePath(this clsReferFilesEN objReferFilesEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, conReferFiles.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conReferFiles.FilePath);
}
objReferFilesEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.FilePath) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.FilePath, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.FilePath] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetIsNeedDownLoad(this clsReferFilesEN objReferFilesEN, bool bolIsNeedDownLoad, string strComparisonOp="")
	{
objReferFilesEN.IsNeedDownLoad = bolIsNeedDownLoad; //是否需要下载
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.IsNeedDownLoad) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.IsNeedDownLoad, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.IsNeedDownLoad] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetVersion(this clsReferFilesEN objReferFilesEN, string strVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersion, 30, conReferFiles.Version);
}
objReferFilesEN.Version = strVersion; //版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.Version) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.Version, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.Version] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetInUse(this clsReferFilesEN objReferFilesEN, bool bolInUse, string strComparisonOp="")
	{
objReferFilesEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.InUse) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.InUse, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.InUse] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetOrderNum(this clsReferFilesEN objReferFilesEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conReferFiles.OrderNum);
objReferFilesEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.OrderNum) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.OrderNum, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.OrderNum] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetUpdDate(this clsReferFilesEN objReferFilesEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conReferFiles.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conReferFiles.UpdDate);
}
objReferFilesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.UpdDate) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.UpdDate, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.UpdDate] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetUpdUserId(this clsReferFilesEN objReferFilesEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUserId, conReferFiles.UpdUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conReferFiles.UpdUserId);
}
objReferFilesEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.UpdUserId) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.UpdUserId, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.UpdUserId] = strComparisonOp;
}
}
return objReferFilesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objReferFilesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsReferFilesEN SetMemo(this clsReferFilesEN objReferFilesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conReferFiles.Memo);
}
objReferFilesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objReferFilesEN.dicFldComparisonOp.ContainsKey(conReferFiles.Memo) == false)
{
objReferFilesEN.dicFldComparisonOp.Add(conReferFiles.Memo, strComparisonOp);
}
else
{
objReferFilesEN.dicFldComparisonOp[conReferFiles.Memo] = strComparisonOp;
}
}
return objReferFilesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objReferFilesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsReferFilesEN objReferFilesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objReferFilesEN.CheckPropertyNew();
clsReferFilesEN objReferFilesCond = new clsReferFilesEN();
string strCondition = objReferFilesCond
.SetReferFileId(objReferFilesEN.ReferFileId, "<>")
.SetFileName(objReferFilesEN.FileName, "=")
.SetReferFileTypeId(objReferFilesEN.ReferFileTypeId, "=")
.GetCombineCondition();
objReferFilesEN._IsCheckProperty = true;
bool bolIsExist = clsReferFilesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FileName_ReferFileTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objReferFilesEN.Update();
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
 /// <param name = "objReferFiles">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsReferFilesEN objReferFiles)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsReferFilesEN objReferFilesCond = new clsReferFilesEN();
string strCondition = objReferFilesCond
.SetFileName(objReferFiles.FileName, "=")
.SetReferFileTypeId(objReferFiles.ReferFileTypeId, "=")
.GetCombineCondition();
objReferFiles._IsCheckProperty = true;
bool bolIsExist = clsReferFilesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objReferFiles.ReferFileId = clsReferFilesBL.GetFirstID_S(strCondition);
objReferFiles.UpdateWithCondition(strCondition);
}
else
{
objReferFiles.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
objReferFiles.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsReferFilesEN objReferFilesEN)
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsReferFilesBL.ReferFilesDA.UpdateBySql2(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsReferFilesEN objReferFilesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsReferFilesBL.ReferFilesDA.UpdateBySql2(objReferFilesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsReferFilesEN objReferFilesEN, string strWhereCond)
{
try
{
bool bolResult = clsReferFilesBL.ReferFilesDA.UpdateBySqlWithCondition(objReferFilesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsReferFilesEN objReferFilesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsReferFilesBL.ReferFilesDA.UpdateBySqlWithConditionTransaction(objReferFilesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsReferFilesEN objReferFilesEN)
{
try
{
int intRecNum = clsReferFilesBL.ReferFilesDA.DelRecord(objReferFilesEN.ReferFileId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesENS">源对象</param>
 /// <param name = "objReferFilesENT">目标对象</param>
 public static void CopyTo(this clsReferFilesEN objReferFilesENS, clsReferFilesEN objReferFilesENT)
{
try
{
objReferFilesENT.ReferFileId = objReferFilesENS.ReferFileId; //引用文件Id
objReferFilesENT.FileName = objReferFilesENS.FileName; //文件名
objReferFilesENT.ReferFileTypeId = objReferFilesENS.ReferFileTypeId; //引用文件类型Id
objReferFilesENT.FilePath = objReferFilesENS.FilePath; //文件路径
objReferFilesENT.IsNeedDownLoad = objReferFilesENS.IsNeedDownLoad; //是否需要下载
objReferFilesENT.Version = objReferFilesENS.Version; //版本
objReferFilesENT.InUse = objReferFilesENS.InUse; //是否在用
objReferFilesENT.OrderNum = objReferFilesENS.OrderNum; //序号
objReferFilesENT.UpdDate = objReferFilesENS.UpdDate; //修改日期
objReferFilesENT.UpdUserId = objReferFilesENS.UpdUserId; //修改用户Id
objReferFilesENT.Memo = objReferFilesENS.Memo; //说明
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
 /// <param name = "objReferFilesENS">源对象</param>
 /// <returns>目标对象=>clsReferFilesEN:objReferFilesENT</returns>
 public static clsReferFilesEN CopyTo(this clsReferFilesEN objReferFilesENS)
{
try
{
 clsReferFilesEN objReferFilesENT = new clsReferFilesEN()
{
ReferFileId = objReferFilesENS.ReferFileId, //引用文件Id
FileName = objReferFilesENS.FileName, //文件名
ReferFileTypeId = objReferFilesENS.ReferFileTypeId, //引用文件类型Id
FilePath = objReferFilesENS.FilePath, //文件路径
IsNeedDownLoad = objReferFilesENS.IsNeedDownLoad, //是否需要下载
Version = objReferFilesENS.Version, //版本
InUse = objReferFilesENS.InUse, //是否在用
OrderNum = objReferFilesENS.OrderNum, //序号
UpdDate = objReferFilesENS.UpdDate, //修改日期
UpdUserId = objReferFilesENS.UpdUserId, //修改用户Id
Memo = objReferFilesENS.Memo, //说明
};
 return objReferFilesENT;
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
public static void CheckPropertyNew(this clsReferFilesEN objReferFilesEN)
{
 clsReferFilesBL.ReferFilesDA.CheckPropertyNew(objReferFilesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsReferFilesEN objReferFilesEN)
{
 clsReferFilesBL.ReferFilesDA.CheckProperty4Condition(objReferFilesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsReferFilesEN objReferFilesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objReferFilesCond.IsUpdated(conReferFiles.ReferFileId) == true)
{
string strComparisonOpReferFileId = objReferFilesCond.dicFldComparisonOp[conReferFiles.ReferFileId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.ReferFileId, objReferFilesCond.ReferFileId, strComparisonOpReferFileId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.FileName) == true)
{
string strComparisonOpFileName = objReferFilesCond.dicFldComparisonOp[conReferFiles.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.FileName, objReferFilesCond.FileName, strComparisonOpFileName);
}
if (objReferFilesCond.IsUpdated(conReferFiles.ReferFileTypeId) == true)
{
string strComparisonOpReferFileTypeId = objReferFilesCond.dicFldComparisonOp[conReferFiles.ReferFileTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.ReferFileTypeId, objReferFilesCond.ReferFileTypeId, strComparisonOpReferFileTypeId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.FilePath) == true)
{
string strComparisonOpFilePath = objReferFilesCond.dicFldComparisonOp[conReferFiles.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.FilePath, objReferFilesCond.FilePath, strComparisonOpFilePath);
}
if (objReferFilesCond.IsUpdated(conReferFiles.IsNeedDownLoad) == true)
{
if (objReferFilesCond.IsNeedDownLoad == true)
{
strWhereCond += string.Format(" And {0} = '1'", conReferFiles.IsNeedDownLoad);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conReferFiles.IsNeedDownLoad);
}
}
if (objReferFilesCond.IsUpdated(conReferFiles.Version) == true)
{
string strComparisonOpVersion = objReferFilesCond.dicFldComparisonOp[conReferFiles.Version];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.Version, objReferFilesCond.Version, strComparisonOpVersion);
}
if (objReferFilesCond.IsUpdated(conReferFiles.InUse) == true)
{
if (objReferFilesCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conReferFiles.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conReferFiles.InUse);
}
}
if (objReferFilesCond.IsUpdated(conReferFiles.OrderNum) == true)
{
string strComparisonOpOrderNum = objReferFilesCond.dicFldComparisonOp[conReferFiles.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conReferFiles.OrderNum, objReferFilesCond.OrderNum, strComparisonOpOrderNum);
}
if (objReferFilesCond.IsUpdated(conReferFiles.UpdDate) == true)
{
string strComparisonOpUpdDate = objReferFilesCond.dicFldComparisonOp[conReferFiles.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.UpdDate, objReferFilesCond.UpdDate, strComparisonOpUpdDate);
}
if (objReferFilesCond.IsUpdated(conReferFiles.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objReferFilesCond.dicFldComparisonOp[conReferFiles.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.UpdUserId, objReferFilesCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objReferFilesCond.IsUpdated(conReferFiles.Memo) == true)
{
string strComparisonOpMemo = objReferFilesCond.dicFldComparisonOp[conReferFiles.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conReferFiles.Memo, objReferFilesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ReferFiles(引用文件), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FileName_ReferFileTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsReferFilesEN objReferFilesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objReferFilesEN == null) return true;
if (objReferFilesEN.ReferFileId == null || objReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 if (objReferFilesEN.ReferFileTypeId == null)
{
 sbCondition.AppendFormat(" and ReferFileTypeId is null", objReferFilesEN.ReferFileTypeId);
}
else
{
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
}
if (clsReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
if (clsReferFilesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ReferFiles(引用文件), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileName_ReferFileTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsReferFilesEN objReferFilesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objReferFilesEN == null) return "";
if (objReferFilesEN.ReferFileId == null || objReferFilesEN.ReferFileId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 if (objReferFilesEN.ReferFileTypeId == null)
{
 sbCondition.AppendFormat(" and ReferFileTypeId is null", objReferFilesEN.ReferFileTypeId);
}
else
{
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReferFileId !=  '{0}'", objReferFilesEN.ReferFileId);
 sbCondition.AppendFormat(" and FileName = '{0}'", objReferFilesEN.FileName);
 sbCondition.AppendFormat(" and ReferFileTypeId = '{0}'", objReferFilesEN.ReferFileTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ReferFiles
{
public virtual bool UpdRelaTabDate(string strReferFileId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 引用文件(ReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsReferFilesBL
{
public static RelatedActions_ReferFiles relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsReferFilesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsReferFilesDA ReferFilesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsReferFilesDA();
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
 public clsReferFilesBL()
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
if (string.IsNullOrEmpty(clsReferFilesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsReferFilesEN._ConnectString);
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
public static DataTable GetDataTable_ReferFiles(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ReferFilesDA.GetDataTable_ReferFiles(strWhereCond);
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
objDT = ReferFilesDA.GetDataTable(strWhereCond);
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
objDT = ReferFilesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ReferFilesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ReferFilesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ReferFilesDA.GetDataTable_Top(objTopPara);
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
objDT = ReferFilesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ReferFilesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrReferFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsReferFilesEN> GetObjLstByReferFileIdLst(List<string> arrReferFileIdLst)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrReferFileIdLst, true);
 string strWhereCond = string.Format("ReferFileId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReferFileIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsReferFilesEN> GetObjLstByReferFileIdLstCache(List<string> arrReferFileIdLst)
{
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel =
arrReferFilesObjLstCache
.Where(x => arrReferFileIdLst.Contains(x.ReferFileId));
return arrReferFilesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsReferFilesEN> GetObjLst(string strWhereCond)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
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
public static List<clsReferFilesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsReferFilesEN> GetSubObjLstCache(clsReferFilesEN objReferFilesCond)
{
List<clsReferFilesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conReferFiles._AttributeName)
{
if (objReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objReferFilesCond[strFldName].ToString());
}
else
{
if (objReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objReferFilesCond[strFldName]));
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
public static List<clsReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
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
public static List<clsReferFilesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
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
List<clsReferFilesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsReferFilesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsReferFilesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
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
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
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
public static List<clsReferFilesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsReferFilesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
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
public static List<clsReferFilesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsReferFilesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsReferFilesEN> arrObjLst = new List<clsReferFilesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsReferFilesEN objReferFilesEN = new clsReferFilesEN();
try
{
objReferFilesEN.ReferFileId = objRow[conReferFiles.ReferFileId].ToString().Trim(); //引用文件Id
objReferFilesEN.FileName = objRow[conReferFiles.FileName].ToString().Trim(); //文件名
objReferFilesEN.ReferFileTypeId = objRow[conReferFiles.ReferFileTypeId] == DBNull.Value ? null : objRow[conReferFiles.ReferFileTypeId].ToString().Trim(); //引用文件类型Id
objReferFilesEN.FilePath = objRow[conReferFiles.FilePath].ToString().Trim(); //文件路径
objReferFilesEN.IsNeedDownLoad = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.IsNeedDownLoad].ToString().Trim()); //是否需要下载
objReferFilesEN.Version = objRow[conReferFiles.Version] == DBNull.Value ? null : objRow[conReferFiles.Version].ToString().Trim(); //版本
objReferFilesEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conReferFiles.InUse].ToString().Trim()); //是否在用
objReferFilesEN.OrderNum = Int32.Parse(objRow[conReferFiles.OrderNum].ToString().Trim()); //序号
objReferFilesEN.UpdDate = objRow[conReferFiles.UpdDate].ToString().Trim(); //修改日期
objReferFilesEN.UpdUserId = objRow[conReferFiles.UpdUserId].ToString().Trim(); //修改用户Id
objReferFilesEN.Memo = objRow[conReferFiles.Memo] == DBNull.Value ? null : objRow[conReferFiles.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objReferFilesEN.ReferFileId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objReferFilesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objReferFilesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetReferFiles(ref clsReferFilesEN objReferFilesEN)
{
bool bolResult = ReferFilesDA.GetReferFiles(ref objReferFilesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReferFileId">表关键字</param>
 /// <returns>表对象</returns>
public static clsReferFilesEN GetObjByReferFileId(string strReferFileId)
{
if (strReferFileId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strReferFileId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strReferFileId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strReferFileId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsReferFilesEN objReferFilesEN = ReferFilesDA.GetObjByReferFileId(strReferFileId);
return objReferFilesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsReferFilesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsReferFilesEN objReferFilesEN = ReferFilesDA.GetFirstObj(strWhereCond);
 return objReferFilesEN;
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
public static clsReferFilesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsReferFilesEN objReferFilesEN = ReferFilesDA.GetObjByDataRow(objRow);
 return objReferFilesEN;
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
public static clsReferFilesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsReferFilesEN objReferFilesEN = ReferFilesDA.GetObjByDataRow(objRow);
 return objReferFilesEN;
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
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <param name = "lstReferFilesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsReferFilesEN GetObjByReferFileIdFromList(string strReferFileId, List<clsReferFilesEN> lstReferFilesObjLst)
{
foreach (clsReferFilesEN objReferFilesEN in lstReferFilesObjLst)
{
if (objReferFilesEN.ReferFileId == strReferFileId)
{
return objReferFilesEN;
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
 string strMaxReferFileId;
 try
 {
 strMaxReferFileId = clsReferFilesDA.GetMaxStrId();
 return strMaxReferFileId;
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
 string strReferFileId;
 try
 {
 strReferFileId = new clsReferFilesDA().GetFirstID(strWhereCond);
 return strReferFileId;
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
 arrList = ReferFilesDA.GetID(strWhereCond);
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
bool bolIsExist = ReferFilesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strReferFileId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ReferFilesDA.IsExist(strReferFileId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strReferFileId">引用文件Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strReferFileId, string strOpUser)
{
clsReferFilesEN objReferFilesEN = clsReferFilesBL.GetObjByReferFileId(strReferFileId);
objReferFilesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objReferFilesEN.UpdUserId = strOpUser;
return clsReferFilesBL.UpdateBySql2(objReferFilesEN);
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
 bolIsExist = clsReferFilesDA.IsExistTable();
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
 bolIsExist = ReferFilesDA.IsExistTable(strTabName);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objReferFilesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!文件名 = [{0}],引用文件类型Id = [{1}]的数据已经存在!(in clsReferFilesBL.AddNewRecordBySql2)", objReferFilesEN.FileName,objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
bool bolResult = ReferFilesDA.AddNewRecordBySQL2(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsReferFilesEN objReferFilesEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objReferFilesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!文件名 = [{0}],引用文件类型Id = [{1}]的数据已经存在!(in clsReferFilesBL.AddNewRecordBySql2WithReturnKey)", objReferFilesEN.FileName,objReferFilesEN.ReferFileTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true || clsReferFilesBL.IsExist(objReferFilesEN.ReferFileId) == true)
 {
     objReferFilesEN.ReferFileId = clsReferFilesBL.GetMaxStrId_S();
 }
string strKey = ReferFilesDA.AddNewRecordBySQL2WithReturnKey(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsReferFilesEN objReferFilesEN)
{
try
{
bool bolResult = ReferFilesDA.Update(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "objReferFilesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsReferFilesEN objReferFilesEN)
{
 if (string.IsNullOrEmpty(objReferFilesEN.ReferFileId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ReferFilesDA.UpdateBySql2(objReferFilesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsReferFilesBL.ReFreshCache();

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
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
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strReferFileId)
{
try
{
 clsReferFilesEN objReferFilesEN = clsReferFilesBL.GetObjByReferFileId(strReferFileId);

if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFilesEN.ReferFileId, objReferFilesEN.UpdUserId);
}
if (objReferFilesEN != null)
{
int intRecNum = ReferFilesDA.DelRecord(strReferFileId);
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
/// <param name="strReferFileId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strReferFileId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsReferFilesDA.GetSpecSQLObj();
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
//删除与表:[ReferFiles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conReferFiles.ReferFileId,
//strReferFileId);
//        clsReferFilesBL.DelReferFilessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsReferFilesBL.DelRecord(strReferFileId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsReferFilesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReferFileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strReferFileId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strReferFileId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(strReferFileId, "UpdRelaTabDate");
}
bool bolResult = ReferFilesDA.DelRecord(strReferFileId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrReferFileIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelReferFiless(List<string> arrReferFileIdLst)
{
if (arrReferFileIdLst.Count == 0) return 0;
try
{
if (clsReferFilesBL.relatedActions != null)
{
foreach (var strReferFileId in arrReferFileIdLst)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(strReferFileId, "UpdRelaTabDate");
}
}
int intDelRecNum = ReferFilesDA.DelReferFiles(arrReferFileIdLst);
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
public static int DelReferFilessByCond(string strWhereCond)
{
try
{
if (clsReferFilesBL.relatedActions != null)
{
List<string> arrReferFileId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strReferFileId in arrReferFileId)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(strReferFileId, "UpdRelaTabDate");
}
}
int intRecNum = ReferFilesDA.DelReferFiles(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ReferFiles]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strReferFileId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strReferFileId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsReferFilesDA.GetSpecSQLObj();
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
//删除与表:[ReferFiles]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsReferFilesBL.DelRecord(strReferFileId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsReferFilesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReferFileId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objReferFilesENS">源对象</param>
 /// <param name = "objReferFilesENT">目标对象</param>
 public static void CopyTo(clsReferFilesEN objReferFilesENS, clsReferFilesEN objReferFilesENT)
{
try
{
objReferFilesENT.ReferFileId = objReferFilesENS.ReferFileId; //引用文件Id
objReferFilesENT.FileName = objReferFilesENS.FileName; //文件名
objReferFilesENT.ReferFileTypeId = objReferFilesENS.ReferFileTypeId; //引用文件类型Id
objReferFilesENT.FilePath = objReferFilesENS.FilePath; //文件路径
objReferFilesENT.IsNeedDownLoad = objReferFilesENS.IsNeedDownLoad; //是否需要下载
objReferFilesENT.Version = objReferFilesENS.Version; //版本
objReferFilesENT.InUse = objReferFilesENS.InUse; //是否在用
objReferFilesENT.OrderNum = objReferFilesENS.OrderNum; //序号
objReferFilesENT.UpdDate = objReferFilesENS.UpdDate; //修改日期
objReferFilesENT.UpdUserId = objReferFilesENS.UpdUserId; //修改用户Id
objReferFilesENT.Memo = objReferFilesENS.Memo; //说明
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
 /// <param name = "objReferFilesEN">源简化对象</param>
 public static void SetUpdFlag(clsReferFilesEN objReferFilesEN)
{
try
{
objReferFilesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objReferFilesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conReferFiles.ReferFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.ReferFileId = objReferFilesEN.ReferFileId; //引用文件Id
}
if (arrFldSet.Contains(conReferFiles.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.FileName = objReferFilesEN.FileName; //文件名
}
if (arrFldSet.Contains(conReferFiles.ReferFileTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.ReferFileTypeId = objReferFilesEN.ReferFileTypeId == "[null]" ? null :  objReferFilesEN.ReferFileTypeId; //引用文件类型Id
}
if (arrFldSet.Contains(conReferFiles.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.FilePath = objReferFilesEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conReferFiles.IsNeedDownLoad, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.IsNeedDownLoad = objReferFilesEN.IsNeedDownLoad; //是否需要下载
}
if (arrFldSet.Contains(conReferFiles.Version, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.Version = objReferFilesEN.Version == "[null]" ? null :  objReferFilesEN.Version; //版本
}
if (arrFldSet.Contains(conReferFiles.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.InUse = objReferFilesEN.InUse; //是否在用
}
if (arrFldSet.Contains(conReferFiles.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.OrderNum = objReferFilesEN.OrderNum; //序号
}
if (arrFldSet.Contains(conReferFiles.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.UpdDate = objReferFilesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conReferFiles.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.UpdUserId = objReferFilesEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conReferFiles.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objReferFilesEN.Memo = objReferFilesEN.Memo == "[null]" ? null :  objReferFilesEN.Memo; //说明
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
 /// <param name = "objReferFilesEN">源简化对象</param>
 public static void AccessFldValueNull(clsReferFilesEN objReferFilesEN)
{
try
{
if (objReferFilesEN.ReferFileTypeId == "[null]") objReferFilesEN.ReferFileTypeId = null; //引用文件类型Id
if (objReferFilesEN.Version == "[null]") objReferFilesEN.Version = null; //版本
if (objReferFilesEN.Memo == "[null]") objReferFilesEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsReferFilesEN objReferFilesEN)
{
 ReferFilesDA.CheckPropertyNew(objReferFilesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsReferFilesEN objReferFilesEN)
{
 ReferFilesDA.CheckProperty4Condition(objReferFilesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ReferFileId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conReferFiles.ReferFileId); 
List<clsReferFilesEN> arrObjLst = clsReferFilesBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsReferFilesEN objReferFilesEN = new clsReferFilesEN()
{
ReferFileId = "0",
FileName = "选[引用文件]..."
};
arrObjLst.Insert(0, objReferFilesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conReferFiles.ReferFileId;
objComboBox.DisplayMember = conReferFiles.FileName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ReferFileId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[引用文件]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conReferFiles.ReferFileId); 
IEnumerable<clsReferFilesEN> arrObjLst = clsReferFilesBL.GetObjLst(strCondition);
objDDL.DataValueField = conReferFiles.ReferFileId;
objDDL.DataTextField = conReferFiles.FileName;
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
public static void BindDdl_ReferFileIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[引用文件]...","0");
List<clsReferFilesEN> arrReferFilesObjLst = GetAllReferFilesObjLstCache(); 
arrReferFilesObjLst = arrReferFilesObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conReferFiles.ReferFileId;
objDDL.DataTextField = conReferFiles.FileName;
objDDL.DataSource = arrReferFilesObjLst;
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
if (clsReferFilesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsReferFilesBL没有刷新缓存机制(clsReferFilesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReferFileId");
//if (arrReferFilesObjLstCache == null)
//{
//arrReferFilesObjLstCache = ReferFilesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsReferFilesEN GetObjByReferFileIdCache(string strReferFileId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrReferFilesObjLst_Sel =
arrReferFilesObjLstCache
.Where(x=> x.ReferFileId == strReferFileId 
);
if (arrReferFilesObjLst_Sel.Count() == 0)
{
   clsReferFilesEN obj = clsReferFilesBL.GetObjByReferFileId(strReferFileId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrReferFilesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFileNameByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return "";
//获取缓存中的对象列表
clsReferFilesEN objReferFiles = GetObjByReferFileIdCache(strReferFileId);
if (objReferFiles == null) return "";
return objReferFiles.FileName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strReferFileId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByReferFileIdCache(string strReferFileId)
{
if (string.IsNullOrEmpty(strReferFileId) == true) return "";
//获取缓存中的对象列表
clsReferFilesEN objReferFiles = GetObjByReferFileIdCache(strReferFileId);
if (objReferFiles == null) return "";
return objReferFiles.FileName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsReferFilesEN> GetAllReferFilesObjLstCache()
{
//获取缓存中的对象列表
List<clsReferFilesEN> arrReferFilesObjLstCache = GetObjLstCache(); 
return arrReferFilesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsReferFilesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
List<clsReferFilesEN> arrReferFilesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrReferFilesObjLstCache;
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
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsReferFilesEN._RefreshTimeLst.Count == 0) return "";
return clsReferFilesEN._RefreshTimeLst[clsReferFilesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsReferFilesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsReferFilesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsReferFilesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsReferFilesBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ReferFiles(引用文件)
 /// 唯一性条件:FileName_ReferFileTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objReferFilesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsReferFilesEN objReferFilesEN)
{
//检测记录是否存在
string strResult = ReferFilesDA.GetUniCondStr(objReferFilesEN);
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
public static string Func(string strInFldName, string strOutFldName, string strReferFileId)
{
if (strInFldName != conReferFiles.ReferFileId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conReferFiles._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conReferFiles._AttributeName));
throw new Exception(strMsg);
}
var objReferFiles = clsReferFilesBL.GetObjByReferFileIdCache(strReferFileId);
if (objReferFiles == null) return "";
return objReferFiles[strOutFldName].ToString();
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
int intRecCount = clsReferFilesDA.GetRecCount(strTabName);
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
int intRecCount = clsReferFilesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsReferFilesDA.GetRecCount();
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
int intRecCount = clsReferFilesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objReferFilesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsReferFilesEN objReferFilesCond)
{
List<clsReferFilesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsReferFilesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conReferFiles._AttributeName)
{
if (objReferFilesCond.IsUpdated(strFldName) == false) continue;
if (objReferFilesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objReferFilesCond[strFldName].ToString());
}
else
{
if (objReferFilesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objReferFilesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objReferFilesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objReferFilesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objReferFilesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objReferFilesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objReferFilesCond[strFldName]));
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
 List<string> arrList = clsReferFilesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ReferFilesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ReferFilesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ReferFilesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsReferFilesDA.SetFldValue(clsReferFilesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ReferFilesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsReferFilesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsReferFilesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsReferFilesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ReferFiles] "); 
 strCreateTabCode.Append(" ( "); 
 // /**引用文件Id*/ 
 strCreateTabCode.Append(" ReferFileId char(8) primary key, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) not Null, "); 
 // /**引用文件类型Id*/ 
 strCreateTabCode.Append(" ReferFileTypeId char(2) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) not Null, "); 
 // /**是否需要下载*/ 
 strCreateTabCode.Append(" IsNeedDownLoad bit Null, "); 
 // /**版本*/ 
 strCreateTabCode.Append(" Version varchar(30) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) not Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", conReferFiles.OrderNum); 
List<clsReferFilesEN> arrReferFilesObjList = new clsReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsReferFilesEN objReferFiles in arrReferFilesObjList)
{
objReferFiles.OrderNum = intIndex;
UpdateBySql2(objReferFiles);
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
/// <param name="strReferFileId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strReferFileId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[ReferFileId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字ReferFileId
//5、把当前关键字ReferFileId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字ReferFileId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevReferFileId = "";    //上一条序号的关键字ReferFileId
string strNextReferFileId = "";    //下一条序号的关键字ReferFileId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[ReferFileId],获取相应的序号[OrderNum]。

clsReferFilesEN objReferFiles = clsReferFilesBL.GetObjByReferFileId(strReferFileId);

intOrderNum = objReferFiles.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsReferFilesBL.GetRecCountByCond(clsReferFilesEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conReferFiles.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字ReferFileId
strPrevReferFileId = clsReferFilesBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevReferFileId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字ReferFileId所对应记录的序号减1
//6、把下(上)一个序号关键字ReferFileId所对应的记录序号加1
clsReferFilesBL.SetFldValue(clsReferFilesEN._CurrTabName, conReferFiles.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conReferFiles.ReferFileId, strReferFileId));
clsReferFilesBL.SetFldValue(clsReferFilesEN._CurrTabName, conReferFiles.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conReferFiles.ReferFileId, strPrevReferFileId));
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

//4、获取下一个序号字段的关键字ReferFileId
strCondition.AppendFormat(" {0} = {1}", conReferFiles.OrderNum, intOrderNum + 1);

strNextReferFileId = clsReferFilesBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextReferFileId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字ReferFileId所对应记录的序号加1
//6、把下(上)一个序号关键字ReferFileId所对应的记录序号减1
clsReferFilesBL.SetFldValue(clsReferFilesEN._CurrTabName, conReferFiles.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conReferFiles.ReferFileId, strReferFileId));
clsReferFilesBL.SetFldValue(clsReferFilesEN._CurrTabName, conReferFiles.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conReferFiles.ReferFileId, strNextReferFileId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsReferFilesBL.ReFreshCache();
if (clsReferFilesBL.relatedActions != null)
{
clsReferFilesBL.relatedActions.UpdRelaTabDate(objReferFiles.ReferFileId, "UpdRelaTabDate");
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
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conReferFiles.ReferFileId, strKeyList);
List<clsReferFilesEN> arrReferFilesLst = GetObjLst(strCondition);
foreach (clsReferFilesEN objReferFiles in arrReferFilesLst)
{
objReferFiles.OrderNum = objReferFiles.OrderNum + 10000;
UpdateBySql2(objReferFiles);
}
strCondition = string.Format("1 = 1 order by {0} ", conReferFiles.OrderNum); 
List<clsReferFilesEN> arrReferFilesObjList = new clsReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsReferFilesEN objReferFiles in arrReferFilesObjList)
{
objReferFiles.OrderNum = intIndex;
UpdateBySql2(objReferFiles);
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
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conReferFiles.ReferFileId, strKeyList);
List<clsReferFilesEN> arrReferFilesLst = GetObjLst(strCondition);
foreach (clsReferFilesEN objReferFiles in arrReferFilesLst)
{
objReferFiles.OrderNum = objReferFiles.OrderNum - 10000;
UpdateBySql2(objReferFiles);
}
strCondition = string.Format("1 = 1 order by {0} ", conReferFiles.OrderNum); 
List<clsReferFilesEN> arrReferFilesObjList = new clsReferFilesDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsReferFilesEN objReferFiles in arrReferFilesObjList)
{
objReferFiles.OrderNum = intIndex;
UpdateBySql2(objReferFiles);
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
 /// 引用文件(ReferFiles)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ReferFiles : clsCommFun4BL
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
clsReferFilesBL.ReFreshThisCache();
}
}

}