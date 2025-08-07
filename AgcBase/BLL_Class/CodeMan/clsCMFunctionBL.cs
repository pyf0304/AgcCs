
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionBL
 表名:CMFunction(00050502)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMFunctionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionEN GetObj(this K_CmFunctionId_CMFunction myKey)
{
clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.CMFunctionDA.GetObjByCmFunctionId(myKey.Value);
return objCMFunctionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecord)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
bool bolResult = clsCMFunctionBL.CMFunctionDA.AddNewRecordBySQL2(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
public static bool AddRecordEx(this clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCMFunctionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMFunctionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能名称(FunctionName)=[{0}],函数参数列表(FuncParaLst)=[{1}],类Id(CmClassId)=[{2}])已经存在,不能重复!", objCMFunctionEN.FunctionName, objCMFunctionEN.FuncParaLst, objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCMFunctionEN.AddNewRecord();
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecordWithMaxId)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
string strCmFunctionId = clsCMFunctionBL.CMFunctionDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionEN);
     objCMFunctionEN.CmFunctionId = strCmFunctionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
}
return strCmFunctionId;
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecord(SqlTransaction))", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.AddNewRecordBySQL2(objCMFunctionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecordWithReturnKey)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
string strKey = clsCMFunctionBL.CMFunctionDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecordWithReturnKey)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMFunctionBL.CMFunctionDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetCmFunctionId(this clsCMFunctionEN objCMFunctionEN, string strCmFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, conCMFunction.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, conCMFunction.CmFunctionId);
}
objCMFunctionEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.CmFunctionId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.CmFunctionId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.CmFunctionId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetCmClassId(this clsCMFunctionEN objCMFunctionEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, conCMFunction.CmClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, conCMFunction.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, conCMFunction.CmClassId);
}
objCMFunctionEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.CmClassId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.CmClassId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.CmClassId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFunctionName(this clsCMFunctionEN objCMFunctionEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conCMFunction.FunctionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, conCMFunction.FunctionName);
}
objCMFunctionEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FunctionName) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FunctionName, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FunctionName] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncContent(this clsCMFunctionEN objCMFunctionEN, string strFuncContent, string strComparisonOp="")
	{
objCMFunctionEN.FuncContent = strFuncContent; //函数内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncContent) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncContent, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncContent] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetKeyWords(this clsCMFunctionEN objCMFunctionEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, conCMFunction.KeyWords);
}
objCMFunctionEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.KeyWords) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.KeyWords, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.KeyWords] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncParaLst(this clsCMFunctionEN objCMFunctionEN, string strFuncParaLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, conCMFunction.FuncParaLst);
}
objCMFunctionEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncParaLst) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncParaLst, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncParaLst] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncComments(this clsCMFunctionEN objCMFunctionEN, string strFuncComments, string strComparisonOp="")
	{
objCMFunctionEN.FuncComments = strFuncComments; //函数注释
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncComments) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncComments, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncComments] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFunctionSignature(this clsCMFunctionEN objCMFunctionEN, string strFunctionSignature, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conCMFunction.FunctionSignature);
}
objCMFunctionEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FunctionSignature) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FunctionSignature, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FunctionSignature] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetFuncTypeId(this clsCMFunctionEN objCMFunctionEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conCMFunction.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conCMFunction.FuncTypeId);
}
objCMFunctionEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.FuncTypeId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.FuncTypeId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.FuncTypeId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnType(this clsCMFunctionEN objCMFunctionEN, string strReturnType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, conCMFunction.ReturnType);
}
objCMFunctionEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnType) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnType, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnType] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnTypeFullName(this clsCMFunctionEN objCMFunctionEN, string strReturnTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conCMFunction.ReturnTypeFullName);
}
objCMFunctionEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnTypeFullName) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnTypeFullName, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnTypeFullName] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsKnownType(this clsCMFunctionEN objCMFunctionEN, bool bolIsKnownType, string strComparisonOp="")
	{
objCMFunctionEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsKnownType) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsKnownType, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsKnownType] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnTypeId(this clsCMFunctionEN objCMFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conCMFunction.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conCMFunction.ReturnTypeId);
}
objCMFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnTypeId) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnTypeId, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnTypeId] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsAsyncFunc(this clsCMFunctionEN objCMFunctionEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objCMFunctionEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsAsyncFunc) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsAsyncFunc, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsAsyncFunc] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSourceFunction(this clsCMFunctionEN objCMFunctionEN, string strSourceFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conCMFunction.SourceFunction);
}
objCMFunctionEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SourceFunction) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SourceFunction, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SourceFunction] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsGeneCode(this clsCMFunctionEN objCMFunctionEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objCMFunctionEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsGeneCode) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsGeneCode, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsGeneCode] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetReturnValueDescription(this clsCMFunctionEN objCMFunctionEN, string strReturnValueDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, conCMFunction.ReturnValueDescription);
}
objCMFunctionEN.ReturnValueDescription = strReturnValueDescription; //返回值说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ReturnValueDescription) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ReturnValueDescription, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ReturnValueDescription] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSysFunction(this clsCMFunctionEN objCMFunctionEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objCMFunctionEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSysFunction) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSysFunction, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSysFunction] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetGetCustomAttributes(this clsCMFunctionEN objCMFunctionEN, int? intGetCustomAttributes, string strComparisonOp="")
	{
objCMFunctionEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.GetCustomAttributes) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.GetCustomAttributes, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.GetCustomAttributes] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetClassNameLst(this clsCMFunctionEN objCMFunctionEN, string strClassNameLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassNameLst, 500, conCMFunction.ClassNameLst);
}
objCMFunctionEN.ClassNameLst = strClassNameLst; //类名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.ClassNameLst) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.ClassNameLst, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.ClassNameLst] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetUpdDate(this clsCMFunctionEN objCMFunctionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFunction.UpdDate);
}
objCMFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.UpdDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.UpdDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.UpdDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetUpdUser(this clsCMFunctionEN objCMFunctionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFunction.UpdUser);
}
objCMFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.UpdUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.UpdUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.UpdUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetMemo(this clsCMFunctionEN objCMFunctionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFunction.Memo);
}
objCMFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.Memo) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.Memo, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.Memo] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSynchToServer(this clsCMFunctionEN objCMFunctionEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMFunctionEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSynchToServer) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSynchToServer, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSynchToServer] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToServerDate(this clsCMFunctionEN objCMFunctionEN, string strSynchToServerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMFunction.SynchToServerDate);
}
objCMFunctionEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToServerDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToServerDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToServerDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToServerUser(this clsCMFunctionEN objCMFunctionEN, string strSynchToServerUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMFunction.SynchToServerUser);
}
objCMFunctionEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToServerUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToServerUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToServerUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetIsSynchToClient(this clsCMFunctionEN objCMFunctionEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMFunctionEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.IsSynchToClient) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.IsSynchToClient, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.IsSynchToClient] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToClientDate(this clsCMFunctionEN objCMFunctionEN, string strSynchToClientDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMFunction.SynchToClientDate);
}
objCMFunctionEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToClientDate) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToClientDate, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToClientDate] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynchToClientUser(this clsCMFunctionEN objCMFunctionEN, string strSynchToClientUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMFunction.SynchToClientUser);
}
objCMFunctionEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynchToClientUser) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynchToClientUser, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynchToClientUser] = strComparisonOp;
}
}
return objCMFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionEN SetSynSource(this clsCMFunctionEN objCMFunctionEN, string strSynSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMFunction.SynSource);
}
objCMFunctionEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionEN.dicFldComparisonOp.ContainsKey(conCMFunction.SynSource) == false)
{
objCMFunctionEN.dicFldComparisonOp.Add(conCMFunction.SynSource, strComparisonOp);
}
else
{
objCMFunctionEN.dicFldComparisonOp[conCMFunction.SynSource] = strComparisonOp;
}
}
return objCMFunctionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMFunctionEN objCMFunctionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMFunctionEN.CheckPropertyNew();
clsCMFunctionEN objCMFunctionCond = new clsCMFunctionEN();
string strCondition = objCMFunctionCond
.SetCmFunctionId(objCMFunctionEN.CmFunctionId, "<>")
.SetFunctionName(objCMFunctionEN.FunctionName, "=")
.SetFuncParaLst(objCMFunctionEN.FuncParaLst, "=")
.SetCmClassId(objCMFunctionEN.CmClassId, "=")
.GetCombineCondition();
objCMFunctionEN._IsCheckProperty = true;
bool bolIsExist = clsCMFunctionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CMClassId_FuncName_UserId_ParaList)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMFunctionEN.Update();
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
 /// <param name = "objCMFunction">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMFunctionEN objCMFunction)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMFunctionEN objCMFunctionCond = new clsCMFunctionEN();
string strCondition = objCMFunctionCond
.SetFunctionName(objCMFunction.FunctionName, "=")
.SetFuncParaLst(objCMFunction.FuncParaLst, "=")
.SetCmClassId(objCMFunction.CmClassId, "=")
.GetCombineCondition();
objCMFunction._IsCheckProperty = true;
bool bolIsExist = clsCMFunctionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMFunction.CmFunctionId = clsCMFunctionBL.GetFirstID_S(strCondition);
objCMFunction.UpdateWithCondition(strCondition);
}
else
{
objCMFunction.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
objCMFunction.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionEN objCMFunctionEN)
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.UpdateBySql2(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.UpdateBySql2(objCMFunctionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.UpdateBySql2(objCMFunctionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionEN objCMFunctionEN, string strWhereCond)
{
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.UpdateBySqlWithCondition(objCMFunctionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionEN objCMFunctionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMFunctionBL.CMFunctionDA.UpdateBySqlWithConditionTransaction(objCMFunctionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMFunctionEN objCMFunctionEN)
{
try
{
int intRecNum = clsCMFunctionBL.CMFunctionDA.DelRecord(objCMFunctionEN.CmFunctionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionENS">源对象</param>
 /// <param name = "objCMFunctionENT">目标对象</param>
 public static void CopyTo(this clsCMFunctionEN objCMFunctionENS, clsCMFunctionEN objCMFunctionENT)
{
try
{
objCMFunctionENT.CmFunctionId = objCMFunctionENS.CmFunctionId; //函数Id
objCMFunctionENT.CmClassId = objCMFunctionENS.CmClassId; //类Id
objCMFunctionENT.FunctionName = objCMFunctionENS.FunctionName; //功能名称
objCMFunctionENT.FuncContent = objCMFunctionENS.FuncContent; //函数内容
objCMFunctionENT.KeyWords = objCMFunctionENS.KeyWords; //关键字
objCMFunctionENT.FuncParaLst = objCMFunctionENS.FuncParaLst; //函数参数列表
objCMFunctionENT.FuncComments = objCMFunctionENS.FuncComments; //函数注释
objCMFunctionENT.FunctionSignature = objCMFunctionENS.FunctionSignature; //函数签名
objCMFunctionENT.FuncTypeId = objCMFunctionENS.FuncTypeId; //函数类型Id
objCMFunctionENT.ReturnType = objCMFunctionENS.ReturnType; //返回类型
objCMFunctionENT.ReturnTypeFullName = objCMFunctionENS.ReturnTypeFullName; //返回类型全名
objCMFunctionENT.IsKnownType = objCMFunctionENS.IsKnownType; //是否已知类型
objCMFunctionENT.ReturnTypeId = objCMFunctionENS.ReturnTypeId; //返回类型ID
objCMFunctionENT.IsAsyncFunc = objCMFunctionENS.IsAsyncFunc; //是否异步函数
objCMFunctionENT.SourceFunction = objCMFunctionENS.SourceFunction; //来源函数
objCMFunctionENT.IsGeneCode = objCMFunctionENS.IsGeneCode; //是否生成代码
objCMFunctionENT.ReturnValueDescription = objCMFunctionENS.ReturnValueDescription; //返回值说明
objCMFunctionENT.IsSysFunction = objCMFunctionENS.IsSysFunction; //是否系统函数
objCMFunctionENT.GetCustomAttributes = objCMFunctionENS.GetCustomAttributes; //GetCustomAttributes
objCMFunctionENT.ClassNameLst = objCMFunctionENS.ClassNameLst; //类名列表
objCMFunctionENT.UpdDate = objCMFunctionENS.UpdDate; //修改日期
objCMFunctionENT.UpdUser = objCMFunctionENS.UpdUser; //修改者
objCMFunctionENT.Memo = objCMFunctionENS.Memo; //说明
objCMFunctionENT.IsSynchToServer = objCMFunctionENS.IsSynchToServer; //是否同步到Server
objCMFunctionENT.SynchToServerDate = objCMFunctionENS.SynchToServerDate; //同步到Server日期
objCMFunctionENT.SynchToServerUser = objCMFunctionENS.SynchToServerUser; //同步到Server用户
objCMFunctionENT.IsSynchToClient = objCMFunctionENS.IsSynchToClient; //是否同步到Client
objCMFunctionENT.SynchToClientDate = objCMFunctionENS.SynchToClientDate; //同步到Client库日期
objCMFunctionENT.SynchToClientUser = objCMFunctionENS.SynchToClientUser; //同步到Client库用户
objCMFunctionENT.SynSource = objCMFunctionENS.SynSource; //同步来源
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
 /// <param name = "objCMFunctionENS">源对象</param>
 /// <returns>目标对象=>clsCMFunctionEN:objCMFunctionENT</returns>
 public static clsCMFunctionEN CopyTo(this clsCMFunctionEN objCMFunctionENS)
{
try
{
 clsCMFunctionEN objCMFunctionENT = new clsCMFunctionEN()
{
CmFunctionId = objCMFunctionENS.CmFunctionId, //函数Id
CmClassId = objCMFunctionENS.CmClassId, //类Id
FunctionName = objCMFunctionENS.FunctionName, //功能名称
FuncContent = objCMFunctionENS.FuncContent, //函数内容
KeyWords = objCMFunctionENS.KeyWords, //关键字
FuncParaLst = objCMFunctionENS.FuncParaLst, //函数参数列表
FuncComments = objCMFunctionENS.FuncComments, //函数注释
FunctionSignature = objCMFunctionENS.FunctionSignature, //函数签名
FuncTypeId = objCMFunctionENS.FuncTypeId, //函数类型Id
ReturnType = objCMFunctionENS.ReturnType, //返回类型
ReturnTypeFullName = objCMFunctionENS.ReturnTypeFullName, //返回类型全名
IsKnownType = objCMFunctionENS.IsKnownType, //是否已知类型
ReturnTypeId = objCMFunctionENS.ReturnTypeId, //返回类型ID
IsAsyncFunc = objCMFunctionENS.IsAsyncFunc, //是否异步函数
SourceFunction = objCMFunctionENS.SourceFunction, //来源函数
IsGeneCode = objCMFunctionENS.IsGeneCode, //是否生成代码
ReturnValueDescription = objCMFunctionENS.ReturnValueDescription, //返回值说明
IsSysFunction = objCMFunctionENS.IsSysFunction, //是否系统函数
GetCustomAttributes = objCMFunctionENS.GetCustomAttributes, //GetCustomAttributes
ClassNameLst = objCMFunctionENS.ClassNameLst, //类名列表
UpdDate = objCMFunctionENS.UpdDate, //修改日期
UpdUser = objCMFunctionENS.UpdUser, //修改者
Memo = objCMFunctionENS.Memo, //说明
IsSynchToServer = objCMFunctionENS.IsSynchToServer, //是否同步到Server
SynchToServerDate = objCMFunctionENS.SynchToServerDate, //同步到Server日期
SynchToServerUser = objCMFunctionENS.SynchToServerUser, //同步到Server用户
IsSynchToClient = objCMFunctionENS.IsSynchToClient, //是否同步到Client
SynchToClientDate = objCMFunctionENS.SynchToClientDate, //同步到Client库日期
SynchToClientUser = objCMFunctionENS.SynchToClientUser, //同步到Client库用户
SynSource = objCMFunctionENS.SynSource, //同步来源
};
 return objCMFunctionENT;
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
public static void CheckPropertyNew(this clsCMFunctionEN objCMFunctionEN)
{
 clsCMFunctionBL.CMFunctionDA.CheckPropertyNew(objCMFunctionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMFunctionEN objCMFunctionEN)
{
 clsCMFunctionBL.CMFunctionDA.CheckProperty4Condition(objCMFunctionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFunctionEN objCMFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFunctionCond.IsUpdated(conCMFunction.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.CmFunctionId, objCMFunctionCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.CmClassId) == true)
{
string strComparisonOpCmClassId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.CmClassId, objCMFunctionCond.CmClassId, strComparisonOpCmClassId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FunctionName) == true)
{
string strComparisonOpFunctionName = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FunctionName, objCMFunctionCond.FunctionName, strComparisonOpFunctionName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCMFunctionCond.IsUpdated(conCMFunction.KeyWords) == true)
{
string strComparisonOpKeyWords = objCMFunctionCond.dicFldComparisonOp[conCMFunction.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.KeyWords, objCMFunctionCond.KeyWords, strComparisonOpKeyWords);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FuncParaLst, objCMFunctionCond.FuncParaLst, strComparisonOpFuncParaLst);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objCMFunctionCond.IsUpdated(conCMFunction.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FunctionSignature, objCMFunctionCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.FuncTypeId, objCMFunctionCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnType) == true)
{
string strComparisonOpReturnType = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnType, objCMFunctionCond.ReturnType, strComparisonOpReturnType);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnTypeFullName, objCMFunctionCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsKnownType) == true)
{
if (objCMFunctionCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsKnownType);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnTypeId, objCMFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsAsyncFunc) == true)
{
if (objCMFunctionCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsAsyncFunc);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SourceFunction, objCMFunctionCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsGeneCode) == true)
{
if (objCMFunctionCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsGeneCode);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ReturnValueDescription) == true)
{
string strComparisonOpReturnValueDescription = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ReturnValueDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ReturnValueDescription, objCMFunctionCond.ReturnValueDescription, strComparisonOpReturnValueDescription);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSysFunction) == true)
{
if (objCMFunctionCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSysFunction);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objCMFunctionCond.dicFldComparisonOp[conCMFunction.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFunction.GetCustomAttributes, objCMFunctionCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.ClassNameLst) == true)
{
string strComparisonOpClassNameLst = objCMFunctionCond.dicFldComparisonOp[conCMFunction.ClassNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.ClassNameLst, objCMFunctionCond.ClassNameLst, strComparisonOpClassNameLst);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.UpdDate, objCMFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.UpdUser, objCMFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.Memo) == true)
{
string strComparisonOpMemo = objCMFunctionCond.dicFldComparisonOp[conCMFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.Memo, objCMFunctionCond.Memo, strComparisonOpMemo);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSynchToServer) == true)
{
if (objCMFunctionCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSynchToServer);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToServerDate, objCMFunctionCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToServerUser, objCMFunctionCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.IsSynchToClient) == true)
{
if (objCMFunctionCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunction.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunction.IsSynchToClient);
}
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToClientDate, objCMFunctionCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynchToClientUser, objCMFunctionCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMFunctionCond.IsUpdated(conCMFunction.SynSource) == true)
{
string strComparisonOpSynSource = objCMFunctionCond.dicFldComparisonOp[conCMFunction.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunction.SynSource, objCMFunctionCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMFunction(CM函数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CMClassId_FuncName_UserId_ParaList
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMFunctionEN objCMFunctionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionEN == null) return true;
if (objCMFunctionEN.CmFunctionId == null || objCMFunctionEN.CmFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 if (objCMFunctionEN.FuncParaLst == null)
{
 sbCondition.AppendFormat(" and FuncParaLst is null", objCMFunctionEN.FuncParaLst);
}
else
{
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
}
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
if (clsCMFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CmFunctionId !=  '{0}'", objCMFunctionEN.CmFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
if (clsCMFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMFunction(CM函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMClassId_FuncName_UserId_ParaList
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMFunctionEN objCMFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionEN == null) return "";
if (objCMFunctionEN.CmFunctionId == null || objCMFunctionEN.CmFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 if (objCMFunctionEN.FuncParaLst == null)
{
 sbCondition.AppendFormat(" and FuncParaLst is null", objCMFunctionEN.FuncParaLst);
}
else
{
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
}
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CmFunctionId !=  '{0}'", objCMFunctionEN.CmFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMFunction
{
public virtual bool UpdRelaTabDate(string strCmFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM函数(CMFunction)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMFunctionBL
{
public static RelatedActions_CMFunction relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMFunctionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMFunctionDA CMFunctionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMFunctionDA();
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
 public clsCMFunctionBL()
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
if (string.IsNullOrEmpty(clsCMFunctionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFunctionEN._ConnectString);
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
public static DataTable GetDataTable_CMFunction(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMFunctionDA.GetDataTable_CMFunction(strWhereCond);
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
objDT = CMFunctionDA.GetDataTable(strWhereCond);
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
objDT = CMFunctionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMFunctionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMFunctionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMFunctionDA.GetDataTable_Top(objTopPara);
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
objDT = CMFunctionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCmFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstByCmFunctionIdLst(List<string> arrCmFunctionIdLst)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCmFunctionIdLst, true);
 string strWhereCond = string.Format("CmFunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCmFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMFunctionEN> GetObjLstByCmFunctionIdLstCache(List<string> arrCmFunctionIdLst)
{
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel =
arrCMFunctionObjLstCache
.Where(x => arrCmFunctionIdLst.Contains(x.CmFunctionId));
return arrCMFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetObjLst(string strWhereCond)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
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
public static List<clsCMFunctionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMFunctionEN> GetSubObjLstCache(clsCMFunctionEN objCMFunctionCond)
{
List<clsCMFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFunction._AttributeName)
{
if (objCMFunctionCond.IsUpdated(strFldName) == false) continue;
if (objCMFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionCond[strFldName].ToString());
}
else
{
if (objCMFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFunctionCond[strFldName]));
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
public static List<clsCMFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
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
public static List<clsCMFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
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
List<clsCMFunctionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMFunctionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
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
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
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
public static List<clsCMFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
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
public static List<clsCMFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMFunctionEN.CmFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMFunctionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMFunction(ref clsCMFunctionEN objCMFunctionEN)
{
bool bolResult = CMFunctionDA.GetCMFunction(ref objCMFunctionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
if (strCmFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCmFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCmFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCmFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMFunctionEN objCMFunctionEN = CMFunctionDA.GetObjByCmFunctionId(strCmFunctionId);
return objCMFunctionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMFunctionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMFunctionEN objCMFunctionEN = CMFunctionDA.GetFirstObj(strWhereCond);
 return objCMFunctionEN;
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
public static clsCMFunctionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMFunctionEN objCMFunctionEN = CMFunctionDA.GetObjByDataRow(objRow);
 return objCMFunctionEN;
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
public static clsCMFunctionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMFunctionEN objCMFunctionEN = CMFunctionDA.GetObjByDataRow(objRow);
 return objCMFunctionEN;
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
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <param name = "lstCMFunctionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFunctionEN GetObjByCmFunctionIdFromList(string strCmFunctionId, List<clsCMFunctionEN> lstCMFunctionObjLst)
{
foreach (clsCMFunctionEN objCMFunctionEN in lstCMFunctionObjLst)
{
if (objCMFunctionEN.CmFunctionId == strCmFunctionId)
{
return objCMFunctionEN;
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
 string strMaxCmFunctionId;
 try
 {
 strMaxCmFunctionId = clsCMFunctionDA.GetMaxStrId();
 return strMaxCmFunctionId;
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
 string strCmFunctionId;
 try
 {
 strCmFunctionId = new clsCMFunctionDA().GetFirstID(strWhereCond);
 return strCmFunctionId;
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
 arrList = CMFunctionDA.GetID(strWhereCond);
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
bool bolIsExist = CMFunctionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCmFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMFunctionDA.IsExist(strCmFunctionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCmFunctionId">函数Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCmFunctionId, string strOpUser)
{
clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMFunctionEN.UpdUser = strOpUser;
return clsCMFunctionBL.UpdateBySql2(objCMFunctionEN);
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
 bolIsExist = clsCMFunctionDA.IsExistTable();
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
 bolIsExist = CMFunctionDA.IsExistTable(strTabName);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFunctionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecordBySql2)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
bool bolResult = CMFunctionDA.AddNewRecordBySQL2(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMFunctionEN objCMFunctionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMFunctionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],函数参数列表 = [{1}],类Id = [{2}]的数据已经存在!(in clsCMFunctionBL.AddNewRecordBySql2WithReturnKey)", objCMFunctionEN.FunctionName,objCMFunctionEN.FuncParaLst,objCMFunctionEN.CmClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true || clsCMFunctionBL.IsExist(objCMFunctionEN.CmFunctionId) == true)
 {
     objCMFunctionEN.CmFunctionId = clsCMFunctionBL.GetMaxStrId_S();
 }
string strKey = CMFunctionDA.AddNewRecordBySQL2WithReturnKey(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMFunctionEN objCMFunctionEN)
{
try
{
bool bolResult = CMFunctionDA.Update(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMFunctionEN objCMFunctionEN)
{
 if (string.IsNullOrEmpty(objCMFunctionEN.CmFunctionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMFunctionDA.UpdateBySql2(objCMFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFunctionBL.ReFreshCache();

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
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
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCmFunctionId)
{
try
{
 clsCMFunctionEN objCMFunctionEN = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);

if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(objCMFunctionEN.CmFunctionId, objCMFunctionEN.UpdUser);
}
if (objCMFunctionEN != null)
{
int intRecNum = CMFunctionDA.DelRecord(strCmFunctionId);
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
/// <param name="strCmFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCmFunctionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
//删除与表:[CMFunction]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMFunction.CmFunctionId,
//strCmFunctionId);
//        clsCMFunctionBL.DelCMFunctionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFunctionBL.DelRecord(strCmFunctionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFunctionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCmFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMFunctionBL.relatedActions != null)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(strCmFunctionId, "UpdRelaTabDate");
}
bool bolResult = CMFunctionDA.DelRecord(strCmFunctionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCmFunctionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMFunctions(List<string> arrCmFunctionIdLst)
{
if (arrCmFunctionIdLst.Count == 0) return 0;
try
{
if (clsCMFunctionBL.relatedActions != null)
{
foreach (var strCmFunctionId in arrCmFunctionIdLst)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(strCmFunctionId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMFunctionDA.DelCMFunction(arrCmFunctionIdLst);
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
public static int DelCMFunctionsByCond(string strWhereCond)
{
try
{
if (clsCMFunctionBL.relatedActions != null)
{
List<string> arrCmFunctionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmFunctionId in arrCmFunctionId)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(strCmFunctionId, "UpdRelaTabDate");
}
}
int intRecNum = CMFunctionDA.DelCMFunction(strWhereCond);
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
public static bool DelCMFunctionsByCondWithTransaction_S(string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMFunctionBL.relatedActions != null)
{
List<string> arrCmFunctionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCmFunctionId in arrCmFunctionId)
{
clsCMFunctionBL.relatedActions.UpdRelaTabDate(strCmFunctionId, "UpdRelaTabDate");
}
}
bool bolResult = CMFunctionDA.DelCMFunctionWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMFunction]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCmFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCmFunctionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
//删除与表:[CMFunction]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMFunctionBL.DelRecord(strCmFunctionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMFunctionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCmFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMFunctionENS">源对象</param>
 /// <param name = "objCMFunctionENT">目标对象</param>
 public static void CopyTo(clsCMFunctionEN objCMFunctionENS, clsCMFunctionEN objCMFunctionENT)
{
try
{
objCMFunctionENT.CmFunctionId = objCMFunctionENS.CmFunctionId; //函数Id
objCMFunctionENT.CmClassId = objCMFunctionENS.CmClassId; //类Id
objCMFunctionENT.FunctionName = objCMFunctionENS.FunctionName; //功能名称
objCMFunctionENT.FuncContent = objCMFunctionENS.FuncContent; //函数内容
objCMFunctionENT.KeyWords = objCMFunctionENS.KeyWords; //关键字
objCMFunctionENT.FuncParaLst = objCMFunctionENS.FuncParaLst; //函数参数列表
objCMFunctionENT.FuncComments = objCMFunctionENS.FuncComments; //函数注释
objCMFunctionENT.FunctionSignature = objCMFunctionENS.FunctionSignature; //函数签名
objCMFunctionENT.FuncTypeId = objCMFunctionENS.FuncTypeId; //函数类型Id
objCMFunctionENT.ReturnType = objCMFunctionENS.ReturnType; //返回类型
objCMFunctionENT.ReturnTypeFullName = objCMFunctionENS.ReturnTypeFullName; //返回类型全名
objCMFunctionENT.IsKnownType = objCMFunctionENS.IsKnownType; //是否已知类型
objCMFunctionENT.ReturnTypeId = objCMFunctionENS.ReturnTypeId; //返回类型ID
objCMFunctionENT.IsAsyncFunc = objCMFunctionENS.IsAsyncFunc; //是否异步函数
objCMFunctionENT.SourceFunction = objCMFunctionENS.SourceFunction; //来源函数
objCMFunctionENT.IsGeneCode = objCMFunctionENS.IsGeneCode; //是否生成代码
objCMFunctionENT.ReturnValueDescription = objCMFunctionENS.ReturnValueDescription; //返回值说明
objCMFunctionENT.IsSysFunction = objCMFunctionENS.IsSysFunction; //是否系统函数
objCMFunctionENT.GetCustomAttributes = objCMFunctionENS.GetCustomAttributes; //GetCustomAttributes
objCMFunctionENT.ClassNameLst = objCMFunctionENS.ClassNameLst; //类名列表
objCMFunctionENT.UpdDate = objCMFunctionENS.UpdDate; //修改日期
objCMFunctionENT.UpdUser = objCMFunctionENS.UpdUser; //修改者
objCMFunctionENT.Memo = objCMFunctionENS.Memo; //说明
objCMFunctionENT.IsSynchToServer = objCMFunctionENS.IsSynchToServer; //是否同步到Server
objCMFunctionENT.SynchToServerDate = objCMFunctionENS.SynchToServerDate; //同步到Server日期
objCMFunctionENT.SynchToServerUser = objCMFunctionENS.SynchToServerUser; //同步到Server用户
objCMFunctionENT.IsSynchToClient = objCMFunctionENS.IsSynchToClient; //是否同步到Client
objCMFunctionENT.SynchToClientDate = objCMFunctionENS.SynchToClientDate; //同步到Client库日期
objCMFunctionENT.SynchToClientUser = objCMFunctionENS.SynchToClientUser; //同步到Client库用户
objCMFunctionENT.SynSource = objCMFunctionENS.SynSource; //同步来源
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
 /// <param name = "objCMFunctionEN">源简化对象</param>
 public static void SetUpdFlag(clsCMFunctionEN objCMFunctionEN)
{
try
{
objCMFunctionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMFunctionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMFunction.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.CmFunctionId = objCMFunctionEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(conCMFunction.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.CmClassId = objCMFunctionEN.CmClassId; //类Id
}
if (arrFldSet.Contains(conCMFunction.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FunctionName = objCMFunctionEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(conCMFunction.FuncContent, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FuncContent = objCMFunctionEN.FuncContent == "[null]" ? null :  objCMFunctionEN.FuncContent; //函数内容
}
if (arrFldSet.Contains(conCMFunction.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.KeyWords = objCMFunctionEN.KeyWords == "[null]" ? null :  objCMFunctionEN.KeyWords; //关键字
}
if (arrFldSet.Contains(conCMFunction.FuncParaLst, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FuncParaLst = objCMFunctionEN.FuncParaLst == "[null]" ? null :  objCMFunctionEN.FuncParaLst; //函数参数列表
}
if (arrFldSet.Contains(conCMFunction.FuncComments, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FuncComments = objCMFunctionEN.FuncComments == "[null]" ? null :  objCMFunctionEN.FuncComments; //函数注释
}
if (arrFldSet.Contains(conCMFunction.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FunctionSignature = objCMFunctionEN.FunctionSignature == "[null]" ? null :  objCMFunctionEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(conCMFunction.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.FuncTypeId = objCMFunctionEN.FuncTypeId == "[null]" ? null :  objCMFunctionEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conCMFunction.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.ReturnType = objCMFunctionEN.ReturnType == "[null]" ? null :  objCMFunctionEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(conCMFunction.ReturnTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.ReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName == "[null]" ? null :  objCMFunctionEN.ReturnTypeFullName; //返回类型全名
}
if (arrFldSet.Contains(conCMFunction.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsKnownType = objCMFunctionEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(conCMFunction.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.ReturnTypeId = objCMFunctionEN.ReturnTypeId == "[null]" ? null :  objCMFunctionEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(conCMFunction.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsAsyncFunc = objCMFunctionEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(conCMFunction.SourceFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SourceFunction = objCMFunctionEN.SourceFunction == "[null]" ? null :  objCMFunctionEN.SourceFunction; //来源函数
}
if (arrFldSet.Contains(conCMFunction.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsGeneCode = objCMFunctionEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(conCMFunction.ReturnValueDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.ReturnValueDescription = objCMFunctionEN.ReturnValueDescription == "[null]" ? null :  objCMFunctionEN.ReturnValueDescription; //返回值说明
}
if (arrFldSet.Contains(conCMFunction.IsSysFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsSysFunction = objCMFunctionEN.IsSysFunction; //是否系统函数
}
if (arrFldSet.Contains(conCMFunction.GetCustomAttributes, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.GetCustomAttributes = objCMFunctionEN.GetCustomAttributes; //GetCustomAttributes
}
if (arrFldSet.Contains(conCMFunction.ClassNameLst, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.ClassNameLst = objCMFunctionEN.ClassNameLst == "[null]" ? null :  objCMFunctionEN.ClassNameLst; //类名列表
}
if (arrFldSet.Contains(conCMFunction.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.UpdDate = objCMFunctionEN.UpdDate == "[null]" ? null :  objCMFunctionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMFunction.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.UpdUser = objCMFunctionEN.UpdUser == "[null]" ? null :  objCMFunctionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMFunction.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.Memo = objCMFunctionEN.Memo == "[null]" ? null :  objCMFunctionEN.Memo; //说明
}
if (arrFldSet.Contains(conCMFunction.IsSynchToServer, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsSynchToServer = objCMFunctionEN.IsSynchToServer; //是否同步到Server
}
if (arrFldSet.Contains(conCMFunction.SynchToServerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SynchToServerDate = objCMFunctionEN.SynchToServerDate == "[null]" ? null :  objCMFunctionEN.SynchToServerDate; //同步到Server日期
}
if (arrFldSet.Contains(conCMFunction.SynchToServerUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SynchToServerUser = objCMFunctionEN.SynchToServerUser == "[null]" ? null :  objCMFunctionEN.SynchToServerUser; //同步到Server用户
}
if (arrFldSet.Contains(conCMFunction.IsSynchToClient, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.IsSynchToClient = objCMFunctionEN.IsSynchToClient; //是否同步到Client
}
if (arrFldSet.Contains(conCMFunction.SynchToClientDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SynchToClientDate = objCMFunctionEN.SynchToClientDate == "[null]" ? null :  objCMFunctionEN.SynchToClientDate; //同步到Client库日期
}
if (arrFldSet.Contains(conCMFunction.SynchToClientUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SynchToClientUser = objCMFunctionEN.SynchToClientUser == "[null]" ? null :  objCMFunctionEN.SynchToClientUser; //同步到Client库用户
}
if (arrFldSet.Contains(conCMFunction.SynSource, new clsStrCompareIgnoreCase())  ==  true)
{
objCMFunctionEN.SynSource = objCMFunctionEN.SynSource == "[null]" ? null :  objCMFunctionEN.SynSource; //同步来源
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
 /// <param name = "objCMFunctionEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMFunctionEN objCMFunctionEN)
{
try
{
if (objCMFunctionEN.FuncContent == "[null]") objCMFunctionEN.FuncContent = null; //函数内容
if (objCMFunctionEN.KeyWords == "[null]") objCMFunctionEN.KeyWords = null; //关键字
if (objCMFunctionEN.FuncParaLst == "[null]") objCMFunctionEN.FuncParaLst = null; //函数参数列表
if (objCMFunctionEN.FuncComments == "[null]") objCMFunctionEN.FuncComments = null; //函数注释
if (objCMFunctionEN.FunctionSignature == "[null]") objCMFunctionEN.FunctionSignature = null; //函数签名
if (objCMFunctionEN.FuncTypeId == "[null]") objCMFunctionEN.FuncTypeId = null; //函数类型Id
if (objCMFunctionEN.ReturnType == "[null]") objCMFunctionEN.ReturnType = null; //返回类型
if (objCMFunctionEN.ReturnTypeFullName == "[null]") objCMFunctionEN.ReturnTypeFullName = null; //返回类型全名
if (objCMFunctionEN.ReturnTypeId == "[null]") objCMFunctionEN.ReturnTypeId = null; //返回类型ID
if (objCMFunctionEN.SourceFunction == "[null]") objCMFunctionEN.SourceFunction = null; //来源函数
if (objCMFunctionEN.ReturnValueDescription == "[null]") objCMFunctionEN.ReturnValueDescription = null; //返回值说明
if (objCMFunctionEN.ClassNameLst == "[null]") objCMFunctionEN.ClassNameLst = null; //类名列表
if (objCMFunctionEN.UpdDate == "[null]") objCMFunctionEN.UpdDate = null; //修改日期
if (objCMFunctionEN.UpdUser == "[null]") objCMFunctionEN.UpdUser = null; //修改者
if (objCMFunctionEN.Memo == "[null]") objCMFunctionEN.Memo = null; //说明
if (objCMFunctionEN.SynchToServerDate == "[null]") objCMFunctionEN.SynchToServerDate = null; //同步到Server日期
if (objCMFunctionEN.SynchToServerUser == "[null]") objCMFunctionEN.SynchToServerUser = null; //同步到Server用户
if (objCMFunctionEN.SynchToClientDate == "[null]") objCMFunctionEN.SynchToClientDate = null; //同步到Client库日期
if (objCMFunctionEN.SynchToClientUser == "[null]") objCMFunctionEN.SynchToClientUser = null; //同步到Client库用户
if (objCMFunctionEN.SynSource == "[null]") objCMFunctionEN.SynSource = null; //同步来源
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
public static void CheckPropertyNew(clsCMFunctionEN objCMFunctionEN)
{
 CMFunctionDA.CheckPropertyNew(objCMFunctionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMFunctionEN objCMFunctionEN)
{
 CMFunctionDA.CheckProperty4Condition(objCMFunctionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CmFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMFunction.CmFunctionId); 
List<clsCMFunctionEN> arrObjLst = clsCMFunctionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN()
{
CmFunctionId = "0",
FunctionName = "选[CM函数]..."
};
arrObjLst.Insert(0, objCMFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMFunction.CmFunctionId;
objComboBox.DisplayMember = conCMFunction.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CmFunctionId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM函数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMFunction.CmFunctionId); 
IEnumerable<clsCMFunctionEN> arrObjLst = clsCMFunctionBL.GetObjLst(strCondition);
objDDL.DataValueField = conCMFunction.CmFunctionId;
objDDL.DataTextField = conCMFunction.FunctionName;
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
public static void BindDdl_CmFunctionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[CM函数]...","0");
List<clsCMFunctionEN> arrCMFunctionObjLst = GetAllCMFunctionObjLstCache(); 
objDDL.DataValueField = conCMFunction.CmFunctionId;
objDDL.DataTextField = conCMFunction.FunctionName;
objDDL.DataSource = arrCMFunctionObjLst;
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
if (clsCMFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionBL没有刷新缓存机制(clsCMFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CmFunctionId");
//if (arrCMFunctionObjLstCache == null)
//{
//arrCMFunctionObjLstCache = CMFunctionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMFunctionEN GetObjByCmFunctionIdCache(string strCmFunctionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel =
arrCMFunctionObjLstCache
.Where(x=> x.CmFunctionId == strCmFunctionId 
);
if (arrCMFunctionObjLst_Sel.Count() == 0)
{
   clsCMFunctionEN obj = clsCMFunctionBL.GetObjByCmFunctionId(strCmFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//获取缓存中的对象列表
clsCMFunctionEN objCMFunction = GetObjByCmFunctionIdCache(strCmFunctionId);
if (objCMFunction == null) return "";
return objCMFunction.FunctionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCmFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCmFunctionIdCache(string strCmFunctionId)
{
if (string.IsNullOrEmpty(strCmFunctionId) == true) return "";
//获取缓存中的对象列表
clsCMFunctionEN objCMFunction = GetObjByCmFunctionIdCache(strCmFunctionId);
if (objCMFunction == null) return "";
return objCMFunction.FunctionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFunctionEN> GetAllCMFunctionObjLstCache()
{
//获取缓存中的对象列表
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache(); 
return arrCMFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMFunctionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMFunctionObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:GetCustomAttributes字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrCMFunctionObjLst">需要排序的对象列表</param>
public static List <clsCMFunctionEN> GetSubSet4CMFunctionObjLstByGetCustomAttributesCache(int intGetCustomAttributes)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
List<clsCMFunctionEN> arrCMFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrCMFunctionObjLst_Sel1 =
from objCMFunctionEN in arrCMFunctionObjLstCache
where objCMFunctionEN.GetCustomAttributes == intGetCustomAttributes
select objCMFunctionEN;
List <clsCMFunctionEN> arrCMFunctionObjLst_Sel = new List<clsCMFunctionEN>();
foreach (clsCMFunctionEN obj in arrCMFunctionObjLst_Sel1)
{
arrCMFunctionObjLst_Sel.Add(obj);
}
return arrCMFunctionObjLst_Sel;
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
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMFunctionEN._RefreshTimeLst.Count == 0) return "";
return clsCMFunctionEN._RefreshTimeLst[clsCMFunctionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCMFunctionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMFunctionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMFunction(CM函数)
 /// 唯一性条件:CMClassId_FuncName_UserId_ParaList
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMFunctionEN objCMFunctionEN)
{
//检测记录是否存在
string strResult = CMFunctionDA.GetUniCondStr(objCMFunctionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCmFunctionId)
{
if (strInFldName != conCMFunction.CmFunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMFunction._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMFunction._AttributeName));
throw new Exception(strMsg);
}
var objCMFunction = clsCMFunctionBL.GetObjByCmFunctionIdCache(strCmFunctionId);
if (objCMFunction == null) return "";
return objCMFunction[strOutFldName].ToString();
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
int intRecCount = clsCMFunctionDA.GetRecCount(strTabName);
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
int intRecCount = clsCMFunctionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMFunctionDA.GetRecCount();
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
int intRecCount = clsCMFunctionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMFunctionEN objCMFunctionCond)
{
List<clsCMFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMFunction._AttributeName)
{
if (objCMFunctionCond.IsUpdated(strFldName) == false) continue;
if (objCMFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionCond[strFldName].ToString());
}
else
{
if (objCMFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMFunctionCond[strFldName]));
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
 List<string> arrList = clsCMFunctionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMFunctionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMFunctionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMFunctionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFunctionDA.SetFldValue(clsCMFunctionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMFunctionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFunctionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMFunctionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMFunctionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMFunction] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数Id*/ 
 strCreateTabCode.Append(" CmFunctionId char(8) primary key, "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" CmClassId char(8) not Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FunctionName varchar(200) not Null, "); 
 // /**函数内容*/ 
 strCreateTabCode.Append(" FuncContent text Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" KeyWords varchar(500) Null, "); 
 // /**函数参数列表*/ 
 strCreateTabCode.Append(" FuncParaLst varchar(500) Null, "); 
 // /**函数注释*/ 
 strCreateTabCode.Append(" FuncComments text Null, "); 
 // /**函数签名*/ 
 strCreateTabCode.Append(" FunctionSignature varchar(500) Null, "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) Null, "); 
 // /**返回类型*/ 
 strCreateTabCode.Append(" ReturnType varchar(500) Null, "); 
 // /**返回类型全名*/ 
 strCreateTabCode.Append(" ReturnTypeFullName varchar(500) Null, "); 
 // /**是否已知类型*/ 
 strCreateTabCode.Append(" IsKnownType bit Null, "); 
 // /**返回类型ID*/ 
 strCreateTabCode.Append(" ReturnTypeId char(2) Null, "); 
 // /**是否异步函数*/ 
 strCreateTabCode.Append(" IsAsyncFunc bit Null, "); 
 // /**来源函数*/ 
 strCreateTabCode.Append(" SourceFunction varchar(500) Null, "); 
 // /**是否生成代码*/ 
 strCreateTabCode.Append(" IsGeneCode bit Null, "); 
 // /**返回值说明*/ 
 strCreateTabCode.Append(" ReturnValueDescription varchar(500) Null, "); 
 // /**是否系统函数*/ 
 strCreateTabCode.Append(" IsSysFunction bit Null, "); 
 // /**GetCustomAttributes*/ 
 strCreateTabCode.Append(" GetCustomAttributes int Null, "); 
 // /**类名列表*/ 
 strCreateTabCode.Append(" ClassNameLst varchar(500) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**是否同步到Server*/ 
 strCreateTabCode.Append(" IsSynchToServer bit Null, "); 
 // /**同步到Server日期*/ 
 strCreateTabCode.Append(" SynchToServerDate varchar(20) Null, "); 
 // /**同步到Server用户*/ 
 strCreateTabCode.Append(" SynchToServerUser varchar(20) Null, "); 
 // /**是否同步到Client*/ 
 strCreateTabCode.Append(" IsSynchToClient bit Null, "); 
 // /**同步到Client库日期*/ 
 strCreateTabCode.Append(" SynchToClientDate varchar(20) Null, "); 
 // /**同步到Client库用户*/ 
 strCreateTabCode.Append(" SynchToClientUser varchar(20) Null, "); 
 // /**同步来源*/ 
 strCreateTabCode.Append(" SynSource varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// CM函数(CMFunction)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMFunction : clsCommFun4BL
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
clsCMFunctionBL.ReFreshThisCache();
}
}

}