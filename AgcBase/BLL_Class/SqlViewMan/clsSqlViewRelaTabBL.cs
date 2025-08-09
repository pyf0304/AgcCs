
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewRelaTabBL
 表名:SqlViewRelaTab(00050247)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:05
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
public static class  clsSqlViewRelaTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewRelaTabEN GetObj(this K_RelaTabId_SqlViewRelaTab myKey)
{
clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabBL.SqlViewRelaTabDA.GetObjByRelaTabId(myKey.Value);
return objSqlViewRelaTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewRelaTabEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图Id = [{0}],表别名 = [{1}]的数据已经存在!(in clsSqlViewRelaTabBL.AddNewRecord)", objSqlViewRelaTabEN.SqlViewId,objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
bool bolResult = clsSqlViewRelaTabBL.SqlViewRelaTabDA.AddNewRecordBySQL2(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
public static bool AddRecordEx(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSqlViewRelaTabEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSqlViewRelaTabEN.CheckUniqueness() == false)
{
strMsg = string.Format("(Sql视图Id(SqlViewId)=[{0}],表别名(TabAliases)=[{1}])已经存在,不能重复!", objSqlViewRelaTabEN.SqlViewId, objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSqlViewRelaTabEN.AddNewRecord();
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewRelaTabEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图Id = [{0}],表别名 = [{1}]的数据已经存在!(in clsSqlViewRelaTabBL.AddNewRecordWithMaxId)", objSqlViewRelaTabEN.SqlViewId,objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
string strRelaTabId = clsSqlViewRelaTabBL.SqlViewRelaTabDA.AddNewRecordBySQL2WithReturnKey(objSqlViewRelaTabEN);
     objSqlViewRelaTabEN.RelaTabId = strRelaTabId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
}
return strRelaTabId;
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSqlViewRelaTabEN) == false)
{
var strMsg = string.Format("记录已经存在!Sql视图Id = [{0}],表别名 = [{1}]的数据已经存在!(in clsSqlViewRelaTabBL.AddNewRecordWithReturnKey)", objSqlViewRelaTabEN.SqlViewId,objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
string strKey = clsSqlViewRelaTabBL.SqlViewRelaTabDA.AddNewRecordBySQL2WithReturnKey(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetRelaTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strRelaTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlViewRelaTab.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlViewRelaTab.RelaTabId);
}
objSqlViewRelaTabEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.RelaTabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.RelaTabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.RelaTabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetSqlViewId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewId, conSqlViewRelaTab.SqlViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlViewRelaTab.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlViewRelaTab.SqlViewId);
}
objSqlViewRelaTabEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.SqlViewId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.SqlViewId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.SqlViewId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conSqlViewRelaTab.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, conSqlViewRelaTab.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conSqlViewRelaTab.TabId);
}
objSqlViewRelaTabEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabAliases(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabAliases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabAliases, conSqlViewRelaTab.TabAliases);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabAliases, 100, conSqlViewRelaTab.TabAliases);
}
objSqlViewRelaTabEN.TabAliases = strTabAliases; //表别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabAliases) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabAliases, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabAliases] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetRelaFldId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strRelaFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaFldId, 8, conSqlViewRelaTab.RelaFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaFldId, 8, conSqlViewRelaTab.RelaFldId);
}
objSqlViewRelaTabEN.RelaFldId = strRelaFldId; //关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.RelaFldId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.RelaFldId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.RelaFldId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOtherFldId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strOtherFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherFldId, 8, conSqlViewRelaTab.OtherFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOtherFldId, 8, conSqlViewRelaTab.OtherFldId);
}
objSqlViewRelaTabEN.OtherFldId = strOtherFldId; //其他表字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OtherFldId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OtherFldId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OtherFldId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOtherTabId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strOtherTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOtherTabId, 8, conSqlViewRelaTab.OtherTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOtherTabId, 8, conSqlViewRelaTab.OtherTabId);
}
objSqlViewRelaTabEN.OtherTabId = strOtherTabId; //其他表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OtherTabId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OtherTabId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OtherTabId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetSvRelaTabTypeId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strSvRelaTabTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
}
objSqlViewRelaTabEN.SvRelaTabTypeId = strSvRelaTabTypeId; //Sql视图相关表类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.SvRelaTabTypeId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.SvRelaTabTypeId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.SvRelaTabTypeId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabRelationTypeId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
}
objSqlViewRelaTabEN.TabRelationTypeId = strTabRelationTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabRelationTypeId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabRelationTypeId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabRelationTypeId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetTabRelationText(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strTabRelationText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabRelationText, 500, conSqlViewRelaTab.TabRelationText);
}
objSqlViewRelaTabEN.TabRelationText = strTabRelationText; //表关系文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.TabRelationText) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.TabRelationText, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.TabRelationText] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetOrderNum(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conSqlViewRelaTab.OrderNum);
objSqlViewRelaTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.OrderNum) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.OrderNum, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.OrderNum] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetPrjId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlViewRelaTab.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlViewRelaTab.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlViewRelaTab.PrjId);
}
objSqlViewRelaTabEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.PrjId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.PrjId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.PrjId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetUpdDate(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlViewRelaTab.UpdDate);
}
objSqlViewRelaTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.UpdDate) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.UpdDate, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.UpdDate] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetUpdUserId(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlViewRelaTab.UpdUserId);
}
objSqlViewRelaTabEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.UpdUserId) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.UpdUserId, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.UpdUserId] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewRelaTabEN SetMemo(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlViewRelaTab.Memo);
}
objSqlViewRelaTabEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewRelaTabEN.dicFldComparisonOp.ContainsKey(conSqlViewRelaTab.Memo) == false)
{
objSqlViewRelaTabEN.dicFldComparisonOp.Add(conSqlViewRelaTab.Memo, strComparisonOp);
}
else
{
objSqlViewRelaTabEN.dicFldComparisonOp[conSqlViewRelaTab.Memo] = strComparisonOp;
}
}
return objSqlViewRelaTabEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSqlViewRelaTabEN.CheckPropertyNew();
clsSqlViewRelaTabEN objSqlViewRelaTabCond = new clsSqlViewRelaTabEN();
string strCondition = objSqlViewRelaTabCond
.SetRelaTabId(objSqlViewRelaTabEN.RelaTabId, "<>")
.SetSqlViewId(objSqlViewRelaTabEN.SqlViewId, "=")
.SetTabAliases(objSqlViewRelaTabEN.TabAliases, "=")
.GetCombineCondition();
objSqlViewRelaTabEN._IsCheckProperty = true;
bool bolIsExist = clsSqlViewRelaTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SqlViewId_TabAliases)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSqlViewRelaTabEN.Update();
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
 /// <param name = "objSqlViewRelaTab">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSqlViewRelaTabEN objSqlViewRelaTab)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSqlViewRelaTabEN objSqlViewRelaTabCond = new clsSqlViewRelaTabEN();
string strCondition = objSqlViewRelaTabCond
.SetSqlViewId(objSqlViewRelaTab.SqlViewId, "=")
.SetTabAliases(objSqlViewRelaTab.TabAliases, "=")
.GetCombineCondition();
objSqlViewRelaTab._IsCheckProperty = true;
bool bolIsExist = clsSqlViewRelaTabBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSqlViewRelaTab.RelaTabId = clsSqlViewRelaTabBL.GetFirstID_S(strCondition);
objSqlViewRelaTab.UpdateWithCondition(strCondition);
}
else
{
objSqlViewRelaTab.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
objSqlViewRelaTab.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewRelaTabBL.SqlViewRelaTabDA.UpdateBySql2(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSqlViewRelaTabBL.SqlViewRelaTabDA.UpdateBySql2(objSqlViewRelaTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strWhereCond)
{
try
{
bool bolResult = clsSqlViewRelaTabBL.SqlViewRelaTabDA.UpdateBySqlWithCondition(objSqlViewRelaTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSqlViewRelaTabBL.SqlViewRelaTabDA.UpdateBySqlWithConditionTransaction(objSqlViewRelaTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
int intRecNum = clsSqlViewRelaTabBL.SqlViewRelaTabDA.DelRecord(objSqlViewRelaTabEN.RelaTabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabENS">源对象</param>
 /// <param name = "objSqlViewRelaTabENT">目标对象</param>
 public static void CopyTo(this clsSqlViewRelaTabEN objSqlViewRelaTabENS, clsSqlViewRelaTabEN objSqlViewRelaTabENT)
{
try
{
objSqlViewRelaTabENT.RelaTabId = objSqlViewRelaTabENS.RelaTabId; //相关表Id
objSqlViewRelaTabENT.SqlViewId = objSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objSqlViewRelaTabENT.TabId = objSqlViewRelaTabENS.TabId; //表ID
objSqlViewRelaTabENT.TabAliases = objSqlViewRelaTabENS.TabAliases; //表别名
objSqlViewRelaTabENT.RelaFldId = objSqlViewRelaTabENS.RelaFldId; //关系字段
objSqlViewRelaTabENT.OtherFldId = objSqlViewRelaTabENS.OtherFldId; //其他表字段
objSqlViewRelaTabENT.OtherTabId = objSqlViewRelaTabENS.OtherTabId; //其他表Id
objSqlViewRelaTabENT.SvRelaTabTypeId = objSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSqlViewRelaTabENT.TabRelationTypeId = objSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objSqlViewRelaTabENT.TabRelationText = objSqlViewRelaTabENS.TabRelationText; //表关系文本
objSqlViewRelaTabENT.OrderNum = objSqlViewRelaTabENS.OrderNum; //序号
objSqlViewRelaTabENT.PrjId = objSqlViewRelaTabENS.PrjId; //工程Id
objSqlViewRelaTabENT.UpdDate = objSqlViewRelaTabENS.UpdDate; //修改日期
objSqlViewRelaTabENT.UpdUserId = objSqlViewRelaTabENS.UpdUserId; //修改用户Id
objSqlViewRelaTabENT.Memo = objSqlViewRelaTabENS.Memo; //说明
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
 /// <param name = "objSqlViewRelaTabENS">源对象</param>
 /// <returns>目标对象=>clsSqlViewRelaTabEN:objSqlViewRelaTabENT</returns>
 public static clsSqlViewRelaTabEN CopyTo(this clsSqlViewRelaTabEN objSqlViewRelaTabENS)
{
try
{
 clsSqlViewRelaTabEN objSqlViewRelaTabENT = new clsSqlViewRelaTabEN()
{
RelaTabId = objSqlViewRelaTabENS.RelaTabId, //相关表Id
SqlViewId = objSqlViewRelaTabENS.SqlViewId, //Sql视图Id
TabId = objSqlViewRelaTabENS.TabId, //表ID
TabAliases = objSqlViewRelaTabENS.TabAliases, //表别名
RelaFldId = objSqlViewRelaTabENS.RelaFldId, //关系字段
OtherFldId = objSqlViewRelaTabENS.OtherFldId, //其他表字段
OtherTabId = objSqlViewRelaTabENS.OtherTabId, //其他表Id
SvRelaTabTypeId = objSqlViewRelaTabENS.SvRelaTabTypeId, //Sql视图相关表类型Id
TabRelationTypeId = objSqlViewRelaTabENS.TabRelationTypeId, //表关系类型Id
TabRelationText = objSqlViewRelaTabENS.TabRelationText, //表关系文本
OrderNum = objSqlViewRelaTabENS.OrderNum, //序号
PrjId = objSqlViewRelaTabENS.PrjId, //工程Id
UpdDate = objSqlViewRelaTabENS.UpdDate, //修改日期
UpdUserId = objSqlViewRelaTabENS.UpdUserId, //修改用户Id
Memo = objSqlViewRelaTabENS.Memo, //说明
};
 return objSqlViewRelaTabENT;
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
public static void CheckPropertyNew(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 clsSqlViewRelaTabBL.SqlViewRelaTabDA.CheckPropertyNew(objSqlViewRelaTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 clsSqlViewRelaTabBL.SqlViewRelaTabDA.CheckProperty4Condition(objSqlViewRelaTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewRelaTabEN objSqlViewRelaTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.RelaTabId, objSqlViewRelaTabCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.SqlViewId, objSqlViewRelaTabCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabId) == true)
{
string strComparisonOpTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabId, objSqlViewRelaTabCond.TabId, strComparisonOpTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabAliases) == true)
{
string strComparisonOpTabAliases = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabAliases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabAliases, objSqlViewRelaTabCond.TabAliases, strComparisonOpTabAliases);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.RelaFldId) == true)
{
string strComparisonOpRelaFldId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.RelaFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.RelaFldId, objSqlViewRelaTabCond.RelaFldId, strComparisonOpRelaFldId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OtherFldId) == true)
{
string strComparisonOpOtherFldId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OtherFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.OtherFldId, objSqlViewRelaTabCond.OtherFldId, strComparisonOpOtherFldId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OtherTabId) == true)
{
string strComparisonOpOtherTabId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OtherTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.OtherTabId, objSqlViewRelaTabCond.OtherTabId, strComparisonOpOtherTabId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId) == true)
{
string strComparisonOpSvRelaTabTypeId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.SvRelaTabTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.SvRelaTabTypeId, objSqlViewRelaTabCond.SvRelaTabTypeId, strComparisonOpSvRelaTabTypeId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabRelationTypeId) == true)
{
string strComparisonOpTabRelationTypeId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabRelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabRelationTypeId, objSqlViewRelaTabCond.TabRelationTypeId, strComparisonOpTabRelationTypeId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.TabRelationText) == true)
{
string strComparisonOpTabRelationText = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.TabRelationText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.TabRelationText, objSqlViewRelaTabCond.TabRelationText, strComparisonOpTabRelationText);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSqlViewRelaTab.OrderNum, objSqlViewRelaTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.PrjId, objSqlViewRelaTabCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.UpdDate, objSqlViewRelaTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.UpdUserId, objSqlViewRelaTabCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewRelaTabCond.IsUpdated(conSqlViewRelaTab.Memo) == true)
{
string strComparisonOpMemo = objSqlViewRelaTabCond.dicFldComparisonOp[conSqlViewRelaTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlViewRelaTab.Memo, objSqlViewRelaTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SqlViewRelaTab(Sql视图相关表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SqlViewId_TabAliases
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewRelaTabEN == null) return true;
if (objSqlViewRelaTabEN.RelaTabId == null || objSqlViewRelaTabEN.RelaTabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
if (clsSqlViewRelaTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RelaTabId !=  '{0}'", objSqlViewRelaTabEN.RelaTabId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
if (clsSqlViewRelaTabBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SqlViewRelaTab(Sql视图相关表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SqlViewId_TabAliases
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewRelaTabEN == null) return "";
if (objSqlViewRelaTabEN.RelaTabId == null || objSqlViewRelaTabEN.RelaTabId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelaTabId !=  '{0}'", objSqlViewRelaTabEN.RelaTabId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SqlViewRelaTab
{
public virtual bool UpdRelaTabDate(string strRelaTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// Sql视图相关表(SqlViewRelaTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewRelaTabBL
{
public static RelatedActions_SqlViewRelaTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSqlViewRelaTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSqlViewRelaTabDA SqlViewRelaTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSqlViewRelaTabDA();
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
 public clsSqlViewRelaTabBL()
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
if (string.IsNullOrEmpty(clsSqlViewRelaTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlViewRelaTabEN._ConnectString);
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
public static DataTable GetDataTable_SqlViewRelaTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SqlViewRelaTabDA.GetDataTable_SqlViewRelaTab(strWhereCond);
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
objDT = SqlViewRelaTabDA.GetDataTable(strWhereCond);
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
objDT = SqlViewRelaTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SqlViewRelaTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SqlViewRelaTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SqlViewRelaTabDA.GetDataTable_Top(objTopPara);
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
objDT = SqlViewRelaTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SqlViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SqlViewRelaTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRelaTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstByRelaTabIdLst(List<string> arrRelaTabIdLst)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRelaTabIdLst, true);
 string strWhereCond = string.Format("RelaTabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRelaTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSqlViewRelaTabEN> GetObjLstByRelaTabIdLstCache(List<string> arrRelaTabIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLst_Sel =
arrSqlViewRelaTabObjLstCache
.Where(x => arrRelaTabIdLst.Contains(x.RelaTabId));
return arrSqlViewRelaTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLst(string strWhereCond)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
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
public static List<clsSqlViewRelaTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSqlViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSqlViewRelaTabEN> GetSubObjLstCache(clsSqlViewRelaTabEN objSqlViewRelaTabCond)
{
 string strPrjId = objSqlViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSqlViewRelaTabBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSqlViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlViewRelaTab._AttributeName)
{
if (objSqlViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewRelaTabCond[strFldName].ToString());
}
else
{
if (objSqlViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewRelaTabCond[strFldName]));
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
public static List<clsSqlViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
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
public static List<clsSqlViewRelaTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
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
List<clsSqlViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSqlViewRelaTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSqlViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
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
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
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
public static List<clsSqlViewRelaTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSqlViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
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
public static List<clsSqlViewRelaTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSqlViewRelaTabEN.RelaTabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSqlViewRelaTab(ref clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
bool bolResult = SqlViewRelaTabDA.GetSqlViewRelaTab(ref objSqlViewRelaTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
if (strRelaTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRelaTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRelaTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRelaTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSqlViewRelaTabEN objSqlViewRelaTabEN = SqlViewRelaTabDA.GetObjByRelaTabId(strRelaTabId);
return objSqlViewRelaTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSqlViewRelaTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = SqlViewRelaTabDA.GetFirstObj(strWhereCond);
 return objSqlViewRelaTabEN;
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
public static clsSqlViewRelaTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = SqlViewRelaTabDA.GetObjByDataRow(objRow);
 return objSqlViewRelaTabEN;
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
public static clsSqlViewRelaTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = SqlViewRelaTabDA.GetObjByDataRow(objRow);
 return objSqlViewRelaTabEN;
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
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <param name = "lstSqlViewRelaTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewRelaTabEN GetObjByRelaTabIdFromList(string strRelaTabId, List<clsSqlViewRelaTabEN> lstSqlViewRelaTabObjLst)
{
foreach (clsSqlViewRelaTabEN objSqlViewRelaTabEN in lstSqlViewRelaTabObjLst)
{
if (objSqlViewRelaTabEN.RelaTabId == strRelaTabId)
{
return objSqlViewRelaTabEN;
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
 string strMaxRelaTabId;
 try
 {
 strMaxRelaTabId = clsSqlViewRelaTabDA.GetMaxStrId();
 return strMaxRelaTabId;
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
 string strRelaTabId;
 try
 {
 strRelaTabId = new clsSqlViewRelaTabDA().GetFirstID(strWhereCond);
 return strRelaTabId;
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
 arrList = SqlViewRelaTabDA.GetID(strWhereCond);
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
bool bolIsExist = SqlViewRelaTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRelaTabId)
{
if (string.IsNullOrEmpty(strRelaTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRelaTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SqlViewRelaTabDA.IsExist(strRelaTabId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRelaTabId">相关表Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRelaTabId, string strOpUser)
{
clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabBL.GetObjByRelaTabId(strRelaTabId);
objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSqlViewRelaTabEN.UpdUserId = strOpUser;
return clsSqlViewRelaTabBL.UpdateBySql2(objSqlViewRelaTabEN);
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
 bolIsExist = clsSqlViewRelaTabDA.IsExistTable();
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
 bolIsExist = SqlViewRelaTabDA.IsExistTable(strTabName);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewRelaTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Sql视图Id = [{0}],表别名 = [{1}]的数据已经存在!(in clsSqlViewRelaTabBL.AddNewRecordBySql2)", objSqlViewRelaTabEN.SqlViewId,objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
bool bolResult = SqlViewRelaTabDA.AddNewRecordBySQL2(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSqlViewRelaTabEN objSqlViewRelaTabEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSqlViewRelaTabEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!Sql视图Id = [{0}],表别名 = [{1}]的数据已经存在!(in clsSqlViewRelaTabBL.AddNewRecordBySql2WithReturnKey)", objSqlViewRelaTabEN.SqlViewId,objSqlViewRelaTabEN.TabAliases);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true || clsSqlViewRelaTabBL.IsExist(objSqlViewRelaTabEN.RelaTabId) == true)
 {
     objSqlViewRelaTabEN.RelaTabId = clsSqlViewRelaTabBL.GetMaxStrId_S();
 }
string strKey = SqlViewRelaTabDA.AddNewRecordBySQL2WithReturnKey(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
bool bolResult = SqlViewRelaTabDA.Update(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 if (string.IsNullOrEmpty(objSqlViewRelaTabEN.RelaTabId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SqlViewRelaTabDA.UpdateBySql2(objSqlViewRelaTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSqlViewRelaTabBL.ReFreshCache(objSqlViewRelaTabEN.PrjId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
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
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRelaTabId)
{
try
{
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabBL.GetObjByRelaTabId(strRelaTabId);

if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(objSqlViewRelaTabEN.RelaTabId, objSqlViewRelaTabEN.UpdUserId);
}
if (objSqlViewRelaTabEN != null)
{
int intRecNum = SqlViewRelaTabDA.DelRecord(strRelaTabId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
/// <param name="strRelaTabId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strRelaTabId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
//删除与表:[SqlViewRelaTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSqlViewRelaTab.RelaTabId,
//strRelaTabId);
//        clsSqlViewRelaTabBL.DelSqlViewRelaTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewRelaTabBL.DelRecord(strRelaTabId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewRelaTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRelaTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRelaTabId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSqlViewRelaTabBL.relatedActions != null)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(strRelaTabId, "UpdRelaTabDate");
}
bool bolResult = SqlViewRelaTabDA.DelRecord(strRelaTabId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRelaTabIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSqlViewRelaTabs(List<string> arrRelaTabIdLst)
{
if (arrRelaTabIdLst.Count == 0) return 0;
try
{
if (clsSqlViewRelaTabBL.relatedActions != null)
{
foreach (var strRelaTabId in arrRelaTabIdLst)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(strRelaTabId, "UpdRelaTabDate");
}
}
 clsSqlViewRelaTabEN objSqlViewRelaTabEN = clsSqlViewRelaTabBL.GetObjByRelaTabId(arrRelaTabIdLst[0]);
int intDelRecNum = SqlViewRelaTabDA.DelSqlViewRelaTab(arrRelaTabIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSqlViewRelaTabEN.PrjId);
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
public static int DelSqlViewRelaTabsByCond(string strWhereCond)
{
try
{
if (clsSqlViewRelaTabBL.relatedActions != null)
{
List<string> arrRelaTabId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRelaTabId in arrRelaTabId)
{
clsSqlViewRelaTabBL.relatedActions.UpdRelaTabDate(strRelaTabId, "UpdRelaTabDate");
}
}
List<string> arrPrjId = GetFldValue(conSqlViewRelaTab.PrjId, strWhereCond);
int intRecNum = SqlViewRelaTabDA.DelSqlViewRelaTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SqlViewRelaTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRelaTabId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRelaTabId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
//删除与表:[SqlViewRelaTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSqlViewRelaTabBL.DelRecord(strRelaTabId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSqlViewRelaTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRelaTabId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSqlViewRelaTabENS">源对象</param>
 /// <param name = "objSqlViewRelaTabENT">目标对象</param>
 public static void CopyTo(clsSqlViewRelaTabEN objSqlViewRelaTabENS, clsSqlViewRelaTabEN objSqlViewRelaTabENT)
{
try
{
objSqlViewRelaTabENT.RelaTabId = objSqlViewRelaTabENS.RelaTabId; //相关表Id
objSqlViewRelaTabENT.SqlViewId = objSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objSqlViewRelaTabENT.TabId = objSqlViewRelaTabENS.TabId; //表ID
objSqlViewRelaTabENT.TabAliases = objSqlViewRelaTabENS.TabAliases; //表别名
objSqlViewRelaTabENT.RelaFldId = objSqlViewRelaTabENS.RelaFldId; //关系字段
objSqlViewRelaTabENT.OtherFldId = objSqlViewRelaTabENS.OtherFldId; //其他表字段
objSqlViewRelaTabENT.OtherTabId = objSqlViewRelaTabENS.OtherTabId; //其他表Id
objSqlViewRelaTabENT.SvRelaTabTypeId = objSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSqlViewRelaTabENT.TabRelationTypeId = objSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objSqlViewRelaTabENT.TabRelationText = objSqlViewRelaTabENS.TabRelationText; //表关系文本
objSqlViewRelaTabENT.OrderNum = objSqlViewRelaTabENS.OrderNum; //序号
objSqlViewRelaTabENT.PrjId = objSqlViewRelaTabENS.PrjId; //工程Id
objSqlViewRelaTabENT.UpdDate = objSqlViewRelaTabENS.UpdDate; //修改日期
objSqlViewRelaTabENT.UpdUserId = objSqlViewRelaTabENS.UpdUserId; //修改用户Id
objSqlViewRelaTabENT.Memo = objSqlViewRelaTabENS.Memo; //说明
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
 /// <param name = "objSqlViewRelaTabEN">源简化对象</param>
 public static void SetUpdFlag(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
objSqlViewRelaTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSqlViewRelaTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSqlViewRelaTab.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.RelaTabId = objSqlViewRelaTabEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.SqlViewId = objSqlViewRelaTabEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.TabId = objSqlViewRelaTabEN.TabId; //表ID
}
if (arrFldSet.Contains(conSqlViewRelaTab.TabAliases, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.TabAliases = objSqlViewRelaTabEN.TabAliases; //表别名
}
if (arrFldSet.Contains(conSqlViewRelaTab.RelaFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.RelaFldId = objSqlViewRelaTabEN.RelaFldId == "[null]" ? null :  objSqlViewRelaTabEN.RelaFldId; //关系字段
}
if (arrFldSet.Contains(conSqlViewRelaTab.OtherFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.OtherFldId = objSqlViewRelaTabEN.OtherFldId == "[null]" ? null :  objSqlViewRelaTabEN.OtherFldId; //其他表字段
}
if (arrFldSet.Contains(conSqlViewRelaTab.OtherTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.OtherTabId = objSqlViewRelaTabEN.OtherTabId == "[null]" ? null :  objSqlViewRelaTabEN.OtherTabId; //其他表Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.SvRelaTabTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.SvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId; //Sql视图相关表类型Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.TabRelationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.TabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId; //表关系类型Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.TabRelationText, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.TabRelationText = objSqlViewRelaTabEN.TabRelationText == "[null]" ? null :  objSqlViewRelaTabEN.TabRelationText; //表关系文本
}
if (arrFldSet.Contains(conSqlViewRelaTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.OrderNum = objSqlViewRelaTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conSqlViewRelaTab.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.PrjId = objSqlViewRelaTabEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.UpdDate = objSqlViewRelaTabEN.UpdDate == "[null]" ? null :  objSqlViewRelaTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSqlViewRelaTab.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.UpdUserId = objSqlViewRelaTabEN.UpdUserId == "[null]" ? null :  objSqlViewRelaTabEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSqlViewRelaTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSqlViewRelaTabEN.Memo = objSqlViewRelaTabEN.Memo == "[null]" ? null :  objSqlViewRelaTabEN.Memo; //说明
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
 /// <param name = "objSqlViewRelaTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
try
{
if (objSqlViewRelaTabEN.RelaFldId == "[null]") objSqlViewRelaTabEN.RelaFldId = null; //关系字段
if (objSqlViewRelaTabEN.OtherFldId == "[null]") objSqlViewRelaTabEN.OtherFldId = null; //其他表字段
if (objSqlViewRelaTabEN.OtherTabId == "[null]") objSqlViewRelaTabEN.OtherTabId = null; //其他表Id
if (objSqlViewRelaTabEN.TabRelationText == "[null]") objSqlViewRelaTabEN.TabRelationText = null; //表关系文本
if (objSqlViewRelaTabEN.UpdDate == "[null]") objSqlViewRelaTabEN.UpdDate = null; //修改日期
if (objSqlViewRelaTabEN.UpdUserId == "[null]") objSqlViewRelaTabEN.UpdUserId = null; //修改用户Id
if (objSqlViewRelaTabEN.Memo == "[null]") objSqlViewRelaTabEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 SqlViewRelaTabDA.CheckPropertyNew(objSqlViewRelaTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 SqlViewRelaTabDA.CheckProperty4Condition(objSqlViewRelaTabEN);
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
if (clsSqlViewRelaTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewRelaTabBL没有刷新缓存机制(clsSqlViewRelaTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelaTabId");
//if (arrSqlViewRelaTabObjLstCache == null)
//{
//arrSqlViewRelaTabObjLstCache = SqlViewRelaTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRelaTabId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSqlViewRelaTabEN GetObjByRelaTabIdCache(string strRelaTabId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLst_Sel =
arrSqlViewRelaTabObjLstCache
.Where(x=> x.RelaTabId == strRelaTabId 
);
if (arrSqlViewRelaTabObjLst_Sel.Count() == 0)
{
   clsSqlViewRelaTabEN obj = clsSqlViewRelaTabBL.GetObjByRelaTabId(strRelaTabId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strRelaTabId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSqlViewRelaTabObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetAllSqlViewRelaTabObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = GetObjLstCache(strPrjId); 
return arrSqlViewRelaTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSqlViewRelaTabEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsSqlViewRelaTabEN> arrSqlViewRelaTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSqlViewRelaTabObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSqlViewRelaTabEN._RefreshTimeLst.Count == 0) return "";
return clsSqlViewRelaTabEN._RefreshTimeLst[clsSqlViewRelaTabEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewRelaTabBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewRelaTabBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsSqlViewRelaTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewRelaTabEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewRelaTabEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSqlViewRelaTabBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SqlViewRelaTab(Sql视图相关表)
 /// 唯一性条件:SqlViewId_TabAliases
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检测记录是否存在
string strResult = SqlViewRelaTabDA.GetUniCondStr(objSqlViewRelaTabEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRelaTabId, string strPrjId)
{
if (strInFldName != conSqlViewRelaTab.RelaTabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSqlViewRelaTab._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSqlViewRelaTab._AttributeName));
throw new Exception(strMsg);
}
var objSqlViewRelaTab = clsSqlViewRelaTabBL.GetObjByRelaTabIdCache(strRelaTabId, strPrjId);
if (objSqlViewRelaTab == null) return "";
return objSqlViewRelaTab[strOutFldName].ToString();
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
int intRecCount = clsSqlViewRelaTabDA.GetRecCount(strTabName);
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
int intRecCount = clsSqlViewRelaTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSqlViewRelaTabDA.GetRecCount();
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
int intRecCount = clsSqlViewRelaTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSqlViewRelaTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSqlViewRelaTabEN objSqlViewRelaTabCond)
{
 string strPrjId = objSqlViewRelaTabCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSqlViewRelaTabBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSqlViewRelaTabEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsSqlViewRelaTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSqlViewRelaTab._AttributeName)
{
if (objSqlViewRelaTabCond.IsUpdated(strFldName) == false) continue;
if (objSqlViewRelaTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewRelaTabCond[strFldName].ToString());
}
else
{
if (objSqlViewRelaTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSqlViewRelaTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSqlViewRelaTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSqlViewRelaTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSqlViewRelaTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSqlViewRelaTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSqlViewRelaTabCond[strFldName]));
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
 List<string> arrList = clsSqlViewRelaTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SqlViewRelaTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SqlViewRelaTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SqlViewRelaTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewRelaTabDA.SetFldValue(clsSqlViewRelaTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SqlViewRelaTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewRelaTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSqlViewRelaTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSqlViewRelaTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SqlViewRelaTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**相关表Id*/ 
 strCreateTabCode.Append(" RelaTabId char(8) primary key, "); 
 // /**Sql视图Id*/ 
 strCreateTabCode.Append(" SqlViewId char(8) not Null, "); 
 // /**表ID*/ 
 strCreateTabCode.Append(" TabId char(8) not Null, "); 
 // /**表别名*/ 
 strCreateTabCode.Append(" TabAliases varchar(100) not Null, "); 
 // /**关系字段*/ 
 strCreateTabCode.Append(" RelaFldId char(8) Null, "); 
 // /**其他表字段*/ 
 strCreateTabCode.Append(" OtherFldId char(8) Null, "); 
 // /**其他表Id*/ 
 strCreateTabCode.Append(" OtherTabId char(8) Null, "); 
 // /**Sql视图相关表类型Id*/ 
 strCreateTabCode.Append(" SvRelaTabTypeId char(2) not Null, "); 
 // /**表关系类型Id*/ 
 strCreateTabCode.Append(" TabRelationTypeId char(2) not Null, "); 
 // /**表关系文本*/ 
 strCreateTabCode.Append(" TabRelationText varchar(500) Null, "); 
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
 /// Sql视图相关表(SqlViewRelaTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SqlViewRelaTab : clsCommFun4BLV2
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
clsSqlViewRelaTabBL.ReFreshThisCache(strPrjId);
}
}

}