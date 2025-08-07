
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMRequirementBL
 表名:CMRequirement(00050075)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:40
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
public static class  clsCMRequirementBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMRequirementEN GetObj(this K_ReqId_CMRequirement myKey)
{
clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.CMRequirementDA.GetObjByReqId(myKey.Value);
return objCMRequirementEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMRequirementEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecord)", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.AddNewRecordBySQL2(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
public static bool AddRecordEx(this clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCMRequirementEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMRequirementEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Cm工程Id(CmPrjId)=[{0}],需求名称(RequirementName)=[{1}])已经存在,不能重复!", objCMRequirementEN.CmPrjId, objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMRequirementEN.AddNewRecord();
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMRequirementEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecordWithMaxId)", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true || clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
     objCMRequirementEN.ReqId = clsCMRequirementBL.GetMaxStrIdByPrefix_S(objCMRequirementEN.PrjId);
 }
string strReqId = clsCMRequirementBL.CMRequirementDA.AddNewRecordBySQL2WithReturnKey(objCMRequirementEN);
     objCMRequirementEN.ReqId = strReqId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
}
return strReqId;
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMRequirementEN objCMRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空.(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMRequirementEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecord(SqlTransaction))", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.AddNewRecordBySQL2(objCMRequirementEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMRequirementEN) == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecordWithReturnKey)", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMRequirementBL.CMRequirementDA.AddNewRecordBySQL2WithReturnKey(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetReqId(this clsCMRequirementEN objCMRequirementEN, string strReqId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqId, 8, conCMRequirement.ReqId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReqId, 8, conCMRequirement.ReqId);
}
objCMRequirementEN.ReqId = strReqId; //需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.ReqId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.ReqId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.ReqId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetRequirementName(this clsCMRequirementEN objCMRequirementEN, string strRequirementName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementName, conCMRequirement.RequirementName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementName, 50, conCMRequirement.RequirementName);
}
objCMRequirementEN.RequirementName = strRequirementName; //需求名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.RequirementName) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.RequirementName, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.RequirementName] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetRequirementTypeId(this clsCMRequirementEN objCMRequirementEN, string strRequirementTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRequirementTypeId, conCMRequirement.RequirementTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequirementTypeId, 4, conCMRequirement.RequirementTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequirementTypeId, 4, conCMRequirement.RequirementTypeId);
}
objCMRequirementEN.RequirementTypeId = strRequirementTypeId; //需求类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.RequirementTypeId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.RequirementTypeId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.RequirementTypeId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetReqContent(this clsCMRequirementEN objCMRequirementEN, string strReqContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqContent, conCMRequirement.ReqContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReqContent, 4000, conCMRequirement.ReqContent);
}
objCMRequirementEN.ReqContent = strReqContent; //需求内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.ReqContent) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.ReqContent, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.ReqContent] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpReqId(this clsCMRequirementEN objCMRequirementEN, string strUpReqId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpReqId, 8, conCMRequirement.UpReqId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUpReqId, 8, conCMRequirement.UpReqId);
}
objCMRequirementEN.UpReqId = strUpReqId; //上级需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpReqId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpReqId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpReqId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsFinished(this clsCMRequirementEN objCMRequirementEN, bool bolIsFinished, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsFinished, conCMRequirement.IsFinished);
objCMRequirementEN.IsFinished = bolIsFinished; //是否完成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsFinished) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsFinished, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsFinished] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetCmPrjId(this clsCMRequirementEN objCMRequirementEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conCMRequirement.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conCMRequirement.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conCMRequirement.CmPrjId);
}
objCMRequirementEN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.CmPrjId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.CmPrjId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.CmPrjId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetFuncModuleAgcId(this clsCMRequirementEN objCMRequirementEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conCMRequirement.FuncModuleAgcId);
}
objCMRequirementEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.FuncModuleAgcId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.FuncModuleAgcId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.FuncModuleAgcId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetPrjId(this clsCMRequirementEN objCMRequirementEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMRequirement.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMRequirement.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMRequirement.PrjId);
}
objCMRequirementEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.PrjId) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.PrjId, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.PrjId] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpdUser(this clsCMRequirementEN objCMRequirementEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMRequirement.UpdUser);
}
objCMRequirementEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpdUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpdUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpdUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetUpdDate(this clsCMRequirementEN objCMRequirementEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMRequirement.UpdDate);
}
objCMRequirementEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.UpdDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.UpdDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.UpdDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetMemo(this clsCMRequirementEN objCMRequirementEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMRequirement.Memo);
}
objCMRequirementEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.Memo) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.Memo, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.Memo] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsSynchToServer(this clsCMRequirementEN objCMRequirementEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMRequirementEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsSynchToServer) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsSynchToServer, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsSynchToServer] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToServerDate(this clsCMRequirementEN objCMRequirementEN, string strSynchToServerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMRequirement.SynchToServerDate);
}
objCMRequirementEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToServerDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToServerDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToServerDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToServerUser(this clsCMRequirementEN objCMRequirementEN, string strSynchToServerUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMRequirement.SynchToServerUser);
}
objCMRequirementEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToServerUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToServerUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToServerUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetIsSynchToClient(this clsCMRequirementEN objCMRequirementEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMRequirementEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.IsSynchToClient) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.IsSynchToClient, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.IsSynchToClient] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToClientDate(this clsCMRequirementEN objCMRequirementEN, string strSynchToClientDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMRequirement.SynchToClientDate);
}
objCMRequirementEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToClientDate) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToClientDate, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToClientDate] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynchToClientUser(this clsCMRequirementEN objCMRequirementEN, string strSynchToClientUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMRequirement.SynchToClientUser);
}
objCMRequirementEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynchToClientUser) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynchToClientUser, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynchToClientUser] = strComparisonOp;
}
}
return objCMRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMRequirementEN SetSynSource(this clsCMRequirementEN objCMRequirementEN, string strSynSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMRequirement.SynSource);
}
objCMRequirementEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMRequirementEN.dicFldComparisonOp.ContainsKey(conCMRequirement.SynSource) == false)
{
objCMRequirementEN.dicFldComparisonOp.Add(conCMRequirement.SynSource, strComparisonOp);
}
else
{
objCMRequirementEN.dicFldComparisonOp[conCMRequirement.SynSource] = strComparisonOp;
}
}
return objCMRequirementEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMRequirementEN objCMRequirementEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMRequirementEN.CheckPropertyNew();
clsCMRequirementEN objCMRequirementCond = new clsCMRequirementEN();
string strCondition = objCMRequirementCond
.SetReqId(objCMRequirementEN.ReqId, "<>")
.SetCmPrjId(objCMRequirementEN.CmPrjId, "=")
.SetRequirementName(objCMRequirementEN.RequirementName, "=")
.GetCombineCondition();
objCMRequirementEN._IsCheckProperty = true;
bool bolIsExist = clsCMRequirementBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RequirementName_CMPrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMRequirementEN.Update();
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
 /// <param name = "objCMRequirement">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMRequirementEN objCMRequirement)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMRequirementEN objCMRequirementCond = new clsCMRequirementEN();
string strCondition = objCMRequirementCond
.SetCmPrjId(objCMRequirement.CmPrjId, "=")
.SetRequirementName(objCMRequirement.RequirementName, "=")
.GetCombineCondition();
objCMRequirement._IsCheckProperty = true;
bool bolIsExist = clsCMRequirementBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMRequirement.ReqId = clsCMRequirementBL.GetFirstID_S(strCondition);
objCMRequirement.UpdateWithCondition(strCondition);
}
else
{
objCMRequirement.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMRequirementEN objCMRequirementEN)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.UpdateBySql2(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsCMRequirementEN objCMRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.UpdateBySql2(objCMRequirementEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMRequirementEN objCMRequirementEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.UpdateBySql2(objCMRequirementEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMRequirementEN objCMRequirementEN, string strWhereCond)
{
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.UpdateBySqlWithCondition(objCMRequirementEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMRequirementEN objCMRequirementEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMRequirementBL.CMRequirementDA.UpdateBySqlWithConditionTransaction(objCMRequirementEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCMRequirementEN objCMRequirementEN)
{
try
{
int intRecNum = clsCMRequirementBL.CMRequirementDA.DelRecord(objCMRequirementEN.ReqId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementENS">源对象</param>
 /// <param name = "objCMRequirementENT">目标对象</param>
 public static void CopyTo(this clsCMRequirementEN objCMRequirementENS, clsCMRequirementEN objCMRequirementENT)
{
try
{
objCMRequirementENT.ReqId = objCMRequirementENS.ReqId; //需求Id
objCMRequirementENT.RequirementName = objCMRequirementENS.RequirementName; //需求名称
objCMRequirementENT.RequirementTypeId = objCMRequirementENS.RequirementTypeId; //需求类型Id
objCMRequirementENT.ReqContent = objCMRequirementENS.ReqContent; //需求内容
objCMRequirementENT.UpReqId = objCMRequirementENS.UpReqId; //上级需求Id
objCMRequirementENT.IsFinished = objCMRequirementENS.IsFinished; //是否完成
objCMRequirementENT.CmPrjId = objCMRequirementENS.CmPrjId; //Cm工程Id
objCMRequirementENT.FuncModuleAgcId = objCMRequirementENS.FuncModuleAgcId; //功能模块Id
objCMRequirementENT.PrjId = objCMRequirementENS.PrjId; //工程Id
objCMRequirementENT.UpdUser = objCMRequirementENS.UpdUser; //修改者
objCMRequirementENT.UpdDate = objCMRequirementENS.UpdDate; //修改日期
objCMRequirementENT.Memo = objCMRequirementENS.Memo; //说明
objCMRequirementENT.IsSynchToServer = objCMRequirementENS.IsSynchToServer; //是否同步到Server
objCMRequirementENT.SynchToServerDate = objCMRequirementENS.SynchToServerDate; //同步到Server日期
objCMRequirementENT.SynchToServerUser = objCMRequirementENS.SynchToServerUser; //同步到Server用户
objCMRequirementENT.IsSynchToClient = objCMRequirementENS.IsSynchToClient; //是否同步到Client
objCMRequirementENT.SynchToClientDate = objCMRequirementENS.SynchToClientDate; //同步到Client库日期
objCMRequirementENT.SynchToClientUser = objCMRequirementENS.SynchToClientUser; //同步到Client库用户
objCMRequirementENT.SynSource = objCMRequirementENS.SynSource; //同步来源
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
 /// <param name = "objCMRequirementENS">源对象</param>
 /// <returns>目标对象=>clsCMRequirementEN:objCMRequirementENT</returns>
 public static clsCMRequirementEN CopyTo(this clsCMRequirementEN objCMRequirementENS)
{
try
{
 clsCMRequirementEN objCMRequirementENT = new clsCMRequirementEN()
{
ReqId = objCMRequirementENS.ReqId, //需求Id
RequirementName = objCMRequirementENS.RequirementName, //需求名称
RequirementTypeId = objCMRequirementENS.RequirementTypeId, //需求类型Id
ReqContent = objCMRequirementENS.ReqContent, //需求内容
UpReqId = objCMRequirementENS.UpReqId, //上级需求Id
IsFinished = objCMRequirementENS.IsFinished, //是否完成
CmPrjId = objCMRequirementENS.CmPrjId, //Cm工程Id
FuncModuleAgcId = objCMRequirementENS.FuncModuleAgcId, //功能模块Id
PrjId = objCMRequirementENS.PrjId, //工程Id
UpdUser = objCMRequirementENS.UpdUser, //修改者
UpdDate = objCMRequirementENS.UpdDate, //修改日期
Memo = objCMRequirementENS.Memo, //说明
IsSynchToServer = objCMRequirementENS.IsSynchToServer, //是否同步到Server
SynchToServerDate = objCMRequirementENS.SynchToServerDate, //同步到Server日期
SynchToServerUser = objCMRequirementENS.SynchToServerUser, //同步到Server用户
IsSynchToClient = objCMRequirementENS.IsSynchToClient, //是否同步到Client
SynchToClientDate = objCMRequirementENS.SynchToClientDate, //同步到Client库日期
SynchToClientUser = objCMRequirementENS.SynchToClientUser, //同步到Client库用户
SynSource = objCMRequirementENS.SynSource, //同步来源
};
 return objCMRequirementENT;
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
public static void CheckPropertyNew(this clsCMRequirementEN objCMRequirementEN)
{
 clsCMRequirementBL.CMRequirementDA.CheckPropertyNew(objCMRequirementEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMRequirementEN objCMRequirementEN)
{
 clsCMRequirementBL.CMRequirementDA.CheckProperty4Condition(objCMRequirementEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMRequirementEN objCMRequirementCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMRequirementCond.IsUpdated(conCMRequirement.ReqId) == true)
{
string strComparisonOpReqId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.ReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.ReqId, objCMRequirementCond.ReqId, strComparisonOpReqId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.RequirementName) == true)
{
string strComparisonOpRequirementName = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.RequirementName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.RequirementName, objCMRequirementCond.RequirementName, strComparisonOpRequirementName);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.RequirementTypeId) == true)
{
string strComparisonOpRequirementTypeId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.RequirementTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.RequirementTypeId, objCMRequirementCond.RequirementTypeId, strComparisonOpRequirementTypeId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.ReqContent) == true)
{
string strComparisonOpReqContent = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.ReqContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.ReqContent, objCMRequirementCond.ReqContent, strComparisonOpReqContent);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpReqId) == true)
{
string strComparisonOpUpReqId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpReqId, objCMRequirementCond.UpReqId, strComparisonOpUpReqId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsFinished) == true)
{
if (objCMRequirementCond.IsFinished == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsFinished);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsFinished);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.CmPrjId, objCMRequirementCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.FuncModuleAgcId, objCMRequirementCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.PrjId) == true)
{
string strComparisonOpPrjId = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.PrjId, objCMRequirementCond.PrjId, strComparisonOpPrjId);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpdUser, objCMRequirementCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.UpdDate, objCMRequirementCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.Memo) == true)
{
string strComparisonOpMemo = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.Memo, objCMRequirementCond.Memo, strComparisonOpMemo);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsSynchToServer) == true)
{
if (objCMRequirementCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsSynchToServer);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToServerDate, objCMRequirementCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToServerUser, objCMRequirementCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.IsSynchToClient) == true)
{
if (objCMRequirementCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMRequirement.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMRequirement.IsSynchToClient);
}
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToClientDate, objCMRequirementCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynchToClientUser, objCMRequirementCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMRequirementCond.IsUpdated(conCMRequirement.SynSource) == true)
{
string strComparisonOpSynSource = objCMRequirementCond.dicFldComparisonOp[conCMRequirement.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMRequirement.SynSource, objCMRequirementCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMRequirement(项目需求), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RequirementName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMRequirementEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMRequirementEN objCMRequirementEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMRequirementEN == null) return true;
if (objCMRequirementEN.ReqId == null || objCMRequirementEN.ReqId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
if (clsCMRequirementBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ReqId !=  '{0}'", objCMRequirementEN.ReqId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
if (clsCMRequirementBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMRequirement(项目需求), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequirementName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMRequirementEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMRequirementEN objCMRequirementEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMRequirementEN == null) return "";
if (objCMRequirementEN.ReqId == null || objCMRequirementEN.ReqId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReqId !=  '{0}'", objCMRequirementEN.ReqId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objCMRequirementEN.CmPrjId);
 sbCondition.AppendFormat(" and RequirementName = '{0}'", objCMRequirementEN.RequirementName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMRequirement
{
public virtual bool UpdRelaTabDate(string strReqId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 项目需求(CMRequirement)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMRequirementBL
{
public static RelatedActions_CMRequirement relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMRequirementDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMRequirementDA CMRequirementDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMRequirementDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsCMRequirementBL()
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
if (string.IsNullOrEmpty(clsCMRequirementEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMRequirementEN._ConnectString);
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
public static DataTable GetDataTable_CMRequirement(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMRequirementDA.GetDataTable_CMRequirement(strWhereCond);
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
objDT = CMRequirementDA.GetDataTable(strWhereCond);
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
objDT = CMRequirementDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMRequirementDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMRequirementDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMRequirementDA.GetDataTable_Top(objTopPara);
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
objDT = CMRequirementDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMRequirementDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrReqIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstByReqIdLst(List<string> arrReqIdLst)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrReqIdLst, true);
 string strWhereCond = string.Format("ReqId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReqIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMRequirementEN> GetObjLstByReqIdLstCache(List<string> arrReqIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrCMRequirementObjLst_Sel =
arrCMRequirementObjLstCache
.Where(x => arrReqIdLst.Contains(x.ReqId));
return arrCMRequirementObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMRequirementEN> GetObjLst(string strWhereCond)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
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
public static List<clsCMRequirementEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMRequirementEN> GetSubObjLstCache(clsCMRequirementEN objCMRequirementCond)
{
 string strPrjId = objCMRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCMRequirementBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCMRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMRequirement._AttributeName)
{
if (objCMRequirementCond.IsUpdated(strFldName) == false) continue;
if (objCMRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMRequirementCond[strFldName].ToString());
}
else
{
if (objCMRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMRequirementCond[strFldName]));
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
public static List<clsCMRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
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
public static List<clsCMRequirementEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
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
List<clsCMRequirementEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMRequirementEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMRequirementEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
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
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
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
public static List<clsCMRequirementEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
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
public static List<clsCMRequirementEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMRequirementEN> arrObjLst = new List<clsCMRequirementEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN();
try
{
objCMRequirementEN.ReqId = objRow[conCMRequirement.ReqId].ToString().Trim(); //需求Id
objCMRequirementEN.RequirementName = objRow[conCMRequirement.RequirementName].ToString().Trim(); //需求名称
objCMRequirementEN.RequirementTypeId = objRow[conCMRequirement.RequirementTypeId].ToString().Trim(); //需求类型Id
objCMRequirementEN.ReqContent = objRow[conCMRequirement.ReqContent].ToString().Trim(); //需求内容
objCMRequirementEN.UpReqId = objRow[conCMRequirement.UpReqId] == DBNull.Value ? null : objRow[conCMRequirement.UpReqId].ToString().Trim(); //上级需求Id
objCMRequirementEN.IsFinished = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsFinished].ToString().Trim()); //是否完成
objCMRequirementEN.CmPrjId = objRow[conCMRequirement.CmPrjId].ToString().Trim(); //Cm工程Id
objCMRequirementEN.FuncModuleAgcId = objRow[conCMRequirement.FuncModuleAgcId] == DBNull.Value ? null : objRow[conCMRequirement.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objCMRequirementEN.PrjId = objRow[conCMRequirement.PrjId].ToString().Trim(); //工程Id
objCMRequirementEN.UpdUser = objRow[conCMRequirement.UpdUser] == DBNull.Value ? null : objRow[conCMRequirement.UpdUser].ToString().Trim(); //修改者
objCMRequirementEN.UpdDate = objRow[conCMRequirement.UpdDate] == DBNull.Value ? null : objRow[conCMRequirement.UpdDate].ToString().Trim(); //修改日期
objCMRequirementEN.Memo = objRow[conCMRequirement.Memo] == DBNull.Value ? null : objRow[conCMRequirement.Memo].ToString().Trim(); //说明
objCMRequirementEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMRequirementEN.SynchToServerDate = objRow[conCMRequirement.SynchToServerDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMRequirementEN.SynchToServerUser = objRow[conCMRequirement.SynchToServerUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMRequirementEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMRequirement.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMRequirementEN.SynchToClientDate = objRow[conCMRequirement.SynchToClientDate] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMRequirementEN.SynchToClientUser = objRow[conCMRequirement.SynchToClientUser] == DBNull.Value ? null : objRow[conCMRequirement.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMRequirementEN.SynSource = objRow[conCMRequirement.SynSource] == DBNull.Value ? null : objRow[conCMRequirement.SynSource].ToString().Trim(); //同步来源
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMRequirementEN.ReqId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMRequirementEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMRequirementEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMRequirement(ref clsCMRequirementEN objCMRequirementEN)
{
bool bolResult = CMRequirementDA.GetCMRequirement(ref objCMRequirementEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMRequirementEN GetObjByReqId(string strReqId)
{
if (strReqId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strReqId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strReqId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strReqId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCMRequirementEN objCMRequirementEN = CMRequirementDA.GetObjByReqId(strReqId);
return objCMRequirementEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMRequirementEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMRequirementEN objCMRequirementEN = CMRequirementDA.GetFirstObj(strWhereCond);
 return objCMRequirementEN;
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
public static clsCMRequirementEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMRequirementEN objCMRequirementEN = CMRequirementDA.GetObjByDataRow(objRow);
 return objCMRequirementEN;
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
public static clsCMRequirementEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMRequirementEN objCMRequirementEN = CMRequirementDA.GetObjByDataRow(objRow);
 return objCMRequirementEN;
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
 /// <param name = "strReqId">所给的关键字</param>
 /// <param name = "lstCMRequirementObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMRequirementEN GetObjByReqIdFromList(string strReqId, List<clsCMRequirementEN> lstCMRequirementObjLst)
{
foreach (clsCMRequirementEN objCMRequirementEN in lstCMRequirementObjLst)
{
if (objCMRequirementEN.ReqId == strReqId)
{
return objCMRequirementEN;
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
 string strMaxReqId;
 try
 {
 strMaxReqId = new clsCMRequirementDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxReqId;
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
 string strReqId;
 try
 {
 strReqId = new clsCMRequirementDA().GetFirstID(strWhereCond);
 return strReqId;
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
 arrList = CMRequirementDA.GetID(strWhereCond);
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
bool bolIsExist = CMRequirementDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strReqId)
{
if (string.IsNullOrEmpty(strReqId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strReqId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CMRequirementDA.IsExist(strReqId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strReqId">需求Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strReqId, string strOpUser)
{
clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.GetObjByReqId(strReqId);
objCMRequirementEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCMRequirementEN.UpdUser = strOpUser;
return clsCMRequirementBL.UpdateBySql2(objCMRequirementEN);
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
 bolIsExist = clsCMRequirementDA.IsExistTable();
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
 bolIsExist = CMRequirementDA.IsExistTable(strTabName);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objCMRequirementEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecordBySql2)", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMRequirementDA.AddNewRecordBySQL2(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMRequirementEN objCMRequirementEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCMRequirementBL.IsExist(objCMRequirementEN.ReqId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCMRequirementEN.ReqId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objCMRequirementEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Cm工程Id = [{0}],需求名称 = [{1}]的数据已经存在!(in clsCMRequirementBL.AddNewRecordBySql2WithReturnKey)", objCMRequirementEN.CmPrjId,objCMRequirementEN.RequirementName);
throw new Exception(strMsg);
}
try
{
string strKey = CMRequirementDA.AddNewRecordBySQL2WithReturnKey(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMRequirementEN objCMRequirementEN)
{
try
{
bool bolResult = CMRequirementDA.Update(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "objCMRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMRequirementEN objCMRequirementEN)
{
 if (string.IsNullOrEmpty(objCMRequirementEN.ReqId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMRequirementDA.UpdateBySql2(objCMRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMRequirementBL.ReFreshCache(objCMRequirementEN.PrjId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
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
 /// <param name = "strReqId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strReqId)
{
try
{
 clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.GetObjByReqId(strReqId);

if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(objCMRequirementEN.ReqId, objCMRequirementEN.UpdUser);
}
if (objCMRequirementEN != null)
{
int intRecNum = CMRequirementDA.DelRecord(strReqId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMRequirementEN.PrjId);
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
/// <param name="strReqId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strReqId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
//删除与表:[CMRequirement]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMRequirement.ReqId,
//strReqId);
//        clsCMRequirementBL.DelCMRequirementsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMRequirementBL.DelRecord(strReqId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMRequirementBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReqId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strReqId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strReqId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMRequirementBL.relatedActions != null)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(strReqId, "UpdRelaTabDate");
}
bool bolResult = CMRequirementDA.DelRecord(strReqId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrReqIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCMRequirements(List<string> arrReqIdLst)
{
if (arrReqIdLst.Count == 0) return 0;
try
{
if (clsCMRequirementBL.relatedActions != null)
{
foreach (var strReqId in arrReqIdLst)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(strReqId, "UpdRelaTabDate");
}
}
 clsCMRequirementEN objCMRequirementEN = clsCMRequirementBL.GetObjByReqId(arrReqIdLst[0]);
int intDelRecNum = CMRequirementDA.DelCMRequirement(arrReqIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCMRequirementEN.PrjId);
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
public static int DelCMRequirementsByCond(string strWhereCond)
{
try
{
if (clsCMRequirementBL.relatedActions != null)
{
List<string> arrReqId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strReqId in arrReqId)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(strReqId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conCMRequirement.PrjId, strWhereCond);
int intRecNum = CMRequirementDA.DelCMRequirement(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
public static bool DelCMRequirementsByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCMRequirementBL.relatedActions != null)
{
List<string> arrReqId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strReqId in arrReqId)
{
clsCMRequirementBL.relatedActions.UpdRelaTabDate(strReqId, "UpdRelaTabDate");
}
}
bool bolResult = CMRequirementDA.DelCMRequirementWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMRequirement]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strReqId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strReqId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMRequirementDA.GetSpecSQLObj();
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
//删除与表:[CMRequirement]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMRequirementBL.DelRecord(strReqId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMRequirementBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReqId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCMRequirementENS">源对象</param>
 /// <param name = "objCMRequirementENT">目标对象</param>
 public static void CopyTo(clsCMRequirementEN objCMRequirementENS, clsCMRequirementEN objCMRequirementENT)
{
try
{
objCMRequirementENT.ReqId = objCMRequirementENS.ReqId; //需求Id
objCMRequirementENT.RequirementName = objCMRequirementENS.RequirementName; //需求名称
objCMRequirementENT.RequirementTypeId = objCMRequirementENS.RequirementTypeId; //需求类型Id
objCMRequirementENT.ReqContent = objCMRequirementENS.ReqContent; //需求内容
objCMRequirementENT.UpReqId = objCMRequirementENS.UpReqId; //上级需求Id
objCMRequirementENT.IsFinished = objCMRequirementENS.IsFinished; //是否完成
objCMRequirementENT.CmPrjId = objCMRequirementENS.CmPrjId; //Cm工程Id
objCMRequirementENT.FuncModuleAgcId = objCMRequirementENS.FuncModuleAgcId; //功能模块Id
objCMRequirementENT.PrjId = objCMRequirementENS.PrjId; //工程Id
objCMRequirementENT.UpdUser = objCMRequirementENS.UpdUser; //修改者
objCMRequirementENT.UpdDate = objCMRequirementENS.UpdDate; //修改日期
objCMRequirementENT.Memo = objCMRequirementENS.Memo; //说明
objCMRequirementENT.IsSynchToServer = objCMRequirementENS.IsSynchToServer; //是否同步到Server
objCMRequirementENT.SynchToServerDate = objCMRequirementENS.SynchToServerDate; //同步到Server日期
objCMRequirementENT.SynchToServerUser = objCMRequirementENS.SynchToServerUser; //同步到Server用户
objCMRequirementENT.IsSynchToClient = objCMRequirementENS.IsSynchToClient; //是否同步到Client
objCMRequirementENT.SynchToClientDate = objCMRequirementENS.SynchToClientDate; //同步到Client库日期
objCMRequirementENT.SynchToClientUser = objCMRequirementENS.SynchToClientUser; //同步到Client库用户
objCMRequirementENT.SynSource = objCMRequirementENS.SynSource; //同步来源
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
 /// <param name = "objCMRequirementEN">源简化对象</param>
 public static void SetUpdFlag(clsCMRequirementEN objCMRequirementEN)
{
try
{
objCMRequirementEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMRequirementEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMRequirement.ReqId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.ReqId = objCMRequirementEN.ReqId; //需求Id
}
if (arrFldSet.Contains(conCMRequirement.RequirementName, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.RequirementName = objCMRequirementEN.RequirementName; //需求名称
}
if (arrFldSet.Contains(conCMRequirement.RequirementTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.RequirementTypeId = objCMRequirementEN.RequirementTypeId; //需求类型Id
}
if (arrFldSet.Contains(conCMRequirement.ReqContent, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.ReqContent = objCMRequirementEN.ReqContent; //需求内容
}
if (arrFldSet.Contains(conCMRequirement.UpReqId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.UpReqId = objCMRequirementEN.UpReqId == "[null]" ? null :  objCMRequirementEN.UpReqId; //上级需求Id
}
if (arrFldSet.Contains(conCMRequirement.IsFinished, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.IsFinished = objCMRequirementEN.IsFinished; //是否完成
}
if (arrFldSet.Contains(conCMRequirement.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.CmPrjId = objCMRequirementEN.CmPrjId; //Cm工程Id
}
if (arrFldSet.Contains(conCMRequirement.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.FuncModuleAgcId = objCMRequirementEN.FuncModuleAgcId == "[null]" ? null :  objCMRequirementEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conCMRequirement.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.PrjId = objCMRequirementEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conCMRequirement.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.UpdUser = objCMRequirementEN.UpdUser == "[null]" ? null :  objCMRequirementEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMRequirement.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.UpdDate = objCMRequirementEN.UpdDate == "[null]" ? null :  objCMRequirementEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMRequirement.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.Memo = objCMRequirementEN.Memo == "[null]" ? null :  objCMRequirementEN.Memo; //说明
}
if (arrFldSet.Contains(conCMRequirement.IsSynchToServer, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.IsSynchToServer = objCMRequirementEN.IsSynchToServer; //是否同步到Server
}
if (arrFldSet.Contains(conCMRequirement.SynchToServerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.SynchToServerDate = objCMRequirementEN.SynchToServerDate == "[null]" ? null :  objCMRequirementEN.SynchToServerDate; //同步到Server日期
}
if (arrFldSet.Contains(conCMRequirement.SynchToServerUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.SynchToServerUser = objCMRequirementEN.SynchToServerUser == "[null]" ? null :  objCMRequirementEN.SynchToServerUser; //同步到Server用户
}
if (arrFldSet.Contains(conCMRequirement.IsSynchToClient, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.IsSynchToClient = objCMRequirementEN.IsSynchToClient; //是否同步到Client
}
if (arrFldSet.Contains(conCMRequirement.SynchToClientDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.SynchToClientDate = objCMRequirementEN.SynchToClientDate == "[null]" ? null :  objCMRequirementEN.SynchToClientDate; //同步到Client库日期
}
if (arrFldSet.Contains(conCMRequirement.SynchToClientUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.SynchToClientUser = objCMRequirementEN.SynchToClientUser == "[null]" ? null :  objCMRequirementEN.SynchToClientUser; //同步到Client库用户
}
if (arrFldSet.Contains(conCMRequirement.SynSource, new clsStrCompareIgnoreCase())  ==  true)
{
objCMRequirementEN.SynSource = objCMRequirementEN.SynSource == "[null]" ? null :  objCMRequirementEN.SynSource; //同步来源
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
 /// <param name = "objCMRequirementEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMRequirementEN objCMRequirementEN)
{
try
{
if (objCMRequirementEN.UpReqId == "[null]") objCMRequirementEN.UpReqId = null; //上级需求Id
if (objCMRequirementEN.FuncModuleAgcId == "[null]") objCMRequirementEN.FuncModuleAgcId = null; //功能模块Id
if (objCMRequirementEN.UpdUser == "[null]") objCMRequirementEN.UpdUser = null; //修改者
if (objCMRequirementEN.UpdDate == "[null]") objCMRequirementEN.UpdDate = null; //修改日期
if (objCMRequirementEN.Memo == "[null]") objCMRequirementEN.Memo = null; //说明
if (objCMRequirementEN.SynchToServerDate == "[null]") objCMRequirementEN.SynchToServerDate = null; //同步到Server日期
if (objCMRequirementEN.SynchToServerUser == "[null]") objCMRequirementEN.SynchToServerUser = null; //同步到Server用户
if (objCMRequirementEN.SynchToClientDate == "[null]") objCMRequirementEN.SynchToClientDate = null; //同步到Client库日期
if (objCMRequirementEN.SynchToClientUser == "[null]") objCMRequirementEN.SynchToClientUser = null; //同步到Client库用户
if (objCMRequirementEN.SynSource == "[null]") objCMRequirementEN.SynSource = null; //同步来源
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
public static void CheckPropertyNew(clsCMRequirementEN objCMRequirementEN)
{
 CMRequirementDA.CheckPropertyNew(objCMRequirementEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMRequirementEN objCMRequirementEN)
{
 CMRequirementDA.CheckProperty4Condition(objCMRequirementEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_ReqId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCMRequirement.ReqId); 
List<clsCMRequirementEN> arrObjLst = clsCMRequirementBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCMRequirementEN objCMRequirementEN = new clsCMRequirementEN()
{
ReqId = "0",
RequirementName = "选[项目需求]..."
};
arrObjLstSel.Insert(0, objCMRequirementEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCMRequirement.ReqId;
objComboBox.DisplayMember = conCMRequirement.RequirementName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindDdl_ReqId(System.Web.UI.WebControls.DropDownList objDDL , string strCmPrjId,string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[项目需求]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCMRequirement.ReqId); 
IEnumerable<clsCMRequirementEN> arrObjLst = clsCMRequirementBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CmPrjId == strCmPrjId&& x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conCMRequirement.ReqId;
objDDL.DataTextField = conCMRequirement.RequirementName;
objDDL.DataSource = arrObjLstSel;
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
if (clsCMRequirementBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMRequirementBL没有刷新缓存机制(clsCMRequirementBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReqId");
//if (arrCMRequirementObjLstCache == null)
//{
//arrCMRequirementObjLstCache = CMRequirementDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReqId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMRequirementEN GetObjByReqIdCache(string strReqId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrCMRequirementObjLst_Sel =
arrCMRequirementObjLstCache
.Where(x=> x.ReqId == strReqId 
);
if (arrCMRequirementObjLst_Sel.Count() == 0)
{
   clsCMRequirementEN obj = clsCMRequirementBL.GetObjByReqId(strReqId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strReqId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCMRequirementObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMRequirementEN> GetAllCMRequirementObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsCMRequirementEN> arrCMRequirementObjLstCache = GetObjLstCache(strPrjId); 
return arrCMRequirementObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMRequirementEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsCMRequirementEN> arrCMRequirementObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCMRequirementObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMRequirementEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMRequirementEN._RefreshTimeLst.Count == 0) return "";
return clsCMRequirementEN._RefreshTimeLst[clsCMRequirementEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("缓存分类字段:[PrjId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMRequirementBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMRequirementEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMRequirementBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMRequirement(项目需求)
 /// 唯一性条件:RequirementName_CMPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMRequirementEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMRequirementEN objCMRequirementEN)
{
//检测记录是否存在
string strResult = CMRequirementDA.GetUniCondStr(objCMRequirementEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strReqId, string strPrjId)
{
if (strInFldName != conCMRequirement.ReqId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMRequirement._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMRequirement._AttributeName));
throw new Exception(strMsg);
}
var objCMRequirement = clsCMRequirementBL.GetObjByReqIdCache(strReqId, strPrjId);
if (objCMRequirement == null) return "";
return objCMRequirement[strOutFldName].ToString();
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
int intRecCount = clsCMRequirementDA.GetRecCount(strTabName);
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
int intRecCount = clsCMRequirementDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMRequirementDA.GetRecCount();
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
int intRecCount = clsCMRequirementDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMRequirementCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMRequirementEN objCMRequirementCond)
{
 string strPrjId = objCMRequirementCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCMRequirementBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCMRequirementEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsCMRequirementEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMRequirement._AttributeName)
{
if (objCMRequirementCond.IsUpdated(strFldName) == false) continue;
if (objCMRequirementCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMRequirementCond[strFldName].ToString());
}
else
{
if (objCMRequirementCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMRequirementCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMRequirementCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMRequirementCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMRequirementCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMRequirementCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMRequirementCond[strFldName]));
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
 List<string> arrList = clsCMRequirementDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMRequirementDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMRequirementDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMRequirementDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMRequirementDA.SetFldValue(clsCMRequirementEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMRequirementDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMRequirementDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMRequirementDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMRequirementDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMRequirement] "); 
 strCreateTabCode.Append(" ( "); 
 // /**需求Id*/ 
 strCreateTabCode.Append(" ReqId char(8) primary key, "); 
 // /**需求名称*/ 
 strCreateTabCode.Append(" RequirementName varchar(50) not Null, "); 
 // /**需求类型Id*/ 
 strCreateTabCode.Append(" RequirementTypeId char(4) not Null, "); 
 // /**需求内容*/ 
 strCreateTabCode.Append(" ReqContent varchar(4000) not Null, "); 
 // /**上级需求Id*/ 
 strCreateTabCode.Append(" UpReqId char(8) Null, "); 
 // /**是否完成*/ 
 strCreateTabCode.Append(" IsFinished bit not Null, "); 
 // /**Cm工程Id*/ 
 strCreateTabCode.Append(" CmPrjId char(6) not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
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
 /// 项目需求(CMRequirement)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMRequirement : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsCMRequirementBL.ReFreshThisCache(strPrjId);
}
}

}