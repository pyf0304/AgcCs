
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFunctionBL
 表名:PrjFunction(00050072)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:26
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsPrjFunctionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFunctionEN GetObj(this K_FuncId_PrjFunction myKey)
{
clsPrjFunctionEN objPrjFunctionEN = clsPrjFunctionBL.PrjFunctionDA.GetObjByFuncId(myKey.Value);
return objPrjFunctionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjFunctionEN.FuncId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjFunctionBL.AddNewRecord)", objPrjFunctionEN.FuncName,objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPrjFunctionBL.PrjFunctionDA.AddNewRecordBySQL2(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
public static bool AddRecordEx(this clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPrjFunctionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjFunctionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数名(FuncName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objPrjFunctionEN.FuncName, objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPrjFunctionEN.AddNewRecord();
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjFunctionBL.AddNewRecordWithMaxId)", objPrjFunctionEN.FuncName,objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true || clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId) == true)
 {
     objPrjFunctionEN.FuncId = clsPrjFunctionBL.GetMaxStrIdByPrefix_S(objPrjFunctionEN.PrjId);
 }
string strFuncId = clsPrjFunctionBL.PrjFunctionDA.AddNewRecordBySQL2WithReturnKey(objPrjFunctionEN);
     objPrjFunctionEN.FuncId = strFuncId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
}
return strFuncId;
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjFunctionEN.FuncId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjFunctionEN) == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjFunctionBL.AddNewRecordWithReturnKey)", objPrjFunctionEN.FuncName,objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPrjFunctionBL.PrjFunctionDA.AddNewRecordBySQL2WithReturnKey(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetFuncId(this clsPrjFunctionEN objPrjFunctionEN, string strFuncId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId, 10, conPrjFunction.FuncId);
}
objPrjFunctionEN.FuncId = strFuncId; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.FuncId) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.FuncId, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.FuncId] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetFuncName(this clsPrjFunctionEN objPrjFunctionEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, conPrjFunction.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, conPrjFunction.FuncName);
}
objPrjFunctionEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.FuncName) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.FuncName, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.FuncName] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetPrjId(this clsPrjFunctionEN objPrjFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjFunction.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjFunction.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjFunction.PrjId);
}
objPrjFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.PrjId) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.PrjId, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.PrjId] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetReturnTypeId(this clsPrjFunctionEN objPrjFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnTypeId, conPrjFunction.ReturnTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, conPrjFunction.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, conPrjFunction.ReturnTypeId);
}
objPrjFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.ReturnTypeId) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.ReturnTypeId, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.ReturnTypeId] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetFuncTypeId(this clsPrjFunctionEN objPrjFunctionEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, conPrjFunction.FuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, conPrjFunction.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, conPrjFunction.FuncTypeId);
}
objPrjFunctionEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.FuncTypeId) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.FuncTypeId, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.FuncTypeId] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetIsTemplate(this clsPrjFunctionEN objPrjFunctionEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, conPrjFunction.IsTemplate);
objPrjFunctionEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.IsTemplate) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.IsTemplate, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.IsTemplate] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetFuncCode(this clsPrjFunctionEN objPrjFunctionEN, string strFuncCode, string strComparisonOp="")
	{
objPrjFunctionEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.FuncCode) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.FuncCode, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.FuncCode] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetUserId(this clsPrjFunctionEN objPrjFunctionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conPrjFunction.UserId);
}
objPrjFunctionEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.UserId) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.UserId, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.UserId] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetUpdDate(this clsPrjFunctionEN objPrjFunctionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjFunction.UpdDate);
}
objPrjFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.UpdDate) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.UpdDate, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.UpdDate] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetUpdUser(this clsPrjFunctionEN objPrjFunctionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjFunction.UpdUser);
}
objPrjFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.UpdUser) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.UpdUser, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.UpdUser] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFunctionEN SetMemo(this clsPrjFunctionEN objPrjFunctionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjFunction.Memo);
}
objPrjFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFunctionEN.dicFldComparisonOp.ContainsKey(conPrjFunction.Memo) == false)
{
objPrjFunctionEN.dicFldComparisonOp.Add(conPrjFunction.Memo, strComparisonOp);
}
else
{
objPrjFunctionEN.dicFldComparisonOp[conPrjFunction.Memo] = strComparisonOp;
}
}
return objPrjFunctionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjFunctionEN objPrjFunctionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjFunctionEN.CheckPropertyNew();
clsPrjFunctionEN objPrjFunctionCond = new clsPrjFunctionEN();
string strCondition = objPrjFunctionCond
.SetFuncId(objPrjFunctionEN.FuncId, "<>")
.SetFuncName(objPrjFunctionEN.FuncName, "=")
.SetPrjId(objPrjFunctionEN.PrjId, "=")
.GetCombineCondition();
objPrjFunctionEN._IsCheckProperty = true;
bool bolIsExist = clsPrjFunctionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(FuncName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjFunctionEN.Update();
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
 /// <param name = "objPrjFunction">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjFunctionEN objPrjFunction)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjFunctionEN objPrjFunctionCond = new clsPrjFunctionEN();
string strCondition = objPrjFunctionCond
.SetFuncName(objPrjFunction.FuncName, "=")
.SetPrjId(objPrjFunction.PrjId, "=")
.GetCombineCondition();
objPrjFunction._IsCheckProperty = true;
bool bolIsExist = clsPrjFunctionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjFunction.FuncId = clsPrjFunctionBL.GetFirstID_S(strCondition);
objPrjFunction.UpdateWithCondition(strCondition);
}
else
{
objPrjFunction.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFunctionEN objPrjFunctionEN)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFunctionBL.PrjFunctionDA.UpdateBySql2(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFunctionEN objPrjFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjFunctionBL.PrjFunctionDA.UpdateBySql2(objPrjFunctionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFunctionEN objPrjFunctionEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjFunctionBL.PrjFunctionDA.UpdateBySqlWithCondition(objPrjFunctionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFunctionEN objPrjFunctionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjFunctionBL.PrjFunctionDA.UpdateBySqlWithConditionTransaction(objPrjFunctionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjFunctionEN objPrjFunctionEN)
{
try
{
int intRecNum = clsPrjFunctionBL.PrjFunctionDA.DelRecord(objPrjFunctionEN.FuncId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionENS">源对象</param>
 /// <param name = "objPrjFunctionENT">目标对象</param>
 public static void CopyTo(this clsPrjFunctionEN objPrjFunctionENS, clsPrjFunctionEN objPrjFunctionENT)
{
try
{
objPrjFunctionENT.FuncId = objPrjFunctionENS.FuncId; //函数ID
objPrjFunctionENT.FuncName = objPrjFunctionENS.FuncName; //函数名
objPrjFunctionENT.PrjId = objPrjFunctionENS.PrjId; //工程Id
objPrjFunctionENT.ReturnTypeId = objPrjFunctionENS.ReturnTypeId; //返回类型ID
objPrjFunctionENT.FuncTypeId = objPrjFunctionENS.FuncTypeId; //函数类型Id
objPrjFunctionENT.IsTemplate = objPrjFunctionENS.IsTemplate; //是否模板
objPrjFunctionENT.FuncCode = objPrjFunctionENS.FuncCode; //函数代码
objPrjFunctionENT.UserId = objPrjFunctionENS.UserId; //用户Id
objPrjFunctionENT.UpdDate = objPrjFunctionENS.UpdDate; //修改日期
objPrjFunctionENT.UpdUser = objPrjFunctionENS.UpdUser; //修改者
objPrjFunctionENT.Memo = objPrjFunctionENS.Memo; //说明
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
 /// <param name = "objPrjFunctionENS">源对象</param>
 /// <returns>目标对象=>clsPrjFunctionEN:objPrjFunctionENT</returns>
 public static clsPrjFunctionEN CopyTo(this clsPrjFunctionEN objPrjFunctionENS)
{
try
{
 clsPrjFunctionEN objPrjFunctionENT = new clsPrjFunctionEN()
{
FuncId = objPrjFunctionENS.FuncId, //函数ID
FuncName = objPrjFunctionENS.FuncName, //函数名
PrjId = objPrjFunctionENS.PrjId, //工程Id
ReturnTypeId = objPrjFunctionENS.ReturnTypeId, //返回类型ID
FuncTypeId = objPrjFunctionENS.FuncTypeId, //函数类型Id
IsTemplate = objPrjFunctionENS.IsTemplate, //是否模板
FuncCode = objPrjFunctionENS.FuncCode, //函数代码
UserId = objPrjFunctionENS.UserId, //用户Id
UpdDate = objPrjFunctionENS.UpdDate, //修改日期
UpdUser = objPrjFunctionENS.UpdUser, //修改者
Memo = objPrjFunctionENS.Memo, //说明
};
 return objPrjFunctionENT;
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
public static void CheckPropertyNew(this clsPrjFunctionEN objPrjFunctionEN)
{
 clsPrjFunctionBL.PrjFunctionDA.CheckPropertyNew(objPrjFunctionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjFunctionEN objPrjFunctionEN)
{
 clsPrjFunctionBL.PrjFunctionDA.CheckProperty4Condition(objPrjFunctionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjFunctionEN objPrjFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjFunctionCond.IsUpdated(conPrjFunction.FuncId) == true)
{
string strComparisonOpFuncId = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.FuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.FuncId, objPrjFunctionCond.FuncId, strComparisonOpFuncId);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.FuncName) == true)
{
string strComparisonOpFuncName = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.FuncName, objPrjFunctionCond.FuncName, strComparisonOpFuncName);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.PrjId) == true)
{
string strComparisonOpPrjId = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.PrjId, objPrjFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.ReturnTypeId, objPrjFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.FuncTypeId, objPrjFunctionCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.IsTemplate) == true)
{
if (objPrjFunctionCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjFunction.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjFunction.IsTemplate);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objPrjFunctionCond.IsUpdated(conPrjFunction.UserId) == true)
{
string strComparisonOpUserId = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.UserId, objPrjFunctionCond.UserId, strComparisonOpUserId);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.UpdDate, objPrjFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.UpdUser, objPrjFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjFunctionCond.IsUpdated(conPrjFunction.Memo) == true)
{
string strComparisonOpMemo = objPrjFunctionCond.dicFldComparisonOp[conPrjFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFunction.Memo, objPrjFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjFunction(工程函数), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjFunctionEN objPrjFunctionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjFunctionEN == null) return true;
if (objPrjFunctionEN.FuncId == null || objPrjFunctionEN.FuncId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objPrjFunctionEN.FuncName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionEN.PrjId);
if (clsPrjFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncId !=  '{0}'", objPrjFunctionEN.FuncId);
 sbCondition.AppendFormat(" and FuncName = '{0}'", objPrjFunctionEN.FuncName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionEN.PrjId);
if (clsPrjFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjFunction(工程函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjFunctionEN objPrjFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjFunctionEN == null) return "";
if (objPrjFunctionEN.FuncId == null || objPrjFunctionEN.FuncId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objPrjFunctionEN.FuncName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncId !=  '{0}'", objPrjFunctionEN.FuncId);
 sbCondition.AppendFormat(" and FuncName = '{0}'", objPrjFunctionEN.FuncName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjFunction
{
public virtual bool UpdRelaTabDate(string strFuncId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程函数(PrjFunction)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjFunctionBL
{
public static RelatedActions_PrjFunction relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjFunctionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjFunctionDA PrjFunctionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjFunctionDA();
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
 public clsPrjFunctionBL()
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
if (string.IsNullOrEmpty(clsPrjFunctionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFunctionEN._ConnectString);
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
public static DataTable GetDataTable_PrjFunction(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjFunctionDA.GetDataTable_PrjFunction(strWhereCond);
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
objDT = PrjFunctionDA.GetDataTable(strWhereCond);
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
objDT = PrjFunctionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjFunctionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjFunctionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjFunctionDA.GetDataTable_Top(objTopPara);
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
objDT = PrjFunctionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjFunctionEN> GetObjLstByFuncIdLst(List<string> arrFuncIdLst)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncIdLst, true);
 string strWhereCond = string.Format("FuncId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjFunctionEN> GetObjLstByFuncIdLstCache(List<string> arrFuncIdLst)
{
string strKey = string.Format("{0}", clsPrjFunctionEN._CurrTabName);
List<clsPrjFunctionEN> arrPrjFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFunctionEN> arrPrjFunctionObjLst_Sel =
arrPrjFunctionObjLstCache
.Where(x => arrFuncIdLst.Contains(x.FuncId));
return arrPrjFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFunctionEN> GetObjLst(string strWhereCond)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
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
public static List<clsPrjFunctionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjFunctionEN> GetSubObjLstCache(clsPrjFunctionEN objPrjFunctionCond)
{
List<clsPrjFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFunction._AttributeName)
{
if (objPrjFunctionCond.IsUpdated(strFldName) == false) continue;
if (objPrjFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFunctionCond[strFldName].ToString());
}
else
{
if (objPrjFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFunctionCond[strFldName]));
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
public static List<clsPrjFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
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
public static List<clsPrjFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
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
List<clsPrjFunctionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjFunctionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFunctionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
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
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
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
public static List<clsPrjFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
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
public static List<clsPrjFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFunctionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjFunctionEN> arrObjLst = new List<clsPrjFunctionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN();
try
{
objPrjFunctionEN.FuncId = objRow[conPrjFunction.FuncId].ToString().Trim(); //函数ID
objPrjFunctionEN.FuncName = objRow[conPrjFunction.FuncName].ToString().Trim(); //函数名
objPrjFunctionEN.PrjId = objRow[conPrjFunction.PrjId].ToString().Trim(); //工程Id
objPrjFunctionEN.ReturnTypeId = objRow[conPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objPrjFunctionEN.FuncTypeId = objRow[conPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objPrjFunctionEN.FuncCode = objRow[conPrjFunction.FuncCode] == DBNull.Value ? null : objRow[conPrjFunction.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionEN.UserId = objRow[conPrjFunction.UserId] == DBNull.Value ? null : objRow[conPrjFunction.UserId].ToString().Trim(); //用户Id
objPrjFunctionEN.UpdDate = objRow[conPrjFunction.UpdDate] == DBNull.Value ? null : objRow[conPrjFunction.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionEN.UpdUser = objRow[conPrjFunction.UpdUser] == DBNull.Value ? null : objRow[conPrjFunction.UpdUser].ToString().Trim(); //修改者
objPrjFunctionEN.Memo = objRow[conPrjFunction.Memo] == DBNull.Value ? null : objRow[conPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjFunctionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjFunctionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjFunction(ref clsPrjFunctionEN objPrjFunctionEN)
{
bool bolResult = PrjFunctionDA.GetPrjFunction(ref objPrjFunctionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFunctionEN GetObjByFuncId(string strFuncId)
{
if (strFuncId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjFunctionEN objPrjFunctionEN = PrjFunctionDA.GetObjByFuncId(strFuncId);
return objPrjFunctionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjFunctionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjFunctionEN objPrjFunctionEN = PrjFunctionDA.GetFirstObj(strWhereCond);
 return objPrjFunctionEN;
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
public static clsPrjFunctionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjFunctionEN objPrjFunctionEN = PrjFunctionDA.GetObjByDataRow(objRow);
 return objPrjFunctionEN;
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
public static clsPrjFunctionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjFunctionEN objPrjFunctionEN = PrjFunctionDA.GetObjByDataRow(objRow);
 return objPrjFunctionEN;
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
 /// <param name = "strFuncId">所给的关键字</param>
 /// <param name = "lstPrjFunctionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFunctionEN GetObjByFuncIdFromList(string strFuncId, List<clsPrjFunctionEN> lstPrjFunctionObjLst)
{
foreach (clsPrjFunctionEN objPrjFunctionEN in lstPrjFunctionObjLst)
{
if (objPrjFunctionEN.FuncId == strFuncId)
{
return objPrjFunctionEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxFuncId;
 try
 {
 strMaxFuncId = new clsPrjFunctionDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxFuncId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strFuncId;
 try
 {
 strFuncId = new clsPrjFunctionDA().GetFirstID(strWhereCond);
 return strFuncId;
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
 arrList = PrjFunctionDA.GetID(strWhereCond);
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
bool bolIsExist = PrjFunctionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjFunctionDA.IsExist(strFuncId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFuncId">函数ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFuncId, string strOpUser)
{
clsPrjFunctionEN objPrjFunctionEN = clsPrjFunctionBL.GetObjByFuncId(strFuncId);
objPrjFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjFunctionEN.UpdUser = strOpUser;
return clsPrjFunctionBL.UpdateBySql2(objPrjFunctionEN);
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
 bolIsExist = clsPrjFunctionDA.IsExistTable();
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
 bolIsExist = PrjFunctionDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjFunctionEN.FuncId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjFunctionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjFunctionBL.AddNewRecordBySql2)", objPrjFunctionEN.FuncName,objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PrjFunctionDA.AddNewRecordBySQL2(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjFunctionEN objPrjFunctionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjFunctionBL.IsExist(objPrjFunctionEN.FuncId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjFunctionEN.FuncId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjFunctionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjFunctionBL.AddNewRecordBySql2WithReturnKey)", objPrjFunctionEN.FuncName,objPrjFunctionEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = PrjFunctionDA.AddNewRecordBySQL2WithReturnKey(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjFunctionEN objPrjFunctionEN)
{
try
{
bool bolResult = PrjFunctionDA.Update(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "objPrjFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjFunctionEN objPrjFunctionEN)
{
 if (string.IsNullOrEmpty(objPrjFunctionEN.FuncId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjFunctionDA.UpdateBySql2(objPrjFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFunctionBL.ReFreshCache();

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
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
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFuncId)
{
try
{
 clsPrjFunctionEN objPrjFunctionEN = clsPrjFunctionBL.GetObjByFuncId(strFuncId);

if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(objPrjFunctionEN.FuncId, objPrjFunctionEN.UpdUser);
}
if (objPrjFunctionEN != null)
{
int intRecNum = PrjFunctionDA.DelRecord(strFuncId);
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
/// <param name="strFuncId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFuncId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
//删除与表:[PrjFunction]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjFunction.FuncId,
//strFuncId);
//        clsPrjFunctionBL.DelPrjFunctionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFunctionBL.DelRecord(strFuncId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFunctionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFuncId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjFunctionBL.relatedActions != null)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(strFuncId, "UpdRelaTabDate");
}
bool bolResult = PrjFunctionDA.DelRecord(strFuncId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFuncIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjFunctions(List<string> arrFuncIdLst)
{
if (arrFuncIdLst.Count == 0) return 0;
try
{
if (clsPrjFunctionBL.relatedActions != null)
{
foreach (var strFuncId in arrFuncIdLst)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(strFuncId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjFunctionDA.DelPrjFunction(arrFuncIdLst);
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
public static int DelPrjFunctionsByCond(string strWhereCond)
{
try
{
if (clsPrjFunctionBL.relatedActions != null)
{
List<string> arrFuncId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFuncId in arrFuncId)
{
clsPrjFunctionBL.relatedActions.UpdRelaTabDate(strFuncId, "UpdRelaTabDate");
}
}
int intRecNum = PrjFunctionDA.DelPrjFunction(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjFunction]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFuncId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFuncId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjFunctionDA.GetSpecSQLObj();
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
//删除与表:[PrjFunction]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjFunctionBL.DelRecord(strFuncId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjFunctionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFuncId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjFunctionENS">源对象</param>
 /// <param name = "objPrjFunctionENT">目标对象</param>
 public static void CopyTo(clsPrjFunctionEN objPrjFunctionENS, clsPrjFunctionEN objPrjFunctionENT)
{
try
{
objPrjFunctionENT.FuncId = objPrjFunctionENS.FuncId; //函数ID
objPrjFunctionENT.FuncName = objPrjFunctionENS.FuncName; //函数名
objPrjFunctionENT.PrjId = objPrjFunctionENS.PrjId; //工程Id
objPrjFunctionENT.ReturnTypeId = objPrjFunctionENS.ReturnTypeId; //返回类型ID
objPrjFunctionENT.FuncTypeId = objPrjFunctionENS.FuncTypeId; //函数类型Id
objPrjFunctionENT.IsTemplate = objPrjFunctionENS.IsTemplate; //是否模板
objPrjFunctionENT.FuncCode = objPrjFunctionENS.FuncCode; //函数代码
objPrjFunctionENT.UserId = objPrjFunctionENS.UserId; //用户Id
objPrjFunctionENT.UpdDate = objPrjFunctionENS.UpdDate; //修改日期
objPrjFunctionENT.UpdUser = objPrjFunctionENS.UpdUser; //修改者
objPrjFunctionENT.Memo = objPrjFunctionENS.Memo; //说明
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
 /// <param name = "objPrjFunctionEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjFunctionEN objPrjFunctionEN)
{
try
{
objPrjFunctionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjFunctionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjFunction.FuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.FuncId = objPrjFunctionEN.FuncId; //函数ID
}
if (arrFldSet.Contains(conPrjFunction.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.FuncName = objPrjFunctionEN.FuncName; //函数名
}
if (arrFldSet.Contains(conPrjFunction.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.PrjId = objPrjFunctionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjFunction.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.ReturnTypeId = objPrjFunctionEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(conPrjFunction.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.FuncTypeId = objPrjFunctionEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(conPrjFunction.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.IsTemplate = objPrjFunctionEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(conPrjFunction.FuncCode, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.FuncCode = objPrjFunctionEN.FuncCode == "[null]" ? null :  objPrjFunctionEN.FuncCode; //函数代码
}
if (arrFldSet.Contains(conPrjFunction.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.UserId = objPrjFunctionEN.UserId == "[null]" ? null :  objPrjFunctionEN.UserId; //用户Id
}
if (arrFldSet.Contains(conPrjFunction.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.UpdDate = objPrjFunctionEN.UpdDate == "[null]" ? null :  objPrjFunctionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjFunction.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.UpdUser = objPrjFunctionEN.UpdUser == "[null]" ? null :  objPrjFunctionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conPrjFunction.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjFunctionEN.Memo = objPrjFunctionEN.Memo == "[null]" ? null :  objPrjFunctionEN.Memo; //说明
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
 /// <param name = "objPrjFunctionEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjFunctionEN objPrjFunctionEN)
{
try
{
if (objPrjFunctionEN.FuncCode == "[null]") objPrjFunctionEN.FuncCode = null; //函数代码
if (objPrjFunctionEN.UserId == "[null]") objPrjFunctionEN.UserId = null; //用户Id
if (objPrjFunctionEN.UpdDate == "[null]") objPrjFunctionEN.UpdDate = null; //修改日期
if (objPrjFunctionEN.UpdUser == "[null]") objPrjFunctionEN.UpdUser = null; //修改者
if (objPrjFunctionEN.Memo == "[null]") objPrjFunctionEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjFunctionEN objPrjFunctionEN)
{
 PrjFunctionDA.CheckPropertyNew(objPrjFunctionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjFunctionEN objPrjFunctionEN)
{
 PrjFunctionDA.CheckProperty4Condition(objPrjFunctionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjFunction.FuncId); 
List<clsPrjFunctionEN> arrObjLst = clsPrjFunctionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjFunctionEN objPrjFunctionEN = new clsPrjFunctionEN()
{
FuncId = "0",
FuncName = "选[工程函数]..."
};
arrObjLst.Insert(0, objPrjFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjFunction.FuncId;
objComboBox.DisplayMember = conPrjFunction.FuncName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程函数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjFunction.FuncId); 
IEnumerable<clsPrjFunctionEN> arrObjLst = clsPrjFunctionBL.GetObjLst(strCondition);
objDDL.DataValueField = conPrjFunction.FuncId;
objDDL.DataTextField = conPrjFunction.FuncName;
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
public static void BindDdl_FuncIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程函数]...","0");
List<clsPrjFunctionEN> arrPrjFunctionObjLst = GetAllPrjFunctionObjLstCache(); 
objDDL.DataValueField = conPrjFunction.FuncId;
objDDL.DataTextField = conPrjFunction.FuncName;
objDDL.DataSource = arrPrjFunctionObjLst;
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
if (clsPrjFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFunctionBL没有刷新缓存机制(clsPrjFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId");
//if (arrPrjFunctionObjLstCache == null)
//{
//arrPrjFunctionObjLstCache = PrjFunctionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFunctionEN GetObjByFuncIdCache(string strFuncId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjFunctionEN._CurrTabName);
List<clsPrjFunctionEN> arrPrjFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFunctionEN> arrPrjFunctionObjLst_Sel =
arrPrjFunctionObjLstCache
.Where(x=> x.FuncId == strFuncId 
);
if (arrPrjFunctionObjLst_Sel.Count() == 0)
{
   clsPrjFunctionEN obj = clsPrjFunctionBL.GetObjByFuncId(strFuncId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncNameByFuncIdCache(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true) return "";
//获取缓存中的对象列表
clsPrjFunctionEN objPrjFunction = GetObjByFuncIdCache(strFuncId);
if (objPrjFunction == null) return "";
return objPrjFunction.FuncName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncIdCache(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true) return "";
//获取缓存中的对象列表
clsPrjFunctionEN objPrjFunction = GetObjByFuncIdCache(strFuncId);
if (objPrjFunction == null) return "";
return objPrjFunction.FuncName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFunctionEN> GetAllPrjFunctionObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjFunctionEN> arrPrjFunctionObjLstCache = GetObjLstCache(); 
return arrPrjFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFunctionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjFunctionEN._CurrTabName);
List<clsPrjFunctionEN> arrPrjFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjFunctionObjLstCache;
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
string strKey = string.Format("{0}", clsPrjFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjFunctionEN._RefreshTimeLst.Count == 0) return "";
return clsPrjFunctionEN._RefreshTimeLst[clsPrjFunctionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{

if (clsPrjFunctionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjFunctionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjFunction(工程函数)
 /// 唯一性条件:FuncName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjFunctionEN objPrjFunctionEN)
{
//检测记录是否存在
string strResult = PrjFunctionDA.GetUniCondStr(objPrjFunctionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strFuncId)
{
if (strInFldName != conPrjFunction.FuncId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjFunction._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjFunction._AttributeName));
throw new Exception(strMsg);
}
var objPrjFunction = clsPrjFunctionBL.GetObjByFuncIdCache(strFuncId);
if (objPrjFunction == null) return "";
return objPrjFunction[strOutFldName].ToString();
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
int intRecCount = clsPrjFunctionDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjFunctionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjFunctionDA.GetRecCount();
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
int intRecCount = clsPrjFunctionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjFunctionEN objPrjFunctionCond)
{
List<clsPrjFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjFunction._AttributeName)
{
if (objPrjFunctionCond.IsUpdated(strFldName) == false) continue;
if (objPrjFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFunctionCond[strFldName].ToString());
}
else
{
if (objPrjFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjFunctionCond[strFldName]));
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
 List<string> arrList = clsPrjFunctionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjFunctionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjFunctionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjFunctionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFunctionDA.SetFldValue(clsPrjFunctionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjFunctionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFunctionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjFunctionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjFunctionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjFunction] "); 
 strCreateTabCode.Append(" ( "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId varchar(10) primary key, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**返回类型ID*/ 
 strCreateTabCode.Append(" ReturnTypeId char(2) not Null, "); 
 // /**函数类型Id*/ 
 strCreateTabCode.Append(" FuncTypeId char(2) not Null, "); 
 // /**是否模板*/ 
 strCreateTabCode.Append(" IsTemplate bit not Null, "); 
 // /**函数代码*/ 
 strCreateTabCode.Append(" FuncCode text Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
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
 /// 工程函数(PrjFunction)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjFunction : clsCommFun4BL
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
clsPrjFunctionBL.ReFreshThisCache();
}
}

}