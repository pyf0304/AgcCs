
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewFldBL
 表名:SqlViewFld(00050249)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsSqlViewFldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewFldEN GetObj(this K_mId_SqlViewFld myKey)
{
clsSqlViewFldEN objSqlViewFldEN = clsSqlViewFldBL.SqlViewFldDA.GetObjBymId(myKey.Value);
return objSqlViewFldEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewFldEN objSqlViewFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewFldEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Sql视图Id = [{1}],相关表Id = [{2}],字段Id = [{3}],字段表达式 = [{4}]的数据已经存在!(in clsSqlViewFldBL.AddNewRecord)", objSqlViewFldEN.PrjId,objSqlViewFldEN.SqlViewId,objSqlViewFldEN.RelaTabId,objSqlViewFldEN.FldId,objSqlViewFldEN.FldExpression);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSqlViewFldBL.SqlViewFldDA.AddNewRecordBySQL2(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
public static bool AddRecordEx(this clsSqlViewFldEN objSqlViewFldEN, bool bolIsNeedCheckUniqueness = true)
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
objSqlViewFldEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSqlViewFldEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工程Id(PrjId)=[{0}],Sql视图Id(SqlViewId)=[{1}],相关表Id(RelaTabId)=[{2}],字段Id(FldId)=[{3}],字段表达式(FldExpression)=[{4}])已经存在,不能重复!", objSqlViewFldEN.PrjId, objSqlViewFldEN.SqlViewId, objSqlViewFldEN.RelaTabId, objSqlViewFldEN.FldId, objSqlViewFldEN.FldExpression);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSqlViewFldEN.AddNewRecord();
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSqlViewFldEN objSqlViewFldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewFldEN) == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Sql视图Id = [{1}],相关表Id = [{2}],字段Id = [{3}],字段表达式 = [{4}]的数据已经存在!(in clsSqlViewFldBL.AddNewRecordWithReturnKey)", objSqlViewFldEN.PrjId,objSqlViewFldEN.SqlViewId,objSqlViewFldEN.RelaTabId,objSqlViewFldEN.FldId,objSqlViewFldEN.FldExpression);
throw new Exception(strMsg);
}
try
{
string strKey = clsSqlViewFldBL.SqlViewFldDA.AddNewRecordBySQL2WithReturnKey(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetmId(this clsSqlViewFldEN objSqlViewFldEN, long lngmId, string strComparisonOp="")
	{
objSqlViewFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.mId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.mId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.mId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetSqlViewId(this clsSqlViewFldEN objSqlViewFldEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, conSqlViewFld.SqlViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlViewFld.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlViewFld.SqlViewId);
}
objSqlViewFldEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.SqlViewId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.SqlViewId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.SqlViewId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetRelaTabId(this clsSqlViewFldEN objSqlViewFldEN, string strRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlViewFld.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlViewFld.RelaTabId);
}
objSqlViewFldEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.RelaTabId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.RelaTabId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.RelaTabId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFldId(this clsSqlViewFldEN objSqlViewFldEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conSqlViewFld.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conSqlViewFld.FldId);
}
objSqlViewFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FldId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FldId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FldId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFldExpression(this clsSqlViewFldEN objSqlViewFldEN, string strFldExpression, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldExpression, 500, conSqlViewFld.FldExpression);
}
objSqlViewFldEN.FldExpression = strFldExpression; //字段表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FldExpression) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FldExpression, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FldExpression] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFieldAliases(this clsSqlViewFldEN objSqlViewFldEN, string strFieldAliases, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldAliases, 50, conSqlViewFld.FieldAliases);
}
objSqlViewFldEN.FieldAliases = strFieldAliases; //字段别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.FieldAliases) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.FieldAliases, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.FieldAliases] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetFilters(this clsSqlViewFldEN objSqlViewFldEN, string strFilters, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilters, 50, conSqlViewFld.Filters);
}
objSqlViewFldEN.Filters = strFilters; //筛选器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.Filters) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.Filters, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.Filters] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetOrderNum(this clsSqlViewFldEN objSqlViewFldEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conSqlViewFld.OrderNum);
objSqlViewFldEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.OrderNum) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.OrderNum, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.OrderNum] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetPrjId(this clsSqlViewFldEN objSqlViewFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlViewFld.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlViewFld.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlViewFld.PrjId);
}
objSqlViewFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.PrjId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.PrjId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.PrjId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetUpdDate(this clsSqlViewFldEN objSqlViewFldEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlViewFld.UpdDate);
}
objSqlViewFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.UpdDate) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.UpdDate, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.UpdDate] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetUpdUserId(this clsSqlViewFldEN objSqlViewFldEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlViewFld.UpdUserId);
}
objSqlViewFldEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.UpdUserId) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.UpdUserId, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.UpdUserId] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewFldEN SetMemo(this clsSqlViewFldEN objSqlViewFldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlViewFld.Memo);
}
objSqlViewFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewFldEN.dicFldComparisonOp.ContainsKey(conSqlViewFld.Memo) == false)
{
objSqlViewFldEN.dicFldComparisonOp.Add(conSqlViewFld.Memo, strComparisonOp);
}
else
{
objSqlViewFldEN.dicFldComparisonOp[conSqlViewFld.Memo] = strComparisonOp;
}
}
return objSqlViewFldEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSqlViewFldEN objSqlViewFldEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSqlViewFldEN.CheckPropertyNew();
clsSqlViewFldEN objSqlViewFldCond = new clsSqlViewFldEN();
string strCondition = objSqlViewFldCond
.SetmId(objSqlViewFldEN.mId, "<>")
.SetPrjId(objSqlViewFldEN.PrjId, "=")
.SetSqlViewId(objSqlViewFldEN.SqlViewId, "=")
.SetRelaTabId(objSqlViewFldEN.RelaTabId, "=")
.SetFldId(objSqlViewFldEN.FldId, "=")
.SetFldExpression(objSqlViewFldEN.FldExpression, "=")
.GetCombineCondition();
objSqlViewFldEN._IsCheckProperty = true;
bool bolIsExist = clsSqlViewFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_SqlViewId_RelaTabId_FldId_FldExpression)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSqlViewFldEN.Update();
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
 /// <param name = "objSqlViewFld">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSqlViewFldEN objSqlViewFld)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSqlViewFldEN objSqlViewFldCond = new clsSqlViewFldEN();
string strCondition = objSqlViewFldCond
.SetPrjId(objSqlViewFld.PrjId, "=")
.SetSqlViewId(objSqlViewFld.SqlViewId, "=")
.SetRelaTabId(objSqlViewFld.RelaTabId, "=")
.SetFldId(objSqlViewFld.FldId, "=")
.SetFldExpression(objSqlViewFld.FldExpression, "=")
.GetCombineCondition();
objSqlViewFld._IsCheckProperty = true;
bool bolIsExist = clsSqlViewFldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSqlViewFld.mId = clsSqlViewFldBL.GetFirstID_S(strCondition);
objSqlViewFld.UpdateWithCondition(strCondition);
}
else
{
objSqlViewFld.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewFldEN objSqlViewFldEN)
{
 if (objSqlViewFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewFldBL.SqlViewFldDA.UpdateBySql2(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewFldEN objSqlViewFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSqlViewFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewFldBL.SqlViewFldDA.UpdateBySql2(objSqlViewFldEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewFldEN objSqlViewFldEN, string strWhereCond)
{
try
{
bool bolResult = clsSqlViewFldBL.SqlViewFldDA.UpdateBySqlWithCondition(objSqlViewFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewFldEN objSqlViewFldEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSqlViewFldBL.SqlViewFldDA.UpdateBySqlWithConditionTransaction(objSqlViewFldEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
public static int Delete(this clsSqlViewFldEN objSqlViewFldEN)
{
try
{
int intRecNum = clsSqlViewFldBL.SqlViewFldDA.DelRecord(objSqlViewFldEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldENS">源对象</param>
 /// <param name = "objSqlViewFldENT">目标对象</param>
 public static void CopyTo(this clsSqlViewFldEN objSqlViewFldENS, clsSqlViewFldEN objSqlViewFldENT)
{
try
{
objSqlViewFldENT.mId = objSqlViewFldENS.mId; //mId
objSqlViewFldENT.SqlViewId = objSqlViewFldENS.SqlViewId; //Sql视图Id
objSqlViewFldENT.RelaTabId = objSqlViewFldENS.RelaTabId; //相关表Id
objSqlViewFldENT.FldId = objSqlViewFldENS.FldId; //字段Id
objSqlViewFldENT.FldExpression = objSqlViewFldENS.FldExpression; //字段表达式
objSqlViewFldENT.FldExpressionType = objSqlViewFldENS.FldExpressionType; //FldExpressionType
objSqlViewFldENT.FieldAliases = objSqlViewFldENS.FieldAliases; //字段别名
objSqlViewFldENT.Filters = objSqlViewFldENS.Filters; //筛选器
objSqlViewFldENT.OrderNum = objSqlViewFldENS.OrderNum; //序号
objSqlViewFldENT.PrjId = objSqlViewFldENS.PrjId; //工程Id
objSqlViewFldENT.UpdDate = objSqlViewFldENS.UpdDate; //修改日期
objSqlViewFldENT.UpdUserId = objSqlViewFldENS.UpdUserId; //修改用户Id
objSqlViewFldENT.Memo = objSqlViewFldENS.Memo; //说明
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
 /// <param name = "objSqlViewFldENS">源对象</param>
 /// <returns>目标对象=>clsSqlViewFldEN:objSqlViewFldENT</returns>
 public static clsSqlViewFldEN CopyTo(this clsSqlViewFldEN objSqlViewFldENS)
{
try
{
 clsSqlViewFldEN objSqlViewFldENT = new clsSqlViewFldEN()
{
mId = objSqlViewFldENS.mId, //mId
SqlViewId = objSqlViewFldENS.SqlViewId, //Sql视图Id
RelaTabId = objSqlViewFldENS.RelaTabId, //相关表Id
FldId = objSqlViewFldENS.FldId, //字段Id
FldExpression = objSqlViewFldENS.FldExpression, //字段表达式
FldExpressionType = objSqlViewFldENS.FldExpressionType, //FldExpressionType
FieldAliases = objSqlViewFldENS.FieldAliases, //字段别名
Filters = objSqlViewFldENS.Filters, //筛选器
OrderNum = objSqlViewFldENS.OrderNum, //序号
PrjId = objSqlViewFldENS.PrjId, //工程Id
UpdDate = objSqlViewFldENS.UpdDate, //修改日期
UpdUserId = objSqlViewFldENS.UpdUserId, //修改用户Id
Memo = objSqlViewFldENS.Memo, //说明
};
 return objSqlViewFldENT;
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
public static void CheckPropertyNew(this clsSqlViewFldEN objSqlViewFldEN)
{
 clsSqlViewFldBL.SqlViewFldDA.CheckPropertyNew(objSqlViewFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSqlViewFldEN objSqlViewFldEN)
{
 clsSqlViewFldBL.SqlViewFldDA.CheckProperty4Condition(objSqlViewFldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewFldEN objSqlViewFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.mId) == true)
{
string strComparisonOpmId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewFld.mId, objSqlViewFldCond.mId, strComparisonOpmId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.SqlViewId, objSqlViewFldCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.RelaTabId, objSqlViewFldCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldId) == true)
{
string strComparisonOpFldId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldId, objSqlViewFldCond.FldId, strComparisonOpFldId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldExpression) == true)
{
string strComparisonOpFldExpression = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldExpression, objSqlViewFldCond.FldExpression, strComparisonOpFldExpression);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FldExpressionType) == true)
{
string strComparisonOpFldExpressionType = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FldExpressionType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FldExpressionType, objSqlViewFldCond.FldExpressionType, strComparisonOpFldExpressionType);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.FieldAliases) == true)
{
string strComparisonOpFieldAliases = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.FieldAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.FieldAliases, objSqlViewFldCond.FieldAliases, strComparisonOpFieldAliases);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.Filters) == true)
{
string strComparisonOpFilters = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.Filters];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.Filters, objSqlViewFldCond.Filters, strComparisonOpFilters);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.OrderNum) == true)
{
string strComparisonOpOrderNum = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewFld.OrderNum, objSqlViewFldCond.OrderNum, strComparisonOpOrderNum);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.PrjId, objSqlViewFldCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.UpdDate, objSqlViewFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.UpdUserId, objSqlViewFldCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewFldCond.IsUpdated(conSqlViewFld.Memo) == true)
{
string strComparisonOpMemo = objSqlViewFldCond.dicFldComparisonOp[conSqlViewFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewFld.Memo, objSqlViewFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SqlViewFld(Sql视图字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_SqlViewId_RelaTabId_FldId_FldExpression
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSqlViewFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSqlViewFldEN objSqlViewFldEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewFldEN == null) return true;
if (objSqlViewFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 if (objSqlViewFldEN.RelaTabId == null)
{
 sbCondition.AppendFormat(" and RelaTabId is null", objSqlViewFldEN.RelaTabId);
}
else
{
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
}
 if (objSqlViewFldEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objSqlViewFldEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
}
 if (objSqlViewFldEN.FldExpression == null)
{
 sbCondition.AppendFormat(" and FldExpression is null", objSqlViewFldEN.FldExpression);
}
else
{
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
}
if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSqlViewFldEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
if (clsSqlViewFldBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SqlViewFld(Sql视图字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_SqlViewId_RelaTabId_FldId_FldExpression
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSqlViewFldEN objSqlViewFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewFldEN == null) return "";
if (objSqlViewFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 if (objSqlViewFldEN.RelaTabId == null)
{
 sbCondition.AppendFormat(" and RelaTabId is null", objSqlViewFldEN.RelaTabId);
}
else
{
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
}
 if (objSqlViewFldEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null", objSqlViewFldEN.FldId);
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
}
 if (objSqlViewFldEN.FldExpression == null)
{
 sbCondition.AppendFormat(" and FldExpression is null", objSqlViewFldEN.FldExpression);
}
else
{
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objSqlViewFldEN.mId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SqlViewFld
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Sql视图字段(SqlViewFld)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewFldBL
{
public static RelatedActions_SqlViewFld relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSqlViewFldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSqlViewFldDA SqlViewFldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSqlViewFldDA();
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
 public clsSqlViewFldBL()
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
if (string.IsNullOrEmpty(clsSqlViewFldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlViewFldEN._ConnectString);
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
public static DataTable GetDataTable_SqlViewFld(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SqlViewFldDA.GetDataTable_SqlViewFld(strWhereCond);
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
objDT = SqlViewFldDA.GetDataTable(strWhereCond);
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
objDT = SqlViewFldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SqlViewFldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SqlViewFldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SqlViewFldDA.GetDataTable_Top(objTopPara);
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
objDT = SqlViewFldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SqlViewFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SqlViewFldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsSqlViewFldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
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
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSqlViewFldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
List<clsSqlViewFldEN> arrSqlViewFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewFldEN> arrSqlViewFldObjLst_Sel =
arrSqlViewFldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrSqlViewFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewFldEN> GetObjLst(string strWhereCond)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
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
public static List<clsSqlViewFldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSqlViewFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSqlViewFldEN> GetSubObjLstCache(clsSqlViewFldEN objSqlViewFldCond)
{
 string strPrjId = objSqlViewFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSqlViewFldBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSqlViewFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlViewFld._AttributeName)
{
if (objSqlViewFldCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewFldCond[strFldName].ToString());
}
else
{
if (objSqlViewFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewFldCond[strFldName]));
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
public static List<clsSqlViewFldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
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
public static List<clsSqlViewFldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
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
List<clsSqlViewFldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSqlViewFldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewFldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSqlViewFldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
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
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
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
public static List<clsSqlViewFldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSqlViewFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSqlViewFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
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
public static List<clsSqlViewFldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewFldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewFldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSqlViewFldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSqlViewFld(ref clsSqlViewFldEN objSqlViewFldEN)
{
bool bolResult = SqlViewFldDA.GetSqlViewFld(ref objSqlViewFldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewFldEN GetObjBymId(long lngmId)
{
clsSqlViewFldEN objSqlViewFldEN = SqlViewFldDA.GetObjBymId(lngmId);
return objSqlViewFldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSqlViewFldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSqlViewFldEN objSqlViewFldEN = SqlViewFldDA.GetFirstObj(strWhereCond);
 return objSqlViewFldEN;
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
public static clsSqlViewFldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSqlViewFldEN objSqlViewFldEN = SqlViewFldDA.GetObjByDataRow(objRow);
 return objSqlViewFldEN;
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
public static clsSqlViewFldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSqlViewFldEN objSqlViewFldEN = SqlViewFldDA.GetObjByDataRow(objRow);
 return objSqlViewFldEN;
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
 /// <param name = "lstSqlViewFldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewFldEN GetObjBymIdFromList(long lngmId, List<clsSqlViewFldEN> lstSqlViewFldObjLst)
{
foreach (clsSqlViewFldEN objSqlViewFldEN in lstSqlViewFldObjLst)
{
if (objSqlViewFldEN.mId == lngmId)
{
return objSqlViewFldEN;
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
 lngmId = new clsSqlViewFldDA().GetFirstID(strWhereCond);
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
 arrList = SqlViewFldDA.GetID(strWhereCond);
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
bool bolIsExist = SqlViewFldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = SqlViewFldDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsSqlViewFldEN objSqlViewFldEN = clsSqlViewFldBL.GetObjBymId(lngmId);
objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSqlViewFldEN.UpdUserId = strOpUser;
return clsSqlViewFldBL.UpdateBySql2(objSqlViewFldEN);
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
 bolIsExist = clsSqlViewFldDA.IsExistTable();
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
 bolIsExist = SqlViewFldDA.IsExistTable(strTabName);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSqlViewFldEN objSqlViewFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Sql视图Id = [{1}],相关表Id = [{2}],字段Id = [{3}],字段表达式 = [{4}]的数据已经存在!(in clsSqlViewFldBL.AddNewRecordBySql2)", objSqlViewFldEN.PrjId,objSqlViewFldEN.SqlViewId,objSqlViewFldEN.RelaTabId,objSqlViewFldEN.FldId,objSqlViewFldEN.FldExpression);
throw new Exception(strMsg);
}
try
{
bool bolResult = SqlViewFldDA.AddNewRecordBySQL2(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSqlViewFldEN objSqlViewFldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewFldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工程Id = [{0}],Sql视图Id = [{1}],相关表Id = [{2}],字段Id = [{3}],字段表达式 = [{4}]的数据已经存在!(in clsSqlViewFldBL.AddNewRecordBySql2WithReturnKey)", objSqlViewFldEN.PrjId,objSqlViewFldEN.SqlViewId,objSqlViewFldEN.RelaTabId,objSqlViewFldEN.FldId,objSqlViewFldEN.FldExpression);
throw new Exception(strMsg);
}
try
{
string strKey = SqlViewFldDA.AddNewRecordBySQL2WithReturnKey(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSqlViewFldEN objSqlViewFldEN)
{
try
{
bool bolResult = SqlViewFldDA.Update(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSqlViewFldEN objSqlViewFldEN)
{
 if (objSqlViewFldEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SqlViewFldDA.UpdateBySql2(objSqlViewFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewFldBL.ReFreshCache(objSqlViewFldEN.PrjId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
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
 clsSqlViewFldEN objSqlViewFldEN = clsSqlViewFldBL.GetObjBymId(lngmId);

if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(objSqlViewFldEN.mId, objSqlViewFldEN.UpdUserId);
}
if (objSqlViewFldEN != null)
{
int intRecNum = SqlViewFldDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewFldEN.PrjId);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
//删除与表:[SqlViewFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSqlViewFld.mId,
//lngmId);
//        clsSqlViewFldBL.DelSqlViewFldsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewFldBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSqlViewFldBL.relatedActions != null)
{
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = SqlViewFldDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSqlViewFlds(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsSqlViewFldBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsSqlViewFldEN objSqlViewFldEN = clsSqlViewFldBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = SqlViewFldDA.DelSqlViewFld(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewFldEN.PrjId);
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
public static int DelSqlViewFldsByCond(string strWhereCond)
{
try
{
if (clsSqlViewFldBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsSqlViewFldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conSqlViewFld.PrjId, strWhereCond);
int intRecNum = SqlViewFldDA.DelSqlViewFld(strWhereCond);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SqlViewFld]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
//删除与表:[SqlViewFld]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewFldBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewFldBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objSqlViewFldENS">源对象</param>
 /// <param name = "objSqlViewFldENT">目标对象</param>
 public static void CopyTo(clsSqlViewFldEN objSqlViewFldENS, clsSqlViewFldEN objSqlViewFldENT)
{
try
{
objSqlViewFldENT.mId = objSqlViewFldENS.mId; //mId
objSqlViewFldENT.SqlViewId = objSqlViewFldENS.SqlViewId; //Sql视图Id
objSqlViewFldENT.RelaTabId = objSqlViewFldENS.RelaTabId; //相关表Id
objSqlViewFldENT.FldId = objSqlViewFldENS.FldId; //字段Id
objSqlViewFldENT.FldExpression = objSqlViewFldENS.FldExpression; //字段表达式
objSqlViewFldENT.FldExpressionType = objSqlViewFldENS.FldExpressionType; //FldExpressionType
objSqlViewFldENT.FieldAliases = objSqlViewFldENS.FieldAliases; //字段别名
objSqlViewFldENT.Filters = objSqlViewFldENS.Filters; //筛选器
objSqlViewFldENT.OrderNum = objSqlViewFldENS.OrderNum; //序号
objSqlViewFldENT.PrjId = objSqlViewFldENS.PrjId; //工程Id
objSqlViewFldENT.UpdDate = objSqlViewFldENS.UpdDate; //修改日期
objSqlViewFldENT.UpdUserId = objSqlViewFldENS.UpdUserId; //修改用户Id
objSqlViewFldENT.Memo = objSqlViewFldENS.Memo; //说明
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
 /// <param name = "objSqlViewFldEN">源简化对象</param>
 public static void SetUpdFlag(clsSqlViewFldEN objSqlViewFldEN)
{
try
{
objSqlViewFldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSqlViewFldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSqlViewFld.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.mId = objSqlViewFldEN.mId; //mId
}
if (arrFldSet.Contains(conSqlViewFld.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.SqlViewId = objSqlViewFldEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(conSqlViewFld.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.RelaTabId = objSqlViewFldEN.RelaTabId == "[null]" ? null :  objSqlViewFldEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(conSqlViewFld.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.FldId = objSqlViewFldEN.FldId == "[null]" ? null :  objSqlViewFldEN.FldId; //字段Id
}
if (arrFldSet.Contains(conSqlViewFld.FldExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.FldExpression = objSqlViewFldEN.FldExpression == "[null]" ? null :  objSqlViewFldEN.FldExpression; //字段表达式
}
if (arrFldSet.Contains(conSqlViewFld.FldExpressionType, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.FldExpressionType = objSqlViewFldEN.FldExpressionType == "[null]" ? null :  objSqlViewFldEN.FldExpressionType; //FldExpressionType
}
if (arrFldSet.Contains(conSqlViewFld.FieldAliases, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.FieldAliases = objSqlViewFldEN.FieldAliases == "[null]" ? null :  objSqlViewFldEN.FieldAliases; //字段别名
}
if (arrFldSet.Contains(conSqlViewFld.Filters, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.Filters = objSqlViewFldEN.Filters == "[null]" ? null :  objSqlViewFldEN.Filters; //筛选器
}
if (arrFldSet.Contains(conSqlViewFld.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.OrderNum = objSqlViewFldEN.OrderNum; //序号
}
if (arrFldSet.Contains(conSqlViewFld.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.PrjId = objSqlViewFldEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSqlViewFld.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.UpdDate = objSqlViewFldEN.UpdDate == "[null]" ? null :  objSqlViewFldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSqlViewFld.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.UpdUserId = objSqlViewFldEN.UpdUserId == "[null]" ? null :  objSqlViewFldEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSqlViewFld.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewFldEN.Memo = objSqlViewFldEN.Memo == "[null]" ? null :  objSqlViewFldEN.Memo; //说明
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
 /// <param name = "objSqlViewFldEN">源简化对象</param>
 public static void AccessFldValueNull(clsSqlViewFldEN objSqlViewFldEN)
{
try
{
if (objSqlViewFldEN.RelaTabId == "[null]") objSqlViewFldEN.RelaTabId = null; //相关表Id
if (objSqlViewFldEN.FldId == "[null]") objSqlViewFldEN.FldId = null; //字段Id
if (objSqlViewFldEN.FldExpression == "[null]") objSqlViewFldEN.FldExpression = null; //字段表达式
if (objSqlViewFldEN.FldExpressionType == "[null]") objSqlViewFldEN.FldExpressionType = null; //FldExpressionType
if (objSqlViewFldEN.FieldAliases == "[null]") objSqlViewFldEN.FieldAliases = null; //字段别名
if (objSqlViewFldEN.Filters == "[null]") objSqlViewFldEN.Filters = null; //筛选器
if (objSqlViewFldEN.UpdDate == "[null]") objSqlViewFldEN.UpdDate = null; //修改日期
if (objSqlViewFldEN.UpdUserId == "[null]") objSqlViewFldEN.UpdUserId = null; //修改用户Id
if (objSqlViewFldEN.Memo == "[null]") objSqlViewFldEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSqlViewFldEN objSqlViewFldEN)
{
 SqlViewFldDA.CheckPropertyNew(objSqlViewFldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSqlViewFldEN objSqlViewFldEN)
{
 SqlViewFldDA.CheckProperty4Condition(objSqlViewFldEN);
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
if (clsSqlViewFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewFldBL没有刷新缓存机制(clsSqlViewFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrSqlViewFldObjLstCache == null)
//{
//arrSqlViewFldObjLstCache = SqlViewFldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewFldEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
List<clsSqlViewFldEN> arrSqlViewFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewFldEN> arrSqlViewFldObjLst_Sel =
arrSqlViewFldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrSqlViewFldObjLst_Sel.Count() == 0)
{
   clsSqlViewFldEN obj = clsSqlViewFldBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSqlViewFldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewFldEN> GetAllSqlViewFldObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsSqlViewFldEN> arrSqlViewFldObjLstCache = GetObjLstCache(strPrjId); 
return arrSqlViewFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewFldEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsSqlViewFldEN> arrSqlViewFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSqlViewFldObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSqlViewFldEN._RefreshTimeLst.Count == 0) return "";
return clsSqlViewFldEN._RefreshTimeLst[clsSqlViewFldEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewFldBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewFldBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsSqlViewFldBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewFldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSqlViewFldBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SqlViewFld(Sql视图字段)
 /// 唯一性条件:PrjId_SqlViewId_RelaTabId_FldId_FldExpression
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlViewFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSqlViewFldEN objSqlViewFldEN)
{
//检测记录是否存在
string strResult = SqlViewFldDA.GetUniCondStr(objSqlViewFldEN);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conSqlViewFld.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSqlViewFld._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSqlViewFld._AttributeName));
throw new Exception(strMsg);
}
var objSqlViewFld = clsSqlViewFldBL.GetObjBymIdCache(lngmId, strPrjId);
if (objSqlViewFld == null) return "";
return objSqlViewFld[strOutFldName].ToString();
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
int intRecCount = clsSqlViewFldDA.GetRecCount(strTabName);
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
int intRecCount = clsSqlViewFldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSqlViewFldDA.GetRecCount();
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
int intRecCount = clsSqlViewFldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSqlViewFldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSqlViewFldEN objSqlViewFldCond)
{
 string strPrjId = objSqlViewFldCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSqlViewFldBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSqlViewFldEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewFldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlViewFld._AttributeName)
{
if (objSqlViewFldCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewFldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewFldCond[strFldName].ToString());
}
else
{
if (objSqlViewFldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewFldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewFldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewFldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewFldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewFldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewFldCond[strFldName]));
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
 List<string> arrList = clsSqlViewFldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SqlViewFldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SqlViewFldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SqlViewFldDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewFldDA.SetFldValue(clsSqlViewFldEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SqlViewFldDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewFldDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewFldDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewFldDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SqlViewFld] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**Sql视图Id*/ 
 strCreateTabCode.Append(" SqlViewId char(8) not Null, "); 
 // /**相关表Id*/ 
 strCreateTabCode.Append(" RelaTabId char(8) Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**字段表达式*/ 
 strCreateTabCode.Append(" FldExpression varchar(500) Null, "); 
 // /**FldExpressionType*/ 
 strCreateTabCode.Append(" FldExpressionType varchar(50) Null, "); 
 // /**字段别名*/ 
 strCreateTabCode.Append(" FieldAliases varchar(50) Null, "); 
 // /**筛选器*/ 
 strCreateTabCode.Append(" Filters varchar(50) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// Sql视图字段(SqlViewFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SqlViewFld : clsCommFun4BLV2
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
clsSqlViewFldBL.ReFreshThisCache(strPrjId);
}
}

}