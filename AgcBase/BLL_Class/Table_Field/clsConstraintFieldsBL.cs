
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConstraintFieldsBL
 表名:ConstraintFields(00050334)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsConstraintFieldsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConstraintFieldsEN GetObj(this K_mId_ConstraintFields myKey)
{
clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsBL.ConstraintFieldsDA.GetObjBymId(myKey.Value);
return objConstraintFieldsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConstraintFieldsEN objConstraintFieldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConstraintFieldsEN) == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecord)", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.AddNewRecordBySQL2(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
public static bool AddRecordEx(this clsConstraintFieldsEN objConstraintFieldsEN, bool bolIsNeedCheckUniqueness = true)
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
objConstraintFieldsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objConstraintFieldsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(约束表Id(PrjConstraintId)=[{0}],字段Id(FldId)=[{1}])已经存在,不能重复!", objConstraintFieldsEN.PrjConstraintId, objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objConstraintFieldsEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithTransaction)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConstraintFieldsEN) == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecord(SqlTransaction))", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.AddNewRecordBySQL2(objConstraintFieldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsConstraintFieldsEN objConstraintFieldsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConstraintFieldsEN) == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecordWithReturnKey)", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsConstraintFieldsBL.ConstraintFieldsDA.AddNewRecordBySQL2WithReturnKey(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConstraintFieldsEN) == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecordWithReturnKey)", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = clsConstraintFieldsBL.ConstraintFieldsDA.AddNewRecordBySQL2WithReturnKey(objConstraintFieldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetmId(this clsConstraintFieldsEN objConstraintFieldsEN, long lngmId, string strComparisonOp="")
	{
objConstraintFieldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.mId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.mId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.mId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetPrjConstraintId(this clsConstraintFieldsEN objConstraintFieldsEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjConstraintId, conConstraintFields.PrjConstraintId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, conConstraintFields.PrjConstraintId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, conConstraintFields.PrjConstraintId);
}
objConstraintFieldsEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.PrjConstraintId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.PrjConstraintId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.PrjConstraintId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetTabId(this clsConstraintFieldsEN objConstraintFieldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conConstraintFields.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conConstraintFields.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conConstraintFields.TabId);
}
objConstraintFieldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.TabId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.TabId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.TabId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetFldId(this clsConstraintFieldsEN objConstraintFieldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conConstraintFields.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conConstraintFields.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conConstraintFields.FldId);
}
objConstraintFieldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.FldId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.FldId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.FldId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMaxValue(this clsConstraintFieldsEN objConstraintFieldsEN, string strMaxValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMaxValue, 50, conConstraintFields.MaxValue);
}
objConstraintFieldsEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.MaxValue) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.MaxValue, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.MaxValue] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMinValue(this clsConstraintFieldsEN objConstraintFieldsEN, string strMinValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMinValue, 50, conConstraintFields.MinValue);
}
objConstraintFieldsEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.MinValue) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.MinValue, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.MinValue] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetSortTypeId(this clsConstraintFieldsEN objConstraintFieldsEN, string strSortTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeId, conConstraintFields.SortTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSortTypeId, 2, conConstraintFields.SortTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSortTypeId, 2, conConstraintFields.SortTypeId);
}
objConstraintFieldsEN.SortTypeId = strSortTypeId; //排序类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.SortTypeId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.SortTypeId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.SortTypeId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetInUse(this clsConstraintFieldsEN objConstraintFieldsEN, bool bolInUse, string strComparisonOp="")
	{
objConstraintFieldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.InUse) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.InUse, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.InUse] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetOrderNum(this clsConstraintFieldsEN objConstraintFieldsEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conConstraintFields.OrderNum);
objConstraintFieldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.OrderNum) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.OrderNum, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.OrderNum] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetPrjId(this clsConstraintFieldsEN objConstraintFieldsEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conConstraintFields.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conConstraintFields.PrjId);
}
objConstraintFieldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.PrjId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.PrjId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.PrjId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetUpdDate(this clsConstraintFieldsEN objConstraintFieldsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conConstraintFields.UpdDate);
}
objConstraintFieldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.UpdDate) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.UpdDate, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.UpdDate] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetUpdUser(this clsConstraintFieldsEN objConstraintFieldsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conConstraintFields.UpdUser);
}
objConstraintFieldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.UpdUser) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.UpdUser, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.UpdUser] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMemo(this clsConstraintFieldsEN objConstraintFieldsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conConstraintFields.Memo);
}
objConstraintFieldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.Memo) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.Memo, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.Memo] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsConstraintFieldsEN objConstraintFieldsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objConstraintFieldsEN.CheckPropertyNew();
clsConstraintFieldsEN objConstraintFieldsCond = new clsConstraintFieldsEN();
string strCondition = objConstraintFieldsCond
.SetmId(objConstraintFieldsEN.mId, "<>")
.SetPrjConstraintId(objConstraintFieldsEN.PrjConstraintId, "=")
.SetFldId(objConstraintFieldsEN.FldId, "=")
.GetCombineCondition();
objConstraintFieldsEN._IsCheckProperty = true;
bool bolIsExist = clsConstraintFieldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(在一个表中，约束名和字段名组合唯一。即同一个约束名只能有唯一的一个字段名)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objConstraintFieldsEN.Update();
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
 /// <param name = "objConstraintFields">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsConstraintFieldsEN objConstraintFields)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsConstraintFieldsEN objConstraintFieldsCond = new clsConstraintFieldsEN();
string strCondition = objConstraintFieldsCond
.SetPrjConstraintId(objConstraintFields.PrjConstraintId, "=")
.SetFldId(objConstraintFields.FldId, "=")
.GetCombineCondition();
objConstraintFields._IsCheckProperty = true;
bool bolIsExist = clsConstraintFieldsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objConstraintFields.mId = clsConstraintFieldsBL.GetFirstID_S(strCondition);
objConstraintFields.UpdateWithCondition(strCondition);
}
else
{
objConstraintFields.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConstraintFieldsEN objConstraintFieldsEN)
{
 if (objConstraintFieldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.UpdateBySql2(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(this clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConstraintFieldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000066)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.UpdateBySql2(objConstraintFieldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConstraintFieldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.UpdateBySql2(objConstraintFieldsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConstraintFieldsEN objConstraintFieldsEN, string strWhereCond)
{
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.UpdateBySqlWithCondition(objConstraintFieldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConstraintFieldsEN objConstraintFieldsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsConstraintFieldsBL.ConstraintFieldsDA.UpdateBySqlWithConditionTransaction(objConstraintFieldsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
public static int Delete(this clsConstraintFieldsEN objConstraintFieldsEN)
{
try
{
int intRecNum = clsConstraintFieldsBL.ConstraintFieldsDA.DelRecord(objConstraintFieldsEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsENS">源对象</param>
 /// <param name = "objConstraintFieldsENT">目标对象</param>
 public static void CopyTo(this clsConstraintFieldsEN objConstraintFieldsENS, clsConstraintFieldsEN objConstraintFieldsENT)
{
try
{
objConstraintFieldsENT.mId = objConstraintFieldsENS.mId; //mId
objConstraintFieldsENT.PrjConstraintId = objConstraintFieldsENS.PrjConstraintId; //约束表Id
objConstraintFieldsENT.TabId = objConstraintFieldsENS.TabId; //表ID
objConstraintFieldsENT.FldId = objConstraintFieldsENS.FldId; //字段Id
objConstraintFieldsENT.MaxValue = objConstraintFieldsENS.MaxValue; //最大值
objConstraintFieldsENT.MinValue = objConstraintFieldsENS.MinValue; //最小值
objConstraintFieldsENT.SortTypeId = objConstraintFieldsENS.SortTypeId; //排序类型Id
objConstraintFieldsENT.InUse = objConstraintFieldsENS.InUse; //是否在用
objConstraintFieldsENT.OrderNum = objConstraintFieldsENS.OrderNum; //序号
objConstraintFieldsENT.PrjId = objConstraintFieldsENS.PrjId; //工程Id
objConstraintFieldsENT.UpdDate = objConstraintFieldsENS.UpdDate; //修改日期
objConstraintFieldsENT.UpdUser = objConstraintFieldsENS.UpdUser; //修改者
objConstraintFieldsENT.Memo = objConstraintFieldsENS.Memo; //说明
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
 /// <param name = "objConstraintFieldsENS">源对象</param>
 /// <returns>目标对象=>clsConstraintFieldsEN:objConstraintFieldsENT</returns>
 public static clsConstraintFieldsEN CopyTo(this clsConstraintFieldsEN objConstraintFieldsENS)
{
try
{
 clsConstraintFieldsEN objConstraintFieldsENT = new clsConstraintFieldsEN()
{
mId = objConstraintFieldsENS.mId, //mId
PrjConstraintId = objConstraintFieldsENS.PrjConstraintId, //约束表Id
TabId = objConstraintFieldsENS.TabId, //表ID
FldId = objConstraintFieldsENS.FldId, //字段Id
MaxValue = objConstraintFieldsENS.MaxValue, //最大值
MinValue = objConstraintFieldsENS.MinValue, //最小值
SortTypeId = objConstraintFieldsENS.SortTypeId, //排序类型Id
InUse = objConstraintFieldsENS.InUse, //是否在用
OrderNum = objConstraintFieldsENS.OrderNum, //序号
PrjId = objConstraintFieldsENS.PrjId, //工程Id
UpdDate = objConstraintFieldsENS.UpdDate, //修改日期
UpdUser = objConstraintFieldsENS.UpdUser, //修改者
Memo = objConstraintFieldsENS.Memo, //说明
};
 return objConstraintFieldsENT;
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
public static void CheckPropertyNew(this clsConstraintFieldsEN objConstraintFieldsEN)
{
 clsConstraintFieldsBL.ConstraintFieldsDA.CheckPropertyNew(objConstraintFieldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsConstraintFieldsEN objConstraintFieldsEN)
{
 clsConstraintFieldsBL.ConstraintFieldsDA.CheckProperty4Condition(objConstraintFieldsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsConstraintFieldsEN objConstraintFieldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.mId) == true)
{
string strComparisonOpmId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conConstraintFields.mId, objConstraintFieldsCond.mId, strComparisonOpmId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.PrjConstraintId, objConstraintFieldsCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.TabId) == true)
{
string strComparisonOpTabId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.TabId, objConstraintFieldsCond.TabId, strComparisonOpTabId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.FldId) == true)
{
string strComparisonOpFldId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.FldId, objConstraintFieldsCond.FldId, strComparisonOpFldId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.MaxValue) == true)
{
string strComparisonOpMaxValue = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.MaxValue, objConstraintFieldsCond.MaxValue, strComparisonOpMaxValue);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.MinValue) == true)
{
string strComparisonOpMinValue = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.MinValue, objConstraintFieldsCond.MinValue, strComparisonOpMinValue);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.SortTypeId) == true)
{
string strComparisonOpSortTypeId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.SortTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.SortTypeId, objConstraintFieldsCond.SortTypeId, strComparisonOpSortTypeId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.InUse) == true)
{
if (objConstraintFieldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conConstraintFields.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conConstraintFields.InUse);
}
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.OrderNum) == true)
{
string strComparisonOpOrderNum = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conConstraintFields.OrderNum, objConstraintFieldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.PrjId) == true)
{
string strComparisonOpPrjId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.PrjId, objConstraintFieldsCond.PrjId, strComparisonOpPrjId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.UpdDate) == true)
{
string strComparisonOpUpdDate = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.UpdDate, objConstraintFieldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.UpdUser) == true)
{
string strComparisonOpUpdUser = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.UpdUser, objConstraintFieldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.Memo) == true)
{
string strComparisonOpMemo = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.Memo, objConstraintFieldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ConstraintFields(约束字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:Uni_ConstraintField
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsConstraintFieldsEN objConstraintFieldsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objConstraintFieldsEN == null) return true;
if (objConstraintFieldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
if (clsConstraintFieldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objConstraintFieldsEN.mId);
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
if (clsConstraintFieldsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ConstraintFields(约束字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Uni_ConstraintField
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsConstraintFieldsEN objConstraintFieldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objConstraintFieldsEN == null) return "";
if (objConstraintFieldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objConstraintFieldsEN.mId);
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ConstraintFields
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 约束字段(ConstraintFields)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsConstraintFieldsBL
{
public static RelatedActions_ConstraintFields relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsConstraintFieldsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsConstraintFieldsDA ConstraintFieldsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsConstraintFieldsDA();
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
 public clsConstraintFieldsBL()
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
if (string.IsNullOrEmpty(clsConstraintFieldsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConstraintFieldsEN._ConnectString);
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
public static DataTable GetDataTable_ConstraintFields(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ConstraintFieldsDA.GetDataTable_ConstraintFields(strWhereCond);
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
objDT = ConstraintFieldsDA.GetDataTable(strWhereCond);
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
objDT = ConstraintFieldsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ConstraintFieldsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ConstraintFieldsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ConstraintFieldsDA.GetDataTable_Top(objTopPara);
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
objDT = ConstraintFieldsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ConstraintFieldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ConstraintFieldsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsConstraintFieldsEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
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
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsConstraintFieldsEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrConstraintFieldsObjLst_Sel =
arrConstraintFieldsObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrConstraintFieldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLst(string strWhereCond)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
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
public static List<clsConstraintFieldsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objConstraintFieldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsConstraintFieldsEN> GetSubObjLstCache(clsConstraintFieldsEN objConstraintFieldsCond)
{
 string strPrjId = objConstraintFieldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsConstraintFieldsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsConstraintFieldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConstraintFields._AttributeName)
{
if (objConstraintFieldsCond.IsUpdated(strFldName) == false) continue;
if (objConstraintFieldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConstraintFieldsCond[strFldName].ToString());
}
else
{
if (objConstraintFieldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConstraintFieldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConstraintFieldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConstraintFieldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConstraintFieldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConstraintFieldsCond[strFldName]));
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
public static List<clsConstraintFieldsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
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
public static List<clsConstraintFieldsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
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
List<clsConstraintFieldsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsConstraintFieldsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsConstraintFieldsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
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
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
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
public static List<clsConstraintFieldsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsConstraintFieldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
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
public static List<clsConstraintFieldsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConstraintFieldsEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetConstraintFields(ref clsConstraintFieldsEN objConstraintFieldsEN)
{
bool bolResult = ConstraintFieldsDA.GetConstraintFields(ref objConstraintFieldsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConstraintFieldsEN GetObjBymId(long lngmId)
{
clsConstraintFieldsEN objConstraintFieldsEN = ConstraintFieldsDA.GetObjBymId(lngmId);
return objConstraintFieldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsConstraintFieldsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsConstraintFieldsEN objConstraintFieldsEN = ConstraintFieldsDA.GetFirstObj(strWhereCond);
 return objConstraintFieldsEN;
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
public static clsConstraintFieldsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsConstraintFieldsEN objConstraintFieldsEN = ConstraintFieldsDA.GetObjByDataRow(objRow);
 return objConstraintFieldsEN;
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
public static clsConstraintFieldsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsConstraintFieldsEN objConstraintFieldsEN = ConstraintFieldsDA.GetObjByDataRow(objRow);
 return objConstraintFieldsEN;
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
 /// <param name = "lstConstraintFieldsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConstraintFieldsEN GetObjBymIdFromList(long lngmId, List<clsConstraintFieldsEN> lstConstraintFieldsObjLst)
{
foreach (clsConstraintFieldsEN objConstraintFieldsEN in lstConstraintFieldsObjLst)
{
if (objConstraintFieldsEN.mId == lngmId)
{
return objConstraintFieldsEN;
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
 lngmId = new clsConstraintFieldsDA().GetFirstID(strWhereCond);
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
 arrList = ConstraintFieldsDA.GetID(strWhereCond);
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
bool bolIsExist = ConstraintFieldsDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ConstraintFieldsDA.IsExist(lngmId);
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
clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsBL.GetObjBymId(lngmId);
objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objConstraintFieldsEN.UpdUser = strOpUser;
return clsConstraintFieldsBL.UpdateBySql2(objConstraintFieldsEN);
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
 bolIsExist = clsConstraintFieldsDA.IsExistTable();
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
 bolIsExist = ConstraintFieldsDA.IsExistTable(strTabName);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsConstraintFieldsEN objConstraintFieldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConstraintFieldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecordBySql2)", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ConstraintFieldsDA.AddNewRecordBySQL2(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsConstraintFieldsEN objConstraintFieldsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConstraintFieldsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!约束表Id = [{0}],字段Id = [{1}]的数据已经存在!(in clsConstraintFieldsBL.AddNewRecordBySql2WithReturnKey)", objConstraintFieldsEN.PrjConstraintId,objConstraintFieldsEN.FldId);
throw new Exception(strMsg);
}
try
{
string strKey = ConstraintFieldsDA.AddNewRecordBySQL2WithReturnKey(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsConstraintFieldsEN objConstraintFieldsEN)
{
try
{
bool bolResult = ConstraintFieldsDA.Update(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsConstraintFieldsEN objConstraintFieldsEN)
{
 if (objConstraintFieldsEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ConstraintFieldsDA.UpdateBySql2(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsBL.ReFreshCache(objConstraintFieldsEN.PrjId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
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
 clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsBL.GetObjBymId(lngmId);

if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(objConstraintFieldsEN.mId, objConstraintFieldsEN.UpdUser);
}
if (objConstraintFieldsEN != null)
{
int intRecNum = ConstraintFieldsDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConstraintFieldsEN.PrjId);
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
objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
//删除与表:[ConstraintFields]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conConstraintFields.mId,
//lngmId);
//        clsConstraintFieldsBL.DelConstraintFieldssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConstraintFieldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConstraintFieldsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsConstraintFieldsBL.relatedActions != null)
{
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ConstraintFieldsDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelConstraintFieldss(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsConstraintFieldsBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ConstraintFieldsDA.DelConstraintFields(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConstraintFieldsEN.PrjId);
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
public static int DelConstraintFieldssByCond(string strWhereCond)
{
try
{
if (clsConstraintFieldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conConstraintFields.PrjId, strWhereCond);
int intRecNum = ConstraintFieldsDA.DelConstraintFields(strWhereCond);
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
public static bool DelConstraintFieldssByCondWithTransaction_S(string strWhereCond, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsConstraintFieldsBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsConstraintFieldsBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
bool bolResult = ConstraintFieldsDA.DelConstraintFieldsWithTransaction_S(strWhereCond, objSqlConnection, objSqlTransaction);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ConstraintFields]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
//删除与表:[ConstraintFields]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConstraintFieldsBL.DelRecord(lngmId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConstraintFieldsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objConstraintFieldsENS">源对象</param>
 /// <param name = "objConstraintFieldsENT">目标对象</param>
 public static void CopyTo(clsConstraintFieldsEN objConstraintFieldsENS, clsConstraintFieldsEN objConstraintFieldsENT)
{
try
{
objConstraintFieldsENT.mId = objConstraintFieldsENS.mId; //mId
objConstraintFieldsENT.PrjConstraintId = objConstraintFieldsENS.PrjConstraintId; //约束表Id
objConstraintFieldsENT.TabId = objConstraintFieldsENS.TabId; //表ID
objConstraintFieldsENT.FldId = objConstraintFieldsENS.FldId; //字段Id
objConstraintFieldsENT.MaxValue = objConstraintFieldsENS.MaxValue; //最大值
objConstraintFieldsENT.MinValue = objConstraintFieldsENS.MinValue; //最小值
objConstraintFieldsENT.SortTypeId = objConstraintFieldsENS.SortTypeId; //排序类型Id
objConstraintFieldsENT.InUse = objConstraintFieldsENS.InUse; //是否在用
objConstraintFieldsENT.OrderNum = objConstraintFieldsENS.OrderNum; //序号
objConstraintFieldsENT.PrjId = objConstraintFieldsENS.PrjId; //工程Id
objConstraintFieldsENT.UpdDate = objConstraintFieldsENS.UpdDate; //修改日期
objConstraintFieldsENT.UpdUser = objConstraintFieldsENS.UpdUser; //修改者
objConstraintFieldsENT.Memo = objConstraintFieldsENS.Memo; //说明
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
 /// <param name = "objConstraintFieldsEN">源简化对象</param>
 public static void SetUpdFlag(clsConstraintFieldsEN objConstraintFieldsEN)
{
try
{
objConstraintFieldsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objConstraintFieldsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conConstraintFields.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.mId = objConstraintFieldsEN.mId; //mId
}
if (arrFldSet.Contains(conConstraintFields.PrjConstraintId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.PrjConstraintId = objConstraintFieldsEN.PrjConstraintId; //约束表Id
}
if (arrFldSet.Contains(conConstraintFields.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.TabId = objConstraintFieldsEN.TabId; //表ID
}
if (arrFldSet.Contains(conConstraintFields.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.FldId = objConstraintFieldsEN.FldId; //字段Id
}
if (arrFldSet.Contains(conConstraintFields.MaxValue, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.MaxValue = objConstraintFieldsEN.MaxValue == "[null]" ? null :  objConstraintFieldsEN.MaxValue; //最大值
}
if (arrFldSet.Contains(conConstraintFields.MinValue, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.MinValue = objConstraintFieldsEN.MinValue == "[null]" ? null :  objConstraintFieldsEN.MinValue; //最小值
}
if (arrFldSet.Contains(conConstraintFields.SortTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.SortTypeId = objConstraintFieldsEN.SortTypeId; //排序类型Id
}
if (arrFldSet.Contains(conConstraintFields.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.InUse = objConstraintFieldsEN.InUse; //是否在用
}
if (arrFldSet.Contains(conConstraintFields.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.OrderNum = objConstraintFieldsEN.OrderNum; //序号
}
if (arrFldSet.Contains(conConstraintFields.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.PrjId = objConstraintFieldsEN.PrjId == "[null]" ? null :  objConstraintFieldsEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conConstraintFields.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.UpdDate = objConstraintFieldsEN.UpdDate == "[null]" ? null :  objConstraintFieldsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conConstraintFields.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.UpdUser = objConstraintFieldsEN.UpdUser == "[null]" ? null :  objConstraintFieldsEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conConstraintFields.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objConstraintFieldsEN.Memo = objConstraintFieldsEN.Memo == "[null]" ? null :  objConstraintFieldsEN.Memo; //说明
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
 /// <param name = "objConstraintFieldsEN">源简化对象</param>
 public static void AccessFldValueNull(clsConstraintFieldsEN objConstraintFieldsEN)
{
try
{
if (objConstraintFieldsEN.MaxValue == "[null]") objConstraintFieldsEN.MaxValue = null; //最大值
if (objConstraintFieldsEN.MinValue == "[null]") objConstraintFieldsEN.MinValue = null; //最小值
if (objConstraintFieldsEN.PrjId == "[null]") objConstraintFieldsEN.PrjId = null; //工程Id
if (objConstraintFieldsEN.UpdDate == "[null]") objConstraintFieldsEN.UpdDate = null; //修改日期
if (objConstraintFieldsEN.UpdUser == "[null]") objConstraintFieldsEN.UpdUser = null; //修改者
if (objConstraintFieldsEN.Memo == "[null]") objConstraintFieldsEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsConstraintFieldsEN objConstraintFieldsEN)
{
 ConstraintFieldsDA.CheckPropertyNew(objConstraintFieldsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsConstraintFieldsEN objConstraintFieldsEN)
{
 ConstraintFieldsDA.CheckProperty4Condition(objConstraintFieldsEN);
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
if (clsConstraintFieldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConstraintFieldsBL没有刷新缓存机制(clsConstraintFieldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrConstraintFieldsObjLstCache == null)
//{
//arrConstraintFieldsObjLstCache = ConstraintFieldsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConstraintFieldsEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrConstraintFieldsObjLst_Sel =
arrConstraintFieldsObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrConstraintFieldsObjLst_Sel.Count() == 0)
{
   clsConstraintFieldsEN obj = clsConstraintFieldsBL.GetObjBymId(lngmId);
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
return arrConstraintFieldsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConstraintFieldsEN> GetAllConstraintFieldsObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = GetObjLstCache(strPrjId); 
return arrConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrConstraintFieldsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsConstraintFieldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsConstraintFieldsEN._RefreshTimeLst.Count == 0) return "";
return clsConstraintFieldsEN._RefreshTimeLst[clsConstraintFieldsEN._RefreshTimeLst.Count - 1];
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
if (clsConstraintFieldsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsConstraintFieldsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsConstraintFieldsBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ConstraintFields(约束字段)
 /// 唯一性条件:Uni_ConstraintField
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsConstraintFieldsEN objConstraintFieldsEN)
{
//检测记录是否存在
string strResult = ConstraintFieldsDA.GetUniCondStr(objConstraintFieldsEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != conConstraintFields.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conConstraintFields._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conConstraintFields._AttributeName));
throw new Exception(strMsg);
}
var objConstraintFields = clsConstraintFieldsBL.GetObjBymIdCache(lngmId, strPrjId);
if (objConstraintFields == null) return "";
return objConstraintFields[strOutFldName].ToString();
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
int intRecCount = clsConstraintFieldsDA.GetRecCount(strTabName);
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
int intRecCount = clsConstraintFieldsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsConstraintFieldsDA.GetRecCount();
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
int intRecCount = clsConstraintFieldsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objConstraintFieldsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsConstraintFieldsEN objConstraintFieldsCond)
{
 string strPrjId = objConstraintFieldsCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsConstraintFieldsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsConstraintFieldsEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConstraintFields._AttributeName)
{
if (objConstraintFieldsCond.IsUpdated(strFldName) == false) continue;
if (objConstraintFieldsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConstraintFieldsCond[strFldName].ToString());
}
else
{
if (objConstraintFieldsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConstraintFieldsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConstraintFieldsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConstraintFieldsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConstraintFieldsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConstraintFieldsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConstraintFieldsCond[strFldName]));
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
 List<string> arrList = clsConstraintFieldsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ConstraintFieldsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ConstraintFieldsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ConstraintFieldsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsConstraintFieldsDA.SetFldValue(clsConstraintFieldsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ConstraintFieldsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsConstraintFieldsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsConstraintFieldsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsConstraintFieldsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ConstraintFields] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**约束表Id*/ 
 strCreateTabCode.Append(" PrjConstraintId char(8) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) not Null, "); 
 // /**最大值*/ 
 strCreateTabCode.Append(" MaxValue varchar(50) Null, "); 
 // /**最小值*/ 
 strCreateTabCode.Append(" MinValue varchar(50) Null, "); 
 // /**排序类型Id*/ 
 strCreateTabCode.Append(" SortTypeId char(2) not Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**约束名*/ 
 strCreateTabCode.Append(" ConstraintName varchar(100) Null, "); 
 // /**排序类型名称*/ 
 strCreateTabCode.Append(" SortTypeName varchar(30) Null, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：PrjConstraintId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strPrjConstraintId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strPrjConstraintId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);
 strCondition += string.Format(" order by OrderNum ");
List<clsConstraintFieldsEN> arrConstraintFieldsObjList = new clsConstraintFieldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsConstraintFieldsEN objConstraintFields in arrConstraintFieldsObjList)
{
objConstraintFields.OrderNum = intIndex;
UpdateBySql2(objConstraintFields);
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
/// 调整所给关键字记录的序号。根据分类字段：PrjConstraintId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <param name="strPrjConstraintId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId ,string strPrjConstraintId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsConstraintFieldsEN objConstraintFields = clsConstraintFieldsBL.GetObjBymId(lngmId);

intOrderNum = objConstraintFields.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);
intTabRecNum = clsConstraintFieldsBL.GetRecCountByCond(clsConstraintFieldsEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conConstraintFields.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsConstraintFieldsBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsConstraintFieldsBL.SetFldValue(clsConstraintFieldsEN._CurrTabName, conConstraintFields.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conConstraintFields.mId, lngmId));
clsConstraintFieldsBL.SetFldValue(clsConstraintFieldsEN._CurrTabName, conConstraintFields.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conConstraintFields.mId, lngPrevmId));
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

//4、获取下一个序号字段的关键字mId
sbCondition.AppendFormat(" {0} = {1} ", conConstraintFields.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);

lngNextmId = clsConstraintFieldsBL.GetFirstID_S(sbCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsConstraintFieldsBL.SetFldValue(clsConstraintFieldsEN._CurrTabName, conConstraintFields.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conConstraintFields.mId, lngmId));
clsConstraintFieldsBL.SetFldValue(clsConstraintFieldsEN._CurrTabName, conConstraintFields.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conConstraintFields.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjConstraintId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,string strPrjConstraintId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conConstraintFields.mId, strKeyList);
List<clsConstraintFieldsEN> arrConstraintFieldsLst = GetObjLst(strCondition);
foreach (clsConstraintFieldsEN objConstraintFields in arrConstraintFieldsLst)
{
objConstraintFields.OrderNum = objConstraintFields.OrderNum + 10000;
UpdateBySql2(objConstraintFields);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);
 strCondition += string.Format(" order by OrderNum ");
List<clsConstraintFieldsEN> arrConstraintFieldsObjList = new clsConstraintFieldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsConstraintFieldsEN objConstraintFields in arrConstraintFieldsObjList)
{
objConstraintFields.OrderNum = intIndex;
UpdateBySql2(objConstraintFields);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjConstraintId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strPrjConstraintId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,string strPrjConstraintId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conConstraintFields.mId, strKeyList);
List<clsConstraintFieldsEN> arrConstraintFieldsLst = GetObjLst(strCondition);
foreach (clsConstraintFieldsEN objConstraintFields in arrConstraintFieldsLst)
{
objConstraintFields.OrderNum = objConstraintFields.OrderNum - 10000;
UpdateBySql2(objConstraintFields);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conConstraintFields.PrjConstraintId, strPrjConstraintId);
 strCondition += string.Format(" order by OrderNum ");
List<clsConstraintFieldsEN> arrConstraintFieldsObjList = new clsConstraintFieldsDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsConstraintFieldsEN objConstraintFields in arrConstraintFieldsObjList)
{
objConstraintFields.OrderNum = intIndex;
UpdateBySql2(objConstraintFields);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 约束字段(ConstraintFields)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ConstraintFields : clsCommFun4BLV2
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
clsConstraintFieldsBL.ReFreshThisCache(strPrjId);
}
}

}