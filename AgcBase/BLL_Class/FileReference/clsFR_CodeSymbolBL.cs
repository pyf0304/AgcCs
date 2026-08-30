
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_CodeSymbolBL
 表名:FR_CodeSymbol(00050657)
 * 版本:2026.07.24(服务器:WIN-SRV103-116)
 日期:2026/07/24 08:14:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
public static class  clsFR_CodeSymbolBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSymbolId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_CodeSymbolEN GetObj(this K_SymbolId_FR_CodeSymbol myKey)
{
clsFR_CodeSymbolEN objFR_CodeSymbolEN = clsFR_CodeSymbolBL.FR_CodeSymbolDA.GetObjBySymbolId(myKey.Value);
return objFR_CodeSymbolEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFR_CodeSymbolEN) == false)
{
var strMsg = string.Format("记录已经存在!文件资源Id = [{0}],符号名称 = [{1}],符号类型 = [{2}]的数据已经存在!(in clsFR_CodeSymbolBL.AddNewRecord)", objFR_CodeSymbolEN.FileResourceId,objFR_CodeSymbolEN.SymbolName,objFR_CodeSymbolEN.SymbolType);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFR_CodeSymbolBL.FR_CodeSymbolDA.AddNewRecordBySQL2(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsNeedCheckUniqueness = true)
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
objFR_CodeSymbolEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFR_CodeSymbolEN.CheckUniqueness() == false)
{
strMsg = string.Format("(文件资源Id(FileResourceId)=[{0}],符号名称(SymbolName)=[{1}],符号类型(SymbolType)=[{2}])已经存在,不能重复!", objFR_CodeSymbolEN.FileResourceId, objFR_CodeSymbolEN.SymbolName, objFR_CodeSymbolEN.SymbolType);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFR_CodeSymbolEN.AddNewRecord();
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFR_CodeSymbolEN) == false)
{
var strMsg = string.Format("记录已经存在!文件资源Id = [{0}],符号名称 = [{1}],符号类型 = [{2}]的数据已经存在!(in clsFR_CodeSymbolBL.AddNewRecordWithReturnKey)", objFR_CodeSymbolEN.FileResourceId,objFR_CodeSymbolEN.SymbolName,objFR_CodeSymbolEN.SymbolType);
throw new Exception(strMsg);
}
try
{
string strKey = clsFR_CodeSymbolBL.FR_CodeSymbolDA.AddNewRecordBySQL2WithReturnKey(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetSymbolId(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, long lngSymbolId, string strComparisonOp="")
	{
objFR_CodeSymbolEN.SymbolId = lngSymbolId; //符号Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.SymbolId) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.SymbolId, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.SymbolId] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetFileResourceId(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, long lngFileResourceId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngFileResourceId, conFR_CodeSymbol.FileResourceId);
objFR_CodeSymbolEN.FileResourceId = lngFileResourceId; //文件资源Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.FileResourceId) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.FileResourceId, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.FileResourceId] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetSymbolName(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strSymbolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolName, conFR_CodeSymbol.SymbolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolName, 100, conFR_CodeSymbol.SymbolName);
}
objFR_CodeSymbolEN.SymbolName = strSymbolName; //符号名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.SymbolName) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.SymbolName, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.SymbolName] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetSymbolType(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strSymbolType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSymbolType, conFR_CodeSymbol.SymbolType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolType, 100, conFR_CodeSymbol.SymbolType);
}
objFR_CodeSymbolEN.SymbolType = strSymbolType; //符号类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.SymbolType) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.SymbolType, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.SymbolType] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetSymbolExportType(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strSymbolExportType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSymbolExportType, 100, conFR_CodeSymbol.SymbolExportType);
}
objFR_CodeSymbolEN.SymbolExportType = strSymbolExportType; //符号导出类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.SymbolExportType) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.SymbolExportType, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.SymbolExportType] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetIsExported(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsExported, string strComparisonOp="")
	{
objFR_CodeSymbolEN.IsExported = bolIsExported; //是否导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.IsExported) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.IsExported, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.IsExported] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetLineStart(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, int? intLineStart, string strComparisonOp="")
	{
objFR_CodeSymbolEN.LineStart = intLineStart; //开始行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.LineStart) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.LineStart, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.LineStart] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetLineEnd(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, int? intLineEnd, string strComparisonOp="")
	{
objFR_CodeSymbolEN.LineEnd = intLineEnd; //结束行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.LineEnd) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.LineEnd, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.LineEnd] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetColumnStart(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, int? intColumnStart, string strComparisonOp="")
	{
objFR_CodeSymbolEN.ColumnStart = intColumnStart; //开始列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.ColumnStart) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.ColumnStart, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.ColumnStart] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetColumnEnd(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, int? intColumnEnd, string strComparisonOp="")
	{
objFR_CodeSymbolEN.ColumnEnd = intColumnEnd; //结束列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.ColumnEnd) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.ColumnEnd, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.ColumnEnd] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetSignature(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSignature, 200, conFR_CodeSymbol.Signature);
}
objFR_CodeSymbolEN.Signature = strSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.Signature) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.Signature, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.Signature] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetDocComment(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strDocComment, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocComment, 500, conFR_CodeSymbol.DocComment);
}
objFR_CodeSymbolEN.DocComment = strDocComment; //文档注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.DocComment) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.DocComment, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.DocComment] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_CodeSymbolEN SetCreatedAt(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, DateTime dteCreatedAt, string strComparisonOp="")
	{
objFR_CodeSymbolEN.CreatedAt = dteCreatedAt; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_CodeSymbolEN.dicFldComparisonOp.ContainsKey(conFR_CodeSymbol.CreatedAt) == false)
{
objFR_CodeSymbolEN.dicFldComparisonOp.Add(conFR_CodeSymbol.CreatedAt, strComparisonOp);
}
else
{
objFR_CodeSymbolEN.dicFldComparisonOp[conFR_CodeSymbol.CreatedAt] = strComparisonOp;
}
}
return objFR_CodeSymbolEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFR_CodeSymbolEN.CheckPropertyNew();
clsFR_CodeSymbolEN objFR_CodeSymbolCond = new clsFR_CodeSymbolEN();
string strCondition = objFR_CodeSymbolCond
.SetSymbolId(objFR_CodeSymbolEN.SymbolId, "<>")
.SetFileResourceId(objFR_CodeSymbolEN.FileResourceId, "=")
.SetSymbolName(objFR_CodeSymbolEN.SymbolName, "=")
.SetSymbolType(objFR_CodeSymbolEN.SymbolType, "=")
.GetCombineCondition();
objFR_CodeSymbolEN._IsCheckProperty = true;
bool bolIsExist = clsFR_CodeSymbolBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFR_CodeSymbolEN.Update();
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
 /// <param name = "objFR_CodeSymbol">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFR_CodeSymbolEN objFR_CodeSymbol)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFR_CodeSymbolEN objFR_CodeSymbolCond = new clsFR_CodeSymbolEN();
string strCondition = objFR_CodeSymbolCond
.SetFileResourceId(objFR_CodeSymbol.FileResourceId, "=")
.SetSymbolName(objFR_CodeSymbol.SymbolName, "=")
.SetSymbolType(objFR_CodeSymbol.SymbolType, "=")
.GetCombineCondition();
objFR_CodeSymbol._IsCheckProperty = true;
bool bolIsExist = clsFR_CodeSymbolBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFR_CodeSymbol.SymbolId = clsFR_CodeSymbolBL.GetFirstID_S(strCondition);
objFR_CodeSymbol.UpdateWithCondition(strCondition);
}
else
{
objFR_CodeSymbol.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN.SymbolId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_CodeSymbolBL.FR_CodeSymbolDA.UpdateBySql2(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_CodeSymbolEN.SymbolId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_CodeSymbolBL.FR_CodeSymbolDA.UpdateBySql2(objFR_CodeSymbolEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strWhereCond)
{
try
{
bool bolResult = clsFR_CodeSymbolBL.FR_CodeSymbolDA.UpdateBySqlWithCondition(objFR_CodeSymbolEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFR_CodeSymbolBL.FR_CodeSymbolDA.UpdateBySqlWithConditionTransaction(objFR_CodeSymbolEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
try
{
int intRecNum = clsFR_CodeSymbolBL.FR_CodeSymbolDA.DelRecord(objFR_CodeSymbolEN.SymbolId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <param name = "objFR_CodeSymbolENT">目标对象</param>
 public static void CopyTo(this clsFR_CodeSymbolEN objFR_CodeSymbolENS, clsFR_CodeSymbolEN objFR_CodeSymbolENT)
{
try
{
objFR_CodeSymbolENT.SymbolId = objFR_CodeSymbolENS.SymbolId; //符号Id
objFR_CodeSymbolENT.FileResourceId = objFR_CodeSymbolENS.FileResourceId; //文件资源Id
objFR_CodeSymbolENT.SymbolName = objFR_CodeSymbolENS.SymbolName; //符号名称
objFR_CodeSymbolENT.SymbolType = objFR_CodeSymbolENS.SymbolType; //符号类型
objFR_CodeSymbolENT.SymbolExportType = objFR_CodeSymbolENS.SymbolExportType; //符号导出类型
objFR_CodeSymbolENT.IsExported = objFR_CodeSymbolENS.IsExported; //是否导出
objFR_CodeSymbolENT.LineStart = objFR_CodeSymbolENS.LineStart; //开始行
objFR_CodeSymbolENT.LineEnd = objFR_CodeSymbolENS.LineEnd; //结束行
objFR_CodeSymbolENT.ColumnStart = objFR_CodeSymbolENS.ColumnStart; //开始列
objFR_CodeSymbolENT.ColumnEnd = objFR_CodeSymbolENS.ColumnEnd; //结束列
objFR_CodeSymbolENT.Signature = objFR_CodeSymbolENS.Signature; //函数签名
objFR_CodeSymbolENT.DocComment = objFR_CodeSymbolENS.DocComment; //文档注释
objFR_CodeSymbolENT.CreatedAt = objFR_CodeSymbolENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <returns>目标对象=>clsFR_CodeSymbolEN:objFR_CodeSymbolENT</returns>
 public static clsFR_CodeSymbolEN CopyTo(this clsFR_CodeSymbolEN objFR_CodeSymbolENS)
{
try
{
 clsFR_CodeSymbolEN objFR_CodeSymbolENT = new clsFR_CodeSymbolEN()
{
SymbolId = objFR_CodeSymbolENS.SymbolId, //符号Id
FileResourceId = objFR_CodeSymbolENS.FileResourceId, //文件资源Id
SymbolName = objFR_CodeSymbolENS.SymbolName, //符号名称
SymbolType = objFR_CodeSymbolENS.SymbolType, //符号类型
SymbolExportType = objFR_CodeSymbolENS.SymbolExportType, //符号导出类型
IsExported = objFR_CodeSymbolENS.IsExported, //是否导出
LineStart = objFR_CodeSymbolENS.LineStart, //开始行
LineEnd = objFR_CodeSymbolENS.LineEnd, //结束行
ColumnStart = objFR_CodeSymbolENS.ColumnStart, //开始列
ColumnEnd = objFR_CodeSymbolENS.ColumnEnd, //结束列
Signature = objFR_CodeSymbolENS.Signature, //函数签名
DocComment = objFR_CodeSymbolENS.DocComment, //文档注释
CreatedAt = objFR_CodeSymbolENS.CreatedAt, //建立时间
};
 return objFR_CodeSymbolENT;
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
public static void CheckPropertyNew(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 clsFR_CodeSymbolBL.FR_CodeSymbolDA.CheckPropertyNew(objFR_CodeSymbolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 clsFR_CodeSymbolBL.FR_CodeSymbolDA.CheckProperty4Condition(objFR_CodeSymbolEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFR_CodeSymbolEN objFR_CodeSymbolCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.SymbolId) == true)
{
string strComparisonOpSymbolId = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.SymbolId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.SymbolId, objFR_CodeSymbolCond.SymbolId, strComparisonOpSymbolId);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.FileResourceId) == true)
{
string strComparisonOpFileResourceId = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.FileResourceId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.FileResourceId, objFR_CodeSymbolCond.FileResourceId, strComparisonOpFileResourceId);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.SymbolName) == true)
{
string strComparisonOpSymbolName = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.SymbolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.SymbolName, objFR_CodeSymbolCond.SymbolName, strComparisonOpSymbolName);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.SymbolType) == true)
{
string strComparisonOpSymbolType = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.SymbolType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.SymbolType, objFR_CodeSymbolCond.SymbolType, strComparisonOpSymbolType);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.SymbolExportType) == true)
{
string strComparisonOpSymbolExportType = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.SymbolExportType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.SymbolExportType, objFR_CodeSymbolCond.SymbolExportType, strComparisonOpSymbolExportType);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.IsExported) == true)
{
if (objFR_CodeSymbolCond.IsExported == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFR_CodeSymbol.IsExported);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFR_CodeSymbol.IsExported);
}
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.LineStart) == true)
{
string strComparisonOpLineStart = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.LineStart];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.LineStart, objFR_CodeSymbolCond.LineStart, strComparisonOpLineStart);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.LineEnd) == true)
{
string strComparisonOpLineEnd = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.LineEnd];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.LineEnd, objFR_CodeSymbolCond.LineEnd, strComparisonOpLineEnd);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.ColumnStart) == true)
{
string strComparisonOpColumnStart = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.ColumnStart];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.ColumnStart, objFR_CodeSymbolCond.ColumnStart, strComparisonOpColumnStart);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.ColumnEnd) == true)
{
string strComparisonOpColumnEnd = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.ColumnEnd];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_CodeSymbol.ColumnEnd, objFR_CodeSymbolCond.ColumnEnd, strComparisonOpColumnEnd);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.Signature) == true)
{
string strComparisonOpSignature = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.Signature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.Signature, objFR_CodeSymbolCond.Signature, strComparisonOpSignature);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.DocComment) == true)
{
string strComparisonOpDocComment = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.DocComment];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.DocComment, objFR_CodeSymbolCond.DocComment, strComparisonOpDocComment);
}
if (objFR_CodeSymbolCond.IsUpdated(conFR_CodeSymbol.CreatedAt) == true)
{
string strComparisonOpCreatedAt = objFR_CodeSymbolCond.dicFldComparisonOp[conFR_CodeSymbol.CreatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_CodeSymbol.CreatedAt, objFR_CodeSymbolCond.CreatedAt, strComparisonOpCreatedAt);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FR_CodeSymbol(FR_CodeSymbol), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FileResourceId_SymbolName_SymbolType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFR_CodeSymbolEN == null) return true;
if (objFR_CodeSymbolEN.SymbolId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileResourceId = '{0}'", objFR_CodeSymbolEN.FileResourceId);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objFR_CodeSymbolEN.SymbolName);
 sbCondition.AppendFormat(" and SymbolType = '{0}'", objFR_CodeSymbolEN.SymbolType);
if (clsFR_CodeSymbolBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SymbolId !=  {0}", objFR_CodeSymbolEN.SymbolId);
 sbCondition.AppendFormat(" and FileResourceId = '{0}'", objFR_CodeSymbolEN.FileResourceId);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objFR_CodeSymbolEN.SymbolName);
 sbCondition.AppendFormat(" and SymbolType = '{0}'", objFR_CodeSymbolEN.SymbolType);
if (clsFR_CodeSymbolBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FR_CodeSymbol(FR_CodeSymbol), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FileResourceId_SymbolName_SymbolType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFR_CodeSymbolEN == null) return "";
if (objFR_CodeSymbolEN.SymbolId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileResourceId = '{0}'", objFR_CodeSymbolEN.FileResourceId);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objFR_CodeSymbolEN.SymbolName);
 sbCondition.AppendFormat(" and SymbolType = '{0}'", objFR_CodeSymbolEN.SymbolType);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SymbolId !=  {0}", objFR_CodeSymbolEN.SymbolId);
 sbCondition.AppendFormat(" and FileResourceId = '{0}'", objFR_CodeSymbolEN.FileResourceId);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objFR_CodeSymbolEN.SymbolName);
 sbCondition.AppendFormat(" and SymbolType = '{0}'", objFR_CodeSymbolEN.SymbolType);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FR_CodeSymbol
{
public virtual bool UpdRelaTabDate(long lngSymbolId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFR_CodeSymbolBL
{
public static RelatedActions_FR_CodeSymbol relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFR_CodeSymbolDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFR_CodeSymbolDA FR_CodeSymbolDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFR_CodeSymbolDA();
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
 public clsFR_CodeSymbolBL()
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
if (string.IsNullOrEmpty(clsFR_CodeSymbolEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFR_CodeSymbolEN._ConnectString);
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
public static DataTable GetDataTable_FR_CodeSymbol(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FR_CodeSymbolDA.GetDataTable_FR_CodeSymbol(strWhereCond);
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
objDT = FR_CodeSymbolDA.GetDataTable(strWhereCond);
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
objDT = FR_CodeSymbolDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FR_CodeSymbolDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FR_CodeSymbolDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FR_CodeSymbolDA.GetDataTable_Top(objTopPara);
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
objDT = FR_CodeSymbolDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FR_CodeSymbolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FR_CodeSymbolDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSymbolIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetObjLstBySymbolIdLst(List<long> arrSymbolIdLst)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSymbolIdLst);
 string strWhereCond = string.Format("SymbolId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSymbolIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFR_CodeSymbolEN> GetObjLstBySymbolIdLstCache(List<long> arrSymbolIdLst)
{
string strKey = string.Format("{0}", clsFR_CodeSymbolEN._CurrTabName);
List<clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLstCache = GetObjLstCache();
IEnumerable <clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLst_Sel =
arrFR_CodeSymbolObjLstCache
.Where(x => arrSymbolIdLst.Contains(x.SymbolId));
return arrFR_CodeSymbolObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetObjLst(string strWhereCond)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
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
public static List<clsFR_CodeSymbolEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFR_CodeSymbolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFR_CodeSymbolEN> GetSubObjLstCache(clsFR_CodeSymbolEN objFR_CodeSymbolCond)
{
List<clsFR_CodeSymbolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_CodeSymbolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_CodeSymbol._AttributeName)
{
if (objFR_CodeSymbolCond.IsUpdated(strFldName) == false) continue;
if (objFR_CodeSymbolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_CodeSymbolCond[strFldName].ToString());
}
else
{
if (objFR_CodeSymbolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_CodeSymbolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_CodeSymbolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_CodeSymbolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_CodeSymbolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_CodeSymbolCond[strFldName]));
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
public static List<clsFR_CodeSymbolEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
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
public static List<clsFR_CodeSymbolEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
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
List<clsFR_CodeSymbolEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFR_CodeSymbolEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFR_CodeSymbolEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
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
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
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
public static List<clsFR_CodeSymbolEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFR_CodeSymbolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
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
public static List<clsFR_CodeSymbolEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_CodeSymbolEN.SymbolId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFR_CodeSymbol(ref clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
bool bolResult = FR_CodeSymbolDA.GetFR_CodeSymbol(ref objFR_CodeSymbolEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSymbolId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_CodeSymbolEN GetObjBySymbolId(long lngSymbolId)
{
clsFR_CodeSymbolEN objFR_CodeSymbolEN = FR_CodeSymbolDA.GetObjBySymbolId(lngSymbolId);
return objFR_CodeSymbolEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFR_CodeSymbolEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFR_CodeSymbolEN objFR_CodeSymbolEN = FR_CodeSymbolDA.GetFirstObj(strWhereCond);
 return objFR_CodeSymbolEN;
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
public static clsFR_CodeSymbolEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFR_CodeSymbolEN objFR_CodeSymbolEN = FR_CodeSymbolDA.GetObjByDataRow(objRow);
 return objFR_CodeSymbolEN;
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
public static clsFR_CodeSymbolEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFR_CodeSymbolEN objFR_CodeSymbolEN = FR_CodeSymbolDA.GetObjByDataRow(objRow);
 return objFR_CodeSymbolEN;
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
 /// <param name = "lngSymbolId">所给的关键字</param>
 /// <param name = "lstFR_CodeSymbolObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_CodeSymbolEN GetObjBySymbolIdFromList(long lngSymbolId, List<clsFR_CodeSymbolEN> lstFR_CodeSymbolObjLst)
{
foreach (clsFR_CodeSymbolEN objFR_CodeSymbolEN in lstFR_CodeSymbolObjLst)
{
if (objFR_CodeSymbolEN.SymbolId == lngSymbolId)
{
return objFR_CodeSymbolEN;
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
 long lngSymbolId;
 try
 {
 lngSymbolId = new clsFR_CodeSymbolDA().GetFirstID(strWhereCond);
 return lngSymbolId;
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
 arrList = FR_CodeSymbolDA.GetID(strWhereCond);
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
bool bolIsExist = FR_CodeSymbolDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSymbolId)
{
//检测记录是否存在
bool bolIsExist = FR_CodeSymbolDA.IsExist(lngSymbolId);
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
 bolIsExist = clsFR_CodeSymbolDA.IsExistTable();
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
 bolIsExist = FR_CodeSymbolDA.IsExistTable(strTabName);
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFR_CodeSymbolEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!文件资源Id = [{0}],符号名称 = [{1}],符号类型 = [{2}]的数据已经存在!(in clsFR_CodeSymbolBL.AddNewRecordBySql2)", objFR_CodeSymbolEN.FileResourceId,objFR_CodeSymbolEN.SymbolName,objFR_CodeSymbolEN.SymbolType);
throw new Exception(strMsg);
}
try
{
bool bolResult = FR_CodeSymbolDA.AddNewRecordBySQL2(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFR_CodeSymbolEN objFR_CodeSymbolEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFR_CodeSymbolEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!文件资源Id = [{0}],符号名称 = [{1}],符号类型 = [{2}]的数据已经存在!(in clsFR_CodeSymbolBL.AddNewRecordBySql2WithReturnKey)", objFR_CodeSymbolEN.FileResourceId,objFR_CodeSymbolEN.SymbolName,objFR_CodeSymbolEN.SymbolType);
throw new Exception(strMsg);
}
try
{
string strKey = FR_CodeSymbolDA.AddNewRecordBySQL2WithReturnKey(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
try
{
bool bolResult = FR_CodeSymbolDA.Update(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN.SymbolId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FR_CodeSymbolDA.UpdateBySql2(objFR_CodeSymbolEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_CodeSymbolBL.ReFreshCache();

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
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
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngSymbolId)
{
try
{
 clsFR_CodeSymbolEN objFR_CodeSymbolEN = clsFR_CodeSymbolBL.GetObjBySymbolId(lngSymbolId);

if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(objFR_CodeSymbolEN.SymbolId, "SetUpdDate");
}
if (objFR_CodeSymbolEN != null)
{
int intRecNum = FR_CodeSymbolDA.DelRecord(lngSymbolId);
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
/// <param name="lngSymbolId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngSymbolId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
//删除与表:[FR_CodeSymbol]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFR_CodeSymbol.SymbolId,
//lngSymbolId);
//        clsFR_CodeSymbolBL.DelFR_CodeSymbolsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_CodeSymbolBL.DelRecord(lngSymbolId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_CodeSymbolBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSymbolId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngSymbolId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFR_CodeSymbolBL.relatedActions != null)
{
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(lngSymbolId, "UpdRelaTabDate");
}
bool bolResult = FR_CodeSymbolDA.DelRecord(lngSymbolId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSymbolIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFR_CodeSymbols(List<string> arrSymbolIdLst)
{
if (arrSymbolIdLst.Count == 0) return 0;
try
{
if (clsFR_CodeSymbolBL.relatedActions != null)
{
foreach (var strSymbolId in arrSymbolIdLst)
{
long lngSymbolId = long.Parse(strSymbolId);
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(lngSymbolId, "UpdRelaTabDate");
}
}
int intDelRecNum = FR_CodeSymbolDA.DelFR_CodeSymbol(arrSymbolIdLst);
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
public static int DelFR_CodeSymbolsByCond(string strWhereCond)
{
try
{
if (clsFR_CodeSymbolBL.relatedActions != null)
{
List<string> arrSymbolId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSymbolId in arrSymbolId)
{
long lngSymbolId = long.Parse(strSymbolId);
clsFR_CodeSymbolBL.relatedActions.UpdRelaTabDate(lngSymbolId, "UpdRelaTabDate");
}
}
int intRecNum = FR_CodeSymbolDA.DelFR_CodeSymbol(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FR_CodeSymbol]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSymbolId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSymbolId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
//删除与表:[FR_CodeSymbol]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_CodeSymbolBL.DelRecord(lngSymbolId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_CodeSymbolBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSymbolId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <param name = "objFR_CodeSymbolENT">目标对象</param>
 public static void CopyTo(clsFR_CodeSymbolEN objFR_CodeSymbolENS, clsFR_CodeSymbolEN objFR_CodeSymbolENT)
{
try
{
objFR_CodeSymbolENT.SymbolId = objFR_CodeSymbolENS.SymbolId; //符号Id
objFR_CodeSymbolENT.FileResourceId = objFR_CodeSymbolENS.FileResourceId; //文件资源Id
objFR_CodeSymbolENT.SymbolName = objFR_CodeSymbolENS.SymbolName; //符号名称
objFR_CodeSymbolENT.SymbolType = objFR_CodeSymbolENS.SymbolType; //符号类型
objFR_CodeSymbolENT.SymbolExportType = objFR_CodeSymbolENS.SymbolExportType; //符号导出类型
objFR_CodeSymbolENT.IsExported = objFR_CodeSymbolENS.IsExported; //是否导出
objFR_CodeSymbolENT.LineStart = objFR_CodeSymbolENS.LineStart; //开始行
objFR_CodeSymbolENT.LineEnd = objFR_CodeSymbolENS.LineEnd; //结束行
objFR_CodeSymbolENT.ColumnStart = objFR_CodeSymbolENS.ColumnStart; //开始列
objFR_CodeSymbolENT.ColumnEnd = objFR_CodeSymbolENS.ColumnEnd; //结束列
objFR_CodeSymbolENT.Signature = objFR_CodeSymbolENS.Signature; //函数签名
objFR_CodeSymbolENT.DocComment = objFR_CodeSymbolENS.DocComment; //文档注释
objFR_CodeSymbolENT.CreatedAt = objFR_CodeSymbolENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_CodeSymbolEN">源简化对象</param>
 public static void SetUpdFlag(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
try
{
objFR_CodeSymbolEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFR_CodeSymbolEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFR_CodeSymbol.SymbolId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.SymbolId = objFR_CodeSymbolEN.SymbolId; //符号Id
}
if (arrFldSet.Contains(conFR_CodeSymbol.FileResourceId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.FileResourceId = objFR_CodeSymbolEN.FileResourceId; //文件资源Id
}
if (arrFldSet.Contains(conFR_CodeSymbol.SymbolName, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.SymbolName = objFR_CodeSymbolEN.SymbolName; //符号名称
}
if (arrFldSet.Contains(conFR_CodeSymbol.SymbolType, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.SymbolType = objFR_CodeSymbolEN.SymbolType; //符号类型
}
if (arrFldSet.Contains(conFR_CodeSymbol.SymbolExportType, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.SymbolExportType = objFR_CodeSymbolEN.SymbolExportType == "[null]" ? null :  objFR_CodeSymbolEN.SymbolExportType; //符号导出类型
}
if (arrFldSet.Contains(conFR_CodeSymbol.IsExported, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.IsExported = objFR_CodeSymbolEN.IsExported; //是否导出
}
if (arrFldSet.Contains(conFR_CodeSymbol.LineStart, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.LineStart = objFR_CodeSymbolEN.LineStart; //开始行
}
if (arrFldSet.Contains(conFR_CodeSymbol.LineEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.LineEnd = objFR_CodeSymbolEN.LineEnd; //结束行
}
if (arrFldSet.Contains(conFR_CodeSymbol.ColumnStart, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.ColumnStart = objFR_CodeSymbolEN.ColumnStart; //开始列
}
if (arrFldSet.Contains(conFR_CodeSymbol.ColumnEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.ColumnEnd = objFR_CodeSymbolEN.ColumnEnd; //结束列
}
if (arrFldSet.Contains(conFR_CodeSymbol.Signature, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.Signature = objFR_CodeSymbolEN.Signature == "[null]" ? null :  objFR_CodeSymbolEN.Signature; //函数签名
}
if (arrFldSet.Contains(conFR_CodeSymbol.DocComment, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.DocComment = objFR_CodeSymbolEN.DocComment == "[null]" ? null :  objFR_CodeSymbolEN.DocComment; //文档注释
}
if (arrFldSet.Contains(conFR_CodeSymbol.CreatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_CodeSymbolEN.CreatedAt = objFR_CodeSymbolEN.CreatedAt; //建立时间
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
 /// <param name = "objFR_CodeSymbolEN">源简化对象</param>
 public static void AccessFldValueNull(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
try
{
if (objFR_CodeSymbolEN.SymbolExportType == "[null]") objFR_CodeSymbolEN.SymbolExportType = null; //符号导出类型
if (objFR_CodeSymbolEN.Signature == "[null]") objFR_CodeSymbolEN.Signature = null; //函数签名
if (objFR_CodeSymbolEN.DocComment == "[null]") objFR_CodeSymbolEN.DocComment = null; //文档注释
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
public static void CheckPropertyNew(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 FR_CodeSymbolDA.CheckPropertyNew(objFR_CodeSymbolEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 FR_CodeSymbolDA.CheckProperty4Condition(objFR_CodeSymbolEN);
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
if (clsFR_CodeSymbolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFR_CodeSymbolBL没有刷新缓存机制(clsFR_CodeSymbolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SymbolId");
//if (arrFR_CodeSymbolObjLstCache == null)
//{
//arrFR_CodeSymbolObjLstCache = FR_CodeSymbolDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSymbolId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_CodeSymbolEN GetObjBySymbolIdCache(long lngSymbolId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFR_CodeSymbolEN._CurrTabName);
List<clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLstCache = GetObjLstCache();
IEnumerable <clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLst_Sel =
arrFR_CodeSymbolObjLstCache
.Where(x=> x.SymbolId == lngSymbolId 
);
if (arrFR_CodeSymbolObjLst_Sel.Count() == 0)
{
   clsFR_CodeSymbolEN obj = clsFR_CodeSymbolBL.GetObjBySymbolId(lngSymbolId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFR_CodeSymbolObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetAllFR_CodeSymbolObjLstCache()
{
//获取缓存中的对象列表
List<clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLstCache = GetObjLstCache(); 
return arrFR_CodeSymbolObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_CodeSymbolEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFR_CodeSymbolEN._CurrTabName);
List<clsFR_CodeSymbolEN> arrFR_CodeSymbolObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFR_CodeSymbolObjLstCache;
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
string strKey = string.Format("{0}", clsFR_CodeSymbolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_CodeSymbolEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFR_CodeSymbolEN._RefreshTimeLst.Count == 0) return "";
return clsFR_CodeSymbolEN._RefreshTimeLst[clsFR_CodeSymbolEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFR_CodeSymbolBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFR_CodeSymbolEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_CodeSymbolEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFR_CodeSymbolBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FR_CodeSymbol(FR_CodeSymbol)
 /// 唯一性条件:FileResourceId_SymbolName_SymbolType
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检测记录是否存在
string strResult = FR_CodeSymbolDA.GetUniCondStr(objFR_CodeSymbolEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-07-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngSymbolId)
{
if (strInFldName != conFR_CodeSymbol.SymbolId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFR_CodeSymbol._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFR_CodeSymbol._AttributeName));
throw new Exception(strMsg);
}
var objFR_CodeSymbol = clsFR_CodeSymbolBL.GetObjBySymbolIdCache(lngSymbolId);
if (objFR_CodeSymbol == null) return "";
return objFR_CodeSymbol[strOutFldName].ToString();
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
int intRecCount = clsFR_CodeSymbolDA.GetRecCount(strTabName);
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
int intRecCount = clsFR_CodeSymbolDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFR_CodeSymbolDA.GetRecCount();
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
int intRecCount = clsFR_CodeSymbolDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFR_CodeSymbolCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFR_CodeSymbolEN objFR_CodeSymbolCond)
{
List<clsFR_CodeSymbolEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_CodeSymbolEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_CodeSymbol._AttributeName)
{
if (objFR_CodeSymbolCond.IsUpdated(strFldName) == false) continue;
if (objFR_CodeSymbolCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_CodeSymbolCond[strFldName].ToString());
}
else
{
if (objFR_CodeSymbolCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_CodeSymbolCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_CodeSymbolCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_CodeSymbolCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_CodeSymbolCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_CodeSymbolCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_CodeSymbolCond[strFldName]));
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
 List<string> arrList = clsFR_CodeSymbolDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FR_CodeSymbolDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FR_CodeSymbolDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FR_CodeSymbolDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_CodeSymbolDA.SetFldValue(clsFR_CodeSymbolEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FR_CodeSymbolDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_CodeSymbolDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_CodeSymbolDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_CodeSymbolDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FR_CodeSymbol] "); 
 strCreateTabCode.Append(" ( "); 
 // /**符号Id*/ 
 strCreateTabCode.Append(" SymbolId bigint primary key identity, "); 
 // /**文件资源Id*/ 
 strCreateTabCode.Append(" FileResourceId bigint not Null, "); 
 // /**符号名称*/ 
 strCreateTabCode.Append(" SymbolName varchar(100) not Null, "); 
 // /**符号类型*/ 
 strCreateTabCode.Append(" SymbolType varchar(100) not Null, "); 
 // /**符号导出类型*/ 
 strCreateTabCode.Append(" SymbolExportType varchar(100) Null, "); 
 // /**是否导出*/ 
 strCreateTabCode.Append(" IsExported bit Null, "); 
 // /**开始行*/ 
 strCreateTabCode.Append(" LineStart int Null, "); 
 // /**结束行*/ 
 strCreateTabCode.Append(" LineEnd int Null, "); 
 // /**开始列*/ 
 strCreateTabCode.Append(" ColumnStart int Null, "); 
 // /**结束列*/ 
 strCreateTabCode.Append(" ColumnEnd int Null, "); 
 // /**函数签名*/ 
 strCreateTabCode.Append(" Signature varchar(200) Null, "); 
 // /**文档注释*/ 
 strCreateTabCode.Append(" DocComment varchar(500) Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreatedAt datetime Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FR_CodeSymbol : clsCommFun4BL
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
clsFR_CodeSymbolBL.ReFreshThisCache();
}
}

}