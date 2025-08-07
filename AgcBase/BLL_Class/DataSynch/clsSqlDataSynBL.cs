
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlDataSynBL
 表名:SqlDataSyn(00050269)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
public static class  clsSqlDataSynBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlDataSynEN GetObj(this K_TabId_SqlDataSyn myKey)
{
clsSqlDataSynEN objSqlDataSynEN = clsSqlDataSynBL.SqlDataSynDA.GetObjByTabId(myKey.Value);
return objSqlDataSynEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlDataSynEN objSqlDataSynEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSqlDataSynBL.IsExist(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSqlDataSynEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSqlDataSynBL.SqlDataSynDA.AddNewRecordBySQL2(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
public static bool AddRecordEx(this clsSqlDataSynEN objSqlDataSynEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSqlDataSynBL.IsExist(objSqlDataSynEN.TabId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSqlDataSynEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSqlDataSynEN.AddNewRecord();
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSqlDataSynEN objSqlDataSynEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSqlDataSynBL.IsExist(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSqlDataSynEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSqlDataSynBL.SqlDataSynDA.AddNewRecordBySQL2WithReturnKey(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabId(this clsSqlDataSynEN objSqlDataSynEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conSqlDataSyn.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conSqlDataSyn.TabId);
}
objSqlDataSynEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabName(this clsSqlDataSynEN objSqlDataSynEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conSqlDataSyn.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conSqlDataSyn.TabName);
}
objSqlDataSynEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabCnName(this clsSqlDataSynEN objSqlDataSynEN, string strTabCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabCnName, conSqlDataSyn.TabCnName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, conSqlDataSyn.TabCnName);
}
objSqlDataSynEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabCnName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabCnName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabCnName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTabEnName(this clsSqlDataSynEN objSqlDataSynEN, string strTabEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabEnName, 200, conSqlDataSyn.TabEnName);
}
objSqlDataSynEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TabEnName) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TabEnName, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TabEnName] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlData(this clsSqlDataSynEN objSqlDataSynEN, string strSqlData, string strComparisonOp="")
	{
objSqlDataSynEN.SqlData = strSqlData; //Sql表数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlData) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlData, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlData] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlCommandTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strSqlCommandTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
}
objSqlDataSynEN.SqlCommandTypeId = strSqlCommandTypeId; //Sql命令类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlCommandTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlCommandTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlCommandTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlCommandText(this clsSqlDataSynEN objSqlDataSynEN, string strSqlCommandText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlCommandText, 200, conSqlDataSyn.SqlCommandText);
}
objSqlDataSynEN.SqlCommandText = strSqlCommandText; //Sql命令内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlCommandText) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlCommandText, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlCommandText] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetSqlDataRecNum(this clsSqlDataSynEN objSqlDataSynEN, int? intSqlDataRecNum, string strComparisonOp="")
	{
objSqlDataSynEN.SqlDataRecNum = intSqlDataRecNum; //Sql数据记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.SqlDataRecNum) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.SqlDataRecNum, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.SqlDataRecNum] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTargetTabCondition(this clsSqlDataSynEN objSqlDataSynEN, string strTargetTabCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetTabCondition, 300, conSqlDataSyn.TargetTabCondition);
}
objSqlDataSynEN.TargetTabCondition = strTargetTabCondition; //目标表有效记录条件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TargetTabCondition) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TargetTabCondition, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TargetTabCondition] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTargetTabRecNum(this clsSqlDataSynEN objSqlDataSynEN, int? intTargetTabRecNum, string strComparisonOp="")
	{
objSqlDataSynEN.TargetTabRecNum = intTargetTabRecNum; //目标表记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TargetTabRecNum) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TargetTabRecNum, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TargetTabRecNum] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetDataSynDate(this clsSqlDataSynEN objSqlDataSynEN, string strDataSynDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataSynDate, 14, conSqlDataSyn.DataSynDate);
}
objSqlDataSynEN.DataSynDate = strDataSynDate; //数据同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.DataSynDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.DataSynDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.DataSynDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetPrimaryTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, conSqlDataSyn.PrimaryTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
}
objSqlDataSynEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.PrimaryTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.PrimaryTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.PrimaryTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetRecExclusiveWayId(this clsSqlDataSynEN objSqlDataSynEN, string strRecExclusiveWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
}
objSqlDataSynEN.RecExclusiveWayId = strRecExclusiveWayId; //记录排他方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.RecExclusiveWayId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.RecExclusiveWayId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.RecExclusiveWayId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTextResouce(this clsSqlDataSynEN objSqlDataSynEN, string strTextResouce, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResouce, 100, conSqlDataSyn.TextResouce);
}
objSqlDataSynEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TextResouce) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TextResouce, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TextResouce] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetTextResourceTypeId(this clsSqlDataSynEN objSqlDataSynEN, string strTextResourceTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
}
objSqlDataSynEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.TextResourceTypeId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.TextResourceTypeId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.TextResourceTypeId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetAnalysisDate(this clsSqlDataSynEN objSqlDataSynEN, string strAnalysisDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, conSqlDataSyn.AnalysisDate);
}
objSqlDataSynEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.AnalysisDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.AnalysisDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.AnalysisDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetPrjId(this clsSqlDataSynEN objSqlDataSynEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlDataSyn.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlDataSyn.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlDataSyn.PrjId);
}
objSqlDataSynEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.PrjId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.PrjId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.PrjId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetErrMsg(this clsSqlDataSynEN objSqlDataSynEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conSqlDataSyn.ErrMsg);
}
objSqlDataSynEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.ErrMsg) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.ErrMsg, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.ErrMsg] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetUpdDate(this clsSqlDataSynEN objSqlDataSynEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlDataSyn.UpdDate);
}
objSqlDataSynEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.UpdDate) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.UpdDate, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.UpdDate] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetUpdUserId(this clsSqlDataSynEN objSqlDataSynEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlDataSyn.UpdUserId);
}
objSqlDataSynEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.UpdUserId) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.UpdUserId, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.UpdUserId] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlDataSynEN SetMemo(this clsSqlDataSynEN objSqlDataSynEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlDataSyn.Memo);
}
objSqlDataSynEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlDataSynEN.dicFldComparisonOp.ContainsKey(conSqlDataSyn.Memo) == false)
{
objSqlDataSynEN.dicFldComparisonOp.Add(conSqlDataSyn.Memo, strComparisonOp);
}
else
{
objSqlDataSynEN.dicFldComparisonOp[conSqlDataSyn.Memo] = strComparisonOp;
}
}
return objSqlDataSynEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSqlDataSynEN objSqlDataSynEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSqlDataSynEN.CheckPropertyNew();
clsSqlDataSynEN objSqlDataSynCond = new clsSqlDataSynEN();
string strCondition = objSqlDataSynCond
.SetTabId(objSqlDataSynEN.TabId, "=")
.GetCombineCondition();
objSqlDataSynEN._IsCheckProperty = true;
bool bolIsExist = clsSqlDataSynBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSqlDataSynEN.Update();
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlDataSynEN objSqlDataSynEN)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlDataSynBL.SqlDataSynDA.UpdateBySql2(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlDataSynEN objSqlDataSynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlDataSynBL.SqlDataSynDA.UpdateBySql2(objSqlDataSynEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlDataSynEN objSqlDataSynEN, string strWhereCond)
{
try
{
bool bolResult = clsSqlDataSynBL.SqlDataSynDA.UpdateBySqlWithCondition(objSqlDataSynEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlDataSynEN objSqlDataSynEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSqlDataSynBL.SqlDataSynDA.UpdateBySqlWithConditionTransaction(objSqlDataSynEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSqlDataSynEN objSqlDataSynEN)
{
try
{
int intRecNum = clsSqlDataSynBL.SqlDataSynDA.DelRecord(objSqlDataSynEN.TabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynENS">源对象</param>
 /// <param name = "objSqlDataSynENT">目标对象</param>
 public static void CopyTo(this clsSqlDataSynEN objSqlDataSynENS, clsSqlDataSynEN objSqlDataSynENT)
{
try
{
objSqlDataSynENT.TabId = objSqlDataSynENS.TabId; //表ID
objSqlDataSynENT.TabName = objSqlDataSynENS.TabName; //表名
objSqlDataSynENT.TabCnName = objSqlDataSynENS.TabCnName; //表中文名
objSqlDataSynENT.TabEnName = objSqlDataSynENS.TabEnName; //表英文详细名
objSqlDataSynENT.SqlData = objSqlDataSynENS.SqlData; //Sql表数据
objSqlDataSynENT.SqlCommandTypeId = objSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objSqlDataSynENT.SqlCommandText = objSqlDataSynENS.SqlCommandText; //Sql命令内容
objSqlDataSynENT.SqlDataRecNum = objSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objSqlDataSynENT.TargetTabCondition = objSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objSqlDataSynENT.TargetTabRecNum = objSqlDataSynENS.TargetTabRecNum; //目标表记录数
objSqlDataSynENT.DataSynDate = objSqlDataSynENS.DataSynDate; //数据同步日期
objSqlDataSynENT.PrimaryTypeId = objSqlDataSynENS.PrimaryTypeId; //主键类型ID
objSqlDataSynENT.RecExclusiveWayId = objSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objSqlDataSynENT.TextResouce = objSqlDataSynENS.TextResouce; //文本来源
objSqlDataSynENT.TextResourceTypeId = objSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objSqlDataSynENT.AnalysisDate = objSqlDataSynENS.AnalysisDate; //分析日期
objSqlDataSynENT.PrjId = objSqlDataSynENS.PrjId; //工程Id
objSqlDataSynENT.ErrMsg = objSqlDataSynENS.ErrMsg; //错误信息
objSqlDataSynENT.UpdDate = objSqlDataSynENS.UpdDate; //修改日期
objSqlDataSynENT.UpdUserId = objSqlDataSynENS.UpdUserId; //修改用户Id
objSqlDataSynENT.Memo = objSqlDataSynENS.Memo; //说明
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
 /// <param name = "objSqlDataSynENS">源对象</param>
 /// <returns>目标对象=>clsSqlDataSynEN:objSqlDataSynENT</returns>
 public static clsSqlDataSynEN CopyTo(this clsSqlDataSynEN objSqlDataSynENS)
{
try
{
 clsSqlDataSynEN objSqlDataSynENT = new clsSqlDataSynEN()
{
TabId = objSqlDataSynENS.TabId, //表ID
TabName = objSqlDataSynENS.TabName, //表名
TabCnName = objSqlDataSynENS.TabCnName, //表中文名
TabEnName = objSqlDataSynENS.TabEnName, //表英文详细名
SqlData = objSqlDataSynENS.SqlData, //Sql表数据
SqlCommandTypeId = objSqlDataSynENS.SqlCommandTypeId, //Sql命令类型Id
SqlCommandText = objSqlDataSynENS.SqlCommandText, //Sql命令内容
SqlDataRecNum = objSqlDataSynENS.SqlDataRecNum, //Sql数据记录数
TargetTabCondition = objSqlDataSynENS.TargetTabCondition, //目标表有效记录条件
TargetTabRecNum = objSqlDataSynENS.TargetTabRecNum, //目标表记录数
DataSynDate = objSqlDataSynENS.DataSynDate, //数据同步日期
PrimaryTypeId = objSqlDataSynENS.PrimaryTypeId, //主键类型ID
RecExclusiveWayId = objSqlDataSynENS.RecExclusiveWayId, //记录排他方式Id
TextResouce = objSqlDataSynENS.TextResouce, //文本来源
TextResourceTypeId = objSqlDataSynENS.TextResourceTypeId, //文本来源类型Id
AnalysisDate = objSqlDataSynENS.AnalysisDate, //分析日期
PrjId = objSqlDataSynENS.PrjId, //工程Id
ErrMsg = objSqlDataSynENS.ErrMsg, //错误信息
UpdDate = objSqlDataSynENS.UpdDate, //修改日期
UpdUserId = objSqlDataSynENS.UpdUserId, //修改用户Id
Memo = objSqlDataSynENS.Memo, //说明
};
 return objSqlDataSynENT;
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
public static void CheckPropertyNew(this clsSqlDataSynEN objSqlDataSynEN)
{
 clsSqlDataSynBL.SqlDataSynDA.CheckPropertyNew(objSqlDataSynEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSqlDataSynEN objSqlDataSynEN)
{
 clsSqlDataSynBL.SqlDataSynDA.CheckProperty4Condition(objSqlDataSynEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlDataSynEN objSqlDataSynCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabId) == true)
{
string strComparisonOpTabId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabId, objSqlDataSynCond.TabId, strComparisonOpTabId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabName) == true)
{
string strComparisonOpTabName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabName, objSqlDataSynCond.TabName, strComparisonOpTabName);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabCnName) == true)
{
string strComparisonOpTabCnName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabCnName, objSqlDataSynCond.TabCnName, strComparisonOpTabCnName);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TabEnName) == true)
{
string strComparisonOpTabEnName = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TabEnName, objSqlDataSynCond.TabEnName, strComparisonOpTabEnName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlCommandTypeId) == true)
{
string strComparisonOpSqlCommandTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlCommandTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.SqlCommandTypeId, objSqlDataSynCond.SqlCommandTypeId, strComparisonOpSqlCommandTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlCommandText) == true)
{
string strComparisonOpSqlCommandText = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlCommandText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.SqlCommandText, objSqlDataSynCond.SqlCommandText, strComparisonOpSqlCommandText);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.SqlDataRecNum) == true)
{
string strComparisonOpSqlDataRecNum = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.SqlDataRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlDataSyn.SqlDataRecNum, objSqlDataSynCond.SqlDataRecNum, strComparisonOpSqlDataRecNum);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TargetTabCondition) == true)
{
string strComparisonOpTargetTabCondition = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TargetTabCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TargetTabCondition, objSqlDataSynCond.TargetTabCondition, strComparisonOpTargetTabCondition);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TargetTabRecNum) == true)
{
string strComparisonOpTargetTabRecNum = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TargetTabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlDataSyn.TargetTabRecNum, objSqlDataSynCond.TargetTabRecNum, strComparisonOpTargetTabRecNum);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.DataSynDate) == true)
{
string strComparisonOpDataSynDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.DataSynDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.DataSynDate, objSqlDataSynCond.DataSynDate, strComparisonOpDataSynDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.PrimaryTypeId, objSqlDataSynCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.RecExclusiveWayId) == true)
{
string strComparisonOpRecExclusiveWayId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.RecExclusiveWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.RecExclusiveWayId, objSqlDataSynCond.RecExclusiveWayId, strComparisonOpRecExclusiveWayId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TextResouce) == true)
{
string strComparisonOpTextResouce = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TextResouce, objSqlDataSynCond.TextResouce, strComparisonOpTextResouce);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.TextResourceTypeId, objSqlDataSynCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.AnalysisDate, objSqlDataSynCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.PrjId) == true)
{
string strComparisonOpPrjId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.PrjId, objSqlDataSynCond.PrjId, strComparisonOpPrjId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.ErrMsg) == true)
{
string strComparisonOpErrMsg = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.ErrMsg, objSqlDataSynCond.ErrMsg, strComparisonOpErrMsg);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.UpdDate, objSqlDataSynCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.UpdUserId, objSqlDataSynCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlDataSynCond.IsUpdated(conSqlDataSyn.Memo) == true)
{
string strComparisonOpMemo = objSqlDataSynCond.dicFldComparisonOp[conSqlDataSyn.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlDataSyn.Memo, objSqlDataSynCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SqlDataSyn
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Sql数据同步(SqlDataSyn)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSqlDataSynBL
{
public static RelatedActions_SqlDataSyn relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSqlDataSynDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSqlDataSynDA SqlDataSynDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSqlDataSynDA();
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
 public clsSqlDataSynBL()
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
if (string.IsNullOrEmpty(clsSqlDataSynEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlDataSynEN._ConnectString);
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
public static DataTable GetDataTable_SqlDataSyn(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SqlDataSynDA.GetDataTable_SqlDataSyn(strWhereCond);
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
objDT = SqlDataSynDA.GetDataTable(strWhereCond);
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
objDT = SqlDataSynDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SqlDataSynDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SqlDataSynDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SqlDataSynDA.GetDataTable_Top(objTopPara);
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
objDT = SqlDataSynDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SqlDataSynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SqlDataSynDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSqlDataSynEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSqlDataSynEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst)
{
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
List<clsSqlDataSynEN> arrSqlDataSynObjLstCache = GetObjLstCache();
IEnumerable <clsSqlDataSynEN> arrSqlDataSynObjLst_Sel =
arrSqlDataSynObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrSqlDataSynObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlDataSynEN> GetObjLst(string strWhereCond)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
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
public static List<clsSqlDataSynEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSqlDataSynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSqlDataSynEN> GetSubObjLstCache(clsSqlDataSynEN objSqlDataSynCond)
{
List<clsSqlDataSynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSqlDataSynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlDataSyn._AttributeName)
{
if (objSqlDataSynCond.IsUpdated(strFldName) == false) continue;
if (objSqlDataSynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlDataSynCond[strFldName].ToString());
}
else
{
if (objSqlDataSynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlDataSynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlDataSynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlDataSynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlDataSynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlDataSynCond[strFldName]));
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
public static List<clsSqlDataSynEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
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
public static List<clsSqlDataSynEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
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
List<clsSqlDataSynEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSqlDataSynEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlDataSynEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSqlDataSynEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
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
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
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
public static List<clsSqlDataSynEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSqlDataSynEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSqlDataSynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
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
public static List<clsSqlDataSynEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlDataSynEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlDataSynEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSqlDataSynEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSqlDataSyn(ref clsSqlDataSynEN objSqlDataSynEN)
{
bool bolResult = SqlDataSynDA.GetSqlDataSyn(ref objSqlDataSynEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlDataSynEN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSqlDataSynEN objSqlDataSynEN = SqlDataSynDA.GetObjByTabId(strTabId);
return objSqlDataSynEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSqlDataSynEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSqlDataSynEN objSqlDataSynEN = SqlDataSynDA.GetFirstObj(strWhereCond);
 return objSqlDataSynEN;
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
public static clsSqlDataSynEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSqlDataSynEN objSqlDataSynEN = SqlDataSynDA.GetObjByDataRow(objRow);
 return objSqlDataSynEN;
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
public static clsSqlDataSynEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSqlDataSynEN objSqlDataSynEN = SqlDataSynDA.GetObjByDataRow(objRow);
 return objSqlDataSynEN;
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
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstSqlDataSynObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlDataSynEN GetObjByTabIdFromList(string strTabId, List<clsSqlDataSynEN> lstSqlDataSynObjLst)
{
foreach (clsSqlDataSynEN objSqlDataSynEN in lstSqlDataSynObjLst)
{
if (objSqlDataSynEN.TabId == strTabId)
{
return objSqlDataSynEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsSqlDataSynDA().GetFirstID(strWhereCond);
 return strTabId;
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
 arrList = SqlDataSynDA.GetID(strWhereCond);
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
bool bolIsExist = SqlDataSynDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SqlDataSynDA.IsExist(strTabId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strTabId">表ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strTabId, string strOpUser)
{
clsSqlDataSynEN objSqlDataSynEN = clsSqlDataSynBL.GetObjByTabId(strTabId);
objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSqlDataSynEN.UpdUserId = strOpUser;
return clsSqlDataSynBL.UpdateBySql2(objSqlDataSynEN);
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
 bolIsExist = clsSqlDataSynDA.IsExistTable();
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
 bolIsExist = SqlDataSynDA.IsExistTable(strTabName);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSqlDataSynEN objSqlDataSynEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSqlDataSynBL.IsExist(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSqlDataSynEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SqlDataSynDA.AddNewRecordBySQL2(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSqlDataSynEN objSqlDataSynEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSqlDataSynBL.IsExist(objSqlDataSynEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSqlDataSynEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SqlDataSynDA.AddNewRecordBySQL2WithReturnKey(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSqlDataSynEN objSqlDataSynEN)
{
try
{
bool bolResult = SqlDataSynDA.Update(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSqlDataSynEN objSqlDataSynEN)
{
 if (string.IsNullOrEmpty(objSqlDataSynEN.TabId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SqlDataSynDA.UpdateBySql2(objSqlDataSynEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlDataSynBL.ReFreshCache();

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTabId)
{
try
{
 clsSqlDataSynEN objSqlDataSynEN = clsSqlDataSynBL.GetObjByTabId(strTabId);

if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(objSqlDataSynEN.TabId, objSqlDataSynEN.UpdUserId);
}
if (objSqlDataSynEN != null)
{
int intRecNum = SqlDataSynDA.DelRecord(strTabId);
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
/// <param name="strTabId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
//删除与表:[SqlDataSyn]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSqlDataSyn.TabId,
//strTabId);
//        clsSqlDataSynBL.DelSqlDataSynsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlDataSynBL.DelRecord(strTabId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlDataSynBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSqlDataSynBL.relatedActions != null)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
bool bolResult = SqlDataSynDA.DelRecord(strTabId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTabIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSqlDataSyns(List<string> arrTabIdLst)
{
if (arrTabIdLst.Count == 0) return 0;
try
{
if (clsSqlDataSynBL.relatedActions != null)
{
foreach (var strTabId in arrTabIdLst)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
int intDelRecNum = SqlDataSynDA.DelSqlDataSyn(arrTabIdLst);
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
public static int DelSqlDataSynsByCond(string strWhereCond)
{
try
{
if (clsSqlDataSynBL.relatedActions != null)
{
List<string> arrTabId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTabId in arrTabId)
{
clsSqlDataSynBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
int intRecNum = SqlDataSynDA.DelSqlDataSyn(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SqlDataSyn]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTabId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTabId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
//删除与表:[SqlDataSyn]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlDataSynBL.DelRecord(strTabId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlDataSynBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSqlDataSynENS">源对象</param>
 /// <param name = "objSqlDataSynENT">目标对象</param>
 public static void CopyTo(clsSqlDataSynEN objSqlDataSynENS, clsSqlDataSynEN objSqlDataSynENT)
{
try
{
objSqlDataSynENT.TabId = objSqlDataSynENS.TabId; //表ID
objSqlDataSynENT.TabName = objSqlDataSynENS.TabName; //表名
objSqlDataSynENT.TabCnName = objSqlDataSynENS.TabCnName; //表中文名
objSqlDataSynENT.TabEnName = objSqlDataSynENS.TabEnName; //表英文详细名
objSqlDataSynENT.SqlData = objSqlDataSynENS.SqlData; //Sql表数据
objSqlDataSynENT.SqlCommandTypeId = objSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objSqlDataSynENT.SqlCommandText = objSqlDataSynENS.SqlCommandText; //Sql命令内容
objSqlDataSynENT.SqlDataRecNum = objSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objSqlDataSynENT.TargetTabCondition = objSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objSqlDataSynENT.TargetTabRecNum = objSqlDataSynENS.TargetTabRecNum; //目标表记录数
objSqlDataSynENT.DataSynDate = objSqlDataSynENS.DataSynDate; //数据同步日期
objSqlDataSynENT.PrimaryTypeId = objSqlDataSynENS.PrimaryTypeId; //主键类型ID
objSqlDataSynENT.RecExclusiveWayId = objSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objSqlDataSynENT.TextResouce = objSqlDataSynENS.TextResouce; //文本来源
objSqlDataSynENT.TextResourceTypeId = objSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objSqlDataSynENT.AnalysisDate = objSqlDataSynENS.AnalysisDate; //分析日期
objSqlDataSynENT.PrjId = objSqlDataSynENS.PrjId; //工程Id
objSqlDataSynENT.ErrMsg = objSqlDataSynENS.ErrMsg; //错误信息
objSqlDataSynENT.UpdDate = objSqlDataSynENS.UpdDate; //修改日期
objSqlDataSynENT.UpdUserId = objSqlDataSynENS.UpdUserId; //修改用户Id
objSqlDataSynENT.Memo = objSqlDataSynENS.Memo; //说明
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
 /// <param name = "objSqlDataSynEN">源简化对象</param>
 public static void SetUpdFlag(clsSqlDataSynEN objSqlDataSynEN)
{
try
{
objSqlDataSynEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSqlDataSynEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSqlDataSyn.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TabId = objSqlDataSynEN.TabId; //表ID
}
if (arrFldSet.Contains(conSqlDataSyn.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TabName = objSqlDataSynEN.TabName; //表名
}
if (arrFldSet.Contains(conSqlDataSyn.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TabCnName = objSqlDataSynEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(conSqlDataSyn.TabEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TabEnName = objSqlDataSynEN.TabEnName == "[null]" ? null :  objSqlDataSynEN.TabEnName; //表英文详细名
}
if (arrFldSet.Contains(conSqlDataSyn.SqlData, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.SqlData = objSqlDataSynEN.SqlData == "[null]" ? null :  objSqlDataSynEN.SqlData; //Sql表数据
}
if (arrFldSet.Contains(conSqlDataSyn.SqlCommandTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.SqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId == "[null]" ? null :  objSqlDataSynEN.SqlCommandTypeId; //Sql命令类型Id
}
if (arrFldSet.Contains(conSqlDataSyn.SqlCommandText, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.SqlCommandText = objSqlDataSynEN.SqlCommandText == "[null]" ? null :  objSqlDataSynEN.SqlCommandText; //Sql命令内容
}
if (arrFldSet.Contains(conSqlDataSyn.SqlDataRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.SqlDataRecNum = objSqlDataSynEN.SqlDataRecNum; //Sql数据记录数
}
if (arrFldSet.Contains(conSqlDataSyn.TargetTabCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TargetTabCondition = objSqlDataSynEN.TargetTabCondition == "[null]" ? null :  objSqlDataSynEN.TargetTabCondition; //目标表有效记录条件
}
if (arrFldSet.Contains(conSqlDataSyn.TargetTabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TargetTabRecNum = objSqlDataSynEN.TargetTabRecNum; //目标表记录数
}
if (arrFldSet.Contains(conSqlDataSyn.DataSynDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.DataSynDate = objSqlDataSynEN.DataSynDate == "[null]" ? null :  objSqlDataSynEN.DataSynDate; //数据同步日期
}
if (arrFldSet.Contains(conSqlDataSyn.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.PrimaryTypeId = objSqlDataSynEN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(conSqlDataSyn.RecExclusiveWayId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.RecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId; //记录排他方式Id
}
if (arrFldSet.Contains(conSqlDataSyn.TextResouce, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TextResouce = objSqlDataSynEN.TextResouce == "[null]" ? null :  objSqlDataSynEN.TextResouce; //文本来源
}
if (arrFldSet.Contains(conSqlDataSyn.TextResourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.TextResourceTypeId = objSqlDataSynEN.TextResourceTypeId == "[null]" ? null :  objSqlDataSynEN.TextResourceTypeId; //文本来源类型Id
}
if (arrFldSet.Contains(conSqlDataSyn.AnalysisDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.AnalysisDate = objSqlDataSynEN.AnalysisDate == "[null]" ? null :  objSqlDataSynEN.AnalysisDate; //分析日期
}
if (arrFldSet.Contains(conSqlDataSyn.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.PrjId = objSqlDataSynEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSqlDataSyn.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.ErrMsg = objSqlDataSynEN.ErrMsg == "[null]" ? null :  objSqlDataSynEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conSqlDataSyn.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.UpdDate = objSqlDataSynEN.UpdDate == "[null]" ? null :  objSqlDataSynEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSqlDataSyn.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.UpdUserId = objSqlDataSynEN.UpdUserId == "[null]" ? null :  objSqlDataSynEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSqlDataSyn.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlDataSynEN.Memo = objSqlDataSynEN.Memo == "[null]" ? null :  objSqlDataSynEN.Memo; //说明
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
 /// <param name = "objSqlDataSynEN">源简化对象</param>
 public static void AccessFldValueNull(clsSqlDataSynEN objSqlDataSynEN)
{
try
{
if (objSqlDataSynEN.TabEnName == "[null]") objSqlDataSynEN.TabEnName = null; //表英文详细名
if (objSqlDataSynEN.SqlData == "[null]") objSqlDataSynEN.SqlData = null; //Sql表数据
if (objSqlDataSynEN.SqlCommandTypeId == "[null]") objSqlDataSynEN.SqlCommandTypeId = null; //Sql命令类型Id
if (objSqlDataSynEN.SqlCommandText == "[null]") objSqlDataSynEN.SqlCommandText = null; //Sql命令内容
if (objSqlDataSynEN.TargetTabCondition == "[null]") objSqlDataSynEN.TargetTabCondition = null; //目标表有效记录条件
if (objSqlDataSynEN.DataSynDate == "[null]") objSqlDataSynEN.DataSynDate = null; //数据同步日期
if (objSqlDataSynEN.TextResouce == "[null]") objSqlDataSynEN.TextResouce = null; //文本来源
if (objSqlDataSynEN.TextResourceTypeId == "[null]") objSqlDataSynEN.TextResourceTypeId = null; //文本来源类型Id
if (objSqlDataSynEN.AnalysisDate == "[null]") objSqlDataSynEN.AnalysisDate = null; //分析日期
if (objSqlDataSynEN.ErrMsg == "[null]") objSqlDataSynEN.ErrMsg = null; //错误信息
if (objSqlDataSynEN.UpdDate == "[null]") objSqlDataSynEN.UpdDate = null; //修改日期
if (objSqlDataSynEN.UpdUserId == "[null]") objSqlDataSynEN.UpdUserId = null; //修改用户Id
if (objSqlDataSynEN.Memo == "[null]") objSqlDataSynEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSqlDataSynEN objSqlDataSynEN)
{
 SqlDataSynDA.CheckPropertyNew(objSqlDataSynEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSqlDataSynEN objSqlDataSynEN)
{
 SqlDataSynDA.CheckProperty4Condition(objSqlDataSynEN);
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
if (clsSqlDataSynBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlDataSynBL没有刷新缓存机制(clsSqlDataSynBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrSqlDataSynObjLstCache == null)
//{
//arrSqlDataSynObjLstCache = SqlDataSynDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlDataSynEN GetObjByTabIdCache(string strTabId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
List<clsSqlDataSynEN> arrSqlDataSynObjLstCache = GetObjLstCache();
IEnumerable <clsSqlDataSynEN> arrSqlDataSynObjLst_Sel =
arrSqlDataSynObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrSqlDataSynObjLst_Sel.Count() == 0)
{
   clsSqlDataSynEN obj = clsSqlDataSynBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSqlDataSynObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlDataSynEN> GetAllSqlDataSynObjLstCache()
{
//获取缓存中的对象列表
List<clsSqlDataSynEN> arrSqlDataSynObjLstCache = GetObjLstCache(); 
return arrSqlDataSynObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlDataSynEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
List<clsSqlDataSynEN> arrSqlDataSynObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSqlDataSynObjLstCache;
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
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSqlDataSynEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSqlDataSynEN._RefreshTimeLst.Count == 0) return "";
return clsSqlDataSynEN._RefreshTimeLst[clsSqlDataSynEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSqlDataSynBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSqlDataSynEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSqlDataSynEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSqlDataSynBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strTabId)
{
if (strInFldName != conSqlDataSyn.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSqlDataSyn._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSqlDataSyn._AttributeName));
throw new Exception(strMsg);
}
var objSqlDataSyn = clsSqlDataSynBL.GetObjByTabIdCache(strTabId);
if (objSqlDataSyn == null) return "";
return objSqlDataSyn[strOutFldName].ToString();
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
int intRecCount = clsSqlDataSynDA.GetRecCount(strTabName);
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
int intRecCount = clsSqlDataSynDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSqlDataSynDA.GetRecCount();
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
int intRecCount = clsSqlDataSynDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSqlDataSynCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSqlDataSynEN objSqlDataSynCond)
{
List<clsSqlDataSynEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSqlDataSynEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlDataSyn._AttributeName)
{
if (objSqlDataSynCond.IsUpdated(strFldName) == false) continue;
if (objSqlDataSynCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlDataSynCond[strFldName].ToString());
}
else
{
if (objSqlDataSynCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlDataSynCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlDataSynCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlDataSynCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlDataSynCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlDataSynCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlDataSynCond[strFldName]));
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
 List<string> arrList = clsSqlDataSynDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SqlDataSynDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SqlDataSynDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SqlDataSynDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlDataSynDA.SetFldValue(clsSqlDataSynEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SqlDataSynDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlDataSynDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlDataSynDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlDataSynDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SqlDataSyn] "); 
 strCreateTabCode.Append(" ( "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) primary key, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**表中文名*/ 
 strCreateTabCode.Append(" TabCnName varchar(200) not Null, "); 
 // /**表英文详细名*/ 
 strCreateTabCode.Append(" TabEnName varchar(200) Null, "); 
 // /**Sql表数据*/ 
 strCreateTabCode.Append(" SqlData text Null, "); 
 // /**Sql命令类型Id*/ 
 strCreateTabCode.Append(" SqlCommandTypeId char(2) Null, "); 
 // /**Sql命令内容*/ 
 strCreateTabCode.Append(" SqlCommandText varchar(200) Null, "); 
 // /**Sql数据记录数*/ 
 strCreateTabCode.Append(" SqlDataRecNum int Null, "); 
 // /**目标表有效记录条件*/ 
 strCreateTabCode.Append(" TargetTabCondition varchar(300) Null, "); 
 // /**目标表记录数*/ 
 strCreateTabCode.Append(" TargetTabRecNum int Null, "); 
 // /**数据同步日期*/ 
 strCreateTabCode.Append(" DataSynDate varchar(14) Null, "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) not Null, "); 
 // /**记录排他方式Id*/ 
 strCreateTabCode.Append(" RecExclusiveWayId char(4) not Null, "); 
 // /**文本来源*/ 
 strCreateTabCode.Append(" TextResouce varchar(100) Null, "); 
 // /**文本来源类型Id*/ 
 strCreateTabCode.Append(" TextResourceTypeId char(2) Null, "); 
 // /**分析日期*/ 
 strCreateTabCode.Append(" AnalysisDate varchar(20) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
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
 /// Sql数据同步(SqlDataSyn)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SqlDataSyn : clsCommFun4BL
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
clsSqlDataSynBL.ReFreshThisCache();
}
}

}