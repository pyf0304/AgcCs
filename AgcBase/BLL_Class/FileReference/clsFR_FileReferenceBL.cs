
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_FileReferenceBL
 表名:FR_FileReference(00050658)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/23 22:47:46
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
public static class  clsFR_FileReferenceBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_FileReferenceEN GetObj(this K_mId_FR_FileReference myKey)
{
clsFR_FileReferenceEN objFR_FileReferenceEN = clsFR_FileReferenceBL.FR_FileReferenceDA.GetObjBymId(myKey.Value);
return objFR_FileReferenceEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFR_FileReferenceEN objFR_FileReferenceEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
bool bolResult = clsFR_FileReferenceBL.FR_FileReferenceDA.AddNewRecordBySQL2(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsFR_FileReferenceEN objFR_FileReferenceEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsFR_FileReferenceBL.IsExist(objFR_FileReferenceEN.mId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objFR_FileReferenceEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objFR_FileReferenceEN.AddNewRecord();
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFR_FileReferenceEN objFR_FileReferenceEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
string strKey = clsFR_FileReferenceBL.FR_FileReferenceDA.AddNewRecordBySQL2WithReturnKey(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetmId(this clsFR_FileReferenceEN objFR_FileReferenceEN, long lngmId, string strComparisonOp="")
	{
objFR_FileReferenceEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.mId) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.mId, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.mId] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetSourceFileId(this clsFR_FileReferenceEN objFR_FileReferenceEN, long lngSourceFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSourceFileId, conFR_FileReference.SourceFileId);
objFR_FileReferenceEN.SourceFileId = lngSourceFileId; //源文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.SourceFileId) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.SourceFileId, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.SourceFileId] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetTargetFileId(this clsFR_FileReferenceEN objFR_FileReferenceEN, long lngTargetFileId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngTargetFileId, conFR_FileReference.TargetFileId);
objFR_FileReferenceEN.TargetFileId = lngTargetFileId; //目标文件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.TargetFileId) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.TargetFileId, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.TargetFileId] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetSourceSymbolId(this clsFR_FileReferenceEN objFR_FileReferenceEN, long? lngSourceSymbolId, string strComparisonOp="")
	{
objFR_FileReferenceEN.SourceSymbolId = lngSourceSymbolId; //源符号Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.SourceSymbolId) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.SourceSymbolId, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.SourceSymbolId] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetTargetSymbolId(this clsFR_FileReferenceEN objFR_FileReferenceEN, long? lngTargetSymbolId, string strComparisonOp="")
	{
objFR_FileReferenceEN.TargetSymbolId = lngTargetSymbolId; //目标符号Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.TargetSymbolId) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.TargetSymbolId, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.TargetSymbolId] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetRefType(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strRefType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRefType, conFR_FileReference.RefType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRefType, 50, conFR_FileReference.RefType);
}
objFR_FileReferenceEN.RefType = strRefType; //引用类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.RefType) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.RefType, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.RefType] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetRefName(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strRefName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRefName, conFR_FileReference.RefName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRefName, 100, conFR_FileReference.RefName);
}
objFR_FileReferenceEN.RefName = strRefName; //引用名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.RefName) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.RefName, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.RefName] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetRefAlias(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strRefAlias, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRefAlias, 100, conFR_FileReference.RefAlias);
}
objFR_FileReferenceEN.RefAlias = strRefAlias; //别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.RefAlias) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.RefAlias, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.RefAlias] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetLineStart(this clsFR_FileReferenceEN objFR_FileReferenceEN, int? intLineStart, string strComparisonOp="")
	{
objFR_FileReferenceEN.LineStart = intLineStart; //开始行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.LineStart) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.LineStart, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.LineStart] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetLineEnd(this clsFR_FileReferenceEN objFR_FileReferenceEN, int? intLineEnd, string strComparisonOp="")
	{
objFR_FileReferenceEN.LineEnd = intLineEnd; //结束行
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.LineEnd) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.LineEnd, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.LineEnd] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetColumnStart(this clsFR_FileReferenceEN objFR_FileReferenceEN, int? intColumnStart, string strComparisonOp="")
	{
objFR_FileReferenceEN.ColumnStart = intColumnStart; //开始列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.ColumnStart) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.ColumnStart, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.ColumnStart] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetColumnEnd(this clsFR_FileReferenceEN objFR_FileReferenceEN, int? intColumnEnd, string strComparisonOp="")
	{
objFR_FileReferenceEN.ColumnEnd = intColumnEnd; //结束列
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.ColumnEnd) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.ColumnEnd, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.ColumnEnd] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetRefStatement(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strRefStatement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRefStatement, 500, conFR_FileReference.RefStatement);
}
objFR_FileReferenceEN.RefStatement = strRefStatement; //原始引用语句
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.RefStatement) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.RefStatement, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.RefStatement] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFR_FileReferenceEN SetCreatedAt(this clsFR_FileReferenceEN objFR_FileReferenceEN, DateTime dteCreatedAt, string strComparisonOp="")
	{
objFR_FileReferenceEN.CreatedAt = dteCreatedAt; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFR_FileReferenceEN.dicFldComparisonOp.ContainsKey(conFR_FileReference.CreatedAt) == false)
{
objFR_FileReferenceEN.dicFldComparisonOp.Add(conFR_FileReference.CreatedAt, strComparisonOp);
}
else
{
objFR_FileReferenceEN.dicFldComparisonOp[conFR_FileReference.CreatedAt] = strComparisonOp;
}
}
return objFR_FileReferenceEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFR_FileReferenceEN objFR_FileReferenceEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFR_FileReferenceEN.CheckPropertyNew();
clsFR_FileReferenceEN objFR_FileReferenceCond = new clsFR_FileReferenceEN();
string strCondition = objFR_FileReferenceCond
.SetmId(objFR_FileReferenceEN.mId, "=")
.GetCombineCondition();
objFR_FileReferenceEN._IsCheckProperty = true;
bool bolIsExist = clsFR_FileReferenceBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFR_FileReferenceEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_FileReferenceBL.FR_FileReferenceDA.UpdateBySql2(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFR_FileReferenceEN objFR_FileReferenceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_FileReferenceEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFR_FileReferenceBL.FR_FileReferenceDA.UpdateBySql2(objFR_FileReferenceEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strWhereCond)
{
try
{
bool bolResult = clsFR_FileReferenceBL.FR_FileReferenceDA.UpdateBySqlWithCondition(objFR_FileReferenceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFR_FileReferenceEN objFR_FileReferenceEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFR_FileReferenceBL.FR_FileReferenceDA.UpdateBySqlWithConditionTransaction(objFR_FileReferenceEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
public static int Delete(this clsFR_FileReferenceEN objFR_FileReferenceEN)
{
try
{
int intRecNum = clsFR_FileReferenceBL.FR_FileReferenceDA.DelRecord(objFR_FileReferenceEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceENS">源对象</param>
 /// <param name = "objFR_FileReferenceENT">目标对象</param>
 public static void CopyTo(this clsFR_FileReferenceEN objFR_FileReferenceENS, clsFR_FileReferenceEN objFR_FileReferenceENT)
{
try
{
objFR_FileReferenceENT.mId = objFR_FileReferenceENS.mId; //mId
objFR_FileReferenceENT.SourceFileId = objFR_FileReferenceENS.SourceFileId; //源文件Id
objFR_FileReferenceENT.TargetFileId = objFR_FileReferenceENS.TargetFileId; //目标文件Id
objFR_FileReferenceENT.SourceSymbolId = objFR_FileReferenceENS.SourceSymbolId; //源符号Id
objFR_FileReferenceENT.TargetSymbolId = objFR_FileReferenceENS.TargetSymbolId; //目标符号Id
objFR_FileReferenceENT.RefType = objFR_FileReferenceENS.RefType; //引用类型
objFR_FileReferenceENT.RefName = objFR_FileReferenceENS.RefName; //引用名
objFR_FileReferenceENT.RefAlias = objFR_FileReferenceENS.RefAlias; //别名
objFR_FileReferenceENT.LineStart = objFR_FileReferenceENS.LineStart; //开始行
objFR_FileReferenceENT.LineEnd = objFR_FileReferenceENS.LineEnd; //结束行
objFR_FileReferenceENT.ColumnStart = objFR_FileReferenceENS.ColumnStart; //开始列
objFR_FileReferenceENT.ColumnEnd = objFR_FileReferenceENS.ColumnEnd; //结束列
objFR_FileReferenceENT.RefStatement = objFR_FileReferenceENS.RefStatement; //原始引用语句
objFR_FileReferenceENT.CreatedAt = objFR_FileReferenceENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_FileReferenceENS">源对象</param>
 /// <returns>目标对象=>clsFR_FileReferenceEN:objFR_FileReferenceENT</returns>
 public static clsFR_FileReferenceEN CopyTo(this clsFR_FileReferenceEN objFR_FileReferenceENS)
{
try
{
 clsFR_FileReferenceEN objFR_FileReferenceENT = new clsFR_FileReferenceEN()
{
mId = objFR_FileReferenceENS.mId, //mId
SourceFileId = objFR_FileReferenceENS.SourceFileId, //源文件Id
TargetFileId = objFR_FileReferenceENS.TargetFileId, //目标文件Id
SourceSymbolId = objFR_FileReferenceENS.SourceSymbolId, //源符号Id
TargetSymbolId = objFR_FileReferenceENS.TargetSymbolId, //目标符号Id
RefType = objFR_FileReferenceENS.RefType, //引用类型
RefName = objFR_FileReferenceENS.RefName, //引用名
RefAlias = objFR_FileReferenceENS.RefAlias, //别名
LineStart = objFR_FileReferenceENS.LineStart, //开始行
LineEnd = objFR_FileReferenceENS.LineEnd, //结束行
ColumnStart = objFR_FileReferenceENS.ColumnStart, //开始列
ColumnEnd = objFR_FileReferenceENS.ColumnEnd, //结束列
RefStatement = objFR_FileReferenceENS.RefStatement, //原始引用语句
CreatedAt = objFR_FileReferenceENS.CreatedAt, //建立时间
};
 return objFR_FileReferenceENT;
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
public static void CheckPropertyNew(this clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 clsFR_FileReferenceBL.FR_FileReferenceDA.CheckPropertyNew(objFR_FileReferenceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 clsFR_FileReferenceBL.FR_FileReferenceDA.CheckProperty4Condition(objFR_FileReferenceEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFR_FileReferenceEN objFR_FileReferenceCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.mId) == true)
{
string strComparisonOpmId = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.mId, objFR_FileReferenceCond.mId, strComparisonOpmId);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.SourceFileId) == true)
{
string strComparisonOpSourceFileId = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.SourceFileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.SourceFileId, objFR_FileReferenceCond.SourceFileId, strComparisonOpSourceFileId);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.TargetFileId) == true)
{
string strComparisonOpTargetFileId = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.TargetFileId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.TargetFileId, objFR_FileReferenceCond.TargetFileId, strComparisonOpTargetFileId);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.SourceSymbolId) == true)
{
string strComparisonOpSourceSymbolId = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.SourceSymbolId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.SourceSymbolId, objFR_FileReferenceCond.SourceSymbolId, strComparisonOpSourceSymbolId);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.TargetSymbolId) == true)
{
string strComparisonOpTargetSymbolId = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.TargetSymbolId];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.TargetSymbolId, objFR_FileReferenceCond.TargetSymbolId, strComparisonOpTargetSymbolId);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.RefType) == true)
{
string strComparisonOpRefType = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.RefType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_FileReference.RefType, objFR_FileReferenceCond.RefType, strComparisonOpRefType);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.RefName) == true)
{
string strComparisonOpRefName = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.RefName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_FileReference.RefName, objFR_FileReferenceCond.RefName, strComparisonOpRefName);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.RefAlias) == true)
{
string strComparisonOpRefAlias = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.RefAlias];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_FileReference.RefAlias, objFR_FileReferenceCond.RefAlias, strComparisonOpRefAlias);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.LineStart) == true)
{
string strComparisonOpLineStart = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.LineStart];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.LineStart, objFR_FileReferenceCond.LineStart, strComparisonOpLineStart);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.LineEnd) == true)
{
string strComparisonOpLineEnd = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.LineEnd];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.LineEnd, objFR_FileReferenceCond.LineEnd, strComparisonOpLineEnd);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.ColumnStart) == true)
{
string strComparisonOpColumnStart = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.ColumnStart];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.ColumnStart, objFR_FileReferenceCond.ColumnStart, strComparisonOpColumnStart);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.ColumnEnd) == true)
{
string strComparisonOpColumnEnd = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.ColumnEnd];
strWhereCond += string.Format(" And {0} {2} {1}", conFR_FileReference.ColumnEnd, objFR_FileReferenceCond.ColumnEnd, strComparisonOpColumnEnd);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.RefStatement) == true)
{
string strComparisonOpRefStatement = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.RefStatement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_FileReference.RefStatement, objFR_FileReferenceCond.RefStatement, strComparisonOpRefStatement);
}
if (objFR_FileReferenceCond.IsUpdated(conFR_FileReference.CreatedAt) == true)
{
string strComparisonOpCreatedAt = objFR_FileReferenceCond.dicFldComparisonOp[conFR_FileReference.CreatedAt];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFR_FileReference.CreatedAt, objFR_FileReferenceCond.CreatedAt, strComparisonOpCreatedAt);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FR_FileReference
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// FR_FileReference(FR_FileReference)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFR_FileReferenceBL
{
public static RelatedActions_FR_FileReference relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFR_FileReferenceDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFR_FileReferenceDA FR_FileReferenceDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFR_FileReferenceDA();
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
 public clsFR_FileReferenceBL()
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
if (string.IsNullOrEmpty(clsFR_FileReferenceEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFR_FileReferenceEN._ConnectString);
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
public static DataTable GetDataTable_FR_FileReference(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FR_FileReferenceDA.GetDataTable_FR_FileReference(strWhereCond);
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
objDT = FR_FileReferenceDA.GetDataTable(strWhereCond);
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
objDT = FR_FileReferenceDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FR_FileReferenceDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FR_FileReferenceDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FR_FileReferenceDA.GetDataTable_Top(objTopPara);
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
objDT = FR_FileReferenceDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FR_FileReferenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FR_FileReferenceDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFR_FileReferenceEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
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
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFR_FileReferenceEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFR_FileReferenceEN._CurrTabName);
List<clsFR_FileReferenceEN> arrFR_FileReferenceObjLstCache = GetObjLstCache();
IEnumerable <clsFR_FileReferenceEN> arrFR_FileReferenceObjLst_Sel =
arrFR_FileReferenceObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFR_FileReferenceObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_FileReferenceEN> GetObjLst(string strWhereCond)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
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
public static List<clsFR_FileReferenceEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFR_FileReferenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFR_FileReferenceEN> GetSubObjLstCache(clsFR_FileReferenceEN objFR_FileReferenceCond)
{
List<clsFR_FileReferenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_FileReferenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_FileReference._AttributeName)
{
if (objFR_FileReferenceCond.IsUpdated(strFldName) == false) continue;
if (objFR_FileReferenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_FileReferenceCond[strFldName].ToString());
}
else
{
if (objFR_FileReferenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_FileReferenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_FileReferenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_FileReferenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_FileReferenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_FileReferenceCond[strFldName]));
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
public static List<clsFR_FileReferenceEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
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
public static List<clsFR_FileReferenceEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
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
List<clsFR_FileReferenceEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFR_FileReferenceEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_FileReferenceEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFR_FileReferenceEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
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
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
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
public static List<clsFR_FileReferenceEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFR_FileReferenceEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFR_FileReferenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
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
public static List<clsFR_FileReferenceEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFR_FileReferenceEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFR_FileReferenceEN> arrObjLst = new List<clsFR_FileReferenceEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_FileReferenceEN objFR_FileReferenceEN = new clsFR_FileReferenceEN();
try
{
objFR_FileReferenceEN.mId = Int32.Parse(objRow[conFR_FileReference.mId].ToString().Trim()); //mId
objFR_FileReferenceEN.SourceFileId = Int32.Parse(objRow[conFR_FileReference.SourceFileId].ToString().Trim()); //源文件Id
objFR_FileReferenceEN.TargetFileId = Int32.Parse(objRow[conFR_FileReference.TargetFileId].ToString().Trim()); //目标文件Id
objFR_FileReferenceEN.SourceSymbolId = objRow[conFR_FileReference.SourceSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.SourceSymbolId].ToString().Trim()); //源符号Id
objFR_FileReferenceEN.TargetSymbolId = objRow[conFR_FileReference.TargetSymbolId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.TargetSymbolId].ToString().Trim()); //目标符号Id
objFR_FileReferenceEN.RefType = objRow[conFR_FileReference.RefType].ToString().Trim(); //引用类型
objFR_FileReferenceEN.RefName = objRow[conFR_FileReference.RefName].ToString().Trim(); //引用名
objFR_FileReferenceEN.RefAlias = objRow[conFR_FileReference.RefAlias] == DBNull.Value ? null : objRow[conFR_FileReference.RefAlias].ToString().Trim(); //别名
objFR_FileReferenceEN.LineStart = objRow[conFR_FileReference.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineStart].ToString().Trim()); //开始行
objFR_FileReferenceEN.LineEnd = objRow[conFR_FileReference.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.LineEnd].ToString().Trim()); //结束行
objFR_FileReferenceEN.ColumnStart = objRow[conFR_FileReference.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnStart].ToString().Trim()); //开始列
objFR_FileReferenceEN.ColumnEnd = objRow[conFR_FileReference.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_FileReference.ColumnEnd].ToString().Trim()); //结束列
objFR_FileReferenceEN.RefStatement = objRow[conFR_FileReference.RefStatement] == DBNull.Value ? null : objRow[conFR_FileReference.RefStatement].ToString().Trim(); //原始引用语句
objFR_FileReferenceEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_FileReference.CreatedAt].ToString().Trim()); //建立时间
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFR_FileReferenceEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFR_FileReferenceEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFR_FileReferenceEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFR_FileReference(ref clsFR_FileReferenceEN objFR_FileReferenceEN)
{
bool bolResult = FR_FileReferenceDA.GetFR_FileReference(ref objFR_FileReferenceEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFR_FileReferenceEN GetObjBymId(long lngmId)
{
clsFR_FileReferenceEN objFR_FileReferenceEN = FR_FileReferenceDA.GetObjBymId(lngmId);
return objFR_FileReferenceEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFR_FileReferenceEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFR_FileReferenceEN objFR_FileReferenceEN = FR_FileReferenceDA.GetFirstObj(strWhereCond);
 return objFR_FileReferenceEN;
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
public static clsFR_FileReferenceEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFR_FileReferenceEN objFR_FileReferenceEN = FR_FileReferenceDA.GetObjByDataRow(objRow);
 return objFR_FileReferenceEN;
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
public static clsFR_FileReferenceEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFR_FileReferenceEN objFR_FileReferenceEN = FR_FileReferenceDA.GetObjByDataRow(objRow);
 return objFR_FileReferenceEN;
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
 /// <param name = "lstFR_FileReferenceObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_FileReferenceEN GetObjBymIdFromList(long lngmId, List<clsFR_FileReferenceEN> lstFR_FileReferenceObjLst)
{
foreach (clsFR_FileReferenceEN objFR_FileReferenceEN in lstFR_FileReferenceObjLst)
{
if (objFR_FileReferenceEN.mId == lngmId)
{
return objFR_FileReferenceEN;
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
 lngmId = new clsFR_FileReferenceDA().GetFirstID(strWhereCond);
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
 arrList = FR_FileReferenceDA.GetID(strWhereCond);
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
bool bolIsExist = FR_FileReferenceDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FR_FileReferenceDA.IsExist(lngmId);
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
 bolIsExist = clsFR_FileReferenceDA.IsExistTable();
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
 bolIsExist = FR_FileReferenceDA.IsExistTable(strTabName);
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFR_FileReferenceEN objFR_FileReferenceEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
bool bolResult = FR_FileReferenceDA.AddNewRecordBySQL2(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFR_FileReferenceEN objFR_FileReferenceEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
string strKey = FR_FileReferenceDA.AddNewRecordBySQL2WithReturnKey(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
try
{
bool bolResult = FR_FileReferenceDA.Update(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 /// <param name = "objFR_FileReferenceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 if (objFR_FileReferenceEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FR_FileReferenceDA.UpdateBySql2(objFR_FileReferenceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFR_FileReferenceBL.ReFreshCache();

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
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
 clsFR_FileReferenceEN objFR_FileReferenceEN = clsFR_FileReferenceBL.GetObjBymId(lngmId);

if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(objFR_FileReferenceEN.mId, "SetUpdDate");
}
if (objFR_FileReferenceEN != null)
{
int intRecNum = FR_FileReferenceDA.DelRecord(lngmId);
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
objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
//删除与表:[FR_FileReference]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFR_FileReference.mId,
//lngmId);
//        clsFR_FileReferenceBL.DelFR_FileReferencesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_FileReferenceBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_FileReferenceBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFR_FileReferenceBL.relatedActions != null)
{
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FR_FileReferenceDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFR_FileReferences(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFR_FileReferenceBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FR_FileReferenceDA.DelFR_FileReference(arrmIdLst);
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
public static int DelFR_FileReferencesByCond(string strWhereCond)
{
try
{
if (clsFR_FileReferenceBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFR_FileReferenceBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FR_FileReferenceDA.DelFR_FileReference(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FR_FileReference]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFR_FileReferenceDA.GetSpecSQLObj();
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
//删除与表:[FR_FileReference]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFR_FileReferenceBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFR_FileReferenceBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFR_FileReferenceENS">源对象</param>
 /// <param name = "objFR_FileReferenceENT">目标对象</param>
 public static void CopyTo(clsFR_FileReferenceEN objFR_FileReferenceENS, clsFR_FileReferenceEN objFR_FileReferenceENT)
{
try
{
objFR_FileReferenceENT.mId = objFR_FileReferenceENS.mId; //mId
objFR_FileReferenceENT.SourceFileId = objFR_FileReferenceENS.SourceFileId; //源文件Id
objFR_FileReferenceENT.TargetFileId = objFR_FileReferenceENS.TargetFileId; //目标文件Id
objFR_FileReferenceENT.SourceSymbolId = objFR_FileReferenceENS.SourceSymbolId; //源符号Id
objFR_FileReferenceENT.TargetSymbolId = objFR_FileReferenceENS.TargetSymbolId; //目标符号Id
objFR_FileReferenceENT.RefType = objFR_FileReferenceENS.RefType; //引用类型
objFR_FileReferenceENT.RefName = objFR_FileReferenceENS.RefName; //引用名
objFR_FileReferenceENT.RefAlias = objFR_FileReferenceENS.RefAlias; //别名
objFR_FileReferenceENT.LineStart = objFR_FileReferenceENS.LineStart; //开始行
objFR_FileReferenceENT.LineEnd = objFR_FileReferenceENS.LineEnd; //结束行
objFR_FileReferenceENT.ColumnStart = objFR_FileReferenceENS.ColumnStart; //开始列
objFR_FileReferenceENT.ColumnEnd = objFR_FileReferenceENS.ColumnEnd; //结束列
objFR_FileReferenceENT.RefStatement = objFR_FileReferenceENS.RefStatement; //原始引用语句
objFR_FileReferenceENT.CreatedAt = objFR_FileReferenceENS.CreatedAt; //建立时间
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
 /// <param name = "objFR_FileReferenceEN">源简化对象</param>
 public static void SetUpdFlag(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
try
{
objFR_FileReferenceEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFR_FileReferenceEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFR_FileReference.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.mId = objFR_FileReferenceEN.mId; //mId
}
if (arrFldSet.Contains(conFR_FileReference.SourceFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.SourceFileId = objFR_FileReferenceEN.SourceFileId; //源文件Id
}
if (arrFldSet.Contains(conFR_FileReference.TargetFileId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.TargetFileId = objFR_FileReferenceEN.TargetFileId; //目标文件Id
}
if (arrFldSet.Contains(conFR_FileReference.SourceSymbolId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.SourceSymbolId = objFR_FileReferenceEN.SourceSymbolId; //源符号Id
}
if (arrFldSet.Contains(conFR_FileReference.TargetSymbolId, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.TargetSymbolId = objFR_FileReferenceEN.TargetSymbolId; //目标符号Id
}
if (arrFldSet.Contains(conFR_FileReference.RefType, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.RefType = objFR_FileReferenceEN.RefType; //引用类型
}
if (arrFldSet.Contains(conFR_FileReference.RefName, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.RefName = objFR_FileReferenceEN.RefName; //引用名
}
if (arrFldSet.Contains(conFR_FileReference.RefAlias, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.RefAlias = objFR_FileReferenceEN.RefAlias == "[null]" ? null :  objFR_FileReferenceEN.RefAlias; //别名
}
if (arrFldSet.Contains(conFR_FileReference.LineStart, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.LineStart = objFR_FileReferenceEN.LineStart; //开始行
}
if (arrFldSet.Contains(conFR_FileReference.LineEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.LineEnd = objFR_FileReferenceEN.LineEnd; //结束行
}
if (arrFldSet.Contains(conFR_FileReference.ColumnStart, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.ColumnStart = objFR_FileReferenceEN.ColumnStart; //开始列
}
if (arrFldSet.Contains(conFR_FileReference.ColumnEnd, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.ColumnEnd = objFR_FileReferenceEN.ColumnEnd; //结束列
}
if (arrFldSet.Contains(conFR_FileReference.RefStatement, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.RefStatement = objFR_FileReferenceEN.RefStatement == "[null]" ? null :  objFR_FileReferenceEN.RefStatement; //原始引用语句
}
if (arrFldSet.Contains(conFR_FileReference.CreatedAt, new clsStrCompareIgnoreCase())  ==  true)
{
objFR_FileReferenceEN.CreatedAt = objFR_FileReferenceEN.CreatedAt; //建立时间
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
 /// <param name = "objFR_FileReferenceEN">源简化对象</param>
 public static void AccessFldValueNull(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
try
{
if (objFR_FileReferenceEN.RefAlias == "[null]") objFR_FileReferenceEN.RefAlias = null; //别名
if (objFR_FileReferenceEN.RefStatement == "[null]") objFR_FileReferenceEN.RefStatement = null; //原始引用语句
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
public static void CheckPropertyNew(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 FR_FileReferenceDA.CheckPropertyNew(objFR_FileReferenceEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFR_FileReferenceEN objFR_FileReferenceEN)
{
 FR_FileReferenceDA.CheckProperty4Condition(objFR_FileReferenceEN);
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
if (clsFR_FileReferenceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFR_FileReferenceBL没有刷新缓存机制(clsFR_FileReferenceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFR_FileReferenceObjLstCache == null)
//{
//arrFR_FileReferenceObjLstCache = FR_FileReferenceDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFR_FileReferenceEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFR_FileReferenceEN._CurrTabName);
List<clsFR_FileReferenceEN> arrFR_FileReferenceObjLstCache = GetObjLstCache();
IEnumerable <clsFR_FileReferenceEN> arrFR_FileReferenceObjLst_Sel =
arrFR_FileReferenceObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFR_FileReferenceObjLst_Sel.Count() == 0)
{
   clsFR_FileReferenceEN obj = clsFR_FileReferenceBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFR_FileReferenceObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_FileReferenceEN> GetAllFR_FileReferenceObjLstCache()
{
//获取缓存中的对象列表
List<clsFR_FileReferenceEN> arrFR_FileReferenceObjLstCache = GetObjLstCache(); 
return arrFR_FileReferenceObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFR_FileReferenceEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFR_FileReferenceEN._CurrTabName);
List<clsFR_FileReferenceEN> arrFR_FileReferenceObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFR_FileReferenceObjLstCache;
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
string strKey = string.Format("{0}", clsFR_FileReferenceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_FileReferenceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFR_FileReferenceEN._RefreshTimeLst.Count == 0) return "";
return clsFR_FileReferenceEN._RefreshTimeLst[clsFR_FileReferenceEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsFR_FileReferenceBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFR_FileReferenceEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFR_FileReferenceEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFR_FileReferenceBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2026-07-23
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFR_FileReference.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFR_FileReference._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFR_FileReference._AttributeName));
throw new Exception(strMsg);
}
var objFR_FileReference = clsFR_FileReferenceBL.GetObjBymIdCache(lngmId);
if (objFR_FileReference == null) return "";
return objFR_FileReference[strOutFldName].ToString();
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
int intRecCount = clsFR_FileReferenceDA.GetRecCount(strTabName);
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
int intRecCount = clsFR_FileReferenceDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFR_FileReferenceDA.GetRecCount();
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
int intRecCount = clsFR_FileReferenceDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFR_FileReferenceCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFR_FileReferenceEN objFR_FileReferenceCond)
{
List<clsFR_FileReferenceEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFR_FileReferenceEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFR_FileReference._AttributeName)
{
if (objFR_FileReferenceCond.IsUpdated(strFldName) == false) continue;
if (objFR_FileReferenceCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_FileReferenceCond[strFldName].ToString());
}
else
{
if (objFR_FileReferenceCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFR_FileReferenceCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFR_FileReferenceCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFR_FileReferenceCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFR_FileReferenceCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFR_FileReferenceCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFR_FileReferenceCond[strFldName]));
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
 List<string> arrList = clsFR_FileReferenceDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FR_FileReferenceDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FR_FileReferenceDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FR_FileReferenceDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_FileReferenceDA.SetFldValue(clsFR_FileReferenceEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FR_FileReferenceDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_FileReferenceDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFR_FileReferenceDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFR_FileReferenceDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FR_FileReference] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key, "); 
 // /**源文件Id*/ 
 strCreateTabCode.Append(" SourceFileId bigint not Null, "); 
 // /**目标文件Id*/ 
 strCreateTabCode.Append(" TargetFileId bigint not Null, "); 
 // /**源符号Id*/ 
 strCreateTabCode.Append(" SourceSymbolId bigint Null, "); 
 // /**目标符号Id*/ 
 strCreateTabCode.Append(" TargetSymbolId bigint Null, "); 
 // /**引用类型*/ 
 strCreateTabCode.Append(" RefType varchar(50) not Null, "); 
 // /**引用名*/ 
 strCreateTabCode.Append(" RefName varchar(100) not Null, "); 
 // /**别名*/ 
 strCreateTabCode.Append(" RefAlias varchar(100) Null, "); 
 // /**开始行*/ 
 strCreateTabCode.Append(" LineStart int Null, "); 
 // /**结束行*/ 
 strCreateTabCode.Append(" LineEnd int Null, "); 
 // /**开始列*/ 
 strCreateTabCode.Append(" ColumnStart int Null, "); 
 // /**结束列*/ 
 strCreateTabCode.Append(" ColumnEnd int Null, "); 
 // /**原始引用语句*/ 
 strCreateTabCode.Append(" RefStatement varchar(500) Null, "); 
 // /**建立时间*/ 
 strCreateTabCode.Append(" CreatedAt datetime Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// FR_FileReference(FR_FileReference)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FR_FileReference : clsCommFun4BL
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
clsFR_FileReferenceBL.ReFreshThisCache();
}
}

}