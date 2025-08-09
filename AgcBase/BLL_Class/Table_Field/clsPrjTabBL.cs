
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabBL
 表名:PrjTab(00050009)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsPrjTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabEN GetObj(this K_TabId_PrjTab myKey)
{
clsPrjTabEN objPrjTabEN = clsPrjTabBL.PrjTabDA.GetObjByTabId(myKey.Value);
return objPrjTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTabBL.IsExist(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjTabBL.AddNewRecord)", objPrjTabEN.TabName,objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsPrjTabBL.PrjTabDA.AddNewRecordBySQL2(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
public static bool AddRecordEx(this clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPrjTabBL.IsExist(objPrjTabEN.TabId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPrjTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objPrjTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(表名(TabName)=[{0}],工程Id(PrjId)=[{1}])已经存在,不能重复!", objPrjTabEN.TabName, objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objPrjTabEN.AddNewRecord();
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjTabBL.AddNewRecordWithMaxId)", objPrjTabEN.TabName,objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true || clsPrjTabBL.IsExist(objPrjTabEN.TabId) == true)
 {
     objPrjTabEN.TabId = clsPrjTabBL.GetMaxStrIdByPrefix_S(objPrjTabEN.PrjId);
 }
string strTabId = clsPrjTabBL.PrjTabDA.AddNewRecordBySQL2WithReturnKey(objPrjTabEN);
     objPrjTabEN.TabId = strTabId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
}
return strTabId;
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTabBL.IsExist(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objPrjTabEN) == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjTabBL.AddNewRecordWithReturnKey)", objPrjTabEN.TabName,objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = clsPrjTabBL.PrjTabDA.AddNewRecordBySQL2WithReturnKey(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabId(this clsPrjTabEN objPrjTabEN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTab.TabId);
}
objPrjTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabName(this clsPrjTabEN objPrjTabEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, conPrjTab.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, conPrjTab.TabName);
}
objPrjTabEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabCnName(this clsPrjTabEN objPrjTabEN, string strTabCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabCnName, 200, conPrjTab.TabCnName);
}
objPrjTabEN.TabCnName = strTabCnName; //表中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabCnName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabCnName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabCnName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetPrjId(this clsPrjTabEN objPrjTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTab.PrjId);
}
objPrjTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.PrjId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.PrjId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.PrjId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetSqlDsTypeId(this clsPrjTabEN objPrjTabEN, string strSqlDsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
}
objPrjTabEN.SqlDsTypeId = strSqlDsTypeId; //数据源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.SqlDsTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.SqlDsTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.SqlDsTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabStateId(this clsPrjTabEN objPrjTabEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabStateId, conPrjTab.TabStateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, conPrjTab.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, conPrjTab.TabStateId);
}
objPrjTabEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabStateId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabStateId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabStateId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetFuncModuleAgcId(this clsPrjTabEN objPrjTabEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
}
objPrjTabEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.FuncModuleAgcId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.FuncModuleAgcId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.FuncModuleAgcId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsReleToSqlTab(this clsPrjTabEN objPrjTabEN, bool bolIsReleToSqlTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsReleToSqlTab, conPrjTab.IsReleToSqlTab);
objPrjTabEN.IsReleToSqlTab = bolIsReleToSqlTab; //是否与SQL表相关
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsReleToSqlTab) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsReleToSqlTab, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsReleToSqlTab] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetKeyword(this clsPrjTabEN objPrjTabEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 50, conPrjTab.Keyword);
}
objPrjTabEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Keyword) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Keyword, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Keyword] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabTypeId(this clsPrjTabEN objPrjTabEN, string strTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabTypeId, conPrjTab.TabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabTypeId, 4, conPrjTab.TabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabTypeId, 4, conPrjTab.TabTypeId);
}
objPrjTabEN.TabTypeId = strTabTypeId; //表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabMainTypeId(this clsPrjTabEN objPrjTabEN, string strTabMainTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabMainTypeId, conPrjTab.TabMainTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabMainTypeId, 4, conPrjTab.TabMainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabMainTypeId, 4, conPrjTab.TabMainTypeId);
}
objPrjTabEN.TabMainTypeId = strTabMainTypeId; //表主类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabMainTypeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabMainTypeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabMainTypeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetRelaTabId4View(this clsPrjTabEN objPrjTabEN, string strRelaTabId4View, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId4View, 8, conPrjTab.RelaTabId4View);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId4View, 8, conPrjTab.RelaTabId4View);
}
objPrjTabEN.RelaTabId4View = strRelaTabId4View; //视图的相关表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.RelaTabId4View) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.RelaTabId4View, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.RelaTabId4View] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNeedGeneIndexer(this clsPrjTabEN objPrjTabEN, bool bolIsNeedGeneIndexer, string strComparisonOp="")
	{
objPrjTabEN.IsNeedGeneIndexer = bolIsNeedGeneIndexer; //是否需要生成索引器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNeedGeneIndexer) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNeedGeneIndexer, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNeedGeneIndexer] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParentClass(this clsPrjTabEN objPrjTabEN, string strParentClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentClass, 50, conPrjTab.ParentClass);
}
objPrjTabEN.ParentClass = strParentClass; //父类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParentClass) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParentClass, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParentClass] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsShare(this clsPrjTabEN objPrjTabEN, bool bolIsShare, string strComparisonOp="")
	{
objPrjTabEN.IsShare = bolIsShare; //是否共享
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsShare) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsShare, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsShare] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsUseDelSign(this clsPrjTabEN objPrjTabEN, bool bolIsUseDelSign, string strComparisonOp="")
	{
objPrjTabEN.IsUseDelSign = bolIsUseDelSign; //是否使用删除标记
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsUseDelSign) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsUseDelSign, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsUseDelSign] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsUseCache(this clsPrjTabEN objPrjTabEN, bool bolIsUseCache, string strComparisonOp="")
	{
objPrjTabEN.IsUseCache = bolIsUseCache; //是否使用Cache
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsUseCache) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsUseCache, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsUseCache] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsMultiKeyClassify(this clsPrjTabEN objPrjTabEN, bool bolIsMultiKeyClassify, string strComparisonOp="")
	{
objPrjTabEN.IsMultiKeyClassify = bolIsMultiKeyClassify; //是否可以多个关键字分类共存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsMultiKeyClassify) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsMultiKeyClassify, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsMultiKeyClassify] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyField, 8, conPrjTab.CacheClassifyField);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField, 8, conPrjTab.CacheClassifyField);
}
objPrjTabEN.CacheClassifyField = strCacheClassifyField; //缓存分类字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField2(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
}
objPrjTabEN.CacheClassifyField2 = strCacheClassifyField2; //缓存分类字段2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField2) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField2, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField2] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheModeId(this clsPrjTabEN objPrjTabEN, string strCacheModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, conPrjTab.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, conPrjTab.CacheModeId);
}
objPrjTabEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheModeId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheModeId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheModeId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyFieldTS(this clsPrjTabEN objPrjTabEN, string strCacheClassifyFieldTS, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
}
objPrjTabEN.CacheClassifyFieldTS = strCacheClassifyFieldTS; //缓存分类字段_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyFieldTS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyFieldTS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyFieldTS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetCacheClassifyField2TS(this clsPrjTabEN objPrjTabEN, string strCacheClassifyField2TS, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
}
objPrjTabEN.CacheClassifyField2TS = strCacheClassifyField2TS; //缓存分类字段2_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.CacheClassifyField2TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.CacheClassifyField2TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.CacheClassifyField2TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParaVar2TS(this clsPrjTabEN objPrjTabEN, string strParaVar2TS, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaVar2TS, 8, conPrjTab.ParaVar2TS);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParaVar2TS, 8, conPrjTab.ParaVar2TS);
}
objPrjTabEN.ParaVar2TS = strParaVar2TS; //参数变量2_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParaVar2TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParaVar2TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParaVar2TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetParaVar1TS(this clsPrjTabEN objPrjTabEN, string strParaVar1TS, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParaVar1TS, 8, conPrjTab.ParaVar1TS);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParaVar1TS, 8, conPrjTab.ParaVar1TS);
}
objPrjTabEN.ParaVar1TS = strParaVar1TS; //参数变量_TS
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ParaVar1TS) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ParaVar1TS, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ParaVar1TS] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetWhereFormat(this clsPrjTabEN objPrjTabEN, string strWhereFormat, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWhereFormat, 500, conPrjTab.WhereFormat);
}
objPrjTabEN.WhereFormat = strWhereFormat; //缓存条件格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.WhereFormat) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.WhereFormat, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.WhereFormat] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetWhereFormatBack(this clsPrjTabEN objPrjTabEN, string strWhereFormatBack, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWhereFormatBack, 500, conPrjTab.WhereFormatBack);
}
objPrjTabEN.WhereFormatBack = strWhereFormatBack; //后台缓存条件格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.WhereFormatBack) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.WhereFormatBack, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.WhereFormatBack] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsRefresh4RelaView(this clsPrjTabEN objPrjTabEN, bool bolIsRefresh4RelaView, string strComparisonOp="")
	{
objPrjTabEN.IsRefresh4RelaView = bolIsRefresh4RelaView; //是否刷新相关视图
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsRefresh4RelaView) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsRefresh4RelaView, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsRefresh4RelaView] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabRecNum(this clsPrjTabEN objPrjTabEN, int? intTabRecNum, string strComparisonOp="")
	{
objPrjTabEN.TabRecNum = intTabRecNum; //记录数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabRecNum) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabRecNum, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabRecNum] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetKeyId4Test(this clsPrjTabEN objPrjTabEN, string strKeyId4Test, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conPrjTab.KeyId4Test);
}
objPrjTabEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.KeyId4Test) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.KeyId4Test, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.KeyId4Test] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetErrMsg(this clsPrjTabEN objPrjTabEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjTab.ErrMsg);
}
objPrjTabEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.ErrMsg) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.ErrMsg, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.ErrMsg] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetFldNum(this clsPrjTabEN objPrjTabEN, int? intFldNum, string strComparisonOp="")
	{
objPrjTabEN.FldNum = intFldNum; //字段数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.FldNum) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.FldNum, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.FldNum] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetUpdUserId(this clsPrjTabEN objPrjTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPrjTab.UpdUserId);
}
objPrjTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.UpdUserId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.UpdUserId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.UpdUserId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetUpdDate(this clsPrjTabEN objPrjTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjTab.UpdDate);
}
objPrjTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.UpdDate) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.UpdDate, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.UpdDate] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetMemo(this clsPrjTabEN objPrjTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTab.Memo);
}
objPrjTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Memo) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Memo, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Memo] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetOrderNum4Refer(this clsPrjTabEN objPrjTabEN, int? intOrderNum4Refer, string strComparisonOp="")
	{
objPrjTabEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.OrderNum4Refer) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.OrderNum4Refer, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.OrderNum4Refer] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsChecked(this clsPrjTabEN objPrjTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objPrjTabEN.IsChecked = bolIsChecked; //是否核实
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsChecked) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsChecked, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsChecked] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetOwner(this clsPrjTabEN objPrjTabEN, string strOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwner, 50, conPrjTab.Owner);
}
objPrjTabEN.Owner = strOwner; //拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.Owner) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.Owner, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.Owner] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabEnName(this clsPrjTabEN objPrjTabEN, string strTabEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabEnName, 200, conPrjTab.TabEnName);
}
objPrjTabEN.TabEnName = strTabEnName; //表英文详细名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabEnName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabEnName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabEnName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNeedTransCode(this clsPrjTabEN objPrjTabEN, bool bolIsNeedTransCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedTransCode, conPrjTab.IsNeedTransCode);
objPrjTabEN.IsNeedTransCode = bolIsNeedTransCode; //是否需要转换代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNeedTransCode) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNeedTransCode, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNeedTransCode] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetTabNameB(this clsPrjTabEN objPrjTabEN, string strTabNameB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabNameB, 50, conPrjTab.TabNameB);
}
objPrjTabEN.TabNameB = strTabNameB; //表名_后备
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.TabNameB) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.TabNameB, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.TabNameB] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetRelaViewId(this clsPrjTabEN objPrjTabEN, string strRelaViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaViewId, 8, conPrjTab.RelaViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaViewId, 8, conPrjTab.RelaViewId);
}
objPrjTabEN.RelaViewId = strRelaViewId; //RelaViewId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.RelaViewId) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.RelaViewId, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.RelaViewId] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetDataBaseName(this clsPrjTabEN objPrjTabEN, string strDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, conPrjTab.DataBaseName);
}
objPrjTabEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.DataBaseName) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.DataBaseName, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.DataBaseName] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsNationStandard(this clsPrjTabEN objPrjTabEN, bool bolIsNationStandard, string strComparisonOp="")
	{
objPrjTabEN.IsNationStandard = bolIsNationStandard; //是否国标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsNationStandard) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsNationStandard, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsNationStandard] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsParaTab(this clsPrjTabEN objPrjTabEN, bool bolIsParaTab, string strComparisonOp="")
	{
objPrjTabEN.IsParaTab = bolIsParaTab; //是否参数表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsParaTab) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsParaTab, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsParaTab] = strComparisonOp;
}
}
return objPrjTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabEN SetIsArchive(this clsPrjTabEN objPrjTabEN, bool bolIsArchive, string strComparisonOp="")
	{
objPrjTabEN.IsArchive = bolIsArchive; //是否存档
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabEN.dicFldComparisonOp.ContainsKey(conPrjTab.IsArchive) == false)
{
objPrjTabEN.dicFldComparisonOp.Add(conPrjTab.IsArchive, strComparisonOp);
}
else
{
objPrjTabEN.dicFldComparisonOp[conPrjTab.IsArchive] = strComparisonOp;
}
}
return objPrjTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPrjTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPrjTabEN objPrjTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPrjTabEN.CheckPropertyNew();
clsPrjTabEN objPrjTabCond = new clsPrjTabEN();
string strCondition = objPrjTabCond
.SetTabId(objPrjTabEN.TabId, "<>")
.SetTabName(objPrjTabEN.TabName, "=")
.SetPrjId(objPrjTabEN.PrjId, "=")
.GetCombineCondition();
objPrjTabEN._IsCheckProperty = true;
bool bolIsExist = clsPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PrjId_TabName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPrjTabEN.Update();
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
 /// <param name = "objPrjTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsPrjTabEN objPrjTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsPrjTabEN objPrjTabCond = new clsPrjTabEN();
string strCondition = objPrjTabCond
.SetTabName(objPrjTab.TabName, "=")
.SetPrjId(objPrjTab.PrjId, "=")
.GetCombineCondition();
objPrjTab._IsCheckProperty = true;
bool bolIsExist = clsPrjTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objPrjTab.TabId = clsPrjTabBL.GetFirstID_S(strCondition);
objPrjTab.UpdateWithCondition(strCondition);
}
else
{
objPrjTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabEN objPrjTabEN)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabBL.PrjTabDA.UpdateBySql2(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabEN objPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPrjTabBL.PrjTabDA.UpdateBySql2(objPrjTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabEN objPrjTabEN, string strWhereCond)
{
try
{
bool bolResult = clsPrjTabBL.PrjTabDA.UpdateBySqlWithCondition(objPrjTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabEN objPrjTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPrjTabBL.PrjTabDA.UpdateBySqlWithConditionTransaction(objPrjTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
public static int Delete(this clsPrjTabEN objPrjTabEN)
{
try
{
int intRecNum = clsPrjTabBL.PrjTabDA.DelRecord(objPrjTabEN.TabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
 public static void CopyTo(this clsPrjTabEN objPrjTabENS, clsPrjTabEN objPrjTabENT)
{
try
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程Id
objPrjTabENT.SqlDsTypeId = objPrjTabENS.SqlDsTypeId; //数据源类型Id
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.Keyword = objPrjTabENS.Keyword; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsShare = objPrjTabENS.IsShare; //是否共享
objPrjTabENT.IsUseDelSign = objPrjTabENS.IsUseDelSign; //是否使用删除标记
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.IsMultiKeyClassify = objPrjTabENS.IsMultiKeyClassify; //是否可以多个关键字分类共存
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.CacheClassifyField2 = objPrjTabENS.CacheClassifyField2; //缓存分类字段2
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyFieldTS = objPrjTabENS.CacheClassifyFieldTS; //缓存分类字段_TS
objPrjTabENT.CacheClassifyField2TS = objPrjTabENS.CacheClassifyField2TS; //缓存分类字段2_TS
objPrjTabENT.ParaVar2TS = objPrjTabENS.ParaVar2TS; //参数变量2_TS
objPrjTabENT.ParaVar1TS = objPrjTabENS.ParaVar1TS; //参数变量_TS
objPrjTabENT.WhereFormat = objPrjTabENS.WhereFormat; //缓存条件格式
objPrjTabENT.WhereFormatBack = objPrjTabENS.WhereFormatBack; //后台缓存条件格式
objPrjTabENT.IsRefresh4RelaView = objPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objPrjTabENT.TabRecNum = objPrjTabENS.TabRecNum; //记录数
objPrjTabENT.KeyId4Test = objPrjTabENS.KeyId4Test; //测试关键字Id
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.FldNum = objPrjTabENS.FldNum; //字段数
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabNameB = objPrjTabENS.TabNameB; //表名_后备
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
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
 /// <param name = "objPrjTabENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabEN:objPrjTabENT</returns>
 public static clsPrjTabEN CopyTo(this clsPrjTabEN objPrjTabENS)
{
try
{
 clsPrjTabEN objPrjTabENT = new clsPrjTabEN()
{
TabId = objPrjTabENS.TabId, //表ID
TabName = objPrjTabENS.TabName, //表名
TabCnName = objPrjTabENS.TabCnName, //表中文名
PrjId = objPrjTabENS.PrjId, //工程Id
SqlDsTypeId = objPrjTabENS.SqlDsTypeId, //数据源类型Id
TabStateId = objPrjTabENS.TabStateId, //表状态ID
FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId, //功能模块Id
IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab, //是否与SQL表相关
Keyword = objPrjTabENS.Keyword, //关键字
TabTypeId = objPrjTabENS.TabTypeId, //表类型Id
TabMainTypeId = objPrjTabENS.TabMainTypeId, //表主类型Id
RelaTabId4View = objPrjTabENS.RelaTabId4View, //视图的相关表ID
IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer, //是否需要生成索引器
ParentClass = objPrjTabENS.ParentClass, //父类
IsShare = objPrjTabENS.IsShare, //是否共享
IsUseDelSign = objPrjTabENS.IsUseDelSign, //是否使用删除标记
IsUseCache = objPrjTabENS.IsUseCache, //是否使用Cache
IsMultiKeyClassify = objPrjTabENS.IsMultiKeyClassify, //是否可以多个关键字分类共存
CacheClassifyField = objPrjTabENS.CacheClassifyField, //缓存分类字段
CacheClassifyField2 = objPrjTabENS.CacheClassifyField2, //缓存分类字段2
CacheModeId = objPrjTabENS.CacheModeId, //缓存方式Id
CacheClassifyFieldTS = objPrjTabENS.CacheClassifyFieldTS, //缓存分类字段_TS
CacheClassifyField2TS = objPrjTabENS.CacheClassifyField2TS, //缓存分类字段2_TS
ParaVar2TS = objPrjTabENS.ParaVar2TS, //参数变量2_TS
ParaVar1TS = objPrjTabENS.ParaVar1TS, //参数变量_TS
WhereFormat = objPrjTabENS.WhereFormat, //缓存条件格式
WhereFormatBack = objPrjTabENS.WhereFormatBack, //后台缓存条件格式
IsRefresh4RelaView = objPrjTabENS.IsRefresh4RelaView, //是否刷新相关视图
TabRecNum = objPrjTabENS.TabRecNum, //记录数
KeyId4Test = objPrjTabENS.KeyId4Test, //测试关键字Id
ErrMsg = objPrjTabENS.ErrMsg, //错误信息
FldNum = objPrjTabENS.FldNum, //字段数
UpdUserId = objPrjTabENS.UpdUserId, //修改用户Id
UpdDate = objPrjTabENS.UpdDate, //修改日期
Memo = objPrjTabENS.Memo, //说明
OrderNum4Refer = objPrjTabENS.OrderNum4Refer, //引用序号
IsChecked = objPrjTabENS.IsChecked, //是否核实
Owner = objPrjTabENS.Owner, //拥有者
TabEnName = objPrjTabENS.TabEnName, //表英文详细名
IsNeedTransCode = objPrjTabENS.IsNeedTransCode, //是否需要转换代码
TabNameB = objPrjTabENS.TabNameB, //表名_后备
RelaViewId = objPrjTabENS.RelaViewId, //RelaViewId
DataBaseName = objPrjTabENS.DataBaseName, //数据库名
IsNationStandard = objPrjTabENS.IsNationStandard, //是否国标
IsParaTab = objPrjTabENS.IsParaTab, //是否参数表
IsArchive = objPrjTabENS.IsArchive, //是否存档
};
 return objPrjTabENT;
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
public static void CheckPropertyNew(this clsPrjTabEN objPrjTabEN)
{
 clsPrjTabBL.PrjTabDA.CheckPropertyNew(objPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPrjTabEN objPrjTabEN)
{
 clsPrjTabBL.PrjTabDA.CheckProperty4Condition(objPrjTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabEN objPrjTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabCond.IsUpdated(conPrjTab.TabId) == true)
{
string strComparisonOpTabId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabId, objPrjTabCond.TabId, strComparisonOpTabId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabName) == true)
{
string strComparisonOpTabName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabName, objPrjTabCond.TabName, strComparisonOpTabName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabCnName) == true)
{
string strComparisonOpTabCnName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabCnName, objPrjTabCond.TabCnName, strComparisonOpTabCnName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabCond.dicFldComparisonOp[conPrjTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.PrjId, objPrjTabCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.SqlDsTypeId) == true)
{
string strComparisonOpSqlDsTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.SqlDsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.SqlDsTypeId, objPrjTabCond.SqlDsTypeId, strComparisonOpSqlDsTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabStateId) == true)
{
string strComparisonOpTabStateId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabStateId, objPrjTabCond.TabStateId, strComparisonOpTabStateId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objPrjTabCond.dicFldComparisonOp[conPrjTab.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.FuncModuleAgcId, objPrjTabCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsReleToSqlTab) == true)
{
if (objPrjTabCond.IsReleToSqlTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsReleToSqlTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsReleToSqlTab);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.Keyword) == true)
{
string strComparisonOpKeyword = objPrjTabCond.dicFldComparisonOp[conPrjTab.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Keyword, objPrjTabCond.Keyword, strComparisonOpKeyword);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabTypeId) == true)
{
string strComparisonOpTabTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabTypeId, objPrjTabCond.TabTypeId, strComparisonOpTabTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabMainTypeId) == true)
{
string strComparisonOpTabMainTypeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabMainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabMainTypeId, objPrjTabCond.TabMainTypeId, strComparisonOpTabMainTypeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.RelaTabId4View) == true)
{
string strComparisonOpRelaTabId4View = objPrjTabCond.dicFldComparisonOp[conPrjTab.RelaTabId4View];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.RelaTabId4View, objPrjTabCond.RelaTabId4View, strComparisonOpRelaTabId4View);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNeedGeneIndexer) == true)
{
if (objPrjTabCond.IsNeedGeneIndexer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNeedGeneIndexer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNeedGeneIndexer);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParentClass) == true)
{
string strComparisonOpParentClass = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParentClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParentClass, objPrjTabCond.ParentClass, strComparisonOpParentClass);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsShare) == true)
{
if (objPrjTabCond.IsShare == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsShare);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsShare);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsUseDelSign) == true)
{
if (objPrjTabCond.IsUseDelSign == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsUseDelSign);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsUseDelSign);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsUseCache) == true)
{
if (objPrjTabCond.IsUseCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsUseCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsUseCache);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsMultiKeyClassify) == true)
{
if (objPrjTabCond.IsMultiKeyClassify == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsMultiKeyClassify);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsMultiKeyClassify);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField) == true)
{
string strComparisonOpCacheClassifyField = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField, objPrjTabCond.CacheClassifyField, strComparisonOpCacheClassifyField);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField2) == true)
{
string strComparisonOpCacheClassifyField2 = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField2, objPrjTabCond.CacheClassifyField2, strComparisonOpCacheClassifyField2);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheModeId, objPrjTabCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyFieldTS) == true)
{
string strComparisonOpCacheClassifyFieldTS = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyFieldTS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyFieldTS, objPrjTabCond.CacheClassifyFieldTS, strComparisonOpCacheClassifyFieldTS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.CacheClassifyField2TS) == true)
{
string strComparisonOpCacheClassifyField2TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.CacheClassifyField2TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.CacheClassifyField2TS, objPrjTabCond.CacheClassifyField2TS, strComparisonOpCacheClassifyField2TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParaVar2TS) == true)
{
string strComparisonOpParaVar2TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParaVar2TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParaVar2TS, objPrjTabCond.ParaVar2TS, strComparisonOpParaVar2TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ParaVar1TS) == true)
{
string strComparisonOpParaVar1TS = objPrjTabCond.dicFldComparisonOp[conPrjTab.ParaVar1TS];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ParaVar1TS, objPrjTabCond.ParaVar1TS, strComparisonOpParaVar1TS);
}
if (objPrjTabCond.IsUpdated(conPrjTab.WhereFormat) == true)
{
string strComparisonOpWhereFormat = objPrjTabCond.dicFldComparisonOp[conPrjTab.WhereFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.WhereFormat, objPrjTabCond.WhereFormat, strComparisonOpWhereFormat);
}
if (objPrjTabCond.IsUpdated(conPrjTab.WhereFormatBack) == true)
{
string strComparisonOpWhereFormatBack = objPrjTabCond.dicFldComparisonOp[conPrjTab.WhereFormatBack];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.WhereFormatBack, objPrjTabCond.WhereFormatBack, strComparisonOpWhereFormatBack);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsRefresh4RelaView) == true)
{
if (objPrjTabCond.IsRefresh4RelaView == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsRefresh4RelaView);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsRefresh4RelaView);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabRecNum) == true)
{
string strComparisonOpTabRecNum = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabRecNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.TabRecNum, objPrjTabCond.TabRecNum, strComparisonOpTabRecNum);
}
if (objPrjTabCond.IsUpdated(conPrjTab.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objPrjTabCond.dicFldComparisonOp[conPrjTab.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.KeyId4Test, objPrjTabCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objPrjTabCond.IsUpdated(conPrjTab.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjTabCond.dicFldComparisonOp[conPrjTab.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.ErrMsg, objPrjTabCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjTabCond.IsUpdated(conPrjTab.FldNum) == true)
{
string strComparisonOpFldNum = objPrjTabCond.dicFldComparisonOp[conPrjTab.FldNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.FldNum, objPrjTabCond.FldNum, strComparisonOpFldNum);
}
if (objPrjTabCond.IsUpdated(conPrjTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPrjTabCond.dicFldComparisonOp[conPrjTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.UpdUserId, objPrjTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjTabCond.dicFldComparisonOp[conPrjTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.UpdDate, objPrjTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjTabCond.IsUpdated(conPrjTab.Memo) == true)
{
string strComparisonOpMemo = objPrjTabCond.dicFldComparisonOp[conPrjTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Memo, objPrjTabCond.Memo, strComparisonOpMemo);
}
if (objPrjTabCond.IsUpdated(conPrjTab.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objPrjTabCond.dicFldComparisonOp[conPrjTab.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTab.OrderNum4Refer, objPrjTabCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsChecked) == true)
{
if (objPrjTabCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsChecked);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.Owner) == true)
{
string strComparisonOpOwner = objPrjTabCond.dicFldComparisonOp[conPrjTab.Owner];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.Owner, objPrjTabCond.Owner, strComparisonOpOwner);
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabEnName) == true)
{
string strComparisonOpTabEnName = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabEnName, objPrjTabCond.TabEnName, strComparisonOpTabEnName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNeedTransCode) == true)
{
if (objPrjTabCond.IsNeedTransCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNeedTransCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNeedTransCode);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.TabNameB) == true)
{
string strComparisonOpTabNameB = objPrjTabCond.dicFldComparisonOp[conPrjTab.TabNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.TabNameB, objPrjTabCond.TabNameB, strComparisonOpTabNameB);
}
if (objPrjTabCond.IsUpdated(conPrjTab.RelaViewId) == true)
{
string strComparisonOpRelaViewId = objPrjTabCond.dicFldComparisonOp[conPrjTab.RelaViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.RelaViewId, objPrjTabCond.RelaViewId, strComparisonOpRelaViewId);
}
if (objPrjTabCond.IsUpdated(conPrjTab.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objPrjTabCond.dicFldComparisonOp[conPrjTab.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTab.DataBaseName, objPrjTabCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsNationStandard) == true)
{
if (objPrjTabCond.IsNationStandard == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsNationStandard);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsNationStandard);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsParaTab) == true)
{
if (objPrjTabCond.IsParaTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsParaTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsParaTab);
}
}
if (objPrjTabCond.IsUpdated(conPrjTab.IsArchive) == true)
{
if (objPrjTabCond.IsArchive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTab.IsArchive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTab.IsArchive);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--PrjTab(工程表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PrjId_TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsPrjTabEN objPrjTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabEN == null) return true;
if (objPrjTabEN.TabId == null || objPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
if (clsPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
if (clsPrjTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--PrjTab(工程表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsPrjTabEN objPrjTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabEN == null) return "";
if (objPrjTabEN.TabId == null || objPrjTabEN.TabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TabId !=  '{0}'", objPrjTabEN.TabId);
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PrjTab
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工程表(PrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabBL
{
public static RelatedActions_PrjTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPrjTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPrjTabDA PrjTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPrjTabDA();
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
 public clsPrjTabBL()
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
if (string.IsNullOrEmpty(clsPrjTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabEN._ConnectString);
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
public static DataTable GetDataTable_PrjTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PrjTabDA.GetDataTable_PrjTab(strWhereCond);
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
objDT = PrjTabDA.GetDataTable(strWhereCond);
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
objDT = PrjTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PrjTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PrjTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PrjTabDA.GetDataTable_Top(objTopPara);
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
objDT = PrjTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PrjTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsPrjTabEN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
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
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPrjTabEN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel =
arrPrjTabObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrPrjTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabEN> GetObjLst(string strWhereCond)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
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
public static List<clsPrjTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPrjTabEN> GetSubObjLstCache(clsPrjTabEN objPrjTabCond)
{
 string strPrjId = objPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsPrjTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTab._AttributeName)
{
if (objPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabCond[strFldName].ToString());
}
else
{
if (objPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabCond[strFldName]));
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
public static List<clsPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
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
public static List<clsPrjTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
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
List<clsPrjTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPrjTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
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
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
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
public static List<clsPrjTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPrjTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
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
public static List<clsPrjTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPrjTabEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPrjTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPrjTab(ref clsPrjTabEN objPrjTabEN)
{
bool bolResult = PrjTabDA.GetPrjTab(ref objPrjTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabEN GetObjByTabId(string strTabId)
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
clsPrjTabEN objPrjTabEN = PrjTabDA.GetObjByTabId(strTabId);
return objPrjTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPrjTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPrjTabEN objPrjTabEN = PrjTabDA.GetFirstObj(strWhereCond);
 return objPrjTabEN;
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
public static clsPrjTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPrjTabEN objPrjTabEN = PrjTabDA.GetObjByDataRow(objRow);
 return objPrjTabEN;
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
public static clsPrjTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPrjTabEN objPrjTabEN = PrjTabDA.GetObjByDataRow(objRow);
 return objPrjTabEN;
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
 /// <param name = "lstPrjTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabEN GetObjByTabIdFromList(string strTabId, List<clsPrjTabEN> lstPrjTabObjLst)
{
foreach (clsPrjTabEN objPrjTabEN in lstPrjTabObjLst)
{
if (objPrjTabEN.TabId == strTabId)
{
return objPrjTabEN;
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
 string strMaxTabId;
 try
 {
 strMaxTabId = new clsPrjTabDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxTabId;
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
 string strTabId;
 try
 {
 strTabId = new clsPrjTabDA().GetFirstID(strWhereCond);
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
 arrList = PrjTabDA.GetID(strWhereCond);
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
bool bolIsExist = PrjTabDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = PrjTabDA.IsExist(strTabId);
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
clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPrjTabEN.UpdUserId = strOpUser;
return clsPrjTabBL.UpdateBySql2(objPrjTabEN);
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
 bolIsExist = clsPrjTabDA.IsExistTable();
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
 bolIsExist = PrjTabDA.IsExistTable(strTabName);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTabBL.IsExist(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjTabBL.AddNewRecordBySql2)", objPrjTabEN.TabName,objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
bool bolResult = PrjTabDA.AddNewRecordBySQL2(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPrjTabEN objPrjTabEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPrjTabBL.IsExist(objPrjTabEN.TabId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPrjTabEN.TabId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objPrjTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!表名 = [{0}],工程Id = [{1}]的数据已经存在!(in clsPrjTabBL.AddNewRecordBySql2WithReturnKey)", objPrjTabEN.TabName,objPrjTabEN.PrjId);
throw new Exception(strMsg);
}
try
{
string strKey = PrjTabDA.AddNewRecordBySQL2WithReturnKey(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPrjTabEN objPrjTabEN)
{
try
{
bool bolResult = PrjTabDA.Update(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPrjTabEN objPrjTabEN)
{
 if (string.IsNullOrEmpty(objPrjTabEN.TabId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PrjTabDA.UpdateBySql2(objPrjTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabBL.ReFreshCache(objPrjTabEN.PrjId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
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
 clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);

if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(objPrjTabEN.TabId, objPrjTabEN.UpdUserId);
}
if (objPrjTabEN != null)
{
int intRecNum = PrjTabDA.DelRecord(strTabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabEN.PrjId);
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
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTabId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTabDA.GetSpecSQLObj();
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
//删除与表:[PrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPrjTab.TabId,
//strTabId);
//        clsPrjTabBL.DelPrjTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabBL.DelRecord(strTabId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(string strTabId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPrjTabBL.relatedActions != null)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
bool bolResult = PrjTabDA.DelRecord(strTabId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTabIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPrjTabs(List<string> arrTabIdLst)
{
if (arrTabIdLst.Count == 0) return 0;
try
{
if (clsPrjTabBL.relatedActions != null)
{
foreach (var strTabId in arrTabIdLst)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
 clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(arrTabIdLst[0]);
int intDelRecNum = PrjTabDA.DelPrjTab(arrTabIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objPrjTabEN.PrjId);
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
public static int DelPrjTabsByCond(string strWhereCond)
{
try
{
if (clsPrjTabBL.relatedActions != null)
{
List<string> arrTabId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTabId in arrTabId)
{
clsPrjTabBL.relatedActions.UpdRelaTabDate(strTabId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conPrjTab.PrjId, strWhereCond);
int intRecNum = PrjTabDA.DelPrjTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PrjTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTabId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTabId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPrjTabDA.GetSpecSQLObj();
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
//删除与表:[PrjTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPrjTabBL.DelRecord(strTabId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPrjTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
 public static void CopyTo(clsPrjTabEN objPrjTabENS, clsPrjTabEN objPrjTabENT)
{
try
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程Id
objPrjTabENT.SqlDsTypeId = objPrjTabENS.SqlDsTypeId; //数据源类型Id
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.Keyword = objPrjTabENS.Keyword; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsShare = objPrjTabENS.IsShare; //是否共享
objPrjTabENT.IsUseDelSign = objPrjTabENS.IsUseDelSign; //是否使用删除标记
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.IsMultiKeyClassify = objPrjTabENS.IsMultiKeyClassify; //是否可以多个关键字分类共存
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.CacheClassifyField2 = objPrjTabENS.CacheClassifyField2; //缓存分类字段2
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyFieldTS = objPrjTabENS.CacheClassifyFieldTS; //缓存分类字段_TS
objPrjTabENT.CacheClassifyField2TS = objPrjTabENS.CacheClassifyField2TS; //缓存分类字段2_TS
objPrjTabENT.ParaVar2TS = objPrjTabENS.ParaVar2TS; //参数变量2_TS
objPrjTabENT.ParaVar1TS = objPrjTabENS.ParaVar1TS; //参数变量_TS
objPrjTabENT.WhereFormat = objPrjTabENS.WhereFormat; //缓存条件格式
objPrjTabENT.WhereFormatBack = objPrjTabENS.WhereFormatBack; //后台缓存条件格式
objPrjTabENT.IsRefresh4RelaView = objPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objPrjTabENT.TabRecNum = objPrjTabENS.TabRecNum; //记录数
objPrjTabENT.KeyId4Test = objPrjTabENS.KeyId4Test; //测试关键字Id
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.FldNum = objPrjTabENS.FldNum; //字段数
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabNameB = objPrjTabENS.TabNameB; //表名_后备
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
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
 /// <param name = "objPrjTabEN">源简化对象</param>
 public static void SetUpdFlag(clsPrjTabEN objPrjTabEN)
{
try
{
objPrjTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPrjTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPrjTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabId = objPrjTabEN.TabId; //表ID
}
if (arrFldSet.Contains(conPrjTab.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabName = objPrjTabEN.TabName; //表名
}
if (arrFldSet.Contains(conPrjTab.TabCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabCnName = objPrjTabEN.TabCnName == "[null]" ? null :  objPrjTabEN.TabCnName; //表中文名
}
if (arrFldSet.Contains(conPrjTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.PrjId = objPrjTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conPrjTab.SqlDsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.SqlDsTypeId = objPrjTabEN.SqlDsTypeId == "[null]" ? null :  objPrjTabEN.SqlDsTypeId; //数据源类型Id
}
if (arrFldSet.Contains(conPrjTab.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabStateId = objPrjTabEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(conPrjTab.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId == "[null]" ? null :  objPrjTabEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(conPrjTab.IsReleToSqlTab, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsReleToSqlTab = objPrjTabEN.IsReleToSqlTab; //是否与SQL表相关
}
if (arrFldSet.Contains(conPrjTab.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.Keyword = objPrjTabEN.Keyword == "[null]" ? null :  objPrjTabEN.Keyword; //关键字
}
if (arrFldSet.Contains(conPrjTab.TabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabTypeId = objPrjTabEN.TabTypeId; //表类型Id
}
if (arrFldSet.Contains(conPrjTab.TabMainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabMainTypeId = objPrjTabEN.TabMainTypeId; //表主类型Id
}
if (arrFldSet.Contains(conPrjTab.RelaTabId4View, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.RelaTabId4View = objPrjTabEN.RelaTabId4View == "[null]" ? null :  objPrjTabEN.RelaTabId4View; //视图的相关表ID
}
if (arrFldSet.Contains(conPrjTab.IsNeedGeneIndexer, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsNeedGeneIndexer = objPrjTabEN.IsNeedGeneIndexer; //是否需要生成索引器
}
if (arrFldSet.Contains(conPrjTab.ParentClass, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.ParentClass = objPrjTabEN.ParentClass == "[null]" ? null :  objPrjTabEN.ParentClass; //父类
}
if (arrFldSet.Contains(conPrjTab.IsShare, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsShare = objPrjTabEN.IsShare; //是否共享
}
if (arrFldSet.Contains(conPrjTab.IsUseDelSign, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsUseDelSign = objPrjTabEN.IsUseDelSign; //是否使用删除标记
}
if (arrFldSet.Contains(conPrjTab.IsUseCache, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsUseCache = objPrjTabEN.IsUseCache; //是否使用Cache
}
if (arrFldSet.Contains(conPrjTab.IsMultiKeyClassify, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsMultiKeyClassify = objPrjTabEN.IsMultiKeyClassify; //是否可以多个关键字分类共存
}
if (arrFldSet.Contains(conPrjTab.CacheClassifyField, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.CacheClassifyField = objPrjTabEN.CacheClassifyField == "[null]" ? null :  objPrjTabEN.CacheClassifyField; //缓存分类字段
}
if (arrFldSet.Contains(conPrjTab.CacheClassifyField2, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.CacheClassifyField2 = objPrjTabEN.CacheClassifyField2 == "[null]" ? null :  objPrjTabEN.CacheClassifyField2; //缓存分类字段2
}
if (arrFldSet.Contains(conPrjTab.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.CacheModeId = objPrjTabEN.CacheModeId == "[null]" ? null :  objPrjTabEN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(conPrjTab.CacheClassifyFieldTS, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.CacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS == "[null]" ? null :  objPrjTabEN.CacheClassifyFieldTS; //缓存分类字段_TS
}
if (arrFldSet.Contains(conPrjTab.CacheClassifyField2TS, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.CacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS == "[null]" ? null :  objPrjTabEN.CacheClassifyField2TS; //缓存分类字段2_TS
}
if (arrFldSet.Contains(conPrjTab.ParaVar2TS, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.ParaVar2TS = objPrjTabEN.ParaVar2TS == "[null]" ? null :  objPrjTabEN.ParaVar2TS; //参数变量2_TS
}
if (arrFldSet.Contains(conPrjTab.ParaVar1TS, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.ParaVar1TS = objPrjTabEN.ParaVar1TS == "[null]" ? null :  objPrjTabEN.ParaVar1TS; //参数变量_TS
}
if (arrFldSet.Contains(conPrjTab.WhereFormat, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.WhereFormat = objPrjTabEN.WhereFormat == "[null]" ? null :  objPrjTabEN.WhereFormat; //缓存条件格式
}
if (arrFldSet.Contains(conPrjTab.WhereFormatBack, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.WhereFormatBack = objPrjTabEN.WhereFormatBack == "[null]" ? null :  objPrjTabEN.WhereFormatBack; //后台缓存条件格式
}
if (arrFldSet.Contains(conPrjTab.IsRefresh4RelaView, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsRefresh4RelaView = objPrjTabEN.IsRefresh4RelaView; //是否刷新相关视图
}
if (arrFldSet.Contains(conPrjTab.TabRecNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabRecNum = objPrjTabEN.TabRecNum; //记录数
}
if (arrFldSet.Contains(conPrjTab.KeyId4Test, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.KeyId4Test = objPrjTabEN.KeyId4Test == "[null]" ? null :  objPrjTabEN.KeyId4Test; //测试关键字Id
}
if (arrFldSet.Contains(conPrjTab.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.ErrMsg = objPrjTabEN.ErrMsg == "[null]" ? null :  objPrjTabEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conPrjTab.FldNum, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.FldNum = objPrjTabEN.FldNum; //字段数
}
if (arrFldSet.Contains(conPrjTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.UpdUserId = objPrjTabEN.UpdUserId == "[null]" ? null :  objPrjTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPrjTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.UpdDate = objPrjTabEN.UpdDate == "[null]" ? null :  objPrjTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPrjTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.Memo = objPrjTabEN.Memo == "[null]" ? null :  objPrjTabEN.Memo; //说明
}
if (arrFldSet.Contains(conPrjTab.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.OrderNum4Refer = objPrjTabEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(conPrjTab.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsChecked = objPrjTabEN.IsChecked; //是否核实
}
if (arrFldSet.Contains(conPrjTab.Owner, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.Owner = objPrjTabEN.Owner == "[null]" ? null :  objPrjTabEN.Owner; //拥有者
}
if (arrFldSet.Contains(conPrjTab.TabEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabEnName = objPrjTabEN.TabEnName == "[null]" ? null :  objPrjTabEN.TabEnName; //表英文详细名
}
if (arrFldSet.Contains(conPrjTab.IsNeedTransCode, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsNeedTransCode = objPrjTabEN.IsNeedTransCode; //是否需要转换代码
}
if (arrFldSet.Contains(conPrjTab.TabNameB, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.TabNameB = objPrjTabEN.TabNameB == "[null]" ? null :  objPrjTabEN.TabNameB; //表名_后备
}
if (arrFldSet.Contains(conPrjTab.RelaViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.RelaViewId = objPrjTabEN.RelaViewId == "[null]" ? null :  objPrjTabEN.RelaViewId; //RelaViewId
}
if (arrFldSet.Contains(conPrjTab.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.DataBaseName = objPrjTabEN.DataBaseName == "[null]" ? null :  objPrjTabEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(conPrjTab.IsNationStandard, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsNationStandard = objPrjTabEN.IsNationStandard; //是否国标
}
if (arrFldSet.Contains(conPrjTab.IsParaTab, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsParaTab = objPrjTabEN.IsParaTab; //是否参数表
}
if (arrFldSet.Contains(conPrjTab.IsArchive, new clsStrCompareIgnoreCase())  ==  true)
{
objPrjTabEN.IsArchive = objPrjTabEN.IsArchive; //是否存档
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
 /// <param name = "objPrjTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsPrjTabEN objPrjTabEN)
{
try
{
if (objPrjTabEN.TabCnName == "[null]") objPrjTabEN.TabCnName = null; //表中文名
if (objPrjTabEN.SqlDsTypeId == "[null]") objPrjTabEN.SqlDsTypeId = null; //数据源类型Id
if (objPrjTabEN.FuncModuleAgcId == "[null]") objPrjTabEN.FuncModuleAgcId = null; //功能模块Id
if (objPrjTabEN.Keyword == "[null]") objPrjTabEN.Keyword = null; //关键字
if (objPrjTabEN.RelaTabId4View == "[null]") objPrjTabEN.RelaTabId4View = null; //视图的相关表ID
if (objPrjTabEN.ParentClass == "[null]") objPrjTabEN.ParentClass = null; //父类
if (objPrjTabEN.CacheClassifyField == "[null]") objPrjTabEN.CacheClassifyField = null; //缓存分类字段
if (objPrjTabEN.CacheClassifyField2 == "[null]") objPrjTabEN.CacheClassifyField2 = null; //缓存分类字段2
if (objPrjTabEN.CacheModeId == "[null]") objPrjTabEN.CacheModeId = null; //缓存方式Id
if (objPrjTabEN.CacheClassifyFieldTS == "[null]") objPrjTabEN.CacheClassifyFieldTS = null; //缓存分类字段_TS
if (objPrjTabEN.CacheClassifyField2TS == "[null]") objPrjTabEN.CacheClassifyField2TS = null; //缓存分类字段2_TS
if (objPrjTabEN.ParaVar2TS == "[null]") objPrjTabEN.ParaVar2TS = null; //参数变量2_TS
if (objPrjTabEN.ParaVar1TS == "[null]") objPrjTabEN.ParaVar1TS = null; //参数变量_TS
if (objPrjTabEN.WhereFormat == "[null]") objPrjTabEN.WhereFormat = null; //缓存条件格式
if (objPrjTabEN.WhereFormatBack == "[null]") objPrjTabEN.WhereFormatBack = null; //后台缓存条件格式
if (objPrjTabEN.KeyId4Test == "[null]") objPrjTabEN.KeyId4Test = null; //测试关键字Id
if (objPrjTabEN.ErrMsg == "[null]") objPrjTabEN.ErrMsg = null; //错误信息
if (objPrjTabEN.UpdUserId == "[null]") objPrjTabEN.UpdUserId = null; //修改用户Id
if (objPrjTabEN.UpdDate == "[null]") objPrjTabEN.UpdDate = null; //修改日期
if (objPrjTabEN.Memo == "[null]") objPrjTabEN.Memo = null; //说明
if (objPrjTabEN.Owner == "[null]") objPrjTabEN.Owner = null; //拥有者
if (objPrjTabEN.TabEnName == "[null]") objPrjTabEN.TabEnName = null; //表英文详细名
if (objPrjTabEN.TabNameB == "[null]") objPrjTabEN.TabNameB = null; //表名_后备
if (objPrjTabEN.RelaViewId == "[null]") objPrjTabEN.RelaViewId = null; //RelaViewId
if (objPrjTabEN.DataBaseName == "[null]") objPrjTabEN.DataBaseName = null; //数据库名
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
public static void CheckPropertyNew(clsPrjTabEN objPrjTabEN)
{
 PrjTabDA.CheckPropertyNew(objPrjTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPrjTabEN objPrjTabEN)
{
 PrjTabDA.CheckProperty4Condition(objPrjTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_TabId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
List<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLst(strCondition).OrderBy(x=>x.TabName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjTabEN objPrjTabEN = new clsPrjTabEN()
{
TabId = "0",
TabName = "选[工程表]..."
};
arrObjLstSel.Insert(0, objPrjTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjTab.TabId;
objComboBox.DisplayMember = conPrjTab.TabName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_TabId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPrjTab.TabId); 
IEnumerable<clsPrjTabEN> arrObjLst = clsPrjTabBL.GetObjLst(strCondition).OrderBy(x=>x.TabName);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = conPrjTab.TabId;
objDDL.DataTextField = conPrjTab.TabName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TabIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表]...","0");
List<clsPrjTabEN> arrPrjTabObjLst = GetAllPrjTabObjLstCache(strPrjId); 
objDDL.DataValueField = conPrjTab.TabId;
objDDL.DataTextField = conPrjTab.TabName;
objDDL.DataSource = arrPrjTabObjLst;
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrPrjTabObjLstCache == null)
//{
//arrPrjTabObjLstCache = PrjTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabEN GetObjByTabIdCache(string strTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabEN> arrPrjTabObjLst_Sel =
arrPrjTabObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrPrjTabObjLst_Sel.Count() == 0)
{
   clsPrjTabEN obj = clsPrjTabBL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrPrjTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTabNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsPrjTabEN objPrjTab = GetObjByTabIdCache(strTabId, strPrjId);
if (objPrjTab == null) return "";
return objPrjTab.TabName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTabIdCache(string strTabId, string strPrjId)
{
if (string.IsNullOrEmpty(strTabId) == true) return "";
//获取缓存中的对象列表
clsPrjTabEN objPrjTab = GetObjByTabIdCache(strTabId, strPrjId);
if (objPrjTab == null) return "";
return objPrjTab.TabName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabEN> GetAllPrjTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsPrjTabEN> arrPrjTabObjLstCache = GetObjLstCache(strPrjId); 
return arrPrjTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsPrjTabEN> arrPrjTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrPrjTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPrjTabEN._RefreshTimeLst.Count == 0) return "";
return clsPrjTabEN._RefreshTimeLst[clsPrjTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsPrjTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPrjTabBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--PrjTab(工程表)
 /// 唯一性条件:PrjId_TabName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsPrjTabEN objPrjTabEN)
{
//检测记录是否存在
string strResult = PrjTabDA.GetUniCondStr(objPrjTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strPrjId)
{
if (strInFldName != conPrjTab.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPrjTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPrjTab._AttributeName));
throw new Exception(strMsg);
}
var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
if (objPrjTab == null) return "";
return objPrjTab[strOutFldName].ToString();
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
int intRecCount = clsPrjTabDA.GetRecCount(strTabName);
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
int intRecCount = clsPrjTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPrjTabDA.GetRecCount();
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
int intRecCount = clsPrjTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPrjTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPrjTabEN objPrjTabCond)
{
 string strPrjId = objPrjTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsPrjTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsPrjTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPrjTab._AttributeName)
{
if (objPrjTabCond.IsUpdated(strFldName) == false) continue;
if (objPrjTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabCond[strFldName].ToString());
}
else
{
if (objPrjTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPrjTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPrjTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPrjTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPrjTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPrjTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPrjTabCond[strFldName]));
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
 List<string> arrList = clsPrjTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PrjTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PrjTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PrjTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabDA.SetFldValue(clsPrjTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PrjTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPrjTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPrjTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PrjTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) primary key, "); 
 // /**表名*/ 
 strCreateTabCode.Append(" TabName varchar(100) not Null, "); 
 // /**表中文名*/ 
 strCreateTabCode.Append(" TabCnName varchar(200) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**数据源类型Id*/ 
 strCreateTabCode.Append(" SqlDsTypeId char(2) Null, "); 
 // /**表状态ID*/ 
 strCreateTabCode.Append(" TabStateId char(2) not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleAgcId char(8) Null, "); 
 // /**是否与SQL表相关*/ 
 strCreateTabCode.Append(" IsReleToSqlTab bit not Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(50) Null, "); 
 // /**表类型Id*/ 
 strCreateTabCode.Append(" TabTypeId char(4) not Null, "); 
 // /**表主类型Id*/ 
 strCreateTabCode.Append(" TabMainTypeId char(4) not Null, "); 
 // /**视图的相关表ID*/ 
 strCreateTabCode.Append(" RelaTabId4View char(8) Null, "); 
 // /**是否需要生成索引器*/ 
 strCreateTabCode.Append(" IsNeedGeneIndexer bit Null, "); 
 // /**父类*/ 
 strCreateTabCode.Append(" ParentClass varchar(50) Null, "); 
 // /**是否共享*/ 
 strCreateTabCode.Append(" IsShare bit Null, "); 
 // /**是否使用删除标记*/ 
 strCreateTabCode.Append(" IsUseDelSign bit Null, "); 
 // /**是否使用Cache*/ 
 strCreateTabCode.Append(" IsUseCache bit Null, "); 
 // /**是否可以多个关键字分类共存*/ 
 strCreateTabCode.Append(" IsMultiKeyClassify bit Null, "); 
 // /**缓存分类字段*/ 
 strCreateTabCode.Append(" CacheClassifyField char(8) Null, "); 
 // /**缓存分类字段2*/ 
 strCreateTabCode.Append(" CacheClassifyField2 char(8) Null, "); 
 // /**缓存方式Id*/ 
 strCreateTabCode.Append(" CacheModeId char(2) Null, "); 
 // /**缓存分类字段_TS*/ 
 strCreateTabCode.Append(" CacheClassifyFieldTS char(8) Null, "); 
 // /**缓存分类字段2_TS*/ 
 strCreateTabCode.Append(" CacheClassifyField2TS char(8) Null, "); 
 // /**参数变量2_TS*/ 
 strCreateTabCode.Append(" ParaVar2TS char(8) Null, "); 
 // /**参数变量_TS*/ 
 strCreateTabCode.Append(" ParaVar1TS char(8) Null, "); 
 // /**缓存条件格式*/ 
 strCreateTabCode.Append(" WhereFormat varchar(500) Null, "); 
 // /**后台缓存条件格式*/ 
 strCreateTabCode.Append(" WhereFormatBack varchar(500) Null, "); 
 // /**是否刷新相关视图*/ 
 strCreateTabCode.Append(" IsRefresh4RelaView bit Null, "); 
 // /**记录数*/ 
 strCreateTabCode.Append(" TabRecNum int Null, "); 
 // /**测试关键字Id*/ 
 strCreateTabCode.Append(" KeyId4Test varchar(50) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**字段数*/ 
 strCreateTabCode.Append(" FldNum int Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**引用序号*/ 
 strCreateTabCode.Append(" OrderNum4Refer int Null, "); 
 // /**功能模块名称*/ 
 strCreateTabCode.Append(" FuncModuleName varchar(30) Null, "); 
 // /**Sql数据源名*/ 
 strCreateTabCode.Append(" SqlDsTypeName varchar(20) Null, "); 
 // /**表状态名称*/ 
 strCreateTabCode.Append(" TabStateName varchar(30) Null, "); 
 // /**表主类型名*/ 
 strCreateTabCode.Append(" TabMainTypeName varchar(30) Null, "); 
 // /**表类型名*/ 
 strCreateTabCode.Append(" TabTypeName varchar(30) Null, "); 
 // /**简化日期时间*/ 
 strCreateTabCode.Append(" DateTimeSim varchar(20) Null, "); 
 // /**RelaTabName4View*/ 
 strCreateTabCode.Append(" RelaTabName4View varchar(100) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**表功能约束*/ 
 strCreateTabCode.Append(" TabFeatureConstraint varchar(50) Null, "); 
 // /**是否核实*/ 
 strCreateTabCode.Append(" IsChecked bit Null, "); 
 // /**Cm工程名s*/ 
 strCreateTabCode.Append(" TabNameEx varchar(50) Null, "); 
 // /**表类型名Ex*/ 
 strCreateTabCode.Append(" TabTypeNameEx varchar(50) Null, "); 
 // /**缓存分类字段名Ex*/ 
 strCreateTabCode.Append(" CacheClassifyField4TSEx varchar(50) Null, "); 
 // /**缓存分类字段名Ex*/ 
 strCreateTabCode.Append(" CacheClassifyFieldEx varchar(50) Null, "); 
 // /**Cm工程名s*/ 
 strCreateTabCode.Append(" CmPrjNames varchar(50) Null, "); 
 // /**主键类型名Ex*/ 
 strCreateTabCode.Append(" PrimaryTypeNameEx varchar(50) Null, "); 
 // /**主键类型名*/ 
 strCreateTabCode.Append(" PrimaryTypeName varchar(30) not Null, "); 
 // /**TrClass*/ 
 strCreateTabCode.Append(" TrClass varchar(50) Null, "); 
 // /**关键字段名s*/ 
 strCreateTabCode.Append(" KeyFldNames varchar(50) Null, "); 
 // /**拥有者*/ 
 strCreateTabCode.Append(" Owner varchar(50) Null, "); 
 // /**表英文详细名*/ 
 strCreateTabCode.Append(" TabEnName varchar(200) Null, "); 
 // /**是否需要转换代码*/ 
 strCreateTabCode.Append(" IsNeedTransCode bit not Null, "); 
 // /**表名_后备*/ 
 strCreateTabCode.Append(" TabNameB varchar(50) Null, "); 
 // /**主键类型ID*/ 
 strCreateTabCode.Append(" PrimaryTypeId char(2) Null, "); 
 // /**包含字段Id*/ 
 strCreateTabCode.Append(" IncludeFldId char(2) Null, "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FeatureId char(4) Null, "); 
 // /**RelaViewId*/ 
 strCreateTabCode.Append(" RelaViewId char(8) Null, "); 
 // /**数据库名*/ 
 strCreateTabCode.Append(" DataBaseName varchar(50) Null, "); 
 // /**是否国标*/ 
 strCreateTabCode.Append(" IsNationStandard bit Null, "); 
 // /**是否参数表*/ 
 strCreateTabCode.Append(" IsParaTab bit Null, "); 
 // /**是否存档*/ 
 strCreateTabCode.Append(" IsArchive bit Null, "); 
 // /**是否选择*/ 
 strCreateTabCode.Append(" Checked bit Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 工程表(PrjTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PrjTab : clsCommFun4BLV2
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
clsPrjTabBL.ReFreshThisCache(strPrjId);
}
}

}