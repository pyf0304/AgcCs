
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjCasesBL
 表名:PrjCases(00050071)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:30:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
public static class  clsPrjCasesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjCasesEN GetObj(this K_CaseId_PrjCases myKey)
{
clsPrjCasesEN objPrjCasesEN = clsPrjCasesBL.PrjCasesDA.GetObjByCaseId(myKey.Value);
return objPrjCasesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjCasesEN.CaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjCasesEN) == false)
{
var strMsg = string.Format("记录已经存在!CaseName = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjCasesBL.AddNewRecord)", objPrjCasesEN.CaseName,objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPrjCasesBL.PrjCasesDA.AddNewRecordBySQL2(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
public static bool AddRecordEx(this clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPrjCasesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjCasesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(CaseName(CaseName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objPrjCasesEN.CaseName, objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPrjCasesEN.AddNewRecord();
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjCasesEN) == false)
{
var strMsg = string.Format("记录已经存在!CaseName = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjCasesBL.AddNewRecordWithMaxId)", objPrjCasesEN.CaseName,objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true || clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId) == true)
 {
     objPrjCasesEN.CaseId = clsPrjCasesBL.GetMaxStrIdByPrefix_S(objPrjCasesEN.PrjId);
 }
string strCaseId = clsPrjCasesBL.PrjCasesDA.AddNewRecordBySQL2WithReturnKey(objPrjCasesEN);
     objPrjCasesEN.CaseId = strCaseId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
}
return strCaseId;
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjCasesEN.CaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjCasesEN) == false)
{
var strMsg = string.Format("记录已经存在!CaseName = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjCasesBL.AddNewRecordWithReturnKey)", objPrjCasesEN.CaseName,objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPrjCasesBL.PrjCasesDA.AddNewRecordBySQL2WithReturnKey(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetCaseId(this clsPrjCasesEN objPrjCasesEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conPrjCases.CaseId);
}
objPrjCasesEN.CaseId = strCaseId; //CaseId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.CaseId) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.CaseId, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.CaseId] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetCaseName(this clsPrjCasesEN objPrjCasesEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conPrjCases.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 20, conPrjCases.CaseName);
}
objPrjCasesEN.CaseName = strCaseName; //CaseName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.CaseName) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.CaseName, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.CaseName] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetPrjId(this clsPrjCasesEN objPrjCasesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjCases.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjCases.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjCases.PrjId);
}
objPrjCasesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.PrjId) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.PrjId, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.PrjId] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetCaseContent(this clsPrjCasesEN objPrjCasesEN, string strCaseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseContent, conPrjCases.CaseContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseContent, 1000, conPrjCases.CaseContent);
}
objPrjCasesEN.CaseContent = strCaseContent; //CaseContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.CaseContent) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.CaseContent, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.CaseContent] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetCaseTypeId(this clsPrjCasesEN objPrjCasesEN, string strCaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseTypeId, conPrjCases.CaseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeId, 4, conPrjCases.CaseTypeId);
}
objPrjCasesEN.CaseTypeId = strCaseTypeId; //CaseTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.CaseTypeId) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.CaseTypeId, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.CaseTypeId] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetImportLevelId(this clsPrjCasesEN objPrjCasesEN, string strImportLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImportLevelId, 4, conPrjCases.ImportLevelId);
}
objPrjCasesEN.ImportLevelId = strImportLevelId; //重要程度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.ImportLevelId) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.ImportLevelId, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.ImportLevelId] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetUserId(this clsPrjCasesEN objPrjCasesEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conPrjCases.UserId);
}
objPrjCasesEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.UserId) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.UserId, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.UserId] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetUpdDate(this clsPrjCasesEN objPrjCasesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjCases.UpdDate);
}
objPrjCasesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.UpdDate) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.UpdDate, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.UpdDate] = strComparisonOp;
}
}
return objPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjCasesEN SetMemo(this clsPrjCasesEN objPrjCasesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjCases.Memo);
}
objPrjCasesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjCasesEN.dicFldComparisonOp.ContainsKey(conPrjCases.Memo) == false)
{
objPrjCasesEN.dicFldComparisonOp.Add(conPrjCases.Memo, strComparisonOp);
}
else
{
objPrjCasesEN.dicFldComparisonOp[conPrjCases.Memo] = strComparisonOp;
}
}
return objPrjCasesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjCasesEN objPrjCasesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjCasesEN.CheckPropertyNew();
clsPrjCasesEN objPrjCasesCond = new clsPrjCasesEN();
string strCondition = objPrjCasesCond
.SetCaseId(objPrjCasesEN.CaseId, "<>")
.SetCaseName(objPrjCasesEN.CaseName, "=")
.SetPrjId(objPrjCasesEN.PrjId, "=")
.GetCombineCondition();
objPrjCasesEN._IsCheckProperty = true;
bool bolIsExist = clsPrjCasesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjCasesEN.Update();
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
 /// <param name = "objPrjCases">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjCasesEN objPrjCases)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjCasesEN objPrjCasesCond = new clsPrjCasesEN();
string strCondition = objPrjCasesCond
.SetCaseName(objPrjCases.CaseName, "=")
.SetPrjId(objPrjCases.PrjId, "=")
.GetCombineCondition();
objPrjCases._IsCheckProperty = true;
bool bolIsExist = clsPrjCasesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjCases.CaseId = clsPrjCasesBL.GetFirstID_S(strCondition);
objPrjCases.UpdateWithCondition(strCondition);
}
else
{
objPrjCases.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjCasesEN objPrjCasesEN)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjCasesBL.PrjCasesDA.UpdateBySql2(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjCasesEN objPrjCasesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjCasesBL.PrjCasesDA.UpdateBySql2(objPrjCasesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjCasesEN objPrjCasesEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjCasesBL.PrjCasesDA.UpdateBySqlWithCondition(objPrjCasesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjCasesEN objPrjCasesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjCasesBL.PrjCasesDA.UpdateBySqlWithConditionTransaction(objPrjCasesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPrjCasesEN objPrjCasesEN)
{
try
{
int intRecNum = clsPrjCasesBL.PrjCasesDA.DelRecord(objPrjCasesEN.CaseId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesENS">源对象</param>
 /// <param name = "objPrjCasesENT">目标对象</param>
 public static void CopyTo(this clsPrjCasesEN objPrjCasesENS, clsPrjCasesEN objPrjCasesENT)
{
try
{
objPrjCasesENT.CaseId = objPrjCasesENS.CaseId; //CaseId
objPrjCasesENT.CaseName = objPrjCasesENS.CaseName; //CaseName
objPrjCasesENT.PrjId = objPrjCasesENS.PrjId; //工程Id
objPrjCasesENT.CaseContent = objPrjCasesENS.CaseContent; //CaseContent
objPrjCasesENT.CaseTypeId = objPrjCasesENS.CaseTypeId; //CaseTypeId
objPrjCasesENT.ImportLevelId = objPrjCasesENS.ImportLevelId; //重要程度Id
objPrjCasesENT.UserId = objPrjCasesENS.UserId; //用户Id
objPrjCasesENT.UpdDate = objPrjCasesENS.UpdDate; //修改日期
objPrjCasesENT.Memo = objPrjCasesENS.Memo; //说明
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
 /// <param name = "objPrjCasesENS">源对象</param>
 /// <returns>目标对象=>clsPrjCasesEN:objPrjCasesENT</returns>
 public static clsPrjCasesEN CopyTo(this clsPrjCasesEN objPrjCasesENS)
{
try
{
 clsPrjCasesEN objPrjCasesENT = new clsPrjCasesEN()
{
CaseId = objPrjCasesENS.CaseId, //CaseId
CaseName = objPrjCasesENS.CaseName, //CaseName
PrjId = objPrjCasesENS.PrjId, //工程Id
CaseContent = objPrjCasesENS.CaseContent, //CaseContent
CaseTypeId = objPrjCasesENS.CaseTypeId, //CaseTypeId
ImportLevelId = objPrjCasesENS.ImportLevelId, //重要程度Id
UserId = objPrjCasesENS.UserId, //用户Id
UpdDate = objPrjCasesENS.UpdDate, //修改日期
Memo = objPrjCasesENS.Memo, //说明
};
 return objPrjCasesENT;
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
public static void CheckPropertyNew(this clsPrjCasesEN objPrjCasesEN)
{
 clsPrjCasesBL.PrjCasesDA.CheckPropertyNew(objPrjCasesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjCasesEN objPrjCasesEN)
{
 clsPrjCasesBL.PrjCasesDA.CheckProperty4Condition(objPrjCasesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjCasesEN objPrjCasesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjCasesCond.IsUpdated(conPrjCases.CaseId) == true)
{
string strComparisonOpCaseId = objPrjCasesCond.dicFldComparisonOp[conPrjCases.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.CaseId, objPrjCasesCond.CaseId, strComparisonOpCaseId);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.CaseName) == true)
{
string strComparisonOpCaseName = objPrjCasesCond.dicFldComparisonOp[conPrjCases.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.CaseName, objPrjCasesCond.CaseName, strComparisonOpCaseName);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.PrjId) == true)
{
string strComparisonOpPrjId = objPrjCasesCond.dicFldComparisonOp[conPrjCases.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.PrjId, objPrjCasesCond.PrjId, strComparisonOpPrjId);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.CaseContent) == true)
{
string strComparisonOpCaseContent = objPrjCasesCond.dicFldComparisonOp[conPrjCases.CaseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.CaseContent, objPrjCasesCond.CaseContent, strComparisonOpCaseContent);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.CaseTypeId) == true)
{
string strComparisonOpCaseTypeId = objPrjCasesCond.dicFldComparisonOp[conPrjCases.CaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.CaseTypeId, objPrjCasesCond.CaseTypeId, strComparisonOpCaseTypeId);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.ImportLevelId) == true)
{
string strComparisonOpImportLevelId = objPrjCasesCond.dicFldComparisonOp[conPrjCases.ImportLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.ImportLevelId, objPrjCasesCond.ImportLevelId, strComparisonOpImportLevelId);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.UserId) == true)
{
string strComparisonOpUserId = objPrjCasesCond.dicFldComparisonOp[conPrjCases.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.UserId, objPrjCasesCond.UserId, strComparisonOpUserId);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjCasesCond.dicFldComparisonOp[conPrjCases.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.UpdDate, objPrjCasesCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjCasesCond.IsUpdated(conPrjCases.Memo) == true)
{
string strComparisonOpMemo = objPrjCasesCond.dicFldComparisonOp[conPrjCases.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjCases.Memo, objPrjCasesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjCases(工程用例), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjCasesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjCasesEN objPrjCasesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjCasesEN == null) return true;
if (objPrjCasesEN.CaseId == null || objPrjCasesEN.CaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseName = '{0}'", objPrjCasesEN.CaseName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjCasesEN.PrjId);
if (clsPrjCasesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CaseId !=  '{0}'", objPrjCasesEN.CaseId);
 sbCondition.AppendFormat(" and CaseName = '{0}'", objPrjCasesEN.CaseName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjCasesEN.PrjId);
if (clsPrjCasesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjCases(工程用例), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjCasesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjCasesEN objPrjCasesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjCasesEN == null) return "";
if (objPrjCasesEN.CaseId == null || objPrjCasesEN.CaseId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseName = '{0}'", objPrjCasesEN.CaseName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjCasesEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CaseId !=  '{0}'", objPrjCasesEN.CaseId);
 sbCondition.AppendFormat(" and CaseName = '{0}'", objPrjCasesEN.CaseName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjCasesEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjCases
{
public virtual bool UpdRelaTabDate(string strCaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程用例(PrjCases)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjCasesBL
{
public static RelatedActions_PrjCases relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjCasesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjCasesDA PrjCasesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjCasesDA();
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
 public clsPrjCasesBL()
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
if (string.IsNullOrEmpty(clsPrjCasesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjCasesEN._ConnectString);
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
public static DataTable GetDataTable_PrjCases(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjCasesDA.GetDataTable_PrjCases(strWhereCond);
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
objDT = PrjCasesDA.GetDataTable(strWhereCond);
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
objDT = PrjCasesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjCasesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjCasesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjCasesDA.GetDataTable_Top(objTopPara);
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
objDT = PrjCasesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjCasesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjCasesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPrjCasesEN> GetObjLstByCaseIdLst(List<string> arrCaseIdLst)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCaseIdLst, true);
 string strWhereCond = string.Format("CaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjCasesEN> GetObjLstByCaseIdLstCache(List<string> arrCaseIdLst)
{
string strKey = string.Format("{0}", clsPrjCasesEN._CurrTabName);
List<clsPrjCasesEN> arrPrjCasesObjLstCache = GetObjLstCache();
IEnumerable <clsPrjCasesEN> arrPrjCasesObjLst_Sel =
arrPrjCasesObjLstCache
.Where(x => arrCaseIdLst.Contains(x.CaseId));
return arrPrjCasesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjCasesEN> GetObjLst(string strWhereCond)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
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
public static List<clsPrjCasesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjCasesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjCasesEN> GetSubObjLstCache(clsPrjCasesEN objPrjCasesCond)
{
List<clsPrjCasesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjCasesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjCases._AttributeName)
{
if (objPrjCasesCond.IsUpdated(strFldName) == false) continue;
if (objPrjCasesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjCasesCond[strFldName].ToString());
}
else
{
if (objPrjCasesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjCasesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjCasesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjCasesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjCasesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjCasesCond[strFldName]));
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
public static List<clsPrjCasesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
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
public static List<clsPrjCasesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
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
List<clsPrjCasesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjCasesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjCasesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjCasesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
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
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
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
public static List<clsPrjCasesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjCasesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjCasesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
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
public static List<clsPrjCasesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjCasesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjCasesEN> arrObjLst = new List<clsPrjCasesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN();
try
{
objPrjCasesEN.CaseId = objRow[conPrjCases.CaseId].ToString().Trim(); //CaseId
objPrjCasesEN.CaseName = objRow[conPrjCases.CaseName].ToString().Trim(); //CaseName
objPrjCasesEN.PrjId = objRow[conPrjCases.PrjId].ToString().Trim(); //工程Id
objPrjCasesEN.CaseContent = objRow[conPrjCases.CaseContent].ToString().Trim(); //CaseContent
objPrjCasesEN.CaseTypeId = objRow[conPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objPrjCasesEN.ImportLevelId = objRow[conPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[conPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objPrjCasesEN.UserId = objRow[conPrjCases.UserId] == DBNull.Value ? null : objRow[conPrjCases.UserId].ToString().Trim(); //用户Id
objPrjCasesEN.UpdDate = objRow[conPrjCases.UpdDate] == DBNull.Value ? null : objRow[conPrjCases.UpdDate].ToString().Trim(); //修改日期
objPrjCasesEN.Memo = objRow[conPrjCases.Memo] == DBNull.Value ? null : objRow[conPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjCasesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjCasesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjCases(ref clsPrjCasesEN objPrjCasesEN)
{
bool bolResult = PrjCasesDA.GetPrjCases(ref objPrjCasesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjCasesEN GetObjByCaseId(string strCaseId)
{
if (strCaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPrjCasesEN objPrjCasesEN = PrjCasesDA.GetObjByCaseId(strCaseId);
return objPrjCasesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjCasesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjCasesEN objPrjCasesEN = PrjCasesDA.GetFirstObj(strWhereCond);
 return objPrjCasesEN;
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
public static clsPrjCasesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjCasesEN objPrjCasesEN = PrjCasesDA.GetObjByDataRow(objRow);
 return objPrjCasesEN;
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
public static clsPrjCasesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjCasesEN objPrjCasesEN = PrjCasesDA.GetObjByDataRow(objRow);
 return objPrjCasesEN;
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
 /// <param name = "strCaseId">所给的关键字</param>
 /// <param name = "lstPrjCasesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjCasesEN GetObjByCaseIdFromList(string strCaseId, List<clsPrjCasesEN> lstPrjCasesObjLst)
{
foreach (clsPrjCasesEN objPrjCasesEN in lstPrjCasesObjLst)
{
if (objPrjCasesEN.CaseId == strCaseId)
{
return objPrjCasesEN;
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
 string strMaxCaseId;
 try
 {
 strMaxCaseId = new clsPrjCasesDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxCaseId;
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
 string strCaseId;
 try
 {
 strCaseId = new clsPrjCasesDA().GetFirstID(strWhereCond);
 return strCaseId;
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
 arrList = PrjCasesDA.GetID(strWhereCond);
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
bool bolIsExist = PrjCasesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCaseId)
{
if (string.IsNullOrEmpty(strCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PrjCasesDA.IsExist(strCaseId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strCaseId">CaseId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strCaseId, string strOpUser)
{
clsPrjCasesEN objPrjCasesEN = clsPrjCasesBL.GetObjByCaseId(strCaseId);
objPrjCasesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsPrjCasesBL.UpdateBySql2(objPrjCasesEN);
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
 bolIsExist = clsPrjCasesDA.IsExistTable();
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
 bolIsExist = PrjCasesDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjCasesEN.CaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjCasesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CaseName = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjCasesBL.AddNewRecordBySql2)", objPrjCasesEN.CaseName,objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PrjCasesDA.AddNewRecordBySQL2(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjCasesEN objPrjCasesEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjCasesBL.IsExist(objPrjCasesEN.CaseId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjCasesEN.CaseId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjCasesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!CaseName = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjCasesBL.AddNewRecordBySql2WithReturnKey)", objPrjCasesEN.CaseName,objPrjCasesEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = PrjCasesDA.AddNewRecordBySQL2WithReturnKey(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjCasesEN objPrjCasesEN)
{
try
{
bool bolResult = PrjCasesDA.Update(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "objPrjCasesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjCasesEN objPrjCasesEN)
{
 if (string.IsNullOrEmpty(objPrjCasesEN.CaseId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjCasesDA.UpdateBySql2(objPrjCasesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjCasesBL.ReFreshCache();

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCaseId)
{
try
{
 clsPrjCasesEN objPrjCasesEN = clsPrjCasesBL.GetObjByCaseId(strCaseId);

if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(objPrjCasesEN.CaseId, "SetUpdDate");
}
if (objPrjCasesEN != null)
{
int intRecNum = PrjCasesDA.DelRecord(strCaseId);
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
/// <param name="strCaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCaseId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
//删除与表:[PrjCases]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjCases.CaseId,
//strCaseId);
//        clsPrjCasesBL.DelPrjCasessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjCasesBL.DelRecord(strCaseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjCasesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCaseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjCasesBL.relatedActions != null)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(strCaseId, "UpdRelaTabDate");
}
bool bolResult = PrjCasesDA.DelRecord(strCaseId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCaseIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjCasess(List<string> arrCaseIdLst)
{
if (arrCaseIdLst.Count == 0) return 0;
try
{
if (clsPrjCasesBL.relatedActions != null)
{
foreach (var strCaseId in arrCaseIdLst)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(strCaseId, "UpdRelaTabDate");
}
}
int intDelRecNum = PrjCasesDA.DelPrjCases(arrCaseIdLst);
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
public static int DelPrjCasessByCond(string strWhereCond)
{
try
{
if (clsPrjCasesBL.relatedActions != null)
{
List<string> arrCaseId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCaseId in arrCaseId)
{
clsPrjCasesBL.relatedActions.UpdRelaTabDate(strCaseId, "UpdRelaTabDate");
}
}
int intRecNum = PrjCasesDA.DelPrjCases(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjCases]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCaseId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCaseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjCasesDA.GetSpecSQLObj();
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
//删除与表:[PrjCases]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjCasesBL.DelRecord(strCaseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjCasesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCaseId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPrjCasesENS">源对象</param>
 /// <param name = "objPrjCasesENT">目标对象</param>
 public static void CopyTo(clsPrjCasesEN objPrjCasesENS, clsPrjCasesEN objPrjCasesENT)
{
try
{
objPrjCasesENT.CaseId = objPrjCasesENS.CaseId; //CaseId
objPrjCasesENT.CaseName = objPrjCasesENS.CaseName; //CaseName
objPrjCasesENT.PrjId = objPrjCasesENS.PrjId; //工程Id
objPrjCasesENT.CaseContent = objPrjCasesENS.CaseContent; //CaseContent
objPrjCasesENT.CaseTypeId = objPrjCasesENS.CaseTypeId; //CaseTypeId
objPrjCasesENT.ImportLevelId = objPrjCasesENS.ImportLevelId; //重要程度Id
objPrjCasesENT.UserId = objPrjCasesENS.UserId; //用户Id
objPrjCasesENT.UpdDate = objPrjCasesENS.UpdDate; //修改日期
objPrjCasesENT.Memo = objPrjCasesENS.Memo; //说明
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
 /// <param name = "objPrjCasesEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjCasesEN objPrjCasesEN)
{
try
{
objPrjCasesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjCasesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjCases.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.CaseId = objPrjCasesEN.CaseId; //CaseId
}
if (arrFldSet.Contains(conPrjCases.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.CaseName = objPrjCasesEN.CaseName; //CaseName
}
if (arrFldSet.Contains(conPrjCases.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.PrjId = objPrjCasesEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjCases.CaseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.CaseContent = objPrjCasesEN.CaseContent; //CaseContent
}
if (arrFldSet.Contains(conPrjCases.CaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.CaseTypeId = objPrjCasesEN.CaseTypeId; //CaseTypeId
}
if (arrFldSet.Contains(conPrjCases.ImportLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.ImportLevelId = objPrjCasesEN.ImportLevelId == "[null]" ? null :  objPrjCasesEN.ImportLevelId; //重要程度Id
}
if (arrFldSet.Contains(conPrjCases.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.UserId = objPrjCasesEN.UserId == "[null]" ? null :  objPrjCasesEN.UserId; //用户Id
}
if (arrFldSet.Contains(conPrjCases.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.UpdDate = objPrjCasesEN.UpdDate == "[null]" ? null :  objPrjCasesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjCases.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjCasesEN.Memo = objPrjCasesEN.Memo == "[null]" ? null :  objPrjCasesEN.Memo; //说明
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
 /// <param name = "objPrjCasesEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjCasesEN objPrjCasesEN)
{
try
{
if (objPrjCasesEN.ImportLevelId == "[null]") objPrjCasesEN.ImportLevelId = null; //重要程度Id
if (objPrjCasesEN.UserId == "[null]") objPrjCasesEN.UserId = null; //用户Id
if (objPrjCasesEN.UpdDate == "[null]") objPrjCasesEN.UpdDate = null; //修改日期
if (objPrjCasesEN.Memo == "[null]") objPrjCasesEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsPrjCasesEN objPrjCasesEN)
{
 PrjCasesDA.CheckPropertyNew(objPrjCasesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjCasesEN objPrjCasesEN)
{
 PrjCasesDA.CheckProperty4Condition(objPrjCasesEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CaseId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjCases.CaseId); 
List<clsPrjCasesEN> arrObjLst = clsPrjCasesBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjCasesEN objPrjCasesEN = new clsPrjCasesEN()
{
CaseId = "0",
CaseName = "选[工程用例]..."
};
arrObjLst.Insert(0, objPrjCasesEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjCases.CaseId;
objComboBox.DisplayMember = conPrjCases.CaseName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CaseId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程用例]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjCases.CaseId); 
IEnumerable<clsPrjCasesEN> arrObjLst = clsPrjCasesBL.GetObjLst(strCondition);
objDDL.DataValueField = conPrjCases.CaseId;
objDDL.DataTextField = conPrjCases.CaseName;
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
public static void BindDdl_CaseIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程用例]...","0");
List<clsPrjCasesEN> arrPrjCasesObjLst = GetAllPrjCasesObjLstCache(); 
objDDL.DataValueField = conPrjCases.CaseId;
objDDL.DataTextField = conPrjCases.CaseName;
objDDL.DataSource = arrPrjCasesObjLst;
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
if (clsPrjCasesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjCasesBL没有刷新缓存机制(clsPrjCasesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CaseId");
//if (arrPrjCasesObjLstCache == null)
//{
//arrPrjCasesObjLstCache = PrjCasesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjCasesEN GetObjByCaseIdCache(string strCaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPrjCasesEN._CurrTabName);
List<clsPrjCasesEN> arrPrjCasesObjLstCache = GetObjLstCache();
IEnumerable <clsPrjCasesEN> arrPrjCasesObjLst_Sel =
arrPrjCasesObjLstCache
.Where(x=> x.CaseId == strCaseId 
);
if (arrPrjCasesObjLst_Sel.Count() == 0)
{
   clsPrjCasesEN obj = clsPrjCasesBL.GetObjByCaseId(strCaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPrjCasesObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCaseNameByCaseIdCache(string strCaseId)
{
if (string.IsNullOrEmpty(strCaseId) == true) return "";
//获取缓存中的对象列表
clsPrjCasesEN objPrjCases = GetObjByCaseIdCache(strCaseId);
if (objPrjCases == null) return "";
return objPrjCases.CaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCaseId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCaseIdCache(string strCaseId)
{
if (string.IsNullOrEmpty(strCaseId) == true) return "";
//获取缓存中的对象列表
clsPrjCasesEN objPrjCases = GetObjByCaseIdCache(strCaseId);
if (objPrjCases == null) return "";
return objPrjCases.CaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjCasesEN> GetAllPrjCasesObjLstCache()
{
//获取缓存中的对象列表
List<clsPrjCasesEN> arrPrjCasesObjLstCache = GetObjLstCache(); 
return arrPrjCasesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjCasesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPrjCasesEN._CurrTabName);
List<clsPrjCasesEN> arrPrjCasesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPrjCasesObjLstCache;
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
string strKey = string.Format("{0}", clsPrjCasesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjCasesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjCasesEN._RefreshTimeLst.Count == 0) return "";
return clsPrjCasesEN._RefreshTimeLst[clsPrjCasesEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPrjCasesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjCasesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjCasesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjCasesBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjCases(工程用例)
 /// 唯一性条件:CaseName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjCasesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjCasesEN objPrjCasesEN)
{
//检测记录是否存在
string strResult = PrjCasesDA.GetUniCondStr(objPrjCasesEN);
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
public static string Func(string strInFldName, string strOutFldName, string strCaseId)
{
if (strInFldName != conPrjCases.CaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjCases._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjCases._AttributeName));
throw new Exception(strMsg);
}
var objPrjCases = clsPrjCasesBL.GetObjByCaseIdCache(strCaseId);
if (objPrjCases == null) return "";
return objPrjCases[strOutFldName].ToString();
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
int intRecCount = clsPrjCasesDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjCasesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjCasesDA.GetRecCount();
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
int intRecCount = clsPrjCasesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjCasesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjCasesEN objPrjCasesCond)
{
List<clsPrjCasesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPrjCasesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjCases._AttributeName)
{
if (objPrjCasesCond.IsUpdated(strFldName) == false) continue;
if (objPrjCasesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjCasesCond[strFldName].ToString());
}
else
{
if (objPrjCasesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjCasesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjCasesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjCasesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjCasesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjCasesCond[strFldName]));
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
 List<string> arrList = clsPrjCasesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjCasesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjCasesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjCasesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjCasesDA.SetFldValue(clsPrjCasesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjCasesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjCasesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjCasesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjCasesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjCases] "); 
 strCreateTabCode.Append(" ( "); 
 // /**CaseId*/ 
 strCreateTabCode.Append(" CaseId varchar(8) primary key, "); 
 // /**CaseName*/ 
 strCreateTabCode.Append(" CaseName varchar(20) not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**CaseContent*/ 
 strCreateTabCode.Append(" CaseContent varchar(1000) not Null, "); 
 // /**CaseTypeId*/ 
 strCreateTabCode.Append(" CaseTypeId varchar(4) not Null, "); 
 // /**重要程度Id*/ 
 strCreateTabCode.Append(" ImportLevelId varchar(4) Null, "); 
 // /**用户Id*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程用例(PrjCases)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjCases : clsCommFun4BL
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
clsPrjCasesBL.ReFreshThisCache();
}
}

}