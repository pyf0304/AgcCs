
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResourceBL
 表名:FileResource(00050539)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理(ResourceMan)
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
public static class  clsFileResourceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileResourceEN GetObj(this K_FileResourceID_FileResource myKey)
{
clsFileResourceEN objFileResourceEN = clsFileResourceBL.FileResourceDA.GetObjByFileResourceID(myKey.Value);
return objFileResourceEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFileResourceEN objFileResourceEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFileResourceEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Cm工程Id = [{1}],文件目录名 = [{2}],文件名 = [{3}]的数据已经存在!(in clsFileResourceBL.AddNewRecord)", objFileResourceEN.PrjId,objFileResourceEN.CmPrjId,objFileResourceEN.FileDirName,objFileResourceEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFileResourceBL.FileResourceDA.AddNewRecordBySQL2(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
public static bool AddRecordEx(this clsFileResourceEN objFileResourceEN, bool bolIsNeedCheckUniqueness = true)
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
objFileResourceEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFileResourceEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],Cm工程Id(CmPrjId)=[{1}],文件目录名(FileDirName)=[{2}],文件名(FileName)=[{3}])已经存在,不能重复!", objFileResourceEN.PrjId, objFileResourceEN.CmPrjId, objFileResourceEN.FileDirName, objFileResourceEN.FileName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFileResourceEN.AddNewRecord();
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFileResourceEN objFileResourceEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFileResourceEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Cm工程Id = [{1}],文件目录名 = [{2}],文件名 = [{3}]的数据已经存在!(in clsFileResourceBL.AddNewRecordWithReturnKey)", objFileResourceEN.PrjId,objFileResourceEN.CmPrjId,objFileResourceEN.FileDirName,objFileResourceEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = clsFileResourceBL.FileResourceDA.AddNewRecordBySQL2WithReturnKey(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetFileResourceID(this clsFileResourceEN objFileResourceEN, long lngFileResourceID, string strComparisonOp="")
	{
objFileResourceEN.FileResourceID = lngFileResourceID; //FileResourceID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileResourceID) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileResourceID, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileResourceID] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetFileDirName(this clsFileResourceEN objFileResourceEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileDirName, conFileResource.FileDirName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileDirName, 200, conFileResource.FileDirName);
}
objFileResourceEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileDirName) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileDirName, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileDirName] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetFileName(this clsFileResourceEN objFileResourceEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conFileResource.FileName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileName, 150, conFileResource.FileName);
}
objFileResourceEN.FileName = strFileName; //文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileName) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileName, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileName] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetExtension(this clsFileResourceEN objFileResourceEN, string strExtension, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExtension, 20, conFileResource.Extension);
}
objFileResourceEN.Extension = strExtension; //扩展名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.Extension) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.Extension, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.Extension] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetTabId(this clsFileResourceEN objFileResourceEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conFileResource.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conFileResource.TabId);
}
objFileResourceEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.TabId) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.TabId, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.TabId] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIsBelongsCurrCMPrj(this clsFileResourceEN objFileResourceEN, bool bolIsBelongsCurrCMPrj, string strComparisonOp="")
	{
objFileResourceEN.IsBelongsCurrCMPrj = bolIsBelongsCurrCMPrj; //是否属于当前项目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IsBelongsCurrCMPrj) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IsBelongsCurrCMPrj, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IsBelongsCurrCMPrj] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIsGeneCode(this clsFileResourceEN objFileResourceEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objFileResourceEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IsGeneCode) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IsGeneCode, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IsGeneCode] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIsCanDel(this clsFileResourceEN objFileResourceEN, bool bolIsCanDel, string strComparisonOp="")
	{
objFileResourceEN.IsCanDel = bolIsCanDel; //是否可删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IsCanDel) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IsCanDel, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IsCanDel] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetFileLength(this clsFileResourceEN objFileResourceEN, long? lngFileLength, string strComparisonOp="")
	{
objFileResourceEN.FileLength = lngFileLength; //文件长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileLength) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileLength, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileLength] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetFileType(this clsFileResourceEN objFileResourceEN, string strFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileType, 30, conFileResource.FileType);
}
objFileResourceEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.FileType) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.FileType, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.FileType] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetCreationTime(this clsFileResourceEN objFileResourceEN, string strCreationTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreationTime, 20, conFileResource.CreationTime);
}
objFileResourceEN.CreationTime = strCreationTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.CreationTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.CreationTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.CreationTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetLastWriteTime(this clsFileResourceEN objFileResourceEN, string strLastWriteTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLastWriteTime, 30, conFileResource.LastWriteTime);
}
objFileResourceEN.LastWriteTime = strLastWriteTime; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.LastWriteTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.LastWriteTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.LastWriteTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetCheckDateTime(this clsFileResourceEN objFileResourceEN, string strCheckDateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCheckDateTime, 30, conFileResource.CheckDateTime);
}
objFileResourceEN.CheckDateTime = strCheckDateTime; //CheckDateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.CheckDateTime) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.CheckDateTime, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.CheckDateTime] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetInUse(this clsFileResourceEN objFileResourceEN, bool bolInUse, string strComparisonOp="")
	{
objFileResourceEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.InUse) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.InUse, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.InUse] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIsExistFile(this clsFileResourceEN objFileResourceEN, bool bolIsExistFile, string strComparisonOp="")
	{
objFileResourceEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IsExistFile) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IsExistFile, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IsExistFile] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetPrjId(this clsFileResourceEN objFileResourceEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFileResource.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conFileResource.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFileResource.PrjId);
}
objFileResourceEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.PrjId) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.PrjId, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.PrjId] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetCmPrjId(this clsFileResourceEN objFileResourceEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conFileResource.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conFileResource.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conFileResource.CmPrjId);
}
objFileResourceEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.CmPrjId) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.CmPrjId, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.CmPrjId] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIpAddress(this clsFileResourceEN objFileResourceEN, string strIpAddress, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, conFileResource.IpAddress);
}
objFileResourceEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IpAddress) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IpAddress, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IpAddress] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetIdFtpResource(this clsFileResourceEN objFileResourceEN, string strIdFtpResource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdFtpResource, 8, conFileResource.IdFtpResource);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdFtpResource, 8, conFileResource.IdFtpResource);
}
objFileResourceEN.IdFtpResource = strIdFtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.IdFtpResource) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.IdFtpResource, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.IdFtpResource] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetUpdDate(this clsFileResourceEN objFileResourceEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFileResource.UpdDate);
}
objFileResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.UpdDate) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.UpdDate, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.UpdDate] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetUpdUser(this clsFileResourceEN objFileResourceEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFileResource.UpdUser);
}
objFileResourceEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.UpdUser) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.UpdUser, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.UpdUser] = strComparisonOp;
}
}
return objFileResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFileResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFileResourceEN SetMemo(this clsFileResourceEN objFileResourceEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFileResource.Memo);
}
objFileResourceEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFileResourceEN.dicFldComparisonOp.ContainsKey(conFileResource.Memo) == false)
{
objFileResourceEN.dicFldComparisonOp.Add(conFileResource.Memo, strComparisonOp);
}
else
{
objFileResourceEN.dicFldComparisonOp[conFileResource.Memo] = strComparisonOp;
}
}
return objFileResourceEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFileResourceEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFileResourceEN objFileResourceEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFileResourceEN.CheckPropertyNew();
clsFileResourceEN objFileResourceCond = new clsFileResourceEN();
string strCondition = objFileResourceCond
.SetFileResourceID(objFileResourceEN.FileResourceID, "<>")
.SetPrjId(objFileResourceEN.PrjId, "=")
.SetCmPrjId(objFileResourceEN.CmPrjId, "=")
.SetFileDirName(objFileResourceEN.FileDirName, "=")
.SetFileName(objFileResourceEN.FileName, "=")
.GetCombineCondition();
objFileResourceEN._IsCheckProperty = true;
bool bolIsExist = clsFileResourceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_CMPrjId_FileDirName_FileName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFileResourceEN.Update();
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
 /// <param name = "objFileResource">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFileResourceEN objFileResource)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFileResourceEN objFileResourceCond = new clsFileResourceEN();
string strCondition = objFileResourceCond
.SetPrjId(objFileResource.PrjId, "=")
.SetCmPrjId(objFileResource.CmPrjId, "=")
.SetFileDirName(objFileResource.FileDirName, "=")
.SetFileName(objFileResource.FileName, "=")
.GetCombineCondition();
objFileResource._IsCheckProperty = true;
bool bolIsExist = clsFileResourceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFileResource.FileResourceID = clsFileResourceBL.GetFirstID_S(strCondition);
objFileResource.UpdateWithCondition(strCondition);
}
else
{
objFileResource.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileResourceEN objFileResourceEN)
{
 if (objFileResourceEN.FileResourceID == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileResourceBL.FileResourceDA.UpdateBySql2(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFileResourceEN objFileResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFileResourceEN.FileResourceID == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFileResourceBL.FileResourceDA.UpdateBySql2(objFileResourceEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileResourceEN objFileResourceEN, string strWhereCond)
{
try
{
bool bolResult = clsFileResourceBL.FileResourceDA.UpdateBySqlWithCondition(objFileResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFileResourceEN objFileResourceEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFileResourceBL.FileResourceDA.UpdateBySqlWithConditionTransaction(objFileResourceEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFileResourceEN objFileResourceEN)
{
try
{
int intRecNum = clsFileResourceBL.FileResourceDA.DelRecord(objFileResourceEN.FileResourceID);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceENS">源对象</param>
 /// <param name = "objFileResourceENT">目标对象</param>
 public static void CopyTo(this clsFileResourceEN objFileResourceENS, clsFileResourceEN objFileResourceENT)
{
try
{
objFileResourceENT.FileResourceID = objFileResourceENS.FileResourceID; //FileResourceID
objFileResourceENT.FileDirName = objFileResourceENS.FileDirName; //文件目录名
objFileResourceENT.FileName = objFileResourceENS.FileName; //文件名
objFileResourceENT.Extension = objFileResourceENS.Extension; //扩展名
objFileResourceENT.TabId = objFileResourceENS.TabId; //表ID
objFileResourceENT.IsBelongsCurrCMPrj = objFileResourceENS.IsBelongsCurrCMPrj; //是否属于当前项目
objFileResourceENT.IsGeneCode = objFileResourceENS.IsGeneCode; //是否生成代码
objFileResourceENT.IsCanDel = objFileResourceENS.IsCanDel; //是否可删除
objFileResourceENT.FileLength = objFileResourceENS.FileLength; //文件长度
objFileResourceENT.FileType = objFileResourceENS.FileType; //文件类型
objFileResourceENT.CreationTime = objFileResourceENS.CreationTime; //建立时间
objFileResourceENT.LastWriteTime = objFileResourceENS.LastWriteTime; //修改日期
objFileResourceENT.CheckDateTime = objFileResourceENS.CheckDateTime; //CheckDateTime
objFileResourceENT.InUse = objFileResourceENS.InUse; //是否在用
objFileResourceENT.IsExistFile = objFileResourceENS.IsExistFile; //是否存在文件
objFileResourceENT.PrjId = objFileResourceENS.PrjId; //工程Id
objFileResourceENT.CmPrjId = objFileResourceENS.CmPrjId; //Cm工程Id
objFileResourceENT.IpAddress = objFileResourceENS.IpAddress; //服务器
objFileResourceENT.IdFtpResource = objFileResourceENS.IdFtpResource; //FTP资源流水号
objFileResourceENT.UpdDate = objFileResourceENS.UpdDate; //修改日期
objFileResourceENT.UpdUser = objFileResourceENS.UpdUser; //修改者
objFileResourceENT.Memo = objFileResourceENS.Memo; //说明
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
 /// <param name = "objFileResourceENS">源对象</param>
 /// <returns>目标对象=>clsFileResourceEN:objFileResourceENT</returns>
 public static clsFileResourceEN CopyTo(this clsFileResourceEN objFileResourceENS)
{
try
{
 clsFileResourceEN objFileResourceENT = new clsFileResourceEN()
{
FileResourceID = objFileResourceENS.FileResourceID, //FileResourceID
FileDirName = objFileResourceENS.FileDirName, //文件目录名
FileName = objFileResourceENS.FileName, //文件名
Extension = objFileResourceENS.Extension, //扩展名
TabId = objFileResourceENS.TabId, //表ID
IsBelongsCurrCMPrj = objFileResourceENS.IsBelongsCurrCMPrj, //是否属于当前项目
IsGeneCode = objFileResourceENS.IsGeneCode, //是否生成代码
IsCanDel = objFileResourceENS.IsCanDel, //是否可删除
FileLength = objFileResourceENS.FileLength, //文件长度
FileType = objFileResourceENS.FileType, //文件类型
CreationTime = objFileResourceENS.CreationTime, //建立时间
LastWriteTime = objFileResourceENS.LastWriteTime, //修改日期
CheckDateTime = objFileResourceENS.CheckDateTime, //CheckDateTime
InUse = objFileResourceENS.InUse, //是否在用
IsExistFile = objFileResourceENS.IsExistFile, //是否存在文件
PrjId = objFileResourceENS.PrjId, //工程Id
CmPrjId = objFileResourceENS.CmPrjId, //Cm工程Id
IpAddress = objFileResourceENS.IpAddress, //服务器
IdFtpResource = objFileResourceENS.IdFtpResource, //FTP资源流水号
UpdDate = objFileResourceENS.UpdDate, //修改日期
UpdUser = objFileResourceENS.UpdUser, //修改者
Memo = objFileResourceENS.Memo, //说明
};
 return objFileResourceENT;
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
public static void CheckPropertyNew(this clsFileResourceEN objFileResourceEN)
{
 clsFileResourceBL.FileResourceDA.CheckPropertyNew(objFileResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFileResourceEN objFileResourceEN)
{
 clsFileResourceBL.FileResourceDA.CheckProperty4Condition(objFileResourceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFileResourceEN objFileResourceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFileResourceCond.IsUpdated(conFileResource.FileResourceID) == true)
{
string strComparisonOpFileResourceID = objFileResourceCond.dicFldComparisonOp[conFileResource.FileResourceID];
strWhereCond += string.Format(" And {0} {2} {1}", conFileResource.FileResourceID, objFileResourceCond.FileResourceID, strComparisonOpFileResourceID);
}
if (objFileResourceCond.IsUpdated(conFileResource.FileDirName) == true)
{
string strComparisonOpFileDirName = objFileResourceCond.dicFldComparisonOp[conFileResource.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileDirName, objFileResourceCond.FileDirName, strComparisonOpFileDirName);
}
if (objFileResourceCond.IsUpdated(conFileResource.FileName) == true)
{
string strComparisonOpFileName = objFileResourceCond.dicFldComparisonOp[conFileResource.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileName, objFileResourceCond.FileName, strComparisonOpFileName);
}
if (objFileResourceCond.IsUpdated(conFileResource.Extension) == true)
{
string strComparisonOpExtension = objFileResourceCond.dicFldComparisonOp[conFileResource.Extension];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.Extension, objFileResourceCond.Extension, strComparisonOpExtension);
}
if (objFileResourceCond.IsUpdated(conFileResource.TabId) == true)
{
string strComparisonOpTabId = objFileResourceCond.dicFldComparisonOp[conFileResource.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.TabId, objFileResourceCond.TabId, strComparisonOpTabId);
}
if (objFileResourceCond.IsUpdated(conFileResource.IsBelongsCurrCMPrj) == true)
{
if (objFileResourceCond.IsBelongsCurrCMPrj == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.IsBelongsCurrCMPrj);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.IsBelongsCurrCMPrj);
}
}
if (objFileResourceCond.IsUpdated(conFileResource.IsGeneCode) == true)
{
if (objFileResourceCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.IsGeneCode);
}
}
if (objFileResourceCond.IsUpdated(conFileResource.IsCanDel) == true)
{
if (objFileResourceCond.IsCanDel == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.IsCanDel);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.IsCanDel);
}
}
if (objFileResourceCond.IsUpdated(conFileResource.FileLength) == true)
{
string strComparisonOpFileLength = objFileResourceCond.dicFldComparisonOp[conFileResource.FileLength];
strWhereCond += string.Format(" And {0} {2} {1}", conFileResource.FileLength, objFileResourceCond.FileLength, strComparisonOpFileLength);
}
if (objFileResourceCond.IsUpdated(conFileResource.FileType) == true)
{
string strComparisonOpFileType = objFileResourceCond.dicFldComparisonOp[conFileResource.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.FileType, objFileResourceCond.FileType, strComparisonOpFileType);
}
if (objFileResourceCond.IsUpdated(conFileResource.CreationTime) == true)
{
string strComparisonOpCreationTime = objFileResourceCond.dicFldComparisonOp[conFileResource.CreationTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.CreationTime, objFileResourceCond.CreationTime, strComparisonOpCreationTime);
}
if (objFileResourceCond.IsUpdated(conFileResource.LastWriteTime) == true)
{
string strComparisonOpLastWriteTime = objFileResourceCond.dicFldComparisonOp[conFileResource.LastWriteTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.LastWriteTime, objFileResourceCond.LastWriteTime, strComparisonOpLastWriteTime);
}
if (objFileResourceCond.IsUpdated(conFileResource.CheckDateTime) == true)
{
string strComparisonOpCheckDateTime = objFileResourceCond.dicFldComparisonOp[conFileResource.CheckDateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.CheckDateTime, objFileResourceCond.CheckDateTime, strComparisonOpCheckDateTime);
}
if (objFileResourceCond.IsUpdated(conFileResource.InUse) == true)
{
if (objFileResourceCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.InUse);
}
}
if (objFileResourceCond.IsUpdated(conFileResource.IsExistFile) == true)
{
if (objFileResourceCond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFileResource.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFileResource.IsExistFile);
}
}
if (objFileResourceCond.IsUpdated(conFileResource.PrjId) == true)
{
string strComparisonOpPrjId = objFileResourceCond.dicFldComparisonOp[conFileResource.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.PrjId, objFileResourceCond.PrjId, strComparisonOpPrjId);
}
if (objFileResourceCond.IsUpdated(conFileResource.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objFileResourceCond.dicFldComparisonOp[conFileResource.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.CmPrjId, objFileResourceCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objFileResourceCond.IsUpdated(conFileResource.IpAddress) == true)
{
string strComparisonOpIpAddress = objFileResourceCond.dicFldComparisonOp[conFileResource.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.IpAddress, objFileResourceCond.IpAddress, strComparisonOpIpAddress);
}
if (objFileResourceCond.IsUpdated(conFileResource.IdFtpResource) == true)
{
string strComparisonOpIdFtpResource = objFileResourceCond.dicFldComparisonOp[conFileResource.IdFtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.IdFtpResource, objFileResourceCond.IdFtpResource, strComparisonOpIdFtpResource);
}
if (objFileResourceCond.IsUpdated(conFileResource.UpdDate) == true)
{
string strComparisonOpUpdDate = objFileResourceCond.dicFldComparisonOp[conFileResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.UpdDate, objFileResourceCond.UpdDate, strComparisonOpUpdDate);
}
if (objFileResourceCond.IsUpdated(conFileResource.UpdUser) == true)
{
string strComparisonOpUpdUser = objFileResourceCond.dicFldComparisonOp[conFileResource.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.UpdUser, objFileResourceCond.UpdUser, strComparisonOpUpdUser);
}
if (objFileResourceCond.IsUpdated(conFileResource.Memo) == true)
{
string strComparisonOpMemo = objFileResourceCond.dicFldComparisonOp[conFileResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFileResource.Memo, objFileResourceCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FileResource(文件资源), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_CMPrjId_FileDirName_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFileResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFileResourceEN objFileResourceEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFileResourceEN == null) return true;
if (objFileResourceEN.FileResourceID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFileResourceEN.PrjId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objFileResourceEN.CmPrjId);
 sbCondition.AppendFormat(" and FileDirName = '{0}'", objFileResourceEN.FileDirName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
if (clsFileResourceBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FileResourceID !=  {0}", objFileResourceEN.FileResourceID);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFileResourceEN.PrjId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objFileResourceEN.CmPrjId);
 sbCondition.AppendFormat(" and FileDirName = '{0}'", objFileResourceEN.FileDirName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
if (clsFileResourceBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FileResource(文件资源), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_CMPrjId_FileDirName_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFileResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFileResourceEN objFileResourceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFileResourceEN == null) return "";
if (objFileResourceEN.FileResourceID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFileResourceEN.PrjId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objFileResourceEN.CmPrjId);
 sbCondition.AppendFormat(" and FileDirName = '{0}'", objFileResourceEN.FileDirName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FileResourceID !=  {0}", objFileResourceEN.FileResourceID);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFileResourceEN.PrjId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objFileResourceEN.CmPrjId);
 sbCondition.AppendFormat(" and FileDirName = '{0}'", objFileResourceEN.FileDirName);
 sbCondition.AppendFormat(" and FileName = '{0}'", objFileResourceEN.FileName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FileResource
{
public virtual bool UpdRelaTabDate(long lngFileResourceID, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 文件资源(FileResource)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFileResourceBL
{
public static RelatedActions_FileResource relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFileResourceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFileResourceDA FileResourceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFileResourceDA();
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
 public clsFileResourceBL()
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
if (string.IsNullOrEmpty(clsFileResourceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFileResourceEN._ConnectString);
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
public static DataTable GetDataTable_FileResource(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FileResourceDA.GetDataTable_FileResource(strWhereCond);
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
objDT = FileResourceDA.GetDataTable(strWhereCond);
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
objDT = FileResourceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FileResourceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FileResourceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FileResourceDA.GetDataTable_Top(objTopPara);
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
objDT = FileResourceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FileResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FileResourceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFileResourceIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFileResourceEN> GetObjLstByFileResourceIDLst(List<long> arrFileResourceIDLst)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFileResourceIDLst);
 string strWhereCond = string.Format("FileResourceID in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFileResourceIDLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFileResourceEN> GetObjLstByFileResourceIDLstCache(List<long> arrFileResourceIDLst)
{
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName);
List<clsFileResourceEN> arrFileResourceObjLstCache = GetObjLstCache();
IEnumerable <clsFileResourceEN> arrFileResourceObjLst_Sel =
arrFileResourceObjLstCache
.Where(x => arrFileResourceIDLst.Contains(x.FileResourceID));
return arrFileResourceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileResourceEN> GetObjLst(string strWhereCond)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
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
public static List<clsFileResourceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFileResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFileResourceEN> GetSubObjLstCache(clsFileResourceEN objFileResourceCond)
{
List<clsFileResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileResource._AttributeName)
{
if (objFileResourceCond.IsUpdated(strFldName) == false) continue;
if (objFileResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileResourceCond[strFldName].ToString());
}
else
{
if (objFileResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileResourceCond[strFldName]));
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
public static List<clsFileResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
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
public static List<clsFileResourceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
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
List<clsFileResourceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFileResourceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileResourceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFileResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
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
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
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
public static List<clsFileResourceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFileResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFileResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
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
public static List<clsFileResourceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFileResourceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFileResourceEN> arrObjLst = new List<clsFileResourceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFileResourceEN objFileResourceEN = new clsFileResourceEN();
try
{
objFileResourceEN.FileResourceID = Int32.Parse(objRow[conFileResource.FileResourceID].ToString().Trim()); //FileResourceID
objFileResourceEN.FileDirName = objRow[conFileResource.FileDirName].ToString().Trim(); //文件目录名
objFileResourceEN.FileName = objRow[conFileResource.FileName].ToString().Trim(); //文件名
objFileResourceEN.Extension = objRow[conFileResource.Extension] == DBNull.Value ? null : objRow[conFileResource.Extension].ToString().Trim(); //扩展名
objFileResourceEN.TabId = objRow[conFileResource.TabId] == DBNull.Value ? null : objRow[conFileResource.TabId].ToString().Trim(); //表ID
objFileResourceEN.IsBelongsCurrCMPrj = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsBelongsCurrCMPrj].ToString().Trim()); //是否属于当前项目
objFileResourceEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsGeneCode].ToString().Trim()); //是否生成代码
objFileResourceEN.IsCanDel = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsCanDel].ToString().Trim()); //是否可删除
objFileResourceEN.FileLength = objRow[conFileResource.FileLength] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFileResource.FileLength].ToString().Trim()); //文件长度
objFileResourceEN.FileType = objRow[conFileResource.FileType] == DBNull.Value ? null : objRow[conFileResource.FileType].ToString().Trim(); //文件类型
objFileResourceEN.CreationTime = objRow[conFileResource.CreationTime] == DBNull.Value ? null : objRow[conFileResource.CreationTime].ToString().Trim(); //建立时间
objFileResourceEN.LastWriteTime = objRow[conFileResource.LastWriteTime] == DBNull.Value ? null : objRow[conFileResource.LastWriteTime].ToString().Trim(); //修改日期
objFileResourceEN.CheckDateTime = objRow[conFileResource.CheckDateTime] == DBNull.Value ? null : objRow[conFileResource.CheckDateTime].ToString().Trim(); //CheckDateTime
objFileResourceEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.InUse].ToString().Trim()); //是否在用
objFileResourceEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[conFileResource.IsExistFile].ToString().Trim()); //是否存在文件
objFileResourceEN.PrjId = objRow[conFileResource.PrjId].ToString().Trim(); //工程Id
objFileResourceEN.CmPrjId = objRow[conFileResource.CmPrjId].ToString().Trim(); //Cm工程Id
objFileResourceEN.IpAddress = objRow[conFileResource.IpAddress] == DBNull.Value ? null : objRow[conFileResource.IpAddress].ToString().Trim(); //服务器
objFileResourceEN.IdFtpResource = objRow[conFileResource.IdFtpResource] == DBNull.Value ? null : objRow[conFileResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objFileResourceEN.UpdDate = objRow[conFileResource.UpdDate] == DBNull.Value ? null : objRow[conFileResource.UpdDate].ToString().Trim(); //修改日期
objFileResourceEN.UpdUser = objRow[conFileResource.UpdUser] == DBNull.Value ? null : objRow[conFileResource.UpdUser].ToString().Trim(); //修改者
objFileResourceEN.Memo = objRow[conFileResource.Memo] == DBNull.Value ? null : objRow[conFileResource.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFileResourceEN.FileResourceID, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFileResourceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFileResourceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFileResource(ref clsFileResourceEN objFileResourceEN)
{
bool bolResult = FileResourceDA.GetFileResource(ref objFileResourceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngFileResourceID">表关键字</param>
 /// <returns>表对象</returns>
public static clsFileResourceEN GetObjByFileResourceID(long lngFileResourceID)
{
clsFileResourceEN objFileResourceEN = FileResourceDA.GetObjByFileResourceID(lngFileResourceID);
return objFileResourceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFileResourceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFileResourceEN objFileResourceEN = FileResourceDA.GetFirstObj(strWhereCond);
 return objFileResourceEN;
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
public static clsFileResourceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFileResourceEN objFileResourceEN = FileResourceDA.GetObjByDataRow(objRow);
 return objFileResourceEN;
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
public static clsFileResourceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFileResourceEN objFileResourceEN = FileResourceDA.GetObjByDataRow(objRow);
 return objFileResourceEN;
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
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <param name = "lstFileResourceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileResourceEN GetObjByFileResourceIDFromList(long lngFileResourceID, List<clsFileResourceEN> lstFileResourceObjLst)
{
foreach (clsFileResourceEN objFileResourceEN in lstFileResourceObjLst)
{
if (objFileResourceEN.FileResourceID == lngFileResourceID)
{
return objFileResourceEN;
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
 long lngFileResourceID;
 try
 {
 lngFileResourceID = new clsFileResourceDA().GetFirstID(strWhereCond);
 return lngFileResourceID;
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
 arrList = FileResourceDA.GetID(strWhereCond);
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
bool bolIsExist = FileResourceDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngFileResourceID)
{
//检测记录是否存在
bool bolIsExist = FileResourceDA.IsExist(lngFileResourceID);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngFileResourceID">FileResourceID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngFileResourceID, string strOpUser)
{
clsFileResourceEN objFileResourceEN = clsFileResourceBL.GetObjByFileResourceID(lngFileResourceID);
objFileResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFileResourceEN.UpdUser = strOpUser;
return clsFileResourceBL.UpdateBySql2(objFileResourceEN);
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
 bolIsExist = clsFileResourceDA.IsExistTable();
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
 bolIsExist = FileResourceDA.IsExistTable(strTabName);
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFileResourceEN objFileResourceEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFileResourceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Cm工程Id = [{1}],文件目录名 = [{2}],文件名 = [{3}]的数据已经存在!(in clsFileResourceBL.AddNewRecordBySql2)", objFileResourceEN.PrjId,objFileResourceEN.CmPrjId,objFileResourceEN.FileDirName,objFileResourceEN.FileName);
throw new Exception(strMsg);
}
try
{
bool bolResult = FileResourceDA.AddNewRecordBySQL2(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFileResourceEN objFileResourceEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFileResourceEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Cm工程Id = [{1}],文件目录名 = [{2}],文件名 = [{3}]的数据已经存在!(in clsFileResourceBL.AddNewRecordBySql2WithReturnKey)", objFileResourceEN.PrjId,objFileResourceEN.CmPrjId,objFileResourceEN.FileDirName,objFileResourceEN.FileName);
throw new Exception(strMsg);
}
try
{
string strKey = FileResourceDA.AddNewRecordBySQL2WithReturnKey(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFileResourceEN objFileResourceEN)
{
try
{
bool bolResult = FileResourceDA.Update(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "objFileResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFileResourceEN objFileResourceEN)
{
 if (objFileResourceEN.FileResourceID == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FileResourceDA.UpdateBySql2(objFileResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFileResourceBL.ReFreshCache();

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
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
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngFileResourceID)
{
try
{
 clsFileResourceEN objFileResourceEN = clsFileResourceBL.GetObjByFileResourceID(lngFileResourceID);

if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(objFileResourceEN.FileResourceID, objFileResourceEN.UpdUser);
}
if (objFileResourceEN != null)
{
int intRecNum = FileResourceDA.DelRecord(lngFileResourceID);
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
/// <param name="lngFileResourceID">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngFileResourceID )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileResourceDA.GetSpecSQLObj();
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
//删除与表:[FileResource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFileResource.FileResourceID,
//lngFileResourceID);
//        clsFileResourceBL.DelFileResourcesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileResourceBL.DelRecord(lngFileResourceID, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileResourceBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngFileResourceID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngFileResourceID">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngFileResourceID, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFileResourceBL.relatedActions != null)
{
clsFileResourceBL.relatedActions.UpdRelaTabDate(lngFileResourceID, "UpdRelaTabDate");
}
bool bolResult = FileResourceDA.DelRecord(lngFileResourceID,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFileResourceIDLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFileResources(List<string> arrFileResourceIDLst)
{
if (arrFileResourceIDLst.Count == 0) return 0;
try
{
if (clsFileResourceBL.relatedActions != null)
{
foreach (var strFileResourceID in arrFileResourceIDLst)
{
long lngFileResourceID = long.Parse(strFileResourceID);
clsFileResourceBL.relatedActions.UpdRelaTabDate(lngFileResourceID, "UpdRelaTabDate");
}
}
int intDelRecNum = FileResourceDA.DelFileResource(arrFileResourceIDLst);
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
public static int DelFileResourcesByCond(string strWhereCond)
{
try
{
if (clsFileResourceBL.relatedActions != null)
{
List<string> arrFileResourceID = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFileResourceID in arrFileResourceID)
{
long lngFileResourceID = long.Parse(strFileResourceID);
clsFileResourceBL.relatedActions.UpdRelaTabDate(lngFileResourceID, "UpdRelaTabDate");
}
}
int intRecNum = FileResourceDA.DelFileResource(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FileResource]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngFileResourceID">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngFileResourceID)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFileResourceDA.GetSpecSQLObj();
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
//删除与表:[FileResource]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFileResourceBL.DelRecord(lngFileResourceID, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFileResourceBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngFileResourceID, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFileResourceENS">源对象</param>
 /// <param name = "objFileResourceENT">目标对象</param>
 public static void CopyTo(clsFileResourceEN objFileResourceENS, clsFileResourceEN objFileResourceENT)
{
try
{
objFileResourceENT.FileResourceID = objFileResourceENS.FileResourceID; //FileResourceID
objFileResourceENT.FileDirName = objFileResourceENS.FileDirName; //文件目录名
objFileResourceENT.FileName = objFileResourceENS.FileName; //文件名
objFileResourceENT.Extension = objFileResourceENS.Extension; //扩展名
objFileResourceENT.TabId = objFileResourceENS.TabId; //表ID
objFileResourceENT.IsBelongsCurrCMPrj = objFileResourceENS.IsBelongsCurrCMPrj; //是否属于当前项目
objFileResourceENT.IsGeneCode = objFileResourceENS.IsGeneCode; //是否生成代码
objFileResourceENT.IsCanDel = objFileResourceENS.IsCanDel; //是否可删除
objFileResourceENT.FileLength = objFileResourceENS.FileLength; //文件长度
objFileResourceENT.FileType = objFileResourceENS.FileType; //文件类型
objFileResourceENT.CreationTime = objFileResourceENS.CreationTime; //建立时间
objFileResourceENT.LastWriteTime = objFileResourceENS.LastWriteTime; //修改日期
objFileResourceENT.CheckDateTime = objFileResourceENS.CheckDateTime; //CheckDateTime
objFileResourceENT.InUse = objFileResourceENS.InUse; //是否在用
objFileResourceENT.IsExistFile = objFileResourceENS.IsExistFile; //是否存在文件
objFileResourceENT.PrjId = objFileResourceENS.PrjId; //工程Id
objFileResourceENT.CmPrjId = objFileResourceENS.CmPrjId; //Cm工程Id
objFileResourceENT.IpAddress = objFileResourceENS.IpAddress; //服务器
objFileResourceENT.IdFtpResource = objFileResourceENS.IdFtpResource; //FTP资源流水号
objFileResourceENT.UpdDate = objFileResourceENS.UpdDate; //修改日期
objFileResourceENT.UpdUser = objFileResourceENS.UpdUser; //修改者
objFileResourceENT.Memo = objFileResourceENS.Memo; //说明
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
 /// <param name = "objFileResourceEN">源简化对象</param>
 public static void SetUpdFlag(clsFileResourceEN objFileResourceEN)
{
try
{
objFileResourceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFileResourceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFileResource.FileResourceID, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.FileResourceID = objFileResourceEN.FileResourceID; //FileResourceID
}
if (arrFldSet.Contains(conFileResource.FileDirName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.FileDirName = objFileResourceEN.FileDirName; //文件目录名
}
if (arrFldSet.Contains(conFileResource.FileName, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.FileName = objFileResourceEN.FileName; //文件名
}
if (arrFldSet.Contains(conFileResource.Extension, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.Extension = objFileResourceEN.Extension == "[null]" ? null :  objFileResourceEN.Extension; //扩展名
}
if (arrFldSet.Contains(conFileResource.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.TabId = objFileResourceEN.TabId == "[null]" ? null :  objFileResourceEN.TabId; //表ID
}
if (arrFldSet.Contains(conFileResource.IsBelongsCurrCMPrj, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IsBelongsCurrCMPrj = objFileResourceEN.IsBelongsCurrCMPrj; //是否属于当前项目
}
if (arrFldSet.Contains(conFileResource.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IsGeneCode = objFileResourceEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(conFileResource.IsCanDel, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IsCanDel = objFileResourceEN.IsCanDel; //是否可删除
}
if (arrFldSet.Contains(conFileResource.FileLength, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.FileLength = objFileResourceEN.FileLength; //文件长度
}
if (arrFldSet.Contains(conFileResource.FileType, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.FileType = objFileResourceEN.FileType == "[null]" ? null :  objFileResourceEN.FileType; //文件类型
}
if (arrFldSet.Contains(conFileResource.CreationTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.CreationTime = objFileResourceEN.CreationTime == "[null]" ? null :  objFileResourceEN.CreationTime; //建立时间
}
if (arrFldSet.Contains(conFileResource.LastWriteTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.LastWriteTime = objFileResourceEN.LastWriteTime == "[null]" ? null :  objFileResourceEN.LastWriteTime; //修改日期
}
if (arrFldSet.Contains(conFileResource.CheckDateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.CheckDateTime = objFileResourceEN.CheckDateTime == "[null]" ? null :  objFileResourceEN.CheckDateTime; //CheckDateTime
}
if (arrFldSet.Contains(conFileResource.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.InUse = objFileResourceEN.InUse; //是否在用
}
if (arrFldSet.Contains(conFileResource.IsExistFile, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IsExistFile = objFileResourceEN.IsExistFile; //是否存在文件
}
if (arrFldSet.Contains(conFileResource.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.PrjId = objFileResourceEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conFileResource.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.CmPrjId = objFileResourceEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conFileResource.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IpAddress = objFileResourceEN.IpAddress == "[null]" ? null :  objFileResourceEN.IpAddress; //服务器
}
if (arrFldSet.Contains(conFileResource.IdFtpResource, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.IdFtpResource = objFileResourceEN.IdFtpResource == "[null]" ? null :  objFileResourceEN.IdFtpResource; //FTP资源流水号
}
if (arrFldSet.Contains(conFileResource.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.UpdDate = objFileResourceEN.UpdDate == "[null]" ? null :  objFileResourceEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFileResource.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.UpdUser = objFileResourceEN.UpdUser == "[null]" ? null :  objFileResourceEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFileResource.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFileResourceEN.Memo = objFileResourceEN.Memo == "[null]" ? null :  objFileResourceEN.Memo; //说明
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
 /// <param name = "objFileResourceEN">源简化对象</param>
 public static void AccessFldValueNull(clsFileResourceEN objFileResourceEN)
{
try
{
if (objFileResourceEN.Extension == "[null]") objFileResourceEN.Extension = null; //扩展名
if (objFileResourceEN.TabId == "[null]") objFileResourceEN.TabId = null; //表ID
if (objFileResourceEN.FileType == "[null]") objFileResourceEN.FileType = null; //文件类型
if (objFileResourceEN.CreationTime == "[null]") objFileResourceEN.CreationTime = null; //建立时间
if (objFileResourceEN.LastWriteTime == "[null]") objFileResourceEN.LastWriteTime = null; //修改日期
if (objFileResourceEN.CheckDateTime == "[null]") objFileResourceEN.CheckDateTime = null; //CheckDateTime
if (objFileResourceEN.IpAddress == "[null]") objFileResourceEN.IpAddress = null; //服务器
if (objFileResourceEN.IdFtpResource == "[null]") objFileResourceEN.IdFtpResource = null; //FTP资源流水号
if (objFileResourceEN.UpdDate == "[null]") objFileResourceEN.UpdDate = null; //修改日期
if (objFileResourceEN.UpdUser == "[null]") objFileResourceEN.UpdUser = null; //修改者
if (objFileResourceEN.Memo == "[null]") objFileResourceEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFileResourceEN objFileResourceEN)
{
 FileResourceDA.CheckPropertyNew(objFileResourceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFileResourceEN objFileResourceEN)
{
 FileResourceDA.CheckProperty4Condition(objFileResourceEN);
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
if (clsFileResourceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileResourceBL没有刷新缓存机制(clsFileResourceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FileResourceID");
//if (arrFileResourceObjLstCache == null)
//{
//arrFileResourceObjLstCache = FileResourceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngFileResourceID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFileResourceEN GetObjByFileResourceIDCache(long lngFileResourceID)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName);
List<clsFileResourceEN> arrFileResourceObjLstCache = GetObjLstCache();
IEnumerable <clsFileResourceEN> arrFileResourceObjLst_Sel =
arrFileResourceObjLstCache
.Where(x=> x.FileResourceID == lngFileResourceID 
);
if (arrFileResourceObjLst_Sel.Count() == 0)
{
   clsFileResourceEN obj = clsFileResourceBL.GetObjByFileResourceID(lngFileResourceID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFileResourceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileResourceEN> GetAllFileResourceObjLstCache()
{
//获取缓存中的对象列表
List<clsFileResourceEN> arrFileResourceObjLstCache = GetObjLstCache(); 
return arrFileResourceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFileResourceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName);
List<clsFileResourceEN> arrFileResourceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFileResourceObjLstCache;
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
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFileResourceEN._RefreshTimeLst.Count == 0) return "";
return clsFileResourceEN._RefreshTimeLst[clsFileResourceEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFileResourceBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFileResourceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFileResourceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFileResourceBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FileResource(文件资源)
 /// 唯一性条件:PrjId_CMPrjId_FileDirName_FileName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFileResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFileResourceEN objFileResourceEN)
{
//检测记录是否存在
string strResult = FileResourceDA.GetUniCondStr(objFileResourceEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngFileResourceID)
{
if (strInFldName != conFileResource.FileResourceID)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFileResource._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFileResource._AttributeName));
throw new Exception(strMsg);
}
var objFileResource = clsFileResourceBL.GetObjByFileResourceIDCache(lngFileResourceID);
if (objFileResource == null) return "";
return objFileResource[strOutFldName].ToString();
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
int intRecCount = clsFileResourceDA.GetRecCount(strTabName);
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
int intRecCount = clsFileResourceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFileResourceDA.GetRecCount();
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
int intRecCount = clsFileResourceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFileResourceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFileResourceEN objFileResourceCond)
{
List<clsFileResourceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFileResourceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFileResource._AttributeName)
{
if (objFileResourceCond.IsUpdated(strFldName) == false) continue;
if (objFileResourceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileResourceCond[strFldName].ToString());
}
else
{
if (objFileResourceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFileResourceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFileResourceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFileResourceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFileResourceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFileResourceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFileResourceCond[strFldName]));
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
 List<string> arrList = clsFileResourceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FileResourceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FileResourceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FileResourceDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileResourceDA.SetFldValue(clsFileResourceEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FileResourceDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileResourceDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFileResourceDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFileResourceDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FileResource] "); 
 strCreateTabCode.Append(" ( "); 
 // /**FileResourceID*/ 
 strCreateTabCode.Append(" FileResourceID bigint primary key identity, "); 
 // /**文件目录名*/ 
 strCreateTabCode.Append(" FileDirName varchar(200) not Null, "); 
 // /**文件名*/ 
 strCreateTabCode.Append(" FileName varchar(150) not Null, "); 
 // /**扩展名*/ 
 strCreateTabCode.Append(" Extension varchar(20) Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) Null, "); 
 // /**是否属于当前项目*/ 
 strCreateTabCode.Append(" IsBelongsCurrCMPrj bit Null, "); 
 // /**是否生成代码*/ 
 strCreateTabCode.Append(" IsGeneCode bit Null, "); 
 // /**是否可删除*/ 
 strCreateTabCode.Append(" IsCanDel bit Null, "); 
 // /**文件长度*/ 
 strCreateTabCode.Append(" FileLength bigint Null, "); 
 // /**文件类型*/ 
 strCreateTabCode.Append(" FileType varchar(30) Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreationTime varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" LastWriteTime varchar(30) Null, "); 
 // /**CheckDateTime*/ 
 strCreateTabCode.Append(" CheckDateTime varchar(30) Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**是否存在文件*/ 
 strCreateTabCode.Append(" IsExistFile bit Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**服务器*/ 
 strCreateTabCode.Append(" IpAddress varchar(25) Null, "); 
 // /**FTP资源流水号*/ 
 strCreateTabCode.Append(" IdFtpResource char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 文件资源(FileResource)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FileResource : clsCommFun4BL
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
clsFileResourceBL.ReFreshThisCache();
}
}

}