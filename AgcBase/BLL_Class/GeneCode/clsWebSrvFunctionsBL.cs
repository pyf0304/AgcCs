
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFunctionsBL
 表名:WebSrvFunctions(00050342)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsWebSrvFunctionsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvFunctionsEN GetObj(this K_WebSrvFunctionId_WebSrvFunctions myKey)
{
clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsBL.WebSrvFunctionsDA.GetObjByWebSrvFunctionId(myKey.Value);
return objWebSrvFunctionsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvFunctionsEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],类Id = [{1}]的数据已经存在!(in clsWebSrvFunctionsBL.AddNewRecord)", objWebSrvFunctionsEN.FunctionName,objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
bool bolResult = clsWebSrvFunctionsBL.WebSrvFunctionsDA.AddNewRecordBySQL2(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
public static bool AddRecordEx(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objWebSrvFunctionsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objWebSrvFunctionsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(功能名称(FunctionName)=[{0}],类Id(WebSrvClassId)=[{1}])已经存在,不能重复!", objWebSrvFunctionsEN.FunctionName, objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objWebSrvFunctionsEN.AddNewRecord();
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvFunctionsEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],类Id = [{1}]的数据已经存在!(in clsWebSrvFunctionsBL.AddNewRecordWithMaxId)", objWebSrvFunctionsEN.FunctionName,objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
string strWebSrvFunctionId = clsWebSrvFunctionsBL.WebSrvFunctionsDA.AddNewRecordBySQL2WithReturnKey(objWebSrvFunctionsEN);
     objWebSrvFunctionsEN.WebSrvFunctionId = strWebSrvFunctionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
}
return strWebSrvFunctionId;
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objWebSrvFunctionsEN) == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],类Id = [{1}]的数据已经存在!(in clsWebSrvFunctionsBL.AddNewRecordWithReturnKey)", objWebSrvFunctionsEN.FunctionName,objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
string strKey = clsWebSrvFunctionsBL.WebSrvFunctionsDA.AddNewRecordBySQL2WithReturnKey(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetWebSrvFunctionId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWebSrvFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
}
objWebSrvFunctionsEN.WebSrvFunctionId = strWebSrvFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.WebSrvFunctionId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.WebSrvFunctionId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.WebSrvFunctionId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetWebSrvClassId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvClassId, conWebSrvFunctions.WebSrvClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
}
objWebSrvFunctionsEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.WebSrvClassId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.WebSrvClassId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.WebSrvClassId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFunctionName(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conWebSrvFunctions.FunctionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, conWebSrvFunctions.FunctionName);
}
objWebSrvFunctionsEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FunctionName) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FunctionName, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FunctionName] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetGetCustomAttributes(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, int intGetCustomAttributes, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intGetCustomAttributes, conWebSrvFunctions.GetCustomAttributes);
objWebSrvFunctionsEN.GetCustomAttributes = intGetCustomAttributes; //GetCustomAttributes
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.GetCustomAttributes) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.GetCustomAttributes, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.GetCustomAttributes] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFunctionSignature(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFunctionSignature, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionSignature, conWebSrvFunctions.FunctionSignature);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionSignature, 500, conWebSrvFunctions.FunctionSignature);
}
objWebSrvFunctionsEN.FunctionSignature = strFunctionSignature; //函数签名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FunctionSignature) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FunctionSignature, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FunctionSignature] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFuncTypeId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, conWebSrvFunctions.FuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
}
objWebSrvFunctionsEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FuncTypeId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FuncTypeId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FuncTypeId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnType(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnType, conWebSrvFunctions.ReturnType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnType, 500, conWebSrvFunctions.ReturnType);
}
objWebSrvFunctionsEN.ReturnType = strReturnType; //返回类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnType) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnType, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnType] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnTypeFullName(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeFullName, 500, conWebSrvFunctions.ReturnTypeFullName);
}
objWebSrvFunctionsEN.ReturnTypeFullName = strReturnTypeFullName; //返回类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnTypeFullName) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnTypeFullName, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeFullName] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsKnownType(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsKnownType, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsKnownType = bolIsKnownType; //是否已知类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsKnownType) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsKnownType, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsKnownType] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnTypeId(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
}
objWebSrvFunctionsEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnTypeId) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnTypeId, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeId] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsAsyncFunc(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsAsyncFunc, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsAsyncFunc = bolIsAsyncFunc; //是否异步函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsAsyncFunc) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsAsyncFunc, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsAsyncFunc] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetSourceFunction(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strSourceFunction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceFunction, 500, conWebSrvFunctions.SourceFunction);
}
objWebSrvFunctionsEN.SourceFunction = strSourceFunction; //来源函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.SourceFunction) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.SourceFunction, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.SourceFunction] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsGeneCode(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsGeneCode) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsGeneCode, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsGeneCode] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetReturnValueDescription(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strReturnValueDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnValueDescription, 500, conWebSrvFunctions.ReturnValueDescription);
}
objWebSrvFunctionsEN.ReturnValueDescription = strReturnValueDescription; //返回值说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.ReturnValueDescription) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.ReturnValueDescription, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.ReturnValueDescription] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetFuncParaLst(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strFuncParaLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncParaLst, 500, conWebSrvFunctions.FuncParaLst);
}
objWebSrvFunctionsEN.FuncParaLst = strFuncParaLst; //函数参数列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.FuncParaLst) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.FuncParaLst, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.FuncParaLst] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetIsSysFunction(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsSysFunction, string strComparisonOp="")
	{
objWebSrvFunctionsEN.IsSysFunction = bolIsSysFunction; //是否系统函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.IsSysFunction) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.IsSysFunction, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.IsSysFunction] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetUpdDate(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conWebSrvFunctions.UpdDate);
}
objWebSrvFunctionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.UpdDate) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.UpdDate, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.UpdDate] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetUpdUser(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conWebSrvFunctions.UpdUser);
}
objWebSrvFunctionsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.UpdUser) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.UpdUser, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.UpdUser] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsWebSrvFunctionsEN SetMemo(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conWebSrvFunctions.Memo);
}
objWebSrvFunctionsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objWebSrvFunctionsEN.dicFldComparisonOp.ContainsKey(conWebSrvFunctions.Memo) == false)
{
objWebSrvFunctionsEN.dicFldComparisonOp.Add(conWebSrvFunctions.Memo, strComparisonOp);
}
else
{
objWebSrvFunctionsEN.dicFldComparisonOp[conWebSrvFunctions.Memo] = strComparisonOp;
}
}
return objWebSrvFunctionsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objWebSrvFunctionsEN.CheckPropertyNew();
clsWebSrvFunctionsEN objWebSrvFunctionsCond = new clsWebSrvFunctionsEN();
string strCondition = objWebSrvFunctionsCond
.SetWebSrvFunctionId(objWebSrvFunctionsEN.WebSrvFunctionId, "<>")
.SetFunctionName(objWebSrvFunctionsEN.FunctionName, "=")
.SetWebSrvClassId(objWebSrvFunctionsEN.WebSrvClassId, "=")
.GetCombineCondition();
objWebSrvFunctionsEN._IsCheckProperty = true;
bool bolIsExist = clsWebSrvFunctionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FunctionName_WebSrvClassId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objWebSrvFunctionsEN.Update();
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
 /// <param name = "objWebSrvFunctions">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsWebSrvFunctionsEN objWebSrvFunctions)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsWebSrvFunctionsEN objWebSrvFunctionsCond = new clsWebSrvFunctionsEN();
string strCondition = objWebSrvFunctionsCond
.SetFunctionName(objWebSrvFunctions.FunctionName, "=")
.SetWebSrvClassId(objWebSrvFunctions.WebSrvClassId, "=")
.GetCombineCondition();
objWebSrvFunctions._IsCheckProperty = true;
bool bolIsExist = clsWebSrvFunctionsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objWebSrvFunctions.WebSrvFunctionId = clsWebSrvFunctionsBL.GetFirstID_S(strCondition);
objWebSrvFunctions.UpdateWithCondition(strCondition);
}
else
{
objWebSrvFunctions.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
objWebSrvFunctions.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebSrvFunctionsBL.WebSrvFunctionsDA.UpdateBySql2(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsWebSrvFunctionsBL.WebSrvFunctionsDA.UpdateBySql2(objWebSrvFunctionsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWhereCond)
{
try
{
bool bolResult = clsWebSrvFunctionsBL.WebSrvFunctionsDA.UpdateBySqlWithCondition(objWebSrvFunctionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsWebSrvFunctionsBL.WebSrvFunctionsDA.UpdateBySqlWithConditionTransaction(objWebSrvFunctionsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
int intRecNum = clsWebSrvFunctionsBL.WebSrvFunctionsDA.DelRecord(objWebSrvFunctionsEN.WebSrvFunctionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsENS">源对象</param>
 /// <param name = "objWebSrvFunctionsENT">目标对象</param>
 public static void CopyTo(this clsWebSrvFunctionsEN objWebSrvFunctionsENS, clsWebSrvFunctionsEN objWebSrvFunctionsENT)
{
try
{
objWebSrvFunctionsENT.WebSrvFunctionId = objWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objWebSrvFunctionsENT.WebSrvClassId = objWebSrvFunctionsENS.WebSrvClassId; //类Id
objWebSrvFunctionsENT.FunctionName = objWebSrvFunctionsENS.FunctionName; //功能名称
objWebSrvFunctionsENT.GetCustomAttributes = objWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objWebSrvFunctionsENT.FunctionSignature = objWebSrvFunctionsENS.FunctionSignature; //函数签名
objWebSrvFunctionsENT.FuncTypeId = objWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objWebSrvFunctionsENT.ReturnType = objWebSrvFunctionsENS.ReturnType; //返回类型
objWebSrvFunctionsENT.ReturnTypeFullName = objWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objWebSrvFunctionsENT.IsKnownType = objWebSrvFunctionsENS.IsKnownType; //是否已知类型
objWebSrvFunctionsENT.ReturnTypeId = objWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objWebSrvFunctionsENT.IsAsyncFunc = objWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objWebSrvFunctionsENT.SourceFunction = objWebSrvFunctionsENS.SourceFunction; //来源函数
objWebSrvFunctionsENT.IsGeneCode = objWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objWebSrvFunctionsENT.ReturnValueDescription = objWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objWebSrvFunctionsENT.FuncParaLst = objWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objWebSrvFunctionsENT.IsSysFunction = objWebSrvFunctionsENS.IsSysFunction; //是否系统函数
objWebSrvFunctionsENT.UpdDate = objWebSrvFunctionsENS.UpdDate; //修改日期
objWebSrvFunctionsENT.UpdUser = objWebSrvFunctionsENS.UpdUser; //修改者
objWebSrvFunctionsENT.Memo = objWebSrvFunctionsENS.Memo; //说明
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
 /// <param name = "objWebSrvFunctionsENS">源对象</param>
 /// <returns>目标对象=>clsWebSrvFunctionsEN:objWebSrvFunctionsENT</returns>
 public static clsWebSrvFunctionsEN CopyTo(this clsWebSrvFunctionsEN objWebSrvFunctionsENS)
{
try
{
 clsWebSrvFunctionsEN objWebSrvFunctionsENT = new clsWebSrvFunctionsEN()
{
WebSrvFunctionId = objWebSrvFunctionsENS.WebSrvFunctionId, //函数Id
WebSrvClassId = objWebSrvFunctionsENS.WebSrvClassId, //类Id
FunctionName = objWebSrvFunctionsENS.FunctionName, //功能名称
GetCustomAttributes = objWebSrvFunctionsENS.GetCustomAttributes, //GetCustomAttributes
FunctionSignature = objWebSrvFunctionsENS.FunctionSignature, //函数签名
FuncTypeId = objWebSrvFunctionsENS.FuncTypeId, //函数类型Id
ReturnType = objWebSrvFunctionsENS.ReturnType, //返回类型
ReturnTypeFullName = objWebSrvFunctionsENS.ReturnTypeFullName, //返回类型全名
IsKnownType = objWebSrvFunctionsENS.IsKnownType, //是否已知类型
ReturnTypeId = objWebSrvFunctionsENS.ReturnTypeId, //返回类型ID
IsAsyncFunc = objWebSrvFunctionsENS.IsAsyncFunc, //是否异步函数
SourceFunction = objWebSrvFunctionsENS.SourceFunction, //来源函数
IsGeneCode = objWebSrvFunctionsENS.IsGeneCode, //是否生成代码
ReturnValueDescription = objWebSrvFunctionsENS.ReturnValueDescription, //返回值说明
FuncParaLst = objWebSrvFunctionsENS.FuncParaLst, //函数参数列表
IsSysFunction = objWebSrvFunctionsENS.IsSysFunction, //是否系统函数
UpdDate = objWebSrvFunctionsENS.UpdDate, //修改日期
UpdUser = objWebSrvFunctionsENS.UpdUser, //修改者
Memo = objWebSrvFunctionsENS.Memo, //说明
};
 return objWebSrvFunctionsENT;
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
public static void CheckPropertyNew(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 clsWebSrvFunctionsBL.WebSrvFunctionsDA.CheckPropertyNew(objWebSrvFunctionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 clsWebSrvFunctionsBL.WebSrvFunctionsDA.CheckProperty4Condition(objWebSrvFunctionsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsWebSrvFunctionsEN objWebSrvFunctionsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.WebSrvFunctionId) == true)
{
string strComparisonOpWebSrvFunctionId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.WebSrvFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.WebSrvFunctionId, objWebSrvFunctionsCond.WebSrvFunctionId, strComparisonOpWebSrvFunctionId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.WebSrvClassId, objWebSrvFunctionsCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FunctionName) == true)
{
string strComparisonOpFunctionName = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FunctionName, objWebSrvFunctionsCond.FunctionName, strComparisonOpFunctionName);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.GetCustomAttributes) == true)
{
string strComparisonOpGetCustomAttributes = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.GetCustomAttributes];
strWhereCond += string.Format(" And {0} {2} {1}", conWebSrvFunctions.GetCustomAttributes, objWebSrvFunctionsCond.GetCustomAttributes, strComparisonOpGetCustomAttributes);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FunctionSignature) == true)
{
string strComparisonOpFunctionSignature = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FunctionSignature];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FunctionSignature, objWebSrvFunctionsCond.FunctionSignature, strComparisonOpFunctionSignature);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FuncTypeId, objWebSrvFunctionsCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnType) == true)
{
string strComparisonOpReturnType = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnType, objWebSrvFunctionsCond.ReturnType, strComparisonOpReturnType);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnTypeFullName) == true)
{
string strComparisonOpReturnTypeFullName = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnTypeFullName, objWebSrvFunctionsCond.ReturnTypeFullName, strComparisonOpReturnTypeFullName);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsKnownType) == true)
{
if (objWebSrvFunctionsCond.IsKnownType == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsKnownType);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsKnownType);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnTypeId, objWebSrvFunctionsCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsAsyncFunc) == true)
{
if (objWebSrvFunctionsCond.IsAsyncFunc == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsAsyncFunc);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsAsyncFunc);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.SourceFunction) == true)
{
string strComparisonOpSourceFunction = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.SourceFunction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.SourceFunction, objWebSrvFunctionsCond.SourceFunction, strComparisonOpSourceFunction);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsGeneCode) == true)
{
if (objWebSrvFunctionsCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsGeneCode);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.ReturnValueDescription) == true)
{
string strComparisonOpReturnValueDescription = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.ReturnValueDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.ReturnValueDescription, objWebSrvFunctionsCond.ReturnValueDescription, strComparisonOpReturnValueDescription);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.FuncParaLst) == true)
{
string strComparisonOpFuncParaLst = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.FuncParaLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.FuncParaLst, objWebSrvFunctionsCond.FuncParaLst, strComparisonOpFuncParaLst);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.IsSysFunction) == true)
{
if (objWebSrvFunctionsCond.IsSysFunction == true)
{
strWhereCond += string.Format(" And {0} = '1'", conWebSrvFunctions.IsSysFunction);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conWebSrvFunctions.IsSysFunction);
}
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.UpdDate) == true)
{
string strComparisonOpUpdDate = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.UpdDate, objWebSrvFunctionsCond.UpdDate, strComparisonOpUpdDate);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.UpdUser) == true)
{
string strComparisonOpUpdUser = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.UpdUser, objWebSrvFunctionsCond.UpdUser, strComparisonOpUpdUser);
}
if (objWebSrvFunctionsCond.IsUpdated(conWebSrvFunctions.Memo) == true)
{
string strComparisonOpMemo = objWebSrvFunctionsCond.dicFldComparisonOp[conWebSrvFunctions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conWebSrvFunctions.Memo, objWebSrvFunctionsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--WebSrvFunctions(WebSrv函数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FunctionName_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvFunctionsEN == null) return true;
if (objWebSrvFunctionsEN.WebSrvFunctionId == null || objWebSrvFunctionsEN.WebSrvFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
if (clsWebSrvFunctionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("WebSrvFunctionId !=  '{0}'", objWebSrvFunctionsEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
if (clsWebSrvFunctionsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--WebSrvFunctions(WebSrv函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FunctionName_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objWebSrvFunctionsEN == null) return "";
if (objWebSrvFunctionsEN.WebSrvFunctionId == null || objWebSrvFunctionsEN.WebSrvFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WebSrvFunctionId !=  '{0}'", objWebSrvFunctionsEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_WebSrvFunctions
{
public virtual bool UpdRelaTabDate(string strWebSrvFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// WebSrv函数(WebSrvFunctions)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsWebSrvFunctionsBL
{
public static RelatedActions_WebSrvFunctions relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsWebSrvFunctionsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsWebSrvFunctionsDA WebSrvFunctionsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsWebSrvFunctionsDA();
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
 public clsWebSrvFunctionsBL()
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
if (string.IsNullOrEmpty(clsWebSrvFunctionsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebSrvFunctionsEN._ConnectString);
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
public static DataTable GetDataTable_WebSrvFunctions(string strWhereCond)
{
DataTable objDT;
try
{
objDT = WebSrvFunctionsDA.GetDataTable_WebSrvFunctions(strWhereCond);
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
objDT = WebSrvFunctionsDA.GetDataTable(strWhereCond);
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
objDT = WebSrvFunctionsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = WebSrvFunctionsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = WebSrvFunctionsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = WebSrvFunctionsDA.GetDataTable_Top(objTopPara);
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
objDT = WebSrvFunctionsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = WebSrvFunctionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = WebSrvFunctionsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrWebSrvFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLst(List<string> arrWebSrvFunctionIdLst)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWebSrvFunctionIdLst, true);
 string strWhereCond = string.Format("WebSrvFunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsWebSrvFunctionsEN> GetObjLstByWebSrvFunctionIdLstCache(List<string> arrWebSrvFunctionIdLst)
{
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel =
arrWebSrvFunctionsObjLstCache
.Where(x => arrWebSrvFunctionIdLst.Contains(x.WebSrvFunctionId));
return arrWebSrvFunctionsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLst(string strWhereCond)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
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
public static List<clsWebSrvFunctionsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objWebSrvFunctionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsWebSrvFunctionsEN> GetSubObjLstCache(clsWebSrvFunctionsEN objWebSrvFunctionsCond)
{
List<clsWebSrvFunctionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebSrvFunctions._AttributeName)
{
if (objWebSrvFunctionsCond.IsUpdated(strFldName) == false) continue;
if (objWebSrvFunctionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvFunctionsCond[strFldName].ToString());
}
else
{
if (objWebSrvFunctionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebSrvFunctionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvFunctionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebSrvFunctionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebSrvFunctionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebSrvFunctionsCond[strFldName]));
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
public static List<clsWebSrvFunctionsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
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
public static List<clsWebSrvFunctionsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
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
List<clsWebSrvFunctionsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsWebSrvFunctionsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsWebSrvFunctionsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
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
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
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
public static List<clsWebSrvFunctionsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsWebSrvFunctionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
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
public static List<clsWebSrvFunctionsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objWebSrvFunctionsEN.WebSrvFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetWebSrvFunctions(ref clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
bool bolResult = WebSrvFunctionsDA.GetWebSrvFunctions(ref objWebSrvFunctionsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
if (strWebSrvFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWebSrvFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWebSrvFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsWebSrvFunctionsEN objWebSrvFunctionsEN = WebSrvFunctionsDA.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
return objWebSrvFunctionsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsWebSrvFunctionsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsWebSrvFunctionsEN objWebSrvFunctionsEN = WebSrvFunctionsDA.GetFirstObj(strWhereCond);
 return objWebSrvFunctionsEN;
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
public static clsWebSrvFunctionsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsWebSrvFunctionsEN objWebSrvFunctionsEN = WebSrvFunctionsDA.GetObjByDataRow(objRow);
 return objWebSrvFunctionsEN;
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
public static clsWebSrvFunctionsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsWebSrvFunctionsEN objWebSrvFunctionsEN = WebSrvFunctionsDA.GetObjByDataRow(objRow);
 return objWebSrvFunctionsEN;
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
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <param name = "lstWebSrvFunctionsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebSrvFunctionsEN GetObjByWebSrvFunctionIdFromList(string strWebSrvFunctionId, List<clsWebSrvFunctionsEN> lstWebSrvFunctionsObjLst)
{
foreach (clsWebSrvFunctionsEN objWebSrvFunctionsEN in lstWebSrvFunctionsObjLst)
{
if (objWebSrvFunctionsEN.WebSrvFunctionId == strWebSrvFunctionId)
{
return objWebSrvFunctionsEN;
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
 string strMaxWebSrvFunctionId;
 try
 {
 strMaxWebSrvFunctionId = clsWebSrvFunctionsDA.GetMaxStrId();
 return strMaxWebSrvFunctionId;
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
 string strWebSrvFunctionId;
 try
 {
 strWebSrvFunctionId = new clsWebSrvFunctionsDA().GetFirstID(strWhereCond);
 return strWebSrvFunctionId;
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
 arrList = WebSrvFunctionsDA.GetID(strWhereCond);
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
bool bolIsExist = WebSrvFunctionsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWebSrvFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = WebSrvFunctionsDA.IsExist(strWebSrvFunctionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strWebSrvFunctionId">函数Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strWebSrvFunctionId, string strOpUser)
{
clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objWebSrvFunctionsEN.UpdUser = strOpUser;
return clsWebSrvFunctionsBL.UpdateBySql2(objWebSrvFunctionsEN);
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
 bolIsExist = clsWebSrvFunctionsDA.IsExistTable();
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
 bolIsExist = WebSrvFunctionsDA.IsExistTable(strTabName);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebSrvFunctionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],类Id = [{1}]的数据已经存在!(in clsWebSrvFunctionsBL.AddNewRecordBySql2)", objWebSrvFunctionsEN.FunctionName,objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
bool bolResult = WebSrvFunctionsDA.AddNewRecordBySQL2(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsWebSrvFunctionsEN objWebSrvFunctionsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objWebSrvFunctionsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!功能名称 = [{0}],类Id = [{1}]的数据已经存在!(in clsWebSrvFunctionsBL.AddNewRecordBySql2WithReturnKey)", objWebSrvFunctionsEN.FunctionName,objWebSrvFunctionsEN.WebSrvClassId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true || clsWebSrvFunctionsBL.IsExist(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
     objWebSrvFunctionsEN.WebSrvFunctionId = clsWebSrvFunctionsBL.GetMaxStrId_S();
 }
string strKey = WebSrvFunctionsDA.AddNewRecordBySQL2WithReturnKey(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
bool bolResult = WebSrvFunctionsDA.Update(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 if (string.IsNullOrEmpty(objWebSrvFunctionsEN.WebSrvFunctionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = WebSrvFunctionsDA.UpdateBySql2(objWebSrvFunctionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsWebSrvFunctionsBL.ReFreshCache();

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strWebSrvFunctionId)
{
try
{
 clsWebSrvFunctionsEN objWebSrvFunctionsEN = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);

if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(objWebSrvFunctionsEN.WebSrvFunctionId, objWebSrvFunctionsEN.UpdUser);
}
if (objWebSrvFunctionsEN != null)
{
int intRecNum = WebSrvFunctionsDA.DelRecord(strWebSrvFunctionId);
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
/// <param name="strWebSrvFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strWebSrvFunctionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
//删除与表:[WebSrvFunctions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conWebSrvFunctions.WebSrvFunctionId,
//strWebSrvFunctionId);
//        clsWebSrvFunctionsBL.DelWebSrvFunctionssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebSrvFunctionsBL.DelRecord(strWebSrvFunctionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebSrvFunctionsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strWebSrvFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strWebSrvFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsWebSrvFunctionsBL.relatedActions != null)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(strWebSrvFunctionId, "UpdRelaTabDate");
}
bool bolResult = WebSrvFunctionsDA.DelRecord(strWebSrvFunctionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrWebSrvFunctionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelWebSrvFunctionss(List<string> arrWebSrvFunctionIdLst)
{
if (arrWebSrvFunctionIdLst.Count == 0) return 0;
try
{
if (clsWebSrvFunctionsBL.relatedActions != null)
{
foreach (var strWebSrvFunctionId in arrWebSrvFunctionIdLst)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(strWebSrvFunctionId, "UpdRelaTabDate");
}
}
int intDelRecNum = WebSrvFunctionsDA.DelWebSrvFunctions(arrWebSrvFunctionIdLst);
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
public static int DelWebSrvFunctionssByCond(string strWhereCond)
{
try
{
if (clsWebSrvFunctionsBL.relatedActions != null)
{
List<string> arrWebSrvFunctionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strWebSrvFunctionId in arrWebSrvFunctionId)
{
clsWebSrvFunctionsBL.relatedActions.UpdRelaTabDate(strWebSrvFunctionId, "UpdRelaTabDate");
}
}
int intRecNum = WebSrvFunctionsDA.DelWebSrvFunctions(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[WebSrvFunctions]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strWebSrvFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strWebSrvFunctionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
//删除与表:[WebSrvFunctions]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsWebSrvFunctionsBL.DelRecord(strWebSrvFunctionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsWebSrvFunctionsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strWebSrvFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objWebSrvFunctionsENS">源对象</param>
 /// <param name = "objWebSrvFunctionsENT">目标对象</param>
 public static void CopyTo(clsWebSrvFunctionsEN objWebSrvFunctionsENS, clsWebSrvFunctionsEN objWebSrvFunctionsENT)
{
try
{
objWebSrvFunctionsENT.WebSrvFunctionId = objWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objWebSrvFunctionsENT.WebSrvClassId = objWebSrvFunctionsENS.WebSrvClassId; //类Id
objWebSrvFunctionsENT.FunctionName = objWebSrvFunctionsENS.FunctionName; //功能名称
objWebSrvFunctionsENT.GetCustomAttributes = objWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objWebSrvFunctionsENT.FunctionSignature = objWebSrvFunctionsENS.FunctionSignature; //函数签名
objWebSrvFunctionsENT.FuncTypeId = objWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objWebSrvFunctionsENT.ReturnType = objWebSrvFunctionsENS.ReturnType; //返回类型
objWebSrvFunctionsENT.ReturnTypeFullName = objWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objWebSrvFunctionsENT.IsKnownType = objWebSrvFunctionsENS.IsKnownType; //是否已知类型
objWebSrvFunctionsENT.ReturnTypeId = objWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objWebSrvFunctionsENT.IsAsyncFunc = objWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objWebSrvFunctionsENT.SourceFunction = objWebSrvFunctionsENS.SourceFunction; //来源函数
objWebSrvFunctionsENT.IsGeneCode = objWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objWebSrvFunctionsENT.ReturnValueDescription = objWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objWebSrvFunctionsENT.FuncParaLst = objWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objWebSrvFunctionsENT.IsSysFunction = objWebSrvFunctionsENS.IsSysFunction; //是否系统函数
objWebSrvFunctionsENT.UpdDate = objWebSrvFunctionsENS.UpdDate; //修改日期
objWebSrvFunctionsENT.UpdUser = objWebSrvFunctionsENS.UpdUser; //修改者
objWebSrvFunctionsENT.Memo = objWebSrvFunctionsENS.Memo; //说明
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
 /// <param name = "objWebSrvFunctionsEN">源简化对象</param>
 public static void SetUpdFlag(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
objWebSrvFunctionsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objWebSrvFunctionsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conWebSrvFunctions.WebSrvFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.WebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId; //函数Id
}
if (arrFldSet.Contains(conWebSrvFunctions.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.WebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(conWebSrvFunctions.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.FunctionName = objWebSrvFunctionsEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(conWebSrvFunctions.GetCustomAttributes, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.GetCustomAttributes = objWebSrvFunctionsEN.GetCustomAttributes; //GetCustomAttributes
}
if (arrFldSet.Contains(conWebSrvFunctions.FunctionSignature, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.FunctionSignature = objWebSrvFunctionsEN.FunctionSignature; //函数签名
}
if (arrFldSet.Contains(conWebSrvFunctions.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.FuncTypeId = objWebSrvFunctionsEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conWebSrvFunctions.ReturnType, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.ReturnType = objWebSrvFunctionsEN.ReturnType; //返回类型
}
if (arrFldSet.Contains(conWebSrvFunctions.ReturnTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.ReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName == "[null]" ? null :  objWebSrvFunctionsEN.ReturnTypeFullName; //返回类型全名
}
if (arrFldSet.Contains(conWebSrvFunctions.IsKnownType, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.IsKnownType = objWebSrvFunctionsEN.IsKnownType; //是否已知类型
}
if (arrFldSet.Contains(conWebSrvFunctions.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.ReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId == "[null]" ? null :  objWebSrvFunctionsEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(conWebSrvFunctions.IsAsyncFunc, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.IsAsyncFunc = objWebSrvFunctionsEN.IsAsyncFunc; //是否异步函数
}
if (arrFldSet.Contains(conWebSrvFunctions.SourceFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.SourceFunction = objWebSrvFunctionsEN.SourceFunction == "[null]" ? null :  objWebSrvFunctionsEN.SourceFunction; //来源函数
}
if (arrFldSet.Contains(conWebSrvFunctions.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.IsGeneCode = objWebSrvFunctionsEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(conWebSrvFunctions.ReturnValueDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.ReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription == "[null]" ? null :  objWebSrvFunctionsEN.ReturnValueDescription; //返回值说明
}
if (arrFldSet.Contains(conWebSrvFunctions.FuncParaLst, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.FuncParaLst = objWebSrvFunctionsEN.FuncParaLst == "[null]" ? null :  objWebSrvFunctionsEN.FuncParaLst; //函数参数列表
}
if (arrFldSet.Contains(conWebSrvFunctions.IsSysFunction, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.IsSysFunction = objWebSrvFunctionsEN.IsSysFunction; //是否系统函数
}
if (arrFldSet.Contains(conWebSrvFunctions.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.UpdDate = objWebSrvFunctionsEN.UpdDate == "[null]" ? null :  objWebSrvFunctionsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conWebSrvFunctions.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.UpdUser = objWebSrvFunctionsEN.UpdUser == "[null]" ? null :  objWebSrvFunctionsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conWebSrvFunctions.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objWebSrvFunctionsEN.Memo = objWebSrvFunctionsEN.Memo == "[null]" ? null :  objWebSrvFunctionsEN.Memo; //说明
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
 /// <param name = "objWebSrvFunctionsEN">源简化对象</param>
 public static void AccessFldValueNull(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
try
{
if (objWebSrvFunctionsEN.ReturnTypeFullName == "[null]") objWebSrvFunctionsEN.ReturnTypeFullName = null; //返回类型全名
if (objWebSrvFunctionsEN.ReturnTypeId == "[null]") objWebSrvFunctionsEN.ReturnTypeId = null; //返回类型ID
if (objWebSrvFunctionsEN.SourceFunction == "[null]") objWebSrvFunctionsEN.SourceFunction = null; //来源函数
if (objWebSrvFunctionsEN.ReturnValueDescription == "[null]") objWebSrvFunctionsEN.ReturnValueDescription = null; //返回值说明
if (objWebSrvFunctionsEN.FuncParaLst == "[null]") objWebSrvFunctionsEN.FuncParaLst = null; //函数参数列表
if (objWebSrvFunctionsEN.UpdDate == "[null]") objWebSrvFunctionsEN.UpdDate = null; //修改日期
if (objWebSrvFunctionsEN.UpdUser == "[null]") objWebSrvFunctionsEN.UpdUser = null; //修改者
if (objWebSrvFunctionsEN.Memo == "[null]") objWebSrvFunctionsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 WebSrvFunctionsDA.CheckPropertyNew(objWebSrvFunctionsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 WebSrvFunctionsDA.CheckProperty4Condition(objWebSrvFunctionsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_WebSrvFunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conWebSrvFunctions.WebSrvFunctionId); 
List<clsWebSrvFunctionsEN> arrObjLst = clsWebSrvFunctionsBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN()
{
WebSrvFunctionId = "0",
FunctionName = "选[WebSrv函数]..."
};
arrObjLst.Insert(0, objWebSrvFunctionsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conWebSrvFunctions.WebSrvFunctionId;
objComboBox.DisplayMember = conWebSrvFunctions.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_WebSrvFunctionId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[WebSrv函数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conWebSrvFunctions.WebSrvFunctionId); 
IEnumerable<clsWebSrvFunctionsEN> arrObjLst = clsWebSrvFunctionsBL.GetObjLst(strCondition);
objDDL.DataValueField = conWebSrvFunctions.WebSrvFunctionId;
objDDL.DataTextField = conWebSrvFunctions.FunctionName;
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
public static void BindDdl_WebSrvFunctionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[WebSrv函数]...","0");
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst = GetAllWebSrvFunctionsObjLstCache(); 
objDDL.DataValueField = conWebSrvFunctions.WebSrvFunctionId;
objDDL.DataTextField = conWebSrvFunctions.FunctionName;
objDDL.DataSource = arrWebSrvFunctionsObjLst;
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
if (clsWebSrvFunctionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvFunctionsBL没有刷新缓存机制(clsWebSrvFunctionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvFunctionId");
//if (arrWebSrvFunctionsObjLstCache == null)
//{
//arrWebSrvFunctionsObjLstCache = WebSrvFunctionsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsWebSrvFunctionsEN GetObjByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel =
arrWebSrvFunctionsObjLstCache
.Where(x=> x.WebSrvFunctionId == strWebSrvFunctionId 
);
if (arrWebSrvFunctionsObjLst_Sel.Count() == 0)
{
   clsWebSrvFunctionsEN obj = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionId(strWebSrvFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrWebSrvFunctionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return "";
//获取缓存中的对象列表
clsWebSrvFunctionsEN objWebSrvFunctions = GetObjByWebSrvFunctionIdCache(strWebSrvFunctionId);
if (objWebSrvFunctions == null) return "";
return objWebSrvFunctions.FunctionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByWebSrvFunctionIdCache(string strWebSrvFunctionId)
{
if (string.IsNullOrEmpty(strWebSrvFunctionId) == true) return "";
//获取缓存中的对象列表
clsWebSrvFunctionsEN objWebSrvFunctions = GetObjByWebSrvFunctionIdCache(strWebSrvFunctionId);
if (objWebSrvFunctions == null) return "";
return objWebSrvFunctions.FunctionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetAllWebSrvFunctionsObjLstCache()
{
//获取缓存中的对象列表
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache(); 
return arrWebSrvFunctionsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsWebSrvFunctionsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrWebSrvFunctionsObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:GetCustomAttributes字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrWebSrvFunctionsObjLst">需要排序的对象列表</param>
public static List <clsWebSrvFunctionsEN> GetSubSet4WebSrvFunctionsObjLstByGetCustomAttributesCache(int intGetCustomAttributes)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel1 =
from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLstCache
where objWebSrvFunctionsEN.GetCustomAttributes == intGetCustomAttributes
select objWebSrvFunctionsEN;
List <clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel = new List<clsWebSrvFunctionsEN>();
foreach (clsWebSrvFunctionsEN obj in arrWebSrvFunctionsObjLst_Sel1)
{
arrWebSrvFunctionsObjLst_Sel.Add(obj);
}
return arrWebSrvFunctionsObjLst_Sel;
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
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebSrvFunctionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsWebSrvFunctionsEN._RefreshTimeLst.Count == 0) return "";
return clsWebSrvFunctionsEN._RefreshTimeLst[clsWebSrvFunctionsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsWebSrvFunctionsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsWebSrvFunctionsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsWebSrvFunctionsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsWebSrvFunctionsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--WebSrvFunctions(WebSrv函数)
 /// 唯一性条件:FunctionName_WebSrvClassId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检测记录是否存在
string strResult = WebSrvFunctionsDA.GetUniCondStr(objWebSrvFunctionsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strWebSrvFunctionId)
{
if (strInFldName != conWebSrvFunctions.WebSrvFunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conWebSrvFunctions._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conWebSrvFunctions._AttributeName));
throw new Exception(strMsg);
}
var objWebSrvFunctions = clsWebSrvFunctionsBL.GetObjByWebSrvFunctionIdCache(strWebSrvFunctionId);
if (objWebSrvFunctions == null) return "";
return objWebSrvFunctions[strOutFldName].ToString();
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
int intRecCount = clsWebSrvFunctionsDA.GetRecCount(strTabName);
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
int intRecCount = clsWebSrvFunctionsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsWebSrvFunctionsDA.GetRecCount();
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
int intRecCount = clsWebSrvFunctionsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objWebSrvFunctionsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsWebSrvFunctionsEN objWebSrvFunctionsCond)
{
List<clsWebSrvFunctionsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsWebSrvFunctionsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conWebSrvFunctions._AttributeName)
{
if (objWebSrvFunctionsCond.IsUpdated(strFldName) == false) continue;
if (objWebSrvFunctionsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvFunctionsCond[strFldName].ToString());
}
else
{
if (objWebSrvFunctionsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objWebSrvFunctionsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objWebSrvFunctionsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objWebSrvFunctionsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objWebSrvFunctionsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objWebSrvFunctionsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objWebSrvFunctionsCond[strFldName]));
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
 List<string> arrList = clsWebSrvFunctionsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = WebSrvFunctionsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = WebSrvFunctionsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = WebSrvFunctionsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebSrvFunctionsDA.SetFldValue(clsWebSrvFunctionsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = WebSrvFunctionsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebSrvFunctionsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsWebSrvFunctionsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsWebSrvFunctionsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[WebSrvFunctions] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数Id*/ 
 strCreateTabCode.Append(" WebSrvFunctionId char(8) primary key, "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" WebSrvClassId char(8) not Null, "); 
 // /**功能名称*/ 
 strCreateTabCode.Append(" FunctionName varchar(200) not Null, "); 
 // /**GetCustomAttributes*/ 
 strCreateTabCode.Append(" GetCustomAttributes int not Null, "); 
 // /**函数签名*/ 
 strCreateTabCode.Append(" FunctionSignature varchar(500) not Null, "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) not Null, "); 
 // /**返回类型*/ 
 strCreateTabCode.Append(" ReturnType varchar(500) not Null, "); 
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
 // /**函数参数列表*/ 
 strCreateTabCode.Append(" FuncParaLst varchar(500) Null, "); 
 // /**是否系统函数*/ 
 strCreateTabCode.Append(" IsSysFunction bit Null, "); 
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
 /// WebSrv函数(WebSrvFunctions)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4WebSrvFunctions : clsCommFun4BL
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
clsWebSrvFunctionsBL.ReFreshThisCache();
}
}

}